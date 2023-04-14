public class ParkingMeter : VigObject
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
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if (FUN_32B90(hit.self.maxHalfHealth))
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 5, vTransform.position);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 8)
		{
			return 0u;
		}
		if (FUN_32B90((uint)arg2))
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 5, vTransform.position);
		}
		return 0u;
	}
}