public class Disco3 : VigObject
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
			vAnim = null;
			return uint.MaxValue;
		}
		return 0u;
	}
}
