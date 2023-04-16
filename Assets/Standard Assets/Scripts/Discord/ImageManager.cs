using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Discord
{
	// Token: 0x02000033 RID: 51
	public class ImageManager
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000047D2 File Offset: 0x000029D2
		private ImageManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(ImageManager.FFIMethods));
				}
				return (ImageManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004804 File Offset: 0x00002A04
		internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref ImageManager.FFIEvents events)
		{
			if (eventsPtr == IntPtr.Zero)
			{
				throw new ResultException(Result.InternalError);
			}
			this.InitEvents(eventsPtr, ref events);
			this.MethodsPtr = ptr;
			if (this.MethodsPtr == IntPtr.Zero)
			{
				throw new ResultException(Result.InternalError);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004853 File Offset: 0x00002A53
		private void InitEvents(IntPtr eventsPtr, ref ImageManager.FFIEvents events)
		{
			Marshal.StructureToPtr<ImageManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004864 File Offset: 0x00002A64
		[MonoPInvokeCallback]
		private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ImageManager.FetchHandler fetchHandler = (ImageManager.FetchHandler)gchandle.Target;
			gchandle.Free();
			fetchHandler(result, handleResult);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004894 File Offset: 0x00002A94
		public void Fetch(ImageHandle handle, bool refresh, ImageManager.FetchHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.Fetch(this.MethodsPtr, handle, refresh, GCHandle.ToIntPtr(gchandle), new ImageManager.FFIMethods.FetchCallback(ImageManager.FetchCallbackImpl));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000048D4 File Offset: 0x00002AD4
		public ImageDimensions GetDimensions(ImageHandle handle)
		{
			ImageDimensions imageDimensions = default(ImageDimensions);
			Result result = this.Methods.GetDimensions(this.MethodsPtr, handle, ref imageDimensions);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return imageDimensions;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004910 File Offset: 0x00002B10
		public void GetData(ImageHandle handle, byte[] data)
		{
			Result result = this.Methods.GetData(this.MethodsPtr, handle, data, data.Length);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004943 File Offset: 0x00002B43
		public void Fetch(ImageHandle handle, ImageManager.FetchHandler callback)
		{
			this.Fetch(handle, false, callback);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004950 File Offset: 0x00002B50
		public byte[] GetData(ImageHandle handle)
		{
			ImageDimensions dimensions = this.GetDimensions(handle);
			byte[] array = new byte[dimensions.Width * dimensions.Height * 4U];
			this.GetData(handle, array);
			return array;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004984 File Offset: 0x00002B84
		public Texture2D GetTexture(ImageHandle handle)
		{
			ImageDimensions dimensions = this.GetDimensions(handle);
			Texture2D texture2D = new Texture2D((int)dimensions.Width, (int)dimensions.Height, TextureFormat.RGBA32, false, true);
			texture2D.LoadRawTextureData(this.GetData(handle));
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x0400011B RID: 283
		private IntPtr MethodsPtr;

		// Token: 0x0400011C RID: 284
		private object MethodsStructure;

		// Token: 0x0200005C RID: 92
		internal struct FFIEvents
		{
		}

		// Token: 0x0200005D RID: 93
		internal struct FFIMethods
		{
			// Token: 0x0400019B RID: 411
			internal ImageManager.FFIMethods.FetchMethod Fetch;

			// Token: 0x0400019C RID: 412
			internal ImageManager.FFIMethods.GetDimensionsMethod GetDimensions;

			// Token: 0x0400019D RID: 413
			internal ImageManager.FFIMethods.GetDataMethod GetData;

			// Token: 0x020000D3 RID: 211
			// (Invoke) Token: 0x0600030B RID: 779
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchCallback(IntPtr ptr, Result result, ImageHandle handleResult);

			// Token: 0x020000D4 RID: 212
			// (Invoke) Token: 0x0600030F RID: 783
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchMethod(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback);

			// Token: 0x020000D5 RID: 213
			// (Invoke) Token: 0x06000313 RID: 787
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetDimensionsMethod(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions);

			// Token: 0x020000D6 RID: 214
			// (Invoke) Token: 0x06000317 RID: 791
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetDataMethod(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen);
		}

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000177 RID: 375
		public delegate void FetchHandler(Result result, ImageHandle handleResult);
	}
}
