public class BridgeS : Destructible
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
		if (arg1 == 9 && arg2 != 0)
		{
			LevelManager.instance.FUN_518DC(screen, -1).DAT_08 = ushort.MaxValue;
			if (id == 112)
			{
				LevelManager.instance.FUN_359FC(screen.x, screen.z, 0u);
			}
		}
		return 0u;
	}
}
