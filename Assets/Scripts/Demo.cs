using System;
using System.Collections.Generic;
using Discord;
using UnityEngine;
using UnityEngine.UI;
public class Demo : MonoBehaviour
{
    private void Awake()
    {
        if (Demo.instance == null)
        {
            Demo.instance = this;
        }
    }
    private void Start()
    {
        this.playerReady = new Dictionary<long, bool>();
        this.playerText = new Dictionary<long, Text>();
        this.playerNames = new Dictionary<long, string>();
        this.playerVehicles = new Dictionary<long, byte>();
        GameManager.instance.map = 1;
        GameManager.instance.playerSpawns = 1;
        discordController.sceneLoaded = true;
    }
    private void Update()
    {
    }
    public void InstantiateText(long userId)
    {
        Text component = UnityEngine.Object.Instantiate<GameObject>(this.playerTextPrefab).GetComponent<Text>();
        component.transform.SetParent(this.playerList, false);
        this.playerText.Add(userId, component);
        this.playerText[userId].text = this.playerNames[userId] + ": " + Demo.vehicleNames[(int)this.playerVehicles[userId]];

    }
    public void UpdatePlayerStatus(long userId)
    {
        if (this.playerText[userId] != null)
        {
            this.playerText[userId].text = this.playerNames[userId] + ": " + (this.playerReady[userId] ? (Demo.vehicleNames[(int)this.playerVehicles[userId]] + " - READY") : Demo.vehicleNames[(int)this.playerVehicles[userId]]);
        }
    }
    public void SetupPlaceholders()
    {
        int num = (int)GameManager.instance.vehicles[0];
        this.accelInput.text = GameManager.vehicleConfigs[num].DAT_13.ToString();
        this.speedInput.text = GameManager.vehicleConfigs[num].lightness.ToString();
        this.armorInput.text = GameManager.vehicleConfigs[num].maxHalfHealth.ToString();
        this.avoidInput.text = GameManager.vehicleConfigs[num].DAT_15.ToString();
    }
    public void SetAccel()
    {
        int num = (int)GameManager.instance.vehicles[0];
        GameManager.vehicleConfigs[num].DAT_13 = byte.Parse(this.accelInput.text);
    }
    public void SetSpeed()
    {
        int num = (int)GameManager.instance.vehicles[0];
        GameManager.vehicleConfigs[num].lightness = int.Parse(this.speedInput.text);
    }
    public void SetArmor()
    {
        int num = (int)GameManager.instance.vehicles[0];
        GameManager.vehicleConfigs[num].maxHalfHealth = ushort.Parse(this.armorInput.text);
    }
    public void SetAvoid()
    {
        int num = (int)GameManager.instance.vehicles[0];
        GameManager.vehicleConfigs[num].DAT_15 = byte.Parse(this.avoidInput.text);
    }
    public void GetLobbies()
    {
        Plugin.ShowConnectionWindow = true;
        discordController.SearchLobbies();
    }

