public class TrumpetBallistic : Ballistic
{
    public Trumpet2 DAT_90;

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
        if (hit.self.type == 2 && (hit.self.flags & 0x4000000) == 0)
        {
            Vehicle vehicle = (Vehicle)hit.self;
            if (vehicle.shield != 0)
            {
                return 0u;
            }
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15AA8(~vehicle.id, 8, byte.MaxValue, 64, 16);
            }
            int num = vehicle.DAT_A6 >> 17;
            if (num == 0)
            {
                num = 1;
            }
            vehicle.physics1.X += DAT_90.physics1.Z * 2 / num;
            vehicle.physics1.Z += DAT_90.physics2.X * 2 / num;
            vehicle.physics2.X = 131072 / num;
            vehicle.physics2.Y = 131072 / num;
            vehicle.physics2.Z = 131072 / num;
            maxHalfHealth = 0;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        return base.UpdateW(arg1, arg2);
    }
}
