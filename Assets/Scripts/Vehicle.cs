using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using TMPro;
using V2UnityDiscordIntercept;
using Unity.Burst;

public enum _WHEELS
{
    Ground,
    Air,
    Sea,
    Snow
};

public enum _VEHICLE
{
    Wonderwagon,
    Thunderbolt,
    DakotaCycle,
    SamsonTow,
    Livingston,
    Xanadu,
    Palomino,
    ElGuerrero,
    BlueBurro,
    Excelsior,
    Tsunami,
    Marathon,
    Trekker,
    Loader,
    Stinger,
    Vertigo,
    Goliath,
    Wapiti,
    NONE //0xFF
};

public enum _CAR_VIEW
{
    NoHUD,
    Far,
    Close
}

public enum _VEHICLE_TYPE
{
    LoadWonderwagon, //FUN_368DC
    LoadThunderbolt, //FUN_36900
    LoadDakota, //FUN_36924
    LoadSamson, //FUN_36948
    LoadLivingston, //FUN_36B40
    LoadXanadu, //FUN_3696C
    LoadPalomino, //FUN_36990
    LoadGuerrero, //FUN_369B4
    LoadBurro, //FUN_369D8
    LoadExcelsior, //FUN_369FC
    LoadTsunami, //FUN_36A20
    LoadMarathon, //FUN_36A44
    LoadTrekker, //FUN_36A68
    LoadLoader, //FUN_36A8C
    LoadStinger, //FUN_36AB0
    LoadVertigo, //FUN_36AD4
    LoadGoliath, //FUN_36AF8
    LoadWapiti, //FUN_36B1C
    Vehicle, //FUN_3C118
    Chasis, //FUN_384A4
    Wrecked, //FUN_38CA4
    Drowning, //FUN_38F7C
    Collector, //FUN_230 (GRBLDER.DLL)
    Observatory, //FUN_E1C (ROUTE66.DLL)
    Observatory2, //FUN_1070 (ROUTE66.DLL)
    Gondola, //FUN_DEC (OLYMPIC.DLL)
    Hotel, //FUN_2004 (OLYMPIC.DLL)
    SkiJump, //FUN_2658 (OLYMPIC.DLL)
    SkiJump2, //FUN_2AF8 (OLYMPIC.DLL)
    WindTunnel, //FUN_28B8 (LAUNCH.DLL)
    Fence, //FUN_36D4 (LAUNCH.DLL)
    LaunchEntry, //FUN_48D0 (LAUNCH.DLL)
    LaunchEntry2, //FUN_4628 (LAUNCH.DLL)
    Mansion, //FUN_2630 (BAYOU.DLL)
    NuclearTunnel, //FUN_580 (NUCLEAR.DLL)
    TransferBooth, //FUN_5F4 (NUCLEAR.DLL)
    Transformer, //FUN_BE8 (NUCLEAR.DLL)
    MilTunnel, //FUN_558 (STEELMIL.DLL)
    Tunnel, //FUN_AC4 (STEELMIL.DLL)
    Crane, //FUN_2C08 (STEELMIL.DLL)
    Pipe, //FUN_12FC (OILFIELD.DLL)
    Harbor, //FUN_644 (HARBOR.DLL)
    CraneSmall, //FUN_13FC (HARBOR.DLL)
    Warehouse, //FUN_9E0 (HARBOR.DLL)
    Lighthouse, //FUN_F28 (HARBOR.DLL)
    Beamup,
    Dam,
    Blimp,
    Gondola2,
    Factory
}

[BurstCompile]
public class Vehicle : VigObject
{
    public struct AI
    {
        public short DAT_00;

        public short DAT_02;

        public short[] DAT_04;

        public int DAT_08;

        public int DAT_0C;

        public ushort rubberTimer;

        public bool FUN_51C54(Vector3Int param1, Vector3Int param2, uint param3, uint param4)
        {
            short[] array = GameManager.instance.FUN_51ED4(param1, param2, param3, param4);
            if (FUN_51BDC(array) == 0)
            {
                DAT_08 = param2.x;
                DAT_0C = param2.z;
            }
            return array != null;
        }

        public int FUN_51CFC(VigObject param1, int param2)
        {
            int num = DAT_08 - param1.vTransform.position.x;
            if (num < 0)
            {
                num = -num;
            }
            if (num < param2)
            {
                num = DAT_0C - param1.vTransform.position.z;
                if (num < 0)
                {
                    num = -num;
                }
                if (num < param2)
                {
                    if (0 < DAT_00)
                    {
                        short dAT_ = DAT_02;
                        DAT_02++;
                        short num2 = DAT_04[(dAT_ + 1 << 16 >> 14) / 2];
                        short num3 = DAT_04[(dAT_ + 1 << 16 >> 14) / 2 + 1];
                        if (num2 != 0 || num3 != 0)
                        {
                            DAT_08 = num2 << 16;
                            DAT_0C = num3 << 16;
                            goto IL_00b3;
                        }
                    }
                    DAT_00 = -1;
                }
            }
            goto IL_00b3;
        IL_00b3:
            Vector3Int vector3Int = default(Vector3Int);
            vector3Int.y = 0;
            vector3Int.x = DAT_08 - param1.vTransform.position.x;
            num = DAT_0C;
            int z = param1.vTransform.position.z;
            vector3Int.z = num - z;
            vector3Int = Utilities.FUN_2426C(param1.vTransform.rotation, new Matrix2x4(vector3Int.x, vector3Int.y, vector3Int.z, 0));
            return (int)((long)Utilities.Ratan2(vector3Int.x, vector3Int.z) << 20) >> 20;
        }

        public int FUN_51BDC(short[] param1)
        {
            DAT_04 = param1;
            DAT_02 = 0;
            DAT_00 = (short)((param1 != null) ? 1 : 0);
            if (param1 != null)
            {
                DAT_08 = param1[0] << 16;
                DAT_0C = param1[1] << 16;
            }
            return DAT_00;
        }

        public void FUN_51CC0()
        {
            DAT_04 = null;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass105_0
    {
        public Vector3Int local_60;

        public Vehicle _003C_003E4__this;

        public Vector3Int local_40;

        public Vector3Int local_a0;

        public int iVar5;

        public Vector3Int local_b0;

        public TileData local_28;
    }

    [StructLayout(LayoutKind.Auto)]
    [CompilerGenerated]
    private struct _003C_003Ec__DisplayClass142_0
    {
        public Vector3Int local_40;

        public Vehicle _003C_003E4__this;

        public int iVar3;

        public TileData local_20;

        public int iVar4;

        public Vector3Int local_30;

        public Vector3Int local_50;

        public Vector3Int local_60;
    }

    public short turning;

    public short acceleration;

    public _WHEELS wheelsType;

    public sbyte direction;

    public byte weaponSlot;

    public byte DAT_AF;

    public sbyte DAT_B0;

    public sbyte DAT_B0_2;

    public sbyte DAT_B1;

    public sbyte DAT_B2;

    public byte DAT_B3;

    public ushort DAT_B4;

    public short[] DAT_B6;

    public short ignition;

    public ushort DAT_BA;

    public sbyte DAT_BB;

    public byte DAT_BC;

    public byte DAT_BD;

    public ushort DAT_BE;

    public ushort DAT_BF;

    public byte DAT_C0;

    public sbyte breaking;

    public byte DAT_C2;

    public byte DAT_C3;

    public byte DAT_C4;

    public byte DAT_C5;

    public short DAT_C6;

    public short DAT_C8;

    public AI ai;

    public _VEHICLE vehicle;

    public _CAR_VIEW view;

    public byte DAT_DE;

    public byte DAT_DF;

    public short DAT_E0;

    public short DAT_E2;

    public int DAT_E4;

    public int lightness;

    public int peelSpeed;

    public VigCamera vCamera;

    public VigObject target;

    public short DAT_F4;

    public ushort DAT_F6;

    public VigObject[] body;

    public VigObject closeViewer;

    public Wheel[] wheels;

    public VigObject mgun;

    public VigObject[] weapons;

    public ushort transformation;

    public ushort doubleDamage;

    public ushort shield;

    public ushort jammer;

    public ushort flip;

    public ushort peelout;

    public byte timer;

    public byte timer2;

    public bool wheelOnGround;

    public long userId;

    public List<VigObject> targetList = new List<VigObject>();

    public VigObject manualAim;

    public Trailer2 trailer;

    public _VEHICLE_TYPE state;

    public RawImage unit;
    public TextMeshPro gameTag;

    private VigConfig config;

    public ushort GetPowerup(int index)
    {
        switch (index)
        {
            case 0:
                return doubleDamage;
            case 1:
                return shield;
            default:
                return jammer;
        }
    }

    public void SetPowerup(int index, ushort value)
    {
        switch (index)
        {
            case 0:
                doubleDamage = value;
                break;
            case 1:
                shield = value;
                break;
            default:
                jammer = value;
                break;
        }
    }

    private void Awake()
    {
        config = GetComponent<VigConfig>();
        weapons = new VigObject[3];
        DAT_B6 = new short[3];
    }

    protected override void Start()
    {
        Debug.Log("User: " + Plugin.Username);
        base.Start();
    }

    public string namePlayer = " ";
    private bool setGameTag = true;
    private bool setGameTagLocal = true;

    protected override void Update()
    {
        base.Update();

        //Asigna GameTag al vehiculo correcto.
        if (setGameTag)
        {
            setGameTag = false;
            foreach (var valueVehicle in GameManager.instance.networkMembers.Values)
            {
                if (valueVehicle == this)
                {
                    Debug.Log("Same Vehicle");
                    Debug.Log("GameTag Set...");
                    gameTag = UIManager.instance.InstantiateGameTag();
                    gameTag.text = Demo.instance.playerNames[valueVehicle.userId];
                    namePlayer = gameTag.text;
                    Debug.Log("Pass...");
                    Debug.Log("Vehiculo object: " + valueVehicle);
                    Debug.Log("Vehiculo object local: " + this);
                    Debug.Log("userId de Vehiculo: " + valueVehicle.userId);
                    Debug.Log("userId de Vehiculo local: " + this.userId);
                    Debug.Log("Tipo de Vehiculo: " + valueVehicle.vehicle);
                    Debug.Log("Tipo de Vehiculo local: " + this.vehicle);
                    Debug.Log("GameTag: " + valueVehicle.gameTag.text);
                    Debug.Log("GameTag local: " + gameTag.text);
                }
            }
        }

        if (GameManager.instance.playerObjects[0] == this)
        {
            //if (setGameTagLocal)
            //{
            //    setGameTagLocal = false;
            //    gameTag = UIManager.instance.InstantiateGameTag();
            //    gameTag.text = Demo.instance.playerNames[0];
            //    Debug.Log("Local Name Player: " + gameTag.text);
            //}
            //else
            //{
            //    Debug.Log("Update GameTag" + gameTag.text + " Vehicle: " + this.vehicle);
            //    UIManager.instance.GameTagPlayer(gameTag, this, true);
            //}
        }
    }

    public override uint OnCollision(HitDetection hit)
    {
        switch (state)
        {
            case _VEHICLE_TYPE.Vehicle:
            case _VEHICLE_TYPE.SkiJump2:
                {
                    VigObject @object = hit.object1;
                    uint num = 0u;
                    if (@object != this && @object.GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        num = ((@object.OnCollision(hit) != 0) ? 1u : 0u);
                    }
                    if (num != 0)
                    {
                        return num;
                    }
                    return (uint)FUN_3B424(this, hit);
                }
            case _VEHICLE_TYPE.Chasis:
                {
                    if (hit.self.type == 3)
                    {
                        return 0u;
                    }
                    if (hit.object2.type == 3)
                    {
                        return 0u;
                    }
                    HitDetection hit2 = GameManager.instance.FUN_2F798(this, hit);
                    FUN_2B834(hit2);
                    break;
                }
            case _VEHICLE_TYPE.Wrecked:
                return (uint)FUN_3B424(this, hit);
            case _VEHICLE_TYPE.LaunchEntry:
                return (uint)FUN_3B424(this, hit);
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (state)
        {
            case _VEHICLE_TYPE.LoadDakota:
                return Biker.LoadDakota(this, arg1, arg2, param4: true);
            case _VEHICLE_TYPE.LoadLivingston:
                return Trailer.LoadTrailer(this, arg1, arg2);
            case _VEHICLE_TYPE.LoadWonderwagon:
            case _VEHICLE_TYPE.LoadThunderbolt:
            case _VEHICLE_TYPE.LoadSamson:
            case _VEHICLE_TYPE.LoadXanadu:
            case _VEHICLE_TYPE.LoadPalomino:
            case _VEHICLE_TYPE.LoadGuerrero:
            case _VEHICLE_TYPE.LoadBurro:
            case _VEHICLE_TYPE.LoadExcelsior:
            case _VEHICLE_TYPE.LoadTsunami:
            case _VEHICLE_TYPE.LoadMarathon:
            case _VEHICLE_TYPE.LoadTrekker:
            case _VEHICLE_TYPE.LoadLoader:
            case _VEHICLE_TYPE.LoadStinger:
            case _VEHICLE_TYPE.LoadVertigo:
            case _VEHICLE_TYPE.LoadGoliath:
            case _VEHICLE_TYPE.LoadWapiti:
                return FUN_367A4(arg1, arg2);
            case _VEHICLE_TYPE.Vehicle:
                return FUN_3C118(arg1, arg2);
            case _VEHICLE_TYPE.Chasis:
                {
                    if (arg1 == 2)
                    {
                        VigCollider vCollider = base.vCollider;
                        int num;
                        if ((flags & 0x40000) != 0)
                        {
                            num = (int)GameManager.FUN_2AC5C();
                            Vector3Int param = default(Vector3Int);
                            param.x = (num * 3051 >> 15) - 1525;
                            param.y = -4577;
                            num = (int)GameManager.FUN_2AC5C();
                            param.z = (num * 3051 >> 15) - 1525;
                            LevelManager.instance.FUN_4AA24((ushort)GameManager.DAT_63FA4[14 + GameManager.instance.DAT_1004], vTransform.position, param).flags |= 33816576u;
                        }
                        num = 0;
                        do
                        {
                            if (wheels[num] != null)
                            {
                                Throwaway throwaway = wheels[num].FUN_4ECA0();
                            }
                            num++;
                        }
                        while (num < 6);
                        if (mgun != null)
                        {
                            Throwaway throwaway = mgun.FUN_4ECA0();
                        }
                        num = 0;
                        do
                        {
                            if (weapons[num] != null)
                            {
                                Throwaway throwaway = weapons[num].FUN_4ECA0();
                                if (throwaway.maxHalfHealth != 0 && throwaway.tags != 7)
                                {
                                    throwaway.state = _THROWAWAY_TYPE.Spawnable;
                                }
                            }
                            num++;
                        }
                        while (num < 3);
                        for (int i = 0; i < weapons.Length; i++)
                        {
                            weapons[i] = null;
                        }
                        num = (int)FUN_4DC20();
                        if (num != 0)
                        {
                            FUN_4D8A8(vData, (ushort)num, null);
                        }
                        base.vCollider = vCollider;
                        flags &= 4294934495u;
                        Smoke3 smoke = LevelManager.instance.xobfList[19].FUN_4F730(21, GameManager.DAT_9C4);
                        smoke.flags |= 33554432u;
                        Utilities.FUN_2CC9C(this, smoke);
                        smoke.transform.parent = base.transform;
                        smoke.FUN_30B78();
                        smoke.FUN_30BF0();
                        GameManager.instance.FUN_30CB0(smoke, 480);
                        return 0u;
                    }
                    if (arg1 >= 3)
                    {
                        break;
                    }
                    if (arg1 != 0)
                    {
                        return 0u;
                    }
                    if (base.id < 0 && GameManager.instance.terrain.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z).DAT_10[3] == 7)
                    {
                        physics1.X = -physics1.X;
                        physics1.Z = -physics1.Z;
                        physics1.Y = -physics1.Y;
                    }
                    if ((DAT_F6 & 0x200) != 0)
                    {
                        break;
                    }
                    if ((flags & 0x8000) != 0)
                    {
                        FUN_41AE8();
                        return 0u;
                    }
                    base.vCollider.reader.Seek(4L, SeekOrigin.Current);
                    FUN_2B4F8(base.vCollider.reader);
                    base.vCollider.reader.Seek(-4L, SeekOrigin.Current);
                    screen = vTransform.position;
                    int id = base.id;
                    short num2 = ++DAT_C8;
                    if (id < 0 && (GameManager.instance.gameMode < _GAME_MODE.Unk2 || GameManager.instance.gameMode >= _GAME_MODE.Versus2))
                    {
                        return 0u;
                    }
                    if (num2 == 540)
                    {
                        if (id < 0)
                        {
                            GameManager.instance.FUN_307CC(GameManager.instance.playerObjects[~id].vCamera);
                            GameManager.instance.playerObjects[~base.id] = null;
                        }
                        int param2 = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, 66, vTransform.position);
                        LevelManager.instance.FUN_4DE54(vTransform.position, 39);
                        GameManager.instance.FUN_309A0(this);
                        return uint.MaxValue;
                    }
                    break;
                }
            case _VEHICLE_TYPE.Wrecked:
                {
                    uint result;
                    if (arg1 == 2)
                    {
                        if (base.id > 0 && unit != null)
                        {
                            Debug.Log("Type unit: " + unit);
                            UIManager.instance.CalculateUnitPosition(unit, this);
                        }
                        FUN_38C40();
                        result = 0u;
                    }
                    else if (arg1 < 3)
                    {
                        result = 0u;
                        if (arg1 == 0)
                        {
                            if (base.id < 0 && GameManager.instance.terrain.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z).DAT_10[3] == 7)
                            {
                                physics1.X = -physics1.X;
                                physics1.Z = -physics1.Z;
                                physics1.Y = -physics1.Y;
                            }
                            if ((DAT_F6 & 0x200) == 0)
                            {
                                FUN_41AE8();
                            }
                            else
                            {
                                FUN_41E08();
                            }
                            result = GameManager.instance.FUN_1E478(vTransform.position);
                            GameManager.instance.FUN_1E2C8(DAT_18, result);
                            result = 0u;
                        }
                    }
                    else
                    {
                        result = 0u;
                        if (arg1 == 4)
                        {
                            FUN_38484();
                            result = 0u;
                        }
                    }
                    return result;
                }
            case _VEHICLE_TYPE.Drowning:
                return FUN_38F7C(arg1, arg2);
            case _VEHICLE_TYPE.Collector:
                if (arg1 == 4)
                {
                    PDAT_74.PDAT_74 = null;
                    FUN_38484();
                }
                break;
            case _VEHICLE_TYPE.Observatory:
                return FUN_E1C(arg1, arg2);
            case _VEHICLE_TYPE.Observatory2:
                return FUN_1070(arg1, arg2);
            case _VEHICLE_TYPE.Gondola:
                return FUN_DEC(arg1, arg2);
            case _VEHICLE_TYPE.Hotel:
                return FUN_2004(arg1, arg2);
            case _VEHICLE_TYPE.SkiJump:
                return FUN_2658(arg1, arg2);
            case _VEHICLE_TYPE.SkiJump2:
                return FUN_2AF8(arg1, arg2);
            case _VEHICLE_TYPE.WindTunnel:
                return FUN_28B8(arg1, arg2);
            case _VEHICLE_TYPE.Fence:
                return FUN_36D4(arg1, arg2);
            case _VEHICLE_TYPE.LaunchEntry:
                return FUN_48D0(arg1, arg2);
            case _VEHICLE_TYPE.LaunchEntry2:
                return FUN_4628(arg1, arg2);
            case _VEHICLE_TYPE.Mansion:
                return FUN_2630(arg1, arg2);
            case _VEHICLE_TYPE.NuclearTunnel:
                return FUN_580(arg1, arg2);
            case _VEHICLE_TYPE.TransferBooth:
                return FUN_5F4(arg1, arg2);
            case _VEHICLE_TYPE.Transformer:
                return FUN_BE8(arg1, arg2);
            case _VEHICLE_TYPE.MilTunnel:
                return FUN_558(arg1, arg2);
            case _VEHICLE_TYPE.Tunnel:
                return FUN_AC4(arg1, arg2);
            case _VEHICLE_TYPE.Crane:
                return FUN_2C08(arg1, arg2);
            case _VEHICLE_TYPE.Pipe:
                return FUN_12FC(arg1, arg2);
            case _VEHICLE_TYPE.Harbor:
                return FUN_644(arg1, arg2);
            case _VEHICLE_TYPE.CraneSmall:
                return FUN_13FC(arg1, arg2);
            case _VEHICLE_TYPE.Warehouse:
                return FUN_9E0(arg1, arg2);
            case _VEHICLE_TYPE.Lighthouse:
                return FUN_F28(arg1, arg2);
            case _VEHICLE_TYPE.Beamup:
                return FUN_C40(arg1, arg2);
            case _VEHICLE_TYPE.Dam:
                return FUN_910(arg1, arg2);
            case _VEHICLE_TYPE.Blimp:
                return FUN_C80(arg1, arg2);
            case _VEHICLE_TYPE.Gondola2:
                return FUN_109C(arg1, arg2);
            case _VEHICLE_TYPE.Factory:
                return FUN_C78(arg1, arg2);
        }
        return 0u;
    }

    private uint FUN_38F7C(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                {
                    flags = (uint)(((int)flags & -131105) | 8);
                    FUN_39C94();
                    if (0 < id)
                    {
                        tags = 1;
                    }
                    int num = (int)LevelManager.instance.level.UpdateW(this, 19, 0);
                    if (-1 < num)
                    {
                        FUN_41FEC();
                        VigCamera vigCamera = vCamera;
                        if (vigCamera != null)
                        {
                            vigCamera.flags &= 4227858431u;
                        }
                        flags &= 4261412863u;
                    }
                    break;
                }
            case 0:
                {
                    FUN_2AF20();
                    int x = physics1.X;
                    int num = x;
                    if (x < 0)
                    {
                        num = x + 31;
                    }
                    physics1.X = x - (num >> 5);
                    num = -physics1.Y;
                    x = num + 195200;
                    if (x < 0)
                    {
                        x = num + 195231;
                    }
                    int z = physics1.Z;
                    physics1.Y += x >> 5;
                    num = z;
                    if (z < 0)
                    {
                        num = z + 31;
                    }
                    x = physics2.X;
                    physics1.Z = z - (num >> 5);
                    num = x;
                    if (x < 0)
                    {
                        num = x + 31;
                    }
                    z = physics2.Y;
                    physics2.X = x - (num >> 5);
                    num = z;
                    if (z < 0)
                    {
                        num = z + 31;
                    }
                    x = physics2.Z;
                    physics2.Y = z - (num >> 5);
                    num = x;
                    if (x < 0)
                    {
                        num = x + 31;
                    }
                    physics2.Z = x - (num >> 5);
                    if ((GameManager.FUN_2AC5C() & 7) == 0)
                    {
                        num = (int)GameManager.FUN_2AC5C();
                        z = vTransform.position.x;
                        x = (int)GameManager.FUN_2AC5C();
                        LevelManager.instance.FUN_38F38(z + (num * 81920 >> 15) - 40960, vTransform.position.z + (x * 81920 >> 15) - 40960);
                    }
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    int unint = 0;

    public uint FUN_367A4(int arg1, int arg2)
    {
        if (arg1 == 1)
        {
            uint flags = base.flags;
            state = _VEHICLE_TYPE.Vehicle;
            base.flags = ((flags & 0xFFFF) | 0x16088);
            int y = screen.y;
            screen.y = y - 32768;
            vTransform.position.y = y - 32768;
            target = GameManager.instance.playerObjects[0];
            ushort num = maxFullHealth = ((!(body[0] == null)) ? ((ushort)(body[0].maxHalfHealth + body[1].maxHalfHealth)) : maxHalfHealth);
            FUN_3A500(flags | 0x1000000);
            if (GameManager.instance.gameMode != _GAME_MODE.Versus2 && id > 0 && (flags & 0x1840000) != 0)
            {
                vTransform.position.y -= 16384;
                _WHEELS param = _WHEELS.Snow;
                int type = 9;
                if ((flags & 0x800000) == 0)
                {
                    uint num2 = 262144u;
                    if ((flags & 0x1000000) != 0)
                    {
                        param = _WHEELS.Sea;
                        type = 8;
                    }
                }
                FUN_3E32C(param, 500);
                if (GameManager.instance.gameMode > _GAME_MODE.Versus2)
                {
                    ClientSend.PickupAI(id, type, 0, 0);
                }
            }
            if (id > 0)
            {
                unint += 1;
                Debug.Log("instantiateunint: " + unint);
                //Genera Objetivos en Radar
                unit = UIManager.instance.InstantiateUnit();
                Debug.Log("instantiateUnit: " + unit);
                gameTag = UIManager.instance.InstantiateGameTag();
            }
            if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && id == -2)
            {
                unit = UIManager.instance.InstantiateFriendlyUnit();
            }
            if ((LevelManager.instance.level.flags & 0x2000) != 0)
            {
                FUN_3670C(param1: true);
            }
            VigObject vigObject = new GameObject().AddComponent<VigObject>();
            vigObject.screen = new Vector3Int(0, 0, 524288);
            vigObject.ApplyTransformation();
            Utilities.FUN_2CC9C(this, vigObject);
            vigObject.transform.parent = base.transform;
            vigObject.type = 12;
            manualAim = vigObject;
            return 0u;
        }
        return 0u;
    }

    private uint FUN_3C118(int arg1, int arg2)
    {
        switch (arg1)
        {
            default:
                return 0u;
            case 0:
                if (id < 0 && GameManager.instance.gameMode != _GAME_MODE.Demo)
                {
                    if (!GameManager.instance.terrain)
                    {
                        Debug.Log("No se encontro un componente Terrain");
                    }
                    else
                    {
                        TileData tileByPosition = GameManager.instance.terrain.GetTileByPosition((uint)vTransform.position.x, (uint)vTransform.position.z);
                        if (tileByPosition.DAT_10[3] == 7)
                        {
                            FUN_3BFC0();
                        }
                        if ((flags & 0x20000000) == 0)
                        {
                            if (DAT_DF != 0)
                            {
                                GameManager.instance.FUN_1DE78(DAT_DF);
                                DAT_DE = 0;
                                DAT_DF = 0;
                            }
                        }
                        else if (tileByPosition.DAT_10[4] != DAT_DE)
                        {
                            GameManager.instance.FUN_1DE78(DAT_DF);
                            DAT_DE = (byte)tileByPosition.DAT_10[4];
                            if ((byte)tileByPosition.DAT_10[4] == 0)
                            {
                                DAT_DF = 0;
                            }
                            else
                            {
                                ushort num = (ushort)LevelManager.instance.level.UpdateW(this, 12, tileByPosition);
                                DAT_DF = (byte)num;
                            }
                        }
                        FUN_3D424(InputManager.controllers[~id]);
                        FUN_3AC84(InputManager.controllers[~id]);
                        if (arg2 != 0)
                        {
                            FUN_3A844();
                        }
                    }
                }
                else
                {
                    short num2 = ignition;
                    if (num2 == 0)
                    {
                        if (!GameManager.instance.noAI && GameManager.instance.gameMode != _GAME_MODE.Versus2)
                        {
                            FUN_34728();
                        }
                        else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && !GameManager.instance.noAI)
                        {
                            FUN_34728();
                        }
                        if ((DAT_F6 & 0x10) != 0)
                        {
                            GameManager.instance.FUN_1E580(DAT_18, GameManager.instance.DAT_C2C, 32, vTransform.position);
                            DAT_18 = 0;
                            DAT_F6 &= 65519;
                        }
                    }
                    else
                    {
                        ignition--;
                        if (num2 == 1)
                        {
                            GameManager.instance.FUN_1E580(DAT_18, GameManager.instance.DAT_C2C, 32, vTransform.position);
                            DAT_18 = 0;
                            DAT_F6 &= 65519;
                        }
                        else
                        {
                            if (arg2 == 0)
                            {
                                goto IL_027d;
                            }
                            uint volume = GameManager.instance.FUN_1E478(vTransform.position);
                            GameManager.instance.FUN_1E2C8(DAT_18, volume);
                        }
                    }
                    if (arg2 != 0 && id < 0)
                    {
                        FUN_3A844();
                    }
                }
                goto IL_027d;
            case 2:
                break;
            IL_027d:
                FUN_3B344();
                if (arg2 != 0)
                {
                    uint num3 = (uint)((int)flags & -16809985);
                    if ((flags & 0x1000000) != 0)
                    {
                        num3 |= 0x8000;
                    }
                    flags = num3;
                }
                if (id != 0)
                {
                    GameManager.instance.FUN_30CB0(this, 0);
                    return 0u;
                }
                break;
        }
        if ((DAT_F6 & 0x200) == 0)
        {
            if (id > 0 && unit != null)
            {
                //Debug.Log("CalculateUnitPosition: " + unit.name + "vehicle: " + this.vehicle);
                UIManager.instance.CalculateUnitPosition(unit, this);

                //Verifica si es un Miembro o un NPC
                if (GameManager.instance.networkMembers.TryGetValue(this.userId, out Vehicle value))
                {
                    if (UIManager.instance.isGameTagPlayers)
                        if (gameTag.text == "")
                        {
                            gameTag.text = namePlayer;
                            UIManager.instance.GameTagPlayer(gameTag, this, true);
                        }
                        else
                            gameTag.text = "";
                }
                else
                {
                    if (UIManager.instance.isGameTagNPC)
                        UIManager.instance.GameTagPlayer(gameTag, this, false);
                    else
                        gameTag.text = "";
                }
            }
            FUN_41AE8();
        }
        else
        {
            FUN_41E08();
        }
        return 0u;
    }