    public string nametag;
    public void _GetLobbies(List<Lobby> lobbies)
    {
        for (int i = 0; i < lobbies.Count; i++)
        {
            Button component = UnityEngine.Object.Instantiate<GameObject>(this.lobbyButtonPrefab).GetComponent<Button>();
            Text componentInChildren = component.GetComponentInChildren<Text>();
            component.transform.SetParent(this.lobbyList, false);
            Lobby lobby = lobbies[i];
            componentInChildren.text = discordController.GetLobbyMetadataValue(lobby.Id, "name");
            component.onClick.AddListener(delegate ()
            {
                this.componentPanel.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.controlPanel.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.modeLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                this.stageLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug damageLabel");
                this.damageLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug difficulty");
                this.difficultyLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug onlineDmg");
                this.onlineDmgLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug livesLabel");
                this.livesLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug Ready");
                this.readyLabel.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                Debug.Log("Debug NotReady");
                this.notReadyLabel.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                this.settingsText.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.mapText.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.damageText.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.livesText.gameObject.SetActive(true);
            });
            component.onClick.AddListener(delegate ()
            {
                this.lobbyScrollView.gameObject.SetActive(false);
            });
            component.onClick.AddListener(delegate ()
            {
                this.DeleteLobbies();
            });
            component.onClick.AddListener(delegate ()
            {
                this.SetupPlaceholders();
            });
            component.onClick.AddListener(delegate ()
            {
                this.JoinLobby(lobby.Id, lobby.Secret);
            });
        }
    }
    public void DeleteLobbies()
    {
        for (int i = 0; i < this.lobbyList.childCount; i++)
        {
            UnityEngine.Object.Destroy(this.lobbyList.GetChild(i).gameObject);
        }
    }
    public void JoinLobby(long lobbyId, string secret)
    {
        discordController.lobbyManager.ConnectLobby(lobbyId, secret, delegate (Result result, ref Lobby lobby)
        {
            if (result == Result.Ok)
            {
                discordController.InitNetworking(lobby.Id);
                ClientSend.Joined();
            }
        });
    }
    public void SetupLobby()
    {
        //Crea el lobby, arreglarlo
        discordController.CreateLobby(this.lobbyInput.text);
    }
    public void MemberLeft(long userId)
    {
        Debug.Log(userId + " Se ha salido: " + this.playerText[userId].gameObject);
        Debug.Log(this.playerText[userId].gameObject + " - " + this.playerNames[userId] + " - " + this.playerReady[userId] + " - " + this.playerVehicles[userId]);
        UnityEngine.Object.Destroy(this.playerText[userId].gameObject);
        this.playerText.Remove(userId);
        this.playerNames.Remove(userId);
        this.playerReady.Remove(userId);
        this.playerVehicles.Remove(userId);
        GameManager.instance.networkMembers.Remove(userId);
        if (GameManager.instance.networkIds.ContainsKey(userId))
        {
            GameManager.instance.networkIds.Remove(userId);
        }
    }
    public void LeaveLobby(long lobbyId)
    {
        LobbyManager lobbyManager = discordController.lobbyManager;
        for (int i = 0; i < lobbyManager.MemberCount(lobbyId); i++)
        {
            long memberUserId = lobbyManager.GetMemberUserId(lobbyId, i);
            if (GameManager.instance.inDebug && this.playerText.ContainsKey(memberUserId))
            {
                UnityEngine.Object.Destroy(this.playerText[memberUserId].gameObject);
            }
        }
        this.playerText.Clear();
        this.playerNames.Clear();
        this.playerReady.Clear();
        this.playerVehicles.Clear();
        GameManager.instance.networkMembers.Clear();
        GameManager.instance.networkIds.Clear();
    }
    public DiscordController discordController;
    public static Demo instance;
    public Dictionary<long, bool> playerReady;
    public Dictionary<long, Text> playerText;
    public Dictionary<long, string> playerNames;
    public Dictionary<long, byte> playerVehicles;
    public RectTransform playerList;
    public RectTransform lobbyList;
    public Text settingsText;
    public Text modeText;
    public Text mapText;
    public Text damageText;
    public Text difficultyText;
    public Text livesText;
    public RectTransform Space1;
    public RectTransform Space2;
    public RectTransform Space3;
    public RectTransform Space4;
    public RectTransform Space5;
    public RectTransform componentPanel;
    public RectTransform controlPanel;
    public RectTransform modeLabel;
    public RectTransform stageLabel;
    public RectTransform damageLabel;
    public RectTransform difficultyLabel;
    public RectTransform onlineDmgLabel;
    public RectTransform livesLabel;
    public RectTransform readyLabel;
    public RectTransform notReadyLabel;
    public RectTransform lobbyScrollView;
    public InputField lobbyInput;
    public InputField accelInput;
    public InputField speedInput;
    public InputField armorInput;
    public InputField avoidInput;
    public GameObject playerTextPrefab;
    public GameObject lobbyButtonPrefab;
    public static string[] vehicleNames = new string[]
    {
        "WUNDER",
        "TBOLT",
        "STNTBIKE",
        "TOWTRUCK",
        "TRUCK",
        "CARAVLLE",
        "CORSAIR",
        "ELGUERRO",
        "BUS",
        "EXCELSR",
        "TSUNAMI",
        "MARATHON",
        "LUNAR",
        "GRBLDER",
        "STINGER",
        "VERTIGO",
        "HALFTRAK",
        "FRONTIER"
    };
    public static string[] mapNames = new string[]
    {
        "ROUTE66",
        "OLYMPIC",
        "BAYOU",
        "LAUNCH",
        "STEELMILL",
        "NUCLEAR",
        "OILFIELD",
        "HARBOR",
        "SCRTBASE",
        "SANDFACT",
        "OILFIELD2",
        "AIRGRAVE",
        "WILDWEST",
        "HOOVRDAM",
        "VALLYFRM",
        "CASNOCTY",
        "CANYNLND",
        "SKIRESRT"
    };
    public static string[] modeNames = new string[]
    {
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "VERSUS",
        "COOP",
        "SURVIVAL"
    };
    public static string[] damageNames = new string[]
    {
        "LOW",
        "MEDIUM",
        "HIGH"
    };
    public static string[] difficultyNames = new string[]
    {
        "86",
        "89",
        "92"
    };
}
