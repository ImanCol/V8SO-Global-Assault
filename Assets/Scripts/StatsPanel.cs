
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.InputSystem;

[Serializable]
public class StatsPanel : MonoBehaviour
{
    [Header("Photon")]
    public LobbyMainPanel lobbyMainPanel;

    [Header("Config StatsPanel")]

    public _STATS_TYPE state;
    public List<Camera> cameras = new List<Camera>(); //Lista de Vehiculos (Players)
    public List<RawImage> playersRawImages = new List<RawImage>();
    public Image panel;
    public Image background;
    public Image accelBackground;
    public Image speedBackground;
    public Image armorBackground;
    public Image avoidanceBackground;
    public Image accelPlusBackground;
    public Image speedPlusBackground;
    public Image armorPlusBackground;
    public Image avoidancePlusBackground;
    public TextMeshProUGUI accelText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI armorText;
    public TextMeshProUGUI avoidanceText;
    public TextMeshProUGUI accelPlusText;
    public TextMeshProUGUI speedPlusText;
    public TextMeshProUGUI armorPlusText;
    public TextMeshProUGUI avoidancePlusText;
    public List<Image> signs;
    public TextMeshProUGUI desc;
    public List<TextMeshProUGUI> descDriver;
    public List<Image> poses;
    public GameObject selectMap;
    public List<Sprite> maps;
    public List<Sprite> panelSprites;
    public List<Sprite> backgroundSprites;
    public List<Sprite> sliderSprites;
    public List<Sprite> sliderPlusSprites;
    public List<Sprite> signSprites;
    public List<Color> textColors;
    public List<Vector3Int> cameraPositions;
    public Slider2 accel;
    public Slider2 speed;
    public Slider2 armor;
    public Slider2 avoidance;
    public Slider2 accelPlus;
    public Slider2 speedPlus;
    public Slider2 armorPlus;
    public Slider2 avoidancePlus;
    public List<Animator> questAnimators;
    private Vehicle vehicle;
    private Vehicle vehicle1;
    private Vehicle vehicle2;
    private Vehicle vehicle3;
    private Vehicle vehicle4;
    private Vehicle vehicle5;
    private Vehicle vehicle6;
    private Vehicle vehicle7;
    private Vehicle vehicle8;
    public int cursor = 0;
    public int spawnVehicleID;
    GameManager gameManager;
    public List<Vehicle> vehicles = new List<Vehicle>(); //Lista de Vehiculos (Players)
    public Dropdown PlayersDropdown;
    public int Players = 1;
    public List<Vector3Int> Spawnposition = new List<Vector3Int>();
    public Image panelOnline;
    public List<Slider2> accelPlayers;
    public List<Slider2> speedPlayers;
    public List<Slider2> armorPlayers;
    public List<Slider2> avoidancePlayers;
    public List<Slider2> accelPlusPlayers;
    public List<Slider2> speedPlusPlayers;
    public List<Slider2> armorPlusPlayers;
    public List<Slider2> avoidancePlusPlayers;
    public List<Image> accelsBackgroundPlayers;
    public List<Image> speedsBackgroundPlayers;
    public List<Image> armorsBackgroundPlayers;
    public List<Image> avoidancesBackgroundPlayers;
    public List<Image> accelsPlusBackgroundPlayers;
    public List<Image> speedsPlusBackgroundPlayers;
    public List<Image> armorsPlusBackgroundPlayers;
    public List<Image> avoidancesPlusBackgroundPlayers;

    public void SetPlayer()
    {
        switch (PlayersDropdown.value)
        {
            case 0:
                Players = 1;
                PhotonNetwork.LocalPlayer.NickName = "Player 1";
                //Spawnposition[0] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 1:
                Players = 2;
                PhotonNetwork.LocalPlayer.NickName = "Player 2";
                //Spawnposition[1] = new Vector3Int(67108000, 3078144, 67108864); // posición del primer vehículo
                break;
            case 2:
                Players = 3;
                PhotonNetwork.LocalPlayer.NickName = "Player 3";
                //Spawnposition[2] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 3:
                Players = 4;
                PhotonNetwork.LocalPlayer.NickName = "Player 4";
                //Spawnposition[3] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 4:
                Players = 5;
                PhotonNetwork.LocalPlayer.NickName = "Player 5";
                //Spawnposition[4] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 5:
                Players = 6;
                PhotonNetwork.LocalPlayer.NickName = "Player 6";
                //Spawnposition[5] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 6:
                Players = 7;
                PhotonNetwork.LocalPlayer.NickName = "Player 7";
                //Spawnposition[6] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 7:
                Players = 8;
                PhotonNetwork.LocalPlayer.NickName = "Player 8";
                //Spawnposition[7] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
            case 8:
                Players = 9;
                PhotonNetwork.LocalPlayer.NickName = "Player 9";
                //Spawnposition[8] = new Vector3Int(67108864, 3078144, 67108864); // posición del primer vehículo
                break;
        }
    }

