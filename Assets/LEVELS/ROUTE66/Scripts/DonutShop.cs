public class DonutShop : Destructible
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
		return base.OnCollision(hit);
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 9)
		{
			result = 0u;
			if (arg2 == 0)
			{
				Donut obj = Utilities.FUN_52188(child2.FUN_2CD04(), typeof(Donut)) as Donut;
				uint num = (uint)((long)obj.DAT_58 * 25734L);
				int num2 = (int)((ulong)((long)obj.DAT_58 * 25734L) >> 32);
				obj.flags = 128u;
				short id = base.id;
				obj.maxHalfHealth = 300;
				obj.id = id;
				int num3 = FUN_50B0(num, num2, 0u, 0);
				if (num3 < 1)
				{
					num += 4095;
					num2 += ((num < 4095) ? 1 : 0);
				}
				obj.physics2.Y = ((int)(num >> 12) | (num2 << 20));
				obj.vr = Utilities.FUN_2A2E0(obj.vTransform.rotation);
				num3 = obj.vTransform.rotation.V02 * 4577;
				if (num3 < 0)
				{
					num3 += 4095;
				}
				obj.physics1.X = num3 >> 12;
				obj.physics1.Y = -3051;
				num3 = obj.vTransform.rotation.V22 * 4577;
				if (num3 < 0)
				{
					num3 += 4095;
				}
				obj.physics1.Z = num3 >> 12;
				obj.FUN_305FC();
				result = 0u;
			}
		}
		else
		{
			result = base.UpdateW(arg1, arg2);
		}
		return result;
	}

	private static int FUN_50B0(uint param1, int param2, uint param3, int param4)
	{
		int result = 0;
		if (param4 <= param2)
		{
			result = 2;
			if (param2 <= param4)
			{
				if (param1 < param3)
				{
					result = 0;
				}
				else
				{
					result = 2;
					if (param1 <= param3)
					{
						result = 1;
					}
				}
			}
		}
		return result;
	}
}
