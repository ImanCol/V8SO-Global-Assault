public class HQ : Destructible
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
		VigObject @object = hit.object1;
		if (@object.type == 3 && hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			int param = 116;
			if (vehicle.physics1.X < 0)
			{
				param = 117;
			}
			VigObject vigObject = GameManager.instance.FUN_318D0(param);
			vigObject.FUN_2FBC8(vigObject.vAnim.ReadUInt16(0));
			vigObject.tags = 1;
			GameManager.instance.FUN_30CB0(vigObject, 600);
			GameManager.instance.FUN_30CB0(this, 600);
			@object.flags |= 32u;
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 0, vehicle.vTransform.position);
			return 0u;
		}
		if (FUN_32CF0(hit))
		{
			FUN_30C68();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			child2.flags &= 4294967263u;
		}
		else if (arg1 < 3)
		{
			if (arg1 == 1)
			{
				child2.type = 3;
			}
		}
		else
		{
			if (arg1 != 8)
			{
				return 0u;
			}
			if (FUN_32B90((uint)arg2))
			{
				FUN_30C68();
			}
		}
		return 0u;
	}
}
