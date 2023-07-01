using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Rewired;
using System.IO;
using UnityEngine.SceneManagement;
using Time = UnityEngine.Time;
using System.Threading.Tasks;
using Unity.Burst;
using Beebyte;
using Beebyte.Obfuscator;
using System;
using Random = UnityEngine.Random;
using UnityEngine.Networking;

[SkipRename]
[Serializable]
public class TrackList
{
    public string[] list;
    public TrackList[] tracks;
}

[Serializable]
public class TrackElement
{
    public string audioClipName;
    public string audioClipPath;
    public AudioClip audioClip;
}

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
    [SerializeField]
    private List<TKey> trackList = new List<TKey>();

    [SerializeField]
    private List<TValue> trackElement = new List<TValue>();

    public void OnBeforeSerialize()
    {
        trackList.Clear();
        trackElement.Clear();

        foreach (var pair in this)
        {
            trackList.Add(pair.Key);
            trackElement.Add(pair.Value);
        }
    }

    public void OnAfterDeserialize()
    {
        this.Clear();

        if (trackList.Count != trackElement.Count)
        {
            Debug.LogError("Error al deserializar el diccionario. La cantidad de claves y valores no coincide.");
            return;
        }

        for (int i = 0; i < trackList.Count; i++)
        {
            this[trackList[i]] = trackElement[i];
        }
    }
}

[BurstCompile]
public class MusicManager : MonoBehaviour
{
    [Header("Asset")]
    public CanvasGroup canvas;
    public float fadeDuration = 2f;
    public float currentSceneProgress;
    public static MusicManager instance;
    public TrackList musicList;
    public AudioSource music;
    public Dropdown musicDropdown;
    public Toggle musicToggle;
    public int listID;
    public bool play;
    public int rndList;
    public int rndTrack;
    public bool musicClipsPreloaded = false;
    private Player player;

    [SerializeField]
    private SerializableDictionary<string, TrackElement> musicClips = new SerializableDictionary<string, TrackElement>();

    private Task preloadCoroutine;

    private string canvasKey = "CanvasLink";
    private string musicDropdownKey = "MusicDropdownLink";
    private string musicToggleKey = "MusicToggleLink";

    public bool pressed = false;

    private static int previousDropdownValue;
    private static bool previousToggleValue;

    public bool setDropdown = true;

    public bool P = false;
    public bool O = false;
    public bool isDev = false;

    public float playResume = 0f;

    public float fadeTrack = 2f;

    public bool isFading = false;
    public string songPlay = "";
    public bool isLoading = false;

    public bool noLobby = false;


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

    public async void SetMusic()
    {
        if (GameManager.instance.inDebug)
        {
            musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
        }
        play = musicToggle.isOn;
        listID = musicDropdown.value;
        previousDropdownValue = musicDropdown.value;
        previousToggleValue = musicToggle.isOn;

        PlayerPrefs.SetInt("MusicDropdownValue", musicDropdown.value);
        PlayerPrefs.SetInt("MusicToggleValue", musicToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();

        await PlayNextMusic();
    }

    private void OnEnable()
    {
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

        musicClips = new SerializableDictionary<string, TrackElement>();
        musicClipsPreloaded = false;
        DontDestroyOnLoad(this.gameObject);
    }
    private async Task FadeCanvasGroup()
    {
        canvas.interactable = true;
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            canvas.alpha = alpha;
            await Task.Yield(); // Esperar un frame
            elapsedTime += Time.deltaTime;
        }
        canvas.alpha = 1f; // Asegúrate de establecer el valor final exactamente a 1

    }

