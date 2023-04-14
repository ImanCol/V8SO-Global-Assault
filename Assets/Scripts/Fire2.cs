public class Fire2 : VigObject
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
            FUN_4EE8C(GameManager.instance.interObjs);
            result = uint.MaxValue;
        }
        return result;
    }

    public void FUN_4EE40()
    {
        ApplyTransformation();
        FUN_2D1DC();
        VigTuple vigTuple = TDAT_74 = GameManager.instance.FUN_30080(GameManager.instance.interObjs, this);
        vigTuple = (TDAT_78 = GameManager.instance.FUN_30080(GameManager.instance.DAT_10A8, this));
    }
}
