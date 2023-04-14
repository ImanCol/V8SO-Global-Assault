public class ProjectionBooth : Destructible
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
		uint result;
		switch (arg1)
		{
		case 1:
			GameManager.instance.FUN_30CB0(this, DAT_19 + 120);
			result = 0u;
			break;
		case 0:
			result = 0u;
			if (arg2 != 0)
			{
				int num = (int)GameManager.instance.FUN_1E7A8(screen);
				if (num == 0)
				{
					FUN_30BA8();
					GameManager.instance.FUN_30CB0(this, 120);
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
					result = 0u;
				}
				else
				{
					GameManager.instance.FUN_1E2C8(DAT_18, (uint)num);
					result = 0u;
				}
			}
			break;
		case 2:
		{
			int num = (int)GameManager.instance.FUN_1E7A8(screen);
			if (num == 0)
			{
				GameManager.instance.FUN_30CB0(this, 120);
				result = 0u;
				break;
			}
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 6, (uint)num, param5: true);
			FUN_30B78();
			result = 0u;
			break;
		}
		case 9:
			FUN_30BA8();
			FUN_30C68();
			GameManager.instance.FUN_1DE78(DAT_18);
			result = 0u;
			break;
		default:
			result = base.UpdateW(arg1, arg2);
			break;
		}
		return result;
	}
}
