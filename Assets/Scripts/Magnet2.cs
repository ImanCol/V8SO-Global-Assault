public class Magnet2 : VigObject
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
            vTransform.position.x += physics1.Z;
            vTransform.position.y += physics1.W;
            vTransform.position.z += physics2.X;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result = 0u;
        if (arg1 == 5)
        {
            GameManager.instance.FUN_309A0(this);
            result = uint.MaxValue;
        }
        return result;
    }
}
