public class Furnace4 : VigObject
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
			vTransform.position.x += physics1.Z;
			vTransform.position.z += physics2.X;
			short num = (short)IDAT_78;
			vTransform.position.y += physics1.W;
			physics1.W += 90;
			IDAT_78 = num - 68;
			vTransform.rotation.V22 = num;
			vTransform.rotation.V11 = num;
			vTransform.rotation.V00 = num;
			if (num - 68 < 205)
			{
				VigObject param = FUN_2CCBC();
				GameManager.instance.FUN_307CC(param);
				return uint.MaxValue;
			}
		}
		return 0u;
	}
}
