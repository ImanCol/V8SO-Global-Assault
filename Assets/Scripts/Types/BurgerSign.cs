public class BurgerSign : Destructible
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
			FUN_30BA8();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			flags |= 128u;
			short y = (short)GameManager.FUN_2AC5C();
			child2.vr.y = y;
			break;
		}
		case 0:
			if (arg2 != 0)
			{
				child2.vr.y += arg2 * 4096 / 240;
				child2.ApplyTransformation();
			}
			break;
		default:
			return 0u;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				FUN_30BA8();
			}
			break;
		}
		return 0u;
	}
}