    //Testing
    private static ushort[] salvagePartOffsets = new ushort[18]
    {
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        1
    };
    private static Vector3Int DAT_15DE8 = new Vector3Int(-170, 0, 0);
    private void Start()
    {
        reflectionsCoroutine = StartCoroutine(UpdateReflections());
        StartCoroutine(UpdateReflections());

        for (int i = 0; i <= 9; i++)
            vehicles.Add(vehicle);
        Debug.Log("Add: " + vehicles);

        //Vehiculo inicial
        //SetPlayer();
        //SpawnVehicle(1, 0);

        //Crear un RenderTexture para cada cámara en la lista

        RenderTexture rt = new RenderTexture(textureWidth, textureHeight, 16, RenderTextureFormat.ARGB32); //Principal
        rtList.Add(rt);
        for (int i = 1; i < cameras.Count; i++)
        {

            rt = new RenderTexture(480, 320, 32, RenderTextureFormat.ARGB32);
            rtList.Add(rt);
        }

        //Asignar RenderTexture a la Camaras y al RawImage(UI)
        for (int i = 1; i < cameras.Count; i++)
        {
            Camera cam = cameras[i];
            rt = rtList[i];
            cam.targetTexture = rt;
            playersRawImages[i].texture = rt;
        }
    }

    void OnDisable()
    {
        //Liberar memoria de todos los RenderTextures
        foreach (RenderTexture rt in rtList)
        {
            rt.Release();
        }
    }

    public int setPAD;

    public void setPadUP()
    {
        if (PlayersDropdown.value < 17)
        {
            PlayersDropdown.value += 1;
            Debug.Log("PRESS UP");
        }
    }

    public void setPadDOWN()
    {
        if (PlayersDropdown.value > 0)
        {
            PlayersDropdown.value -= 1;
            Debug.Log("PRESS DOWN");
        }
    }

    public void setPadLEFT()
    {
        setPAD = 1;
    }

    public void setPadRIGHT()
    {
        setPAD = 2;
    }

    bool pressed = false;

    int GetAssignedPlayer(Player player)
    {
        int assignedPlayer = 0;
        //Recorrer la lista de jugadores en la sala
        foreach (Player p in PhotonNetwork.PlayerList)
        {
            //Verificar si el jugador es igual al jugador especificado
            if (p == player)
            {
                //Obtener el número de jugador asignado al jugador especificado
                assignedPlayer = p.ActorNumber;
                break;
            }
        }
        return assignedPlayer;
    }

