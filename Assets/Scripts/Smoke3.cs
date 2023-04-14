using UnityEngine;

public class Smoke3 : VigObject
{
    public XOBF_DB DAT_98;

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
                uint num2 = GameManager.FUN_2AC5C();
                Smoke2 smoke = DAT_98.ini.FUN_2C17C((ushort)physics2.M3, typeof(Smoke2), 8u) as Smoke2;
                int num3 = (int)((num2 & 0xFFF) * 2);
                smoke.flags |= 1040u;
                int num4 = physics1.Y * GameManager.DAT_65C90[num3];
                if (num4 < 0)
                {
                    num4 += 4095;
                }
                smoke.physics1.Z = num4 >> 12;
                num4 = physics1.Y * GameManager.DAT_65C90[num3 + 1];
                if (num4 < 0)
                {
                    num4 += 4095;
                }
                smoke.physics2.X = num4 >> 12;
                num4 = (int)GameManager.FUN_2AC5C();
                num3 = physics1.Z;
                smoke.vTransform.position = new Vector3Int(0, 0, 0);
                smoke.physics1.W = num3 + (num4 * num3 >> 15);
                smoke.vTransform = GameManager.FUN_2A39C();
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
                    vigObject.vTransform.position.x += vigObject.physics1.Z;
                    vigObject.vTransform.position.y += vigObject.physics1.W;
                    vigObject.vTransform.position.z += vigObject.physics2.X;
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
