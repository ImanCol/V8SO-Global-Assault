using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Discord
{
	// Token: 0x02000031 RID: 49
	public class ApplicationManager
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004329 File Offset: 0x00002529
		private ApplicationManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(ApplicationManager.FFIMethods));
				}
				return (ApplicationManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000435C File Offset: 0x0000255C
		internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
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

		// Token: 0x0600005C RID: 92 RVA: 0x000043AB File Offset: 0x000025AB
		private void InitEvents(IntPtr eventsPtr, ref ApplicationManager.FFIEvents events)
		{
			Marshal.StructureToPtr<ApplicationManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000043BC File Offset: 0x000025BC
		[MonoPInvokeCallback]
		private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ApplicationManager.ValidateOrExitHandler validateOrExitHandler = (ApplicationManager.ValidateOrExitHandler)gchandle.Target;
			gchandle.Free();
			validateOrExitHandler(result);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000043EC File Offset: 0x000025EC
		public void ValidateOrExit(ApplicationManager.ValidateOrExitHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ValidateOrExit(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new ApplicationManager.FFIMethods.ValidateOrExitCallback(ApplicationManager.ValidateOrExitCallbackImpl));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004428 File Offset: 0x00002628
		public string GetCurrentLocale()
		{
			StringBuilder stringBuilder = new StringBuilder(128);
			this.Methods.GetCurrentLocale(this.MethodsPtr, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004460 File Offset: 0x00002660
		public string GetCurrentBranch()
		{
			StringBuilder stringBuilder = new StringBuilder(4096);
			this.Methods.GetCurrentBranch(this.MethodsPtr, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004498 File Offset: 0x00002698
		[MonoPInvokeCallback]
		private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ApplicationManager.GetOAuth2TokenHandler getOAuth2TokenHandler = (ApplicationManager.GetOAuth2TokenHandler)gchandle.Target;
			gchandle.Free();
			getOAuth2TokenHandler(result, ref oauth2Token);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000044C8 File Offset: 0x000026C8
		public void GetOAuth2Token(ApplicationManager.GetOAuth2TokenHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.GetOAuth2Token(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new ApplicationManager.FFIMethods.GetOAuth2TokenCallback(ApplicationManager.GetOAuth2TokenCallbackImpl));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004504 File Offset: 0x00002704
		[MonoPInvokeCallback]
		private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			ApplicationManager.GetTicketHandler getTicketHandler = (ApplicationManager.GetTicketHandler)gchandle.Target;
			gchandle.Free();
			getTicketHandler(result, ref data);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004534 File Offset: 0x00002734
		public void GetTicket(ApplicationManager.GetTicketHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.GetTicket(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new ApplicationManager.FFIMethods.GetTicketCallback(ApplicationManager.GetTicketCallbackImpl));
		}

		// Token: 0x04000116 RID: 278
		private IntPtr MethodsPtr;

		// Token: 0x04000117 RID: 279
		private object MethodsStructure;

		// Token: 0x02000053 RID: 83
		internal struct FFIEvents
		{
		}

		// Token: 0x02000054 RID: 84
		internal struct FFIMethods
		{
			// Token: 0x04000191 RID: 401
			internal ApplicationManager.FFIMethods.ValidateOrExitMethod ValidateOrExit;

			// Token: 0x04000192 RID: 402
			internal ApplicationManager.FFIMethods.GetCurrentLocaleMethod GetCurrentLocale;

			// Token: 0x04000193 RID: 403
			internal ApplicationManager.FFIMethods.GetCurrentBranchMethod GetCurrentBranch;

			// Token: 0x04000194 RID: 404
			internal ApplicationManager.FFIMethods.GetOAuth2TokenMethod GetOAuth2Token;

			// Token: 0x04000195 RID: 405
			internal ApplicationManager.FFIMethods.GetTicketMethod GetTicket;

			// Token: 0x020000C5 RID: 197
			// (Invoke) Token: 0x060002D3 RID: 723
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ValidateOrExitCallback(IntPtr ptr, Result result);

			// Token: 0x020000C6 RID: 198
			// (Invoke) Token: 0x060002D7 RID: 727
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ValidateOrExitMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback);

			// Token: 0x020000C7 RID: 199
			// (Invoke) Token: 0x060002DB RID: 731
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetCurrentLocaleMethod(IntPtr methodsPtr, StringBuilder locale);

			// Token: 0x020000C8 RID: 200
			// (Invoke) Token: 0x060002DF RID: 735
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetCurrentBranchMethod(IntPtr methodsPtr, StringBuilder branch);

			// Token: 0x020000C9 RID: 201
			// (Invoke) Token: 0x060002E3 RID: 739
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetOAuth2TokenCallback(IntPtr ptr, Result result, ref OAuth2Token oauth2Token);

			// Token: 0x020000CA RID: 202
			// (Invoke) Token: 0x060002E7 RID: 743
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetOAuth2TokenMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback);

			// Token: 0x020000CB RID: 203
			// (Invoke) Token: 0x060002EB RID: 747
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetTicketCallback(IntPtr ptr, Result result, [MarshalAs(UnmanagedType.LPStr)] ref string data);

			// Token: 0x020000CC RID: 204
			// (Invoke) Token: 0x060002EF RID: 751
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetTicketMethod(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback);
		}

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000163 RID: 355
		public delegate void ValidateOrExitHandler(Result result);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000167 RID: 359
		public delegate void GetOAuth2TokenHandler(Result result, ref OAuth2Token oauth2Token);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x0600016B RID: 363
		public delegate void GetTicketHandler(Result result, ref string data);
	}
}
