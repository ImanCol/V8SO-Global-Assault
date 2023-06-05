using System.Collections;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private static AudioPlayer instance;
    public static AudioPlayer Instance { get { return instance; } }

    private AudioSource audioSource;
    private bool isInitialized = false;
    private Coroutine preloadCoroutine;

    public AudioClip[] tracks;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        audioSource = GetComponent<AudioSource>();
        isInitialized = true;
    }

    private void Start()
    {
        LoadMusicClips();
    }

    private void LoadMusicClips()
    {
        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "music.json");
        string json = System.IO.File.ReadAllText(filePath);
        MusicList2 musicList = JsonUtility.FromJson<MusicList2>(json);

        tracks = new AudioClip[musicList.tracks.Length];

        for (int i = 0; i < musicList.tracks.Length; i++)
        {
            string[] trackList = musicList.tracks[i].list;
            AudioClip[] audioClips = new AudioClip[trackList.Length];

            for (int j = 0; j < trackList.Length; j++)
            {
                string audioPath = System.IO.Path.Combine(Application.streamingAssetsPath, trackList[j]);
                StartCoroutine(LoadMusicClip(audioPath, i, j));
            }
        }
    }

    private IEnumerator LoadMusicClip(string audioPath, int listIndex, int trackIndex)
    {
        using (UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequestMultimedia.GetAudioClip(audioPath, UnityEngine.AudioType.OGGVORBIS))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityEngine.Networking.UnityWebRequest.Result.ConnectionError)
            {
                Debug.LogError("Error loading audio clip: " + www.error);
            }
            else
            {
                AudioClip audioClip = UnityEngine.Networking.DownloadHandlerAudioClip.GetContent(www);

                if (audioClip != null)
                {
                    tracks[listIndex * trackIndex] = audioClip;

                    // Si es la primera pista, comenzamos a reproducir de inmediato
                    if (listIndex == 0 && trackIndex == 0)
                    {
                        PlayTrack(0);
                    }
                }
            }
        }
    }

    public void PlayNextTrack()
    {
        int nextTrackIndex = Random.Range(0, tracks.Length);
        PlayTrack(nextTrackIndex);
    }

    private void PlayTrack(int trackIndex)
    {
        if (!isInitialized)
        {
            Debug.LogWarning("AudioPlayer is not initialized.");
            return;
        }

        if (trackIndex < 0 || trackIndex >= tracks.Length)
        {
            Debug.LogWarning("Invalid track index.");
            return;
        }

        audioSource.clip = tracks[trackIndex];
        audioSource.Play();
    }
}

[System.Serializable]
public class MusicList2
{
    public MusicTrack2[] tracks;
}

[System.Serializable]
public class MusicTrack2
{
    public string[] list;
}
