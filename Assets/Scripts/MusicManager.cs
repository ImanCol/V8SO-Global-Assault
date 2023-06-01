using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public Dropdown musicDropdown;
    public Toggle musicToggle;
    public List<string>[] tracks = new List<string>[5];
    public AudioSource music;
    public int listID;
    public int trackID;
    public bool play;
    private int rndList;
    private int rndTrack;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        music = gameObject.AddComponent<AudioSource>();
        MusicManager.instance.music.Stop();

        // Escanear la carpeta "Music" dentro de StreamingAssets
        ScanMusicFolder();

        music.playOnAwake = false;
        music.loop = true;
        music.volume = 0.35f;
    }

    void Update()
    {
        //PlayMusic();
    }

    public void SetMusic()
    {
        if (GameManager.instance.inDebug)
            musicDropdown.gameObject.SetActive(value: musicToggle.isOn);
        play = musicToggle.isOn;
        listID = musicDropdown.value;
    }

    public void PlayMusic()
    {
        if (play == true)
        {
            if (tracks[listID].Count > 0 && music.isPlaying == false)
            {
                rndTrack = UnityEngine.Random.Range(0, tracks[listID].Count);
                string audioPath = tracks[listID][rndTrack];
                string audioFullPath = Path.Combine(Application.streamingAssetsPath, audioPath);

                LoadMusicClip(audioFullPath, PlayMusicAfterLoad);
            }
        }
    }

    private void LoadMusicClip(string audioFullPath, System.Action onComplete)
    {
        StartCoroutine(LoadMusicClipCoroutine(audioFullPath, onComplete));
    }

    private IEnumerator LoadMusicClipCoroutine(string audioFullPath, System.Action onComplete)
    {
        using (var www = UnityEngine.Networking.UnityWebRequestMultimedia.GetAudioClip(audioFullPath, UnityEngine.AudioType.OGGVORBIS))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityEngine.Networking.UnityWebRequest.Result.ConnectionError)
            {
                Debug.LogError("Error loading music clip: " + www.error);
            }
            else
            {
                AudioClip clip = UnityEngine.Networking.DownloadHandlerAudioClip.GetContent(www);

                if (clip != null)
                {
                    music.clip = clip;

                    // Llamar al método onComplete después de cargar el clip
                    onComplete?.Invoke();
                }
                else
                {
                    Debug.LogError("Error loading music clip: AudioClip is null");
                }
            }
        }
    }

    private void PlayMusicAfterLoad()
    {
        if (music.isPlaying == false)
        {
            music.Play();
        }
    }

    private void ScanMusicFolder()
    {
        string musicFolderPath = Path.Combine(Application.streamingAssetsPath, "Music");

        if (Directory.Exists(musicFolderPath))
        {
            tracks = new List<string>[5];

            for (int i = 0; i < tracks.Length; i++)
            {
                tracks[i] = new List<string>();
            }

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.ogg", SearchOption.AllDirectories);

            foreach (string musicFile in musicFiles)
            {
                string relativePath = GetRelativePath(musicFile, Application.streamingAssetsPath);
                int listIndex = GetListIndexFromFilePath(relativePath);

                if (listIndex != -1)
                {
                    tracks[listIndex].Add(relativePath);
                }
            }
        }
        else
        {
            Debug.LogWarning("Music folder not found in StreamingAssets");
        }
    }

    private string GetRelativePath(string absolutePath, string basePath)
    {
        if (!basePath.EndsWith(Path.DirectorySeparatorChar.ToString()))
        {
            basePath += Path.DirectorySeparatorChar;
        }

        Uri baseUri = new Uri(basePath);
        Uri absoluteUri = new Uri(absolutePath);

        Uri relativeUri = baseUri.MakeRelativeUri(absoluteUri);
        string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

        return relativePath.Replace('/', Path.DirectorySeparatorChar);
    }

    private int GetListIndexFromFilePath(string filePath)
    {
        string[] pathParts = filePath.Split(Path.DirectorySeparatorChar);

        if (pathParts.Length >= 2)
        {
            string listFolderName = pathParts[pathParts.Length - 2];

            if (listFolderName.StartsWith("List"))
            {
                string listIndexStr = listFolderName.Substring(4);

                if (int.TryParse(listIndexStr, out int listIndex))
                {
                    if (listIndex >= 0 && listIndex < tracks.Length)
                    {
                        return listIndex;
                    }
                }
            }
        }

        return -1;
    }
}
