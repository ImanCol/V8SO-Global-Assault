public class LaunchRocket2 : VigObject
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
		if (arg1 == 4 && DAT_18 != 0)
		{
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
		}
		return 0u;
	}
}
