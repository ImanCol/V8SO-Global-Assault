using System.Collections.Generic;
using UnityEngine;

public class Hook2 : VigObject
{
	private static Vector3Int DAT_20 = new Vector3Int(0, 0, 0);

	public VigObject DAT_88;

	public int DAT_A0_2;

	public ConfigContainer DAT_A4;

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
		Vector3Int vout;
		if (arg1 == 2)
		{
			sbyte tags = base.tags;
			if (tags == 1)
			{
				VigObject param = FUN_2CCBC();
				GameManager.instance.FUN_308C4(param);
				return 0u;
			}
			if (tags < 2)
			{
				if (tags != 0)
				{
					return 0u;
				}
				int z = physics2.Z;
				physics2.W = z;
				int num = z;
				if (z < 0)
				{
					num = z + 15;
				}
				child2.vTransform.rotation.V22 = (short)(num >> 4);
				DAT_88.vTransform.position.z = z << 1;
				Vector3Int vector3Int = Utilities.FUN_24148(DAT_80.vTransform, new Vector3Int(physics1.W, physics2.X, physics2.Y));
				Vector3Int param2 = GameManager.instance.FUN_2CE50(DAT_88);
				Vector3Int phy = default(Vector3Int);
				phy.x = vector3Int.x - param2.x;
				phy.y = vector3Int.y - param2.y;
				phy.z = vector3Int.z - param2.z;
				num = Utilities.FUN_29E84(phy);
				if (81920 < num || (DAT_80.flags & 0x4000000) != 0)
				{
					base.tags = 1;
					num = physics2.W - 16384;
					DAT_A0_2 = ((int)(num * 2290649225u >> 32) + num >> 3) - (num >> 31);
					GameManager.instance.FUN_30CB0(this, 15);
					return 0u;
				}
				((Vehicle)DAT_80).FUN_3A020(-10, DAT_20, param3: true);
				base.tags = 2;
				physics2.Z = 98304;
				GameManager.instance.FUN_30CB0(this, 300);
				if (((Vehicle)DAT_80).wheelsType == _WHEELS.Air)
				{
					if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || DAT_80.id == -1)
					{
						((Vehicle)DAT_80).FUN_3E32C(_WHEELS.Ground, 0);
						if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
						{
							ClientSend.Pickup(16, 0, 0);
						}
					}
					else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && DAT_80.id > 0)
					{
						((Vehicle)DAT_80).FUN_3E32C(_WHEELS.Ground, 0);
						ClientSend.PickupAI(DAT_80.id, 16, 0, 0);
					}
				}
				tags = (DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
				GameManager.instance.FUN_1E5D4(tags, vData.sndList, 5, param2, param5: true);
				VigObject vigObject = Utilities.FUN_2CD78(DAT_84);
				vigObject.tags = 3;
			}
			else
			{
				switch (tags)
				{
				default:
					return 0u;
				case 3:
				{
					VigObject param = FUN_2CCBC();
					GameManager.instance.FUN_308C4(param);
					return 0u;
				}
				case 2:
					break;
				}
				Vehicle vehicle = (Vehicle)DAT_80;
				Vector3Int vin = default(Vector3Int);
				vin.x = vehicle.vTransform.position.x - vTransform.position.x;
				vin.y = vehicle.vTransform.position.y - vTransform.position.y;
				vin.z = vehicle.vTransform.position.z - vTransform.position.z;
				int num = 4096;
				VigObject vigObject2 = null;
				if (vTransform.rotation.V02 * vin.x + vTransform.rotation.V12 * vin.y + vTransform.rotation.V22 * vin.z < 0)
				{
					VigObject vigObject3 = Utilities.FUN_2CD78(DAT_84);
					VigTransform transform = GameManager.instance.FUN_2CDF4(vigObject3);
					List<VigTuple> worldObjs = GameManager.instance.worldObjs;
					for (int i = 0; i < worldObjs.Count; i++)
					{
						VigObject vObject = worldObjs[i].vObject;
						if (vObject.type != 2 || !(vObject != vigObject3) || !(vObject != DAT_80))
						{
							continue;
						}
						vin = Utilities.FUN_24304(transform, vObject.screen);
						if (0 < vin.z)
						{
							int num2 = (vin.z >> 12 != 0) ? (vin.x / (vin.z >> 12)) : vin.x;
							if (num2 < 0)
							{
								num2 = -num2;
							}
							if (num2 < num)
							{
								vigObject2 = vObject;
								num = num2;
							}
						}
					}
					if (vigObject2 == null)
					{
						vin.x = vigObject3.vTransform.rotation.V02;
						vin.y = vigObject3.vTransform.rotation.V12 - 1638;
						vin.z = vigObject3.vTransform.rotation.V22;
					}
					else
					{
						vehicle = (Vehicle)DAT_80;
						vin.x = vigObject2.screen.x - vehicle.vTransform.position.x;
						vin.z = vigObject2.screen.z - vehicle.vTransform.position.z;
						vin.y = vigObject2.screen.y - vehicle.vTransform.position.y - 81920;
					}
					Utilities.FUN_29FC8(vin, out vout);
					num = physics2.W;
					int z;
					if (num < 49152)
					{
						z = 49152;
					}
					else
					{
						z = 163840;
						if (num < 163841)
						{
							z = num;
						}
					}
					num = vout.x * z;
					if (num < 0)
					{
						num += 16383;
					}
					int num3 = vout.y * z;
					Vector3Int vector3Int2 = default(Vector3Int);
					vector3Int2.x = num >> 14 << 7;
					if (num3 < 0)
					{
						num3 += 16383;
					}
					vector3Int2.y = num3 >> 14 << 7;
					z = vout.z * z;
					if (z < 0)
					{
						z += 16383;
					}
					vector3Int2.z = z >> 14 << 7;
					vector3Int2 = Utilities.FUN_2426C(DAT_80.vTransform.rotation, new Matrix2x4(vector3Int2.x, vector3Int2.y, vector3Int2.z, 0));
					DAT_80.FUN_2B1FC(vector3Int2, new Vector3Int(physics1.W, physics2.X, physics2.Y));
					int param3 = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param3, vData.sndList, 4, vigObject3.vTransform.position);
				}
				GameManager.instance.FUN_30CB0(this, 6);
				base.tags = 3;
			}
		}
		else if (arg1 < 3)
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
			int num;
			switch (base.tags)
			{
			case 1:
				physics2.W -= DAT_A0_2;
				break;
			case 0:
				physics2.W += DAT_A0_2;
				break;
			case 2:
			case 3:
			{
				Vehicle vehicle = (Vehicle)DAT_80;
				if (vehicle.shield != 0)
				{
					vehicle.FUN_393F8();
					GameManager.instance.FUN_30CB0(this, 0);
					base.tags = 3;
					return 0u;
				}
				if ((vehicle.flags & 0x4000000) != 0)
				{
					GameManager.instance.FUN_30CB0(this, 0);
					base.tags = 3;
					return 0u;
				}
				Vector3Int vector3Int = Utilities.FUN_24148(DAT_80.vTransform, new Vector3Int(physics1.W, physics2.X, physics2.Y));
				VigTransform transform = GameManager.instance.FUN_2CEAC(DAT_84, DAT_A4);
				Vector3Int phy = default(Vector3Int);
				phy.x = vector3Int.x - transform.position.x;
				phy.y = vector3Int.y - transform.position.y;
				phy.z = vector3Int.z - transform.position.z;
				Vector3Int param2 = Utilities.FUN_2426C(transform.rotation, new Matrix2x4(phy.x, phy.y, phy.z, 0));
				num = Utilities.FUN_29FC8(param2, out vout);
				num /= 2;
				if (327679 < num)
				{
					VigObject param = FUN_2CCBC();
					GameManager.instance.FUN_308C4(param);
					return uint.MaxValue;
				}
				vTransform.rotation = Utilities.FUN_2A724(vout);
				physics2.W = num;
				if (base.tags != 3 && physics2.Z < num)
				{
					Utilities.FUN_29FC8(phy, out vout);
					num = physics2.Z - num;
					Vector3Int v = default(Vector3Int);
					v.x = num * vout.x;
					if (v.x < 0)
					{
						v.x += 8191;
					}
					v.y = num * vout.y;
					v.x >>= 13;
					if (v.y < 0)
					{
						v.y += 8191;
					}
					v.y >>= 13;
					v.z = num * vout.z;
					if (v.z < 0)
					{
						v.z += 8191;
					}
					v.z >>= 13;
					DAT_80.FUN_2B370(v, vector3Int);
					VigObject param = Utilities.FUN_2CD78(DAT_84);
					num *= 3;
					if (num < 0)
					{
						num += 65535;
					}
					num = ((id < 0) ? (num >> 18) : (num >> 16));
					if (((Vehicle)param).doubleDamage != 0)
					{
						num *= 2;
					}
					if (-1 < num)
					{
						num = -1;
					}
					int param3 = ((Vehicle)DAT_80).FUN_3B078(param, (ushort)DAT_1A, num, 1u);
					((Vehicle)DAT_80).FUN_39DCC(param3, DAT_20, param3: true);
				}
				break;
			}
			}
			num = physics2.W;
			if (num < 0)
			{
				num += 15;
			}
			child2.vTransform.rotation.V22 = (short)(num >> 4);
			DAT_88.vTransform.position.z = physics2.W << 1;
		}
		else
		{
			if (arg1 != 4)
			{
				return 0u;
			}
			VigObject vigObject2 = DAT_84;
			VigObject vigObject = Utilities.FUN_2CD78(vigObject2);
			if (DAT_18 != 0)
			{
				GameManager.instance.FUN_1DE78(DAT_18);
			}
			if (vigObject == null)
			{
				return 0u;
			}
			if (GameManager.instance.FUN_30134(GameManager.instance.worldObjs, vigObject) != null)
			{
				if (vigObject2.maxHalfHealth == 0)
				{
					vigObject2.FUN_3A368();
					return 0u;
				}
				VigObject param = DAT_84.vData.ini.FUN_2C17C(2, typeof(VigObject), 8u);
				ConfigContainer cont = vigObject2.FUN_2C5F4(32768);
				Utilities.FUN_2CA94(vigObject2, cont, param);
				Utilities.ParentChildren(vigObject2, vigObject2);
				param.FUN_30BF0();
				vigObject2.PDAT_78 = param;
				vigObject2.flags &= 4160749567u;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			FUN_30C20();
			vAnim = null;
			flags |= 4u;
			return 4294967294u;
		}
		return 0u;
	}
}
