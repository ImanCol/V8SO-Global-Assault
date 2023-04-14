public class ContBuilding : Destructible
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
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				vigObject.maxHalfHealth = 75;
				vigObject = vigObject.child;
			}
		}
		return base.UpdateW(arg1, arg2);
	}
}
