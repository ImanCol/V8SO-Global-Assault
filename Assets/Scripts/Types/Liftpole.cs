public class Liftpole : Destructible
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
		if (arg1 == 1)
		{
			SKIRESRT.instance.FUN_13F8(this);
			return 0u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
