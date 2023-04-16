using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x0200003A RID: 58
	public class VoiceManager
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00006E5C File Offset: 0x0000505C
		private VoiceManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(VoiceManager.FFIMethods));
				}
				return (VoiceManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600011D RID: 285 RVA: 0x00006E8C File Offset: 0x0000508C
		// (remove) Token: 0x0600011E RID: 286 RVA: 0x00006EC4 File Offset: 0x000050C4
		public event VoiceManager.SettingsUpdateHandler OnSettingsUpdate;

		// Token: 0x0600011F RID: 287 RVA: 0x00006EFC File Offset: 0x000050FC
		internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
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

		// Token: 0x06000120 RID: 288 RVA: 0x00006F4B File Offset: 0x0000514B
		private void InitEvents(IntPtr eventsPtr, ref VoiceManager.FFIEvents events)
		{
			events.OnSettingsUpdate = new VoiceManager.FFIEvents.SettingsUpdateHandler(VoiceManager.OnSettingsUpdateImpl);
			Marshal.StructureToPtr<VoiceManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006F6C File Offset: 0x0000516C
		public InputMode GetInputMode()
		{
			InputMode inputMode = default(InputMode);
			Result result = this.Methods.GetInputMode(this.MethodsPtr, ref inputMode);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return inputMode;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006FA8 File Offset: 0x000051A8
		[MonoPInvokeCallback]
		private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			VoiceManager.SetInputModeHandler setInputModeHandler = (VoiceManager.SetInputModeHandler)gchandle.Target;
			gchandle.Free();
			setInputModeHandler(result);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006FD8 File Offset: 0x000051D8
		public void SetInputMode(InputMode inputMode, VoiceManager.SetInputModeHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SetInputMode(this.MethodsPtr, inputMode, GCHandle.ToIntPtr(gchandle), new VoiceManager.FFIMethods.SetInputModeCallback(VoiceManager.SetInputModeCallbackImpl));
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007018 File Offset: 0x00005218
		public bool IsSelfMute()
		{
			bool flag = false;
			Result result = this.Methods.IsSelfMute(this.MethodsPtr, ref flag);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000704C File Offset: 0x0000524C
		public void SetSelfMute(bool mute)
		{
			Result result = this.Methods.SetSelfMute(this.MethodsPtr, mute);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000707C File Offset: 0x0000527C
		public bool IsSelfDeaf()
		{
			bool flag = false;
			Result result = this.Methods.IsSelfDeaf(this.MethodsPtr, ref flag);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000070B0 File Offset: 0x000052B0
		public void SetSelfDeaf(bool deaf)
		{
			Result result = this.Methods.SetSelfDeaf(this.MethodsPtr, deaf);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000070E0 File Offset: 0x000052E0
		public bool IsLocalMute(long userId)
		{
			bool flag = false;
			Result result = this.Methods.IsLocalMute(this.MethodsPtr, userId, ref flag);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007114 File Offset: 0x00005314
		public void SetLocalMute(long userId, bool mute)
		{
			Result result = this.Methods.SetLocalMute(this.MethodsPtr, userId, mute);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007144 File Offset: 0x00005344
		public byte GetLocalVolume(long userId)
		{
			byte b = 0;
			Result result = this.Methods.GetLocalVolume(this.MethodsPtr, userId, ref b);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return b;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007178 File Offset: 0x00005378
		public void SetLocalVolume(long userId, byte volume)
		{
			Result result = this.Methods.SetLocalVolume(this.MethodsPtr, userId, volume);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000071A8 File Offset: 0x000053A8
		[MonoPInvokeCallback]
		private static void OnSettingsUpdateImpl(IntPtr ptr)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.VoiceManagerInstance.OnSettingsUpdate != null)
			{
				discord.VoiceManagerInstance.OnSettingsUpdate();
			}
		}

		// Token: 0x04000138 RID: 312
		private IntPtr MethodsPtr;

		// Token: 0x04000139 RID: 313
		private object MethodsStructure;

		// Token: 0x02000090 RID: 144
		internal struct FFIEvents
		{
			// Token: 0x040001F5 RID: 501
			internal VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate;

			// Token: 0x02000144 RID: 324
			// (Invoke) Token: 0x060004CF RID: 1231
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SettingsUpdateHandler(IntPtr ptr);
		}

		// Token: 0x02000091 RID: 145
		internal struct FFIMethods
		{
			// Token: 0x040001F6 RID: 502
			internal VoiceManager.FFIMethods.GetInputModeMethod GetInputMode;

			// Token: 0x040001F7 RID: 503
			internal VoiceManager.FFIMethods.SetInputModeMethod SetInputMode;

			// Token: 0x040001F8 RID: 504
			internal VoiceManager.FFIMethods.IsSelfMuteMethod IsSelfMute;

			// Token: 0x040001F9 RID: 505
			internal VoiceManager.FFIMethods.SetSelfMuteMethod SetSelfMute;

			// Token: 0x040001FA RID: 506
			internal VoiceManager.FFIMethods.IsSelfDeafMethod IsSelfDeaf;

			// Token: 0x040001FB RID: 507
			internal VoiceManager.FFIMethods.SetSelfDeafMethod SetSelfDeaf;

			// Token: 0x040001FC RID: 508
			internal VoiceManager.FFIMethods.IsLocalMuteMethod IsLocalMute;

			// Token: 0x040001FD RID: 509
			internal VoiceManager.FFIMethods.SetLocalMuteMethod SetLocalMute;

			// Token: 0x040001FE RID: 510
			internal VoiceManager.FFIMethods.GetLocalVolumeMethod GetLocalVolume;

			// Token: 0x040001FF RID: 511
			internal VoiceManager.FFIMethods.SetLocalVolumeMethod SetLocalVolume;

			// Token: 0x02000145 RID: 325
			// (Invoke) Token: 0x060004D3 RID: 1235
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetInputModeMethod(IntPtr methodsPtr, ref InputMode inputMode);

			// Token: 0x02000146 RID: 326
			// (Invoke) Token: 0x060004D7 RID: 1239
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetInputModeCallback(IntPtr ptr, Result result);

			// Token: 0x02000147 RID: 327
			// (Invoke) Token: 0x060004DB RID: 1243
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetInputModeMethod(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback);

			// Token: 0x02000148 RID: 328
			// (Invoke) Token: 0x060004DF RID: 1247
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsSelfMuteMethod(IntPtr methodsPtr, ref bool mute);

			// Token: 0x02000149 RID: 329
			// (Invoke) Token: 0x060004E3 RID: 1251
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetSelfMuteMethod(IntPtr methodsPtr, bool mute);

			// Token: 0x0200014A RID: 330
			// (Invoke) Token: 0x060004E7 RID: 1255
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsSelfDeafMethod(IntPtr methodsPtr, ref bool deaf);

			// Token: 0x0200014B RID: 331
			// (Invoke) Token: 0x060004EB RID: 1259
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetSelfDeafMethod(IntPtr methodsPtr, bool deaf);

			// Token: 0x0200014C RID: 332
			// (Invoke) Token: 0x060004EF RID: 1263
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsLocalMuteMethod(IntPtr methodsPtr, long userId, ref bool mute);

			// Token: 0x0200014D RID: 333
			// (Invoke) Token: 0x060004F3 RID: 1267
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLocalMuteMethod(IntPtr methodsPtr, long userId, bool mute);

			// Token: 0x0200014E RID: 334
			// (Invoke) Token: 0x060004F7 RID: 1271
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLocalVolumeMethod(IntPtr methodsPtr, long userId, ref byte volume);

			// Token: 0x0200014F RID: 335
			// (Invoke) Token: 0x060004FB RID: 1275
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLocalVolumeMethod(IntPtr methodsPtr, long userId, byte volume);
		}

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x0600020F RID: 527
		public delegate void SetInputModeHandler(Result result);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000213 RID: 531
		public delegate void SettingsUpdateHandler();
	}
}
