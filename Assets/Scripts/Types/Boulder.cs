using UnityEngine;

public class Boulder : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		Boulder boulder = new GameObject().AddComponent<Boulder>();
		boulder.vData = arg1;
		boulder.DAT_1A = (short)arg2;
		return boulder;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 8)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			flags |= 34u;
		}
		else
		{
			if (arg1 != 10)
			{
				return 0u;
			}
			if ((flags & 1) != 0)
			{
				return 0u;
			}
			Boulder2 boulder = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Boulder2), 0u) as Boulder2;
			int num = (int)GameManager.FUN_2AC5C();
			short num2 = (short)vr.y;
			boulder.FUN_2D1DC();
			int num3 = boulder.DAT_58 * 2364;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			boulder.DAT_58 = num3 >> 12;
			boulder.id = 1000;
			byte b = boulder.DAT_19 = (byte)GameManager.FUN_2AC5C();
			ushort maxFullHealth = base.maxFullHealth;
			boulder.flags |= 1160u;
			boulder.maxFullHealth = maxFullHealth;
			boulder.maxHalfHealth = maxFullHealth;
			boulder.screen = screen;
			boulder.physics1.Y = -3051;
			num3 = ((num2 + (num << 8 >> 15) - 128) & 0xFFF) * 2;
			num = GameManager.DAT_65C90[num3] * 3051;
			if (num < 0)
			{
				num += 4095;
			}
			boulder.physics1.X = num >> 12;
			num = GameManager.DAT_65C90[num3 + 1] * 3051;
			if (num < 0)
			{
				num += 4095;
			}
			boulder.physics1.Z = num >> 12;
			num = boulder.DAT_58 * 12867;
			if (num < 0)
			{
				num += 4095;
			}
			boulder.physics2.M2 = (short)(16777216 / (num >> 12));
			boulder.FUN_4C9C8();
			boulder.ApplyTransformation();
			boulder.FUN_305FC();
			boulder.FUN_2C7D0();
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 11, boulder.vTransform.position);
			GameManager.instance.FUN_30CB0(this, 300);
			GameManager.instance.FUN_30080(CANYNLND.instance.DAT_1298, boulder);
			CANYNLND.instance.DAT_12A4++;
		}
		return 0u;
	}
}