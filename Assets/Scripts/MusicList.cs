using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ML
{
    public List<string> list = new List<string>();
}

public class MusicList : ScriptableObject
{

    public string path;
    public string[] dirs = new string[5];
    public List<ML> tracks = new List<ML>();
    
    public void ConfigList() 
    {
        path = "/StreamingAssets/Music/";

        dirs[0] = "V82DCProto/";
        dirs[1] = "V82PS1/";
        dirs[2] = "V81PS1/";
        dirs[3] = "V82N64/";
        dirs[4] = "V81N64/";

        GetMusicLinks(dirs);
    }

    private void GetMusicLinks(string[] dirs) 
    {
        //for (int i = 0; i < dirs.Length; i++) 
        //{
        //    tracks.Add(new ML());
        //
        //    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.dataPath + path + dirs[i]);
        //    System.IO.FileInfo[] info = dir.GetFiles("*.*");
        //
        //    foreach (System.IO.FileInfo f in info)
        //    {
        //        if (f.Extension == ".flac")
        //        {
        //            tracks[i].list.Add("Music/" + dirs[i] + System.IO.Path.GetFileNameWithoutExtension(f.Name));
        //        }
        //    }
        //}
    }
}