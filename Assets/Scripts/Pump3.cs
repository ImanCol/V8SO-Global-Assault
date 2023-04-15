public class Pump3 : Destructible
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
		if (FUN_32CF0(hit) && tags-- == 1 && VALLYFRM.instance.DAT_14C8 < 2)
		{
			VALLYFRM.instance.DAT_14C8++;
			GameManager.instance.FUN_31EDC(1000).FUN_3066C();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			int num = FUN_4DCD8();
			tags = (sbyte)num;
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2) && tags-- == 1 && VALLYFRM.instance.DAT_14C8 < 2)
		{
			VALLYFRM.instance.DAT_14C8++;
			GameManager.instance.FUN_31EDC(1000).FUN_3066C();
		}
		return 0u;
	}
}
