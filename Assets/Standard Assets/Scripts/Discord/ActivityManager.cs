using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000004 RID: 4
	public class ActivityManager
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000030C6 File Offset: 0x000012C6
		public void RegisterCommand()
		{
			this.RegisterCommand(null);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000030CF File Offset: 0x000012CF
		private ActivityManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(ActivityManager.FFIMethods));
				}
				return (ActivityManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000019 RID: 25 RVA: 0x00003100 File Offset: 0x00001300
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x00003138 File Offset: 0x00001338
		public event ActivityManager.ActivityJoinHandler OnActivityJoin;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001B RID: 27 RVA: 0x00003170 File Offset: 0x00001370
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x000031A8 File Offset: 0x000013A8
		public event ActivityManager.ActivitySpectateHandler OnActivitySpectate;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600001D RID: 29 RVA: 0x000031E0 File Offset: 0x000013E0
		// (remove) Token: 0x0600001E RID: 30 RVA: 0x00003218 File Offset: 0x00001418
		public event ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600001F RID: 31 RVA: 0x00003250 File Offset: 0x00001450
		// (remove) Token: 0x06000020 RID: 32 RVA: 0x00003288 File Offset: 0x00001488
		public event ActivityManager.ActivityInviteHandler OnActivityInvite;

		// Token: 0x06000021 RID: 33 RVA: 0x000032C0 File Offset: 0x000014C0
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
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

		// Token: 0x06000022 RID: 34 RVA: 0x00003310 File Offset: 0x00001510
		private void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
		{
			events.OnActivityJoin = new ActivityManager.FFIEvents.ActivityJoinHandler(ActivityManager.OnActivityJoinImpl);
			events.OnActivitySpectate = new ActivityManager.FFIEvents.ActivitySpectateHandler(ActivityManager.OnActivitySpectateImpl);
			events.OnActivityJoinRequest = new ActivityManager.FFIEvents.ActivityJoinRequestHandler(ActivityManager.OnActivityJoinRequestImpl);
			events.OnActivityInvite = new ActivityManager.FFIEvents.ActivityInviteHandler(ActivityManager.OnActivityInviteImpl);
			Marshal.StructureToPtr<ActivityManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003374 File Offset: 0x00001574
		public void RegisterCommand(string command)
		{
			Result result = this.Methods.RegisterCommand(this.MethodsPtr, command);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000033A4 File Offset: 0x000015A4
		public void RegisterSteam(uint steamId)
		{
			Result result = this.Methods.RegisterSteam(this.MethodsPtr, steamId);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000033D4 File Offset: 0x000015D4
		[MonoPInvokeCallback]
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ActivityManager.UpdateActivityHandler updateActivityHandler = (ActivityManager.UpdateActivityHandler)gchandle.Target;
			gchandle.Free();
			updateActivityHandler(result);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003404 File Offset: 0x00001604
		public void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.UpdateActivity(this.MethodsPtr, ref activity, GCHandle.ToIntPtr(gchandle), new ActivityManager.FFIMethods.UpdateActivityCallback(ActivityManager.UpdateActivityCallbackImpl));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003444 File Offset: 0x00001644
		[MonoPInvokeCallback]
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ActivityManager.ClearActivityHandler clearActivityHandler = (ActivityManager.ClearActivityHandler)gchandle.Target;
			gchandle.Free();
			clearActivityHandler(result);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003474 File Offset: 0x00001674
		public void ClearActivity(ActivityManager.ClearActivityHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ClearActivity(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new ActivityManager.FFIMethods.ClearActivityCallback(ActivityManager.ClearActivityCallbackImpl));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000034B0 File Offset: 0x000016B0
		[MonoPInvokeCallback]
		private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ActivityManager.SendRequestReplyHandler sendRequestReplyHandler = (ActivityManager.SendRequestReplyHandler)gchandle.Target;
			gchandle.Free();
			sendRequestReplyHandler(result);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000034E0 File Offset: 0x000016E0
		public void SendRequestReply(long userId, ActivityJoinRequestReply reply, ActivityManager.SendRequestReplyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SendRequestReply(this.MethodsPtr, userId, reply, GCHandle.ToIntPtr(gchandle), new ActivityManager.FFIMethods.SendRequestReplyCallback(ActivityManager.SendRequestReplyCallbackImpl));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003520 File Offset: 0x00001720
		[MonoPInvokeCallback]
		private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ActivityManager.SendInviteHandler sendInviteHandler = (ActivityManager.SendInviteHandler)gchandle.Target;
			gchandle.Free();
			sendInviteHandler(result);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003550 File Offset: 0x00001750
		public void SendInvite(long userId, ActivityActionType type, string content, ActivityManager.SendInviteHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SendInvite(this.MethodsPtr, userId, type, content, GCHandle.ToIntPtr(gchandle), new ActivityManager.FFIMethods.SendInviteCallback(ActivityManager.SendInviteCallbackImpl));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003590 File Offset: 0x00001790
		[MonoPInvokeCallback]
		private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ActivityManager.AcceptInviteHandler acceptInviteHandler = (ActivityManager.AcceptInviteHandler)gchandle.Target;
			gchandle.Free();
			acceptInviteHandler(result);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000035C0 File Offset: 0x000017C0
		public void AcceptInvite(long userId, ActivityManager.AcceptInviteHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.AcceptInvite(this.MethodsPtr, userId, GCHandle.ToIntPtr(gchandle), new ActivityManager.FFIMethods.AcceptInviteCallback(ActivityManager.AcceptInviteCallbackImpl));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003600 File Offset: 0x00001800
		[MonoPInvokeCallback]
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.ActivityManagerInstance.OnActivityJoin != null)
			{
				discord.ActivityManagerInstance.OnActivityJoin(secret);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003640 File Offset: 0x00001840
		[MonoPInvokeCallback]
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.ActivityManagerInstance.OnActivitySpectate != null)
			{
				discord.ActivityManagerInstance.OnActivitySpectate(secret);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003680 File Offset: 0x00001880
		[MonoPInvokeCallback]
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.ActivityManagerInstance.OnActivityJoinRequest != null)
			{
				discord.ActivityManagerInstance.OnActivityJoinRequest(ref user);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000036C0 File Offset: 0x000018C0
		[MonoPInvokeCallback]
		private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.ActivityManagerInstance.OnActivityInvite != null)
			{
				discord.ActivityManagerInstance.OnActivityInvite(type, ref user, ref activity);
			}
		}

		// Token: 0x04000022 RID: 34
		private IntPtr MethodsPtr;

		// Token: 0x04000023 RID: 35
		private object MethodsStructure;

		// Token: 0x02000041 RID: 65
		internal struct FFIEvents
		{
			// Token: 0x0400014F RID: 335
			internal ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin;

			// Token: 0x04000150 RID: 336
			internal ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate;

			// Token: 0x04000151 RID: 337
			internal ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest;

			// Token: 0x04000152 RID: 338
			internal ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite;

			// Token: 0x02000099 RID: 153
			// (Invoke) Token: 0x06000223 RID: 547
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinHandler(IntPtr ptr, [MarshalAs(UnmanagedType.LPStr)] string secret);

			// Token: 0x0200009A RID: 154
			// (Invoke) Token: 0x06000227 RID: 551
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivitySpectateHandler(IntPtr ptr, [MarshalAs(UnmanagedType.LPStr)] string secret);

			// Token: 0x0200009B RID: 155
			// (Invoke) Token: 0x0600022B RID: 555
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

			// Token: 0x0200009C RID: 156
			// (Invoke) Token: 0x0600022F RID: 559
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);
		}

		// Token: 0x02000042 RID: 66
		internal struct FFIMethods
		{
			// Token: 0x04000153 RID: 339
			internal ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand;

			// Token: 0x04000154 RID: 340
			internal ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam;

			// Token: 0x04000155 RID: 341
			internal ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity;

			// Token: 0x04000156 RID: 342
			internal ActivityManager.FFIMethods.ClearActivityMethod ClearActivity;

			// Token: 0x04000157 RID: 343
			internal ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply;

			// Token: 0x04000158 RID: 344
			internal ActivityManager.FFIMethods.SendInviteMethod SendInvite;

			// Token: 0x04000159 RID: 345
			internal ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite;

			// Token: 0x0200009D RID: 157
			// (Invoke) Token: 0x06000233 RID: 563
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string command);

			// Token: 0x0200009E RID: 158
			// (Invoke) Token: 0x06000237 RID: 567
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

			// Token: 0x0200009F RID: 159
			// (Invoke) Token: 0x0600023B RID: 571
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

			// Token: 0x020000A0 RID: 160
			// (Invoke) Token: 0x0600023F RID: 575
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback);

			// Token: 0x020000A1 RID: 161
			// (Invoke) Token: 0x06000243 RID: 579
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

			// Token: 0x020000A2 RID: 162
			// (Invoke) Token: 0x06000247 RID: 583
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback);

			// Token: 0x020000A3 RID: 163
			// (Invoke) Token: 0x0600024B RID: 587
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

			// Token: 0x020000A4 RID: 164
			// (Invoke) Token: 0x0600024F RID: 591
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback);

			// Token: 0x020000A5 RID: 165
			// (Invoke) Token: 0x06000253 RID: 595
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020000A6 RID: 166
			// (Invoke) Token: 0x06000257 RID: 599
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, [MarshalAs(UnmanagedType.LPStr)] string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback);

			// Token: 0x020000A7 RID: 167
			// (Invoke) Token: 0x0600025B RID: 603
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

			// Token: 0x020000A8 RID: 168
			// (Invoke) Token: 0x0600025F RID: 607
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback);
		}

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600013B RID: 315
		public delegate void UpdateActivityHandler(Result result);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600013F RID: 319
		public delegate void ClearActivityHandler(Result result);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000143 RID: 323
		public delegate void SendRequestReplyHandler(Result result);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000147 RID: 327
		public delegate void SendInviteHandler(Result result);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600014B RID: 331
		public delegate void AcceptInviteHandler(Result result);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600014F RID: 335
		public delegate void ActivityJoinHandler(string secret);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000153 RID: 339
		public delegate void ActivitySpectateHandler(string secret);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000157 RID: 343
		public delegate void ActivityJoinRequestHandler(ref User user);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600015B RID: 347
		public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);
	}
}
