public class Revolver2 : VigObject
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
			vr.z += maxHalfHealth * 2;
			if (arg2 != 0)
			{
				ApplyTransformation();
			}
			short num = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num;
			if (num == 0)
			{
				FUN_30BA8();
			}
		}
		return 0u;
	}
}
