public class GlacierSmall : Destructible
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
		if (hit.self.type == 2)
		{
			Vehicle obj = (Vehicle)hit.self;
			int num = physics1.Z / 32768;
			obj.FUN_3A064(-num * 4, vTransform.position, param3: true);
			obj.physics1.X += physics1.X;
			obj.physics1.Z += physics1.Z;
		}
		else
		{
			if (hit.self.type == 0)
			{
				if (hit.self.GetType() == typeof(GlacierSmall) && physics1.Z > hit.self.physics1.Z)
				{
					hit.self.FUN_4DC94();
					return 4294967294u;
				}
				FUN_4DC94();
				return 4294967294u;
			}
			if (hit.self.type == 4)
			{
				hit.self.FUN_32B90(5u);
				FUN_4DC94();
				return 4294967294u;
			}
		}
		if (FUN_32CF0(hit))
		{
			return 4294967294u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num = physics1.X;
			if (num < 0)
			{
				num += 127;
			}
			int num2 = physics1.Z;
			vTransform.position.x += num >> 7;
			if (num2 < 0)
			{
				num2 += 127;
			}
			vTransform.position.z += num2 >> 7;
			if ((uint)GameManager.instance.terrain.DAT_DEC < (uint)vTransform.position.z)
			{
				num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				if (num < GameManager.instance.DAT_DB0)
				{
					physics1.Z = 0;
					physics1.X = 0;
					vTransform.position.y = num;
				}
				else
				{
					vTransform.position.y = GameManager.instance.DAT_DB0;
				}
			}
			else
			{
				vTransform.position.y = GameManager.instance.DAT_DB0;
			}
			break;
		}
		case 1:
			flags |= 65536u;
			break;
		case 2:
			FUN_4DC94();
			return 0u;
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 == 0)
			{
				return 0u;
			}
			if (tags == 1)
			{
				Oilfield.instance.DAT_A4--;
			}
			GameManager.instance.FUN_309A0(this);
			return 0u;
		}
		return 0u;
	}
}
