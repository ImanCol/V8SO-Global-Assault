using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private static Vector3Int DAT_15F0 = new Vector3Int(0, 4096, 0);

    public string title;

    public string desc;

    public short DAT_63972;

    public short DAT_6397A;

    public short DAT_63982;

    public short DAT_6398A;

    public short DAT_63992;

    public short DAT_6399A;

    public Material defaultMaterial;

    public Camera defaultCamera;

    public VigTerrain terrain;

    public Matrix3x3 DAT_738;

    public ushort[] DAT_C18;

    public Color32 DAT_D98;

    public Color32 DAT_DA4;

    public Color32 DAT_DAC;

    public short DAT_DBA;

    public Color32 DAT_DBC;

    public Material DAT_DC0;

    public Material DAT_DD0;

    public Color32 DAT_DDC;

    public Color32 DAT_DE0;

    public Material[] DAT_DF8;

    public Color32 DAT_E04;

    public Color32 DAT_E08;

    public Material DAT_E48;

    public Material DAT_E58;

    public Vector3Int DAT_10F8;

    public XOBF_DB DAT_1178;

    public int DAT_117C;

    public int DAT_1180;

    public int DAT_1184;

    public int DAT_118C;

    public byte[] bspData;

    public List<OBJ> objData;

    public int aimpSize;

    public ushort[] aimpData;

    public VigObject level;

    public AudioSource music;

    public List<Junction> roadList = new List<Junction>();

    public List<XRTP_DB> xrtpList = new List<XRTP_DB>();

    public List<JUNC_DB> juncList = new List<JUNC_DB>();

    public List<XOBF_DB> xobfList = new List<XOBF_DB>();

    public Navigation ainav;

    public List<VigTuple> levelObjs;

    private int counter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        ainav = new Navigation();
        levelObjs = new List<VigTuple>();
        for (int i = 0; i < xobfList.Count; i++)
        {
            if (xobfList[i] != null)
            {
                Debug.Log("Read: " + xobfList[i].name);
                xobfList[i].SetAtlas();
            }
        }
    }

    private void Start()
    {
        GameManager.instance.levelManager = this;
        GameManager.instance.terrain = terrain;
        if (GameManager.instance.inMenu)
        {
            return;
        }
        PSXEffects component = defaultCamera.GetComponent<PSXEffects>();
        switch (GameManager.instance.ditheringMethod)
        {
            case _DITHERING.None:
                component.colorDepth = 16;
                component.resolutionFactor = 1;
                component.dithering = false;
                break;
            case _DITHERING.Standard:
                component.colorDepth = 5;
                component.resolutionFactor = 2;
                component.dithering = true;
                component.ditherType = 1;
                break;
            case _DITHERING.PSX:
                component.colorDepth = 5;
                component.resolutionFactor = 2;
                component.dithering = true;
                component.ditherType = 0;
                break;
        }
        if ((GameManager.instance.DAT_40 & 0x40) != 0)
        {
            DAT_C18[4] = 0;
        }
        LoadData();
        GameManager.DAT_63970[0].y = DAT_63972;
        GameManager.DAT_63970[1].y = DAT_6397A;
        GameManager.DAT_63970[2].y = DAT_63982;
        GameManager.DAT_63970[3].y = DAT_6398A;
        GameManager.DAT_63970[4].y = DAT_63992;
        GameManager.DAT_63970[5].y = DAT_6399A;
        int num = 0;
        do
        {
            VigMesh vigMesh = xobfList[18].FUN_2CB74_2(base.gameObject, GameManager.DAT_63A7C[num]);
            GameManager.instance.DAT_1150[num] = vigMesh;
            vigMesh.topology = MeshTopology.Lines;
            num++;
        }
        while (num < 4);
        GameManager.instance.targetHUD = new Material(Shader.Find("PSXEffects/PS1Screen"));
        int num2 = 1;
        if (_GAME_MODE.Demo < GameManager.instance.gameMode)
        {
            num2 = 4;
            if (GameManager.instance.gameMode < _GAME_MODE.Unk2)
            {
                num2 = 2;
            }
        }
        int num3 = 0;
        if (num2 != 0)
        {
            do
            {
                int num4 = GameManager.instance.vehicles[num3];
                num3++;
            }
            while (num3 < num2);
        }
        GameManager.instance.timer = 0;
        Vector3Int param = new Vector3Int(DAT_10F8.x * 6144 >> 12, DAT_10F8.y * 6144 >> 12, DAT_10F8.z * 6144 >> 12);
        GameManager.instance.FUN_2DE84(0, param, DAT_DAC);
        GameManager.instance.FUN_2DE84(1, DAT_15F0, DAT_D98);
        param = new Vector3Int(-DAT_10F8.x, DAT_10F8.y, -DAT_10F8.z);
        GameManager.instance.FUN_2DE84(2, param, DAT_DBC);
        num = GameManager.instance.interObjs.Count;
        Utilities.SetColorMatrix(GameManager.instance.DAT_FA8);
        Utilities.SetLightMatrix(GameManager.instance.DAT_F68);
        Utilities.SetBackColor(64, 64, 64);
        if (GameManager.instance.interObjs.Count > 0)
        {
            List<VigTuple> interObjs = GameManager.instance.interObjs;
            do
            {
                VigTuple vigTuple = interObjs[0];
                VigObject vObject = vigTuple.vObject;
                interObjs.RemoveAt(0);
                FUN_3C8C(vObject, GameManager.defaultTransform);
                if (vigTuple.flag == 0)
                {
                    FUN_278C(GameManager.instance.bspTree, vigTuple);
                }
                else
                {
                    FUN_284C((int)(vigTuple.flag & int.MaxValue)).LDAT_04.Add(vigTuple);
                }
            }
            while (GameManager.instance.interObjs.Count > 0);
        }
        if (GameManager.instance.gameMode != 0)
        {
            _GAME_MODE gameMode = GameManager.instance.gameMode;
        }
        if (GameManager.instance.playerObjects[0] == null)
        {
            if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
            {
                GameManager.instance.playerObjects[0] = GameManager.instance.FUN_3208C(-1, ~DiscordController.GetMemberId());
                GameManager.instance.playerObjects[0].userId = DiscordController.GetUserId();
                Debug.Log("User get: " + GameManager.instance.playerObjects[0].userId);
                GameManager.instance.playerSpawns--;
            }
            else
            {
                GameManager.instance.playerObjects[0] = GameManager.instance.FUN_3208C(-1);
            }
            if (GameManager.instance.playerObjects[0] != null)
            {
                if (GameManager.instance.gameMode < _GAME_MODE.Versus2)
                {
                    num = 1;
                    GameManager.instance.playerObjects[0].flags = (uint)((int)(GameManager.instance.playerObjects[0].flags & 0x1FFFFFF) | int.MinValue);
                    while (true)
                    {
                        num2 = (int)GameManager.FUN_2AC5C();
                        uint num5 = (uint)(16777216 << (((num2 * 7 >> 15) + 1) & 0x1F));
                        if ((GameManager.instance.playerObjects[0].flags & num5) == 0)
                        {
                            GameManager.instance.playerObjects[0].flags |= num5;
                            num++;
                            if (num >= 3)
                            {
                                break;
                            }
                        }
                    }
                }
                GameManager.instance.playerObjects[0].FUN_3066C();
            }
        }
        FUN_3D94(GameManager.instance.playerObjects[0]);
        GameManager.instance.EnemyKill = 0;
        GameManager.instance.inDebug = false;
        level.UpdateW(1, 0);
        if ((level.flags & 0x80) != 0)
        {
            GameManager.instance.FUN_30080(GameManager.instance.DAT_1088, level);
        }

        //music
        //MusicManager.instance.PlayNextMusic();
        MusicManager.instance.music.loop = false;

        //Envia Spawn Inicial
        if (GameManager.instance.online)
            Debug.Log("Spawn Vehicle...");
        ClientSend.Spawn();
        if (!DiscordController.instance)
        {
            Debug.Log("No se encontro DiscordController");
        }

        if (DiscordController.instance)
            DiscordController.instance.sceneLoaded = true;
    }

    private void Update()
    {
        //MusicManager.instance.PlayMusic();
    }

    public void LoadData()
    {
        IMP_BSP.LoadData(bspData);
        for (int i = 0; i < objData.Count; i++)
        {
            IMP_OBJ.LoadOBJ(objData[i].buffer);
        }
    }

    public int FUN_9C10(uint param1, int param2, uint param3, int param4)
    {
        int result = 0;
        if (param4 < param2)
        {
            result = 2;
            if (param2 <= param4)
            {
                if (param1 < param3)
                {
                    result = 0;
                }
                else
                {
                    result = 2;
                    if (param1 <= param3)
                    {
                        result = 1;
                    }
                }
            }
        }
        return result;
    }

    public void FUN_7E6C()
    {
        counter = 0;
        if (0 < DAT_1184)
        {
            for (int i = 0; i < DAT_1184; i++)
            {
                JUNC_DB jUNC_DB = juncList[i];
                if (jUNC_DB.DAT_11 == 0)
                {
                    continue;
                }
                for (int j = 0; j < jUNC_DB.DAT_11; j++)
                {
                    RSEG_DB rSEG_DB = jUNC_DB.DAT_1C[j];
                    if (jUNC_DB == rSEG_DB.DAT_00[0] && (rSEG_DB.DAT_0C & 0x10) == 0 && xrtpList[rSEG_DB.DAT_0A].timFarList.Count > 0)
                    {
                        FUN_719C(rSEG_DB);
                    }
                }
            }
        }
        if (0 >= DAT_1180)
        {
            return;
        }
        for (int k = 0; k < DAT_1180; k++)
        {
            if (xrtpList[k].timFarList != null)
            {
                FUN_50F0(xrtpList[k]);
            }
        }
    }

    public void FUN_21594(short[] param1, ushort param2, ushort param3, ushort param4)
    {
        uint num = ((uint)param2 >> 7) & 3;
        if (param1 != null)
        {
            param1[0] = (short)((param2 & 0xF) * 64 + (short)((byte)param3 >> (int)((2 - num) & 0x1F)));
            param1[1] = (short)((param2 & 0x10) * 16 + (int)((uint)param3 >> 8));
            param1[2] = (short)(DAT_DF8[0].mainTexture.width >> (int)((2 - num) & 0x1F));
            param1[3] = (short)DAT_DF8[0].mainTexture.height;
        }
    }

    public uint FUN_35778(int param1, int param2)
    {
        uint num = (uint)(param1 << 5);
        param2 <<= 5;
        int num2 = 0;
        uint num3;
        while (true)
        {
            num3 = num >> 31;
            if (param2 < 0)
            {
                num3 |= 2;
            }
            ushort num4 = aimpData[num2 + num3 + 1];
            num3 = num4;
            if (num3 == 0 || (num4 & 0x8000) != 0)
            {
                break;
            }
            num2 += (int)(num3 * 5);
            num <<= 1;
            param2 <<= 1;
        }
        return num3;
    }

    public void FUN_359CC(short[] param1, uint param2)
    {
        FUN_357D4(param1, param2, 0, 0, 0, 2048, aimpData);
    }

    public void FUN_357D4(short[] param1, uint param2, int param3, int param4, int param5, int param6, ushort[] param7)
    {
        param6 >>= 1;
        ushort num = (ushort)param2;
        if (param1[1] < param5 + param6)
        {
            if (param1[0] < param4 + param6)
            {
                ushort num2 = param7[param3 + 1];
                if (num2 == 0 || (num2 & 0x8000) != 0)
                {
                    param7[param3 + 1] = num;
                }
                else
                {
                    FUN_357D4(param1, param2, param3 + num2 * 5, param4, param5, param6, param7);
                }
            }
            if (param4 + param6 < param1[0] + param1[2])
            {
                ushort num2 = param7[param3 + 2];
                if (num2 == 0 || (num2 & 0x8000) != 0)
                {
                    param7[param3 + 2] = num;
                }
                else
                {
                    FUN_357D4(param1, param2, param3 + num2 * 5, param4 + param6, param5, param6, param7);
                }
            }
        }
        if (param5 + param6 >= param1[1] + param1[3])
        {
            return;
        }
        if (param1[0] < param4 + param6)
        {
            ushort num2 = param7[param3 + 3];
            if (num2 == 0 || (num2 & 0x8000) != 0)
            {
                param7[param3 + 3] = num;
            }
            else
            {
                FUN_357D4(param1, param2, param3 + num2 * 5, param4, param5 + param6, param6, param7);
            }
        }
        if (param4 + param6 < param1[0] + param1[2])
        {
            ushort num2 = param7[param3 + 4];
            if (num2 == 0 || (num2 & 0x8000) != 0)
            {
                param7[param3 + 4] = num;
            }
            else
            {
                FUN_357D4(param1, param2, param3 + num2 * 5, param4 + param6, param5 + param6, param6, param7);
            }
        }
    }

    public void FUN_309C8(VigObject param1, int param2)
    {
        level.UpdateW(param1, 18, param2);
        GameManager.instance.FUN_309A0(param1);
    }

    public void FUN_359FC(int param1, int param2, uint param3)
    {
        if (param1 < 0)
        {
            param1 += 65535;
        }
        if (param2 < 0)
        {
            param2 += 65535;
        }
        FUN_357D4(new short[4]
        {
            (short)(param1 >> 16),
            (short)(param2 >> 16),
            1,
            1
        }, param3, 0, 0, 0, 2048, aimpData);
    }

    public void FUN_38EF4(int param1, int param2)
    {
        Vector3Int param3 = new Vector3Int(param1, GameManager.instance.DAT_DB0, param2);
        FUN_4DE54(param3, 147).flags &= 4294967279u;
    }

    public void FUN_38F38(int param1, int param2)
    {
        Vector3Int param3 = new Vector3Int(param1, GameManager.instance.DAT_DB0, param2);
        FUN_4DE54(param3, 146).flags &= 4294967279u;
    }

    public Fire1 FUN_399FC(Vehicle param1, XOBF_DB param2, short param3)
    {
        Fire1 fire;
        if ((param1.DAT_F6 & 8) == 0 && (param1.DAT_F6 & 0x100) == 0)
        {
            fire = null;
            if (param1.shield == 0)
            {
                fire = new GameObject().AddComponent<Fire1>();
                fire.DAT_58 = 65536;
                fire.physics1.M1 = 4;
                fire.DAT_98 = param2;
                fire.physics2.M3 = param3;
                fire.maxHalfHealth = 2;
                fire.flags |= 32u;
                fire.vTransform = GameManager.FUN_2A39C();
                fire.physics1.Y = 512;
                fire.physics1.Z = -1536;
                fire.physics1.W = 0;
                Utilities.FUN_2CC9C(param1, fire);
                fire.transform.parent = param1.transform;
                fire.FUN_30B78();
                GameManager.instance.FUN_30CB0(fire, 600);
                param1.DAT_F6 |= 8;
            }
        }
        else
        {
            fire = null;
        }
        return fire;
    }

    public bool FUN_39AF8(Vehicle param1)
    {
        Fire1 x = FUN_399FC(param1, xobfList[19], 22);
        if (x != null)
        {
            int param2 = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 68, param1.vTransform.position);
        }
        return x != null;
    }

    public VigObject FUN_42408(VigObject param1, VigObject param2, ushort param3, Type param4, VigObject param5)
    {
        ConfigContainer configContainer = (!(param2.vData == null)) ? param2.FUN_2C5F4(32768) : null;
        VigObject vigObject = (param3 << 16 >= 0) ? param2.vData.ini.FUN_2C17C(param3, param4, 8u) : (new GameObject().AddComponent(param4) as VigObject);
        vigObject.DAT_80 = param1;
        vigObject.flags = 536870912u;
        ushort num = (ushort)param1.id;
        vigObject.type = 8;
        vigObject.id = (short)num;
        if (configContainer == null)
        {
            VigTransform vigTransform = vigObject.vTransform = GameManager.instance.FUN_2CDF4(param2);
        }
        else
        {
            vigObject.vTransform = GameManager.instance.FUN_2CEAC(param2, configContainer);
        }
        vigObject.screen = vigObject.vTransform.position;
        if (param5 != null)
        {
            Utilities.FUN_2CA94(param2, configContainer, param5);
            param5.transform.parent = param2.transform;
        }
        return vigObject;
    }

    public VigObject FUN_42560(VigObject param1, VigObject param2, VigObject param3, VigObject param4)
    {
        param3.DAT_80 = param1;
        param3.flags = 536870912u;
        short id = param1.id;
        param3.type = 8;
        param3.id = id;
        param3.vTransform = GameManager.instance.FUN_2CDF4(param2);
        param3.screen = param3.vTransform.position;
        if (param4 != null)
        {
            param4.vTransform = GameManager.FUN_2A39C();
            Utilities.FUN_2CC48(param2, param4);
            param4.transform.parent = param2.transform;
        }
        return param3;
    }

    public void FUN_4AAC0(uint param1, Vector3Int param2, Vector3Int param3)
    {
        int num = (int)GameManager.instance.FUN_4A970(param1, 0u);
        FUN_4AA24((ushort)GameManager.DAT_63FA4[num], param2, param3);
    }

    public Pickup FUN_4AA24(ushort param1, Vector3Int param2, Vector3Int param3)
    {
        Pickup obj = DAT_1178.ini.FUN_2C17C(param1, typeof(Pickup), 0u) as Pickup;
        obj.state = _PICKUP_TYPE.Type2;
        obj.screen = param2;
        obj.physics1.Z = param3.x;
        obj.physics1.W = param3.y;
        obj.physics2.X = param3.z;
        obj.DAT_87 = 2;
        obj.FUN_3066C();
        return obj;
    }

    public Pickup FUN_4AD24(short param1)
    {
        Pickup obj = Utilities.FUN_31D30(typeof(Pickup), DAT_1178, param1, 0u) as Pickup;
        obj.FUN_2C7D0();
        return obj;
    }

    public Pickup FUN_4AD78(uint param1)
    {
        int num = (int)GameManager.instance.FUN_4A970(param1, 0u);
        return FUN_4AD24(GameManager.DAT_63FA4[num]);
    }

    public Pickup FUN_4AE08(uint param1, Vector3Int param2)
    {
        Pickup pickup = FUN_4AD78(param1);
        pickup.screen = param2;
        pickup.FUN_3066C();
        return pickup;
    }

    public VigCamera FUN_4B984(VigObject param1, VigObject param2)
    {
        VigCamera vigCamera = new GameObject().AddComponent<VigCamera>();
        vigCamera.DAT_80 = param1;
        vigCamera.id = param2.id;
        vigCamera.screen = param2.screen;
        vigCamera.vr = param2.vr;
        vigCamera.state = _CAMERA_TYPE.Teleport;
        vigCamera.maxHalfHealth = param2.maxHalfHealth;
        vigCamera.ApplyTransformation();
        if (param1.type == 2)
        {
            param1.flags = (uint)(((int)param1.flags & -3) | 0x2000000);
        }
        return vigCamera;
    }

    public void FUN_4DF20(Vector3Int param1, ushort param2, short param3)
    {
        Particle1 particle = FUN_4DE54(param1, param2);
        Utilities.FUN_245AC(sv: new Vector3Int(param3, param3, param3), m33: ref particle.vTransform.rotation);
        particle.vTransform.padding = param3;
    }

    public Particle1 FUN_4DE54(Vector3Int param1, ushort param2)
    {
        Particle1 particle = xobfList[19].ini.FUN_2C17C(param2, typeof(Particle1), 8u) as Particle1;
        Utilities.ParentChildren(particle, particle);
        particle.type = 7;
        particle.flags = 52u;
        particle.screen = param1;
        VigObject vigObject = particle.child2;
        while (vigObject != null)
        {
            vigObject.flags = 16u;
            vigObject = vigObject.child;
        }
        particle.ApplyTransformation();
        particle.FUN_2D1DC();
        VigTuple vigTuple = particle.TDAT_74 = GameManager.instance.FUN_30080(GameManager.instance.interObjs, particle);
        vigTuple = (particle.TDAT_78 = GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, particle));
        return particle;
    }

    public void FUN_4D16C(XOBF_DB param1, ushort param2, VigTransform param3)
    {
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        ushort flag = configContainer.flag;
        uint num = flag;
        switch ((int)num >> 12)
        {
            case 9:
                {
                    int param4 = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param4, GameManager.instance.DAT_C2C, GameManager.DAT_BC0[GameManager.DAT_640C8[((flag >> 6) & 0x3C) / 4] + (num & 0xFF)], param3.position);
                    break;
                }
            case 8:
                {
                    if (num - 33792 < 61)
                    {
                        if (GameManager.DAT_63FE4[num - 33792] != -1)
                        {
                            VigCollider vigCollider;
                            if (configContainer.colliderID < 0)
                            {
                                vigCollider = null;
                            }
                            else
                            {
                                vigCollider = param1.cbbList[configContainer.colliderID];
                                vigCollider.GetReader();
                            }
                            FUN_4DF74(param3.position, GameManager.DAT_63FE4[num - 33792], vigCollider);
                        }
                        break;
                    }
                    uint num2 = num - 34048;
                    if (num2 < 21)
                    {
                        if (num < 34058)
                        {
                            FUN_4E56C(param3, GameManager.DAT_6405C[num2]);
                        }
                        else
                        {
                            FUN_4E8C8(param3.position, GameManager.DAT_6405C[num2]);
                        }
                        break;
                    }
                    switch (num)
                    {
                        case 34560u:
                        case 34561u:
                        case 34562u:
                        case 34563u:
                        case 34564u:
                        case 34565u:
                        case 34566u:
                        case 34567u:
                        case 34568u:
                        case 34569u:
                        case 34570u:
                        case 34571u:
                        case 34572u:
                        case 34573u:
                        case 34574u:
                        case 34575u:
                        case 34576u:
                        case 34577u:
                        case 34578u:
                        case 34579u:
                        case 34580u:
                            FUN_4E128(param3.position, (ushort)GameManager.DAT_64084[num - 34560], 100);
                            break;
                        case 34816u:
                        case 34817u:
                        case 34818u:
                        case 34819u:
                        case 34820u:
                        case 34821u:
                        case 34822u:
                        case 34823u:
                            UIManager.instance.FUN_4E414(param3.position, GameManager.DAT_640AC[num - 34816]);
                            break;
                    }
                    break;
                }
            case 14:
                {
                    configContainer.flag = (ushort)(flag & 0xFFF);
                    Particle5 obj = param1.ini.FUN_2C17C((ushort)(param2 & 0xFFFF), typeof(Particle5), 0u) as Particle5;
                    configContainer.flag |= 57344;
                    obj.type = 7;
                    obj.flags |= 16777344u;
                    obj.vTransform = param3;
                    obj.vr.y = 12;
                    obj.FUN_2D1DC();
                    obj.FUN_305FC();
                    break;
                }
        }
        if (configContainer.next != ushort.MaxValue)
        {
            param1.FUN_4D498(configContainer.next, param3, 0);
        }
    }

    public Ballistic FUN_4DD54(VigObject param1, Vector3Int param2, ushort param3)
    {
        Ballistic ballistic = xobfList[19].ini.FUN_2C17C(param3, typeof(Ballistic), 8u) as Ballistic;
        ballistic.type = 7;
        ballistic.flags = 48u;
        ballistic.vTransform = GameManager.FUN_2A39C();
        ballistic.vTransform.position = param2;
        VigObject vigObject = ballistic.child2;
        while (vigObject != null)
        {
            vigObject.flags = 16u;
            vigObject = vigObject.child;
        }
        ballistic.FUN_30BF0();
        Utilities.FUN_2CC9C(param1, ballistic);
        Utilities.ParentChildren(ballistic, ballistic);
        ballistic.transform.parent = param1.transform;
        return ballistic;
    }

    public void FUN_4DF74(Vector3Int param1, int param2, VigCollider param3)
    {
        Particle1 particle = FUN_4DE54(param1, (ushort)param2);
        if (param3 == null || param3.reader.ReadUInt16(0) != 1)
        {
            return;
        }
        VigCollider vCollider = particle.vCollider;
        if (vCollider != null && vCollider.reader.ReadUInt16(0) == 1)
        {
            int num = (param3.reader.ReadInt32(16) - param3.reader.ReadInt32(4)) * 4096 / (vCollider.reader.ReadInt32(16) - vCollider.reader.ReadInt32(4));
            int num2 = 32767;
            if (num < 32767)
            {
                num2 = num;
            }
            Utilities.FUN_245AC(sv: new Vector3Int(num2, num2, num2), m33: ref particle.vTransform.rotation);
            particle.vTransform.padding = (short)num2;
        }
    }

    public Particle2 FUN_4E128(Vector3Int param1, ushort param2, int param3)
    {
        Particle2 particle = xobfList[19].ini.FUN_2C17C(param2, typeof(Particle2), 8u) as Particle2;
        Utilities.ParentChildren(particle, particle);
        particle.type = 8;
        uint num = particle.flags = ((param3 != 0) ? (particle.flags | 0x304) : (particle.flags | 0x324));
        particle.screen = param1;
        particle.maxHalfHealth = (ushort)(param3 / 12);
        particle.FUN_3066C();
        BufferedBinaryReader reader = particle.vCollider.reader;
        particle.DAT_58 = reader.ReadInt32(16);
        return particle;
    }

    public Particle3 FUN_4E56C(VigTransform param1, int param2)
    {
        Particle3 particle = new GameObject().AddComponent<Particle3>();
        VigConfig ini = xobfList[19].ini;
        particle.flags |= 160u;
        particle.screen = param1.position;
        particle.DAT_58 = 65536;
        particle.ApplyTransformation();
        Utilities.SetRotMatrix(param1.rotation);
        ushort next = ini.configContainers[param2].next;
        for (uint num = next; num != 65535; num = next)
        {
            VigObject vigObject = xobfList[19].ini.FUN_2C17C((ushort)num, typeof(VigObject), 0u);
            Vector3Int vector3Int = Utilities.FUN_23F7C(vigObject.screen);
            vigObject.physics1.Z = vector3Int.x;
            vigObject.physics1.W = vector3Int.y;
            vigObject.physics2.X = vector3Int.z;
            int num2 = vigObject.physics1.Z;
            if (num2 < 0)
            {
                num2 += 3;
            }
            int num3 = vigObject.physics1.W;
            vigObject.physics1.Z = num2 >> 2;
            if (num3 < 0)
            {
                num3 += 3;
            }
            num2 = vigObject.physics2.X;
            vigObject.physics1.W = num3 >> 2;
            if (num2 < 0)
            {
                num2 += 3;
            }
            vigObject.physics2.X = num2 >> 2;
            next = (ushort)GameManager.FUN_2AC5C();
            vigObject.physics1.M0 = (short)(next & 0x1F);
            next = (ushort)GameManager.FUN_2AC5C();
            vigObject.physics1.M1 = (short)(next & 0x1F);
            next = (ushort)GameManager.FUN_2AC5C();
            vigObject.physics1.M2 = (short)(next & 0x1F);
            vigObject.screen = new Vector3Int(0, 0, 0);
            vigObject.ApplyTransformation();
            num2 = (int)GameManager.FUN_2AC5C();
            vigObject.physics2.Y = (num2 * 30 >> 15) + 30;
            Utilities.FUN_2CC48(particle, vigObject);
            vigObject.transform.parent = particle.transform;
            next = xobfList[19].ini.configContainers[(int)num].previous;
        }
        particle.FUN_3066C();
        return particle;
    }

    public Particle4 FUN_4E8C8(Vector3Int param1, short param2)
    {
        Particle4 particle = new GameObject().AddComponent<Particle4>();
        particle.flags = 164u;
        particle.DAT_1A = param2;
        particle.screen = param1;
        particle.FUN_3066C();
        return particle;
    }

    public Particle9 FUN_4EAE8(Vector3Int param1, Vector3Int param2, short param3)
    {
        Particle9 particle = new GameObject().AddComponent<Particle9>();
        particle.type = 8;
        particle.flags = 164u;
        particle.DAT_1A = param3;
        particle.screen = param1;
        particle.maxHalfHealth = 4096;
        particle.FUN_3066C();
        particle.vTransform.rotation = Utilities.FUN_2A5EC(param2);
        return particle;
    }

    public JUNC_DB FUN_51B74(int param1)
    {
        int num = 0;
        if (0 < DAT_1184)
        {
            do
            {
                JUNC_DB jUNC_DB = juncList[num];
                if (jUNC_DB.DAT_12 == param1 && (jUNC_DB.DAT_10 & 0x40) != 0)
                {
                    return jUNC_DB;
                }
                num++;
            }
            while (num < DAT_1184);
        }
        return null;
    }

    public RSEG_DB FUN_518DC(Vector3Int param1, int param2)
    {
        int num = int.MaxValue;
        int num2 = 0;
        RSEG_DB result = null;
        List<JUNC_DB> list = juncList;
        if (0 < DAT_1184)
        {
            do
            {
                JUNC_DB jUNC_DB = list[num2];
                int num3 = 0;
                if (jUNC_DB.DAT_11 != 0)
                {
                    do
                    {
                        RSEG_DB rSEG_DB = jUNC_DB.DAT_1C[num3];
                        if (rSEG_DB.DAT_00[0] == jUNC_DB && (param2 == -1 || (short)rSEG_DB.DAT_08 == param2))
                        {
                            int num4 = (rSEG_DB.DAT_00[1].DAT_00.x < jUNC_DB.DAT_00.x) ? 1 : 0;
                            int num5 = param1.x - rSEG_DB.DAT_00[1 - num4].DAT_00.x;
                            int num6 = (rSEG_DB.DAT_00[1].DAT_00.z < jUNC_DB.DAT_00.z) ? 1 : 0;
                            int num7 = 0;
                            if (0 < num5)
                            {
                                num7 = num5;
                            }
                            int num8 = param1.x - rSEG_DB.DAT_00[num4].DAT_00.x;
                            num5 = 0;
                            if (num8 < 0)
                            {
                                num5 = num8;
                            }
                            int num9 = param1.z - rSEG_DB.DAT_00[1 - num6].DAT_00.z;
                            num8 = 0;
                            if (0 < num9)
                            {
                                num8 = num9;
                            }
                            int num10 = param1.z - rSEG_DB.DAT_00[num6].DAT_00.z;
                            num9 = 0;
                            if (num10 < 0)
                            {
                                num9 = num10;
                            }
                            num7 = num7 - num5 + (num8 - num9);
                            if (num7 < num)
                            {
                                num = num7;
                                result = rSEG_DB;
                            }
                        }
                        num3++;
                    }
                    while (num3 < jUNC_DB.DAT_11);
                }
                num2++;
            }
            while (num2 < DAT_1184);
        }
        return result;
    }

    private void FUN_278C(BSP param1, VigTuple param2)
    {
        int dAT_ = param1.DAT_00;
        BSP param3;
        if (dAT_ == 1)
        {
            if (param2.vObject.screen.x > param1.DAT_04)
            {
                goto IL_0062;
            }
            param3 = param1.DAT_08;
        }
        else
        {
            if (dAT_ == 0)
            {
                param1.LDAT_04.Add(param2);
                return;
            }
            if (dAT_ != 2)
            {
                return;
            }
            if (param2.vObject.screen.z > param1.DAT_04)
            {
                goto IL_0062;
            }
            param3 = param1.DAT_08;
        }
        goto IL_0069;
    IL_0062:
        param3 = param1.DAT_0C;
        goto IL_0069;
    IL_0069:
        FUN_278C(param3, param2);
    }

    private BSP FUN_284C(int param1)
    {
        BSP bSP = GameManager.instance.bspTree;
        if (0 < param1)
        {
            param1 <<= 1;
            while (0 < param1)
            {
                param1 <<= 1;
            }
        }
        param1 <<= 1;
        while (bSP.DAT_00 != 0)
        {
            bSP = ((param1 >= 0) ? bSP.DAT_08 : bSP.DAT_0C);
            param1 <<= 1;
        }
        return bSP;
    }

    private uint FUN_3630(VigObject param1, Vector3Int param2, Vector3Int param3)
    {
        Vector3Int v = new Vector3Int(param1.vTransform.rotation.V01, param1.vTransform.rotation.V11, param1.vTransform.rotation.V21);
        int num = Utilities.FUN_29C5C(param3, v);
        uint result = 0u;
        if (num < 0)
        {
            uint num2 = (ushort)GameManager.DAT_65C90[(param1.physics1.M7 & 0xFFF) * 2 + 1];
            ushort num3 = (ushort)GameManager.DAT_65C90[(param1.physics1.M6 & 0xFFF) * 2 + 1];
            Vector3Int vector3Int = new Vector3Int(param2.x - param1.screen.x, param2.y - param1.screen.y, param2.z - param1.screen.z);
            result = (uint)Utilities.FUN_29E84(vector3Int);
            Utilities.FUN_29FC8(vector3Int, out Vector3Int vout);
            int num4 = Utilities.FUN_29C5C(vout, v);
            if (num4 < 0)
            {
                num4 += 4095;
            }
            uint z = (uint)param1.physics1.Z;
            if (result < z)
            {
                int num5 = -num;
                if ((int)num2 < num4 >> 12)
                {
                    if (0 < num)
                    {
                        num5 += 4095;
                    }
                    result = (z - result) / ((uint)((int)z - param1.physics1.Y) >> 12);
                    if (4096 < (int)result)
                    {
                        result = 4096u;
                    }
                    num = (num5 >> 12) * (int)result;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    num4 = (int)((num2 - (num4 >> 12)) * 4096) / (int)(num2 - num3);
                    if (4096 < num4)
                    {
                        num4 = 4096;
                    }
                    num4 = (num >> 12) * num4;
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    num = (num4 >> 12) * (ushort)param1.physics2.M0;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    result = (uint)((num >> 12) & 0xFFFF);
                }
                else
                {
                    result = 0u;
                }
            }
            else
            {
                result = 0u;
            }
        }
        return result;
    }

    private void FUN_3828(MemoryStream param1, MemoryStream param2, MemoryStream param3, MemoryStream param4)
    {
        Vector3Int param5;
        using (BinaryReader reader = new BinaryReader(param3, Encoding.Default, leaveOpen: true))
        {
            param5 = Utilities.FUN_23F58(new Vector3Int(reader.ReadInt16(0), reader.ReadInt16(2), reader.ReadInt16(4)));
        }
        Vector3Int vector3Int;
        using (BinaryReader reader2 = new BinaryReader(param4, Encoding.Default, leaveOpen: true))
        {
            vector3Int = Utilities.FUN_23EA0(new Vector3Int(reader2.ReadInt16(0), reader2.ReadInt16(2), reader2.ReadInt16(4)));
        }
        Color32 color;
        using (BinaryReader reader3 = new BinaryReader(param2, Encoding.Default, leaveOpen: true))
        {
            color = Utilities.NormalColorCol(vector3Int, new Color32(reader3.ReadByte(0), reader3.ReadByte(1), reader3.ReadByte(2), reader3.ReadByte(3)));
        }
        uint num = color.r;
        uint num2 = color.g;
        uint num3 = color.b;
        if (levelObjs != null)
        {
            for (int i = 0; i < levelObjs.Count; i++)
            {
                VigObject vObject = levelObjs[i].vObject;
                uint num4 = FUN_3630(vObject, param5, vector3Int);
                num4 &= 0xFFFF;
                if (num4 != 0)
                {
                    int num5 = (int)(num4 * (byte)vObject.physics1.M0);
                    if (num5 < 0)
                    {
                        num5 += 4095;
                    }
                    num = (uint)((int)num + (num5 >> 12));
                    int num6 = (int)(num4 * (byte)(vObject.physics1.M0 >> 8));
                    if (num6 < 0)
                    {
                        num6 += 4095;
                    }
                    num2 = (uint)((int)num2 + (num6 >> 12));
                    int num7 = (int)(num4 * (byte)vObject.physics1.M1);
                    if (num7 < 0)
                    {
                        num7 += 4095;
                    }
                    num3 = (uint)((int)num3 + (num7 >> 12));
                }
            }
        }
        using (BinaryWriter binaryWriter = new BinaryWriter(param1, Encoding.Default, leaveOpen: true))
        {
            uint num4 = 255u;
            if ((int)num < 255)
            {
                num4 = num;
            }
            binaryWriter.Write((byte)num4);
            num = 255u;
            if ((int)num2 < 255)
            {
                num = num2;
            }
            binaryWriter.Write((byte)num);
            num = 255u;
            if ((int)num3 < 255)
            {
                num = num3;
            }
            binaryWriter.Write((byte)num);
        }
    }

    private void FUN_3C8C(VigObject param1, VigTransform param2)
    {
        do
        {
            VigTransform vigTransform = Utilities.CompMatrixLV(param2, param1.vTransform);
            Utilities.FUN_246BC(vigTransform);
            VigMesh vMesh = param1.vMesh;
            DELEGATE_79A0 param3 = FUN_3828;
            if (vMesh != null && (vMesh.DAT_00 & 1) != 0)
            {
                vMesh.FUN_39A8(param3);
                vMesh.Initialize();
                vMesh.DAT_00 &= 254;
                vMesh.DAT_00 |= 4;
            }
            vMesh = param1.vLOD;
            if (vMesh != null && (vMesh.DAT_00 & 1) != 0)
            {
                vMesh.FUN_39A8(FUN_3828);
                vMesh.Initialize();
                vMesh.DAT_00 &= 254;
                vMesh.DAT_00 |= 4;
            }
            if (param1.child2 != null)
            {
                FUN_3C8C(param1.child2, vigTransform);
            }
            param1 = param1.child;
        }
        while (param1 != null);
    }

    public void FUN_3D94(Vehicle param1)
    {
        param1.FUN_3CCD4(param1: true);
        VigCamera vigCamera = param1.vCamera = GameManager.instance.FUN_4B914(param1, 256, defaultCamera);
        GameManager.instance.cameraObjects[~param1.id] = vigCamera;
        if (param1.vehicle == _VEHICLE.Livingston)
        {
            param1.vCamera.DAT_9C += 102400;
        }
        param1.view = _CAR_VIEW.Far;
        param1.vCamera.FUN_30B78();
        param1.vCamera.FUN_4BC0C();
        param1.FUN_38408();
        param1.FUN_3C9C4(~param1.id);
        if (GameManager.instance.difficultyMode < 2)
        {
            int num = (GameManager.instance.difficultyMode != 0) ? (param1.maxHalfHealth * 3 >> 1) : (param1.maxHalfHealth << 1);
            param1.FUN_3C404((ushort)num);
        }
        GameObject gameObject = new GameObject();
        VigObject closeViewer = gameObject.AddComponent<VigObject>();
        gameObject.transform.parent = param1.transform;
        param1.closeViewer = closeViewer;
        ConfigContainer configContainer = param1.FUN_2C5F4(33024);
        if (configContainer == null)
        {
            param1.closeViewer.screen.y = -21845;
            param1.closeViewer.ApplyTransformation();
            Utilities.FUN_2CC48(param1, param1.closeViewer);
        }
        else
        {
            Utilities.FUN_2CA94(param1, configContainer, param1.closeViewer);
        }
        if ((GameManager.instance.DAT_40 & 0x8000) != 0)
        {
            param1.DAT_A6 = 20480;
        }
        if ((GameManager.instance.DAT_40 & 0x10000) != 0)
        {
            param1.lightness = 0;
        }
    }

    private void FUN_719C(RSEG_DB param1)
    {
        VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
        int[,] array = new int[3, 4]
        {
            {
                param1.DAT_00[0].DAT_00.x,
                param1.DAT_00[0].DAT_00.y,
                param1.DAT_00[0].DAT_00.z,
                param1.DAT_00[0].DAT_00.x + param1.DAT_10[0]
            },
            {
                0,
                param1.DAT_00[0].DAT_00.z + param1.DAT_14[0],
                param1.DAT_00[1].DAT_00.x + param1.DAT_10[1],
                0
            },
            {
                param1.DAT_00[1].DAT_00.z + param1.DAT_14[1],
                param1.DAT_00[1].DAT_00.x,
                param1.DAT_00[1].DAT_00.y,
                param1.DAT_00[1].DAT_00.z
            }
        };
        int[,] array2 = new int[3, 4];
        Array.Copy(array, array2, array.Length);
        int num = 0;
        for (int i = 0; i < 2; i++)
        {
            JUNC_DB jUNC_DB = param1.DAT_00[i];
            if (jUNC_DB.DAT_18 == null)
            {
                if ((jUNC_DB.DAT_10 & 1) == 0)
                {
                    int num2 = 0;
                    if ((param1.DAT_0C & (2 << (i & 0x1F))) == 0)
                    {
                        byte dAT_ = jUNC_DB.DAT_11;
                        int num3 = 0;
                        if (dAT_ != 0)
                        {
                            int num4 = num3;
                            do
                            {
                                num3 = num4;
                                if ((short)jUNC_DB.DAT_1C[num2].DAT_08 < (short)param1.DAT_08)
                                {
                                    num3 = xrtpList[jUNC_DB.DAT_1C[num2].DAT_0A].DAT_24 / 2;
                                    if (num3 < num4)
                                    {
                                        num3 = num4;
                                    }
                                }
                                num2++;
                                num4 = num3;
                            }
                            while (num2 < dAT_);
                        }
                        if (num3 != 0)
                        {
                            FUN_6604(array2, i, num3);
                        }
                    }
                }
            }
            else
            {
                VigConfig ini = jUNC_DB.DAT_0C.ini;
                array[1, 1] = 0;
                array[1, 0] = param1.DAT_10[i];
                array[1, 3] = 0;
                array[1, 2] = param1.DAT_14[i];
                array[0, 0] = param1.DAT_10[i];
                array[0, 1] = 0;
                array[0, 2] = param1.DAT_14[i];
                array[0, 3] = 0;
                int num5 = 0;
                ushort num6 = ini.configContainers[jUNC_DB.DAT_14].next;
                int num2 = (jUNC_DB.DAT_16 & 0xFFF) * 2;
                int num4 = GameManager.DAT_65C90[num2 + 1];
                int num3 = GameManager.DAT_65C90[num2];
                num2 = num;
                while (num6 != ushort.MaxValue)
                {
                    ConfigContainer configContainer = ini.configContainers[num6];
                    array = new int[4, 4]
                    {
                        {
                            array[0, 0],
                            array[0, 1],
                            array[0, 2],
                            array[0, 3]
                        },
                        {
                            array[1, 0],
                            array[1, 1],
                            array[1, 2],
                            array[1, 3]
                        },
                        {
                            array[2, 0],
                            array[2, 1],
                            array[2, 2],
                            array[2, 3]
                        },
                        {
                            0,
                            0,
                            0,
                            0
                        }
                    };
                    num2 = num4 * configContainer.v3_1.x + num3 * configContainer.v3_1.z;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    array[2, 0] = num2 >> 12;
                    num2 = -num3 * configContainer.v3_1.x + num4 * configContainer.v3_1.z;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    array[2, 2] = num2 >> 12;
                    array[2, 1] = array[3, 1];
                    array[2, 3] = array[3, 3];
                    array[3, 0] = array[2, 0];
                    array[3, 2] = array[2, 2];
                    Vector2Int vector2Int = Utilities.FUN_2ACD0(new Vector3Int(array[2, 0], array[2, 1], array[2, 2]), new Vector3Int(array[0, 0], array[0, 1], array[0, 2]));
                    num2 = Utilities.FUN_29E84(new Vector3Int(array[2, 0], array[2, 1], array[2, 2]));
                    int num7 = Utilities.FUN_29E84(new Vector3Int(array[0, 0], array[0, 1], array[0, 2]));
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    num7 = (num2 >> 12) * num7;
                    long num8 = Utilities.Divdi3(vector2Int.x, vector2Int.y, num7, num7 >> 31);
                    if (num5 < (int)num8)
                    {
                        num5 = (int)num8;
                        array[1, 0] = array[2, 0];
                        array[1, 1] = array[2, 1];
                        array[1, 2] = array[2, 2];
                        array[1, 3] = array[2, 3];
                    }
                    num6 = ini.configContainers[num6].previous;
                    num2 = num;
                    num = num2;
                }
                array2[num, i] = jUNC_DB.DAT_00.x + array[1, 0];
                array2[num, 2 + i] = jUNC_DB.DAT_00.z + array[1, 2];
                int num9 = array2[num, 1 + i] = vigTerrain.FUN_1B750((uint)array2[num, i], (uint)array2[num, 2 + i]);
            }
            num += 2;
        }
        FUN_630C(array2, xrtpList[param1.DAT_0A], param1.DAT_0C);
    }

    private Junction FUN_50C0(int param1)
    {
        GameObject gameObject = new GameObject("ROAD" + counter.ToString().PadLeft(2, '0'));
        Junction junction = gameObject.AddComponent<Junction>();
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        junction.DAT_1C = param1;
        junction.DAT_20 = new List<Vector3Int>();
        junction.DAT_26 = new List<short>();
        junction.DAT_28 = new List<Vector3Int>();
        junction.DAT_2E = new List<short>();
        return junction;
    }

    private void FUN_50F0(XRTP_DB param1)
    {
        int num = param1.DAT_28 >> 8;
        int num2 = param1.DAT_24 >> 8;
        short num3 = (short)Utilities.SquareRoot(num * num + num2 * num2);
        param1.DAT_30 = (short)(num3 - 128);
        param1.DAT_20 = 0;
        param1.DAT_18 = 0;
    }

    private int FUN_57AC(int[] param1)
    {
        int num = 1;
        int num2 = 3;
        int num3 = param1[2];
        int num4 = param1[2];
        int num5 = param1[0];
        int num6 = param1[0];
        int num7;
        int num8;
        int num9;
        int num10;
        do
        {
            num7 = param1[num2];
            num8 = num7;
            if (num5 < num7)
            {
                num8 = num5;
            }
            if (num7 < num6)
            {
                num7 = num6;
            }
            num9 = param1[num2 + 2];
            num10 = num9;
            if (num3 < num9)
            {
                num10 = num3;
            }
            if (num9 < num4)
            {
                num9 = num4;
            }
            num++;
            num2 += 3;
            num3 = num10;
            num4 = num9;
            num5 = num8;
            num6 = num7;
        }
        while (num < 3);
        num3 = num9 - num10;
        if (num9 - num10 < num7 - num8)
        {
            num3 = num7 - num8;
        }
        return num3;
    }

    private Junction FUN_5850(int[,] param1, XRTP_DB param2, ushort param3)
    {
        VigTerrain vigTerrain = UnityEngine.Object.FindObjectOfType<VigTerrain>();
        int num = param1[0, 3] * 3 - param1[0, 0] + param1[1, 2] * -3 + param1[2, 1];
        if (num < 0)
        {
            num += 15;
        }
        int num2 = param1[1, 1] * 3 - param1[0, 2] + param1[2, 0] * -3 + param1[2, 3];
        if (num2 < 0)
        {
            num2 += 15;
        }
        int num3 = param1[0, 0] * 3 + param1[0, 3] * -6 + param1[1, 2] * 3;
        if (num3 < 0)
        {
            num3 += 15;
        }
        int num4 = param1[0, 2] * 3 + param1[1, 1] * -6 + param1[2, 0] * 3;
        if (num4 < 0)
        {
            num4 += 15;
        }
        int num5 = param1[0, 3] * 3 + param1[0, 0] * -3;
        if (num5 < 0)
        {
            num5 += 15;
        }
        num5 >>= 4;
        int num6 = param1[1, 1] * 3 + param1[0, 2] * -3;
        if (num6 < 0)
        {
            num6 += 15;
        }
        num6 >>= 4;
        int num7 = param1[0, 0];
        int num8 = param1[0, 2];
        uint num9 = (uint)((num >> 4) * 3);
        uint num10 = (uint)((num2 >> 4) * 3);
        int num11 = (num3 >> 4) * 2;
        int num12 = (num4 >> 4) * 2;
        Vector3Int v = new Vector3Int((short)num7, num7 >> 16, num8);
        int num13 = 0;
        if ((param3 & 1) != 0)
        {
            v = vigTerrain.FUN_1BB50(param1[0, 0], param1[0, 1]);
            v = Utilities.VectorNormal(v);
        }
        int num14 = 0;
        int num15 = 0;
        int num16;
        do
        {
            num16 = num14 * num14;
            if (num16 < 0)
            {
                num16 += 4095;
            }
            int num17 = (int)num9 * (num16 >> 12) + num11 * num14;
            if (num17 < 0)
            {
                num17 += 4095;
            }
            num17 = (num17 >> 12) + num5;
            if (num17 < 0)
            {
                num17 += 255;
            }
            num16 = (int)num10 * (num16 >> 12) + num12 * num14;
            if (num16 < 0)
            {
                num16 += 4095;
            }
            num16 = (num16 >> 12) + num6;
            if (num16 < 0)
            {
                num16 += 255;
            }
            num16 = (int)Utilities.SquareRoot((num17 >> 8) * (num17 >> 8) + (num16 >> 8) * (num16 >> 8));
            num15++;
            num14 += param2.DAT_28 / num16;
        }
        while (num14 < 4096);
        int num18 = 0;
        param2.DAT_14 += num15 * 2;
        Junction junction = FUN_50C0(num15);
        num16 = (param1[0, 0] + param1[2, 1]) / 2;
        int z = (param1[0, 2] + param1[2, 3]) / 2;
        uint y = (uint)vigTerrain.FUN_1B750((uint)num16, (uint)z);
        junction.pos = new Vector3Int(num16, (int)y, z);
        junction.xrtp = param2;
        junction.GetComponent<MeshRenderer>().materials = junction.xrtp.timFarList.ToArray();
        num16 = 0;
        if (-1 < num15)
        {
            int num19 = 0;
            int num20 = 0;
            int num21 = 0;
            do
            {
                int num17 = num16 * num16;
                if (num17 < 0)
                {
                    num17 += 4095;
                }
                num17 >>= 12;
                z = num17 * num16;
                if (z < 0)
                {
                    z += 4095;
                }
                int num22 = (num >> 4) * (z >> 12) + (num3 >> 4) * num17 + num5 * num16;
                if (num22 < 0)
                {
                    num22 += 255;
                }
                int num23 = (num2 >> 4) * (z >> 12) + (num4 >> 4) * num17 + num6 * num16;
                z = (num22 >> 8) + num7;
                if (num23 < 0)
                {
                    num23 += 255;
                }
                num22 = (int)num9 * num17 + num11 * num16;
                num23 = (num23 >> 8) + num8;
                if (num22 < 0)
                {
                    num22 += 4095;
                }
                num22 = (num22 >> 12) + num5;
                if (num22 < 0)
                {
                    num22 += 255;
                }
                num17 = (int)num10 * num17 + num12 * num16;
                num22 >>= 8;
                if (num17 < 0)
                {
                    num17 += 4095;
                }
                num17 = (num17 >> 12) + num6;
                if (num17 < 0)
                {
                    num17 += 255;
                }
                num17 >>= 8;
                int num24 = (int)Utilities.SquareRoot(num22 * num22 + num17 * num17);
                int num25 = num17 * param2.DAT_24 / 2 / num24;
                int num26 = num22 * param2.DAT_24 / 2 / num24;
                num17 = z - num25;
                z += num25;
                num22 = num23 + num26;
                num23 -= num26;
                if ((param3 & 1) == 0)
                {
                    Vector2Int vector2Int = default(Vector2Int);
                    Vector2Int vector2Int2 = default(Vector2Int);
                    vector2Int.x = num17 - junction.pos.x >> 8;
                    num25 = vigTerrain.FUN_1B750((uint)num17, (uint)num22);
                    vector2Int.y = num25 - junction.pos.y >> 8;
                    num25 = num22 - junction.pos.z;
                    vector2Int2.x = num25 >> 8;
                    if (num17 < 0)
                    {
                        num17 += 65535;
                    }
                    if (num22 < 0)
                    {
                        num22 += 65535;
                    }
                    vector2Int2.y = (int)((uint)vigTerrain.vertices[vigTerrain.chunks[(((uint)(num22 >> 16) >> 6) * 4 + ((uint)(num17 >> 16) >> 6) * 128) / 4u] * 4096 + (((num22 >> 16) & 0x3F) * 2 + ((num17 >> 16) & 0x3F) * 128) / 2] >> 11 << 2);
                    junction.DAT_20.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
                    junction.DAT_26.Add((short)vector2Int2.y);
                    vector2Int.x = z - junction.pos.x >> 8;
                    num17 = vigTerrain.FUN_1B750((uint)z, (uint)num23);
                    vector2Int.y = num17 - junction.pos.y >> 8;
                    num17 = num23 - junction.pos.z;
                    if (z < 0)
                    {
                        z += 65535;
                    }
                    if (num23 < 0)
                    {
                        num23 += 65535;
                    }
                    vector2Int2.x = num17 >> 8;
                    vector2Int2.y = (int)((uint)vigTerrain.vertices[vigTerrain.chunks[(((uint)(num23 >> 16) >> 6) * 4 + ((uint)(z >> 16) >> 6) * 128) / 4u] * 4096 + (((num23 >> 16) & 0x3F) * 2 + ((z >> 16) & 0x3F) * 128) / 2] >> 11 << 2);
                    junction.DAT_28.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
                    junction.DAT_2E.Add((short)vector2Int2.y);
                }
                else
                {
                    long num27 = (long)(4096 - num16) * (long)param1[0, 1];
                    uint num28 = (uint)((long)num16 * (long)param1[2, 2]);
                    int num29 = (int)((ulong)((long)num16 * (long)param1[2, 2]) >> 32);
                    uint num30 = (uint)((int)num27 + num28);
                    num26 = (int)((ulong)num27 >> 32) + num29 + ((num30 < num28) ? 1 : 0);
                    num25 = FUN_9C10(num30, num26, 0u, 0);
                    if (num25 < 1)
                    {
                        num30 += 4095;
                        num26 += ((num30 < 4095) ? 1 : 0);
                    }
                    num30 = (uint)((int)(num30 >> 12) | (num26 << 20));
                    Vector2Int vector2Int = default(Vector2Int);
                    Vector2Int vector2Int2 = default(Vector2Int);
                    vector2Int.x = num17 - junction.pos.x >> 8;
                    vector2Int.y = (int)num30 - junction.pos.y >> 8;
                    vector2Int2.x = num22 - junction.pos.z >> 8;
                    num22 = Utilities.FUN_29C5C(v, DAT_10F8);
                    num17 = 0;
                    if (0 < num22)
                    {
                        num17 = num22;
                    }
                    if (num17 < 0)
                    {
                        num17 += 131071;
                    }
                    num22 = (num17 >> 17) + 32;
                    num17 = 128;
                    if (num22 < 128)
                    {
                        num17 = num22;
                    }
                    vector2Int2.y = num17;
                    junction.DAT_20.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
                    junction.DAT_26.Add((short)vector2Int2.y);
                    vector2Int.x = z - junction.pos.x >> 8;
                    vector2Int.y = (int)num30 - junction.pos.y >> 8;
                    vector2Int2.x = num23 - junction.pos.z >> 8;
                    z = Utilities.FUN_29C5C(v, DAT_10F8);
                    num17 = 0;
                    if (0 < z)
                    {
                        num17 = z;
                    }
                    if (num17 < 0)
                    {
                        num17 += 131071;
                    }
                    z = (num17 >> 17) + 32;
                    num17 = 128;
                    if (z < 128)
                    {
                        num17 = z;
                    }
                    vector2Int2.y = num17;
                    junction.DAT_28.Add(new Vector3Int(vector2Int.x, vector2Int.y, vector2Int2.x));
                    junction.DAT_2E.Add((short)vector2Int2.y);
                }
                num17 = Utilities.FUN_29DDC(junction.DAT_20[num19]);
                if (num17 < num13)
                {
                    num17 = num13;
                }
                num13 = Utilities.FUN_29DDC(junction.DAT_28[num19]);
                if (num13 < num17)
                {
                    num13 = num17;
                }
                num16 = ((num18 != num15 - 1) ? (num16 + param2.DAT_28 / num24) : 4096);
                num19++;
                num20++;
                num21++;
                num18++;
            }
            while (num18 <= num15);
        }
        num = (int)Utilities.SquareRoot(num13);
        junction.DAT_18 = num << 8;
        return junction;
    }

    private void FUN_630C(int[,] param1, XRTP_DB param2, ushort param3)
    {
        int num = FUN_57AC(new int[12]
        {
            param1[0, 0],
            param1[0, 1],
            param1[0, 2],
            param1[0, 3],
            param1[1, 0],
            param1[1, 1],
            param1[1, 2],
            param1[1, 3],
            param1[2, 0],
            param1[2, 1],
            param1[2, 2],
            param1[2, 3]
        });
        if (num < 1048576)
        {
            Junction item = FUN_5850(param1, param2, param3);
            counter++;
            roadList.Add(item);
            return;
        }
        num = (param1[0, 3] + param1[1, 2]) / 2;
        int num2 = (param1[1, 1] + param1[2, 0]) / 2;
        Vector3Int vector3Int = new Vector3Int(param1[0, 0], param1[0, 1], param1[0, 2]);
        Vector3Int vector3Int2 = new Vector3Int(param1[2, 1], param1[2, 2], param1[2, 3]);
        Vector3Int vector3Int3 = new Vector3Int((param1[0, 0] + param1[0, 3]) / 2, 0, (param1[0, 2] + param1[1, 1]) / 2);
        Vector3Int vector3Int4 = new Vector3Int((vector3Int3.x + num) / 2, 0, (vector3Int3.z + num2) / 2);
        Vector3Int vector3Int5 = new Vector3Int((param1[1, 2] + param1[2, 1]) / 2, 0, (param1[2, 0] + param1[2, 3]) / 2);
        Vector3Int vector3Int6 = new Vector3Int((vector3Int5.x + num) / 2, 0, (vector3Int5.z + num2) / 2);
        Vector3Int vector3Int7 = new Vector3Int((vector3Int4.x + vector3Int6.x) / 2, (param1[0, 1] + param1[2, 2]) / 2, (vector3Int4.z + vector3Int6.z) / 2);
        Vector3Int vector3Int8 = vector3Int7;
        FUN_630C(new int[3, 4]
        {
            {
                vector3Int.x,
                vector3Int.y,
                vector3Int.z,
                vector3Int3.x
            },
            {
                vector3Int3.y,
                vector3Int3.z,
                vector3Int4.x,
                vector3Int4.y
            },
            {
                vector3Int4.z,
                vector3Int7.x,
                vector3Int7.y,
                vector3Int7.z
            }
        }, param2, param3);
        FUN_630C(new int[3, 4]
        {
            {
                vector3Int8.x,
                vector3Int8.y,
                vector3Int8.z,
                vector3Int6.x
            },
            {
                vector3Int6.y,
                vector3Int6.z,
                vector3Int5.x,
                vector3Int5.y
            },
            {
                vector3Int5.z,
                vector3Int2.x,
                vector3Int2.y,
                vector3Int2.z
            }
        }, param2, param3);
    }

    private void FUN_6604(int[,] param1, int param2, int param3)
    {
        uint[] array = new uint[32];
        uint num = 0u;
        uint num2 = 32768u;
        int num3 = 0;
        uint num4 = 65536u;
        uint num5;
        do
        {
            num5 = (uint)param1[0, 3];
            uint num6 = 65536 - num2;
            int num7 = -((65536 < num2) ? 1 : 0) - num3;
            uint num8 = (uint)param1[1, 2];
            uint num9 = (uint)((long)num2 * (long)num8);
            uint num10 = (uint)((int)((long)num6 * (long)num5) + (int)num9);
            array[26] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num6 * (long)num5) >> 32) + (int)num6 * ((int)num5 >> 31) + (int)num5 * num7 + (int)((ulong)((long)num2 * (long)num8) >> 32) + (int)num2 * ((int)num8 >> 31) + (int)num8 * num3 + ((num10 < num9) ? 1 : 0), 65536, 0);
            num5 = (uint)param1[1, 1];
            num8 = (uint)param1[2, 0];
            num9 = (uint)((long)num2 * (long)num8);
            num10 = (uint)((int)((long)num6 * (long)num5) + (int)num9);
            array[25] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num6 * (long)num5) >> 32) + (int)num6 * ((int)num5 >> 31) + (int)num5 * num7 + (int)((ulong)((long)num2 * (long)num8) >> 32) + (int)num2 * ((int)num8 >> 31) + (int)num8 * num3 + ((num10 < num9) ? 1 : 0), 65536, 0);
            array[24] = array[26];
            array[0] = (uint)param1[0, 0];
            array[1] = (uint)param1[0, 1];
            array[2] = (uint)param1[0, 2];
            array[21] = (uint)param1[2, 1];
            array[22] = (uint)param1[2, 2];
            array[23] = (uint)param1[2, 3];
            num5 = (uint)param1[0, 0];
            num8 = (uint)param1[0, 3];
            num9 = (uint)((long)num2 * (long)num8);
            num10 = (uint)((int)((long)num6 * (long)num5) + (int)num9);
            array[27] = array[25];
            array[28] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num6 * (long)num5) >> 32) + (int)num6 * ((int)num5 >> 31) + (int)num5 * num7 + (int)((ulong)((long)num2 * (long)num8) >> 32) + (int)num2 * ((int)num8 >> 31) + (int)num8 * num3 + ((num10 < num9) ? 1 : 0), 65536, 0);
            array[29] = 0u;
            num5 = (uint)param1[0, 2];
            num8 = (uint)param1[1, 1];
            num9 = (uint)((long)num2 * (long)num8);
            num10 = (uint)((int)((long)num6 * (long)num5) + (int)num9);
            array[5] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num6 * (long)num5) >> 32) + (int)num6 * ((int)num5 >> 31) + (int)num5 * num7 + (int)((ulong)((long)num2 * (long)num8) >> 32) + (int)num2 * ((int)num8 >> 31) + (int)num8 * num3 + ((num10 < num9) ? 1 : 0), 65536, 0);
            array[3] = array[28];
            array[4] = array[29];
            num10 = (uint)((long)num2 * (long)array[24]);
            num5 = (uint)((int)((long)num6 * (long)array[28]) + (int)num10);
            array[30] = array[5];
            array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num6 * (long)array[28]) >> 32) + (int)num6 * ((int)array[28] >> 31) + (int)array[28] * num7 + (int)((ulong)((long)num2 * (long)array[24]) >> 32) + (int)num2 * ((int)array[24] >> 31) + (int)array[24] * num3 + ((num5 < num10) ? 1 : 0), 65536, 0);
            num10 = (uint)((long)num2 * (long)array[25]);
            array[27] = 0u;
            num5 = (uint)((int)((long)num6 * (long)array[5]) + (int)num10);
            array[8] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num6 * (long)array[5]) >> 32) + (int)num6 * ((int)array[5] >> 31) + (int)array[5] * num7 + (int)((ulong)((long)num2 * (long)array[25]) >> 32) + (int)num2 * ((int)array[25] >> 31) + (int)array[25] * num3 + ((num5 < num10) ? 1 : 0), 65536, 0);
            array[6] = array[26];
            array[7] = array[27];
            num5 = (uint)param1[2, 1];
            num8 = (uint)param1[1, 2];
            num9 = (uint)((long)num6 * (long)num8);
            num10 = (uint)((int)((long)num2 * (long)num5) + (int)num9);
            array[28] = array[8];
            array[26] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num2 * (long)num5) >> 32) + (int)num2 * ((int)num5 >> 31) + (int)num5 * num3 + (int)((ulong)((long)num6 * (long)num8) >> 32) + (int)num6 * ((int)num8 >> 31) + (int)num8 * num7 + ((num10 < num9) ? 1 : 0), 65536, 0);
            array[27] = 0u;
            num5 = (uint)param1[2, 3];
            num8 = (uint)param1[2, 0];
            num9 = (uint)((long)num6 * (long)num8);
            num10 = (uint)((int)((long)num2 * (long)num5) + (int)num9);
            array[20] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num2 * (long)num5) >> 32) + (int)num2 * ((int)num5 >> 31) + (int)num5 * num3 + (int)((ulong)((long)num6 * (long)num8) >> 32) + (int)num6 * ((int)num8 >> 31) + (int)num8 * num7 + ((num10 < num9) ? 1 : 0), 65536, 0);
            array[18] = array[26];
            array[19] = array[27];
            num10 = (uint)((long)num6 * (long)array[24]);
            num5 = (uint)((int)((long)num2 * (long)array[26]) + (int)num10);
            array[28] = array[20];
            array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num2 * (long)array[26]) >> 32) + (int)num2 * ((int)array[26] >> 31) + (int)array[26] * num3 + (int)((ulong)((long)num6 * (long)array[24]) >> 32) + (int)num6 * ((int)array[24] >> 31) + (int)array[24] * num7 + ((num5 < num10) ? 1 : 0), 65536, 0);
            num10 = (uint)((long)num6 * (long)array[25]);
            array[27] = 0u;
            num5 = (uint)((int)((long)num2 * (long)array[20]) + (int)num10);
            array[17] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num2 * (long)array[20]) >> 32) + (int)num2 * ((int)array[20] >> 31) + (int)array[20] * num3 + (int)((ulong)((long)num6 * (long)array[25]) >> 32) + (int)num6 * ((int)array[25] >> 31) + (int)array[25] * num7 + ((num5 < num10) ? 1 : 0), 65536, 0);
            array[15] = array[26];
            array[16] = array[27];
            num10 = (uint)((long)num2 * (long)array[26]);
            num5 = (uint)((int)((long)num6 * (long)array[6]) + (int)num10);
            array[28] = array[17];
            array[26] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num6 * (long)array[6]) >> 32) + (int)num6 * ((int)array[6] >> 31) + (int)array[6] * num7 + (int)((ulong)((long)num2 * (long)array[26]) >> 32) + (int)num2 * ((int)array[26] >> 31) + (int)array[26] * num3 + ((num5 < num10) ? 1 : 0), 65536, 0);
            num5 = (uint)param1[0, 1];
            num8 = (uint)param1[2, 2];
            num9 = (uint)((long)num2 * (long)num8);
            num10 = (uint)((int)((long)num6 * (long)num5) + (int)num9);
            array[27] = (uint)Utilities.Divdi3((int)num10, (int)((ulong)((long)num6 * (long)num5) >> 32) + (int)num6 * ((int)num5 >> 31) + (int)num5 * num7 + (int)((ulong)((long)num2 * (long)num8) >> 32) + (int)num2 * ((int)num8 >> 31) + (int)num8 * num3 + ((num10 < num9) ? 1 : 0), 65536, 0);
            num10 = (uint)((long)num2 * (long)array[17]);
            num5 = (uint)((int)((long)num6 * (long)array[8]) + (int)num10);
            array[28] = (uint)Utilities.Divdi3((int)num5, (int)((ulong)((long)num6 * (long)array[8]) >> 32) + (int)num6 * ((int)array[8] >> 31) + (int)array[8] * num7 + (int)((ulong)((long)num2 * (long)array[17]) >> 32) + (int)num2 * ((int)array[17] >> 31) + (int)array[17] * num3 + ((num5 < num10) ? 1 : 0), 65536, 0);
            array[12] = array[26];
            array[13] = array[27];
            array[14] = array[28];
            array[9] = array[26];
            array[10] = array[27];
            array[11] = array[28];
            num5 = num2;
            if (param2 == 0)
            {
                long num11 = (long)((int)array[26] - param1[0, 0]) * (long)((int)array[26] - param1[0, 0]);
                long num12 = (long)((int)array[28] - param1[0, 2]) * (long)((int)array[28] - param1[0, 2]);
                uint num13 = (uint)num12;
                int num14 = (int)((ulong)num12 >> 32);
                num7 = (int)((ulong)((long)param3 * (long)param3) >> 32);
                num10 = (uint)((int)num11 + num13);
                num3 = (int)((ulong)num11 >> 32) + num14 + ((num10 < num13) ? 1 : 0);
                if (num3 <= num7 && (num3 != num7 || num10 <= (uint)((long)param3 * (long)param3)))
                {
                    num5 = num4;
                    num = num2;
                }
            }
            else
            {
                long num15 = (long)((int)array[26] - param1[2, 1]) * (long)((int)array[26] - param1[2, 1]);
                long num16 = (long)((int)array[28] - param1[2, 3]) * (long)((int)array[28] - param1[2, 3]);
                uint num13 = (uint)num16;
                int num14 = (int)((ulong)num16 >> 32);
                num7 = (int)((ulong)((long)param3 * (long)param3) >> 32);
                num10 = (uint)((int)num15 + num13);
                num3 = (int)((ulong)num15 >> 32) + num14 + ((num10 < num13) ? 1 : 0);
                if (num7 < num3 || (num3 == num7 && (uint)((long)param3 * (long)param3) < num10))
                {
                    num5 = num4;
                    num = num2;
                }
            }
            num3 = (int)(num + num5);
            num2 = (uint)(num3 / 2);
            num3 = num3 - (int)((uint)num3 >> 31) >> 31;
            num4 = num5;
        }
        while ((int)(num5 - num) >= 2);
        int num17 = 0;
        if (param2 == 0)
        {
            num17 = 12;
            int num18 = 0;
            while (num17 < 24)
            {
                num4 = array[num17 + 1];
                num = array[num17 + 2];
                num2 = array[num17 + 3];
                param1[num18, 0] = (int)array[num17];
                param1[num18, 1] = (int)num4;
                param1[num18, 2] = (int)num;
                param1[num18, 3] = (int)num2;
                num17 += 4;
                num18++;
            }
        }
        else
        {
            int num19 = 0;
            while (num17 < 12)
            {
                num4 = array[num17 + 1];
                num = array[num17 + 2];
                num2 = array[num17 + 3];
                param1[num19, 0] = (int)array[num17];
                param1[num19, 1] = (int)num4;
                param1[num19, 2] = (int)num;
                param1[num19, 3] = (int)num2;
                num17 += 4;
                num19++;
            }
        }
    }
}
