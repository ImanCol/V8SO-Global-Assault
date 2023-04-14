using UnityEngine;

public class Particle4 : VigObject
{
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
        switch (arg1)
        {
            case 1:
                {
                    int num2 = 0;
                    bool flag;
                    do
                    {
                        VigObject vigObject2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C((ushort)DAT_1A, typeof(VigObject), 8u);
                        vigObject2.vTransform.position = new Vector3Int(0, 0, 0);
                        vigObject2.vTransform.rotation = new Matrix3x3
                        {
                            V00 = 4096,
                            V01 = 0,
                            V02 = 0,
                            V10 = 0,
                            V11 = 4096,
                            V12 = 0,
                            V20 = 0,
                            V21 = 0,
                            V22 = 4096
                        };
                        int num3 = (int)GameManager.FUN_2AC5C();
                        vigObject2.physics1.Z = (num3 << 11 >> 15) - 1024;
                        num3 = (int)GameManager.FUN_2AC5C();
                        vigObject2.physics1.W = -(num3 << 13 >> 15);
                        num3 = (int)GameManager.FUN_2AC5C();
                        vigObject2.physics2.X = (num3 << 11 >> 15) - 1024;
                        vigObject2.flags = 16u;
                        Utilities.FUN_2CC48(this, vigObject2);
                        Utilities.ParentChildren(this, this);
                        flag = (num2 < 8);
                        num2++;
                    }
                    while (flag);
                    return 0u;
                }
            case 0:
                {
                    VigObject vigObject = child2;
                    uint num = 0u;
                    if (vigObject != null)
                    {
                        do
                        {
                            vigObject.vTransform.position.x += vigObject.physics1.Z;
                            vigObject.vTransform.position.y += vigObject.physics1.W;
                            vigObject.vTransform.position.z += vigObject.physics2.X;
                            vigObject.physics1.W += 56;
                            vigObject = vigObject.child;
                        }
                        while (vigObject != null);
                        num = 0u;
                    }
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
