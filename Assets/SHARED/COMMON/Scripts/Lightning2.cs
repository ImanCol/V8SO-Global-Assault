using UnityEngine;

public enum _LIGHTNING2_TYPE
{
    Default,
    Type1 //FUN_F8 (EXCELSR.DLL)
}
public class Lightning2 : VigObject
{
	public _LIGHTNING2_TYPE state;

	public Lightning2 DAT_88;

	public Lightning3 DAT_8C;

	public ConfigContainer DAT_90;

	public int DAT_94;

	public bool doubleDamage;

	public int chainID;

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
		if (state == _LIGHTNING2_TYPE.Type1)
		{
			if (arg1 == 2)
			{
				if (DAT_94 == 0 || tags == 0 || DAT_84.maxHalfHealth == 0)
				{
					VigObject param = FUN_2CCBC();
					GameManager.instance.FUN_307CC(param);
					return 0u;
				}
				DAT_94--;
				GameManager.instance.FUN_30CB0(this, 180);
				DAT_84.id += 180;
				DAT_84.maxHalfHealth--;
			}
			if (arg1 < 3)
			{
				if (arg1 != 0)
				{
					return 0u;
				}
				VigObject vigObject = DAT_84 = Utilities.FUN_2CD78(this);
				if (vigObject == null || (vigObject = Utilities.FUN_2CD78(vigObject)) == null)
				{
					VigObject param = FUN_2CCBC();
					GameManager.instance.FUN_308C4(param);
					return uint.MaxValue;
				}
				Lightning2 lightning = this;
				vigObject = lightning.DAT_80;
				if (vigObject != null)
				{
					while ((vigObject.flags & 0x4000) == 0)
					{
						if (lightning.DAT_88 == null)
						{
							VigObject param = FUN_2CCBC();
							GameManager.instance.FUN_308C4(param);
							return uint.MaxValue;
						}
						lightning = lightning.DAT_88;
						vigObject = lightning.DAT_80;
					}
				}
				vigObject = DAT_80;
				Vector3Int position = default(Vector3Int);
				bool flag = true;
				Vector3Int vout;
				if (vigObject == null)
				{
					sbyte b = (sbyte)(DAT_19 - 1);
					DAT_19 = (byte)b;
					if (b != 0)
					{
						return 0u;
					}
					int num = (int)GameManager.FUN_2AC5C();
					Vector3Int vin = default(Vector3Int);
					vin.x = (num - 16384) * 65536;
					uint num2 = GameManager.FUN_2AC5C();
					vin.y = (int)(((num2 & 0x1FFF) - 4096) * 65536);
					num = (int)GameManager.FUN_2AC5C();
					vin.z = (num - 16384) * 65536;
					Utilities.FUN_29FC8(vin, out vout);
					vTransform.rotation = Utilities.FUN_2A724(vout);
					vTransform.rotation.MatrixNormal();
					num = (int)GameManager.FUN_2AC5C();
					int num3 = (num * 327680 >> 15) + 131072;
					num = num3 * vTransform.rotation.V02;
					if (num < 0)
					{
						num += 65535;
					}
					int num4 = num3 * vTransform.rotation.V12;
					vTransform.rotation.V02 = (short)(num >> 16);
					if (num4 < 0)
					{
						num4 += 65535;
					}
					num3 *= vTransform.rotation.V22;
					vTransform.rotation.V12 = (short)(num4 >> 16);
					if (num3 < 0)
					{
						num3 += 65535;
					}
					vTransform.rotation.V22 = (short)(num3 >> 16);
					num = (int)GameManager.FUN_2AC5C();
					DAT_19 = (byte)((num * 10 >> 15) + 5);
				}
				else
				{
					VigObject param2 = Utilities.FUN_2CD78(DAT_84);
					uint num2 = GameManager.FUN_2AC5C();
					lightning = this;
					while (true)
					{
						uint num5 = GameManager.FUN_2AC5C();
						if (DAT_94 == 0)
						{
							lightning.DAT_80.vTransform.position.y -= 682;
						}
						else
						{
							lightning.DAT_80.vTransform.position.y -= 222;
						}
						int x = lightning.DAT_80.vTransform.position.x;
						int num4 = x - 2730;
						if ((num5 & 1) == 0)
						{
							num4 = x + 2730;
						}
						lightning.DAT_80.vTransform.position.x = num4;
						x = lightning.DAT_80.vTransform.position.z;
						num4 = x - 2730;
						if ((num5 & 2) == 0)
						{
							num4 = x + 2730;
						}
						lightning.DAT_80.vTransform.position.z = num4;
						VigObject dAT_ = lightning.DAT_80;
						num4 = (int)GameManager.FUN_2AC5C();
						lightning.DAT_80.FUN_24700((short)((num4 * 511 >> 15) - 255), 0, 0);
						sbyte b = (sbyte)(lightning.DAT_19 - 1);
						lightning.DAT_19 = (byte)b;
						if (b == 0)
						{
							lightning.DAT_19 = 40;
							if (flag)
							{
								num4 = 0;
								int param3 = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E580(param3, GameManager.instance.DAT_C2C, 75, lightning.DAT_80.vTransform.position);
								UIManager.instance.FUN_4E414(lightning.DAT_80.vTransform.position, new Color32(0, 0, byte.MaxValue, 8));
								do
								{
									Throwaway obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Throwaway), 8u) as Throwaway;
									obj.physics1.M0 = 0;
									obj.physics1.M1 = 0;
									obj.physics1.M2 = 0;
									num5 = GameManager.FUN_2AC5C();
									obj.physics1.Z = (int)((num5 & 0xFFF) - 2048);
									x = (int)GameManager.FUN_2AC5C();
									if (x < 0)
									{
										x += 15;
									}
									obj.physics1.W = -(x >> 4);
									num5 = GameManager.FUN_2AC5C();
									obj.physics2.X = (int)((num5 & 0xFFF) - 2048);
									obj.type = 7;
									obj.flags |= 180u;
									short id = base.id;
									num4++;
									obj.state = _THROWAWAY_TYPE.Type3;
									obj.id = id;
									obj.vTransform = GameManager.FUN_2A39C();
									VigObject dAT_2 = lightning.DAT_80;
									obj.vTransform.position = dAT_2.vTransform.position;
									obj.FUN_2D1DC();
									obj.DAT_87 = 1;
									obj.FUN_305FC();
								}
								while (num4 < 5);
							}
						}
						if (((num2 ^ 1) & chainID) != 0L)
						{
							int param3 = doubleDamage ? (-4) : (-2);
							param3 = ((Vehicle)lightning.DAT_80).FUN_3B078(param2, (ushort)DAT_1A, param3, 1u);
							((Vehicle)lightning.DAT_8C.PDAT_74).FUN_39DCC(param3, Lightning.DAT_20, param3: true);
							if (lightning.DAT_80.id < 0)
							{
								GameManager.instance.FUN_15ADC(~lightning.DAT_80.id, 20);
							}
						}
						Vector3Int vin;
						if (flag)
						{
							vin = Utilities.FUN_24304(GameManager.instance.FUN_2CEAC(lightning.DAT_84, lightning.DAT_90), lightning.DAT_80.vTransform.position);
						}
						else
						{
							dAT_ = lightning.DAT_80;
							vin = default(Vector3Int);
							vin.x = dAT_.vTransform.position.x - position.x;
							vin.y = dAT_.vTransform.position.y - position.y;
							vin.z = dAT_.vTransform.position.z - position.z;
							lightning.vTransform.position = position;
						}
						dAT_ = lightning.DAT_80;
						position = dAT_.vTransform.position;
						Utilities.FUN_29FC8(vin, out vout);
						num4 = Utilities.FUN_29E84(vin);
						num4 /= 2;
						if (458752 < num4 && flag)
						{
							break;
						}
						x = num4;
						if (!flag)
						{
							x = 458752;
							if (num4 < 458752)
							{
								x = num4;
							}
						}
						lightning.vTransform.rotation = Utilities.FUN_2A724(vout);
						lightning.vTransform.rotation.MatrixNormal();
						num4 = x * lightning.vTransform.rotation.V02;
						if (num4 < 0)
						{
							num4 += 65535;
						}
						int num6 = x * lightning.vTransform.rotation.V12;
						lightning.vTransform.rotation.V02 = (short)(num4 >> 16);
						if (num6 < 0)
						{
							num6 += 65535;
						}
						x *= lightning.vTransform.rotation.V22;
						lightning.vTransform.rotation.V12 = (short)(num6 >> 16);
						if (x < 0)
						{
							x += 65535;
						}
						lightning.vTransform.rotation.V22 = (short)(x >> 16);
						lightning = lightning.DAT_88;
						flag = false;
						if (lightning == null)
						{
							return 0u;
						}
					}
					lightning.DAT_19 = 5;
					Lightning2 lightning2 = lightning;
					Lightning2 lightning3;
					while ((lightning3 = lightning2) != null)
					{
						lightning2 = lightning3.DAT_88;
						lightning3.DAT_88 = null;
						if (lightning3.DAT_80 != null)
						{
							Lightning3 dAT_8C = lightning3.DAT_8C;
							if (dAT_8C != null && (dAT_8C.flags & 0x3000000) == 0)
							{
								dAT_8C.flags |= 33554432u;
								VigObject param = lightning3.DAT_8C.FUN_2CCBC();
								GameManager.instance.FUN_307CC(param);
								lightning3.DAT_8C = null;
								UnityEngine.Debug.Log("!");
							}
							else
							{
								lightning3.DAT_80.flags &= 4227858431u;
								((Vehicle)lightning3.DAT_80).DAT_F6 &= 65023;
							}
							lightning3.DAT_80 = null;
						}
						if (lightning3 != lightning)
						{
							GameManager.instance.FUN_309A0(lightning3);
						}
					}
					lightning.DAT_80 = null;
				}
			}
			else
			{
				if (arg1 != 4)
				{
					return 0u;
				}
				Lightning2 lightning2 = DAT_88;
				while (lightning2 != null)
				{
					Lightning2 lightning3 = lightning2.DAT_88;
					Lightning3 dAT_8C = lightning2.DAT_8C;
					lightning2.DAT_88 = null;
					if (dAT_8C != null && (dAT_8C.flags & 0x3000000) == 0)
					{
						dAT_8C.flags |= 33554432u;
						VigObject param = lightning2.DAT_8C.FUN_2CCBC();
						GameManager.instance.FUN_307CC(param);
						lightning2.DAT_8C = null;
					}
					else
					{
						lightning2.DAT_80.flags &= 4227858431u;
						((Vehicle)lightning2.DAT_80).DAT_F6 &= 65023;
					}
					lightning2.DAT_80 = null;
					GameManager.instance.FUN_309A0(lightning2);
					lightning2 = lightning3;
				}
				if (DAT_80 != null)
				{
					Lightning3 dAT_8C = DAT_8C;
					if (dAT_8C != null && (dAT_8C.flags & 0x3000000) == 0)
					{
						dAT_8C.flags |= 33554432u;
						VigObject param = DAT_8C.FUN_2CCBC();
						GameManager.instance.FUN_307CC(param);
						DAT_8C = null;
					}
					else
					{
						DAT_80.flags &= 4227858431u;
						((Vehicle)DAT_80).DAT_F6 &= 65023;
					}
					DAT_80 = null;
				}
				if (DAT_84 != null)
				{
					VigObject vigObject = Utilities.FUN_2CD78(DAT_84);
					if (vigObject != null && GameManager.instance.FUN_30134(GameManager.instance.worldObjs, vigObject) != null && DAT_84.maxHalfHealth == 0)
					{
						DAT_84.FUN_3A368();
					}
				}
				GameManager.instance.DAT_1084--;
				if (DAT_18 == 0)
				{
					return 0u;
				}
				GameManager.instance.FUN_1DE78(DAT_18);
			}
		}
		return 0u;
	}
}
