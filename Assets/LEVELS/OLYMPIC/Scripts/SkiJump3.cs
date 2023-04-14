public class SkiJump3 : VigObject
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
			((VigCamera)PDAT_74).DAT_90 = -256;
			GameManager.instance.FUN_308C4(this);
		}
		return 0u;
	}
}
