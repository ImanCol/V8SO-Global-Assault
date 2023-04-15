public class Silo2 : Destructible
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
			@object.flags |= 32u;
			if (tags != 1)
			{
				return 0u;
			}
			FUN_1860((Vehicle)hit.self);
			tags = 2;
			FUN_2FBC8((ushort)(DAT_4A + vAnim.ReadUInt16(0)));
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 0, hit.self.vTransform.position);
			return 0u;
		}
		if (!FUN_32CF0(hit))
		{
			return 0u;
		}
		FUN_30C68();
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			PDAT_78.flags &= 4294967263u;
			tags = 0;
		}
		else
		{
			if (2 < arg1)
			{
				if (arg1 != 8)
				{
					return 0u;
				}
				if (!FUN_32B90((uint)arg2))
				{
					return 0u;
				}
				FUN_30C68();
				return 0u;
			}
			if (arg1 != 1)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id == 0)
				{
					PDAT_78 = vigObject;
					vigObject.type = 3;
					break;
				}
				vigObject = vigObject.child;
			}
		}
		FUN_2C01C();
		FUN_2FBC8(0);
		return 0u;
	}

	private Silo3 FUN_1860(Vehicle param1)
	{
		Silo3 obj = vData.ini.FUN_2C17C(482, typeof(Silo3), 8u) as Silo3;
		ConfigContainer param2 = FUN_2C5F4(32768);
		obj.vTransform = GameManager.instance.FUN_2CEAC(this, param2);
		obj.screen = obj.vTransform.position;
		obj.flags = 132u;
		obj.type = 8;
		obj.maxHalfHealth = 0;
		obj.id = id;
		VigObject dAT_ = param1.target;
		if (param1.target == null)
		{
			dAT_ = param1;
		}
		obj.DAT_84 = dAT_;
		obj.FUN_3066C();
		return obj;
	}
}
