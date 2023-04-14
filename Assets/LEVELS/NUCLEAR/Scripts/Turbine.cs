public class Turbine : Destructible
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
		switch (arg1)
		{
		case 1:
		{
			VigObject vigObject2 = child2;
			vigObject2.maxFullHealth = 300;
			vigObject2.maxHalfHealth = 300;
			while (vigObject2 != null)
			{
				if ((uint)((ushort)vigObject2.id - 1) < 2u)
				{
					vigObject2.flags = (uint)(((int)vigObject2.flags & -5) | 2);
				}
				vigObject2 = vigObject2.child;
			}
			break;
		}
		case 2:
			if (base.tags == 1)
			{
				VigObject vigObject2 = child2;
				if (vigObject2 != null)
				{
					while (vigObject2.id != 1)
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
			}
			else
			{
				if (base.tags != 2)
				{
					base.tags = 0;
					return 0u;
				}
				VigObject vigObject2 = child2;
				if (vigObject2 != null)
				{
					while (vigObject2.id != 2)
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
			}
			base.tags = 0;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			break;
		case 9:
			if (arg2 != 0)
			{
				flags |= 16777216u;
			}
			break;
		case 20:
		{
			if (id == 113)
			{
				VigObject vigObject = GameManager.instance.FUN_31950(114);
				if (vigObject != null && vigObject.GetType().IsSubclassOf(typeof(VigObject)))
				{
					vigObject.UpdateW(20, arg2 | 0x100);
				}
			}
			sbyte tags;
			VigObject vigObject2;
			if ((arg2 & 0xFF) == 1)
			{
				if (base.tags == 0)
				{
					vigObject2 = child2;
					while (vigObject2 != null)
					{
						if (vigObject2.id == 1)
						{
							vigObject2.flags &= 4294967293u;
							vigObject2.FUN_30BF0();
							break;
						}
						vigObject2 = vigObject2.child;
					}
					if ((arg2 & 0x100) == 0)
					{
						VigObject vigObject3 = PDAT_78 = FUN_1F78(1);
					}
				}
				else if (base.tags == 2)
				{
					vigObject2 = child2;
					while (vigObject2 != null)
					{
						if (vigObject2.id == 1)
						{
							vigObject2.flags &= 4294967293u;
							vigObject2.FUN_30BF0();
						}
						else if (vigObject2.id == 2)
						{
							vigObject2.flags |= 2u;
							vigObject2.FUN_30C20();
						}
						vigObject2 = vigObject2.child;
					}
					if ((arg2 & 0x100) == 0)
					{
						GameManager.instance.FUN_309A0(PDAT_78);
						PDAT_78 = null;
						VigObject vigObject3 = PDAT_78 = FUN_1F78(1);
					}
				}
				vigObject2 = PDAT_78;
				tags = 1;
			}
			else
			{
				if ((arg2 & 0xFF) != 2)
				{
					return 0u;
				}
				if (base.tags == 0)
				{
					vigObject2 = child2;
					while (vigObject2 != null)
					{
						if (vigObject2.id == 2)
						{
							vigObject2.flags &= 4294967293u;
							vigObject2.FUN_30BF0();
							break;
						}
						vigObject2 = vigObject2.child;
					}
					if ((arg2 & 0x100) == 0)
					{
						VigObject vigObject3 = PDAT_78 = FUN_1F78(2);
					}
				}
				else if (base.tags == 1)
				{
					vigObject2 = child2;
					while (vigObject2 != null)
					{
						if (vigObject2.id == 2)
						{
							vigObject2.flags &= 4294967293u;
							vigObject2.FUN_30BF0();
						}
						else if (vigObject2.id == 1)
						{
							vigObject2.flags |= 2u;
							vigObject2.FUN_30C20();
						}
						vigObject2 = vigObject2.child;
					}
					if ((arg2 & 0x100) == 0)
					{
						GameManager.instance.FUN_309A0(PDAT_78);
						PDAT_78 = null;
						VigObject vigObject3 = PDAT_78 = FUN_1F78(2);
					}
				}
				vigObject2 = PDAT_78;
				tags = 2;
			}
			base.tags = tags;
			if (vigObject2 != null)
			{
				GameManager.instance.FUN_30CB0(vigObject2, 1800);
			}
			GameManager.instance.FUN_30CB0(this, 1800);
			break;
		}
		}
		return 0u;
	}

	private static VigObject FUN_1F78(sbyte param1)
	{
		VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, 400).FUN_31DDC();
		if (vigObject != null)
		{
			Utilities.ParentChildren(vigObject, vigObject);
			vigObject.tags = param1;
			vigObject.FUN_3066C();
		}
		return vigObject;
	}
}
