using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Discord
{
	// Token: 0x02000038 RID: 56
	public class StorageManager
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000653B File Offset: 0x0000473B
		private StorageManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(StorageManager.FFIMethods));
				}
				return (StorageManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000656C File Offset: 0x0000476C
		internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref StorageManager.FFIEvents events)
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

		// Token: 0x060000F4 RID: 244 RVA: 0x000065BB File Offset: 0x000047BB
		private void InitEvents(IntPtr eventsPtr, ref StorageManager.FFIEvents events)
		{
			Marshal.StructureToPtr<StorageManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000065CC File Offset: 0x000047CC
		public uint Read(string name, byte[] data)
		{
			uint num = 0U;
			Result result = this.Methods.Read(this.MethodsPtr, name, data, data.Length, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006604 File Offset: 0x00004804
		[MonoPInvokeCallback]
		private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StorageManager.ReadAsyncHandler readAsyncHandler = (StorageManager.ReadAsyncHandler)gchandle.Target;
			gchandle.Free();
			byte[] array = new byte[dataLen];
			Marshal.Copy(dataPtr, array, 0, dataLen);
			readAsyncHandler(result, array);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006644 File Offset: 0x00004844
		public void ReadAsync(string name, StorageManager.ReadAsyncHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ReadAsync(this.MethodsPtr, name, GCHandle.ToIntPtr(gchandle), new StorageManager.FFIMethods.ReadAsyncCallback(StorageManager.ReadAsyncCallbackImpl));
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006684 File Offset: 0x00004884
		[MonoPInvokeCallback]
		private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StorageManager.ReadAsyncPartialHandler readAsyncPartialHandler = (StorageManager.ReadAsyncPartialHandler)gchandle.Target;
			gchandle.Free();
			byte[] array = new byte[dataLen];
			Marshal.Copy(dataPtr, array, 0, dataLen);
			readAsyncPartialHandler(result, array);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000066C4 File Offset: 0x000048C4
		public void ReadAsyncPartial(string name, ulong offset, ulong length, StorageManager.ReadAsyncPartialHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ReadAsyncPartial(this.MethodsPtr, name, offset, length, GCHandle.ToIntPtr(gchandle), new StorageManager.FFIMethods.ReadAsyncPartialCallback(StorageManager.ReadAsyncPartialCallbackImpl));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006704 File Offset: 0x00004904
		public void Write(string name, byte[] data)
		{
			Result result = this.Methods.Write(this.MethodsPtr, name, data, data.Length);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006738 File Offset: 0x00004938
		[MonoPInvokeCallback]
		private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StorageManager.WriteAsyncHandler writeAsyncHandler = (StorageManager.WriteAsyncHandler)gchandle.Target;
			gchandle.Free();
			writeAsyncHandler(result);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006768 File Offset: 0x00004968
		public void WriteAsync(string name, byte[] data, StorageManager.WriteAsyncHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.WriteAsync(this.MethodsPtr, name, data, data.Length, GCHandle.ToIntPtr(gchandle), new StorageManager.FFIMethods.WriteAsyncCallback(StorageManager.WriteAsyncCallbackImpl));
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000067AC File Offset: 0x000049AC
		public void Delete(string name)
		{
			Result result = this.Methods.Delete(this.MethodsPtr, name);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000067DC File Offset: 0x000049DC
		public bool Exists(string name)
		{
			bool flag = false;
			Result result = this.Methods.Exists(this.MethodsPtr, name, ref flag);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006810 File Offset: 0x00004A10
		public int Count()
		{
			int num = 0;
			this.Methods.Count(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006838 File Offset: 0x00004A38
		public FileStat Stat(string name)
		{
			FileStat fileStat = default(FileStat);
			Result result = this.Methods.Stat(this.MethodsPtr, name, ref fileStat);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return fileStat;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006874 File Offset: 0x00004A74
		public FileStat StatAt(int index)
		{
			FileStat fileStat = default(FileStat);
			Result result = this.Methods.StatAt(this.MethodsPtr, index, ref fileStat);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return fileStat;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000068B0 File Offset: 0x00004AB0
		public string GetPath()
		{
			StringBuilder stringBuilder = new StringBuilder(4096);
			Result result = this.Methods.GetPath(this.MethodsPtr, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000068F0 File Offset: 0x00004AF0
		public IEnumerable<FileStat> Files()
		{
			int num = this.Count();
			List<FileStat> list = new List<FileStat>();
			for (int i = 0; i < num; i++)
			{
				list.Add(this.StatAt(i));
			}
			return list;
		}

		// Token: 0x04000132 RID: 306
		private IntPtr MethodsPtr;

		// Token: 0x04000133 RID: 307
		private object MethodsStructure;

		// Token: 0x02000084 RID: 132
		internal struct FFIEvents
		{
		}

		// Token: 0x02000085 RID: 133
		internal struct FFIMethods
		{
			// Token: 0x040001DE RID: 478
			internal StorageManager.FFIMethods.ReadMethod Read;

			// Token: 0x040001DF RID: 479
			internal StorageManager.FFIMethods.ReadAsyncMethod ReadAsync;

			// Token: 0x040001E0 RID: 480
			internal StorageManager.FFIMethods.ReadAsyncPartialMethod ReadAsyncPartial;

			// Token: 0x040001E1 RID: 481
			internal StorageManager.FFIMethods.WriteMethod Write;

			// Token: 0x040001E2 RID: 482
			internal StorageManager.FFIMethods.WriteAsyncMethod WriteAsync;

			// Token: 0x040001E3 RID: 483
			internal StorageManager.FFIMethods.DeleteMethod Delete;

			// Token: 0x040001E4 RID: 484
			internal StorageManager.FFIMethods.ExistsMethod Exists;

			// Token: 0x040001E5 RID: 485
			internal StorageManager.FFIMethods.CountMethod Count;

			// Token: 0x040001E6 RID: 486
			internal StorageManager.FFIMethods.StatMethod Stat;

			// Token: 0x040001E7 RID: 487
			internal StorageManager.FFIMethods.StatAtMethod StatAt;

			// Token: 0x040001E8 RID: 488
			internal StorageManager.FFIMethods.GetPathMethod GetPath;

			// Token: 0x02000127 RID: 295
			// (Invoke) Token: 0x0600045B RID: 1115
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ReadMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, byte[] data, int dataLen, ref uint read);

			// Token: 0x02000128 RID: 296
			// (Invoke) Token: 0x0600045F RID: 1119
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			// Token: 0x02000129 RID: 297
			// (Invoke) Token: 0x06000463 RID: 1123
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback);

			// Token: 0x0200012A RID: 298
			// (Invoke) Token: 0x06000467 RID: 1127
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncPartialCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			// Token: 0x0200012B RID: 299
			// (Invoke) Token: 0x0600046B RID: 1131
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncPartialMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback);

			// Token: 0x0200012C RID: 300
			// (Invoke) Token: 0x0600046F RID: 1135
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result WriteMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, byte[] data, int dataLen);

			// Token: 0x0200012D RID: 301
			// (Invoke) Token: 0x06000473 RID: 1139
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void WriteAsyncCallback(IntPtr ptr, Result result);

			// Token: 0x0200012E RID: 302
			// (Invoke) Token: 0x06000477 RID: 1143
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void WriteAsyncMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, byte[] data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback);

			// Token: 0x0200012F RID: 303
			// (Invoke) Token: 0x0600047B RID: 1147
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name);

			// Token: 0x02000130 RID: 304
			// (Invoke) Token: 0x0600047F RID: 1151
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ExistsMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, ref bool exists);

			// Token: 0x02000131 RID: 305
			// (Invoke) Token: 0x06000483 RID: 1155
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x02000132 RID: 306
			// (Invoke) Token: 0x06000487 RID: 1159
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result StatMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string name, ref FileStat stat);

			// Token: 0x02000133 RID: 307
			// (Invoke) Token: 0x0600048B RID: 1163
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result StatAtMethod(IntPtr methodsPtr, int index, ref FileStat stat);

			// Token: 0x02000134 RID: 308
			// (Invoke) Token: 0x0600048F RID: 1167
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetPathMethod(IntPtr methodsPtr, StringBuilder path);
		}

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001EF RID: 495
		public delegate void ReadAsyncHandler(Result result, byte[] data);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001F3 RID: 499
		public delegate void ReadAsyncPartialHandler(Result result, byte[] data);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001F7 RID: 503
		public delegate void WriteAsyncHandler(Result result);
	}
}
