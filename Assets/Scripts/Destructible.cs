public class Destructible : VigObject
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
        FUN_32CF0(hit);
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 8)
        {
            FUN_32B90((uint)arg2);
        }
        return 0u;
    }

    public bool FUN_32CF0(HitDetection param1)
    {
        bool result = false;
        if (param1.self.type == 8)
        {
            result = param1.object1.FUN_32B90(param1.self.maxHalfHealth);
        }
        return result;
    }
}
