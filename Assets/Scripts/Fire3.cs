public class Fire3 : VigObject
{
    public enum _FIRE3_TYPE
{
	Default,
	Type1
}

	public _FIRE3_TYPE state;

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
		if (state == _FIRE3_TYPE.Type1)
		{
			uint result;
			if (arg1 == 5)
			{
				FUN_2CCBC();
				base.transform.parent = null;
				result = uint.MaxValue;
				child = LDAT_78[0];
				LDAT_78[0] = this;
			}
			else
			{
				result = 0u;
			}
			return result;
		}
		return 0u;
	}
}
