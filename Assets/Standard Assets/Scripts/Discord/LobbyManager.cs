using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Discord
{
	// Token: 0x02000035 RID: 53

	public class LobbyManager
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004CEB File Offset: 0x00002EEB
		private LobbyManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(LobbyManager.FFIMethods));
				}
				return (LobbyManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00004D1C File Offset: 0x00002F1C
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00004D54 File Offset: 0x00002F54
		public event LobbyManager.LobbyUpdateHandler OnLobbyUpdate;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600008B RID: 139 RVA: 0x00004D8C File Offset: 0x00002F8C
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00004DC4 File Offset: 0x00002FC4
		public event LobbyManager.LobbyDeleteHandler OnLobbyDelete;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600008D RID: 141 RVA: 0x00004DFC File Offset: 0x00002FFC
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x00004E34 File Offset: 0x00003034
		public event LobbyManager.MemberConnectHandler OnMemberConnect;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600008F RID: 143 RVA: 0x00004E6C File Offset: 0x0000306C
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x00004EA4 File Offset: 0x000030A4
		public event LobbyManager.MemberUpdateHandler OnMemberUpdate;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000091 RID: 145 RVA: 0x00004EDC File Offset: 0x000030DC
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x00004F14 File Offset: 0x00003114
		public event LobbyManager.MemberDisconnectHandler OnMemberDisconnect;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000093 RID: 147 RVA: 0x00004F4C File Offset: 0x0000314C
		// (remove) Token: 0x06000094 RID: 148 RVA: 0x00004F84 File Offset: 0x00003184
		public event LobbyManager.LobbyMessageHandler OnLobbyMessage;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000095 RID: 149 RVA: 0x00004FBC File Offset: 0x000031BC
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x00004FF4 File Offset: 0x000031F4
		public event LobbyManager.SpeakingHandler OnSpeaking;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000097 RID: 151 RVA: 0x0000502C File Offset: 0x0000322C
		// (remove) Token: 0x06000098 RID: 152 RVA: 0x00005064 File Offset: 0x00003264
		public event LobbyManager.NetworkMessageHandler OnNetworkMessage;

		// Token: 0x06000099 RID: 153 RVA: 0x0000509C File Offset: 0x0000329C
		internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
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

		// Token: 0x0600009A RID: 154 RVA: 0x000050EC File Offset: 0x000032EC
		private void InitEvents(IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
		{
			events.OnLobbyUpdate = new LobbyManager.FFIEvents.LobbyUpdateHandler(LobbyManager.OnLobbyUpdateImpl);
			events.OnLobbyDelete = new LobbyManager.FFIEvents.LobbyDeleteHandler(LobbyManager.OnLobbyDeleteImpl);
			events.OnMemberConnect = new LobbyManager.FFIEvents.MemberConnectHandler(LobbyManager.OnMemberConnectImpl);
			events.OnMemberUpdate = new LobbyManager.FFIEvents.MemberUpdateHandler(LobbyManager.OnMemberUpdateImpl);
			events.OnMemberDisconnect = new LobbyManager.FFIEvents.MemberDisconnectHandler(LobbyManager.OnMemberDisconnectImpl);
			events.OnLobbyMessage = new LobbyManager.FFIEvents.LobbyMessageHandler(LobbyManager.OnLobbyMessageImpl);
			events.OnSpeaking = new LobbyManager.FFIEvents.SpeakingHandler(LobbyManager.OnSpeakingImpl);
			events.OnNetworkMessage = new LobbyManager.FFIEvents.NetworkMessageHandler(LobbyManager.OnNetworkMessageImpl);
			Marshal.StructureToPtr<LobbyManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005198 File Offset: 0x00003398
		public LobbyTransaction GetLobbyCreateTransaction()
		{
			LobbyTransaction lobbyTransaction = default(LobbyTransaction);
			Result result = this.Methods.GetLobbyCreateTransaction(this.MethodsPtr, ref lobbyTransaction.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return lobbyTransaction;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000051D8 File Offset: 0x000033D8
		public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			LobbyTransaction lobbyTransaction = default(LobbyTransaction);
			Result result = this.Methods.GetLobbyUpdateTransaction(this.MethodsPtr, lobbyId, ref lobbyTransaction.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return lobbyTransaction;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005218 File Offset: 0x00003418
		public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			LobbyMemberTransaction lobbyMemberTransaction = default(LobbyMemberTransaction);
			Result result = this.Methods.GetMemberUpdateTransaction(this.MethodsPtr, lobbyId, userId, ref lobbyMemberTransaction.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return lobbyMemberTransaction;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005258 File Offset: 0x00003458
		[MonoPInvokeCallback]
		private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.CreateLobbyHandler createLobbyHandler = (LobbyManager.CreateLobbyHandler)gchandle.Target;
			gchandle.Free();
			createLobbyHandler(result, ref lobby);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005288 File Offset: 0x00003488
		public void CreateLobby(LobbyTransaction transaction, LobbyManager.CreateLobbyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.CreateLobby(this.MethodsPtr, transaction.MethodsPtr, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.CreateLobbyCallback(LobbyManager.CreateLobbyCallbackImpl));
			transaction.MethodsPtr = IntPtr.Zero;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000052D8 File Offset: 0x000034D8
		[MonoPInvokeCallback]
		private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.UpdateLobbyHandler updateLobbyHandler = (LobbyManager.UpdateLobbyHandler)gchandle.Target;
			gchandle.Free();
			updateLobbyHandler(result);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005308 File Offset: 0x00003508
		public void UpdateLobby(long lobbyId, LobbyTransaction transaction, LobbyManager.UpdateLobbyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.UpdateLobby(this.MethodsPtr, lobbyId, transaction.MethodsPtr, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.UpdateLobbyCallback(LobbyManager.UpdateLobbyCallbackImpl));
			transaction.MethodsPtr = IntPtr.Zero;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005358 File Offset: 0x00003558
		[MonoPInvokeCallback]
		private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.DeleteLobbyHandler deleteLobbyHandler = (LobbyManager.DeleteLobbyHandler)gchandle.Target;
			gchandle.Free();
			deleteLobbyHandler(result);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005388 File Offset: 0x00003588
		public void DeleteLobby(long lobbyId, LobbyManager.DeleteLobbyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.DeleteLobby(this.MethodsPtr, lobbyId, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.DeleteLobbyCallback(LobbyManager.DeleteLobbyCallbackImpl));
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000053C8 File Offset: 0x000035C8
		[MonoPInvokeCallback]
		private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.ConnectLobbyHandler connectLobbyHandler = (LobbyManager.ConnectLobbyHandler)gchandle.Target;
			gchandle.Free();
			connectLobbyHandler(result, ref lobby);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000053F8 File Offset: 0x000035F8
		public void ConnectLobby(long lobbyId, string secret, LobbyManager.ConnectLobbyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ConnectLobby(this.MethodsPtr, lobbyId, secret, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.ConnectLobbyCallback(LobbyManager.ConnectLobbyCallbackImpl));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005438 File Offset: 0x00003638
		[MonoPInvokeCallback]
		private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.ConnectLobbyWithActivitySecretHandler connectLobbyWithActivitySecretHandler = (LobbyManager.ConnectLobbyWithActivitySecretHandler)gchandle.Target;
			gchandle.Free();
			connectLobbyWithActivitySecretHandler(result, ref lobby);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005468 File Offset: 0x00003668
		public void ConnectLobbyWithActivitySecret(string activitySecret, LobbyManager.ConnectLobbyWithActivitySecretHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ConnectLobbyWithActivitySecret(this.MethodsPtr, activitySecret, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback(LobbyManager.ConnectLobbyWithActivitySecretCallbackImpl));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000054A8 File Offset: 0x000036A8
		[MonoPInvokeCallback]
		private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.DisconnectLobbyHandler disconnectLobbyHandler = (LobbyManager.DisconnectLobbyHandler)gchandle.Target;
			gchandle.Free();
			disconnectLobbyHandler(result);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000054D8 File Offset: 0x000036D8
		public void DisconnectLobby(long lobbyId, LobbyManager.DisconnectLobbyHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.DisconnectLobby(this.MethodsPtr, lobbyId, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.DisconnectLobbyCallback(LobbyManager.DisconnectLobbyCallbackImpl));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005518 File Offset: 0x00003718
		public Lobby GetLobby(long lobbyId)
		{
			Lobby lobby = default(Lobby);
			Result result = this.Methods.GetLobby(this.MethodsPtr, lobbyId, ref lobby);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return lobby;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005554 File Offset: 0x00003754
		public string GetLobbyActivitySecret(long lobbyId)
		{
			StringBuilder stringBuilder = new StringBuilder(128);
			Result result = this.Methods.GetLobbyActivitySecret(this.MethodsPtr, lobbyId, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005598 File Offset: 0x00003798
		public string GetLobbyMetadataValue(long lobbyId, string key)
		{
			StringBuilder stringBuilder = new StringBuilder(4096);
			Result result = this.Methods.GetLobbyMetadataValue(this.MethodsPtr, lobbyId, key, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000055DC File Offset: 0x000037DC
		public string GetLobbyMetadataKey(long lobbyId, int index)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			Result result = this.Methods.GetLobbyMetadataKey(this.MethodsPtr, lobbyId, index, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005620 File Offset: 0x00003820
		public int LobbyMetadataCount(long lobbyId)
		{
			int num = 0;
			Result result = this.Methods.LobbyMetadataCount(this.MethodsPtr, lobbyId, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005654 File Offset: 0x00003854
		public int MemberCount(long lobbyId)
		{
			int num = 0;
			Result result = this.Methods.MemberCount(this.MethodsPtr, lobbyId, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005688 File Offset: 0x00003888
		public long GetMemberUserId(long lobbyId, int index)
		{
			long num = 0L;
			Result result = this.Methods.GetMemberUserId(this.MethodsPtr, lobbyId, index, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000056C0 File Offset: 0x000038C0
		public User GetMemberUser(long lobbyId, long userId)
		{
			User user = default(User);
			Result result = this.Methods.GetMemberUser(this.MethodsPtr, lobbyId, userId, ref user);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return user;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000056FC File Offset: 0x000038FC
		public string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			StringBuilder stringBuilder = new StringBuilder(4096);
			Result result = this.Methods.GetMemberMetadataValue(this.MethodsPtr, lobbyId, userId, key, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005740 File Offset: 0x00003940
		public string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			Result result = this.Methods.GetMemberMetadataKey(this.MethodsPtr, lobbyId, userId, index, stringBuilder);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005784 File Offset: 0x00003984
		public int MemberMetadataCount(long lobbyId, long userId)
		{
			int num = 0;
			Result result = this.Methods.MemberMetadataCount(this.MethodsPtr, lobbyId, userId, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000057BC File Offset: 0x000039BC
		[MonoPInvokeCallback]
		private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.UpdateMemberHandler updateMemberHandler = (LobbyManager.UpdateMemberHandler)gchandle.Target;
			gchandle.Free();
			updateMemberHandler(result);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000057EC File Offset: 0x000039EC
		public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, LobbyManager.UpdateMemberHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.UpdateMember(this.MethodsPtr, lobbyId, userId, transaction.MethodsPtr, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.UpdateMemberCallback(LobbyManager.UpdateMemberCallbackImpl));
			transaction.MethodsPtr = IntPtr.Zero;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005840 File Offset: 0x00003A40
		[MonoPInvokeCallback]
		private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.SendLobbyMessageHandler sendLobbyMessageHandler = (LobbyManager.SendLobbyMessageHandler)gchandle.Target;
			gchandle.Free();
			sendLobbyMessageHandler(result);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005870 File Offset: 0x00003A70
		public void SendLobbyMessage(long lobbyId, byte[] data, LobbyManager.SendLobbyMessageHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.SendLobbyMessage(this.MethodsPtr, lobbyId, data, data.Length, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.SendLobbyMessageCallback(LobbyManager.SendLobbyMessageCallbackImpl));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000058B4 File Offset: 0x00003AB4
		public LobbySearchQuery GetSearchQuery()
		{
			LobbySearchQuery lobbySearchQuery = default(LobbySearchQuery);
			Result result = this.Methods.GetSearchQuery(this.MethodsPtr, ref lobbySearchQuery.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return lobbySearchQuery;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000058F4 File Offset: 0x00003AF4
		[MonoPInvokeCallback]
		private static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.SearchHandler searchHandler = (LobbyManager.SearchHandler)gchandle.Target;
			gchandle.Free();
			searchHandler(result);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005924 File Offset: 0x00003B24
		public void Search(LobbySearchQuery query, LobbyManager.SearchHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.Search(this.MethodsPtr, query.MethodsPtr, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.SearchCallback(LobbyManager.SearchCallbackImpl));
			query.MethodsPtr = IntPtr.Zero;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005974 File Offset: 0x00003B74
		public int LobbyCount()
		{
			int num = 0;
			this.Methods.LobbyCount(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000599C File Offset: 0x00003B9C
		public long GetLobbyId(int index)
		{
			long num = 0L;
			Result result = this.Methods.GetLobbyId(this.MethodsPtr, index, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000059D4 File Offset: 0x00003BD4
		[MonoPInvokeCallback]
		private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.ConnectVoiceHandler connectVoiceHandler = (LobbyManager.ConnectVoiceHandler)gchandle.Target;
			gchandle.Free();
			connectVoiceHandler(result);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005A04 File Offset: 0x00003C04
		public void ConnectVoice(long lobbyId, LobbyManager.ConnectVoiceHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.ConnectVoice(this.MethodsPtr, lobbyId, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.ConnectVoiceCallback(LobbyManager.ConnectVoiceCallbackImpl));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005A44 File Offset: 0x00003C44
		[MonoPInvokeCallback]
		private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			LobbyManager.DisconnectVoiceHandler disconnectVoiceHandler = (LobbyManager.DisconnectVoiceHandler)gchandle.Target;
			gchandle.Free();
			disconnectVoiceHandler(result);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005A74 File Offset: 0x00003C74
		public void DisconnectVoice(long lobbyId, LobbyManager.DisconnectVoiceHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.DisconnectVoice(this.MethodsPtr, lobbyId, GCHandle.ToIntPtr(gchandle), new LobbyManager.FFIMethods.DisconnectVoiceCallback(LobbyManager.DisconnectVoiceCallbackImpl));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public void ConnectNetwork(long lobbyId)
		{
			Result result = this.Methods.ConnectNetwork(this.MethodsPtr, lobbyId);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public void DisconnectNetwork(long lobbyId)
		{
			Result result = this.Methods.DisconnectNetwork(this.MethodsPtr, lobbyId);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005B14 File Offset: 0x00003D14
		public void FlushNetwork()
		{
			Result result = this.Methods.FlushNetwork(this.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005B44 File Offset: 0x00003D44
		public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
			Result result = this.Methods.OpenNetworkChannel(this.MethodsPtr, lobbyId, channelId, reliable);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005B78 File Offset: 0x00003D78
		public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
		{
			Result result = this.Methods.SendNetworkMessage(this.MethodsPtr, lobbyId, userId, channelId, data, data.Length);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[MonoPInvokeCallback]
		private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnLobbyUpdate != null)
			{
				discord.LobbyManagerInstance.OnLobbyUpdate(lobbyId);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005BF0 File Offset: 0x00003DF0
		[MonoPInvokeCallback]
		private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnLobbyDelete != null)
			{
				discord.LobbyManagerInstance.OnLobbyDelete(lobbyId, reason);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005C30 File Offset: 0x00003E30
		[MonoPInvokeCallback]
		private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnMemberConnect != null)
			{
				discord.LobbyManagerInstance.OnMemberConnect(lobbyId, userId);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005C70 File Offset: 0x00003E70
		[MonoPInvokeCallback]
		private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnMemberUpdate != null)
			{
				discord.LobbyManagerInstance.OnMemberUpdate(lobbyId, userId);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005CB0 File Offset: 0x00003EB0
		[MonoPInvokeCallback]
		private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnMemberDisconnect != null)
			{
				discord.LobbyManagerInstance.OnMemberDisconnect(lobbyId, userId);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005CF0 File Offset: 0x00003EF0
		[MonoPInvokeCallback]
		private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnLobbyMessage != null)
			{
				byte[] array = new byte[dataLen];
				Marshal.Copy(dataPtr, array, 0, dataLen);
				discord.LobbyManagerInstance.OnLobbyMessage(lobbyId, userId, array);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005D44 File Offset: 0x00003F44
		[MonoPInvokeCallback]
		private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnSpeaking != null)
			{
				discord.LobbyManagerInstance.OnSpeaking(lobbyId, userId, speaking);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005D88 File Offset: 0x00003F88
		[MonoPInvokeCallback]
		private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.LobbyManagerInstance.OnNetworkMessage != null)
			{
				byte[] array = new byte[dataLen];
				Marshal.Copy(dataPtr, array, 0, dataLen);
				discord.LobbyManagerInstance.OnNetworkMessage(lobbyId, userId, channelId, array);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			int num = this.MemberCount(lobbyID);
			List<User> list = new List<User>();
			for (int i = 0; i < num; i++)
			{
				list.Add(this.GetMemberUser(lobbyID, this.GetMemberUserId(lobbyID, i)));
			}
			return list;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005E1D File Offset: 0x0000401D
		public void SendLobbyMessage(long lobbyID, string data, LobbyManager.SendLobbyMessageHandler handler)
		{
			this.SendLobbyMessage(lobbyID, Encoding.UTF8.GetBytes(data), handler);
		}

		// Token: 0x04000121 RID: 289
		private IntPtr MethodsPtr;

		// Token: 0x04000122 RID: 290
		private object MethodsStructure;

		// Token: 0x02000064 RID: 100
		internal struct FFIEvents
		{
			// Token: 0x040001A4 RID: 420
			internal LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate;

			// Token: 0x040001A5 RID: 421
			internal LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete;

			// Token: 0x040001A6 RID: 422
			internal LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect;

			// Token: 0x040001A7 RID: 423
			internal LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate;

			// Token: 0x040001A8 RID: 424
			internal LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect;

			// Token: 0x040001A9 RID: 425
			internal LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage;

			// Token: 0x040001AA RID: 426
			internal LobbyManager.FFIEvents.SpeakingHandler OnSpeaking;

			// Token: 0x040001AB RID: 427
			internal LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage;

			// Token: 0x020000DE RID: 222
			// (Invoke) Token: 0x06000337 RID: 823
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

			// Token: 0x020000DF RID: 223
			// (Invoke) Token: 0x0600033B RID: 827
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

			// Token: 0x020000E0 RID: 224
			// (Invoke) Token: 0x0600033F RID: 831
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x020000E1 RID: 225
			// (Invoke) Token: 0x06000343 RID: 835
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x020000E2 RID: 226
			// (Invoke) Token: 0x06000347 RID: 839
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

			// Token: 0x020000E3 RID: 227
			// (Invoke) Token: 0x0600034B RID: 843
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

			// Token: 0x020000E4 RID: 228
			// (Invoke) Token: 0x0600034F RID: 847
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

			// Token: 0x020000E5 RID: 229
			// (Invoke) Token: 0x06000353 RID: 851
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);
		}

		// Token: 0x02000065 RID: 101
		internal struct FFIMethods
		{
			// Token: 0x040001AC RID: 428
			internal LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod GetLobbyCreateTransaction;

			// Token: 0x040001AD RID: 429
			internal LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction;

			// Token: 0x040001AE RID: 430
			internal LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod GetMemberUpdateTransaction;

			// Token: 0x040001AF RID: 431
			internal LobbyManager.FFIMethods.CreateLobbyMethod CreateLobby;

			// Token: 0x040001B0 RID: 432
			internal LobbyManager.FFIMethods.UpdateLobbyMethod UpdateLobby;

			// Token: 0x040001B1 RID: 433
			internal LobbyManager.FFIMethods.DeleteLobbyMethod DeleteLobby;

			// Token: 0x040001B2 RID: 434
			internal LobbyManager.FFIMethods.ConnectLobbyMethod ConnectLobby;

			// Token: 0x040001B3 RID: 435
			internal LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret;

			// Token: 0x040001B4 RID: 436
			internal LobbyManager.FFIMethods.DisconnectLobbyMethod DisconnectLobby;

			// Token: 0x040001B5 RID: 437
			internal LobbyManager.FFIMethods.GetLobbyMethod GetLobby;

			// Token: 0x040001B6 RID: 438
			internal LobbyManager.FFIMethods.GetLobbyActivitySecretMethod GetLobbyActivitySecret;

			// Token: 0x040001B7 RID: 439
			internal LobbyManager.FFIMethods.GetLobbyMetadataValueMethod GetLobbyMetadataValue;

			// Token: 0x040001B8 RID: 440
			internal LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod GetLobbyMetadataKey;

			// Token: 0x040001B9 RID: 441
			internal LobbyManager.FFIMethods.LobbyMetadataCountMethod LobbyMetadataCount;

			// Token: 0x040001BA RID: 442
			internal LobbyManager.FFIMethods.MemberCountMethod MemberCount;

			// Token: 0x040001BB RID: 443
			internal LobbyManager.FFIMethods.GetMemberUserIdMethod GetMemberUserId;

			// Token: 0x040001BC RID: 444
			internal LobbyManager.FFIMethods.GetMemberUserMethod GetMemberUser;

			// Token: 0x040001BD RID: 445
			internal LobbyManager.FFIMethods.GetMemberMetadataValueMethod GetMemberMetadataValue;

			// Token: 0x040001BE RID: 446
			internal LobbyManager.FFIMethods.GetMemberMetadataKeyMethod GetMemberMetadataKey;

			// Token: 0x040001BF RID: 447
			internal LobbyManager.FFIMethods.MemberMetadataCountMethod MemberMetadataCount;

			// Token: 0x040001C0 RID: 448
			internal LobbyManager.FFIMethods.UpdateMemberMethod UpdateMember;

			// Token: 0x040001C1 RID: 449
			internal LobbyManager.FFIMethods.SendLobbyMessageMethod SendLobbyMessage;

			// Token: 0x040001C2 RID: 450
			internal LobbyManager.FFIMethods.GetSearchQueryMethod GetSearchQuery;

			// Token: 0x040001C3 RID: 451
			internal LobbyManager.FFIMethods.SearchMethod Search;

			// Token: 0x040001C4 RID: 452
			internal LobbyManager.FFIMethods.LobbyCountMethod LobbyCount;

			// Token: 0x040001C5 RID: 453
			internal LobbyManager.FFIMethods.GetLobbyIdMethod GetLobbyId;

			// Token: 0x040001C6 RID: 454
			internal LobbyManager.FFIMethods.ConnectVoiceMethod ConnectVoice;

			// Token: 0x040001C7 RID: 455
			internal LobbyManager.FFIMethods.DisconnectVoiceMethod DisconnectVoice;

			// Token: 0x040001C8 RID: 456
			internal LobbyManager.FFIMethods.ConnectNetworkMethod ConnectNetwork;

			// Token: 0x040001C9 RID: 457
			internal LobbyManager.FFIMethods.DisconnectNetworkMethod DisconnectNetwork;

			// Token: 0x040001CA RID: 458
			internal LobbyManager.FFIMethods.FlushNetworkMethod FlushNetwork;

			// Token: 0x040001CB RID: 459
			internal LobbyManager.FFIMethods.OpenNetworkChannelMethod OpenNetworkChannel;

			// Token: 0x040001CC RID: 460
			internal LobbyManager.FFIMethods.SendNetworkMessageMethod SendNetworkMessage;

			// Token: 0x020000E6 RID: 230
			// (Invoke) Token: 0x06000357 RID: 855
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyCreateTransactionMethod(IntPtr methodsPtr, ref IntPtr transaction);

			// Token: 0x020000E7 RID: 231
			// (Invoke) Token: 0x0600035B RID: 859
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction);

			// Token: 0x020000E8 RID: 232
			// (Invoke) Token: 0x0600035F RID: 863
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction);

			// Token: 0x020000E9 RID: 233
			// (Invoke) Token: 0x06000363 RID: 867
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CreateLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x020000EA RID: 234
			// (Invoke) Token: 0x06000367 RID: 871
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CreateLobbyMethod(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback);

			// Token: 0x020000EB RID: 235
			// (Invoke) Token: 0x0600036B RID: 875
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x020000EC RID: 236
			// (Invoke) Token: 0x0600036F RID: 879
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback);

			// Token: 0x020000ED RID: 237
			// (Invoke) Token: 0x06000373 RID: 883
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DeleteLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x020000EE RID: 238
			// (Invoke) Token: 0x06000377 RID: 887
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DeleteLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback);

			// Token: 0x020000EF RID: 239
			// (Invoke) Token: 0x0600037B RID: 891
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x020000F0 RID: 240
			// (Invoke) Token: 0x0600037F RID: 895
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyMethod(IntPtr methodsPtr, long lobbyId, [MarshalAs(UnmanagedType.LPStr)] string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback);

			// Token: 0x020000F1 RID: 241
			// (Invoke) Token: 0x06000383 RID: 899
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyWithActivitySecretCallback(IntPtr ptr, Result result, ref Lobby lobby);

			// Token: 0x020000F2 RID: 242
			// (Invoke) Token: 0x06000387 RID: 903
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyWithActivitySecretMethod(IntPtr methodsPtr, [MarshalAs(UnmanagedType.LPStr)] string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback);

			// Token: 0x020000F3 RID: 243
			// (Invoke) Token: 0x0600038B RID: 907
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectLobbyCallback(IntPtr ptr, Result result);

			// Token: 0x020000F4 RID: 244
			// (Invoke) Token: 0x0600038F RID: 911
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback);

			// Token: 0x020000F5 RID: 245
			// (Invoke) Token: 0x06000393 RID: 915
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMethod(IntPtr methodsPtr, long lobbyId, ref Lobby lobby);

			// Token: 0x020000F6 RID: 246
			// (Invoke) Token: 0x06000397 RID: 919
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyActivitySecretMethod(IntPtr methodsPtr, long lobbyId, StringBuilder secret);

			// Token: 0x020000F7 RID: 247
			// (Invoke) Token: 0x0600039B RID: 923
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMetadataValueMethod(IntPtr methodsPtr, long lobbyId, [MarshalAs(UnmanagedType.LPStr)] string key, StringBuilder value);

			// Token: 0x020000F8 RID: 248
			// (Invoke) Token: 0x0600039F RID: 927
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key);

			// Token: 0x020000F9 RID: 249
			// (Invoke) Token: 0x060003A3 RID: 931
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result LobbyMetadataCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			// Token: 0x020000FA RID: 250
			// (Invoke) Token: 0x060003A7 RID: 935
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result MemberCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			// Token: 0x020000FB RID: 251
			// (Invoke) Token: 0x060003AB RID: 939
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUserIdMethod(IntPtr methodsPtr, long lobbyId, int index, ref long userId);

			// Token: 0x020000FC RID: 252
			// (Invoke) Token: 0x060003AF RID: 943
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUserMethod(IntPtr methodsPtr, long lobbyId, long userId, ref User user);

			// Token: 0x020000FD RID: 253
			// (Invoke) Token: 0x060003B3 RID: 947
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberMetadataValueMethod(IntPtr methodsPtr, long lobbyId, long userId, [MarshalAs(UnmanagedType.LPStr)] string key, StringBuilder value);

			// Token: 0x020000FE RID: 254
			// (Invoke) Token: 0x060003B7 RID: 951
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key);

			// Token: 0x020000FF RID: 255
			// (Invoke) Token: 0x060003BB RID: 955
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result MemberMetadataCountMethod(IntPtr methodsPtr, long lobbyId, long userId, ref int count);

			// Token: 0x02000100 RID: 256
			// (Invoke) Token: 0x060003BF RID: 959
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateMemberCallback(IntPtr ptr, Result result);

			// Token: 0x02000101 RID: 257
			// (Invoke) Token: 0x060003C3 RID: 963
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateMemberMethod(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback);

			// Token: 0x02000102 RID: 258
			// (Invoke) Token: 0x060003C7 RID: 967
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendLobbyMessageCallback(IntPtr ptr, Result result);

			// Token: 0x02000103 RID: 259
			// (Invoke) Token: 0x060003CB RID: 971
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendLobbyMessageMethod(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback);

			// Token: 0x02000104 RID: 260
			// (Invoke) Token: 0x060003CF RID: 975
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSearchQueryMethod(IntPtr methodsPtr, ref IntPtr query);

			// Token: 0x02000105 RID: 261
			// (Invoke) Token: 0x060003D3 RID: 979
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SearchCallback(IntPtr ptr, Result result);

			// Token: 0x02000106 RID: 262
			// (Invoke) Token: 0x060003D7 RID: 983
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SearchMethod(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback);

			// Token: 0x02000107 RID: 263
			// (Invoke) Token: 0x060003DB RID: 987
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyCountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x02000108 RID: 264
			// (Invoke) Token: 0x060003DF RID: 991
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyIdMethod(IntPtr methodsPtr, int index, ref long lobbyId);

			// Token: 0x02000109 RID: 265
			// (Invoke) Token: 0x060003E3 RID: 995
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectVoiceCallback(IntPtr ptr, Result result);

			// Token: 0x0200010A RID: 266
			// (Invoke) Token: 0x060003E7 RID: 999
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback);

			// Token: 0x0200010B RID: 267
			// (Invoke) Token: 0x060003EB RID: 1003
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectVoiceCallback(IntPtr ptr, Result result);

			// Token: 0x0200010C RID: 268
			// (Invoke) Token: 0x060003EF RID: 1007
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback);

			// Token: 0x0200010D RID: 269
			// (Invoke) Token: 0x060003F3 RID: 1011
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ConnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			// Token: 0x0200010E RID: 270
			// (Invoke) Token: 0x060003F7 RID: 1015
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DisconnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			// Token: 0x0200010F RID: 271
			// (Invoke) Token: 0x060003FB RID: 1019
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FlushNetworkMethod(IntPtr methodsPtr);

			// Token: 0x02000110 RID: 272
			// (Invoke) Token: 0x060003FF RID: 1023
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenNetworkChannelMethod(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable);

			// Token: 0x02000111 RID: 273
			// (Invoke) Token: 0x06000403 RID: 1027
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SendNetworkMessageMethod(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen);
		}

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000187 RID: 391
		public delegate void CreateLobbyHandler(Result result, ref Lobby lobby);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x0600018B RID: 395
		public delegate void UpdateLobbyHandler(Result result);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x0600018F RID: 399
		public delegate void DeleteLobbyHandler(Result result);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000193 RID: 403
		public delegate void ConnectLobbyHandler(Result result, ref Lobby lobby);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000197 RID: 407
		public delegate void ConnectLobbyWithActivitySecretHandler(Result result, ref Lobby lobby);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600019B RID: 411
		public delegate void DisconnectLobbyHandler(Result result);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x0600019F RID: 415
		public delegate void UpdateMemberHandler(Result result);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001A3 RID: 419
		public delegate void SendLobbyMessageHandler(Result result);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001A7 RID: 423
		public delegate void SearchHandler(Result result);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001AB RID: 427
		public delegate void ConnectVoiceHandler(Result result);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001AF RID: 431
		public delegate void DisconnectVoiceHandler(Result result);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001B3 RID: 435
		public delegate void LobbyUpdateHandler(long lobbyId);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001B7 RID: 439
		public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001BB RID: 443
		public delegate void MemberConnectHandler(long lobbyId, long userId);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001BF RID: 447
		public delegate void MemberUpdateHandler(long lobbyId, long userId);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001C3 RID: 451
		public delegate void MemberDisconnectHandler(long lobbyId, long userId);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001C7 RID: 455
		public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001CB RID: 459
		public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060001CF RID: 463
		public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);
	}
}
