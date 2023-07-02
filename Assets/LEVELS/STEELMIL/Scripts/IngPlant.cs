public class IngPlant : Destructible
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
		if (FUN_32CF0(hit))
		{
			FUN_30C68();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			IngPlant2 obj = vData.ini.FUN_2C17C(29, typeof(IngPlant2), 8u) as IngPlant2;
			int num = (int)GameManager.FUN_2AC5C();
			obj.screen = Utilities.FUN_24148(v: FUN_2C5F4((ushort)(((num * 3 >> 15) - 32768) & 0xFFFF)).v3_1, transform: vTransform);
			obj.FUN_3066C();
			GameManager.instance.FUN_30CB0(this, 240);
		}
		else if (arg1 < 3)
		{
			if (arg1 == 1)
			{
				GameManager.instance.FUN_30CB0(this, 120);
			}
		}
		else
		{
			if (arg1 != 8)
			{
				return 0u;
			}
			if (FUN_32B90((uint)arg2))
			{
				FUN_30C68();
			}
		}
		return 0u;
	}
}
