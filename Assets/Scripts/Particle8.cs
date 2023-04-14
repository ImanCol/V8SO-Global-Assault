public class Particle8 : VigObject
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
        if (arg1 == 2)
        {
            VigObject vigObject = Utilities.FUN_2CD78(this);
            Ballistic obj = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Ballistic), 8u) as Ballistic;
            obj.screen = Utilities.FUN_24148(vigObject.vTransform, vTransform.position);
            obj.flags |= 1076u;
            short z = (short)GameManager.FUN_2AC5C();
            obj.vr.z = z;
            obj.FUN_3066C();
            GameManager.instance.FUN_30CB0(this, tags);
        }
        return 0u;
    }
}
