public class RailSwitch : VigObject
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
		if ((flags & 0x80) != 0)
		{
			return 0u;
		}
		byte b = (byte)((byte)tags ^ 1);
		tags = (sbyte)b;
		SteelMil.instance.DAT_4618[id - 1000] = b;
		FUN_30B78();
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, vData.sndList, 5, screen);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		VigObject child;
		switch (arg1)
		{
		case 1:
			return 0u;
		default:
			return 0u;
		case 0:
			{
				child = child2;
				if (tags == 0)
				{
					short num = (short)(child.vr.z - 16);
					child.vr.z = num;
					if (-513 >= num)
					{
						goto IL_0064;
					}
				}
				else
				{
					short num = (short)(child.vr.z + 16);
					child.vr.z = num;
					if (num >= 513)
					{
						goto IL_0064;
					}
				}
				goto IL_006b;
			}
			IL_0064:
			FUN_30BA8();
			goto IL_006b;
			IL_006b:
			if (arg2 != 0)
			{
				child.ApplyTransformation();
			}
			return 0u;
		}
	}
}
