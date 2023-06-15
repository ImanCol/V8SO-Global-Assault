using System;
using System.Collections.Generic;
using Discord;
using UnityEngine;
using System.Reflection;
using V2UnityDiscordIntercept;

public class DiscordController : MonoBehaviour
{
    //private void Start()
    public static bool Start()
    {
#if UNITY_EDITOR
        Debug.Log("Ejecutando en el editor de Unity");
#else
        Debug.Log("Ejecutando en la Build");
#endif
        return false;
        //---------//
        //discord = new Discord.Discord(814993856163479584L, 0uL);
        //this.activityManager = this.discord.GetActivityManager();
        //Activity activity = new Activity
        //{
        //    State = "Vigilante 8: Globbal Assault",
        //    Details = "Make by ImanCol"
        //};
        //this.activityManager.UpdateActivity(activity, delegate (Result res)
        //{
        //    if (res == Result.Ok)
        //    {
        //        Debug.Log("Everything is fine!");
        //    }
        //});
        //this.lobbyManager = this.discord.GetLobbyManager();
        //this.userManager = this.discord.GetUserManager();
        //this.userManager.OnCurrentUserUpdate += delegate
        //{
        //    User currentUser = this.userManager.GetCurrentUser();
        //    this.userId = currentUser.Id;
        //};
        //this.ReceiveNetworkMessage();
        //this.MemberDisconnected();
    }

    private void Awake()
    {
        if (DiscordController.instance == null)
        {
            DiscordController.instance = this;
        }
    }

    //private void Update()
    public static bool Update()
    {
        return false;
        //---------//
        //if (this.sceneLoaded)
        //{
        //    if (GameManager.instance.online)
        //    {
        //        if (DiscordController.instance)
        //            this.discord.RunCallbacks();
        //    }
        //}
    }

    //private void LateUpdate()
    public static bool LateUpdate()
    {
        return false;
        //---------//
        //if (DiscordController.instance)
        //    this.lobbyManager.FlushNetwork();
    }

#if UNITY_EDITOR
#endif
    //private void OnApplicationQuit()
    public static void OnApplicationQuit(DiscordController __instance)
    {
        Debug.Log("DiscordController.OnApplicationQuit");
        DisconnectNetwork2();
        //return false;
        //---------//
        //this.DisconnectNetwork2();
        //while (this.pendingCallbacks)
        //{
        //	this.discord.RunCallbacks();
        //}
        //this.pendingCallbacks = true;
        //this.activityManager.ClearActivity(delegate(Result result)
        //{
        //	if (result == Result.Ok)
        //	{
        //		this.pendingCallbacks = false;
        //		return;
        //	}
        //	this.pendingCallbacks = false;
        //});
        //while (this.pendingCallbacks)
        //{
        //	this.discord.RunCallbacks();
        //}
    }

    StatsPanel statsPanel;

    //public void CreateLobby(string lobbyName)
    public static bool CreateLobby(string lobbyName)
    {
        Plugin.Username = lobbyName;
        VigServer vigServer = new VigServer(Plugin.Port);
        vigServer.CreateLobby();
        Plugin.Server = vigServer;
        Plugin.Client = new VigClient();
        Plugin.Client.ConnectToLobby("localhost", Plugin.Port);
        DiscordController.SetLobbyOwner(DiscordController.instance, Plugin.Client.Peer.UniqueIdentifier);
        return false;
        //---------//
        //Debug.Log("Create Lobby: " + lobbyName + "...");
        ////statsPanel.SpawnVehicle(1, 1); //Spawn Vehicle Host
        //LobbyTransaction lobbyCreateTransaction = this.lobbyManager.GetLobbyCreateTransaction();
        //lobbyCreateTransaction.SetCapacity(10U);
        //lobbyCreateTransaction.SetType(LobbyType.Public);
        //lobbyCreateTransaction.SetMetadata("name", lobbyName);
        //lobbyCreateTransaction.SetMetadata("game", "V8GO");
        //lobbyCreateTransaction.SetMetadata("level", "DEBUG2");
        //this.lobbyManager.CreateLobby(lobbyCreateTransaction, delegate (Result result, ref Lobby lobby)
        //{
        //    Debug.Log("lobby " + lobby.Id.ToString() + " created with secret " + lobby.Secret);
        //    LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(lobby.Id);
        //    lobbyUpdateTransaction.SetCapacity(9U);
        //    this.lobbyId = lobby.Id;
        //    this.lobbyOwner = true;
        //    this.lobbyManager.UpdateLobby(lobby.Id, lobbyUpdateTransaction, delegate (Result result)
        //    {
        //        Debug.Log("lobby " + this.lobbyId.ToString() + " updated");
        //        this.InitNetworking(this.lobbyId);
        //    });
        //});
    }

