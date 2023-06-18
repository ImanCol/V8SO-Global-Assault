using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

[BurstCompile]
public class Water3 : VigObject
{
    private static Vector3Int DAT_134 = new Vector3Int(0, 0, 0);

    public List<VigTuple> DAT_80_2;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint OnCollision(HitDetection hit)
    {
        if (hit.self.type == 2)
        {
            Vehicle vehicle = (Vehicle)hit.self;
            if ((vehicle.flags & 0x4000) != 0)
            {
                GameManager.instance.FUN_30080(DAT_80_2, vehicle).flag = (uint)((GameManager.instance.DAT_28 + 300) | 1);
                if ((flags & 1) == 0)
                {
                    GameManager.instance.FUN_30CB0(this, 60);
                }
                FUN_4D0(vehicle.vTransform.position, LevelManager.instance.level.vData, 1422, 1421, 2, 4, 60);
                vehicle.flags &= 4294950911u;
                GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, vehicle);
                return 0u;
            }
            VigTuple vigTuple = GameManager.instance.FUN_30134(DAT_80_2, vehicle);
            if (vigTuple != null)
            {
                vigTuple.flag |= 1u;
                return 0u;
            }
            return 0u;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 != 2)
        {
            if (arg1 < 3)
            {
                if (arg1 == 1)
                {
                    type = 3;
                    DAT_80_2 = new List<VigTuple>();
                    return 0u;
                }
                return 0u;
            }
            if (arg1 != 3)
            {
                return 0u;
            }
        }
        bool flag = false;
        List<VigTuple> dAT_80_ = DAT_80_2;
        uint dAT_ = (uint)GameManager.instance.DAT_28;
        for (int i = 0; i < dAT_80_.Count; i++)
        {
            VigTuple vigTuple = dAT_80_[i];
            GameManager.instance.DAT_28 = (int)dAT_;
            if ((vigTuple.flag & 1) == 0 || vigTuple.vObject.maxHalfHealth == 0)
            {
                vigTuple.vObject.flags |= 16384u;
                dAT_80_.Remove(vigTuple);
                i--;
            }
            else
            {
                if ((vigTuple.flag &= 4294967294u) < dAT_)
                {
                    Vehicle vehicle = (Vehicle)vigTuple.vObject;
                    if (vehicle.shield == 0 && vehicle.ai.rubberTimer == 0)
                    {
                        vehicle.acceleration = -120;
                        vehicle.FUN_39BC4();
                    }
                    flag = true;
                    if (DAT_18 == 0)
                    {
                        sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
                        GameManager.instance.FUN_1E098(param, vData.sndList, 3, 0u, param5: true);
                    }
                }
                GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, vigTuple.vObject);
            }
            dAT_ = (uint)GameManager.instance.DAT_28;
        }
        if (!flag)
        {
            if (DAT_18 == 0)
            {
                goto IL_01a7;
            }
            GameManager.instance.FUN_1DE78(DAT_18);
            DAT_18 = 0;
        }
        if (DAT_18 != 0)
        {
            uint volume = GameManager.instance.FUN_1E478(screen);
            GameManager.instance.FUN_1E2C8(DAT_18, volume);
        }
        goto IL_01a7;
    IL_01a7:
        if (DAT_80_2.Count == 0)
        {
            return 0u;
        }
        GameManager.instance.FUN_30CB0(this, 60);
        return 0u;
    }

    private static Water4 FUN_4D0(Vector3Int param1, XOBF_DB param2, ushort param3, short param4, ushort param5, short param6, int param7)
    {
        Water4 water = param2.ini.FUN_2C17C(param3, typeof(Water4), 8u) as Water4;
        water.vTransform = GameManager.FUN_2A39C();
        water.vTransform.position = param1;
        water.DAT_58 = 32768;
        water.DAT_98 = param2;
        water.physics2.M3 = param4;
        water.flags |= 164u;
        water.physics1.M1 = param6;
        water.FUN_305FC();
        GameManager.instance.FUN_30CB0(water, param7);
        int param8 = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param8, param2.sndList, param5, param1);
        return water;
    }
}
