using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Profiling;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;

public delegate VigObject _VEHICLE_INIT(XOBF_DB param1, int param2, uint param3); //needs parameters
public delegate VigObject _SPECIAL_INIT(XOBF_DB param1, int param2);
public delegate VigObject _OBJECT_INIT(XOBF_DB param1, int param2, uint param3);

public struct VehicleData
{
    // Token: 0x04000414 RID: 1044
    public short[] DAT_00;

    // Token: 0x04000415 RID: 1045
    public byte DAT_0C;

    // Token: 0x04000416 RID: 1046
    public _VEHICLE vehicleID;

    // Token: 0x04000417 RID: 1047
    public sbyte DAT_0E;

    // Token: 0x04000418 RID: 1048
    public sbyte DAT_0F;

    // Token: 0x04000419 RID: 1049
    public byte DAT_10;

    // Token: 0x0400041A RID: 1050
    public byte DAT_11;

    // Token: 0x0400041B RID: 1051
    public byte DAT_12;

    // Token: 0x0400041C RID: 1052
    public byte DAT_13;

    // Token: 0x0400041D RID: 1053
    public byte DAT_14;

    // Token: 0x0400041E RID: 1054
    public byte DAT_15;

    // Token: 0x0400041F RID: 1055
    public byte DAT_16;

    // Token: 0x04000420 RID: 1056
    public ushort maxHalfHealth;

    // Token: 0x04000421 RID: 1057
    public ushort DAT_1A;

    // Token: 0x04000422 RID: 1058
    public int lightness;

    // Token: 0x04000423 RID: 1059
    public int DAT_20;

    // Token: 0x04000424 RID: 1060
    public ushort peelout;

    // Token: 0x04000425 RID: 1061
    public Vector3Int DAT_24;

    // Token: 0x04000426 RID: 1062
    public short DAT_2A;

    // Token: 0x04000427 RID: 1063
    public byte[] DAT_2C;
}

public enum _GAME_MODE
{
    Quest,
    Arcade,
    Alone,
    Survival,
    Demo,
    Versus,
    Coop,
    Quest2,
    Unk1,
    Unk2,
    Versus2,
    Coop2,
    Survival2
}

public enum _SCREEN_MODE
{
    Whole,
    Horizontal,
    Vertical,
    Unknown
}

public enum _DITHERING
{
    None,
    Standard,
    PSX
}

public class BSP
{
    public int DAT_00; //0x00
    public int DAT_04; //0x04
    public List<VigTuple> LDAT_04; //0x04
    public BSP DAT_08; //0x08
    public BSP DAT_0C; //0x0C
}


public class GameManager : MonoBehaviour
{

    #region DEBUG_MENU
    public void SetDriver()
    {
        int index = driverDropdown.value;

        switch (index)
        {
            case 0:
                vehicles[0] = 0;
                break;
            case 1:
                vehicles[0] = 1;
                break;
            case 2:
                vehicles[0] = 2;
                break;
            case 3:
                vehicles[0] = 3;
                break;
            case 4:
                vehicles[0] = 4;
                break;
            case 5:
                vehicles[0] = 5;
                break;
            case 6:
                vehicles[0] = 6;
                break;
            case 7:
                vehicles[0] = 7;
                break;
            case 8:
                vehicles[0] = 8;
                break;
            case 9:
                vehicles[0] = 9;
                break;
            case 10:
                vehicles[0] = 10;
                break;
            case 11:
                vehicles[0] = 11;
                break;
            case 12:
                vehicles[0] = 12;
                break;
            case 13:
                vehicles[0] = 13;
                break;
            case 14:
                vehicles[0] = 14;
                break;
            case 15:
                vehicles[0] = 15;
                break;
            case 16:
                vehicles[0] = 16;
                break;
            case 17:
                vehicles[0] = 17;
                break;
        }
    }

    public void SetStage()
    {
        this.map = this.stageDropdown.value + 1;
        ClientSend.Map(0L);
    }

    public void SetDithering()
    {
        switch (this.ditheringDropdown.value)
        {
            case 0:
                this.ditheringMethod = _DITHERING.None;
                return;
            case 1:
                this.ditheringMethod = _DITHERING.Standard;
                return;
            case 2:
                this.ditheringMethod = _DITHERING.PSX;
                return;
            default:
                return;
        }
    }

    public void SetLives()
    {
        sbyte b = (sbyte)(this.livesDropdown.value + 1);
        this.playerSpawns = b;
        for (int i = 0; i < this.networkMembers.Count; i++)
        {
            this.DAT_1030[i] = b;
        }
        ClientSend.Lives((int)this.playerSpawns, 0L);
    }

    public void SetGameMode()
    {
        int value = this.gameModeDropdown.value;
        if (value == 0)
        {
            this.gameMode = _GAME_MODE.Quest;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 1)
        {
            this.gameMode = _GAME_MODE.Arcade;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 2)
        {
            this.gameMode = _GAME_MODE.Alone;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 3)
        {
            this.gameMode = _GAME_MODE.Survival;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 4)
        {
            this.gameMode = _GAME_MODE.Demo;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 5)
        {
            this.gameMode = _GAME_MODE.Coop;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 6)
        {
            this.gameMode = _GAME_MODE.Quest2;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 7)
        {
            this.gameMode = _GAME_MODE.Unk1;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 8)
        {
            this.gameMode = _GAME_MODE.Unk2;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 9)
        {
            this.gameMode = _GAME_MODE.Versus2;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 10)
        {
            this.gameMode = _GAME_MODE.Coop2;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 11)
        {
            this.gameMode = _GAME_MODE.Survival2;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value == 12)
        {
            this.gameMode = _GAME_MODE.Arcade;
            this.spawnsRect.gameObject.SetActive(true);
            return;
        }
        if (value != 13)
        {
            return;
        }
        //this.gameMode = _GAME_MODE.Survival;
        this.spawnsRect.gameObject.SetActive(false);
        this.DAT_1030[0] = 1;
        this.DAT_1030[1] = 0;
        this.DAT_1030[2] = 0;
        this.DAT_1030[3] = 0;

    }

    //public void SetMultiplayerMode()
    //{
    //    switch (this.mpModeDropdown.value)
    //    {
    //        case 0:
    //            this.gameMode = _GAME_MODE.Versus2;
    //            this.livesDropdown.transform.parent.gameObject.SetActive(true);
    //            this.onlineDmgDropdown.transform.parent.gameObject.SetActive(true);
    //            this.damageDropdown.transform.parent.gameObject.SetActive(false);
    //            this.difficultyDropdown.transform.parent.gameObject.SetActive(false);
    //            break;
    //        case 1:
    //            this.gameMode = _GAME_MODE.Coop2;
    //            this.livesDropdown.transform.parent.gameObject.SetActive(false);
    //            this.onlineDmgDropdown.transform.parent.gameObject.SetActive(false);
    //            this.damageDropdown.transform.parent.gameObject.SetActive(true);
    //            this.difficultyDropdown.transform.parent.gameObject.SetActive(true);
    //            this.DAT_1030[0] = 1;
    //            this.DAT_1030[1] = 1;
    //            this.DAT_1030[2] = 1;
    //            this.DAT_1030[3] = 1;
    //            this.DAT_1030[4] = 1;
    //            this.DAT_1030[5] = 1;
    //            break;
    //        case 2:
    //            this.gameMode = _GAME_MODE.Survival2;
    //            this.livesDropdown.transform.parent.gameObject.SetActive(false);
    //            this.onlineDmgDropdown.transform.parent.gameObject.SetActive(false);
    //            this.damageDropdown.transform.parent.gameObject.SetActive(true);
    //            this.difficultyDropdown.transform.parent.gameObject.SetActive(true);
    //            this.DAT_1030[0] = 1;
    //            this.DAT_1030[1] = 0;
    //            this.DAT_1030[2] = 0;
    //            this.DAT_1030[3] = 0;
    //            break;
    //    }
    //    ClientSend.Mode(0L);
    //}
    public void SetMultiplayerMode()
    {
        switch (mpModeDropdown.value)
        {
            case 0:
                gameMode = _GAME_MODE.Versus2;
                livesDropdown.transform.parent.gameObject.SetActive(value: true);
                onlineDmgDropdown.transform.parent.gameObject.SetActive(value: true);
                damageDropdown.transform.parent.gameObject.SetActive(value: false);
                difficultyDropdown.transform.parent.gameObject.SetActive(value: false);
                break;
            case 1:
                gameMode = _GAME_MODE.Coop2;
                livesDropdown.transform.parent.gameObject.SetActive(value: false);
                onlineDmgDropdown.transform.parent.gameObject.SetActive(value: false);
                damageDropdown.transform.parent.gameObject.SetActive(value: true);
                difficultyDropdown.transform.parent.gameObject.SetActive(value: true);
                DAT_1030[0] = 1;
                DAT_1030[1] = 1;
                DAT_1030[2] = 1;
                DAT_1030[3] = 1;
                DAT_1030[4] = 1;
                DAT_1030[5] = 1;
                break;
            case 2:
                gameMode = _GAME_MODE.Survival2;
                livesDropdown.transform.parent.gameObject.SetActive(value: false);
                onlineDmgDropdown.transform.parent.gameObject.SetActive(value: false);
                damageDropdown.transform.parent.gameObject.SetActive(value: true);
                difficultyDropdown.transform.parent.gameObject.SetActive(value: true);
                DAT_1030[0] = 1;
                DAT_1030[1] = 0;
                DAT_1030[2] = 0;
                DAT_1030[3] = 0;
                break;
        }
        ClientSend.Mode(0L);
    }

    public void SetDamage()
    {
        int value = this.damageDropdown.value;
        this.DAT_C80[0] = (sbyte)value;
        this.DAT_C80[1] = (sbyte)value;
        ClientSend.Damage(0L);
    }

    public void SetDifficulty()
    {
        int value = this.difficultyDropdown.value;
        this.DAT_C6E = (byte)value;
        ClientSend.Difficulty(0L);
    }

    public void SetOnlineDamage()
    {
        int value = this.onlineDmgDropdown.value;
        this.DAT_C6E = (byte)value;
        ClientSend.Difficulty(0L);
    }

    public void SetDrawPlayer()
    {
        this.drawPlayer = this.drawPlayerToggle.isOn;
    }

    public void SetDrawObjects()
    {
        this.drawObjects = this.drawObjectsToggle.isOn;
    }

    public void SetDrawTerrain()
    {
        this.drawTerrain = this.drawTerrainToggle.isOn;
    }

    public void SetDrawRoads()
    {
        this.drawRoads = this.drawRoadsToggle.isOn;
    }

    public void SetEnemySpawn(int index)
    {
        this.DAT_1030[index] = ((sbyte)(this.spawnEnemiesToggle[index].isOn ? 1 : 0));
    }
    // public void SetEnemySpawn(int index)
    //{
    //    DAT_1030[index] = (sbyte)(spawnEnemiesToggle[index].isOn ? 1 : 0);
    //}

    public void SetDPAD()
    {
        GameManager.DAT_637E0[0, 5] = (this.disableDpadToggle.isOn ? 7431u : 3116899591u);
    }

    public void SetAutoTarget()
    {
        this.autoTarget = this.disableAutoTarget.isOn;
    }

    public void SetExperimentalDakota()
    {
        this.experimentalDakota = this.enableExperimentalDakota.isOn;
    }

    public void SetPlayerReady(bool ready)
    {
        this.ready = ready;
        if (ready)
        {
            ClientSend.Ready(0L);
            return;
        }
        ClientSend.NotReady(0L);
    }

    public void RandomizeEnemies(int players)
    {
        List<int> list = new List<int>(playable);
        survival = new List<int>();
        int num = playable.Count - players;

        for (int i = 0; i < num; i++)
        {
            do
            {
                int random = UnityEngine.Random.Range(0, list.Count);

                if (list[random] != vehicles[0])
                {
                    survival.Add(list[random]);
                    list.RemoveAt(random);
                    break;
                }
            } while (true);
        }


        //for (int i = 0; i < num; i++)
        //{
        //    int index;
        //    do
        //    {
        //        index = UnityEngine.Random.Range(0, list.Count);
        //    }
        //    while (list[index] == vehicles[0] || list[index] == vehicles[1]);
        //    survival.Add(list[index]);
        //    list.RemoveAt(index);
        //}
        //for (int j = 0; j < 6; j++)


        int playerammount = 4;

        if (players == 1)
        {
            playerammount = 4;
        }
        else if (players == 2)
        {
            playerammount = 6;
        }
        Debug.Log(players);

        for (int j = 0; j < playerammount; j++)
        {
            if (gameMode == _GAME_MODE.Arcade)
            {
                SetEnemySpawn(j);
            }
            int index2;
            do
            {
                index2 = UnityEngine.Random.Range(0, playable.Count);
            }
            while (playable[index2] == vehicles[0] || playable[index2] == vehicles[1]);
            vehicles[j + 2] = (byte)playable[index2];
            playable.RemoveAt(index2);
        }
    }

    //public void LoadLevel()
    //{
    //	this.SetDriver();
    //	this.SetStage();
    //	this.SetDithering();
    //	this.SetGameMode();
    //	this.SetDamage();
    //	this.SetDifficulty();
    //	this.SetDrawPlayer();
    //	this.SetDrawObjects();
    //	this.SetDrawTerrain();
    //	this.SetDrawRoads();
    //	this.SetDPAD();
    //	this.SetAutoTarget();
    //	this.SetExperimentalDakota();
    //	this.RandomizeEnemies(1);
    //	this.totalSpawns = (int)(this.DAT_1030[0] + this.DAT_1030[1] + this.DAT_1030[2] + this.DAT_1030[3]);
    //	UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
    //	SceneManager.LoadScene(this.map, LoadSceneMode.Single);
    //}

    public void LoadLevel()
    {
        SetDriver();
        SetStage();
        SetDithering();
        SetGameMode();
        //SetScreenMode();
        SetDamage();
        SetDifficulty();
        SetDrawPlayer();
        SetDrawObjects();
        SetDrawTerrain();
        SetDrawRoads();
        SetDPAD();
        SetAutoTarget();
        //SetExperimentalDakota();
        RandomizeEnemies(1);
        totalSpawns = DAT_1030[0] + DAT_1030[1] + DAT_1030[2] + DAT_1030[3];
        UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
        SceneManager.LoadScene(map, LoadSceneMode.Single);
    }

    public void LoadMultiplayerLevel(bool isHost)
    {
        this.SetDriver();
        this.SetDPAD();
        this.SetAutoTarget();
        ClientSend.Ready(0L);
        if (isHost)
        {
            this.SetMultiplayerMode();
            this.SetStage();
            if (this.gameMode == _GAME_MODE.Versus2)
            {
                this.SetOnlineDamage();
                this.SetLives();
            }
            else
            {
                this.SetDamage();
                this.SetDifficulty();
            }
            DiscordController.instance.SetLobbyMetadata("level", Demo.mapNames[this.map - 1]);
            while (DiscordController.instance.pendingCallbacks)
            {
                DiscordController.instance.discord.RunCallbacks();
            }
            this.RandomizeEnemies(2);
            ClientSend.Load();
        }
        for (short num = 1; num <= 6; num += 1)
        {
            this.enemiesDictionary.Add(num, null);
        }
        this.drawTerrain = true;
        this.drawRoads = true;
        this.drawObjects = true;
        this.drawPlayer = true;
        DiscordController.instance.sceneLoaded = false;
        UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
        SceneManager.LoadScene(this.map, LoadSceneMode.Single);
    }

    public void LoadDebug()
    {
        this.inDebug = true;
        UnityEngine.Object.Destroy(base.gameObject);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    #endregion
    public void FUN_17F34(int param1, int param2)
    {
        this.DAT_DA0 = param2;
        this.DAT_DB0 = 3143680 - param1;
    }

    public void FUN_17EB8()
    {
        uint num = (uint)(this.DAT_DB0 - this.DAT_F28.position.y);
        Vector3Int param = new Vector3Int((int)this.DAT_F28.rotation.V10, (int)this.DAT_F28.rotation.V11, (int)this.DAT_F28.rotation.V12);
        Water.instance.FUN_15F28(this.DAT_F28, this.DAT_DB0);
        uint num2 = (uint)param.z;
        if ((num ^ num2) < 1u)
        {
            if (num2 < 0u)
            {
                num2 = (uint)-num2;
            }
            if (1637u < num2)
            {
                return;
            }
        }
        Water.instance.FUN_16664(param, (int)num);
    }

    public void FUN_1C134()
    {
        this.terrain.ClearTerrainData();
        this.FUN_1C158();
    }

    public void FUN_1DC0C(bool param1, int param2, bool param3 = false)
    {
        if (param1)
        {
            GameManager.voices[param2].loop = param3;
            GameManager.voices[param2].Play();
            return;
        }
        GameManager.voices[param2].Pause();
    }

    public int FUN_1DD9C()
    {
        int num = 0;
        AudioSource[] array = GameManager.voices;
        uint num2 = this.DAT_E44;
        while ((num2 & 1u) != 0u || array[num].isPlaying)
        {
            num++;
            num2 = (uint)((int)num2 >> 1);
            if (23 < num)
            {
                return 0;
            }
        }
        return num + 1;
    }

    public bool IsAudioPlaying(int param1, AudioClip param2)
    {
        return param1 != 0 && GameManager.voices[param1 - 1].clip == param2 && GameManager.voices[param1 - 1].isPlaying;
    }

    public bool IsAudioPlaying(int param1)
    {
        return param1 != 0 && GameManager.voices[param1 - 1].isPlaying;
    }

    public void FUN_1DE78(int param1)
    {
        if (param1 != 0)
        {
            this.FUN_1DC0C(false, param1 - 1 & 31, false);
        }
    }

    public void FUN_1E098(int param1, List<AudioClip> param2, int param3, uint param4, bool param5 = false)
    {
        if (param1 != 0)
        {
            AudioClip audioClip = param2[param3];
            int sampleRate = 4096;
            int num = param1 - 1;
            if (audioClip != null)
            {
                GameManager.SpuSetVoicePitch(num, sampleRate);
                GameManager.SpuSetVoiceVolume(num, (int)((short)param4), (int)((short)(param4 >> 16)));
                GameManager.SpuSetVoiceStartAddr(num, audioClip);
                this.FUN_1DC0C(true, num & 31, param5);
            }
        }
    }

    public void FUN_1E14C(int param1, List<AudioClip> param2, int param3, bool param4 = false)
    {
        int num = (int)this.DAT_E1C;
        uint num2 = (uint)((uint)((ushort)this.DAT_E1C) << 16) >> 31;
        num += (int)num2;
        num >>= 1;
        num2 = (uint)((uint)num << 16);
        num2 += (uint)num;
        this.FUN_1E098(param1, param2, param3, num2, param4);
    }

    public void FUN_1E188(int param1, List<AudioClip> param2, int param3, bool param4 = false)
    {
        uint num = (uint)((uint)this.DAT_E1C << 16);
        num = (uint)this.DAT_E1C + num;
        this.FUN_1E098(param1, param2, param3, num, param4);
    }

    public void FUN_1E188(int param1, List<AudioClip> param2, int param3, int param4, bool param5 = false)
    {
        uint num = (uint)((uint)this.DAT_E1C << 16);
        num = (uint)this.DAT_E1C + num;
        this.FUN_1E098(param1, param2, param3, num << param4, param5);
    }

    public void FUN_1E28C(int param1, List<AudioClip> param2, int param3)
    {
        uint num = (uint)((ushort)this.DAT_E1C) >> 31;
        uint num2 = (uint)this.DAT_E1C + num;
        num2 = (uint)((int)num2 >> 1);
        num2 = (num2 << 16) + num2;
        this.FUN_1E1B0(param1, param2, param3, num2, false);
    }

    public void FUN_1E2E8(int source, int sampleRate)
    {
        if (source != 0)
        {
            GameManager.voices[source - 1].pitch = (float)sampleRate / (float)(GameManager.voices[source - 1].clip.frequency / 11);
        }
    }

    public void FUN_1E30C(int source, int sampleRate)
    {
        if (source != 0)
        {
            int num = GameManager.voices[source - 1].clip.frequency / 11;
            sampleRate = (int)((uint)(num * sampleRate) >> 12);
            GameManager.voices[source - 1].pitch = (float)sampleRate / (float)num;
        }
    }

    public void FUN_1E580(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint param6 = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, param6, param5);
    }

