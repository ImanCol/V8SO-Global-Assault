using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000036 RID: 54
	public class NetworkManager
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005E32 File Offset: 0x00004032
		private NetworkManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(NetworkManager.FFIMethods));
				}
				return (NetworkManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000D2 RID: 210 RVA: 0x00005E64 File Offset: 0x00004064
		// (remove) Token: 0x060000D3 RID: 211 RVA: 0x00005E9C File Offset: 0x0000409C
		public event NetworkManager.MessageHandler OnMessage;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000D4 RID: 212 RVA: 0x00005ED4 File Offset: 0x000040D4
		// (remove) Token: 0x060000D5 RID: 213 RVA: 0x00005F0C File Offset: 0x0000410C
		public event NetworkManager.RouteUpdateHandler OnRouteUpdate;

		// Token: 0x060000D6 RID: 214 RVA: 0x00005F44 File Offset: 0x00004144
		internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
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

		// Token: 0x060000D7 RID: 215 RVA: 0x00005F93 File Offset: 0x00004193
		private void InitEvents(IntPtr eventsPtr, ref NetworkManager.FFIEvents events)
		{
			events.OnMessage = new NetworkManager.FFIEvents.MessageHandler(NetworkManager.OnMessageImpl);
			events.OnRouteUpdate = new NetworkManager.FFIEvents.RouteUpdateHandler(NetworkManager.OnRouteUpdateImpl);
			Marshal.StructureToPtr<NetworkManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005FC8 File Offset: 0x000041C8
		public ulong GetPeerId()
		{
			ulong num = 0UL;
			this.Methods.GetPeerId(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005FF4 File Offset: 0x000041F4
		public void Flush()
		{
			Result result = this.Methods.Flush(this.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006024 File Offset: 0x00004224
		public void OpenPeer(ulong peerId, string routeData)
		{
			Result result = this.Methods.OpenPeer(this.MethodsPtr, peerId, routeData);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006054 File Offset: 0x00004254
		public void UpdatePeer(ulong peerId, string routeData)
		{
			Result result = this.Methods.UpdatePeer(this.MethodsPtr, peerId, routeData);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006084 File Offset: 0x00004284
		public void ClosePeer(ulong peerId)
		{
			Result result = this.Methods.ClosePeer(this.MethodsPtr, peerId);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000060B4 File Offset: 0x000042B4
		public void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
			Result result = this.Methods.OpenChannel(this.MethodsPtr, peerId, channelId, reliable);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000060E8 File Offset: 0x000042E8
		public void CloseChannel(ulong peerId, byte channelId)
		{
			Result result = this.Methods.CloseChannel(this.MethodsPtr, peerId, channelId);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006118 File Offset: 0x00004318
		public void SendMessage(ulong peerId, byte channelId, byte[] data)
		{
			Result result = this.Methods.SendMessage(this.MethodsPtr, peerId, channelId, data, data.Length);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000614C File Offset: 0x0000434C
		[MonoPInvokeCallback]
		private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.NetworkManagerInstance.OnMessage != null)
			{
				byte[] array = new byte[dataLen];
				Marshal.Copy(dataPtr, array, 0, dataLen);
				discord.NetworkManagerInstance.OnMessage(peerId, channelId, array);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000061A0 File Offset: 0x000043A0
		[MonoPInvokeCallback]
		private static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.NetworkManagerInstance.OnRouteUpdate != null)
			{
				discord.NetworkManagerInstance.OnRouteUpdate(routeData);
			}
		}

		// Token: 0x0400012B RID: 299
		private IntPtr MethodsPtr;

		// Token: 0x0400012C RID: 300
		private object MethodsStructure;

		// Token: 0x02000079 RID: 121
		internal struct FFIEvents
		{
			// Token: 0x040001CD RID: 461
			internal NetworkManager.FFIEvents.MessageHandler OnMessage;

			// Token: 0x040001CE RID: 462
			internal NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate;

			// Token: 0x02000112 RID: 274
			// (Invoke) Token: 0x06000407 RID: 1031
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

			// Token: 0x02000113 RID: 275
			// (Invoke) Token: 0x0600040B RID: 1035
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RouteUpdateHandler(IntPtr ptr, [MarshalAs(UnmanagedType.LPStr)] string routeData);
		}

		// Token: 0x0200007A RID: 122
		internal struct FFIMethods
		{
			// Token: 0x040001CF RID: 463
			internal NetworkManager.FFIMethods.GetPeerIdMethod GetPeerId;

			// Token: 0x040001D0 RID: 464
			internal NetworkManager.FFIMethods.FlushMethod Flush;

			// Token: 0x040001D1 RID: 465
			internal NetworkManager.FFIMethods.OpenPeerMethod OpenPeer;

			// Token: 0x040001D2 RID: 466
			internal NetworkManager.FFIMethods.UpdatePeerMethod UpdatePeer;

			// Token: 0x040001D3 RID: 467
			internal NetworkManager.FFIMethods.ClosePeerMethod ClosePeer;

			// Token: 0x040001D4 RID: 468
			internal NetworkManager.FFIMethods.OpenChannelMethod OpenChannel;

			// Token: 0x040001D5 RID: 469
			internal NetworkManager.FFIMethods.CloseChannelMethod CloseChannel;

			// Token: 0x040001D6 RID: 470
			internal NetworkManager.FFIMethods.SendMessageMethod SendMessage;

			// Token: 0x02000114 RID: 276
			// (Invoke) Token: 0x0600040F RID: 1039
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetPeerIdMethod(IntPtr methodsPtr, ref ulong peerId);

			// Token: 0x02000115 RID: 277
			// (Invoke) Token: 0x06000413 RID: 1043
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FlushMethod(IntPtr methodsPtr);

			// Token: 0x02000116 RID: 278
			// (Invoke) Token: 0x06000417 RID: 1047
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenPeerMethod(IntPtr methodsPtr, ulong peerId, [MarshalAs(UnmanagedType.LPStr)] string routeData);

			// Token: 0x02000117 RID: 279
			// (Invoke) Token: 0x0600041B RID: 1051
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result UpdatePeerMethod(IntPtr methodsPtr, ulong peerId, [MarshalAs(UnmanagedType.LPStr)] string routeData);

			// Token: 0x02000118 RID: 280
			// (Invoke) Token: 0x0600041F RID: 1055
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ClosePeerMethod(IntPtr methodsPtr, ulong peerId);

			// Token: 0x02000119 RID: 281
			// (Invoke) Token: 0x06000423 RID: 1059
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable);

			// Token: 0x0200011A RID: 282
			// (Invoke) Token: 0x06000427 RID: 1063
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CloseChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId);

			// Token: 0x0200011B RID: 283
			// (Invoke) Token: 0x0600042B RID: 1067
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SendMessageMethod(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen);
		}

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001D3 RID: 467
		public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001D7 RID: 471
		public delegate void RouteUpdateHandler(string routeData);
	}
}
