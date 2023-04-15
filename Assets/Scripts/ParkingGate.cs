public class ParkingGate : Destructible
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
			GameManager.instance.FUN_30CB0(this, 40);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				GameManager.instance.FUN_30CB0(this, 40);
			}
			return 0u;
		case 2:
			flags |= 2u;
			break;
		}
		return base.UpdateW(arg1, arg2);
	}
}