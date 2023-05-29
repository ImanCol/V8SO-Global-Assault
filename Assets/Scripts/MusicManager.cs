using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public MusicList musicList;
    public Dropdown musicDropdown;
    public Toggle musicToggle;
    public List<string>[] tracks = new List<string>[5];
    public AudioSource music = new AudioSource();
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

        //Cargar el primer clip de música de la lista 0
        LoadMusicClip(0, 0, PlayMusicAfterLoad);

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
            switch (listID)
            {
                case 0:
                    if (music.isPlaying == false)
                    {
                        rndList = Random.Range(0, musicList.tracks.Count);
                        rndTrack = Random.Range(0, musicList.tracks[rndList].list.Count);

                        LoadMusicClip(rndList, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
                case 1:
                    if (music.isPlaying == false)
                    {
                        rndTrack = Random.Range(0, musicList.tracks[0].list.Count);

                        LoadMusicClip(0, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
                case 2:
                    if (music.isPlaying == false)
                    {
                        rndTrack = Random.Range(0, musicList.tracks[1].list.Count);

                        LoadMusicClip(1, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
                case 3:
                    if (music.isPlaying == false)
                    {
                        rndTrack = Random.Range(0, musicList.tracks[2].list.Count);

                        LoadMusicClip(2, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
                case 4:
                    if (music.isPlaying == false)
                    {
                        rndTrack = Random.Range(0, musicList.tracks[3].list.Count);

                        LoadMusicClip(3, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
                case 5:
                    if (music.isPlaying == false)
                    {
                        rndTrack = Random.Range(0, musicList.tracks[4].list.Count);

                        LoadMusicClip(4, rndTrack, PlayMusicAfterLoad);
                    }
                    break;
            }
        }
    }

    private void LoadMusicClip(int listIndex, int trackIndex, System.Action onComplete)
    {
        string audioPath = musicList.tracks[listIndex].list[trackIndex];
        string audioFullPath = System.IO.Path.Combine(Application.streamingAssetsPath, audioPath);

        StartCoroutine(LoadMusicClipCoroutine(audioFullPath, onComplete));
    }

    private IEnumerator LoadMusicClipCoroutine(string audioFullPath, System.Action onComplete)
    {
        using (UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequestMultimedia.GetAudioClip(audioFullPath, UnityEngine.AudioType.OGGVORBIS))
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
                    if (onComplete != null)
                        onComplete.Invoke();
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
}
