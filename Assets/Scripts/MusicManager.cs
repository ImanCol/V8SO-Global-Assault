using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections.Generic;
using Rewired;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class MusicList
{
    public TrackList[] tracks;
}

[System.Serializable]
public class TrackList
{
    public string[] list;
}

public class MusicManager : MonoBehaviour
{
    public CanvasGroup canvas;
    public float fadeDuration = 2f;
    public Texture2D progressBarTexture;
    private float currentSceneProgress;
    public static MusicManager instance;
    public MusicList musicList;
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
        if (musicClipsPreloaded)
        {
            canvas.alpha = 1f;
            canvas.interactable = true;
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
    private void Update()
    {
        if (player.GetButton("L3") && player.GetButton("R3") && !pressed)
        {
            pressed = true;
            PlayNextMusic();
        }

        if (!player.GetButton("L3") || !player.GetButton("R3"))
        {
            pressed = false;
        }
    }

    public void PlayMusic()
    {
        if (!musicClipsPreloaded)
        {
            Debug.Log("Music clips are not preloaded yet.");
            return;
        }

        if (music.isPlaying)
        {
            music.Stop();
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
                music.Play();
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
                    music.Play();
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

    public void PlayNextMusic()
    {
        if (!musicClipsPreloaded)
        {
            Debug.Log("Music clips are not preloaded yet.");
            return;
        }

        if (music.isPlaying)
        {
            music.Stop();
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
                music.Play();
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
                    music.Play();
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

    private IEnumerator LoadAudioClip(string trackPath)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, trackPath);
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(filePath, AudioType.OGGVORBIS))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(www.error);
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

    private void OnGUI()
    {
        if (!musicClipsPreloaded) // Solo dibujar la barra de progreso si los clips de música no se han cargado completamente
        {
            if (preloadCoroutine != null)
            {
                float progress = currentSceneProgress;
                Rect rect = new Rect(10, 10, Screen.width - 20, 100);
                GUI.DrawTexture(new Rect(rect.x, rect.y, rect.width * progress, rect.height), progressBarTexture);
            }
        }
    }
    public void LoadMusicList()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, "music.json");
        string json = File.ReadAllText(filePath);
        if (json != null)
        {
            musicList = JsonUtility.FromJson<MusicList>(json);
        }
        else
        {
            Debug.LogError("Failed to load music list at path: " + filePath);
        }
    }
}
