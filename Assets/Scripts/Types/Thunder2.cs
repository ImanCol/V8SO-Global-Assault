public class Thunder2 : VigObject
{
	public bool trigger;

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
		switch (arg1)
		{
		case 2:
			if (DAT_18 == 0)
			{
				int num = GameManager.instance.FUN_1DD9C();
				DAT_18 = (sbyte)num;
				int num2 = (int)GameManager.FUN_2AC5C();
				num2 %= 3;
				num2 = ((tags != 0) ? (num2 + 11) : (num2 + 8));
				GameManager.instance.FUN_1E188(num, LevelManager.instance.xobfList[42].sndList, num2);
				trigger = false;
			}
			break;
		case 0:
			if (!GameManager.instance.IsAudioPlaying(DAT_18))
			{
				DAT_18 = 0;
			}
			break;
		}
		return 0u;
	}
}
