public class Gallow : Destructible
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
		if (arg1 != 1)
		{
			if (arg1 != 2)
			{
				goto IL_0050;
			}
			int param = 1;
			if (DAT_1A == 135)
			{
				param = 2;
			}
			GameManager.instance.FUN_1E8B0(vData.sndList, param, screen);
		}
		int num = (int)GameManager.FUN_2AC5C();
		GameManager.instance.FUN_30CB0(this, (num * 120 >> 15) + 60);
		goto IL_0050;
		IL_0050:
		return base.UpdateW(arg1, arg2);
	}
}