    private uint FUN_E1C(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        {
                            physics1.X = 0;
                            flags &= 4294967261u;
                            physics1.Y = 0;
                            physics1.Z = 0;
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            FUN_30B78();
                            GameManager.instance.FUN_30CB0(this, 31);
                            break;
                        }
                    case 0:
                        {
                            ApplyTransformation();
                            VigCamera vigCamera = vCamera;
                            if (vigCamera != null)
                            {
                                vigCamera.flags &= 4227858431u;
                                VigObject pDAT_ = PDAT_74;
                                if (pDAT_ == null)
                                {
                                    vCamera.FUN_4BC0C();
                                }
                                else
                                {
                                    pDAT_.tags = 60;
                                    pDAT_.maxHalfHealth = 256;
                                    GameManager.instance.FUN_30CB0(vCamera, pDAT_.tags);
                                    vCamera.screen = pDAT_.screen;
                                    VigCamera vigCamera2 = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                                    LevelManager.instance.defaultCamera.transform.SetParent(vigCamera2.transform, worldPositionStays: false);
                                    vigCamera2.FUN_30B78();
                                }
                            }
                            FUN_30BA8();
                            GameManager.instance.FUN_30CB0(this, 2);
                            break;
                        }
                    case 2:
                        flags &= 4261412863u;
                        FUN_41FEC();
                        if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1)
                        {
                            FUN_3E32C(_WHEELS.Air, 500);
                            if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                            {
                                ClientSend.Pickup(7, 0, 0);
                            }
                        }
                        else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
                        {
                            FUN_3E32C(_WHEELS.Air, 500);
                            ClientSend.PickupAI(id, 7, 0, 0);
                        }
                        break;
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_1070(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        {
                            int num = vTransform.rotation.V02 * 7629;
                            flags &= 4294967293u;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.X = num >> 5;
                            num = vTransform.rotation.V12 * 7629;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Y = num >> 5;
                            num = vTransform.rotation.V22 * 7629;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            FUN_30B78();
                            GameManager.instance.FUN_30CB0(this, 61);
                            break;
                        }
                    case 0:
                        {
                            ApplyTransformation();
                            VigCamera vigCamera = vCamera;
                            if (vigCamera != null)
                            {
                                vigCamera.flags &= 4227858431u;
                                VigObject pDAT_ = PDAT_74;
                                if (pDAT_ != null)
                                {
                                    pDAT_.tags = 90;
                                    pDAT_.maxHalfHealth = 256;
                                    vCamera.screen = pDAT_.screen;
                                    GameManager.instance.FUN_30CB0(vCamera, pDAT_.tags);
                                    VigCamera vigCamera2 = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                                    LevelManager.instance.defaultCamera.transform.SetParent(vigCamera2.transform, worldPositionStays: false);
                                    vigCamera2.FUN_30B78();
                                }
                            }
                            flags |= 2u;
                            FUN_30BA8();
                            GameManager.instance.FUN_30CB0(this, 30);
                            break;
                        }
                    case 2:
                        tags = 0;
                        flags &= 4261412831u;
                        FUN_41FEC();
                        break;
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_DEC(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                flags |= 2u;
                ((OLYMPIC)LevelManager.instance.level).DAT_D2 = 60;
                break;
            case 0:
                if ((flags & 1) == 0)
                {
                    VigObject pDAT_ = PDAT_78;
                    ushort dAT_4A = pDAT_.DAT_4A;
                    vTransform = pDAT_.vTransform;
                    screen = pDAT_.vTransform.position;
                    OLYMPIC obj = (OLYMPIC)LevelManager.instance.level;
                    vTransform.position.y += 86016;
                    if (id < 0)
                    {
                        int num = InputManager.controllers[~id].stick[2] - 128;
                        int num2 = num;
                        if (num < 0)
                        {
                            num2 = -num;
                        }
                        if (32 < num2)
                        {
                            if (num < 0)
                            {
                                num = InputManager.controllers[~id].stick[2] - 125;
                            }
                            vCamera.DAT_92 -= (short)(num >> 2);
                        }
                    }
                    if (obj.DAT_D2 == 0 && (pDAT_.DAT_1A != 4 || 24576 < (short)dAT_4A || 57344 < pDAT_.DAT_4A || (id < 0 && (InputManager.controllers[~id].GetAxis() & 0x1000000) != 0 && 4096 < pDAT_.DAT_4A && -28672 < (short)dAT_4A)))
                    {
                        pDAT_.DAT_80 = null;
                        pDAT_.flags |= 32u;
                        GameManager.instance.FUN_30CB0(pDAT_, 120);
                        FUN_41FEC();
                        physics1.X = 0;
                        flags = (uint)(((int)flags & -33554467) | 8);
                        physics1.Y = 1525;
                        int z = (dAT_4A << 16 >= 0) ? 47800 : (-292864);
                        physics1.Z = z;
                    }
                }
                else
                {
                    int num3 = physics1.X;
                    if (num3 < 0)
                    {
                        num3 += 127;
                    }
                    int num4 = physics1.Y;
                    vTransform.position.x += num3 >> 7;
                    if (num4 < 0)
                    {
                        num4 += 127;
                    }
                    num3 = physics1.Z;
                    vTransform.position.y += num4 >> 7;
                    if (num3 < 0)
                    {
                        num3 += 127;
                    }
                    vTransform.position.z += num3 >> 7;
                }
                break;
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_2004(int arg1, int arg2)
    {
        if (arg1 != 2)
        {
            if (2 < arg1)
            {
                if (arg1 != 4)
                {
                    return 0u;
                }
                FUN_38484();
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            int num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            int num2 = physics1.Y;
            vTransform.position.x += num >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num = physics1.Z;
            vTransform.position.y += num2 >> 7;
            if (num < 0)
            {
                num += 127;
            }
            vTransform.position.z += num >> 7;
            return 0u;
        }
        sbyte b = tags++;
        if (b == 1)
        {
            int num = vTransform.rotation.V02 * 7629;
            flags &= 4261412861u;
            if (num < 0)
            {
                num += 31;
            }
            physics1.X = num >> 5;
            num = vTransform.rotation.V12 * 7629;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Y = num >> 5;
            num = vTransform.rotation.V22 * 7629;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Z = num >> 5;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
            FUN_30B78();
        }
        else
        {
            if (1 < b)
            {
                if (b != 2)
                {
                    return 0u;
                }
                tags = 0;
                flags &= 4294967263u;
                FUN_41FEC();
                return 0u;
            }
            if (b != 0)
            {
                return 0u;
            }
            ApplyTransformation();
            if (vCamera != null)
            {
                VigObject pDAT_ = PDAT_74;
                pDAT_.tags = 90;
                pDAT_.maxHalfHealth = 256;
                vCamera.flags &= 4227858431u;
                GameManager.instance.FUN_30CB0(vCamera, pDAT_.tags);
                VigCamera vigCamera = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
                vigCamera.FUN_30B78();
            }
            flags |= 2u;
            FUN_30BA8();
        }
        GameManager.instance.FUN_30CB0(this, 30);
        return 0u;
    }

    private uint FUN_2658(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        ApplyTransformation();
                        FUN_30BA8();
                        flags &= 4294967293u;
                        GameManager.instance.FUN_30CB0(this, 60);
                        break;
                    case 0:
                        {
                            GameManager.instance.FUN_30CB0(this, 60);
                            VigCamera vigCamera = vCamera;
                            if (vigCamera != null)
                            {
                                VigObject pDAT_ = PDAT_74;
                                int num2 = pDAT_.vTransform.position.y;
                                int y = vigCamera.vTransform.position.y;
                                int z = pDAT_.vTransform.position.z;
                                int z2 = vigCamera.vTransform.position.z;
                                VigCamera vigCamera2 = vCamera;
                                vigCamera2.DAT_84.x = (pDAT_.vTransform.position.x - vigCamera.vTransform.position.x) / 120;
                                vigCamera2.DAT_84.y = (num2 - y) / 120;
                                vigCamera2.DAT_84.z = (z - z2) / 120;
                                vCamera.DAT_90 = -682;
                            }
                            flags |= 2u;
                            physics1.X = (screen.x - vTransform.position.x) * 128 / 60;
                            physics1.Y = (screen.y - vTransform.position.y) * 128 / 60;
                            physics1.Z = (screen.z - vTransform.position.z) * 128 / 60;
                            break;
                        }
                    case 2:
                        {
                            VigCamera vigCamera = vCamera;
                            if (vigCamera != null)
                            {
                                vigCamera.DAT_84 = new Vector3Int(0, 0, 0);
                                vCamera.flags &= 4227858431u;
                            }
                            GameManager.instance.FUN_30CB0(this, 30);
                            break;
                        }
                    case 3:
                        {
                            physics2.X = 0;
                            flags &= 4261412863u;
                            physics2.Y = 0;
                            physics2.Z = 0;
                            int num = vTransform.rotation.V02 * 3051;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.X = num >> 5;
                            num = vTransform.rotation.V12 * 3051;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Y = num >> 5;
                            num = vTransform.rotation.V22 * 3051;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            FUN_30B78();
                            tags = 0;
                            flags &= 4294967263u;
                            FUN_41FEC();
                            if (vCamera != null)
                            {
                                SkiJump3 skiJump = new GameObject().AddComponent<SkiJump3>();
                                skiJump.PDAT_74 = vCamera;
                                GameManager.instance.FUN_30CB0(skiJump, 600);
                            }
                            break;
                        }
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_2AF8(int arg1, int arg2)
    {
        uint result = FUN_3C118(arg1, arg2);
        if ((flags & 0x20000000) == 0)
        {
            return result;
        }
        VigObject vigObject = GameManager.instance.FUN_318D0(81);
        OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
        Vector3Int phy = default(Vector3Int);
        phy.x = vTransform.position.x - 55902208;
        phy.y = vTransform.position.y - 55902208;
        phy.z = vTransform.position.z - 55902208;
        int num = Utilities.FUN_29E84(phy);
        if (oLYMPIC.DAT_DC < num)
        {
            oLYMPIC.DAT_DC = num;
            vigObject.tags = 1;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, vigObject.vData.sndList, 0, vTransform.position);
            VigObject vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 400);
            Pickup param2 = LevelManager.instance.FUN_4AE08(4194304u, vigObject2.screen);
            GameManager.instance.FUN_30CB0(param2, 1800);
            vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 401);
            param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
            GameManager.instance.FUN_30CB0(param2, 1800);
            vigObject2 = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 402);
            param2 = LevelManager.instance.FUN_4AE08(4261412864u, vigObject2.screen);
            GameManager.instance.FUN_30CB0(param2, 1800);
            if (id < 0)
            {
                vigObject.DAT_19 = 0;
                goto IL_0202;
            }
        }
        else
        {
            vigObject.tags = 3;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, vigObject.vData.sndList, 1, vTransform.position);
        }
        vigObject.DAT_19 = 0;
        goto IL_0202;
    IL_0202:
        GameManager.instance.FUN_30CB0(vigObject, 6);
        FUN_41FEC();
        return result;
    }

    private uint FUN_28B8(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                flags &= 4261412829u;
                FUN_41FEC();
                break;
            case 0:
                FUN_2AF20();
                break;
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_36D4(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                FUN_41FEC();
                break;
            case 0:
                {
                    uint num = GameManager.FUN_2AC5C();
                    vTransform.position.y -= 682;
                    int x = vTransform.position.x - 4096;
                    if ((num & 1) == 0)
                    {
                        x = vTransform.position.x + 4096;
                    }
                    vTransform.position.x = x;
                    if ((num & 2) == 0)
                    {
                        vTransform.position.z += 4096;
                    }
                    else
                    {
                        vTransform.position.z -= 4096;
                    }
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_48D0(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            switch (tags++)
            {
                case 0:
                    ApplyTransformation();
                    if (vCamera != null)
                    {
                        VigObject child = PDAT_74;
                        child.maxHalfHealth = 256;
                        vCamera.flags = (uint)(((int)vCamera.flags & -67108865) | 0x20000000);
                        VigCamera vigCamera = vCamera;
                        vigCamera.DAT_94 = 0;
                        vigCamera.DAT_90 = 0;
                        GameManager.instance.FUN_30CB0(vCamera, 660);
                        VigCamera vigCamera2 = vCamera = LevelManager.instance.FUN_4B984(this, child);
                        LevelManager.instance.defaultCamera.transform.SetParent(vigCamera2.transform, worldPositionStays: false);
                    }
                    flags |= 2u;
                    FUN_30BA8();
                    GameManager.instance.FUN_30CB0(this, 30);
                    break;
                case 1:
                    {
                        VigObject vigObject = LevelManager.instance.xobfList[42].ini.FUN_2C17C(21, typeof(VigObject), 8u);
                        BufferedBinaryReader reader = vCollider.reader;
                        vigObject.vLOD = vigObject.vMesh;
                        vigObject.vTransform = GameManager.FUN_2A39C();
                        vigObject.vTransform.position.x = 0;
                        vigObject.vTransform.position.y = (reader.ReadInt32(8) + reader.ReadInt32(20)) / 2;
                        vigObject.vTransform.position.z = reader.ReadInt32(12);
                        Utilities.FUN_2CC9C(this, vigObject);
                        vigObject.transform.parent = base.transform;
                        Utilities.ParentChildren(vigObject, vigObject);
                        vigObject.FUN_30BF0();
                        physics1.X = 0;
                        flags &= 4294967293u;
                        physics1.Y = -349525;
                        physics1.Z = 0;
                        FUN_30B78();
                        GameManager.instance.FUN_30CB0(this, 120);
                        break;
                    }
                case 2:
                    physics1.Y = 0;
                    FUN_30BA8();
                    GameManager.instance.FUN_30CB0(this, 40);
                    break;
                case 3:
                    {
                        VigObject child = child2;
                        VigObject vigObject = child.vData.ini.FUN_2C17C(26, typeof(VigObject), 8u);
                        ConfigContainer cont = child.FUN_2C5F4(32768);
                        Utilities.FUN_2CB04(child, cont, vigObject);
                        Utilities.ParentChildren(child, child);
                        vigObject.vLOD = vigObject.vMesh;
                        sbyte param2 = child.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(param2, child.vData.sndList, 2, vTransform.position);
                        GameManager.instance.FUN_1E30C(child.DAT_18, 5160);
                        FUN_30B78();
                        GameManager.instance.FUN_30CB0(this, 105);
                        break;
                    }
                case 4:
                    if (vCamera != null)
                    {
                        Water.instance.topView = true;
                        VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 512);
                        vCamera.vTransform = vigObject.vTransform;
                    }
                    GameManager.instance.FUN_30CB0(this, 150);
                    break;
                case 5:
                    {
                        Throwaway throwaway = child2.FUN_4ECA0();
                        GameManager.instance.FUN_1DE78(throwaway.DAT_18);
                        throwaway.id = id;
                        VigObject param = throwaway.child2.FUN_2CCBC();
                        GameManager.instance.FUN_307CC(param);
                        throwaway.physics1.Z = 0;
                        int num2 = physics1.Y;
                        if (num2 < 0)
                        {
                            num2 += 127;
                        }
                        throwaway.physics1.W = num2 >> 7;
                        throwaway.physics2.X = 0;
                        GameManager.instance.FUN_30CB0(this, 30);
                        break;
                    }
                case 6:
                    GameManager.instance.FUN_30CB0(this, 180);
                    break;
                case 7:
                    {
                        int num = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(num, GameManager.instance.DAT_C2C, 58, vTransform.position);
                        GameManager.instance.FUN_1E30C(num, 1290);
                        vr.x = -1024;
                        physics1.Y = 0;
                        vr.y = 0;
                        vr.z = 0;
                        ApplyRotationMatrix();
                        flags &= 4294967263u;
                        break;
                    }
            }
        }
        else
        {
            if (2 < arg1)
            {
                if (arg1 == 4)
                {
                    FUN_38484();
                    return 0u;
                }
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            int num3 = physics1.X;
            if (num3 < 0)
            {
                num3 += 127;
            }
            int num2 = physics1.Z;
            vTransform.position.x += num3 >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num3 = physics1.Y;
            vTransform.position.z += num2 >> 7;
            if (num3 < 0)
            {
                num3 += 127;
            }
            vTransform.position.y += num3 >> 7;
            switch (((byte)tags - 4) * 16777216 >> 24)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    physics1.Y -= 5376;
                    break;
                case 4:
                    {
                        num3 = ~id;
                        if (num3 >= 0)
                        {
                            uint axis = InputManager.controllers[num3].GetAxis();
                            if (InputManager.controllers[num3].type < _CONTROLLER_TYPE.JoypadAnalog)
                            {
                                num3 = 0;
                                num2 = 0;
                            }
                            else
                            {
                                num2 = InputManager.controllers[num3].stick[0] - 128;
                                num3 = InputManager.controllers[num3].stick[1] - 128;
                            }
                            if ((axis & 0x1800) != 0)
                            {
                                num2 = -64;
                                if ((axis & 0x1000) != 0)
                                {
                                    num2 = 64;
                                }
                            }
                            if ((axis & 0x300) != 0)
                            {
                                num3 = -64;
                                if ((axis & 0x100) != 0)
                                {
                                    num3 = 64;
                                }
                            }
                        }
                        else
                        {
                            num3 = UnityEngine.Random.Range(-64, 65);
                            num2 = UnityEngine.Random.Range(-64, 65);
                        }
                        int x = physics1.X;
                        int num5 = x;
                        if (x < 0)
                        {
                            num5 = x + 63;
                        }
                        physics1.X = x + (num2 * 304 - (num5 >> 6));
                        num5 = physics1.Z;
                        num2 = num5;
                        if (num5 < 0)
                        {
                            num2 = num5 + 63;
                        }
                        physics1.Z = num5 + (num3 * 304 - (num2 >> 6));
                        num2 = physics1.Y + 3584;
                        num3 = 1953024;
                        if (num2 < 1953024)
                        {
                            num3 = num2;
                        }
                        physics1.Y = num3;
                        num2 = FUN_2CFBC(vTransform.position);
                        num3 = GameManager.instance.DAT_DB0;
                        if (num2 < GameManager.instance.DAT_DB0)
                        {
                            num3 = num2;
                        }
                        if (num3 - 819200 < vTransform.position.y)
                        {
                            tags++;
                        }
                        if ((GameManager.instance.DAT_28 & 0x1F) != 0)
                        {
                            return 0u;
                        }
                        Pickup pickup = ((GameManager.instance.DAT_1002 & 1) != 0) ? LevelManager.instance.FUN_4AD24(23) : LevelManager.instance.FUN_4AD78(4269277184u);
                        num2 = (int)GameManager.FUN_2AC5C();
                        pickup.screen.x = vTransform.position.x + (num2 * 204800 >> 15) - 102400;
                        pickup.screen.y = vTransform.position.y + 819200;
                        num2 = (int)GameManager.FUN_2AC5C();
                        pickup.screen.z = vTransform.position.z + (num2 * 204800 >> 15) - 102400;
                        pickup.FUN_3066C();
                        GameManager.instance.FUN_30CB0(pickup, 180);
                        break;
                    }
                case 5:
                    {
                        if (vTransform.rotation.V11 < 3891)
                        {
                            num3 = -vTransform.rotation.V21;
                            if (0 < vTransform.rotation.V21)
                            {
                                num3 += 7;
                            }
                            int num5 = vTransform.rotation.V01;
                            if (num5 < 0)
                            {
                                num5 += 7;
                            }
                            FUN_24700((short)(num3 >> 3), 0, (short)(num5 >> 3));
                            vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
                            return 0u;
                        }
                        Ballistic2 ballistic = LevelManager.instance.xobfList[42].ini.FUN_2C17C(19, typeof(Ballistic2), 8u) as Ballistic2;
                        BufferedBinaryReader reader2 = vCollider.reader;
                        ballistic.maxHalfHealth = 4096;
                        ballistic.vTransform.position.x = 0;
                        ballistic.vLOD = ballistic.vMesh;
                        ballistic.vTransform.position.y = reader2.ReadInt32(8);
                        ballistic.vTransform.position.z = (reader2.ReadInt32(12) + reader2.ReadInt32(24)) / 2;
                        Utilities.FUN_2CC9C(this, ballistic);
                        ballistic.transform.parent = base.transform;
                        int num = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E580(num, LevelManager.instance.xobfList[42].sndList, 3, vTransform.position);
                        VigCamera vigCamera = vCamera;
                        tags++;
                        if (vigCamera != null)
                        {
                            new Vector3Int(0, 0, 0);
                            Vector3Int sv = default(Vector3Int);
                            sv.x = vTransform.position.x - 204800;
                            sv.y = vTransform.position.y;
                            sv.z = vTransform.position.z;
                            vigCamera.FUN_4B898();
                            vigCamera.screen.x = vTransform.position.x - 204800;
                            int num5 = FUN_2CFBC(sv);
                            num2 = GameManager.instance.DAT_DB0;
                            if (num5 < GameManager.instance.DAT_DB0)
                            {
                                num2 = num5;
                            }
                            vigCamera.screen.y = num2 - 20480;
                            vigCamera.screen.z = vTransform.position.z;
                            vigCamera.DAT_84 = new Vector3Int(0, 0, 0);
                            vigCamera.flags = (uint)(((int)vigCamera.flags & -536870913) | 0x4000000);
                        }
                        break;
                    }
                case 6:
                    {
                        num2 = physics1.Y;
                        num3 = num2;
                        if (num2 < 0)
                        {
                            num3 = num2 + 31;
                        }
                        num2 -= num3 >> 5;
                        num3 = 195200;
                        if (195200 < num2)
                        {
                            num3 = num2;
                        }
                        num2 = physics1.X;
                        physics1.Y = num3;
                        num3 = num2;
                        if (num2 < 0)
                        {
                            num3 = num2 + 63;
                        }
                        int num5 = physics1.Z;
                        physics1.X = num2 - (num3 >> 6);
                        num3 = num5;
                        if (num5 < 0)
                        {
                            num3 = num5 + 63;
                        }
                        physics1.Z = num5 - (num3 >> 6);
                        num2 = FUN_2CFBC(vTransform.position);
                        num3 = GameManager.instance.DAT_DB0;
                        if (num2 < GameManager.instance.DAT_DB0)
                        {
                            num3 = num2;
                        }
                        if (vTransform.position.y <= num3 - 102400)
                        {
                            return 0u;
                        }
                        tags++;
                        break;
                    }
                case 7:
                    {
                        VigObject vigObject = child2;
                        short num4 = (short)(vigObject.maxHalfHealth - 128);
                        vigObject.maxHalfHealth = (ushort)num4;
                        if (num4 != 0)
                        {
                            ushort maxHalfHealth = vigObject.maxHalfHealth;
                            Vector3Int sv = default(Vector3Int);
                            sv.x = (short)maxHalfHealth;
                            sv.y = (short)maxHalfHealth;
                            sv.z = (short)maxHalfHealth;
                            vigObject.ApplyRotationMatrix();
                            Utilities.FUN_245AC(ref vigObject.vTransform.rotation, sv);
                            return 0u;
                        }
                        VigObject param = vigObject.FUN_2CCBC();
                        GameManager.instance.FUN_307CC(param);
                        tags = 0;
                        FUN_41FEC();
                        VigCamera vigCamera = vCamera;
                        if (vigCamera != null)
                        {
                            vigCamera.flags &= 4093640703u;
                            Water.instance.topView = false;
                        }
                        break;
                    }
            }
        }
        return 0u;
    }

    private uint FUN_4628(int arg1, int arg2)
    {
        if (arg1 != 2)
        {
            if (2 < arg1)
            {
                if (arg1 != 4)
                {
                    return 0u;
                }
                FUN_38484();
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            int num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            int num2 = physics1.Y;
            vTransform.position.x += num >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num = physics1.Z;
            vTransform.position.y += num2 >> 7;
            if (num < 0)
            {
                num += 127;
            }
            vTransform.position.z += num >> 7;
            return 0u;
        }
        sbyte b = tags++;
        if (b == 1)
        {
            int num = vTransform.rotation.V02 * 9155;
            flags &= 4261412861u;
            if (num < 0)
            {
                num += 31;
            }
            physics1.X = num >> 5;
            num = vTransform.rotation.V12 * 9155;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Y = num >> 5;
            num = vTransform.rotation.V22 * 9155;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Z = num >> 5;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
            FUN_30B78();
        }
        else
        {
            if (1 < b)
            {
                if (b != 2)
                {
                    return 0u;
                }
                tags = 0;
                flags &= 4294967263u;
                FUN_41FEC();
                return 0u;
            }
            if (b != 0)
            {
                return 0u;
            }
            ApplyTransformation();
            if (vCamera != null)
            {
                VigObject pDAT_ = PDAT_74;
                pDAT_.maxHalfHealth = 256;
                vCamera.flags &= 4227858431u;
                GameManager.instance.FUN_30CB0(vCamera, 90);
                VigCamera vigCamera = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
                vigCamera.FUN_30B78();
            }
            flags |= 2u;
            FUN_30BA8();
        }
        GameManager.instance.FUN_30CB0(this, 30);
        return 0u;
    }

    private uint FUN_2630(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        {
                            int num = vTransform.rotation.V02 * 9155;
                            flags &= 4261412861u;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.X = num >> 5;
                            num = vTransform.rotation.V12 * 9155;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Y = num >> 5;
                            num = vTransform.rotation.V22 * 9155;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            FUN_30B78();
                            GameManager.instance.FUN_30CB0(this, 30);
                            if (weapons[2] == null)
                            {
                                num = (int)GameManager.FUN_2AC5C();
                                num = (num * 7 >> 15) + 1;
                                while ((weapons[0] != null && num == weapons[0].tags) || (weapons[1] != null && num == weapons[1].tags))
                                {
                                    num++;
                                    if (7 < num)
                                    {
                                        num = 1;
                                    }
                                }
                            }
                            else
                            {
                                num = (int)GameManager.FUN_2AC5C();
                                num = weapons[num * 3 >> 15].tags;
                            }
                            if (GameManager.instance.gameMode == _GAME_MODE.Versus2 && id > 0)
                            {
                                return 0u;
                            }
                            if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && id == -2)
                            {
                                return 0u;
                            }
                            if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && id > 0 && !DiscordController.IsOwner())
                            {
                                return 0u;
                            }
                            ConfigContainer configContainer = FUN_4AE5C(num);
                            if (configContainer == null)
                            {
                                break;
                            }
                            VigObject pDAT_2 = FUN_4AE94(num);
                            if (pDAT_2 != null)
                            {
                                pDAT_2.CCDAT_74 = configContainer;
                                pDAT_2.vr = configContainer.v3_2;
                                pDAT_2.screen.x = 0;
                                pDAT_2.flags |= 16777216u;
                                pDAT_2.maxFullHealth = pDAT_2.maxHalfHealth;
                                pDAT_2.screen.y = 0;
                                pDAT_2.screen.z = 131072;
                                pDAT_2.ApplyTransformation();
                                if ((pDAT_2.flags & 0x80) == 0)
                                {
                                    pDAT_2.FUN_30B78();
                                }
                                FUN_3A3D4(pDAT_2);
                                if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id == -1)
                                {
                                    ClientSend.Pickup(num, pDAT_2.maxHalfHealth, weapons[weaponSlot].tags);
                                }
                                else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
                                {
                                    ClientSend.PickupAI(id, num, pDAT_2.maxHalfHealth, weapons[weaponSlot].tags);
                                }
                            }
                            break;
                        }
                    case 0:
                        ApplyTransformation();
                        if (vCamera != null)
                        {
                            VigObject pDAT_ = PDAT_74;
                            pDAT_.maxHalfHealth = 256;
                            vCamera.flags &= 4227858431u;
                            GameManager.instance.FUN_30CB0(vCamera, 90);
                            VigCamera vigCamera = vCamera;
                            VigObject pDAT_2 = PDAT_74;
                            vigCamera.screen = pDAT_2.vTransform.position;
                            VigCamera vigCamera2 = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                            LevelManager.instance.defaultCamera.transform.SetParent(vigCamera2.transform, worldPositionStays: false);
                            vigCamera2.FUN_30B78();
                        }
                        flags |= 2u;
                        FUN_30BA8();
                        GameManager.instance.FUN_30CB0(this, 30);
                        break;
                    case 2:
                        tags = 0;
                        flags &= 4294967263u;
                        FUN_41FEC();
                        break;
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_580(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                FUN_41FEC();
                break;
            case 0:
                FUN_2AF20();
                break;
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_5F4(int arg1, int arg2)
    {
        if (arg1 != 2)
        {
            if (2 < arg1)
            {
                if (arg1 != 4)
                {
                    return 0u;
                }
                FUN_38484();
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            int num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            int num2 = physics1.Y;
            vTransform.position.x += num >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num = physics1.Z;
            vTransform.position.y += num2 >> 7;
            if (num < 0)
            {
                num += 127;
            }
            vTransform.position.z += num >> 7;
            return 0u;
        }
        sbyte b = tags++;
        if (b == 1)
        {
            int num = vTransform.rotation.V02 * 7629;
            flags &= 4294967293u;
            if (num < 0)
            {
                num += 31;
            }
            physics1.X = num >> 5;
            num = vTransform.rotation.V12 * 7629;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Y = num >> 5;
            num = vTransform.rotation.V22 * 7629;
            if (num < 0)
            {
                num += 31;
            }
            physics1.Z = num >> 5;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
            FUN_30B78();
        }
        else
        {
            if (1 < b)
            {
                if (b != 2)
                {
                    return 0u;
                }
                tags = 0;
                flags &= 4294967263u;
                FUN_41FEC();
                return 0u;
            }
            if (b != 0)
            {
                return 0u;
            }
            ApplyTransformation();
            if (vCamera != null)
            {
                VigObject pDAT_ = PDAT_74;
                pDAT_.maxHalfHealth = 256;
                vCamera.flags &= 4227858431u;
                vCamera.screen = pDAT_.screen;
                GameManager.instance.FUN_30CB0(vCamera, 90);
                VigCamera vigCamera = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
                vigCamera.FUN_30B78();
            }
            flags |= 2u;
            FUN_30BA8();
        }
        GameManager.instance.FUN_30CB0(this, 30);
        return 0u;
    }

    private uint FUN_BE8(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                FUN_41FEC();
                break;
            case 0:
                if (arg2 != 0)
                {
                    uint num = GameManager.FUN_2AC5C();
                    vTransform.position.y -= 682;
                    int x = vTransform.position.x - 4096;
                    if ((num & 1) == 0)
                    {
                        x = vTransform.position.x + 4096;
                    }
                    vTransform.position.x = x;
                    if ((num & 2) == 0)
                    {
                        vTransform.position.z += 4096;
                    }
                    else
                    {
                        vTransform.position.z -= 4096;
                    }
                }
                break;
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_558(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                flags &= 4294967263u;
                FUN_41FEC();
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_AC4(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        {
                            int num = vTransform.rotation.V02 * 4577;
                            flags &= 4294967293u;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.X = num >> 5;
                            num = vTransform.rotation.V12 * 4577;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Y = num >> 5;
                            num = vTransform.rotation.V22 * 4577;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            physics2.X = 0;
                            physics2.Y = 0;
                            physics2.Z = 0;
                            GameManager.instance.FUN_30CB0(this, 60);
                            break;
                        }
                    case 0:
                        {
                            VigObject vigObject = GameManager.instance.FUN_318D0(DAT_DE);
                            ConfigContainer param = vigObject.FUN_2C5F4(32768);
                            screen = (vTransform = GameManager.instance.FUN_2CEAC(vigObject, param)).position;
                            physics1.X = 0;
                            physics1.Y = 0;
                            physics1.Z = 0;
                            VigCamera vigCamera = vCamera;
                            if (vigCamera != null)
                            {
                                vigCamera.flags &= 4227858431u;
                                VigObject pDAT_ = PDAT_74;
                                if (pDAT_ == null)
                                {
                                    vCamera.FUN_4BC0C();
                                }
                                else
                                {
                                    pDAT_.maxHalfHealth = 256;
                                    GameManager.instance.FUN_30CB0(vCamera, 75);
                                    VigCamera vCamera2 = vCamera;
                                    vigCamera.screen = pDAT_.screen;
                                    VigCamera vigCamera2 = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                                    LevelManager.instance.defaultCamera.transform.SetParent(vigCamera2.transform, worldPositionStays: false);
                                    vigCamera2.FUN_30B78();
                                }
                            }
                            flags |= 2u;
                            GameManager.instance.FUN_30CB0(this, 15);
                            break;
                        }
                    case 2:
                        tags = 0;
                        flags &= 4294967263u;
                        FUN_41FEC();
                        break;
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_2C08(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 4:
                FUN_38484();
                break;
            case 8:
                FUN_41FEC();
                break;
        }
        return 0u;
    }

    private uint FUN_12FC(int arg1, int arg2)
    {
        int num;
        if (arg1 != 2)
        {
            if (2 < arg1)
            {
                if (arg1 != 4)
                {
                    return 0u;
                }
                FUN_38484();
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            int num2 = physics1.Y;
            vTransform.position.x += num >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num = physics1.Z;
            vTransform.position.y += num2 >> 7;
            if (num < 0)
            {
                num += 127;
            }
            vTransform.position.z += num >> 7;
            return 0u;
        }
        sbyte b = tags++;
        Vector3Int vin;
        if (b == 1)
        {
            GameManager.instance.FUN_30CB0(this, 60);
            VigObject vigObject;
            if (DAT_19 < 102)
            {
                vigObject = GameManager.instance.FUN_31950(DAT_19);
            }
            else
            {
                vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 400);
                DAT_19 = 100;
                tags--;
            }
            screen = vigObject.screen;
            Vector3Int vector3Int = default(Vector3Int);
            vector3Int.x = screen.x - vTransform.position.x;
            vector3Int.y = screen.y - vTransform.position.y;
            vector3Int.z = screen.z - vTransform.position.z;
            physics1.X = vector3Int.x * 128 / 60;
            physics1.Y = vector3Int.y * 128 / 60;
            vin = vector3Int;
            num = vector3Int.z;
        }
        else
        {
            VigCamera vigCamera;
            if (1 < b)
            {
                switch (b)
                {
                    case 2:
                        {
                            screen = vTransform.position;
                            num = vTransform.rotation.V02 * 6866;
                            flags &= 4261412861u;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.X = num >> 5;
                            num = vTransform.rotation.V12 * 6866;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Y = num >> 5;
                            num = vTransform.rotation.V22 * 6866;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            if (vCamera != null)
                            {
                                VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, DAT_19 + 414);
                                vCamera.DAT_90 = -256;
                                vCamera.DAT_9C -= 4096;
                                vCamera.flags &= 4227858431u;
                                vCamera.screen = vigObject.screen;
                                GameManager.instance.FUN_30CB0(vCamera, 90);
                                vigCamera = (vCamera = LevelManager.instance.FUN_4B984(this, vigObject));
                                LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
                                vigCamera.maxHalfHealth = 256;
                                vCamera.FUN_30B78();
                            }
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            param = 45;
                            if (DAT_19 == 98)
                            {
                                param = 75;
                            }
                            GameManager.instance.FUN_30CB0(this, param);
                            return 0u;
                        }
                    default:
                        return 0u;
                    case 3:
                        tags = 0;
                        flags &= 4294967263u;
                        FUN_41FEC();
                        return 0u;
                }
            }
            if (b != 0)
            {
                return 0u;
            }
            GameManager.instance.FUN_30CB0(this, 60);
            vigCamera = vCamera;
            if (vigCamera != null)
            {
                vigCamera.flags &= 4093640703u;
                vigCamera.DAT_90 = -682;
                vCamera.DAT_9C += 61440;
            }
            Vector3Int vector3Int2 = default(Vector3Int);
            vector3Int2.x = screen.x - vTransform.position.x;
            flags |= 33554434u;
            vector3Int2.y = screen.y - vTransform.position.y;
            vector3Int2.z = screen.z - vTransform.position.z;
            physics1.X = vector3Int2.x * 128 / 60;
            physics1.Y = vector3Int2.y * 128 / 60;
            vin = vector3Int2;
            num = vector3Int2.z;
        }
        physics1.Z = num * 128 / 60;
        Utilities.FUN_29FC8(vin, out Vector3Int vout);
        vTransform.rotation = Utilities.FUN_2A724(vout);
        return 0u;
    }

    private uint FUN_644(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                FUN_41FEC();
                break;
            case 0:
                FUN_2AF20();
                break;
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_13FC(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 4:
                FUN_38484();
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 8:
                FUN_41FEC();
                break;
        }
        return 0u;
    }

    private uint FUN_9E0(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                switch (tags++)
                {
                    case 1:
                        {
                            int num3 = 9155;
                            if (DAT_DE == 5)
                            {
                                num3 = 13733;
                            }
                            int num = vTransform.rotation.V02 * num3;
                            flags &= 4261412861u;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            int num2 = vTransform.rotation.V12 * num3;
                            physics1.X = num >> 5;
                            if (num2 < 0)
                            {
                                num2 += 31;
                            }
                            physics1.Y = (num2 >> 5) + 65536;
                            num = vTransform.rotation.V22 * num3;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            physics1.Z = num >> 5;
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
                            FUN_30B78();
                            GameManager.instance.FUN_30CB0(this, 30);
                            if ((uint)(DAT_DE - 3) < 2u)
                            {
                                param = GameManager.instance.FUN_1DD9C();
                                GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 20, vTransform.position);
                            }
                            break;
                        }
                    case 0:
                        ApplyTransformation();
                        if (vCamera != null)
                        {
                            VigObject pDAT_ = PDAT_74;
                            pDAT_.tags = 90;
                            pDAT_.maxHalfHealth = 256;
                            vCamera.flags &= 4227858431u;
                            GameManager.instance.FUN_30CB0(vCamera, pDAT_.tags);
                            VigCamera vigCamera = vCamera = LevelManager.instance.FUN_4B984(this, pDAT_);
                            LevelManager.instance.defaultCamera.transform.SetParent(vigCamera.transform, worldPositionStays: false);
                            vigCamera.FUN_30B78();
                        }
                        flags |= 2u;
                        FUN_30BA8();
                        GameManager.instance.FUN_30CB0(this, 30);
                        break;
                    case 2:
                        tags = 0;
                        DAT_DE = 0;
                        flags &= 4294967263u;
                        FUN_41FEC();
                        break;
                }
                break;
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 4:
                FUN_38484();
                break;
        }
        return 0u;
    }

    private uint FUN_F28(int arg1, int arg2)
    {
        int num;
        if (arg1 != 2)
        {
            if (2 < arg1)
            {
                if (arg1 != 4)
                {
                    return 0u;
                }
                FUN_38484();
                return 0u;
            }
            if (arg1 != 0)
            {
                return 0u;
            }
            num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            int num2 = physics1.Y;
            vTransform.position.x += num >> 7;
            if (num2 < 0)
            {
                num2 += 127;
            }
            num = physics1.Z;
            vTransform.position.y += num2 >> 7;
            if (num < 0)
            {
                num += 127;
            }
            vTransform.position.z += num >> 7;
            return 0u;
        }
        sbyte b = tags++;
        int param;
        if (b == 1)
        {
            param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 37, vTransform.position);
            flags &= 4261412861u;
            ApplyTransformation();
            physics1.X = vTransform.rotation.V02 * 286;
            physics1.Y = vTransform.rotation.V12 * 286;
            param = 30;
            num = vTransform.rotation.V22 * 286;
        }
        else
        {
            if (1 < b)
            {
                if (b != 2)
                {
                    return 0u;
                }
                VigCamera vigCamera = vCamera;
                if (vigCamera != null)
                {
                    vigCamera.flags &= 4093640703u;
                }
                flags &= 4294967263u;
                FUN_41FEC();
                if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1)
                {
                    FUN_3E32C(_WHEELS.Air, 500);
                    if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                    {
                        ClientSend.Pickup(7, 0, 0);
                    }
                }
                else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
                {
                    FUN_3E32C(_WHEELS.Air, 500);
                    ClientSend.PickupAI(id, 7, 0, 0);
                }
                return 0u;
            }
            if (b != 0)
            {
                return 0u;
            }
            flags |= 2u;
            physics1.X = screen.x - vTransform.position.x;
            physics1.Y = screen.y - vTransform.position.y;
            param = 128;
            num = screen.z - vTransform.position.z;
        }
        physics1.Z = num;
        GameManager.instance.FUN_30CB0(this, param);
        return 0u;
    }

    private uint FUN_C40(int arg1, int arg2)
    {
        if (arg1 == 0)
        {
            FUN_2AF20();
            if ((flags & 2) == 0)
            {
                physics1.Y -= 5760;
            }
            screen = vTransform.position;
        }
        return 0u;
    }

    private uint FUN_910(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    if (arg2 != 0)
                    {
                        uint volume = GameManager.instance.FUN_1E478(vTransform.position);
                        GameManager.instance.FUN_1E2C8(DAT_DF, volume);
                    }
                    break;
                }
            case 2:
                {
                    sbyte b = tags++;
                    int num;
                    if (b == 1)
                    {
                        GameManager.instance.FUN_1E580(DAT_DF, LevelManager.instance.xobfList[42].sndList, 3, vTransform.position);
                        DAT_DF = 0;
                        num = vTransform.rotation.V02 * 9155;
                        flags &= 4261412861u;
                        if (num < 0)
                        {
                            num += 31;
                        }
                        physics1.X = num >> 5;
                        num = vTransform.rotation.V12 * 9155;
                        if (num < 0)
                        {
                            num += 31;
                        }
                        physics1.Y = num >> 5;
                        num = vTransform.rotation.V22 * 9155;
                        if (num < 0)
                        {
                            num += 31;
                        }
                        physics1.Z = num >> 5;
                        GameManager.instance.FUN_30CB0(this, 30);
                        break;
                    }
                    if (b < 2)
                    {
                        if (b != 0)
                        {
                            return 0u;
                        }
                    }
                    else
                    {
                        switch (b)
                        {
                            case 2:
                                tags = 0;
                                flags &= 4294967263u;
                                FUN_41FEC();
                                return 0u;
                            default:
                                return 0u;
                            case 8:
                                break;
                        }
                    }
                    num = 7;
                    VigObject vigObject = GameManager.instance.FUN_31950(DAT_DE);
                    if (tags == 1)
                    {
                        num = 8;
                    }
                    tags = 1;
                    ConfigContainer param = vigObject.FUN_2C5F4(32768);
                    VigTransform vigTransform = GameManager.instance.FUN_2CEAC(vigObject, param);
                    vTransform.rotation = vigTransform.rotation;
                    VigObject vigObject2 = child2;
                    flags |= 2u;
                    while (vigObject2 != null)
                    {
                        if (vigObject2.vMesh != null)
                        {
                            vigObject2.vMesh.DAT_02 = 0;
                        }
                        vigObject2 = vigObject2.child;
                    }
                    if (vLOD != null)
                    {
                        vLOD.DAT_02 = 0;
                    }
                    physics1.X = (vigTransform.position.x - vTransform.position.x) * 128 >> num;
                    physics1.Y = (vigTransform.position.y - vTransform.position.y) * 128 >> num;
                    physics1.Z = (vigTransform.position.z - vTransform.position.z) * 128 >> num;
                    physics2.X = 0;
                    physics2.Y = 0;
                    physics2.Z = 0;
                    GameManager.instance.FUN_30CB0(this, 1 << num);
                    break;
                }
        }
        return 0u;
    }

    private uint FUN_C80(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    Blimp blimp = (Blimp)PDAT_78;
                    int num = ~id;
                    uint axis = InputManager.controllers[num].GetAxis();
                    if ((flags & 1) == 0)
                    {
                        _CONTROLLER_TYPE type = InputManager.controllers[num].type;
                        int num2 = InputManager.controllers[num].stick[2] - 128;
                        int num3 = num2;
                        if (num2 < 0)
                        {
                            num3 = -num2;
                        }
                        if (32 < num3)
                        {
                            if (num2 < 0)
                            {
                                num2 = InputManager.controllers[num].stick[2] - 125;
                            }
                            vCamera.DAT_92 -= (short)(num2 >> 2);
                        }
                        switch (type)
                        {
                            case _CONTROLLER_TYPE.SteeringWheel:
                                turning = (short)((InputManager.controllers[num].stick[0] - 128) * 5);
                                break;
                            case _CONTROLLER_TYPE.JoypadDigital:
                                if ((axis & 0x800) == 0)
                                {
                                    if ((axis & 0x1000) == 0)
                                    {
                                        num = turning;
                                        if (num < 0)
                                        {
                                            num += 15;
                                        }
                                        turning -= (short)(num >> 4);
                                        break;
                                    }
                                    int num4 = turning + 16;
                                    num = 682;
                                    if (num4 < 682)
                                    {
                                        num = num4;
                                    }
                                    turning = (short)num;
                                }
                                else
                                {
                                    int num4 = turning - 16;
                                    num = -682;
                                    if (-682 < num4)
                                    {
                                        num = num4;
                                    }
                                    turning = (short)num;
                                }
                                break;
                            case _CONTROLLER_TYPE.JoypadAnalog:
                                {
                                    int num4 = InputManager.controllers[num].stick[0] - 128;
                                    if (num4 < 0)
                                    {
                                        num4 = InputManager.controllers[num].stick[0] - 125;
                                    }
                                    num4 = turning + (num4 >> 2);
                                    num = -682;
                                    if (-683 < num4)
                                    {
                                        num = 682;
                                        if (num4 < 683)
                                        {
                                            num = num4;
                                        }
                                    }
                                    num4 = turning;
                                    if (num4 < 0)
                                    {
                                        num4 += 15;
                                    }
                                    turning = (short)(num - (num4 >> 4));
                                    break;
                                }
                        }
                        if (blimp.tags < 4)
                        {
                            num = turning;
                            if (num < 0)
                            {
                                num = -num;
                            }
                            if (42 < num)
                            {
                                blimp.tags = -1;
                            }
                        }
                        if (blimp.tags < 0)
                        {
                            num = turning;
                            if (num < 0)
                            {
                                num += 31;
                            }
                            blimp.vr.y += num >> 5;
                        }
                        vTransform = blimp.vTransform;
                        screen = blimp.screen;
                    }
                    else
                    {
                        num = physics1.X;
                        if (num < 0)
                        {
                            num += 127;
                        }
                        int num4 = physics1.Y;
                        vTransform.position.x += num >> 7;
                        if (num4 < 0)
                        {
                            num4 += 127;
                        }
                        num = physics1.Z;
                        vTransform.position.y += num4 >> 7;
                        if (num < 0)
                        {
                            num += 127;
                        }
                        vTransform.position.z += num >> 7;
                    }
                    sbyte tags = blimp.tags;
                    if (4 < tags || ((flags & 1) == 0 && tags != 4 && (tags == 2 || (axis & 0x1000000) != 0)))
                    {
                        int param = GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 0, blimp.screen);
                        blimp.DAT_90 = null;
                        blimp.flags |= 32u;
                        GameManager.instance.FUN_30CB0(blimp, 120);
                        FUN_41FEC();
                        vCamera.FUN_4B898();
                        flags = (uint)(((int)flags & -33554467) | 8);
                        tags = blimp.tags;
                        if (tags == 2 || tags < 0)
                        {
                            blimp.tags = 0;
                        }
                        else if (4 < tags)
                        {
                            physics1.Y = -4577;
                        }
                    }
                    break;
                }
            case 2:
                flags |= 2u;
                break;
        }
        return 0u;
    }

    private uint FUN_109C(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                if ((flags & 1) == 0)
                {
                    Gondola2 gondola = (Gondola2)PDAT_78;
                    ushort dAT_4A = gondola.DAT_4A;
                    vTransform = gondola.vTransform;
                    screen = gondola.screen;
                    SKIRESRT instance = SKIRESRT.instance;
                    vTransform.position.y += 86016;
                    if (id < 0)
                    {
                        int num = InputManager.controllers[~id].stick[2] - 128;
                        int num2 = num;
                        if (num < 0)
                        {
                            num2 = -num;
                        }
                        if (32 < num2)
                        {
                            if (num < 0)
                            {
                                num = InputManager.controllers[~id].stick[2] - 125;
                            }
                            vCamera.DAT_92 -= (short)(num >> 2);
                        }
                    }
                    if (instance.DAT_A2 == 0 && (gondola.DAT_1A != 85 || 24576 < (short)dAT_4A || 57344u < (uint)gondola.DAT_4A || ((InputManager.controllers[~id].GetAxis() & 0x1000000) != 0 && 4096u < (uint)gondola.DAT_4A && -28672 < (short)dAT_4A)))
                    {
                        gondola.DAT_80 = null;
                        gondola.flags |= 32u;
                        GameManager.instance.FUN_30CB0(gondola, 120);
                        FUN_41FEC();
                        physics1.X = 0;
                        flags = (uint)(((int)flags & -33554467) | 8);
                        physics1.Y = 1525;
                        int z = (dAT_4A << 16 >= 0) ? 292864 : (-292864);
                        physics1.Z = z;
                    }
                }
                else
                {
                    int num3 = physics1.X;
                    if (num3 < 0)
                    {
                        num3 += 127;
                    }
                    int num4 = physics1.Y;
                    vTransform.position.x += num3 >> 7;
                    if (num4 < 0)
                    {
                        num4 += 127;
                    }
                    num3 = physics1.Z;
                    vTransform.position.y += num4 >> 7;
                    if (num3 < 0)
                    {
                        num3 += 127;
                    }
                    vTransform.position.z += num3 >> 7;
                }
                break;
            case 2:
                flags |= 2u;
                SKIRESRT.instance.DAT_A2 = 60;
                break;
        }
        return 0u;
    }

    private uint FUN_C78(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    int num = physics1.X;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    int num2 = physics1.Y;
                    vTransform.position.x += num >> 7;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num = physics1.Z;
                    vTransform.position.y += num2 >> 7;
                    if (num < 0)
                    {
                        num += 127;
                    }
                    vTransform.position.z += num >> 7;
                    break;
                }
            case 2:
                {
                    uint flags = base.flags;
                    if ((flags & 2) == 0)
                    {
                        base.flags = (uint)((int)flags & -33);
                        FUN_41FEC();
                        break;
                    }
                    base.flags = (uint)((int)flags & -33554435);
                    ApplyTransformation();
                    int num = vTransform.rotation.V02 * 18310;
                    if (num < 0)
                    {
                        num += 31;
                    }
                    physics1.X = num >> 5;
                    num = vTransform.rotation.V12 * 18310;
                    if (num < 0)
                    {
                        num += 31;
                    }
                    physics1.Y = num >> 5;
                    num = vTransform.rotation.V22 * 18310;
                    if (num < 0)
                    {
                        num += 31;
                    }
                    physics1.Z = num >> 5;
                    if (vCamera != null)
                    {
                        GameManager.instance.FUN_30CB0(vCamera, 60);
                    }
                    GameManager.instance.FUN_30CB0(this, 30);
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E580(param, LevelManager.instance.xobfList[44].sndList, 4, vTransform.position);
                    break;
                }
        }
        return 0u;
    }

    public void FUN_41AE8()
    {
        FUN_41B0C();
    }

    private void FUN_41B0C()
    {
        short num = 84;
        if (-1 < acceleration)
        {
            num = 85;
            if (-1 < direction)
            {
                num = 0;
                if ((DAT_F6 & 0x80) != 0)
                {
                    num = 86;
                }
            }
        }
        VigObject vigObject = body[1];
        if (vigObject != null)
        {
            VigObject pDAT_ = vigObject.PDAT_74;
            if (pDAT_ != null && (num == 0 || pDAT_.DAT_1A != num))
            {
                VigObject param = pDAT_.FUN_2CCBC();
                GameManager.instance.FUN_2C4B4(param);
                vigObject.PDAT_74 = null;
            }
            pDAT_ = vigObject.PDAT_78;
            if (pDAT_ != null && (num == 0 || pDAT_.DAT_1A != num))
            {
                VigObject param = pDAT_.FUN_2CCBC();
                GameManager.instance.FUN_2C4B4(param);
                vigObject.PDAT_78 = null;
            }
            if (num != 0)
            {
                if (vigObject.PDAT_74 == null)
                {
                    ConfigContainer configContainer = vigObject.FUN_2C5F4(32834);
                    if (configContainer != null)
                    {
                        VigObject vigObject2 = vigObject.PDAT_74 = LevelManager.instance.xobfList[18].ini.FUN_2C17C((ushort)num, typeof(VigObject), 0u);
                        Utilities.FUN_2CB04(vigObject, configContainer, vigObject2);
                        Utilities.ParentChildren(vigObject, vigObject);
                        vigObject2.vMesh.DAT_02 = -1;
                    }
                }
                if (num != 0 && vigObject.PDAT_78 == null)
                {
                    ConfigContainer configContainer = vigObject.FUN_2C5F4(32835);
                    if (configContainer != null)
                    {
                        VigObject vigObject2 = vigObject.PDAT_78 = LevelManager.instance.xobfList[18].ini.FUN_2C17C((ushort)num, typeof(VigObject), 0u);
                        Utilities.FUN_2CB04(vigObject, configContainer, vigObject2);
                        Utilities.ParentChildren(vigObject, vigObject);
                        vigObject2.vMesh.DAT_02 = -1;
                    }
                }
            }
        }
        flags &= 2415919103u;
        int num2 = Utilities.FUN_29E84(new Vector3Int(physics1.X, physics1.Y, physics1.Z));
        if (num2 < 0)
        {
            num2 += 127;
        }
        int num3 = physics1.X;
        physics1.W = num2 >> 7;
        if (num3 < 0)
        {
            num3 += 127;
        }
        num2 = physics1.Y;
        if (num2 < 0)
        {
            num2 += 127;
        }
        int num4 = physics1.Z;
        if (num4 < 0)
        {
            num4 += 127;
        }
        num2 = vTransform.rotation.V02 * (num3 >> 7) + vTransform.rotation.V12 * (num2 >> 7) + vTransform.rotation.V22 * (num4 >> 7);
        if (num2 < 0)
        {
            num2 += 4095;
        }
        physics2.W = num2 >> 12;
        if (!GameManager.instance.noPhysics || id < 0)
        {
            if (DAT_B4 == 0)
            {
                if (wheelsType == _WHEELS.Air)
                {
                    PhyAir();
                }
                else if (wheelsType < _WHEELS.Sea)
                {
                    num3 = 0;
                    if (wheelsType != 0)
                    {
                        goto IL_0320;
                    }
                    PhyGround();
                }
                else if (wheelsType == _WHEELS.Sea)
                {
                    PhySea();
                }
                else
                {
                    num3 = 0;
                    if (wheelsType != _WHEELS.Snow)
                    {
                        goto IL_0320;
                    }
                    PhySnow();
                }
            }
            else
            {
                FUN_3E774();
                FUN_3E8C0();
            }
        }
        num3 = 0;
        goto IL_0320;
    IL_0320:
        FUN_41E08();
    }

    private void FUN_41E08()
    {
        int i;
        for (i = 0; i < 3; i++)
        {
            if (weapons[i] != null && weapons[i].id != 0)
            {
                weapons[i].id--;
            }
        }
        for (int j = 0; j < 3; j++)
        {
            if (DAT_B6[j] != 0)
            {
                DAT_B6[j]--;
            }
        }
        if (doubleDamage != 0)
        {
            doubleDamage--;
        }
        if (shield != 0)
        {
            shield--;
            FUN_39B50();
        }
        if ((short)shield < 0)
        {
            shield = 0;
        }
        if (jammer != 0)
        {
            jammer--;
        }
        if (flip != 0)
        {
            flip--;
        }
        if (peelout != 0)
        {
            peelout--;
        }
        if (acceleration < 0 && breaking == 0)
        {
            peelout = 0;
        }
        if ((flags & 0x8000000) != 0)
        {
            return;
        }
        int num;
        if (jammer == 0)
        {
            if (-1 < id && (DAT_F6 & 2) == 0)
            {
                screen = vTransform.position;
                return;
            }
            num = (vTransform.position.x - screen.x) * DAT_AF;
            if (num < 0)
            {
                num += 255;
            }
            screen.x += num >> 8;
            num = (vTransform.position.y - screen.y) * DAT_AF;
            if (num < 0)
            {
                num += 255;
            }
            screen.y += num >> 8;
            i = screen.z;
            num = (vTransform.position.z - i) * DAT_AF;
            if (num < 0)
            {
                num += 255;
            }
            num >>= 8;
        }
        else
        {
            num = vTransform.position.x - screen.x;
            if (num < 0)
            {
                num += 31;
            }
            screen.x += num >> 5;
            num = vTransform.position.y - screen.y;
            if (num < 0)
            {
                num += 31;
            }
            i = screen.z;
            screen.y += num >> 5;
            num = vTransform.position.z - i;
            if (num < 0)
            {
                num += 31;
            }
            num >>= 5;
        }
        screen.z = i + num;
    }

    public void PhySnow()
    {
        if (vTransform.rotation.V11 < 0)
        {
            FUN_3E8C0();
            for (int i = 2; i < 6; i++)
            {
                if (!(wheels[i] != null))
                {
                    continue;
                }
                int z = wheels[i].physics2.Z;
                wheels[i].screen.y = wheels[i].physics1.Y;
                int num = z;
                if (z < 0)
                {
                    num = z + 63;
                }
                z -= num >> 6;
                wheels[i].physics2.Z = z;
                if (wheels[i].physics2.Y != 0)
                {
                    if (z < 0)
                    {
                        z += 4095;
                    }
                    num = (z >> 12) * wheels[i].physics2.Y;
                    if (num < 0)
                    {
                        num += 524287;
                    }
                    wheels[i].vr.x -= num >> 19;
                }
                wheels[i].ApplyTransformation();
            }
            if (GameManager.instance.DAT_DB0 != 0 && GameManager.instance.DAT_DA0 > vTransform.position.z && vTransform.position.y > GameManager.instance.DAT_DB0 + 20480)
            {
                FUN_391AC();
            }
            return;
        }
        if (GameManager.instance.DAT_DB0 != 0 && vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < vTransform.position.y)
        {
            if (GameManager.instance.DAT_DB0 + 20480 < vTransform.position.y && FUN_2CFBC(vTransform.position) - GameManager.instance.DAT_DB0 > 24576)
            {
                FUN_391AC();
                return;
            }
            byte b = (byte)GameManager.FUN_2AC5C();
            if ((b & 0x3F) == 0 && shield == 0 && ai.rubberTimer == 0)
            {
                acceleration = -120;
                if (b == 0 && physics1.W < 1525)
                {
                    FUN_39BC4();
                }
                else
                {
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 33, vTransform.position);
                }
            }
            FUN_39B50();
        }
        VigTransform transform = FUN_2AEAC();
        List<Vector3Int> list = new List<Vector3Int>();
        List<Vector3Int> list2 = new List<Vector3Int>();
        List<TileData> list3 = new List<TileData>();
        List<int> list4 = new List<int>();
        Vector3Int v = new Vector3Int(0, 0, 0);
        Vector3Int v2 = new Vector3Int(0, 0, 0);
        wheelOnGround = false;
        for (int j = 0; j < 6; j++)
        {
            if (wheels[j] != null)
            {
                Vector3Int vector3Int = Utilities.FUN_24148(v: (j < 2) ? Utilities.FUN_24148(wheels[j].vTransform, wheels[j].child2.vTransform.position) : new Vector3Int(wheels[j].screen.x, wheels[j].screen.y + wheels[j].physics2.X, wheels[j].screen.z), transform: vTransform);
                int y = vector3Int.y;
                Vector3Int normalVector = default(Vector3Int);
                TileData normalTile;
                int param = vector3Int.y = FUN_2CFBC(vector3Int, ref normalVector, out normalTile);
                list.Add(vector3Int);
                list2.Add(normalVector);
                list3.Add(normalTile);
                list4.Add(y);
                if (normalTile != null)
                {
                    wheelOnGround = true;
                }
            }
        }
        uint num8;
        int num9;
        int num5;
        int num16;
        for (int k = 0; k < 6; k++)
        {
            if (!(wheels[k] != null))
            {
                continue;
            }
            Vector3Int v4 = new Vector3Int(wheels[k].screen.x, wheels[k].screen.y, wheels[k].screen.z);
            Vector3Int vector3Int2 = Utilities.FUN_24148(transform, v4);
            Vector3Int vector3Int3 = list[k];
            int num3 = list4[k];
            Vector3Int normal = list2[k];
            TileData tileData = list3[k];
            int num;
            if (k < 2)
            {
                short num4 = turning;
                num = (int)((long)num4 & 4095L) * 2;
                num5 = GameManager.DAT_65C90[num];
                num = GameManager.DAT_65C90[num + 1];
                if (wheels[k].child2 != null)
                {
                    wheels[k].child2.vr.y = num4;
                    if ((k & 1) != 0)
                    {
                        wheels[k].child2.vr.y = num4 + 2048;
                    }
                    wheels[k].child2.ApplyTransformation();
                }
            }
            else
            {
                num5 = 0;
                if (GameManager.instance.DAT_DB0 == 0)
                {
                    goto IL_057f;
                }
                num = 4096;
                if (GameManager.instance.DAT_DA0 > vector3Int3.y && num3 > GameManager.instance.DAT_DB0)
                {
                    int z = (int)GameManager.FUN_2AC5C();
                    if (physics1.W > z)
                    {
                        LevelManager.instance.FUN_38EF4(vector3Int3.x, vector3Int3.z);
                        goto IL_057f;
                    }
                }
            }
            goto IL_0586;
        IL_0586:
            Vector3Int vector3Int4 = Utilities.FUN_24304(vTransform, vector3Int3);
            vector3Int4.y -= wheels[k].physics2.X;
            if (vector3Int4.y < wheels[k].physics1.Y)
            {
                if (k < 4)
                {
                    uint num6 = 268435456u;
                    if (tileData != null)
                    {
                        num6 = 805306368u;
                    }
                    flags |= num6;
                    Vector3Int vector3Int5 = Utilities.FUN_24210(vTransform.rotation, normal);
                    int z = wheels[k].physics1.X;
                    if (wheels[k].physics1.X < vector3Int4.y)
                    {
                        z = vector3Int4.y;
                    }
                    int y2 = wheels[k].physics1.Y;
                    short num4 = wheels[k].physics1.M6;
                    Vector3Int vector3Int6 = default(Vector3Int);
                    if (wheels[k].physics1.X < vector3Int4.y || wheels[k].screen.y < vector3Int4.y)
                    {
                        vector3Int6.y = (vector3Int4.y - wheels[k].screen.y) * wheels[k].physics1.M7;
                        if (vector3Int6.y < 0)
                        {
                            vector3Int6.y += 31;
                        }
                        vector3Int6.y >>= 5;
                    }
                    else
                    {
                        vector3Int6.y = (vector3Int4.y - wheels[k].screen.y) * 16;
                        flags |= 1073741824u;
                    }
                    if (vector3Int5.y == 0)
                    {
                        vector3Int5.y = 1;
                    }
                    vector3Int6.y = (y2 - z) * num4 * 128 / vector3Int5.y + vector3Int6.y;
                    wheels[k].screen.y = vector3Int4.y;
                    z = ((tileData == null) ? (-vector3Int6.y) : ((tileData.DAT_10[4] == 2) ? int.MaxValue : (-vector3Int6.y)));
                    uint num7;
                    if (num5 == 0)
                    {
                        num6 = (uint)(vector3Int2.x >> 5);
                        num7 = (uint)(vector3Int2.z >> 2);
                    }
                    else
                    {
                        num6 = (uint)((long)vector3Int2.x * (long)num);
                        num8 = (uint)((long)vector3Int2.z * (long)num5);
                        num9 = (int)((ulong)((long)vector3Int2.z * (long)num5) >> 32);
                        uint num10 = (uint)((long)vector3Int2.z * (long)num);
                        num6 = (uint)((int)(num6 - num8 >> 17) | ((int)((int)((ulong)((long)vector3Int2.x * (long)num) >> 32) - num9 - (uint)((num6 < num8) ? 1 : 0)) * 32768));
                        num7 = (uint)((int)((long)vector3Int2.x * (long)num5) + (int)num10);
                        num7 = (uint)((int)(num7 >> 14) | ((int)((int)((ulong)((long)vector3Int2.x * (long)num5) >> 32) + (int)((ulong)((long)vector3Int2.z * (long)num) >> 32) + (uint)((num7 < num10) ? 1 : 0)) * 262144));
                    }
                    vector3Int6.z = 0;
                    int num11;
                    int num12;
                    if (1 < k)
                    {
                        num11 = acceleration;
                        y2 = num11;
                        if (num11 < 0)
                        {
                            y2 = -num11;
                        }
                        y2 *= DAT_C5;
                        num12 = z;
                        if (y2 < z)
                        {
                            num12 = y2;
                        }
                        if (num11 < 0)
                        {
                            vector3Int6.z = (int)(0 - num7);
                            if (0 < (int)num7)
                            {
                                y2 = -num12;
                                if (vector3Int6.z < y2)
                                {
                                    vector3Int6.z = y2;
                                }
                            }
                            y2 = vector3Int6.z;
                            if (num12 < vector3Int6.z)
                            {
                                y2 = num12;
                            }
                            vector3Int6.z = y2;
                        }
                        else if (direction < 1)
                        {
                            vector3Int6.z = -num12;
                        }
                        else
                        {
                            y2 = (int)(0 - num7) >> 2;
                            vector3Int6.z = num12;
                            if (vector3Int6.z < y2)
                            {
                                vector3Int6.z = y2;
                            }
                        }
                    }
                    vector3Int6.x = (int)(0 - num6);
                    if ((int)num6 < 1)
                    {
                        if (z < vector3Int6.x)
                        {
                            vector3Int6.x = z;
                        }
                    }
                    else if (vector3Int6.x < -z)
                    {
                        vector3Int6.x = -z;
                    }
                    if (num5 != 0)
                    {
                        z = num5 * vector3Int6.x;
                        vector3Int6.x = num5 * vector3Int6.z + num * vector3Int6.x >> 12;
                        vector3Int6.z = num * vector3Int6.z - z >> 12;
                    }
                    int num13 = v4.x >> 3;
                    int num14 = v4.y >> 3;
                    int num15 = v4.z >> 3;
                    Coprocessor.rotationMatrix.rt11 = (short)(num13 & 0xFFFF);
                    Coprocessor.rotationMatrix.rt12 = (short)(num13 >> 16);
                    Coprocessor.rotationMatrix.rt22 = (short)(num14 & 0xFFFF);
                    Coprocessor.rotationMatrix.rt23 = (short)(num14 >> 16);
                    Coprocessor.rotationMatrix.rt33 = (short)num15;
                    z = vector3Int6.x >> 3;
                    if (z < -32768)
                    {
                        y2 = -32768;
                    }
                    else
                    {
                        y2 = 32767;
                        if (z < 32768)
                        {
                            y2 = z;
                        }
                    }
                    z = vector3Int6.y >> 3;
                    if (z < -32768)
                    {
                        num11 = -32768;
                    }
                    else
                    {
                        num11 = 32767;
                        if (z < 32768)
                        {
                            num11 = z;
                        }
                    }
                    z = vector3Int6.z >> 3;
                    if (z < -32768)
                    {
                        num12 = -32768;
                    }
                    else
                    {
                        num12 = 32767;
                        if (z < 32768)
                        {
                            num12 = z;
                        }
                    }
                    if (vector3Int4.y < -wheels[k].physics1.Y)
                    {
                        flip++;
                    }
                    Coprocessor.accumulator.ir1 = (short)y2;
                    Coprocessor.accumulator.ir2 = (short)num11;
                    Coprocessor.accumulator.ir3 = (short)num12;
                    Coprocessor.ExecuteOP(12, lm: false);
                    v2.x += vector3Int6.x;
                    v2.y += vector3Int6.y;
                    v2.z += vector3Int6.z;
                    z = Coprocessor.mathsAccumulator.mac1;
                    v.x += z;
                    z = Coprocessor.mathsAccumulator.mac2;
                    v.y += z;
                    z = Coprocessor.mathsAccumulator.mac3;
                    v.z += z;
                    if (tileData != null)
                    {
                        if (tileData.DAT_10[3] != 0 && tileData.DAT_10[3] != 7)
                        {
                            LevelManager.instance.level.UpdateW(wheels[k], 10, vector3Int3);
                        }
                        if (k < 2)
                        {
                            continue;
                        }
                        if (tileData.DAT_10[4] == 2)
                        {
                            num16 = (int)GameManager.FUN_2AC5C();
                            if (num16 < physics1.W)
                            {
                                Particle1 particle = LevelManager.instance.FUN_4DE54(vector3Int3, 12);
                                particle.flags |= 1024u;
                                short z2 = (short)GameManager.FUN_2AC5C();
                                particle.vr.z = z2;
                                particle.ApplyTransformation();
                            }
                        }
                    }
                }
                else
                {
                    wheels[k].screen.y = vector3Int4.y;
                }
            }
            else
            {
                wheels[k].screen.y = wheels[k].physics1.Y;
            }
            if (1 < k)
            {
                num16 = num5 * vector3Int2.x + num * vector3Int2.z;
                if (num16 < 0)
                {
                    num16 += 4095;
                }
                int num17 = wheels[k].physics2.Y;
                if (num17 == 0)
                {
                    num17 = 370;
                }
                num5 = (num16 >> 12) * num17;
                wheels[k].physics2.Z = num16 >> 12;
                if (num5 < 0)
                {
                    num5 += 524287;
                }
                wheels[k].vr.x -= num5 >> 19;
            }
            continue;
        IL_057f:
            num = 4096;
            goto IL_0586;
        }
        for (int l = 0; l < 6; l++)
        {
            if (wheels[l] != null)
            {
                wheels[l].ApplyTransformation();
            }
        }
        v2 = Utilities.FUN_24094(vTransform.rotation, v2);
        int num18 = physics1.W * lightness;
        v2.x -= (int)((ulong)((long)physics1.X * (long)num18) >> 32);
        v2.y = v2.y + GameManager.instance.gravityFactor - (int)((ulong)((long)physics1.Y * (long)num18) >> 32);
        long num19 = (long)physics1.Z * (long)num18;
        num8 = (uint)num19;
        num9 = (int)((ulong)num19 >> 32);
        v2.z -= num9;
        if (physics2.Y > 32768 || physics2.Y < -32768)
        {
            v.y = Mathf.Clamp(v.y, -512, 512);
        }

        //Control Snow
        FUN_2AFF8(v2, v);
        num16 = physics2.X;
        num18 = num16;
        if (num16 < 0)
        {
            num18 = num16 + 31;
        }
        num5 = physics2.Y;
        physics2.X = num16 - (num18 >> 5);
        num18 = num5;
        if (num5 < 0)
        {
            num18 = num5 + 31;
        }
        num16 = physics2.Z;
        physics2.Y = num5 - (num18 >> 5);
        num18 = num16;
        if (num16 < 0)
        {
            num18 = num16 + 31;
        }
        physics2.Z = num16 - (num18 >> 5);
    }


    //Control Fisica Oseano
    public void PhySea()
    {
        _003C_003Ec__DisplayClass105_0 _003C_003Ec__DisplayClass105_ = default(_003C_003Ec__DisplayClass105_0);
        _003C_003Ec__DisplayClass105_._003C_003E4__this = this;
        Vector3Int normalVector = default(Vector3Int);
        if (vTransform.rotation.V11 < 0)
        {
            _003C_003Ec__DisplayClass105_.iVar5 = VigTerrain.instance.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
            if (_003C_003Ec__DisplayClass105_.iVar5 < GameManager.instance.DAT_DB0)
            {
                FUN_3E8C0();
                return;
            }
        }
        VigTransform transform = FUN_2AE18();
        _003C_003Ec__DisplayClass105_.local_b0 = new Vector3Int(0, 0, 0);
        _003C_003Ec__DisplayClass105_.local_a0 = new Vector3Int(0, GameManager.instance.gravityFactor, 0);
        _003C_003Ec__DisplayClass105_.iVar5 = vTransform.rotation.V11;
        int num = 0;
        int w;
        if (0 < _003C_003Ec__DisplayClass105_.iVar5)
        {
            num = acceleration * DAT_C4 * _003C_003Ec__DisplayClass105_.iVar5;
            if (num < 0)
            {
                num += 131071;
            }
            _003C_003Ec__DisplayClass105_.iVar5 = (num >> 17) * _003C_003Ec__DisplayClass105_.iVar5;
            if (_003C_003Ec__DisplayClass105_.iVar5 < 0)
            {
                _003C_003Ec__DisplayClass105_.iVar5 += 4095;
            }
            _003C_003Ec__DisplayClass105_.iVar5 >>= 12;
            num = _003C_003Ec__DisplayClass105_.iVar5;
            if (_003C_003Ec__DisplayClass105_.iVar5 < 0)
            {
                w = physics2.W;
            }
            else
            {
                w = direction;
                if (0 < w)
                {
                    goto IL_0164;
                }
                num = 0;
            }
            if (w < 0)
            {
                num = -_003C_003Ec__DisplayClass105_.iVar5;
            }
        }
        goto IL_0164;
    IL_0164:
        bool flag = false;
        _003C_003Ec__DisplayClass105_.iVar5 = 3;
        uint num2 = 0u;
        uint num3;
        do
        {
            _003C_003Ec__DisplayClass105_.iVar5 -= 3;
            if (wheels[_003C_003Ec__DisplayClass105_.iVar5] != null)
            {
                if (1 < (int)num2)
                {
                    VigObject child = wheels[_003C_003Ec__DisplayClass105_.iVar5].child2;
                    short y = ((num2 & 1) != 0) ? ((short)(2048 - (((ushort)turning << 16 >> 16) - ((ushort)turning << 16 >> 31) >> 1))) : ((short)(-turning / 2));
                    child.vr.y = y;
                    child.ApplyTransformation();
                    child.child2.vr.z += num * 3;
                    child.child2.ApplyTransformation();
                }
                w = wheels[_003C_003Ec__DisplayClass105_.iVar5].IDAT_78;
                _VEHICLE vEHICLE = vehicle;
                if (vEHICLE == _VEHICLE.Wonderwagon || vEHICLE == _VEHICLE.DakotaCycle || vEHICLE == _VEHICLE.Palomino)
                {
                    w -= 4000;
                }
                Vector3Int v = new Vector3Int(wheels[_003C_003Ec__DisplayClass105_.iVar5].screen.x, wheels[_003C_003Ec__DisplayClass105_.iVar5].screen.y + w, wheels[_003C_003Ec__DisplayClass105_.iVar5].screen.z);
                _003C_003Ec__DisplayClass105_.local_60 = Utilities.FUN_24148(vTransform, v);
                w = FUN_2CFBC(_003C_003Ec__DisplayClass105_.local_60, ref normalVector, out _003C_003Ec__DisplayClass105_.local_28);
                Vector3Int vector3Int = Utilities.FUN_24148(transform, v);
                if (_003C_003Ec__DisplayClass105_.local_60.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < w)
                {
                    flag = true;
                    if (GameManager.instance.DAT_DB0 < _003C_003Ec__DisplayClass105_.local_60.y)
                    {
                        int num4;
                        if ((int)num2 < 2)
                        {
                            _003C_003Ec__DisplayClass105_.local_40 = new Vector3Int(0, 0, 0);
                        }
                        else
                        {
                            num3 = (uint)(((-turning - (-turning >> 31)) * 2) & 0x3FFC);
                            _003C_003Ec__DisplayClass105_.local_40 = default(Vector3Int);
                            _003C_003Ec__DisplayClass105_.local_40.x = GameManager.DAT_65C90[num3 / 2u] * num;
                            if (_003C_003Ec__DisplayClass105_.local_40.x < 0)
                            {
                                _003C_003Ec__DisplayClass105_.local_40.x += 63;
                            }
                            _003C_003Ec__DisplayClass105_.local_40.x = _003C_003Ec__DisplayClass105_.local_40.x >> 6;
                            _003C_003Ec__DisplayClass105_.local_40.z = GameManager.DAT_65C90[num3 / 2u + 1] * num;
                            if (_003C_003Ec__DisplayClass105_.local_40.z < 0)
                            {
                                _003C_003Ec__DisplayClass105_.local_40.z += 63;
                            }
                            _003C_003Ec__DisplayClass105_.local_40.z = _003C_003Ec__DisplayClass105_.local_40.z >> 6;
                            _003C_003Ec__DisplayClass105_.local_40.y = 0;
                            _003C_003Ec__DisplayClass105_.local_40 = Utilities.FUN_24094(vTransform.rotation, _003C_003Ec__DisplayClass105_.local_40);
                            num4 = (int)GameManager.FUN_2AC5C();
                            if (num4 < physics1.W)
                            {
                                LevelManager.instance.FUN_38F38(_003C_003Ec__DisplayClass105_.local_60.x, _003C_003Ec__DisplayClass105_.local_60.z);
                            }
                        }
                        num4 = (w - _003C_003Ec__DisplayClass105_.local_60.y) * 16;
                        w = (GameManager.instance.DAT_DB0 - _003C_003Ec__DisplayClass105_.local_60.y) * 90 / 24576 * 128;
                        if (num4 < w)
                        {
                            w = num4;
                        }
                        _003C_003Ec__DisplayClass105_.local_40.y += w;
                        if (vector3Int.y < 1)
                        {
                            w = vector3Int.y;
                            if (vector3Int.y < 0)
                            {
                                w = vector3Int.y + 7;
                            }
                            _003C_003Ec__DisplayClass105_.local_40.y -= w >> 3;
                            wheels[_003C_003Ec__DisplayClass105_.iVar5].flags &= 4160749567u;
                        }
                        else if ((int)num2 < 2)
                        {
                            if (-_003C_003Ec__DisplayClass105_.local_40.y < 2881)
                            {
                                wheels[_003C_003Ec__DisplayClass105_.iVar5].flags &= 4160749567u;
                            }
                            else if ((wheels[_003C_003Ec__DisplayClass105_.iVar5].flags & 0x8000000) == 0)
                            {
                                LevelManager.instance.FUN_38EF4(_003C_003Ec__DisplayClass105_.local_60.x, _003C_003Ec__DisplayClass105_.local_60.z);
                                wheels[_003C_003Ec__DisplayClass105_.iVar5].flags |= 134217728u;
                            }
                            else
                            {
                                w = (int)GameManager.FUN_2AC5C();
                                if (w < physics1.W)
                                {
                                    LevelManager.instance.FUN_38EF4(_003C_003Ec__DisplayClass105_.local_60.x, _003C_003Ec__DisplayClass105_.local_60.z);
                                    wheels[_003C_003Ec__DisplayClass105_.iVar5].flags |= 134217728u;
                                }
                            }
                        }
                        if (_003C_003Ec__DisplayClass105_.local_28 != null)
                        {
                            num3 = (flags |= 536870912u);
                        }
                        _003CPhySea_003Eg__FUN_40B3C_007C105_0(ref _003C_003Ec__DisplayClass105_);
                    }
                }
                else if (w < _003C_003Ec__DisplayClass105_.local_60.y)
                {
                    _003C_003Ec__DisplayClass105_.local_40 = default(Vector3Int);
                    if ((int)num2 < 2)
                    {
                        _003C_003Ec__DisplayClass105_.local_40.z = 0;
                        _003C_003Ec__DisplayClass105_.local_40.x = 0;
                    }
                    else
                    {
                        num3 = (uint)(((-turning - (-turning >> 31)) * 2) & 0x3FFC);
                        _003C_003Ec__DisplayClass105_.local_40.x = GameManager.DAT_65C90[num3 / 2u] * num;
                        if (_003C_003Ec__DisplayClass105_.local_40.x < 0)
                        {
                            _003C_003Ec__DisplayClass105_.local_40.x += 63;
                        }
                        _003C_003Ec__DisplayClass105_.local_40.x = _003C_003Ec__DisplayClass105_.local_40.x >> 6;
                        _003C_003Ec__DisplayClass105_.local_40.z = GameManager.DAT_65C90[num3 / 2u + 1] * num;
                        if (_003C_003Ec__DisplayClass105_.local_40.z < 0)
                        {
                            _003C_003Ec__DisplayClass105_.local_40.z += 63;
                        }
                        _003C_003Ec__DisplayClass105_.local_40.z = _003C_003Ec__DisplayClass105_.local_40.z >> 6;
                        _003C_003Ec__DisplayClass105_.local_40.y = 0;
                        _003C_003Ec__DisplayClass105_.local_40 = Utilities.FUN_24094(vTransform.rotation, _003C_003Ec__DisplayClass105_.local_40);
                    }
                    _003C_003Ec__DisplayClass105_.iVar5 = vector3Int.y;
                    if (vector3Int.y < 0)
                    {
                        _003C_003Ec__DisplayClass105_.iVar5 = vector3Int.y + 3;
                    }
                    _003C_003Ec__DisplayClass105_.local_40.y = (w - _003C_003Ec__DisplayClass105_.local_60.y) * 16 - (_003C_003Ec__DisplayClass105_.iVar5 >> 2);
                    num3 = 805306368u;
                    if (_003C_003Ec__DisplayClass105_.local_28 != null)
                    {
                        num3 = 268435456u;
                    }
                    num3 = (flags |= num3);
                    _003CPhySea_003Eg__FUN_40B3C_007C105_0(ref _003C_003Ec__DisplayClass105_);
                }
            }
            num3 = num2 + 1;
            _003C_003Ec__DisplayClass105_.iVar5 = (int)(num2 + 4);
            num2 = num3;
        }
        while (3 >= (int)num3);
        if (flag || (flags & 0x10000000) == 0)
        {
            DAT_C2 = 0;
        }
        else
        {
            byte b = DAT_C2++;
            if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1)
            {
                if (60 < b)
                {
                    FUN_3E32C(_WHEELS.Ground, 0);
                    if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                    {
                        ClientSend.Pickup(16, 0, 0);
                    }
                }
            }
            else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
            {
                FUN_3E32C(_WHEELS.Ground, 0);
                ClientSend.PickupAI(id, 16, 0, 0);
            }
        }
        _003C_003Ec__DisplayClass105_.local_b0 = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(_003C_003Ec__DisplayClass105_.local_b0.x, _003C_003Ec__DisplayClass105_.local_b0.y, _003C_003Ec__DisplayClass105_.local_b0.z, 0));
        _003C_003Ec__DisplayClass105_.iVar5 = physics1.W * lightness;
        _003C_003Ec__DisplayClass105_.local_a0.y -= (int)((ulong)((long)physics1.Y * (long)_003C_003Ec__DisplayClass105_.iVar5) >> 32);
        int num5 = (int)((ulong)((long)physics1.Z * (long)_003C_003Ec__DisplayClass105_.iVar5) >> 32);
        if (acceleration == 0)
        {
            num = physics1.X;
            if (num < 0)
            {
                num += 63;
            }
            num = -(num >> 6);
            w = physics1.Z;
            if (w < 0)
            {
                w += 63;
            }
            w = -(w >> 6);
        }
        else
        {
            w = -physics1.X;
            if (0 < physics1.X)
            {
                w += 31;
            }
            int num4 = vTransform.rotation.V02;
            if (num4 < 0)
            {
                num4 = -num4;
            }
            num = 0;
            if (0 < 4096 - num4)
            {
                num = 4096 - num4;
            }
            num = (w >> 5) * num;
            if (num < 0)
            {
                num += 4095;
            }
            num >>= 12;
            num4 = -physics1.Z;
            if (0 < physics1.Z)
            {
                num4 += 31;
            }
            int num6 = vTransform.rotation.V22;
            if (num6 < 0)
            {
                num6 = -num6;
            }
            w = 0;
            if (0 < 4096 - num6)
            {
                w = 4096 - num6;
            }
            w = (num4 >> 5) * w;
            if (w < 0)
            {
                w += 4095;
            }
            w >>= 12;
        }
        _003C_003Ec__DisplayClass105_.local_a0.x = _003C_003Ec__DisplayClass105_.local_a0.x - (int)((ulong)((long)physics1.X * (long)_003C_003Ec__DisplayClass105_.iVar5) >> 32) + num;
        _003C_003Ec__DisplayClass105_.local_a0.z = _003C_003Ec__DisplayClass105_.local_a0.z - num5 + w;

        //set Pyshic Sea
        FUN_2AFF8(_003C_003Ec__DisplayClass105_.local_a0, _003C_003Ec__DisplayClass105_.local_b0);
        num = (_003C_003Ec__DisplayClass105_.iVar5 = physics2.X);
        if (num < 0)
        {
            _003C_003Ec__DisplayClass105_.iVar5 = num + 31;
        }
        w = physics2.Y;
        physics2.X = num - (_003C_003Ec__DisplayClass105_.iVar5 >> 5);
        _003C_003Ec__DisplayClass105_.iVar5 = w;
        if (w < 0)
        {
            _003C_003Ec__DisplayClass105_.iVar5 = w + 31;
        }
        num = physics2.Z;
        physics2.Y = w - (_003C_003Ec__DisplayClass105_.iVar5 >> 5);
        _003C_003Ec__DisplayClass105_.iVar5 = num;
        if (num < 0)
        {
            _003C_003Ec__DisplayClass105_.iVar5 = num + 31;
        }
        physics2.Z = num - (_003C_003Ec__DisplayClass105_.iVar5 >> 5);
    }


    //Control Aire - Trineo
    public void PhyAir()
    {
        Vector3Int normalVector = default(Vector3Int);
        if (vTransform.rotation.V11 < 0)
        {
            FUN_3E8C0();
            if (GameManager.instance.DAT_DB0 != 0 && GameManager.instance.DAT_DA0 > vTransform.position.z && vTransform.position.y > GameManager.instance.DAT_DB0 + 20480)
            {
                FUN_391AC();
            }
            return;
        }
        if (GameManager.instance.DAT_DB0 != 0 && vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < vTransform.position.y)
        {
            if (GameManager.instance.DAT_DB0 + 20480 < vTransform.position.y && FUN_2CFBC(vTransform.position) - GameManager.instance.DAT_DB0 > 24576)
            {
                FUN_391AC();
                return;
            }
            byte b = (byte)GameManager.FUN_2AC5C();
            if ((b & 0x3F) == 0 && shield == 0)
            {
                acceleration = -120;
                if (b == 0 && physics1.W < 1525)
                {
                    FUN_39BC4();
                }
                else
                {
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 33, vTransform.position);
                }
            }
            FUN_39B50();
        }
        VigTransform transform = FUN_2AE18();
        Vector3Int v = new Vector3Int(0, 0, 0);
        Vector3Int v2 = new Vector3Int(0, 0, 0);
        flags |= 268435456u;
        wheelOnGround = false;
        int num = 0;
        int num3;
        int num4;
        int num2;
        for (int i = 0; i < 4; i++)
        {
            if (!(wheels[i] != null))
            {
                continue;
            }
            Vector3Int vector3Int = Utilities.FUN_24148(vTransform, wheels[i].screen);
            num2 = FUN_2CFBC(vector3Int, ref normalVector, out TileData normalTile);
            if (normalTile != null)
            {
                wheelOnGround = true;
            }
            if (vector3Int.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < num2 && GameManager.instance.DAT_36 && GameManager.instance.DAT_DB0 < vector3Int.y + 40960)
            {
                num3 = (int)GameManager.FUN_2AC5C();
                if (num3 << 1 < physics1.W)
                {
                    LevelManager.instance.FUN_38EF4(vector3Int.x, vector3Int.z);
                }
            }
            num2 -= vector3Int.y;
            num3 = 409;
            if (409 < num2)
            {
                num3 = num2;
            }
            if (i < 2)
            {
                if (turning < 1)
                {
                    if (i == 0)
                    {
                        goto IL_0305;
                    }
                    num4 = turning;
                    if (num4 < 0)
                    {
                        num4 = -num4;
                    }
                    num3 = (num4 * -32 - 10240) * GameManager.instance.gravityFactor / num3;
                }
                else
                {
                    if (i == 1)
                    {
                        goto IL_0305;
                    }
                    num4 = turning;
                    if (num4 < 0)
                    {
                        num4 = -num4;
                    }
                    num3 = (num4 * -32 - 10240) * GameManager.instance.gravityFactor / num3;
                }
            }
            else
            {
                num4 = 0;
                if (0 < acceleration)
                {
                    num4 = acceleration;
                }
                num3 = (num4 * -32 - 10240) * GameManager.instance.gravityFactor / num3;
            }
            goto IL_0347;
        IL_0305:
            num3 = GameManager.instance.gravityFactor * -10240 / num3;
            goto IL_0347;
        IL_0347:
            if (10240 < num2)
            {
                Vector3Int vector3Int2 = Utilities.FUN_24148(transform, wheels[i].screen);
                if (vector3Int2.y < 0)
                {
                    num3 -= vector3Int2.y + 63 >> 6;
                }
            }
            v2.y += num3;
            num2 = (wheels[i].screen.z >> 3) * (num3 >> 3);
            if (num2 < 0)
            {
                num2 += 4095;
            }
            v.x -= num2 >> 12;
            num2 = (wheels[i].screen.x >> 3) * (num3 >> 3);
            if (num2 < 0)
            {
                num2 += 4095;
            }
            v.z += num2 >> 12;
            if (normalTile != null)
            {
                if (normalTile.DAT_10[3] != 0 && normalTile.DAT_10[3] != 7)
                {
                    LevelManager.instance.level.UpdateW(wheels[i], 10, vector3Int);
                }
                flags |= 536870912u;
            }
        }
        short num5 = 0;
        if (0 < acceleration)
        {
            num5 = acceleration;
        }
        for (int j = 0; j < 6; j++)
        {
            if (wheels[j] != null && wheels[j].child2 != null)
            {
                wheels[j].child2.vTransform.rotation.V11 = (short)(num5 * 16 + 4096);
                ((WheelChild)wheels[j].child2).eulerAngles = new Vector3(0f, 0f - base.transform.localEulerAngles.y, 0f);
            }
        }
        num = acceleration * DAT_C3;
        if (num < 0)
        {
            num += 31;
        }
        num >>= 5;
        int num6 = num;
        if (num < 0)
        {
            num2 = physics2.W;
        }
        else
        {
            num2 = direction;
            if (0 < num2)
            {
                goto IL_0557;
            }
            num6 = 0;
        }
        if (num2 < 0)
        {
            num6 = -num;
        }
        goto IL_0557;
    IL_0557:
        v2 = Utilities.FUN_24094(vTransform.rotation, v2);
        num = vTransform.rotation.V02;
        num3 = num * num6;
        num2 = physics1.X;
        if (num2 < 0)
        {
            num2 += 63;
        }
        if (num < 0)
        {
            num = -num;
        }
        num4 = 0;
        if (0 < 4096 - num)
        {
            num4 = 4096 - num;
        }
        num4 = (num2 >> 6) * num4;
        if (num4 < 0)
        {
            num4 += 4095;
        }
        v2.x += num3 / 24 - (num4 >> 12);
        num = vTransform.rotation.V22;
        num3 = num * num6;
        num2 = physics1.Z;
        if (num2 < 0)
        {
            num2 += 63;
        }
        if (num < 0)
        {
            num = -num;
        }
        num4 = 0;
        if (0 < 4096 - num)
        {
            num4 = 4096 - num;
        }
        num4 = (num2 >> 6) * num4;
        if (num4 < 0)
        {
            num4 += 4095;
        }
        v2.z += num3 / 24 - (num4 >> 12);
        v2.y += GameManager.instance.gravityFactor;
        if (3051 < physics1.W)
        {
            num = (int)((long)(physics2.W >> 31) & 8L) / 4;
            Vector3Int vector3Int = Utilities.FUN_24148(v: new Vector3Int(0, wheels[num].screen.y, wheels[num].screen.z), transform: vTransform);
            num = physics1.X;
            if (num < 0)
            {
                num += 3;
            }
            vector3Int.x += num >> 2;
            num = physics1.Z;
            if (num < 0)
            {
                num += 3;
            }
            vector3Int.z += num >> 2;
            num = FUN_2CFBC(vector3Int);
            if (num - 20480 < vTransform.position.y)
            {
                v2.y += vTransform.rotation.V12 * num6 / 12;
            }
            num = num - 20480 - vector3Int.y;
            if (num < 0)
            {
                num6 = num + 31;
                if (-1 < physics2.W)
                {
                    num6 = -num;
                    if (0 < num)
                    {
                        num6 += 31;
                    }
                }
                physics2.X += num6 >> 5;
            }
        }
        num = physics1.W * lightness;
        v2.x -= (int)((ulong)((long)physics1.X * (long)num) >> 32);
        v2.y -= (int)((ulong)((long)physics1.Y * (long)num) >> 32);
        int num7 = (int)((long)physics1.Z * (long)num >> 32);
        v2.z -= num7;

        //Set Pyshic Air
        FUN_2AFF8(v2, v);
        num6 = physics2.X;
        num = num6;
        if (num6 < 0)
        {
            num = num6 + 31;
        }
        num >>= 5;
        num2 = num6;
        if (num6 < 0)
        {
            num2 = -num6;
        }
        if (1024 < num2)
        {
            num2 = num6;
            if (num6 < 0)
            {
                num2 = num6 + 7;
            }
            num += num2 >> 3;
        }
        num2 = physics2.Z;
        physics2.X = num6 - num;
        num = num2;
        if (num2 < 0)
        {
            num = num2 + 31;
        }
        num >>= 5;
        num6 = num2;
        if (num2 < 0)
        {
            num6 = -num2;
        }
        if (1024 < num6)
        {
            num6 = num2;
            if (num2 < 0)
            {
                num6 = num2 + 7;
            }
            num += num6 >> 3;
        }
        num6 = physics2.Y;
        physics2.Z = num2 - num;
        num = num6;
        if (num6 < 0)
        {
            num = num6 + 15;
        }
        physics2.Y = num6 + (turning * 2 - (num >> 4));
    }


    //Fisica Tierra
    public void PhyGround()
    {
        int num;
        if (vTransform.rotation.V11 < 0)
        {
            FUN_3E8C0();
            for (int i = 0; i < 6; i++)
            {
                if (!(wheels[i] != null))
                {
                    continue;
                }
                int z = wheels[i].physics2.Z;
                wheels[i].screen.y = wheels[i].physics1.Y;
                num = z;
                if (z < 0)
                {
                    num = z + 63;
                }
                z -= num >> 6;
                wheels[i].physics2.Z = z;
                if (wheels[i].physics2.Y != 0)
                {
                    if (z < 0)
                    {
                        z += 4095;
                    }
                    num = (z >> 12) * wheels[i].physics2.Y;
                    if (num < 0)
                    {
                        num += 524287;
                    }
                    wheels[i].vr.x -= num >> 19;
                }
                wheels[i].ApplyTransformation();
            }
            if (GameManager.instance.DAT_DB0 != 0 && GameManager.instance.DAT_DA0 > vTransform.position.z && vTransform.position.y > GameManager.instance.DAT_DB0 + 20480)
            {
                FUN_391AC();
            }
            return;
        }
        if (GameManager.instance.DAT_DB0 != 0 && vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < vTransform.position.y)
        {
            if (GameManager.instance.DAT_DB0 + 20480 < vTransform.position.y && FUN_2CFBC(vTransform.position) - GameManager.instance.DAT_DB0 > 24576)
            {
                FUN_391AC();
                return;
            }
            byte b = (byte)GameManager.FUN_2AC5C();
            if ((b & 0x3F) == 0 && shield == 0 && ai.rubberTimer == 0)
            {
                acceleration = -120;
                if (b == 0 && physics1.W < 1525)
                {
                    FUN_39BC4();
                }
                else
                {
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 33, vTransform.position);
                }
            }
            FUN_39B50();
        }
        VigTransform transform = FUN_2AEAC();
        num = 0;
        int num2 = 0;
        int num3 = 0;
        List<Vector3Int> list = new List<Vector3Int>();
        List<Vector3Int> list2 = new List<Vector3Int>();
        List<int> list3 = new List<int>();
        List<TileData> list4 = new List<TileData>();
        Vector3Int v = new Vector3Int(0, 0, 0);
        Vector3Int v2 = new Vector3Int(0, 0, 0);
        wheelOnGround = false;
        for (int j = 0; j < 6; j++)
        {
            if (wheels[j] != null)
            {
                Vector3Int v3 = new Vector3Int(wheels[j].screen.x, wheels[j].screen.y + wheels[j].physics2.X, wheels[j].screen.z);
                Vector3Int normalVector = default(Vector3Int);
                Vector3Int vector3Int = Utilities.FUN_24148(vTransform, v3);
                list3.Add(vector3Int.y);

                vector3Int.y = FUN_2CFBC(vector3Int, ref normalVector, out TileData normalTile);
                list.Add(vector3Int);
                list2.Add(normalVector);
                list4.Add(normalTile);
                if (normalTile != null)
                {
                    wheelOnGround = true;
                }

            }
        }
        long num9;
        uint num18;
        int num19;
        for (int k = 0; k < 6; k++)
        {
            if (!(wheels[k] != null))
            {
                continue;
            }
            int num4;
            int num5;
            uint num6;
            if ((wheels[k].flags & 0x2000000) == 0)
            {
                num4 = 0;
                num5 = 4096;
            }
            else
            {
                num6 = (uint)turning;
                if (1 < k)
                {
                    num6 = 0 - num6;
                }
                num2 = (int)((num6 & 0xFFF) * 4);
                wheels[k].vr.y = (short)num6;
                num4 = GameManager.DAT_65C90[num2 / 2];
                num5 = GameManager.DAT_65C90[num2 / 2 + 1];
            }
            Vector3Int v4 = new Vector3Int(wheels[k].screen.x, wheels[k].screen.y + wheels[k].physics2.X, wheels[k].screen.z);
            Vector3Int vector3Int2 = Utilities.FUN_24148(transform, v4);

            Vector3Int vector3Int3 = list[k];
            int num7 = list3[k];
            Vector3Int normal = list2[k];
            TileData tileData = list4[k];
            if (1 < k && GameManager.instance.DAT_DB0 != 0 && vector3Int3.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 < num7)
            {
                num2 = (int)GameManager.FUN_2AC5C();
                if (num2 < physics1.W)
                {
                    LevelManager.instance.FUN_38EF4(vector3Int3.x, vector3Int3.z);
                }
            }
            Vector3Int vector3Int4 = Utilities.FUN_24304(vTransform, vector3Int3);
            vector3Int4.y -= wheels[k].physics2.X;
            Vector3Int v3;
            uint y;
            int z;
            int num20;
            if (vector3Int4.y < wheels[k].physics1.Y)
            {
                if (k < 4)
                {
                    num6 = 268435456u;
                    if (tileData != null)
                    {
                        num6 = 805306368u;
                    }
                    else
                    {
                        num3 = 0;
                    }
                    flags |= num6;
                    uint num8 = (uint)(normal.x << 16 >> 16);
                    num6 = (uint)physics1.X;
                    num9 = (long)num8 * (long)num6;
                    int num10 = (ushort)normal.y << 16;
                    uint num11 = (uint)(num10 >> 16);
                    num10 >>= 31;
                    y = (uint)physics1.Y;
                    uint num12 = (uint)((long)num11 * (long)y);
                    uint num13 = (uint)((ushort)normal.z << 16 >> 16);
                    uint z2 = (uint)physics1.Z;
                    long num14 = (long)num13 * (long)z2;
                    uint num15 = (uint)num14;
                    int num16 = (int)num8 * ((int)num6 >> 31);
                    int num17 = (int)((ulong)num14 >> 32) + (int)num13 * ((int)z2 >> 31) + (int)z2 * ((ushort)normal.z << 16 >> 31);
                    num13 = (uint)((int)num9 + (int)num12);
                    z2 = num13 + num15;
                    num6 = (uint)((z2 >> 15) | (((int)((ulong)num9 >> 32) + num16 + (int)num6 * (normal.x << 16 >> 31) + (int)((ulong)((long)num11 * (long)y) >> 32) + (int)num11 * ((int)y >> 31) + (int)y * num10 + ((num13 < num12) ? 1 : 0) + num17 + (uint)((z2 < num15) ? 1 : 0)) * 131072));
                    Vector3Int vector3Int5 = Utilities.FUN_24210(vTransform.rotation, normal);
                    num2 = -vector3Int5.x * (int)num6;
                    if (num2 < 0)
                    {
                        num2 += 4095;
                    }
                    v3 = default(Vector3Int);
                    v3.x = 0;
                    if (v4.x - vector3Int4.x < 0)
                    {
                        v3.x = v4.x - vector3Int4.x;
                    }
                    num = -vector3Int5.z * (int)num6;
                    v3.x = (num2 >> 12) - v3.x;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    v3.z = 0;
                    if (v4.z - vector3Int4.z < 0)
                    {
                        v3.z = v4.z - vector3Int4.z;
                    }
                    v3.z = (num >> 12) - v3.z;
                    num2 = wheels[k].physics1.X;
                    if (wheels[k].physics1.X < vector3Int4.y)
                    {
                        num2 = vector3Int4.y;
                    }
                    num = wheels[k].physics1.Y;
                    short m = wheels[k].physics1.M6;
                    if (wheels[k].physics1.X < vector3Int4.y || wheels[k].screen.y < vector3Int4.y)
                    {
                        v3.y = (vector3Int4.y - wheels[k].screen.y) * wheels[k].physics1.M7;
                        if (v3.y < 0)
                        {
                            v3.y += 31;
                        }
                        v3.y >>= 5;
                    }
                    else
                    {
                        v3.y = (vector3Int4.y - wheels[k].screen.y) * 16;
                        flags |= 1073741824u;
                    }
                    if (vector3Int5.y != 0)
                    {
                        v3.y = (num - num2) * m * 128 / vector3Int5.y + v3.y;
                    }
                    else
                    {
                        v3.y = -1 + v3.y;
                    }

                    //Suspension Llantas
                    wheels[k].screen.y = vector3Int4.y;
                    //Debug.Log("Bounce: " +wheels[k].screen.y);

                    //Friccion sobre el terreno
                    if ((wheels[k].flags & 0x4000000) == 0)
                    {
                        num2 = ((tileData == null) ? (v3.y * -2) : ((tileData.DAT_10[0] != 0) ? (-v3.y * (256 - tileData.DAT_10[0]) >> 7) : (v3.y * -2)));
                        if (num4 == 0)
                        {
                            num6 = (uint)(vector3Int2.x >> 5);
                            y = (uint)(vector3Int2.z >> 2);
                        }
                        else
                        {
                            num6 = (uint)((long)vector3Int2.x * (long)num5);
                            num18 = (uint)((long)vector3Int2.z * (long)num4);
                            num19 = (int)((ulong)((long)vector3Int2.z * (long)num4) >> 32);
                            num15 = (uint)((long)vector3Int2.x * (long)num4);
                            num17 = (int)((ulong)((long)vector3Int2.x * (long)num4) >> 32);
                            num13 = (uint)((long)vector3Int2.z * (long)num5);
                            num6 = (uint)((num6 - num18 >> 17) | ((long)((int)((ulong)((long)vector3Int2.x * (long)num5) >> 32) - num19 - ((num6 < num18) ? 1 : 0)) * 32768L));
                            y = num15 + num13;
                            y = (uint)((y >> 14) | ((long)(num17 + (int)((ulong)((long)vector3Int2.z * (long)num5) >> 32) + ((y < num13) ? 1 : 0)) * 262144L));
                        }
                        z = acceleration;
                        num = z;
                        if (z < 0)
                        {
                            num = -z;
                        }
                        num20 = num2;
                        if (num << 6 < num2)
                        {
                            num20 = num << 6;
                        }
                        if (z < 0)
                        {
                            num = (int)(0 - y);
                            if ((int)y < 1)
                            {
                                z = num;
                                if (num20 < num)
                                {
                                    z = num20;
                                }
                            }
                            else
                            {
                                z = -num20;
                                if (z <= num)
                                {
                                    goto IL_0b0b;
                                }
                            }
                            num = z;
                        }
                        else if ((wheels[k].flags & 0x1000000) == 0)
                        {
                            num = 0;
                        }
                        else if (direction < 1)
                        {
                            num = -num20;
                        }
                        else
                        {
                            num = num20;
                            if (num20 < (int)(0 - y) >> 2)
                            {
                                num = (int)(0 - y) >> 2;
                            }
                        }
                        goto IL_0b0b;
                    }
                    goto IL_0c38;
                }
                wheels[k].screen.y = vector3Int4.y;
            }
            else
            {
                wheels[k].screen.y = wheels[k].physics1.Y;
                if (k >= 2 && k <= 3)
                {
                    if (vector3Int4.y > wheels[k].physics1.Y * -2)
                    {
                        num3 = 0;
                    }
                }
                else if (k >= 0 && k <= 1 && peelout != 0)
                {
                    Vector3Int vector3Int6 = Utilities.FUN_24148(vTransform, v4);
                    num2 = GameManager.instance.terrain.FUN_1B750((uint)vector3Int6.x, (uint)vector3Int6.z);
                    num2 -= vector3Int6.y;
                    num2 = (num2 >> 4) * peelSpeed;
                    num2 -= physics1.W / 2;
                    if (num2 < 0)
                    {
                        num2 = 0;
                    }
                    num3 += num2;
                }
            }
            goto IL_0fb1;
        IL_0fb1:
            num2 = num4 * vector3Int2.x + num5 * vector3Int2.z;
            if (num2 < 0)
            {
                num2 += 4095;
            }
            wheels[k].physics2.Z = num2 >> 12;
            if (wheels[k].physics2.Y != 0)
            {
                num2 = (num2 >> 12) * wheels[k].physics2.Y;
                if (num2 < 0)
                {
                    num2 += 524287;
                }
                short m = (short)(num2 >> 19);
                if ((wheels[k].flags & 0x1000000) != 0 && 0 < breaking)
                {
                    m = (short)(m + (sbyte)(breaking * 5));
                }
                wheels[k].vr.x -= m;
            }
            continue;
        IL_0b0b:
            if ((wheels[k].flags & 0x1000000) != 0)
            {
                z = breaking;
                if (z != 0)
                {
                    if (z < 1)
                    {
                        num += z * -384;
                    }
                    else
                    {
                        num += z * 64;
                        num2 /= 2;
                        v3.y += z * -128;
                    }
                }
            }
            z = (int)y >> 8;
            if ((wheels[k].flags & 0x40000000) != 0)
            {
                num20 = z;
                if (z < 0)
                {
                    num20 = -z;
                }
                num -= z * num20 >> 5;
            }
            if (tileData != null && tileData.DAT_10[1] != 0)
            {
                num20 = z;
                if (z < 0)
                {
                    num20 = -z;
                }
                num -= z * num20 * tileData.DAT_10[1] >> 12;
            }
            z = (int)(0 - num6);
            if ((int)num6 < 1)
            {
                if (num2 < z)
                {
                    z = num2;
                }
            }
            else if (z < -num2)
            {
                z = -num2;
            }
            if (num4 != 0)
            {
                num2 = num4 * z;
                z = num4 * num + num5 * z >> 12;
                num = num5 * num - num2 >> 12;
            }
            v3.x += z;
            v3.z += num;
            goto IL_0c38;
        IL_0c38:
            int num21 = v4.x >> 3;
            int num22 = v4.y >> 3;
            int num23 = v4.z >> 3;
            Coprocessor.rotationMatrix.rt11 = (short)(num21 & 0xFFFF);
            Coprocessor.rotationMatrix.rt12 = (short)(num21 >> 16);
            Coprocessor.rotationMatrix.rt22 = (short)(num22 & 0xFFFF);
            Coprocessor.rotationMatrix.rt23 = (short)(num22 >> 16);
            Coprocessor.rotationMatrix.rt33 = (short)num23;
            num2 = v3.x >> 3;
            if (num2 < -32768)
            {
                num = -32768;
            }
            else
            {
                num = 32767;
                if (num2 < 32768)
                {
                    num = num2;
                }
            }
            num2 = v3.y >> 3;
            if (num2 < -32768)
            {
                z = -32768;
            }
            else
            {
                z = 32767;
                if (num2 < 32768)
                {
                    z = num2;
                }
            }
            num2 = v3.z >> 3;
            if (num2 < -32768)
            {
                num20 = -32768;
            }
            else
            {
                num20 = 32767;
                if (num2 < 32768)
                {
                    num20 = num2;
                }
            }
            Coprocessor.accumulator.ir1 = (short)num;
            Coprocessor.accumulator.ir2 = (short)z;
            Coprocessor.accumulator.ir3 = (short)num20;
            Coprocessor.ExecuteOP(12, lm: false);
            if (wheels[k].physics1.Y < 0)
            {
                if (vector3Int4.y < wheels[k].physics1.Y * 2)
                {
                    flip++;
                }
            }
            else if (vector3Int4.y < -wheels[k].physics1.Y)
            {
                flip++;
            }
            v2.x += v3.x;
            v2.y += v3.y;
            v2.z += v3.z;
            num2 = Coprocessor.mathsAccumulator.mac1;
            v.x += num2;
            num2 = Coprocessor.mathsAccumulator.mac2;
            v.y += num2;
            num2 = Coprocessor.mathsAccumulator.mac3;
            v.z += num2;
            if (tileData != null && tileData.DAT_10[3] != 0 && tileData.DAT_10[3] != 7)
            {
                LevelManager.instance.level.UpdateW(wheels[k], 10, vector3Int3);
            }
            if (peelout != 0)
            {
                num3 += 255;
            }
            goto IL_0fb1;
        }
        for (int l = 0; l < 6; l++)
        {
            if (wheels[l] != null)
            {
                wheels[l].ApplyTransformation();
            }
        }
        v2 = Utilities.FUN_24094(vTransform.rotation, v2);
        v2.y = GameManager.instance.gravityFactor + v2.y;
        int num24 = physics1.W * (lightness - num3);
        v2.x -= (int)((ulong)((long)physics1.X * (long)num24) >> 32);
        v2.y -= (int)((ulong)((long)physics1.Y * (long)num24) >> 32);
        num9 = (long)physics1.Z * (long)num24;
        num18 = (uint)num9;
        num19 = (int)((ulong)num9 >> 32);
        v2.z -= num19;
        if (physics2.Y > 32768 || physics2.Y < -32768)
        {
            v.y = Mathf.Clamp(v.y, -512, 512);
        }

        //Set Physic Tierra
        FUN_2AFF8(v2, v);
        //Debug.Log(v2 + " - " + v);
        int x = physics2.X;

        //Control de giro Vertical
        num24 = x;
        if (x < 0)
        {
            num24 = x + 31;
        }

        //Control de giro Horizontal
        num2 = physics2.Y;
        physics2.X = x - (num24 >> 5);
        num24 = num2;
        if (num2 < 0)
        {
            num24 = num2 + 31;
        }
        x = physics2.Z;

        //Limite de Giro
        physics2.Y = num2 - (num24 >> 5);
        num24 = x;
        if (x < 0)
        {
            num24 = x + 31;
        }
        physics2.Z = x - (num24 >> 5);
    }


    //Actualiza objetivo Radar
    public void FUN_3CCD4(bool param1, bool param2 = false)
    {
        VigTerrain instance = VigTerrain.instance;
        VigObject vigObject = null;
        VigObject vigObject2 = null;
        int num = 0;
        int num2 = 0;
        uint num3 = uint.MaxValue;
        uint num4 = (uint)(~id);
        sbyte b = GameManager.instance.DAT_1128[num4];
        Coprocessor.rotationMatrix.rt11 = instance.DAT_BDFF0[num4].rotation.V00;
        Coprocessor.rotationMatrix.rt12 = instance.DAT_BDFF0[num4].rotation.V01;
        Coprocessor.rotationMatrix.rt13 = instance.DAT_BDFF0[num4].rotation.V02;
        Coprocessor.rotationMatrix.rt21 = instance.DAT_BDFF0[num4].rotation.V10;
        Coprocessor.rotationMatrix.rt22 = instance.DAT_BDFF0[num4].rotation.V11;
        Coprocessor.rotationMatrix.rt23 = instance.DAT_BDFF0[num4].rotation.V12;
        Coprocessor.rotationMatrix.rt31 = instance.DAT_BDFF0[num4].rotation.V20;
        Coprocessor.rotationMatrix.rt32 = instance.DAT_BDFF0[num4].rotation.V21;
        Coprocessor.rotationMatrix.rt33 = instance.DAT_BDFF0[num4].rotation.V22;
        Coprocessor.translationVector._trx = instance.DAT_BDFF0[num4].position.x;
        Coprocessor.translationVector._try = instance.DAT_BDFF0[num4].position.y;
        Coprocessor.translationVector._trz = instance.DAT_BDFF0[num4].position.z;
        for (int i = 0; i < GameManager.instance.worldObjs.Count; i++)
        {
            VigObject vObject = GameManager.instance.worldObjs[i].vObject;
            VigObject vigObject3 = vigObject2;
            num4 = num3;
            int num5 = num;
            int num6 = num2;
            VigObject vigObject4 = vigObject;
            if (vObject == this || vObject.type == 3 || vObject.type == 13)
            {
                vigObject2 = vigObject3;
                num3 = num4;
                num = num5;
                num2 = num6;
                vigObject = vigObject4;
            }
            else
            {
                if ((vObject.flags & 0x4000) == 0 || (0 >= vObject.id && b == GameManager.instance.DAT_1128[~vObject.id]))
                {
                    continue;
                }
                Vector3Int vector3Int = Utilities.FUN_24008(vObject.screen);
                num6 = vector3Int.y >> 10;
                if (num6 < 0)
                {
                    num6 = -num6;
                }
                int num7 = vector3Int.x >> 10;
                if (num7 < 0)
                {
                    num7 = -num7;
                }
                if (num6 < num7)
                {
                    num6 = num7;
                }
                num5 = vector3Int.z >> 10;
                if (num6 < num5 && param2)
                {
                    vigObject3 = vObject;
                    if (vigObject2 == null || num * num6 < num5 * num2)
                    {
                        vigObject2 = vigObject3;
                        num3 = num4;
                        num = num5;
                        num2 = num6;
                        vigObject = vigObject4;
                        continue;
                    }
                }
                if (vigObject2 == null || !param2)
                {
                    num4 = (uint)Utilities.FUN_29F6C(vTransform.position, vObject.screen);
                    vigObject3 = vigObject2;
                    num5 = num;
                    num6 = num2;
                    vigObject4 = vObject;
                    if (num4 < num3)
                    {
                        vigObject2 = vigObject3;
                        num3 = num4;
                        num = num5;
                        num2 = num6;
                        vigObject = vigObject4;
                    }
                }
            }
        }
        if (vigObject2 == null)
        {
            vigObject2 = vigObject;
        }
        if (vigObject2 != target && ((vigObject2 != null) | param1))
        {
            target = vigObject2;
            DAT_C6 = 0;
            VigObject vigObject5 = weapons[weaponSlot];
            if (vigObject5 != null && vigObject5.GetType().IsSubclassOf(typeof(VigObject)))
            {
                vigObject5.UpdateW(11, null);
            }
        }
    }

    public void FUN_41FEC()
    {
        uint flags = base.flags;
        base.flags = (uint)((int)flags & -67108865);
        tags = 1;
        if ((flags & 0x4000) == 0)
        {
            state = _VEHICLE_TYPE.Chasis;
            UnityEngine.Object.Destroy(unit);
            UnityEngine.Object.Destroy(gameTag);
            unit = null;
            gameTag = null;
        }
        else if (maxHalfHealth == 0)
        {
            FUN_38C40();
        }
        else
        {
            state = _VEHICLE_TYPE.Vehicle;
        }
    }

    public void FUN_3C9C4(int param1)
    {
        XOBF_DB vData = base.vData;
        ushort next = vData.ini.configContainers[DAT_1A].next;
        _VEHICLE vehicle2 = vehicle;
        for (uint num = next; num != 65535; num = next)
        {
            ConfigContainer configContainer = vData.ini.configContainers[(int)num];
            int num2 = configContainer.objID - 256;
            next = configContainer.previous;
        }
        DAT_B3 = GameManager.vehicleConfigs[(int)vehicle].DAT_13;
        lightness = GameManager.vehicleConfigs[(int)vehicle].lightness;
        DAT_AF = GameManager.vehicleConfigs[(int)vehicle].DAT_15;
        FUN_3C404(GameManager.vehicleConfigs[(int)vehicle].maxHalfHealth);
    }

    public void InitializeEnemyStats()
    {
        XOBF_DB vData = base.vData;
        ushort next = vData.ini.configContainers[DAT_1A].next;
        for (uint num = next; num != 65535; num = next)
        {
            ConfigContainer configContainer = vData.ini.configContainers[(int)num];
            if ((uint)(configContainer.objID - 256) < 4u && GameManager.instance.EnemyKill >= 30)
            {
                VigObject vigObject = vData.ini.FUN_2C17C((ushort)num, typeof(VigObject), 8u);
                Utilities.FUN_2CA94(this, configContainer, vigObject);
                vigObject.FUN_2C7D0();
                if (vigObject.vMesh != null)
                {
                    vigObject.vMesh.DAT_02 = -4;
                }
            }
            next = configContainer.previous;
        }
        int num2 = 0;
        byte b = 0;
        if (GameManager.instance.EnemyKill >= 30)
        {
            b = 50;
            do
            {
                VigObject vigObject = wheels[num2];
                if (vigObject != null)
                {
                    ConfigContainer configContainer2 = vigObject.FUN_2C6F8(256);
                    if (configContainer2 != null)
                    {
                        GameManager.instance.FUN_2C4B4(vigObject.child2);
                        if (vigObject.vLOD != null && vigObject.vLOD != vigObject.vMesh)
                        {
                            GameManager.instance.FUN_1FEB8(vigObject.vLOD);
                        }
                        GameManager.instance.FUN_1FEB8(vigObject.vMesh);
                        ushort param = (ushort)vigObject.vData.ini.FUN_2C73C(configContainer2);
                        vigObject.FUN_2C344(vigObject.vData, param, 8u);
                        vigObject.FUN_2C7D0();
                    }
                }
                num2++;
            }
            while (num2 < 6);
            if (GameManager.instance.EnemyKill >= 70)
            {
                Debug.Log("HOOOOOOOOOT");
                DAT_F6 |= 1024;
                b = 100;
            }
        }
        Utilities.ParentChildren(this, this);
        VehicleData vehicleData = GameManager.vehicleConfigs[(int)vehicle];
        DAT_B3 = (byte)(vehicleData.DAT_13 + (vehicleData.DAT_14 - vehicleData.DAT_13) * b / 100);
        lightness = vehicleData.lightness + (vehicleData.DAT_20 - vehicleData.lightness) * b / 100;
        DAT_AF = (byte)(vehicleData.DAT_15 + (vehicleData.DAT_16 - vehicleData.DAT_15) * b / 100);
        FUN_3C404((ushort)(vehicleData.maxHalfHealth + (vehicleData.DAT_1A - vehicleData.maxHalfHealth) * b / 100));
    }

    public void FUN_3C404(ushort param1)
    {
        maxHalfHealth = param1;
        int num = 0;
        do
        {
            if (body[num] != null)
            {
                body[num].maxHalfHealth = param1;
            }
            num++;
        }
        while (num < 2);
        ushort num2 = maxFullHealth = ((!(body[0] == null)) ? ((ushort)(body[0].maxHalfHealth + body[1].maxHalfHealth)) : maxHalfHealth);
    }

    public int FUN_3B424(VigObject param1, HitDetection param2)
    {
        VigObject self = param2.self;
        if (param2.object2.type != 3)
        {
            if (param2.object2.type == 10)
            {
                return 0;
            }
            GameManager.instance.FUN_2F798(param1, param2);
            switch ((sbyte)self.type)
            {
                case 8:
                    if (param2.object1.type == 3)
                    {
                        return 0;
                    }
                    if (shield != 0)
                    {
                        FUN_393F8();
                        shield -= (ushort)((int)self.maxHalfHealth / 3);
                        return 0;
                    }
                    if (param1.type == 2)
                    {
                        if ((self.flags & 0x20000000) == 0)
                        {
                            ((Vehicle)param1).FUN_39DCC(-self.maxHalfHealth, param2.position, param3: true);
                            return 0;
                        }
                        int param3 = FUN_3B078(self.DAT_80, (ushort)self.DAT_1A, -self.maxHalfHealth, (self.flags >> 30) & 1);
                        ((Vehicle)param1).FUN_39DCC(param3, param2.position, param3: true);
                        self.flags &= 3758096383u;
                    }
                    else if (param1.GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        param1.UpdateW(8, self.maxHalfHealth);
                        return 0;
                    }
                    break;
                case 7:
                    {
                        int num3;
                        if ((self.flags & 0x1000000) == 0)
                        {
                            num3 = Utilities.FUN_29E84(new Vector3Int(self.physics1.Z, self.physics1.W, self.physics2.X));
                            int num10 = self.DAT_58;
                            if (num10 < 0)
                            {
                                num10 += 255;
                            }
                            num3 *= num10 >> 8;
                        }
                        else
                        {
                            int num10 = self.DAT_58;
                            if (num10 < 0)
                            {
                                num10 += 255;
                            }
                            num3 = self.physics1.Y * num10 >> 8;
                        }
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        uint num2 = (uint)maxHalfHealth >> 2;
                        if (num3 >> 12 < (int)num2)
                        {
                            num2 = (uint)(num3 >> 12);
                        }
                        self.flags |= 32u;
                        if (param1.type == 2)
                        {
                            ((Vehicle)param1).FUN_3A020((int)(0 - num2), param2.position, param3: false);
                            return 0;
                        }
                        if (param1.GetType().IsSubclassOf(typeof(VigObject)) && param1.type != 10)
                        {
                            param1.UpdateW(8, (int)(0 - num2));
                            return 0;
                        }
                        break;
                    }
                case 2:
                    {
                        Vector3Int v2 = default(Vector3Int);
                        v2.x = param1.physics1.X * (int)((uint)(ushort)param1.DAT_A6 >> 6) - self.physics1.X * (int)((uint)(ushort)self.DAT_A6 >> 6);
                        v2.y = param1.physics1.Y * (int)((uint)(ushort)param1.DAT_A6 >> 6) - self.physics1.Y * (int)((uint)(ushort)self.DAT_A6 >> 6);
                        v2.z = param1.physics1.Z * (int)((uint)(ushort)param1.DAT_A6 >> 6) - self.physics1.Z * (int)((uint)(ushort)self.DAT_A6 >> 6);
                        ulong num = (ulong)Utilities.FUN_2AD3C(v2, param2.normal1);
                        uint num2 = ((uint)num >> 13) | ((uint)(num >> 32) << 19);
                        if ((int)num2 < 0)
                        {
                            int num3 = (int)num2 / (int)((uint)(ushort)param1.DAT_A6 >> 6);
                            Vector3Int v = Utilities.FUN_24210(param1.vTransform.rotation, param2.normal1);
                            uint num5 = (uint)(-(param2.distance + num3));
                            int num4 = (int)num5 >> 31;
                            int num6 = v.x * num4;
                            int num7 = v.z * num4;
                            v.x = ((int)((uint)((long)(uint)v.x * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.x * (long)num5) >> 32) + num6 + (int)num5 * (v.x >> 31)) * 1048576));
                            v.y = ((int)((uint)((long)(uint)v.y * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.y * (long)num5) >> 32) + v.y * num4 + (int)num5 * (v.y >> 31)) * 1048576));
                            v.z = ((int)((uint)((long)(uint)v.z * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.z * (long)num5) >> 32) + num7 + (int)num5 * (v.z >> 31)) * 1048576));
                            param1.FUN_2B1FC(v, param2.position, 1);
                            if (num3 < 0)
                            {
                                num3 += 8191;
                            }
                            num3 >>= 13;
                            if (num3 < -8)
                            {
                                if (param1.type == 2)
                                {
                                    if (id <= 0 || self.id <= 0)
                                    {
                                        ((Vehicle)param1).FUN_3A020(num3, param2.position, param3: true);
                                    }
                                }
                                else if (param1.GetType().IsSubclassOf(typeof(VigObject)))
                                {
                                    param1.UpdateW(8, -num3);
                                }
                                if (id < 0)
                                {
                                    GameManager.instance.FUN_15AA8(~id, 10, 192, 0, 64);
                                }
                            }
                            param2.position = Utilities.FUN_24148(param1.vTransform, param2.position);
                            param2.position = Utilities.FUN_24304(self.vTransform, param2.position);
                            num3 = (int)num2 / (int)((uint)(ushort)self.DAT_A6 >> 6);
                            v = Utilities.FUN_24210(self.vTransform.rotation, param2.normal1);
                            num2 = (uint)(param2.distance + num3);
                            num4 = (int)num2 >> 31;
                            num6 = v.x * num4;
                            v.x = ((int)((uint)((long)(uint)v.x * (long)num2) >> 12) | (((int)((ulong)((long)(uint)v.x * (long)num2) >> 32) + num6 + (int)num2 * (v.x >> 31)) * 1048576));
                            v.y = ((int)((uint)((long)(uint)v.y * (long)num2) >> 12) | (((int)((ulong)((long)(uint)v.y * (long)num2) >> 32) + v.y * num4 + (int)num2 * (v.y >> 31)) * 1048576));
                            v.z = ((int)((uint)((long)(uint)v.z * (long)num2) >> 12) | (((int)((ulong)((long)(uint)v.z * (long)num2) >> 32) + v.z * num4 + (int)num2 * (v.z >> 31)) * 1048576));
                            self.FUN_2B1FC(v, param2.position, 1);
                            if (num3 < 0)
                            {
                                num3 += 8191;
                            }
                            num3 >>= 13;
                            if (num3 < -8)
                            {
                                if (doubleDamage != 0)
                                {
                                    num3 <<= 1;
                                }
                                if (id <= 0 || self.id <= 0)
                                {
                                    if ((DAT_F6 & 0x100) == 0)
                                    {
                                        ((Vehicle)self).FUN_3A020(num3, param2.position, param3: true);
                                    }
                                    else
                                    {
                                        ((Vehicle)self).FUN_3B078(this, 65535u, num3, 1u);
                                    }
                                }
                                if (self.id < 0)
                                {
                                    GameManager.instance.FUN_15AA8(~self.id, 10, 192, 0, 64);
                                }
                            }
                            if ((flags & 0x8000) == 0 && 457 < physics1.W)
                            {
                                int param3 = GameManager.instance.FUN_1DD9C();
                                GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 31, self.screen);
                            }
                        }
                        flags |= 16809984u;
                        return 0;
                    }
                default:
                    {
                        bool flag = false;
                        if ((PDAT_74 == self || PDAT_78 == self) && param2.normal1.y < -2048)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            return 0;
                        }
                        ulong num = (ulong)Utilities.FUN_2AD3C(new Vector3Int(param1.physics1.X, param1.physics1.Y, param1.physics1.Z), param2.normal1);
                        uint num2 = (uint)((int)((uint)num >> 13) | (int)(num >> 32 << 19));
                        int num3 = 0;
                        if ((int)num2 < 0)
                        {
                            num3 = (int)(0 - num2);
                            if (0 < (int)num2)
                            {
                                num3 += 16383;
                            }
                            int num4 = (num3 >> 14) * param1.DAT_A6;
                            if (num4 < 0)
                            {
                                num4 += 4095;
                            }
                            num3 = 0;
                            if (self.GetType().IsSubclassOf(typeof(VigObject)) && !flag)
                            {
                                num3 = (int)self.UpdateW(8, num4 >> 12);
                            }
                            if (num3 == 0)
                            {
                                Vector3Int v = Utilities.FUN_24210(param1.vTransform.rotation, param2.normal1);
                                uint num5 = (uint)(-(param2.distance * 10 + (int)num2));
                                num4 = (int)num5 >> 31;
                                int num6 = v.x * num4;
                                int num7 = v.z * num4;
                                v.x = ((int)((uint)((long)(uint)v.x * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.x * (long)num5) >> 32) + num6 + (int)num5 * (v.x >> 31)) * 1048576));
                                v.y = ((int)((uint)((long)(uint)v.y * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.y * (long)num5) >> 32) + v.y * num4 + (int)num5 * (v.y >> 31)) * 1048576));
                                v.z = ((int)((uint)((long)(uint)v.z * (long)num5) >> 12) | (((int)((ulong)((long)(uint)v.z * (long)num5) >> 32) + num7 + (int)num5 * (v.z >> 31)) * 1048576));
                                param1.FUN_2B1FC(v, param2.position);
                                if ((flags & 0x8000) == 0 && !flag)
                                {
                                    int num8 = (int)(num2 + 16383) >> 14;
                                    num4 = -self.maxHalfHealth;
                                    if (-self.maxHalfHealth < num8)
                                    {
                                        num4 = num8;
                                    }
                                    if (param1.type == 2)
                                    {
                                        ((Vehicle)param1).FUN_3A020(num4, param2.position, param3: false);
                                    }
                                    else if (param1.GetType().IsSubclassOf(typeof(VigObject)))
                                    {
                                        param1.UpdateW(8, -num4);
                                    }
                                    if (id < 0)
                                    {
                                        GameManager.instance.FUN_15B00(~id, byte.MaxValue, 0, 64);
                                    }
                                    if (457 < param1.physics1.W)
                                    {
                                        num2 = (uint)(ushort)self.id >> 4;
                                        int num9 = 11;
                                        if (num2 < 11)
                                        {
                                            num9 = (int)num2;
                                        }
                                        sbyte b = Utilities.DAT_106E8[num9];
                                        if (b != -1)
                                        {
                                            int param3 = GameManager.instance.FUN_1DD9C();
                                            GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, b, self.screen);
                                        }
                                    }
                                    if (1525 < param1.physics1.W && -32 < num4 / param1.physics1.W)
                                    {
                                        self = LevelManager.instance.xobfList[19].ini.FUN_2C17C(46, typeof(Ballistic), 8u);
                                        Vector3Int screen = Utilities.FUN_24148(param1.vTransform, param2.position);
                                        self.type = 4;
                                        self.flags = 164u;
                                        self.screen = screen;
                                        self.FUN_3066C();
                                    }
                                }
                                flags |= 16809984u;
                            }
                        }
                        if (num3 < 1)
                        {
                            return num3;
                        }
                        break;
                    }
            }
        }
        return 0;
    }

    public void FUN_3B344()
    {
        ushort dAT_BA = DAT_BA;
        if (dAT_BA == 0)
        {
            return;
        }
        DAT_BA = (byte)(dAT_BA - 1);
        if (dAT_BA == 1 && DAT_BD != 0)
        {
            if (id < 0)
            {
                IEnumerator routine = UIManager.instance.Printf(DAT_BD.ToString() + " x WHAMMY!");
                UIManager.instance.StopAllCoroutines();
                UIManager.instance.StartCoroutine(routine);
                FUN_3AC4C();
            }
            byte dAT_BD = DAT_BD;
            DAT_BA = 30;
            DAT_BD = 0;
            DAT_BE += dAT_BD;
        }
    }

    public string FUN_38398()
    {
        if (-1 < id)
        {
            return Utilities.DAT_310[(int)vehicle];
        }
        else
        {
            return Demo.instance.lobbyInput.text;
        }
        return "PLAYER";
    }

    public int FUN_3B078(VigObject param1, uint param2, int param3, uint param4)
    {
        int id = param1.id;
        if ((flags & 0x4000) == 0)
        {
            param3 = 0;
        }
        else
        {
            if (id < 0)
            {
                param3 = param3 << (GameManager.instance.damageMode[~id] & 0x1F) >> 1;
            }
            Vehicle vehicle = (Vehicle)param1;
            if (id == -2 && GameManager.instance.gameMode - 6 < _GAME_MODE.Alone)
            {
                param2 ^= 0x80;
                vehicle = GameManager.instance.playerObjects[0];
            }
            if (vehicle.DAT_BA == 0 || base.id != vehicle.DAT_BB || param2 == vehicle.DAT_BC)
            {
                byte b = 30;
                if (vehicle.DAT_BD != 0)
                {
                    b = 1;
                }
                vehicle.DAT_BA += b;
                b = (byte)base.id;
                vehicle.DAT_BC = (byte)param2;
                vehicle.DAT_BB = (sbyte)b;
            }
            else
            {
                vehicle.DAT_BC = (byte)param2;
                uint num = (uint)(++vehicle.DAT_BD + 1);
                vehicle.DAT_BA += 30;
                int num2 = param3;
                uint num3 = (param4 != 0) ? (num * 13) : (num * 10);
                num2 += param3 * (int)num3 / 100;
                param3 = -65535;
                if (-65535 < num2)
                {
                    param3 = num2;
                }
            }
            if ((GameManager.instance.gameMode < _GAME_MODE.Versus2 || base.id == -1 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && base.id > 0)) && maxHalfHealth == 0 && param4 != 0)
            {
                if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && base.id == -1)
                {
                    ClientSend.Totaled();
                }
                else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && base.id > 0)
                {
                    GameManager.instance.networkEnemies.Remove(this);
                    ClientSend.TotaledAI(base.id);
                }
                if (id < 0)
                {
                    string str = FUN_38398();
                    IEnumerator routine = UIManager.instance.Printf(str + " TOTALED!");
                    UIManager.instance.StopAllCoroutines();
                    UIManager.instance.StartCoroutine(routine);
                }
                FUN_38870();
                UIManager.instance.FUN_4E414(vTransform.position, new Color32(byte.MaxValue, 0, 0, 8));
                physics2.Y = 50000;
                physics1.Y -= 976512;
                param1.FUN_3AC4C();
                vehicle.DAT_BF++;
                int num4 = 0;
                if (GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2)
                {
                    num4 = (int)GameManager.FUN_2AC5C();
                    Vector3Int param5 = default(Vector3Int);
                    param5.x = (num4 * 3051 >> 15) - 1525;
                    param5.y = -4577;
                    num4 = (int)GameManager.FUN_2AC5C();
                    param5.z = (num4 * 3051 >> 15) - 1525;
                    LevelManager.instance.FUN_4AA24(0, vTransform.position, param5);
                }
                else
                {
                    do
                    {
                        bool num5 = FUN_38A38(param1: false);
                        num4++;
                        if (!num5)
                        {
                            return param3;
                        }
                    }
                    while (num4 < 3);
                }
            }
        }
        return param3;
    }

    public VigObject FUN_4AE94(int param1)
    {
        VigObject vigObject;
        if (param1 == 7)
        {
            ConfigContainer configContainer = FUN_2C5F4(32799);
            Type type = Utilities.vehicleSpecials[(int)vehicle];
            if (type == null)
            {
                type = typeof(Empty);
            }
            if (configContainer == null)
            {
                return null;
            }
            vigObject = Utilities.FUN_31D30_2(type, vData, (short)configContainer.next, 8u);
        }
        else
        {
            vigObject = Utilities.FUN_31D30(Utilities.weaponTypes[param1].Value, LevelManager.instance.xobfList[19], (short)Utilities.weaponTypes[param1].Key, 8u);
        }
        vigObject.id = 0;
        vigObject.tags = (sbyte)param1;
        vigObject.flags |= 32u;
        Utilities.ParentChildren(vigObject, vigObject);
        if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
        {
            vigObject.UpdateW(1, this);
        }
        return vigObject;
    }

    public void FUN_3A500(uint param1)
    {
        uint num = 0u;
        do
        {
            if ((param1 & (16777216 << (int)(num & 0x1F))) != 0L)
            {
                ConfigContainer configContainer = FUN_4AE5C((int)num);
                if (configContainer != null)
                {
                    VigObject vigObject = FUN_4AE94((int)num);
                    int num2 = -1;
                    if (vigObject != null)
                    {
                        Utilities.FUN_2CA94(this, configContainer, vigObject);
                        vigObject.transform.parent = base.transform;
                        bool flag = true;
                        if (num != 0)
                        {
                            VigObject x = weapons[0];
                            num2 = 0;
                            while (x != null)
                            {
                                if (2 >= num2)
                                {
                                    x = weapons[num2 + 1];
                                    num2++;
                                    continue;
                                }
                                goto IL_00db;
                            }
                            flag = (num2 < 3);
                        }
                        if (flag)
                        {
                            if (num2 == -1)
                            {
                                mgun = vigObject;
                            }
                            else
                            {
                                weapons[num2] = vigObject;
                                if ((DAT_F6 & 0x400) != 0)
                                {
                                    vigObject.maxHalfHealth *= 2;
                                    vigObject.maxFullHealth *= 2;
                                }
                            }
                        }
                    }
                }
            }
            goto IL_00db;
        IL_00db:
            num++;
        }
        while (7 >= (int)num);
    }

    public void FUN_3A3D4(VigObject param1)
    {
        param1.id = 0;
        Utilities.FUN_2CC48(this, param1);
        param1.transform.parent = base.transform;
        uint num = 0u;
        if (weapons[0] != null)
        {
            int num2 = 0;
            while (2 >= (int)num)
            {
                num2++;
                if (weapons[num].tags == param1.tags)
                {
                    param1.tags = (sbyte)(-param1.tags);
                    return;
                }
                num++;
                if (num2 > 2 || !(weapons[num2] != null))
                {
                    break;
                }
            }
        }
        if (num == 3)
        {
            uint num3 = weaponSlot;
            num = num3;
            if (id < 1 || GameManager.instance.gameMode == _GAME_MODE.Versus2 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0))
            {
                if (7 < weapons[num3].tags)
                {
                    num = 2u;
                    if (num3 != 0)
                    {
                        num = num3 - 1;
                    }
                }
            }
            else if (weapons[num3].tags == 7)
            {
                num = 2u;
                if (num3 != 0)
                {
                    num = num3 - 1;
                }
            }
            FUN_3A148((int)num);
        }
        weapons[num] = param1;
    }

    private void FUN_3A148(int param1)
    {
        DAT_B6[param1] = 0;
        VigObject vigObject = weapons[param1];
        if (vigObject.tags < 8)
        {
            Throwaway throwaway = vigObject.FUN_4ECA0(param1: true);
            throwaway.id = id;
            int num = physics1.X;
            if (num < 0)
            {
                num += 127;
            }
            throwaway.physics1.Z += num >> 7;
            num = physics1.Y;
            if (num < 0)
            {
                num += 127;
            }
            throwaway.physics1.W += num >> 7;
            num = physics1.Z;
            if (num < 0)
            {
                num += 127;
            }
            throwaway.physics2.X += num >> 7;
            int param2 = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 46, throwaway.vTransform.position);
            if (throwaway.maxHalfHealth != 0 && throwaway.tags != 7)
            {
                throwaway.state = _THROWAWAY_TYPE.Spawnable;
            }
        }
        else
        {
            vigObject.FUN_2CCBC();
            GameManager.instance.FUN_307CC(vigObject);
            flags &= 4294705151u;
        }
    }

    public void FUN_3A0C0(int param1)
    {
        uint maxHalfHealth = base.maxHalfHealth;
        if (body[0] == null)
        {
            ushort num = maxFullHealth;
            if ((int)maxHalfHealth + param1 < num)
            {
                num = (ushort)((int)maxHalfHealth + param1);
            }
            base.maxHalfHealth = num;
            return;
        }
        int num2 = 0;
        if (param1 == 0)
        {
            return;
        }
        while (1 >= num2)
        {
            uint maxHalfHealth2 = body[num2].maxHalfHealth;
            uint num3 = (uint)((int)maxHalfHealth2 + param1);
            uint num4 = maxHalfHealth;
            if ((int)num3 < (int)maxHalfHealth)
            {
                num4 = num3;
            }
            body[num2].maxHalfHealth = (ushort)num4;
            param1 -= (int)(num4 - maxHalfHealth2);
            num2++;
            if (param1 == 0)
            {
                break;
            }
        }
    }

    public void FUN_391AC()
    {
        if ((flags & 0x4000) != 0 && (flags & 0x4000000) == 0 && type != 13)
        {
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 38, vTransform.position);
            param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 39, vTransform.position);
            param = -25;
            if (id < 0)
            {
                param = -100;
            }
            FUN_39FF8(param, param2: false);
            state = _VEHICLE_TYPE.Drowning;
            flags = (uint)(((int)flags & -11) | 0x6020020);
            GameManager.instance.FUN_30CB0(this, 90);
            VigCamera vigCamera = vCamera;
            if (vigCamera != null)
            {
                vigCamera.DAT_84 = new Vector3Int(0, 0, 0);
                vigCamera.flags |= 67108864u;
            }
        }
    }

    public bool FUN_39FF8(int param1, bool param2)
    {
        return FUN_3A020(param1, GameManager.DAT_9C4, param2);
    }

    public void FUN_39BC4()
    {
        if ((DAT_F6 & 0x10) == 0)
        {
            DAT_F6 |= 16;
            int num = (int)GameManager.FUN_2AC5C();
            int num2 = DAT_18;
            ignition = (short)((num * 180 >> 15) + 180);
            acceleration = -120;
            if (id >= 0)
            {
                ai.rubberTimer = 800;
            }
            if (num2 == 0)
            {
                num2 = GameManager.instance.FUN_1DD9C();
            }
            GameManager.instance.FUN_1E628(num2, GameManager.instance.DAT_C2C, 33, vTransform.position);
            if (id < 0)
            {
                DAT_18 = 0;
                return;
            }
            sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E098(param, GameManager.instance.DAT_C2C, 34, 0u, param5: true);
        }
    }

    public bool FUN_39DCC(int param1, Vector3Int param2, bool param3)
    {
        ushort maxHalfHealth = base.maxHalfHealth;
        uint num = maxHalfHealth;
        if (param1 < 0)
        {
            if (num == 0)
            {
                return false;
            }
            ushort num2 = transformation;
            if (num2 != 0)
            {
                if (-param1 < num2)
                {
                    transformation = (ushort)(num2 + param1);
                }
                else if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1)
                {
                    FUN_3E32C(_WHEELS.Ground, 0);
                    if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
                    {
                        ClientSend.Pickup(16, 0, 0);
                    }
                }
                else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
                {
                    FUN_3E32C(_WHEELS.Ground, 0);
                    ClientSend.PickupAI(id, 16, 0, 0);
                }
            }
            if (body[0] == null)
            {
                if ((int)num + param1 < 1)
                {
                    if (param3)
                    {
                        if (param1 < -20)
                        {
                            FUN_38C40();
                            return true;
                        }
                        FUN_38DA8();
                        return false;
                    }
                }
                else
                {
                    base.maxHalfHealth = (ushort)((int)num + param1);
                }
            }
            else
            {
                uint num3 = (param2.z < 1) ? 1u : 0u;
                VigObject vigObject = body[num3];
                uint num4 = (uint)maxHalfHealth >> 1;
                while (vigObject != null)
                {
                    param1 = vigObject.maxHalfHealth + param1;
                    if ((vigObject.maxHalfHealth * vigObject.tags + (int)num4) / (int)num != (param1 * vigObject.tags + (int)num4) / (int)num)
                    {
                        vigObject.FUN_4DC94();
                        vigObject.IDAT_78 = 0;
                        vigObject.IDAT_74 = 0;
                        if (vigObject.PDAT_74 != null)
                        {
                            vigObject.PDAT_74.gameObject.SetActive(value: false);
                        }
                        if (vigObject.PDAT_78 != null)
                        {
                            vigObject.PDAT_78.gameObject.SetActive(value: false);
                        }
                        vigObject.PDAT_78 = null;
                        vigObject.PDAT_74 = null;
                        if (vigObject == body[0] && (DAT_F6 & 0x80) != 0)
                        {
                            FUN_36634();
                        }
                    }
                    if (-1 < param1)
                    {
                        vigObject.maxHalfHealth = (ushort)param1;
                        return false;
                    }
                    vigObject.maxHalfHealth = 0;
                    num3 = 1 - num3;
                    if (body[0].maxHalfHealth == 0 && body[1].maxHalfHealth == 0)
                    {
                        if (param3)
                        {
                            if (param1 < -20)
                            {
                                FUN_38C40();
                                return true;
                            }
                            FUN_38DA8();
                            return false;
                        }
                        return false;
                    }
                    vigObject = body[num3];
                }
            }
        }
        return false;
    }

    public void FUN_3670C(bool param1)
    {
        if (!param1)
        {
            VigObject vigObject = body[0];
            DAT_F6 &= 65407;
            if (vigObject != null)
            {
                if (vigObject.PDAT_74 != null)
                {
                    VigObject param2 = vigObject.PDAT_74.FUN_2CCBC();
                    GameManager.instance.FUN_2C4B4(param2);
                    vigObject.PDAT_74 = null;
                }
                if (vigObject.PDAT_78 != null)
                {
                    VigObject param2 = vigObject.PDAT_78.FUN_2CCBC();
                    GameManager.instance.FUN_2C4B4(param2);
                    vigObject.PDAT_78 = null;
                }
            }
        }
        else
        {
            DAT_F6 |= 128;
            FUN_36634();
        }
    }

    public void FUN_36634()
    {
        VigObject vigObject = body[0];
        if (vigObject != null)
        {
            ConfigContainer configContainer = vigObject.FUN_2C5F4(32832);
            if (configContainer != null)
            {
                VigObject vigObject2 = vigObject.PDAT_74 = LevelManager.instance.xobfList[18].ini.FUN_2C17C(87, typeof(VigObject), 8u);
                Utilities.FUN_2CB04(vigObject, configContainer, vigObject2);
                Utilities.ParentChildren(vigObject, vigObject);
                vigObject2.vMesh.DAT_02 = -1;
            }
            configContainer = vigObject.FUN_2C5F4(32833);
            if (configContainer != null)
            {
                VigObject vigObject2 = vigObject.PDAT_78 = LevelManager.instance.xobfList[18].ini.FUN_2C17C(87, typeof(VigObject), 8u);
                Utilities.FUN_2CB04(vigObject, configContainer, vigObject2);
                Utilities.ParentChildren(vigObject, vigObject);
                vigObject2.vMesh.DAT_02 = -1;
            }
        }
    }

    public bool FUN_39B50()
    {
        if ((DAT_F6 & 8) != 0)
        {
            VigObject vigObject = child2;
            while (vigObject != null)
            {
                if (vigObject.GetType() == typeof(Fire1))
                {
                    GameManager.instance.FUN_30CB0(vigObject, 0);
                    return true;
                }
                vigObject = vigObject.child;
            }
        }
        return false;
    }

    public void FUN_3968C(Wheel param1)
    {
        if (wheelsType == _WHEELS.Ground && (param1.flags & 0x40000000) == 0)
        {
            param1.state = _WHEEL_TYPE.Flatten;
            param1.flags |= 1073741824u;
            param1.physics2.X -= 3072;
            flags |= 131072u;
            GameManager.instance.FUN_30CB0(param1, 300);
            Vector3Int param2 = GameManager.instance.FUN_2CE50(param1);
            LevelManager.instance.FUN_4DE54(param2, 13);
        }
    }

    public bool FUN_39714(Vector3Int param1)
    {
        bool result = false;
        if (wheelsType == _WHEELS.Ground && shield == 0)
        {
            Vector3Int vector3Int = Utilities.FUN_24304(vTransform, param1);
            int num = (0 < vector3Int.x) ? 1 : 0;
            if (vector3Int.z < 0)
            {
                num |= 2;
            }
            Wheel wheel = wheels[num];
            if (wheel == null)
            {
                wheel = wheels[num & 2];
                if (wheel == null)
                {
                    return false;
                }
            }
            if ((wheel.flags & 0x40000000) == 0)
            {
                wheel.state = _WHEEL_TYPE.Flatten;
                wheel.flags |= 1073741824u;
                wheel.physics2.X -= 3072;
                flags |= 131072u;
                GameManager.instance.FUN_30CB0(wheel, 300);
                Vector3Int param2 = GameManager.instance.FUN_2CE50(wheel);
                LevelManager.instance.FUN_4DE54(param2, 13);
                int param3 = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 40, vTransform.position);
                result = true;
            }
            else
            {
                result = false;
            }
        }
        return result;
    }

    public void FUN_38C40()
    {
        if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0))
        {
            if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id == -1)
            {
                ClientSend.Destroyed();
            }
            else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && id > 0)
            {
                GameManager.instance.networkEnemies.Remove(this);
                ClientSend.DestroyedAI(id);
            }
            if (GameManager.instance.gameMode != _GAME_MODE.Survival && GameManager.instance.gameMode != _GAME_MODE.Survival2)
            {
                FUN_38A38(param1: true);
            }
            string str = FUN_38398();
            IEnumerator routine = UIManager.instance.Printf(str + " destroyed!");
            UIManager.instance.StopAllCoroutines();
            UIManager.instance.StartCoroutine(routine);
            FUN_38870();
        }
    }

    public void FUN_38C40_2()
    {
        if (GameManager.instance.gameMode != _GAME_MODE.Survival && GameManager.instance.gameMode != _GAME_MODE.Survival2)
        {
            FUN_38A38(param1: true);
        }
        string str = FUN_38398();
        IEnumerator routine = UIManager.instance.Printf(str + " destroyed!");
        UIManager.instance.StopAllCoroutines();
        UIManager.instance.StartCoroutine(routine);
        FUN_38870();
    }

    public void FUN_38DA8()
    {
        if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id == -1 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0))
        {
            if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id == -1)
            {
                ClientSend.Wrecked();
            }
            else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && id > 0)
            {
                ClientSend.WreckedAI(id);
            }
            GameManager.instance.FUN_30CB0(this, 300);
            state = _VEHICLE_TYPE.Wrecked;
            maxHalfHealth = 0;
            acceleration = 0;
            direction = 0;
            GameManager.instance.FUN_1DE78(DAT_DF);
            int num = DAT_18;
            if (num == 0)
            {
                num = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
            }
            GameManager.instance.FUN_1E628(num, GameManager.instance.DAT_C2C, 35, vTransform.position, param5: true);
            if (0 < id || GameManager.instance.gameMode == _GAME_MODE.Versus || _GAME_MODE.Unk1 < GameManager.instance.gameMode)
            {
                string str = FUN_38398();
                IEnumerator routine = UIManager.instance.Printf(str + " wrecked; Total it!");
                UIManager.instance.StopAllCoroutines();
                UIManager.instance.StartCoroutine(routine);
            }
            ConfigContainer configContainer = FUN_2C5F4(33025);
            if (configContainer != null)
            {
                Smoke smoke = LevelManager.instance.xobfList[19].FUN_4F438(5, GameManager.DAT_9C4);
                smoke.flags |= 33554432u;
                Utilities.FUN_2CA94(this, configContainer, smoke);
                smoke.transform.parent = base.transform;
                smoke.FUN_30B78();
                smoke.FUN_30BF0();
            }
        }
    }

    public void FUN_38DA8_2()
    {
        GameManager.instance.FUN_30CB0(this, 300);
        state = _VEHICLE_TYPE.Wrecked;
        maxHalfHealth = 0;
        acceleration = 0;
        direction = 0;
        GameManager.instance.FUN_1DE78(DAT_DF);
        int num = DAT_18;
        if (num == 0)
        {
            num = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
        }
        GameManager.instance.FUN_1E628(num, GameManager.instance.DAT_C2C, 35, vTransform.position, param5: true);
        if (0 < id || GameManager.instance.gameMode == _GAME_MODE.Versus || _GAME_MODE.Unk1 < GameManager.instance.gameMode)
        {
            string str = FUN_38398();
            IEnumerator routine = UIManager.instance.Printf(str + " wrecked; Total it!");
            UIManager.instance.StopAllCoroutines();
            UIManager.instance.StartCoroutine(routine);
        }
        ConfigContainer configContainer = FUN_2C5F4(33025);
        if (configContainer != null)
        {
            Smoke smoke = LevelManager.instance.xobfList[19].FUN_4F438(5, GameManager.DAT_9C4);
            smoke.flags |= 33554432u;
            Utilities.FUN_2CA94(this, configContainer, smoke);
            smoke.transform.parent = base.transform;
            smoke.FUN_30B78();
            smoke.FUN_30BF0();
        }
    }

    public bool FUN_38A38(bool param1)
    {
        int num = (int)GameManager.FUN_2AC5C();
        Vector3Int param2 = default(Vector3Int);
        param2.x = (num * 3051 >> 15) - 1525;
        param2.y = -4577;
        num = (int)GameManager.FUN_2AC5C();
        param2.z = (num * 3051 >> 15) - 1525;
        uint num2 = 1u;
        uint num3 = DAT_C0;
        if (param1)
        {
            num2 = GameManager.FUN_2AC5C();
            num3 = (uint)((int)num3 >> ((GameManager.DAT_63F60[num2 & 7] & 0xF) << 1));
        }
        num3 &= 3;
        num2 = (uint)(((sbyte)GameManager.instance.difficultyMode + 1) * (GameManager.instance.damageMode[0] + 1) + 1);
        bool result = false;
        if (num2 != 0)
        {
            Pickup pickup = LevelManager.instance.FUN_4AA24((ushort)GameManager.DAT_63F58[num3], vTransform.position, param2);
            result = ((num2 & 0xFFFF) != 0);
            pickup.maxHalfHealth = (ushort)num2;
        }
        return result;
    }

    public void FUN_38870()
    {
        int num = (int)FUN_4DC20();
        short param;
        if (num == 0)
        {
            param = 0;
        }
        else
        {
            ConfigContainer configContainer = vData.ini.configContainers[num];
            VigTransform param2 = GameManager.instance.FUN_2CEAC(this, configContainer);
            vData.FUN_4D498(configContainer.next, param2, id);
            param = 0;
            if (configContainer.objID != 43690)
            {
                param = (short)configContainer.objID;
            }
        }
        num = 0;
        GameManager.instance.FUN_30CB0(this, param);
        state = _VEHICLE_TYPE.Chasis;
        UnityEngine.Object.Destroy(unit);
        UnityEngine.Object.Destroy(gameTag);
        unit = null;
        gameTag = null;
        maxHalfHealth = 0;
        acceleration = 0;
        DAT_C8 = 0;
        flags = (uint)(((int)flags & -16385) | 0x8000);
        GameManager.instance.FUN_1DE78(DAT_18);
        GameManager.instance.FUN_1DE78(DAT_DF);
        ai.FUN_51CC0();
        Vehicle[] playerObjects = GameManager.instance.playerObjects;
        target = null;
        do
        {
            Vehicle vehicle = playerObjects[num];
            if (vehicle != null && vehicle.target == this)
            {
                vehicle.DAT_F6 &= 65503;
                playerObjects[num].FUN_3CCD4(param1: true);
            }
            num++;
        }
        while (num < 2);
        if (0 < id || _GAME_MODE.Unk1 < GameManager.instance.gameMode || GameManager.instance.gameMode == _GAME_MODE.Versus)
        {
            GameManager.instance.EnemyKill++;
            if (GameManager.instance.EnemyKill == 1 && GameManager.instance.difficultyMode == 2)
            {
                FUN_38398();
                Debug.Log("Approaching HOOOOOOOOOOOT!");
                IEnumerator routine = UIManager.instance.Printf("Approaching Hotrod!");
                UIManager.instance.StopAllCoroutines();
                UIManager.instance.StartCoroutine(routine);
                GameManager.instance.DAT_1030[0] = 0;
                GameManager.instance.DAT_1030[1] = 0;
                GameManager.instance.DAT_1030[2] = 0;
                GameManager.instance.DAT_1030[3] = 0;
            }
        }
        if (id < 1)
        {
            if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
            {
                if (GameManager.instance.playerSpawns == 0)
                {
                    vCamera.flags |= 33554432u;
                    GameManager.instance.DAT_C74 = 1;
                    UIManager.instance.LoseScreen();
                }
            }
            else if (GameManager.instance.gameMode > _GAME_MODE.Versus2)
            {
                //Originalmente era [1] pero daba error
                if (GameManager.instance.playerObjects[1].maxHalfHealth == 0)
                {
                    bool num2 = GameManager.instance.gameMode < _GAME_MODE.Unk2;
                    vCamera.flags |= 33554432u;
                    if (num2)
                    {
                        GameManager.instance.DAT_C74 = 1;
                    }
                    if (GameManager.instance.gameMode == _GAME_MODE.Coop2)
                    {
                        UIManager.instance.LoseScreen();
                    }
                    else if (GameManager.instance.gameMode == _GAME_MODE.Survival2)
                    {
                        UIManager.instance.GameOver();
                    }
                }
            }
            else
            {
                bool num3 = GameManager.instance.gameMode < _GAME_MODE.Unk2;
                vCamera.flags |= 33554432u;
                if (num3)
                {
                    GameManager.instance.DAT_C74 = 1;
                }
                if (GameManager.instance.gameMode == _GAME_MODE.Arcade)
                {
                    UIManager.instance.LoseScreen();
                }
                else if (GameManager.instance.gameMode == _GAME_MODE.Survival)
                {
                    UIManager.instance.GameOver();
                }
            }
        }
        else if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
        {
            id = 0;
        }
    }

    public void FUN_38484()
    {
        ai.FUN_51CC0();
    }

    public void FUN_39C94()
    {
        if ((DAT_F6 & 0x10) != 0)
        {
            DAT_F6 &= 65519;
            FUN_38408();
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 32, vTransform.position);
        }
    }

    public void FUN_38408()
    {
        if (DAT_18 == 0)
        {
            sbyte b = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
        }
        int param;
        sbyte dAT_;
        List<AudioClip> param2;
        if (wheelsType == _WHEELS.Ground)
        {
            param = 0;
            dAT_ = DAT_18;
            param2 = vData.sndList;
        }
        else
        {
            dAT_ = DAT_18;
            param = (int)(wheelsType + 20);
            param2 = GameManager.instance.DAT_C2C;
        }
        GameManager.instance.FUN_1E098(dAT_, param2, param, 0u, param5: true);
    }

    private void FUN_3E4A8(uint param1)
    {
        Wheel wheel = wheels[param1];
        VigObject vigObject = Utilities.FUN_2CD78(wheel);
        XOBF_DB vData = base.vData;
        _WHEELS wHEELS = wheelsType;
        if (wheel.vMesh != null)
        {
            wheel.vMesh.ClearMeshData();
        }
        GameManager.instance.FUN_1FEB8(wheel.vMesh);
        if (wheel.vLOD != null && wheel.vLOD != wheel.vMesh)
        {
            wheel.vLOD.ClearMeshData();
            GameManager.instance.FUN_1FEB8(wheel.vLOD);
        }
        MeshFilter component = wheel.GetComponent<MeshFilter>();
        MeshRenderer component2 = wheel.GetComponent<MeshRenderer>();
        if (component != null)
        {
            UnityEngine.Object.DestroyImmediate(component, allowDestroyingAssets: false);
        }
        if (component2 != null)
        {
            UnityEngine.Object.DestroyImmediate(component2, allowDestroyingAssets: false);
        }
        GameManager.instance.FUN_2C4B4(wheel.child2);
        ConfigContainer container = vData.ini.FUN_2C590((ushort)DAT_1A, (int)((param1 - 32768) & 0xFFFF));
        ConfigContainer configContainer = vData.ini.FUN_2C6D0(container, (int)wHEELS);
        XOBF_DB param2 = LevelManager.instance.xobfList[18];
        int num;
        if (configContainer == null)
        {
            if (wHEELS == _WHEELS.Ground)
            {
                num = wheel.id;
                wheel.vr = new Vector3Int(0, 0, (int)((param1 & 1) << 11));
            }
            else
            {
                num = GameManager.DAT_63F74[(param1 * 2 + (int)wHEELS * 12) / 2];
                VigConfig ini = LevelManager.instance.xobfList[18].ini;
                wheel.tags = 0;
                ConfigContainer configContainer2 = ini.configContainers[num];
                wheel.vr = configContainer2.v3_2;
                wheel.IDAT_78 = -configContainer2.v3_1.y;
                vigObject.screen.y = DAT_E4 - wheel.physics2.X;
            }
        }
        else
        {
            num = vData.ini.FUN_2C73C(configContainer);
            wheel.vr = configContainer.v3_2;
            vigObject.screen.y = wheel.physics1.Y + configContainer.v3_1.y;
            param2 = vData;
        }
        wheel.FUN_2C344(param2, (ushort)num, 8u);
        wheel.FUN_2C7D0();
        if (wheel.vAnim == null)
        {
            wheel.FUN_30C20();
        }
        else if ((wheel.flags & 4) == 0)
        {
            wheel.FUN_30BF0();
        }
        wheel.screen = new Vector3Int(0, 0, 0);
        wheel.ApplyTransformation();
        Utilities.ParentChildren(wheel, wheel);
    }

    private void FUN_3E774()
    {
        uint num = 0u;
        int num2 = --DAT_B4 - 16;
        if (num2 < 0)
        {
            num2 = -num2;
        }
        short num3 = (short)(16 - num2);
        do
        {
            Wheel wheel = wheels[num];
            if (wheel != null)
            {
                if (DAT_B4 == 16)
                {
                    FUN_3E4A8(num);
                }
                else
                {
                    VigObject vigObject = Utilities.FUN_2CD78(wheel);
                    if (DAT_B4 == 0)
                    {
                        wheel.screen = vigObject.screen;
                        wheel.vTransform.position = wheel.screen;
                        vigObject.FUN_2CCBC();
                        wheel.transform.parent = base.transform;
                        UnityEngine.Object.Destroy(vigObject.gameObject);
                        Utilities.FUN_2CC9C(this, wheel);
                    }
                    else
                    {
                        vigObject.vr.z = num3 * 64;
                        if ((num & 1) == 0)
                        {
                            vigObject.vr.z = num3 * -64;
                        }
                        vigObject.ApplyTransformation();
                    }
                }
            }
            num++;
        }
        while ((int)num < 6);
    }

    private void FUN_3E8C0()
    {
        _003C_003Ec__DisplayClass142_0 _003C_003Ec__DisplayClass142_ = default(_003C_003Ec__DisplayClass142_0);
        _003C_003Ec__DisplayClass142_._003C_003E4__this = this;
        uint num = 0u;
        if (DAT_B4 == 0)
        {
            num = (uint)(((wheelsType == _WHEELS.Ground) ? 1 : 0) << 2);
        }
        uint num2 = 0u;
        _003C_003Ec__DisplayClass142_.local_60 = new Vector3Int(0, 0, 0);
        _003C_003Ec__DisplayClass142_.local_50 = new Vector3Int(0, GameManager.instance.gravityFactor, 0);
        do
        {
            _003C_003Ec__DisplayClass142_.local_40 = default(Vector3Int);
            _003C_003Ec__DisplayClass142_.local_30 = default(Vector3Int);
            vCollider.reader.Seek(0L, SeekOrigin.Begin);
            if ((num2 & num) == 0)
            {
                if ((num2 & 1) == 0)
                {
                    _003C_003Ec__DisplayClass142_.local_40.x = vCollider.reader.ReadInt32(4);
                }
                else
                {
                    _003C_003Ec__DisplayClass142_.local_40.x = vCollider.reader.ReadInt32(16);
                }
                if ((num2 & 4) == 0)
                {
                    _003C_003Ec__DisplayClass142_.local_40.y = vCollider.reader.ReadInt32(8);
                }
                else
                {
                    _003C_003Ec__DisplayClass142_.local_40.y = vCollider.reader.ReadInt32(20);
                }
                if ((num2 & 2) == 0)
                {
                    _003C_003Ec__DisplayClass142_.local_40.z = vCollider.reader.ReadInt32(12);
                }
                else
                {
                    _003C_003Ec__DisplayClass142_.local_40.z = vCollider.reader.ReadInt32(24);
                }
                _003CFUN_3E8C0_003Eg__FUN_3EA0C_007C142_0(ref _003C_003Ec__DisplayClass142_);
            }
            else
            {
                _003C_003Ec__DisplayClass142_.iVar3 = (int)(num2 - 4);
                if (wheels[_003C_003Ec__DisplayClass142_.iVar3] != null)
                {
                    _003C_003Ec__DisplayClass142_.local_40.x = wheels[_003C_003Ec__DisplayClass142_.iVar3].screen.x;
                    _003C_003Ec__DisplayClass142_.local_40.y = wheels[_003C_003Ec__DisplayClass142_.iVar3].screen.y + wheels[_003C_003Ec__DisplayClass142_.iVar3].physics2.X;
                    _003C_003Ec__DisplayClass142_.local_40.z = wheels[_003C_003Ec__DisplayClass142_.iVar3].screen.z;
                    _003CFUN_3E8C0_003Eg__FUN_3EA0C_007C142_0(ref _003C_003Ec__DisplayClass142_);
                }
            }
            num2++;
        }
        while (7 >= (int)num2);
        _003C_003Ec__DisplayClass142_.local_60 = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(_003C_003Ec__DisplayClass142_.local_60.x, _003C_003Ec__DisplayClass142_.local_60.y, _003C_003Ec__DisplayClass142_.local_60.z, 0));
        int num3 = physics1.W * lightness;
        _003C_003Ec__DisplayClass142_.local_50.x -= (int)((ulong)((long)physics1.X * (long)num3) >> 32);
        _003C_003Ec__DisplayClass142_.local_50.y -= (int)((ulong)((long)physics1.Y * (long)num3) >> 32);
        int num4 = (int)((ulong)((long)physics1.Z * (long)num3) >> 32);
        _003C_003Ec__DisplayClass142_.local_50.z -= num4;
        //Set Cambio de Wheels
        FUN_2AFF8(_003C_003Ec__DisplayClass142_.local_50, _003C_003Ec__DisplayClass142_.local_60);
        _003C_003Ec__DisplayClass142_.iVar3 = physics2.X;
        num3 = _003C_003Ec__DisplayClass142_.iVar3;
        if (_003C_003Ec__DisplayClass142_.iVar3 < 0)
        {
            num3 = _003C_003Ec__DisplayClass142_.iVar3 + 31;
        }
        _003C_003Ec__DisplayClass142_.iVar4 = physics2.Y;
        physics2.X = _003C_003Ec__DisplayClass142_.iVar3 - (num3 >> 5);
        num3 = _003C_003Ec__DisplayClass142_.iVar4;
        if (_003C_003Ec__DisplayClass142_.iVar4 < 0)
        {
            num3 = _003C_003Ec__DisplayClass142_.iVar4 + 31;
        }
        _003C_003Ec__DisplayClass142_.iVar3 = physics2.Z;
        physics2.Y = _003C_003Ec__DisplayClass142_.iVar4 - (num3 >> 5);
        num3 = _003C_003Ec__DisplayClass142_.iVar3;
        if (_003C_003Ec__DisplayClass142_.iVar3 < 0)
        {
            num3 = _003C_003Ec__DisplayClass142_.iVar3 + 31;
        }
        physics2.Z = _003C_003Ec__DisplayClass142_.iVar3 - (num3 >> 5);
        if ((flags & 0x40000000) != 0)
        {
            FUN_3A020(-(physics1.Y / 19456), GameManager.DAT_9C4, 0 < id);
        }
    }

    public bool FUN_3A064(int param1, Vector3Int param2, bool param3)
    {
        Vector3Int param4 = Utilities.FUN_24304(vTransform, param2);
        return FUN_3A020(param1, param4, param3);
    }

    public bool FUN_3A020(int param1, Vector3Int param2, bool param3)
    {
        if (shield == 0)
        {
            return FUN_39DCC(param1, param2, param3);
        }
        FUN_393F8();
        shield -= (ushort)(-param1 / 3);
        return false;
    }

    private void FUN_33AF8()
    {
        if ((short)LevelManager.instance.FUN_35778(vTransform.position.x, vTransform.position.z) != 0)
        {
            ai.FUN_51C54(vTransform.position, target.vTransform.position, 141120u, 0u);
            tags = 3;
            flags &= 4294967263u;
        }
        VigObject vigObject = mgun;
        direction = 1;
        turning = 0;
        acceleration = 60;
        int arg = 12;
        if (vigObject.tags == 0)
        {
            int num = (int)(vigObject.GetType().IsSubclassOf(typeof(VigObject)) ? vigObject.UpdateW(13, this) : 0);
            arg = 12;
            if (num == 0)
            {
                arg = 4;
            }
        }
        if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
        {
            vigObject.UpdateW(arg, this);
        }
    }

    private int FUN_33C10()
    {
        if (GameManager.instance.gameMode != 0 && GameManager.instance.gameMode != _GAME_MODE.Quest2)
        {
            return 0;
        }
        int num = GameManager.instance.DAT_1002 & 0x80;
        return 0;
    }

    private void FUN_33DE8()
    {
        if (((GameManager.instance.DAT_28 - DAT_19) & 0x7F) == 0 && (ai.DAT_00 < 1 || (flags & 0x20000000) != 0))
        {
            ai.FUN_51C54(vTransform.position, target.vTransform.position, 141120u, 0u);
        }
        direction = 1;
        int num;
        int num2 = num = (short)ai.FUN_51CFC(this, physics1.W * 32 + 65536);
        int num3 = -682;
        if (-683 < num)
        {
            num3 = 682;
            if (num < 683)
            {
                num3 = num;
            }
        }
        turning = (short)num3;
        num = physics1.W * DAT_B2;
        if (num < 0)
        {
            num += 4095;
        }
        int num4 = DAT_B1 + (num >> 12);
        num = 0;
        if (0 < num4)
        {
            num = num4;
        }
        num3 *= num;
        if (num3 < 0)
        {
            num3 += 15;
        }
        physics2.Y += num3 >> 4;
        num3 = num2;
        if (num3 < 0)
        {
            num3 = -num3;
        }
        bool flag;
        uint dAT_B;
        if (num3 < 342 || physics1.W < 3052)
        {
            if (physics1.W < 6867)
            {
                num3 = 0;
                if (0 < acceleration)
                {
                    num3 = acceleration;
                }
                dAT_B = DAT_B3;
                num3++;
                flag = (num3 < (int)dAT_B);
                short num5 = (short)dAT_B;
                if (flag)
                {
                    num5 = (short)num3;
                }
                acceleration = num5;
            }
            else
            {
                num = acceleration - 1;
                num3 = -DAT_B3;
                if (-DAT_B3 < num)
                {
                    num3 = num;
                }
                acceleration = (short)num3;
            }
        }
        else
        {
            num3 = 0;
            if (acceleration < 0)
            {
                num3 = acceleration;
            }
            num3--;
            dAT_B = (uint)(-DAT_B3);
            flag = ((int)dAT_B < num3);
            short num5 = (short)dAT_B;
            if (flag)
            {
                num5 = (short)num3;
            }
            acceleration = num5;
        }
        if (ai.rubberTimer != 0)
        {
            if (DAT_B3 < 40)
            {
                acceleration = (short)(DAT_B3 * 2);
            }
            ai.rubberTimer--;
        }
        num3 = 0;
        VigObject vigObject = weapons[weaponSlot];
        flag = false;
        bool flag2 = false;
        bool flag3 = false;
        if (vigObject != null)
        {
            flag = (vigObject.id == 0);
        }
        if (vigObject != null && vigObject.tags == 7 && vehicle != _VEHICLE.BlueBurro && vehicle != 0)
        {
            flag2 = (vigObject.id != 0);
        }
        if (flag && FUN_33C10() == 0 && vigObject.GetType().IsSubclassOf(typeof(VigObject)) && vigObject.UpdateW(13, this) != 0)
        {
            num3 = 1;
        }
        FUN_3A5FC(num3);
        if (DAT_B6[weaponSlot] == 0 && (DAT_F6 & 0x400) != 0 && vigObject != null)
        {
            num = (int)(vigObject.GetType().IsSubclassOf(typeof(VigObject)) ? vigObject.UpdateW(14, this) : 0);
            if (num != 0)
            {
                DAT_B6[weaponSlot] = (short)vigObject.UpdateW(10, num);
                if (DAT_B6[weaponSlot] != 0 && GameManager.instance.gameMode > _GAME_MODE.Versus2)
                {
                    ClientSend.ComboAI(id, (ushort)num, vigObject.tags);
                }
            }
        }
        vigObject = mgun;
        if (vigObject.tags != 0)
        {
            goto IL_03c0;
        }
        int arg;
        if (num3 != 0)
        {
            arg = 4;
        }
        else
        {
            num = (int)(vigObject.GetType().IsSubclassOf(typeof(VigObject)) ? vigObject.UpdateW(13, this) : 0);
            arg = 4;
            if (num != 0)
            {
                goto IL_03c0;
            }
        }
        goto IL_03c4;
    IL_03c4:
        if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
        {
            vigObject.UpdateW(arg, this);
        }
        if ((DAT_F6 & 0x400) != 0)
        {
            num = Utilities.FUN_29F6C(screen, target.screen);
            flag3 = (num < 524288);
        }
        if (!(flag | flag2 | flag3))
        {
            return;
        }
        if (num3 == 0)
        {
            FUN_3A734(1);
            return;
        }
        dAT_B = GameManager.FUN_2AC5C();
        if ((dAT_B & 7) == 0)
        {
            FUN_3A734(1);
        }
        return;
    IL_03c0:
        arg = 12;
        goto IL_03c4;
    }

    private void FUN_33BE4()
    {
        if (60 < GameManager.instance.DAT_28)
        {
            tags = 1;
        }
        turning = 0;
        acceleration = 60;
    }

    private void FUN_341F8()
    {
        uint param;
        VigObject vigObject;
        if (((GameManager.instance.DAT_28 - DAT_19) & 0x7F) == 0 && (ai.DAT_00 < 1 || (flags & 0x20000000) != 0))
        {
            vigObject = null;
            if (DAT_F4 != 0)
            {
                vigObject = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, DAT_F4);
            }
            if (DAT_F4 == 0 || vigObject == null)
            {
                if (body[0] == null)
                {
                    if (maxFullHealth <= maxHalfHealth * 3)
                    {
                        param = 4261412864u;
                        if (weapons[1] == null)
                        {
                            vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                        }
                        if (vigObject == null)
                        {
                            vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                            if (!(vigObject != null))
                            {
                                if (wheelsType == _WHEELS.Ground)
                                {
                                    uint num = GameManager.FUN_2AC5C();
                                    if ((num & 1) == 0)
                                    {
                                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 8650752u, vTransform.position);
                                        if (!(vigObject != null))
                                        {
                                            vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4269277184u, vTransform.position);
                                            if (!(vigObject != null))
                                            {
                                                goto IL_0187;
                                            }
                                        }
                                        goto IL_02f1;
                                    }
                                }
                                goto IL_0187;
                            }
                        }
                    }
                    else
                    {
                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4194304u, vTransform.position);
                        param = 1048576u;
                        if (vigObject == null)
                        {
                            vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                            if (!(vigObject != null))
                            {
                                if (wheelsType == _WHEELS.Ground)
                                {
                                    uint num = GameManager.FUN_2AC5C();
                                    if ((num & 1) == 0)
                                    {
                                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 8650752u, vTransform.position);
                                        if (!(vigObject != null))
                                        {
                                            vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4269277184u, vTransform.position);
                                            if (!(vigObject != null))
                                            {
                                                goto IL_02ac;
                                            }
                                        }
                                        goto IL_02f1;
                                    }
                                }
                                goto IL_02ac;
                            }
                        }
                    }
                    goto IL_02f1;
                }
                if ((body[0].maxHalfHealth + body[1].maxHalfHealth) * 3 < maxFullHealth)
                {
                    vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4194304u, vTransform.position);
                    param = 1048576u;
                    if (vigObject == null)
                    {
                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                        if (!(vigObject != null))
                        {
                            if (wheelsType == _WHEELS.Ground)
                            {
                                uint num = GameManager.FUN_2AC5C();
                                if ((num & 1) == 0)
                                {
                                    vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 8650752u, vTransform.position);
                                    if (!(vigObject != null))
                                    {
                                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4269277184u, vTransform.position);
                                        if (!(vigObject != null))
                                        {
                                            goto IL_0419;
                                        }
                                    }
                                    goto IL_058f;
                                }
                            }
                            goto IL_0419;
                        }
                    }
                }
                else
                {
                    param = 4261412864u;
                    if (weapons[1] == null)
                    {
                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                    }
                    if (vigObject == null)
                    {
                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, param, vTransform.position);
                        if (!(vigObject != null))
                        {
                            if (wheelsType == _WHEELS.Ground)
                            {
                                uint num = GameManager.FUN_2AC5C();
                                if ((num & 1) == 0)
                                {
                                    vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 8650752u, vTransform.position);
                                    if (!(vigObject != null))
                                    {
                                        vigObject = GameManager.instance.FUN_34120(GameManager.instance.worldObjs, 4269277184u, vTransform.position);
                                        if (!(vigObject != null))
                                        {
                                            goto IL_054a;
                                        }
                                    }
                                    goto IL_058f;
                                }
                            }
                            goto IL_054a;
                        }
                    }
                }
                goto IL_058f;
            }
            goto IL_05eb;
        }
        goto IL_0636;
    IL_05a6:
        if (vigObject == null || vigObject.GetType() != typeof(Pickup) || ((Pickup)vigObject).cannotReach)
        {
            vigObject = GameManager.instance.playerObjects[0];
            DAT_F4 = 0;
        }
        goto IL_05eb;
    IL_02f1:
        if (vigObject != null)
        {
            DAT_F4 = vigObject.id;
        }
        goto IL_05a6;
    IL_02ac:
        int num2 = (int)GameManager.FUN_2AC5C();
        int num3 = GameManager.instance.FUN_30428(GameManager.instance.DAT_1078, 7864320u);
        vigObject = GameManager.instance.FUN_30498(GameManager.instance.DAT_1078, 7864320u, num2 * num3 >> 15);
        goto IL_02f1;
    IL_09cf:
        VigObject vigObject2;
        vigObject2.UpdateW((int)param, this);
        return;
    IL_0419:
        num2 = (int)GameManager.FUN_2AC5C();
        num3 = GameManager.instance.FUN_30428(GameManager.instance.DAT_1078, 7864320u);
        vigObject = GameManager.instance.FUN_30498(GameManager.instance.DAT_1078, 7864320u, num2 * num3 >> 15);
        goto IL_058f;
    IL_0187:
        num2 = (int)GameManager.FUN_2AC5C();
        num3 = GameManager.instance.FUN_30428(GameManager.instance.DAT_1078, 7864320u);
        vigObject = GameManager.instance.FUN_30498(GameManager.instance.DAT_1078, 7864320u, num2 * num3 >> 15);
        goto IL_02f1;
    IL_054a:
        num2 = (int)GameManager.FUN_2AC5C();
        num3 = GameManager.instance.FUN_30428(GameManager.instance.DAT_1078, 7864320u);
        vigObject = GameManager.instance.FUN_30498(GameManager.instance.DAT_1078, 7864320u, num2 * num3 >> 15);
        goto IL_058f;
    IL_05eb:
        bool flag = !ai.FUN_51C54(vTransform.position, vigObject.screen, 141120u, 0u);
        if (vigObject.type == 3)
        {
            ((Pickup)vigObject).cannotReach = flag;
            if (flag)
            {
                DAT_F4 = 0;
            }
        }
        goto IL_0636;
    IL_058f:
        if (vigObject != null)
        {
            DAT_F4 = vigObject.id;
        }
        goto IL_05a6;
    IL_0636:
        direction = 1;
        int num4 = (short)ai.FUN_51CFC(this, physics1.W * 32 + 65536);
        int num5 = -682;
        if (-682 < num4)
        {
            num5 = num4;
        }
        int num6 = 682;
        if (num5 < 682)
        {
            num6 = num5;
        }
        turning = (short)num6;
        num5 = physics1.W * DAT_B2;
        if (num5 < 0)
        {
            num5 += 4095;
        }
        int num7 = DAT_B1 + (num5 >> 12);
        num5 = 0;
        if (0 < num7)
        {
            num5 = num7;
        }
        num5 = (short)num6 * num5;
        if (num5 < 0)
        {
            num5 += 15;
        }
        physics2.Y += num5 >> 4;
        if (num4 < 0)
        {
            num4 = -num4;
        }
        if (num4 < 342 || physics1.W < 3052)
        {
            if (physics1.W < 6867)
            {
                num4 = 0;
                if (0 < acceleration)
                {
                    num4 = acceleration;
                }
                uint num = DAT_B3;
                num4++;
                bool num8 = num4 < (int)num;
                short num9 = (short)num;
                if (num8)
                {
                    num9 = (short)num4;
                }
                acceleration = num9;
            }
            else
            {
                num5 = acceleration - 1;
                num4 = -DAT_B3;
                if (-DAT_B3 < num5)
                {
                    num4 = num5;
                }
                acceleration = (short)num4;
            }
        }
        else
        {
            num4 = 0;
            if (acceleration < 0)
            {
                num4 = acceleration;
            }
            num4--;
            uint num = (uint)(-DAT_B3);
            bool num10 = (int)num < num4;
            short num9 = (short)num;
            if (num10)
            {
                num9 = (short)num4;
            }
            acceleration = num9;
        }
        if (ai.rubberTimer != 0)
        {
            if (DAT_B3 < 40)
            {
                acceleration = (short)(DAT_B3 * 2);
            }
            ai.rubberTimer--;
        }
        VigObject vigObject3 = weapons[weaponSlot];
        vigObject2 = mgun;
        if (vigObject3 != null && vigObject3.id == 0 && FUN_33C10() == 0)
        {
            vigObject = target;
            if (vigObject != null)
            {
                num5 = vTransform.position.x - vigObject.vTransform.position.x;
                if (num5 < 0)
                {
                    num5 = -num5;
                }
                if (num5 < 1228800)
                {
                    num5 = vTransform.position.y - vigObject.vTransform.position.y;
                    if (num5 < 0)
                    {
                        num5 = -num5;
                    }
                    if (num5 < 1228800)
                    {
                        num4 = vTransform.position.z - vigObject.vTransform.position.z;
                        if (num4 < 0)
                        {
                            num4 = -num4;
                        }
                        if (num4 < 1228800)
                        {
                            num4 = (int)(vigObject3.GetType().IsSubclassOf(typeof(VigObject)) ? vigObject3.UpdateW(13, this) : 0);
                            FUN_3A5FC(num4);
                            if (num4 == 0)
                            {
                                FUN_3A734(1);
                            }
                            else
                            {
                                uint num = GameManager.FUN_2AC5C();
                                if ((num & 7) == 0)
                                {
                                    FUN_3A734(1);
                                }
                            }
                            if (vigObject2.tags == 0)
                            {
                                if (num4 == 0)
                                {
                                    num4 = (int)(vigObject2.GetType().IsSubclassOf(typeof(VigObject)) ? vigObject2.UpdateW(13, this) : 0);
                                    param = 4u;
                                    if (num4 != 0)
                                    {
                                        param = 12u;
                                    }
                                }
                                else
                                {
                                    param = 4u;
                                }
                            }
                            else
                            {
                                param = 12u;
                            }
                            if (!vigObject2.GetType().IsSubclassOf(typeof(VigObject)))
                            {
                                return;
                            }
                            goto IL_09cf;
                        }
                    }
                }
            }
        }
        if (!vigObject2.GetType().IsSubclassOf(typeof(VigObject)))
        {
            return;
        }
        param = 4u;
        goto IL_09cf;
    }

    public void FUN_34728()
    {
        switch (tags)
        {
            case 1:
                FUN_33AF8();
                break;
            case 2:
                FUN_33DE8();
                break;
            case 3:
                FUN_341F8();
                break;
            case 4:
                FUN_33BE4();
                break;
        }
    }

    private void FUN_3928C(int param1)
    {
        if (!GameManager.instance.DAT_36)
        {
            return;
        }
        int num = 0;
        do
        {
            Wheel wheel = wheels[num];
            if (wheel != null && ((GameManager.instance.DAT_28 + num) & 3) == 0 && (param1 == 0 || (wheel.flags & 0x1000000) != 0))
            {
                Vector3Int param2 = Utilities.FUN_24148(v: new Vector3Int(wheel.screen.x, wheel.screen.y + wheel.physics2.X, wheel.screen.z), transform: vTransform);
                Particle1 particle = LevelManager.instance.FUN_4DE54(param2, 7);
                particle.flags |= 1024u;
                short z = (short)GameManager.FUN_2AC5C();
                particle.vr.z = z;
                particle.ApplyTransformation();
            }
            num++;
        }
        while (num < 6);
    }

    public void FUN_393F8()
    {
        if ((DAT_F6 & 1) == 0)
        {
            BufferedBinaryReader reader = vCollider.reader;
            Shield shield = LevelManager.instance.xobfList[19].ini.FUN_2C17C(205, typeof(Shield), 8u) as Shield;
            shield.vTransform.position.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
            shield.vTransform.position.y = reader.ReadInt32(20);
            int num = reader.ReadInt32(12);
            int num2 = reader.ReadInt32(24);
            shield.vTransform.rotation = new Matrix3x3
            {
                V00 = 0,
                V01 = 0,
                V02 = 0,
                V10 = 0,
                V11 = 0,
                V12 = 0,
                V20 = 0,
                V21 = 0,
                V22 = 0
            };
            shield.vTransform.position.z = (num + num2) / 2;
            num = reader.ReadInt32(16) - reader.ReadInt32(4);
            if (num < 0)
            {
                num += 7;
            }
            shield.vTransform.rotation.V00 = (short)(num >> 3);
            num = reader.ReadInt32(20) - reader.ReadInt32(8);
            if (num < 0)
            {
                num += 3;
            }
            shield.vTransform.rotation.V11 = (short)(num >> 2);
            num = reader.ReadInt32(24) - reader.ReadInt32(12);
            if (num < 0)
            {
                num += 7;
            }
            shield.vTransform.rotation.V22 = (short)(num >> 3);
            Utilities.FUN_2CC9C(this, shield);
            shield.transform.parent = base.transform;
            DAT_F6 |= 1;
            if ((flags & 4) == 0)
            {
                shield.FUN_30BF0();
            }
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 50, vTransform.position);
            return;
        }
        VigObject vigObject = child2;
        if (!(vigObject != null))
        {
            return;
        }
        while (vigObject.DAT_1A != 205 || !(vigObject.vData == LevelManager.instance.xobfList[19]))
        {
            vigObject = vigObject.child;
            if (!(vigObject != null))
            {
                break;
            }
        }
        if (vigObject != null)
        {
            vigObject.FUN_2C05C();
        }
    }

    private void FUN_39CEC(uint param1)
    {
        if ((param1 & 0xFFFF) == 0)
        {
            GameManager.instance.FUN_1DE78(DAT_18);
            DAT_18 = 0;
            return;
        }
        acceleration = 0;
        if (--ignition == -1)
        {
            FUN_39C94();
        }
        else if (((int)param1 & -65536) != 0)
        {
            int num = (int)GameManager.FUN_2AC5C();
            short num2 = 6;
            if (num * 5 >> 15 != 0)
            {
                num2 = 90;
            }
            ignition = num2;
            num = DAT_18;
            if (num == 0)
            {
                num = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
            }
            GameManager.instance.FUN_1E098(num, GameManager.instance.DAT_C2C, 34, 0u, param5: true);
        }
    }

    private void FUN_3A844()
    {
        uint num = 0u;
        sbyte dAT_;
        uint volume;
        if ((DAT_F6 & 0x10) == 0)
        {
            int num2;
            int num3;
            if (wheelsType == _WHEELS.Ground)
            {
                if ((flags & 0x10000000) == 0)
                {
                    num2 = 3072;
                    if (0 < acceleration)
                    {
                        num2 = 8192;
                    }
                }
                else
                {
                    num3 = breaking << 6;
                    if (breaking < 1)
                    {
                        num3 = physics1.W * GameManager.DAT_63F68[direction + 1];
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        num3 >>= 12;
                        if (num3 < 3072 && 1 < direction)
                        {
                            direction--;
                        }
                        if (8192 < num3)
                        {
                            byte b = (byte)direction;
                            if (b < 3 && -1 < b << 24)
                            {
                                direction = (sbyte)(b + 1);
                            }
                        }
                    }
                    num2 = 3072;
                    if (3072 < num3)
                    {
                        num2 = num3;
                    }
                }
            }
            else
            {
                num2 = physics1.W / 2;
            }
            num2 -= DAT_E0;
            num3 = -512;
            if (-513 < num2)
            {
                num3 = 512;
                if (num2 < 513)
                {
                    num3 = num2;
                }
            }
            num3 = DAT_E0 + num3;
            DAT_E0 = (short)num3;
            GameManager.instance.FUN_1E30C(DAT_18, num3 * 65536 >> 16);
            Controller controller = InputManager.controllers[~id];
            if ((((controller.DAT_B << 24) | (controller.DAT_A << 16) | (controller.steering << 8) | controller.actions) & 0x100) == 0)
            {
                num3 = DAT_E2 - 128;
                num2 = 2048;
                if (2048 < num3)
                {
                    num2 = num3;
                }
                DAT_E2 = (short)num2;
            }
            else
            {
                num3 = DAT_E2 + 128;
                num2 = 4096;
                if (num3 < 4096)
                {
                    num2 = num3;
                }
                DAT_E2 = (short)num2;
            }
            num = GameManager.instance.FUN_1E478(vTransform.position);
            num2 = (int)(num & 0xFFFF) * (int)DAT_E2;
            dAT_ = DAT_18;
            if (num2 < 0)
            {
                num2 += 4095;
            }
            num3 = (int)(num >> 16) * (int)DAT_E2;
            if (num3 < 0)
            {
                num3 += 4095;
            }
            volume = (uint)((num2 >> 12) | (num3 >> 12 << 16));
        }
        else
        {
            volume = GameManager.instance.FUN_1E478(vTransform.position);
            dAT_ = DAT_18;
        }
        GameManager.instance.FUN_1E2C8(dAT_, volume);
        if ((flags & 0x40000000) != 0)
        {
            int param = GameManager.instance.FUN_1DD9C();
            int param2 = 31;
            if (0 < vTransform.rotation.V11)
            {
                param2 = 30;
            }
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, param2, vTransform.position);
            GameManager.instance.FUN_15B00(~id, 192, 0, 64);
        }
        if (wheelsType == _WHEELS.Ground && (flags & 0x10000000) != 0 && 3051 < physics1.W)
        {
            int num3 = physics2.W;
            int num2 = physics1.W * 3;
            if (num3 < 0)
            {
                num3 = -num3;
            }
            if (num2 < 0)
            {
                num2 += 3;
            }
            if (num3 < num2 >> 2)
            {
                if ((DAT_F6 & 4) == 0)
                {
                    DAT_F6 |= 4;
                    int param = GameManager.instance.FUN_1DD9C();
                    volume = GameManager.FUN_2AC5C();
                    int param2 = 27;
                    if ((volume & 1) != 0)
                    {
                        param2 = 26;
                    }
                    GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, param2, vTransform.position);
                }
                FUN_3928C(0);
                goto IL_03d7;
            }
        }
        DAT_F6 &= 65531;
        goto IL_03d7;
    IL_03d7:
        if (DAT_DF == 0)
        {
            return;
        }
        volume = (uint)(physics1.W / 2);
        byte dAT_DF;
        if (volume < 768)
        {
            dAT_DF = DAT_DF;
            num = 0u;
        }
        else
        {
            uint num4 = 3072u;
            if (volume < 3072)
            {
                num4 = volume;
            }
            GameManager.instance.FUN_1E2E8(DAT_DF, (int)(num4 & 0xFFFF));
            dAT_DF = DAT_DF;
        }
        GameManager.instance.FUN_1E2C8(dAT_DF, num);
    }

    public void FUN_3AC84(Controller playerController)
    {
        uint num = (uint)((playerController.DAT_B << 24) | (playerController.DAT_A << 16) | (playerController.steering << 8) | playerController.actions);
        int num2 = (playerController.DAT_19 << 8) | playerController.DAT_18;
        if ((flags & 0x2000000) == 0 && (DAT_F6 & 0x40) != (num & 0x40))
        {
            VigCamera vigCamera = GameManager.instance.cameraObjects[~id];
            DAT_F6 ^= 64;
            if ((num & 0x40) == 0)
            {
                vigCamera.DAT_92 = 0;
            }
            else
            {
                vigCamera.DAT_92 = 2048;
            }
            closeViewer.vr.y = vigCamera.DAT_92;
            vigCamera.DAT_A0_1 = -vigCamera.DAT_A0_1;
            closeViewer.ApplyRotationMatrix();
        }
        int param2;
        uint param;
        if ((num & 0x180000) != 0)
        {
            param = uint.MaxValue;
            if ((num & 0x80000) != 0)
            {
                param = 1u;
            }
            bool flag = FUN_3A734((int)param);
            DAT_F6 &= 65503;
            param2 = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E14C(param2, GameManager.instance.DAT_C2C, (!flag) ? 1 : 0);
            if (flag)
            {
                VigObject vigObject = weapons[weaponSlot];
                if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
                {
                    vigObject.UpdateW(11, this);
                }
            }
            if ((num & 0x18) == 24)
            {
                FUN_3E32C(_WHEELS.Ground, 0);
                if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
                {
                    //Envia cambio de Wheel
                    ClientSend.Pickup(16, 0, 0);
                }
            }
        }
        if ((DAT_F6 & 0x1020) == 0 && GameManager.instance.autoTarget && ((GameManager.instance.DAT_28 - DAT_19) & 0x3F) == 0)
        {
            FUN_3CCD4(param1: false);
        }
        if ((num & 0x20) != 0)
        {
            timer++;
            if (timer > 40 && target != null)
            {
                target = null;
                DAT_F6 |= 4096;
                param2 = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E14C(param2, GameManager.instance.DAT_C2C, 0);
            }
        }
        if (timer2 > 0)
        {
            timer2--;
            if (timer2 == 0)
            {
                targetList.Clear();
            }
        }
        if ((num2 & 0x20) != 0)
        {
            VigObject vigObject2 = target;
            if (timer > 40)
            {
                timer = 0;
            }
            else
            {
                timer = 0;
                vigObject2 = (target = FUN_3CF7C(this));
                targetList.Add(vigObject2);
                timer2 = 60;
                DAT_C6 = 0;
                DAT_F6 &= 61439;
                DAT_F6 |= 32;
                param2 = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E14C(param2, GameManager.instance.DAT_C2C, 0);
            }
        }
        if ((num & 0x40000) != 0)
        {
            VigObject vigObject3 = weapons[weaponSlot];
            if (!(vigObject3 != null))
            {
                goto IL_033b;
            }
            if (vigObject3.id != 0)
            {
                if ((GameManager.instance.DAT_40 & 0x800) == 0)
                {
                    goto IL_033b;
                }
                vigObject3.id = 0;
            }
        }
        goto IL_035f;
    IL_033b:
        param2 = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E14C(param2, GameManager.instance.DAT_C2C, 1);
        goto IL_035f;
    IL_035f:
        FUN_3A5FC((int)(num & 4));
        int num3 = playerController.sequence[0] | (playerController.sequence[1] << 8) | (playerController.sequence[2] << 16) | (playerController.sequence[3] << 24);
        if ((num & 0x20000) != 0 && 256 < num3)
        {
            int num4 = 0;
            if ((num3 & 0xFFFF) == 4900)
            {
                FUN_3E32C(_WHEELS.Ground, 0);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!(weapons[i] != null) || weapons[i].tags != 7)
                    {
                        continue;
                    }
                    VigObject vigObject = weapons[i];
                    if (DAT_B6[num4] != 0 || vigObject.maxHalfHealth == 0)
                    {
                        continue;
                    }
                    int num5 = 0;
                    if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
                    {
                        vigObject.UpdateW(0, this);
                        num5 = (int)vigObject.UpdateW(10, num3);
                    }
                    if (num5 != 0)
                    {
                        if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
                        {
                            ClientSend.Combo((ushort)num3, 7);
                        }
                        vigObject.UpdateW(0, this);
                        param2 = GameManager.instance.FUN_1DD9C();
                        int param3 = 47;
                        if (num5 < 0)
                        {
                            param3 = 1;
                        }
                        GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, param3, vTransform.position);
                        if (0 < num5 && vigObject == weapons[num4])
                        {
                            DAT_B6[num4] = (short)num5;
                        }
                        playerController.sequence[0] &= 15;
                        playerController.sequence[1] = 0;
                        playerController.sequence[2] = 0;
                        playerController.sequence[3] = 0;
                        playerController.delay = 30;
                        return;
                    }
                }
                int num6 = 40;
                do
                {
                    VigObject vigObject = weapons[num4];
                    if (DAT_B6[num4] == 0 && vigObject != null && vigObject.maxHalfHealth != 0)
                    {
                        int num5 = 0;
                        if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
                        {
                            vigObject.UpdateW(0, this);
                            num5 = (int)vigObject.UpdateW(10, num3);
                        }
                        if (num5 != 0)
                        {
                            if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
                            {
                                ClientSend.Combo((ushort)num3, vigObject.tags);
                            }
                            param2 = GameManager.instance.FUN_1DD9C();
                            int param3 = 47;
                            if (num5 < 0)
                            {
                                param3 = 1;
                            }
                            GameManager.instance.FUN_1E580(param2, GameManager.instance.DAT_C2C, param3, vTransform.position);
                            if (0 < num5 && vigObject == weapons[num4])
                            {
                                DAT_B6[num4] = (short)num5;
                            }
                            playerController.sequence[0] &= 15;
                            playerController.sequence[1] = 0;
                            playerController.sequence[2] = 0;
                            playerController.sequence[3] = 0;
                            playerController.delay = 30;
                            break;
                        }
                    }
                    num4++;
                    num6 += 4;
                }
                while (num4 < 3);
            }
        }
        param = 4u;
        if ((num & 2) != 0)
        {
            param = 12u;
        }
        VigObject vigObject4 = mgun;
        if (vigObject4.GetType().IsSubclassOf(typeof(VigObject)))
        {
            vigObject4.UpdateW((int)param, this);
        }
        if (DAT_C6 < 256)
        {
            DAT_C6 += 8;
        }
    }

    public void FUN_3A5FC(int param1)
    {
        VigObject vigObject = weapons[weaponSlot];
        if (!(vigObject != null))
        {
            return;
        }
        if (param1 == 0 || vigObject.maxHalfHealth == 0 || vigObject.id != 0)
        {
            if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                vigObject.UpdateW(0, this);
            }
            return;
        }
        short num = (short)(vigObject.GetType().IsSubclassOf(typeof(VigObject)) ? ((short)vigObject.UpdateW(12, this)) : 0);
        if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id == -1)
        {
            ClientSend.Weapon(vigObject.tags);
        }
        else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id > 0)
        {
            ClientSend.WeaponAI(id, vigObject.tags);
        }
        if (vigObject.maxHalfHealth != 0)
        {
            if (0 < id && (vigObject.flags & 0x4000000) == 0)
            {
                int num2 = ((DAT_F6 & 2) != 0) ? ((2 - GameManager.instance.difficultyMode) * 32) : ((2 - GameManager.instance.difficultyMode) * 64);
                int num3 = (int)GameManager.FUN_2AC5C();
                num = (short)(num + num2 + (num3 * num2 >> 15));
            }
            vigObject.id = num;
            if (GameManager.instance.gameMode == _GAME_MODE.Versus2 && id > 0)
            {
                vigObject.id = 0;
            }

            //RapidFire? = Remove !DiscordController.IsOwner() 
            else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && !DiscordController.IsOwner() && (id > 0 || id == -2))
            {
                vigObject.id = 0;
            }
        }
    }

    //Fix Weapon Last Round
    public void FUN_3A280(uint param1)
    {
        byte bVar1;
        short sVar2;
        int iVar3;
        VigObject oVar3;
        uint uVar4;

        bVar1 = weaponSlot;
        uVar4 = bVar1;
        FUN_3A148((int)param1);
        iVar3 = (int)param1;

        for (int i = 0; i < 2 - param1; i++)
            weapons[iVar3 + i] = weapons[iVar3 + i + 1];

        weapons[2] = null;

        if ((int)uVar4 <= (int)param1)
        {
            if (param1 == 0) goto LAB_3A304;

            if (uVar4 != param1)
                return;

            if (weapons[iVar3] != null) goto LAB_3A304;
        }

        weaponSlot--;
    LAB_3A304:
        if (uVar4 == param1)
        {
            oVar3 = weapons[weaponSlot];

            if (oVar3 != null)
            {
                sVar2 = 30;

                if (30 < oVar3.id)
                    sVar2 = oVar3.id;

                oVar3.id = sVar2;
            }
        }
    }
    //public void FUN_3A280(uint param1)
    //{
    //    uint num = weaponSlot;
    //    FUN_3A148((int)param1);
    //    for (int i = 0; i < 2 - param1; i++)
    //    {
    //        weapons[(int)param1 + i] = weapons[(int)param1 + i + 1];
    //        DAT_B6[(int)param1 + i] = DAT_B6[(int)param1 + i + 1];
    //    }
    //    weapons[2] = null;
    //    if ((int)num > (int)param1)
    //    {
    //        goto IL_0071;
    //    }
    //    if (param1 != 0)
    //    {
    //        if (num != param1)
    //        {
    //            return;
    //        }
    //        if (!(weapons[param1] != null))
    //        {
    //            goto IL_0071;
    //        }
    //    }
    //    goto IL_0080;
    //IL_0080:
    //    if (num == param1)
    //    {
    //        bool flag = weapons[weaponSlot] != null;
    //    }
    //    return;
    //IL_0071:
    //    weaponSlot--;
    //    goto IL_0080;
    //}

    public bool FUN_3A734(int param1)
    {
        VigObject vigObject = weapons[weaponSlot];
        uint num = (uint)(weaponSlot + param1 + 3) % 3u;
        weaponSlot = (byte)num;
        int num2 = 0;
        if (weapons[num & 0xFF] == null)
        {
            int num3 = 1;
            do
            {
                num2 = num3;
                if (2 < num2)
                {
                    break;
                }
                num = (uint)(weaponSlot + param1 + 3) % 3u;
                weaponSlot = (byte)num;
                num3 = num2 + 1;
            }
            while (weapons[num & 0xFF] == null);
        }
        bool result = false;
        if (num2 < 2)
        {
            if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                vigObject.UpdateW(11, null);
            }
            result = true;
        }
        return result;
    }

    public VigObject FUN_3CF7C(VigObject param1, bool repeat = true)
    {
        VigObject vigObject = null;
        VigObject vigObject2 = null;
        uint num = uint.MaxValue;
        uint num2 = uint.MaxValue;
        uint num3 = (uint)((!(param1 == null)) ? Utilities.FUN_29F6C(vTransform.position, param1.screen) : 0);
        sbyte b = GameManager.instance.DAT_1128[~id];
        List<VigTuple> worldObjs = GameManager.instance.worldObjs;
        for (int i = 0; i < worldObjs.Count; i++)
        {
            VigObject vObject = worldObjs[i].vObject;
            uint num4 = num2;
            uint num5 = num;
            VigObject vigObject3 = vigObject2;
            VigObject vigObject4 = vigObject;
            if (vObject == this || vObject.type == 3 || vObject.type == 13 || (vObject.flags & 0x4000) == 0 || targetList.Contains(vObject))
            {
                num2 = num4;
                num = num5;
                vigObject2 = vigObject3;
                vigObject = vigObject4;
            }
            else
            {
                if (0 >= vObject.id && b == GameManager.instance.DAT_1128[~vObject.id])
                {
                    continue;
                }
                uint num6 = (uint)Utilities.FUN_29F6C(vTransform.position, vObject.screen);
                if (num3 < num6)
                {
                    num4 = num6;
                    vigObject3 = vObject;
                    if (num6 < num2)
                    {
                        num2 = num4;
                        num = num5;
                        vigObject2 = vigObject3;
                        vigObject = vigObject4;
                        continue;
                    }
                }
                num4 = num2;
                num5 = num6;
                vigObject3 = vigObject2;
                vigObject4 = vObject;
                if (num6 < num)
                {
                    num2 = num4;
                    num = num5;
                    vigObject2 = vigObject3;
                    vigObject = vigObject4;
                }
            }
        }
        if (vigObject2 == null)
        {
            vigObject2 = vigObject;
            targetList.Clear();
            if (repeat)
            {
                vigObject2 = FUN_3CF7C(this, repeat: false);
            }
        }
        return vigObject2;
    }

    public void FUN_3E32C(_WHEELS param1, ushort param2)
    {
        if (DAT_B4 != 0)
        {
            return;
        }
        int num = 0;
        if (wheelsType == param1)
        {
            if (param1 == _WHEELS.Ground)
            {
                transformation = 0;
                goto IL_013f;
            }
        }
        else
        {
            int num2 = 12;
            do
            {
                VigObject vigObject = wheels[num];
                if (vigObject != null)
                {
                    VigObject vigObject2 = new GameObject().AddComponent<VigObject>();
                    vigObject2.screen = vigObject.screen;
                    vigObject2.ApplyTransformation();
                    vigObject.vTransform.position = new Vector3Int(0, 0, 0);
                    vigObject.FUN_2CCBC();
                    Utilities.FUN_2CC9C(vigObject2, vigObject);
                    Utilities.FUN_2CC9C(this, vigObject2);
                    vigObject2.transform.parent = base.transform;
                    vigObject.transform.parent = vigObject2.transform;
                }
                num++;
                num2 += 4;
            }
            while (num < 6);
            wheelsType = param1;
            DAT_B4 = 32;
            physics1.Y -= 295200;
            int param3 = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 62, vTransform.position);
            FUN_38408();
            if (param1 == _WHEELS.Ground)
            {
                if (0 < id && transformation == 2)
                {
                    tags = 1;
                }
                if (param1 == _WHEELS.Ground)
                {
                    transformation = 0;
                    goto IL_013f;
                }
            }
        }
        transformation = param2;
        goto IL_013f;
    IL_013f:
        DAT_C2 = 0;
    }

    private void FUN_3D0F8(uint param1)
    {
        sbyte dAT_B2;
        uint num4;
        if (wheelsType == _WHEELS.Air)
        {
            if ((param1 & 0xFFFF) == 0)
            {
                int num = DAT_B0 - 1;
                sbyte dAT_B = 0;
                if (0 < num)
                {
                    dAT_B = (sbyte)num;
                }
                DAT_B0 = dAT_B;
                return;
            }
            if (((int)param1 & -65536) != 0)
            {
                sbyte dAT_B = -120;
                if (DAT_B0 == 0)
                {
                    dAT_B = 15;
                }
                DAT_B0 = dAT_B;
            }
            if (DAT_B0 < 0)
            {
                if (0 < direction)
                {
                    int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
                    int num2 = ((GameManager.instance.DAT_40 & 0x80000) != 0) ? (-1228800) : (-204800);
                    num2 = num - vTransform.position.y + num2;
                    if (num2 < 0)
                    {
                        num = -204800;
                        if (-204800 < num2)
                        {
                            num = num2;
                        }
                        if (num < 0)
                        {
                            num += 1023;
                        }
                        num >>= 10;
                        num2 = vTransform.rotation.V01 * num;
                        if (num2 < 0)
                        {
                            num2 += 31;
                        }
                        int num3 = vTransform.rotation.V11 * num;
                        physics1.X += num2 >> 5;
                        if (num3 < 0)
                        {
                            num3 += 31;
                        }
                        num = vTransform.rotation.V21 * num;
                        physics1.Y += (num3 >> 5) - GameManager.instance.gravityFactor;
                        if (num < 0)
                        {
                            num += 31;
                        }
                        physics1.Z += num >> 5;
                    }
                }
                dAT_B2 = (sbyte)(DAT_B0 + 1);
            }
            else
            {
                int num = DAT_B0 - 1;
                dAT_B2 = 0;
                if (0 < num)
                {
                    dAT_B2 = (sbyte)num;
                }
            }
        }
        else
        {
            if ((param1 & 0xFFFF) != 0)
            {
                if (((int)param1 & -65536) != 0 && (flags & 0x10000000) != 0)
                {
                    if (DAT_B0 < 1 || direction < 1)
                    {
                        if (2287 < physics1.W)
                        {
                            goto IL_0298;
                        }
                    }
                    else
                    {
                        if (vehicle == _VEHICLE.DakotaCycle)
                        {
                            FUN_2B1FC(GameManager.DAT_A18, new Vector3Int(0, 10240, 0));
                        }
                        else
                        {
                            FUN_2B1FC(GameManager.DAT_A18, GameManager.DAT_A24);
                        }
                        DAT_B0 = -39;
                    }
                    int param2 = GameManager.instance.FUN_1DD9C();
                    num4 = GameManager.FUN_2AC5C();
                    int param3 = 28;
                    if ((num4 & 1) != 0)
                    {
                        param3 = 29;
                    }
                    GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, param3, vTransform.position);
                    FUN_3928C(0);
                }
                goto IL_0298;
            }
            dAT_B2 = (sbyte)(DAT_B0 - 1);
            if (DAT_B0 < 1)
            {
                return;
            }
        }
        DAT_B0 = dAT_B2;
        return;
    IL_0298:
        dAT_B2 = (sbyte)(DAT_B0 + 1);
        if (-2 < DAT_B0)
        {
            dAT_B2 = 15;
        }
        DAT_B0 = dAT_B2;
        if (wheelsType != 0 || breaking == 0)
        {
            return;
        }
        num4 = GameManager.FUN_2AC5C();
        if ((num4 & 3) == 0)
        {
            FUN_3928C(1);
            if ((num4 & 0x1C) == 0)
            {
                int param2 = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 28, vTransform.position);
            }
        }
    }

    private void FUN_3D0F8_2(uint param1)
    {
        if (wheelsType == _WHEELS.Air)
        {
            return;
        }
        uint num;
        if ((param1 & 0xFFFF) != 0)
        {
            if (((int)param1 & -65536) != 0 && (flags & 0x10000000) != 0)
            {
                if (DAT_B0_2 < 1 || direction > -1)
                {
                    if (2287 < physics1.W)
                    {
                        goto IL_00e9;
                    }
                }
                else
                {
                    if (vehicle == _VEHICLE.DakotaCycle)
                    {
                        FUN_2B1FC(-GameManager.DAT_A18, new Vector3Int(0, 10240, 0));
                    }
                    else
                    {
                        FUN_2B1FC(-GameManager.DAT_A18, GameManager.DAT_A24);
                    }
                    DAT_B0_2 = -39;
                }
                int param2 = GameManager.instance.FUN_1DD9C();
                num = GameManager.FUN_2AC5C();
                int param3 = 28;
                if ((num & 1) != 0)
                {
                    param3 = 29;
                }
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, param3, vTransform.position);
                FUN_3928C(0);
            }
            goto IL_00e9;
        }
        sbyte dAT_B0_ = (sbyte)(DAT_B0_2 - 1);
        if (DAT_B0_2 >= 1)
        {
            DAT_B0_2 = dAT_B0_;
        }
        return;
    IL_00e9:
        dAT_B0_ = (sbyte)(DAT_B0_2 + 1);
        if (-2 < DAT_B0_2)
        {
            dAT_B0_ = 15;
        }
        DAT_B0_2 = dAT_B0_;
        if (wheelsType != 0 || breaking == 0)
        {
            return;
        }
        num = GameManager.FUN_2AC5C();
        if ((num & 3) == 0)
        {
            FUN_3928C(1);
            if ((num & 0x1C) == 0)
            {
                int param2 = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 28, vTransform.position);
            }
        }
    }

    public void FUN_3D424(Controller playerController)
    {
        _WHEELS wHEELS = wheelsType;
        uint num = (uint)((playerController.DAT_B << 24) | (playerController.DAT_A << 16) | (playerController.steering << 8) | playerController.actions);
        uint num2 = 0u;
        bool flag;
        uint num5;
        uint num3;
        uint num4;
        int z;
        int num6;
        if (playerController.type == _CONTROLLER_TYPE.SteeringWheel)
        {
            turning = (short)((playerController.stick[0] - 128) * 5);
            num3 = (uint)(((playerController.stick[1] < 129) ? 1 : 0) ^ 1);
            if (-1 < (sbyte)playerController.DAT_14[1])
            {
                num3 |= 0x10000;
            }
            if ((DAT_F6 & 0x10) == 0)
            {
                if (direction < 0 && 16 < playerController.stick[1])
                {
                    sbyte b = direction = 1;
                }
                else
                {
                    sbyte b = -1;
                    if ((playerController.actions & 0x100) != 0)
                    {
                        direction = b;
                    }
                }
                num4 = DAT_B3;
                if (direction < 0)
                {
                    if ((playerController.actions & 0x100) == 0)
                    {
                        num4 = 0u;
                    }
                }
                else
                {
                    num5 = playerController.stick[1];
                    if (playerController.stick[2] < 241)
                    {
                        num5 -= playerController.stick[2];
                    }
                    else
                    {
                        num6 = turning;
                        if (num6 < 0)
                        {
                            num6 = -num6;
                        }
                        if (num6 < 170)
                        {
                            num5 -= playerController.stick[2];
                        }
                    }
                    num5 *= num4;
                    num4 = num5 >> 8;
                    if ((int)num5 < 0)
                    {
                        num4 = num5 + 255 >> 8;
                    }
                }
                acceleration = (short)num4;
                FUN_3D0F8(num3);
            }
            else
            {
                FUN_39CEC(num3);
            }
            if (vTransform.rotation.V11 < 0)
            {
                num = playerController.stick[0];
                if ((int)(num ^ playerController.stick[0]) < 0)
                {
                    num = 0u;
                }
                z = physics2.Z;
                num6 = (int)(num << 2);
                if (wHEELS != _WHEELS.Sea)
                {
                    physics2.Z = z + (int)num;
                }
                else
                {
                    physics2.Z = z + num6;
                }
                return;
            }
            if ((num & 0x400) == 0 && playerController.stick[0] < 241)
            {
                if (0 < breaking)
                {
                    breaking = (sbyte)(-breaking);
                }
                if (wHEELS == _WHEELS.Ground)
                {
                    num6 = physics1.W * DAT_B2;
                    if (num6 < 0)
                    {
                        num6 += 4095;
                    }
                    z = DAT_B1 + (num6 >> 12);
                    num6 = 0;
                    if (0 < z)
                    {
                        num6 = z;
                    }
                    if (direction < 0)
                    {
                        num6 = -num6;
                    }
                    num6 = turning * num6;
                    if (num6 < 0)
                    {
                        num6 += 15;
                    }
                    num6 = physics2.Y + (num6 >> 4);
                    physics2.Y = num6;
                }
            }
            else
            {
                num6 = turning;
                if (num6 < 0)
                {
                    num6 = -num6;
                }
                if (num6 < 170)
                {
                    if (physics1.W < 2370)
                    {
                        sbyte b = sbyte.MaxValue;
                        if (num3 == 0)
                        {
                            b = 0;
                            num6 = breaking - 3;
                            flag = (0 < num6);
                        }
                        else
                        {
                            num6 = breaking + 2;
                            flag = (num6 < 127);
                        }
                        if (flag)
                        {
                            b = (sbyte)num6;
                        }
                        breaking = b;
                    }
                    acceleration = (short)(DAT_B3 * -2);
                }
                if (wHEELS != _WHEELS.Air)
                {
                    num6 = ((direction >= 0) ? (physics2.Y + turning * 2) : (physics2.Y + turning * -2));
                    physics2.Y = num6;
                }
            }
            num6 = breaking + 4;
            if (-1 >= breaking)
            {
                sbyte b = 0;
                if (num6 < 0)
                {
                    b = (sbyte)num6;
                }
                breaking = b;
            }
            return;
        }
        int num10;
        if (playerController.type < _CONTROLLER_TYPE.JoystickAnalog)
        {
            if (playerController.type != _CONTROLLER_TYPE.JoypadDigital)
            {
                return;
            }
            num3 = 256u;
            if (direction < 0)
            {
                num3 = 512u;
                num4 = 256u;
            }
            else
            {
                num4 = 512u;
            }
            if ((num & num4) == 0)
            {
                num2 = (num & (num3 | (num3 << 16)));
                if ((DAT_F6 & 0x10) == 0)
                {
                    num4 = num2;
                    if ((((playerController.DAT_F << 24) | (playerController.DAT_E << 16) | (playerController.dpad << 8) | playerController.buttons) & 4026531840u) != 0L)
                    {
                        num4 = (num2 & 0xFFFF);
                    }
                    FUN_3D0F8(num4);
                    if ((num2 & 0xFFFF) == 0)
                    {
                        num6 = acceleration - 4;
                        uint num7 = 0u;
                        if (0 < num6)
                        {
                            num7 = (uint)num6;
                        }
                        acceleration = (short)num7;
                    }
                    else
                    {
                        acceleration = DAT_B3;
                    }
                }
                else
                {
                    FUN_39CEC(num2);
                }
            }
            else
            {
                num6 = physics2.W;
                if (num6 < 0)
                {
                    num6 = -num6;
                }
                if (num6 < 474)
                {
                    sbyte b = 1;
                    if (-1 < direction)
                    {
                        b = -1;
                    }
                    direction = b;
                }
                else
                {
                    acceleration = (short)(-DAT_B3);
                }
            }
            if ((num & 0x1800) == 0)
            {
                short num8 = turning;
                num6 = num8;
                if (num6 != 0)
                {
                    z = num6 * physics1.W;
                    if (z < 0)
                    {
                        z += 32767;
                    }
                    short num9 = (short)(num8 - (z >> 15));
                    if (z >> 15 == 0)
                    {
                        num9 = (short)(num8 - 1);
                        if (num6 < 0)
                        {
                            num9 = (short)(num8 + 1);
                        }
                    }
                    turning = num9;
                }
                if ((num & 0x400) == 0)
                {
                    if (0 < breaking)
                    {
                        breaking = (sbyte)(-breaking);
                    }
                }
                else if (physics1.W < 2370)
                {
                    sbyte b = sbyte.MaxValue;
                    if (num2 == 0)
                    {
                        b = 0;
                        num6 = breaking - 3;
                        flag = (0 < num6);
                    }
                    else
                    {
                        num6 = breaking + 2;
                        flag = (num6 < 127);
                    }
                    if (flag)
                    {
                        b = (sbyte)num6;
                    }
                    breaking = b;
                }
                num6 = breaking + 4;
                if (-1 >= breaking)
                {
                    sbyte b = 0;
                    if (num6 < 0)
                    {
                        b = (sbyte)num6;
                    }
                    breaking = b;
                }
                return;
            }
            if (0 < vTransform.rotation.V11)
            {
                num4 = 0u;
                if (direction < 1)
                {
                    if ((num & 0x18000000) != 0)
                    {
                        num4 = (flags & int.MaxValue);
                        if (direction < 0 && ((num & num3) != 0 || physics2.W < -4997120))
                        {
                            num4 = (uint)((int)num4 | int.MinValue);
                        }
                        flags = num4;
                    }
                    num4 = flags >> 31;
                }
                else
                {
                    flags &= 2147483647u;
                }
                if ((num & 0x400) == 0 || wheelsType == _WHEELS.Air)
                {
                    if ((num & 0x800) == 0)
                    {
                        z = turning;
                        num6 = 0;
                        if (0 < z)
                        {
                            num6 = z;
                        }
                        if (num6 < 0)
                        {
                            num6 += 63;
                        }
                        num10 = z + 16 - (num6 >> 6);
                        z = 44695552;
                        num6 = 682;
                        if (num10 < 682)
                        {
                            z = num10 * 65536;
                            num6 = num10;
                        }
                        z >>= 16;
                        turning = (short)num6;
                        if (z < 1)
                        {
                            return;
                        }
                    }
                    else
                    {
                        z = turning;
                        num6 = 0;
                        if (z < 0)
                        {
                            num6 = z;
                        }
                        if (num6 < 0)
                        {
                            num6 += 63;
                        }
                        num10 = z - 16 - (num6 >> 6);
                        z = -44695552;
                        num6 = -682;
                        if (-682 < num10)
                        {
                            z = num10 * 65536;
                            num6 = num10;
                        }
                        z >>= 16;
                        turning = (short)num6;
                        if (-1 < z)
                        {
                            return;
                        }
                    }
                    if (wheelsType == _WHEELS.Ground)
                    {
                        num6 = physics1.W * DAT_B2;
                        if (num6 < 0)
                        {
                            num6 += 4095;
                        }
                        num10 = DAT_B1 + (num6 >> 12);
                        num6 = 0;
                        if (0 < num10)
                        {
                            num6 = num10;
                        }
                        num6 = (int)(num4 * 2 - 1) * z * num6;
                        if (num6 < 0)
                        {
                            num6 += 15;
                        }
                        physics2.Y -= num6 >> 4;
                    }
                    return;
                }
                if ((num & 0x800) == 0)
                {
                    num6 = 682;
                    if (turning + 32 < 682)
                    {
                        num6 = turning + 32;
                    }
                    turning = (short)num6;
                    num6 = physics2.Y;
                    if (num4 == 0)
                    {
                        physics2.Y = num6 + 1280;
                        return;
                    }
                }
                else
                {
                    num6 = -682;
                    if (-682 < turning - 32)
                    {
                        num6 = turning - 32;
                    }
                    turning = (short)num6;
                    num6 = physics2.Y;
                    if (num4 != 0)
                    {
                        physics2.Y = num6 + 1280;
                        return;
                    }
                }
                physics2.Y = num6 - 1280;
                return;
            }
            if ((num & 0x8000000) == 0)
            {
                if ((num & 0x10000000) == 0)
                {
                    return;
                }
                z = physics2.Z;
                num6 = 32768;
                if (wheelsType == _WHEELS.Sea)
                {
                    num6 = 65536;
                }
            }
            else
            {
                z = physics2.Z;
                num6 = -32768;
                if (wheelsType == _WHEELS.Sea)
                {
                    num6 = -65536;
                }
            }
            physics2.Z = z + num6;
            return;
        }
        if (_CONTROLLER_TYPE.JoypadAnalog < playerController.type)
        {
            return;
        }
        num3 = playerController.stick[0];
        num4 = num3 - 128;
        z = 128 - playerController.stick[1];
        num6 = z;
        if (z < 0)
        {
            num6 = -z;
        }
        num10 = 0;
        if (8 < num6)
        {
            num10 = z;
        }
        flag = false;
        if (((num & 0x400) != 0 && num10 < -64) || (num & 0x200) != 0)
        {
            flag = true;
        }
        bool flag2 = false;
        if ((num & 0x400) != 0 && (-1 < direction || -64 < num10))
        {
            flag2 = true;
        }
        bool flag3 = false;
        if ((num & 0x1800) == 0)
        {
            num5 = num4;
            if ((int)num4 < 0)
            {
                num5 = 0 - num4;
            }
            if (7 < (int)num5)
            {
                flag3 = true;
            }
        }
        else
        {
            flag3 = true;
        }
        if ((num & 0x1800) == 0)
        {
            num5 = num4;
            if ((int)num4 < 0)
            {
                num5 = 0 - num4;
            }
            short num8;
            if ((int)num5 < 8)
            {
                num6 = turning * physics1.W;
                if (num6 < 0)
                {
                    num6 += 32767;
                }
                num8 = (short)(turning - (num6 >> 15));
            }
            else
            {
                num6 = 16;
                if (flag2)
                {
                    num6 = 32;
                }
                num5 = (uint)turning;
                if ((InputManager.turnRadius[num3] ^ (int)num5) < 0)
                {
                    num8 = (short)num6;
                    if (-1 < (int)num5)
                    {
                        num8 = (short)(-num8);
                    }
                }
                else
                {
                    int num11 = InputManager.turnRadius[num3] - (int)num5;
                    z = -num6;
                    if (-num6 <= num11)
                    {
                        z = num6;
                        if (num11 <= num6)
                        {
                            z = num11;
                        }
                    }
                    num8 = (short)(turning + z);
                }
            }
            turning = num8;
        }
        else if (flag2)
        {
            if ((num & 0x800) != 0)
            {
                num6 = turning - 32;
                goto IL_0b18;
            }
            num6 = turning + 32;
            z = 682;
            if (num6 < 682)
            {
                z = num6;
            }
            turning = (short)z;
        }
        else
        {
            if ((num & 0x800) != 0)
            {
                z = turning;
                num6 = 0;
                if (z < 0)
                {
                    num6 = z;
                }
                if (num6 < 0)
                {
                    num6 += 63;
                }
                num6 = z - 16 - (num6 >> 6);
                goto IL_0b18;
            }
            z = turning;
            num6 = 0;
            if (0 < z)
            {
                num6 = z;
            }
            if (num6 < 0)
            {
                num6 += 63;
            }
            num6 = z + 16 - (num6 >> 6);
            z = 682;
            if (num6 < 682)
            {
                z = num6;
            }
            turning = (short)z;
        }
        goto IL_0b35;
    IL_0b35:
        num5 = 0u;
        if (64 < num10)
        {
            num5 = ((128 - playerController.DAT_14[1] < 65) ? 1u : 0u);
        }
        uint num12 = num & 0x1000100;
        uint num13 = num & 0x6000600;
        if (64 < num10)
        {
            num12 |= 1;
        }
        num12 = ((num5 << 16) | num12);
        num13 = ((num5 << 16) | num13);
        if ((DAT_F6 & 0x10) == 0)
        {
            short num8 = -1;
            if (-1 < direction)
            {
                num8 = 1;
            }
            ushort num14;
            if ((num & 0x100) == 0)
            {
                if (flag)
                {
                    num14 = (ushort)(-DAT_B3);
                }
                else
                {
                    num10 *= DAT_B3;
                    if (num10 < 0)
                    {
                        num10 += 127;
                    }
                    num14 = (ushort)(num10 >> 7);
                }
            }
            else
            {
                num14 = DAT_B3;
            }
            acceleration = (short)(num8 * num14);
            num6 = physics2.W;
            if (num6 >= 0 && acceleration <= 0)
            {
                direction = 1;
            }
            if (num6 < 0)
            {
                num6 = -num6;
            }
            if (num6 < 474 && acceleration < -16)
            {
                if (direction < 0)
                {
                    direction = 1;
                }
                else if (flag)
                {
                    direction = -1;
                }
            }
            FUN_3D0F8(num12);
            FUN_3D0F8_2(num13);
        }
        else
        {
            FUN_39CEC(num12);
        }
        num6 = 1;
        if (direction < 0)
        {
            num6 = -1;
            if (!flag)
            {
                z = physics1.X;
                if (z < 0)
                {
                    z += 127;
                }
                num10 = physics1.Z;
                if (num10 < 0)
                {
                    num10 += 127;
                }
                num6 = -1;
                if (-1941505 < vTransform.rotation.V02 * (z >> 7) + vTransform.rotation.V22 * (num10 >> 7))
                {
                    num6 = 1;
                }
            }
        }
        if (vTransform.rotation.V11 < 0)
        {
            if (ignition <= 0)
            {
                num3 -= playerController.DAT_14[0];
                if ((int)(num3 ^ num4) < 0)
                {
                    num3 = 0u;
                }
                num4 = ((num >> 28) & 1);
                num6 = (int)(((num & 0x8000000) != 0) ? ((num4 - 1) * 32768) : (num4 << 15));
                num6 = (int)(num3 * 512) + num6;
                if (wheelsType == _WHEELS.Sea)
                {
                    physics2.Z += num6;
                }
                else
                {
                    physics2.Z += num6;
                }
            }
        }
        else if (flag2)
        {
            z = turning;
            if (z < 0)
            {
                z = -z;
            }
            if (z < 170)
            {
                if (physics1.W < 2370)
                {
                    if (num12 == 0)
                    {
                        z = breaking - 3;
                        sbyte b = 0;
                        if (0 < z)
                        {
                            b = (sbyte)z;
                        }
                        breaking = b;
                    }
                    else
                    {
                        num10 = breaking + 2;
                        z = 127;
                        if (num10 < 127)
                        {
                            z = num10;
                        }
                        breaking = (sbyte)z;
                    }
                }
                acceleration = (short)(DAT_B3 * -2);
            }
            peelout += 4;
            if (flag3 && wheelsType != _WHEELS.Air)
            {
                z = physics2.Y;
                num6 = num6 * turning * 2;
                if (breaking == 0)
                {
                    peelout = 0;
                }
                goto IL_0ee5;
            }
        }
        else
        {
            if (0 < breaking)
            {
                breaking = (sbyte)(-breaking);
            }
            if (flag3 && wheelsType == _WHEELS.Ground)
            {
                z = physics1.W * DAT_B2;
                if (z < 0)
                {
                    z += 4095;
                }
                num10 = DAT_B1 + (z >> 12);
                z = 0;
                if (0 < num10)
                {
                    z = num10;
                }
                num6 = num6 * turning * z / 14;
                z = physics2.Y;
                goto IL_0ee5;
            }
        }
        goto IL_0ef5;
    IL_0ee5:
        physics2.Y = z + num6;
        goto IL_0ef5;
    IL_0b18:
        z = -682;
        if (-682 < num6)
        {
            z = num6;
        }
        turning = (short)z;
        goto IL_0b35;
    IL_0ef5:
        num6 = breaking + 4;
        if (breaking < 0)
        {
            sbyte b = 0;
            if (num6 < 0)
            {
                b = (sbyte)num6;
            }
            breaking = b;
        }
        z = playerController.stick[2] - 128;
        num6 = z;
        if (z < 0)
        {
            num6 = -z;
        }
        if (32 < num6)
        {
            if (z < 0)
            {
                z = playerController.stick[2] - 125;
            }
            vCamera.DAT_92 -= (short)(z >> 2);
        }
        z = playerController.stick[3] - 128;
        num6 = z;
        if (z < 0)
        {
            num6 = -z;
        }
        if (32 < num6)
        {
            z *= 3051;
            if (z < 0)
            {
                z += 127;
            }
            z = vCamera.DAT_9C + (z >> 7);
            num6 = DAT_58 << 1;
            if (num6 <= z)
            {
                num6 = 1310720;
                if (z < 1310721)
                {
                    num6 = z;
                }
            }
            vCamera.DAT_9C = num6;
        }
        if ((num & 0x20000000) != 0 && (flags & 0x2000000) == 0 && GameManager.instance.DAT_C74 == 0)
        {
            vCamera.FUN_4B898();
        }
    }

    [CompilerGenerated]
    private void _003CPhySea_003Eg__FUN_40B3C_007C105_0(ref _003C_003Ec__DisplayClass105_0 P_0)
    {
        int num = P_0.local_60.x - vTransform.position.x >> 3;
        int num2 = P_0.local_60.y - vTransform.position.y >> 3;
        int num3 = P_0.local_60.z - vTransform.position.z >> 3;
        Coprocessor.rotationMatrix.rt11 = (short)(num & 0xFFFF);
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)(num2 & 0xFFFF);
        Coprocessor.rotationMatrix.rt23 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)num3;
        Coprocessor.accumulator.ir1 = (short)(P_0.local_40.x >> 3);
        Coprocessor.accumulator.ir2 = (short)(P_0.local_40.y >> 3);
        Coprocessor.accumulator.ir3 = (short)(P_0.local_40.z >> 3);
        Coprocessor.ExecuteOP(12, lm: false);
        P_0.local_a0.x += P_0.local_40.x;
        P_0.local_a0.y += P_0.local_40.y;
        P_0.local_a0.z += P_0.local_40.z;
        P_0.iVar5 = Coprocessor.mathsAccumulator.mac1;
        P_0.local_b0.x += P_0.iVar5 >> 1;
        P_0.iVar5 = Coprocessor.mathsAccumulator.mac2;
        P_0.local_b0.y += P_0.iVar5;
        P_0.iVar5 = Coprocessor.mathsAccumulator.mac3;
        P_0.local_b0.z += P_0.iVar5 >> 1;
        if (P_0.local_28 != null && P_0.local_28.DAT_10[3] != 0 && P_0.local_28.DAT_10[3] != 7)
        {
            LevelManager.instance.level.UpdateW(this, 10, P_0.local_60);
        }
    }

    [CompilerGenerated]
    private void _003CFUN_3E8C0_003Eg__FUN_3EA0C_007C142_0(ref _003C_003Ec__DisplayClass142_0 P_0)
    {
        P_0.local_40 = Utilities.FUN_24148(vTransform, P_0.local_40);
        P_0.iVar3 = FUN_2CFBC(P_0.local_40, out P_0.local_20);
        if (0 >= P_0.local_40.y - P_0.iVar3)
        {
            return;
        }
        P_0.iVar4 = -physics1.X;
        if (0 < physics1.X)
        {
            P_0.iVar4 += 3;
        }
        P_0.iVar4 >>= 2;
        if (P_0.iVar4 < -2880)
        {
            P_0.local_30.x = -2880;
        }
        else
        {
            P_0.local_30.x = 2880;
            if (P_0.iVar4 < 2881)
            {
                P_0.local_30.x = P_0.iVar4;
            }
        }
        P_0.iVar4 = -physics1.Z;
        if (0 < physics1.Z)
        {
            P_0.iVar4 += 3;
        }
        P_0.iVar4 >>= 2;
        if (P_0.iVar4 < -2880)
        {
            P_0.local_30.z = -2880;
        }
        else
        {
            P_0.local_30.z = 2880;
            if (P_0.iVar4 < 2881)
            {
                P_0.local_30.z = P_0.iVar4;
            }
        }
        P_0.local_30.y = -(P_0.local_40.y - P_0.iVar3);
        if (0 < physics1.Y)
        {
            P_0.local_30.y -= physics1.Y >> 2;
        }
        int num = P_0.local_40.x - vTransform.position.x >> 3;
        int num2 = P_0.local_40.y - vTransform.position.y >> 3;
        int num3 = P_0.local_40.z - vTransform.position.z >> 3;
        Coprocessor.rotationMatrix.rt11 = (short)(num & 0xFFFF);
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)(num2 & 0xFFFF);
        Coprocessor.rotationMatrix.rt23 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)num3;
        Coprocessor.accumulator.ir1 = (short)(P_0.local_30.x >> 3);
        Coprocessor.accumulator.ir2 = (short)(P_0.local_30.y >> 3);
        Coprocessor.accumulator.ir3 = (short)(P_0.local_30.z >> 3);
        Coprocessor.ExecuteOP(12, lm: false);
        P_0.local_50.x += P_0.local_30.x;
        P_0.local_50.y += P_0.local_30.y;
        P_0.local_50.z += P_0.local_30.z;
        P_0.iVar3 = Coprocessor.mathsAccumulator.mac1;
        P_0.local_60.x += P_0.iVar3;
        P_0.iVar3 = Coprocessor.mathsAccumulator.mac2;
        P_0.local_60.y += P_0.iVar3;
        P_0.iVar3 = Coprocessor.mathsAccumulator.mac3;
        P_0.local_60.z += P_0.iVar3;
        if (P_0.local_20 != null && P_0.local_20.DAT_10[3] != 0 && P_0.local_20.DAT_10[3] != 7)
        {
            LevelManager.instance.level.UpdateW(this, 10, P_0.local_40);
        }
        if (19456 < physics1.Y)
        {
            flags |= 1073741824u;
        }
    }
}
