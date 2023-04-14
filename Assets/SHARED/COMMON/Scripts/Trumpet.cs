using UnityEngine;

public class Trumpet : VigObject
{
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
        switch (arg1)
        {
            case 0:
                FUN_42330(arg2);
                break;
            case 10:
                {
                    arg2 &= 0xFFFF;
                    if (arg2 != 8772)
                    {
                        break;
                    }
                    Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
                    if (vehicle == null || base.id != 0)
                    {
                        return 0u;
                    }
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E580(param, vData.sndList, 4, vehicle.vTransform.position);
                    int num = 0;
                    child2.FUN_2C05C();
                    child2.child.FUN_2C05C();
                    ((VigChild)child2).state = _CHILD_TYPE.Child;
                    FUN_30BF0();
                    do
                    {
                        Trumpet2 trumpet = vData.ini.FUN_2C17C(1, typeof(Trumpet2), 8u) as Trumpet2;
                        Utilities.ParentChildren(trumpet, trumpet);
                        trumpet.DAT_80 = vehicle;
                        trumpet.flags = 1610613632u;
                        short id = vehicle.id;
                        trumpet.type = 8;
                        trumpet.tags = 1;
                        trumpet.maxHalfHealth = 8;
                        if (vehicle.doubleDamage != 0)
                        {
                            trumpet.maxHalfHealth = 16;
                        }
                        trumpet.id = id;
                        ConfigContainer param2 = FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
                        trumpet.vTransform = GameManager.instance.FUN_2CEAC(this, param2);
                        GameManager.instance.FUN_2FEE8(trumpet, GameManager.instance.timer);
                        int num2 = vehicle.physics1.X;
                        if (num2 < 0)
                        {
                            num2 += 127;
                        }
                        int num3 = trumpet.vTransform.rotation.V02 * 30517;
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        trumpet.physics1.Z = (num2 >> 7) + (num3 >> 12);
                        num2 = vehicle.physics1.Y;
                        if (num2 < 0)
                        {
                            num2 += 127;
                        }
                        num3 = trumpet.vTransform.rotation.V12 * 30517;
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        trumpet.physics1.W = (num2 >> 7) + (num3 >> 12);
                        num2 = vehicle.physics1.Z;
                        if (num2 < 0)
                        {
                            num2 += 127;
                        }
                        num3 = trumpet.vTransform.rotation.V22 * 30517;
                        if (num3 < 0)
                        {
                            num3 += 4095;
                        }
                        trumpet.physics2.X = (num2 >> 7) + (num3 >> 12);
                        trumpet.FUN_305FC();
                        num++;
                    }
                    while (num < 2);
                    base.id = 500;
                    maxHalfHealth--;
                    return 400u;
                }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result;
        if (arg1 <= 1)
        {
            if (arg1 != 0)
            {
                if (arg1 == 1)
                {
                    if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
                    {
                        maxHalfHealth = 6;
                    }
                    else
                    {
                        maxHalfHealth = 3;
                    }
                    ConfigContainer cont = FUN_2C5F4(32768);
                    VigObject vigObject = vData.ini.FUN_2C17C(2, typeof(VigChild), 0u);
                    ((VigChild)vigObject).state = _CHILD_TYPE.Default;
                    Utilities.FUN_2CA94(this, cont, vigObject);
                    cont = FUN_2C5F4(32769);
                    vigObject = vData.ini.FUN_2C17C(2, typeof(VigObject), 0u);
                    Utilities.FUN_2CA94(this, cont, vigObject);
                    Utilities.ParentChildren(this, this);
                }
                goto IL_00d4;
            }
            FUN_42330(arg2);
            result = 0u;
        }
        else if (arg1 != 5)
        {
            if (arg1 != 12)
            {
                if (arg1 != 13)
                {
                    goto IL_00d4;
                }
                result = 0u;
                Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                result = 0u;
                if ((uint)(vector3Int.z - 102401) < 409599u)
                {
                    if (vector3Int.x < 0)
                    {
                        vector3Int.x = -vector3Int.x;
                    }
                    result = ((vector3Int.x * 2 - 65536 < vector3Int.z) ? 1u : 0u);
                }
            }
            else
            {
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E580(param, vData.sndList, 4, arg2.vTransform.position);
                int num = 0;
                param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E188(param, vData.sndList, 2);
                child2.FUN_2C05C();
                child2.child.FUN_2C05C();
                ((VigChild)child2).state = _CHILD_TYPE.Child;
                FUN_30BF0();
                do
                {
                    Trumpet2 trumpet = vData.ini.FUN_2C17C(1, typeof(Trumpet2), 8u) as Trumpet2;
                    Utilities.ParentChildren(trumpet, trumpet);
                    trumpet.DAT_80 = arg2;
                    trumpet.flags = 1610613632u;
                    short id = arg2.id;
                    trumpet.type = 8;
                    trumpet.maxHalfHealth = 8;
                    if (((Vehicle)arg2).doubleDamage != 0)
                    {
                        trumpet.maxHalfHealth = 16;
                    }
                    trumpet.id = id;
                    ConfigContainer cont = FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
                    trumpet.vTransform = GameManager.instance.FUN_2CEAC(this, cont);
                    GameManager.instance.FUN_2FEE8(trumpet, GameManager.instance.timer);
                    int num2 = arg2.physics1.X;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    int num3 = trumpet.vTransform.rotation.V02 * 30517;
                    if (num3 < 0)
                    {
                        num3 += 4095;
                    }
                    trumpet.physics1.Z = (num2 >> 7) + (num3 >> 12);
                    num2 = arg2.physics1.Y;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num3 = trumpet.vTransform.rotation.V12 * 30517;
                    if (num3 < 0)
                    {
                        num3 += 4095;
                    }
                    trumpet.physics1.W = (num2 >> 7) + (num3 >> 12);
                    num2 = arg2.physics1.Z;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    num3 = trumpet.vTransform.rotation.V22 * 30517;
                    if (num3 < 0)
                    {
                        num3 += 4095;
                    }
                    trumpet.physics2.X = (num2 >> 7) + (num3 >> 12);
                    trumpet.FUN_305FC();
                    num++;
                }
                while (num < 2);
                result = 300u;
                maxHalfHealth--;
            }
        }
        else
        {
            VigObject child = child2;
            child.child.vAnim = null;
            child.vAnim = null;
            FUN_30C20();
            result = 4294967294u;
            if (maxHalfHealth == 0)
            {
                FUN_3A368();
                result = 4294967294u;
            }
        }
        goto IL_03e6;
    IL_00d4:
        result = 0u;
        goto IL_03e6;
    IL_03e6:
        return result;
    }
}
