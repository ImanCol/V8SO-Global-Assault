public class Wave2 : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			FUN_2CCBC();
			base.transform.parent = null;
			GameManager.instance.FUN_2C4B4(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}