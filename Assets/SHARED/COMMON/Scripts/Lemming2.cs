public class Lemming2 : VigObject
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
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			physics1.Z = physics1.Z * 3968 >> 12;
			physics1.W = physics1.W * 3968 >> 12;
			physics2.X = physics2.X * 3968 >> 12;
			vr.z += physics2.M3;
			ApplyTransformation();
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
