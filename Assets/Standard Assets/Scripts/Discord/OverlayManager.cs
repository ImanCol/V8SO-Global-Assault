using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000037 RID: 55
	public class OverlayManager
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000061DF File Offset: 0x000043DF
		private OverlayManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(OverlayManager.FFIMethods));
				}
				return (OverlayManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000E3 RID: 227 RVA: 0x00006210 File Offset: 0x00004410
		// (remove) Token: 0x060000E4 RID: 228 RVA: 0x00006248 File Offset: 0x00004448
		public event OverlayManager.ToggleHandler OnToggle;

		// Token: 0x060000E5 RID: 229 RVA: 0x00006280 File Offset: 0x00004480
		internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
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

		// Token: 0x060000E6 RID: 230 RVA: 0x000062CF File Offset: 0x000044CF
		private void InitEvents(IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
		{
			events.OnToggle = new OverlayManager.FFIEvents.ToggleHandler(OverlayManager.OnToggleImpl);
			Marshal.StructureToPtr<OverlayManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000062F0 File Offset: 0x000044F0
		public bool IsEnabled()
		{
			bool flag = false;
			this.Methods.IsEnabled(this.MethodsPtr, ref flag);
			return flag;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006318 File Offset: 0x00004518
		public bool IsLocked()
		{
			bool flag = false;
			this.Methods.IsLocked(this.MethodsPtr, ref flag);
			return flag;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00006340 File Offset: 0x00004540
		[MonoPInvokeCallback]
		private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			OverlayManager.SetLockedHandler setLockedHandler = (OverlayManager.SetLockedHandler)gchandle.Target;
			gchandle.Free();
			setLockedHandler(result);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00006370 File Offset: 0x00004570
		public void SetLocked(bool locked, OverlayManager.SetLockedHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SetLocked(this.MethodsPtr, locked, GCHandle.ToIntPtr(gchandle), new OverlayManager.FFIMethods.SetLockedCallback(OverlayManager.SetLockedCallbackImpl));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000063B0 File Offset: 0x000045B0
		[MonoPInvokeCallback]
		private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			OverlayManager.OpenActivityInviteHandler openActivityInviteHandler = (OverlayManager.OpenActivityInviteHandler)gchandle.Target;
			gchandle.Free();
			openActivityInviteHandler(result);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000063E0 File Offset: 0x000045E0
		public void OpenActivityInvite(ActivityActionType type, OverlayManager.OpenActivityInviteHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.OpenActivityInvite(this.MethodsPtr, type, GCHandle.ToIntPtr(gchandle), new OverlayManager.FFIMethods.OpenActivityInviteCallback(OverlayManager.OpenActivityInviteCallbackImpl));
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006420 File Offset: 0x00004620
		[MonoPInvokeCallback]
		private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			OverlayManager.OpenGuildInviteHandler openGuildInviteHandler = (OverlayManager.OpenGuildInviteHandler)gchandle.Target;
			gchandle.Free();
			openGuildInviteHandler(result);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006450 File Offset: 0x00004650
		public void OpenGuildInvite(string code, OverlayManager.OpenGuildInviteHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.OpenGuildInvite(this.MethodsPtr, code, GCHandle.ToIntPtr(gchandle), new OverlayManager.FFIMethods.OpenGuildInviteCallback(OverlayManager.OpenGuildInviteCallbackImpl));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006490 File Offset: 0x00004690
		[MonoPInvokeCallback]
		private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			OverlayManager.OpenVoiceSettingsHandler openVoiceSettingsHandler = (OverlayManager.OpenVoiceSettingsHandler)gchandle.Target;
			gchandle.Free();
			openVoiceSettingsHandler(result);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000064C0 File Offset: 0x000046C0
		public void OpenVoiceSettings(OverlayManager.OpenVoiceSettingsHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.OpenVoiceSettings(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new OverlayManager.FFIMethods.OpenVoiceSettingsCallback(OverlayManager.OpenVoiceSettingsCallbackImpl));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000064FC File Offset: 0x000046FC
		[MonoPInvokeCallback]
		private static void OnToggleImpl(IntPtr ptr, bool locked)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.OverlayManagerInstance.OnToggle != null)
			{
				discord.OverlayManagerInstance.OnToggle(locked);
			}
		}

		// Token: 0x0400012F RID: 303
		private IntPtr MethodsPtr;

		// Token: 0x04000130 RID: 304
		private object MethodsStructure;

		// Token: 0x0200007D RID: 125
		internal struct FFIEvents
		{
			// Token: 0x040001D7 RID: 471
			internal OverlayManager.FFIEvents.ToggleHandler OnToggle;

			// Token: 0x0200011C RID: 284
			// (Invoke) Token: 0x0600042F RID: 1071
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ToggleHandler(IntPtr ptr, bool locked);
		}

		// Token: 0x0200007E RID: 126
		internal struct FFIMethods
		{
			// Token: 0x040001D8 RID: 472
			internal OverlayManager.FFIMethods.IsEnabledMethod IsEnabled;

			// Token: 0x040001D9 RID: 473
			internal OverlayManager.FFIMethods.IsLockedMethod IsLocked;

			// Token: 0x040001DA RID: 474
			internal OverlayManager.FFIMethods.SetLockedMethod SetLocked;

			// Token: 0x040001DB RID: 475
			internal OverlayManager.FFIMethods.OpenActivityInviteMethod OpenActivityInvite;

			// Token: 0x040001DC RID: 476
			internal OverlayManager.FFIMethods.OpenGuildInviteMethod OpenGuildInvite;

			// Token: 0x040001DD RID: 477
			internal OverlayManager.FFIMethods.OpenVoiceSettingsMethod OpenVoiceSettings;

			// Token: 0x0200011D RID: 285
			// (Invoke) Token: 0x06000433 RID: 1075
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void IsEnabledMethod(IntPtr methodsPtr, ref bool enabled);

			// Token: 0x0200011E RID: 286
			// (Invoke) Token: 0x06000437 RID: 1079
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void IsLockedMethod(IntPtr methodsPtr, ref bool locked);

			// Token: 0x0200011F RID: 287
			// (Invoke) Token: 0x0600043B RID: 1083
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLockedCallback(IntPtr ptr, Result result);

			// Token: 0x02000120 RID: 288
			// (Invoke) Token: 0x0600043F RID: 1087
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLockedMethod(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback);

			// Token: 0x02000121 RID: 289
			// (Invoke) Token: 0x06000443 RID: 1091
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenActivityInviteCallback(IntPtr ptr, Result result);

			// Token: 0x02000122 RID: 290
			// (Invoke) Token: 0x06000447 RID: 1095
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenActivityInviteMethod(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback);

			// Token: 0x02000123 RID: 291
			// (Invoke) Token: 0x0600044B RID: 1099
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenGuildInviteCallback(IntPtr ptr, Result result);

			// Token: 0x02000124 RID: 292
			// (Invoke) Token: 0x0600044F RID: 1103
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenGuildInviteMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback);

			// Token: 0x02000125 RID: 293
			// (Invoke) Token: 0x06000453 RID: 1107
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenVoiceSettingsCallback(IntPtr ptr, Result result);

			// Token: 0x02000126 RID: 294
			// (Invoke) Token: 0x06000457 RID: 1111
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenVoiceSettingsMethod(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback);
		}

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001DB RID: 475
		public delegate void SetLockedHandler(Result result);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060001DF RID: 479
		public delegate void OpenActivityInviteHandler(Result result);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060001E3 RID: 483
		public delegate void OpenGuildInviteHandler(Result result);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001E7 RID: 487
		public delegate void OpenVoiceSettingsHandler(Result result);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001EB RID: 491
		public delegate void ToggleHandler(bool locked);
	}
}
