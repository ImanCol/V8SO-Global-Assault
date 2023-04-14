using UnityEngine;

public class CraneLarge : VigObject
{
	public Vector3Int DAT_88;

	public int DAT_94;

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
		if (!FUN_32B90(hit.self.maxHalfHealth))
		{
			return 0u;
		}
		if ((uint)((byte)tags - 3) < 3u)
		{
			child2.child2.child2.FUN_4ECA0();
		}
		FUN_30BA8();
		FUN_30C68();
		if (DAT_80 != null)
		{
			GameManager.instance.FUN_30CB0(DAT_80, 60);
		}
		if (DAT_84 != null)
		{
			GameManager.instance.FUN_30CB0(DAT_84, 60);
		}
		tags = -1;
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			VigObject child = base.child2;
			VigObject child2 = child.child2;
			switch (((byte)tags - 1) * 16777216 >> 24)
			{
			case 0:
			case 3:
			{
				int num = child.vTransform.position.z + DAT_94;
				child.vTransform.position.z = num;
				int y;
				if (DAT_88.z - num < 0)
				{
					num = DAT_94 - 25;
					y = -1525;
					if (-1526 < num)
					{
						y = 0;
						if (num < 1)
						{
							y = num;
						}
					}
					DAT_94 = y;
				}
				else
				{
					y = DAT_94 + 25;
					if (y < 0)
					{
						num = 0;
					}
					else
					{
						num = 1525;
						if (y < 1526)
						{
							num = y;
						}
					}
					DAT_94 = num;
				}
				bool flag = tags == 1;
				if (id == 121)
				{
					y = 1024;
					if (flag)
					{
						y = 0;
					}
				}
				else
				{
					y = 1024;
					if (!flag)
					{
						y = 0;
					}
				}
				int num3 = y - child2.vr.y;
				num = -8;
				if (-9 < num3)
				{
					num = 8;
					if (num3 < 9)
					{
						num = num3;
					}
				}
				num = child2.vr.y + num;
				child2.vr.y = num;
				if (num * 65536 >> 16 != y || DAT_94 != 0)
				{
					if (arg2 == 0)
					{
						return 0u;
					}
					child2.ApplyRotationMatrix();
					break;
				}
				child2.ApplyRotationMatrix();
				goto IL_04c2;
			}
			case 1:
			case 4:
			{
				int y = child2.vTransform.position.y + 1525;
				child2.vTransform.position.y = y;
				if (y <= DAT_88.y)
				{
					break;
				}
				int param = GameManager.instance.FUN_1DD9C();
				Vector3Int param2 = GameManager.instance.FUN_2CE50(child2);
				GameManager.instance.FUN_1E580(param, vData.sndList, 2, param2);
				int num2 = ((uint)(tags ^ 2) < 1u) ? 1 : 0;
				child = ((id != 120) ? ((num2 == 0) ? DAT_84 : DAT_80) : (((num2 ^ 1) == 0) ? DAT_84 : DAT_80));
				if (child == null)
				{
					goto IL_04ad;
				}
				if (tags == 2)
				{
					VigObject x;
					if (id == 120)
					{
						child = DAT_84;
						GameManager.instance.FUN_30CB0(child, 180);
						x = child.child2;
					}
					else
					{
						child = DAT_80;
						GameManager.instance.FUN_30CB0(child, 180);
						x = child.child2;
						child.DAT_80 = null;
					}
					x.vTransform = GameManager.FUN_2A39C();
					VigObject vigObject2 = x.FUN_2CCBC();
					Utilities.FUN_2CC9C(child2, vigObject2);
					vigObject2.transform.parent = child2.transform;
				}
				else
				{
					VigObject x;
					if (id == 120)
					{
						child = child2.child2;
						x = DAT_80;
						x.DAT_80 = child;
					}
					else
					{
						x = DAT_84;
						child = child2.child2;
					}
					ConfigContainer conf = x.FUN_2C5F4(32768);
					child.vTransform = Utilities.FUN_2C77C(conf);
					VigObject vigObject2 = child.FUN_2CCBC();
					Utilities.FUN_2CC9C(x, vigObject2);
					vigObject2.transform.parent = x.transform;
					GameManager.instance.FUN_30CB0(x, 180);
				}
				goto IL_04c2;
			}
			case 2:
			case 5:
				{
					int num = child2.vTransform.position.y - 1525;
					child2.vTransform.position.y = num;
					if (child2.screen.y <= num)
					{
						break;
					}
					VigObject x = (id != 120) ? DAT_84 : DAT_80;
					if (x != null)
					{
						ConfigContainer configContainer;
						VigObject vigObject;
						if (id == 120)
						{
							configContainer = DAT_80.FUN_2C5F4(32768);
							vigObject = DAT_80;
						}
						else
						{
							configContainer = DAT_84.FUN_2C5F4(32768);
							vigObject = DAT_84;
						}
						Vector3Int v = Utilities.FUN_24148(vigObject.vTransform, configContainer.v3_1);
						DAT_88 = Utilities.FUN_24304(vTransform, v);
						int y = child.screen.y;
						sbyte b = ++tags;
						DAT_88.y -= y;
						if (b == 7)
						{
							GameManager.instance.FUN_1DE78(DAT_18);
							tags = 0;
							DAT_18 = 0;
							FUN_30BA8();
							return 0u;
						}
						break;
					}
					goto IL_04ad;
				}
				IL_04ad:
				tags = 0;
				FUN_30C68();
				FUN_30BA8();
				goto IL_04c2;
				IL_04c2:
				tags++;
				break;
			}
			if (arg2 == 0)
			{
				return 0u;
			}
			Vector3Int param3 = GameManager.instance.FUN_2CE50(child2);
			uint volume = GameManager.instance.FUN_1E7A8(param3);
			GameManager.instance.FUN_1E2C8(DAT_18, volume);
			return 0u;
		}
		case 8:
			if (!FUN_32B90((uint)arg2))
			{
				return 0u;
			}
			if ((uint)((byte)tags - 3) < 3u)
			{
				base.child2.child2.child2.FUN_4ECA0();
			}
			FUN_30BA8();
			FUN_30C68();
			if (DAT_80 != null)
			{
				GameManager.instance.FUN_30CB0(DAT_80, 60);
			}
			if (DAT_84 != null)
			{
				GameManager.instance.FUN_30CB0(DAT_84, 60);
			}
			tags = -1;
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if ((uint)(arg1 - 20) <= 1u)
		{
			if (arg1 == 20)
			{
				DAT_84 = arg2;
			}
			else
			{
				DAT_80 = arg2;
			}
			if (tags != 0)
			{
				return 0u;
			}
			if (DAT_80 == null)
			{
				return 0u;
			}
			if (DAT_84 != null)
			{
				if (id != 120 && DAT_80.DAT_80 == null)
				{
					return 0u;
				}
				DAT_80.FUN_30C68();
				DAT_84.FUN_30C68();
				FUN_30B78();
				sbyte param = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param, vData.sndList, 1, 0u);
				VigObject vigObject;
				VigObject vigObject2;
				if (id == 120)
				{
					vigObject = DAT_84;
					vigObject2 = vigObject.child2;
				}
				else
				{
					vigObject = DAT_80;
					vigObject2 = vigObject.DAT_80;
				}
				Vector3Int v = Utilities.FUN_24148(vigObject.vTransform, vigObject2.vTransform.position);
				DAT_88 = Utilities.FUN_24304(vTransform, v);
				int y = child2.screen.y;
				tags = 1;
				DAT_88.y -= y;
			}
		}
		return 0u;
	}
}
