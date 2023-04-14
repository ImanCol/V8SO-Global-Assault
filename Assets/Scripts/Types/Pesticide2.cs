public class Pesticide2 : VigObject
{
	public int lenght;

	public int duration;

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
		if ((flags & 0x1000000) == 0 && hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			if (vehicle.shield == 0)
			{
				flags |= 16777248u;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 33, screen);
				if ((int)(GameManager.FUN_2AC5C() * 5) >> 15 == 0)
				{
					vehicle.FUN_39BC4();
				}
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			duration++;
			flags &= 251658207u;
			if (duration >= lenght)
			{
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
		}
		return 0u;
	}
}
