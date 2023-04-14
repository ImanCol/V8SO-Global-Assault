public class Ballistic2 : VigObject
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
			FUN_30C20();
			vAnim = null;
			return uint.MaxValue;
		}
		return 0u;
	}
}
