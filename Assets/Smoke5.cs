using UnityEngine;

public class Smoke5 : VigObject
{
    public XOBF_DB DAT_98;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        base.transform.eulerAngles = new Vector3(base.transform.eulerAngles.x, 0f, base.transform.eulerAngles.z);
    }

    public override uint OnCollision(HitDetection hit)
    {
        if (hit.self.type == 2 && physics1.M0 != -1)
        {
            Vehicle vehicle = (Vehicle)hit.self;
            vehicle.physics1.X >>= 1;
            vehicle.physics1.Z >>= 1;
            vehicle.FUN_3A020(-1, Vector3Int.zero, param3: true);
            uint num = GameManager.FUN_2AC5C();
            int num2 = GameManager.instance.terrain.FUN_1B750((uint)vehicle.vTransform.position.x, (uint)vTransform.position.z);
            if ((num & 0x1F) == 0 || vehicle.vTransform.position.y - num2 > -32768)
            {
                vehicle.physics1.Y = -585856;
                if (LevelManager.instance.FUN_39AF8(vehicle))
                {
                    LevelManager.instance.FUN_4DE54(vTransform.position, 35);
                    UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 0, 8));
                }
            }
            else
            {
                vehicle.physics1.Y -= 131072;
                vehicle.physics2.X = 100000;
            }
            vehicle.flip += 10;
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
            }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        uint result;
        if (arg1 == 0)
        {
            if ((flags & 0x2000000) != 0)
            {
                VigObject obj = Utilities.FUN_2CD78(this);
                VigTransform vigTransform = GameManager.instance.FUN_2CDF4(obj);
                vTransform.rotation = Utilities.TransposeMatrix(vigTransform.rotation);
            }
            short num = (short)(physics1.M0 - 1);
            physics1.M0 = num;
            if (num == -1)
            {
                Smoke2 smoke = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Smoke2), 8u) as Smoke2;
                smoke.flags |= 1072u;
                smoke.type = 3;
                short m = physics2.M2;
                smoke.physics1.X = physics2.X;
                smoke.physics1.M2 = m;
                smoke.physics2.W = physics1.Y;
                int num2 = (int)GameManager.FUN_2AC5C();
                smoke.physics1.W = physics1.Z + (num2 * physics1.Z >> 15);
                smoke.screen = new Vector3Int(0, 0, 0);
                if ((flags & 0x1000000) != 0)
                {
                    m = (short)GameManager.FUN_2AC5C();
                    smoke.physics1.M3 = m;
                }
                Utilities.FUN_2CC48(this, smoke);
                Utilities.ParentChildren(this, this);
                physics1.M0 = physics1.M1;
            }
            if (DAT_18 != 0)
            {
                uint volume = GameManager.instance.FUN_1E478(vTransform.position);
                GameManager.instance.FUN_1E2C8(DAT_18, volume);
            }
            VigObject vigObject = child2;
            if (vigObject == null)
            {
                if (parent == null)
                {
                    GameManager.instance.FUN_309A0(this);
                    result = uint.MaxValue;
                }
                else
                {
                    VigObject obj = FUN_2CCBC();
                    GameManager.instance.FUN_307CC(obj);
                    result = uint.MaxValue;
                }
            }
            else
            {
                do
                {
                    vigObject.screen.y += vigObject.physics1.W;
                    uint num3 = (uint)((ushort)vigObject.physics1.M3 + (ushort)vigObject.physics1.M1);
                    vigObject.physics1.M3 = (short)num3;
                    vigObject.vr.z += vigObject.physics1.M2;
                    int num4 = vigObject.physics2.Z * GameManager.DAT_65C90[(num3 & 0xFFF) * 2];
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    vigObject.screen.x = num4 >> 12;
                    num4 = vigObject.physics2.Z * GameManager.DAT_65C90[(vigObject.physics1.M3 & 0xFFF) * 2];
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    vigObject.screen.z = num4 >> 12;
                    vigObject.physics2.Z = vigObject.physics2.Z + vigObject.physics2.W;
                    if (arg2 != 0)
                    {
                        vigObject.ApplyTransformation();
                    }
                    vigObject = vigObject.child;
                    result = 0u;
                }
                while (vigObject != null);
            }
        }
        else
        {
            result = 0u;
            switch (arg1)
            {
                case 2:
                    physics1.M0 = -1;
                    if (DAT_18 != 0)
                    {
                        GameManager.instance.FUN_1DE78(DAT_18);
                        DAT_18 = 0;
                    }
                    result = 0u;
                    break;
                case 4:
                    if (DAT_18 != 0)
                    {
                        GameManager.instance.FUN_1DE78(DAT_18);
                        DAT_18 = 0;
                    }
                    break;
            }
        }
        return result;
    }
}
