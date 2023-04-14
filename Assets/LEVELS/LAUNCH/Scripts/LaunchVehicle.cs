using UnityEngine;

public class LaunchVehicle : Destructible
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
		VigObject self = hit.self;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			if ((flags & 0x80) != 0 && (tags == 0 || tags == 8) && vehicle.vTransform.position.z < vTransform.position.z)
			{
				Vector3Int v = new Vector3Int(0, 0, new Vector3Int(0, 0, physics1.W * 128).z);
				if (tags == 0)
				{
					v.z = physics1.W * -128;
				}
				HitDetection hitDetection = new HitDetection(null);
				GameManager.instance.FUN_2FB70(this, hit, hitDetection);
				Vector3Int v2 = default(Vector3Int);
				v2.x = hitDetection.position.x / 2;
				v2.y = hitDetection.position.y / 2;
				v2.z = hitDetection.position.z / 2;
				v2 = Utilities.FUN_24148(vehicle.vTransform, v2);
				vehicle.FUN_2B370(v, v2);
				int param = -15;
				if (vehicle.id < 0)
				{
					param = -50;
				}
				vehicle.FUN_3A064(param, vTransform.position, param3: true);
				return 0u;
			}
			FUN_32CF0(hit);
			return 0u;
		}
		if (self.type != 8)
		{
			return 0u;
		}
		if (2 < tags - 1)
		{
			FUN_32B90(self.maxHalfHealth);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if (DAT_18 != 0 && arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E7A8(vTransform.position);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			int num2;
			int num;
			if (base.tags == 0 || base.tags == 8)
			{
				num2 = physics1.W + 25;
				num = 3051;
				if (num2 < 3051)
				{
					num = num2;
				}
				physics1.W = num;
			}
			Vector3Int vector3Int;
			if (vTransform.position.z < 79175681)
			{
				vTransform.position.y = 2666496;
				vector3Int = new Vector3Int(0, -4096, 0);
			}
			else
			{
				vector3Int = default(Vector3Int);
				int param = FUN_2CFBC(vTransform.position, ref vector3Int);
				vTransform.position.y = param;
				vector3Int = Utilities.VectorNormal(vector3Int);
			}
			num = vTransform.rotation.V21 * vector3Int.y - vTransform.rotation.V11 * vector3Int.z;
			if (num < 0)
			{
				num += 4095;
			}
			num >>= 12;
			num2 = num;
			if (num < 0)
			{
				num2 = -num;
			}
			if (2 < num2)
			{
				if (num < 0)
				{
					num += 15;
				}
				FUN_24700((short)(num >> 4), 0, 0);
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
			}
			num = ((physics2.X != 0) ? (-physics1.W) : physics1.W);
			num = vTransform.position.z + num;
			vTransform.position.z = num;
			if (base.tags == 0)
			{
				if (79114240 < num)
				{
					return 0u;
				}
				base.tags = 1;
				physics1.W = 0;
				physics2.X ^= 1;
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
				FUN_30BA8();
				GameManager.instance.FUN_30CB0(this, 60);
				flags &= 4278190079u;
			}
			else
			{
				if (base.tags != 8)
				{
					return 0u;
				}
				if (85053439 < num)
				{
					base.tags = 9;
					physics1.W = 0;
					FUN_30BA8();
					return 0u;
				}
			}
			break;
		}
		case 1:
			base.tags = 0;
			physics2.X = 1;
			physics1.W = 0;
			flags |= 8u;
			break;
		case 2:
		{
			sbyte tags = base.tags;
			if (tags != 2)
			{
				if (tags < 3)
				{
					if (tags != 1)
					{
						return 0u;
					}
					int param;
					if ((flags & 0x1000000) == 0)
					{
						param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E14C(param, vData.sndList, 6);
						FUN_1FCC();
						int num = (int)GameManager.FUN_2AC5C();
						GameManager.instance.FUN_30CB0(this, (num * 300 >> 15) + 600);
						return 0u;
					}
					GameManager.instance.FUN_30CB0(this, 210);
					base.tags = 2;
					param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E14C(param, vData.sndList, 4);
					return 0u;
				}
				switch (tags)
				{
				case 3:
					FUN_30B78();
					base.tags = 8;
					return 0u;
				default:
					return 0u;
				case 5:
					break;
				}
			}
			FUN_1BB4();
			GameManager.instance.FUN_30CB0(this, 1200);
			base.tags++;
			break;
		}
		case 8:
			if (2 < base.tags - 1)
			{
				FUN_32B90((uint)arg2);
				return 0u;
			}
			return 0u;
		case 9:
			if (arg2 != 0)
			{
				if (base.tags == 0)
				{
					base.tags = 5;
					FUN_30C68();
					FUN_1BB4();
					FUN_30BA8();
					return 0u;
				}
				return 0u;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			if ((flags & 8) != 0)
			{
				flags &= 4294967287u;
				GameManager.instance.FUN_4C4BC(vShadow);
				vShadow = null;
			}
			break;
		}
		return 0u;
	}

	private void FUN_1BB4()
	{
		VigObject vigObject = child2;
		if (!(vigObject != null))
		{
			return;
		}
		while (vigObject.id != 1)
		{
			vigObject = vigObject.child;
			if (!(vigObject != null))
			{
				break;
			}
		}
		if (!(vigObject != null))
		{
			return;
		}
		VigTransform vigTransform = vigObject.vTransform = GameManager.instance.FUN_2CDF4(vigObject);
		vigObject.FUN_2CCBC();
		LaunchRocket launchRocket = Utilities.FUN_52188(vigObject, typeof(LaunchRocket)) as LaunchRocket;
		launchRocket.flags |= 128u;
		sbyte tags = 0;
		if (base.tags == 5)
		{
			tags = 10;
		}
		launchRocket.tags = tags;
		launchRocket.FUN_305FC();
		GameManager.instance.FUN_30CB0(launchRocket, 60);
		sbyte param = launchRocket.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, launchRocket.vData.sndList, 2, vTransform.position, param5: true);
		ConfigContainer configContainer = launchRocket.FUN_2C5F4(32768);
		if (configContainer != null)
		{
			LaunchRocket2 launchRocket2 = launchRocket.vData.ini.FUN_2C17C(25, typeof(LaunchRocket2), 8u) as LaunchRocket2;
			if (launchRocket2 != null)
			{
				launchRocket2.type = 3;
				Utilities.FUN_2CA94(launchRocket, configContainer, launchRocket2);
				Utilities.ParentChildren(launchRocket, launchRocket);
				launchRocket2.FUN_30BF0();
				param = (launchRocket2.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C());
				GameManager.instance.FUN_1E580(param, launchRocket2.vData.sndList, 2, launchRocket2.vTransform.position, param5: true);
			}
		}
		if (base.tags == 5)
		{
			return;
		}
		vigObject = GameManager.instance.FUN_318D0(49);
		int num = 0;
		if (!(vigObject != null))
		{
			return;
		}
		do
		{
			ConfigContainer configContainer2 = vigObject.FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
			if (configContainer2 != null)
			{
				LaunchRocket3 launchRocket3 = new GameObject().AddComponent<LaunchRocket3>();
				if (launchRocket3 != null)
				{
					VigCollider vCollider = null;
					if (-1 < configContainer2.colliderID)
					{
						vCollider = new VigCollider(vigObject.vData.cbbList[configContainer2.colliderID].buffer);
					}
					launchRocket3.vCollider = vCollider;
					launchRocket3.vTransform = GameManager.instance.FUN_2CEAC(vigObject, configContainer2);
					launchRocket3.flags = 386u;
					launchRocket3.type = 3;
					launchRocket3.FUN_305FC();
					launchRocket3.DAT_58 = 851968;
					GameManager.instance.FUN_30CB0(launchRocket3, 180);
				}
			}
			num++;
		}
		while (num < 2);
	}

	private static void FUN_1FCC()
	{
		Exhaust param = new GameObject().AddComponent<Exhaust>();
		GameManager.instance.FUN_30CB0(param, 60);
	}
}
