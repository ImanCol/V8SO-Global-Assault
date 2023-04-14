public class GondPole : Destructible
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
			OLYMPIC oLYMPIC = (OLYMPIC)LevelManager.instance.level;
			OLYMPIC.FUN_CCC(oLYMPIC.DAT_80_2, oLYMPIC.pole1M, this);
		}
		return base.UpdateW(arg1, arg2);
	}
}
