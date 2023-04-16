using System;
using System.Collections.Generic;
using Discord;
using UnityEngine;

// Token: 0x02000158 RID: 344
public class DiscordController : MonoBehaviour
{
	// Token: 0x06000739 RID: 1849 RVA: 0x000542F4 File Offset: 0x000524F4
	private void Start()
	{
		discord = new Discord.Discord(814993856163479584L, 0uL);
		this.activityManager = this.discord.GetActivityManager();
		Activity activity = new Activity
		{
			State = "Still Testing",
			Details = "Bigger Test"
		};
		this.activityManager.UpdateActivity(activity, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				Debug.Log("Everything is fine!");
			}
		});
		this.lobbyManager = this.discord.GetLobbyManager();
		this.userManager = this.discord.GetUserManager();
		this.userManager.OnCurrentUserUpdate += delegate
		{
			User currentUser = this.userManager.GetCurrentUser();
			this.userId = currentUser.Id;
		};
		this.ReceiveNetworkMessage();
		this.MemberDisconnected();
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x000097A4 File Offset: 0x000079A4
	private void Awake()
	{
		if (DiscordController.instance == null)
		{
			DiscordController.instance = this;
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000097B9 File Offset: 0x000079B9
	private void Update()
	{
		if (this.sceneLoaded)
		{
			this.discord.RunCallbacks();
		}
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x000097CE File Offset: 0x000079CE
	private void LateUpdate()
	{
		this.lobbyManager.FlushNetwork();
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x000543BC File Offset: 0x000525BC
	private void OnApplicationQuit()
	{
		this.DisconnectNetwork2();
		while (this.pendingCallbacks)
		{
			this.discord.RunCallbacks();
		}
		this.pendingCallbacks = true;
		this.activityManager.ClearActivity(delegate(Result result)
		{
			if (result == Result.Ok)
			{
				this.pendingCallbacks = false;
				return;
			}
			this.pendingCallbacks = false;
		});
		while (this.pendingCallbacks)
		{
			this.discord.RunCallbacks();
		}
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00054418 File Offset: 0x00052618
	public void CreateLobby(string lobbyName)
	{
		LobbyTransaction lobbyCreateTransaction = this.lobbyManager.GetLobbyCreateTransaction();
		lobbyCreateTransaction.SetCapacity(10U);
		lobbyCreateTransaction.SetType(LobbyType.Public);
		lobbyCreateTransaction.SetMetadata("name", lobbyName);
		lobbyCreateTransaction.SetMetadata("game", "v2unity");
		lobbyCreateTransaction.SetMetadata("level", "DEBUG2");
		this.lobbyManager.CreateLobby(lobbyCreateTransaction, delegate(Result result, ref Lobby lobby)
		{
			Debug.Log("lobby " + lobby.Id.ToString() + " created with secret " + lobby.Secret);
			LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(lobby.Id);
			lobbyUpdateTransaction.SetCapacity(9U);
			this.lobbyId = lobby.Id;
			this.lobbyOwner = true;
			this.lobbyManager.UpdateLobby(lobby.Id, lobbyUpdateTransaction, delegate(Result result)
			{
				Debug.Log("lobby " + this.lobbyId.ToString() + " updated");
				this.InitNetworking(this.lobbyId);
			});
		});
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x0005448C File Offset: 0x0005268C
	public void SearchLobbies()
	{
		LobbySearchQuery searchQuery = this.lobbyManager.GetSearchQuery();
		searchQuery.Filter("metadata.game", LobbySearchComparison.Equal, LobbySearchCast.String, "v2unity");
		searchQuery.Filter("metadata.level", LobbySearchComparison.Equal, LobbySearchCast.String, "DEBUG2");
		searchQuery.Distance(LobbySearchDistance.Global);
		this.lobbyManager.Search(searchQuery, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				List<Lobby> list = new List<Lobby>();
				for (int i = 0; i < this.lobbyManager.LobbyCount(); i++)
				{
					long num = this.lobbyManager.GetLobbyId(i);
					Lobby lobby = this.lobbyManager.GetLobby(num);
					list.Add(lobby);
				}
				Demo.instance._GetLobbies(list);
			}
		});
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x000544EC File Offset: 0x000526EC
	public void SetLobbyType(LobbyType lobbyType)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
		lobbyUpdateTransaction.SetType(lobbyType);
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby type updated!");
			}
		});
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00054544 File Offset: 0x00052744
	public void SetLobbyOwner(long userId)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
		lobbyUpdateTransaction.SetOwner(userId);
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby owner updated!");
			}
		});
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x0005459C File Offset: 0x0005279C
	public void SetLobbyCapacity(uint capacity)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
		lobbyUpdateTransaction.SetCapacity(capacity);
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby capacity updated!");
			}
		});
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x000545F4 File Offset: 0x000527F4
	public void SetLobbyMetadata(string key, string value)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
			lobbyUpdateTransaction.SetMetadata(key, value);
		this.pendingCallbacks = true;
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby metadata updated!");
				this.pendingCallbacks = false;
			}
		});
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x000097DB File Offset: 0x000079DB
	public string GetLobbyMetadataValue(long lobbyId, string key)
	{
		return this.lobbyManager.GetLobbyMetadataValue(lobbyId, key);
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00054644 File Offset: 0x00052844
	public void DeleteMetadata(string key)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
		lobbyUpdateTransaction.DeleteMetadata(key);
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby metadata updated!");
			}
		});
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0005469C File Offset: 0x0005289C
	public void SetLobbyLocked(bool locked)
	{
		LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
		lobbyUpdateTransaction.SetLocked(locked);
		this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby type updated!");
			}
		});
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x000546F4 File Offset: 0x000528F4
	public void SetMemberMetadata(long userId, string key, string value)
	{
		LobbyMemberTransaction memberUpdateTransaction = this.lobbyManager.GetMemberUpdateTransaction(this.lobbyId, userId);
		memberUpdateTransaction.SetMetadata(key, value);
		this.lobbyManager.UpdateMember(this.lobbyId, userId, memberUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Member metadata updated!");
			}
		});
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00054750 File Offset: 0x00052950
	public void DeleteMemberMetadata(long userId, string key)
	{
		LobbyMemberTransaction memberUpdateTransaction = this.lobbyManager.GetMemberUpdateTransaction(this.lobbyId, userId);
		memberUpdateTransaction.DeleteMetadata(key);
		this.lobbyManager.UpdateMember(this.lobbyId, userId, memberUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Member metadata updated!");
			}
		});
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x000097EA File Offset: 0x000079EA
	public void DeleteLobby()
	{
		this.lobbyManager.DeleteLobby(this.lobbyId, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Lobby deleted!");
				this.pendingCallbacks = false;
			}
		});
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00009809 File Offset: 0x00007A09
	public void ConnectLobby(long id, string password)
	{
		this.lobbyManager.ConnectLobby(id, password, delegate(Result result, ref Lobby lobby)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Connected to lobby " + lobby.Id.ToString() + "!");
			}
		});
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00009837 File Offset: 0x00007A37
	public void ConnectNetwork(long id, string password)
	{
		this.lobbyManager.ConnectLobby(id, password, delegate(Result result, ref Lobby lobby)
		{
			this.lobbyManager.ConnectNetwork(lobby.Id);
			this.lobbyManager.OpenNetworkChannel(lobby.Id, 0, true);
			this.lobbyManager.OpenNetworkChannel(lobby.Id, 1, false);
		});
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00009852 File Offset: 0x00007A52
	public void DisconnectLobby(long id)
	{
		this.lobbyManager.DisconnectLobby(id, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				Debug.Log("Left lobby!");
			}
		});
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x0000987F File Offset: 0x00007A7F
	public void DisconnectNetwork(long id)
	{
		this.lobbyManager.DisconnectNetwork(id);
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x000547AC File Offset: 0x000529AC
	public Lobby GetLobby(long id)
	{
		LobbySearchQuery searchQuery = this.lobbyManager.GetSearchQuery();
		Lobby lobby = this.lobbyManager.GetLobby(id);
		this.lobbyManager.Search(searchQuery, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				lobby = this.lobbyManager.GetLobby(id);
			}
		});
		return lobby;
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00054810 File Offset: 0x00052A10
	public User GetMemberUser(long userId)
	{
		int num = this.lobbyManager.MemberCount(this.lobbyId);
		User user = this.lobbyManager.GetMemberUser(this.lobbyId, 0L);
		if (num > 0)
		{
			user = this.lobbyManager.GetMemberUser(this.lobbyId, userId);
			Debug.Log("Got user " + user.Id.ToString());
			return user;
		}
		return user;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00054878 File Offset: 0x00052A78
	public void SendNetworkMessage(byte channelId, byte[] data)
	{
		for (int i = 0; i < this.lobbyManager.MemberCount(this.lobbyId); i++)
		{
			long memberUserId = this.lobbyManager.GetMemberUserId(this.lobbyId, i);
			if (memberUserId != this.userManager.GetCurrentUser().Id)
			{
				this.lobbyManager.SendNetworkMessage(this.lobbyId, memberUserId, channelId, data);
			}
		}
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x0000988D File Offset: 0x00007A8D
	public void SendNetworkMessageToUser(long userId, byte channelId, byte[] data)
	{
		this.lobbyManager.SendNetworkMessage(this.lobbyId, userId, channelId, data);
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x000548DC File Offset: 0x00052ADC
	public void InitNetworking(long lobbyId)
	{
		this.lobbyManager.ConnectNetwork(lobbyId);
		this.lobbyId = lobbyId;
		this.receivedData = new Packet();
		this.InitializeClientData();
		this.memberId = this.lobbyManager.MemberCount(lobbyId) - 1;
		this.lobbyManager.OpenNetworkChannel(lobbyId, 0, true);
		this.lobbyManager.OpenNetworkChannel(lobbyId, 1, false);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00054940 File Offset: 0x00052B40
	public void DisconnectNetwork2()
	{
		if (this.lobbyId != 0L)
		{
			this.pendingCallbacks = true;
			Demo.instance.LeaveLobby(this.lobbyId);
			this.lobbyManager.DisconnectNetwork(this.lobbyId);
			this.lobbyManager.DisconnectLobby(this.lobbyId, delegate(Result result)
			{
				if (result == Result.Ok)
				{
					Debug.Log("Left lobby!");
					this.pendingCallbacks = false;
				}
			});
		}
		if (this.lobbyOwner)
		{
			this.pendingCallbacks = true;
			this.DeleteLobby();
		}
		this.lobbyId = 0L;
		this.memberId = 0;
		this.lobbyOwner = false;
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x000098A3 File Offset: 0x00007AA3
	public void ReceiveNetworkMessage()
	{
		this.lobbyManager.OnNetworkMessage += delegate(long lobbyId, long userId, byte channelId, byte[] data)
		{
			if (channelId == 0)
			{
				this.receivedData.Reset(this.HandleTCPData(data, userId));
				return;
			}
			if (channelId == 1 && data.Length >= 4)
			{
				this.HandleUDPData(data, userId);
			}
		};
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x000098BC File Offset: 0x00007ABC
	public void MemberDisconnected()
	{
		this.lobbyManager.OnMemberDisconnect += delegate(long lobbyId, long userId)
		{
			if (GameManager.instance.inDebug)
			{
				Demo.instance.MemberLeft(userId);
				return;
			}
			UnityEngine.Object.Destroy(GameManager.instance.networkMembers[userId].unit);
			GameManager.instance.FUN_309A0(GameManager.instance.networkMembers[userId]);
			GameManager.instance.networkMembers.Remove(userId);
			GameManager.instance.networkIds.Remove(userId);
		};
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x000098E8 File Offset: 0x00007AE8
	public static int GetMemberId()
	{
		return DiscordController.instance.memberId;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x000098F4 File Offset: 0x00007AF4
	public static long GetUserId()
	{
		return DiscordController.instance.userId;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00009900 File Offset: 0x00007B00
	public static bool IsOwner()
	{
		return DiscordController.instance.lobbyOwner;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000549C8 File Offset: 0x00052BC8
	private bool HandleTCPData(byte[] _data, long userId)
	{
		int num = 0;
		this.receivedData.SetBytes(_data);
		if (this.receivedData.UnreadLength() >= 4)
		{
			num = this.receivedData.ReadInt(true);
			if (num <= 0)
			{
				return true;
			}
		}
		while (num > 0 && num <= this.receivedData.UnreadLength())
		{
			using (Packet packet = new Packet(this.receivedData.ReadBytes(num, true)))
			{
				int num2 = packet.ReadInt(true);
				DiscordController.packetHandlers[num2](packet, userId);
			}
			num = 0;
			if (this.receivedData.UnreadLength() >= 4)
			{
				num = this.receivedData.ReadInt(true);
				if (num <= 0)
				{
					return true;
				}
			}
		}
		return num <= 1;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00054A8C File Offset: 0x00052C8C
	private void HandleUDPData(byte[] _data, long userId)
	{
		using (Packet packet = new Packet(_data))
		{
			int num = packet.ReadInt(true);
			_data = packet.ReadBytes(num, true);
		}
		using (Packet packet2 = new Packet(_data))
		{
			int num2 = packet2.ReadInt(true);
			DiscordController.packetHandlers[num2](packet2, userId);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00054B08 File Offset: 0x00052D08
	private void InitializeClientData()
	{
		DiscordController.packetHandlers = new Dictionary<int, DiscordController.PacketHandler>
		{
			{
				1,
				new DiscordController.PacketHandler(ClientHandle.Joined)
			},
			{
				2,
				new DiscordController.PacketHandler(ClientHandle.Welcome)
			},
			{
				3,
				new DiscordController.PacketHandler(ClientHandle.Ready)
			},
			{
				4,
				new DiscordController.PacketHandler(ClientHandle.NotReady)
			},
			{
				5,
				new DiscordController.PacketHandler(ClientHandle.Load)
			},
			{
				6,
				new DiscordController.PacketHandler(ClientHandle.Mode)
			},
			{
				7,
				new DiscordController.PacketHandler(ClientHandle.Map)
			},
			{
				8,
				new DiscordController.PacketHandler(ClientHandle.Damage)
			},
			{
				9,
				new DiscordController.PacketHandler(ClientHandle.Difficulty)
			},
			{
				10,
				new DiscordController.PacketHandler(ClientHandle.Lives)
			},
			{
				11,
				new DiscordController.PacketHandler(ClientHandle.Spawn)
			},
			{
				12,
				new DiscordController.PacketHandler(ClientHandle.Transform)
			},
			{
				13,
				new DiscordController.PacketHandler(ClientHandle.Physics)
			},
			{
				14,
				new DiscordController.PacketHandler(ClientHandle.Control)
			},
			{
				15,
				new DiscordController.PacketHandler(ClientHandle.Status)
			},
			{
				16,
				new DiscordController.PacketHandler(ClientHandle.Pickup)
			},
			{
				17,
				new DiscordController.PacketHandler(ClientHandle.Weapon)
			},
			{
				18,
				new DiscordController.PacketHandler(ClientHandle.Combo)
			},
			{
				19,
				new DiscordController.PacketHandler(ClientHandle.TrailerTransform)
			},
			{
				20,
				new DiscordController.PacketHandler(ClientHandle.TrailerDetach)
			},
			{
				21,
				new DiscordController.PacketHandler(ClientHandle.Destroyed)
			},
			{
				22,
				new DiscordController.PacketHandler(ClientHandle.Wrecked)
			},
			{
				23,
				new DiscordController.PacketHandler(ClientHandle.Totaled)
			},
			{
				24,
				new DiscordController.PacketHandler(ClientHandle.DropWeapon)
			},
			{
				25,
				new DiscordController.PacketHandler(ClientHandle.SpawnPickup)
			},
			{
				26,
				new DiscordController.PacketHandler(ClientHandle.ObjectDestroyed)
			},
			{
				27,
				new DiscordController.PacketHandler(ClientHandle.RandomNumber)
			},
			{
				28,
				new DiscordController.PacketHandler(ClientHandle.SpawnAI)
			},
			{
				29,
				new DiscordController.PacketHandler(ClientHandle.TransformAI)
			},
			{
				30,
				new DiscordController.PacketHandler(ClientHandle.PhysicsAI)
			},
			{
				31,
				new DiscordController.PacketHandler(ClientHandle.ControlAI)
			},
			{
				32,
				new DiscordController.PacketHandler(ClientHandle.StatusAI)
			},
			{
				33,
				new DiscordController.PacketHandler(ClientHandle.PickupAI)
			},
			{
				34,
				new DiscordController.PacketHandler(ClientHandle.WeaponAI)
			},
			{
				35,
				new DiscordController.PacketHandler(ClientHandle.ComboAI)
			},
			{
				36,
				new DiscordController.PacketHandler(ClientHandle.TrailerTransformAI)
			},
			{
				37,
				new DiscordController.PacketHandler(ClientHandle.TrailerDetachAI)
			},
			{
				38,
				new DiscordController.PacketHandler(ClientHandle.DestroyedAI)
			},
			{
				39,
				new DiscordController.PacketHandler(ClientHandle.WreckedAI)
			},
			{
				40,
				new DiscordController.PacketHandler(ClientHandle.TotaledAI)
			},
			{
				41,
				new DiscordController.PacketHandler(ClientHandle.DropWeaponAI)
			},
			{
				42,
				new DiscordController.PacketHandler(ClientHandle.Pause)
			}
		};
		Debug.Log("Initialized packets.");
	}

	// Token: 0x040003F0 RID: 1008
	public static DiscordController instance;

	// Token: 0x040003F1 RID: 1009
	public Discord.Discord discord;

	// Token: 0x040003F2 RID: 1010
	private ActivityManager activityManager;

	// Token: 0x040003F3 RID: 1011
	private NetworkManager networkManager;

	// Token: 0x040003F4 RID: 1012
	public LobbyManager lobbyManager;

	// Token: 0x040003F5 RID: 1013
	public UserManager userManager;

	// Token: 0x040003F6 RID: 1014
	public bool sceneLoaded;

	// Token: 0x040003F7 RID: 1015
	public bool pendingCallbacks;

	// Token: 0x040003F8 RID: 1016
	private long lobbyId;

	// Token: 0x040003F9 RID: 1017
	private long userId;

	// Token: 0x040003FA RID: 1018
	private int memberId;

	// Token: 0x040003FB RID: 1019
	private bool lobbyOwner;

	// Token: 0x040003FC RID: 1020
	private Packet receivedData;

	// Token: 0x040003FD RID: 1021
	private static Dictionary<int, DiscordController.PacketHandler> packetHandlers;

	// Token: 0x02000159 RID: 345
	// (Invoke) Token: 0x06000768 RID: 1896
	private delegate void PacketHandler(Packet _packet, long userId);
}
