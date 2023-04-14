public class Smog : VigObject
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

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			physics1.Z = physics1.Z * 3968 >> 12;
			physics1.W = physics1.W * 3968 >> 12;
			physics2.X = physics2.X * 3968 >> 12;
			vr.z += physics2.M3;
			if (arg2 == 0)
			{
				return 0u;
			}
			ApplyTransformation();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