    [Obsolete]
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            //Guardar el valor inicial del Dropdown y del Toggle
            previousDropdownValue = musicDropdown.value;
            previousToggleValue = musicToggle.isOn;
        }
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

        music = gameObject.GetComponent<AudioSource>();
        music.Stop();
        music.playOnAwake = false;
        music.loop = true;
        music.volume = 0.5f;

        if (!musicClipsPreloaded)
            preloadCoroutine = PreloadMusicClips();
    }
    private void SetupDropdownOptions()
    {
        List<string> dropdownOptions = new List<string>();

        // Agregar los elementos de opciones iniciales
        dropdownOptions.Add("Totally Random");

        for (int i = 0; i < musicList.tracks.Length; i++)
        {
            string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);

            if (folderName == "Music\\V82DCProto")
            {
                dropdownOptions.Add("V8:2O DC Beta");
            }
            else if (folderName == "Music\\V82PS1")
            {
                dropdownOptions.Add("V8:2O PS1");
            }
            else if (folderName == "Music\\V81PS1")
            {
                dropdownOptions.Add("V8 PS1");
            }
            else if (folderName == "Music\\V82N64")
            {
                dropdownOptions.Add("V8:2O N64");
            }
            else if (folderName == "Music\\V81N64")
            {
                dropdownOptions.Add("V8 N64");
            }
            else
            {
                folderName = folderName.Replace("Music\\", ""); // Eliminar el prefijo "Music/"
                dropdownOptions.Add(folderName);
            }
        }

        musicDropdown.ClearOptions();
        musicDropdown.AddOptions(dropdownOptions);

        SaveDropdownOptions();
    }
    public void SaveDropdownOptions()
    {
        // Obtén las opciones del Dropdown
        List<string> dropdownOptions = new List<string>();
        foreach (Dropdown.OptionData option in musicDropdown.options)
        {
            dropdownOptions.Add(option.text);
        }

        // Convierte las opciones en una cadena separada por comas
        string optionsString = string.Join(",", dropdownOptions);

        // Guarda la cadena de opciones en PlayerPrefs
        PlayerPrefs.SetString("DropdownOptions", optionsString);
        PlayerPrefs.Save();
    }

    public void LoadDropdownOptions()
    {
        // Obtén la cadena de opciones guardada en PlayerPrefs
        string optionsString = PlayerPrefs.GetString("DropdownOptions", "");

        // Divide la cadena en elementos individuales utilizando el delimitador (coma)
        string[] options = optionsString.Split(',');

        // Limpia las opciones actuales del Dropdown
        musicDropdown.ClearOptions();

        // Agrega las opciones guardadas al Dropdown
        List<Dropdown.OptionData> dropdownOptions = new List<Dropdown.OptionData>();
        foreach (string option in options)
        {
            dropdownOptions.Add(new Dropdown.OptionData(option));
        }
        musicDropdown.AddOptions(dropdownOptions);
    }

    private async void Update()
    {
        //cambiar para otros Menus
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            noLobby = false;
            //Obtener los enlaces guardados en PlayerPrefs
            string canvasLink = PlayerPrefs.GetString(canvasKey);
            string musicDropdownLink = PlayerPrefs.GetString(musicDropdownKey);
            string musicToggleLink = PlayerPrefs.GetString(musicToggleKey);

            if (canvas == GameObject.Find(canvasLink)?.GetComponent<CanvasGroup>())
            {
                //Buscar los GameObjects en función de los enlaces guardados
                canvas = GameObject.Find(canvasLink)?.GetComponent<CanvasGroup>();
            }

            if (musicDropdown == null)
            {
                musicDropdown = GameObject.Find(musicDropdownLink)?.GetComponent<Dropdown>();
            }
            else
            {
                if (setDropdown)
                {
                    LoadDropdownOptions();

                    int savedDropdownValue = PlayerPrefs.GetInt("MusicDropdownValue", 0);
                    musicDropdown.value = savedDropdownValue;

                    int savedToggleValue = PlayerPrefs.GetInt("MusicToggleValue", musicToggle.isOn ? 1 : 0);
                    musicToggle.isOn = savedToggleValue == 1;

                    if (GameManager.instance.inDebug)
                    {
                        musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
                    }

                    setDropdown = false;
                }

                if (musicDropdown.value != previousDropdownValue)
                {
                    SetMusic();
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
                }
            }

            if (musicClipsPreloaded)
            {
                if (canvas == null)
                {
                    canvas = GameObject.Find("Canvas")?.GetComponent<CanvasGroup>();
                }
                else
                {
                    canvas.alpha = 1f;
                    canvas.interactable = true;
                }
            }
        }
        else
        {
            noLobby = true;
            if (!setDropdown)
            {
                setDropdown = true;
            }
        }

        if (player.GetButton("L3") && player.GetButton("R3") && !pressed)
        {
            pressed = true;
            await PlayNextMusic();
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
                if (noLobby) //Si no es el Lobby
                    if (play) //Si esta activa la reproduccion
                        // Verificar si el audio ha terminado de reproducirse
                        if (music)
                            if (GameManager.instance.isWait)
                                if (musicClips.Count != 0)
                                    if (music.clip != null)
                                        if (music.time >= music.clip.length)
                                        {
                                            Debug.Log("Finalizo...reproducir siguiente");
                                            await PlayNextMusic();
                                        }
            }
        }
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.O) && isDev)
        {
            isFading = false;
        }

        if (Input.GetKeyDown(KeyCode.P) && !Input.GetKeyDown(KeyCode.O) && isDev)
        {
            P = true;
            await PlayNextMusic();
        }
        else if (!Input.GetKeyDown(KeyCode.P) && Input.GetKeyDown(KeyCode.O))
        {
            O = true;
            await PlayNextMusic();
        }
    }

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

    public async void PlayMusic()
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
                songPlay = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay].audioClip;
                music.clip = randomClip;
                StartCoroutine(FadeOutAndIn(music.clip));

            }
            else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
            {
                int index = listID - 1;
                if (musicList.tracks[index].list.Length > 0)
                {
                    rndTrack = Random.Range(0, musicList.tracks[index].list.Length);
                    songPlay = musicList.tracks[index].list[rndTrack];
                    AudioClip randomClip = musicClips[songPlay].audioClip;
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
            await PlayNextMusicAfterClipDuration(music.clip.length);
        }
    }
    public async Task PlayNextMusicAfterClipDuration(float clipDuration)
    {
        await Task.Delay(TimeSpan.FromSeconds(clipDuration));
        await PlayNextMusic();
    }

    public async Task PlayNextMusic()
    {
        if (!musicClipsPreloaded || isFading)
        {
            Debug.Log("Music clips are not preloaded yet.");
            return;
        }

        if (play && musicClips.Count > 0)
        {
            if (listID == 0)
            {
                rndList = Random.Range(0, musicList.tracks.Length);
                rndTrack = (rndTrack + 1) % musicList.tracks[rndList].list.Length;
                songPlay = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay].audioClip;
                music.clip = randomClip;
                //StartCoroutine(FadeOutAndIn(music.clip));
                await PlayNextMusicWithFadeAsync();
            }
            else if (listID > 0 && listID <= musicList.tracks.Length)
            {
                int index = listID - 1;
                if (musicList.tracks[index].list.Length > 0)
                {
                    rndTrack = (rndTrack + 1) % musicList.tracks[index].list.Length;
                    songPlay = musicList.tracks[index].list[rndTrack];
                    AudioClip randomClip = musicClips[songPlay].audioClip;
                    music.clip = randomClip;
                    //StartCoroutine(FadeOutAndIn(music.clip));
                    await PlayNextMusicWithFadeAsync();
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

    public async Task PlayNextMusicWithFadeAsync()
    {
        isFading = true;
        //Desvanecer la música actual
        float elapsedTime = 0f;
        float startVolume = music.volume;
        while (elapsedTime < fadeTrack)
        {
            float normalizedTime = elapsedTime / fadeTrack;
            music.volume = Mathf.Lerp(startVolume, 0f, normalizedTime);
            elapsedTime += Time.deltaTime;
            await Task.Yield(); // Esperar un frame

        }

        music.Stop();

        //Reproducir la siguiente pista
        if (listID == 0) // Lista aleatoria
        {
            rndList = Random.Range(0, musicList.tracks.Length);
            rndTrack = (rndTrack + 1) % musicList.tracks[rndList].list.Length;
            songPlay = musicList.tracks[rndList].list[rndTrack];
            AudioClip randomClip = musicClips[songPlay].audioClip;
            music.clip = randomClip;
        }
        else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
        {
            int index = listID - 1;
            if (musicList.tracks[index].list.Length > 0)
            {
                rndTrack = (rndTrack + 1) % musicList.tracks[index].list.Length;
                songPlay = musicList.tracks[index].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay].audioClip;
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
        if (SceneManager.GetActiveScene().name != "MENU-Driver" && SceneManager.GetActiveScene().name != "DEBUG-Online" && SceneManager.GetActiveScene().name != "LoadScene")
        {
            string path = songPlay;
            string trackName = Path.GetFileNameWithoutExtension(path);

            // Eliminar parte de la dirección si es necesario
            for (int i = 0; i < musicList.tracks.Length; i++)
            {
                string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
                trackName = trackName.Replace(folderName, "");
            }
            // Eliminar caracteres especiales
            trackName = trackName.Replace(".", " ");
            trackName = trackName.Replace("/", " ");
            trackName = trackName.Replace("\\", " ");
            trackName = trackName.Replace("'", " ");
            trackName = trackName.Replace("(", " ");
            trackName = trackName.Replace(")", " ");
            trackName = trackName.Replace("-", " ");

            // Eliminar dígitos al principio del nombre (dos caracteres)
            if (trackName.Length >= 2 && char.IsDigit(trackName[0]) && char.IsDigit(trackName[1]))
            {
                trackName = trackName.Substring(2);
            }

            string str = trackName;
            Debug.Log("Sonando..." + path + " track: " + rndList + " list: " + rndTrack);
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
            await Task.Yield(); // Esperar un frame
        }

        if (P = isDev)
        {
            Debug.Log("Resume Audio: " + playResume);
            P = false;

        }
        else if (O = isDev)
        {
            Debug.Log("Load Audio: " + music.clip);
            O = false;
        }
        else
        {
            Debug.Log("Load music..." + music.clip);
            music.volume = startVolume;
            music.Play(); // Mover la reproducción aquí
        }
        isFading = false;
    }

    [Obsolete]
    private async Task PreloadMusicClips()
    {
        // Obtener la lista de pistas de audio disponibles actualmente
        await GetAvailableMusicList();

        //Finalizar la carga de pistas de audio
        {

            if (GameManager.instance.inDebug)
            {
                await FadeCanvasGroup();
            }
            musicClipsPreloaded = true;
            if (musicClipsPreloaded)
            {
                if (SceneManager.GetActiveScene().name != "MENU-Driver" && SceneManager.GetActiveScene().name != "DEBUG-Online" && SceneManager.GetActiveScene().name != "LoadScene")
                {
                    string path = musicList.tracks[rndList].list[rndTrack];
                    string trackName = Path.GetFileNameWithoutExtension(path);
                    await PlayNextMusic();

                    // Eliminar parte de la dirección si es necesario
                    for (int i = 0; i < musicList.tracks.Length; i++)
                    {
                        string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
                        trackName = trackName.Replace(folderName, "");
                    }
                    // Eliminar caracteres especiales
                    trackName = trackName.Replace(".", " ");
                    trackName = trackName.Replace("/", " ");
                    trackName = trackName.Replace("\\", " ");
                    trackName = trackName.Replace("'", " ");
                    trackName = trackName.Replace("(", " ");
                    trackName = trackName.Replace(")", " ");
                    trackName = trackName.Replace("-", " ");

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
                //cambiar para otros Menus
                else if (SceneManager.GetActiveScene().name == "MENU-Driver" || SceneManager.GetActiveScene().name == "DEBUG-Online" || SceneManager.GetActiveScene().name == "LoadScene")
                {
                    string path = musicList.tracks[0].list[0];
                    string trackName = Path.GetFileNameWithoutExtension(path);
                    await PlayNextMusic();
                }
            }
        }
    }

    private string GetRelativePath(string absolutePath, string basePath)
    {
        // Obtener la ruta relativa de un archivo o carpeta en relación a una carpeta base
        Uri baseUri = new Uri(basePath + "/");
        Uri absoluteUri = new Uri(absolutePath);
        Uri relativeUri = baseUri.MakeRelativeUri(absoluteUri);
        return Uri.UnescapeDataString(relativeUri.ToString());
    }

    [Obsolete]
    private async Task GetAvailableMusicList()
    {
        List<string> availableMusicList = new List<string>();
        string streamingAssetsPath = Application.streamingAssetsPath;

        string[] audioExtensions = { "*.ogg", "*.wav", "*.mp3", "*.flac", "*.aiff", "*.mod" };
        Dictionary<string, List<string>> trackDictionary = new Dictionary<string, List<string>>();

        foreach (string extension in audioExtensions)
        {
            string[] audioFiles = Directory.GetFiles(streamingAssetsPath, extension, SearchOption.AllDirectories);
            await ProcessAudioFilesCoroutine(audioFiles, streamingAssetsPath, trackDictionary, availableMusicList);
        }

        musicList.tracks = new TrackList[trackDictionary.Count];
        int index = 0;

        foreach (var kvp in trackDictionary)
        {
            musicList.tracks[index] = new TrackList();
            musicList.tracks[index].list = kvp.Value.ToArray();
            index++;
        }
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SetupDropdownOptions();
    }

    [Obsolete]
    private async Task ProcessAudioFilesCoroutine(string[] audioFiles, string streamingAssetsPath, Dictionary<string, List<string>> trackDictionary, List<string> availableMusicList)
    {
        foreach (string audioFilePath in audioFiles)
        {
            string folderPath = Path.GetDirectoryName(audioFilePath);
            string relativePath = GetRelativePath(audioFilePath, streamingAssetsPath);

            if (trackDictionary.ContainsKey(folderPath))
            {
                trackDictionary[folderPath].Add(relativePath);
            }
            else
            {
                trackDictionary[folderPath] = new List<string> { relativePath };
            }

            availableMusicList.Add(relativePath);

            await LoadMusicClipFromFilePathAsync(audioFilePath, relativePath);
        }
    }

    [Obsolete]
    private async Task LoadMusicClipFromFilePathAsync(string filePath, string relativePath)
    {
        string trackName = Path.GetFileNameWithoutExtension(relativePath);

        string url;
#if UNITY_ANDROID && !UNITY_EDITOR
    url = Path.Combine(Application.streamingAssetsPath, filePath);
#else
        url = "file://" + filePath;
#endif

        using (var webRequest = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.UNKNOWN))
        {
            TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
            // Envía la solicitud
            var asyncOperation = webRequest.SendWebRequest();

            // Espera a que se complete la solicitud
            asyncOperation.completed += (operation) =>
            {
                if (!webRequest.isNetworkError && !webRequest.isHttpError)
                {
                    AudioClip audioClip = DownloadHandlerAudioClip.GetContent(webRequest);
                    Debug.Log("Audio clip loaded: " + relativePath);

                    TrackElement trackElement = new TrackElement();
                    trackElement.audioClipName = trackName;
                    trackElement.audioClipPath = relativePath;
                    trackElement.audioClip = audioClip;

                    musicClips.Add(relativePath, trackElement);

                    if (preloadCoroutine != null)
                    {
                        float progress = (float)musicClips.Count / 63f;
                        currentSceneProgress = progress;
                    }
                }
                else
                {
                    Debug.LogError("Error al cargar el archivo de audio: " + filePath);
                    Debug.Log("Error loading audio clip: " + webRequest.error);
                }

                taskCompletionSource.SetResult(true);
            };

            await taskCompletionSource.Task;
        }
    }



    [Header("Progres Bar")]
    public Texture2D progressBarTexture;
    public float progressBarWidth = Screen.width; //Ancho total de la barra de progreso
    public float progressBarHeight = 20f; //Alto de la barra de progreso
    public float slideSpeed = 200f; //Velocidad de deslizamiento del slide
    public float progress = 0f; //Progreso actual de la barra

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
        //...
    }
}