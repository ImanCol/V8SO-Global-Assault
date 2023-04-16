using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200003B RID: 59
	public class AchievementManager
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000071E6 File Offset: 0x000053E6
		private AchievementManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(AchievementManager.FFIMethods));
				}
				return (AchievementManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600012E RID: 302 RVA: 0x00007218 File Offset: 0x00005418
		// (remove) Token: 0x0600012F RID: 303 RVA: 0x00007250 File Offset: 0x00005450
		public event AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate;

		// Token: 0x06000130 RID: 304 RVA: 0x00007288 File Offset: 0x00005488
		internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
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

		// Token: 0x06000131 RID: 305 RVA: 0x000072D7 File Offset: 0x000054D7
		private void InitEvents(IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
		{
			events.OnUserAchievementUpdate = new AchievementManager.FFIEvents.UserAchievementUpdateHandler(AchievementManager.OnUserAchievementUpdateImpl);
			Marshal.StructureToPtr<AchievementManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000072F8 File Offset: 0x000054F8
		[MonoPInvokeCallback]
		private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			AchievementManager.SetUserAchievementHandler setUserAchievementHandler = (AchievementManager.SetUserAchievementHandler)gchandle.Target;
			gchandle.Free();
			setUserAchievementHandler(result);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007328 File Offset: 0x00005528
		public void SetUserAchievement(long achievementId, byte percentComplete, AchievementManager.SetUserAchievementHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SetUserAchievement(this.MethodsPtr, achievementId, percentComplete, GCHandle.ToIntPtr(gchandle), new AchievementManager.FFIMethods.SetUserAchievementCallback(AchievementManager.SetUserAchievementCallbackImpl));
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00007368 File Offset: 0x00005568
		[MonoPInvokeCallback]
		private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			AchievementManager.FetchUserAchievementsHandler fetchUserAchievementsHandler = (AchievementManager.FetchUserAchievementsHandler)gchandle.Target;
			gchandle.Free();
			fetchUserAchievementsHandler(result);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00007398 File Offset: 0x00005598
		public void FetchUserAchievements(AchievementManager.FetchUserAchievementsHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.FetchUserAchievements(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new AchievementManager.FFIMethods.FetchUserAchievementsCallback(AchievementManager.FetchUserAchievementsCallbackImpl));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000073D4 File Offset: 0x000055D4
		public int CountUserAchievements()
		{
			int num = 0;
			this.Methods.CountUserAchievements(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000073FC File Offset: 0x000055FC
		public UserAchievement GetUserAchievement(long userAchievementId)
		{
			UserAchievement userAchievement = default(UserAchievement);
			Result result = this.Methods.GetUserAchievement(this.MethodsPtr, userAchievementId, ref userAchievement);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return userAchievement;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007438 File Offset: 0x00005638
		public UserAchievement GetUserAchievementAt(int index)
		{
			UserAchievement userAchievement = default(UserAchievement);
			Result result = this.Methods.GetUserAchievementAt(this.MethodsPtr, index, ref userAchievement);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return userAchievement;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007474 File Offset: 0x00005674
		[MonoPInvokeCallback]
		private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.AchievementManagerInstance.OnUserAchievementUpdate != null)
			{
				discord.AchievementManagerInstance.OnUserAchievementUpdate(ref userAchievement);
			}
		}

		// Token: 0x0400013B RID: 315
		private IntPtr MethodsPtr;

		// Token: 0x0400013C RID: 316
		private object MethodsStructure;

		// Token: 0x02000094 RID: 148
		internal struct FFIEvents
		{
			// Token: 0x04000200 RID: 512
			internal AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate;

			// Token: 0x02000150 RID: 336
			// (Invoke) Token: 0x060004FF RID: 1279
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);
		}

		// Token: 0x02000095 RID: 149
		internal struct FFIMethods
		{
			// Token: 0x04000201 RID: 513
			internal AchievementManager.FFIMethods.SetUserAchievementMethod SetUserAchievement;

			// Token: 0x04000202 RID: 514
			internal AchievementManager.FFIMethods.FetchUserAchievementsMethod FetchUserAchievements;

			// Token: 0x04000203 RID: 515
			internal AchievementManager.FFIMethods.CountUserAchievementsMethod CountUserAchievements;

			// Token: 0x04000204 RID: 516
			internal AchievementManager.FFIMethods.GetUserAchievementMethod GetUserAchievement;

			// Token: 0x04000205 RID: 517
			internal AchievementManager.FFIMethods.GetUserAchievementAtMethod GetUserAchievementAt;

			// Token: 0x02000151 RID: 337
			// (Invoke) Token: 0x06000503 RID: 1283
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetUserAchievementCallback(IntPtr ptr, Result result);

			// Token: 0x02000152 RID: 338
			// (Invoke) Token: 0x06000507 RID: 1287
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetUserAchievementMethod(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback);

			// Token: 0x02000153 RID: 339
			// (Invoke) Token: 0x0600050B RID: 1291
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchUserAchievementsCallback(IntPtr ptr, Result result);

			// Token: 0x02000154 RID: 340
			// (Invoke) Token: 0x0600050F RID: 1295
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchUserAchievementsMethod(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback);

			// Token: 0x02000155 RID: 341
			// (Invoke) Token: 0x06000513 RID: 1299
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountUserAchievementsMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x02000156 RID: 342
			// (Invoke) Token: 0x06000517 RID: 1303
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetUserAchievementMethod(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement);

			// Token: 0x02000157 RID: 343
			// (Invoke) Token: 0x0600051B RID: 1307
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetUserAchievementAtMethod(IntPtr methodsPtr, int index, ref UserAchievement userAchievement);
		}

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000217 RID: 535
		public delegate void SetUserAchievementHandler(Result result);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600021B RID: 539
		public delegate void FetchUserAchievementsHandler(Result result);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600021F RID: 543
		public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);
	}
}
