public class Bullet : VigObject
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
        if (hit.object2.type == 3)
        {
            return 0u;
        }
        VigObject self = hit.self;
        Particle1 particle = LevelManager.instance.FUN_4DE54(screen, 0);
        particle.flags |= 1024u;
        short z = (short)GameManager.FUN_2AC5C();
        particle.vr.z = z;
        particle.ApplyTransformation();
        if (self.type != 2 || ((Vehicle)self).shield == 0)
        {
            int param = GameManager.instance.FUN_1DD9C();
            uint num = GameManager.FUN_2AC5C();
            int param2 = 74;
            if ((num & 3) != 0)
            {
                param2 = 72;
                if (self.type != 2)
                {
                    num = (ushort)self.id;
                    switch (num)
                    {
                        case 96u:
                        case 97u:
                        case 98u:
                        case 99u:
                        case 100u:
                        case 101u:
                        case 102u:
                        case 103u:
                        case 104u:
                        case 105u:
                        case 106u:
                        case 107u:
                        case 108u:
                        case 109u:
                        case 110u:
                        case 111u:
                        case 112u:
                        case 113u:
                        case 114u:
                        case 115u:
                        case 116u:
                        case 117u:
                        case 118u:
                        case 119u:
                        case 120u:
                        case 121u:
                        case 122u:
                        case 123u:
                        case 124u:
                        case 125u:
                        case 126u:
                        case 127u:
                            param2 = 72;
                            break;
                        case 64u:
                        case 65u:
                        case 66u:
                        case 67u:
                        case 68u:
                        case 69u:
                        case 70u:
                        case 71u:
                        case 72u:
                        case 73u:
                        case 74u:
                        case 75u:
                        case 76u:
                        case 77u:
                        case 78u:
                        case 79u:
                        case 80u:
                        case 81u:
                        case 82u:
                        case 83u:
                        case 84u:
                        case 85u:
                        case 86u:
                        case 87u:
                        case 88u:
                        case 89u:
                        case 90u:
                        case 91u:
                        case 92u:
                        case 93u:
                        case 94u:
                        case 95u:
                            param2 = 73;
                            break;
                        default:
                            param2 = 71;
                            if (num - 129 < 31)
                            {
                                param2 = 73;
                            }
                            break;
                    }
                }
            }
            GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, param2, screen);
        }
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 0)
        {
            int num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
            if (screen.y <= num)
            {
                screen.x += physics1.Z;
                screen.y += physics1.W;
                screen.z += physics2.X;
                vTransform.position = screen;
                short m = physics2.M2;
                physics2.M2 = (short)(m - 1);
                if (m != 1)
                {
                    return 0u;
                }
            }
            else
            {
                Particle1 particle = LevelManager.instance.FUN_4DE54(screen, 0);
                short z = (short)GameManager.FUN_2AC5C();
                particle.vr.z = z;
                particle.ApplyTransformation();
                int param = GameManager.instance.FUN_1DD9C();
                uint num2 = GameManager.FUN_2AC5C();
                int param2 = 71;
                if ((num2 & 3) == 0)
                {
                    param2 = 74;
                }
                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, param2, screen);
            }
            GameManager.instance.FUN_309A0(this);
            return uint.MaxValue;
        }
        return 0u;
    }
}
