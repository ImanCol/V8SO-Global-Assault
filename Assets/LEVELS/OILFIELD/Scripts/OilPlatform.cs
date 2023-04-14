public class OilPlatform : VigObject
{
	public bool DAT_A0_2;

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
		if (hit.self.type == 2)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			if (tags == 1)
			{
				if (hit.object1.id != 1)
				{
					return 0u;
				}
				if ((flags & 0x80) == 0)
				{
					return 0u;
				}
				DAT_18 = 0;
				tags = 0;
				FUN_30BA8();
			}
			else
			{
				if (hit.collider1.ReadUInt16(2) == 0)
				{
					return 0u;
				}
				if ((flags & 0x80) != 0)
				{
					return 0u;
				}
			}
			GameManager.instance.FUN_30CB0(this, 30);
			return 0u;
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		Destruction(hit.self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			VigObject vigObject = child2;
			while (vigObject != null && vigObject.id != 1)
			{
				vigObject = vigObject.child;
			}
			PDAT_74 = vigObject;
			type = 4;
			maxHalfHealth = 1000;
			maxFullHealth = 1000;
			if (vigObject != null)
			{
				vigObject.vTransform.position.y = GameManager.instance.DAT_DB0 - (screen.y - 20480);
				flags |= 64u;
			}
			vigObject = child2;
			while (vigObject != null)
			{
				vData.FUN_1F288(51u, vigObject.vMesh);
				vData.FUN_1F288(52u, vigObject.vMesh);
				vigObject = vigObject.child;
			}
			GameManager.instance.FUN_30CB0(this, 10);
			break;
		}
		case 2:
			if (DAT_A0_2)
			{
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					vigObject.vMesh.DAT_1C[0] = 51;
					vigObject.vMesh.DAT_1C[0] = 51;
					vigObject = vigObject.child;
				}
			}
			else
			{
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					vigObject.vMesh.DAT_1C[0] = 52;
					vigObject.vMesh.DAT_1C[0] = 52;
					vigObject = vigObject.child;
				}
			}
			DAT_A0_2 = !DAT_A0_2;
			GameManager.instance.FUN_30CB0(this, 60);
			break;
		case 8:
			Destruction((uint)arg2);
			break;
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		case 9:
			if (arg2 == 0)
			{
				if ((flags & 0x80) != 0)
				{
					FUN_30BA8();
				}
				FUN_30C68();
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
				tags = -1;
			}
			break;
		}
		return 0u;
	}

	private void Destruction(uint param1)
	{
		if (FUN_32B90(param1))
		{
			Orca obj = LevelManager.instance.xobfList[42].ini.FUN_2C17C(22, typeof(Orca), 8u) as Orca;
			obj.screen = vTransform.position;
			obj.screen.z -= 16777216;
			obj.tags = 1;
			obj.type = 4;
			obj.FUN_3066C();
			obj.ApplyTransformation();
			Pickup pickup = LevelManager.instance.FUN_4AD24(7);
			pickup.screen = vTransform.position;
			pickup.screen.y += 221184;
			pickup.ApplyTransformation();
			pickup.type = 3;
			pickup.flags = (uint)(((int)pickup.flags & -9) | 0x380);
			pickup.FUN_305FC();
		}
	}
}
