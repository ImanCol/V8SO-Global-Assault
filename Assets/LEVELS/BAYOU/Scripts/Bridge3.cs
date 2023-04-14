public class Bridge3 : Destructible
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
			GameManager.instance.FUN_30CB0(this, 150);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			child2.child.child.child.vTransform.position.y += 32768;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2))
		{
			GameManager.instance.FUN_30CB0(this, 150);
		}
		return 0u;
	}
}
