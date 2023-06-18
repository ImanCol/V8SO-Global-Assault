using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public enum _PLACEHOLDER_TYPE
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
}

[BurstCompile]
public class Placeholder : VigObject
{
    public static Dictionary<_PLACEHOLDER_TYPE, _VEHICLE_INIT> vehicleInit = new Dictionary<_PLACEHOLDER_TYPE, _VEHICLE_INIT>
    {
        {
            _PLACEHOLDER_TYPE.LoadWonderwagon,
            _LoadWonderwagon
        },
        {
            _PLACEHOLDER_TYPE.LoadThunderbolt,
            _LoadThunderbolt
        },
        {
            _PLACEHOLDER_TYPE.LoadDakota,
            _LoadDakota
        },
        {
            _PLACEHOLDER_TYPE.LoadLivingston,
            _LoadLivingston
        },
        {
            _PLACEHOLDER_TYPE.LoadSamson,
            _LoadSamson
        },
        {
            _PLACEHOLDER_TYPE.LoadXanadu,
            _LoadXanadu
        },
        {
            _PLACEHOLDER_TYPE.LoadPalomino,
            _LoadPalomino
        },
        {
            _PLACEHOLDER_TYPE.LoadGuerrero,
            _LoadGuerrero
        },
        {
            _PLACEHOLDER_TYPE.LoadBurro,
            _LoadBurro
        },
        {
            _PLACEHOLDER_TYPE.LoadExcelsior,
            _LoadExcelsior
        },
        {
            _PLACEHOLDER_TYPE.LoadTsunami,
            _LoadTsunami
        },
        {
            _PLACEHOLDER_TYPE.LoadMarathon,
            _LoadMarathon
        },
        {
            _PLACEHOLDER_TYPE.LoadTrekker,
            _LoadTrekker
        },
        {
            _PLACEHOLDER_TYPE.LoadLoader,
            _LoadLoader
        },
        {
            _PLACEHOLDER_TYPE.LoadStinger,
            _LoadStinger
        },
        {
            _PLACEHOLDER_TYPE.LoadVertigo,
            _LoadVertigo
        },
        {
            _PLACEHOLDER_TYPE.LoadGoliath,
            _LoadGoliath
        },
        {
            _PLACEHOLDER_TYPE.LoadWapiti,
            _LoadWapiti
        }
    };

    public _PLACEHOLDER_TYPE state;

    protected override void Start()
    {
    }

    protected override void Update()
    {
    }

    public static VigObject FUN_31D30(_PLACEHOLDER_TYPE param1, XOBF_DB param2, short param3, uint param4)
    {
        vehicleInit.TryGetValue(param1, out _VEHICLE_INIT value);
        if (value != null)
        {
            VigObject vigObject = value(param2, param3, param4);
            if (vigObject != null)
            {
                return vigObject;
            }
        }
        if (param2 == null || param3 == -1)
        {
            VigObject obj = new GameObject().AddComponent(typeof(VigObject)) as VigObject;
            obj.vData = param2;
            return obj;
        }
        return param2.ini.FUN_2C17C((ushort)param3, typeof(VigObject), param4);
    }

    public static Vehicle _LoadWonderwagon(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[0]);
    }

    public static Vehicle _LoadThunderbolt(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[1]);
    }

    public static Vehicle _LoadDakota(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[2]);
    }

    public static Vehicle _LoadSamson(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[3]);
    }

    public static Vehicle _LoadLivingston(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[4], arg3: true);
    }

    public static Vehicle _LoadXanadu(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[5]);
    }

    public static Vehicle _LoadPalomino(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[6]);
    }

    public static Vehicle _LoadGuerrero(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[7]);
    }

    public static Vehicle _LoadBurro(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[8]);
    }

    public static Vehicle _LoadExcelsior(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[9]);
    }

    public static Vehicle _LoadTsunami(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[10]);
    }

    public static Vehicle _LoadMarathon(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[11]);
    }

    public static Vehicle _LoadTrekker(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[12]);
    }

    public static Vehicle _LoadLoader(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[13], arg3: true);
    }

    public static Vehicle _LoadStinger(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[14]);
    }

    public static Vehicle _LoadVertigo(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[15]);
    }

    public static Vehicle _LoadGoliath(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[16]);
    }

    public static Vehicle _LoadWapiti(XOBF_DB param1, int param2, uint param3 = 0u)
    {
        return FUN_367A4(param1, GameManager.vehicleConfigs[17]);
    }

    public static Vehicle FUN_367A4(XOBF_DB arg1, VehicleData arg2, bool arg3 = false)
    {
        Debug.Log("arg1 " + arg1); //Xobfs
        Debug.Log("args2 " + arg2.vehicleID); //VehicleData
        Debug.Log("typeof(Vehicle) " + typeof(Vehicle).Name); //Vehicle
        Debug.Log("arg3 " + arg3); //False
        if (arg1 == null)
        {
            return null;
        }
        return arg1.FUN_3C464(0, arg2, typeof(Vehicle), arg3);
    }

    public override VigObject FUN_31DDC()
    {
        Vehicle vehicle = FUN_31D30(state, vData, DAT_1A, (flags & 4) << 1) as Vehicle;
        vehicle.state = (_VEHICLE_TYPE)state;
        ushort maxHalfHealth = base.maxHalfHealth;
        ushort maxFullHealth = base.maxFullHealth;
        vehicle.flags |= flags;
        vehicle.id = id;
        vehicle.tags = tags;
        vehicle.screen = screen;
        vehicle.vr = vr;
        vehicle.DAT_19 = DAT_19;
        if (maxHalfHealth != 0 || maxFullHealth != 0)
        {
            VigObject vigObject = vehicle.child2;
            vehicle.maxHalfHealth = maxHalfHealth;
            vehicle.maxFullHealth = maxFullHealth;
            while (vigObject != null)
            {
                vigObject.maxHalfHealth = maxHalfHealth;
                vigObject = vigObject.child;
            }
        }
        vehicle.FUN_2D1DC();
        vehicle.FUN_2C958();
        return vehicle;
    }
}
