using UnityEngine;

public class Tornado : VigObject
{
    private static Vector3Int DAT_20 = new Vector3Int(0, 0, 0);

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
        if (hit.self.type != 2)
        {
            return 0u;
        }
        Vehicle vehicle = (Vehicle)hit.self;
        vehicle.physics1.Y = -195200;
        vehicle.physics2.Y += 2000;
        if ((GameManager.FUN_2AC5C() & 0x1F) != 0)
        {
            return 0u;
        }
        int param = -30;
        if (((Vehicle)DAT_80).doubleDamage != 0)
        {
            param = -60;
        }
        param = vehicle.FUN_3B078(DAT_80, (ushort)DAT_1A, param, 1u);
        vehicle.FUN_3A020(param, DAT_20, param3: true);
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 0:
                {
                    int w = physics1.W;
                    Utilities.FUN_2A168(out Vector3Int vout, vTransform.position, DAT_84.screen);
                    int num = vout.x * w;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    vTransform.position.x += num >> 12;
                    num = vout.z * w;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    vTransform.position.z += num >> 12;
                    int y = FUN_2CFBC(vTransform.position);
                    vTransform.position.y = y;
                    physics1.W = w - 33;
                    if (tags == 0)
                    {
                        short z;
                        if (((GameManager.instance.DAT_28 - DAT_19) & 0xF) == 0)
                        {
                            uint num2 = GameManager.FUN_2AC5C();
                            y = 151;
                            if ((num2 & 1) != 0)
                            {
                                y = 150;
                            }
                            Ballistic obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)y, typeof(Ballistic), 8u) as Ballistic;
                            obj.type = 7;
                            obj.flags = 1076u;
                            num = (int)GameManager.FUN_2AC5C();
                            obj.screen.x = vTransform.position.x + (num * 20480 >> 15) - 10240;
                            obj.screen.y = vTransform.position.y;
                            num = (int)GameManager.FUN_2AC5C();
                            obj.screen.z = vTransform.position.z + (num * 20480 >> 15) - 10240;
                            z = (short)GameManager.FUN_2AC5C();
                            obj.vr.z = z;
                            obj.FUN_3066C();
                            return 0u;
                        }
                        if ((GameManager.FUN_2AC5C() & 0x1F) != 0)
                        {
                            return 0u;
                        }
                        uint num3 = GameManager.FUN_2AC5C();
                        y = 5;
                        if ((num3 & 1) != 0)
                        {
                            y = 4;
                        }
                        Throwaway obj2 = vData.ini.FUN_2C17C((ushort)y, typeof(Throwaway), 0u) as Throwaway;
                        w = (int)GameManager.FUN_2AC5C();
                        int num4 = (int)((GameManager.FUN_2AC5C() & 0xFFF) * 2);
                        num = Utilities.DAT_65C90[num4] * 4577;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        obj2.physics1.Z = num >> 12;
                        num = Utilities.DAT_65C90[(((w << 8 >> 15) + 256) & 0xFFF) * 2] * 4577;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        obj2.physics1.W = num >> 12;
                        num = Utilities.DAT_65C90[num4 + 1] * 4577;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        obj2.physics2.X = num >> 12;
                        short num5 = (short)GameManager.FUN_2AC5C();
                        obj2.physics1.M0 = (short)(num5 & 0xFF);
                        num5 = (short)GameManager.FUN_2AC5C();
                        obj2.physics1.M1 = (short)(num5 & 0xFF);
                        num5 = (short)GameManager.FUN_2AC5C();
                        obj2.physics1.M2 = (short)(num5 & 0xFF);
                        z = id;
                        obj2.type = 7;
                        obj2.flags = 384u;
                        obj2.state = _THROWAWAY_TYPE.Unspawnable;
                        obj2.id = z;
                        obj2.vTransform = vTransform;
                        obj2.DAT_87 = 2;
                        obj2.FUN_2D1DC();
                        obj2.FUN_305FC();
                        return 0u;
                    }
                    short m = physics2.M2;
                    Vector3Int sv = new Vector3Int(m, m, m);
                    ApplyRotationMatrix();
                    Utilities.FUN_245AC(ref vTransform.rotation, sv);
                    physics2.M2 = (short)(m - 136);
                    break;
                }
            case 2:
                if (++tags != 1)
                {
                    GameManager.instance.FUN_309A0(this);
                    return uint.MaxValue;
                }
                physics2.M2 = 4096;
                GameManager.instance.FUN_30CB0(this, 30);
                break;
        }
        return 0u;
    }
}