    private void Update()
    {
        if (lobbyMainPanel.selectOptions.activeSelf)
        {
            Debug.Log("Get Player: " + GetAssignedPlayer(PhotonNetwork.LocalPlayer));
            if (GameManager.instance.DriverPlus && pressed == true)
            {
                pressed = false;

                //Obtener el número de jugador asignado al jugador local
                int localPlayerID = GetAssignedPlayer(PhotonNetwork.LocalPlayer);

                //Recorrer la lista de jugadores en la sala
                foreach (Player player in PhotonNetwork.PlayerList)
                {
                    //Obtener el número de jugador asignado al jugador actual
                    Players = GetAssignedPlayer(player);
                    Debug.Log("PLAYER GET: " + player);
                    //Verificar si el jugador es diferente al jugador local
                    if (player != PhotonNetwork.LocalPlayer)
                    {
                        Debug.Log("Spawn Local...");
                        SetPlayer();
                        SpawnVehicle(Players, cursor);
                    }
                    else
                    {
                        Debug.Log("Spawn Normal...");
                        SetPlayer();
                        SpawnVehicle(Players, cursor);
                    }
                }
            }
            else if (!GameManager.instance.DriverPlus && pressed == false)
            {
                pressed = true;

                //Obtener el número de jugador asignado al jugador local
                Players = GetAssignedPlayer(PhotonNetwork.LocalPlayer);

                //Recorrer la lista de jugadores en la sala
                foreach (Player player in PhotonNetwork.PlayerList)
                {
                    // Obtener el número de jugador asignado al jugador actual
                    Players = GetAssignedPlayer(player);
                    Debug.Log("PLAYER GET: " + player + " - " + Players);

                    // Verificar si el jugador es diferente al jugador local
                    if (player != PhotonNetwork.LocalPlayer)
                    {
                        Debug.Log("Spawn Local...");
                        SetPlayer();
                        SpawnVehicle(Players, cursor);
                    }
                    else
                    {
                        Debug.Log("Spawn Normal...");
                        SetPlayer();
                        SpawnVehicle(Players, cursor);
                    }
                }
            }
        }
        if (Input.GetButtonDown("P1_RIGHT") || setPAD == 2)
        {
            poses[cursor].gameObject.SetActive(value: false);
            if (cursor < 17)
            {
                cursor++;
                if (state == _STATS_TYPE.Quest)
                {
                    switch (cursor)
                    {
                        case 5:
                            cursor = 6;
                            break;
                        case 11:
                            cursor = 12;
                            break;
                        case 17:
                            cursor = 0;
                            break;
                    }
                }
            }
            else
            {
                cursor = 0;
            }
            SpawnVehicle(Players, cursor);
            poses[cursor].gameObject.SetActive(value: true);
        }
        else if (Input.GetButtonDown("P1_LEFT") || setPAD == 1)
        {
            poses[cursor].gameObject.SetActive(value: false);
            if (cursor > 0)
            {
                cursor--;
                if (state == _STATS_TYPE.Quest)
                {
                    switch (cursor)
                    {
                        case 5:
                            cursor = 4;
                            break;
                        case 11:
                            cursor = 10;
                            break;
                    }
                }
            }
            else
            {
                cursor = 17;
                if (state == _STATS_TYPE.Quest)
                {
                    cursor = 16;
                }
            }
            SpawnVehicle(Players, cursor);
            poses[cursor].gameObject.SetActive(value: true);
        }
        else if (Input.GetButtonDown("P1_CROSS") && state == _STATS_TYPE.Quest)
        {
            questAnimators[cursor].gameObject.SetActive(value: true);
            questAnimators[cursor].SetTrigger("Next");
        }
        setPAD = 0;
    }

    public List<RenderTexture> rtList = new List<RenderTexture>();
    public int textureWidth = 256;
    public int textureHeight = 256;
    public float targetFrameRate = 60;
    public float fixedUpdateRate = 1f / 60f; // Tasa de fotogramas fija de 60 fps
    public float timeSinceLastUpdate = 0f;
    public float reflectionUpdateTime = 0.1f;
    public int Vehiclerelfection = 0;

