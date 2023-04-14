public class NSwitch : VigObject
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
		if (hit.self.type == 2 && (flags & 0x1000000) == 0 && tags != 0)
		{
			VigObject vigObject = GameManager.instance.FUN_31950(113);
			if (vigObject == null || (vigObject.flags & 0x1000000) != 0)
			{
				vigObject = GameManager.instance.FUN_31950(114);
				if (vigObject == null || (vigObject.flags & 0x1000000) != 0)
				{
					vigObject = null;
				}
			}
			int param;
			XOBF_DB vData;
			int param2;
			if (tags == 1)
			{
				param = GameManager.instance.FUN_1DD9C();
				vData = base.vData;
				param2 = 6;
			}
			else
			{
				param = GameManager.instance.FUN_1DD9C();
				vData = base.vData;
				param2 = 5;
			}
			GameManager.instance.FUN_1E580(param, vData.sndList, param2, vTransform.position);
			if (vigObject != null && vigObject.GetType().IsSubclassOf(typeof(VigObject)))
			{
				vigObject.UpdateW(20, tags);
			}
			VigObject vigObject2 = child2;
			if (vigObject2 != null)
			{
				while (vigObject2.id != tags)
				{
					vigObject2 = vigObject2.child;
					if (!(vigObject2 != null))
					{
						break;
					}
				}
				if (vigObject2 != null)
				{
					vigObject2.flags |= 2u;
					vigObject2.FUN_30C20();
				}
			}
			int num = (int)GameManager.FUN_2AC5C();
			GameManager.instance.FUN_30CB0(this, (num * 300 >> 15) + 600);
			tags = 0;
			return 0u;
		}
		if (hit.self.type != 8)
		{
			return 0u;
		}
		FUN_32B90(hit.self.maxHalfHealth);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		int num;
		switch (arg1)
		{
		default:
			return 0u;
		case 1:
		{
			base.tags = 2;
			byte b2 = (byte)GameManager.FUN_2AC5C();
			VigObject vigObject = child2;
			DAT_19 = (byte)(b2 & 1);
			while (vigObject != null)
			{
				vigObject.type = 3;
				vigObject.flags = (uint)(((int)vigObject.flags & -5) | 2);
				vigObject = vigObject.child;
			}
			flags &= 4294967291u;
			num = (int)GameManager.FUN_2AC5C();
			num = num * 180 >> 15;
			break;
		}
		case 2:
		{
			flags &= 4278190079u;
			VigObject vigObject = GameManager.instance.FUN_31950(113);
			if (vigObject == null || (vigObject.flags & 0x1000000) != 0)
			{
				vigObject = GameManager.instance.FUN_31950(114);
				if (vigObject == null || (vigObject.flags & 0x1000000) != 0)
				{
					vigObject = child2;
					if (vigObject != null)
					{
						do
						{
							if (vigObject.id == base.tags)
							{
								vigObject.flags |= 2u;
								vigObject.FUN_30C20();
							}
							vigObject = vigObject.child;
						}
						while (vigObject != null);
						base.tags = 0;
						return 0u;
					}
					base.tags = 0;
					return 0u;
				}
			}
			sbyte tags = base.tags;
			if (tags == 0)
			{
				sbyte b = base.tags = (sbyte)(((DAT_19 ^= 1) != 0) ? 1 : 2);
				vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == base.tags)
					{
						vigObject.flags &= 4294967293u;
						vigObject.FUN_30BF0();
					}
					vigObject = vigObject.child;
				}
			}
			else if (-1 < tags && tags < 3)
			{
				vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id == base.tags)
					{
						vigObject.flags |= 2u;
						vigObject.FUN_30C20();
					}
					vigObject = vigObject.child;
				}
				base.tags = 0;
			}
			num = (int)GameManager.FUN_2AC5C();
			num = (num * 300 >> 15) + 600;
			break;
		}
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
		GameManager.instance.FUN_30CB0(this, num);
		return 0u;
	}
}
