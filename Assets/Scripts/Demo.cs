using System.Collections;
using System.Collections.Generic;
using Discord;
using TMPro;
using Unity.Burst;
using UnityEngine;
using UnityEngine.UI;
using V2UnityDiscordIntercept;
using Beebyte;
using Beebyte.Obfuscator;

[BurstCompile]
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

        //Desactiva Debug
#if DEBUG
#else
       GameObject.Find("IngameDebugConsole").gameObject.SetActive(false);
#endif

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
        if (titleLobby.text == "Connection timeout")
            StartCoroutine(ChangeTextAfterDelay());
    }

    private IEnumerator ChangeTextAfterDelay()
    {
        yield return new WaitForSeconds(3f); // Esperar 3 segundos
        titleLobby.text = "Network Connection";
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

    //public void GetLobbies()
    public static void GetLobbies()
    {
        Plugin.ShowConnectionWindow = true;
        //---------//
        //discordController.SearchLobbies();
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
                JoinLobby(this, lobby.Id, lobby.Secret);
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


    //public void JoinLobby(long lobbyId, string secret)
    public static bool JoinLobby(Demo __instance, long lobbyId, string secret)
    {
        Debug.Log("Lobby ID: " + lobbyId + " secret: " + secret);

        if (!DiscordController.IsOwner())
        {
            __instance.componentPanel.gameObject.SetActive(true);
            //__instance.loadButtonOnline.gameObject.SetActive(true);
            __instance.loadTextOnline.gameObject.SetActive(false);
            __instance.join.gameObject.SetActive(false);
            __instance.controlPanel.gameObject.SetActive(true);
            __instance.modeLabel.gameObject.SetActive(false);
            __instance.stageLabel.gameObject.SetActive(false);
            __instance.damageLabel.gameObject.SetActive(false);
            __instance.difficultyLabel.gameObject.SetActive(false);
            __instance.onlineDmgLabel.gameObject.SetActive(false);
            __instance.livesLabel.gameObject.SetActive(false);
            __instance.readyLabel.gameObject.SetActive(true);
            __instance.notReadyLabel.gameObject.SetActive(false);
            __instance.settingsText.gameObject.SetActive(true);
            __instance.mapText.gameObject.SetActive(true);
            __instance.damageText.gameObject.SetActive(true);
            __instance.livesText.gameObject.SetActive(true);
            __instance.lobbyScrollView.gameObject.SetActive(false);
            __instance.DeleteLobbies();
            __instance.SetupPlaceholders();
        }
        Plugin.Client.JoinLobby(lobbyId, secret);
        return false;
        //---------//
        //discordController.lobbyManager.ConnectLobby(lobbyId, secret, delegate (Result result, ref Lobby lobby)
        //{
        //    if (result == Result.Ok)
        //    {
        //        discordController.InitNetworking(lobby.Id);
        //        ClientSend.Joined();
        //    }
        //});
    }

    public void SetupLobby()
    {
        //Crea el lobby, arreglarlo
        //discordController.CreateLobby(this.lobbyInput.text);
        DiscordController.CreateLobby(lobbyInput.text);
    }
    public void MemberLeft(long userId)
    {
        Debug.Log("El Usuario: " + this.playerNames[userId] + " con el ID: " + userId + " Se ha salido: " + this.playerText[userId].gameObject);
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

    //public void LeaveLobby(long lobbyId)
    public static bool LeaveLobby(Demo __instance, long lobbyId)
    {
        Debug.Log("Leaving lobby");
        foreach (long num in __instance.playerText.Keys)
        {
            if (GameManager.instance.inDebug)
            {
                UnityEngine.Object.Destroy(__instance.playerText[num].gameObject);
            }
        }
        __instance.playerText.Clear();
        __instance.playerNames.Clear();
        __instance.playerReady.Clear();
        __instance.playerVehicles.Clear();
        GameManager.instance.networkMembers.Clear();
        GameManager.instance.networkIds.Clear();
        return false;
        //return false;
        //---------//
        //LobbyManager lobbyManager = discordController.lobbyManager;
        //for (int i = 0; i < lobbyManager.MemberCount(lobbyId); i++)
        //{
        //    long memberUserId = lobbyManager.GetMemberUserId(lobbyId, i);
        //    if (GameManager.instance.inDebug && this.playerText.ContainsKey(memberUserId))
        //    {
        //        UnityEngine.Object.Destroy(this.playerText[memberUserId].gameObject);
        //    }
        //}
        //this.playerText.Clear();
        //this.playerNames.Clear();
        //this.playerReady.Clear();
        //this.playerVehicles.Clear();
        //GameManager.instance.networkMembers.Clear();
        //GameManager.instance.networkIds.Clear();
    }

    public void ConnectLobby()
    {
        Plugin.Username = UsernameInputField.text;
        Plugin.ipAddress = ipAddressInputField.text;

        string inputText = PortInputField.text; // Obtener el texto del InputField

        int port;
        if (int.TryParse(inputText, out port))
        {
            // La conversión fue exitosa, 'port' contiene el valor entero
            Plugin.Port = port;
        }
        else
        {
            // La conversión falló, mostrar un mensaje de error o realizar alguna acción apropiada
            Debug.LogError("El valor ingresado no es un número entero válido.");
            return;
        }
        GameManager.instance.online = true;
        Plugin.Client = new VigClient();
        Plugin.Client.ConnectToLobby(Plugin.ipAddress, Plugin.Port);
    }

    [Header("Lobby Manager")]
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


    [Header("Lobby Create")]
    public RectTransform join;
    public TextMeshProUGUI titleLobby;
    public InputField UsernameInputField;
    public InputField ipAddressInputField;
    public InputField PortInputField;
    public Button joinLobbyButton;
    public Button backButton;
    public Button loadButtonOnline;
    public TextMeshProUGUI loadTextOnline;

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
