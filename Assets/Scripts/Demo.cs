using Discord;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
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

	public static string[] vehicleNames = new string[18]
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

	public static string[] mapNames = new string[18]
	{
		"ROUTE66",
		"OLYMPIC",
		"LAUNCH",
		"BAYOU",
		"NUCLEAR",
		"STEELMILL",
		"OILFIELD",
		"HARBOR",
		"OILFIELD2",
		"AIRGRAVE",
		"WILDWEST",
		"HOOVRDAM",
		"VALLYFRM",
		"CASNOCTY",
		"CANYNLND",
		"SKIRESRT",
		"SCRTBASE",
		"SANDFACT"
	};

	public static string[] modeNames = new string[13]
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

	public static string[] damageNames = new string[3]
	{
		"LOW",
		"MEDIUM",
		"HIGH"
	};

	public static string[] difficultyNames = new string[3]
	{
		"86",
		"89",
		"92"
	};

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	private void Start()
	{
		playerReady = new Dictionary<long, bool>();
		playerText = new Dictionary<long, Text>();
		playerNames = new Dictionary<long, string>();
		playerVehicles = new Dictionary<long, byte>();
		GameManager.instance.map = 1;
		GameManager.instance.playerSpawns = 1;
		DiscordController.instance.sceneLoaded = true;
	}

	private void Update()
	{
	}

	public void InstantiateText(long userId)
	{
		Text component = UnityEngine.Object.Instantiate(playerTextPrefab).GetComponent<Text>();
		component.transform.SetParent(playerList, worldPositionStays: false);
		playerText.Add(userId, component);
		playerText[userId].text = playerNames[userId] + ": " + vehicleNames[playerVehicles[userId]];
	}

	public void UpdatePlayerStatus(long userId)
	{
		if (playerText[userId] != null)
		{
			playerText[userId].text = playerNames[userId] + ": " + (playerReady[userId] ? (vehicleNames[playerVehicles[userId]] + " - READY") : vehicleNames[playerVehicles[userId]]);
		}
	}

	public void SetupPlaceholders()
	{
		int num = GameManager.instance.vehicles[0];
		accelInput.text = GameManager.vehicleConfigs[num].DAT_13.ToString();
		speedInput.text = GameManager.vehicleConfigs[num].lightness.ToString();
		armorInput.text = GameManager.vehicleConfigs[num].maxHalfHealth.ToString();
		avoidInput.text = GameManager.vehicleConfigs[num].DAT_15.ToString();
	}

	public void SetAccel()
	{
		int num = GameManager.instance.vehicles[0];
		GameManager.vehicleConfigs[num].DAT_13 = byte.Parse(accelInput.text);
	}

	public void SetSpeed()
	{
		int num = GameManager.instance.vehicles[0];
		GameManager.vehicleConfigs[num].lightness = int.Parse(speedInput.text);
	}

	public void SetArmor()
	{
		int num = GameManager.instance.vehicles[0];
		GameManager.vehicleConfigs[num].maxHalfHealth = ushort.Parse(armorInput.text);
	}

	public void SetAvoid()
	{
		int num = GameManager.instance.vehicles[0];
		GameManager.vehicleConfigs[num].DAT_15 = byte.Parse(avoidInput.text);
	}

	public void GetLobbies()
	{
		DiscordController.instance.SearchLobbies();
	}

	public void _GetLobbies(List<Lobby> lobbies)
	{
		for (int i = 0; i < lobbies.Count; i++)
		{
			Button component = UnityEngine.Object.Instantiate(lobbyButtonPrefab).GetComponent<Button>();
			Text componentInChildren = component.GetComponentInChildren<Text>();
			component.transform.SetParent(lobbyList, worldPositionStays: false);
			Lobby lobby = lobbies[i];
			componentInChildren.text = DiscordController.instance.GetLobbyMetadataValue(lobby.Id, "name");
			component.onClick.AddListener(delegate
			{
				componentPanel.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				controlPanel.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				modeLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				stageLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				damageLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				difficultyLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				onlineDmgLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				livesLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				readyLabel.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				notReadyLabel.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				settingsText.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				mapText.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				damageText.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				livesText.gameObject.SetActive(value: true);
			});
			component.onClick.AddListener(delegate
			{
				lobbyScrollView.gameObject.SetActive(value: false);
			});
			component.onClick.AddListener(delegate
			{
				DeleteLobbies();
			});
			component.onClick.AddListener(delegate
			{
				SetupPlaceholders();
			});
			component.onClick.AddListener(delegate
			{
				JoinLobby(lobby.Id, lobby.Secret);
			});
		}
	}

	public void DeleteLobbies()
	{
		for (int i = 0; i < lobbyList.childCount; i++)
		{
			UnityEngine.Object.Destroy(lobbyList.GetChild(i).gameObject);
		}
	}

	public void JoinLobby(long lobbyId, string secret)
	{
		DiscordController.instance.lobbyManager.ConnectLobby(lobbyId, secret, delegate(Result result, ref Lobby lobby)
		{
			if (result == Result.Ok)
			{
				DiscordController.instance.InitNetworking(lobby.Id);
				ClientSend.Joined();
			}
		});
	}

	public void SetupLobby()
	{
        //Crea el lobby, arreglarlo

        //DiscordController.instance.CreateLobby(this.lobbyInput.text);
		DiscordController.instance.CreateLobby(lobbyInput.text);
	}

	public void MemberLeft(long userId)
	{
		UnityEngine.Object.Destroy(playerText[userId].gameObject);
		playerText.Remove(userId);
		playerNames.Remove(userId);
		playerReady.Remove(userId);
		playerVehicles.Remove(userId);
		GameManager.instance.networkMembers.Remove(userId);
		if (GameManager.instance.networkIds.ContainsKey(userId))
		{
			GameManager.instance.networkIds.Remove(userId);
		}
	}

	public void LeaveLobby(long lobbyId)
	{
		LobbyManager lobbyManager = DiscordController.instance.lobbyManager;
		for (int i = 0; i < lobbyManager.MemberCount(lobbyId); i++)
		{
			long memberUserId = lobbyManager.GetMemberUserId(lobbyId, i);
			if (GameManager.instance.inDebug && playerText.ContainsKey(memberUserId))
			{
				UnityEngine.Object.Destroy(playerText[memberUserId].gameObject);
			}
		}
		playerText.Clear();
		playerNames.Clear();
		playerReady.Clear();
		playerVehicles.Clear();
		GameManager.instance.networkMembers.Clear();
		GameManager.instance.networkIds.Clear();
	}
}