    //public void SearchLobbies()
    public static bool SearchLobbies()
    {
        return false;
        //---------//
        //LobbySearchQuery searchQuery = this.lobbyManager.GetSearchQuery();
        //searchQuery.Filter("metadata.game", LobbySearchComparison.Equal, LobbySearchCast.String, "V8SO");
        //searchQuery.Filter("metadata.level", LobbySearchComparison.Equal, LobbySearchCast.String, "DEBUG2");
        //searchQuery.Distance(LobbySearchDistance.Global);
        //this.lobbyManager.Search(searchQuery, delegate (Result res)
        //{
        //    if (res == Result.Ok)
        //    {
        //        List<Lobby> list = new List<Lobby>();
        //        for (int i = 0; i < this.lobbyManager.LobbyCount(); i++)
        //        {
        //            long num = this.lobbyManager.GetLobbyId(i);
        //            Lobby lobby = this.lobbyManager.GetLobby(num);
        //            list.Add(lobby);
        //        }
        //        Debug.Log("GetLobbies");
        //        Demo.instance._GetLobbies(list);
        //    }
        //});
    }

    public void SetLobbyType(LobbyType lobbyType)
    {
        LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        lobbyUpdateTransaction.SetType(lobbyType);
        this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Lobby type updated!");
            }
        });
    }

    //public void SetLobbyOwner(long userId)
    public static bool SetLobbyOwner(DiscordController __instance, long userId)
    {
        Debug.Log("Setting lobby owner");
        __instance.GetType().GetField("lobbyOwner", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(__instance, Plugin.Client.Peer.UniqueIdentifier == userId);
        return false;
        //---------//
        //LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        //lobbyUpdateTransaction.SetOwner(userId);
        //this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        //{
        //    if (result == Result.Ok)
        //    {
        //        Debug.Log("Lobby owner updated!");
        //    }
        //});
    }

    public void SetLobbyCapacity(uint capacity)
    {
        LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        lobbyUpdateTransaction.SetCapacity(capacity);
        this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Lobby capacity updated!");
            }
        });
    }

    //public void SetLobbyMetadata(string key, string value)
    public static bool SetLobbyMetadata(string key, string value)
    {
        Plugin.Client.SetLobbyMetadata(key, value);
        return false;
        //---------//
        //LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        //lobbyUpdateTransaction.SetMetadata(key, value);
        //this.pendingCallbacks = true;
        //this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        //{
        //    if (result == Result.Ok)
        //    {
        //        Debug.Log("Lobby metadata updated!");
        //        this.pendingCallbacks = false;
        //    }
        //});
    }

    public string GetLobbyMetadataValue(long lobbyId, string key)
    {
        return this.lobbyManager.GetLobbyMetadataValue(lobbyId, key);
    }

    public void DeleteMetadata(string key)
    {
        LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        lobbyUpdateTransaction.DeleteMetadata(key);
        this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Lobby metadata updated!");
            }
        });
    }

    public void SetLobbyLocked(bool locked)
    {
        LobbyTransaction lobbyUpdateTransaction = this.lobbyManager.GetLobbyUpdateTransaction(this.lobbyId);
        lobbyUpdateTransaction.SetLocked(locked);
        this.lobbyManager.UpdateLobby(this.lobbyId, lobbyUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Lobby type updated!");
            }
        });
    }

    public void SetMemberMetadata(long userId, string key, string value)
    {
        LobbyMemberTransaction memberUpdateTransaction = this.lobbyManager.GetMemberUpdateTransaction(this.lobbyId, userId);
        memberUpdateTransaction.SetMetadata(key, value);
        this.lobbyManager.UpdateMember(this.lobbyId, userId, memberUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Member metadata updated!");
            }
        });
    }

    public void DeleteMemberMetadata(long userId, string key)
    {
        LobbyMemberTransaction memberUpdateTransaction = this.lobbyManager.GetMemberUpdateTransaction(this.lobbyId, userId);
        memberUpdateTransaction.DeleteMetadata(key);
        this.lobbyManager.UpdateMember(this.lobbyId, userId, memberUpdateTransaction, delegate (Result result)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Member metadata updated!");
            }
        });
    }

    //public void DeleteLobby()
    public static bool DeleteLobby()
    {
        Debug.Log("Deleting lobby");
        Plugin.Server.DeleteLobby();
        return false;
        //---------//
        //this.lobbyManager.DeleteLobby(this.lobbyId, delegate (Result result)
        //{
        //    if (result == Result.Ok)
        //    {
        //        Debug.Log("Lobby deleted!");
        //        this.pendingCallbacks = false;
        //    }
        //});
    }

    public void ConnectLobby(long id, string password)
    {
        this.lobbyManager.ConnectLobby(id, password, delegate (Result result, ref Lobby lobby)
        {
            if (result == Result.Ok)
            {
                Debug.Log("Connected to lobby " + lobby.Id.ToString() + "!");
            }
        });
    }

    public void ConnectNetwork(long id, string password)
    {
        this.lobbyManager.ConnectLobby(id, password, delegate (Result result, ref Lobby lobby)
        {
            this.lobbyManager.ConnectNetwork(lobby.Id);
            this.lobbyManager.OpenNetworkChannel(lobby.Id, 0, true);
            this.lobbyManager.OpenNetworkChannel(lobby.Id, 1, false);
        });
    }

    //public void DisconnectLobby(long id)
    public static void DisconnectLobby()
    {
        Debug.Log("Disconnect Lobby...");
        //---------//
        //this.lobbyManager.DisconnectLobby(id, delegate (Result result)
        //{
        //    if (result == Result.Ok)
        //    {
        //        Debug.Log("Left lobby!");
        //    }
        //});
    }

    //public void DisconnectNetwork(long id)
    public static void DisconnectNetwork()
    {
        Debug.Log("DisconnectNetwork");
        //---------//
        //this.lobbyManager.DisconnectNetwork(id);
    }

    public Lobby GetLobby(long id)
    {
        LobbySearchQuery searchQuery = this.lobbyManager.GetSearchQuery();
        Lobby lobby = this.lobbyManager.GetLobby(id);
        this.lobbyManager.Search(searchQuery, delegate (Result res)
        {
            if (res == Result.Ok)
            {
                lobby = this.lobbyManager.GetLobby(id);
            }
        });
        return lobby;
    }

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

    //public void SendNetworkMessage(byte channelId, byte[] data)
    public static bool SendNetworkMessage(byte channelId, byte[] data)
    {
        Plugin.Client.SendNetworkMessage(channelId, data);
        return false;
        //---------//
        //for (int i = 0; i < this.lobbyManager.MemberCount(this.lobbyId); i++)
        //{
        //    long memberUserId = this.lobbyManager.GetMemberUserId(this.lobbyId, i);
        //    if (memberUserId != this.userManager.GetCurrentUser().Id)
        //    {
        //        this.lobbyManager.SendNetworkMessage(this.lobbyId, memberUserId, channelId, data);
        //    }
        //}
    }

    //public void SendNetworkMessageToUser(long userId, byte channelId, byte[] data)
    public static bool SendNetworkMessageToUser(long userId, byte channelId, byte[] data)
    {
        //Debug.Log("Identificador: " + Demo.instance.playerNames[userId]);
        Debug.Log("Sending network message to user: {0}" + userId);
        Plugin.Client.SendNetworkMessageToUser(userId, channelId, data);
        return false;
        //---------//
        //this.lobbyManager.SendNetworkMessage(this.lobbyId, userId, channelId, data);
    }

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

    //public void DisconnectNetwork2()
    public static bool DisconnectNetwork2()
    {
        Debug.Log("Disconnecting network");
        Demo.LeaveLobby(Demo.instance, 0L);
        Plugin.Client.Disconnect(Plugin.Username + " has disconnected.");
        if (DiscordController.IsOwner())
        {
            Plugin.Server.DeleteLobby();
        }
        return false;
        //---------//
        //if (this.lobbyId != 0L)
        //{
        //    this.pendingCallbacks = true;
        //    Demo.LeaveLobby(Demo.instance, this.lobbyId);
        //    this.lobbyManager.DisconnectNetwork(this.lobbyId);
        //    this.lobbyManager.DisconnectLobby(this.lobbyId, delegate (Result result)
        //    {
        //        if (result == Result.Ok)
        //        {
        //            Debug.Log("Left lobby!");
        //            this.pendingCallbacks = false;
        //        }
        //    });
        //}
        //if (this.lobbyOwner)
        //{
        //    this.pendingCallbacks = true;
        //    //this.DeleteLobby();
        //    DiscordController.DeleteLobby();
        //}
        //this.lobbyId = 0L;
        //this.memberId = 0;
        //this.lobbyOwner = false;
    }

    public void ReceiveNetworkMessage()
    {
        this.lobbyManager.OnNetworkMessage += delegate (long lobbyId, long userId, byte channelId, byte[] data)
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

    public void MemberDisconnected()
    {
        this.lobbyManager.OnMemberDisconnect += delegate (long lobbyId, long userId)
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

    //public static int GetMemberId()
    //public static bool GetMemberId(ref int __result)
    public static int GetMemberId()
    {
        int __result = Plugin.Client.MemberId;
        Debug.Log("Get member id: " + __result.ToString());
        return __result;
        //---------//
        //return DiscordController.instance.memberId;
    }

    //public static long GetUserId()
    //public static bool GetUserId(ref long __result)
    public static long GetUserId()
    {
        long __result = Plugin.Client.Peer.UniqueIdentifier;
        return __result;
        //---------//
        //return DiscordController.instance.userId;
    }

    public static bool IsOwner()
    {
        return DiscordController.instance.lobbyOwner;
    }

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

    private static Dictionary<int, DiscordController.PacketHandler> packetHandlers;

    private delegate void PacketHandler(Packet _packet, long userId);
}
