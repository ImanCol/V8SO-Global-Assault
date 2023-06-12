using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections.Generic;
using Rewired;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class TrackList
{
    public string[] list;
    public TrackList[] tracks;
}

public class MusicManager : MonoBehaviour
{
    public CanvasGroup canvas;
    public float fadeDuration = 2f;
    public Texture2D progressBarTexture;
    private float currentSceneProgress;
    public static MusicManager instance;
    public TrackList musicList;
    public AudioSource music;
    public Dropdown musicDropdown;
    public Toggle musicToggle;
    public int listID;
    public bool play;
    private int rndList;
    private int rndTrack;
    public bool musicClipsPreloaded = false;
    private Player player;

    private Dictionary<string, AudioClip> musicClips = new Dictionary<string, AudioClip>();
    private Coroutine preloadCoroutine;

    private string canvasKey = "CanvasLink";
    private string musicDropdownKey = "MusicDropdownLink";
    private string musicToggleKey = "MusicToggleLink";

    private string GetGameObjectLink(Component component)
    {
        if (component != null)
        {
            GameObject linkedGameObject = component.gameObject;
            if (linkedGameObject != null)
            {
                return linkedGameObject.name;
            }
        }
        return string.Empty;
    }

    public void SetMusic()
    {

        if (GameManager.instance.inDebug)
            musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
        play = musicToggle.isOn;
        listID = musicDropdown.value;
        PlayNextMusic();
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            player = ReInput.players.GetPlayer(0);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private IEnumerator FadeCanvasGroup()
    {
        canvas.interactable = true;
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            canvas.alpha = alpha;
            yield return null;
            elapsedTime += Time.deltaTime;
        }
        canvas.alpha = 1f; // Asegúrate de establecer el valor final exactamente a 1
    }

    private void Start()
    {
        //Guardar el valor inicial del Dropdown y del Toggle
        previousDropdownValue = musicDropdown.value;
        previousToggleValue = musicToggle.isOn;

        // Guardar los enlaces de los GameObjects en PlayerPrefs
        if (canvas != null)
        {
            string canvasLink = GetGameObjectLink(canvas);
            PlayerPrefs.SetString(canvasKey, canvasLink);
        }

        if (musicDropdown != null)
        {
            string musicDropdownLink = GetGameObjectLink(musicDropdown);
            PlayerPrefs.SetString(musicDropdownKey, musicDropdownLink);
        }

        if (musicToggle != null)
        {
            string musicToggleLink = GetGameObjectLink(musicToggle);
            PlayerPrefs.SetString(musicToggleKey, musicToggleLink);
        }

        music = gameObject.AddComponent<AudioSource>();
        music.Stop();
        music.playOnAwake = false;
        music.loop = true;
        music.volume = 0.75f;

        LoadMusicList();
        SetupDropdownOptions();

        if (!musicClipsPreloaded)
            StartCoroutine(PreloadMusicClips());
    }

    private void SetupDropdownOptions()
    {
        List<string> dropdownOptions = new List<string>();
        dropdownOptions.Add("Totally Random"); // Opción 0 para lista aleatoria

        for (int i = 0; i < musicList.tracks.Length; i++)
        {
            string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
            Debug.Log("folderName: " + folderName);
            if (folderName == "Music\\V82DCProto" || folderName == "Music\\V82PS1" || folderName == "Music\\V81PS1"
                || folderName == "Music\\V82N64" || folderName == "Music\\V81N64")
            {
                dropdownOptions.Add(musicDropdown.options[i + 1].text);
                Debug.Log("Paso...: " + musicDropdown.options[i].text);
            }
            else
            {
                folderName = folderName.Replace("Music\\", ""); // Eliminar el prefijo "Music/"
                dropdownOptions.Add(folderName);
            }
        }
        musicDropdown.ClearOptions();
        musicDropdown.AddOptions(dropdownOptions);
    }

    private bool pressed = false;

    private static int previousDropdownValue;
    private static bool previousToggleValue;

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            //Obtener los enlaces guardados en PlayerPrefs
            string canvasLink = PlayerPrefs.GetString(canvasKey);
            string musicDropdownLink = PlayerPrefs.GetString(musicDropdownKey);
            string musicToggleLink = PlayerPrefs.GetString(musicToggleKey);

            //Buscar los GameObjects en función de los enlaces guardados
            canvas = GameObject.Find(canvasLink)?.GetComponent<CanvasGroup>();

            if (musicDropdown == null)
            {
                musicDropdown = GameObject.Find(musicDropdownLink)?.GetComponent<Dropdown>();
            }
            else
            {
                if (musicDropdown.value != previousDropdownValue)
                {
                    SetMusic();
                    previousDropdownValue = musicDropdown.value; //Actualizar el valor previo
                }
            }

