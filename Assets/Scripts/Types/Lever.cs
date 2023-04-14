public class Lever : VigObject
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
		tags ^= 1;
		flags |= 32u;
		GameManager.instance.FUN_30CB0(this, 240);
		FUN_30B78();
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		Lever2 lever;
		int param;
		switch (arg1)
		{
		case 1:
			type = 3;
			return 0u;
		case 2:
			flags &= 4294967263u;
			return 0u;
		default:
			return 0u;
		case 0:
			{
				if (tags == 0)
				{
					short num = (short)(vr.z - 16);
					vr.z = num;
					if (-513 >= num)
					{
						goto IL_007f;
					}
				}
				else
				{
					short num = (short)(vr.z + 16);
					vr.z = num;
					if (num >= 513)
					{
						goto IL_007f;
					}
				}
				goto IL_0155;
			}
			IL_007f:
			lever = (vData.ini.FUN_2C17C(601, typeof(Lever2), 8u) as Lever2);
			lever.type = 8;
			lever.maxHalfHealth = 25;
			lever.flags |= 388u;
			lever.screen.x = screen.x;
			lever.screen.y = screen.y + 86016;
			lever.screen.z = screen.z;
			FUN_30BA8();
			lever.FUN_3066C();
			GameManager.instance.FUN_30CB0(lever, 512);
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 75, lever.screen);
			goto IL_0155;
			IL_0155:
			ApplyTransformation();
			return 0u;
		}
	}
}