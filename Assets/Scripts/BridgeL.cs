public class BridgeL : Destructible
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
		if (arg1 == 9 && arg2 == 0)
		{
			LevelManager.instance.FUN_359FC(screen.x, screen.z, 0u);
			return 0u;
		}
		return base.UpdateW(arg1, arg2);
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		return base.UpdateW(arg1, arg2);
	}
}