    IEnumerator UpdateReflections()
    {
        while (true)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle vehicle = this.vehicles[i];
                if (i == Vehiclerelfection)
                {
                    if (vehicle == null)
                    {
                        continue;
                    }
                    if (cursor == 4)
                    {

                        GameManager.instance.SetReflections(vehicle, cursor);
                    }
                    else
                    {
                        //Solo se ejecuta cada updateTime segundos
                        GameManager.instance.SetReflections(vehicle, cursor);
                    }
                }
            }
            yield return new WaitForSeconds(reflectionUpdateTime);
            Vehiclerelfection += 1;
            if (Vehiclerelfection == 10)
            {
                Vehiclerelfection = 0;
            }
        }
    }

    void Awake()
    {
        //if (lobbyMainPanel2.selectOptions)
        //{
        //    SetPlayer();
        //    SpawnVehicle(1, 0);
        //}
        //if (lobbyMainPanel.selectOptions)
        //{
        //    SetPlayer();
        //    SpawnVehicle(1, 0);
        //}
    }

    private void StopReflections()
    {
        if (reflectionsCoroutine != null)
        {
            StopCoroutine(reflectionsCoroutine);
            reflectionsCoroutine = null;
        }
    }
    private Coroutine reflectionsCoroutine;
    private void FixedUpdate()
    {
        for (int i = 0; i < vehicles.Count; i++)
        {
            //Debug.Log("Vehicle Set: " + vehicles.Count);
            Vehicle vehicle = this.vehicles[i];

            if (vehicle == null)
            {
                continue;
            }

            vehicle.vTransform.rotation = Utilities.RotMatrixY(16L, vehicle.vTransform.rotation); //Rotacion Vehiculo
            vehicle.FUN_41AE8(); //Spawn Visible Vehicle
            vehicle.physics1.Z = 0; //Rotacion Wheels
            vehicle.physics1.X = 0; //Rotacion Wheels
            GameManager.instance.FUN_2FEE8(vehicle, (ushort)Menu.instance.tick); //unknow

            //Detecta Colision Suelo y reproduce Audio

            //Debug.Log("Debug Vehicle: " + vehicle.DAT_A6);
            //Debug.Log("Debug flags: " + vehicle.flags);

            if ((vehicle.flags & 0x12000000) == 268435456)
            {
                int param = 3;
                if (5120 < vehicle.DAT_A6)
                {
                    param = 2;
                    if (vehicle.DAT_A6 < 8193)
                    {
                        param = 1;
                    }
                }
                if (Players == 1)
                {
                    GameManager.instance.FUN_1E28C(1, Menu.instance.sounds, param);
                }
                vehicle.flags |= 33554432u;

            }
            //Posicion?
            //Debug.Log("Vehicle Position : " + vehicle.vTransform.position.y);
            vehicle.vTransform.position.z = 67108864; //unknow
                                                      //vehicle.vTransform.position.y = 3080659; //unknow
            vehicle.vTransform.position.x = 67108864; //unknow
            GameManager.instance.FUN_2DE18(); //Shadow?

            //Solo se ejecuta cada updateTime segundos
        }
    }

    public int DriverAccelPlus;
    public int DriverSpeedPlus;
    public int DriverArmorPlus;
    public int DriverAvoidancePlus;

    //Lobby
    public string playersNames;

    public void SetState(int value)
    {
        state = (_STATS_TYPE)value;
    }

    public ushort param = 0;

    public static object Instance { get; protected set; }
    public static StatsPanel instance;
    Color targetColor;
    Sprite targetSprite;
    Sprite targetPlusSprite;
    int bg;

    //int PlayersID, int id, Vector3Int position
    public void SpawnVehicle(int PlayersID, int id)
    {
        bg = 0;
        //Debug.Log("Borras:" + vehicles[Players].name);
        if (this.vehicles[Players] != null)
        {
            GameManager.instance.FUN_308C4(this.vehicles[Players]);
        }

        switch (id)
        {
            case 0:
                if (PlayersID == 1)
                {
                    desc.text = "Wonderwagon – a white and pink Baja buggy boasting\nhigh acceleration and avoidance, but low armor.";
                    descDriver[Players].text = "Wonderwagon";
                }
                goto IL_00db;
            case 1:
                if (PlayersID == 1)
                {
                    desc.text = "Thunderbolt – an ultramarine pony car with golden trims,\nboasting high speed and acceleration, but low avoidance.";
                    descDriver[Players].text = "Thunderbolt";
                }
                goto IL_00db;
            case 2:
                if (PlayersID == 1)
                {
                    desc.text = "Dakota Stunt Cycle – a red, white and blue stunt motorcycle\nwith a sidecar attachment, boasting high top speed\nand avoidance, but low armor.";
                    descDriver[Players].text = "Dakota Stunt Cycle";
                }
                goto IL_00db;
            case 3:
                if (PlayersID == 1)
                {
                    desc.text = "Samson Tow Truck – an orange tow truck with white trims,\nboasting high acceleration and average armor,\nbut low tracking avoidance.";
                    descDriver[Players].text = "Samson Tow Truck";
                }
                goto IL_00db;
            case 4:
                if (PlayersID == 1)
                {
                    desc.text = "Livingston Truck – a yellow and brown tandem\naxle conventional truck boasting high armor,\nbut low tracking avoidance.";
                    descDriver[Players].text = "Livingston Truck";
                }
                goto IL_00db;
            case 5:
                if (PlayersID == 1)
                {
                    desc.text = "Xanadu RV – a cream-colored motorhome boasting\nhigh armor, but otherwise mediocre stats.";
                    descDriver[Players].text = "Xanadu RV";
                }
                goto IL_00db;
            case 6:
                if (PlayersID == 1)
                {
                    desc.text = "Palomino XIII – a golden concept car from the future,\nboasting high acceleration and top speed,\nbut low tracking avoidance.";
                    descDriver[Players].text = "Palomino XIII";
                }
                goto IL_0376;
            case 7:
                if (PlayersID == 1)
                {
                    desc.text = "El Guerrero – a rusted tan utility vehicle boasting\nhigh acceleration, but low tracking avoidance.";
                    descDriver[Players].text = "El Guerrero";
                }
                goto IL_0376;
            case 8:
                if (PlayersID == 1)
                {
                    desc.text = "Blue Burro Bus – a white and metal grey tandem-axle\nprison bus, boasting high armor but low top speed.";
                    descDriver[Players].text = "Blue Burro Bus";
                }
                goto IL_0376;
            case 9:
                if (PlayersID == 1)
                {
                    desc.text = "Excelsior Stretch – a white limousine boasting\naverage balanced stats, but low avoidance.";
                    //descDriver[Players].text = "Excelsior Stretch";
                    descDriver[Players].text = "V4F 570 Delegate";
                }
                goto IL_0376;
            case 10:
                if (PlayersID == 1)
                {
                    desc.text = "Tsunami – a futuristic red motorcycle boasting\nhigh top speed and acceleration, but low armor.";
                    descDriver[Players].text = "Tsunami";
                }
                goto IL_0376;
            case 11:
                if (PlayersID == 1)
                {
                    desc.text = "Marathon – a blue and yellow subcompact car boasting\nhigh tracking avoidance, but low armor.";
                    descDriver[Players].text = "Marathon";
                }
                goto IL_0376;
            case 12:
                if (PlayersID == 1)
                {
                    desc.text = "Moon Trekker – a stolen white and orange moon rover\nboasting high acceleration and tracking avoidance,\nbut low top speed.";
                    descDriver[Players].text = "Moon Trekker";
                }
                goto IL_0611;
            case 13:
                if (PlayersID == 1)
                {
                    desc.text = "Grubb Dual Loader – a rusted brown waste collection truck\nboasting high armor, but low top speed and tracking\navoidance.";
                    descDriver[Players].text = "Grubb Dual Loader";
                }
                goto IL_0611;
            case 14:
                if (PlayersID == 1)
                {
                    desc.text = "Chrono Stinger – a purple sports car boasting\nhigh acceleration and top speed, but low armor.";
                    descDriver[Players].text = "Chrono Stinger";
                }
                goto IL_0611;
            case 15:
                if (PlayersID == 1)
                {
                    desc.text = "Vertigo – a silver concept car boasting high speed\nand acceleration, but low armor.";
                    descDriver[Players].text = "Vertigo";
                }
                goto IL_0611;
            case 16:
                if (PlayersID == 1)
                {
                    desc.text = "Goliath Halftrack – a tan open-top armored personnel carrier\nboasting high acceleration and armor, but low top speed\nand avoidance.";
                    descDriver[Players].text = "Goliath Halftrack";
                }
                goto IL_0611;
            case 17:
                {
                    if (PlayersID == 1)
                    {
                        desc.text = "Wapiti 4WD – a brown SUV boasting high acceleration.";
                        descDriver[Players].text = "Wapiti 4WD";
                    }
                    goto IL_0611;
                }
            IL_0611:
                panel.sprite = panelSprites[2];
                background.sprite = backgroundSprites[2];

                targetSprite = sliderSprites[2];
                targetPlusSprite = sliderPlusSprites[2];

                if (panelOnline != null)
                {
                    if (panelOnline.enabled)
                    {
                        bg = 1;
                        targetColor = textColors[5];
                        targetSprite = sliderSprites[3];
                        targetPlusSprite = sliderPlusSprites[3];
                    }
                }
                if (PlayersID == 1)
                {
                    accelsBackgroundPlayers[bg].sprite = targetSprite;
                    accelsBackgroundPlayers[bg].color = targetColor;
                    speedsBackgroundPlayers[bg].sprite = targetSprite;
                    speedsBackgroundPlayers[bg].color = targetColor;
                    armorsBackgroundPlayers[bg].sprite = targetSprite;
                    armorsBackgroundPlayers[bg].color = targetColor;
                    avoidancesBackgroundPlayers[bg].sprite = targetSprite;
                    avoidancesBackgroundPlayers[bg].color = targetColor;
                    accelsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    accelsPlusBackgroundPlayers[bg].color = targetColor;
                    speedsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    speedsPlusBackgroundPlayers[bg].color = targetColor;
                    armorsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    armorsPlusBackgroundPlayers[bg].color = targetColor;
                    avoidancesPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    avoidancesPlusBackgroundPlayers[bg].color = targetColor;

                    signs[0].sprite = signSprites[2];
                    signs[1].sprite = signSprites[2];
                    signs[2].sprite = signSprites[2];
                    signs[3].sprite = signSprites[2];
                    accelText.color = textColors[2];
                    speedText.color = textColors[2];
                    armorText.color = textColors[2];
                    avoidanceText.color = textColors[2];
                    accelPlusText.color = textColors[2];
                    speedPlusText.color = textColors[2];
                    armorPlusText.color = textColors[2];
                    avoidancePlusText.color = textColors[2];
                }
                cameras[Players].backgroundColor = textColors[2];

                if (panelOnline.enabled)
                {
                    Debug.Log("Activo");
                }

                //Error de Material en Menu-Elemento
                LevelManager.instance.DAT_E48 = Menu.instance.reflections[2];
                break;
            IL_0376:
                panel.sprite = panelSprites[1];
                background.sprite = backgroundSprites[1];

                targetSprite = sliderSprites[1];
                targetPlusSprite = sliderPlusSprites[1];

                if (panelOnline != null)
                {
                    if (panelOnline.enabled)
                    {
                        bg = 1;
                        targetColor = textColors[4];
                        targetSprite = sliderSprites[3];
                        targetPlusSprite = sliderPlusSprites[3];
                    }
                }
                if (PlayersID == 1)
                {
                    accelsBackgroundPlayers[bg].sprite = targetSprite;
                    accelsBackgroundPlayers[bg].color = targetColor;
                    speedsBackgroundPlayers[bg].sprite = targetSprite;
                    speedsBackgroundPlayers[bg].color = targetColor;
                    armorsBackgroundPlayers[bg].sprite = targetSprite;
                    armorsBackgroundPlayers[bg].color = targetColor;
                    avoidancesBackgroundPlayers[bg].sprite = targetSprite;
                    avoidancesBackgroundPlayers[bg].color = targetColor;
                    accelsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    accelsPlusBackgroundPlayers[bg].color = targetColor;
                    speedsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    speedsPlusBackgroundPlayers[bg].color = targetColor;
                    armorsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    armorsPlusBackgroundPlayers[bg].color = targetColor;
                    avoidancesPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    avoidancesPlusBackgroundPlayers[bg].color = targetColor;

                    signs[0].sprite = signSprites[1];
                    signs[1].sprite = signSprites[1];
                    signs[2].sprite = signSprites[1];
                    signs[3].sprite = signSprites[1];
                    accelText.color = textColors[1];
                    speedText.color = textColors[1];
                    armorText.color = textColors[1];
                    avoidanceText.color = textColors[1];
                    accelPlusText.color = textColors[1];
                    speedPlusText.color = textColors[1];
                    armorPlusText.color = textColors[1];
                    avoidancePlusText.color = textColors[1];
                }
                cameras[Players].backgroundColor = textColors[1];

                //Error de Material en Menu-Elemento 1
                LevelManager.instance.DAT_E48 = Menu.instance.reflections[1];
                break;
            IL_00db:
                panel.sprite = panelSprites[0];
                background.sprite = backgroundSprites[0];

                targetSprite = sliderSprites[0];
                targetPlusSprite = sliderPlusSprites[0];

                if (panelOnline != null)
                {
                    if (panelOnline.enabled)
                    {
                        bg = 1;
                        targetColor = textColors[3];
                        targetSprite = sliderSprites[3];
                        targetPlusSprite = sliderPlusSprites[3];
                    }
                }
                else
                {

                }
                if (PlayersID == 1)
                {
                    accelsBackgroundPlayers[bg].sprite = targetSprite;
                    accelsBackgroundPlayers[bg].color = targetColor;
                    speedsBackgroundPlayers[bg].sprite = targetSprite;
                    speedsBackgroundPlayers[bg].color = targetColor;
                    armorsBackgroundPlayers[bg].sprite = targetSprite;
                    armorsBackgroundPlayers[bg].color = targetColor;
                    avoidancesBackgroundPlayers[bg].sprite = targetSprite;
                    avoidancesBackgroundPlayers[bg].color = targetColor;
                    accelsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    accelsPlusBackgroundPlayers[bg].color = targetColor;
                    speedsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    speedsPlusBackgroundPlayers[bg].color = targetColor;
                    armorsPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    armorsPlusBackgroundPlayers[bg].color = targetColor;
                    avoidancesPlusBackgroundPlayers[bg].sprite = targetPlusSprite;
                    avoidancesPlusBackgroundPlayers[bg].color = targetColor;

                    signs[0].sprite = signSprites[0];
                    signs[1].sprite = signSprites[0];
                    signs[2].sprite = signSprites[0];
                    signs[3].sprite = signSprites[0];
                    accelText.color = textColors[0];
                    speedText.color = textColors[0];
                    armorText.color = textColors[0];
                    avoidanceText.color = textColors[0];
                    accelPlusText.color = textColors[0];
                    speedPlusText.color = textColors[0];
                    armorPlusText.color = textColors[0];
                    avoidancePlusText.color = textColors[0];
                }
                cameras[Players].backgroundColor = textColors[0];

                //Error de Material en Menu-Elemento 0
                LevelManager.instance.DAT_E48 = Menu.instance.reflections[0];
                break;
        }
        if (PlayersID >= 0 && PlayersID < cameras.Count)
        {
            //if (PlayersID != -1)
            cameras[PlayersID].transform.position = cameraPositions[id];
            Debug.Log("Camera: " + cameras[PlayersID]);
        }
        else
        {
            Debug.LogWarning("Invalid camera index: " + PlayersID);
        }
        if (PlayersID == 1)
        {
            accelPlayers[0].value = GameManager.vehicleConfigs[id].DAT_2C[0] * 2;
            speedPlayers[0].value = GameManager.vehicleConfigs[id].DAT_2C[1] * 2;
            armorPlayers[0].value = GameManager.vehicleConfigs[id].DAT_2C[2] * 2;
            avoidancePlayers[0].value = GameManager.vehicleConfigs[id].DAT_2C[3] * 2;

            //Hack Plus
            if (GameManager.instance.DriverPlus)
            {
                DriverAccelPlus = 100;
                DriverSpeedPlus = 100;
                DriverArmorPlus = 100;
                DriverAvoidancePlus = 100;
            }
            else
            {
                DriverAccelPlus = 0;
                DriverSpeedPlus = 0;
                DriverArmorPlus = 0;
                DriverAvoidancePlus = 0;
            }

            accelPlusPlayers[0].value = GameManager.instance.vehicleStats[id].accel + DriverAccelPlus;
            speedPlusPlayers[0].value = GameManager.instance.vehicleStats[id].speed + DriverSpeedPlus;
            armorPlusPlayers[0].value = GameManager.instance.vehicleStats[id].armor + DriverArmorPlus;
            avoidancePlusPlayers[0].value = GameManager.instance.vehicleStats[id].avoidance + DriverAvoidancePlus;

            //Visualizador Online
            if (panelOnline != null)
            {
                if (panelOnline.enabled)
                {
                    accelPlayers[1].value = GameManager.vehicleConfigs[id].DAT_2C[0] * 2;
                    speedPlayers[1].value = GameManager.vehicleConfigs[id].DAT_2C[1] * 2;
                    armorPlayers[1].value = GameManager.vehicleConfigs[id].DAT_2C[2] * 2;
                    avoidancePlayers[1].value = GameManager.vehicleConfigs[id].DAT_2C[3] * 2;
                    accelPlusPlayers[1].value = GameManager.instance.vehicleStats[id].accel + DriverAccelPlus;
                    speedPlusPlayers[1].value = GameManager.instance.vehicleStats[id].speed + DriverSpeedPlus;
                    armorPlusPlayers[1].value = GameManager.instance.vehicleStats[id].armor + DriverArmorPlus;
                    avoidancePlusPlayers[1].value = GameManager.instance.vehicleStats[id].avoidance + DriverAvoidancePlus;
                    //Debug.Log("Online Lobby");
                }
            }
        }
        ushort param = (ushort)(GameManager.instance.FUN_36558(0, id) ? salvagePartOffsets[id] : 0);
        Vehicle vehicle;

        if (accelPlus.value == 100 & speedPlus.value == 100 & armorPlus.value == 100 & avoidancePlus.value == 100)
        {
            if (id == 2 || id + 21 == 23)
            {
                Debug.Log("Dakota");
                vehicle = LevelManager.instance.xobfList[id + 21].FUN_3C464(param, GameManager.vehicleConfigs[id], typeof(Vehicle));
                //vehicle.child2 = LevelManager.instance.xobfList[id + 21].FUN_3C464(1, GameManager.vehicleConfigs[id], typeof(Vehicle));
                //vehicle = LevelManager.instance.xobfList[id + 21].FUN_3C464(1, GameManager.vehicleConfigs[2], typeof(Vehicle));
            }
            else
            {
                vehicle = LevelManager.instance.xobfList[id + 21].FUN_3C464(param, GameManager.vehicleConfigs[id], typeof(Vehicle));
                //Debug.Log("No Dakota");
            }
            //id += 21;
            //Debug.Log("Plus!: " + id);
            //Debug.Log("param: " + param);

        }
        else
        {
            Debug.Log("param: " + param);
            vehicle = LevelManager.instance.xobfList[id].FUN_3C464(param, GameManager.vehicleConfigs[id], typeof(Vehicle));
        }

        vehicle.flags |= 8u;
        GameObject gameObject = new GameObject();
        VigMesh param2 = LevelManager.instance.xobfList[18].FUN_2CB74(gameObject, 56u, init: true);
        vehicle.FUN_4C7E0(param2, gameObject);
        vehicle.screen.x = Spawnposition[0].x;
        if (PlayersID != 1)
        {
            vehicle.screen.y = 3133000;

        }
        else
        {
            vehicle.screen.y = Spawnposition[0].y;
        }
        vehicle.screen.z = Spawnposition[0].z;
        vehicle.ApplyTransformation();
        vehicle.FUN_2D1DC();
        vehicle.FUN_3C9C4(0);
        FUN_536C(vehicle, 512); //Spawn Vehicle
        vehicle.name = "Player " + (Players);

        //Asigna Layers para Renderizar en una sola camara
        vehicle.gameObject.layer = Players + 9;
        Renderer[] renderers = vehicle.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer renderer in renderers)
        {
            renderer.gameObject.layer = Players + 9;
        }

        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, id, Spawnposition[0]);

        if (PlayersID == 1)
        {
            GameManager.instance.FUN_1E28C(id + 1, Menu.instance.sounds, 4); //Spawn Sound
        }
        else
        {
            GameManager.instance.FUN_1E28C(id + 1, Menu.instance.sounds, 3); //Spawn Sound
                                                                             //GameManager.instance.FUN_1E098(1, Menu.instance.sounds, 3, 4095); //Spawn Sound
        }
        //vehicles.Add(vehicle);

        this.vehicles[Players] = vehicle;
        //Agrega el vehículo creado a la lista de vehículos
    }

    private void FUN_536C(Vehicle vehicle, int param2)
    {
        int dAT_E = vehicle.DAT_E4;
        int num = vehicle.vCollider.reader.ReadInt32(8);

        VigTransform vigTransform = default(VigTransform);
        vigTransform.rotation = Utilities.RotMatrixYXZ_gte(DAT_15DE8);
        vigTransform.position = default(Vector3Int);
        vigTransform.position.x = Spawnposition[Players - 1].x;

        int num2 = vigTransform.rotation.V12 * vehicle.DAT_58;

        if (num2 < 0)
        {
            num2 += 1023;
        }

        vigTransform.position.y = Spawnposition[Players - 1].y - ((num - dAT_E) / 2 - ((num2 >> 10) - 3143680));

        num = vigTransform.rotation.V22 * vehicle.DAT_58;
        if (num < 0)
        {
            num += 1023;
        }

        vigTransform.position.z = Spawnposition[Players - 1].z - (num >> 10);

        vigTransform.padding = 0;

        GameManager.instance.FUN_2E0E8(vigTransform, param2);
    }
}
