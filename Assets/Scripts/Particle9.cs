using UnityEngine;

public class Particle9 : VigObject
{
    protected override void Update()
    {
        base.Update();
    }

    protected override void Start()
    {
        base.Start();
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        switch (arg1)
        {
            case 1:
                {
                    int num3 = 0;
                    short num4 = 0;
                    do
                    {
                        num3++;
                        VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)DAT_1A, typeof(VigObject), 8u);
                        vigObject2.screen = new Vector3Int(0, 0, 0);
                        vigObject2.vr = new Vector3Int(341, num4, 0);
                        vigObject2.ApplyTransformation();
                        Utilities.FUN_2CC48(this, vigObject2);
                        Utilities.ParentChildren(this, this);
                        num4 = (short)(num4 + 341);
                    }
                    while (num3 < 12);
                    break;
                }
            default:
                return 0u;
            case 0:
                {
                    VigObject vigObject = child2;
                    int maxHalfHealth = base.maxHalfHealth;
                    while (vigObject != null)
                    {
                        int num = vigObject.vTransform.rotation.V02 * maxHalfHealth;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        int num2 = vigObject.vTransform.rotation.V12 * maxHalfHealth;
                        vigObject.vTransform.position.x += num >> 12;
                        if (num2 < 0)
                        {
                            num2 += 4095;
                        }
                        num = vigObject.vTransform.rotation.V22 * maxHalfHealth;
                        vigObject.vTransform.position.y += num2 >> 12;
                        if (num < 0)
                        {
                            num += 4095;
                        }
                        vigObject.vTransform.position.z += num >> 12;
                        vigObject = vigObject.child;
                    }
                    base.maxHalfHealth = (ushort)(maxHalfHealth * 31 >> 5);
                    break;
                }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 == 5)
        {
            GameManager.instance.FUN_309A0(this);
            return 4294967294u;
        }
        return 0u;
    }
}
