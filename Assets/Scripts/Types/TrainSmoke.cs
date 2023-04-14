public class TrainSmoke : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 0)
		{
			vTransform.position.y -= 1525;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
