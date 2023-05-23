using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

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

    public List<Sprite> slotSprites;

    public List<Sprite> asciiSprites;

    public GameObject unitPrefab;

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

    private Image printedChar;

    private List<Image> feedbackElements;

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

    public RawImage InstantiateFriendlyUnit()
    {
        RawImage component = UnityEngine.Object.Instantiate(unitPrefab, radarRect).GetComponent<RawImage>();
        component.color = GRAY;
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
        CR_Running = true;
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

    public void CalculateUnitPosition(RawImage unit, Vehicle obj)
    {
        Vehicle vehicle = GameManager.instance.playerObjects[0];
        float num = Vector3.Angle(vehicle.transform.forward, Vector3.forward);
        if (Vector3.Cross(vehicle.transform.forward, Vector3.forward).y < 0f)
        {
            num = 0f - num;
        }
        Vector3 b = (Vector3)vehicle.vTransform.position / (float)GameManager.instance.translateFactor;
        Vector3 point = (Vector3)obj.screen / (float)GameManager.instance.translateFactor - b;
        point = Quaternion.Euler(0f, num, 0f) * point;
        Vector3 vector = point / units;
        unit.color = ((!(vehicle.target == obj)) ? RED : ((obj.jammer == 0 && (obj.flags & 0x8000000) == 0) ? GREEN : YELLOW));
        Vector3 vector2 = Vector3.ClampMagnitude(vector, radius);
        unit.rectTransform.anchoredPosition = new Vector2(vector2.x, vector2.z);
    }

    public void UpdateHUD(Vehicle player, int tick)
    {
        float health = GetHealth(player);
        playerHealthSlider.fillAmount = health;
        if (health < 0.3f)
        {
            playerHealthSlider.enabled = (((tick & 0x10) == 0) ? true : false);
        }
        else
        {
            playerHealthSlider.enabled = true;
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
            digits[0].enabled = true;
            digits[1].enabled = true;
            digits[0].sprite = digitSprites[(int)vigObject.maxHalfHealth / 10];
            digits[1].sprite = digitSprites[(int)vigObject.maxHalfHealth % 10];
            slots[0].sprite = slotSprites[0];
            slots[1].sprite = slotSprites[0];
            slots[2].sprite = slotSprites[0];
            slots[player.weaponSlot].sprite = slotSprites[1];
        }
        else
        {
            weaponRect.enabled = false;
            digits[0].enabled = false;
            digits[1].enabled = false;
        }
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

    public Flash FUN_4E414(Vector3Int param1, Color32 param2)
    {
        Flash result;
        if (GameManager.instance.screenMode == _SCREEN_MODE.Whole)
        {
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
