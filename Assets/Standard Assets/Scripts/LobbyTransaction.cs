using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200002B RID: 43
	public struct LobbyTransaction
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000373E File Offset: 0x0000193E
		private LobbyTransaction.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(LobbyTransaction.FFIMethods));
				}
				return (LobbyTransaction.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003770 File Offset: 0x00001970
		public void SetType(LobbyType type)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.SetType(this.MethodsPtr, type);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000037B4 File Offset: 0x000019B4
		public void SetOwner(long ownerId)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.SetOwner(this.MethodsPtr, ownerId);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000037F8 File Offset: 0x000019F8
		public void SetCapacity(uint capacity)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.SetCapacity(this.MethodsPtr, capacity);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000383C File Offset: 0x00001A3C
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

		// Token: 0x0600003A RID: 58 RVA: 0x00003880 File Offset: 0x00001A80
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

		// Token: 0x0600003B RID: 59 RVA: 0x000038C4 File Offset: 0x00001AC4
		public void SetLocked(bool locked)
		{
			if (this.MethodsPtr != IntPtr.Zero)
			{
				Result result = this.Methods.SetLocked(this.MethodsPtr, locked);
				if (result != Result.Ok)
				{
					throw new ResultException(result);
				}
			}
		}

		// Token: 0x040000E5 RID: 229
		internal IntPtr MethodsPtr;

		// Token: 0x040000E6 RID: 230
		internal object MethodsStructure;

		// Token: 0x0200004C RID: 76
		internal struct FFIMethods
		{
			// Token: 0x0400015A RID: 346
			internal LobbyTransaction.FFIMethods.SetTypeMethod SetType;

			// Token: 0x0400015B RID: 347
			internal LobbyTransaction.FFIMethods.SetOwnerMethod SetOwner;

			// Token: 0x0400015C RID: 348
			internal LobbyTransaction.FFIMethods.SetCapacityMethod SetCapacity;

			// Token: 0x0400015D RID: 349
			internal LobbyTransaction.FFIMethods.SetMetadataMethod SetMetadata;

			// Token: 0x0400015E RID: 350
			internal LobbyTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata;

			// Token: 0x0400015F RID: 351
			internal LobbyTransaction.FFIMethods.SetLockedMethod SetLocked;

			// Token: 0x020000A9 RID: 169
			// (Invoke) Token: 0x06000263 RID: 611
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetTypeMethod(IntPtr methodsPtr, LobbyType type);

			// Token: 0x020000AA RID: 170
			// (Invoke) Token: 0x06000267 RID: 615
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetOwnerMethod(IntPtr methodsPtr, long ownerId);

			// Token: 0x020000AB RID: 171
			// (Invoke) Token: 0x0600026B RID: 619
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetCapacityMethod(IntPtr methodsPtr, uint capacity);

			// Token: 0x020000AC RID: 172
			// (Invoke) Token: 0x0600026F RID: 623
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);

			// Token: 0x020000AD RID: 173
			// (Invoke) Token: 0x06000273 RID: 627
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string key);

			// Token: 0x020000AE RID: 174
			// (Invoke) Token: 0x06000277 RID: 631
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLockedMethod(IntPtr methodsPtr, bool locked);
		}
	}
}
