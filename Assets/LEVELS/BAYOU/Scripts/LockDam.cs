public class LockDam : Destructible
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
		{
			int num3 = 227 - id;
			VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.interObjs, num3);
			result = 0u;
			if (vigObject != null)
			{
				if (vigObject.DAT_1A != DAT_1A)
				{
					vigObject = GameManager.instance.FUN_3027C(GameManager.instance.interObjs, num3, vigObject);
				}
				result = 0u;
				if (vigObject != null)
				{
					vigObject.PDAT_74 = this;
					PDAT_74 = vigObject;
				}
			}
			break;
		}
		case 0:
		{
			int num = screen.y - vTransform.position.y;
			uint num2 = GameManager.instance.FUN_1E7A8(screen);
			if (num == 0 || num2 == 0)
			{
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 120);
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
				result = 0u;
				break;
			}
			num /= 15;
			int num3 = (int)(num2 & 0xFFFF) * num;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			GameManager.instance.FUN_1E2C8(DAT_18, (uint)((int)((uint)((int)(num2 >> 16) * num) >> 12 << 16) | (num3 >> 12)));
			result = 0u;
			break;
		}
		case 2:
		{
			int num = screen.y - vTransform.position.y;
			uint num2 = GameManager.instance.FUN_1E7A8(screen);
			if (num == 0 || num2 == 0)
			{
				GameManager.instance.FUN_30CB0(this, 120);
				result = 0u;
				break;
			}
			num /= 15;
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param, vData.sndList, 7, ((uint)((int)(num2 >> 16) * num) >> 12 << 16) | (((uint)((int)num2 * num) >> 12) & 0xFFFF), param5: true);
			FUN_30B78();
			result = 0u;
			break;
		}
		default:
			result = base.UpdateW(arg1, arg2);
			break;
		}
		return result;
	}
}
