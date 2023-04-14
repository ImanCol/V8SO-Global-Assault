public class OilSlick3 : VigObject
{
    protected override void Start()
    {
    }

    protected override void Update()
    {
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            int num = 0;
            Vehicle vehicle = (Vehicle)child;
            do
            {
                Wheel wheel = vehicle.wheels[num];
                if (wheel != null)
                {
                    wheel.flags &= 4227858431u;
                }
                num++;
            }
            while (num < 4);
            GameManager.instance.FUN_30904(this);
            return uint.MaxValue;
        }
        return 0u;
    }
}
