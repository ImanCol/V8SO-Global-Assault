public class Meteorite3 : VigObject
{
	public int DAT_80_2;

	public ushort[] DAT_84_2 = new ushort[576];

	public short[] DAT_504 = new short[576];

	public byte[] DAT_984 = new byte[576];

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
			int num4;
			if (arg2 != 0)
			{
				num = DAT_80_2;
				if (-1 < num)
				{
					num2 = screen.x;
					if (num2 < 0)
					{
						num2 += 65535;
					}
					num3 = screen.z;
					if (num3 < 0)
					{
						num3 += 65535;
					}
					num4 = 0;
					int num5 = 0;
					int num6 = 0;
					do
					{
						int num7 = 0;
						uint num8 = (uint)((num2 >> 16) - 12 + num4);
						int num9 = num5;
						do
						{
							uint num10 = DAT_984[num7 + num6];
							int num11 = (int)(128 - num10);
							num11 = num11 * num11 * 3;
							if (num11 < 0)
							{
								num11 += 3;
							}
							int num12 = (int)num10 - (num / 2 + 48);
							uint num13 = (uint)(num12 * 128);
							num10 = num13;
							if ((int)num13 < 0)
							{
								num10 = (uint)(num12 * -128);
							}
							ushort num14;
							if ((int)num10 < 4096)
							{
								num12 = (int)((num13 & 0xFFF) * 4);
								num11 = Utilities.DAT_65C90[num12 / 2] * (num11 >> 2);
								if (num11 < 0)
								{
									num11 += 1048575;
								}
								num12 = Utilities.DAT_65C90[num12 / 2 + 1];
								if (num12 < 0)
								{
									num12 += 511;
								}
								num14 = (ushort)((ushort)(num11 >> 20) | ((short)(num12 >> 9) * -2048));
							}
							else
							{
								num14 = 0;
							}
							DAT_84_2[num9 / 2] = num14;
							num11 = (short)num14 - DAT_504[num9 / 2];
							num10 = (uint)((num3 >> 16) - 12 + num7);
							if (num11 != 0)
							{
								GameManager.instance.terrain.vertices[GameManager.instance.terrain.chunks[((num10 >> 6) * 4 + (num8 >> 6) * 128) / 4u] * 4096 + ((num8 & 0x3F) * 128 + (num10 & 0x3F) * 2) / 2u] += (ushort)num11;
							}
							num7++;
							num9 += 2;
						}
						while (num7 < 24);
						num5 += 48;
						num4++;
						num6 += 24;
					}
					while (num4 < 24);
					for (int i = 0; i < 576; i++)
					{
						DAT_504[i] = (short)DAT_84_2[i];
					}
				}
			}
			if (++DAT_80_2 != 257)
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
			num4 = 0;
			do
			{
				int num5 = 0;
				uint num8 = (uint)((num >> 16) - 12 + num3);
				int num6 = num4;
				do
				{
					short num15 = DAT_504[num6 / 2];
					uint num10 = (uint)((num2 >> 16) - 12 + num5);
					if (num15 != 0)
					{
						GameManager.instance.terrain.vertices[GameManager.instance.terrain.chunks[((num10 >> 6) * 4 + (num8 >> 6) * 128) / 4u] * 4096 + ((num8 & 0x3F) * 128 + (num10 & 0x3F) * 2) / 2u] -= (ushort)num15;
					}
					num5++;
					num6 += 2;
				}
				while (num5 < 24);
				num3++;
				num4 += 48;
			}
			while (num3 < 24);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		default:
			return 0u;
		case 1:
		{
			int num = -12;
			int num2 = 12;
			do
			{
				int num3 = -12;
				int num4 = 144;
				do
				{
					byte b = (byte)Utilities.SquareRoot((num * num + num4) * 100);
					DAT_984[num3 + num2] = b;
					num3++;
					num4 = num3 * num3;
				}
				while (num3 < 12);
				num++;
				num2 += 24;
			}
			while (num < 12);
			break;
		}
		}
		return 0u;
	}
}
