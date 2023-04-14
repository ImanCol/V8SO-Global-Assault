public class Invasion2 : VigObject
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
		uint result;
		if (arg1 == 0)
		{
			short m = physics2.M3;
			if (physics2.M3 == 0)
			{
				vTransform.position.x += physics1.Z;
				vTransform.position.y += physics1.W;
				vTransform.position.z += physics2.X;
				result = 0u;
			}
			else
			{
				physics2.M3 = (short)(m - 1);
				result = 0u;
				if (m == 1)
				{
					flags &= 4294967293u;
					FUN_30BF0();
					result = 0u;
				}
			}
		}
		else
		{
			result = 0u;
		}
		return result;
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
