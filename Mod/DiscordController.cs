using Discord;
using System.Collections.Generic;
using UnityEngine;

public class DiscordController : MonoBehaviour
{
	private delegate void PacketHandler(Packet _packet, long userId);

	public static DiscordController instance;

	public Discord.Discord discord;

	private ActivityManager activityManager;

	private NetworkManager networkManager;

	public LobbyManager lobbyManager;

	public UserManager userManager;

	public bool sceneLoaded;

	public bool pendingCallbacks;

	private long lobbyId;

	private long userId;

	private int memberId;

	private bool lobbyOwner;

	private Packet receivedData;

	private static Dictionary<int, PacketHandler> packetHandlers;

	private void Start()
	{
		discord = new Discord.Discord(814993856163479584L, 0uL);
		activityManager = discord.GetActivityManager();
		Activity activity = default(Activity);
		activity.State = "Still Testing";
		activity.Details = "Bigger Test";
		Activity activity2 = activity;
		activityManager.UpdateActivity(activity2, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				UnityEngine.Debug.Log("Everything is fine!");
			}
		});
		lobbyManager = discord.GetLobbyManager();
		userManager = discord.GetUserManager();
		userManager.OnCurrentUserUpdate += delegate
		{
			User currentUser = userManager.GetCurrentUser();
			userId = currentUser.Id;
		};
		ReceiveNetworkMessage();
		MemberDisconnected();
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	private void Update()
	{
		if (sceneLoaded)
		{
			discord.RunCallbacks();
		}
	}

	private void LateUpdate()
	{
		lobbyManager.FlushNetwork();
	}

	private void OnApplicationQuit()
	{
		DisconnectNetwork2();
		while (pendingCallbacks)
		{
			discord.RunCallbacks();
		}
		pendingCallbacks = true;
		activityManager.ClearActivity(delegate(Result result)
		{
			if (result == Result.Ok)
			{
				pendingCallbacks = false;
			}
			else
			{
				pendingCallbacks = false;
			}
		});
		while (pendingCallbacks)
		{
			discord.RunCallbacks();
		}
	}

	public void CreateLobby(string lobbyName)
	{
		LobbyTransaction lobbyCreateTransaction = lobbyManager.GetLobbyCreateTransaction();
		lobbyCreateTransaction.SetCapacity(10u);
		lobbyCreateTransaction.SetType(LobbyType.Public);
		lobbyCreateTransaction.SetMetadata("name", lobbyName);
		lobbyCreateTransaction.SetMetadata("game", "v2unity");
		lobbyCreateTransaction.SetMetadata("level", "DEBUG2");
		lobbyManager.CreateLobby(lobbyCreateTransaction, delegate(Result result, ref Lobby lobby)
		{
			UnityEngine.Debug.Log("lobby " + lobby.Id.ToString() + " created with secret " + lobby.Secret);
			LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobby.Id);
			lobbyUpdateTransaction.SetCapacity(9u);
			lobbyId = lobby.Id;
			lobbyOwner = true;
			lobbyManager.UpdateLobby(lobby.Id, lobbyUpdateTransaction, delegate
			{
				UnityEngine.Debug.Log("lobby " + lobbyId.ToString() + " updated");
				InitNetworking(lobbyId);
			});
		});
	}

	public void SearchLobbies()
	{
		LobbySearchQuery searchQuery = lobbyManager.GetSearchQuery();
		searchQuery.Filter("metadata.game", LobbySearchComparison.Equal, LobbySearchCast.String, "v2unity");
		searchQuery.Filter("metadata.level", LobbySearchComparison.Equal, LobbySearchCast.String, "DEBUG2");
		searchQuery.Distance(LobbySearchDistance.Global);
		lobbyManager.Search(searchQuery, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				List<Lobby> list = new List<Lobby>();
				for (int i = 0; i < lobbyManager.LobbyCount(); i++)
				{
					long num = lobbyManager.GetLobbyId(i);
					Lobby lobby = lobbyManager.GetLobby(num);
					list.Add(lobby);
				}
				Demo.instance._GetLobbies(list);
			}
		});
	}

	public void SetLobbyType(LobbyType lobbyType)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.SetType(lobbyType);
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby type updated!");
			}
		});
	}

	public void SetLobbyOwner(long userId)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.SetOwner(userId);
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby owner updated!");
			}
		});
	}

	public void SetLobbyCapacity(uint capacity)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.SetCapacity(capacity);
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby capacity updated!");
			}
		});
	}

	public void SetLobbyMetadata(string key, string value)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.SetMetadata(key, value);
		pendingCallbacks = true;
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby metadata updated!");
				pendingCallbacks = false;
			}
		});
	}

	public string GetLobbyMetadataValue(long lobbyId, string key)
	{
		return lobbyManager.GetLobbyMetadataValue(lobbyId, key);
	}

	public void DeleteMetadata(string key)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.DeleteMetadata(key);
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby metadata updated!");
			}
		});
	}

	public void SetLobbyLocked(bool locked)
	{
		LobbyTransaction lobbyUpdateTransaction = lobbyManager.GetLobbyUpdateTransaction(lobbyId);
		lobbyUpdateTransaction.SetLocked(locked);
		lobbyManager.UpdateLobby(lobbyId, lobbyUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby type updated!");
			}
		});
	}

	public void SetMemberMetadata(long userId, string key, string value)
	{
		LobbyMemberTransaction memberUpdateTransaction = lobbyManager.GetMemberUpdateTransaction(lobbyId, userId);
		memberUpdateTransaction.SetMetadata(key, value);
		lobbyManager.UpdateMember(lobbyId, userId, memberUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Member metadata updated!");
			}
		});
	}

	public void DeleteMemberMetadata(long userId, string key)
	{
		LobbyMemberTransaction memberUpdateTransaction = lobbyManager.GetMemberUpdateTransaction(lobbyId, userId);
		memberUpdateTransaction.DeleteMetadata(key);
		lobbyManager.UpdateMember(lobbyId, userId, memberUpdateTransaction, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Member metadata updated!");
			}
		});
	}

	public void DeleteLobby()
	{
		lobbyManager.DeleteLobby(lobbyId, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Lobby deleted!");
				pendingCallbacks = false;
			}
		});
	}

	public void ConnectLobby(long id, string password)
	{
		lobbyManager.ConnectLobby(id, password, delegate(Result result, ref Lobby lobby)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Connected to lobby " + lobby.Id.ToString() + "!");
			}
		});
	}

	public void ConnectNetwork(long id, string password)
	{
		lobbyManager.ConnectLobby(id, password, delegate(Result result, ref Lobby lobby)
		{
			lobbyManager.ConnectNetwork(lobby.Id);
			lobbyManager.OpenNetworkChannel(lobby.Id, 0, reliable: true);
			lobbyManager.OpenNetworkChannel(lobby.Id, 1, reliable: false);
		});
	}

	public void DisconnectLobby(long id)
	{
		lobbyManager.DisconnectLobby(id, delegate(Result result)
		{
			if (result == Result.Ok)
			{
				UnityEngine.Debug.Log("Left lobby!");
			}
		});
	}

	public void DisconnectNetwork(long id)
	{
		lobbyManager.DisconnectNetwork(id);
	}

	public Lobby GetLobby(long id)
	{
		LobbySearchQuery searchQuery = lobbyManager.GetSearchQuery();
		Lobby lobby = lobbyManager.GetLobby(id);
		lobbyManager.Search(searchQuery, delegate(Result res)
		{
			if (res == Result.Ok)
			{
				lobby = lobbyManager.GetLobby(id);
			}
		});
		return lobby;
	}

	public User GetMemberUser(long userId)
	{
		int num = lobbyManager.MemberCount(lobbyId);
		User memberUser = lobbyManager.GetMemberUser(lobbyId, 0L);
		if (num > 0)
		{
			memberUser = lobbyManager.GetMemberUser(lobbyId, userId);
			UnityEngine.Debug.Log("Got user " + memberUser.Id.ToString());
			return memberUser;
		}
		return memberUser;
	}

	public void SendNetworkMessage(byte channelId, byte[] data)
	{
		for (int i = 0; i < lobbyManager.MemberCount(lobbyId); i++)
		{
			long memberUserId = lobbyManager.GetMemberUserId(lobbyId, i);
			if (memberUserId != userManager.GetCurrentUser().Id)
			{
				lobbyManager.SendNetworkMessage(lobbyId, memberUserId, channelId, data);
			}
		}
	}

	public void SendNetworkMessageToUser(long userId, byte channelId, byte[] data)
	{
		lobbyManager.SendNetworkMessage(lobbyId, userId, channelId, data);
	}

	public void InitNetworking(long lobbyId)
	{
		lobbyManager.ConnectNetwork(lobbyId);
		this.lobbyId = lobbyId;
		receivedData = new Packet();
		InitializeClientData();
		memberId = lobbyManager.MemberCount(lobbyId) - 1;
		lobbyManager.OpenNetworkChannel(lobbyId, 0, reliable: true);
		lobbyManager.OpenNetworkChannel(lobbyId, 1, reliable: false);
	}

	public void DisconnectNetwork2()
	{
		if (lobbyId != 0L)
		{
			pendingCallbacks = true;
			Demo.instance.LeaveLobby(lobbyId);
			lobbyManager.DisconnectNetwork(lobbyId);
			lobbyManager.DisconnectLobby(lobbyId, delegate(Result result)
			{
				if (result == Result.Ok)
				{
					UnityEngine.Debug.Log("Left lobby!");
					pendingCallbacks = false;
				}
			});
		}
		if (lobbyOwner)
		{
			pendingCallbacks = true;
			DeleteLobby();
		}
		lobbyId = 0L;
		memberId = 0;
		lobbyOwner = false;
	}

	public void ReceiveNetworkMessage()
	{
		lobbyManager.OnNetworkMessage += delegate(long lobbyId, long userId, byte channelId, byte[] data)
		{
			switch (channelId)
			{
			case 0:
				receivedData.Reset(HandleTCPData(data, userId));
				break;
			case 1:
				if (data.Length >= 4)
				{
					HandleUDPData(data, userId);
				}
				break;
			}
		};
	}

	public void MemberDisconnected()
	{
		lobbyManager.OnMemberDisconnect += delegate(long lobbyId, long userId)
		{
			if (GameManager.instance.inDebug)
			{
				Demo.instance.MemberLeft(userId);
			}
			else
			{
				UnityEngine.Object.Destroy(GameManager.instance.networkMembers[userId].unit);
				GameManager.instance.FUN_309A0(GameManager.instance.networkMembers[userId]);
				GameManager.instance.networkMembers.Remove(userId);
				GameManager.instance.networkIds.Remove(userId);
			}
		};
	}

	public static int GetMemberId()
	{
		return instance.memberId;
	}

	public static long GetUserId()
	{
		return instance.userId;
	}

	public static bool IsOwner()
	{
		return instance.lobbyOwner;
	}

	private bool HandleTCPData(byte[] _data, long userId)
	{
		int num = 0;
		receivedData.SetBytes(_data);
		if (receivedData.UnreadLength() >= 4)
		{
			num = receivedData.ReadInt();
			if (num <= 0)
			{
				return true;
			}
		}
		while (num > 0 && num <= receivedData.UnreadLength())
		{
			using (Packet packet = new Packet(receivedData.ReadBytes(num)))
			{
				int key = packet.ReadInt();
				packetHandlers[key](packet, userId);
			}
			num = 0;
			if (receivedData.UnreadLength() >= 4)
			{
				num = receivedData.ReadInt();
				if (num <= 0)
				{
					return true;
				}
			}
		}
		if (num <= 1)
		{
			return true;
		}
		return false;
	}

	private void HandleUDPData(byte[] _data, long userId)
	{
		using (Packet packet = new Packet(_data))
		{
			int length = packet.ReadInt();
			_data = packet.ReadBytes(length);
		}
		using (Packet packet2 = new Packet(_data))
		{
			int key = packet2.ReadInt();
			packetHandlers[key](packet2, userId);
		}
	}

	private void InitializeClientData()
	{
		packetHandlers = new Dictionary<int, PacketHandler>
		{
			{
				1,
				ClientHandle.Joined
			},
			{
				2,
				ClientHandle.Welcome
			},
			{
				3,
				ClientHandle.Ready
			},
			{
				4,
				ClientHandle.NotReady
			},
			{
				5,
				ClientHandle.Load
			},
			{
				6,
				ClientHandle.Mode
			},
			{
				7,
				ClientHandle.Map
			},
			{
				8,
				ClientHandle.Damage
			},
			{
				9,
				ClientHandle.Difficulty
			},
			{
				10,
				ClientHandle.Lives
			},
			{
				11,
				ClientHandle.Spawn
			},
			{
				12,
				ClientHandle.Transform
			},
			{
				13,
				ClientHandle.Physics
			},
			{
				14,
				ClientHandle.Control
			},
			{
				15,
				ClientHandle.Status
			},
			{
				16,
				ClientHandle.Pickup
			},
			{
				17,
				ClientHandle.Weapon
			},
			{
				18,
				ClientHandle.Combo
			},
			{
				19,
				ClientHandle.TrailerTransform
			},
			{
				20,
				ClientHandle.TrailerDetach
			},
			{
				21,
				ClientHandle.Destroyed
			},
			{
				22,
				ClientHandle.Wrecked
			},
			{
				23,
				ClientHandle.Totaled
			},
			{
				24,
				ClientHandle.DropWeapon
			},
			{
				25,
				ClientHandle.SpawnPickup
			},
			{
				26,
				ClientHandle.ObjectDestroyed
			},
			{
				27,
				ClientHandle.RandomNumber
			},
			{
				28,
				ClientHandle.SpawnAI
			},
			{
				29,
				ClientHandle.TransformAI
			},
			{
				30,
				ClientHandle.PhysicsAI
			},
			{
				31,
				ClientHandle.ControlAI
			},
			{
				32,
				ClientHandle.StatusAI
			},
			{
				33,
				ClientHandle.PickupAI
			},
			{
				34,
				ClientHandle.WeaponAI
			},
			{
				35,
				ClientHandle.ComboAI
			},
			{
				36,
				ClientHandle.TrailerTransformAI
			},
			{
				37,
				ClientHandle.TrailerDetachAI
			},
			{
				38,
				ClientHandle.DestroyedAI
			},
			{
				39,
				ClientHandle.WreckedAI
			},
			{
				40,
				ClientHandle.TotaledAI
			},
			{
				41,
				ClientHandle.DropWeaponAI
			},
			{
				42,
				ClientHandle.Pause
			}
		};
		UnityEngine.Debug.Log("Initialized packets.");
	}
}
