using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using V2UnityDiscordIntercept;
using Unity.Burst;

[BurstCompile]
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public OcclusionCamera occlusionPrefab;
    public LensFlares lensFlarePrefab;
    public Image flash;
    public RectTransform hudRect;
    public RectTransform flaresRect;
    public List<Sprite> enemySprites;
    public List<Sprite> weaponSprites;
    public List<Sprite> digitSprites;
    public TextMeshProUGUI digitTextTMP_UI;
    public List<Sprite> slotSprites;
    public List<Sprite> asciiSprites;
    public GameObject unitPrefab;

    [Header("PlayerTags")]
    public bool isGameTagThis = false;
    public bool isGameTagPlayers = true;
    public bool isGameTagNPC = true;

    public RectTransform playerTag;
    public GameObject gameLifePrefab;
    public GameObject gameTagPrefab;
    public TextMeshPro gameTagPlayer;
    public SpriteRenderer spriteLifePlayer;
    public Sprite gameTagSprite;

    public GameObject characterPrefab;
    public Image weaponRect;
    public Image enemyRect;
    public RectTransform radarRect;
    public RectTransform feedbackRect;
    public Image playerHealthSlider;
    public Slider enemyHealthSlider;
    public List<Image> digits;
    public List<Image> slots;
    public List<Image> powerups;
    public RectTransform youWinRect;
    public RectTransform youLoseRect;
    public RectTransform gameOverRect;
    public RectTransform destroyedRect;
    public Text completionTime;
    public Text arcadeWhammies;
    public Text arcadeTotaled;
    public Text survivalTime;
    public Text survivalWhammies;
    public Text survivalTotaled;
    public Text survivalDestroyed;
    public Text difficulty;
    public Text destroyed;
    public List<LensFlares> flares;
    public List<OcclusionCamera> cameras;
    public Image underwater;
    public float units;
    public float radius;
    public float printSpeed;
    public float under;
    public float waterOffset;
    public Image printedChar;
    public List<Image> feedbackElements;
    public List<Image> trackElements;
    private int printIndex;
    private bool CR_Running;
    private static Color32 GREEN = new Color32(37, byte.MaxValue, 0, byte.MaxValue);
    private static Color32 RED = new Color32(byte.MaxValue, 0, 0, byte.MaxValue);
    private static Color32 YELLOW = new Color32(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);
    private static Color32 GRAY = Color.gray;

    private void Awake()
    {
        instance = this;
        if (GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2)
        {
            destroyedRect.gameObject.SetActive(value: true);
        }
    }

    public void Underwater(float cameraY, float waterY)
    {
        float y = Mathf.Clamp((waterY + waterOffset - cameraY) / under, 0f, 1f);
        underwater.rectTransform.anchorMax = new Vector2(1f, y);
    }

    public void RefreshDestroyed(int value)
    {
        destroyed.text = value.ToString();
    }

    public RawImage InstantiateUnit()
    {
        RawImage component = UnityEngine.Object.Instantiate(unitPrefab, radarRect).GetComponent<RawImage>();
        component.color = RED;
        return component;
    }

    public TextMeshPro InstantiateGameTag()
    {
        Debug.Log("Generate GameTag...");
        TextMeshPro component = UnityEngine.Object.Instantiate(gameTagPrefab, playerTag).GetComponent<TextMeshPro>();
        Debug.Log("Generate GameTag...Done");
        //component.color = RED;
        return component;
    }

    public SpriteRenderer InstantiateSpriteLife()
    {
        SpriteRenderer component = UnityEngine.Object.Instantiate(gameLifePrefab, playerTag).GetComponent<SpriteRenderer>();
        //component.color = RED;
        return component;
    }

    public RawImage InstantiateFriendlyUnit()
    {
        RawImage component = UnityEngine.Object.Instantiate(unitPrefab, radarRect).GetComponent<RawImage>();
        component.color = GRAY;
        return component;
    }

    public RawImage InstantiateFriendlyGameTag()
    {
        RawImage component = UnityEngine.Object.Instantiate(gameTagPrefab, playerTag).GetComponent<RawImage>();
        component.color = GRAY;
        return component;
    }

    public SpriteRenderer InstantiateFriendlySpriteLife()
    {
        SpriteRenderer component = UnityEngine.Object.Instantiate(gameLifePrefab, playerTag).GetComponent<SpriteRenderer>();
        //component.color = RED;
        return component;
    }

    public void InstantiateCharacter()
    {
        printedChar = UnityEngine.Object.Instantiate(characterPrefab, feedbackRect).GetComponent<Image>();
        feedbackElements.Add(printedChar);
    }

    public void ReplaceCharacter(char c)
    {
        printedChar.sprite = asciiSprites[c];
        printedChar.SetNativeSize();
    }

    public IEnumerator Printf(string text, bool overwrite = true)
    {
        if (feedbackElements != null)
        {
            for (int k = 0; k < feedbackElements.Count; k++)
            {
                UnityEngine.Object.DestroyImmediate(feedbackElements[k].gameObject, allowDestroyingAssets: false);
            }
            feedbackElements.Clear();
            feedbackElements = null;
        }
        if (feedbackElements == null)
        {
            feedbackElements = new List<Image>();
            for (int j = 0; j < text.Length; j++)
            {
                InstantiateCharacter();
                yield return new WaitForSeconds(printSpeed);
                ReplaceCharacter(text[j]);
            }
            yield return new WaitForSeconds(5f);
            for (int j = 0; j < 128; j++)
            {
                for (int l = 0; l < feedbackElements.Count; l++)
                {
                    Color32 c = feedbackElements[l].color;
                    c.r--;
                    c.g--;
                    c.b--;
                    feedbackElements[l].color = c;
                }
                yield return null;
            }

            for (int m = 0; m < feedbackElements.Count; m++)
            {
                UnityEngine.Object.DestroyImmediate(feedbackElements[m].gameObject, allowDestroyingAssets: false);
            }
            feedbackElements.Clear();
            feedbackElements = null;
        }
        CR_Running = false;
    }

    private IEnumerator _WinScreen()
    {
        yield return new WaitForSeconds(5f);
        Vehicle vehicle = GameManager.instance.playerObjects[0];
        TimeSpan timeSpan = TimeSpan.FromSeconds(Time.timeSinceLevelLoadAsDouble);
        string text = $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}:{timeSpan.Milliseconds:D3}";
        arcadeWhammies.text = vehicle.DAT_BE.ToString();
        arcadeTotaled.text = vehicle.DAT_BF.ToString() + " of " + GameManager.instance.totalSpawns.ToString();
        completionTime.text = text;
        youWinRect.gameObject.SetActive(value: true);
    }

    private IEnumerator _LoseScreen()
    {
        yield return new WaitForSeconds(5f);
        youLoseRect.gameObject.SetActive(value: true);
    }

    private IEnumerator _GameOver()
    {
        yield return new WaitForSeconds(5f);
        Vehicle vehicle = GameManager.instance.playerObjects[0];
        TimeSpan timeSpan = TimeSpan.FromSeconds(Time.timeSinceLevelLoadAsDouble);
        string text = $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}:{timeSpan.Milliseconds:D3}";
        survivalWhammies.text = vehicle.DAT_BE.ToString();
        survivalTotaled.text = vehicle.DAT_BF.ToString();
        survivalTime.text = text;
        survivalDestroyed.text = GameManager.instance.EnemyKill.ToString();
        switch (GameManager.instance.difficultyMode)
        {
            case 0:
                difficulty.text = "Easy";
                break;
            case 1:
                difficulty.text = "Medium";
                break;
            default:
                difficulty.text = "Hard";
                break;
        }
        gameOverRect.gameObject.SetActive(value: true);
    }

    private IEnumerator _GoodJob()
    {
        yield return new WaitForSeconds(5f);
        Vehicle vehicle = GameManager.instance.playerObjects[0];
        TimeSpan timeSpan = TimeSpan.FromSeconds(Time.timeSinceLevelLoadAsDouble);
        string text = $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}:{timeSpan.Milliseconds:D3}";
        survivalWhammies.text = vehicle.DAT_BE.ToString();
        survivalTotaled.text = vehicle.DAT_BF.ToString();
        survivalTime.text = text;
        survivalDestroyed.text = GameManager.instance.EnemyKill.ToString();
        Text component = gameOverRect.Find("Title").GetComponent<Text>();
        component.text = "GOOD JOB!";
        component.color = Color.yellow;
        switch (GameManager.instance.difficultyMode)
        {
            case 0:
                difficulty.text = "Easy";
                break;
            case 1:
                difficulty.text = "Medium";
                break;
            default:
                difficulty.text = "Hard";
                break;
        }
        gameOverRect.gameObject.SetActive(value: true);
    }

    void AddUIMessagesScript(GameObject targetObject)
    {
        //Agregar el componente UIMessages al GameObject
        uiMessagesScript = targetObject.AddComponent<UIMessage>();

        //Verificar si el componente se agregó correctamente
        if (uiMessagesScript != null)
        {
            //Hacer cualquier otra configuración o uso del script UIMessages aquí
            //uiMessagesScript.SomeFunction();
        }
    }

    private void makeLoadscene()
    {
        // Obtener el tamaño de la pantalla
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        Vector2 sizeScreen = new Vector2(screenWidth, screenHeight);

        // Crear el objeto Canvas
        GameObject canvasObject = new GameObject("Canvas");

        // Obtener el RectTransform del Canvas
        RectTransform canvasRectTransform = canvasObject.AddComponent<RectTransform>();
        // Obtener el tamaño del Canvas
        Vector2 canvasSize = canvasRectTransform.sizeDelta;

        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvasObject.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
        canvasObject.GetComponent<RectTransform>().sizeDelta = sizeScreen;

        // Calcular la posición central
        Vector2 centerPosition = new Vector2(screenWidth / 2f, screenHeight / 2f);
        // Calcular la posición de anclaje central
        Vector2 anchorPosition = new Vector2(canvasSize.x / 2f, -canvasSize.y / 2f);
        // Establecer la posición y el anclaje del Canvas
        canvasRectTransform.anchoredPosition = centerPosition;
        canvasRectTransform.anchorMin = anchorPosition / canvasSize;
        canvasRectTransform.anchorMax = anchorPosition / canvasSize;

        // Crear el objeto Panel como child del Canvas
        GameObject panelObject = new GameObject("Panel");
        RectTransform reactTransform = panelObject.AddComponent<RectTransform>();
        panelObject.transform.SetParent(canvasObject.transform);
        panelObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);

        // Agregar el componente Image al objeto Panel
        Image panelImage = panelObject.AddComponent<Image>();
        panelImage.sprite = Resources.Load<Sprite>("Assets/Images/XBGM00.png"); //Assets/Images/XBGM00.png
        panelImage.color = Color.black;
        panelImage.GetComponent<RectTransform>().sizeDelta = new Vector2(screenWidth, screenHeight);

        // Crear el objeto RAW Image como child del Panel
        GameObject rawImageObject = new GameObject("RAW Image");
        rawImageObject.transform.SetParent(panelObject.transform);

        // Agregar el componente Raw Image al objeto RAW Image
        RawImage rawImage = rawImageObject.AddComponent<RawImage>();
        rawImage.gameObject.SetActive(false);

        GameObject textScene = new GameObject("TextScene");
        textScene.transform.SetParent(panelObject.transform);
        TextMeshPro textStartScene = textScene.AddComponent<TextMeshPro>();
        textStartScene.text = "Press BackSpace to Continue...";
        textStartScene.font = Resources.Load<TMP_FontAsset>("ds");

        // loadPanel = canvasObject;
    }

    public UIMessage uiMessagesScript;

    public void Start()
    {
        AddUIMessagesScript(this.gameObject);
        //makeLoadscene();

        //Crea un objeto para insertar los GameTags
        GameObject obj = new GameObject("GameTagPlayers");
        obj.AddComponent<RectTransform>();
        playerTag = obj.GetComponent<RectTransform>();

        gameTagPlayer = UIManager.instance.InstantiateGameTag();

        //spriteLifePlayer = UIManager.instance.InstantiateSpriteLife();

        //gameTagPlayer.text = "ImanCol";
        gameTagPlayer.text = Plugin.Username;
        //gameTagPlayer.text = Demo.instance.lobbyInput.text;
        //GameObject obj = new GameObject("GameTagPlayer");
        //spriteRenderer2 = obj.AddComponent<SpriteRenderer>();
        //Asignar el sprite al SpriteRenderer
        //spriteRenderer2.sprite = gameTagSprite;

        //GameObject obj2 = new GameObject("GameTagPlayer2");
        //gameTag2 = obj2.AddComponent<TextMeshPro>();
        //Asignar el sprite al SpriteRenderer
        //gameTag2.text = "Player 1";
        isEnabled = true;
    }

    public static bool isEnabled = false;
    private void Update()
    {
        if (GameManager.instance.isWait)
        {
            if (GameManager.instance.paused)
            {

            }
        }
    }

    public void WinScreen()
    {
        hudRect.gameObject.SetActive(value: false);
        StartCoroutine("_WinScreen");
    }

    public void LoseScreen()
    {
        hudRect.gameObject.SetActive(value: false);
        StartCoroutine("_LoseScreen");
    }

    public void GameOver()
    {
        hudRect.gameObject.SetActive(value: false);
        StartCoroutine("_GameOver");
    }

    public void GoodJob()
    {
        hudRect.gameObject.SetActive(value: false);
        StartCoroutine("_GoodJob");
    }

    public void GameTagPlayer(TextMeshPro gameTag, Vehicle targetPlayer, bool isPlayer)
    {

        Vector3 extra = new Vector3(0, 0, 0);

        float num = Vector3.Angle(targetPlayer.transform.forward, Vector3.forward);

        string nameTagPlayer = targetPlayer.vehicle.ToString();

        //Debug.Log("Position " + nameTagPlayer + " forward: " + num);
        //Debug.Log("Vehiculo actualizado: " + targetPlayer.vehicle);

        if (Vector3.Cross(targetPlayer.transform.forward, Vector3.forward).y < 0f)
        {
            num = 0f - num;
        }
        Vector3 playerPosition = (Vector3)targetPlayer.vTransform.position / (float)GameManager.instance.translateFactor;

        //Debug.Log("Position " + nameTagPlayer + ": " + targetPlayer.vTransform.position);
        //Debug.Log("Position " + nameTagPlayer + ": " + playerPosition + " | translateFactor");

        Vector3 eulerAngles = Quaternion.LookRotation(playerPosition - LevelManager.instance.defaultCamera.transform.position, Vector3.up).eulerAngles;
        Vector3 position = GameManager.instance.positionInt;
        Quaternion rotation = GameManager.instance.rotationInt;
        Vector3 scale = GameManager.instance.scaleInt;

        Vector3 localPosition = new Vector3(playerPosition.x, -playerPosition.y, playerPosition.z);

        switch (nameTagPlayer)
        {
            case "Wonderwagon":
                if (!isPlayer)
                    gameTag.text = "Wonderwagon";
                break;
            case "Thunderbolt":
                if (!isPlayer)
                    gameTag.text = "Thunderbolt";
                break;
            case "DakotaCycle":
                if (!isPlayer)
                    gameTag.text = "Dakota Cycle";
                break;
            case "SamsonTow":
                if (!isPlayer)
                    gameTag.text = "Samson Truck";
                extra = new Vector3(0, 2, 0);
                break;
            case "Livingston":
                if (!isPlayer)
                    gameTag.text = "Livingston Truck";
                extra = new Vector3(0, 8, 0);
                break;
            case "Xanadu":
                if (!isPlayer)
                    gameTag.text = "Xanadu RV";
                extra = new Vector3(0, 5, 0);
                break;
            case "Palomino":
                if (!isPlayer)
                    gameTag.text = "Palomino XIII";
                break;
            case "ElGuerrero":
                if (!isPlayer)
                    gameTag.text = "El Guerrero";
                break;
            case "BlueBurro":
                if (!isPlayer)
                    gameTag.text = "Blue Bus";
                extra = new Vector3(0, 8, 0);
                break;
            case "Excelsior":
                if (!isPlayer)
                    gameTag.text = "Excelsior Stretch";
                break;
            case "Tsunami":
                if (!isPlayer)
                    gameTag.text = "Tsunami";
                break;
            case "Marathon":
                if (!isPlayer)
                    gameTag.text = "Marathon";
                break;
            case "Trekker":
                if (!isPlayer)
                    gameTag.text = "Moon Trekker";
                break;
            case "Loader":
                if (!isPlayer)
                    gameTag.text = "Grubb Loader";
                extra = new Vector3(0, 10, 0);
                break;
            case "Stinger":
                if (!isPlayer)
                    gameTag.text = "Chrono Stinger";
                break;
            case "Vertigo":
                if (!isPlayer)
                    gameTag.text = "Vertigo";
                extra = new Vector3(0, -1, 0);
                break;
            case "Goliath":
                if (!isPlayer)
                    gameTag.text = "Goliath Halftrack";
                break;
            case "Wapiti":
                if (!isPlayer)
                    gameTag.text = "Wapiti 4WD";
                break;
            case "NONE":
                if (!isPlayer)
                    gameTag.text = "NONE";
                break;
            default:
                if (!isPlayer)
                    gameTag.text = "NPC " + targetPlayer.id;
                break;
        }

        //Aplica la transformación personalizada
        if (GameManager.instance.positionSprite)
        {
#if DEBUG
            //Debug.Log("Player Tag: " + nameTagPlayer + " Posicion: " + localPosition + " - id: " + targetPlayer.id);
#endif
            gameTag.rectTransform.localPosition = localPosition + extra + position;
            //spriteLifePlayer.transform.localPosition = localPosition + extra + position;
        }

        if (GameManager.instance.rotationSprite)
        {
            gameTag.rectTransform.localRotation = Quaternion.Euler(eulerAngles) * rotation;
            //spriteLifePlayer.transform.localRotation = Quaternion.Euler(eulerAngles) * rotation;
        }

        if (GameManager.instance.scaleSprite)
        {
            //gameTagPlayer.rectTransform.localScale = scale + GameManager.instance.scaleInt;
            gameTag.rectTransform.localScale = scale;
            //spriteLifePlayer.transform.localScale = scale + GameManager.instance.scaleInt;
            //spriteLifePlayer.transform.localScale = scale;
        }
    }

    public void CalculateUnitPosition(RawImage unit, Vehicle obj)
    {
        //Posicion GameTag Player
        Vehicle vehicle = GameManager.instance.playerObjects[0];

        //GameTag You
        if (isGameTagThis)
        {
            if (gameTagPlayer.text == "")
                gameTagPlayer.text = Plugin.Username;
            GameTagPlayer(gameTagPlayer, vehicle, true);
        }
        else
        {
            gameTagPlayer.text = "";
        }

        float num = Vector3.Angle(vehicle.transform.forward, Vector3.forward);

        if (Vector3.Cross(vehicle.transform.forward, Vector3.forward).y < 0f)
        {
            num = 0f - num;
        }

        Vector3 b = (Vector3)vehicle.vTransform.position / (float)GameManager.instance.translateFactor;
        Vector3 point = (Vector3)obj.screen / (float)GameManager.instance.translateFactor - b;
        point = Quaternion.Euler(0f, num, 0f) * point;
        Vector3 vector = point / units;

        //Debug.Log("Units: " + units);

        unit.color = ((!(vehicle.target == obj)) ? RED : ((obj.jammer == 0 && (obj.flags & 0x8000000) == 0) ? GREEN : YELLOW));
        Vector3 vector2 = Vector3.ClampMagnitude(vector, radius);
        unit.rectTransform.anchoredPosition = new Vector2(vector2.x, vector2.z);
    }

    //Get PowerUp
    public void UpdateHUD(Vehicle player, int tick)
    {
        //Obtiene la cantidad de Vida
        float health = GetHealth(player);
        playerHealthSlider.fillAmount = health;
        //parpadea si la vida es baja
        if (health < 0.3f)
        {
            playerHealthSlider.enabled = (((tick & 0x10) == 0) ? true : false); //parpadea
        }
        else
        {
            playerHealthSlider.enabled = true; //estatico verdadero
        }
        VigObject target = player.target;
        if (target != null && target.type == 2)
        {
            Vehicle vehicle = (Vehicle)target;
            enemyRect.enabled = true;
            enemyRect.sprite = enemySprites[(int)(((vehicle.DAT_F6 & 0x400) == 0) ? vehicle.vehicle : (vehicle.vehicle + 18))];
            enemyRect.SetNativeSize();
            enemyHealthSlider.gameObject.SetActive(value: true);
            enemyHealthSlider.value = GetHealth(vehicle);
        }
        else
        {
            enemyRect.enabled = false;
            enemyHealthSlider.gameObject.SetActive(value: false);
        }
        for (int i = 0; i < 3; i++)
        {
            if (player.weapons[i] != null)
            {
                if (!slots[i].gameObject.activeSelf)
                {
                    slots[i].gameObject.SetActive(value: true);
                }
            }
            else if (slots[i].gameObject.activeSelf)
            {
                slots[i].gameObject.SetActive(value: false);
            }
        }
        VigObject vigObject = player.weapons[player.weaponSlot];
        if (vigObject != null && vigObject.maxHalfHealth != 0)
        {
            weaponRect.enabled = true;
            weaponRect.sprite = weaponSprites[vigObject.tags - 1];
            weaponRect.SetNativeSize();

            //digits[0].enabled = true;
            //digits[1].enabled = true;

            digitTextTMP_UI.gameObject.SetActive(true);

            if (vigObject.maxHalfHealth == 11)
                digitTextTMP_UI.text = "1 1";
            else
                digitTextTMP_UI.text = vigObject.maxHalfHealth.ToString();

            //digits[0].sprite = digitSprites[(int)vigObject.maxHalfHealth / 10];
            //digits[1].sprite = digitSprites[(int)vigObject.maxHalfHealth % 10];
            slots[0].sprite = slotSprites[0];
            slots[1].sprite = slotSprites[0];
            slots[2].sprite = slotSprites[0];
            slots[player.weaponSlot].sprite = slotSprites[1];
        }
        else
        {
            weaponRect.enabled = false;
            //digits[0].enabled = false;
            //digits[1].enabled = false;
            digitTextTMP_UI.gameObject.SetActive(false);
        }

        //get PowerUp
        if (player.transformation != 0)
        {
            int index;
            switch (player.wheelsType)
            {
                case _WHEELS.Air:
                    index = 0;
                    break;
                case _WHEELS.Sea:
                    index = 1;
                    break;
                case _WHEELS.Snow:
                    index = 2;
                    break;
                default:
                    index = 0;
                    break;
            }
            if (!powerups[index].gameObject.activeSelf)
            {
                powerups[0].gameObject.SetActive(value: false);
                powerups[1].gameObject.SetActive(value: false);
                powerups[2].gameObject.SetActive(value: false);
                powerups[index].gameObject.SetActive(value: true);
            }
            if (player.transformation < 300)
            {
                powerups[index].enabled = (((tick & 0x10) == 0) ? true : false);
            }
            else
            {
                powerups[index].enabled = true;
            }
        }
        else if (powerups[0].gameObject.activeSelf || powerups[1].gameObject.activeSelf || powerups[2].gameObject.activeSelf)
        {
            powerups[0].gameObject.SetActive(value: false);
            powerups[1].gameObject.SetActive(value: false);
            powerups[2].gameObject.SetActive(value: false);
        }
        if (player.doubleDamage != 0)
        {
            if (!powerups[3].gameObject.activeSelf)
            {
                powerups[3].gameObject.SetActive(value: true);
            }
            if (player.doubleDamage < 300)
            {
                powerups[3].enabled = (((tick & 0x10) == 0) ? true : false);
            }
            else
            {
                powerups[3].enabled = true;
            }
        }
        else if (powerups[3].gameObject.activeSelf)
        {
            powerups[3].gameObject.SetActive(value: false);
        }
        if (player.shield != 0)
        {
            if (!powerups[4].gameObject.activeSelf)
            {
                powerups[4].gameObject.SetActive(value: true);
            }
            if (player.shield < 300)
            {
                powerups[4].enabled = (((tick & 0x10) == 0) ? true : false);
            }
            else
            {
                powerups[4].enabled = true;
            }
        }
        else if (powerups[4].gameObject.activeSelf)
        {
            powerups[4].gameObject.SetActive(value: false);
        }
        if (player.jammer != 0)
        {
            if (!powerups[5].gameObject.activeSelf)
            {
                powerups[5].gameObject.SetActive(value: true);
            }
            if (player.jammer < 300)
            {
                powerups[5].enabled = (((tick & 0x10) == 0) ? true : false);
            }
            else
            {
                powerups[5].enabled = true;
            }
        }
        else if (powerups[5].gameObject.activeSelf)
        {
            powerups[5].gameObject.SetActive(value: false);
        }
    }

    public float GetHealth(Vehicle obj)
    {
        int num = (!(obj.body[0] == null)) ? (obj.body[0].maxHalfHealth + obj.body[1].maxHalfHealth) : obj.maxHalfHealth;
        return (float)num / (float)(int)obj.maxFullHealth;
    }

    public void RefreshFlares(int counter)
    {
        for (int i = 0; i < flares.Count; i++)
        {
            if (flares[i].update != counter && flares[i].gameObject.activeSelf)
            {
                flares[i].gameObject.SetActive(value: false);
            }
        }
    }

    public void RefreshCameras()
    {
        while (cameras.Count > 0 && cameras[0] == null)
        {
            cameras.RemoveAt(0);
        }
        if (cameras.Count > 0)
        {
            cameras[0].RenderW();
            cameras.RemoveAt(0);
        }
    }

    public void FUN_1D00C(LensFlares param1)
    {
        float num = Mathf.Abs(param1.rectTransform.anchoredPosition.x / 1.5f);
        float num2 = Mathf.Abs(param1.rectTransform.anchoredPosition.y / 1.5f);
        int num3 = (int)Mathf.Sqrt(num * num + num2 * num2);
        if (num3 >= 64)
        {
            return;
        }
        Color32 color = param1.color;
        Color32 c = default(Color32);
        if (color.r == 0 && color.g == 0 && color.b == 0)
        {
            return;
        }
        if (!param1.request.hasError && param1.request.done)
        {
            NativeArray<Color32> data = param1.request.GetData<Color32>();
            param1.renderTexture.LoadRawTextureData(data);
            param1.renderTexture.Apply();
        }
        if (((Color32)param1.renderTexture.GetPixel(32, 32)).r != 0)
        {
            int num4 = 64 - num3;
            uint num5 = ((Color32)flash.color).b + ((uint)(num4 * color.b) >> 6);
            uint num6 = 255u;
            if (num5 < 255)
            {
                num6 = num5;
            }
            uint num7 = ((Color32)flash.color).g + ((uint)(num4 * color.g) >> 6);
            num5 = 255u;
            if (num7 < 255)
            {
                num5 = num7;
            }
            c.b = (byte)num6;
            c.g = (byte)num5;
            num6 = ((Color32)flash.color).r + ((uint)(num4 * color.r) >> 6);
            c.r = byte.MaxValue;
            if (num6 < 255)
            {
                c.r = (byte)num6;
            }
            c.a = byte.MaxValue;
            flash.color = c;
        }
    }

    //Flash Get State
    public Flash FUN_4E414(Vector3Int param1, Color32 param2)
    {
        Flash result;
        if (GameManager.instance.screenMode == _SCREEN_MODE.Whole)
        {
            Debug.Log("Return Magnet1");
            bool num = GameManager.instance.FUN_2E22C(param1, 0);
            result = null;
            if (num)
            {
                result = FUN_4E338(param2);
            }
        }
        else
        {
            result = null;
        }
        return result;
    }

    public Flash FUN_4E338(Color32 param1)
    {
        Flash flash;
        if (GameManager.instance.screenMode == _SCREEN_MODE.Whole)
        {
            flash = new GameObject().AddComponent<Flash>();
            flash.flags = 160u;
            flash.DAT_3C = 128;
            flash.DAT_34 = param1;
            flash.FUN_305FC();
        }
        else
        {
            flash = null;
        }
        return flash;
    }

    public Flash FUN_4E3A8(Color32 param1)
    {
        Flash flash;
        if (GameManager.instance.screenMode == _SCREEN_MODE.Whole)
        {
            flash = new GameObject().AddComponent<Flash>();
            flash.flags = 160u;
            flash.DAT_34 = param1;
            flash.DAT_3C = 0;
            flash.FUN_305FC();
        }
        else
        {
            flash = null;
        }
        return flash;
    }
}