            if (musicToggle == null)
            {
                musicToggle = GameObject.Find(musicToggleLink)?.GetComponent<Toggle>();
            }
            else
            {
                //Comprobar si el valor del Toggle ha cambiado
                if (musicToggle.isOn != previousToggleValue)
                {
                    SetMusic();
                    previousToggleValue = musicToggle.isOn; //Actualizar el valor previo
                }
            }

            if (musicClipsPreloaded)
            {
                canvas.alpha = 1f;
                canvas.interactable = true;
            }
        }

        if (player.GetButton("L3") && player.GetButton("R3") && !pressed)
        {
            pressed = true;
            PlayNextMusic();
        }

        if (!player.GetButton("L3") || !player.GetButton("R3"))
        {
            pressed = false;
        }

        if (music.isPlaying && !isFading)
        {
            //Debug.Log("Reproduciendo...");
        }
        else
        {
            if (musicClipsPreloaded)
            {
                if (nolist)
                    // Verificar si el audio ha terminado de reproducirse
                    if (music.time >= music.clip.length)
                    {
                        Debug.Log("Finalizo...reproducir siguiente");
                        PlayNextMusic();
                    }
            }
        }

        //Actualizar el progreso de la barra (debe estar entre 0 y 1)
        //progress += Time.deltaTime * 0.5f; // Solo para demostración, puedes modificar esto según tus necesidades
        //progress = Mathf.Clamp01(progress);

    }

    public float fadeTrack = 2f;

    private IEnumerator FadeOutAndIn(AudioClip newClip)
    {
        float elapsedTime = 0f;
        float startVolume = music.volume;

        while (elapsedTime < fadeTrack)
        {
            float normalizedTime = elapsedTime / fadeTrack;
            music.volume = Mathf.Lerp(startVolume, 0f, normalizedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        music.Stop();
        music.clip = newClip;
        music.Play();

        elapsedTime = 0f;
        while (elapsedTime < fadeTrack)
        {
            float normalizedTime = elapsedTime / fadeTrack;
            music.volume = Mathf.Lerp(0f, startVolume, normalizedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        music.volume = startVolume;
    }

    public void PlayMusic()
    {
        if (!musicClipsPreloaded)
        {
            Debug.Log("Music clips are not preloaded yet.");
            return;
        }

        if (play && musicClips.Count > 0)
        {
            if (listID == 0) // Lista aleatoria
            {
                rndList = Random.Range(0, musicList.tracks.Length);
                rndTrack = Random.Range(0, musicList.tracks[rndList].list.Length);
                string randomTrackPath = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[randomTrackPath];
                music.clip = randomClip;
                StartCoroutine(FadeOutAndIn(music.clip));

            }
            else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
            {
                int index = listID - 1;
                if (musicList.tracks[index].list.Length > 0)
                {
                    rndTrack = Random.Range(0, musicList.tracks[index].list.Length);
                    string randomTrackPath = musicList.tracks[index].list[rndTrack];
                    AudioClip randomClip = musicClips[randomTrackPath];
                    music.clip = randomClip;
                    StartCoroutine(FadeOutAndIn(music.clip));
                }
                else
                {
                    Debug.Log("No tracks found in the selected list.");
                }
            }
            else
            {
                Debug.Log("Invalid music list ID.");
            }
            // Llamar a PlayNextMusic() al final del método
            StartCoroutine(PlayNextMusicAfterClipDuration(music.clip.length));

        }
    }
    private IEnumerator PlayNextMusicAfterClipDuration(float clipDuration)
    {
        yield return new WaitForSeconds(clipDuration);
        PlayNextMusic();
    }
    private bool isFading = false;

    public void PlayNextMusic()
    {
        if (!musicClipsPreloaded || isFading) // Si los clips de música no se han cargado completamente o se está realizando un fundido, no reproducir la siguiente pista
        {
            Debug.Log("Music clips are not preloaded yet.");
            return;
        }
        if (play && musicClips.Count > 0)
        {
            if (listID == 0) // Lista aleatoria
            {
                rndList = Random.Range(0, musicList.tracks.Length);
                rndTrack = (rndTrack + 1) % musicList.tracks[rndList].list.Length;
                string randomTrackPath = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[randomTrackPath];
                music.clip = randomClip;
                //StartCoroutine(FadeOutAndIn(music.clip));
                StartCoroutine(PlayNextMusicWithFade());

            }
            else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
            {
                int index = listID - 1;
                if (musicList.tracks[index].list.Length > 0)
                {
                    rndTrack = (rndTrack + 1) % musicList.tracks[index].list.Length;
                    string randomTrackPath = musicList.tracks[index].list[rndTrack];
                    AudioClip randomClip = musicClips[randomTrackPath];
                    music.clip = randomClip;
                    //StartCoroutine(FadeOutAndIn(music.clip));
                    StartCoroutine(PlayNextMusicWithFade());

                }
                else
                {
                    Debug.Log("No tracks found in the selected list.");
                }
            }
            else
            {
                Debug.Log("Invalid music list ID.");
            }
        }

    }

    private IEnumerator PlayNextMusicWithFade()
    {
        isFading = true;

        // Desvanecer la música actual
        float elapsedTime = 0f;
        float startVolume = music.volume;
        while (elapsedTime < fadeTrack)
        {
            float normalizedTime = elapsedTime / fadeTrack;
            music.volume = Mathf.Lerp(startVolume, 0f, normalizedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        music.Stop();

        // Reproducir la siguiente pista
        if (listID == 0) // Lista aleatoria
        {
            rndList = Random.Range(0, musicList.tracks.Length);
            rndTrack = (rndTrack + 1) % musicList.tracks[rndList].list.Length;
            string randomTrackPath = musicList.tracks[rndList].list[rndTrack];
            AudioClip randomClip = musicClips[randomTrackPath];
            music.clip = randomClip;
        }
        else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
        {
            int index = listID - 1;
            if (musicList.tracks[index].list.Length > 0)
            {
                rndTrack = (rndTrack + 1) % musicList.tracks[index].list.Length;
                string randomTrackPath = musicList.tracks[index].list[rndTrack];
                AudioClip randomClip = musicClips[randomTrackPath];
                music.clip = randomClip;
            }
            else
            {
                Debug.Log("No tracks found in the selected list.");
            }
        }
        else
        {
            Debug.Log("Invalid music list ID.");
        }

        Debug.Log("Music clip loaded successfully.");
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            string path = musicList.tracks[rndList].list[rndTrack];
            string trackName = Path.GetFileNameWithoutExtension(path);

            // Eliminar parte de la dirección si es necesario
            for (int i = 0; i < musicList.tracks.Length; i++)
            {
                string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
                trackName = trackName.Replace(folderName, "");
            }
            // Eliminar caracteres especiales
            trackName = trackName.Replace(".", "");
            trackName = trackName.Replace("/", "");
            trackName = trackName.Replace("\\", "");
            trackName = trackName.Replace("'", "");
            trackName = trackName.Replace("(", "");
            trackName = trackName.Replace(")", "");

            // Eliminar dígitos al principio del nombre (dos caracteres)
            if (trackName.Length >= 2 && char.IsDigit(trackName[0]) && char.IsDigit(trackName[1]))
            {
                trackName = trackName.Substring(2);
            }

            string str = trackName;
            UIMessage.instance.track = true;
            IEnumerator routineTrack = UIMessage.instance.PrintfTrack(str + " Played!");
            UIMessage.instance.StopAllCoroutines();
            UIMessage.instance.StartCoroutine(routineTrack);
        }
        else
        {
            rndList = 0;
            rndTrack = 0;
        }


        elapsedTime = 0f;
        while (elapsedTime < fadeTrack)
        {
            float normalizedTime = elapsedTime / fadeTrack;
            music.volume = Mathf.Lerp(0f, startVolume, normalizedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        music.volume = startVolume;
        music.Play(); // Mover la reproducción aquí

        isFading = false;
    }

    private IEnumerator PreloadMusicClips()
    {
        preloadCoroutine = StartCoroutine(PreloadCoroutine());
        yield return preloadCoroutine;

        musicClipsPreloaded = true;
        StartCoroutine(FadeCanvasGroup());

        if (musicClipsPreloaded)
        {
            Debug.Log("Music clip loaded successfully.");
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                string path = musicList.tracks[rndList].list[rndTrack];
                string trackName = Path.GetFileNameWithoutExtension(path);
                PlayNextMusic();

                // Eliminar parte de la dirección si es necesario
                for (int i = 0; i < musicList.tracks.Length; i++)
                {
                    string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
                    trackName = trackName.Replace(folderName, "");
                }
                // Eliminar caracteres especiales
                trackName = trackName.Replace(".", "");
                trackName = trackName.Replace("/", "");
                trackName = trackName.Replace("\\", "");
                trackName = trackName.Replace("'", "");
                trackName = trackName.Replace("(", "");
                trackName = trackName.Replace(")", "");

                // Eliminar dígitos al principio del nombre (dos caracteres)
                if (trackName.Length >= 2 && char.IsDigit(trackName[0]) && char.IsDigit(trackName[1]))
                {
                    trackName = trackName.Substring(2);
                }
                string str = trackName;
                UIMessage.instance.track = true;
                IEnumerator routineTrack = UIMessage.instance.PrintfTrack(str + " Played!");
                UIMessage.instance.StopAllCoroutines();
                UIMessage.instance.StartCoroutine(routineTrack);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                string path = musicList.tracks[0].list[0];
                string trackName = Path.GetFileNameWithoutExtension(path);
                PlayNextMusic();
            }
        }
    }
    private IEnumerator PreloadCoroutine()
    {
        foreach (TrackList trackList in musicList.tracks)
        {
            foreach (string trackPath in trackList.list)
            {
                if (!musicClips.ContainsKey(trackPath))
                {
                    yield return StartCoroutine(LoadAudioClip(trackPath));
                }
            }
        }

        musicClipsPreloaded = true; // Actualizar el estado de carga de los clips de música
    }

    private bool nolist = false;

    private IEnumerator LoadAudioClip(string trackPath)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, trackPath);
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(filePath, AudioType.OGGVORBIS))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogWarning(www.error);
                musicClipsPreloaded = false;
                nolist = false;
                yield break;
            }

            AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
            musicClips.Add(trackPath, clip);

            if (preloadCoroutine != null)
            {
                float progress = (float)musicClips.Count / 63f;
                currentSceneProgress = progress;
            }
        }
    }

    private float progressBarWidth = Screen.width; //Ancho total de la barra de progreso
    private float progressBarHeight = 20f; //Alto de la barra de progreso
    private float slideSpeed = 200f; //Velocidad de deslizamiento del slide
    private float progress = 0f; //Progreso actual de la barra

    private void OnGUI()
    {
        if (!musicClipsPreloaded) //Solo dibujar la barra de progreso si los clips de música no se han cargado completamente
        {
            //Calcular la posición de la barra de progreso en la pantalla
            float progressBarX = (Screen.width - progressBarWidth) / 2f; // Centrado horizontal
            float progressBarY = (Screen.height - progressBarHeight) / 15f; // Centrado vertical
            Rect progressBarRect = new Rect(progressBarX, progressBarY, progressBarWidth, progressBarHeight);

            //Calcular la cantidad de mosaicos completos y el progreso dentro del mosaico actual
            int completeTiles = Mathf.FloorToInt(currentSceneProgress * progressBarWidth / progressBarTexture.width);
            float partialTileProgress = (currentSceneProgress * progressBarWidth) % progressBarTexture.width;

            //Dibujar los mosaicos completos
            for (int i = 0; i < completeTiles; i++)
            {
                Rect tileRect = new Rect(progressBarRect.x + i * progressBarTexture.width, progressBarRect.y, progressBarTexture.width, progressBarRect.height);
                GUI.DrawTexture(tileRect, progressBarTexture);
            }

            //Dibujar el mosaico parcial
            Rect partialTileRect = new Rect(progressBarRect.x + completeTiles * progressBarTexture.width, progressBarRect.y, partialTileProgress, progressBarRect.height);
            Rect partialTileTexCoords = new Rect(0f, 0f, partialTileProgress / progressBarTexture.width, 1f);
            GUI.DrawTextureWithTexCoords(partialTileRect, progressBarTexture, partialTileTexCoords);
        }
        else
        {
            //Eliminar la barra de progreso
            DestroyProgressBar();
        }
    }
    private void DestroyProgressBar()
    {
        progressBarTexture = null;
        //Realizar aquí cualquier acción necesaria para eliminar la barra de progreso
        //Por ejemplo, desactivar objetos, limpiar referencias, etc.
        //...
    }
    public void LoadMusicList()
    {
#if UNITY_ANDROID
             string filePath = Path.Combine(Application.streamingAssetsPath, "music.json");
    string json = "";

    if (filePath.Contains("://"))
    {
        UnityWebRequest www = UnityWebRequest.Get(filePath);
        www.SendWebRequest();
        while (!www.isDone) { }

        if (www.result == UnityWebRequest.Result.Success)
        {
            json = www.downloadHandler.text;
        }
    }
    else
    {
        json = File.ReadAllText(filePath);
    }

    musicList = JsonUtility.FromJson<MusicList>(json);
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN || UNITY_SWITCH
        string filePath = Path.Combine(Application.streamingAssetsPath, "music.json");
        string json = File.ReadAllText(filePath);
        if (json != null)
        {
            musicList = JsonUtility.FromJson<TrackList>(json);
        }
        else
        {
            Debug.LogError("Failed to load music list at path: " + filePath);
        }
#endif
    }
}