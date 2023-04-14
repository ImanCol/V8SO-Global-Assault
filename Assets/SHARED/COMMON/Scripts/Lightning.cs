using System.Collections.Generic;
using UnityEngine;

public class Lightning : VigObject
{
	public static Vector3Int DAT_20 = new Vector3Int(0, 0, 0);

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
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			break;
		case 4:
			GameManager.instance.DAT_1084--;
			break;
		case 10:
			arg2 &= 0xFFFF;
			if (arg2 == 16962)
			{
				Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
				if (vehicle == null || id != 0)
				{
					return 0u;
				}
				return CreateLightning(1, vehicle);
			}
			break;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		switch (arg1)
		{
		case 1:
			type = 3;
			maxHalfHealth = 2;
			flags |= 16384u;
			result = 0u;
			break;
		case 0:
			FUN_42330(arg2);
			result = 0u;
			break;
		case 12:
			result = CreateLightning(0, arg2);
			break;
		default:
		{
			result = 0u;
			if (arg1 != 13 || GameManager.instance.DAT_1084 != 0)
			{
				break;
			}
			Vehicle vehicle = (Vehicle)arg2;
			VigObject target = vehicle.target;
			int num = vehicle.vTransform.position.x - target.vTransform.position.x;
			if (num < 0)
			{
				num = -num;
			}
			result = 0u;
			if (num >= 262144)
			{
				break;
			}
			num = vehicle.vTransform.position.y - target.vTransform.position.y;
			if (num < 0)
			{
				num = -num;
			}
			result = 0u;
			if (num < 262144)
			{
				num = vehicle.vTransform.position.z - target.vTransform.position.z;
				if (num < 0)
				{
					num = -num;
				}
				result = (uint)(((262143 < num) ? 1 : 0) ^ 1);
			}
			break;
		}
		}
		return result;
	}

	private uint CreateLightning(int arg1, VigObject arg2)
	{
		int num = (arg2.id >= 0) ? (-1) : GameManager.instance.DAT_1128[~arg2.id];
		VigObject vigObject = null;
		GameManager.instance.DAT_1084++;
		if (arg1 == 0)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param, vData.sndList, 2);
		}
		ConfigContainer param2 = FUN_2C5F4(32768);
		GameManager.instance.FUN_2CF00(out Vector3Int param3, this, param2);
		param2 = FUN_2C5F4(32769);
		GameManager.instance.FUN_2CF00(out Vector3Int param4, this, param2);
		Vector3Int vector3Int = default(Vector3Int);
		vector3Int.x = param3.x / 2 + param4.x / 2;
		vector3Int.y = param3.y / 2 + param4.y / 2;
		vector3Int.z = param3.z / 2 + param4.z / 2;
		DAT_19 = 1;
		maxHalfHealth--;
		uint num2 = 2147418112u;
		if (GameManager.instance.worldObjs.Count > 0)
		{
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject vObject = worldObjs[i].vObject;
				VigObject vigObject2 = vigObject;
				uint num3 = num2;
				if (vObject == arg2 || vObject.type != 2 || (vObject.flags & 0x4004000) != 16384 || ((Vehicle)vObject).shield != 0)
				{
					vigObject = vigObject2;
					num2 = num3;
				}
				else if (0 < vObject.id || GameManager.instance.DAT_1128[~vObject.id] != num)
				{
					Vector3Int v = default(Vector3Int);
					v.x = vObject.vTransform.position.x - vector3Int.x;
					v.y = vObject.vTransform.position.y - vector3Int.y;
					v.z = vObject.vTransform.position.z - vector3Int.z;
					Vector2Int vector2Int = Utilities.FUN_2A1C0(v);
					num3 = (uint)((int)((uint)vector2Int.x >> 16) | (vector2Int.y << 16));
					vigObject2 = vObject;
					if ((int)num3 < (int)num2)
					{
						vigObject = vigObject2;
						num2 = num3;
					}
				}
			}
		}
		Lightning2 lightning = vData.ini.FUN_2C17C(1, typeof(Lightning2), 8u) as Lightning2;
		if (lightning != null)
		{
			arg2.tags = 3;
			lightning.tags = (sbyte)arg1;
			Vector3Int v;
			if (vigObject == null)
			{
				v = new Vector3Int(0, 0, 0);
			}
			else
			{
				v = default(Vector3Int);
				v.x = vigObject.vTransform.position.x - vector3Int.x;
				v.y = vigObject.vTransform.position.y - vector3Int.y;
				v.z = vigObject.vTransform.position.z - vector3Int.z;
			}
			int num4 = v.x;
			if (v.x < 0)
			{
				num4 = v.x + 4095;
			}
			short v2 = arg2.vTransform.rotation.V00;
			int num5 = v.y;
			if (v.y < 0)
			{
				num5 = v.y + 4095;
			}
			short v3 = arg2.vTransform.rotation.V10;
			int num6 = v.z;
			if (v.z < 0)
			{
				num6 = v.z + 4095;
			}
			short v4 = arg2.vTransform.rotation.V20;
			int param = 32768;
			lightning.DAT_84 = this;
			lightning.doubleDamage = (((Vehicle)arg2).doubleDamage != 0);
			lightning.chainID = 1;
			if (0 < (num4 >> 12) * v2 + (num5 >> 12) * v3 + (num6 >> 12) * v4)
			{
				param = 32769;
			}
			Lightning2 pDAT_ = lightning;
			ConfigContainer configContainer = lightning.DAT_90 = FUN_2C5F4((ushort)param);
			num5 = Utilities.FUN_29FC8(Utilities.FUN_2426C(GameManager.instance.FUN_2CEAC(this, configContainer).rotation, new Matrix2x4(v.x, v.y, v.z, 0)), out Vector3Int vout);
			int num7 = num5 / 2;
			if (vigObject == null || 458752 < num7)
			{
				num7 = 458752;
				lightning.DAT_80 = null;
				lightning.DAT_19 = 15;
			}
			else
			{
				Lightning3 lightning2 = vData.ini.FUN_2C17C(3, typeof(Lightning3), 8u) as Lightning3;
				lightning2.type = 3;
				lightning2.flags |= 16u;
				lightning.DAT_19 = 40;
				lightning2.vTransform = GameManager.defaultTransform;
				lightning2.PDAT_74 = vigObject;
				lightning2.PDAT_78 = lightning;
				Utilities.FUN_2CC48(vigObject, lightning2);
				Utilities.ParentChildren(vigObject, vigObject);
				lightning.DAT_8C = lightning2;
				lightning2.FUN_30BF0();
				lightning.DAT_80 = vigObject;
				vigObject.flags |= 67108864u;
				((Vehicle)vigObject).DAT_F6 |= 512;
				param = -100;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					param = -200;
				}
				param = ((Vehicle)vigObject).FUN_3B078(arg2, (ushort)DAT_1A, param, 1u);
				((Vehicle)vigObject).FUN_3A020(param, DAT_20, param3: true);
			}
			VigObject vigObject3 = vData.ini.FUN_2C17C(2, typeof(VigObject), 8u);
			if (vigObject3 != null)
			{
				vigObject3.type = 3;
				vigObject3.flags |= 16u;
				vigObject3.vTransform = GameManager.defaultTransform;
				Utilities.FUN_2CC48(lightning, vigObject3);
				Utilities.ParentChildren(lightning, lightning);
				vigObject3.FUN_30BF0();
			}
			lightning.vTransform.rotation = Utilities.FUN_2A724(vout);
			lightning.vTransform.rotation.MatrixNormal();
			num5 = num7 * lightning.vTransform.rotation.V02;
			if (num5 < 0)
			{
				num5 += 65535;
			}
			num6 = num7 * lightning.vTransform.rotation.V12;
			lightning.vTransform.rotation.V02 = (short)(num5 >> 16);
			if (num6 < 0)
			{
				num6 += 65535;
			}
			num5 = num7 * lightning.vTransform.rotation.V22;
			lightning.vTransform.rotation.V12 = (short)(num6 >> 16);
			if (num5 < 0)
			{
				num5 += 65535;
			}
			lightning.vTransform.rotation.V22 = (short)(num5 >> 16);
			lightning.vTransform.position = configContainer.v3_1;
			lightning.flags = 32u;
			lightning.state = _LIGHTNING2_TYPE.Type1;
			Utilities.FUN_2CC48(this, lightning);
			Utilities.ParentChildren(this, this);
			lightning.FUN_30B78();
			lightning.FUN_30BF0();
			sbyte param5 = lightning.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param5, lightning.vData.sndList, 3, param3, param5: true);
			GameManager.instance.FUN_30CB0(lightning, 180);
			VigObject dAT_ = lightning.DAT_80;
			int num8 = 1;
			while (dAT_ != null)
			{
				uint num3 = 12845056u;
				vigObject = null;
				Vector3Int v5;
				if (GameManager.instance.worldObjs != null)
				{
					List<VigTuple> worldObjs = GameManager.instance.worldObjs;
					for (int j = 0; j < worldObjs.Count; j++)
					{
						VigObject vObject = worldObjs[j].vObject;
						VigObject vigObject2 = vigObject;
						uint num9 = num3;
						if (vObject == arg2 || vObject.type != 2 || (vObject.flags & 0x4004000) != 16384)
						{
							vigObject = vigObject2;
							num3 = num9;
						}
						else if (((Vehicle)vObject).shield == 0 && (0 < vObject.id || GameManager.instance.DAT_1128[~vObject.id] != num))
						{
							dAT_ = lightning.DAT_80;
							v5 = default(Vector3Int);
							v5.x = vObject.vTransform.position.x - dAT_.vTransform.position.x;
							v5.y = vObject.vTransform.position.y - dAT_.vTransform.position.y;
							v5.z = vObject.vTransform.position.z - dAT_.vTransform.position.z;
							Vector2Int vector2Int = Utilities.FUN_2A1C0(v5);
							num9 = (uint)((int)((uint)vector2Int.x >> 16) | (vector2Int.y << 16));
							vigObject2 = vObject;
							num7 = (int)num9;
							if ((int)num9 < (int)num3)
							{
								vigObject = vigObject2;
								num3 = num9;
							}
						}
					}
				}
				if (vigObject == null)
				{
					break;
				}
				Lightning2 lightning3 = vData.ini.FUN_2C17C(1, typeof(Lightning2), 8u) as Lightning2;
				if (lightning3 == null)
				{
					break;
				}
				dAT_ = lightning.DAT_80;
				v5 = default(Vector3Int);
				v5.x = vigObject.vTransform.position.x - dAT_.vTransform.position.x;
				v5.y = vigObject.vTransform.position.y - dAT_.vTransform.position.y;
				v5.z = vigObject.vTransform.position.z - dAT_.vTransform.position.z;
				dAT_ = lightning.DAT_80;
				lightning.DAT_88 = lightning3;
				lightning3.vTransform.position = dAT_.vTransform.position;
				lightning3.DAT_19 = 40;
				Utilities.FUN_29FC8(v5, out Vector3Int vout2);
				Lightning3 lightning2 = vData.ini.FUN_2C17C(3, typeof(Lightning3), 8u) as Lightning3;
				lightning2.type = 3;
				lightning2.flags |= 16u;
				lightning3.doubleDamage = (((Vehicle)arg2).doubleDamage != 0);
				lightning3.chainID = num8 + 1;
				lightning2.vTransform = GameManager.FUN_2A39C();
				lightning2.vTransform.position = new Vector3Int(0, 0, 0);
				lightning2.PDAT_74 = vigObject;
				lightning2.PDAT_78 = pDAT_;
				Utilities.FUN_2CC48(vigObject, lightning2);
				Utilities.ParentChildren(vigObject, vigObject);
				lightning3.DAT_8C = lightning2;
				lightning2.FUN_30BF0();
				lightning3.DAT_80 = vigObject;
				vigObject.flags |= 67108864u;
				((Vehicle)vigObject).DAT_F6 |= 512;
				param = -100 >> num8;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					param = -200 >> num8;
				}
				param = ((Vehicle)vigObject).FUN_3B078(arg2, (ushort)DAT_1A, param, 1u);
				((Vehicle)vigObject).FUN_3A020(param, DAT_20, param3: true);
				lightning3.vTransform.rotation = Utilities.FUN_2A724(vout2);
				lightning3.vTransform.rotation.MatrixNormal();
				num4 = num7 * lightning3.vTransform.rotation.V02;
				if (num4 < 0)
				{
					num4 += 65535;
				}
				num5 = num7 * lightning3.vTransform.rotation.V12;
				lightning3.vTransform.rotation.V02 = (short)(num4 >> 16);
				if (num5 < 0)
				{
					num5 += 65535;
				}
				num4 = num7 * lightning3.vTransform.rotation.V22;
				lightning3.vTransform.rotation.V12 = (short)(num5 >> 16);
				if (num4 < 0)
				{
					num4 += 65535;
				}
				lightning3.vTransform.rotation.V22 = (short)(num4 >> 16);
				lightning3.flags = 36u;
				lightning3.FUN_3066C();
				dAT_ = lightning3.DAT_80;
				lightning = lightning3;
				num8++;
			}
		}
		num2 = 540u;
		if (arg2.id < 0)
		{
			num2 = 600u;
		}
		return num2;
	}
}
