public class Ball : VigObject
{
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
		switch (arg1)
		{
		case 1:
			flags |= 34u;
			break;
		case 10:
			if (arg2 == id && SKIRESRT.instance.DAT_94 < 24)
			{
				Ball2 obj = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Ball2), 0u) as Ball2;
				obj.FUN_2D1DC();
				int num = obj.DAT_58 * 2364;
				if (num < 0)
				{
					num += 4095;
				}
				obj.DAT_58 = num >> 12;
				obj.id = 1000;
				byte b = obj.DAT_19 = (byte)GameManager.FUN_2AC5C();
				ushort maxFullHealth = base.maxFullHealth;
				obj.flags |= 384u;
				obj.maxHalfHealth = maxFullHealth;
				obj.screen = screen;
				obj.physics1.Y = -3051;
				num = obj.DAT_58 * 12867;
				if (num < 0)
				{
					num += 4095;
				}
				obj.physics2.M2 = (short)(16777216 / (num >> 12));
				obj.ApplyTransformation();
				obj.FUN_305FC();
				SKIRESRT.instance.DAT_94++;
			}
			break;
		}
		return 0u;
	}
}
