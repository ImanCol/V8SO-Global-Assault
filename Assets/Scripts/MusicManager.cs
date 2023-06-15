using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Rewired;
using System.IO;
using UnityEngine.SceneManagement;
using NVorbis;
using Time = UnityEngine.Time;

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
        {
            musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
        }
        play = musicToggle.isOn;
        listID = musicDropdown.value;
        previousDropdownValue = musicDropdown.value;
        previousToggleValue = musicToggle.isOn; //Actualizar el valor previo

        PlayerPrefs.SetInt("MusicDropdownValue", musicDropdown.value);
        PlayerPrefs.SetInt("MusicToggleValue", musicToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();

        PlayNextMusic();
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
        musicClips = new Dictionary<string, AudioClip>();
        musicClipsPreloaded = false;
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

        if (!musicClipsPreloaded)
            preloadCoroutine = StartCoroutine(PreloadMusicClips());
        //StartCoroutine(PreloadMusicClips());
    }

    private const string DropdownPrefsKey = "MusicDropdownOptions";

    private void SetupDropdownOptions()
    {
        List<string> dropdownOptions = new List<string>();

        // Agregar los elementos de opciones iniciales
        dropdownOptions.Add("Totally Random");

        for (int i = 0; i < musicList.tracks.Length; i++)
        {
            string folderName = Path.GetDirectoryName(musicList.tracks[i].list[0]);
            Debug.Log("folderName: " + folderName);

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

    private bool pressed = false;

    private static int previousDropdownValue;
    private static bool previousToggleValue;

    private bool boolSet = true;

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
                if (boolSet)
                {
                    Debug.Log("Cargar...");

                    LoadDropdownOptions();

                    int savedDropdownValue = PlayerPrefs.GetInt("MusicDropdownValue", 0);
                    musicDropdown.value = savedDropdownValue;

                    int savedToggleValue = PlayerPrefs.GetInt("MusicToggleValue", musicToggle.isOn ? 1 : 0);
                    musicToggle.isOn = savedToggleValue == 1;

                    if (GameManager.instance.inDebug)
                    {
                        musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
                    }

                    boolSet = false;
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
                canvas.alpha = 1f;
                canvas.interactable = true;
            }
        }
        else
        {
            if (!boolSet)
            {
                boolSet = true;
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
                songPlay = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay];
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
                    AudioClip randomClip = musicClips[songPlay];
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
                songPlay = musicList.tracks[rndList].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay];
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
                    songPlay = musicList.tracks[index].list[rndTrack];
                    AudioClip randomClip = musicClips[songPlay];
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

    public string songPlay = "";

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
            songPlay = musicList.tracks[rndList].list[rndTrack];
            AudioClip randomClip = musicClips[songPlay];
            music.clip = randomClip;
        }
        else if (listID > 0 && listID <= musicList.tracks.Length) // Lista específica
        {
            int index = listID - 1;
            if (musicList.tracks[index].list.Length > 0)
            {
                rndTrack = (rndTrack + 1) % musicList.tracks[index].list.Length;
                songPlay = musicList.tracks[index].list[rndTrack];
                AudioClip randomClip = musicClips[songPlay];
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
            string path = songPlay;
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
            yield return null;
        }

        music.volume = startVolume;
        music.Play(); // Mover la reproducción aquí

        isFading = false;
    }

    private IEnumerator PreloadMusicClips()
    {
        // Cargar la lista de pistas de audio almacenadas en los datos persistentes
        List<string> savedMusicList = LoadMusicListFromPersistentData();

        // Obtener la lista de pistas de audio disponibles actualmente
        List<string> currentMusicList = GetAvailableMusicList();

        // Verificar si hay cambios en la lista de pistas de audio
        if (AreMusicListsDifferent(savedMusicList, currentMusicList))
        {
            Debug.Log("La lista es diferente...");
            // Actualizar las pistas de audio en los datos persistentes
            SaveMusicListToPersistentData(currentMusicList);

            // Cargar las pistas de audio actualizadas
            yield return StartCoroutine(LoadMusicClips(currentMusicList));
        }
        else
        {
            // Cargar las pistas de audio desde los datos persistentes
            yield return StartCoroutine(LoadMusicClips(savedMusicList));
        }

        // Finalizar la carga de pistas de audio
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

    //PRecargar Audios Guardados
    private List<string> LoadMusicListFromPersistentData()
    {
        // Implementa la carga de la lista de pistas de audio desde los datos persistentes
        // Puedes utilizar archivos JSON, PlayerPrefs o una base de datos local para almacenar la lista
        // Retorna una lista de strings que representan las pistas de audio almacenadas
        // Si no hay datos persistentes, retorna una lista vacía

        // Ejemplo de carga desde PlayerPrefs
        string musicListJson = PlayerPrefs.GetString("MusicList");
        if (!string.IsNullOrEmpty(musicListJson))
        {
            Debug.Log("Carga Lista...");

            return JsonUtility.FromJson<List<string>>(musicListJson);
        }
        else
        {
            Debug.Log("Crea Lista...");
            return new List<string>();
        }
    }


    private void SaveMusicListToPersistentData(List<string> musicList)
    {
        // Implementa el guardado de la lista de pistas de audio en los datos persistentes
        // Puedes utilizar archivos JSON, PlayerPrefs o una base de datos local para almacenar la lista
        // Convierte la lista de strings a un formato adecuado para guardar (como JSON) y almacénala en los datos persistentes

        // Ejemplo de guardado en PlayerPrefs
        string musicListJson = JsonUtility.ToJson(musicList);
        Debug.Log("Guardando MusicList: " + musicListJson);
        PlayerPrefs.SetString("MusicList", musicListJson);
    }
    private List<string> GetAvailableMusicList()
    {
        List<string> availableMusicList = new List<string>();
        string streamingAssetsPath = Application.streamingAssetsPath;
        string[] audioFiles = Directory.GetFiles(streamingAssetsPath, "*.ogg", SearchOption.AllDirectories);

        Dictionary<string, List<string>> trackDictionary = new Dictionary<string, List<string>>();

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
        }

        musicList.tracks = new TrackList[trackDictionary.Count];
        int index = 0;

        foreach (var kvp in trackDictionary)
        {
            musicList.tracks[index] = new TrackList();
            musicList.tracks[index].list = kvp.Value.ToArray();
            index++;
        }

        // Verifica el Arreglo del Dropdown y lo modifica
        SetupDropdownOptions();

        Debug.Log("Lista: " + string.Join(", ", availableMusicList));

        return availableMusicList;
    }

    private IEnumerator LoadMusicClips(List<string> musicList)
    {
        string listAsString = string.Join(", ", musicList);
        foreach (string trackPath in musicList)
        {
            yield return StartCoroutine(LoadAudioClip(trackPath));
        }
    }

    private bool AreMusicListsDifferent(List<string> list1, List<string> list2)
    {
        // Verifica si dos listas de pistas de audio son diferentes
        // Compara el contenido de las listas y retorna true si son diferentes, o false si son iguales
        Debug.Log("Verifica diferencia de : " + list1 + " | en: " + list2);

        // Si la cantidad de elementos es diferente, las listas son diferentes
        if (list1.Count != list2.Count)
        {
            Debug.Log("Es diferente todas?...");
            return true;
        }

        // Verifica si hay alguna diferencia en los elementos
        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
            {
                Debug.Log("Es diferente alguna?...");
                return true;
            }
        }

        Debug.Log("La listas son iguales...");
        // Las listas son iguales
        return false;
    }

    private string GetRelativePath(string absolutePath, string basePath)
    {
        // Obtener la ruta relativa de un archivo o carpeta en relación a una carpeta base
        System.Uri baseUri = new System.Uri(basePath + "/");
        System.Uri absoluteUri = new System.Uri(absolutePath);
        System.Uri relativeUri = baseUri.MakeRelativeUri(absoluteUri);
        return System.Uri.UnescapeDataString(relativeUri.ToString());
    }

    private bool nolist = false;
    private IEnumerator LoadAudioClip(string trackPath)
    {
        Debug.Log("Cargando Pista: " + trackPath);
        string filePath = Path.Combine(Application.streamingAssetsPath, trackPath);
        Debug.Log("Ruta Pista: " + filePath);
        AudioClip audioClip = null;

#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_SWITCH
        yield return StartCoroutine(LoadAudioClipLocalAsync(filePath, result =>
        {
            audioClip = result;
        }));
#elif UNITY_ANDROID
        yield return StartCoroutine(LoadAudioClipAndroidAsync(filePath, result =>
        {
            audioClip = result;
        }));
#elif UNITY_IOS
        yield return StartCoroutine(LoadAudioClipIOSAsync(filePath, result =>
        {
            audioClip = result;
        }));
#else
        Debug.LogError("Error Load Music: Platform not supported");
        yield break;
#endif

        if (audioClip == null)
        {
            Debug.LogError("Error Load Music: Failed to load AudioClip: " + trackPath);
            musicClipsPreloaded = false;
            nolist = false;
            yield break;
        }

        Debug.Log("Load AudioClip...");
        musicClips.Add(trackPath, audioClip);

        if (preloadCoroutine != null)
        {
            float progress = (float)musicClips.Count / 63f;
            currentSceneProgress = progress;
        }
    }

    private IEnumerator LoadAudioClipLocalAsync(string filePath, System.Action<AudioClip> callback)
    {
        if (File.Exists(filePath))
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var reader = new VorbisReader(stream, true);
                int channels = reader.Channels;
                int sampleRate = reader.SampleRate;
                int sampleCount = (int)reader.TotalSamples;
                float[] audioData = new float[sampleCount * channels];
                int sampleOffset = 0;
                int sampleRead;
                while ((sampleRead = reader.ReadSamples(audioData, sampleOffset, audioData.Length - sampleOffset)) > 0)
                {
                    sampleOffset += sampleRead;
                    yield return null; // Permitir que el juego continúe en cada iteración para evitar bloqueos
                }
                AudioClip audioClip = AudioClip.Create("AudioClip", sampleCount, channels, sampleRate, false);
                audioClip.SetData(audioData, 0);
                callback.Invoke(audioClip);
            }
        }
        else
        {
            callback.Invoke(null);
        }
    }

