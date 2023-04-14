using UnityEngine;

public class OilSlick1 : VigObject
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
        GameManager.instance.FUN_2F798(this, hit);
        int num = physics1.X * hit.normal1.x + physics1.Y * hit.normal1.y + physics1.Z * hit.normal1.z;
        if (num < 0)
        {
            num += 2047;
        }
        num >>= 11;
        if (-1 < num)
        {
            return 0u;
        }
        int num2 = num * hit.normal1.x;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        physics1.X -= num2 >> 12;
        num2 = num * hit.normal1.y;
        if (num2 < 0)
        {
            num2 += 4095;
        }
        physics1.Y -= num2 >> 12;
        num *= hit.normal1.z;
        if (num < 0)
        {
            num += 4095;
        }
        physics1.Z -= num >> 12;
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 1:
                {
                    int num = DAT_58 * 12867;
                    physics2.Z = DAT_58;
                    if (num < 0)
                    {
                        num += 4095;
                    }
                    physics1.M6 = 0;
                    physics2.M2 = (short)(16777216 / (num >> 12));
                    physics1.M7 = 0;
                    physics2.M0 = 0;
                    break;
                }
            case 0:
                {
                    Vector3Int pos = new Vector3Int(vTransform.position.x, vTransform.position.y + physics2.Z, vTransform.position.z);
                    Vector3Int normalVector = default(Vector3Int);
                    int num = FUN_2CFBC(pos, ref normalVector);
                    if (num < pos.y + 2048)
                    {
                        if (normalVector.y < -3891)
                        {
                            VigObject vigObject = LevelManager.instance.xobfList[19].ini.FUN_2C17C(218, typeof(OilSlick2), 8u, typeof(VigChild));
                            Utilities.ParentChildren(vigObject, vigObject);
                            FUN_2D114(vTransform.position, ref vigObject.vTransform);
                            int param = GameManager.instance.FUN_1DD9C();
                            GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 61);
                            vigObject.flags = 4u;
                            short id = base.id;
                            vigObject.type = 3;
                            vigObject.id = id;
                            vigObject.maxHalfHealth = 100;
                            vigObject.tags = 10;
                            vigObject.FUN_2D1DC();
                            vigObject.FUN_305FC();
                            GameManager.instance.FUN_309A0(this);
                            return uint.MaxValue;
                        }
                        int x = normalVector.x;
                        int x2 = physics1.X;
                        int num2 = x2 * x + physics1.Y * normalVector.y + physics1.Z * normalVector.z;
                        if (num2 < 0)
                        {
                            num2 += 2047;
                        }
                        num2 >>= 11;
                        if (num2 < 0)
                        {
                            x = num2 * x;
                            if (x < 0)
                            {
                                x += 4095;
                            }
                            physics1.X = x2 - (x >> 12);
                            x = num2 * normalVector.y;
                            if (x < 0)
                            {
                                x += 4095;
                            }
                            physics1.Y = (physics1.Y - (x >> 12)) / 2;
                            num2 *= normalVector.z;
                            if (num2 < 0)
                            {
                                num2 += 4095;
                            }
                            physics1.Z -= num2 >> 12;
                            vTransform.position.y = num - physics2.Z;
                        }
                        else
                        {
                            x *= 90;
                            if (x < 0)
                            {
                                x += 4095;
                            }
                            physics1.X = x2 + (x >> 12);
                            num = normalVector.z * 90;
                            if (num < 0)
                            {
                                num += 4095;
                            }
                            physics1.Z += num >> 12;
                        }
                        num = -physics1.Z * (ushort)physics2.M2;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        num2 = physics1.X * (ushort)physics2.M2;
                        physics1.M6 = (short)(num >> 12);
                        if (num2 < 0)
                        {
                            num2 += 4095;
                        }
                        physics2.M0 = (short)(num >> 12);
                    }
                    else
                    {
                        physics1.Y += 90;
                    }
                    vTransform.rotation = Utilities.FUN_2ADB0(vTransform.rotation, new Vector3Int(physics1.M6, physics1.M7, physics2.M0));
                    vTransform.position.y += physics1.Y;
                    vTransform.position.x += physics1.X;
                    int num3 = GameManager.instance.DAT_28 - DAT_19;
                    vTransform.position.z += physics1.Z;
                    if ((num3 & 0xF) == 0)
                    {
                        vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
                        return 0u;
                    }
                    break;
                }
        }
        return 0u;
    }
}
