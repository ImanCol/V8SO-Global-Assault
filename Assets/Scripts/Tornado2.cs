public class Tornado2 : VigObject
{
	public Vehicle.AI DAT_84_2;

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
		VigObject self = hit.self;
		if (self.type != 2)
		{
			return 0u;
		}
		self.physics1.Y = -195200;
		self.physics2.Y += 4000;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			int num;
			if (DAT_84_2.DAT_00 < 0)
			{
				num = (int)GameManager.FUN_2AC5C();
				VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (num * 3 >> 15) - 25);
				DAT_84_2.FUN_51C54(screen, vigObject.screen, uint.MaxValue, 0u);
			}
			int num2 = (Utilities.FUN_51E08(this, ref DAT_84_2, 65536) & 0xFFF) * 2;
			num = GameManager.DAT_65C90[num2] * 1525;
			if (num < 0)
			{
				num += 4095;
			}
			int x = screen.x + (num >> 12);
			screen.x = x;
			num = GameManager.DAT_65C90[num2 + 1] * 1525;
			if (num < 0)
			{
				num += 4095;
			}
			screen.z += num >> 12;
			int y = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
			screen.y = y;
			vr.y += 68;
			child2.vr.y += 68;
			if (((GameManager.instance.DAT_28 - DAT_19) & 0xF) == 0)
			{
				Ballistic obj = vData.ini.FUN_2C17C(175, typeof(Ballistic), 8u) as Ballistic;
				obj.type = 7;
				obj.flags = 52u;
				num = (int)GameManager.FUN_2AC5C();
				obj.screen.x = screen.x + (num * 20480 >> 15) - 10240;
				obj.screen.y = screen.y;
				num = (int)GameManager.FUN_2AC5C();
				obj.screen.z = screen.z + (num * 20480 >> 15) - 10240;
				obj.FUN_3066C();
			}
			else if ((GameManager.FUN_2AC5C() & 0x1F) == 0)
			{
				uint num3 = GameManager.FUN_2AC5C();
				y = 174;
				if ((num3 & 1) != 0)
				{
					y = 173;
				}
				Throwaway obj2 = vData.ini.FUN_2C17C((ushort)y, typeof(Throwaway), 0u) as Throwaway;
				num2 = (int)GameManager.FUN_2AC5C();
				x = (int)((GameManager.FUN_2AC5C() & 0xFFF) * 2);
				num = GameManager.DAT_65C90[x] * 4577;
				if (num < 0)
				{
					num += 4095;
				}
				obj2.physics1.Z = num >> 12;
				num = GameManager.DAT_65C90[(((num2 << 8 >> 15) + 256) & 0xFFF) * 2] * -4577;
				if (num < 0)
				{
					num += 4095;
				}
				obj2.physics1.W = num >> 12;
				num = GameManager.DAT_65C90[x + 1] * 4577;
				if (num < 0)
				{
					num += 4095;
				}
				obj2.physics2.X = num >> 12;
				ushort num4 = (ushort)GameManager.FUN_2AC5C();
				obj2.physics1.M0 = (short)(num4 & 0xFF);
				num4 = (ushort)GameManager.FUN_2AC5C();
				obj2.physics1.M1 = (short)(num4 & 0xFF);
				num4 = (ushort)GameManager.FUN_2AC5C();
				obj2.physics1.M2 = (short)(num4 & 0xFF);
				short id = base.id;
				obj2.type = 7;
				obj2.flags = 128u;
				obj2.state = _THROWAWAY_TYPE.Unspawnable;
				obj2.id = id;
				obj2.vTransform = vTransform;
				obj2.DAT_87 = 2;
				obj2.FUN_2D1DC();
				obj2.FUN_305FC();
			}
			if (arg2 == 0)
			{
				return 0u;
			}
			num = (int)GameManager.instance.FUN_1E7A8(screen);
			if (num == 0)
			{
				if (DAT_18 != 0)
				{
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
			}
			else if (DAT_18 == 0)
			{
				sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param, vData.sndList, 4, (uint)num, param5: true);
			}
			else
			{
				GameManager.instance.FUN_1E2C8(DAT_18, (uint)num);
			}
			ApplyTransformation();
			child2.ApplyTransformation();
			return 0u;
		}
		case 1:
			type = 3;
			DAT_84_2.DAT_00 = -1;
			flags |= 128u;
			break;
		case 4:
			DAT_84_2.FUN_51CC0();
			break;
		}
		return 0u;
	}
}