#if UNITY_ANDROID
    private IEnumerator LoadAudioClipAndroidAsync(string filePath, Action<AudioClip> callback)
    {
        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject assetManager = currentActivity.Call<AndroidJavaObject>("getAssets");

        using (AndroidJavaObject inputStream = assetManager.Call<AndroidJavaObject>("open", filePath))
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = inputStream.Call<int>("read", buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, bytesRead);
                    yield return null; // Permitir que el juego continúe en cada iteración para evitar bloqueos
                }

                byte[] oggData = memoryStream.ToArray();

                callback.Invoke(ConvertOggToAudioClip(oggData));
            }
        }
    }
#endif

#if UNITY_IOS
    private IEnumerator LoadAudioClipIOSAsync(string filePath, Action<AudioClip> callback)
    {
        using (StreamReader sr = new StreamReader(Application.streamingAssetsPath + "/" + filePath))
        {
            byte[] oggData = System.Convert.FromBase64String(sr.ReadToEnd());
            yield return null; // Permitir que el juego continúe después de la lectura del archivo
            callback.Invoke(ConvertOggToAudioClip(oggData));
        }
    }
#endif

    private AudioClip ConvertOggToAudioClip(byte[] oggData)
    {
        using (MemoryStream stream = new MemoryStream(oggData))
        {
            NVorbis.VorbisReader reader = new NVorbis.VorbisReader(stream, true);

            int channelCount = reader.Channels;
            int sampleRate = reader.SampleRate;
            int totalSampleCount = (int)(reader.TotalTime.TotalSeconds * sampleRate);
            float[] audioData = new float[channelCount * totalSampleCount];

            int sampleOffset = 0;
            int bufferSize = 4096;
            float[] buffer = new float[bufferSize * channelCount];

            int bytesRead;
            while ((bytesRead = reader.ReadSamples(buffer, 0, bufferSize)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    for (int c = 0; c < channelCount; c++)
                    {
                        audioData[sampleOffset + i * channelCount + c] = buffer[i * channelCount + c];
                    }
                }

                sampleOffset += bytesRead * channelCount;
            }

            AudioClip audioClip = AudioClip.Create("AudioClip", totalSampleCount, channelCount, sampleRate, false);
            audioClip.SetData(audioData, 0);

            return audioClip;
        }
    }




    private static string GetTrack(string trackPath)
    {
        string path = trackPath;
        string trackName = Path.GetFileNameWithoutExtension(path);

        // Eliminar parte de la dirección si es necesario
        string folderName = Path.GetDirectoryName(trackPath);
        trackName = trackName.Replace(folderName, "");

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
        return str;

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

    musicList = JsonUtility.FromJson<TrackList>(json);
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