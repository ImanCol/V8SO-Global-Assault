using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _BODY_TYPE
{
    Default,
    Collector,  //FUN_25C (GRBLDER.DLL)
    Ant, //FUN_20F0 (ROUTE66.DLL)
    Trailer //FUN_1314 (TRUCK.DLL)
}

public class Body : VigObject
{
    public _BODY_TYPE state;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (state)
        {
            case _BODY_TYPE.Collector:
                switch (arg1)
                {
                    case 0:
                        {
                            short num2 = 32;
                            if (tags == 0)
                            {
                                num2 = -32;
                            }
                            vr.x += num2;
                            if (arg2 != 0)
                            {
                                ApplyTransformation();
                            }
                            break;
                        }
                    case 2:
                        {
                            if ((flags & 0x80) == 0)
                            {
                                GameManager.instance.FUN_30CB0(this, 31);
                                FUN_30B78();
                                break;
                            }
                            ApplyTransformation();
                            int num = 1 - tags;
                            tags = (sbyte)num;
                            if ((((num * 16777216 >> 24) ^ id) & 1) == 0)
                            {
                                FUN_30BA8();
                            }
                            else
                            {
                                GameManager.instance.FUN_30CB0(this, 31);
                            }
                            Vector3Int param = GameManager.instance.FUN_2CE50(this);
                            LevelManager.instance.FUN_4DE54(param, 13);
                            break;
                        }
                }
                break;
            case _BODY_TYPE.Trailer:
                if (arg1 == 1)
                {
                    this.FUN_A0();
                }
                break;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (state == _BODY_TYPE.Ant && arg1 == 5)
        {
            VigObject vigObject = Utilities.FUN_2CDB0(this);
            uint flags = vigObject.flags;
            vigObject.flags = (uint)((int)flags & -33);
            if ((flags & 0x1000000) != 0)
            {
                vigObject.flags = (uint)((int)flags & -16777249);
                if (vigObject.maxHalfHealth < 50)
                {
                    vigObject.FUN_30BA8();
                    vigObject.FUN_30C68();
                    vigObject.FUN_4DC94();
                    return 4294967294u;
                }
                vigObject.FUN_2C124_2(16);
                Utilities.ParentChildren(vigObject, vigObject);
                VigObject vigObject2 = vigObject.child2.child2.child2;
                while (vigObject2 != null && vigObject2.id != 1)
                {
                    vigObject2 = vigObject2.child;
                }
                ((Ant)vigObject).DAT_8C = vigObject2;
                ((Body)vigObject2.child2).state = _BODY_TYPE.Ant;
                int num = vigObject.physics1.X;
                if (65535 < num)
                {
                    return 4294967294u;
                }
                vigObject = vigObject.child2;
                if (num < 0)
                {
                    num += 15;
                }
                short num2 = (short)(num >> 4);
                vigObject.vTransform.rotation.V22 = num2;
                vigObject.vTransform.rotation.V11 = num2;
                vigObject.vTransform.rotation.V00 = num2;
                return 4294967294u;
            }
        }
        return 0u;
    }
}
