public class Empty : VigObject
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
            FUN_42330(arg2);
            return 0u;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result;
        if (arg1 != 0)
        {
            if (arg1 != 1)
            {
                if (arg1 == 12)
                {
                    short num = (short)(maxHalfHealth - 1);
                    maxHalfHealth = (ushort)num;
                    result = 60u;
                    if (num == 0)
                    {
                        FUN_3A368();
                        result = 60u;
                    }
                    goto IL_0046;
                }
            }
            else
            {
                maxHalfHealth = 6;
            }
            result = 0u;
        }
        else
        {
            FUN_42330(arg2);
            result = 0u;
        }
        goto IL_0046;
    IL_0046:
        return result;
    }
}
