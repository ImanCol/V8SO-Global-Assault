using UnityEngine;

public class CactusPatch : Mine
{
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
            if (tags == 0)
            {
                return 0u;
            }
            LevelManager.instance.FUN_4DF20(vTransform.position, 13, 2048);
            UIManager.instance.FUN_4E414(vTransform.position, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 8));
            int num = 0;
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 0);
            if (maxHalfHealth != 0)
            {
                do
                {
                    Mine mine = vData.ini.FUN_2C17C(182, typeof(Mine), 0u) as Mine;
                    mine.type = 8;
                    mine.id = hit.self.id;
                    mine.screen = screen;
                    uint flags = base.flags;
                    mine.maxHalfHealth = 150;
                    if (((Vehicle)DAT_80).doubleDamage != 0)
                    {
                        mine.maxHalfHealth = 300;
                    }
                    mine.physics2.M2 = 0;
                    mine.flags = ((flags & 0x60000000) | 0x80);
                    int num2 = (int)GameManager.FUN_2AC5C();
                    mine.physics1.Z = (num2 * 7629 >> 15) - 3814;
                    mine.physics1.W = -3051;
                    num2 = (int)GameManager.FUN_2AC5C();
                    mine.physics2.X = (num2 * 7629 >> 15) - 3814;
                    mine.DAT_80 = DAT_80;
                    mine.FUN_305FC();
                    num++;
                }
                while (num < maxHalfHealth);
            }
            GameManager.instance.FUN_309A0(this);
            return uint.MaxValue;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 2:
                id = 0;
                if (DAT_80.maxHalfHealth == 0)
                {
                    flags &= 3758096383u;
                    return 0u;
                }
                break;
            default:
                return 0u;
            case 0:
                {
                    if (tags != 0)
                    {
                        int num = GameManager.DAT_65C90[(physics2.M2 & 0xFFF) * 2] * 5120;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        vTransform.position.y = GameManager.instance.DAT_DB0 + (num >> 12);
                        physics2.M2 += 34;
                        return 0u;
                    }
                    if (FUN_46D70() == 0)
                    {
                        return 0u;
                    }
                    tags = 1;
                    bool num2 = GameManager.instance.DAT_DA0 <= vTransform.position.z;
                    physics2.M2 = 0;
                    if (num2 || vTransform.position.y < GameManager.instance.DAT_DB0)
                    {
                        FUN_30BA8();
                    }
                    flags |= 256u;
                    break;
                }
        }
        GameManager.instance.FUN_30CB0(this, 120);
        return 0u;
    }
}
