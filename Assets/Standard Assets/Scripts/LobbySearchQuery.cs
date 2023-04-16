using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200002D RID: 45
	public struct LobbySearchQuery
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000039BD File Offset: 0x00001BBD
		private LobbySearchQuery.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(LobbySearchQuery.FFIMethods));
				}
				return (LobbySearchQuery.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000039F0 File Offset: 0x00001BF0
		public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.Filter(this.MethodsPtr, key, comparison, cast, value);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003A38 File Offset: 0x00001C38
		public void Sort(string key, LobbySearchCast cast, string value)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.Sort(this.MethodsPtr, key, cast, value);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003A7C File Offset: 0x00001C7C
		public void Limit(uint limit)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.Limit(this.MethodsPtr, limit);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public void Distance(LobbySearchDistance distance)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.Distance(this.MethodsPtr, distance);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x040000E9 RID: 233
		internal IntPtr MethodsPtr;

		// Token: 0x040000EA RID: 234
		internal object MethodsStructure;

		// Token: 0x0200004E RID: 78
		internal struct FFIMethods
		{
			// Token: 0x04000162 RID: 354
			internal LobbySearchQuery.FFIMethods.FilterMethod Filter;

			// Token: 0x04000163 RID: 355
			internal LobbySearchQuery.FFIMethods.SortMethod Sort;

			// Token: 0x04000164 RID: 356
			internal LobbySearchQuery.FFIMethods.LimitMethod Limit;

			// Token: 0x04000165 RID: 357
			internal LobbySearchQuery.FFIMethods.DistanceMethod Distance;

			// Token: 0x020000B1 RID: 177
			// (Invoke) Token: 0x06000283 RID: 643
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FilterMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key, LobbySearchComparison comparison, LobbySearchCast cast, [MarshalAs(UnmanagedType.LPStr)] string value);

			// Token: 0x020000B2 RID: 178
			// (Invoke) Token: 0x06000287 RID: 647
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SortMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key, LobbySearchCast cast, [MarshalAs(UnmanagedType.LPStr)] string value);

			// Token: 0x020000B3 RID: 179
			// (Invoke) Token: 0x0600028B RID: 651
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result LimitMethod(IntPtr methodsPtr, uint limit);

			// Token: 0x020000B4 RID: 180
			// (Invoke) Token: 0x0600028F RID: 655
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DistanceMethod(IntPtr methodsPtr, LobbySearchDistance distance);
		}
	}
}
