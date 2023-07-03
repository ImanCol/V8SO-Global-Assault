using UnityEngine;

public class Smoke : VigObject
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
                smoke.flags |= 1040u;
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
                    int num4 = vigObject.physics2.Z * Utilities.DAT_65C90[(num3 & 0xFFF) * 2];
                    if (num4 < 0)
                    {
                        num4 += 4095;
                    }
                    vigObject.screen.x = num4 >> 12;
                    num4 = vigObject.physics2.Z * Utilities.DAT_65C90[(vigObject.physics1.M3 & 0xFFF) * 2];
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
            if (arg1 == 2)
            {
                physics1.M0 = -1;
                result = 0u;
            }
        }
        return result;
    }
}
