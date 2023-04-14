using UnityEngine;

public class Freezer : VigObject
{
	public static int DAT_4C;

	public static int DAT_50;

	public static int DAT_54 = 409;

	public static int DAT_58_2 = 0;

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
		{
			byte dAT_ = DAT_19;
			VigObject vigObject;
			if (dAT_ == 1)
			{
				vigObject = child2;
				if (vigObject == null)
				{
					return 0u;
				}
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject == null)
				{
					return 0u;
				}
				vigObject.IDAT_78 += 2;
			}
			else
			{
				if (dAT_ < 2)
				{
					if (dAT_ != 0)
					{
						return 0u;
					}
					FUN_42330(arg2);
					return 0u;
				}
				if (dAT_ != 2)
				{
					return 0u;
				}
				vigObject = child2;
				if (vigObject == null)
				{
					return 0u;
				}
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject == null)
				{
					return 0u;
				}
			}
			vigObject.vr.z += vigObject.IDAT_78;
			vigObject.ApplyTransformation();
			return 0u;
		}
		case 2:
		{
			sbyte b = (sbyte)(DAT_19 + 1);
			DAT_19 = (byte)b;
			switch (b)
			{
			case 2:
				GameManager.instance.FUN_30CB0(this, 90);
				return 0u;
			default:
				return 0u;
			case 3:
				break;
			}
			DAT_19 = 0;
			break;
		}
		case 10:
		{
			arg2 &= 0xFFFF;
			if (arg2 != 4883)
			{
				break;
			}
			Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
			if (vehicle == null || id != 0)
			{
				return 0u;
			}
			if (DAT_19 != 0 && maxHalfHealth != 0)
			{
				return 0u;
			}
			Freezer2 freezer = vehicle.vData.ini.FUN_2C17C(1, typeof(Freezer2), 8u) as Freezer2;
			if (freezer == null)
			{
				return 880u;
			}
			Vector3Int v = new Vector3Int(DAT_4C, DAT_50, DAT_54);
			int dAT_58_ = DAT_58_2;
			DAT_19 = 1;
			freezer.flags = 1610613776u;
			ushort num = (ushort)vehicle.id;
			freezer.type = 8;
			freezer.tags = 1;
			freezer.DAT_80 = vehicle;
			freezer.DAT_B8 = this;
			freezer.id = (short)num;
			VigTransform vigTransform = freezer.DAT_84_2 = GameManager.instance.FUN_2CDF4(vehicle);
			freezer.vTransform = vehicle.vTransform;
			freezer.DAT_A4 = 409;
			freezer.DAT_BC = 400;
			freezer.FUN_30B78();
			freezer.FUN_30BF0();
			GameManager.instance.FUN_30CB0(freezer, 29);
			GameManager.instance.FUN_30CB0(this, 29);
			VigObject vigObject = child2;
			if (vigObject != null)
			{
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject != null)
				{
					vigObject.IDAT_78 = 0;
				}
			}
			ConfigContainer cont = FUN_2C5F4(32768);
			Utilities.FUN_2CA94(this, cont, freezer);
			Utilities.ParentChildren(this, this);
			freezer.DAT_84_2 = freezer.vTransform;
			Utilities.FUN_2449C(freezer.vTransform.rotation, v, ref freezer.vTransform.rotation);
			maxHalfHealth--;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(param, vehicle.vData.sndList, 4);
			id = 880;
			return 880u;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			byte dAT_ = DAT_19;
			VigObject vigObject;
			if (dAT_ == 1)
			{
				vigObject = child2;
				if (vigObject == null)
				{
					return 0u;
				}
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject == null)
				{
					return 0u;
				}
				vigObject.IDAT_78 += 2;
			}
			else
			{
				if (dAT_ < 2)
				{
					if (dAT_ != 0)
					{
						return 0u;
					}
					FUN_42330(arg2);
					return 0u;
				}
				if (dAT_ != 2)
				{
					return 0u;
				}
				vigObject = child2;
				if (vigObject == null)
				{
					return 0u;
				}
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject == null)
				{
					return 0u;
				}
			}
			vigObject.vr.z += vigObject.IDAT_78;
			vigObject.ApplyTransformation();
			return 0u;
		}
		case 1:
			type = 3;
			maxHalfHealth = 1;
			break;
		case 12:
		{
			if (DAT_19 != 0 && maxHalfHealth != 0)
			{
				return 0u;
			}
			Freezer2 freezer = arg2.vData.ini.FUN_2C17C(1, typeof(Freezer2), 8u) as Freezer2;
			if (freezer == null)
			{
				return 720u;
			}
			Vector3Int vector3Int = new Vector3Int(DAT_4C, DAT_50, DAT_54);
			int dAT_58_ = DAT_58_2;
			DAT_19 = 1;
			freezer.flags = 1610613776u;
			ushort num = (ushort)arg2.id;
			freezer.type = 8;
			freezer.DAT_80 = arg2;
			freezer.DAT_B8 = this;
			freezer.id = (short)num;
			VigTransform vigTransform = freezer.DAT_84_2 = GameManager.instance.FUN_2CDF4(arg2);
			freezer.vTransform = arg2.vTransform;
			freezer.DAT_A4 = 409;
			freezer.FUN_30B78();
			freezer.FUN_30BF0();
			GameManager.instance.FUN_30CB0(freezer, 29);
			GameManager.instance.FUN_30CB0(this, 29);
			VigObject vigObject = child2;
			if (vigObject != null)
			{
				while (vigObject.id != 0)
				{
					vigObject = vigObject.child;
					if (!(vigObject != null))
					{
						break;
					}
				}
				if (vigObject != null)
				{
					vigObject.IDAT_78 = 0;
				}
			}
			ConfigContainer cont = FUN_2C5F4(32768);
			Utilities.FUN_2CA94(this, cont, freezer);
			Utilities.ParentChildren(this, this);
			freezer.DAT_84_2 = freezer.vTransform;
			Utilities.FUN_2449C(freezer.vTransform.rotation, vector3Int, ref freezer.vTransform.rotation);
			maxHalfHealth--;
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(param, arg2.vData.sndList, 4);
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param, vData.sndList, 2);
			return 720u;
		}
		case 13:
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			if ((arg2.flags & 0x20000000) != 0)
			{
				Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
				if (1064958u < (uint)(vector3Int.z - 102401))
				{
					return 0u;
				}
				if (vector3Int.x < 0)
				{
					vector3Int.x = -vector3Int.x;
				}
				if (vector3Int.x * 6 - 65536 >= vector3Int.z)
				{
					return 0u;
				}
				return 1u;
			}
			break;
		}
		return 0u;
	}
}
