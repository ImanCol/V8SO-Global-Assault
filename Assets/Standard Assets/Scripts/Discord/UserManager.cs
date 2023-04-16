using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000032 RID: 50
	public class UserManager
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004570 File Offset: 0x00002770
		private UserManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(UserManager.FFIMethods));
				}
				return (UserManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000066 RID: 102 RVA: 0x000045A0 File Offset: 0x000027A0
		// (remove) Token: 0x06000067 RID: 103 RVA: 0x000045D8 File Offset: 0x000027D8
		public event UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate;

		// Token: 0x06000068 RID: 104 RVA: 0x00004610 File Offset: 0x00002810
		internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref UserManager.FFIEvents events)
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

		// Token: 0x06000069 RID: 105 RVA: 0x0000465F File Offset: 0x0000285F
		private void InitEvents(IntPtr eventsPtr, ref UserManager.FFIEvents events)
		{
			events.OnCurrentUserUpdate = new UserManager.FFIEvents.CurrentUserUpdateHandler(UserManager.OnCurrentUserUpdateImpl);
			Marshal.StructureToPtr<UserManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004680 File Offset: 0x00002880
		public User GetCurrentUser()
		{
			User user = default(User);
			Result result = this.Methods.GetCurrentUser(this.MethodsPtr, ref user);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return user;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000046BC File Offset: 0x000028BC
		[MonoPInvokeCallback]
		private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			UserManager.GetUserHandler getUserHandler = (UserManager.GetUserHandler)gchandle.Target;
			gchandle.Free();
			getUserHandler(result, ref user);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000046EC File Offset: 0x000028EC
		public void GetUser(long userId, UserManager.GetUserHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.GetUser(this.MethodsPtr, userId, GCHandle.ToIntPtr(gchandle), new UserManager.FFIMethods.GetUserCallback(UserManager.GetUserCallbackImpl));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000472C File Offset: 0x0000292C
		public PremiumType GetCurrentUserPremiumType()
		{
			PremiumType premiumType = PremiumType.None;
			Result result = this.Methods.GetCurrentUserPremiumType(this.MethodsPtr, ref premiumType);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return premiumType;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004760 File Offset: 0x00002960
		public bool CurrentUserHasFlag(UserFlag flag)
		{
			bool flag2 = false;
			Result result = this.Methods.CurrentUserHasFlag(this.MethodsPtr, flag, ref flag2);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag2;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004794 File Offset: 0x00002994
		[MonoPInvokeCallback]
		private static void OnCurrentUserUpdateImpl(IntPtr ptr)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.UserManagerInstance.OnCurrentUserUpdate != null)
			{
				discord.UserManagerInstance.OnCurrentUserUpdate();
			}
		}

		// Token: 0x04000118 RID: 280
		private IntPtr MethodsPtr;

		// Token: 0x04000119 RID: 281
		private object MethodsStructure;

		// Token: 0x02000058 RID: 88
		internal struct FFIEvents
		{
			// Token: 0x04000196 RID: 406
			internal UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate;

			// Token: 0x020000CD RID: 205
			// (Invoke) Token: 0x060002F3 RID: 755
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CurrentUserUpdateHandler(IntPtr ptr);
		}

		// Token: 0x02000059 RID: 89
		internal struct FFIMethods
		{
			// Token: 0x04000197 RID: 407
			internal UserManager.FFIMethods.GetCurrentUserMethod GetCurrentUser;

			// Token: 0x04000198 RID: 408
			internal UserManager.FFIMethods.GetUserMethod GetUser;

			// Token: 0x04000199 RID: 409
			internal UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType;

			// Token: 0x0400019A RID: 410
			internal UserManager.FFIMethods.CurrentUserHasFlagMethod CurrentUserHasFlag;

			// Token: 0x020000CE RID: 206
			// (Invoke) Token: 0x060002F7 RID: 759
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetCurrentUserMethod(IntPtr methodsPtr, ref User currentUser);

			// Token: 0x020000CF RID: 207
			// (Invoke) Token: 0x060002FB RID: 763
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetUserCallback(IntPtr ptr, Result result, ref User user);

			// Token: 0x020000D0 RID: 208
			// (Invoke) Token: 0x060002FF RID: 767
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetUserMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback);

			// Token: 0x020000D1 RID: 209
			// (Invoke) Token: 0x06000303 RID: 771
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetCurrentUserPremiumTypeMethod(IntPtr methodsPtr, ref PremiumType premiumType);

			// Token: 0x020000D2 RID: 210
			// (Invoke) Token: 0x06000307 RID: 775
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CurrentUserHasFlagMethod(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag);
		}

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600016F RID: 367
		public delegate void GetUserHandler(Result result, ref User user);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000173 RID: 371
		public delegate void CurrentUserUpdateHandler();
	}
}
