public class Quake2 : VigObject
{
	public ushort[] DAT_84_2 = new ushort[1024];

	public ushort[] DAT_884 = new ushort[1024];

	public byte[] DAT_1084 = new byte[2048];

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
		case 0:
		{
			int num;
			int num2;
			int num3;
			if (arg2 != 0)
			{
				num = screen.x;
				if (num < 0)
				{
					num += 65535;
				}
				num2 = screen.z;
				if (num2 < 0)
				{
					num2 += 65535;
				}
				int num4 = 0;
				num3 = physics1.X;
				do
				{
					int num5 = 0;
					uint num6 = (uint)((num >> 16) - 16 + num4);
					do
					{
						uint num7 = DAT_1084[num5 + num4 * 32];
						int num8 = (int)(128 - num7);
						int num9 = (int)num7 - (num3 / 2 + 48);
						uint num10 = (uint)(num9 * 128);
						num7 = num10;
						if ((int)num10 < 0)
						{
							num7 = (uint)(num9 * -128);
						}
						ushort num11;
						if ((int)num7 < 4096)
						{
							num9 = (int)((num10 & 0xFFF) * 2);
							num8 = GameManager.DAT_65C90[num9] * num8 * num8;
							if (num8 < 0)
							{
								num8 += 1048575;
							}
							num9 = GameManager.DAT_65C90[num9 + 1];
							if (num9 < 0)
							{
								num9 += 511;
							}
							num11 = (ushort)((num8 >> 20) | ((num9 >> 9) * -2048));
						}
						else
						{
							num11 = 0;
						}
						num9 = num5 * 2 + num4 * 64;
						DAT_84_2[num9 / 2] = num11;
						num9 = (short)num11 - (short)DAT_884[num9 / 2];
						num7 = (uint)((num2 >> 16) - 16 + num5);
						if (num9 != 0)
						{
							VigTerrain.instance.vertices[VigTerrain.instance.chunks[((num7 >> 6) * 4 + (num6 >> 6) * 128) / 4u] * 4096 + ((num6 & 0x3F) * 128 + (num7 & 0x3F) * 2) / 2u] += (ushort)num9;
						}
						num5++;
					}
					while (num5 < 32);
					num4++;
				}
				while (num4 < 32);
				for (int i = 0; i < 1024; i++)
				{
					DAT_884[i] = DAT_84_2[i];
				}
			}
			num = physics1.X + 1;
			physics1.X = num;
			if (num != 257)
			{
				break;
			}
			num = screen.x;
			if (num < 0)
			{
				num += 65535;
			}
			num2 = screen.z;
			if (num2 < 0)
			{
				num2 += 65535;
			}
			num3 = 0;
			do
			{
				int num5 = 0;
				uint num6 = (uint)((num >> 16) - 16 + num3);
				int num4 = num3 << 6;
				do
				{
					short num12 = (short)DAT_884[num4 / 2];
					uint num7 = (uint)((num2 >> 16) - 16 + num5);
					if (num12 != 0)
					{
						VigTerrain.instance.vertices[VigTerrain.instance.chunks[((num7 >> 6) * 4 + (num6 >> 6) * 128) / 4u] * 4096 + ((num6 & 0x3F) * 128 + (num7 & 0x3F) * 2) / 2u] -= (ushort)num12;
					}
					num5++;
					num4 += 2;
				}
				while (num5 < 32);
				num3++;
			}
			while (num3 < 32);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		default:
			return 0u;
		case 1:
		{
			int num = -16;
			int num2 = 16;
			do
			{
				int num3 = -16;
				int num4 = 256;
				do
				{
					byte b = (byte)Utilities.SquareRoot((num * num + num4) * 64);
					DAT_1084[num3 + num2] = b;
					num3++;
					num4 = num3 * num3;
				}
				while (num3 < 16);
				num++;
				num2 += 32;
			}
			while (num < 16);
			break;
		}
		}
		return 0u;
	}
}
