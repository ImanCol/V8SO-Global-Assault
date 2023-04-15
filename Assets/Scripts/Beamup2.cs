public class Beamup2 : VigObject
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
		switch (arg1)
		{
		case 0:
			vr.x += 91;
			vr.y += 68;
			if (arg2 != 0)
			{
				ApplyTransformation();
			}
			break;
		case 1:
			type = 3;
			flags = 132u;
			break;
		}
		return 0u;
	}
}