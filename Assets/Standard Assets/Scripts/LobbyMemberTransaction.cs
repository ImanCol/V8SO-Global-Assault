using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200002C RID: 44
	public struct LobbyMemberTransaction
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003905 File Offset: 0x00001B05
		private LobbyMemberTransaction.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(LobbyMemberTransaction.FFIMethods));
				}
				return (LobbyMemberTransaction.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003938 File Offset: 0x00001B38
		public void SetMetadata(string key, string value)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.SetMetadata(this.MethodsPtr, key, value);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000397C File Offset: 0x00001B7C
		public void DeleteMetadata(string key)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.DeleteMetadata(this.MethodsPtr, key);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x040000E7 RID: 231
		internal IntPtr MethodsPtr;

		// Token: 0x040000E8 RID: 232
		internal object MethodsStructure;

		// Token: 0x0200004D RID: 77
		internal struct FFIMethods
		{
			// Token: 0x04000160 RID: 352
			internal LobbyMemberTransaction.FFIMethods.SetMetadataMethod SetMetadata;

			// Token: 0x04000161 RID: 353
			internal LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata;

			// Token: 0x020000AF RID: 175
			// (Invoke) Token: 0x0600027B RID: 635
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

			// Token: 0x020000B0 RID: 176
			// (Invoke) Token: 0x0600027F RID: 639
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key);
		}
	}
}
