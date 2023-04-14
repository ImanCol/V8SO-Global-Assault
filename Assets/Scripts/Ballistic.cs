public class Ballistic : VigObject
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
			if (parent == null)
			{
				GameManager.instance.FUN_309A0(this);
				return 4294967294u;
			}
			VigObject param = FUN_2CCBC();
			GameManager.instance.FUN_307CC(param);
			return 4294967294u;
		}
		return 0u;
	}
}
