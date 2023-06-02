using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIMessage : MonoBehaviour
{
    public static UIMessage instance;
    public RectTransform hudRect;
    public GameObject characterPrefab;
    public List<Sprite> asciiSprites;
    public GameObject unitPrefab;
    public RectTransform trackFeedbackRect;
    public float printSpeed = -0.5f;
    public Image printedCharTrack;
    public List<Image> trackElements;
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
        }
    }
    public bool track = false;

    public void InstantiateCharacterTrack()
    {
        printedCharTrack = UnityEngine.Object.Instantiate(characterPrefab, trackFeedbackRect).GetComponent<Image>();
        trackElements.Add(printedCharTrack);
    }
    public void ReplaceCharacterTrack(char c)
    {
        printedCharTrack.sprite = asciiSprites[c];
        printedCharTrack.SetNativeSize();
    }

    public IEnumerator PrintfTrack(string text, bool overwrite = true)
    {
        CR_Running = true;
        if (track)
        {
            if (trackElements != null)
            {
                for (int k = 0; k < trackElements.Count; k++)
                {
                    UnityEngine.Object.DestroyImmediate(trackElements[k].gameObject, allowDestroyingAssets: false);
                }
                trackElements.Clear();
                trackElements = null;
            }
            if (trackElements == null)
            {
                trackElements = new List<Image>();
                for (int j = 0; j < text.Length; j++)
                {
                    InstantiateCharacterTrack();
                    yield return new WaitForSeconds(printSpeed);
                    ReplaceCharacterTrack(text[j]);
                }
                yield return new WaitForSeconds(5f);
                for (int j = 0; j < 128; j++)
                {
                    for (int l = 0; l < trackElements.Count; l++)
                    {
                        Color32 c = trackElements[l].color;
                        c.r--;
                        c.g--;
                        c.b--;
                        trackElements[l].color = c;
                    }
                    yield return null;
                }
                for (int m = 0; m < trackElements.Count; m++)
                {
                    UnityEngine.Object.DestroyImmediate(trackElements[m].gameObject, allowDestroyingAssets: false);
                }
                trackElements.Clear();
                trackElements = null;
                track = false;
            }
        }
        CR_Running = false;
    }

    void CreateTrackGameObject()
    {
        //Crear el GameObject "Track"
        GameObject trackGO = new GameObject("Track");

        //Añadir el componente HorizontalLayoutGroup
        HorizontalLayoutGroup layoutGroup = trackGO.AddComponent<HorizontalLayoutGroup>();

        //Configurar el HorizontalLayoutGroup
        layoutGroup.childForceExpandHeight = true;
        layoutGroup.childForceExpandWidth = false;
        layoutGroup.childAlignment = TextAnchor.MiddleCenter;
        layoutGroup.childControlWidth = false;
        layoutGroup.childControlHeight = false;

        // Hacer que el GameObject actual sea el padre de "Track"
        trackGO.transform.SetParent(transform);

        // Ajustar la escala y posición del objeto para que ocupe el ancho total del objeto actual
        RectTransform trackRect = trackGO.GetComponent<RectTransform>();
        trackRect.localScale = Vector3.one;
        trackRect.anchorMin = new Vector2(0f, 0f);
        trackRect.anchorMax = new Vector2(1f, 0f);
        trackRect.pivot = new Vector2(0.5f, 0.5f);
        trackRect.anchoredPosition = new Vector3(225, 50, 0);

        // Ajustar el SizeDelta en Left y Right
        trackRect.sizeDelta = new Vector2(-450, 100f);

        // Asignar el RectTransform del objeto "Track" a la variable trackFeedbackRect
        trackFeedbackRect = trackRect;
    }

    private void Start()
    {
        CreateTrackGameObject();
        hudRect = UIManager.instance.hudRect;
        asciiSprites = UIManager.instance.asciiSprites;
        unitPrefab = UIManager.instance.unitPrefab;
        characterPrefab = UIManager.instance.characterPrefab;
    }
}
