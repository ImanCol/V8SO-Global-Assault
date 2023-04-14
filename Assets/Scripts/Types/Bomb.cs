public class Bomb : VigObject
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
		if (hit.self.type == 8)
		{
			return 0u;
		}
		if (hit.self.type == 3)
		{
			return 0u;
		}
		FUN_4DC94();
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			short num = (short)Utilities.Ratan2(physics1.W, 7629);
			vr.x = -num;
			physics1.W += 56;
			int num2 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
			if (screen.y <= num2)
			{
				ApplyTransformation();
				return 0u;
			}
			FUN_4DC94();
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}