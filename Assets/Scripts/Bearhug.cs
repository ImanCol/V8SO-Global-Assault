using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brearhug : Mine
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
        VigObject self = hit.self;
        if (self.GetType() == typeof(HellGate4))
        {
            GameManager.instance.FUN_300B8(GameManager.instance.DAT_10C8, this);
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, screen);
            LevelManager.instance.FUN_4DE54(screen, 39);
            LevelManager.instance.FUN_309C8(this, 0);
            return uint.MaxValue;
        }
        if (self.type == 2)
        {
            if (self.id > 0 && id > 0)
            {
                return 0u;
            }
            if (child2 == null)
            {
                Magnet1 magnet = vData.ini.FUN_2C17C(192, typeof(Magnet1), 8u) as Magnet1;
                magnet.flags = 16u;
                magnet.screen = new Vector3Int(0, 0, 0);
                Utilities.FUN_2CC48(this, magnet);
                magnet.transform.parent = base.transform;
                sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 56, vTransform.position, param5: true);
                LevelManager.instance.DAT_117C++;
            }
            Vehicle vehicle = (Vehicle)self;
            Utilities.FUN_29FC8(new Vector3Int(vTransform.position.x - vehicle.vTransform.position.x, vTransform.position.y - vehicle.vTransform.position.y - 20480, vTransform.position.z - vehicle.vTransform.position.z), out Vector3Int vout);
            vehicle.physics1.X += vout.x * 8;
            vehicle.physics1.Y += vout.y * 8;
            vehicle.physics1.Z += vout.z * 8;
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15ADC(~vehicle.id, 4);
            }
            if ((GameManager.FUN_2AC5C() & 3) == 0)
            {
                int param = (int)GameManager.FUN_2AC5C();
                ConfigContainer configContainer = vehicle.FUN_2C5F4((ushort)(((param * 7 >> 15) - 32752) & 0xFFFF));
                if (configContainer != null)
                {
                    Magnet2 obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Magnet2), 8u) as Magnet2;
                    obj.vTransform = GameManager.instance.FUN_2CEAC(vehicle, configContainer);
                    obj.physics1.Z = vout.x;
                    obj.physics1.W = vout.y;
                    obj.physics2.X = vout.z;
                    obj.flags = 180u;
                    obj.FUN_305FC();
                }
            }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2 && id < 0)
        {
            id = 0;
        }
        else
        {
            switch (arg1)
            {
                case 0:
                    if (tags == 0)
                    {
                        if (FUN_46D70() != 0)
                        {
                            if (vTransform.position.z < GameManager.instance.DAT_DA0 && GameManager.instance.DAT_DB0 <= vTransform.position.y)
                            {
                                tags = 1;
                                physics2.M2 = 0;
                            }
                            else
                            {
                                FUN_30BA8();
                            }
                            flags |= 256u;
                            GameManager.instance.FUN_30CB0(this, 120);
                        }
                    }
                    else
                    {
                        int num = Utilities.DAT_65C90[(physics2.M2 & 0xFFF) * 2] * 5120;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        vTransform.position.y = GameManager.instance.DAT_DB0 + (num >> 12);
                        physics2.M2 += 34;
                    }
                    break;
                case 4:
                    GameManager.instance.FUN_1DE78(DAT_18);
                    break;
            }
        }
        return 0u;
    }
}
