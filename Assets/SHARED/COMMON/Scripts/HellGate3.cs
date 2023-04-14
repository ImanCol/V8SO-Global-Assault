public class HellGate3 : VigObject
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
		if (arg1 == 2)
		{
			VigObject param = FUN_2CCBC();
			GameManager.instance.FUN_307CC(param);
			return uint.MaxValue;
		}
		return 0u;
	}
}
