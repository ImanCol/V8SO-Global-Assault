using System.Collections.Generic;

public class GloryRockets : VigObject
{
	private bool isLeader;

	public List<Biker2> bikers = new List<Biker2>();

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
		if (arg1 != 0)
		{
			if (arg1 != 4)
			{
				if (arg1 == 14)
				{
					return 6u;
				}
			}
			else if (isLeader && bikers.Count > 0 && maxHalfHealth != 0)
			{
				GameManager.instance.FUN_308C4(bikers[0].weapons[0].FUN_2CCBC());
				GameManager.instance.FUN_308C4(bikers[1].weapons[0].FUN_2CCBC());
				bikers.Clear();
			}
			return 0u;
		}
		FUN_42330(arg2);
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			result = 0u;
			break;
		case 1:
			maxHalfHealth = 3;
			flags |= 16384u;
			if (arg2.type == 2 && GameManager.instance.experimentalDakota)
			{
				List<VigTuple> worldObjs = GameManager.instance.worldObjs;
				isLeader = true;
				for (int j = 0; j < worldObjs.Count; j++)
				{
					VigObject vObject = worldObjs[j].vObject;
					if (!(vObject != null) || vObject.type != 13 || vObject.id != arg2.id)
					{
						continue;
					}
					Biker2 biker = (Biker2)vObject;
					ConfigContainer configContainer = biker.FUN_4AE5C(7);
					if (configContainer == null)
					{
						continue;
					}
					VigObject vigObject3 = biker.FUN_4AE94(7);
					if (vigObject3 != null)
					{
						if (!bikers.Contains(biker) && biker.weapons[0] == null)
						{
							bikers.Add(biker);
						}
						Utilities.FUN_2CA94(biker, configContainer, vigObject3);
						vigObject3.transform.parent = biker.transform;
						if (biker.weapons[0] == null)
						{
							biker.weapons[0] = vigObject3;
						}
						else
						{
							biker.weapons[0].UpdateW(20, vigObject3);
						}
					}
				}
			}
			goto default;
		default:
			result = 0u;
			break;
		case 12:
			if (!GameManager.instance.experimentalDakota)
			{
				if ((flags & 0x80) != 0)
				{
					return 0u;
				}
				int num2 = 0;
				short num3 = 1;
				VigObject vigObject = child2;
				do
				{
					VigObject child = vigObject.child;
					GloryRocket gloryRocket = vigObject.vData.ini.FUN_2C17C((ushort)vigObject.DAT_1A, typeof(GloryRocket), 0u) as GloryRocket;
					gloryRocket.id = 3;
					gloryRocket.vTransform = vigObject.vTransform;
					gloryRocket.screen = vigObject.vTransform.position;
					gloryRocket.type = 8;
					gloryRocket.maxHalfHealth = 100;
					if (((Vehicle)arg2).doubleDamage != 0)
					{
						gloryRocket.maxHalfHealth = 200;
					}
					gloryRocket.DAT_19 = (byte)num2;
					gloryRocket.DAT_80 = arg2;
					gloryRocket.flags |= 1610612768u;
					VigObject dAT_ = ((Vehicle)arg2).target;
					if (((Vehicle)arg2).target == null)
					{
						dAT_ = arg2;
					}
					gloryRocket.DAT_84 = dAT_;
					gloryRocket.physics2.M3 = num3;
					gloryRocket.FUN_30B78();
					if (maxHalfHealth < 2)
					{
						VigObject obj = vigObject.FUN_2CCBC();
						GameManager.instance.FUN_2C4B4(obj);
					}
					Utilities.FUN_2CC48(this, gloryRocket);
					Utilities.ParentChildren(this, this);
					GameManager.instance.DAT_1084++;
					int num = (int)GameManager.FUN_2AC5C();
					num3 = (short)(num3 + 15);
					num2++;
					gloryRocket.vr.x = 4096 / ((num * 15 >> 15) + 15);
					GameManager.instance.FUN_30CB0(gloryRocket, 480);
					vigObject = child;
				}
				while (num2 < 3);
				DAT_19 = 0;
				maxHalfHealth--;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
			}
			else
			{
				if ((flags & 0x80) != 0)
				{
					return 0u;
				}
				short num3 = 1;
				VigObject vigObject = GetRocket((int)maxHalfHealth % 3);
				GloryRocket gloryRocket = vigObject.vData.ini.FUN_2C17C((ushort)vigObject.DAT_1A, typeof(GloryRocket), 0u) as GloryRocket;
				gloryRocket.id = 3;
				gloryRocket.vTransform = vigObject.vTransform;
				gloryRocket.screen = vigObject.vTransform.position;
				gloryRocket.type = 8;
				gloryRocket.maxHalfHealth = 100;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					gloryRocket.maxHalfHealth = 200;
				}
				gloryRocket.DAT_19 = 0;
				gloryRocket.DAT_80 = arg2;
				gloryRocket.flags |= 1610612768u;
				VigObject dAT_ = ((Vehicle)arg2).target;
				if (((Vehicle)arg2).target == null)
				{
					dAT_ = arg2;
				}
				gloryRocket.DAT_84 = dAT_;
				gloryRocket.physics2.M3 = num3;
				gloryRocket.FUN_30B78();
				if (maxHalfHealth < 4)
				{
					VigObject obj = vigObject.FUN_2CCBC();
					GameManager.instance.FUN_2C4B4(obj);
				}
				Utilities.FUN_2CC48(this, gloryRocket);
				Utilities.ParentChildren(this, this);
				GameManager.instance.DAT_1084++;
				int num = (int)GameManager.FUN_2AC5C();
				num3 = (short)(num3 + 15);
				gloryRocket.vr.x = 4096 / ((num * 15 >> 15) + 15);
				GameManager.instance.FUN_30CB0(gloryRocket, 480);
				vigObject = ((GloryRockets)bikers[0].weapons[0]).GetRocket((maxHalfHealth + 1) % 3);
				gloryRocket = (vigObject.vData.ini.FUN_2C17C((ushort)vigObject.DAT_1A, typeof(GloryRocket), 0u) as GloryRocket);
				gloryRocket.id = 3;
				gloryRocket.vTransform = vigObject.vTransform;
				gloryRocket.screen = vigObject.vTransform.position;
				gloryRocket.type = 8;
				gloryRocket.maxHalfHealth = 100;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					gloryRocket.maxHalfHealth = 200;
				}
				gloryRocket.DAT_19 = 1;
				gloryRocket.DAT_80 = arg2;
				gloryRocket.flags |= 1610612768u;
				dAT_ = ((Vehicle)arg2).target;
				if (((Vehicle)arg2).target == null)
				{
					dAT_ = arg2;
				}
				gloryRocket.DAT_84 = dAT_;
				gloryRocket.physics2.M3 = num3;
				gloryRocket.FUN_30B78();
				if (maxHalfHealth < 4)
				{
					VigObject obj = vigObject.FUN_2CCBC();
					GameManager.instance.FUN_2C4B4(obj);
				}
				Utilities.FUN_2CC48(bikers[0].weapons[0], gloryRocket);
				Utilities.ParentChildren(bikers[0].weapons[0], bikers[0].weapons[0]);
				GameManager.instance.DAT_1084++;
				num = (int)GameManager.FUN_2AC5C();
				num3 = (short)(num3 + 15);
				gloryRocket.vr.x = 4096 / ((num * 15 >> 15) + 15);
				GameManager.instance.FUN_30CB0(gloryRocket, 480);
				vigObject = ((GloryRockets)bikers[1].weapons[0]).GetRocket((maxHalfHealth + 2) % 3);
				gloryRocket = (vigObject.vData.ini.FUN_2C17C((ushort)vigObject.DAT_1A, typeof(GloryRocket), 0u) as GloryRocket);
				gloryRocket.id = 3;
				gloryRocket.vTransform = vigObject.vTransform;
				gloryRocket.screen = vigObject.vTransform.position;
				gloryRocket.type = 8;
				gloryRocket.maxHalfHealth = 100;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					gloryRocket.maxHalfHealth = 200;
				}
				gloryRocket.DAT_19 = 2;
				gloryRocket.DAT_80 = arg2;
				gloryRocket.flags |= 1610612768u;
				dAT_ = ((Vehicle)arg2).target;
				if (((Vehicle)arg2).target == null)
				{
					dAT_ = arg2;
				}
				gloryRocket.DAT_84 = dAT_;
				gloryRocket.physics2.M3 = num3;
				gloryRocket.FUN_30B78();
				if (maxHalfHealth < 4)
				{
					VigObject obj = vigObject.FUN_2CCBC();
					GameManager.instance.FUN_2C4B4(obj);
				}
				Utilities.FUN_2CC48(bikers[1].weapons[0], gloryRocket);
				Utilities.ParentChildren(bikers[1].weapons[0], bikers[1].weapons[0]);
				GameManager.instance.DAT_1084++;
				num = (int)GameManager.FUN_2AC5C();
				gloryRocket.vr.x = 4096 / ((num * 15 >> 15) + 15);
				GameManager.instance.FUN_30CB0(gloryRocket, 480);
				DAT_19 = 0;
				maxHalfHealth--;
				bikers[0].weapons[0].maxHalfHealth = maxHalfHealth;
				bikers[1].weapons[0].maxHalfHealth = maxHalfHealth;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
			}
			result = 780u;
			if (arg2.id < 0)
			{
				result = 390u;
			}
			break;
		case 13:
			result = 0u;
			if (GameManager.instance.DAT_1084 == 0)
			{
				int num = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
				if (num < 4096000)
				{
					result = ((614400 < num) ? 1u : 0u);
				}
			}
			break;
		case 14:
			result = 6u;
			break;
		case 16:
			if (!GameManager.instance.experimentalDakota)
			{
				int num = child2.id;
				if (num != 0)
				{
					VigObject vigObject2 = arg2.child2;
					for (short num3 = vigObject2.id; num3 != num - 1; num3 = vigObject2.id)
					{
						vigObject2 = vigObject2.child;
					}
					VigObject obj = vigObject2.FUN_2CCBC();
					Utilities.FUN_2CC9C(this, obj);
					Utilities.ParentChildren(this, this);
					return 0u;
				}
			}
			else
			{
				List<short> list = new List<short>();
				VigObject vigObject = child2;
				while (vigObject != null)
				{
					if (vigObject.id != 3)
					{
						list.Add(vigObject.id);
					}
					vigObject = vigObject.child;
				}
				VigObject vigObject2 = arg2.child2;
				while (vigObject2 != null)
				{
					if (!list.Contains(vigObject2.id))
					{
						VigObject obj = vigObject2.FUN_2CCBC();
						vigObject2.transform.parent = null;
						Utilities.FUN_2CC9C(this, obj);
						Utilities.ParentChildren(this, this);
						return 0u;
					}
					vigObject2 = vigObject2.child;
				}
			}
			goto default;
		case 20:
		{
			List<short> list = new List<short>();
			List<VigObject> list2 = new List<VigObject>();
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				if (vigObject.id != 3)
				{
					list.Add(vigObject.id);
				}
				vigObject = vigObject.child;
			}
			VigObject vigObject2 = arg2.child2;
			while (vigObject2 != null)
			{
				if (!list.Contains(vigObject2.id))
				{
					list2.Add(vigObject2);
				}
				vigObject2 = vigObject2.child;
			}
			for (int i = 0; i < list2.Count; i++)
			{
				vigObject2 = list2[i];
				VigObject obj = vigObject2.FUN_2CCBC();
				vigObject2.transform.parent = null;
				Utilities.FUN_2CC9C(this, obj);
				Utilities.ParentChildren(this, this);
			}
			GameManager.instance.FUN_308C4(arg2.FUN_2CCBC());
			goto default;
		}
		}
		return result;
	}

	public VigObject GetRocket(int id)
	{
		VigObject vigObject = child2;
		while (vigObject != null)
		{
			if (vigObject.id == id)
			{
				return vigObject;
			}
			vigObject = vigObject.child;
		}
		return null;
	}
}
