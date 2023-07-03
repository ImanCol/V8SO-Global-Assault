public class Disco2 : VigObject
{
	private static ushort[] DAT_95C = new ushort[7]
	{
		3,
		1,
		2,
		10,
		8,
		40,
		0
	};

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
		uint result;
		if (arg1 == 0)
		{
			screen.y += physics1.W;
			vr.x += 91;
			vr.y += 68;
			if (arg2 != 0)
			{
				ApplyTransformation();
			}
			if (physics1.W < 0)
			{
				physics1.W += 56;
			}
			else
			{
				physics1.W = 0;
			}
			ushort num = (ushort)(physics2.M2 + 1);
			physics2.M2 = (short)num;
			if ((num & 0xF) == 0)
			{
				if (tags == 0)
				{
					int num2 = (int)GameManager.FUN_2AC5C();
					uint num3 = (uint)(num2 * 3) >> 15;
					DiscoBall discoBall = vData.ini.FUN_2C17C(DAT_95C[num3], typeof(DiscoBall), 8u) as DiscoBall;
					uint num4 = GameManager.FUN_2AC5C();
					uint num5 = GameManager.FUN_2AC5C();
					int dAT_ = DAT_58;
					discoBall.type = 8;
					num2 = (int)((num5 & 0xFFF) * 2);
					discoBall.DAT_1A = 3;
					discoBall.tags = (sbyte)num3;
					int num6 = (int)((num4 & 0xFFF) * 2);
					discoBall.id = id;
					int num7 = Utilities.DAT_65C90[num2 + 1] * Utilities.DAT_65C90[num6];
					if (num7 < 0)
					{
						num7 += 4095;
					}
					num7 = (num7 >> 12) * dAT_;
					if (num7 < 0)
					{
						num7 += 4095;
					}
					discoBall.screen.x = num7 >> 12;
					num7 = Utilities.DAT_65C90[num2] * dAT_;
					if (num7 < 0)
					{
						num7 += 4095;
					}
					discoBall.screen.y = num7 >> 12;
					num2 = Utilities.DAT_65C90[num2 + 1] * Utilities.DAT_65C90[num6 + 1];
					if (num2 < 0)
					{
						num2 += 4095;
					}
					dAT_ = (num2 >> 12) * dAT_;
					if (dAT_ < 0)
					{
						dAT_ += 4095;
					}
					discoBall.screen.z = dAT_ >> 12;
					discoBall.flags = 1610613776u;
					discoBall.maxHalfHealth = maxHalfHealth;
					discoBall.DAT_84 = DAT_84;
					discoBall.DAT_80 = DAT_80;
					discoBall.ApplyTransformation();
					Utilities.FUN_2CC48(this, discoBall);
					Utilities.ParentChildren(this, this);
					GameManager.instance.FUN_30CB0(discoBall, 120);
				}
				else
				{
					int num2 = (int)GameManager.FUN_2AC5C();
					uint num3 = (uint)(num2 * 3) >> 15;
					DiscoBall2 discoBall2 = vData.ini.FUN_2C17C(DAT_95C[num3], typeof(DiscoBall2), 8u) as DiscoBall2;
					uint num8 = GameManager.FUN_2AC5C();
					uint num9 = GameManager.FUN_2AC5C();
					int dAT_ = DAT_58;
					discoBall2.type = 8;
					num2 = (int)((num9 & 0xFFF) * 2);
					discoBall2.DAT_1A = 3;
					discoBall2.tags = (sbyte)num3;
					int num6 = (int)((num8 & 0xFFF) * 2);
					discoBall2.id = id;
					int num7 = Utilities.DAT_65C90[num2 + 1] * Utilities.DAT_65C90[num6];
					if (num7 < 0)
					{
						num7 += 4095;
					}
					num7 = (num7 >> 12) * dAT_;
					if (num7 < 0)
					{
						num7 += 4095;
					}
					discoBall2.screen.x = num7 >> 12;
					num7 = Utilities.DAT_65C90[num2] * dAT_;
					if (num7 < 0)
					{
						num7 += 4095;
					}
					discoBall2.screen.y = num7 >> 12;
					num2 = Utilities.DAT_65C90[num2 + 1] * Utilities.DAT_65C90[num6 + 1];
					if (num2 < 0)
					{
						num2 += 4095;
					}
					dAT_ = (num2 >> 12) * dAT_;
					if (dAT_ < 0)
					{
						dAT_ += 4095;
					}
					discoBall2.screen.z = dAT_ >> 12;
					discoBall2.flags = 1610613776u;
					discoBall2.maxHalfHealth = 0;
					discoBall2.IDAT_78 = maxHalfHealth;
					discoBall2.DAT_84 = DAT_84;
					discoBall2.DAT_80 = DAT_80;
					discoBall2.ApplyTransformation();
					Utilities.FUN_2CC48(this, discoBall2);
					Utilities.ParentChildren(this, this);
					GameManager.instance.FUN_30CB0(discoBall2, 300);
				}
			}
			result = 0u;
			if (physics2.M2 == 240)
			{
				VigObject vigObject = Utilities.FUN_2CD78(this);
				if (vigObject.maxHalfHealth == 0)
				{
					vigObject.FUN_3A368();
				}
				else
				{
					vigObject.flags &= 4160749567u;
				}
				FUN_4DC94();
				VigObject param = FUN_2CCBC();
				GameManager.instance.FUN_307CC(param);
				result = uint.MaxValue;
				GameManager.instance.DAT_1084--;
			}
		}
		else
		{
			result = 0u;
		}
		return result;
	}
}
