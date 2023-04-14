using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _PARTICLE6_TYPE
{
    Default, //0
    Type1, //FUN_4CB04
    Collector
}

public class Particle6 : VigObject
{
    public _PARTICLE6_TYPE state;

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
        if (state == _PARTICLE6_TYPE.Collector)
        {
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
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (state == _PARTICLE6_TYPE.Type1 && arg1 == 5)
        {
            Utilities.FUN_2CD78(this).FUN_30C20();
            vAnim = null;
            return uint.MaxValue;
        }
        return 0u;
    }
}
