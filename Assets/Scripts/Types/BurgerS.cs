public class BurgerS : Destructible
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
			vMesh.DAT_02 = 20;
			return 0u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
