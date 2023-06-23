using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class Water3 : VigObject
{
    // Token: 0x060003D8 RID: 984 RVA: 0x00007FCE File Offset: 0x000061CE
    protected override void Start()
    {
        base.Start();
    }

    // Token: 0x060003D9 RID: 985 RVA: 0x00007FD6 File Offset: 0x000061D6
    protected override void Update()
    {
        base.Update();
    }

    // Token: 0x060003DA RID: 986 RVA: 0x00034C28 File Offset: 0x00032E28
    public override uint OnCollision(HitDetection hit)
    {
        if (hit.self.type != 2)
        {
            return 0U;
        }
        Vehicle vehicle = (Vehicle)hit.self;
        if ((vehicle.flags & 16384U) != 0U)
        {
            GameManager.instance.FUN_30080(this.DAT_80_2, vehicle).flag = (uint)((GameManager.instance.DAT_28 + 300) | 1);
            if ((this.flags & 1U) == 0U)
            {
                GameManager.instance.FUN_30CB0(this, 60);
            }
            Water3.FUN_4D0(vehicle.vTransform.position, LevelManager.instance.level.vData, 1422, 1421, 2, 4, 60);
            vehicle.flags &= 4294950911U;
            GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, vehicle);
            return 0U;
        }
        VigTuple vigTuple = GameManager.instance.FUN_30134(this.DAT_80_2, vehicle);
        if (vigTuple != null)
        {
            vigTuple.flag |= 1U;
            return 0U;
        }
        return 0U;
    }

    // Token: 0x060003DB RID: 987 RVA: 0x00034D24 File Offset: 0x00032F24
    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 != 2)
        {
            if (arg1 < 3)
            {
                if (arg1 == 1)
                {
                    this.type = 3;
                    this.DAT_80_2 = new List<VigTuple>();
                    return 0U;
                }
                return 0U;
            }
            else if (arg1 != 3)
            {
                return 0U;
            }
        }
        bool flag = false;
        List<VigTuple> dat_80_ = this.DAT_80_2;
        uint num = (uint)GameManager.instance.DAT_28;
        for (int i = 0; i < dat_80_.Count; i++)
        {
            VigTuple vigTuple = dat_80_[i];
            GameManager.instance.DAT_28 = (int)num;
            if ((vigTuple.flag & 1U) == 0U || vigTuple.vObject.maxHalfHealth == 0)
            {
                vigTuple.vObject.flags |= 16384U;
                dat_80_.Remove(vigTuple);
                i--;
            }
            else
            {
                uint num2 = vigTuple.flag & 4294967294U;
                vigTuple.flag = num2;
                if (num2 < num)
                {
                    Vehicle vehicle = (Vehicle)vigTuple.vObject;
                    if (vehicle.shield == 0 && vehicle.ai.rubberTimer == 0)
                    {
                        vehicle.acceleration = -120;
                        vehicle.FUN_39BC4();
                    }
                    flag = true;
                    if (this.DAT_18 == 0)
                    {
                        sbyte b = (sbyte)GameManager.instance.FUN_1DD9C();
                        this.DAT_18 = b;
                        GameManager.instance.FUN_1E098((int)b, this.vData.sndList, 3, 0U, true);
                    }
                }
                GameManager.instance.FUN_30334(GameManager.instance.worldObjs, 10, vigTuple.vObject);
            }
            num = (uint)GameManager.instance.DAT_28;
        }
        if (!flag)
        {
            if (this.DAT_18 == 0)
            {
                goto IL_1A7;
            }
            GameManager.instance.FUN_1DE78((int)this.DAT_18);
            this.DAT_18 = 0;
        }
        if (this.DAT_18 != 0)
        {
            uint num3 = GameManager.instance.FUN_1E478(this.screen);
            GameManager.instance.FUN_1E2C8((int)this.DAT_18, num3);
        }
    IL_1A7:
        if (this.DAT_80_2.Count == 0)
        {
            return 0U;
        }
        GameManager.instance.FUN_30CB0(this, 60);
        return 0U;
    }

    // Token: 0x060003DC RID: 988 RVA: 0x00034EF8 File Offset: 0x000330F8
    private static Water4 FUN_4D0(Vector3Int param1, XOBF_DB param2, ushort param3, short param4, ushort param5, short param6, int param7)
    {
        Water4 water = param2.ini.FUN_2C17C(param3, typeof(Water4), 8U) as Water4;
        water.vTransform = GameManager.FUN_2A39C();
        water.vTransform.position = param1;
        water.DAT_58 = 32768;
        water.DAT_98 = param2;
        water.physics2.M3 = param4;
        water.flags |= 164U;
        water.physics1.M1 = param6;
        water.FUN_305FC();
        GameManager.instance.FUN_30CB0(water, param7);
        int num = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(num, param2.sndList, (int)param5, param1, false);
        return water;
    }

    // Token: 0x0400017D RID: 381
    private static Vector3Int DAT_134 = new Vector3Int(0, 0, 0);

    // Token: 0x0400017E RID: 382
    public List<VigTuple> DAT_80_2;
}
