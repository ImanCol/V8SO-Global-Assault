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


}
