public class Billboard : Destructible
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
			int num = (int)GameManager.FUN_2AC5C();
			num = num * 3 >> 15;
			FUN_2C01C();
			GameManager.instance.FUN_2FEE8(this, (ushort)(num * 60));
			tags = (sbyte)num;
			return 0u;
		}
		return base.UpdateW(arg1, arg2);
	}
}
