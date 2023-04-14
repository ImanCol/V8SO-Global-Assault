public class Particle3 : VigObject
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
        if (arg1 == 0)
        {
            VigObject vigObject = child2;
            if (child2 == null)
            {
                GameManager.instance.FUN_309A0(this);
            }
            else
            {
                VigObject child;
                do
                {
                    child = vigObject.child;
                    int num = vigObject.physics2.Y - 1;
                    vigObject.physics2.Y = num;
                    if (num == 0)
                    {
                        vigObject.FUN_2CCBC();
                        GameManager.instance.FUN_2C4B4(vigObject);
                        Utilities.ParentChildren(this, this);
                    }
                    else
                    {
                        vigObject.screen.x += vigObject.physics1.Z;
                        vigObject.screen.y += vigObject.physics1.W;
                        vigObject.screen.z += vigObject.physics2.X;
                        vigObject.vr.x += vigObject.physics1.M0;
                        vigObject.vr.y += vigObject.physics1.M1;
                        vigObject.vr.z += vigObject.physics1.M2;
                        vigObject.ApplyTransformation();
                        vigObject.physics1.W += 90;
                    }
                    vigObject = child;
                }
                while (child != null);
            }
        }
        return 0u;
    }
}
