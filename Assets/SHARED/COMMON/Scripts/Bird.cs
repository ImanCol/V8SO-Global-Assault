using System.Collections.Generic;
using UnityEngine;

public class Bird : VigObject
{
	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2)
	{
		Bird bird = new GameObject().AddComponent<Bird>();
		bird.vData = arg1;
		return bird;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 != 0)
		{
			if (arg1 != 4)
			{
				if (arg1 == 10)
				{
					result = 0u;
					if (arg2 == 17443)
					{
						Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
						if (vehicle == null || id != 0)
						{
							return 0u;
						}
						VigObject vigObject;
						if ((vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth) * 3 < vehicle.maxFullHealth)
						{
							List<ushort> list = new List<ushort>();
							list.Add(0);
							vigObject = GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position);
							if (vigObject == null)
							{
								list = new List<ushort>();
								for (int i = 0; i < 3; i++)
								{
									if (vehicle.weapons[i] != null)
									{
										switch (vehicle.weapons[i].tags)
										{
										case 1:
											list.Add(12);
											break;
										case 2:
											list.Add(10);
											break;
										case 3:
											list.Add(11);
											break;
										case 4:
											list.Add(14);
											break;
										case 5:
											list.Add(13);
											break;
										case 6:
											list.Add(15);
											break;
										case 7:
											list.Add(6);
											break;
										}
									}
								}
								vigObject = ((!(vehicle.weapons[1] == null) && !(vehicle.weapons[2] == null)) ? GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position) : GameManager.instance.FUN_34120_2(GameManager.instance.worldObjs, 4261412864u, vehicle.vTransform.position));
								if (vigObject == null)
								{
									int param = GameManager.instance.FUN_1DD9C();
									GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 1);
									return 0u;
								}
							}
						}
						else
						{
							List<ushort> list = new List<ushort>();
							for (int j = 0; j < 3; j++)
							{
								if (vehicle.weapons[j] != null)
								{
									switch (vehicle.weapons[j].tags)
									{
									case 1:
										list.Add(12);
										break;
									case 2:
										list.Add(10);
										break;
									case 3:
										list.Add(11);
										break;
									case 4:
										list.Add(14);
										break;
									case 5:
										list.Add(13);
										break;
									case 6:
										list.Add(15);
										break;
									case 7:
										list.Add(6);
										break;
									}
								}
							}
							vigObject = ((!(vehicle.weapons[1] == null) && !(vehicle.weapons[2] == null)) ? GameManager.instance.FUN_34120_3(GameManager.instance.worldObjs, list, vehicle.vTransform.position) : GameManager.instance.FUN_34120_2(GameManager.instance.worldObjs, 4261412864u, vehicle.vTransform.position));
							if (vigObject == null)
							{
								int param = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 1);
								return 0u;
							}
						}
						VigObject pDAT_ = PDAT_74;
						if ((flags & 0x1000000) != 0 || pDAT_.DAT_19 != 0)
						{
							return 0u;
						}
						pDAT_.DAT_19 = 1;
						VigObject vigObject2 = pDAT_.DAT_84 = vigObject;
						maxHalfHealth--;
						GameManager.instance.FUN_30CB0(pDAT_, 1800);
						result = 900u;
						id = 900;
						if (vehicle.id < 0)
						{
							result = 600u;
							id = 600;
						}
					}
					goto IL_0508;
				}
			}
			else
			{
				GameManager.instance.DAT_1084--;
				if ((flags & 0x1000000) != 0)
				{
					return 0u;
				}
				GameManager.instance.FUN_309A0(PDAT_74);
			}
			result = 0u;
		}
		else
		{
			result = 0u;
			if (tags < 0)
			{
				result = (uint)FUN_4205C();
			}
			else
			{
				VigObject vigObject3 = Utilities.FUN_2CD78(this);
				Bird2 bird = vData.ini.FUN_2C17C(1, typeof(Bird2), 8u) as Bird2;
				if ((flags & 0x1000000) != 0)
				{
					ConfigContainer cCDAT_ = CCDAT_74;
					vTransform.position = cCDAT_.v3_1;
					flags &= 4278190079u;
				}
				bird.id = vigObject3.id;
				VigTransform vigTransform = bird.vTransform = GameManager.instance.FUN_2CDF4(this);
				bird.flags = 164u;
				bird.DAT_80 = vigObject3;
				bird.DAT_94 = this;
				PDAT_74 = bird;
				if (bird.GetType().IsSubclassOf(typeof(VigObject)))
				{
					bird.UpdateW(1, 0);
				}
				bird.FUN_305FC();
				FUN_30BA8();
				result = 0u;
			}
		}
		goto IL_0508;
		IL_0508:
		return result;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		if (arg1 != 1)
		{
			if (arg1 != 12)
			{
				if (arg1 != 13)
				{
					goto IL_0032;
				}
				result = 0u;
				if (GameManager.instance.DAT_1084 == 0 && PDAT_74 != null && PDAT_74.DAT_19 == 0 && ((Vehicle)arg2).target.physics1.W < 1525)
				{
					int num = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
					result = ((409600 < num) ? 1u : 0u);
				}
			}
			else
			{
				VigObject pDAT_ = PDAT_74;
				if ((flags & 0x1000000) != 0 || pDAT_.DAT_19 != 0)
				{
					return 0u;
				}
				pDAT_.DAT_19 = 1;
				VigObject vigObject = ((Vehicle)arg2).target;
				if (vigObject == null)
				{
					vigObject = arg2;
				}
				pDAT_.DAT_84 = vigObject;
				maxHalfHealth--;
				GameManager.instance.FUN_30CB0(pDAT_, 450);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E188(param, vData.sndList, 2);
				GameManager.instance.DAT_1084++;
				result = 900u;
				if (arg2.id < 0)
				{
					result = 600u;
				}
			}
			goto IL_0160;
		}
		FUN_30B78();
		maxHalfHealth = 3;
		flags |= 16384u;
		goto IL_0032;
		IL_0160:
		return result;
		IL_0032:
		result = 0u;
		goto IL_0160;
	}
}
