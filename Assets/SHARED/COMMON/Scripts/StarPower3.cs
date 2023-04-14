public class StarPower3 : VigObject
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
		if (arg1 == 0)
		{
			int num = vTransform.rotation.V02;
			if (num < 0)
			{
				num += 3;
			}
			int num2 = vTransform.rotation.V12;
			vTransform.position.x += num >> 2;
			if (num2 < 0)
			{
				num2 += 3;
			}
			num = vTransform.rotation.V22;
			vTransform.position.y += num2 >> 2;
			if (num < 0)
			{
				num += 3;
			}
			vTransform.position.z += num >> 2;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
