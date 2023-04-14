public class Scoreboard : Destructible
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
		if (arg1 != 2)
		{
			if (2 < arg1)
			{
				if (arg1 != 8)
				{
					return 0u;
				}
				FUN_32B90((uint)arg2);
				return 0u;
			}
			if (arg1 != 1)
			{
				return 0u;
			}
			flags &= 4294967291u;
			FUN_2C01C();
			FUN_2FBC8(0);
			return 0u;
		}
		sbyte b = (sbyte)DAT_19;
		byte b2 = DAT_19 = (byte)(b + 1);
		if (19 < (byte)(b + 1))
		{
			FUN_2C01C();
			FUN_2FBC8(0);
			return 0u;
		}
		int num;
		if ((b2 & 1) == 0)
		{
			FUN_2C01C();
			num = 0;
			goto IL_00da;
		}
		BufferedBinaryReader vAnim = base.vAnim;
		ushort dAT_4A;
		uint num2;
		if (vAnim != null)
		{
			b = tags;
			if (b == 2)
			{
				num = DAT_4A + vAnim.ReadUInt16(0) * 3;
				goto IL_00da;
			}
			if (b < 3)
			{
				if (b == 1)
				{
					dAT_4A = DAT_4A;
					num2 = vAnim.ReadUInt16(0);
					goto IL_00d5;
				}
			}
			else if (b == 3)
			{
				dAT_4A = DAT_4A;
				num2 = (uint)(vAnim.ReadUInt16(0) << 1);
				goto IL_00d5;
			}
		}
		goto IL_00e3;
		IL_00d5:
		num = (int)(dAT_4A + num2);
		goto IL_00da;
		IL_00e3:
		GameManager.instance.FUN_30CB0(this, 30);
		return 0u;
		IL_00da:
		FUN_2FBC8((ushort)num);
		goto IL_00e3;
	}
}
