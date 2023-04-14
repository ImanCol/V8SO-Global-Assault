public class Radar : VigObject
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
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if (FUN_32B90(hit.self.maxHalfHealth))
		{
			FUN_30BA8();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			child2.vr.y += 17;
			if (arg2 != 0)
			{
				child2.ApplyTransformation();
				if ((flags & 0x80) != 0)
				{
					FUN_418(3);
				}
			}
			break;
		case 1:
			maxHalfHealth *= 4;
			maxFullHealth *= 4;
			break;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				FUN_30BA8();
			}
			break;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		case 10:
			switch (arg2)
			{
			case 0:
				FUN_30BA8();
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
				break;
			case 1:
				if ((flags & 0x80) != 0)
				{
					return 0u;
				}
				if (child2 != null)
				{
					FUN_30B78();
					VigMesh vMesh = child2.vMesh;
					vMesh.DAT_00 = (byte)((vMesh.DAT_00 & 0xFB) | 1);
				}
				break;
			}
			break;
		}
		return 0u;
	}

	private void FUN_418(int param1)
	{
		uint num = GameManager.instance.FUN_1E7A8(screen);
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
			sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param2, vData.sndList, param1, num, param5: true);
		}
		else
		{
			GameManager.instance.FUN_1E2C8(DAT_18, num);
		}
	}
}