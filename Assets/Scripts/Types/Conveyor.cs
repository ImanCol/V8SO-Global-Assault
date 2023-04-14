public class Conveyor : Destructible
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
		switch (arg1)
		{
		case 1:
			GameManager.instance.FUN_30CB0(this, DAT_19 + 120);
			break;
		case 0:
		{
			uint num = GameManager.instance.FUN_1E7A8(screen);
			if (num == 0)
			{
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 120);
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
			else
			{
				GameManager.instance.FUN_1E2C8(DAT_18, num);
			}
			break;
		}
		case 2:
		{
			uint num = GameManager.instance.FUN_1E7A8(screen);
			if (num == 0)
			{
				GameManager.instance.FUN_30CB0(this, 120);
				break;
			}
			if (DAT_18 != 0)
			{
				return 0u;
			}
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 2, num, param5: true);
			break;
		}
		default:
			return base.UpdateW(arg1, arg2);
		}
		return 0u;
	}
}
