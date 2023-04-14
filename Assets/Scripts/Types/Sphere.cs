

public enum _SPHERE_TYPE
{
	Sphere,
	Destructible
}


public class Sphere : Destructible2
{
	public _SPHERE_TYPE state;

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
		switch (state)
		{
		case _SPHERE_TYPE.Sphere:
			if (hit.self.type == 8)
			{
				FUN_32B90(hit.self.maxHalfHealth);
			}
			break;
		case _SPHERE_TYPE.Destructible:
			return base.OnCollision(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (state)
		{
		case _SPHERE_TYPE.Sphere:
			switch (arg1)
			{
			case 1:
				base.UpdateW(arg1, arg2);
				break;
			case 8:
				FUN_32B90((uint)arg2);
				break;
			case 9:
				if (arg2 == 0)
				{
					Sphere2 obj = Utilities.FUN_52188(child2.FUN_2CD04(), typeof(Sphere2)) as Sphere2;
					int num = obj.DAT_58 * 3072;
					if (num < 0)
					{
						num += 4095;
					}
					obj.DAT_58 = num >> 12;
					obj.id = 1000;
					ushort maxFullHealth = base.maxFullHealth;
					obj.physics1.Y = -3051;
					num = obj.DAT_58 * 12867;
					obj.maxHalfHealth = maxFullHealth;
					obj.flags |= 136u;
					if (num < 0)
					{
						num += 4095;
					}
					obj.physics1.X = 0;
					obj.physics2.M2 = (short)(16777216 / (num >> 12));
					obj.physics1.Z = 0;
					obj.physics1.M6 = 0;
					obj.physics1.M7 = 0;
					obj.physics2.M0 = 0;
					obj.FUN_4C9C8();
					obj.FUN_305FC();
				}
				break;
			}
			break;
		case _SPHERE_TYPE.Destructible:
			return base.UpdateW(arg1, arg2);
		}
		return 0u;
	}
}
