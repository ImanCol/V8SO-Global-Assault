public class SpeedLimit : VigObject
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
		VigObject self = hit.self;
		if (self.type == 2 && 8392 < self.physics1.W)
		{
			Police police = GameManager.instance.FUN_31994(typeof(Police)) as Police;
			if (police == null)
			{
				return 0u;
			}
			if (police.tags != 0)
			{
				return 0u;
			}
			if (police.DAT_F4 != id)
			{
				return 0u;
			}
			if (!police.GetType().IsSubclassOf(typeof(VigObject)))
			{
				return 0u;
			}
			police.UpdateW(20, self);
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		if (hit.object1 != this)
		{
			return 0u;
		}
		FUN_32B90(self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 < 4)
		{
			if (arg1 != 1)
			{
				return 0u;
			}
			child2.type = 3;
			return 0u;
		}
		if (arg1 != 8)
		{
			return 0u;
		}
		FUN_32B90((uint)arg2);
		return 0u;
	}
}
