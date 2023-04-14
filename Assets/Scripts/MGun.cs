using UnityEngine;

public class MGun : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (arg1)
        {
            case 1:
                base.maxHalfHealth = 1280;
                return 0u;
            case 4:
                {
                    int num = base.maxHalfHealth - 64;
                    int num2 = 1280;
                    if (1280 < num)
                    {
                        num2 = num;
                    }
                    base.maxHalfHealth = (ushort)num2;
                    DAT_18 = 0;
                    if (tags != 0)
                    {
                        tags--;
                    }
                    return 0u;
                }
            case 12:
                {
                    if (--tags != -1)
                    {
                        return 0u;
                    }
                    Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(2, typeof(Ballistic), 8u) as Ballistic;
                    Bullet bullet = LevelManager.instance.xobfList[19].ini.FUN_2C17C(210, typeof(Bullet), 8u) as Bullet;
                    LevelManager.instance.FUN_42560(arg2, this, bullet, ballistic);
                    bullet.flags = 640u;
                    ushort maxHalfHealth = 7;
                    if (((Vehicle)arg2).doubleDamage != 0)
                    {
                        maxHalfHealth = 14;
                    }
                    bullet.maxHalfHealth = maxHalfHealth;
                    int num2 = arg2.physics1.X;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    bullet.physics1.Z = (num2 >> 7) + bullet.vTransform.rotation.V02 * 4;
                    num2 = arg2.physics1.Y;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    bullet.physics1.W = (num2 >> 7) + bullet.vTransform.rotation.V12 * 4;
                    num2 = arg2.physics1.Z;
                    if (num2 < 0)
                    {
                        num2 += 127;
                    }
                    bullet.physics2.X = (num2 >> 7) + bullet.vTransform.rotation.V22 * 4;
                    bullet.physics2.M2 = 45;
                    bullet.FUN_305FC();
                    if ((arg2.flags & 4) == 0)
                    {
                        ballistic.FUN_30BF0();
                    }
                    num2 = DAT_18;
                    if (num2 == 0)
                    {
                        num2 = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
                    }
                    GameManager.instance.FUN_1E580(num2, GameManager.instance.DAT_C2C, 41, bullet.screen);
                    tags = (sbyte)(base.maxHalfHealth >> 8);
                    base.maxHalfHealth += 32;
                    break;
                }
            case 13:
                {
                    Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
                    if (511998 < vector3Int.z - 1)
                    {
                        return 0u;
                    }
                    if (vector3Int.x < 0)
                    {
                        vector3Int.x = -vector3Int.x;
                    }
                    if (vector3Int.x * 6 >= vector3Int.z)
                    {
                        return 0u;
                    }
                    return 1u;
                }
        }
        return 0u;
    }
}
