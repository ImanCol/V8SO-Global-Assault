public class SunLensFlare : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        base.transform.rotation = base.transform.localRotation;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        uint result;
        if (arg1 == 0)
        {
            result = 0u;
        }
        else
        {
            result = 0u;
            if (arg1 == 1)
            {
                vr = LevelManager.instance.DAT_10F8;
                vTransform = GameManager.FUN_2A39C();
                result = uint.MaxValue;
                GameManager.instance.DAT_1124 = this;
                base.transform.parent = LevelManager.instance.defaultCamera.transform;
            }
        }
        return result;
    }
}
