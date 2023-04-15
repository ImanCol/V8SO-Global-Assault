public class FactoryDoor : Destructible
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
		if (!FUN_32CF0(hit))
		{
			return 0u;
		}
		return 1u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		return 0u;
	}
}