    public void FUN_1E5D4(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, num << 1, param5);
    }

    public void FUN_1E5D4(int param1, List<AudioClip> param2, int param3, Vector3Int param4, int param5, bool param6 = false)
    {
        uint num = this.FUN_1E478(param4);
        this.FUN_1E098(param1, param2, param3, num << param5, param6);
    }

    public static void SpuSetVoicePitch(int vNum, int sampleRate)
    {
        GameManager.voices[vNum].pitch = (float)sampleRate / 4096f;
    }

    public void FUN_1E2C8(int source, uint volume)
    {
        if (source != 0)
        {
            int num = (int)((short)volume);
            int num2 = (int)((short)(volume >> 16));
            num &= 32767;
            if (num > 16383)
            {
                num = (-num & 32767);
            }
            num2 &= 32767;
            if (num2 > 16383)
            {
                num2 = (-num2 & 32767);
            }
            float num3 = (float)num / 16384f;
            float num4 = (float)num2 / 16384f;
            GameManager.voices[source - 1].volume = Mathf.Max(num3, num4);
            GameManager.voices[source - 1].panStereo = num4 - num3;
        }
    }

    public static void SpuSetVoiceVolume(int vNum, int volL, int volR)
    {
        volL &= 32767;
        if (volL > 16383)
        {
            volL = (-volL & 32767);
        }
        volR &= 32767;
        if (volR > 16383)
        {
            volR = (-volR & 32767);
        }
        float num = (float)volL / 16384f;
        float num2 = (float)volR / 16384f;
        GameManager.voices[vNum].volume = Mathf.Max(num, num2);
        GameManager.voices[vNum].panStereo = num2 - num;
    }

    public static void SpuSetVoiceStartAddr(int vNum, AudioClip startAddr)
    {
        GameManager.voices[vNum].clip = startAddr;
    }

    public void FUN_1E1B0(int param1, List<AudioClip> param2, int param3, uint param4, bool param5 = false)
    {
        if (param1 != 0)
        {
            AudioClip audioClip = param2[param3];
            if (audioClip != null)
            {
                int num = param1 - 1;
                int sampleRate = (int)(GameManager.FUN_2AC5C() + 114688u) >> 5;
                GameManager.SpuSetVoicePitch(num, sampleRate);
                GameManager.SpuSetVoiceVolume(num, (int)((short)param4), (int)((short)(param4 >> 16)));
                GameManager.SpuSetVoiceStartAddr(num, audioClip);
                this.FUN_1DC0C(true, num & 31, param5);
            }
        }
    }

    public void FUN_1E628(int param1, List<AudioClip> param2, int param3, Vector3Int param4, bool param5 = false)
    {
        uint param6 = this.FUN_1E478(param4);
        this.FUN_1E1B0(param1, param2, param3, param6, param5);
    }

    public void FUN_1E8B0(List<AudioClip> param1, int param2, Vector3Int param3)
    {
        uint num = this.FUN_1E7A8(param3);
        if (num != 0u)
        {
            int param4 = this.FUN_1DD9C();
            this.FUN_1E1B0(param4, param1, param2, num, false);
        }
    }

    public void FUN_1FEB8(VigMesh param1)
    {
        if (param1 != null)
        {
            if (param1.DAT_14 != null)
            {
                param1.DAT_14 = null;
            }
            UnityEngine.Object.Destroy(param1);
        }
    }

    public void FUN_2C0A0(VigObject param1)
    {
        if (param1 != null)
        {
            do
            {
                ushort dat_4A = this.timer;
                BufferedBinaryReader bufferedBinaryReader = param1.vAnim;
                if (bufferedBinaryReader == null)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(param1.vData.animations);
                    if (bufferedBinaryReader.GetBuffer() != null)
                    {
                        int num = bufferedBinaryReader.ReadInt32((int)((ushort)param1.DAT_1A * 4 + 4));
                        if (num != 0)
                        {
                            bufferedBinaryReader.Seek((long)num, SeekOrigin.Begin);
                        }
                        else
                        {
                            bufferedBinaryReader = null;
                        }
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                else
                {
                    bufferedBinaryReader.Seek(0L, SeekOrigin.Begin);
                    int num = bufferedBinaryReader.ReadInt32((int)((ushort)param1.DAT_1A * 4 + 4));
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek((long)num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                param1.vAnim = bufferedBinaryReader;
                param1.DAT_4A = dat_4A;
                if (param1.child2 != null)
                {
                    this.FUN_2C0A0(param1.child2);
                }
                param1 = param1.child;
            }
            while (param1 != null);
        }
    }

    public void FUN_2C4B4(VigObject param1)
    {
        if (param1 != null)
        {
            VigObject child;
            do
            {
                if (param1.vLOD != null && param1.vLOD != param1.vMesh)
                {
                    this.FUN_1FEB8(param1.vLOD);
                }
                this.FUN_1FEB8(param1.vMesh);
                this.FUN_2C4B4(param1.child2);
                child = param1.child;
                UnityEngine.Object.Destroy(param1.gameObject);
                param1 = child;
            }
            while (child != null);
        }
    }

    public void FUN_2DE18()
    {
        Utilities.SetColorMatrix(this.DAT_FA8);
        Utilities.SetBackColor(64, 64, 64);
        Utilities.SetFogNearFar(2048, 8192, this.DAT_ED8);
        Utilities.SetColorMatrix2(this.DAT_FA8);
        Utilities.SetBackColor2(64, 64, 64);
        Utilities.SetFogNearFar2(2048, 8192, this.DAT_ED8);
    }

    public void FUN_2DE84(int param1, Vector3Int param2, Color32 param3)
    {
        int num = param1;
        param1 = num * 3;
        this.DAT_F68.SetValue16(param1, param2.x);
        this.DAT_F68.SetValue16(param1 + 1, param2.y);
        this.DAT_F68.SetValue16(param1 + 2, param2.z);
        this.DAT_FA8.SetValue16(num, (int)param3.r << 4);
        this.DAT_FA8.SetValue16(num + 3, (int)param3.g << 4);
        this.DAT_FA8.SetValue16(num + 6, (int)param3.b << 4);
    }

    public void FUN_2FB70(VigObject param1, HitDetection param2, HitDetection param3)
    {
        param3.self = param1;
        param3.collider1 = param2.collider2;
        param3.collider2 = param2.collider1;
        param3.object1 = param2.object2;
        param3.object2 = param2.object1;
        this.FUN_2F798(param2.self, param3, 1);
    }

    public int FUN_2FE58(VigObject param1, ushort param2)
    {
        int num;
        for (; ; )
        {
            VigObject child = param1.child;
            if ((param1.flags & 4u) == 0u)
            {
                num = param1.FUN_2FBC8(param2);
                if (-1 < num)
                {
                    if (param1.child2 == null)
                    {
                        goto IL_3F;
                    }
                    num = this.FUN_2FE58(param1.child2, param2);
                }
                if (num < -1)
                {
                    break;
                }
            }
        IL_3F:
            param1 = child;
            if (child == null)
            {
                return 0;
            }
        }
        return num;
    }

    public void FUN_2FEE8(VigObject param1, ushort param2)
    {
        int num = param1.FUN_2FBC8(param2);
        if (-1 < num && param1.child2 != null)
        {
            this.FUN_2FE58(param1.child2, param2);
        }
    }

    public VigTuple2 FUN_2FF3C(uint param1, uint param2)
    {
        List<VigTuple2> dat_10D = this.DAT_10D8;
        VigTuple2 vigTuple = null;
        for (int i = 0; i < dat_10D.Count; i++)
        {
            vigTuple = dat_10D[i];
            if ((uint)vigTuple.array[0] <= param1 >> 16 && (uint)vigTuple.array[1] <= param2 >> 16 && param1 >> 16 <= (uint)(vigTuple.array[0] + vigTuple.array[2]) && param2 >> 16 <= (uint)(vigTuple.array[1] + vigTuple.array[3]))
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }

    public VigTuple2 FUN_2FFD0(int param1)
    {
        List<VigTuple2> dat_10D = this.DAT_10D8;
        VigTuple2 vigTuple = null;
        for (int i = 0; i < dat_10D.Count; i++)
        {
            vigTuple = dat_10D[i];
            if ((int)vigTuple.id == param1)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }

    public void FUN_3001C(List<VigTuple> param1)
    {
        param1 = new List<VigTuple>();
    }

    public VigTuple FUN_30080(List<VigTuple> param1, VigObject param2)
    {
        VigTuple vigTuple = new VigTuple(param2, 0u);
        param1.Add(vigTuple);
        return vigTuple;
    }

    public bool FUN_300B8(List<VigTuple> param1, VigObject param2)
    {
        int num = 0;
        while (num != param1.Count)
        {
            VigTuple vigTuple = param1[num++];
            if (vigTuple.vObject == param2)
            {
                if (param1 == this.DAT_1088)
                {
                    this.DAT_1088_tmp.Add(vigTuple);
                }
                else if (param1 == this.DAT_1110)
                {
                    this.DAT_1110_tmp.Add(vigTuple);
                }
                else if (param1 == this.worldObjs)
                {
                    this.worldObjs_tmp.Add(vigTuple);
                }
                else
                {
                    param1.Remove(vigTuple);
                }
                vigTuple.vObject = null;
                return true;
            }
        }
        return false;
    }

    public VigTuple FUN_30134(List<VigTuple> param1, VigObject param2)
    {
        if (param1 == null)
        {
            param1 = new List<VigTuple>();
        }
        for (int num = 0; num != param1.Count; num++)
        {
            VigTuple vigTuple = param1[num];
            if (vigTuple.vObject == param2)
            {
                return vigTuple;
            }
        }
        return null;
    }

    public VigTuple FUN_301DC(List<VigTuple> param1, int param2)
    {
        return this.FUN_30180(param1, param2, null);
    }

    public VigTuple FUN_301FC(List<VigTuple> param1, Type param2)
    {
        VigTuple vigTuple = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigTuple = param1[i];
            if (vigTuple.vObject.GetType() == param2)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }

    private VigTuple _GetPowerup(List<VigTuple> param1, Vector3Int param2)
    {
        VigTuple vigTuple = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigTuple = param1[i];
            if (vigTuple.vObject.screen == param2 && vigTuple.vObject.GetType() == typeof(Pickup) && vigTuple.vObject.type == 5)
            {
                break;
            }
            vigTuple = null;
        }
        return vigTuple;
    }

    public VigObject GetPowerup(List<VigTuple> param1, Vector3Int param2)
    {
        VigTuple vigTuple = this._GetPowerup(param1, param2);
        VigObject result = null;
        if (vigTuple != null)
        {
            result = vigTuple.vObject;
        }
        return result;
    }

    public VigObject FUN_3027C(List<VigTuple> param1, int param2, VigObject param3)
    {
        VigTuple vigTuple = this.FUN_30180(param1, param2, param3);
        VigObject result = null;
        if (vigTuple != null)
        {
            result = vigTuple.vObject;
        }
        return result;
    }

    public VigObject FUN_302A8(List<VigTuple> param1, Type param2)
    {
        VigTuple vigTuple = this.FUN_301FC(param1, param2);
        VigObject result = null;
        if (vigTuple != null)
        {
            result = vigTuple.vObject;
        }
        return result;
    }

    public VigObject FUN_302D4(List<VigTuple> param1, uint param2, int param3)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if ((int)vObject.id == param3 && (uint)vObject.type == param2)
            {
                return vObject;
            }
        }
        return null;
    }

    public uint FUN_30334(List<VigTuple> param1, int param2, VigObject param3)
    {
        uint num = 0u;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (!vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                num = 0u;
            }
            else
            {
                num = vObject.UpdateW(param2, param3);
            }
            if (num != 0u)
            {
                break;
            }
        }
        return num;
    }

    public uint FUN_30334(List<VigTuple> param1, int param2, int param3)
    {
        uint num = 0u;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (!vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                num = 0u;
            }
            else
            {
                num = vObject.UpdateW(param2, param3);
            }
            if (num != 0u)
            {
                break;
            }
        }
        return num;
    }

    public uint FUN_303C0(List<VigTuple> param1, _EVENT_CALL param2, int param3)
    {
        uint num = 0u;
        for (int i = 0; i < param1.Count; i++)
        {
            VigTuple param4 = param1[i];
            num = param2(param4, param3);
            if (num != 0u)
            {
                break;
            }
        }
        return num;
    }

    public int FUN_30428(List<VigTuple> param1, uint param2)
    {
        int num = 0;
        for (int i = 0; i < param1.Count; i++)
        {
            VigTuple vigTuple = param1[i];
            uint flags = vigTuple.vObject.flags;
            if (31 < vigTuple.vObject.id && (flags & param2) != 0u && (flags & 32770u) == 0u)
            {
                num++;
            }
        }
        return num;
    }

    public VigObject FUN_30498(List<VigTuple> param1, uint param2, int param3)
    {
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigObject = param1[i].vObject;
            if (31 < vigObject.id && (vigObject.flags & param2) != 0u && (vigObject.flags & 32770u) == 0u && --param3 == -1)
            {
                break;
            }
            vigObject = null;
        }
        return vigObject;
    }

    public VigObject FUN_30498_2(List<VigTuple> param1, uint param2, int param3)
    {
        VigObject vigObject = null;
        for (int i = 0; i < param1.Count; i++)
        {
            vigObject = param1[i].vObject;
            if (31 < vigObject.id && (vigObject.flags & param2) != 0u && (vigObject.flags & 32770u) != 0u && --param3 == -1)
            {
                break;
            }
        }
        return vigObject;
    }

    public void FUN_307CC(VigObject param1)
    {
        if (param1 != null)
        {
            VigObject child;
            do
            {
                param1.FUN_306FC();
                if (param1.vLOD != null && param1.vLOD != param1.vMesh)
                {
                    this.FUN_1FEB8(param1.vLOD);
                }
                this.FUN_1FEB8(param1.vMesh);
                this.FUN_307CC(param1.child2);
                child = param1.child;
                UnityEngine.Object.Destroy(param1.gameObject);
                if (this.DAT_1068.Count > 0)
                {
                    List<VigTuple> dat_ = this.DAT_1068;
                    for (int i = 0; i < dat_.Count; i++)
                    {
                        VigObject vObject = dat_[i].vObject;
                        if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
                        {
                            vObject.UpdateW(10, param1);
                        }
                    }
                }
                param1 = child;
            }
            while (child != null);
        }
    }

    public void FUN_308C4(VigObject param1)
    {
        if (param1.vShadow != null)
        {
            this.FUN_4C4BC(param1.vShadow);
        }
        this.FUN_307CC(param1);
    }

    public void FUN_30904(VigObject param1)
    {
        if (param1.type == 255)
        {
            UnityEngine.Object.Destroy(param1.FUN_306FC().gameObject);
            return;
        }
        this.FUN_308C4(param1);
    }

    public void FUN_3094C(Tuple<List<VigTuple>, VigTuple> param1)
    {
        if (param1.Item2 != null)
        {
            param1.Item1.Remove(param1.Item2);
            this.FUN_308C4(param1.Item2.vObject);
        }
    }

    public void FUN_309A0(VigObject param1)
    {
        Tuple<List<VigTuple>, VigTuple> param2 = this.FUN_31868(param1);
        this.FUN_3094C(param2);
    }

    public void FUN_30B24(List<VigTuple> param1)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            this.FUN_2D9E0(param1[i].vObject);
        }
    }

    public void FUN_30CB0(VigObject param1, int param2)
    {
        if ((param1.flags & 1u) != 0u)
        {
            this.FUN_300B8(this.DAT_1110, param1);
        }
        VigTuple vigTuple = new VigTuple(null, 0u);
        vigTuple.vObject = param1;
        int dat_ = this.DAT_28;
        param1.flags |= 1u;
        vigTuple.flag = (uint)(param2 + dat_);
        List<VigTuple> dat_2 = this.DAT_1110;
        int num = 0;
        while (num < dat_2.Count && dat_2[num].flag < (uint)(param2 + dat_))
        {
            num++;
        }
        this.DAT_1110.Insert(0, vigTuple);
    }

    public void FUN_30DE8(BSP param1, int param2, int param3, int param4, int param5)
    {
        int num = param1.DAT_00;
        if (num == 1)
        {
            num = param1.DAT_04;
            if (param2 < num)
            {
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
            }
            if (param3 <= num)
            {
                return;
            }
        }
        else
        {
            if (num == 0)
            {
                this.FUN_30B24(param1.LDAT_04);
                return;
            }
            if (num == 2)
            {
                num = param1.DAT_04;
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
                if (param5 <= num)
                {
                    return;
                }
            }
            else
            {
                if (num != 3)
                {
                    return;
                }
                this.FUN_30DE8(param1.DAT_08, param2, param3, param4, param5);
            }
        }
        this.FUN_30DE8(param1.DAT_0C, param2, param3, param4, param5);
    }

    public Tuple<List<VigTuple>, VigTuple> FUN_310F4(BSP param1, VigObject param2)
    {
        while (param1.DAT_00 != 0)
        {
            Tuple<List<VigTuple>, VigTuple> tuple = this.FUN_310F4(param1.DAT_08, param2);
            if (tuple.Item2 != null)
            {
                return tuple;
            }
            param1 = param1.DAT_0C;
        }
        return new Tuple<List<VigTuple>, VigTuple>(param1.LDAT_04, this.FUN_30134(param1.LDAT_04, param2));
    }

    public VigObject FUN_31160(BSP param1, int param2, VigObject param3)
    {
        while (param1.DAT_00 != 0)
        {
            VigObject vigObject = this.FUN_31160(param1.DAT_08, param2, param3);
            if (vigObject != null)
            {
                return vigObject;
            }
            param1 = param1.DAT_0C;
        }
        return this.FUN_3027C(param1.LDAT_04, param2, param3);
    }

    public uint FUN_31248(BSP param1, int param2, int param3)
    {
        uint result;
        if (param1.DAT_00 == 0)
        {
            result = this.FUN_30334(param1.LDAT_04, param2, param3);
        }
        else
        {
            if (this.FUN_31248(param1.DAT_08, param2, param3) == 0u && this.FUN_31248(param1.DAT_0C, param2, param3) == 0u)
            {
                return 0u;
            }
            result = 1u;
        }
        return result;
    }

    public Tuple<List<VigTuple>, VigTuple> FUN_318A8(VigObject param1)
    {
        return this.FUN_310F4(this.bspTree, param1);
    }

    public VigObject FUN_318D0(int param1)
    {
        return this.FUN_31160(this.bspTree, param1, null);
    }

    public uint FUN_31924(int param1, int param2)
    {
        return this.FUN_31248(this.bspTree, param1, param2);
    }

    public VigObject FUN_311DC(BSP param1, Type param2)
    {
        while (param1.DAT_00 != 0)
        {
            VigObject vigObject = this.FUN_311DC(param1.DAT_08, param2);
            if (vigObject != null)
            {
                return vigObject;
            }
            param1 = param1.DAT_0C;
        }
        return this.FUN_302A8(param1.LDAT_04, param2);
    }

    public VigObject FUN_318F8(int param1, VigObject param2)
    {
        return this.FUN_31160(this.bspTree, param1, param2);
    }

    public VigObject FUN_31C98(int param1, int param2, Vector2Int param3, Vector2Int param4)
    {
        return this.FUN_31B30(this.bspTree, param1, param2, param3, param4);
    }

    public VigObject FUN_31B30(BSP param1, int param2, int param3, Vector2Int param4, Vector2Int param5)
    {
        int num = param1.DAT_00;
        bool flag;
        VigObject vigObject2;
        if (num == 1)
        {
            num = param1.DAT_04;
            if (param4.x < num)
            {
                VigObject vigObject = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                if (vigObject != null)
                {
                    return vigObject;
                }
            }
            flag = (num < param4.y);
        }
        else
        {
            if (num == 0)
            {
                return this.FUN_31A74(param1.LDAT_04, param2, param3, param4, param5);
            }
            if (num != 2)
            {
                if (num != 3)
                {
                    return null;
                }
                vigObject2 = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                if (vigObject2 != null)
                {
                    return vigObject2;
                }
                vigObject2 = this.FUN_31B30(param1.DAT_0C, param2, param3, param4, param5);
                if (vigObject2 != null)
                {
                    return vigObject2;
                }
                return null;
            }
            else
            {
                num = param1.DAT_04;
                if (param5.x < num)
                {
                    VigObject vigObject = this.FUN_31B30(param1.DAT_08, param2, param3, param4, param5);
                    if (vigObject != null)
                    {
                        return vigObject;
                    }
                }
                flag = (num < param5.y);
            }
        }
        if (!flag)
        {
            return null;
        }
        vigObject2 = this.FUN_31B30(param1.DAT_0C, param2, param3, param4, param5);
        if (vigObject2 == null)
        {
            vigObject2 = null;
        }
        return vigObject2;
    }

    public uint FUN_31A24(int param1, int param2)
    {
        uint num = this.FUN_30334(this.worldObjs, param1, param2);
        if (num == 0u)
        {
            return this.FUN_31248(this.bspTree, param1, param2);
        }
        return num;
    }

    public uint FUN_312DC(BSP param1, _EVENT_CALL param2, int param3)
    {
        uint num;
        if (param1.DAT_00 == 0)
        {
            num = this.FUN_303C0(param1.LDAT_04, param2, param3);
        }
        else
        {
            num = this.FUN_312DC(param1.DAT_08, param2, param3);
            if (num == 0u)
            {
                num = this.FUN_312DC(param1.DAT_0C, param2, param3);
                if (num == 0u)
                {
                    num = 0u;
                }
            }
        }
        return num;
    }

    public VigObject FUN_31A74(List<VigTuple> param1, int param2, int param3, Vector2Int param4, Vector2Int param5)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (param2 <= (int)vObject.id && (int)vObject.id <= param3)
            {
                int dat_ = vObject.DAT_58;
                if (param4.x < vObject.screen.x + dat_ && vObject.screen.x - dat_ < param4.y && param5.x < vObject.screen.z + dat_ && vObject.screen.z - dat_ < param5.y)
                {
                    return vObject;
                }
            }
        }
        return null;
    }

    public void FUN_3150C()
    {
        if (this.bspTree != null)
        {
            Vector3Int vector3Int = default(Vector3Int);
            vector3Int.x = -GameManager.instance.DAT_EDC / 2;
            vector3Int.y = 0;
            vector3Int.z = GameManager.instance.DAT_ED8;
            Vector3Int vector3Int2 = default(Vector3Int);
            vector3Int2.x = GameManager.instance.DAT_EDC / 2;
            vector3Int2.y = 0;
            vector3Int2.z = GameManager.instance.DAT_ED8;
            vector3Int = Utilities.VectorNormal(vector3Int);
            vector3Int2 = Utilities.VectorNormal(vector3Int2);
            Utilities.SetRotMatrix(GameManager.instance.DAT_F28.rotation);
            vector3Int = Utilities.FUN_23EA0(vector3Int);
            vector3Int2 = Utilities.FUN_23EA0(vector3Int2);
            int num = vector3Int2.x;
            int num2 = vector3Int.x;
            int num3 = num;
            if (num2 < num)
            {
                num3 = num2;
            }
            int num4 = 0;
            if (num3 < 0)
            {
                num4 = num3;
            }
            if (num < num2)
            {
                num = num2;
            }
            num3 = 0;
            if (0 < num)
            {
                num3 = num;
            }
            num = vector3Int2.z;
            int z = vector3Int.z;
            num2 = num;
            if (z < num)
            {
                num2 = z;
            }
            int num5 = 0;
            if (num2 < 0)
            {
                num5 = num2;
            }
            if (num < z)
            {
                num = z;
            }
            num2 = 0;
            if (0 < num)
            {
                num2 = num;
            }
            this.FUN_30DE8(this.bspTree, GameManager.instance.DAT_F28.position.x + num4 * 1024, GameManager.instance.DAT_F28.position.x + num3 * 1024, GameManager.instance.DAT_F28.position.z + num5 * 1024, GameManager.instance.DAT_F28.position.z + num2 * 1024);
        }
    }

    public void FUN_31360(ushort param1)
    {
        List<VigTuple> dat_10A = this.DAT_10A8;
        for (int i = 0; i < dat_10A.Count; i++)
        {
            VigTuple vigTuple = dat_10A[i];
            if (vigTuple.vObject != null)
            {
                this.FUN_2FEE8(vigTuple.vObject, param1);
            }
        }
    }

    public void FUN_313C8(int param1)
    {
        for (int i = 0; i < this.DAT_1088.Count; i++)
        {
            if (this.DAT_1088[i].vObject != null && this.DAT_1088[i].vObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                this.DAT_1088[i].vObject.UpdateW(0, param1);
            }
        }
    }

    public void FUN_31440(uint param1)
    {
        for (int i = 0; i < this.DAT_1110.Count; i++)
        {
            VigTuple vigTuple = this.DAT_1110[i];
            if (param1 >= vigTuple.flag)
            {
                VigObject vObject = vigTuple.vObject;
                if (!(vObject == null))
                {
                    vObject.flags &= 4294967294u;
                    this.DAT_1110.RemoveAt(i--);
                    if (vObject.GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        vObject.UpdateW(2, 0);
                    }
                }
            }
        }
    }

    public void FUN_31678()
    {
        if (this.drawTerrain)
        {
            this.FUN_1C134();
        }
        this.FUN_2DE18();
        if (this.drawRoads)
        {
            this.FUN_50B38();
        }
        JobHandle.ScheduleBatchedJobs();
        if (this.drawPlayer)
        {
            this.FUN_30B24(this.worldObjs);
            this.FUN_30B24(this.interObjs);
        }
        if (this.drawObjects)
        {
            this.FUN_3150C();
        }
        this.terrainHandle.Complete();
        this.nativeArray.Dispose();
        this.terrain.CreateTerrainMesh();
        Junction.junctionHandle.Complete();
        for (int i = 0; i < GameManager.updateJunc.Count; i++)
        {
            GameManager.updateJunc[i].CreateRoadData();
        }
        GameManager.updateJunc.Clear();
        if (this.drawTerrain)
        {
            this.terrain.FUN_1C910();
        }
        LevelManager.instance.level.UpdateW(17, 0);
        if (this.DAT_1124 != null)
        {
            this.FUN_33728(this.DAT_1124, LevelManager.instance.DAT_10F8);
        }
    }

    public void FUN_31728()
    {
        this.FUN_3174C();
    }

    public Tuple<List<VigTuple>, VigTuple> FUN_31868(VigObject param1)
    {
        Tuple<List<VigTuple>, VigTuple> tuple = new Tuple<List<VigTuple>, VigTuple>(this.worldObjs, this.FUN_30134(this.worldObjs, param1));
        if (tuple.Item2 == null)
        {
            return this.FUN_310F4(this.bspTree, param1);
        }
        return tuple;
    }

    public VigObject FUN_31950(int param1)
    {
        VigObject vigObject = this.FUN_3027C(this.worldObjs, param1, null);
        if (vigObject == null)
        {
            vigObject = this.FUN_31160(this.bspTree, param1, null);
        }
        return vigObject;
    }

    public VigObject FUN_31994(Type param1)
    {
        VigObject vigObject = this.FUN_302A8(this.worldObjs, param1);
        if (vigObject == null)
        {
            vigObject = this.FUN_311DC(this.bspTree, param1);
        }
        return vigObject;
    }

    public VigObject FUN_31EDC(int param1)
    {
        VigObject vigObject = this.FUN_30250(this.DAT_1078, param1);
        VigObject result;
        if (vigObject == null)
        {
            result = null;
        }
        else
        {
            result = vigObject.FUN_31DDC();
        }
        return result;
    }

    public VigObject FUN_31F1C(Vector3Int param1)
    {
        uint num = uint.MaxValue;
        VigObject result = null;
        List<VigTuple> dat_ = this.DAT_1078;
        for (int i = 0; i < dat_.Count; i++)
        {
            VigObject vObject = dat_[i].vObject;
            if (vObject.id - 1 < 31)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param1, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    result = vObject;
                }
            }
        }
        return result;
    }

    public Vehicle FUN_3208C(int param1)
    {
        Placeholder param2 = (Placeholder)this.FUN_30250(this.DAT_1078, param1);
        int num = param1 + 1;
        if (param1 < 0)
        {
            num = ~param1;
        }
        return this.FUN_36C2C(param2, (int)this.vehicles[num], param1);
    }

    public Vehicle FUN_3208C(int param1, int param2)
    {
        Placeholder placeholder = (Placeholder)this.FUN_30250(this.DAT_1078, param2);
        if (placeholder == null)
        {
            placeholder = (Placeholder)this.FUN_30250(this.DAT_1078, -1);
        }
        int num = param1 + 1;
        if (param1 < 0)
        {
            num = ~param1;
        }
        return this.FUN_36C2C(placeholder, (int)this.vehicles[num], param1);
    }

    public VigObject FUN_320DC(Vector3Int param1, int param2)
    {
        VigObject vigObject = null;
        VigObject vigObject2 = null;
        int num = -1;
        int num2 = -1;
        sbyte b;
        if (param2 < 0)
        {
            b = this.DAT_1128[~param2];
        }
        else
        {
            b = -1;
        }
        List<VigTuple> list = this.worldObjs;
        for (int i = 0; i < list.Count; i++)
        {
            VigObject vObject = list[i].vObject;
            if (vObject.type == 2 && vObject.maxHalfHealth != 0)
            {
                int num3 = Utilities.FUN_29F6C(param1, vObject.screen);
                int num4 = (int)vObject.id;
                if (num4 != param2 && (0 < num4 || b != this.DAT_1128[~num4]))
                {
                    num4 = num3;
                    int num5 = num;
                    VigObject vigObject3 = vObject;
                    VigObject vigObject4 = vigObject;
                    if (num3 >= num2)
                    {
                        num4 = num2;
                        num5 = num3;
                        vigObject3 = vigObject2;
                        vigObject4 = vObject;
                        if (num3 >= num)
                        {
                            goto IL_AE;
                        }
                    }
                    num2 = num4;
                    num = num5;
                    vigObject2 = vigObject3;
                    vigObject = vigObject4;
                }
            }
        IL_AE:;
        }
        if (vigObject2 == null)
        {
            vigObject2 = vigObject;
        }
        return vigObject2;
    }

    public void FUN_327CC(VigObject param1)
    {
        short id = param1.id;
        if (param1.parent == null && param1.type == 0)
        {
            List<VigTuple> list = this.worldObjs;
            for (int i = 0; i < list.Count; i++)
            {
                VigTuple vigTuple = list[i];
                if (vigTuple.vObject.id == id && vigTuple.vObject.type == 3)
                {
                    this.FUN_3094C(new Tuple<List<VigTuple>, VigTuple>(list, vigTuple));
                }
            }
            VigTuple vigTuple2 = this.FUN_301DC(this.DAT_1078, (int)id);
            if (vigTuple2 == null)
            {
                if (120 < param1.maxHalfHealth)
                {
                    uint num = GameManager.FUN_2AC5C();
                    if ((num & 3u) == 0u)
                    {
                        int num2 = (int)GameManager.FUN_2AC5C();
                        int num3 = (num2 << 1) + num2;
                        num3 = (num3 << 6) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 >>= 15;
                        num3 -= 1525;
                        Vector3Int param2 = default(Vector3Int);
                        param2.x = num3;
                        param2.y = -4577;
                        num2 = (int)GameManager.FUN_2AC5C();
                        num3 = (num2 << 1) + num2;
                        num3 = (num3 << 6) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 = (num3 << 2) - num2;
                        num3 >>= 15;
                        num3 -= 1525;
                        param2.z = num3;
                        LevelManager.instance.FUN_4AAC0(4269277184u, param1.screen, param2);
                        return;
                    }
                }
            }
            else
            {
                uint num = vigTuple2.vObject.flags;
                if ((num & 2u) == 0u)
                {
                    if ((num & 512u) != 0u)
                    {
                        return;
                    }
                }
                else
                {
                    VigObject vigObject = this.FUN_4AC1C(4294705152u, vigTuple2.vObject);
                    if (vigObject != null)
                    {
                        vigObject.flags &= 4278190077u;
                        num = vigTuple2.vObject.flags;
                        if ((num & 512u) == 0u)
                        {
                            vigTuple2.vObject.flags = ((num & 4294967293u) | 512u);
                            return;
                        }
                    }
                }
                if (vigTuple2.vObject.GetType() == typeof(Placeholder))
                {
                    return;
                }
                if (this.gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
                {
                    this.FUN_3094C(new Tuple<List<VigTuple>, VigTuple>(this.DAT_1078, vigTuple2));
                }
            }
        }
    }

    public VigTuple FUN_335FC(VigObject param1)
    {
        VigTuple vigTuple = new VigTuple(param1, 0u);
        this.DAT_1098.Add(vigTuple);
        return vigTuple;
    }

    public void FUN_33728(SunLensFlare param1, Vector3Int param2)
    {
        param1.vTransform.position = Utilities.ApplyMatrixSV(this.DAT_F00.rotation, param1.vr);
        param1.vTransform.position.x = param1.vTransform.position.x << 6;
        param1.vTransform.position.y = param1.vTransform.position.y << 6;
        param1.vTransform.position.z = param1.vTransform.position.z << 6;
        param1.vMesh.FUN_21F70(param1.vTransform);
    }

    public VigObject FUN_34120(List<VigTuple> param1, uint param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject result = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && (vObject.flags & 16384u) != 0u && (vObject.flags & param2) != 0u && !((Pickup)vObject).cannotReach)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    result = vObject;
                }
            }
        }
        return result;
    }

    public VigObject FUN_34120_2(List<VigTuple> param1, uint param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject result = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && (vObject.flags & param2) != 0u)
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    result = vObject;
                }
            }
        }
        return result;
    }

    public VigObject FUN_34120_3(List<VigTuple> param1, List<ushort> param2, Vector3Int param3)
    {
        uint num = uint.MaxValue;
        VigObject result = null;
        for (int i = 0; i < param1.Count; i++)
        {
            VigObject vObject = param1[i].vObject;
            if (31 < vObject.id && param2.Contains((ushort)vObject.DAT_1A))
            {
                uint num2 = (uint)Utilities.FUN_29F6C(param3, vObject.screen);
                if (num2 < num)
                {
                    num = num2;
                    result = vObject;
                }
            }
        }
        return result;
    }

    private void FUN_347A8(uint param1)
    {
        uint num = (uint)((short)this.levelManager.DAT_C18[1] * 2);
        uint num2 = (uint)this.DAT_1038;
        if (num2 < num)
        {
            do
            {
                int num3 = (int)GameManager.FUN_2AC5C();
                int num4 = this.FUN_30428(this.DAT_1078, param1);
                num4 = num3 * num4;
                VigObject vigObject = this.FUN_30498(this.DAT_1078, param1, num4 >> 15);
                vigObject = this.FUN_4AC6C(param1, vigObject);
                if (vigObject == null)
                {
                    break;
                }
                num = (uint)((short)this.levelManager.DAT_C18[1] * 2);
                int num5 = this.DAT_1038 + 1;
                this.DAT_1038 = num5;
                num2 = (uint)num5;
            }
            while (num2 < num);
        }
    }

    private void FUN_349A0()
    {
        int num = 0;
        int num2 = 4;
        if (this.gameMode > _GAME_MODE.Versus2)
        {
            num2 = 6;
        }
        while (this.DAT_C6E != 0 || this.spawns != 30 || this.DAT_CC4 > 30)
        {
            if (this.DAT_C6E == 1 && this.spawns == 70 && this.DAT_CC4 <= 70)
            {
                return;
            }
            if (this.spawns == 70 && this.DAT_CC4 < 70)
            {
                return;
            }
            if (this.gameMode > _GAME_MODE.Versus2 && !DiscordController.IsOwner())
            {
                return;
            }
            if (-1 < (sbyte)this.vehicles[2 + num] && this.DAT_1030[num] != 0)
            {
                VigObject vigObject = this.FUN_302D4(this.worldObjs, 2u, num + 1);
                if (vigObject == null)
                {
                    if (this.gameMode == _GAME_MODE.Survival || this.gameMode == _GAME_MODE.Survival2)
                    {
                        for (int i = 0; i < this.vehicles.Length - 2; i++)
                        {
                            if ((int)this.vehicles[i + 2] == this.survival[this.currentSpawn])
                            {
                                this.currentSpawn++;
                                if (this.currentSpawn >= this.survival.Count)
                                {
                                    this.currentSpawn = 0;
                                }
                                i = -1;
                            }
                        }
                        this.vehicles[2 + num] = (byte)this.survival[this.currentSpawn];
                    }
                    if (this.gameMode < _GAME_MODE.Coop2)
                    {
                        vigObject = this.FUN_3208C(num + 1);
                    }
                    else
                    {
                        vigObject = this.FUN_3208C(num + 1, num % 4 + 1);
                    }
                    if (vigObject != null)
                    {
                        int num3 = 0;
                        vigObject.tags = 1;
                        vigObject.flags &= 33554431u;
                        for (; ; )
                        {
                            int num4 = (int)GameManager.FUN_2AC5C();
                            if ((vigObject.flags & GameManager.DAT_63A6C[(int)((uint)((uint)num4 << 2) >> 15)]) == 0u)
                            {
                                vigObject.flags |= GameManager.DAT_63A6C[(int)((uint)((uint)num4 << 2) >> 15)];
                                num3++;
                                if (num3 >= 3)
                                {
                                    break;
                                }
                            }
                        }
                        uint flags = vigObject.flags;
                        vigObject.FUN_3066C();
                        num3 = (int)(vigObject.vTransform.rotation.V02 * 4577);
                        if (num3 < 0)
                        {
                            num3 += 31;
                        }
                        vigObject.physics1.X = num3 >> 5;
                        vigObject.physics1.Y = 0;
                        num3 = (int)(vigObject.vTransform.rotation.V22 * 4577);
                        if (num3 < 0)
                        {
                            num3 += 31;
                        }
                        vigObject.physics1.Z = num3 >> 5;
                        sbyte[] dat_ = this.DAT_1030;
                        int num5 = num;
                        dat_[num5] -= 1;
                        this.spawns++;
                        if (this.gameMode > _GAME_MODE.Versus2)
                        {
                            this.networkEnemies.Add((Vehicle)vigObject);
                            this.enemiesDictionary[vigObject.id] = (Vehicle)vigObject;
                            ClientSend.SpawnAI(vigObject.id, (byte)((Vehicle)vigObject).vehicle, flags);
                        }
                    }
                }
            }
            num++;
            if (num >= num2)
            {
                return;
            }
        }
    }

    public void FUN_34B34()
    {
        VigTuple[] array = new VigTuple[32];
        int num = 0;
        int i = 0;
        int num2 = 0;
        this.lowHealth = false;
        int num3;
        if ((this.DAT_40 & 4096) == 0)
        {
            num3 = 1;
            if (this.DAT_C6E != 0)
            {
                num3 = 2;
            }
        }
        else
        {
            num3 = 3;
        }
        uint num4 = 0u;
        int num5 = 0;
        uint num6 = uint.MaxValue;
        int num7 = 1;
        this.DAT_1130++;
        uint num8 = 4261412864u;
        if (this.gameMode == _GAME_MODE.Arcade || this.gameMode == _GAME_MODE.Survival || this.gameMode == _GAME_MODE.Coop || this.gameMode == _GAME_MODE.Demo || this.gameMode == _GAME_MODE.Coop2 || this.gameMode == _GAME_MODE.Survival2)
        {
            this.FUN_349A0();
        }
        if (this.gameMode > _GAME_MODE.Versus2)
        {
            num3++;
        }
        if (this.gameMode == _GAME_MODE.Survival || this.gameMode == _GAME_MODE.Survival2)
        {
            num3 += this.DAT_CC4 / 25;
        }
        List<VigTuple> list = this.worldObjs;
        for (int j = 0; j < list.Count; j++)
        {
            VigTuple vigTuple = list[j];
            VigObject vObject = vigTuple.vObject;
            if (vObject.type == 2 || vObject.type == 13)
            {
                Vehicle vehicle = (Vehicle)vObject;
                if (vObject.id < 0 && vObject.type == 2 && this.gameMode != _GAME_MODE.Demo)
                {
                    if (vObject.maxHalfHealth != 0)
                    {
                        num5++;
                        num4 |= 1u << (int)this.DAT_1128[(int)(~(int)vObject.id)];
                        if (vehicle.weapons[2] == null)
                        {
                            num7 = 1;
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            VigObject vigObject = vehicle.weapons[k];
                            if (vigObject != null && (int)vigObject.maxFullHealth << 1 <= (int)vigObject.maxHalfHealth)
                            {
                                num8 &= ~(16777216u << (int)vigObject.tags);
                            }
                        }
                        if (vehicle.body[0] == null)
                        {
                            if (vehicle.maxFullHealth > vehicle.maxHalfHealth * 3)
                            {
                                this.lowHealth = true;
                            }
                        }
                        else if (vehicle.maxFullHealth > (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3)
                        {
                            this.lowHealth = true;
                        }
                    }
                }
                else
                {
                    if (vehicle.maxHalfHealth != 0)
                    {
                        uint num9 = vObject.flags;
                        if ((num9 & 67108864u) == 0u)
                        {
                            if (vObject.vTransform.rotation.V11 < 0)
                            {
                                if (vehicle.wheelsType == _WHEELS.Sea && (num9 & 268435456u) == 0u)
                                {
                                    vehicle.FUN_391AC();
                                }
                                else if (vehicle.ignition <= 0)
                                {
                                    Vehicle vehicle2 = vehicle;
                                    vehicle2.physics2.Z = vehicle2.physics2.Z + 65536;
                                    Vehicle vehicle3 = vehicle;
                                    vehicle3.flip += 10;
                                }
                            }
                            else
                            {
                                TileData tileByPosition = this.terrain.GetTileByPosition((uint)vObject.vTransform.position.x, (uint)vObject.vTransform.position.z);
                                if (((num9 & 536870912u) == 0u && vehicle.vTransform.position.x > 0 && vehicle.vTransform.position.z > 0 && vehicle.vTransform.position.x < 117440512 && vehicle.vTransform.position.z < 117440512) || (this.terrain.DAT_DE4 <= vehicle.vTransform.position.x && vObject.vTransform.position.x <= this.terrain.DAT_DE8 && this.terrain.DAT_DEC <= vehicle.vTransform.position.z && vehicle.vTransform.position.z <= this.terrain.DAT_DF0 && tileByPosition.DAT_10[3] != 7) || (vehicle.tags == 1 && (this.DAT_1130 & 3) != 0))
                                {
                                    if (vehicle.tags != 1 && vehicle.tags != 4)
                                    {
                                        if (vehicle.DAT_B3 * 3 >> 2 < (int)vehicle.acceleration && vehicle.physics1.W < 457 && vehicle.tags != 0)
                                        {
                                            vehicle.direction = -1;
                                            vehicle.turning = 0;
                                            vehicle.tags = 0;
                                            if (vehicle.acceleration < 40)
                                            {
                                                vehicle.acceleration = (short)vehicle.DAT_B3;
                                            }
                                            else
                                            {
                                                vehicle.acceleration = (short)((uint)vehicle.DAT_B3 >> 2);
                                            }
                                        }
                                        else if (vehicle.id < 0)
                                        {
                                            if (vehicle.target == null)
                                            {
                                                vehicle.tags = 3;
                                                vehicle.DAT_F4 = 0;
                                            }
                                            else
                                            {
                                                vehicle.tags = 2;
                                            }
                                        }
                                        else
                                        {
                                            uint num10 = (uint)Utilities.FUN_29F6C(this.playerObjects[0].vTransform.position, vehicle.vTransform.position);
                                            if (this.gameMode == _GAME_MODE.Demo && num10 < num6)
                                            {
                                                num6 = num10;
                                            }
                                            VigObject vigObject2 = this.playerObjects[0];
                                            if ((this.gameMode - _GAME_MODE.Coop < 2 || this.gameMode > _GAME_MODE.Versus2) && this.playerObjects[1] != null)
                                            {
                                                uint num11 = (uint)Utilities.FUN_29F6C(this.playerObjects[1].vTransform.position, vehicle.vTransform.position);
                                                if (num11 < num10)
                                                {
                                                    vigObject2 = this.playerObjects[1];
                                                    num10 = num11;
                                                }
                                            }
                                            vehicle.target = vigObject2;
                                            if (vehicle.tags == 0)
                                            {
                                                vehicle.tags = 3;
                                                vehicle.DAT_F4 = 0;
                                                vehicle.ai.rubberTimer = 500;
                                                array[i++] = new VigTuple(vObject, num10);
                                            }
                                            else if (vehicle.tags == 2)
                                            {
                                                if (2048000u < num10)
                                                {
                                                    vehicle.tags = 3;
                                                    vehicle.DAT_F4 = 0;
                                                    array[i++] = new VigTuple(vObject, num10);
                                                }
                                                else
                                                {
                                                    if (vehicle.weapons[1] == null)
                                                    {
                                                        vehicle.tags = 3;
                                                    }
                                                    else
                                                    {
                                                        if (vehicle.body[0] == null)
                                                        {
                                                            if (vehicle.maxFullHealth < vehicle.maxHalfHealth * 3)
                                                            {
                                                                int k = Utilities.FUN_29F6C(vehicle.target.vTransform.position, vehicle.vTransform.position);
                                                                if (2287 < vehicle.target.physics1.W || 204799 < k)
                                                                {
                                                                    num2++;
                                                                    goto IL_78F;
                                                                }
                                                                vehicle.tags = 3;
                                                            }
                                                            else
                                                            {
                                                                this.lowHealth = true;
                                                            }
                                                        }
                                                        else if (vehicle.maxFullHealth < (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3)
                                                        {
                                                            int k = Utilities.FUN_29F6C(vehicle.target.vTransform.position, vehicle.vTransform.position);
                                                            if (2287 < vehicle.target.physics1.W || 204799 < k)
                                                            {
                                                                num2++;
                                                                goto IL_78F;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            this.lowHealth = true;
                                                        }
                                                        vehicle.tags = 3;
                                                    }
                                                    vehicle.DAT_F4 = 0;
                                                }
                                            }
                                            else if (vehicle.weapons[1] != null)
                                            {
                                                if (vehicle.body[0] == null)
                                                {
                                                    num9 = (uint)vehicle.maxHalfHealth;
                                                }
                                                else
                                                {
                                                    num9 = (uint)(vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth);
                                                }
                                                if ((uint)vehicle.maxFullHealth < num9 * 3u)
                                                {
                                                    array[i++] = new VigTuple(vObject, num10);
                                                }
                                                else
                                                {
                                                    this.lowHealth = true;
                                                }
                                            }
                                        }
                                    IL_78F:
                                        if (vehicle.weapons[0] == null)
                                        {
                                            num7 = 1;
                                        }
                                    }
                                }
                                else
                                {
                                    VigObject vigObject2 = this.FUN_31F1C(vehicle.vTransform.position);
                                    vehicle.vTransform = vigObject2.vTransform;
                                    vehicle.tags = 1;
                                    int k = (int)(vObject.vTransform.rotation.V02 * 4577);
                                    Vehicle vehicle4 = vehicle;
                                    vehicle4.vTransform.position.y = vehicle4.vTransform.position.y - 32768;
                                    vehicle.flags |= 32u;
                                    if (k < 0)
                                    {
                                        k += 31;
                                    }
                                    vehicle.physics1.X = k >> 5;
                                    vehicle.physics1.Y = 0;
                                    k = (int)(vehicle.vTransform.rotation.V22 * 4577);
                                    if (k < 0)
                                    {
                                        k += 31;
                                    }
                                    vehicle.physics1.Z = k >> 5;
                                    vehicle.physics2.X = 0;
                                    vehicle.physics2.Y = 0;
                                    vehicle.physics2.Z = 0;
                                }
                            }
                        }
                    }
                    if (vObject.id != 0 && vObject.type == 2)
                    {
                        num++;
                    }
                }
            }
        }
        if (this.gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
        {
            if (num7 != 0)
            {
                if (num8 == 0u)
                {
                    num8 = 4261412864u;
                }
                this.FUN_347A8(num8);
            }
            this.FUN_34840();
            if (LevelManager.instance.level.id == 0)
            {
                this.FUN_34914();
            }
        }
        if (this.gameMode == _GAME_MODE.Alone)
        {
            return;
        }
        if (this.gameMode == _GAME_MODE.Versus)
        {
            return;
        }
        if (this.DAT_C74 != 0)
        {
            return;
        }
        if (_GAME_MODE.Unk1 < this.gameMode && this.gameMode < _GAME_MODE.Versus2)
        {
            if (this.gameMode == _GAME_MODE.Unk2)
            {
                if (1 < num5)
                {
                    return;
                }
            }
            else if (num4 == 3u)
            {
                return;
            }
            this.DAT_C74 = 1;
            return;
        }
        if (this.gameMode == _GAME_MODE.Survival)
        {
            int num12;
            if (this.DAT_CC4 <= 80)
            {
                num12 = this.DAT_CC4 % 70;
            }
            else
            {
                num12 = this.DAT_CC4;
            }
            int num13 = num12 * 2;
            int k = num13;
            if (num13 < 0)
            {
                k = num13 + 3;
            }
            num13 += (k >> 2) * -4;
            while (true)
            {
                bool flag = num < num12 + 1;
                if (4 < num12 + 1)
                {
                    flag = (num < 4);
                }
                k = 0;
                if (!flag)
                {
                    break;
                }
                do
                {
                    if (DAT_1030[num13] == 0)
                    {
                        DAT_1030[num13] = 1;
                        break;
                    }
                    int num17 = 3;
                    if (num13 != 0)
                    {
                        num17 = num13 - 1;
                    }
                    k++;
                    num13 = num17;
                }
                while (k < 4);
                num++;
            }
        }
        if (this.gameMode == _GAME_MODE.Survival2 && DiscordController.IsOwner())
            if (this.gameMode == _GAME_MODE.Survival2 && DiscordController.IsOwner())
            {
                int num12;
                if (this.DAT_CC4 <= 80)
                {
                    num12 = this.DAT_CC4 % 70;
                }
                else
                {
                    num12 = this.DAT_CC4;
                }
                int num13 = num12 * 2;
                int k = num13;
                if (num13 < 0)
                {
                    k = num13 + 3;
                }
                num13 += (k >> 2) * -4;
                while (true)
                {
                    bool flag = num < num12 + 1;
                    if (6 < num12 + 1)
                    {
                        flag = (num < 6);
                    }
                    k = 0;
                    if (!flag)
                    {
                        break;
                    }
                    do
                    {
                        if (DAT_1030[num13] == 0)
                        {
                            DAT_1030[num13] = 1;
                            break;
                        }
                        int num17 = 5;
                        if (num13 != 0)
                        {
                            num17 = num13 - 1;
                        }
                        k++;
                        num13 = num17;
                    }
                    while (k < 6);
                    num++;
                }
            }
        if (num2 < num3)
        {
            int k;
            bool flag;
            do
            {
                flag = false;
                k = 0;
                if (0 < i - 1)
                {
                    int num13 = 0;
                    VigTuple vigTuple;
                    VigTuple vigTuple2;
                    for (; ; )
                    {
                        vigTuple2 = array[num13];
                        vigTuple = array[++k];
                        if (array[k].flag < array[num13].flag)
                        {
                            break;
                        }
                        num13 = k;
                        if (k >= i - 1)
                        {
                            goto IL_B5C;
                        }
                    }
                    VigObject vObject2 = vigTuple2.vObject;
                    uint flag2 = array[num13].flag;
                    uint flag3 = array[k].flag;
                    vigTuple2.vObject = vigTuple.vObject;
                    array[num13].flag = flag3;
                    flag3 = flag2;
                    vigTuple.vObject = vObject2;
                    array[k].flag = flag3;
                    flag = true;
                }
            IL_B5C:;
            }
            while (flag);
            k = 0;
            if (num2 < num3)
            {
                while (i > k)
                {
                    num2++;
                    VigObject vObject = array[k].vObject;
                    vObject.tags = 2;
                    k++;
                    if (num2 >= num3)
                    {
                        break;
                    }
                }
            }
        }
        if (this.gameMode != _GAME_MODE.Versus2)
        {
            if (this.gameMode == _GAME_MODE.Coop2)
            {
                bool flag = true;
                for (int l = 0; l < 4; l++)
                {
                    if (this.DAT_1030[l] != 0)
                    {
                        flag = false;
                    }
                }
                if (!flag)
                {
                    return;
                }
            }
            if (num == 0 && this.gameMode != _GAME_MODE.Survival2)
            {
                if (this.gameMode != _GAME_MODE.Quest)
                {
                    _GAME_MODE game_MODE = this.gameMode;
                }
                if (!this.gameEnded)
                {
                    UIManager.instance.WinScreen();
                }
                this.gameEnded = true;
                this.DAT_C74 = 1;
                this.playerObjects[0].vCamera.flags |= 33554432u;
            }
            if ((this.gameMode == _GAME_MODE.Survival || this.gameMode == _GAME_MODE.Survival2) && this.DAT_C74 == 0)
            {
                if (this.DAT_C6E == 0)
                {
                    if (this.DAT_CC4 == 30)
                    {
                        this.playerObjects[0].vCamera.flags |= 33554432u;
                        this.DAT_C74 = 1;
                        UIManager.instance.GoodJob();
                    }
                }
                else if (this.DAT_C6E == 1 && this.DAT_CC4 == 70)
                {
                    this.playerObjects[0].vCamera.flags |= 33554432u;
                    this.DAT_C74 = 1;
                    UIManager.instance.GoodJob();
                }
            }
            _GAME_MODE game_MODE2 = this.gameMode;
            return;
        }
        if (num == 0)
        {
            bool flag4 = true;
            for (int m = 0; m < this.DAT_1030.Length; m++)
            {
                if (this.DAT_1030[m] != 0)
                {
                    flag4 = false;
                }
            }
            if (flag4)
            {
                if (!this.gameEnded)
                {
                    UIManager.instance.WinScreen();
                }
                this.gameEnded = true;
                this.DAT_C74 = 1;
                this.playerObjects[0].vCamera.flags |= 33554432u;
                return;
            }
        }
        if (this.playerObjects[0].maxHalfHealth == 0 && this.playerObjects[0].DAT_C8 >= 540 && this.playerSpawns > 0)
        {
            this.playerSpawns -= 1;
            int param = this.FUN_1DD9C();
            this.FUN_1E580(param, GameManager.instance.DAT_C2C, 66, this.playerObjects[0].vTransform.position, false);
            LevelManager.instance.FUN_4DE54(this.playerObjects[0].vTransform.position, 39);
            this.FUN_309A0(this.playerObjects[0]);
            LevelManager.instance.defaultCamera.transform.SetParent(null, false);
            this.FUN_307CC(this.playerObjects[0].vCamera);
            this.playerObjects[0] = this.FUN_3208C(-1, ~DiscordController.GetMemberId());
            this.playerObjects[0].FUN_3066C();
            LevelManager.instance.FUN_3D94(this.playerObjects[0]);
            ClientSend.Spawn();
            return;
        }
    }

    private global::Navigation FUN_35A6C(global::Navigation param1, global::Navigation param2)
    {
        global::Navigation navigation = param1;
        global::Navigation navigation2 = null;
        if (param1 != null)
        {
            do
            {
                global::Navigation navigation3 = navigation;
                navigation = navigation3;
                if (param2.DAT_14 <= navigation3.DAT_14)
                {
                    break;
                }
                navigation = navigation3.next;
                navigation2 = navigation3;
            }
            while (navigation != null);
        }
        param2.next = navigation;
        if (navigation2 == null)
        {
            return param2;
        }
        navigation2.next = param2;
        return param1;
    }

    private void FUN_35AC0(global::Navigation param1)
    {
        if (param1 != null)
        {
            do
            {
                int num = param1.aimpIndex + (int)param1.DAT_10;
                ushort[] aimpData = this.levelManager.aimpData;
                int num2 = num + 1;
                aimpData[num2] &= 40959;
                param1 = param1.next;
            }
            while (param1 != null);
        }
    }

    private global::Navigation FUN_35B00(int param1, int param2)
    {
        global::Navigation dat_ = this.DAT_1138;
        if (this.DAT_1138 != null)
        {
            this.DAT_1138 = this.DAT_1138.next;
        }
        uint num = 11u;
        if (dat_ != null)
        {
            uint num2 = (uint)((uint)param1 << 21);
            int num3 = param2 << 21;
            int num4 = 0;
            uint num5;
            ushort num6;
            for (; ; )
            {
                num -= 1u;
                num5 = num2 >> 31;
                if (num3 < 0)
                {
                    num5 |= 2u;
                }
                num6 = this.levelManager.aimpData[num4 + (int)num5 + 1];
                if (num6 == 0)
                {
                    break;
                }
                num2 <<= 1;
                if ((num6 & 32768) != 0)
                {
                    break;
                }
                num3 <<= 1;
                num4 += (int)(num6 * 5);
            }
            num6 = (ushort)(-1 << (int)num);
            dat_.aimpIndex = num4;
            dat_.DAT_10 = (byte)num5;
            dat_.DAT_11 = (byte)num;
            dat_.DAT_0C = (ushort)(param1 & (int)num6);
            dat_.DAT_0E = (ushort)(param2 & (int)num6);
        }
        return dat_;
    }

    private global::Navigation FUN_35BAC(global::Navigation param1, uint param2, uint param3)
    {
        global::Navigation dat_ = this.DAT_1138;
        if (this.DAT_1138 != null)
        {
            int num = param1.aimpIndex;
            uint num2 = (uint)param1.DAT_11;
            int num3 = (int)(((uint)param1.DAT_0C ^ param2) | ((uint)param1.DAT_0E ^ param3)) >> (int)num2;
            for (; ; )
            {
                num3 >>= 1;
                num2 += 1u;
                if (num3 == 0)
                {
                    goto IL_85;
                }
                if (this.levelManager.aimpData[num] == 0)
                {
                    break;
                }
                num += (int)this.levelManager.aimpData[num] * -5;
            }
            this.DAT_1138 = this.DAT_1138.next;
            return null;
        IL_85:
            uint num4 = param2 << (int)(32u - num2);
            num3 = (int)((int)param3 << (int)(32u - num2));
            uint num5;
            ushort num6;
            for (; ; )
            {
                num2 -= 1u;
                num5 = num4 >> 31;
                if (num3 < 0)
                {
                    num5 |= 2u;
                }
                num6 = this.levelManager.aimpData[(int)(checked((IntPtr)(unchecked((long)num + (long)((ulong)num5) + 1L))))];
                if (num6 == 0)
                {
                    break;
                }
                num4 <<= 1;
                if ((num6 & 32768) != 0)
                {
                    break;
                }
                num3 <<= 1;
                num += (int)(num6 * 5);
            }
            num6 = (ushort)(-1 << (int)num2);
            this.DAT_1138 = this.DAT_1138.next;
            dat_.aimpIndex = num;
            dat_.DAT_10 = (byte)num5;
            dat_.DAT_11 = (byte)num2;
            dat_.DAT_0C = (ushort)(param2 & (uint)num6);
            dat_.DAT_0E = (ushort)(param3 & (uint)num6);
        }
        return dat_;
    }

    private global::Navigation FUN_35CBC(global::Navigation param1)
    {
        global::Navigation navigation = null;
        ushort num = this.levelManager.aimpData[param1.aimpIndex + (int)param1.DAT_10 + 1];
        ushort num2 = 3840;
        if (num != 0)
        {
            num2 = num;
        }
        int num3 = (int)param1.DAT_0E + (1 << (int)param1.DAT_11);
        if ((num2 & 256) != 0)
        {
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)(param1.DAT_0C - 1), (uint)param1.DAT_0E); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)(param1.DAT_0C - 1), (uint)navigation2.DAT_0E + (1u << (int)navigation2.DAT_11)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                if (num3 <= (int)navigation2.DAT_0E + (1 << (int)navigation2.DAT_11))
                {
                    break;
                }
            }
        }
        if ((num2 & 512) != 0)
        {
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C + (1u << (int)param1.DAT_11), (uint)param1.DAT_0E); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)navigation2.DAT_0C, (uint)navigation2.DAT_0E + (1u << (int)navigation2.DAT_11)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                if (num3 <= (int)navigation2.DAT_0E + (1 << (int)navigation2.DAT_11))
                {
                    break;
                }
            }
        }
        num3 = (int)param1.DAT_0C + (1 << (int)param1.DAT_11);
        if ((num2 & 2048) != 0)
        {
            int num4;
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C, (uint)(param1.DAT_0E - 1)); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)num4, (uint)(param1.DAT_0E - 1)))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                num4 = (int)navigation2.DAT_0C + (1 << (int)navigation2.DAT_11);
                if (num3 <= num4)
                {
                    break;
                }
            }
        }
        if ((num2 & 1024) != 0)
        {
            int num4;
            for (global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)param1.DAT_0C, (uint)param1.DAT_0E + (1u << (int)param1.DAT_11)); navigation2 != null; navigation2 = this.FUN_35BAC(navigation2, (uint)num4, (uint)navigation2.DAT_0E))
            {
                if (this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
                {
                    navigation2.next = navigation;
                    navigation = navigation2;
                }
                num4 = (int)navigation2.DAT_0C + (1 << (int)navigation2.DAT_11);
                if (num3 <= num4)
                {
                    break;
                }
            }
        }
        if ((num2 & 4096) != 0)
        {
            num3 = param1.aimpIndex + 5 + (int)param1.DAT_10;
            global::Navigation navigation2 = this.FUN_35BAC(param1, (uint)(param1.DAT_0C + (ushort)((sbyte)this.levelManager.aimpData[num3 + 1])), (uint)(param1.DAT_0E + (ushort)((sbyte)(this.levelManager.aimpData[num3 + 1] >> 8))));
            if (navigation2 != null && this.levelManager.aimpData[navigation2.aimpIndex + (int)navigation2.DAT_10 + 1] != 0)
            {
                navigation2.next = navigation;
                navigation = navigation2;
            }
        }
        return navigation;
    }

    public int FUN_35FF0(global::Navigation param1, short param2, short param3)
    {
        int num = (1 << (int)param1.DAT_11) / 2;
        int num2 = (int)param1.DAT_0C + num - (int)param2;
        num = (int)param1.DAT_0E + num - (int)param3;
        return (int)Utilities.SquareRoot((long)(num2 * num2 + num * num)) << 7;
    }

    public short[] FUN_36060(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        return this.FUN_36084(param1, param2, param3, param4);
    }

    private short[] FUN_36084(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        int num = (int)Utilities.FUN_14A54();
        int num2 = num;
        int num3 = 1022;
        this.DAT_1138 = this.levelManager.ainav;
        global::Navigation navigation = this.levelManager.ainav;
        global::Navigation navigation2;
        do
        {
            navigation2 = new global::Navigation();
            navigation.next = navigation2;
            num3--;
            navigation = navigation2;
        }
        while (-1 < num3);
        navigation2.next = null;
        global::Navigation navigation3 = this.FUN_35B00(param2.x >> 16, param2.z >> 16);
        navigation = navigation3;
        if (this.levelManager.aimpData[navigation3.aimpIndex + (int)navigation3.DAT_10 + 1] == 0)
        {
            navigation = this.FUN_35CBC(navigation3);
            if (navigation == null)
            {
                return null;
            }
            navigation3.next = this.DAT_1138;
            this.DAT_1138 = navigation3;
        }
        global::Navigation navigation4 = this.FUN_35B00(param1.x >> 16, param1.z >> 16);
        navigation3 = navigation4;
        if (this.levelManager.aimpData[navigation4.aimpIndex + (int)navigation4.DAT_10 + 1] == 0)
        {
            navigation3 = this.FUN_35CBC(navigation4);
            if (navigation3 == null)
            {
                return null;
            }
            navigation4.next = this.DAT_1138;
            this.DAT_1138 = navigation4;
        }
        navigation3.DAT_18 = 0;
        int num4 = this.FUN_35FF0(navigation2, (short)navigation.DAT_0C, (short)navigation.DAT_0E);
        navigation3.DAT_14 = num4;
        navigation3.next = null;
        navigation3.DAT_04 = null;
        navigation2 = null;
        while (navigation3 != null)
        {
            bool flag;
            if ((param4 & 2u) == 0u)
            {
                num3 = (int)Utilities.FUN_14A54();
                num2 += UnityEngine.Random.Range(this.aiMin, this.aiMax);
                flag = (num2 > 1000);
                flag = false;
            }
            else
            {
                param3 -= 1u;
                flag = (param3 == 0u);
            }
            if (flag && (param4 & 1u) != 0u)
            {
                break;
            }
            navigation4 = navigation3.next;
            if (flag || (navigation3.aimpIndex == navigation.aimpIndex && navigation3.DAT_10 == navigation.DAT_10))
            {
                num = navigation3.aimpIndex + (int)navigation3.DAT_10;
                ushort[] aimpData = this.levelManager.aimpData;
                int num5 = num + 1;
                aimpData[num5] &= 40959;
                global::Navigation dat_ = navigation3.DAT_04;
                num3 = 0;
                while (dat_ != null)
                {
                    dat_ = dat_.DAT_04;
                    num3++;
                }
                num3 -= ((num3 != 0) ? 1 : 0);
                short[] array = new short[(num3 + 2) * 2];
                int num6 = num3 * 2;
                array[num6 + 3] = 0;
                array[num6 + 2] = 0;
                array[num6] = (short)(param2.x >> 16);
                num3--;
                array[num6 + 1] = (short)(param2.z >> 16);
                if (num3 != -1)
                {
                    int num7 = num3 * 2;
                    do
                    {
                        navigation3 = navigation3.DAT_04;
                        array[num7] = (short)((int)navigation3.DAT_0C + (1 << (int)navigation3.DAT_11) / 2);
                        num3--;
                        array[num7 + 1] = (short)((int)navigation3.DAT_0E + (1 << (int)navigation3.DAT_11) / 2);
                        num7 -= 2;
                    }
                    while (num3 != -1);
                }
                this.FUN_35AC0(navigation4);
                this.FUN_35AC0(navigation2);
                return array;
            }
            global::Navigation navigation5 = this.FUN_35CBC(navigation3);
            for (global::Navigation navigation6 = navigation5; navigation6 != null; navigation6 = navigation5)
            {
                navigation5 = navigation6.next;
                navigation6.DAT_18 = navigation3.DAT_18 + ((int)((byte)this.levelManager.aimpData[navigation6.aimpIndex + (int)navigation6.DAT_10 + 1]) << (int)navigation6.DAT_11);
                num3 = navigation6.aimpIndex + (int)navigation6.DAT_10;
                ushort num8 = this.levelManager.aimpData[num3 + 1];
                global::Navigation navigation7 = null;
                if ((num8 & 16384) != 0)
                {
                    global::Navigation navigation8 = navigation4;
                    if ((num8 & 8192) != 0)
                    {
                        navigation8 = navigation2;
                    }
                    if (navigation6.aimpIndex != navigation8.aimpIndex || navigation6.DAT_10 != navigation8.DAT_10)
                    {
                        do
                        {
                            navigation7 = navigation8;
                            navigation8 = navigation7.next;
                        }
                        while (navigation6.aimpIndex != navigation8.aimpIndex || navigation6.DAT_10 != navigation8.DAT_10);
                    }
                    navigation6.next = this.DAT_1138;
                    int dat_2 = navigation8.DAT_18;
                    num3 = navigation6.DAT_18;
                    this.DAT_1138 = navigation6;
                    if (0 < dat_2 - num3)
                    {
                        if (navigation7 == null)
                        {
                            if ((num8 & 8192) == 0)
                            {
                                navigation4 = navigation8.next;
                            }
                            else
                            {
                                navigation2 = navigation8.next;
                            }
                        }
                        else
                        {
                            navigation7.next = navigation8.next;
                        }
                        this.levelManager.aimpData[navigation8.aimpIndex + (int)navigation8.DAT_10 + 1] = ((ushort)(num8 & 57343));
                        num4 = navigation6.DAT_18;
                        navigation8.DAT_04 = navigation3;
                        navigation8.DAT_18 = num4;
                        navigation8.DAT_14 -= dat_2 - num3;
                        navigation4 = this.FUN_35A6C(navigation4, navigation8);
                    }
                }
                else
                {
                    this.levelManager.aimpData[num3 + 1] = ((ushort)(num8 | 16384));
                    num3 = this.FUN_35FF0(navigation6, (short)navigation.DAT_0C, (short)navigation.DAT_0E);
                    navigation6.DAT_04 = navigation3;
                    navigation6.DAT_14 = navigation6.DAT_18 + num3;
                    navigation4 = this.FUN_35A6C(navigation4, navigation6);
                }
            }
            navigation3.next = navigation2;
            num3 = navigation3.aimpIndex + (int)navigation3.DAT_10;
            ushort[] aimpData2 = this.levelManager.aimpData;
            int num9 = num3 + 1;
            aimpData2[num9] |= 24576;
            navigation2 = navigation3;
            navigation3 = navigation4;
        }
        this.FUN_35AC0(navigation3);
        this.FUN_35AC0(navigation2);
        return null;
    }

    public bool FUN_36558(int param1, int param2)
    {
        return 99 < this.vehicleStats[param2].accel && 99 < this.vehicleStats[param2].speed && 99 < this.vehicleStats[param2].armor && 99 < this.vehicleStats[param2].avoidance;
    }

    private void FUN_380D8(Vector3Int param1, int param2, VigMesh param3, VigTransform param4, int param5)
    {
        Vector3Int vector3Int = Utilities.FUN_24148(param4, param1);
        vector3Int.x = vector3Int.x * param5 >> 8;
        vector3Int.y = vector3Int.y * param5 >> 8;
        vector3Int.z = vector3Int.z * param5 >> 8;
        if ((vector3Int.x - param2) * 256 < vector3Int.z * 160 && vector3Int.z * -160 < (vector3Int.x + param2) * 256 && (vector3Int.y - param2) * 256 < vector3Int.z * 120 && vector3Int.z * -120 < (vector3Int.y + param2) * 256)
        {
            int num = (param5 & 511) * 32;
            int num2 = (int)GameManager.DAT_65C90[num / 2 + 1] * param2;
            Matrix3x3 matrix3x = default(Matrix3x3);
            matrix3x.V00 = (short)(num2 >> 16);
            if (num2 < 0)
            {
                matrix3x.V00 = (short)(num2 + 1048575 >> 16);
            }
            matrix3x.V00 = (short)(matrix3x.V00 >> 4);
            param2 = (int)GameManager.DAT_65C90[num / 2] * param2;
            if (param2 < 0)
            {
                param2 += 1048575;
            }
            matrix3x.V10 = (short)(param2 >> 20);
            matrix3x.V01 = (short)-matrix3x.V10;
            matrix3x.V22 = 4096;
            matrix3x.V21 = 0;
            matrix3x.V20 = 0;
            matrix3x.V12 = 0;
            matrix3x.V02 = 0;
            matrix3x.V11 = matrix3x.V00;
            VigTransform param6 = new VigTransform
            {
                rotation = matrix3x,
                position = param1
            };
            param3.FUN_21F70(param6);
            Vector3 vector = new Vector3((float)param6.position.x / (float)this.translateFactor, (float)(-(float)param6.position.y) / (float)this.translateFactor, (float)param6.position.z / (float)this.translateFactor);
            Vector3 eulerAngles = Quaternion.LookRotation(vector - LevelManager.instance.defaultCamera.transform.position, Vector3.up).eulerAngles;
            Quaternion q = Quaternion.Euler(eulerAngles.x, eulerAngles.y, (float)param5 * 180f / 256f);
            Vector3 scale = param6.rotation.Scale;
            Matrix4x4 matrix = Matrix4x4.TRS(Vector3.Lerp(LevelManager.instance.defaultCamera.transform.position, vector, (float)param5 / 256f), q, scale);
            Graphics.DrawMesh(param3.GetMesh(), matrix, this.targetHUD, 8);
        }
    }

    public void FUN_3827C(Vehicle param1, VigTransform param2)
    {
        Vehicle vehicle = (Vehicle)param1.target;
        if (vehicle != null)
        {
            VigObject vigObject = param1.weapons[(int)param1.weaponSlot];
            Vector3Int param3 = vehicle.screen;
            short dat_C;
            int dat_;
            VigMesh param4;
            if (vehicle.jammer == 0)
            {
                int num = 0;
                param3 = vehicle.vTransform.position;
                if (vigObject != null)
                {
                    num = (((vigObject.flags & 16384u) != 0u) ? 1 : 0);
                }
                dat_C = param1.DAT_C6;
                dat_ = vehicle.DAT_58;
                param4 = this.DAT_1150[num];
            }
            else
            {
                dat_C = param1.DAT_C6;
                dat_ = vehicle.DAT_58;
                param4 = this.DAT_1150[2];
            }
            this.FUN_380D8(param3, dat_, param4, param2, (int)dat_C);
        }
        if (param1.jammer != 0 || (this.DAT_40 & 2097152) != 0 || this.enableReticle)
        {
            this.FUN_380D8(param1.screen, param1.DAT_58, this.DAT_1150[3], param2, 256);
        }
    }

    public uint FUN_4A970(uint param1, uint param2)
    {
        int num;
        if (this.gameMode == _GAME_MODE.Versus2)
        {
            num = 2;
        }
        else
        {
            num = (int)this.DAT_C6E;
        }
        int num2 = ~num + 3;
        while (num2 != -1)
        {
            do
            {
                param2 = GameManager.FUN_2AC5C() * 18u >> 15;
            }
            while (GameManager.DAT_63FA4[(int)param2] < 0 || ((ulong)param1 & (ulong)(262144L << (int)(param2 & 31u & 31u))) == 0UL);
            if (param2 == 13u)
            {
                return 13u;
            }
            num2--;
            if (4294967295u < param1)
            {
                return param2;
            }
        }
        return param2;
    }

    public VigObject FUN_4AB18(uint param1, VigObject param2)
    {
        VigObject vigObject;
        if (param2 == null)
        {
            vigObject = null;
        }
        else
        {
            vigObject = null;
            if ((param1 & param2.flags) != 0u)
            {
                int num = (int)this.FUN_4A970(param1 & param2.flags, 0u);
                if (num == 3)
                {
                    this.DAT_101C++;
                }
                bool flag = false;
                if (6 < num && param2.flags < 0u)
                {
                    flag = ((param2.flags & 2113929216u) > 0u);
                }
                param2.tags = ((sbyte)(flag ? 1 : 0));
                short dat_1A;
                if (flag)
                {
                    dat_1A = 5;
                }
                else
                {
                    dat_1A = GameManager.DAT_63FA4[num];
                }
                param2.DAT_1A = dat_1A;
                if (this.gameMode >= _GAME_MODE.Versus2)
                {
                    ClientSend.SpawnPickup(param2.id, param2.tags, GameManager.DAT_63FA4[num], param2.parent != null);
                }
                vigObject = param2.FUN_31DDC();
                vigObject.flags |= 16777216u;
                vigObject.DAT_1A = GameManager.DAT_63FA4[num];
            }
        }
        return vigObject;
    }

    public VigObject FUN_4AC1C(uint param1, VigObject param2)
    {
        VigObject vigObject;
        if (this.gameMode < _GAME_MODE.Versus2 || DiscordController.IsOwner())
        {
            vigObject = this.FUN_4AB18(param1, param2);
            if (vigObject != null)
            {
                param2.flags |= 32768u;
                vigObject.FUN_3066C();
            }
        }
        else
        {
            vigObject = null;
        }
        return vigObject;
    }

    public VigObject FUN_4AC6C(uint param1, VigObject param2)
    {
        int num = 0;
        VigObject vigObject = param2;
        if (param2 != null)
        {
            do
            {
                vigObject = vigObject.child;
                num++;
            }
            while (vigObject != null);
        }
        int num2 = (int)GameManager.FUN_2AC5C();
        num2 = num2 * num >> 15;
        VigObject vigObject2 = param2;
        for (num2--; num2 != -1; num2--)
        {
            vigObject2 = vigObject2.child;
        }
        vigObject = this.FUN_4AB18(param1, vigObject2);
        if (vigObject != null)
        {
            param2.flags |= 32768u;
            vigObject.FUN_3066C();
        }
        return vigObject;
    }

    public VigCamera FUN_4B914(Vehicle param1, ushort param2, Camera cam)
    {
        GameObject gameObject = new GameObject();
        VigCamera vigCamera = gameObject.AddComponent<VigCamera>();
        cam.transform.parent = gameObject.transform;
        vigCamera.target = param1;
        vigCamera.maxHalfHealth = param2;
        vigCamera.flags |= 16777216u;
        vigCamera.FUN_4B898();
        return vigCamera;
    }

    public void FUN_4C4BC(VigShadow param1)
    {
        if (param1 != null)
        {
            this.FUN_1FEB8(param1.vMesh);
            UnityEngine.Object.Destroy(param1.gameObject);
        }
    }

    public VigObject FUN_4EEB0(List<VigObject> param1, XOBF_DB param2, ushort param3, Type param4, int param5)
    {
        int num = 0;
        VigObject vigObject = null;
        VigObject vigObject2 = vigObject;
        if (0 < param5)
        {
            do
            {
                vigObject2 = param2.ini.FUN_2C17C(param3, param4, 8u);
                vigObject2.vTransform = GameManager.FUN_2A39C();
                vigObject2.child = vigObject;
                num++;
                vigObject2.LDAT_78 = param1;
                vigObject = vigObject2;
            }
            while (num < param5);
        }
        param1[0] = vigObject2;
        return vigObject2;
    }

    public VigObject FUN_4EF80(List<VigObject> param1)
    {
        VigObject vigObject = param1[0];
        if (vigObject != null)
        {
            param1[0] = vigObject.child;
            vigObject.child = null;
            vigObject.FUN_2C05C();
        }
        return vigObject;
    }

    public void FUN_50B38()
    {
        List<Junction> roadList = this.levelManager.roadList;
        for (int i = 0; i < roadList.Count; i++)
        {
            if (this.FUN_2E22C_2(roadList[i].pos, roadList[i].DAT_18))
            {
                Vector3Int param = Utilities.FUN_24148_2(this.DAT_F00, roadList[i].pos);
                if (param.z < 2097152)
                {
                    roadList[i].vTransform.position = roadList[i].pos;
                    roadList[i].FUN_4F804(param);
                }
                else
                {
                    roadList[i].ClearRoadData();
                }
            }
            else
            {
                roadList[i].ClearRoadData();
            }
        }
        if (0 < this.levelManager.DAT_1184)
        {
            for (int j = 0; j < this.levelManager.DAT_1184; j++)
            {
                if (this.levelManager.juncList[j].DAT_18 != null)
                {
                    this.FUN_507DC(this.levelManager.juncList[j]);
                }
            }
        }
    }

    public short[] FUN_51ED4(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
    {
        if (this.DAT_D0C != 0)
        {
            param3 >>= 11;
            param4 |= 2u;
        }
        return this.FUN_36060(param1, param2, param3, param4);
    }

    private void Awake()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = this;
        }
        this.DAT_08 = new ushort[,]
        {
            {
                0,
                0,
                0,
                801,
                8448,
                8515
            },
            {
                0,
                0,
                0,
                801,
                8448,
                8448
            }
        };
        this.gravityFactor = 11520;
        this.DAT_898 = byte.MaxValue;
        this.DAT_36 = true;
        this.DAT_E1C = 8191;
        this.vehicles = new byte[20];
        this.vehicles[2] = byte.MaxValue;
        this.vehicles[3] = byte.MaxValue;
        this.vehicles[4] = byte.MaxValue;
        this.vehicles[5] = byte.MaxValue;
        this.vehicles[6] = byte.MaxValue;
        this.vehicles[7] = byte.MaxValue;
        this.playerObjects = new Vehicle[2];
        this.cameraObjects = new VigCamera[2];

        this.vehicleStats = new VehicleStats[18];
        this.DAT_1030 = new sbyte[20];
        this.DAT_1068 = new List<VigTuple>();
        this.DAT_1078 = new List<VigTuple>();
        this.DAT_1088 = new List<VigTuple>();
        this.DAT_1088_tmp = new List<VigTuple>();
        this.DAT_1098 = new List<VigTuple>();
        this.DAT_10A8 = new List<VigTuple>();
        this.DAT_10C8 = new List<VigTuple>();
        this.DAT_10D8 = new List<VigTuple2>();
        this.DAT_1110 = new List<VigTuple>();
        this.DAT_1110_tmp = new List<VigTuple>();
        this.DAT_1150 = new VigMesh[4];
        this.worldObjs = new List<VigTuple>();
        this.worldObjs_tmp = new List<VigTuple>();
        this.interObjs = new List<VigTuple>();
        GameManager.hit = new HitDetection(new byte[0]);
        this.networkMembers = new Dictionary<long, Vehicle>();
        this.networkIds = new Dictionary<long, short>();
        this.networkObjs = new List<VigObject>();
        this.networkEnemies = new List<Vehicle>();
        this.enemiesDictionary = new Dictionary<short, Vehicle>();
        this.noHUD = true;
        this.DAT_D18 = new byte[2];
        this.DAT_D19 = new byte[2];
        this.DAT_D1A = new byte[2];
        this.DAT_D1B = new byte[2];
        this.DAT_D28 = new byte[2, 8];
        this.DAT_C80 = new sbyte[2];
        this.DAT_CF0 = new ushort[2];
        this.DAT_CF4 = new byte[2, 2];
        this.DAT_CFC = new byte[4];
        this.DAT_1128 = new sbyte[6];
        for (int i = 0; i < 24; i++)
        {
            GameManager.voices[i] = base.gameObject.AddComponent<AudioSource>();
        }
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (inDebug) return;
        if (Input.GetButton("Exit"))
        {
            LoadDebug();
            FUN_3827C(playerObjects[0], DAT_F00);
        };
        if (Input.GetButton("Reset"))
        {
            LoadReboot();

        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
        {
            if (this.gameMode >= _GAME_MODE.Versus2)
            {
                DiscordController.instance.DisconnectNetwork2();
            }
            while (DiscordController.instance.pendingCallbacks)
            {
            	DiscordController.instance.discord.RunCallbacks();
            }
            this.LoadDebug();
        }
        this.FUN_3827C(this.playerObjects[0], this.DAT_F00);
        if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
        {
            this.paused = !this.paused;
            if (this.gameMode >= _GAME_MODE.Versus2)
            {
                ClientSend.Pause();
            }
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.enableReticle = !this.enableReticle;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Return))
        {
            ScreenCapture.CaptureScreenshot("screenshot.png");
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Delete))
        {
            this.noAI = !this.noAI;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Insert))
        {
            this.noPhysics = !this.noPhysics;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.End))
        {
            this.noHUD = !this.noHUD;
            UIManager.instance.hudRect.gameObject.SetActive(this.noHUD);
            UIManager.instance.feedbackRect.gameObject.SetActive(this.noHUD);
        }
    }
    private void LoadReboot()
    {
        totalSpawns = DAT_1030[0] + DAT_1030[1] + DAT_1030[2] + DAT_1030[3];
        DontDestroyOnLoad(this.gameObject);
        print(this);
        SceneManager.LoadScene(map, LoadSceneMode.Single);
        print("Reboot");
    }
    private void FixedUpdate()
    {
        if (this.inDebug || this.inMenu)
        {
            return;
        }
        Color32 color = UIManager.instance.flash.color;
        if (color.r != 0 || color.g != 0 || color.b != 0 || color.a != 0)
        {
            UIManager.instance.flash.color = new Color32(0, 0, 0, 0);
        }
        if (this.gameMode >= _GAME_MODE.Versus2)
        {
            for (int i = 0; i < this.networkMembers.Count; i++)
            {
                if (this.networkMembers.ContainsValue(null))
                {
                    return;
                }
            }
        }
        if (!this.paused)
        {
            uint num = 1u;
            int num2 = 0;
            while ((long)num2 < (long)((ulong)num))
            {
                this.DAT_28++;
                this.timer = (ushort)this.DAT_28;
                uint param = 0u;
                if ((long)num2 == (long)((ulong)(num - 1u)))
                {
                    param = num;
                }
                this.FUN_313C8((int)param);
                this.FUN_31440((uint)this.DAT_28);
                this.FUN_31728();
                for (int j = 0; j < this.worldObjs_tmp.Count; j++)
                {
                    this.worldObjs.Remove(this.worldObjs_tmp[j]);
                }
                this.worldObjs_tmp.Clear();
                if (this.playerObjects[0] != null && (InputManager.controllers[0].DAT_A & 128) != 0)
                {
                    this.playerObjects[0].view = (_CAR_VIEW)3 - (int)this.playerObjects[0].view;
                }
                num2++;
            }
        }
        else
        {
            this.cameraObjects[0].vTransform.rotation = Utilities.RotMatrixYXZ_gte(this.cameraObjects[0].vr);
        }
        this.FUN_31360((ushort)(this.DAT_28 & 65535));
        this.DAT_24 = 1 - this.DAT_24;
        if (this.screenMode == _SCREEN_MODE.Horizontal)
        {
            int param2 = 320;
            int param3 = 160;
            int param4 = 120;
            int param5 = 60;
            this.FUN_2DF30(param2, param4, param3, param5);
        }
        else if (this.screenMode < _SCREEN_MODE.Vertical)
        {
            int param2 = 512;
            if (this.screenMode == _SCREEN_MODE.Whole)
            {
                int param4 = 240;
                int param3 = 160;
                int param5 = 120;
                this.FUN_2DF30(param2, param4, param3, param5);
            }
        }
        else
        {
            int param2;
            if (this.screenMode == _SCREEN_MODE.Vertical)
            {
                param2 = 160;
                int param4 = 240;
                int param3 = 80;
                int param5 = 120;
                this.FUN_2DF30(param2, param4, param3, param5);
            }
            param2 = 160;
            if (this.screenMode == _SCREEN_MODE.Unknown)
            {
                int param3 = 80;
                int param4 = 120;
                int param5 = 60;
                this.FUN_2DF30(param2, param4, param3, param5);
            }
        }
        if (this.screenMode == _SCREEN_MODE.Whole)
        {
            Vehicle vehicle;
            VigObject vigObject;
            if (this.gameMode < _GAME_MODE.Versus || this.playerObjects[0].maxHalfHealth != 0 || this.gameMode >= _GAME_MODE.Versus2)
            {
                vehicle = this.playerObjects[0];
                if (this.playerObjects[1] != null)
                {
                    uint flags = this.playerObjects[1].flags;
                    vigObject = this.playerObjects[1];
                    if ((flags & 33554432u) == 0u)
                    {
                        vigObject.flags = (flags & 4294967293u);
                    }
                }
            }
            else
            {
                uint flags = this.playerObjects[0].flags;
                vigObject = this.playerObjects[0];
                vehicle = this.playerObjects[1];
                if ((flags & 33554432u) == 0u)
                {
                    vigObject.flags = (flags & 4294967293u);
                }
            }
            short fieldOfView;
            if (vehicle.view == _CAR_VIEW.Close)
            {
                if ((vehicle.flags & 33554432u) != 0u)
                {
                    VigCamera vCamera = vehicle.vCamera;
                    fieldOfView = vCamera.fieldOfView;
                    vigObject = vCamera;
                }
                else
                {
                    vigObject = vehicle.closeViewer;
                    vehicle.flags |= 2u;
                    fieldOfView = vehicle.vCamera.fieldOfView;
                }
            }
            else
            {
                if ((vehicle.flags & 33554432u) == 0u)
                {
                    vehicle.flags &= 4294967293u;
                }
                VigCamera vCamera2 = vehicle.vCamera;
                fieldOfView = vCamera2.fieldOfView;
                vigObject = vCamera2;
            }
            LevelManager.instance.defaultCamera.transform.SetParent(vigObject.transform, false);
            this.FUN_2D278(vigObject, (int)fieldOfView);
            this.terrain.DAT_BDFF0[0] = this.DAT_F00;
            this.FUN_31678();
            this.atStart = true;
            if (this.DAT_1084 < 0)
            {
                this.DAT_1084 = 0;
            }
            if (vehicle.view != _CAR_VIEW.NoHUD)
            {
                UIManager.instance.UpdateHUD(this.playerObjects[0], this.DAT_28);
            }
            UIManager.instance.RefreshFlares(this.DAT_28);
            UIManager.instance.RefreshCameras();
            UIManager.instance.RefreshDestroyed(this.DAT_CC4);
        }
        for (int k = 0; k < this.DAT_1088_tmp.Count; k++)
        {
            this.DAT_1088.Remove(this.DAT_1088_tmp[k]);
        }
        this.DAT_1088_tmp.Clear();
        for (int l = 0; l < this.DAT_1110_tmp.Count; l++)
        {
            this.DAT_1110.Remove(this.DAT_1110_tmp[l]);
        }
        this.DAT_1110_tmp.Clear();
        if (this.gameMode >= _GAME_MODE.Versus2)
        {
            ClientSend.Transform(ref this.playerObjects[0].vTransform);
            ClientSend.Physics(ref this.playerObjects[0].physics1, ref this.playerObjects[0].physics2);
            ClientSend.Control(this.playerObjects[0]);
            ClientSend.Status(this.playerObjects[0]);
            ClientSend.RandomNumber(GameManager.DAT_63A64, GameManager.DAT_63A68);
            if (this.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner())
            {
                for (int m = 0; m < this.networkEnemies.Count; m++)
                {
                    ClientSend.TransformAI(this.networkEnemies[m].id, ref this.networkEnemies[m].vTransform);
                    ClientSend.PhysicsAI(this.networkEnemies[m].id, ref this.networkEnemies[m].physics1, ref this.networkEnemies[m].physics2);
                    ClientSend.ControlAI(this.networkEnemies[m]);
                    ClientSend.StatusAI(this.networkEnemies[m]);
                }
            }
        }
    }

    private void FUN_1C158()
    {
        if (this.gameMode < _GAME_MODE.Coop || this.gameMode >= _GAME_MODE.Versus2)
        {
            this.DAT_DB4 = 80;
            this.DAT_DB6 = 40;
            this.DAT_DB8 = 20;
        }
        else
        {
            this.DAT_DB4 = 48;
            this.DAT_DB6 = 24;
            this.DAT_DB8 = 12;
        }
        Utilities.SetRotMatrix(this.DAT_F28.rotation);
        Vector3Int item = default(Vector3Int);
        item.x = this.DAT_F28.position.x;
        if (this.DAT_F28.position.x < 0)
        {
            item.x = this.DAT_F28.position.x + 255;
        }
        item.x >>= 8;
        item.y = this.DAT_F28.position.y;
        if (this.DAT_F28.position.y < 0)
        {
            item.y = this.DAT_F28.position.y + 255;
        }
        item.y >>= 8;
        item.z = this.DAT_F28.position.z;
        if (this.DAT_F28.position.z < 0)
        {
            item.z = this.DAT_F28.position.z + 255;
        }
        item.z >>= 8;
        this.terrain.UpdatePosition((Vector3)this.DAT_F28.position / (float)this.translateFactor);
        GameManager.DAT_1f800084 = new Vector3Int(-item.x, -item.y, -item.z);
        Coprocessor.translationVector._trx = item.x;
        Coprocessor.translationVector._try = item.y;
        Coprocessor.translationVector._trz = item.z;
        int num = (int)this.DAT_DB4 * (this.DAT_EDC / 2) * 256 / this.DAT_ED8;
        uint num2 = 0u;
        int num3 = (int)this.DAT_DB4 * (this.DAT_F20 / 2) * 256 / this.DAT_ED8;
        uint num4 = 0u;
        Vector3Int v = default(Vector3Int);
        List<Vector3Int> list = new List<Vector3Int>();
        do
        {
            v.x = num;
            if (num4 == 0u)
            {
                v.x = -v.x;
            }
            v.y = num3;
            if ((num2 & 2u) == 0u)
            {
                v.y = -v.y;
            }
            num2 += 1u;
            v.z = (int)this.DAT_DB4 << 8;
            list.Add(Utilities.FUN_23F58(v));
            num4 = (num2 & 1u);
        }
        while (num2 < 4u);
        int i = 0;
        num = 0;
        List<Vector2Int> list2 = new List<Vector2Int>();
        list.Add(item);
        do
        {
            if (list[num].y + 8 < 12289)
            {
                list2.Add(new Vector2Int(list[num].x, list[num].z));
                i++;
            }
            num++;
        }
        while (num < 5);
        num = 0;
        int index3;
        do
        {
            num4 = (uint)GameManager.DAT_639A0[num * 2];
            num2 = (uint)GameManager.DAT_639A0[num * 2 + 1];
            int index = (int)num4;
            int index2 = (int)num2;
            if (list[index2].y < -8)
            {
                if (-9 < list[index].y)
                {
                    num3 = list[index].x;
                    list2.Add(new Vector2Int(num3 + (list[index2].x - num3) * (-8 - list[index].y) / (list[index2].y - list[index].y), list[index].z + (list[index2].z - list[index].z) * (-8 - list[index].y) / (list[index2].y - list[index].y)));
                    i++;
                }
            }
            else if (-9 >= list[index].y)
            {
                num3 = list[index].x;
                list2.Add(new Vector2Int(num3 + (list[index2].x - num3) * (-8 - list[index].y) / (list[index2].y - list[index].y), list[index].z + (list[index2].z - list[index].z) * (-8 - list[index].y) / (list[index2].y - list[index].y)));
                i++;
            }
            if (list[index2].y < 12281)
            {
                if (list[index].y >= 12281)
                {
                    num3 = list[index].x;
                    list2.Add(new Vector2Int(num3 + (list[index2].x - num3) * (12280 - list[index].y) / (list[index2].y - list[index].y), list[index].z + (list[index2].z - list[index].z) * (12280 - list[index].y) / (list[index2].y - list[index].y)));
                    i++;
                }
            }
            else if (list[index].y < 12281)
            {
                num3 = list[index].x;
                list2.Add(new Vector2Int(num3 + (list[index2].x - num3) * (12280 - list[index].y) / (list[index2].y - list[index].y), list[index].z + (list[index2].z - list[index].z) * (12280 - list[index].y) / (list[index2].y - list[index].y)));
                i++;
            }
            num++;
            index3 = 0;
        }
        while (7 >= num);
        if (i != 0)
        {
            num = int.MaxValue;
            int num5 = int.MaxValue;
            num3 = 0;
            int num6;
            if (0 < i)
            {
                do
                {
                    num6 = list2[num3].y;
                    if (num6 < num || (num6 == num && list2[num3].x < num5))
                    {
                        num5 = list2[num3].x;
                        num = num6;
                        index3 = num3;
                    }
                    num3++;
                }
                while (num3 < i);
            }
            list2[index3] = new Vector2Int(list2[0].x, list2[0].y);
            list2[0] = new Vector2Int(num5, num);
            num3 = i - 1;
            num6 = 1;
            bool flag;
            do
            {
                flag = false;
                int num7 = num6;
                int num8 = 0;
                if (num6 < num3)
                {
                    do
                    {
                        int index2 = num6;
                        int num9 = num6 + 1;
                        int num10 = num9;
                        int x = list2[index2].x;
                        int y = list2[num10].y;
                        int j = x - num5;
                        int y2 = list2[index2].y;
                        int x2 = list2[num10].x;
                        int num11 = x2 - num5;
                        int num12 = j * (y - num) - (y2 - num) * num11;
                        if (num12 == 0)
                        {
                            i--;
                            num3--;
                            bool flag2;
                            if (y2 == y)
                            {
                                if (j < 0)
                                {
                                    j = -j;
                                }
                                if (num11 < 0)
                                {
                                    num11 = -num11;
                                }
                                flag2 = (num11 < j);
                            }
                            else
                            {
                                flag2 = (y < y2);
                            }
                            for (j = num6 + (flag2 ? 1 : 0); j < i; j = num11)
                            {
                                num11 = j + 1;
                                num9 = list2[num11].y;
                                list2[j] = new Vector2Int(list2[num11].x, num9);
                            }
                            num6--;
                        }
                        else if (num12 < 0)
                        {
                            list2[index2] = new Vector2Int(x2, list2[num10].y);
                            list2[num10] = new Vector2Int(x, y2);
                            if (!flag)
                            {
                                num7 = 1;
                                if (2 < num6)
                                {
                                    num7 = num6 - 1;
                                }
                                flag = true;
                            }
                            num8 = num6;
                        }
                        num6++;
                    }
                    while (num6 < num3);
                }
                num3 = num8;
                num6 = num7;
            }
            while (flag);
            num3 = 0;
            num = 0;
            if (0 < i)
            {
                int num10 = 0;
                do
                {
                    if (1 < num)
                    {
                        do
                        {
                            num6 = num - 1;
                            num5 = list2[num6].x;
                            if ((list2[num6].y - list2[num - 2].y) * (list2[num10].x - num5) <= (num5 - list2[num - 2].x) * (list2[num10].y - list2[num6].y))
                            {
                                break;
                            }
                            num = num6;
                        }
                        while (1 < num6);
                    }
                    num5 = list2[num10].y;
                    list2[num] = new Vector2Int(list2[num10].x, num5);
                    num++;
                    num3++;
                    num10++;
                }
                while (num3 < i);
            }
            Utilities.SetRotMatrix(this.DAT_F00.rotation);
            Utilities.SetRotMatrix3(this.DAT_F00.rotation);
            Coprocessor.translationVector._trx = 0;
            Coprocessor.translationVector._try = 0;
            Coprocessor.translationVector._trz = 0;
            Coprocessor3.translationVector._trx = 0;
            Coprocessor3.translationVector._try = 0;
            Coprocessor3.translationVector._trz = 0;
            Utilities.SetColorMatrix(this.levelManager.DAT_738);
            Utilities.SetColorMatrix3(this.levelManager.DAT_738);
            Utilities.SetLightMatrix(GameManager.DAT_718);
            Utilities.SetLightMatrix3(GameManager.DAT_718);
            Utilities.SetBackColor((int)this.levelManager.DAT_E04.r, (int)this.levelManager.DAT_E04.g, (int)this.levelManager.DAT_E04.b);
            Utilities.SetBackColor3((int)this.levelManager.DAT_E04.r, (int)this.levelManager.DAT_E04.g, (int)this.levelManager.DAT_E04.b);
            Utilities.SetFarColor((int)this.levelManager.DAT_DA4.r, (int)this.levelManager.DAT_DA4.g, (int)this.levelManager.DAT_DA4.b);
            Utilities.SetFarColor3((int)this.levelManager.DAT_DA4.r, (int)this.levelManager.DAT_DA4.g, (int)this.levelManager.DAT_DA4.b);
            GameManager.DAT_1f800080 = 256;
            Utilities.SetFogNearFar((int)this.DAT_DB6 << 8, (int)this.DAT_DB4 << 8, this.DAT_ED8);
            Utilities.SetFogNearFar3((int)this.DAT_DB6 << 8, (int)this.DAT_DB4 << 8, this.DAT_ED8);
            Coprocessor.colorCode.r = this.levelManager.DAT_DDC.r;
            Coprocessor.colorCode.g = this.levelManager.DAT_DDC.g;
            Coprocessor.colorCode.b = this.levelManager.DAT_DDC.b;
            Coprocessor.colorCode.code = this.levelManager.DAT_DDC.a;
            for (i = 0; i < 32; i++)
            {
                Coprocessor.accumulator.ir1 = (short)(i << 7);
                Coprocessor.ExecuteCC(12, true);
                VigTerrain.DAT_BA4F0[i] = new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2);
                GameManager.DAT_1f800000[i] = new Color32(this.terrain.DAT_B9370[i].r, this.terrain.DAT_B9370[i].g, this.terrain.DAT_B9370[i].b, 52);
            }
            GameManager.DAT_1f800094 = (short)((ushort)this.DAT_EDC);
            GameManager.DAT_1f800096 = (short)((ushort)this.DAT_F20);
            GameManager.DAT_1f800098 = (short)(this.DAT_DB6 << 8);
            GameManager.DAT_1f80009a = (short)(this.DAT_DB8 << 8);
            this.nativeArray = new NativeArray<Vector2Int>(list2.Count, Allocator.Persistent, NativeArrayOptions.ClearMemory);
            for (int k = 0; k < this.nativeArray.Length; k++)
            {
                this.nativeArray[k] = list2[k];
            }
            this.terrainJob = new GameManager.TerrainJob
            {
                param1 = this.nativeArray,
                param2 = num
            };
            this.terrainHandle = this.terrainJob.Schedule(default(JobHandle));
        }
    }

    private int FUN_1E354(Vector3Int v3)
    {
        int num = Utilities.FUN_29E84(v3);
        int num2 = num + 2097152;
        if (num2 < 0)
        {
            num2 = num + 2101247;
        }
        return ((int)this.DAT_E1C << 9) / (num2 >> 12);
    }

    private int FUN_1E39C(Vector3Int v3)
    {
        int num = Utilities.FUN_29E84(v3);
        int num2 = num + 2097152;
        if (num2 < 0)
        {
            num2 = num + 2101247;
        }
        int num3 = ((int)this.DAT_E1C << 9) / (num2 >> 12);
        num2 = Utilities.LeadingZeros(num);
        uint num4 = 12u;
        if ((int)((long)num2 - 1L) < 12)
        {
            num4 = (uint)((long)num2 - 1L);
        }
        if (num == 0)
        {
            num = 0;
        }
        else
        {
            num = (v3.x << (int)num4) / (num >> (int)(12u - num4));
        }
        num2 = (4096 - num) * num3;
        if (num2 < 0)
        {
            num2 += 8191;
        }
        num3 = (num + 4096) * num3;
        if (num3 < 0)
        {
            num3 += 8191;
        }
        return num2 >> 13 | num3 >> 13 << 16;
    }

    public uint FUN_1E478(Vector3Int pos)
    {
        Vector3Int v = Utilities.FUN_24148(this.DAT_F00, pos);
        uint result;
        if (this.screenMode == _SCREEN_MODE.Whole)
        {
            if (!this.DAT_83B)
            {
                result = (uint)this.FUN_1E39C(v);
            }
            else
            {
                int num = this.FUN_1E354(v);
                result = (uint)((num * 65536 >> 16) + num * 65536);
            }
        }
        else
        {
            Vector3Int v2 = Utilities.FUN_24148(this.terrain.DAT_BDFF0[0], pos);
            if (!this.DAT_83B)
            {
                int num = this.FUN_1E354(v);
                short num2 = (short)this.FUN_1E354(v2);
                result = (uint)(num << 16 | (int)num2);
            }
            else
            {
                short num2 = (short)this.FUN_1E354(v);
                short num3 = (short)this.FUN_1E354(v2);
                int num = (int)this.DAT_E1C;
                if (num2 + num3 < this.DAT_E1C)
                {
                    num = (int)(num2 + num3);
                }
                result = (uint)(num * 65537);
            }
        }
        return result;
    }

    public int FUN_1E67C(Vector3Int param1)
    {
        int num = Utilities.FUN_29E84(param1);
        int num2;
        if (2097152 - num < 0)
        {
            num2 = 0;
        }
        else
        {
            num2 = (2097152 - num >> 12) * (int)this.DAT_E1C;
            if (num2 < 0)
            {
                num2 += 511;
            }
            num2 = num2 << 7 >> 16;
        }
        return num2;
    }

    public uint FUN_1E6D8(Vector3Int param1)
    {
        int num = Utilities.FUN_29E84(param1);
        uint result = 0u;
        if (num < 2097152)
        {
            int num2 = -num + 2097152;
            if (num2 < 0)
            {
                num2 = -num + 2101247;
            }
            num2 = (num2 >> 12) * (int)this.DAT_E1C;
            if (num2 < 0)
            {
                num2 += 511;
            }
            int num3;
            if (num == 0)
            {
                num3 = 0;
            }
            else
            {
                num3 = (param1.x << 12) / num;
            }
            int num4 = (4096 - num3) * (num2 >> 9);
            if (num2 < 0)
            {
                num2 += 8191;
            }
            result = (uint)(num4 >> 13 | num2 >> 13 << 16);
        }
        return result;
    }

    public uint FUN_1E7A8(Vector3Int param1)
    {
        Vector3Int param2 = Utilities.FUN_24148(this.DAT_F00, param1);
        uint result;
        if (this.screenMode == _SCREEN_MODE.Whole)
        {
            result = this.FUN_1E6D8(param2);
        }
        else
        {
            Vector3Int param3 = Utilities.FUN_24148(this.terrain.DAT_BDFF0[0], param1);
            uint num = (uint)this.FUN_1E67C(param2);
            short num2 = (short)this.FUN_1E67C(param3);
            result = ((uint)num << 16) | (ushort)num2;
        }
        return result;
    }

    public void FUN_15B00(int param1, byte param2, byte param3, byte param4)
    {
        if (this.gameMode != _GAME_MODE.Demo)
        {
            this.DAT_D28[param1, 5] = param2;
            this.DAT_D28[param1, 6] = param3;
            this.DAT_D28[param1, 7] = param4;
        }
    }

    public void FUN_15ADC(int param1, byte param2)
    {
        if (this.gameMode != _GAME_MODE.Demo)
        {
            this.DAT_D28[param1, 4] = param2;
        }
    }

    public void FUN_15AA8(int param1, byte param2, byte param3, byte param4, byte param5)
    {
        if (this.gameMode != _GAME_MODE.Demo)
        {
            this.DAT_D28[param1, 4] = param2;
            this.DAT_D28[param1, 5] = param3;
            this.DAT_D28[param1, 6] = param4;
            this.DAT_D28[param1, 7] = param5;
        }
    }

    public void FUN_2D278(VigObject param1, int param2)
    {
        VigTransform param3 = this.FUN_2CDF4(param1);
        this.FUN_2E0E8(param3, param2);
    }

    public void FUN_2DFF0(VigTransform param1)
    {
        VigTransform vigTransform = default(VigTransform);
        vigTransform.rotation.V00 = (short)this.DAT_ED8;
        vigTransform.rotation.V02 = (short)(-this.DAT_EDC + (int)((uint)(-(uint)this.DAT_EDC) >> 31) >> 1);
        vigTransform.rotation.V10 = (short)-vigTransform.rotation.V00;
        vigTransform.rotation.V12 = vigTransform.rotation.V02;
        vigTransform.rotation.V21 = (short)-vigTransform.rotation.V00;
        vigTransform.rotation.V22 = (short)(-this.DAT_F20 + (int)((uint)(-(uint)this.DAT_F20) >> 31) >> 1);
        Vector3Int n = new Vector3Int((int)vigTransform.rotation.V00, (int)vigTransform.rotation.V01, (int)vigTransform.rotation.V02);
        Vector3Int n2 = new Vector3Int((int)vigTransform.rotation.V10, (int)vigTransform.rotation.V11, (int)vigTransform.rotation.V12);
        Vector3Int n3 = new Vector3Int((int)vigTransform.rotation.V20, (int)vigTransform.rotation.V21, (int)vigTransform.rotation.V22);
        n = Utilities.VectorNormal(n);
        n2 = Utilities.VectorNormal(n2);
        n3 = Utilities.VectorNormal(n3);
        vigTransform.rotation = new Matrix3x3
        {
            V00 = (short)n.x,
            V01 = (short)n.y,
            V02 = (short)n.z,
            V10 = (short)n2.x,
            V11 = (short)n2.y,
            V12 = (short)n2.z,
            V20 = (short)n3.x,
            V21 = (short)n3.y,
            V22 = (short)n3.z
        };
        this.DAT_FD8 = Utilities.FUN_247C4(vigTransform.rotation, param1.rotation);
    }

    public HitDetection FUN_2F798(VigObject obj, HitDetection hit, int multiply = 1)
    {
        VigTransform vigTransform = this.FUN_2CDF4(hit.object2);
        BufferedBinaryReader collider = hit.collider1;
        long position = hit.collider1.Position;
        long position2 = hit.collider2.Position;
        if (collider.ReadUInt16(0) == 1)
        {
            BufferedBinaryReader collider2 = hit.collider2;
            BoundingBox bbox = new BoundingBox
            {
                min = new Vector3Int(collider.ReadInt32(4), collider.ReadInt32(8) * multiply, collider.ReadInt32(12)),
                max = new Vector3Int(collider.ReadInt32(16), collider.ReadInt32(20), collider.ReadInt32(24))
            };
            if (collider2.ReadUInt16(0) == 1)
            {
                int num = 0;
                uint num2 = 2147483648u;
                int num3 = 0;
                do
                {
                    collider2.Seek(4L, SeekOrigin.Current);
                    Radius radius = default(Radius);
                    radius.matrixSV = default(Vector3Int);
                    if (num3 == 0)
                    {
                        radius.matrixSV.x = (((num3 == 3) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.x = ((num3 == 3) ? 1 : 0) << 12;
                    }
                    if (num3 == 1)
                    {
                        radius.matrixSV.y = (((num3 == 4) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.y = ((num3 == 4) ? 1 : 0) << 12;
                    }
                    if (num3 == 2)
                    {
                        radius.matrixSV.z = (((num3 == 5) ? 1 : 0) - 1) * 4096;
                    }
                    else
                    {
                        radius.matrixSV.z = ((num3 == 5) ? 1 : 0) << 12;
                    }
                    radius.contactOffset = collider2.ReadInt32(0);
                    if (num3 < 3)
                    {
                        radius.contactOffset = -radius.contactOffset;
                    }
                    int num4 = Utilities.FUN_2E5B0(bbox, obj.vTransform, radius, vigTransform);
                    if (num2 < (uint)num4)
                    {
                        num = num3;
                        num2 = (uint)num4;
                    }
                    num3++;
                }
                while (num3 < 6);
                uint num5 = (num == 3) ? 1u : 0u;
                if (num == 0)
                {
                    num5 -= 1u;
                }
                Vector3Int v = default(Vector3Int);
                v.x = (int)((short)(num5 << 12));
                if (num == 1)
                {
                    v.y = (((num == 4) ? 1 : 0) - 1) * 4096;
                }
                else
                {
                    v.y = ((num == 4) ? 1 : 0) << 12;
                }
                if (num == 2)
                {
                    v.z = (((num == 5) ? 1 : 0) - 1) * 4096;
                }
                else
                {
                    v.z = ((num == 5) ? 1 : 0) << 12;
                }
                hit.normal1 = Utilities.ApplyMatrixSV(vigTransform.rotation, v);
                hit.normal2 = Utilities.FUN_24238(obj.vTransform.rotation, hit.normal1);
                if (hit.normal2.x < 0)
                {
                    hit.position.x = bbox.max.x;
                }
                else
                {
                    hit.position.x = bbox.min.x;
                }
                if (hit.normal2.y < 0)
                {
                    hit.position.y = bbox.max.y;
                }
                else
                {
                    hit.position.y = bbox.min.y;
                }
                if (hit.normal2.z < 0)
                {
                    hit.position.z = bbox.max.z;
                }
                else
                {
                    hit.position.z = bbox.min.z;
                }
                hit.distance = (int)num2;
            }
            else if (collider2.ReadUInt16(0) == 2)
            {
                uint num2 = 2147483648u;
                int num3 = 0;
                int num = 0;
                if (collider2.ReadUInt16(2) != 0)
                {
                    int num4 = 4;
                    do
                    {
                        Radius radius2 = new Radius
                        {
                            matrixSV = new Vector3Int((int)collider2.ReadInt16(num4), (int)collider2.ReadInt16(num4 + 2), (int)collider2.ReadInt16(num4 + 4)),
                            contactOffset = collider2.ReadInt32(num4 + 8)
                        };
                        int num6 = Utilities.FUN_2E5B0(bbox, obj.vTransform, radius2, vigTransform);
                        if (num2 < (uint)num6)
                        {
                            num = num3;
                            num2 = (uint)num6;
                        }
                        num3++;
                        num4 += 12;
                    }
                    while (num3 < (int)collider2.ReadUInt16(2));
                }
                num = num * 12 + 4;
                Vector3Int v2 = new Vector3Int((int)collider2.ReadInt16(num), (int)collider2.ReadInt16(num + 2), (int)collider2.ReadInt16(num + 4));
                hit.normal1 = Utilities.ApplyMatrixSV(vigTransform.rotation, v2);
                hit.normal2 = Utilities.FUN_24238(obj.vTransform.rotation, hit.normal1);
                if (hit.normal2.x < 0)
                {
                    hit.position.x = bbox.max.x;
                }
                else
                {
                    hit.position.x = bbox.min.x;
                }
                if (hit.normal2.y < 0)
                {
                    hit.position.y = bbox.max.y;
                }
                else
                {
                    hit.position.y = bbox.min.y;
                }
                if (hit.normal2.z < 0)
                {
                    hit.position.z = bbox.max.z;
                }
                else
                {
                    hit.position.z = bbox.min.z;
                }
                hit.distance = (int)num2;
            }
        }
        hit.collider1.Seek(position, SeekOrigin.Begin);
        hit.collider2.Seek(position2, SeekOrigin.Begin);
        return hit;
    }

    public void FUN_2D778(VigObject param1, VigTransform param2)
    {
        do
        {
            if ((param1.flags & 2u) == 0u)
            {
                VigTransform vigTransform = Utilities.CompMatrixLV(param2, param1.vTransform);
                if ((param1.flags & 16u) != 0u)
                {
                    if ((param1.flags & 1024u) == 0u)
                    {
                        vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                    }
                    else
                    {
                        vigTransform.rotation = param1.vTransform.rotation;
                    }
                }
                if (param1.vMesh != null)
                {
                    param1.vMesh.FUN_21F70(vigTransform);
                }
                if (param1.child2 != null)
                {
                    this.FUN_2D778(param1.child2, vigTransform);
                }
            }
            param1 = param1.child;
        }
        while (param1 != null);
    }

    public void FUN_2D9E0(VigObject param1)
    {
        Utilities.ResetMesh(param1);
        if ((param1.flags & 2u) == 0u && this.FUN_2E22C(param1.vTransform.position, param1.DAT_58))
        {
            VigTransform vigTransform = Utilities.CompMatrixLV(this.DAT_F00, param1.vTransform);
            if (vigTransform.position.z < 4194304)
            {
                if ((param1.flags & 16u) != 0u)
                {
                    if ((param1.flags & 1024u) == 0u)
                    {
                        if (param1.vTransform.padding == 0)
                        {
                            vigTransform.rotation = this.DAT_EE0.rotation;
                        }
                        else
                        {
                            vigTransform.rotation = Utilities.FUN_2A4A4(vigTransform.rotation);
                        }
                    }
                    else
                    {
                        vigTransform.rotation = param1.vTransform.rotation;
                    }
                }
                uint num = 64u;
                if ((param1.flags & 8192u) != 0u)
                {
                    int num2 = param1.vTransform.position.x;
                    if (num2 < 0)
                    {
                        num2 += 65535;
                    }
                    if (num2 > 117440512)
                    {
                        num2 = 0;
                    }
                    int num3 = param1.vTransform.position.z;
                    if (num3 < 0)
                    {
                        num3 += 65535;
                    }
                    if (num3 > 117440512)
                    {
                        num3 = 0;
                    }
                    num = (uint)(this.terrain.vertices[(int)(checked((IntPtr)(unchecked((long)(this.terrain.chunks[(int)(((uint)(num2 >> 16) >> 6) * 32u + ((uint)(num3 >> 16) >> 6))] * 4096) + (((long)(num3 >> 16) & 63L) * 2L + ((long)(num2 >> 16) & 63L) * 128L) / 2L))))] & 63488) >> 8;
                }
                Utilities.SetBackColor((int)num, (int)num, (int)num);
                if (param1.DAT_6C == 0 || vigTransform.position.z <= param1.DAT_6C)
                {
                    if ((param1.flags & 131072u) == 0u)
                    {
                        if ((param1.flags & 65536u) == 0u || this.DAT_DA0 <= param1.vTransform.position.z || param1.vTransform.position.y + param1.DAT_58 <= this.DAT_DB0)
                        {
                            if (param1.vMesh != null)
                            {
                                param1.vMesh.FUN_21F70(vigTransform);
                            }
                            if (param1.child2 != null)
                            {
                                this.FUN_2D778(param1.child2, vigTransform);
                            }
                        }
                        else
                        {
                            if (param1.vMesh != null)
                            {
                                param1.vMesh.FUN_2D2A8(vigTransform);
                            }
                            if (param1.child2 != null)
                            {
                                param1.child2.FUN_2D368(vigTransform);
                            }
                        }
                    }
                    else
                    {
                        Vector3Int param2 = new Vector3Int(param1.vTransform.position.x, this.terrain.FUN_1B750((uint)param1.vTransform.position.x, (uint)param1.vTransform.position.z), param1.vTransform.position.z);
                        Vector3Int vector3Int = this.terrain.FUN_1BB50(param1.vTransform.position.x, param1.vTransform.position.z);
                        vector3Int = Utilities.VectorNormal(vector3Int);
                        if (param1.vMesh != null)
                        {
                            param1.vMesh.FUN_2D4D4(vigTransform, vector3Int, param2);
                        }
                        if (param1.child2 != null)
                        {
                            param1.child2.FUN_2D5EC(vigTransform, vector3Int, param2);
                        }
                    }
                }
                else if (param1.vLOD != null)
                {
                    vigTransform.rotation = param1.FUN_2D884(vigTransform);
                }
                if ((param1.flags & 8u) != 0u)
                {
                    if ((param1.flags & 512u) == 0u)
                    {
                        param1.FUN_4C4F4();
                    }
                    param1.vShadow.FUN_4C73C();
                }
            }
        }
    }

    private void FUN_2DEE8(int param1, int param2)
    {
        Utilities.SetScreenOffset(param1, param2);
        this.DAT_FC8 = new Vector2Int(param1, param2);
    }

    private void FUN_2DF30(int param1, int param2, int param3, int param4)
    {
        this.DAT_EDC = param1;
        this.DAT_F20 = param2;
        this.FUN_2DEE8(param3, param4);
    }

    public VigTransform FUN_2CDF4(VigObject obj)
    {
        VigTransform vigTransform = obj.vTransform;
        for (; ; )
        {
            obj = Utilities.FUN_2CD78(obj);
            if (obj == null)
            {
                break;
            }
            this.DAT_EA8 = Utilities.CompMatrixLV(obj.vTransform, vigTransform);
            vigTransform = this.DAT_EA8;
        }
        return vigTransform;
    }

    public Vector3Int FUN_2CE50(VigObject obj)
    {
        Vector3Int vector3Int = obj.vTransform.position;
        for (; ; )
        {
            obj = Utilities.FUN_2CD78(obj);
            if (obj == null)
            {
                break;
            }
            this.DAT_EC8 = Utilities.FUN_24148(obj.vTransform, vector3Int);
            vector3Int = this.DAT_EC8;
        }
        return vector3Int;
    }

    public VigTransform FUN_2CEAC(VigObject param1, ConfigContainer param2)
    {
        VigTransform m = this.FUN_2CDF4(param1);
        VigTransform m2 = Utilities.FUN_2C77C(param2);
        return Utilities.CompMatrixLV(m, m2);
    }

    public void FUN_2CF00(out Vector3Int param1, VigObject param2, ConfigContainer param3)
    {
        VigTransform transform = this.FUN_2CDF4(param2);
        param1 = Utilities.FUN_24148(transform, param3.v3_1);
    }

    public void FUN_2E0E8(VigTransform param1, int param2)
    {
        this.DAT_F28 = param1;
        this.DAT_F88 = this.DAT_F28;
        this.DAT_F00 = Utilities.FUN_2A3EC(param1);
        this.DAT_ED8 = param2;
        Utilities.SetProjectionPlane(param2);
        Utilities.SetProjectionPlane3(param2);
        this.DAT_F48 = Utilities.FUN_247C4(this.DAT_F68, param1.rotation);
        this.FUN_2DFF0(this.DAT_F00);
        this.DAT_EE0 = this.DAT_F00;
        this.DAT_EE0.rotation = Utilities.FUN_2A4A4(this.DAT_EE0.rotation);
    }

    public bool FUN_2E22C(Vector3Int param1, int param2)
    {
        Coprocessor.rotationMatrix.rt11 = this.DAT_FD8.V00;
        Coprocessor.rotationMatrix.rt12 = this.DAT_FD8.V01;
        Coprocessor.rotationMatrix.rt13 = this.DAT_FD8.V02;
        Coprocessor.rotationMatrix.rt21 = this.DAT_FD8.V10;
        Coprocessor.rotationMatrix.rt22 = this.DAT_FD8.V11;
        Coprocessor.rotationMatrix.rt23 = this.DAT_FD8.V12;
        Coprocessor.rotationMatrix.rt31 = this.DAT_FD8.V20;
        Coprocessor.rotationMatrix.rt32 = this.DAT_FD8.V21;
        Coprocessor.rotationMatrix.rt33 = this.DAT_FD8.V22;
        Coprocessor.accumulator.ir1 = (short)(param1.x - this.DAT_F28.position.x >> 8);
        Coprocessor.accumulator.ir2 = (short)(param1.y - this.DAT_F28.position.y >> 8);
        Coprocessor.accumulator.ir3 = (short)(param1.z - this.DAT_F28.position.z >> 8);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        param2 >>= 8;
        bool result = false;
        if ((int)Coprocessor.accumulator.ir1 < param2 && (int)Coprocessor.accumulator.ir2 < param2)
        {
            result = ((int)Coprocessor.accumulator.ir3 < param2);
        }
        return result;
    }

    private bool FUN_2E22C_2(Vector3Int param1, int param2)
    {
        Coprocessor2.rotationMatrix.rt11 = this.DAT_FD8.V00;
        Coprocessor2.rotationMatrix.rt12 = this.DAT_FD8.V01;
        Coprocessor2.rotationMatrix.rt13 = this.DAT_FD8.V02;
        Coprocessor2.rotationMatrix.rt21 = this.DAT_FD8.V10;
        Coprocessor2.rotationMatrix.rt22 = this.DAT_FD8.V11;
        Coprocessor2.rotationMatrix.rt23 = this.DAT_FD8.V12;
        Coprocessor2.rotationMatrix.rt31 = this.DAT_FD8.V20;
        Coprocessor2.rotationMatrix.rt32 = this.DAT_FD8.V21;
        Coprocessor2.rotationMatrix.rt33 = this.DAT_FD8.V22;
        Coprocessor2.accumulator.ir1 = (short)(param1.x - this.DAT_F28.position.x >> 8);
        Coprocessor2.accumulator.ir2 = (short)(param1.y - this.DAT_F28.position.y >> 8);
        Coprocessor2.accumulator.ir3 = (short)(param1.z - this.DAT_F28.position.z >> 8);
        Coprocessor2.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        param2 >>= 8;
        bool result = false;
        if ((int)Coprocessor2.accumulator.ir1 < param2 && (int)Coprocessor2.accumulator.ir2 < param2)
        {
            result = ((int)Coprocessor2.accumulator.ir3 < param2);
        }
        return result;
    }

    private HitDetection FUN_2E998(VigObject param1, VigObject param2, VigTransform param3, VigTransform param4)
    {
        if (param1.vCollider != null)
        {
            if (param2.vCollider == null)
            {
                return null;
            }
            BufferedBinaryReader reader = param1.vCollider.reader;
            BufferedBinaryReader reader2 = param2.vCollider.reader;
            short num = reader.ReadInt16(0);
            while (num != 0)
            {
                num = reader.ReadInt16(0);
                reader2.Seek(0L, SeekOrigin.Begin);
                BoundingBox boundingBox;
                Radius radius;
                switch (num)
                {
                    case 1:
                        if ((reader.ReadUInt16(2) & 0x8000) == 0)
                        {
                            num = reader2.ReadInt16(0);
                            while (num != 0)
                            {
                                num = reader2.ReadInt16(0);
                                switch (num)
                                {
                                    case 2:
                                        {
                                            int num2 = 0;
                                            if (reader2.ReadUInt16(2) == 0)
                                            {
                                                hit.collider1.ChangeBuffer(reader);
                                                hit.collider2.ChangeBuffer(reader2);
                                                hit.object1 = param1;
                                                hit.object2 = param2;
                                                return hit;
                                            }
                                            int num3 = 4;
                                            while (true)
                                            {
                                                boundingBox = default(BoundingBox);
                                                boundingBox.min = new Vector3Int(reader.ReadInt32(4), reader.ReadInt32(8), reader.ReadInt32(12));
                                                boundingBox.max = new Vector3Int(reader.ReadInt32(16), reader.ReadInt32(20), reader.ReadInt32(24));
                                                BoundingBox param5 = boundingBox;
                                                radius = new Radius
                                                {
                                                    matrixSV = new Vector3Int(reader2.ReadInt16(num3), reader2.ReadInt16(num3 + 2), reader2.ReadInt16(num3 + 4)),
                                                    contactOffset = reader2.ReadInt32(num3 + 8)
                                                };
                                                Radius param6 = radius;
                                                uint num4 = Utilities.FUN_2E2E8(param5, param3, param6, param4);
                                                num2++;
                                                if (num4 == 0)
                                                {
                                                    break;
                                                }
                                                num3 += 12;
                                                if (reader2.ReadUInt16(2) <= num2)
                                                {
                                                    hit.collider1.ChangeBuffer(reader);
                                                    hit.collider2.ChangeBuffer(reader2);
                                                    hit.object1 = param1;
                                                    hit.object2 = param2;
                                                    return hit;
                                                }
                                            }
                                            reader2.Seek(reader2.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                                            num = reader2.ReadInt16(0);
                                            break;
                                        }
                                    case 1:
                                        if ((reader2.ReadUInt16(2) & 0x8000) == 0)
                                        {
                                            boundingBox = default(BoundingBox);
                                            boundingBox.min = new Vector3Int(reader.ReadInt32(4), reader.ReadInt32(8), reader.ReadInt32(12));
                                            boundingBox.max = new Vector3Int(reader.ReadInt32(16), reader.ReadInt32(20), reader.ReadInt32(24));
                                            BoundingBox boundingBox2 = boundingBox;
                                            boundingBox = default(BoundingBox);
                                            boundingBox.min = new Vector3Int(reader2.ReadInt32(4), reader2.ReadInt32(8), reader2.ReadInt32(12));
                                            boundingBox.max = new Vector3Int(reader2.ReadInt32(16), reader2.ReadInt32(20), reader2.ReadInt32(24));
                                            BoundingBox boundingBox3 = boundingBox;
                                            if (Utilities.FUN_281FC(boundingBox2, param3, boundingBox3, param4) && Utilities.FUN_281FC(boundingBox3, param4, boundingBox2, param3))
                                            {
                                                hit.collider1.ChangeBuffer(reader);
                                                hit.collider2.ChangeBuffer(reader2);
                                                hit.object1 = param1;
                                                hit.object2 = param2;
                                                return hit;
                                            }
                                        }
                                        reader2.Seek(28L, SeekOrigin.Current);
                                        num = reader2.ReadInt16(0);
                                        break;
                                }
                            }
                        }
                        reader.Seek(28L, SeekOrigin.Current);
                        num = reader.ReadInt16(0);
                        continue;
                    case 2:
                        break;
                    default:
                        continue;
                }
                while (true)
                {
                    bool flag = false;
                    while (true)
                    {
                        num = reader2.ReadInt16(0);
                        while (true)
                        {
                            if (num == 0)
                            {
                                reader.Seek(reader.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                                num = reader.ReadInt16(0);
                                flag = true;
                                break;
                            }
                            num = reader2.ReadInt16(0);
                            if (num == 1)
                            {
                                break;
                            }
                            if (num != 2)
                            {
                                continue;
                            }
                            goto IL_0378;
                        }
                        if (flag)
                        {
                            break;
                        }
                        if ((reader2.ReadUInt16(2) & 0x8000) == 0)
                        {
                            int num2 = 0;
                            if (reader.ReadUInt16(2) == 0)
                            {
                                hit.collider1.ChangeBuffer(reader);
                                hit.collider2.ChangeBuffer(reader2);
                                hit.object1 = param1;
                                hit.object2 = param2;
                                return hit;
                            }
                            int num3 = 4;
                            while (true)
                            {
                                boundingBox = default(BoundingBox);
                                boundingBox.min = new Vector3Int(reader2.ReadInt32(4), reader2.ReadInt32(8), reader2.ReadInt32(12));
                                boundingBox.max = new Vector3Int(reader2.ReadInt32(16), reader2.ReadInt32(20), reader2.ReadInt32(24));
                                BoundingBox param7 = boundingBox;
                                radius = new Radius
                                {
                                    matrixSV = new Vector3Int(reader.ReadInt16(num3), reader.ReadInt16(num3 + 2), reader.ReadInt16(num3 + 4)),
                                    contactOffset = reader.ReadInt32(num3 + 8)
                                };
                                Radius param8 = radius;
                                uint num5 = Utilities.FUN_2E2E8(param7, param4, param8, param3);
                                num2++;
                                if (num5 == 0)
                                {
                                    break;
                                }
                                num3 += 12;
                                if (reader.ReadUInt16(2) <= num2)
                                {
                                    hit.collider1.ChangeBuffer(reader);
                                    hit.collider2.ChangeBuffer(reader2);
                                    hit.object1 = param1;
                                    hit.object2 = param2;
                                    return hit;
                                }
                            }
                        }
                        reader2.Seek(28L, SeekOrigin.Current);
                    }
                    break;
                IL_0378:
                    reader2.Seek(reader2.ReadUInt16(2) * 12 + 4, SeekOrigin.Current);
                }
            }
            reader.Seek(0L, SeekOrigin.Begin);
            reader2.Seek(0L, SeekOrigin.Begin);
        }
        return null;
    }

    private HitDetection FUN_2ECF8(VigObject param1, VigObject param2, VigTransform param3)
    {
        VigObject vigObject = param1.child2;
        while (!(vigObject == null))
        {
            if (vigObject.vCollider == null || (vigObject.flags & 32u) != 0u)
            {
                if ((vigObject.flags & 2048u) != 0u)
                {
                    VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                    HitDetection hitDetection = this.FUN_2ECF8(vigObject, param2, param4);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            else
            {
                VigTransform param4 = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                HitDetection hitDetection = this.FUN_2E998(vigObject, param2, param4, param2.vTransform);
                if (hitDetection != null)
                {
                    return hitDetection;
                }
                if ((vigObject.flags & 2048u) != 0u)
                {
                    hitDetection = this.FUN_2ECF8(vigObject, param2, param4);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            vigObject = vigObject.child;
        }
        return null;
    }

    private HitDetection FUN_2EDEC(VigObject param1, VigObject param2, VigTransform param3)
    {
        VigObject vigObject = param2.child2;
        while (!(vigObject == null))
        {
            if (vigObject.vCollider == null || (vigObject.flags & 32u) != 0u)
            {
                if ((vigObject.flags & 2048u) != 0u)
                {
                    VigTransform vigTransform = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                    HitDetection hitDetection = this.FUN_2EDEC(param1, vigObject, vigTransform);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            else
            {
                VigTransform vigTransform = Utilities.CompMatrixLV(param3, vigObject.vTransform);
                HitDetection hitDetection = this.FUN_2E998(param1, vigObject, param1.vTransform, vigTransform);
                if (hitDetection != null)
                {
                    return hitDetection;
                }
                if ((vigObject.flags & 2048u) != 0u)
                {
                    hitDetection = this.FUN_2EDEC(param1, vigObject, vigTransform);
                    if (hitDetection != null)
                    {
                        return hitDetection;
                    }
                }
            }
            vigObject = vigObject.child;
        }
        return null;
    }

    private uint FUN_2EEE0(VigObject param1, VigObject param2)
    {
        bool flag = false;
        if (param1.id == param2.id)
        {
            return 0u;
        }
        int num = param1.DAT_58 + param2.DAT_58;
        int num2 = param1.vTransform.position.x - param2.vTransform.position.x;
        if (num2 < 0)
        {
            num2 = -num2;
        }
        if (num2 < num)
        {
            num2 = param1.vTransform.position.y - param2.vTransform.position.y;
            if (num2 < 0)
            {
                num2 = -num2;
            }
            if (num2 < num)
            {
                num2 = param1.vTransform.position.z - param2.vTransform.position.z;
                if (num2 < 0)
                {
                    num2 = -num2;
                }
                flag = (num2 < num);
            }
        }
        if (!flag)
        {
            return 0u;
        }
        if ((param2.flags & 64u) != 0u)
        {
            if (param1.PDAT_74 == null)
            {
                param1.PDAT_74 = param2;
            }
            else
            {
                Vector3Int position = param1.vTransform.position;
                if (param1.PDAT_78 != null)
                {
                    num = Utilities.FUN_29F6C(param1.PDAT_74.vTransform.position, position);
                    if (Utilities.FUN_29F6C(param1.PDAT_78.vTransform.position, position) <= num)
                    {
                        num = Utilities.FUN_29F6C(param2.vTransform.position, position);
                        num2 = Utilities.FUN_29F6C(param1.PDAT_74.vTransform.position, position);
                        if (num2 > num)
                        {
                            param1.PDAT_74 = param2;
                            goto IL_196;
                        }
                        goto IL_196;
                    }
                    else
                    {
                        num = Utilities.FUN_29F6C(param2.vTransform.position, position);
                        num2 = Utilities.FUN_29F6C(param1.PDAT_78.vTransform.position, position);
                        if (num2 <= num)
                        {
                            goto IL_196;
                        }
                    }
                }
                param1.PDAT_78 = param2;
            }
        }
    IL_196:
        HitDetection hitDetection = this.FUN_2E998(param1, param2, param1.vTransform, param2.vTransform);
        uint num3 = 0u;
        if (hitDetection != null)
        {
            hitDetection.self = param2;
            num3 = param1.OnCollision(hitDetection);
            if (num3 + 1u < 2u)
            {
                BufferedBinaryReader collider = hitDetection.collider2;
                VigObject @object = hitDetection.object2;
                num3 >>= 31;
                hitDetection.self = param1;
                hitDetection.collider2 = hitDetection.collider1;
                hitDetection.collider1 = collider;
                hitDetection.object2 = hitDetection.object1;
                hitDetection.object1 = @object;
                num2 = (int)param2.OnCollision(hitDetection);
                if (num2 < 0)
                {
                    num3 |= 2u;
                }
            }
            else
            {
                num3 >>= 31;
            }
        }
        hitDetection = null;
        if (num3 == 0u)
        {
            if (((param1.flags & 2048u) == 0u || (hitDetection = this.FUN_2ECF8(param1, param2, param1.vTransform)) == null) && ((param2.flags & 2048u) == 0u || (hitDetection = this.FUN_2EDEC(param1, param2, param2.vTransform)) == null) && hitDetection == null)
            {
                return 0u;
            }
            hitDetection.self = param2;
            num3 = param1.OnCollision(hitDetection);
            if (num3 + 1u < 2u)
            {
                BufferedBinaryReader collider = hitDetection.collider2;
                VigObject @object = hitDetection.object2;
                num3 >>= 31;
                hitDetection.self = param1;
                hitDetection.collider2 = hitDetection.collider1;
                hitDetection.collider1 = collider;
                hitDetection.object2 = hitDetection.object1;
                hitDetection.object1 = @object;
                num2 = (int)param2.OnCollision(hitDetection);
                if (num2 < 0)
                {
                    num3 |= 2u;
                }
            }
            else
            {
                num3 >>= 31;
            }
        }
        return num3;
    }

    private VigTuple FUN_30180(List<VigTuple> param1, int param2, VigObject param3)
    {
        for (int i = 0; i < param1.Count; i++)
        {
            if (param1[i].vObject != param3 && (int)param1[i].vObject.id == param2)
            {
                return param1[i];
            }
        }
        return null;
    }

    public VigObject FUN_30250(List<VigTuple> param1, int param2)
    {
        VigTuple vigTuple = this.FUN_30180(param1, param2, null);
        VigObject result = null;
        if (vigTuple != null)
        {
            result = vigTuple.vObject;
        }
        return result;
    }

    private bool FUN_30F20(BSP param1, VigObject param2)
    {
        BSP[] array = new BSP[32];
        int x = param2.vTransform.position.x;
        int dat_ = param2.DAT_58;
        int z = param2.vTransform.position.z;
        array[0] = param1;
        int num = 0;
        int num2 = 1;
        while (num < array.Length && num >= 0)
        {
            BSP bsp = array[num];
            int dat_2 = bsp.DAT_00;
            int num3 = num2 - 1;
            if (dat_2 == 1)
            {
                if (x - dat_ < bsp.DAT_04)
                {
                    array[num] = bsp.DAT_08;
                    num++;
                    num3 = num2;
                }
                if (bsp.DAT_04 < x + dat_)
                {
                    bsp = bsp.DAT_0C;
                    num3++;
                    array[num] = bsp;
                    num++;
                }
            }
            else if (dat_2 == 0)
            {
                for (int i = 0; i < bsp.LDAT_04.Count; i++)
                {
                    VigTuple vigTuple = bsp.LDAT_04[i];
                    if ((vigTuple.vObject.flags & 32u) == 0u)
                    {
                        num2 = (int)this.FUN_2EEE0(param2, vigTuple.vObject);
                        if (num2 != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (dat_2 == 2)
            {
                if (z - dat_ < bsp.DAT_04)
                {
                    array[num] = bsp.DAT_08;
                    num++;
                    num3 = num2;
                }
                if (bsp.DAT_04 < z + dat_)
                {
                    bsp = bsp.DAT_0C;
                    num3++;
                    array[num] = bsp;
                    num++;
                }
            }
            else if (dat_2 == 3)
            {
                num3 = num2 + 1;
                array[num] = bsp.DAT_08;
                bsp = bsp.DAT_0C;
                num++;
                array[num] = bsp;
                num++;
            }
            num--;
            num2 = num3;
            if (num3 == 0)
            {
                return true;
            }
        }
        return false;
    }

    private void FUN_3174C()
    {
        int count = this.worldObjs.Count;
        int num = 0;
        while (num < this.worldObjs.Count && num < count)
        {
            VigObject vObject = this.worldObjs[num].vObject;
            if (vObject != null && (vObject.flags & 32u) == 0u)
            {
                vObject.PDAT_78 = null;
                vObject.PDAT_74 = null;
                int num2 = num + 1;
                while (num2 < this.worldObjs.Count && num2 < count)
                {
                    VigObject vObject2 = this.worldObjs[num2].vObject;
                    if (vObject2 != null)
                    {
                        uint flags = vObject2.flags;
                        if ((flags & 32u) == 0u && (flags & vObject.flags & 512u) == 0u)
                        {
                            this.FUN_2EEE0(vObject, vObject2);
                        }
                    }
                    num2++;
                }
                if (this.bspTree != null && (vObject.flags & 256u) == 0u)
                {
                    this.FUN_30F20(this.bspTree, vObject);
                }
            }
            num++;
        }
    }

    private void FUN_34840()
    {
        uint num;
        uint num2;
        if (this.gameMode != _GAME_MODE.Versus2)
        {
            num = (uint)((short)this.levelManager.DAT_C18[2] * 2);
            num2 = (uint)((short)this.levelManager.DAT_C18[3] * 2);
        }
        else
        {
            num = (uint)((short)this.levelManager.DAT_C18[2] / 2);
            num2 = (uint)((short)this.levelManager.DAT_C18[3] / 2);
        }
        if (this.DAT_10F0 < (int)num)
        {
            int num6;
            do
            {
                uint num3 = 3670016u;
                if (this.gameMode != _GAME_MODE.Versus || this.DAT_101C < (int)num2)
                {
                    bool flag = GameManager.FUN_2AC5C() != 0u;
                    num3 = 7864320u;
                    if (((flag ? 1 : 0) & 3) == 0)
                    {
                        num3 = 3670016u;
                    }
                }
                int num4 = (int)GameManager.FUN_2AC5C();
                int num5 = this.FUN_30428(this.DAT_1078, num3);
                VigObject param = this.FUN_30498(this.DAT_1078, num3, num4 * num5 >> 15);
                VigObject x = this.FUN_4AC6C(num3, param);
                if (!(x != null))
                {
                    break;
                }
                num6 = this.DAT_10F0 + 1;
                this.DAT_10F0 = num6;
            }
            while (num6 < (int)num);
        }
    }

    private void FUN_34914()
    {
        uint num;
        if (this.gameMode != _GAME_MODE.Versus2)
        {
            num = (uint)((short)this.levelManager.DAT_C18[4]);
        }
        else
        {
            num = (uint)((short)this.levelManager.DAT_C18[4] / 2);
        }
        if (this.DAT_1028 < (int)num)
        {
            for (; ; )
            {
                int num2 = (int)GameManager.FUN_2AC5C();
                int num3 = this.FUN_30428(this.DAT_1078, 25427968u);
                VigObject param = this.FUN_30498(this.DAT_1078, 25427968u, num2 * num3 >> 15);
                if (this.FUN_4AC6C(25427968u, param) == null)
                {
                    break;
                }
                this.DAT_1028++;
                if (this.DAT_1028 >= (int)num)
                {
                    return;
                }
            }
            return;
        }
    }

    private _PLACEHOLDER_TYPE FUN_36B64(ushort param1)
    {
        if (param1 > 17)
        {
            param1 -= 21;
        }
        return (_PLACEHOLDER_TYPE)param1;
    }

    private Vehicle FUN_36C2C(Placeholder param1, int param2, int param3)
    {
        if (param2 < 0 || param1 == null)
        {
            return null;
        }
        _PLACEHOLDER_TYPE state = this.FUN_36B64((ushort)param2);
        param1.state = state;
        int num;
        if (param3 < 0)
        {
            num = (39 - param3) * 4;
            if (this.levelManager.xobfList[39 - param3] != null && this.levelManager.xobfList[39 - param3].ini != null)
            {
                goto IL_7C;
            }
        }
        else if (this.DAT_CC4 >= 70)
        {
            num = param2 + 21;
            goto IL_7C;
        }
        num = param2;
    IL_7C:
        XOBF_DB vData = this.levelManager.xobfList[num];
        param1.DAT_1A = 0;
        param1.vData = vData;
        Vehicle vehicle = (Vehicle)param1.FUN_31DDC();
        if (this.gameMode >= _GAME_MODE.Versus2)
        {
            vehicle.id = (short)param3;
        }
        int i = 0;
        if (param3 >= 0)
        {
            vehicle.InitializeEnemyStats();
        }
        while (i < 2)
        {
            if (vehicle.body[i] != null)
            {
                vehicle.body[i].id = vehicle.id;
            }
            i++;
        }
        if (0 < param3)
        {
            num = (int)(vehicle.vTransform.rotation.V02 * 4577);
            if (num < 0)
            {
                num += 31;
            }
            vehicle.physics1.X = num >> 5;
            vehicle.physics1.Y = 0;
            num = (int)(vehicle.vTransform.rotation.V22 * 4577);
            if (num < 0)
            {
                num += 31;
            }
            vehicle.physics1.Z = num >> 5;
        }
        return vehicle;
    }

    private void FUN_507DC(JUNC_DB param1)
    {
        bool flag = this.FUN_2E22C(param1.DAT_00, (int)param1.DAT_18.DAT_18);
        Vector3Int position = Utilities.FUN_24148(this.DAT_F00, param1.DAT_00);
        if (flag && position.z < 2097152)
        {
            VigTransform param2;
            param2.rotation = default(Matrix3x3);
            param2.rotation.SetValue32(0, 0);
            param2.rotation.SetValue32(1, 0);
            param2.rotation.SetValue32(2, 0);
            param2.rotation.SetValue32(3, 0);
            param2.rotation.SetValue32(4, 0);
            param2.padding = 0;
            param2.position = position;
            param1.DAT_18.FUN_21F70(param2);
        }
    }

    public static VigTransform FUN_2A39C()
    {
        return GameManager.defaultTransform;
    }

    public static uint FUN_2AC5C()
    {
        uint num = GameManager.DAT_63A64;
        uint num2 = (uint)((uint)((byte)GameManager.DAT_63A68) << 31);
        GameManager.DAT_63A68 = (uint)((byte)num);
        uint num3 = (num >> 1) + num2;
        num <<= 12;
        uint num4 = num3 ^ num;
        num = num4 >> 20;
        return (GameManager.DAT_63A64 = (num4 ^ num)) & 32767u;
    }

    public static GameManager instance;

    public static short[] SQRT = new short[]
    {
        4096,
        4127,
        4159,
        4190,
        4222,
        4252,
        4283,
        4314,
        4344,
        4374,
        4404,
        4434,
        4463,
        4492,
        4521,
        4550,
        4579,
        4608,
        4636,
        4664,
        4692,
        4720,
        4748,
        4775,
        4802,
        4830,
        4857,
        4884,
        4910,
        4937,
        4964,
        4990,
        5016,
        5042,
        5068,
        5094,
        5120,
        5145,
        5170,
        5196,
        5221,
        5246,
        5271,
        5296,
        5320,
        5345,
        5369,
        5394,
        5418,
        5442,
        5466,
        5490,
        5514,
        5538,
        5561,
        5585,
        5608,
        5632,
        5655,
        5678,
        5701,
        5724,
        5747,
        5769,
        5792,
        5815,
        5837,
        5860,
        5882,
        5904,
        5926,
        5948,
        5970,
        5992,
        6014,
        6036,
        6058,
        6079,
        6101,
        6122,
        6144,
        6165,
        6186,
        6207,
        6228,
        6249,
        6270,
        6291,
        6312,
        6333,
        6353,
        6374,
        6394,
        6415,
        6435,
        6456,
        6476,
        6496,
        6516,
        6536,
        6556,
        6576,
        6596,
        6616,
        6636,
        6656,
        6675,
        6695,
        6714,
        6734,
        6753,
        6773,
        6792,
        6811,
        6830,
        6850,
        6869,
        6888,
        6907,
        6926,
        6945,
        6963,
        6982,
        7001,
        7020,
        7038,
        7057,
        7075,
        7094,
        7112,
        7131,
        7149,
        7168,
        7186,
        7204,
        7222,
        7240,
        7258,
        7276,
        7294,
        7312,
        7330,
        7348,
        7366,
        7384,
        7401,
        7419,
        7437,
        7454,
        7472,
        7489,
        7507,
        7524,
        7542,
        7559,
        7576,
        7594,
        7611,
        7628,
        7645,
        7662,
        7680,
        7697,
        7714,
        7731,
        7747,
        7764,
        7781,
        7798,
        7815,
        7832,
        7848,
        7865,
        7882,
        7898,
        7915,
        7931,
        7948,
        7964,
        7981,
        7997,
        8014,
        8030,
        8046,
        8062,
        8079,
        8095,
        8111,
        8127,
        8143,
        8159,
        8175
    };

    public static short[] UNK4 = new short[]
    {
        4096,
        4064,
        4033,
        4003,
        3973,
        3944,
        3916,
        3888,
        3861,
        3835,
        3809,
        3783,
        3758,
        3734,
        3710,
        3686,
        3663,
        3640,
        3618,
        3596,
        3575,
        3554,
        3533,
        3513,
        3493,
        3473,
        3454,
        3435,
        3416,
        3397,
        3379,
        3361,
        3344,
        3327,
        3310,
        3293,
        3276,
        3260,
        3244,
        3228,
        3213,
        3197,
        3182,
        3167,
        3153,
        3138,
        3124,
        3110,
        3096,
        3082,
        3069,
        3055,
        3042,
        3029,
        3016,
        3003,
        2991,
        2978,
        2966,
        2954,
        2942,
        2930,
        2919,
        2907,
        2896,
        2885,
        2873,
        2862,
        2852,
        2841,
        2830,
        2820,
        2809,
        2799,
        2789,
        2779,
        2769,
        2759,
        2749,
        2740,
        2730,
        2721,
        2711,
        2702,
        2693,
        2684,
        2675,
        2666,
        2657,
        2649,
        2640,
        2631,
        2623,
        2615,
        2606,
        2598,
        2590,
        2582,
        2574,
        2566,
        2558,
        2550,
        2543,
        2535,
        2528,
        2520,
        2513,
        2505,
        2498,
        2491,
        2484,
        2477,
        2469,
        2462,
        2456,
        2449,
        2442,
        2435,
        2428,
        2422,
        2415,
        2409,
        2402,
        2396,
        2389,
        2383,
        2377,
        2371,
        2364,
        2358,
        2352,
        2346,
        2340,
        2334,
        2328,
        2322,
        2317,
        2311,
        2305,
        2299,
        2294,
        2288,
        2283,
        2277,
        2272,
        2266,
        2261,
        2255,
        2250,
        2245,
        2239,
        2234,
        2229,
        2224,
        2219,
        2214,
        2209,
        2204,
        2199,
        2194,
        2189,
        2184,
        2179,
        2174,
        2170,
        2165,
        2160,
        2155,
        2151,
        2146,
        2142,
        2137,
        2133,
        2128,
        2124,
        2119,
        2115,
        2110,
        2106,
        2102,
        2097,
        2093,
        2089,
        2084,
        2080,
        2076,
        2072,
        2068,
        2064,
        2060,
        2056,
        2052
    };

    public static short[] DAT_65C90 = new short[]
    {
        0,
        4096,
        6,
        4096,
        13,
        4096,
        19,
        4096,
        25,
        4096,
        31,
        4096,
        38,
        4096,
        44,
        4096,
        50,
        4096,
        57,
        4096,
        63,
        4096,
        69,
        4095,
        75,
        4095,
        82,
        4095,
        88,
        4095,
        94,
        4095,
        101,
        4095,
        107,
        4095,
        113,
        4094,
        119,
        4094,
        126,
        4094,
        132,
        4094,
        138,
        4094,
        144,
        4093,
        151,
        4093,
        157,
        4093,
        163,
        4093,
        170,
        4092,
        176,
        4092,
        182,
        4092,
        188,
        4092,
        195,
        4091,
        201,
        4091,
        207,
        4091,
        214,
        4090,
        220,
        4090,
        226,
        4090,
        232,
        4089,
        239,
        4089,
        245,
        4089,
        251,
        4088,
        257,
        4088,
        264,
        4088,
        270,
        4087,
        276,
        4087,
        283,
        4086,
        289,
        4086,
        295,
        4085,
        301,
        4085,
        308,
        4084,
        314,
        4084,
        320,
        4083,
        326,
        4083,
        333,
        4082,
        339,
        4082,
        345,
        4081,
        351,
        4081,
        358,
        4080,
        364,
        4080,
        370,
        4079,
        376,
        4079,
        383,
        4078,
        389,
        4077,
        395,
        4077,
        401,
        4076,
        408,
        4076,
        414,
        4075,
        420,
        4074,
        426,
        4074,
        433,
        4073,
        439,
        4072,
        445,
        4072,
        451,
        4071,
        458,
        4070,
        464,
        4070,
        470,
        4069,
        476,
        4068,
        483,
        4067,
        489,
        4067,
        495,
        4066,
        501,
        4065,
        508,
        4064,
        514,
        4064,
        520,
        4063,
        526,
        4062,
        533,
        4061,
        539,
        4060,
        545,
        4060,
        551,
        4059,
        557,
        4058,
        564,
        4057,
        570,
        4056,
        576,
        4055,
        582,
        4054,
        589,
        4053,
        595,
        4053,
        601,
        4052,
        607,
        4051,
        613,
        4050,
        620,
        4049,
        626,
        4048,
        632,
        4047,
        638,
        4046,
        644,
        4045,
        651,
        4044,
        657,
        4043,
        663,
        4042,
        669,
        4041,
        675,
        4040,
        682,
        4039,
        688,
        4038,
        694,
        4037,
        700,
        4036,
        706,
        4035,
        713,
        4034,
        719,
        4032,
        725,
        4031,
        731,
        4030,
        737,
        4029,
        744,
        4028,
        750,
        4027,
        756,
        4026,
        762,
        4024,
        768,
        4023,
        774,
        4022,
        781,
        4021,
        787,
        4020,
        793,
        4019,
        799,
        4017,
        805,
        4016,
        811,
        4015,
        818,
        4014,
        824,
        4012,
        830,
        4011,
        836,
        4010,
        842,
        4008,
        848,
        4007,
        854,
        4006,
        861,
        4005,
        867,
        4003,
        873,
        4002,
        879,
        4001,
        885,
        3999,
        891,
        3998,
        897,
        3996,
        904,
        3995,
        910,
        3994,
        916,
        3992,
        922,
        3991,
        928,
        3989,
        934,
        3988,
        940,
        3987,
        946,
        3985,
        953,
        3984,
        959,
        3982,
        965,
        3981,
        971,
        3979,
        977,
        3978,
        983,
        3976,
        989,
        3975,
        995,
        3973,
        1001,
        3972,
        1007,
        3970,
        1014,
        3969,
        1020,
        3967,
        1026,
        3965,
        1032,
        3964,
        1038,
        3962,
        1044,
        3961,
        1050,
        3959,
        1056,
        3958,
        1062,
        3956,
        1068,
        3954,
        1074,
        3953,
        1080,
        3951,
        1086,
        3949,
        1092,
        3948,
        1099,
        3946,
        1105,
        3944,
        1111,
        3943,
        1117,
        3941,
        1123,
        3939,
        1129,
        3937,
        1135,
        3936,
        1141,
        3934,
        1147,
        3932,
        1153,
        3930,
        1159,
        3929,
        1165,
        3927,
        1171,
        3925,
        1177,
        3923,
        1183,
        3921,
        1189,
        3920,
        1195,
        3918,
        1201,
        3916,
        1207,
        3914,
        1213,
        3912,
        1219,
        3910,
        1225,
        3909,
        1231,
        3907,
        1237,
        3905,
        1243,
        3903,
        1249,
        3901,
        1255,
        3899,
        1261,
        3897,
        1267,
        3895,
        1273,
        3893,
        1279,
        3891,
        1285,
        3889,
        1291,
        3887,
        1297,
        3885,
        1303,
        3883,
        1309,
        3881,
        1315,
        3879,
        1321,
        3877,
        1327,
        3875,
        1332,
        3873,
        1338,
        3871,
        1344,
        3869,
        1350,
        3867,
        1356,
        3865,
        1362,
        3863,
        1368,
        3861,
        1374,
        3859,
        1380,
        3857,
        1386,
        3854,
        1392,
        3852,
        1398,
        3850,
        1404,
        3848,
        1409,
        3846,
        1415,
        3844,
        1421,
        3842,
        1427,
        3839,
        1433,
        3837,
        1439,
        3835,
        1445,
        3833,
        1451,
        3831,
        1457,
        3828,
        1462,
        3826,
        1468,
        3824,
        1474,
        3822,
        1480,
        3819,
        1486,
        3817,
        1492,
        3815,
        1498,
        3812,
        1503,
        3810,
        1509,
        3808,
        1515,
        3805,
        1521,
        3803,
        1527,
        3801,
        1533,
        3798,
        1538,
        3796,
        1544,
        3794,
        1550,
        3791,
        1556,
        3789,
        1562,
        3787,
        1567,
        3784,
        1573,
        3782,
        1579,
        3779,
        1585,
        3777,
        1591,
        3775,
        1596,
        3772,
        1602,
        3770,
        1608,
        3767,
        1614,
        3765,
        1620,
        3762,
        1625,
        3760,
        1631,
        3757,
        1637,
        3755,
        1643,
        3752,
        1648,
        3750,
        1654,
        3747,
        1660,
        3745,
        1666,
        3742,
        1671,
        3739,
        1677,
        3737,
        1683,
        3734,
        1689,
        3732,
        1694,
        3729,
        1700,
        3727,
        1706,
        3724,
        1711,
        3721,
        1717,
        3719,
        1723,
        3716,
        1729,
        3713,
        1734,
        3711,
        1740,
        3708,
        1746,
        3705,
        1751,
        3703,
        1757,
        3700,
        1763,
        3697,
        1768,
        3695,
        1774,
        3692,
        1780,
        3689,
        1785,
        3686,
        1791,
        3684,
        1797,
        3681,
        1802,
        3678,
        1808,
        3675,
        1813,
        3673,
        1819,
        3670,
        1825,
        3667,
        1830,
        3664,
        1836,
        3661,
        1842,
        3659,
        1847,
        3656,
        1853,
        3653,
        1858,
        3650,
        1864,
        3647,
        1870,
        3644,
        1875,
        3642,
        1881,
        3639,
        1886,
        3636,
        1892,
        3633,
        1898,
        3630,
        1903,
        3627,
        1909,
        3624,
        1914,
        3621,
        1920,
        3618,
        1925,
        3615,
        1931,
        3612,
        1936,
        3609,
        1942,
        3606,
        1947,
        3603,
        1953,
        3600,
        1958,
        3597,
        1964,
        3594,
        1970,
        3591,
        1975,
        3588,
        1981,
        3585,
        1986,
        3582,
        1992,
        3579,
        1997,
        3576,
        2002,
        3573,
        2008,
        3570,
        2013,
        3567,
        2019,
        3564,
        2024,
        3561,
        2030,
        3558,
        2035,
        3555,
        2041,
        3551,
        2046,
        3548,
        2052,
        3545,
        2057,
        3542,
        2062,
        3539,
        2068,
        3536,
        2073,
        3532,
        2079,
        3529,
        2084,
        3526,
        2090,
        3523,
        2095,
        3520,
        2100,
        3516,
        2106,
        3513,
        2111,
        3510,
        2117,
        3507,
        2122,
        3504,
        2127,
        3500,
        2133,
        3497,
        2138,
        3494,
        2143,
        3490,
        2149,
        3487,
        2154,
        3484,
        2159,
        3481,
        2165,
        3477,
        2170,
        3474,
        2175,
        3471,
        2181,
        3467,
        2186,
        3464,
        2191,
        3461,
        2197,
        3457,
        2202,
        3454,
        2207,
        3450,
        2213,
        3447,
        2218,
        3444,
        2223,
        3440,
        2228,
        3437,
        2234,
        3433,
        2239,
        3430,
        2244,
        3426,
        2249,
        3423,
        2255,
        3420,
        2260,
        3416,
        2265,
        3413,
        2270,
        3409,
        2276,
        3406,
        2281,
        3402,
        2286,
        3399,
        2291,
        3395,
        2296,
        3392,
        2302,
        3388,
        2307,
        3385,
        2312,
        3381,
        2317,
        3378,
        2322,
        3374,
        2328,
        3370,
        2333,
        3367,
        2338,
        3363,
        2343,
        3360,
        2348,
        3356,
        2353,
        3352,
        2359,
        3349,
        2364,
        3345,
        2369,
        3342,
        2374,
        3338,
        2379,
        3334,
        2384,
        3331,
        2389,
        3327,
        2394,
        3323,
        2399,
        3320,
        2405,
        3316,
        2410,
        3312,
        2415,
        3309,
        2420,
        3305,
        2425,
        3301,
        2430,
        3297,
        2435,
        3294,
        2440,
        3290,
        2445,
        3286,
        2450,
        3282,
        2455,
        3279,
        2460,
        3275,
        2465,
        3271,
        2470,
        3267,
        2475,
        3264,
        2480,
        3260,
        2485,
        3256,
        2490,
        3252,
        2495,
        3248,
        2500,
        3244,
        2505,
        3241,
        2510,
        3237,
        2515,
        3233,
        2520,
        3229,
        2525,
        3225,
        2530,
        3221,
        2535,
        3217,
        2540,
        3214,
        2545,
        3210,
        2550,
        3206,
        2555,
        3202,
        2559,
        3198,
        2564,
        3194,
        2569,
        3190,
        2574,
        3186,
        2579,
        3182,
        2584,
        3178,
        2589,
        3174,
        2594,
        3170,
        2598,
        3166,
        2603,
        3162,
        2608,
        3158,
        2613,
        3154,
        2618,
        3150,
        2623,
        3146,
        2628,
        3142,
        2632,
        3138,
        2637,
        3134,
        2642,
        3130,
        2647,
        3126,
        2652,
        3122,
        2656,
        3118,
        2661,
        3114,
        2666,
        3110,
        2671,
        3106,
        2675,
        3102,
        2680,
        3097,
        2685,
        3093,
        2690,
        3089,
        2694,
        3085,
        2699,
        3081,
        2704,
        3077,
        2709,
        3073,
        2713,
        3068,
        2718,
        3064,
        2723,
        3060,
        2727,
        3056,
        2732,
        3052,
        2737,
        3048,
        2741,
        3043,
        2746,
        3039,
        2751,
        3035,
        2755,
        3031,
        2760,
        3026,
        2765,
        3022,
        2769,
        3018,
        2774,
        3014,
        2779,
        3009,
        2783,
        3005,
        2788,
        3001,
        2792,
        2997,
        2797,
        2992,
        2802,
        2988,
        2806,
        2984,
        2811,
        2979,
        2815,
        2975,
        2820,
        2971,
        2824,
        2967,
        2829,
        2962,
        2833,
        2958,
        2838,
        2953,
        2843,
        2949,
        2847,
        2945,
        2852,
        2940,
        2856,
        2936,
        2861,
        2932,
        2865,
        2927,
        2870,
        2923,
        2874,
        2918,
        2878,
        2914,
        2883,
        2910,
        2887,
        2905,
        2892,
        2901,
        2896,
        2896,
        2901,
        2892,
        2905,
        2887,
        2910,
        2883,
        2914,
        2878,
        2918,
        2874,
        2923,
        2870,
        2927,
        2865,
        2932,
        2861,
        2936,
        2856,
        2940,
        2852,
        2945,
        2847,
        2949,
        2843,
        2953,
        2838,
        2958,
        2833,
        2962,
        2829,
        2967,
        2824,
        2971,
        2820,
        2975,
        2815,
        2979,
        2811,
        2984,
        2806,
        2988,
        2802,
        2992,
        2797,
        2997,
        2792,
        3001,
        2788,
        3005,
        2783,
        3009,
        2779,
        3014,
        2774,
        3018,
        2769,
        3022,
        2765,
        3026,
        2760,
        3031,
        2755,
        3035,
        2751,
        3039,
        2746,
        3043,
        2741,
        3048,
        2737,
        3052,
        2732,
        3056,
        2727,
        3060,
        2723,
        3064,
        2718,
        3068,
        2713,
        3073,
        2709,
        3077,
        2704,
        3081,
        2699,
        3085,
        2694,
        3089,
        2690,
        3093,
        2685,
        3097,
        2680,
        3102,
        2675,
        3106,
        2671,
        3110,
        2666,
        3114,
        2661,
        3118,
        2656,
        3122,
        2652,
        3126,
        2647,
        3130,
        2642,
        3134,
        2637,
        3138,
        2632,
        3142,
        2628,
        3146,
        2623,
        3150,
        2618,
        3154,
        2613,
        3158,
        2608,
        3162,
        2603,
        3166,
        2598,
        3170,
        2594,
        3174,
        2589,
        3178,
        2584,
        3182,
        2579,
        3186,
        2574,
        3190,
        2569,
        3194,
        2564,
        3198,
        2559,
        3202,
        2555,
        3206,
        2550,
        3210,
        2545,
        3214,
        2540,
        3217,
        2535,
        3221,
        2530,
        3225,
        2525,
        3229,
        2520,
        3233,
        2515,
        3237,
        2510,
        3241,
        2505,
        3244,
        2500,
        3248,
        2495,
        3252,
        2490,
        3256,
        2485,
        3260,
        2480,
        3264,
        2475,
        3267,
        2470,
        3271,
        2465,
        3275,
        2460,
        3279,
        2455,
        3282,
        2450,
        3286,
        2445,
        3290,
        2440,
        3294,
        2435,
        3297,
        2430,
        3301,
        2425,
        3305,
        2420,
        3309,
        2415,
        3312,
        2410,
        3316,
        2405,
        3320,
        2399,
        3323,
        2394,
        3327,
        2389,
        3331,
        2384,
        3334,
        2379,
        3338,
        2374,
        3342,
        2369,
        3345,
        2364,
        3349,
        2359,
        3352,
        2353,
        3356,
        2348,
        3360,
        2343,
        3363,
        2338,
        3367,
        2333,
        3370,
        2328,
        3374,
        2322,
        3378,
        2317,
        3381,
        2312,
        3385,
        2307,
        3388,
        2302,
        3392,
        2296,
        3395,
        2291,
        3399,
        2286,
        3402,
        2281,
        3406,
        2276,
        3409,
        2270,
        3413,
        2265,
        3416,
        2260,
        3420,
        2255,
        3423,
        2249,
        3426,
        2244,
        3430,
        2239,
        3433,
        2234,
        3437,
        2228,
        3440,
        2223,
        3444,
        2218,
        3447,
        2213,
        3450,
        2207,
        3454,
        2202,
        3457,
        2197,
        3461,
        2191,
        3464,
        2186,
        3467,
        2181,
        3471,
        2175,
        3474,
        2170,
        3477,
        2165,
        3481,
        2159,
        3484,
        2154,
        3487,
        2149,
        3490,
        2143,
        3494,
        2138,
        3497,
        2133,
        3500,
        2127,
        3504,
        2122,
        3507,
        2117,
        3510,
        2111,
        3513,
        2106,
        3516,
        2100,
        3520,
        2095,
        3523,
        2090,
        3526,
        2084,
        3529,
        2079,
        3532,
        2073,
        3536,
        2068,
        3539,
        2062,
        3542,
        2057,
        3545,
        2052,
        3548,
        2046,
        3551,
        2041,
        3555,
        2035,
        3558,
        2030,
        3561,
        2024,
        3564,
        2019,
        3567,
        2013,
        3570,
        2008,
        3573,
        2002,
        3576,
        1997,
        3579,
        1992,
        3582,
        1986,
        3585,
        1981,
        3588,
        1975,
        3591,
        1970,
        3594,
        1964,
        3597,
        1958,
        3600,
        1953,
        3603,
        1947,
        3606,
        1942,
        3609,
        1936,
        3612,
        1931,
        3615,
        1925,
        3618,
        1920,
        3621,
        1914,
        3624,
        1909,
        3627,
        1903,
        3630,
        1898,
        3633,
        1892,
        3636,
        1886,
        3639,
        1881,
        3642,
        1875,
        3644,
        1870,
        3647,
        1864,
        3650,
        1858,
        3653,
        1853,
        3656,
        1847,
        3659,
        1842,
        3661,
        1836,
        3664,
        1830,
        3667,
        1825,
        3670,
        1819,
        3673,
        1813,
        3675,
        1808,
        3678,
        1802,
        3681,
        1797,
        3684,
        1791,
        3686,
        1785,
        3689,
        1780,
        3692,
        1774,
        3695,
        1768,
        3697,
        1763,
        3700,
        1757,
        3703,
        1751,
        3705,
        1746,
        3708,
        1740,
        3711,
        1734,
        3713,
        1729,
        3716,
        1723,
        3719,
        1717,
        3721,
        1711,
        3724,
        1706,
        3727,
        1700,
        3729,
        1694,
        3732,
        1689,
        3734,
        1683,
        3737,
        1677,
        3739,
        1671,
        3742,
        1666,
        3745,
        1660,
        3747,
        1654,
        3750,
        1648,
        3752,
        1643,
        3755,
        1637,
        3757,
        1631,
        3760,
        1625,
        3762,
        1620,
        3765,
        1614,
        3767,
        1608,
        3770,
        1602,
        3772,
        1596,
        3775,
        1591,
        3777,
        1585,
        3779,
        1579,
        3782,
        1573,
        3784,
        1567,
        3787,
        1562,
        3789,
        1556,
        3791,
        1550,
        3794,
        1544,
        3796,
        1538,
        3798,
        1533,
        3801,
        1527,
        3803,
        1521,
        3805,
        1515,
        3808,
        1509,
        3810,
        1503,
        3812,
        1498,
        3815,
        1492,
        3817,
        1486,
        3819,
        1480,
        3822,
        1474,
        3824,
        1468,
        3826,
        1462,
        3828,
        1457,
        3831,
        1451,
        3833,
        1445,
        3835,
        1439,
        3837,
        1433,
        3839,
        1427,
        3842,
        1421,
        3844,
        1415,
        3846,
        1409,
        3848,
        1404,
        3850,
        1398,
        3852,
        1392,
        3854,
        1386,
        3857,
        1380,
        3859,
        1374,
        3861,
        1368,
        3863,
        1362,
        3865,
        1356,
        3867,
        1350,
        3869,
        1344,
        3871,
        1338,
        3873,
        1332,
        3875,
        1327,
        3877,
        1321,
        3879,
        1315,
        3881,
        1309,
        3883,
        1303,
        3885,
        1297,
        3887,
        1291,
        3889,
        1285,
        3891,
        1279,
        3893,
        1273,
        3895,
        1267,
        3897,
        1261,
        3899,
        1255,
        3901,
        1249,
        3903,
        1243,
        3905,
        1237,
        3907,
        1231,
        3909,
        1225,
        3910,
        1219,
        3912,
        1213,
        3914,
        1207,
        3916,
        1201,
        3918,
        1195,
        3920,
        1189,
        3921,
        1183,
        3923,
        1177,
        3925,
        1171,
        3927,
        1165,
        3929,
        1159,
        3930,
        1153,
        3932,
        1147,
        3934,
        1141,
        3936,
        1135,
        3937,
        1129,
        3939,
        1123,
        3941,
        1117,
        3943,
        1111,
        3944,
        1105,
        3946,
        1099,
        3948,
        1092,
        3949,
        1086,
        3951,
        1080,
        3953,
        1074,
        3954,
        1068,
        3956,
        1062,
        3958,
        1056,
        3959,
        1050,
        3961,
        1044,
        3962,
        1038,
        3964,
        1032,
        3965,
        1026,
        3967,
        1020,
        3969,
        1014,
        3970,
        1007,
        3972,
        1001,
        3973,
        995,
        3975,
        989,
        3976,
        983,
        3978,
        977,
        3979,
        971,
        3981,
        965,
        3982,
        959,
        3984,
        953,
        3985,
        946,
        3987,
        940,
        3988,
        934,
        3989,
        928,
        3991,
        922,
        3992,
        916,
        3994,
        910,
        3995,
        904,
        3996,
        897,
        3998,
        891,
        3999,
        885,
        4001,
        879,
        4002,
        873,
        4003,
        867,
        4005,
        861,
        4006,
        854,
        4007,
        848,
        4008,
        842,
        4010,
        836,
        4011,
        830,
        4012,
        824,
        4014,
        818,
        4015,
        811,
        4016,
        805,
        4017,
        799,
        4019,
        793,
        4020,
        787,
        4021,
        781,
        4022,
        774,
        4023,
        768,
        4024,
        762,
        4026,
        756,
        4027,
        750,
        4028,
        744,
        4029,
        737,
        4030,
        731,
        4031,
        725,
        4032,
        719,
        4034,
        713,
        4035,
        706,
        4036,
        700,
        4037,
        694,
        4038,
        688,
        4039,
        682,
        4040,
        675,
        4041,
        669,
        4042,
        663,
        4043,
        657,
        4044,
        651,
        4045,
        644,
        4046,
        638,
        4047,
        632,
        4048,
        626,
        4049,
        620,
        4050,
        613,
        4051,
        607,
        4052,
        601,
        4053,
        595,
        4053,
        589,
        4054,
        582,
        4055,
        576,
        4056,
        570,
        4057,
        564,
        4058,
        557,
        4059,
        551,
        4060,
        545,
        4060,
        539,
        4061,
        533,
        4062,
        526,
        4063,
        520,
        4064,
        514,
        4064,
        508,
        4065,
        501,
        4066,
        495,
        4067,
        489,
        4067,
        483,
        4068,
        476,
        4069,
        470,
        4070,
        464,
        4070,
        458,
        4071,
        451,
        4072,
        445,
        4072,
        439,
        4073,
        433,
        4074,
        426,
        4074,
        420,
        4075,
        414,
        4076,
        408,
        4076,
        401,
        4077,
        395,
        4077,
        389,
        4078,
        383,
        4079,
        376,
        4079,
        370,
        4080,
        364,
        4080,
        358,
        4081,
        351,
        4081,
        345,
        4082,
        339,
        4082,
        333,
        4083,
        326,
        4083,
        320,
        4084,
        314,
        4084,
        308,
        4085,
        301,
        4085,
        295,
        4086,
        289,
        4086,
        283,
        4087,
        276,
        4087,
        270,
        4088,
        264,
        4088,
        257,
        4088,
        251,
        4089,
        245,
        4089,
        239,
        4089,
        232,
        4090,
        226,
        4090,
        220,
        4090,
        214,
        4091,
        207,
        4091,
        201,
        4091,
        195,
        4092,
        188,
        4092,
        182,
        4092,
        176,
        4092,
        170,
        4093,
        163,
        4093,
        157,
        4093,
        151,
        4093,
        144,
        4094,
        138,
        4094,
        132,
        4094,
        126,
        4094,
        119,
        4094,
        113,
        4095,
        107,
        4095,
        101,
        4095,
        94,
        4095,
        88,
        4095,
        82,
        4095,
        75,
        4095,
        69,
        4096,
        63,
        4096,
        57,
        4096,
        50,
        4096,
        44,
        4096,
        38,
        4096,
        31,
        4096,
        25,
        4096,
        19,
        4096,
        13,
        4096,
        6,
        4096,
        0,
        4096,
        -6,
        4096,
        -13,
        4096,
        -19,
        4096,
        -25,
        4096,
        -31,
        4096,
        -38,
        4096,
        -44,
        4096,
        -50,
        4096,
        -57,
        4096,
        -63,
        4095,
        -69,
        4095,
        -75,
        4095,
        -82,
        4095,
        -88,
        4095,
        -94,
        4095,
        -101,
        4095,
        -107,
        4094,
        -113,
        4094,
        -119,
        4094,
        -126,
        4094,
        -132,
        4094,
        -138,
        4093,
        -144,
        4093,
        -151,
        4093,
        -157,
        4093,
        -163,
        4092,
        -170,
        4092,
        -176,
        4092,
        -182,
        4092,
        -188,
        4091,
        -195,
        4091,
        -201,
        4091,
        -207,
        4090,
        -214,
        4090,
        -220,
        4090,
        -226,
        4089,
        -232,
        4089,
        -239,
        4089,
        -245,
        4088,
        -251,
        4088,
        -257,
        4088,
        -264,
        4087,
        -270,
        4087,
        -276,
        4086,
        -283,
        4086,
        -289,
        4085,
        -295,
        4085,
        -301,
        4084,
        -308,
        4084,
        -314,
        4083,
        -320,
        4083,
        -326,
        4082,
        -333,
        4082,
        -339,
        4081,
        -345,
        4081,
        -351,
        4080,
        -358,
        4080,
        -364,
        4079,
        -370,
        4079,
        -376,
        4078,
        -383,
        4077,
        -389,
        4077,
        -395,
        4076,
        -401,
        4076,
        -408,
        4075,
        -414,
        4074,
        -420,
        4074,
        -426,
        4073,
        -433,
        4072,
        -439,
        4072,
        -445,
        4071,
        -451,
        4070,
        -458,
        4070,
        -464,
        4069,
        -470,
        4068,
        -476,
        4067,
        -483,
        4067,
        -489,
        4066,
        -495,
        4065,
        -501,
        4064,
        -508,
        4064,
        -514,
        4063,
        -520,
        4062,
        -526,
        4061,
        -533,
        4060,
        -539,
        4060,
        -545,
        4059,
        -551,
        4058,
        -557,
        4057,
        -564,
        4056,
        -570,
        4055,
        -576,
        4054,
        -582,
        4053,
        -589,
        4053,
        -595,
        4052,
        -601,
        4051,
        -607,
        4050,
        -613,
        4049,
        -620,
        4048,
        -626,
        4047,
        -632,
        4046,
        -638,
        4045,
        -644,
        4044,
        -651,
        4043,
        -657,
        4042,
        -663,
        4041,
        -669,
        4040,
        -675,
        4039,
        -682,
        4038,
        -688,
        4037,
        -694,
        4036,
        -700,
        4035,
        -706,
        4034,
        -713,
        4032,
        -719,
        4031,
        -725,
        4030,
        -731,
        4029,
        -737,
        4028,
        -744,
        4027,
        -750,
        4026,
        -756,
        4024,
        -762,
        4023,
        -768,
        4022,
        -774,
        4021,
        -781,
        4020,
        -787,
        4019,
        -793,
        4017,
        -799,
        4016,
        -805,
        4015,
        -811,
        4014,
        -818,
        4012,
        -824,
        4011,
        -830,
        4010,
        -836,
        4008,
        -842,
        4007,
        -848,
        4006,
        -854,
        4005,
        -861,
        4003,
        -867,
        4002,
        -873,
        4001,
        -879,
        3999,
        -885,
        3998,
        -891,
        3996,
        -897,
        3995,
        -904,
        3994,
        -910,
        3992,
        -916,
        3991,
        -922,
        3989,
        -928,
        3988,
        -934,
        3987,
        -940,
        3985,
        -946,
        3984,
        -953,
        3982,
        -959,
        3981,
        -965,
        3979,
        -971,
        3978,
        -977,
        3976,
        -983,
        3975,
        -989,
        3973,
        -995,
        3972,
        -1001,
        3970,
        -1007,
        3969,
        -1014,
        3967,
        -1020,
        3965,
        -1026,
        3964,
        -1032,
        3962,
        -1038,
        3961,
        -1044,
        3959,
        -1050,
        3958,
        -1056,
        3956,
        -1062,
        3954,
        -1068,
        3953,
        -1074,
        3951,
        -1080,
        3949,
        -1086,
        3948,
        -1092,
        3946,
        -1099,
        3944,
        -1105,
        3943,
        -1111,
        3941,
        -1117,
        3939,
        -1123,
        3937,
        -1129,
        3936,
        -1135,
        3934,
        -1141,
        3932,
        -1147,
        3930,
        -1153,
        3929,
        -1159,
        3927,
        -1165,
        3925,
        -1171,
        3923,
        -1177,
        3921,
        -1183,
        3920,
        -1189,
        3918,
        -1195,
        3916,
        -1201,
        3914,
        -1207,
        3912,
        -1213,
        3910,
        -1219,
        3909,
        -1225,
        3907,
        -1231,
        3905,
        -1237,
        3903,
        -1243,
        3901,
        -1249,
        3899,
        -1255,
        3897,
        -1261,
        3895,
        -1267,
        3893,
        -1273,
        3891,
        -1279,
        3889,
        -1285,
        3887,
        -1291,
        3885,
        -1297,
        3883,
        -1303,
        3881,
        -1309,
        3879,
        -1315,
        3877,
        -1321,
        3875,
        -1327,
        3873,
        -1332,
        3871,
        -1338,
        3869,
        -1344,
        3867,
        -1350,
        3865,
        -1356,
        3863,
        -1362,
        3861,
        -1368,
        3859,
        -1374,
        3857,
        -1380,
        3854,
        -1386,
        3852,
        -1392,
        3850,
        -1398,
        3848,
        -1404,
        3846,
        -1409,
        3844,
        -1415,
        3842,
        -1421,
        3839,
        -1427,
        3837,
        -1433,
        3835,
        -1439,
        3833,
        -1445,
        3831,
        -1451,
        3828,
        -1457,
        3826,
        -1462,
        3824,
        -1468,
        3822,
        -1474,
        3819,
        -1480,
        3817,
        -1486,
        3815,
        -1492,
        3812,
        -1498,
        3810,
        -1503,
        3808,
        -1509,
        3805,
        -1515,
        3803,
        -1521,
        3801,
        -1527,
        3798,
        -1533,
        3796,
        -1538,
        3794,
        -1544,
        3791,
        -1550,
        3789,
        -1556,
        3787,
        -1562,
        3784,
        -1567,
        3782,
        -1573,
        3779,
        -1579,
        3777,
        -1585,
        3775,
        -1591,
        3772,
        -1596,
        3770,
        -1602,
        3767,
        -1608,
        3765,
        -1614,
        3762,
        -1620,
        3760,
        -1625,
        3757,
        -1631,
        3755,
        -1637,
        3752,
        -1643,
        3750,
        -1648,
        3747,
        -1654,
        3745,
        -1660,
        3742,
        -1666,
        3739,
        -1671,
        3737,
        -1677,
        3734,
        -1683,
        3732,
        -1689,
        3729,
        -1694,
        3727,
        -1700,
        3724,
        -1706,
        3721,
        -1711,
        3719,
        -1717,
        3716,
        -1723,
        3713,
        -1729,
        3711,
        -1734,
        3708,
        -1740,
        3705,
        -1746,
        3703,
        -1751,
        3700,
        -1757,
        3697,
        -1763,
        3695,
        -1768,
        3692,
        -1774,
        3689,
        -1780,
        3686,
        -1785,
        3684,
        -1791,
        3681,
        -1797,
        3678,
        -1802,
        3675,
        -1808,
        3673,
        -1813,
        3670,
        -1819,
        3667,
        -1825,
        3664,
        -1830,
        3661,
        -1836,
        3659,
        -1842,
        3656,
        -1847,
        3653,
        -1853,
        3650,
        -1858,
        3647,
        -1864,
        3644,
        -1870,
        3642,
        -1875,
        3639,
        -1881,
        3636,
        -1886,
        3633,
        -1892,
        3630,
        -1898,
        3627,
        -1903,
        3624,
        -1909,
        3621,
        -1914,
        3618,
        -1920,
        3615,
        -1925,
        3612,
        -1931,
        3609,
        -1936,
        3606,
        -1942,
        3603,
        -1947,
        3600,
        -1953,
        3597,
        -1958,
        3594,
        -1964,
        3591,
        -1970,
        3588,
        -1975,
        3585,
        -1981,
        3582,
        -1986,
        3579,
        -1992,
        3576,
        -1997,
        3573,
        -2002,
        3570,
        -2008,
        3567,
        -2013,
        3564,
        -2019,
        3561,
        -2024,
        3558,
        -2030,
        3555,
        -2035,
        3551,
        -2041,
        3548,
        -2046,
        3545,
        -2052,
        3542,
        -2057,
        3539,
        -2062,
        3536,
        -2068,
        3532,
        -2073,
        3529,
        -2079,
        3526,
        -2084,
        3523,
        -2090,
        3520,
        -2095,
        3516,
        -2100,
        3513,
        -2106,
        3510,
        -2111,
        3507,
        -2117,
        3504,
        -2122,
        3500,
        -2127,
        3497,
        -2133,
        3494,
        -2138,
        3490,
        -2143,
        3487,
        -2149,
        3484,
        -2154,
        3481,
        -2159,
        3477,
        -2165,
        3474,
        -2170,
        3471,
        -2175,
        3467,
        -2181,
        3464,
        -2186,
        3461,
        -2191,
        3457,
        -2197,
        3454,
        -2202,
        3450,
        -2207,
        3447,
        -2213,
        3444,
        -2218,
        3440,
        -2223,
        3437,
        -2228,
        3433,
        -2234,
        3430,
        -2239,
        3426,
        -2244,
        3423,
        -2249,
        3420,
        -2255,
        3416,
        -2260,
        3413,
        -2265,
        3409,
        -2270,
        3406,
        -2276,
        3402,
        -2281,
        3399,
        -2286,
        3395,
        -2291,
        3392,
        -2296,
        3388,
        -2302,
        3385,
        -2307,
        3381,
        -2312,
        3378,
        -2317,
        3374,
        -2322,
        3370,
        -2328,
        3367,
        -2333,
        3363,
        -2338,
        3360,
        -2343,
        3356,
        -2348,
        3352,
        -2353,
        3349,
        -2359,
        3345,
        -2364,
        3342,
        -2369,
        3338,
        -2374,
        3334,
        -2379,
        3331,
        -2384,
        3327,
        -2389,
        3323,
        -2394,
        3320,
        -2399,
        3316,
        -2405,
        3312,
        -2410,
        3309,
        -2415,
        3305,
        -2420,
        3301,
        -2425,
        3297,
        -2430,
        3294,
        -2435,
        3290,
        -2440,
        3286,
        -2445,
        3282,
        -2450,
        3279,
        -2455,
        3275,
        -2460,
        3271,
        -2465,
        3267,
        -2470,
        3264,
        -2475,
        3260,
        -2480,
        3256,
        -2485,
        3252,
        -2490,
        3248,
        -2495,
        3244,
        -2500,
        3241,
        -2505,
        3237,
        -2510,
        3233,
        -2515,
        3229,
        -2520,
        3225,
        -2525,
        3221,
        -2530,
        3217,
        -2535,
        3214,
        -2540,
        3210,
        -2545,
        3206,
        -2550,
        3202,
        -2555,
        3198,
        -2559,
        3194,
        -2564,
        3190,
        -2569,
        3186,
        -2574,
        3182,
        -2579,
        3178,
        -2584,
        3174,
        -2589,
        3170,
        -2594,
        3166,
        -2598,
        3162,
        -2603,
        3158,
        -2608,
        3154,
        -2613,
        3150,
        -2618,
        3146,
        -2623,
        3142,
        -2628,
        3138,
        -2632,
        3134,
        -2637,
        3130,
        -2642,
        3126,
        -2647,
        3122,
        -2652,
        3118,
        -2656,
        3114,
        -2661,
        3110,
        -2666,
        3106,
        -2671,
        3102,
        -2675,
        3097,
        -2680,
        3093,
        -2685,
        3089,
        -2690,
        3085,
        -2694,
        3081,
        -2699,
        3077,
        -2704,
        3073,
        -2709,
        3068,
        -2713,
        3064,
        -2718,
        3060,
        -2723,
        3056,
        -2727,
        3052,
        -2732,
        3048,
        -2737,
        3043,
        -2741,
        3039,
        -2746,
        3035,
        -2751,
        3031,
        -2755,
        3026,
        -2760,
        3022,
        -2765,
        3018,
        -2769,
        3014,
        -2774,
        3009,
        -2779,
        3005,
        -2783,
        3001,
        -2788,
        2997,
        -2792,
        2992,
        -2797,
        2988,
        -2802,
        2984,
        -2806,
        2979,
        -2811,
        2975,
        -2815,
        2971,
        -2820,
        2967,
        -2824,
        2962,
        -2829,
        2958,
        -2833,
        2953,
        -2838,
        2949,
        -2843,
        2945,
        -2847,
        2940,
        -2852,
        2936,
        -2856,
        2932,
        -2861,
        2927,
        -2865,
        2923,
        -2870,
        2918,
        -2874,
        2914,
        -2878,
        2910,
        -2883,
        2905,
        -2887,
        2901,
        -2892,
        2896,
        -2896,
        2892,
        -2901,
        2887,
        -2905,
        2883,
        -2910,
        2878,
        -2914,
        2874,
        -2918,
        2870,
        -2923,
        2865,
        -2927,
        2861,
        -2932,
        2856,
        -2936,
        2852,
        -2940,
        2847,
        -2945,
        2843,
        -2949,
        2838,
        -2953,
        2833,
        -2958,
        2829,
        -2962,
        2824,
        -2967,
        2820,
        -2971,
        2815,
        -2975,
        2811,
        -2979,
        2806,
        -2984,
        2802,
        -2988,
        2797,
        -2992,
        2792,
        -2997,
        2788,
        -3001,
        2783,
        -3005,
        2779,
        -3009,
        2774,
        -3014,
        2769,
        -3018,
        2765,
        -3022,
        2760,
        -3026,
        2755,
        -3031,
        2751,
        -3035,
        2746,
        -3039,
        2741,
        -3043,
        2737,
        -3048,
        2732,
        -3052,
        2727,
        -3056,
        2723,
        -3060,
        2718,
        -3064,
        2713,
        -3068,
        2709,
        -3073,
        2704,
        -3077,
        2699,
        -3081,
        2694,
        -3085,
        2690,
        -3089,
        2685,
        -3093,
        2680,
        -3097,
        2675,
        -3102,
        2671,
        -3106,
        2666,
        -3110,
        2661,
        -3114,
        2656,
        -3118,
        2652,
        -3122,
        2647,
        -3126,
        2642,
        -3130,
        2637,
        -3134,
        2632,
        -3138,
        2628,
        -3142,
        2623,
        -3146,
        2618,
        -3150,
        2613,
        -3154,
        2608,
        -3158,
        2603,
        -3162,
        2598,
        -3166,
        2594,
        -3170,
        2589,
        -3174,
        2584,
        -3178,
        2579,
        -3182,
        2574,
        -3186,
        2569,
        -3190,
        2564,
        -3194,
        2559,
        -3198,
        2555,
        -3202,
        2550,
        -3206,
        2545,
        -3210,
        2540,
        -3214,
        2535,
        -3217,
        2530,
        -3221,
        2525,
        -3225,
        2520,
        -3229,
        2515,
        -3233,
        2510,
        -3237,
        2505,
        -3241,
        2500,
        -3244,
        2495,
        -3248,
        2490,
        -3252,
        2485,
        -3256,
        2480,
        -3260,
        2475,
        -3264,
        2470,
        -3267,
        2465,
        -3271,
        2460,
        -3275,
        2455,
        -3279,
        2450,
        -3282,
        2445,
        -3286,
        2440,
        -3290,
        2435,
        -3294,
        2430,
        -3297,
        2425,
        -3301,
        2420,
        -3305,
        2415,
        -3309,
        2410,
        -3312,
        2405,
        -3316,
        2399,
        -3320,
        2394,
        -3323,
        2389,
        -3327,
        2384,
        -3331,
        2379,
        -3334,
        2374,
        -3338,
        2369,
        -3342,
        2364,
        -3345,
        2359,
        -3349,
        2353,
        -3352,
        2348,
        -3356,
        2343,
        -3360,
        2338,
        -3363,
        2333,
        -3367,
        2328,
        -3370,
        2322,
        -3374,
        2317,
        -3378,
        2312,
        -3381,
        2307,
        -3385,
        2302,
        -3388,
        2296,
        -3392,
        2291,
        -3395,
        2286,
        -3399,
        2281,
        -3402,
        2276,
        -3406,
        2270,
        -3409,
        2265,
        -3413,
        2260,
        -3416,
        2255,
        -3420,
        2249,
        -3423,
        2244,
        -3426,
        2239,
        -3430,
        2234,
        -3433,
        2228,
        -3437,
        2223,
        -3440,
        2218,
        -3444,
        2213,
        -3447,
        2207,
        -3450,
        2202,
        -3454,
        2197,
        -3457,
        2191,
        -3461,
        2186,
        -3464,
        2181,
        -3467,
        2175,
        -3471,
        2170,
        -3474,
        2165,
        -3477,
        2159,
        -3481,
        2154,
        -3484,
        2149,
        -3487,
        2143,
        -3490,
        2138,
        -3494,
        2133,
        -3497,
        2127,
        -3500,
        2122,
        -3504,
        2117,
        -3507,
        2111,
        -3510,
        2106,
        -3513,
        2100,
        -3516,
        2095,
        -3520,
        2090,
        -3523,
        2084,
        -3526,
        2079,
        -3529,
        2073,
        -3532,
        2068,
        -3536,
        2062,
        -3539,
        2057,
        -3542,
        2052,
        -3545,
        2046,
        -3548,
        2041,
        -3551,
        2035,
        -3555,
        2030,
        -3558,
        2024,
        -3561,
        2019,
        -3564,
        2013,
        -3567,
        2008,
        -3570,
        2002,
        -3573,
        1997,
        -3576,
        1992,
        -3579,
        1986,
        -3582,
        1981,
        -3585,
        1975,
        -3588,
        1970,
        -3591,
        1964,
        -3594,
        1958,
        -3597,
        1953,
        -3600,
        1947,
        -3603,
        1942,
        -3606,
        1936,
        -3609,
        1931,
        -3612,
        1925,
        -3615,
        1920,
        -3618,
        1914,
        -3621,
        1909,
        -3624,
        1903,
        -3627,
        1898,
        -3630,
        1892,
        -3633,
        1886,
        -3636,
        1881,
        -3639,
        1875,
        -3642,
        1870,
        -3644,
        1864,
        -3647,
        1858,
        -3650,
        1853,
        -3653,
        1847,
        -3656,
        1842,
        -3659,
        1836,
        -3661,
        1830,
        -3664,
        1825,
        -3667,
        1819,
        -3670,
        1813,
        -3673,
        1808,
        -3675,
        1802,
        -3678,
        1797,
        -3681,
        1791,
        -3684,
        1785,
        -3686,
        1780,
        -3689,
        1774,
        -3692,
        1768,
        -3695,
        1763,
        -3697,
        1757,
        -3700,
        1751,
        -3703,
        1746,
        -3705,
        1740,
        -3708,
        1734,
        -3711,
        1729,
        -3713,
        1723,
        -3716,
        1717,
        -3719,
        1711,
        -3721,
        1706,
        -3724,
        1700,
        -3727,
        1694,
        -3729,
        1689,
        -3732,
        1683,
        -3734,
        1677,
        -3737,
        1671,
        -3739,
        1666,
        -3742,
        1660,
        -3745,
        1654,
        -3747,
        1648,
        -3750,
        1643,
        -3752,
        1637,
        -3755,
        1631,
        -3757,
        1625,
        -3760,
        1620,
        -3762,
        1614,
        -3765,
        1608,
        -3767,
        1602,
        -3770,
        1596,
        -3772,
        1591,
        -3775,
        1585,
        -3777,
        1579,
        -3779,
        1573,
        -3782,
        1567,
        -3784,
        1562,
        -3787,
        1556,
        -3789,
        1550,
        -3791,
        1544,
        -3794,
        1538,
        -3796,
        1533,
        -3798,
        1527,
        -3801,
        1521,
        -3803,
        1515,
        -3805,
        1509,
        -3808,
        1503,
        -3810,
        1498,
        -3812,
        1492,
        -3815,
        1486,
        -3817,
        1480,
        -3819,
        1474,
        -3822,
        1468,
        -3824,
        1462,
        -3826,
        1457,
        -3828,
        1451,
        -3831,
        1445,
        -3833,
        1439,
        -3835,
        1433,
        -3837,
        1427,
        -3839,
        1421,
        -3842,
        1415,
        -3844,
        1409,
        -3846,
        1404,
        -3848,
        1398,
        -3850,
        1392,
        -3852,
        1386,
        -3854,
        1380,
        -3857,
        1374,
        -3859,
        1368,
        -3861,
        1362,
        -3863,
        1356,
        -3865,
        1350,
        -3867,
        1344,
        -3869,
        1338,
        -3871,
        1332,
        -3873,
        1327,
        -3875,
        1321,
        -3877,
        1315,
        -3879,
        1309,
        -3881,
        1303,
        -3883,
        1297,
        -3885,
        1291,
        -3887,
        1285,
        -3889,
        1279,
        -3891,
        1273,
        -3893,
        1267,
        -3895,
        1261,
        -3897,
        1255,
        -3899,
        1249,
        -3901,
        1243,
        -3903,
        1237,
        -3905,
        1231,
        -3907,
        1225,
        -3909,
        1219,
        -3910,
        1213,
        -3912,
        1207,
        -3914,
        1201,
        -3916,
        1195,
        -3918,
        1189,
        -3920,
        1183,
        -3921,
        1177,
        -3923,
        1171,
        -3925,
        1165,
        -3927,
        1159,
        -3929,
        1153,
        -3930,
        1147,
        -3932,
        1141,
        -3934,
        1135,
        -3936,
        1129,
        -3937,
        1123,
        -3939,
        1117,
        -3941,
        1111,
        -3943,
        1105,
        -3944,
        1099,
        -3946,
        1092,
        -3948,
        1086,
        -3949,
        1080,
        -3951,
        1074,
        -3953,
        1068,
        -3954,
        1062,
        -3956,
        1056,
        -3958,
        1050,
        -3959,
        1044,
        -3961,
        1038,
        -3962,
        1032,
        -3964,
        1026,
        -3965,
        1020,
        -3967,
        1014,
        -3969,
        1007,
        -3970,
        1001,
        -3972,
        995,
        -3973,
        989,
        -3975,
        983,
        -3976,
        977,
        -3978,
        971,
        -3979,
        965,
        -3981,
        959,
        -3982,
        953,
        -3984,
        946,
        -3985,
        940,
        -3987,
        934,
        -3988,
        928,
        -3989,
        922,
        -3991,
        916,
        -3992,
        910,
        -3994,
        904,
        -3995,
        897,
        -3996,
        891,
        -3998,
        885,
        -3999,
        879,
        -4001,
        873,
        -4002,
        867,
        -4003,
        861,
        -4005,
        854,
        -4006,
        848,
        -4007,
        842,
        -4008,
        836,
        -4010,
        830,
        -4011,
        824,
        -4012,
        818,
        -4014,
        811,
        -4015,
        805,
        -4016,
        799,
        -4017,
        793,
        -4019,
        787,
        -4020,
        781,
        -4021,
        774,
        -4022,
        768,
        -4023,
        762,
        -4024,
        756,
        -4026,
        750,
        -4027,
        744,
        -4028,
        737,
        -4029,
        731,
        -4030,
        725,
        -4031,
        719,
        -4032,
        713,
        -4034,
        706,
        -4035,
        700,
        -4036,
        694,
        -4037,
        688,
        -4038,
        682,
        -4039,
        675,
        -4040,
        669,
        -4041,
        663,
        -4042,
        657,
        -4043,
        651,
        -4044,
        644,
        -4045,
        638,
        -4046,
        632,
        -4047,
        626,
        -4048,
        620,
        -4049,
        613,
        -4050,
        607,
        -4051,
        601,
        -4052,
        595,
        -4053,
        589,
        -4053,
        582,
        -4054,
        576,
        -4055,
        570,
        -4056,
        564,
        -4057,
        557,
        -4058,
        551,
        -4059,
        545,
        -4060,
        539,
        -4060,
        533,
        -4061,
        526,
        -4062,
        520,
        -4063,
        514,
        -4064,
        508,
        -4064,
        501,
        -4065,
        495,
        -4066,
        489,
        -4067,
        483,
        -4067,
        476,
        -4068,
        470,
        -4069,
        464,
        -4070,
        458,
        -4070,
        451,
        -4071,
        445,
        -4072,
        439,
        -4072,
        433,
        -4073,
        426,
        -4074,
        420,
        -4074,
        414,
        -4075,
        408,
        -4076,
        401,
        -4076,
        395,
        -4077,
        389,
        -4077,
        383,
        -4078,
        376,
        -4079,
        370,
        -4079,
        364,
        -4080,
        358,
        -4080,
        351,
        -4081,
        345,
        -4081,
        339,
        -4082,
        333,
        -4082,
        326,
        -4083,
        320,
        -4083,
        314,
        -4084,
        308,
        -4084,
        301,
        -4085,
        295,
        -4085,
        289,
        -4086,
        283,
        -4086,
        276,
        -4087,
        270,
        -4087,
        264,
        -4088,
        257,
        -4088,
        251,
        -4088,
        245,
        -4089,
        239,
        -4089,
        232,
        -4089,
        226,
        -4090,
        220,
        -4090,
        214,
        -4090,
        207,
        -4091,
        201,
        -4091,
        195,
        -4091,
        188,
        -4092,
        182,
        -4092,
        176,
        -4092,
        170,
        -4092,
        163,
        -4093,
        157,
        -4093,
        151,
        -4093,
        144,
        -4093,
        138,
        -4094,
        132,
        -4094,
        126,
        -4094,
        119,
        -4094,
        113,
        -4094,
        107,
        -4095,
        101,
        -4095,
        94,
        -4095,
        88,
        -4095,
        82,
        -4095,
        75,
        -4095,
        69,
        -4095,
        63,
        -4096,
        57,
        -4096,
        50,
        -4096,
        44,
        -4096,
        38,
        -4096,
        31,
        -4096,
        25,
        -4096,
        19,
        -4096,
        13,
        -4096,
        6,
        -4096,
        0,
        -4096,
        -6,
        -4096,
        -13,
        -4096,
        -19,
        -4096,
        -25,
        -4096,
        -31,
        -4096,
        -38,
        -4096,
        -44,
        -4096,
        -50,
        -4096,
        -57,
        -4096,
        -63,
        -4096,
        -69,
        -4095,
        -75,
        -4095,
        -82,
        -4095,
        -88,
        -4095,
        -94,
        -4095,
        -101,
        -4095,
        -107,
        -4095,
        -113,
        -4094,
        -119,
        -4094,
        -126,
        -4094,
        -132,
        -4094,
        -138,
        -4094,
        -144,
        -4093,
        -151,
        -4093,
        -157,
        -4093,
        -163,
        -4093,
        -170,
        -4092,
        -176,
        -4092,
        -182,
        -4092,
        -188,
        -4092,
        -195,
        -4091,
        -201,
        -4091,
        -207,
        -4091,
        -214,
        -4090,
        -220,
        -4090,
        -226,
        -4090,
        -232,
        -4089,
        -239,
        -4089,
        -245,
        -4089,
        -251,
        -4088,
        -257,
        -4088,
        -264,
        -4088,
        -270,
        -4087,
        -276,
        -4087,
        -283,
        -4086,
        -289,
        -4086,
        -295,
        -4085,
        -301,
        -4085,
        -308,
        -4084,
        -314,
        -4084,
        -320,
        -4083,
        -326,
        -4083,
        -333,
        -4082,
        -339,
        -4082,
        -345,
        -4081,
        -351,
        -4081,
        -358,
        -4080,
        -364,
        -4080,
        -370,
        -4079,
        -376,
        -4079,
        -383,
        -4078,
        -389,
        -4077,
        -395,
        -4077,
        -401,
        -4076,
        -408,
        -4076,
        -414,
        -4075,
        -420,
        -4074,
        -426,
        -4074,
        -433,
        -4073,
        -439,
        -4072,
        -445,
        -4072,
        -451,
        -4071,
        -458,
        -4070,
        -464,
        -4070,
        -470,
        -4069,
        -476,
        -4068,
        -483,
        -4067,
        -489,
        -4067,
        -495,
        -4066,
        -501,
        -4065,
        -508,
        -4064,
        -514,
        -4064,
        -520,
        -4063,
        -526,
        -4062,
        -533,
        -4061,
        -539,
        -4060,
        -545,
        -4060,
        -551,
        -4059,
        -557,
        -4058,
        -564,
        -4057,
        -570,
        -4056,
        -576,
        -4055,
        -582,
        -4054,
        -589,
        -4053,
        -595,
        -4053,
        -601,
        -4052,
        -607,
        -4051,
        -613,
        -4050,
        -620,
        -4049,
        -626,
        -4048,
        -632,
        -4047,
        -638,
        -4046,
        -644,
        -4045,
        -651,
        -4044,
        -657,
        -4043,
        -663,
        -4042,
        -669,
        -4041,
        -675,
        -4040,
        -682,
        -4039,
        -688,
        -4038,
        -694,
        -4037,
        -700,
        -4036,
        -706,
        -4035,
        -713,
        -4034,
        -719,
        -4032,
        -725,
        -4031,
        -731,
        -4030,
        -737,
        -4029,
        -744,
        -4028,
        -750,
        -4027,
        -756,
        -4026,
        -762,
        -4024,
        -768,
        -4023,
        -774,
        -4022,
        -781,
        -4021,
        -787,
        -4020,
        -793,
        -4019,
        -799,
        -4017,
        -805,
        -4016,
        -811,
        -4015,
        -818,
        -4014,
        -824,
        -4012,
        -830,
        -4011,
        -836,
        -4010,
        -842,
        -4008,
        -848,
        -4007,
        -854,
        -4006,
        -861,
        -4005,
        -867,
        -4003,
        -873,
        -4002,
        -879,
        -4001,
        -885,
        -3999,
        -891,
        -3998,
        -897,
        -3996,
        -904,
        -3995,
        -910,
        -3994,
        -916,
        -3992,
        -922,
        -3991,
        -928,
        -3989,
        -934,
        -3988,
        -940,
        -3987,
        -946,
        -3985,
        -953,
        -3984,
        -959,
        -3982,
        -965,
        -3981,
        -971,
        -3979,
        -977,
        -3978,
        -983,
        -3976,
        -989,
        -3975,
        -995,
        -3973,
        -1001,
        -3972,
        -1007,
        -3970,
        -1014,
        -3969,
        -1020,
        -3967,
        -1026,
        -3965,
        -1032,
        -3964,
        -1038,
        -3962,
        -1044,
        -3961,
        -1050,
        -3959,
        -1056,
        -3958,
        -1062,
        -3956,
        -1068,
        -3954,
        -1074,
        -3953,
        -1080,
        -3951,
        -1086,
        -3949,
        -1092,
        -3948,
        -1099,
        -3946,
        -1105,
        -3944,
        -1111,
        -3943,
        -1117,
        -3941,
        -1123,
        -3939,
        -1129,
        -3937,
        -1135,
        -3936,
        -1141,
        -3934,
        -1147,
        -3932,
        -1153,
        -3930,
        -1159,
        -3929,
        -1165,
        -3927,
        -1171,
        -3925,
        -1177,
        -3923,
        -1183,
        -3921,
        -1189,
        -3920,
        -1195,
        -3918,
        -1201,
        -3916,
        -1207,
        -3914,
        -1213,
        -3912,
        -1219,
        -3910,
        -1225,
        -3909,
        -1231,
        -3907,
        -1237,
        -3905,
        -1243,
        -3903,
        -1249,
        -3901,
        -1255,
        -3899,
        -1261,
        -3897,
        -1267,
        -3895,
        -1273,
        -3893,
        -1279,
        -3891,
        -1285,
        -3889,
        -1291,
        -3887,
        -1297,
        -3885,
        -1303,
        -3883,
        -1309,
        -3881,
        -1315,
        -3879,
        -1321,
        -3877,
        -1327,
        -3875,
        -1332,
        -3873,
        -1338,
        -3871,
        -1344,
        -3869,
        -1350,
        -3867,
        -1356,
        -3865,
        -1362,
        -3863,
        -1368,
        -3861,
        -1374,
        -3859,
        -1380,
        -3857,
        -1386,
        -3854,
        -1392,
        -3852,
        -1398,
        -3850,
        -1404,
        -3848,
        -1409,
        -3846,
        -1415,
        -3844,
        -1421,
        -3842,
        -1427,
        -3839,
        -1433,
        -3837,
        -1439,
        -3835,
        -1445,
        -3833,
        -1451,
        -3831,
        -1457,
        -3828,
        -1462,
        -3826,
        -1468,
        -3824,
        -1474,
        -3822,
        -1480,
        -3819,
        -1486,
        -3817,
        -1492,
        -3815,
        -1498,
        -3812,
        -1503,
        -3810,
        -1509,
        -3808,
        -1515,
        -3805,
        -1521,
        -3803,
        -1527,
        -3801,
        -1533,
        -3798,
        -1538,
        -3796,
        -1544,
        -3794,
        -1550,
        -3791,
        -1556,
        -3789,
        -1562,
        -3787,
        -1567,
        -3784,
        -1573,
        -3782,
        -1579,
        -3779,
        -1585,
        -3777,
        -1591,
        -3775,
        -1596,
        -3772,
        -1602,
        -3770,
        -1608,
        -3767,
        -1614,
        -3765,
        -1620,
        -3762,
        -1625,
        -3760,
        -1631,
        -3757,
        -1637,
        -3755,
        -1643,
        -3752,
        -1648,
        -3750,
        -1654,
        -3747,
        -1660,
        -3745,
        -1666,
        -3742,
        -1671,
        -3739,
        -1677,
        -3737,
        -1683,
        -3734,
        -1689,
        -3732,
        -1694,
        -3729,
        -1700,
        -3727,
        -1706,
        -3724,
        -1711,
        -3721,
        -1717,
        -3719,
        -1723,
        -3716,
        -1729,
        -3713,
        -1734,
        -3711,
        -1740,
        -3708,
        -1746,
        -3705,
        -1751,
        -3703,
        -1757,
        -3700,
        -1763,
        -3697,
        -1768,
        -3695,
        -1774,
        -3692,
        -1780,
        -3689,
        -1785,
        -3686,
        -1791,
        -3684,
        -1797,
        -3681,
        -1802,
        -3678,
        -1808,
        -3675,
        -1813,
        -3673,
        -1819,
        -3670,
        -1825,
        -3667,
        -1830,
        -3664,
        -1836,
        -3661,
        -1842,
        -3659,
        -1847,
        -3656,
        -1853,
        -3653,
        -1858,
        -3650,
        -1864,
        -3647,
        -1870,
        -3644,
        -1875,
        -3642,
        -1881,
        -3639,
        -1886,
        -3636,
        -1892,
        -3633,
        -1898,
        -3630,
        -1903,
        -3627,
        -1909,
        -3624,
        -1914,
        -3621,
        -1920,
        -3618,
        -1925,
        -3615,
        -1931,
        -3612,
        -1936,
        -3609,
        -1942,
        -3606,
        -1947,
        -3603,
        -1953,
        -3600,
        -1958,
        -3597,
        -1964,
        -3594,
        -1970,
        -3591,
        -1975,
        -3588,
        -1981,
        -3585,
        -1986,
        -3582,
        -1992,
        -3579,
        -1997,
        -3576,
        -2002,
        -3573,
        -2008,
        -3570,
        -2013,
        -3567,
        -2019,
        -3564,
        -2024,
        -3561,
        -2030,
        -3558,
        -2035,
        -3555,
        -2041,
        -3551,
        -2046,
        -3548,
        -2052,
        -3545,
        -2057,
        -3542,
        -2062,
        -3539,
        -2068,
        -3536,
        -2073,
        -3532,
        -2079,
        -3529,
        -2084,
        -3526,
        -2090,
        -3523,
        -2095,
        -3520,
        -2100,
        -3516,
        -2106,
        -3513,
        -2111,
        -3510,
        -2117,
        -3507,
        -2122,
        -3504,
        -2127,
        -3500,
        -2133,
        -3497,
        -2138,
        -3494,
        -2143,
        -3490,
        -2149,
        -3487,
        -2154,
        -3484,
        -2159,
        -3481,
        -2165,
        -3477,
        -2170,
        -3474,
        -2175,
        -3471,
        -2181,
        -3467,
        -2186,
        -3464,
        -2191,
        -3461,
        -2197,
        -3457,
        -2202,
        -3454,
        -2207,
        -3450,
        -2213,
        -3447,
        -2218,
        -3444,
        -2223,
        -3440,
        -2228,
        -3437,
        -2234,
        -3433,
        -2239,
        -3430,
        -2244,
        -3426,
        -2249,
        -3423,
        -2255,
        -3420,
        -2260,
        -3416,
        -2265,
        -3413,
        -2270,
        -3409,
        -2276,
        -3406,
        -2281,
        -3402,
        -2286,
        -3399,
        -2291,
        -3395,
        -2296,
        -3392,
        -2302,
        -3388,
        -2307,
        -3385,
        -2312,
        -3381,
        -2317,
        -3378,
        -2322,
        -3374,
        -2328,
        -3370,
        -2333,
        -3367,
        -2338,
        -3363,
        -2343,
        -3360,
        -2348,
        -3356,
        -2353,
        -3352,
        -2359,
        -3349,
        -2364,
        -3345,
        -2369,
        -3342,
        -2374,
        -3338,
        -2379,
        -3334,
        -2384,
        -3331,
        -2389,
        -3327,
        -2394,
        -3323,
        -2399,
        -3320,
        -2405,
        -3316,
        -2410,
        -3312,
        -2415,
        -3309,
        -2420,
        -3305,
        -2425,
        -3301,
        -2430,
        -3297,
        -2435,
        -3294,
        -2440,
        -3290,
        -2445,
        -3286,
        -2450,
        -3282,
        -2455,
        -3279,
        -2460,
        -3275,
        -2465,
        -3271,
        -2470,
        -3267,
        -2475,
        -3264,
        -2480,
        -3260,
        -2485,
        -3256,
        -2490,
        -3252,
        -2495,
        -3248,
        -2500,
        -3244,
        -2505,
        -3241,
        -2510,
        -3237,
        -2515,
        -3233,
        -2520,
        -3229,
        -2525,
        -3225,
        -2530,
        -3221,
        -2535,
        -3217,
        -2540,
        -3214,
        -2545,
        -3210,
        -2550,
        -3206,
        -2555,
        -3202,
        -2559,
        -3198,
        -2564,
        -3194,
        -2569,
        -3190,
        -2574,
        -3186,
        -2579,
        -3182,
        -2584,
        -3178,
        -2589,
        -3174,
        -2594,
        -3170,
        -2598,
        -3166,
        -2603,
        -3162,
        -2608,
        -3158,
        -2613,
        -3154,
        -2618,
        -3150,
        -2623,
        -3146,
        -2628,
        -3142,
        -2632,
        -3138,
        -2637,
        -3134,
        -2642,
        -3130,
        -2647,
        -3126,
        -2652,
        -3122,
        -2656,
        -3118,
        -2661,
        -3114,
        -2666,
        -3110,
        -2671,
        -3106,
        -2675,
        -3102,
        -2680,
        -3097,
        -2685,
        -3093,
        -2690,
        -3089,
        -2694,
        -3085,
        -2699,
        -3081,
        -2704,
        -3077,
        -2709,
        -3073,
        -2713,
        -3068,
        -2718,
        -3064,
        -2723,
        -3060,
        -2727,
        -3056,
        -2732,
        -3052,
        -2737,
        -3048,
        -2741,
        -3043,
        -2746,
        -3039,
        -2751,
        -3035,
        -2755,
        -3031,
        -2760,
        -3026,
        -2765,
        -3022,
        -2769,
        -3018,
        -2774,
        -3014,
        -2779,
        -3009,
        -2783,
        -3005,
        -2788,
        -3001,
        -2792,
        -2997,
        -2797,
        -2992,
        -2802,
        -2988,
        -2806,
        -2984,
        -2811,
        -2979,
        -2815,
        -2975,
        -2820,
        -2971,
        -2824,
        -2967,
        -2829,
        -2962,
        -2833,
        -2958,
        -2838,
        -2953,
        -2843,
        -2949,
        -2847,
        -2945,
        -2852,
        -2940,
        -2856,
        -2936,
        -2861,
        -2932,
        -2865,
        -2927,
        -2870,
        -2923,
        -2874,
        -2918,
        -2878,
        -2914,
        -2883,
        -2910,
        -2887,
        -2905,
        -2892,
        -2901,
        -2896,
        -2896,
        -2901,
        -2892,
        -2905,
        -2887,
        -2910,
        -2883,
        -2914,
        -2878,
        -2918,
        -2874,
        -2923,
        -2870,
        -2927,
        -2865,
        -2932,
        -2861,
        -2936,
        -2856,
        -2940,
        -2852,
        -2945,
        -2847,
        -2949,
        -2843,
        -2953,
        -2838,
        -2958,
        -2833,
        -2962,
        -2829,
        -2967,
        -2824,
        -2971,
        -2820,
        -2975,
        -2815,
        -2979,
        -2811,
        -2984,
        -2806,
        -2988,
        -2802,
        -2992,
        -2797,
        -2997,
        -2792,
        -3001,
        -2788,
        -3005,
        -2783,
        -3009,
        -2779,
        -3014,
        -2774,
        -3018,
        -2769,
        -3022,
        -2765,
        -3026,
        -2760,
        -3031,
        -2755,
        -3035,
        -2751,
        -3039,
        -2746,
        -3043,
        -2741,
        -3048,
        -2737,
        -3052,
        -2732,
        -3056,
        -2727,
        -3060,
        -2723,
        -3064,
        -2718,
        -3068,
        -2713,
        -3073,
        -2709,
        -3077,
        -2704,
        -3081,
        -2699,
        -3085,
        -2694,
        -3089,
        -2690,
        -3093,
        -2685,
        -3097,
        -2680,
        -3102,
        -2675,
        -3106,
        -2671,
        -3110,
        -2666,
        -3114,
        -2661,
        -3118,
        -2656,
        -3122,
        -2652,
        -3126,
        -2647,
        -3130,
        -2642,
        -3134,
        -2637,
        -3138,
        -2632,
        -3142,
        -2628,
        -3146,
        -2623,
        -3150,
        -2618,
        -3154,
        -2613,
        -3158,
        -2608,
        -3162,
        -2603,
        -3166,
        -2598,
        -3170,
        -2594,
        -3174,
        -2589,
        -3178,
        -2584,
        -3182,
        -2579,
        -3186,
        -2574,
        -3190,
        -2569,
        -3194,
        -2564,
        -3198,
        -2559,
        -3202,
        -2555,
        -3206,
        -2550,
        -3210,
        -2545,
        -3214,
        -2540,
        -3217,
        -2535,
        -3221,
        -2530,
        -3225,
        -2525,
        -3229,
        -2520,
        -3233,
        -2515,
        -3237,
        -2510,
        -3241,
        -2505,
        -3244,
        -2500,
        -3248,
        -2495,
        -3252,
        -2490,
        -3256,
        -2485,
        -3260,
        -2480,
        -3264,
        -2475,
        -3267,
        -2470,
        -3271,
        -2465,
        -3275,
        -2460,
        -3279,
        -2455,
        -3282,
        -2450,
        -3286,
        -2445,
        -3290,
        -2440,
        -3294,
        -2435,
        -3297,
        -2430,
        -3301,
        -2425,
        -3305,
        -2420,
        -3309,
        -2415,
        -3312,
        -2410,
        -3316,
        -2405,
        -3320,
        -2399,
        -3323,
        -2394,
        -3327,
        -2389,
        -3331,
        -2384,
        -3334,
        -2379,
        -3338,
        -2374,
        -3342,
        -2369,
        -3345,
        -2364,
        -3349,
        -2359,
        -3352,
        -2353,
        -3356,
        -2348,
        -3360,
        -2343,
        -3363,
        -2338,
        -3367,
        -2333,
        -3370,
        -2328,
        -3374,
        -2322,
        -3378,
        -2317,
        -3381,
        -2312,
        -3385,
        -2307,
        -3388,
        -2302,
        -3392,
        -2296,
        -3395,
        -2291,
        -3399,
        -2286,
        -3402,
        -2281,
        -3406,
        -2276,
        -3409,
        -2270,
        -3413,
        -2265,
        -3416,
        -2260,
        -3420,
        -2255,
        -3423,
        -2249,
        -3426,
        -2244,
        -3430,
        -2239,
        -3433,
        -2234,
        -3437,
        -2228,
        -3440,
        -2223,
        -3444,
        -2218,
        -3447,
        -2213,
        -3450,
        -2207,
        -3454,
        -2202,
        -3457,
        -2197,
        -3461,
        -2191,
        -3464,
        -2186,
        -3467,
        -2181,
        -3471,
        -2175,
        -3474,
        -2170,
        -3477,
        -2165,
        -3481,
        -2159,
        -3484,
        -2154,
        -3487,
        -2149,
        -3490,
        -2143,
        -3494,
        -2138,
        -3497,
        -2133,
        -3500,
        -2127,
        -3504,
        -2122,
        -3507,
        -2117,
        -3510,
        -2111,
        -3513,
        -2106,
        -3516,
        -2100,
        -3520,
        -2095,
        -3523,
        -2090,
        -3526,
        -2084,
        -3529,
        -2079,
        -3532,
        -2073,
        -3536,
        -2068,
        -3539,
        -2062,
        -3542,
        -2057,
        -3545,
        -2052,
        -3548,
        -2046,
        -3551,
        -2041,
        -3555,
        -2035,
        -3558,
        -2030,
        -3561,
        -2024,
        -3564,
        -2019,
        -3567,
        -2013,
        -3570,
        -2008,
        -3573,
        -2002,
        -3576,
        -1997,
        -3579,
        -1992,
        -3582,
        -1986,
        -3585,
        -1981,
        -3588,
        -1975,
        -3591,
        -1970,
        -3594,
        -1964,
        -3597,
        -1958,
        -3600,
        -1953,
        -3603,
        -1947,
        -3606,
        -1942,
        -3609,
        -1936,
        -3612,
        -1931,
        -3615,
        -1925,
        -3618,
        -1920,
        -3621,
        -1914,
        -3624,
        -1909,
        -3627,
        -1903,
        -3630,
        -1898,
        -3633,
        -1892,
        -3636,
        -1886,
        -3639,
        -1881,
        -3642,
        -1875,
        -3644,
        -1870,
        -3647,
        -1864,
        -3650,
        -1858,
        -3653,
        -1853,
        -3656,
        -1847,
        -3659,
        -1842,
        -3661,
        -1836,
        -3664,
        -1830,
        -3667,
        -1825,
        -3670,
        -1819,
        -3673,
        -1813,
        -3675,
        -1808,
        -3678,
        -1802,
        -3681,
        -1797,
        -3684,
        -1791,
        -3686,
        -1785,
        -3689,
        -1780,
        -3692,
        -1774,
        -3695,
        -1768,
        -3697,
        -1763,
        -3700,
        -1757,
        -3703,
        -1751,
        -3705,
        -1746,
        -3708,
        -1740,
        -3711,
        -1734,
        -3713,
        -1729,
        -3716,
        -1723,
        -3719,
        -1717,
        -3721,
        -1711,
        -3724,
        -1706,
        -3727,
        -1700,
        -3729,
        -1694,
        -3732,
        -1689,
        -3734,
        -1683,
        -3737,
        -1677,
        -3739,
        -1671,
        -3742,
        -1666,
        -3745,
        -1660,
        -3747,
        -1654,
        -3750,
        -1648,
        -3752,
        -1643,
        -3755,
        -1637,
        -3757,
        -1631,
        -3760,
        -1625,
        -3762,
        -1620,
        -3765,
        -1614,
        -3767,
        -1608,
        -3770,
        -1602,
        -3772,
        -1596,
        -3775,
        -1591,
        -3777,
        -1585,
        -3779,
        -1579,
        -3782,
        -1573,
        -3784,
        -1567,
        -3787,
        -1562,
        -3789,
        -1556,
        -3791,
        -1550,
        -3794,
        -1544,
        -3796,
        -1538,
        -3798,
        -1533,
        -3801,
        -1527,
        -3803,
        -1521,
        -3805,
        -1515,
        -3808,
        -1509,
        -3810,
        -1503,
        -3812,
        -1498,
        -3815,
        -1492,
        -3817,
        -1486,
        -3819,
        -1480,
        -3822,
        -1474,
        -3824,
        -1468,
        -3826,
        -1462,
        -3828,
        -1457,
        -3831,
        -1451,
        -3833,
        -1445,
        -3835,
        -1439,
        -3837,
        -1433,
        -3839,
        -1427,
        -3842,
        -1421,
        -3844,
        -1415,
        -3846,
        -1409,
        -3848,
        -1404,
        -3850,
        -1398,
        -3852,
        -1392,
        -3854,
        -1386,
        -3857,
        -1380,
        -3859,
        -1374,
        -3861,
        -1368,
        -3863,
        -1362,
        -3865,
        -1356,
        -3867,
        -1350,
        -3869,
        -1344,
        -3871,
        -1338,
        -3873,
        -1332,
        -3875,
        -1327,
        -3877,
        -1321,
        -3879,
        -1315,
        -3881,
        -1309,
        -3883,
        -1303,
        -3885,
        -1297,
        -3887,
        -1291,
        -3889,
        -1285,
        -3891,
        -1279,
        -3893,
        -1273,
        -3895,
        -1267,
        -3897,
        -1261,
        -3899,
        -1255,
        -3901,
        -1249,
        -3903,
        -1243,
        -3905,
        -1237,
        -3907,
        -1231,
        -3909,
        -1225,
        -3910,
        -1219,
        -3912,
        -1213,
        -3914,
        -1207,
        -3916,
        -1201,
        -3918,
        -1195,
        -3920,
        -1189,
        -3921,
        -1183,
        -3923,
        -1177,
        -3925,
        -1171,
        -3927,
        -1165,
        -3929,
        -1159,
        -3930,
        -1153,
        -3932,
        -1147,
        -3934,
        -1141,
        -3936,
        -1135,
        -3937,
        -1129,
        -3939,
        -1123,
        -3941,
        -1117,
        -3943,
        -1111,
        -3944,
        -1105,
        -3946,
        -1099,
        -3948,
        -1092,
        -3949,
        -1086,
        -3951,
        -1080,
        -3953,
        -1074,
        -3954,
        -1068,
        -3956,
        -1062,
        -3958,
        -1056,
        -3959,
        -1050,
        -3961,
        -1044,
        -3962,
        -1038,
        -3964,
        -1032,
        -3965,
        -1026,
        -3967,
        -1020,
        -3969,
        -1014,
        -3970,
        -1007,
        -3972,
        -1001,
        -3973,
        -995,
        -3975,
        -989,
        -3976,
        -983,
        -3978,
        -977,
        -3979,
        -971,
        -3981,
        -965,
        -3982,
        -959,
        -3984,
        -953,
        -3985,
        -946,
        -3987,
        -940,
        -3988,
        -934,
        -3989,
        -928,
        -3991,
        -922,
        -3992,
        -916,
        -3994,
        -910,
        -3995,
        -904,
        -3996,
        -897,
        -3998,
        -891,
        -3999,
        -885,
        -4001,
        -879,
        -4002,
        -873,
        -4003,
        -867,
        -4005,
        -861,
        -4006,
        -854,
        -4007,
        -848,
        -4008,
        -842,
        -4010,
        -836,
        -4011,
        -830,
        -4012,
        -824,
        -4014,
        -818,
        -4015,
        -811,
        -4016,
        -805,
        -4017,
        -799,
        -4019,
        -793,
        -4020,
        -787,
        -4021,
        -781,
        -4022,
        -774,
        -4023,
        -768,
        -4024,
        -762,
        -4026,
        -756,
        -4027,
        -750,
        -4028,
        -744,
        -4029,
        -737,
        -4030,
        -731,
        -4031,
        -725,
        -4032,
        -719,
        -4034,
        -713,
        -4035,
        -706,
        -4036,
        -700,
        -4037,
        -694,
        -4038,
        -688,
        -4039,
        -682,
        -4040,
        -675,
        -4041,
        -669,
        -4042,
        -663,
        -4043,
        -657,
        -4044,
        -651,
        -4045,
        -644,
        -4046,
        -638,
        -4047,
        -632,
        -4048,
        -626,
        -4049,
        -620,
        -4050,
        -613,
        -4051,
        -607,
        -4052,
        -601,
        -4053,
        -595,
        -4053,
        -589,
        -4054,
        -582,
        -4055,
        -576,
        -4056,
        -570,
        -4057,
        -564,
        -4058,
        -557,
        -4059,
        -551,
        -4060,
        -545,
        -4060,
        -539,
        -4061,
        -533,
        -4062,
        -526,
        -4063,
        -520,
        -4064,
        -514,
        -4064,
        -508,
        -4065,
        -501,
        -4066,
        -495,
        -4067,
        -489,
        -4067,
        -483,
        -4068,
        -476,
        -4069,
        -470,
        -4070,
        -464,
        -4070,
        -458,
        -4071,
        -451,
        -4072,
        -445,
        -4072,
        -439,
        -4073,
        -433,
        -4074,
        -426,
        -4074,
        -420,
        -4075,
        -414,
        -4076,
        -408,
        -4076,
        -401,
        -4077,
        -395,
        -4077,
        -389,
        -4078,
        -383,
        -4079,
        -376,
        -4079,
        -370,
        -4080,
        -364,
        -4080,
        -358,
        -4081,
        -351,
        -4081,
        -345,
        -4082,
        -339,
        -4082,
        -333,
        -4083,
        -326,
        -4083,
        -320,
        -4084,
        -314,
        -4084,
        -308,
        -4085,
        -301,
        -4085,
        -295,
        -4086,
        -289,
        -4086,
        -283,
        -4087,
        -276,
        -4087,
        -270,
        -4088,
        -264,
        -4088,
        -257,
        -4088,
        -251,
        -4089,
        -245,
        -4089,
        -239,
        -4089,
        -232,
        -4090,
        -226,
        -4090,
        -220,
        -4090,
        -214,
        -4091,
        -207,
        -4091,
        -201,
        -4091,
        -195,
        -4092,
        -188,
        -4092,
        -182,
        -4092,
        -176,
        -4092,
        -170,
        -4093,
        -163,
        -4093,
        -157,
        -4093,
        -151,
        -4093,
        -144,
        -4094,
        -138,
        -4094,
        -132,
        -4094,
        -126,
        -4094,
        -119,
        -4094,
        -113,
        -4095,
        -107,
        -4095,
        -101,
        -4095,
        -94,
        -4095,
        -88,
        -4095,
        -82,
        -4095,
        -75,
        -4095,
        -69,
        -4096,
        -63,
        -4096,
        -57,
        -4096,
        -50,
        -4096,
        -44,
        -4096,
        -38,
        -4096,
        -31,
        -4096,
        -25,
        -4096,
        -19,
        -4096,
        -13,
        -4096,
        -6,
        -4096,
        0,
        -4096,
        6,
        -4096,
        13,
        -4096,
        19,
        -4096,
        25,
        -4096,
        31,
        -4096,
        38,
        -4096,
        44,
        -4096,
        50,
        -4096,
        57,
        -4096,
        63,
        -4095,
        69,
        -4095,
        75,
        -4095,
        82,
        -4095,
        88,
        -4095,
        94,
        -4095,
        101,
        -4095,
        107,
        -4094,
        113,
        -4094,
        119,
        -4094,
        126,
        -4094,
        132,
        -4094,
        138,
        -4093,
        144,
        -4093,
        151,
        -4093,
        157,
        -4093,
        163,
        -4092,
        170,
        -4092,
        176,
        -4092,
        182,
        -4092,
        188,
        -4091,
        195,
        -4091,
        201,
        -4091,
        207,
        -4090,
        214,
        -4090,
        220,
        -4090,
        226,
        -4089,
        232,
        -4089,
        239,
        -4089,
        245,
        -4088,
        251,
        -4088,
        257,
        -4088,
        264,
        -4087,
        270,
        -4087,
        276,
        -4086,
        283,
        -4086,
        289,
        -4085,
        295,
        -4085,
        301,
        -4084,
        308,
        -4084,
        314,
        -4083,
        320,
        -4083,
        326,
        -4082,
        333,
        -4082,
        339,
        -4081,
        345,
        -4081,
        351,
        -4080,
        358,
        -4080,
        364,
        -4079,
        370,
        -4079,
        376,
        -4078,
        383,
        -4077,
        389,
        -4077,
        395,
        -4076,
        401,
        -4076,
        408,
        -4075,
        414,
        -4074,
        420,
        -4074,
        426,
        -4073,
        433,
        -4072,
        439,
        -4072,
        445,
        -4071,
        451,
        -4070,
        458,
        -4070,
        464,
        -4069,
        470,
        -4068,
        476,
        -4067,
        483,
        -4067,
        489,
        -4066,
        495,
        -4065,
        501,
        -4064,
        508,
        -4064,
        514,
        -4063,
        520,
        -4062,
        526,
        -4061,
        533,
        -4060,
        539,
        -4060,
        545,
        -4059,
        551,
        -4058,
        557,
        -4057,
        564,
        -4056,
        570,
        -4055,
        576,
        -4054,
        582,
        -4053,
        589,
        -4053,
        595,
        -4052,
        601,
        -4051,
        607,
        -4050,
        613,
        -4049,
        620,
        -4048,
        626,
        -4047,
        632,
        -4046,
        638,
        -4045,
        644,
        -4044,
        651,
        -4043,
        657,
        -4042,
        663,
        -4041,
        669,
        -4040,
        675,
        -4039,
        682,
        -4038,
        688,
        -4037,
        694,
        -4036,
        700,
        -4035,
        706,
        -4034,
        713,
        -4032,
        719,
        -4031,
        725,
        -4030,
        731,
        -4029,
        737,
        -4028,
        744,
        -4027,
        750,
        -4026,
        756,
        -4024,
        762,
        -4023,
        768,
        -4022,
        774,
        -4021,
        781,
        -4020,
        787,
        -4019,
        793,
        -4017,
        799,
        -4016,
        805,
        -4015,
        811,
        -4014,
        818,
        -4012,
        824,
        -4011,
        830,
        -4010,
        836,
        -4008,
        842,
        -4007,
        848,
        -4006,
        854,
        -4005,
        861,
        -4003,
        867,
        -4002,
        873,
        -4001,
        879,
        -3999,
        885,
        -3998,
        891,
        -3996,
        897,
        -3995,
        904,
        -3994,
        910,
        -3992,
        916,
        -3991,
        922,
        -3989,
        928,
        -3988,
        934,
        -3987,
        940,
        -3985,
        946,
        -3984,
        953,
        -3982,
        959,
        -3981,
        965,
        -3979,
        971,
        -3978,
        977,
        -3976,
        983,
        -3975,
        989,
        -3973,
        995,
        -3972,
        1001,
        -3970,
        1007,
        -3969,
        1014,
        -3967,
        1020,
        -3965,
        1026,
        -3964,
        1032,
        -3962,
        1038,
        -3961,
        1044,
        -3959,
        1050,
        -3958,
        1056,
        -3956,
        1062,
        -3954,
        1068,
        -3953,
        1074,
        -3951,
        1080,
        -3949,
        1086,
        -3948,
        1092,
        -3946,
        1099,
        -3944,
        1105,
        -3943,
        1111,
        -3941,
        1117,
        -3939,
        1123,
        -3937,
        1129,
        -3936,
        1135,
        -3934,
        1141,
        -3932,
        1147,
        -3930,
        1153,
        -3929,
        1159,
        -3927,
        1165,
        -3925,
        1171,
        -3923,
        1177,
        -3921,
        1183,
        -3920,
        1189,
        -3918,
        1195,
        -3916,
        1201,
        -3914,
        1207,
        -3912,
        1213,
        -3910,
        1219,
        -3909,
        1225,
        -3907,
        1231,
        -3905,
        1237,
        -3903,
        1243,
        -3901,
        1249,
        -3899,
        1255,
        -3897,
        1261,
        -3895,
        1267,
        -3893,
        1273,
        -3891,
        1279,
        -3889,
        1285,
        -3887,
        1291,
        -3885,
        1297,
        -3883,
        1303,
        -3881,
        1309,
        -3879,
        1315,
        -3877,
        1321,
        -3875,
        1327,
        -3873,
        1332,
        -3871,
        1338,
        -3869,
        1344,
        -3867,
        1350,
        -3865,
        1356,
        -3863,
        1362,
        -3861,
        1368,
        -3859,
        1374,
        -3857,
        1380,
        -3854,
        1386,
        -3852,
        1392,
        -3850,
        1398,
        -3848,
        1404,
        -3846,
        1409,
        -3844,
        1415,
        -3842,
        1421,
        -3839,
        1427,
        -3837,
        1433,
        -3835,
        1439,
        -3833,
        1445,
        -3831,
        1451,
        -3828,
        1457,
        -3826,
        1462,
        -3824,
        1468,
        -3822,
        1474,
        -3819,
        1480,
        -3817,
        1486,
        -3815,
        1492,
        -3812,
        1498,
        -3810,
        1503,
        -3808,
        1509,
        -3805,
        1515,
        -3803,
        1521,
        -3801,
        1527,
        -3798,
        1533,
        -3796,
        1538,
        -3794,
        1544,
        -3791,
        1550,
        -3789,
        1556,
        -3787,
        1562,
        -3784,
        1567,
        -3782,
        1573,
        -3779,
        1579,
        -3777,
        1585,
        -3775,
        1591,
        -3772,
        1596,
        -3770,
        1602,
        -3767,
        1608,
        -3765,
        1614,
        -3762,
        1620,
        -3760,
        1625,
        -3757,
        1631,
        -3755,
        1637,
        -3752,
        1643,
        -3750,
        1648,
        -3747,
        1654,
        -3745,
        1660,
        -3742,
        1666,
        -3739,
        1671,
        -3737,
        1677,
        -3734,
        1683,
        -3732,
        1689,
        -3729,
        1694,
        -3727,
        1700,
        -3724,
        1706,
        -3721,
        1711,
        -3719,
        1717,
        -3716,
        1723,
        -3713,
        1729,
        -3711,
        1734,
        -3708,
        1740,
        -3705,
        1746,
        -3703,
        1751,
        -3700,
        1757,
        -3697,
        1763,
        -3695,
        1768,
        -3692,
        1774,
        -3689,
        1780,
        -3686,
        1785,
        -3684,
        1791,
        -3681,
        1797,
        -3678,
        1802,
        -3675,
        1808,
        -3673,
        1813,
        -3670,
        1819,
        -3667,
        1825,
        -3664,
        1830,
        -3661,
        1836,
        -3659,
        1842,
        -3656,
        1847,
        -3653,
        1853,
        -3650,
        1858,
        -3647,
        1864,
        -3644,
        1870,
        -3642,
        1875,
        -3639,
        1881,
        -3636,
        1886,
        -3633,
        1892,
        -3630,
        1898,
        -3627,
        1903,
        -3624,
        1909,
        -3621,
        1914,
        -3618,
        1920,
        -3615,
        1925,
        -3612,
        1931,
        -3609,
        1936,
        -3606,
        1942,
        -3603,
        1947,
        -3600,
        1953,
        -3597,
        1958,
        -3594,
        1964,
        -3591,
        1970,
        -3588,
        1975,
        -3585,
        1981,
        -3582,
        1986,
        -3579,
        1992,
        -3576,
        1997,
        -3573,
        2002,
        -3570,
        2008,
        -3567,
        2013,
        -3564,
        2019,
        -3561,
        2024,
        -3558,
        2030,
        -3555,
        2035,
        -3551,
        2041,
        -3548,
        2046,
        -3545,
        2052,
        -3542,
        2057,
        -3539,
        2062,
        -3536,
        2068,
        -3532,
        2073,
        -3529,
        2079,
        -3526,
        2084,
        -3523,
        2090,
        -3520,
        2095,
        -3516,
        2100,
        -3513,
        2106,
        -3510,
        2111,
        -3507,
        2117,
        -3504,
        2122,
        -3500,
        2127,
        -3497,
        2133,
        -3494,
        2138,
        -3490,
        2143,
        -3487,
        2149,
        -3484,
        2154,
        -3481,
        2159,
        -3477,
        2165,
        -3474,
        2170,
        -3471,
        2175,
        -3467,
        2181,
        -3464,
        2186,
        -3461,
        2191,
        -3457,
        2197,
        -3454,
        2202,
        -3450,
        2207,
        -3447,
        2213,
        -3444,
        2218,
        -3440,
        2223,
        -3437,
        2228,
        -3433,
        2234,
        -3430,
        2239,
        -3426,
        2244,
        -3423,
        2249,
        -3420,
        2255,
        -3416,
        2260,
        -3413,
        2265,
        -3409,
        2270,
        -3406,
        2276,
        -3402,
        2281,
        -3399,
        2286,
        -3395,
        2291,
        -3392,
        2296,
        -3388,
        2302,
        -3385,
        2307,
        -3381,
        2312,
        -3378,
        2317,
        -3374,
        2322,
        -3370,
        2328,
        -3367,
        2333,
        -3363,
        2338,
        -3360,
        2343,
        -3356,
        2348,
        -3352,
        2353,
        -3349,
        2359,
        -3345,
        2364,
        -3342,
        2369,
        -3338,
        2374,
        -3334,
        2379,
        -3331,
        2384,
        -3327,
        2389,
        -3323,
        2394,
        -3320,
        2399,
        -3316,
        2405,
        -3312,
        2410,
        -3309,
        2415,
        -3305,
        2420,
        -3301,
        2425,
        -3297,
        2430,
        -3294,
        2435,
        -3290,
        2440,
        -3286,
        2445,
        -3282,
        2450,
        -3279,
        2455,
        -3275,
        2460,
        -3271,
        2465,
        -3267,
        2470,
        -3264,
        2475,
        -3260,
        2480,
        -3256,
        2485,
        -3252,
        2490,
        -3248,
        2495,
        -3244,
        2500,
        -3241,
        2505,
        -3237,
        2510,
        -3233,
        2515,
        -3229,
        2520,
        -3225,
        2525,
        -3221,
        2530,
        -3217,
        2535,
        -3214,
        2540,
        -3210,
        2545,
        -3206,
        2550,
        -3202,
        2555,
        -3198,
        2559,
        -3194,
        2564,
        -3190,
        2569,
        -3186,
        2574,
        -3182,
        2579,
        -3178,
        2584,
        -3174,
        2589,
        -3170,
        2594,
        -3166,
        2598,
        -3162,
        2603,
        -3158,
        2608,
        -3154,
        2613,
        -3150,
        2618,
        -3146,
        2623,
        -3142,
        2628,
        -3138,
        2632,
        -3134,
        2637,
        -3130,
        2642,
        -3126,
        2647,
        -3122,
        2652,
        -3118,
        2656,
        -3114,
        2661,
        -3110,
        2666,
        -3106,
        2671,
        -3102,
        2675,
        -3097,
        2680,
        -3093,
        2685,
        -3089,
        2690,
        -3085,
        2694,
        -3081,
        2699,
        -3077,
        2704,
        -3073,
        2709,
        -3068,
        2713,
        -3064,
        2718,
        -3060,
        2723,
        -3056,
        2727,
        -3052,
        2732,
        -3048,
        2737,
        -3043,
        2741,
        -3039,
        2746,
        -3035,
        2751,
        -3031,
        2755,
        -3026,
        2760,
        -3022,
        2765,
        -3018,
        2769,
        -3014,
        2774,
        -3009,
        2779,
        -3005,
        2783,
        -3001,
        2788,
        -2997,
        2792,
        -2992,
        2797,
        -2988,
        2802,
        -2984,
        2806,
        -2979,
        2811,
        -2975,
        2815,
        -2971,
        2820,
        -2967,
        2824,
        -2962,
        2829,
        -2958,
        2833,
        -2953,
        2838,
        -2949,
        2843,
        -2945,
        2847,
        -2940,
        2852,
        -2936,
        2856,
        -2932,
        2861,
        -2927,
        2865,
        -2923,
        2870,
        -2918,
        2874,
        -2914,
        2878,
        -2910,
        2883,
        -2905,
        2887,
        -2901,
        2892,
        -2896,
        2896,
        -2892,
        2901,
        -2887,
        2905,
        -2883,
        2910,
        -2878,
        2914,
        -2874,
        2918,
        -2870,
        2923,
        -2865,
        2927,
        -2861,
        2932,
        -2856,
        2936,
        -2852,
        2940,
        -2847,
        2945,
        -2843,
        2949,
        -2838,
        2953,
        -2833,
        2958,
        -2829,
        2962,
        -2824,
        2967,
        -2820,
        2971,
        -2815,
        2975,
        -2811,
        2979,
        -2806,
        2984,
        -2802,
        2988,
        -2797,
        2992,
        -2792,
        2997,
        -2788,
        3001,
        -2783,
        3005,
        -2779,
        3009,
        -2774,
        3014,
        -2769,
        3018,
        -2765,
        3022,
        -2760,
        3026,
        -2755,
        3031,
        -2751,
        3035,
        -2746,
        3039,
        -2741,
        3043,
        -2737,
        3048,
        -2732,
        3052,
        -2727,
        3056,
        -2723,
        3060,
        -2718,
        3064,
        -2713,
        3068,
        -2709,
        3073,
        -2704,
        3077,
        -2699,
        3081,
        -2694,
        3085,
        -2690,
        3089,
        -2685,
        3093,
        -2680,
        3097,
        -2675,
        3102,
        -2671,
        3106,
        -2666,
        3110,
        -2661,
        3114,
        -2656,
        3118,
        -2652,
        3122,
        -2647,
        3126,
        -2642,
        3130,
        -2637,
        3134,
        -2632,
        3138,
        -2628,
        3142,
        -2623,
        3146,
        -2618,
        3150,
        -2613,
        3154,
        -2608,
        3158,
        -2603,
        3162,
        -2598,
        3166,
        -2594,
        3170,
        -2589,
        3174,
        -2584,
        3178,
        -2579,
        3182,
        -2574,
        3186,
        -2569,
        3190,
        -2564,
        3194,
        -2559,
        3198,
        -2555,
        3202,
        -2550,
        3206,
        -2545,
        3210,
        -2540,
        3214,
        -2535,
        3217,
        -2530,
        3221,
        -2525,
        3225,
        -2520,
        3229,
        -2515,
        3233,
        -2510,
        3237,
        -2505,
        3241,
        -2500,
        3244,
        -2495,
        3248,
        -2490,
        3252,
        -2485,
        3256,
        -2480,
        3260,
        -2475,
        3264,
        -2470,
        3267,
        -2465,
        3271,
        -2460,
        3275,
        -2455,
        3279,
        -2450,
        3282,
        -2445,
        3286,
        -2440,
        3290,
        -2435,
        3294,
        -2430,
        3297,
        -2425,
        3301,
        -2420,
        3305,
        -2415,
        3309,
        -2410,
        3312,
        -2405,
        3316,
        -2399,
        3320,
        -2394,
        3323,
        -2389,
        3327,
        -2384,
        3331,
        -2379,
        3334,
        -2374,
        3338,
        -2369,
        3342,
        -2364,
        3345,
        -2359,
        3349,
        -2353,
        3352,
        -2348,
        3356,
        -2343,
        3360,
        -2338,
        3363,
        -2333,
        3367,
        -2328,
        3370,
        -2322,
        3374,
        -2317,
        3378,
        -2312,
        3381,
        -2307,
        3385,
        -2302,
        3388,
        -2296,
        3392,
        -2291,
        3395,
        -2286,
        3399,
        -2281,
        3402,
        -2276,
        3406,
        -2270,
        3409,
        -2265,
        3413,
        -2260,
        3416,
        -2255,
        3420,
        -2249,
        3423,
        -2244,
        3426,
        -2239,
        3430,
        -2234,
        3433,
        -2228,
        3437,
        -2223,
        3440,
        -2218,
        3444,
        -2213,
        3447,
        -2207,
        3450,
        -2202,
        3454,
        -2197,
        3457,
        -2191,
        3461,
        -2186,
        3464,
        -2181,
        3467,
        -2175,
        3471,
        -2170,
        3474,
        -2165,
        3477,
        -2159,
        3481,
        -2154,
        3484,
        -2149,
        3487,
        -2143,
        3490,
        -2138,
        3494,
        -2133,
        3497,
        -2127,
        3500,
        -2122,
        3504,
        -2117,
        3507,
        -2111,
        3510,
        -2106,
        3513,
        -2100,
        3516,
        -2095,
        3520,
        -2090,
        3523,
        -2084,
        3526,
        -2079,
        3529,
        -2073,
        3532,
        -2068,
        3536,
        -2062,
        3539,
        -2057,
        3542,
        -2052,
        3545,
        -2046,
        3548,
        -2041,
        3551,
        -2035,
        3555,
        -2030,
        3558,
        -2024,
        3561,
        -2019,
        3564,
        -2013,
        3567,
        -2008,
        3570,
        -2002,
        3573,
        -1997,
        3576,
        -1992,
        3579,
        -1986,
        3582,
        -1981,
        3585,
        -1975,
        3588,
        -1970,
        3591,
        -1964,
        3594,
        -1958,
        3597,
        -1953,
        3600,
        -1947,
        3603,
        -1942,
        3606,
        -1936,
        3609,
        -1931,
        3612,
        -1925,
        3615,
        -1920,
        3618,
        -1914,
        3621,
        -1909,
        3624,
        -1903,
        3627,
        -1898,
        3630,
        -1892,
        3633,
        -1886,
        3636,
        -1881,
        3639,
        -1875,
        3642,
        -1870,
        3644,
        -1864,
        3647,
        -1858,
        3650,
        -1853,
        3653,
        -1847,
        3656,
        -1842,
        3659,
        -1836,
        3661,
        -1830,
        3664,
        -1825,
        3667,
        -1819,
        3670,
        -1813,
        3673,
        -1808,
        3675,
        -1802,
        3678,
        -1797,
        3681,
        -1791,
        3684,
        -1785,
        3686,
        -1780,
        3689,
        -1774,
        3692,
        -1768,
        3695,
        -1763,
        3697,
        -1757,
        3700,
        -1751,
        3703,
        -1746,
        3705,
        -1740,
        3708,
        -1734,
        3711,
        -1729,
        3713,
        -1723,
        3716,
        -1717,
        3719,
        -1711,
        3721,
        -1706,
        3724,
        -1700,
        3727,
        -1694,
        3729,
        -1689,
        3732,
        -1683,
        3734,
        -1677,
        3737,
        -1671,
        3739,
        -1666,
        3742,
        -1660,
        3745,
        -1654,
        3747,
        -1648,
        3750,
        -1643,
        3752,
        -1637,
        3755,
        -1631,
        3757,
        -1625,
        3760,
        -1620,
        3762,
        -1614,
        3765,
        -1608,
        3767,
        -1602,
        3770,
        -1596,
        3772,
        -1591,
        3775,
        -1585,
        3777,
        -1579,
        3779,
        -1573,
        3782,
        -1567,
        3784,
        -1562,
        3787,
        -1556,
        3789,
        -1550,
        3791,
        -1544,
        3794,
        -1538,
        3796,
        -1533,
        3798,
        -1527,
        3801,
        -1521,
        3803,
        -1515,
        3805,
        -1509,
        3808,
        -1503,
        3810,
        -1498,
        3812,
        -1492,
        3815,
        -1486,
        3817,
        -1480,
        3819,
        -1474,
        3822,
        -1468,
        3824,
        -1462,
        3826,
        -1457,
        3828,
        -1451,
        3831,
        -1445,
        3833,
        -1439,
        3835,
        -1433,
        3837,
        -1427,
        3839,
        -1421,
        3842,
        -1415,
        3844,
        -1409,
        3846,
        -1404,
        3848,
        -1398,
        3850,
        -1392,
        3852,
        -1386,
        3854,
        -1380,
        3857,
        -1374,
        3859,
        -1368,
        3861,
        -1362,
        3863,
        -1356,
        3865,
        -1350,
        3867,
        -1344,
        3869,
        -1338,
        3871,
        -1332,
        3873,
        -1327,
        3875,
        -1321,
        3877,
        -1315,
        3879,
        -1309,
        3881,
        -1303,
        3883,
        -1297,
        3885,
        -1291,
        3887,
        -1285,
        3889,
        -1279,
        3891,
        -1273,
        3893,
        -1267,
        3895,
        -1261,
        3897,
        -1255,
        3899,
        -1249,
        3901,
        -1243,
        3903,
        -1237,
        3905,
        -1231,
        3907,
        -1225,
        3909,
        -1219,
        3910,
        -1213,
        3912,
        -1207,
        3914,
        -1201,
        3916,
        -1195,
        3918,
        -1189,
        3920,
        -1183,
        3921,
        -1177,
        3923,
        -1171,
        3925,
        -1165,
        3927,
        -1159,
        3929,
        -1153,
        3930,
        -1147,
        3932,
        -1141,
        3934,
        -1135,
        3936,
        -1129,
        3937,
        -1123,
        3939,
        -1117,
        3941,
        -1111,
        3943,
        -1105,
        3944,
        -1099,
        3946,
        -1092,
        3948,
        -1086,
        3949,
        -1080,
        3951,
        -1074,
        3953,
        -1068,
        3954,
        -1062,
        3956,
        -1056,
        3958,
        -1050,
        3959,
        -1044,
        3961,
        -1038,
        3962,
        -1032,
        3964,
        -1026,
        3965,
        -1020,
        3967,
        -1014,
        3969,
        -1007,
        3970,
        -1001,
        3972,
        -995,
        3973,
        -989,
        3975,
        -983,
        3976,
        -977,
        3978,
        -971,
        3979,
        -965,
        3981,
        -959,
        3982,
        -953,
        3984,
        -946,
        3985,
        -940,
        3987,
        -934,
        3988,
        -928,
        3989,
        -922,
        3991,
        -916,
        3992,
        -910,
        3994,
        -904,
        3995,
        -897,
        3996,
        -891,
        3998,
        -885,
        3999,
        -879,
        4001,
        -873,
        4002,
        -867,
        4003,
        -861,
        4005,
        -854,
        4006,
        -848,
        4007,
        -842,
        4008,
        -836,
        4010,
        -830,
        4011,
        -824,
        4012,
        -818,
        4014,
        -811,
        4015,
        -805,
        4016,
        -799,
        4017,
        -793,
        4019,
        -787,
        4020,
        -781,
        4021,
        -774,
        4022,
        -768,
        4023,
        -762,
        4024,
        -756,
        4026,
        -750,
        4027,
        -744,
        4028,
        -737,
        4029,
        -731,
        4030,
        -725,
        4031,
        -719,
        4032,
        -713,
        4034,
        -706,
        4035,
        -700,
        4036,
        -694,
        4037,
        -688,
        4038,
        -682,
        4039,
        -675,
        4040,
        -669,
        4041,
        -663,
        4042,
        -657,
        4043,
        -651,
        4044,
        -644,
        4045,
        -638,
        4046,
        -632,
        4047,
        -626,
        4048,
        -620,
        4049,
        -613,
        4050,
        -607,
        4051,
        -601,
        4052,
        -595,
        4053,
        -589,
        4053,
        -582,
        4054,
        -576,
        4055,
        -570,
        4056,
        -564,
        4057,
        -557,
        4058,
        -551,
        4059,
        -545,
        4060,
        -539,
        4060,
        -533,
        4061,
        -526,
        4062,
        -520,
        4063,
        -514,
        4064,
        -508,
        4064,
        -501,
        4065,
        -495,
        4066,
        -489,
        4067,
        -483,
        4067,
        -476,
        4068,
        -470,
        4069,
        -464,
        4070,
        -458,
        4070,
        -451,
        4071,
        -445,
        4072,
        -439,
        4072,
        -433,
        4073,
        -426,
        4074,
        -420,
        4074,
        -414,
        4075,
        -408,
        4076,
        -401,
        4076,
        -395,
        4077,
        -389,
        4077,
        -383,
        4078,
        -376,
        4079,
        -370,
        4079,
        -364,
        4080,
        -358,
        4080,
        -351,
        4081,
        -345,
        4081,
        -339,
        4082,
        -333,
        4082,
        -326,
        4083,
        -320,
        4083,
        -314,
        4084,
        -308,
        4084,
        -301,
        4085,
        -295,
        4085,
        -289,
        4086,
        -283,
        4086,
        -276,
        4087,
        -270,
        4087,
        -264,
        4088,
        -257,
        4088,
        -251,
        4088,
        -245,
        4089,
        -239,
        4089,
        -232,
        4089,
        -226,
        4090,
        -220,
        4090,
        -214,
        4090,
        -207,
        4091,
        -201,
        4091,
        -195,
        4091,
        -188,
        4092,
        -182,
        4092,
        -176,
        4092,
        -170,
        4092,
        -163,
        4093,
        -157,
        4093,
        -151,
        4093,
        -144,
        4093,
        -138,
        4094,
        -132,
        4094,
        -126,
        4094,
        -119,
        4094,
        -113,
        4094,
        -107,
        4095,
        -101,
        4095,
        -94,
        4095,
        -88,
        4095,
        -82,
        4095,
        -75,
        4095,
        -69,
        4095,
        -63,
        4096,
        -57,
        4096,
        -50,
        4096,
        -44,
        4096,
        -38,
        4096,
        -31,
        4096,
        -25,
        4096,
        -19,
        4096,
        -13,
        4096,
        -6,
        4096
    };

    public static short[] DAT_69C90 = new short[]
    {
        0,
        1,
        2,
        2,
        3,
        3,
        4,
        5,
        5,
        6,
        7,
        7,
        8,
        9,
        9,
        10,
        10,
        11,
        12,
        12,
        13,
        14,
        14,
        15,
        16,
        16,
        17,
        17,
        18,
        19,
        19,
        20,
        21,
        21,
        22,
        23,
        23,
        24,
        24,
        25,
        26,
        26,
        27,
        28,
        28,
        29,
        30,
        30,
        31,
        31,
        32,
        33,
        33,
        34,
        35,
        35,
        36,
        36,
        37,
        38,
        38,
        39,
        40,
        40,
        41,
        42,
        42,
        43,
        43,
        44,
        45,
        45,
        46,
        47,
        47,
        48,
        49,
        49,
        50,
        50,
        51,
        52,
        52,
        53,
        54,
        54,
        55,
        55,
        56,
        57,
        57,
        58,
        59,
        59,
        60,
        61,
        61,
        62,
        62,
        63,
        64,
        64,
        65,
        66,
        66,
        67,
        67,
        68,
        69,
        69,
        70,
        71,
        71,
        72,
        73,
        73,
        74,
        74,
        75,
        76,
        76,
        77,
        78,
        78,
        79,
        79,
        80,
        81,
        81,
        82,
        83,
        83,
        84,
        84,
        85,
        86,
        86,
        87,
        88,
        88,
        89,
        89,
        90,
        91,
        91,
        92,
        93,
        93,
        94,
        94,
        95,
        96,
        96,
        97,
        98,
        98,
        99,
        99,
        100,
        101,
        101,
        102,
        103,
        103,
        104,
        104,
        105,
        106,
        106,
        107,
        107,
        108,
        109,
        109,
        110,
        111,
        111,
        112,
        112,
        113,
        114,
        114,
        115,
        116,
        116,
        117,
        117,
        118,
        119,
        119,
        120,
        120,
        121,
        122,
        122,
        123,
        124,
        124,
        125,
        125,
        126,
        127,
        127,
        128,
        128,
        129,
        130,
        130,
        131,
        131,
        132,
        133,
        133,
        134,
        135,
        135,
        136,
        136,
        137,
        138,
        138,
        139,
        139,
        140,
        141,
        141,
        142,
        142,
        143,
        144,
        144,
        145,
        145,
        146,
        147,
        147,
        148,
        148,
        149,
        150,
        150,
        151,
        152,
        152,
        153,
        153,
        154,
        155,
        155,
        156,
        156,
        157,
        158,
        158,
        159,
        159,
        160,
        161,
        161,
        162,
        162,
        163,
        164,
        164,
        165,
        165,
        166,
        166,
        167,
        168,
        168,
        169,
        169,
        170,
        171,
        171,
        172,
        172,
        173,
        174,
        174,
        175,
        175,
        176,
        177,
        177,
        178,
        178,
        179,
        180,
        180,
        181,
        181,
        182,
        182,
        183,
        184,
        184,
        185,
        185,
        186,
        187,
        187,
        188,
        188,
        189,
        190,
        190,
        191,
        191,
        192,
        192,
        193,
        194,
        194,
        195,
        195,
        196,
        197,
        197,
        198,
        198,
        199,
        199,
        200,
        201,
        201,
        202,
        202,
        203,
        203,
        204,
        205,
        205,
        206,
        206,
        207,
        207,
        208,
        209,
        209,
        210,
        210,
        211,
        211,
        212,
        213,
        213,
        214,
        214,
        215,
        215,
        216,
        217,
        217,
        218,
        218,
        219,
        219,
        220,
        221,
        221,
        222,
        222,
        223,
        223,
        224,
        225,
        225,
        226,
        226,
        227,
        227,
        228,
        228,
        229,
        230,
        230,
        231,
        231,
        232,
        232,
        233,
        234,
        234,
        235,
        235,
        236,
        236,
        237,
        237,
        238,
        239,
        239,
        240,
        240,
        241,
        241,
        242,
        242,
        243,
        244,
        244,
        245,
        245,
        246,
        246,
        247,
        247,
        248,
        248,
        249,
        250,
        250,
        251,
        251,
        252,
        252,
        253,
        253,
        254,
        254,
        255,
        256,
        256,
        257,
        257,
        258,
        258,
        259,
        259,
        260,
        260,
        261,
        262,
        262,
        263,
        263,
        264,
        264,
        265,
        265,
        266,
        266,
        267,
        267,
        268,
        269,
        269,
        270,
        270,
        271,
        271,
        272,
        272,
        273,
        273,
        274,
        274,
        275,
        275,
        276,
        276,
        277,
        278,
        278,
        279,
        279,
        280,
        280,
        281,
        281,
        282,
        282,
        283,
        283,
        284,
        284,
        285,
        285,
        286,
        286,
        287,
        288,
        288,
        289,
        289,
        290,
        290,
        291,
        291,
        292,
        292,
        293,
        293,
        294,
        294,
        295,
        295,
        296,
        296,
        297,
        297,
        298,
        298,
        299,
        299,
        300,
        300,
        301,
        301,
        302,
        302,
        303,
        303,
        304,
        304,
        305,
        305,
        306,
        307,
        307,
        308,
        308,
        309,
        309,
        310,
        310,
        311,
        311,
        312,
        312,
        313,
        313,
        314,
        314,
        315,
        315,
        316,
        316,
        317,
        317,
        318,
        318,
        319,
        319,
        320,
        320,
        321,
        321,
        322,
        322,
        322,
        323,
        323,
        324,
        324,
        325,
        325,
        326,
        326,
        327,
        327,
        328,
        328,
        329,
        329,
        330,
        330,
        331,
        331,
        332,
        332,
        333,
        333,
        334,
        334,
        335,
        335,
        336,
        336,
        337,
        337,
        338,
        338,
        339,
        339,
        340,
        340,
        340,
        341,
        341,
        342,
        342,
        343,
        343,
        344,
        344,
        345,
        345,
        346,
        346,
        347,
        347,
        348,
        348,
        349,
        349,
        349,
        350,
        350,
        351,
        351,
        352,
        352,
        353,
        353,
        354,
        354,
        355,
        355,
        356,
        356,
        356,
        357,
        357,
        358,
        358,
        359,
        359,
        360,
        360,
        361,
        361,
        362,
        362,
        362,
        363,
        363,
        364,
        364,
        365,
        365,
        366,
        366,
        367,
        367,
        368,
        368,
        368,
        369,
        369,
        370,
        370,
        371,
        371,
        372,
        372,
        372,
        373,
        373,
        374,
        374,
        375,
        375,
        376,
        376,
        377,
        377,
        377,
        378,
        378,
        379,
        379,
        380,
        380,
        381,
        381,
        381,
        382,
        382,
        383,
        383,
        384,
        384,
        385,
        385,
        385,
        386,
        386,
        387,
        387,
        388,
        388,
        388,
        389,
        389,
        390,
        390,
        391,
        391,
        391,
        392,
        392,
        393,
        393,
        394,
        394,
        395,
        395,
        395,
        396,
        396,
        397,
        397,
        398,
        398,
        398,
        399,
        399,
        400,
        400,
        401,
        401,
        401,
        402,
        402,
        403,
        403,
        403,
        404,
        404,
        405,
        405,
        406,
        406,
        406,
        407,
        407,
        408,
        408,
        409,
        409,
        409,
        410,
        410,
        411,
        411,
        411,
        412,
        412,
        413,
        413,
        413,
        414,
        414,
        415,
        415,
        416,
        416,
        416,
        417,
        417,
        418,
        418,
        418,
        419,
        419,
        420,
        420,
        420,
        421,
        421,
        422,
        422,
        422,
        423,
        423,
        424,
        424,
        425,
        425,
        425,
        426,
        426,
        427,
        427,
        427,
        428,
        428,
        429,
        429,
        429,
        430,
        430,
        431,
        431,
        431,
        432,
        432,
        432,
        433,
        433,
        434,
        434,
        434,
        435,
        435,
        436,
        436,
        436,
        437,
        437,
        438,
        438,
        438,
        439,
        439,
        440,
        440,
        440,
        441,
        441,
        441,
        442,
        442,
        443,
        443,
        443,
        444,
        444,
        445,
        445,
        445,
        446,
        446,
        446,
        447,
        447,
        448,
        448,
        448,
        449,
        449,
        450,
        450,
        450,
        451,
        451,
        451,
        452,
        452,
        453,
        453,
        453,
        454,
        454,
        454,
        455,
        455,
        456,
        456,
        456,
        457,
        457,
        457,
        458,
        458,
        459,
        459,
        459,
        460,
        460,
        460,
        461,
        461,
        461,
        462,
        462,
        463,
        463,
        463,
        464,
        464,
        464,
        465,
        465,
        465,
        466,
        466,
        467,
        467,
        467,
        468,
        468,
        468,
        469,
        469,
        469,
        470,
        470,
        471,
        471,
        471,
        472,
        472,
        472,
        473,
        473,
        473,
        474,
        474,
        474,
        475,
        475,
        476,
        476,
        476,
        477,
        477,
        477,
        478,
        478,
        478,
        479,
        479,
        479,
        480,
        480,
        480,
        481,
        481,
        481,
        482,
        482,
        483,
        483,
        483,
        484,
        484,
        484,
        485,
        485,
        485,
        486,
        486,
        486,
        487,
        487,
        487,
        488,
        488,
        488,
        489,
        489,
        489,
        490,
        490,
        490,
        491,
        491,
        491,
        492,
        492,
        492,
        493,
        493,
        493,
        494,
        494,
        494,
        495,
        495,
        495,
        496,
        496,
        496,
        497,
        497,
        497,
        498,
        498,
        498,
        499,
        499,
        499,
        500,
        500,
        500,
        501,
        501,
        501,
        502,
        502,
        502,
        503,
        503,
        503,
        504,
        504,
        504,
        505,
        505,
        505,
        506,
        506,
        506,
        507,
        507,
        507,
        508,
        508,
        508,
        509,
        509,
        509,
        510,
        510,
        510,
        511,
        511,
        511,
        511,
        512,
        512
    };

    public static uint[,] DAT_637DC = new uint[,]
    {
        {
            0u,
            0u,
            2824221714u,
            1193984u,
            2824221714u,
            2824221714u
        },
        {
            0u,
            0u,
            2824221714u,
            1193984u,
            2824221714u,
            2824221714u
        }
    };

    public static uint[,] DAT_637E0 = new uint[,]
    {
        {
            0u,
            0u,
            3116896263u,
            4096u,
            3116896263u,
            3116899591u
        },
        {
            0u,
            0u,
            3116896263u,
            4096u,
            3116896263u,
            3116899591u
        }
    };

    public static Vector3Int[] DAT_63970 = new Vector3Int[]
    {
        new Vector3Int(-2048, -1472, 0),
        new Vector3Int(2048, -1472, 0),
        new Vector3Int(6144, -1472, 0),
        new Vector3Int(-2048, 0, 0),
        new Vector3Int(2048, 0, 0),
        new Vector3Int(6144, 0, 0)
    };

    public static byte[] DAT_639A0 = new byte[]
    {
        0,
        4,
        1,
        4,
        2,
        4,
        3,
        4,
        0,
        1,
        0,
        2,
        1,
        3,
        2,
        3
    };

    public static uint[] DAT_639EC = new uint[]
    {
        4983104u,
        21258u,
        4655744u,
        21262u,
        4655424u,
        483668u,
        25891136u,
        21194u,
        76500u,
        809090u,
        4655424u,
        25647444u,
        4655424u,
        25647444u,
        4653780u,
        23310u,
        4655424u,
        25647444u,
        25901124u,
        741440u,
        4655424u,
        25647444u,
        21322200u,
        469120u,
        4655424u,
        25647444u,
        4655424u,
        25647444u,
        4655424u,
        25647444u
    };

    public static uint DAT_63A64 = 826366246u;

    public static uint DAT_63A68 = 0u;

    public static uint[] DAT_63A6C = new uint[]
    {
        33554432u,
        67108864u,
        134217728u,
        268435456u
    };

    public static byte[] DAT_63A7C = new byte[]
    {
        90,
        89,
        91,
        91
    };

    public static ushort[] specialLimit = new ushort[]
    {
        50,
        6,
        3,
        3,
        3,
        3,
        3,
        3,
        50,
        2,
        2,
        3,
        3,
        3,
        2,
        3,
        3,
        3
    };

    public static short[] DAT_63F58 = new short[]
    {
        16,
        17,
        18,
        19
    };

    public static byte[] DAT_63F60 = new byte[]
    {
        0,
        0,
        0,
        0,
        1,
        1,
        2,
        3
    };

    public static ushort[] DAT_63F68 = new ushort[]
    {
        2048,
        0,
        2048,
        819,
        655
    };

    public static ushort[] DAT_63F74 = new ushort[]
    {
        0,
        0,
        0,
        0,
        0,
        0,
        56,
        72,
        56,
        72,
        56,
        72,
        63,
        70,
        59,
        77,
        63,
        70,
        67,
        81,
        65,
        75,
        65,
        75
    };

    public static short[] DAT_63FA4 = new short[]
    {
        9,
        3,
        4,
        2,
        0,
        7,
        8,
        12,
        10,
        11,
        14,
        13,
        15,
        6,
        20,
        21,
        22,
        23
    };

    public static int[] DAT_63FC8 = new int[]
    {
        211,
        212,
        213
    };

    public static short[] DAT_63FE4 = new short[]
    {
        39,
        -1,
        33,
        29,
        35,
        13,
        33,
        35,
        -1,
        -1,
        -1,
        36,
        -1,
        -1,
        -1,
        -1,
        37,
        38,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        42,
        44,
        43,
        45,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        13,
        20,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        138,
        136,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        29,
        25,
        31,
        27
    };

    public static short[] DAT_6405C = new short[]
    {
        116,
        123,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        49,
        48,
        50,
        47,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1
    };

    public static short[] DAT_64084 = new short[]
    {
        53,
        55,
        57,
        53,
        -1,
        -1,
        -1,
        -1,
        59,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        -1,
        79,
        81
    };

    public static int[] DAT_640C8 = new int[]
    {
        24,
        12,
        8,
        0
    };

    public static Color32[] DAT_640AC = new Color32[]
    {
        new Color32(128, 128, 128, 8),
        new Color32(128, 128, 0, 8),
        new Color32(180, 128, 80, 8),
        new Color32(128, 0, 0, 8),
        new Color32(128, 0, 128, 8),
        new Color32(30, 128, 200, 8),
        new Color32(0, 128, 0, 8)
    };

    public static VehicleData[] vehicleConfigs = new VehicleData[]
    {
        new VehicleData
        {
            DAT_00 = new short[]
            {
                16,
                12,
                48,
                152,
                64,
                128
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Wonderwagon,
            DAT_0E = 16,
            DAT_0F = -6,
            DAT_10 = 22,
            DAT_11 = 38,
            DAT_12 = 67,
            DAT_13 = 112,
            DAT_14 = 136,
            DAT_15 = 28,
            DAT_16 = 19,
            maxHalfHealth = 683,
            DAT_1A = 983,
            lightness = 5103,
            DAT_20 = 4447,
            peelout = 5,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 6144,
            DAT_2C = new byte[]
            {
                174,
                88,
                43,
                155
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                4,
                8,
                48,
                56,
                92,
                92
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Thunderbolt,
            DAT_0E = 18,
            DAT_0F = -2,
            DAT_10 = 19,
            DAT_11 = 32,
            DAT_12 = 57,
            DAT_13 = 148,
            DAT_14 = 200,
            DAT_15 = 50,
            DAT_16 = 36,
            maxHalfHealth = 903,
            DAT_1A = 1203,
            lightness = 4206,
            DAT_20 = 3112,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 10649,
            DAT_2C = new byte[]
            {
                200,
                172,
                91,
                52
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                156,
                156,
                255,
                255
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.DakotaCycle,
            DAT_0E = 40,
            DAT_0F = -2,
            DAT_10 = 25,
            DAT_11 = 32,
            DAT_12 = 64,
            DAT_13 = 112,
            DAT_14 = 128,
            DAT_15 = 24,
            DAT_16 = 16,
            maxHalfHealth = 1200,
            DAT_1A = 1800,
            lightness = 4323,
            DAT_20 = 3750,
            peelout = 7,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 2048,
            DAT_2C = new byte[]
            {
                168,
                102,
                25,
                174
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                8,
                8,
                64,
                64,
                92,
                92
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.SamsonTow,
            DAT_0E = 9,
            DAT_0F = -2,
            DAT_10 = 48,
            DAT_11 = 67,
            DAT_12 = 131,
            DAT_13 = 44,
            DAT_14 = 52,
            DAT_15 = 49,
            DAT_16 = 35,
            maxHalfHealth = 1069,
            DAT_1A = 1369,
            lightness = 3705,
            DAT_20 = 3112,
            peelout = 1,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 12902,
            DAT_2C = new byte[]
            {
                155,
                102,
                128,
                55
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                24,
                28,
                40,
                40,
                32,
                32,
                1039
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Livingston,
            DAT_0E = 4,
            DAT_0F = -1,
            DAT_10 = 57,
            DAT_11 = 73,
            DAT_12 = 147,
            DAT_13 = 20,
            DAT_14 = 24,
            DAT_15 = 50,
            DAT_16 = 39,
            maxHalfHealth = 1400,
            DAT_1A = 1700,
            lightness = 2061,
            DAT_20 = 1729,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 18432,
            DAT_2C = new byte[]
            {
                25,
                74,
                200,
                31
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                40,
                40,
                92,
                40
            },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Xanadu,
            DAT_0E = 1,
            DAT_0F = 0,
            DAT_10 = 32,
            DAT_11 = 38,
            DAT_12 = 70,
            DAT_13 = 34,
            DAT_14 = 40,
            DAT_15 = 40,
            DAT_16 = 33,
            maxHalfHealth = 1179,
            DAT_1A = 1479,
            lightness = 1541,
            DAT_20 = 1297,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 14336,
            DAT_2C = new byte[]
            {
                57,
                88,
                152,
                71
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                28,
                28,
                16,
                28
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Palomino,
            DAT_0E = 6,
            DAT_0F = -2,
            DAT_10 = 41,
            DAT_11 = 67,
            DAT_12 = 124,
            DAT_13 = 58,
            DAT_14 = 72,
            DAT_15 = 54,
            DAT_16 = 38,
            maxHalfHealth = 1014,
            DAT_1A = 1314,
            lightness = 3537,
            DAT_20 = 2829,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 12288,
            DAT_2C = new byte[]
            {
                181,
                158,
                116,
                36
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                20,
                40,
                56,
                64,
                128,
                96
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.ElGuerrero,
            DAT_0E = 8,
            DAT_0F = -3,
            DAT_10 = 22,
            DAT_11 = 35,
            DAT_12 = 67,
            DAT_13 = 101,
            DAT_14 = 120,
            DAT_15 = 47,
            DAT_16 = 33,
            maxHalfHealth = 959,
            DAT_1A = 1259,
            lightness = 3940,
            DAT_20 = 3311,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 11264,
            DAT_2C = new byte[]
            {
                168,
                130,
                103,
                68
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                32,
                32,
                40,
                40,
                48,
                48,
                2051
            },
            DAT_0C = 3,
            vehicleID = _VEHICLE.BlueBurro,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 28,
            DAT_11 = 38,
            DAT_12 = 80,
            DAT_13 = 34,
            DAT_14 = 40,
            DAT_15 = 37,
            DAT_16 = 35,
            maxHalfHealth = 1290,
            DAT_1A = 1590,
            lightness = 1945,
            DAT_20 = 1638,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 16384,
            DAT_2C = new byte[]
            {
                64,
                46,
                176,
                56
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                20,
                20,
                64,
                64,
                128,
                128
            },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Excelsior,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 22,
            DAT_11 = 35,
            DAT_12 = 64,
            DAT_13 = 72,
            DAT_14 = 96,
            DAT_15 = 48,
            DAT_16 = 38,
            maxHalfHealth = 1124,
            DAT_1A = 1424,
            lightness = 2754,
            DAT_20 = 2075,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 13516,
            DAT_2C = new byte[]
            {
                135,
                130,
                140,
                37
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                72,
                96,
                96,
                160
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Tsunami,
            DAT_0E = 12,
            DAT_0F = -2,
            DAT_10 = 22,
            DAT_11 = 54,
            DAT_12 = 99,
            DAT_13 = 186,
            DAT_14 = byte.MaxValue,
            DAT_15 = 37,
            DAT_16 = 26,
            maxHalfHealth = 628,
            DAT_1A = 928,
            lightness = 3705,
            DAT_20 = 2706,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 3072,
            DAT_2C = new byte[]
            {
                200,
                200,
                31,
                114
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                36,
                36,
                90,
                90,
                200,
                200
            },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Marathon,
            DAT_0E = 8,
            DAT_0F = -4,
            DAT_10 = 6,
            DAT_11 = 12,
            DAT_12 = 25,
            DAT_13 = 191,
            DAT_14 = byte.MaxValue,
            DAT_15 = 18,
            DAT_16 = 12,
            maxHalfHealth = 655,
            DAT_1A = 955,
            lightness = 3176,
            DAT_20 = 1434,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 4096,
            DAT_2C = new byte[]
            {
                109,
                60,
                37,
                200
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                24,
                32,
                72,
                72,
                3327
            },
            DAT_0C = byte.MaxValue,
            vehicleID = _VEHICLE.Trekker,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 38,
            DAT_11 = 60,
            DAT_12 = 115,
            DAT_13 = 58,
            DAT_14 = 72,
            DAT_15 = 20,
            DAT_16 = 19,
            maxHalfHealth = 793,
            DAT_1A = 1093,
            lightness = 5764,
            DAT_20 = 4577,
            peelout = 7,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 9830,
            DAT_2C = new byte[]
            {
                161,
                32,
                67,
                154
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                24,
                28,
                32,
                32,
                16,
                16,
                3331
            },
            DAT_0C = 3,
            vehicleID = _VEHICLE.Loader,
            DAT_0E = 0,
            DAT_0F = 0,
            DAT_10 = 22,
            DAT_11 = 38,
            DAT_12 = 67,
            DAT_13 = 48,
            DAT_14 = 56,
            DAT_15 = 47,
            DAT_16 = 38,
            maxHalfHealth = 1345,
            DAT_1A = 1645,
            lightness = 2936,
            DAT_20 = 2490,
            peelout = 0,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 17408,
            DAT_2C = new byte[]
            {
                90,
                25,
                188,
                39
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                48,
                44,
                64,
                64,
                200,
                200
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Stinger,
            DAT_0E = 16,
            DAT_0F = -1,
            DAT_10 = 12,
            DAT_11 = 22,
            DAT_12 = 44,
            DAT_13 = 186,
            DAT_14 = byte.MaxValue,
            DAT_15 = 37,
            DAT_16 = 26,
            maxHalfHealth = 710,
            DAT_1A = 1010,
            lightness = 3891,
            DAT_20 = 2829,
            peelout = 4,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 7372,
            DAT_2C = new byte[]
            {
                187,
                165,
                49,
                112
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                48,
                48,
                88,
                88,
                224,
                224
            },
            DAT_0C = 12,
            vehicleID = _VEHICLE.Vertigo,
            DAT_0E = 24,
            DAT_0F = -3,
            DAT_10 = 16,
            DAT_11 = 25,
            DAT_12 = 51,
            DAT_13 = 158,
            DAT_14 = 216,
            DAT_15 = 41,
            DAT_16 = 29,
            maxHalfHealth = 738,
            DAT_1A = 1038,
            lightness = 3705,
            DAT_20 = 2706,
            peelout = 3,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 9216,
            DAT_2C = new byte[]
            {
                194,
                186,
                55,
                93
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                0,
                0,
                72,
                64,
                160,
                200
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Goliath,
            DAT_0E = 6,
            DAT_0F = -1,
            DAT_10 = 48,
            DAT_11 = 67,
            DAT_12 = 131,
            DAT_13 = 49,
            DAT_14 = 56,
            DAT_15 = 56,
            DAT_16 = 40,
            maxHalfHealth = 1234,
            DAT_1A = 1534,
            lightness = 4716,
            DAT_20 = 4096,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 15360,
            DAT_2C = new byte[]
            {
                161,
                60,
                164,
                25
            }
        },
        new VehicleData
        {
            DAT_00 = new short[]
            {
                52,
                52,
                64,
                64,
                128,
                128
            },
            DAT_0C = 15,
            vehicleID = _VEHICLE.Wapiti,
            DAT_0E = 8,
            DAT_0F = -1,
            DAT_10 = 38,
            DAT_11 = 57,
            DAT_12 = 112,
            DAT_13 = 65,
            DAT_14 = 80,
            DAT_15 = 41,
            DAT_16 = 29,
            maxHalfHealth = 848,
            DAT_1A = 1148,
            lightness = 4511,
            DAT_20 = 3662,
            peelout = 2,
            DAT_24 = new Vector3Int(64, 64, 64),
            DAT_2A = 10240,
            DAT_2C = new byte[]
            {
                187,
                116,
                79,
                95
            }
        }
    };
    public delegate uint _EVENT_CALL(VigTuple param1, int param2);

    public static Color32[] DAT_1f800000 = new Color32[32];

    public static HitDetection hit;

    public static int DAT_1f800080;

    public static Vector3Int DAT_1f800084;

    public static short DAT_1f800094;

    public static short DAT_1f800096;

    public static short DAT_1f800098;

    public static short DAT_1f80009a;

    public static TerrainScreen[] terrainScreen = new TerrainScreen[40];

    public static AudioSource[] voices = new AudioSource[24];

    public static Matrix3x3 DAT_718 = new Matrix3x3
    {
        V00 = 4096,
        V01 = 0,
        V02 = 0,
        V10 = 0,
        V11 = 0,
        V12 = 0,
        V20 = 0,
        V21 = 0,
        V22 = 0
    };

    public static byte[] DAT_854 = new byte[]
    {
        12,
        32,
        20,
        32,
        12,
        24,
        12,
        24,
        16,
        28,
        12,
        28,
        24,
        24,
        0,
        24
    };

    public static ushort[] DAT_854_2 = new ushort[]
    {
        12,
        20,
        28,
        40,
        20,
        28,
        28,
        40,
        12,
        20,
        20,
        32,
        12,
        16,
        20,
        32,
        16,
        28,
        24,
        40,
        12,
        0,
        24,
        40,
        20,
        32,
        20,
        32,
        0,
        0,
        20,
        32
    };

    public static VigTransform defaultTransform = new VigTransform
    {
        rotation = new Matrix3x3
        {
            V00 = 4096,
            V01 = 0,
            V02 = 0,
            V10 = 0,
            V11 = 4096,
            V12 = 0,
            V20 = 0,
            V21 = 0,
            V22 = 4096
        },
        position = new Vector3Int(0, 0, 0)
    };

    public static Vector3Int DAT_9C4 = new Vector3Int(0, 0, 0);

    public static byte[] DAT_A14 = new byte[]
    {
        0,
        1,
        2,
        3
    };

    public static Vector3Int DAT_A18 = new Vector3Int(0, 0, 196608);

    public static Vector3Int DAT_A24 = new Vector3Int(0, 26624, 0);

    public static Vector3Int DAT_A30 = new Vector3Int(0, 0, -32768);

    public static Vector3Int DAT_A3C = new Vector3Int(0, 0, -131072);

    public static Vector3Int DAT_A4C = new Vector3Int(0, 131072, 0);

    public static Vector3Int DAT_A5C = new Vector3Int(0, -131072, 0);

    public static Vector3Int DAT_A68 = new Vector3Int(0, 32768, 0);

    public static short[] DAT_BC0 = new short[]
    {
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        24,
        25,
        31,
        0,
        10,
        11,
        12,
        13,
        14,
        15,
        16,
        17,
        18,
        19,
        20,
        58,
        63,
        64,
        65,
        66,
        75,
        0,
        75,
        67,
        68,
        71,
        72,
        73,
        74
    };

    public static List<Junction> updateJunc = new List<Junction>();

    public VigTerrain terrain;

    public LevelManager levelManager;

    public VigConfig commonWheelConfiguration;

    public _SCREEN_MODE screenMode;
    public _GAME_MODE gameMode;
    public Vehicle[] playerObjects;

    public VigCamera[] cameraObjects;

    public byte[] vehicles;

    public BSP bspTree;

    public List<VigTuple> worldObjs;

    public List<VigTuple> interObjs;

    public int translateFactor = 10000;

    public int translateFactor2 = 1000;

    public float pixelSnapMin = 0.002f;

    public float pixelSnapMax = 0.998f;

    private NativeArray<Vector2Int> nativeArray;

    private GameManager.TerrainJob terrainJob;

    private JobHandle terrainHandle;

    public Queue<ScreenPoly> DAT_610;

    public bool DAT_83B;

    public byte DAT_C6E;

    public sbyte[] DAT_C80;

    public Color32[] DAT_CE0;

    public ushort[] DAT_CF0;

    public byte[,] DAT_CF4;

    public byte DAT_CF8;

    public byte[] DAT_CFC;

    public byte DAT_D08;

    public int DAT_D0C;

    public byte[] DAT_D18;

    public byte[] DAT_D19;

    public byte[] DAT_D1A;

    public byte[] DAT_D1B;

    public byte[,] DAT_D28;

    public int DAT_DA0;

    public ushort DAT_DA8;

    public int DAT_DB0;

    public short DAT_DB4;

    public short DAT_DB6;

    public short DAT_DB8;

    public VigTransform DAT_F00;

    public int DAT_F20;

    public VigTransform DAT_F28;

    public Matrix3x3 DAT_F48;

    public Matrix3x3 DAT_F68;

    public VigTransform DAT_F88;

    public Matrix3x3 DAT_FA8;

    public Vector2Int DAT_FC8;

    public Matrix3x3 DAT_FD8;

    public short DAT_E1C;

    public VigTransform DAT_EA8;

    public Vector3Int DAT_EC8;

    public int DAT_ED8;

    public int DAT_EDC;

    public VigTransform DAT_EE0;

    public byte DAT_1000;

    public byte DAT_1002;

    public byte DAT_1004;

    public int DAT_101C;

    public int DAT_1028;

    public sbyte[] DAT_1030;

    public sbyte playerSpawns;

    public int DAT_1038;

    public List<VigTuple> DAT_1068;

    public List<VigTuple> DAT_1078;

    public int DAT_1084;

    public List<VigTuple> DAT_1088;

    public List<VigTuple> DAT_1098;

    public List<VigTuple> DAT_10A8;

    public List<VigTuple> DAT_10C8;

    public List<VigTuple2> DAT_10D8;

    public List<VigTuple> DAT_1088_tmp;

    public List<VigTuple> DAT_1110_tmp;

    public List<VigTuple> worldObjs_tmp;

    public int DAT_10F0;

    public List<VigTuple> DAT_1110;

    public sbyte DAT_111C;

    public SunLensFlare DAT_1124;

    public sbyte[] DAT_1128;

    public int DAT_1130;

    public global::Navigation DAT_1138;

    public VigMesh[] DAT_1150;

    public struct VehicleStats
    {
        // Token: 0x04000428 RID: 1064
        public byte accel;

        // Token: 0x04000429 RID: 1065
        public byte speed;

        // Token: 0x0400042A RID: 1066
        public byte armor;

        // Token: 0x0400042B RID: 1067
        public byte avoidance;
    }
    public VehicleStats[] vehicleStats;

    public uint DAT_E44;

    public int DAT_C74;

    public int DAT_CC4;

    public byte DAT_898;

    public List<AudioClip> DAT_C2C;

    public ushort timer;

    public ushort[,] DAT_08;

    public int DAT_20;

    public int DAT_24;

    public int DAT_28;


    public bool gameEnded;

    public bool DAT_36;

    public int gravityFactor;

    public int DAT_40;

    public int map;

    public Material targetHUD;

    public _DITHERING ditheringMethod;

    public bool drawPlayer;

    public bool drawObjects;

    public bool drawTerrain;

    public bool drawRoads;

    public bool playMusic;

    public bool inDebug;

    public bool inMenu;

    public bool autoTarget;

    public bool ready;

    public float max;

    public float terrainHeight;

    public float offsetFactor;

    public float offsetStart;

    public float angleOffset;

    public float aspectRatioScale;

    public Dropdown driverDropdown;

    public Dropdown stageDropdown;

    public Dropdown ditheringDropdown;

    public Dropdown gameModeDropdown;

    public Dropdown mpModeDropdown;

    public Dropdown damageDropdown;

    public Dropdown difficultyDropdown;

    public Dropdown onlineDmgDropdown;

    public Dropdown livesDropdown;

    public Toggle drawPlayerToggle;

    public Toggle drawObjectsToggle;

    public Toggle drawTerrainToggle;

    public Toggle drawRoadsToggle;

    public Toggle[] spawnEnemiesToggle;

    public Toggle disableDpadToggle;

    public Toggle disableAutoTarget;

    public Toggle enableExperimentalDakota;

    public RectTransform spawnsRect;

    public List<int> playable;

    public List<int> survival;

    public int currentSpawn;

    public int wrenchCount;

    public bool lowHealth;

    public int totalSpawns;

    public int aiMin;

    public int aiMax;

    public int spawns;

    public bool paused;

    public bool noAI;

    public bool noPhysics;

    public bool noHUD;

    public bool experimentalDakota;

    public bool enableReticle;

    public Dictionary<long, Vehicle> networkMembers;

    public List<VigObject> networkObjs;

    public Dictionary<long, short> networkIds;

    public List<Vehicle> networkEnemies;

    public Dictionary<short, Vehicle> enemiesDictionary;

    public int leash;

    private bool atStart;

    public struct TerrainJob : IJob
    {
        public void Execute()
        {
            int num = 0;
            int num2 = 0;
            int num3 = this.param1[0].x;
            int i = this.param1[0].y;
            if (i < 0)
            {
                i += 1023;
            }
            int num4 = i >> 10 << 2;
            i = (i >> 10) * 1024;
            int num5 = 0;
            int num6 = num3;
            bool flag = false;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            for (; ; )
            {
                i += 1024;
                int num11 = this.param1[num].y;
                int num12 = num6;
                while (i > num11)
                {
                    num7 = this.param1[num].x;
                    num9 = this.param1[num].y;
                    if (num7 < num12)
                    {
                        num12 = num7;
                    }
                    if (num == 0)
                    {
                        num = this.param2;
                    }
                    num--;
                    num11 = this.param1[num].y;
                    flag = (num11 < num9);
                    if (flag)
                    {
                        break;
                    }
                }
                if (num9 == 0 || num7 == 0)
                {
                    UnityEngine.Debug.Log("!");
                }
                num11 = num3;
                if (this.param1[num5].y >= i)
                {
                    goto IL_1CC;
                }
                int num13 = num2;
                for (; ; )
                {
                    num8 = this.param1[num13].x;
                    num10 = this.param1[num13].y;
                    if (num11 < num8)
                    {
                        num11 = num8;
                    }
                    num5++;
                    num2++;
                    flag = false;
                    if (num2 == this.param2 || this.param1[num13 + 1].y < num10)
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        break;
                    }
                    int index = num13 + 1;
                    num13++;
                    if (this.param1[index].y >= i)
                    {
                        goto IL_1CC;
                    }
                }
            IL_26F:
                int num14 = num11 + 1023;
                if (num12 < 0)
                {
                    num12 += 1023;
                }
                if (num14 < 0)
                {
                    num14 = num11 + 2046;
                }
                VigTerrain.FUN_1BE68(num12 >> 10 << 2, num14 >> 10 << 2, num4);
                num4 += 4;
                if (flag)
                {
                    break;
                }
                continue;
            IL_1CC:
                if (num10 == 0 || num8 == 0)
                {
                    UnityEngine.Debug.Log("!");
                }
                if (flag)
                {
                    goto IL_26F;
                }
                num6 = num7 + (this.param1[num].x - num7) * (i - num9) / (this.param1[num].y - num9);
                num3 = num8 + (this.param1[num5].x - num8) * (i - num10) / (this.param1[num5].y - num10);
                if (num6 < num12)
                {
                    num12 = num6;
                }
                if (num11 < num3)
                {
                    num11 = num3;
                    goto IL_26F;
                }
                goto IL_26F;
            }
        }

        public NativeArray<Vector2Int> param1;

        public int param2;
    }
}
