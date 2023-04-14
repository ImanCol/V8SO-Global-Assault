using UnityEngine;

public class Crane : VigObject
{
	public VigTransform DAT_84_2;

	public int DAT_A4;

	public int DAT_A8;

	public int DAT_AC;

	public int DAT_B0;

	public int DAT_B4;

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
		if (hit.self.type != 2)
		{
			return 0u;
		}
		if (1u < (uint)(byte)tags)
		{
			return 0u;
		}
		VigObject child = child2;
		if (child == null)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
		{
			BufferedBinaryReader reader = vehicle.vCollider.reader;
			ConfigContainer param = child.FUN_2C5F4(32768);
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(child, param);
			Vector3Int v = default(Vector3Int);
			v.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
			v.y = reader.ReadInt32(8);
			v.z = (reader.ReadInt32(12) + reader.ReadInt32(24)) / 2;
			v = Utilities.FUN_24148(hit.self.vTransform, v);
			Vector3Int vin = default(Vector3Int);
			vin.x = vigTransform.position.x - v.x;
			vin.y = vigTransform.position.y - v.y;
			vin.z = vigTransform.position.z - v.z;
			Vector3Int vout;
			int num = Utilities.FUN_29FC8(vin, out vout);
			int num2 = -num + 262144;
			if (num < 262145)
			{
				if (num2 < 0)
				{
					num2 = -num + 262147;
				}
				num2 >>= 2;
				vin.x = vout.x * num2 >> 12;
				vin.y = vout.y * num2 >> 12;
				vin.z = vout.z * num2 >> 12;
				int x = vehicle.physics1.X;
				int num3 = x;
				if (x < 0)
				{
					num3 = x + 31;
				}
				int y = vehicle.physics1.Y;
				vehicle.physics1.X = x + (vin.x - (num3 >> 5));
				num3 = y;
				if (y < 0)
				{
					num3 = x + 31;
				}
				x = vehicle.physics1.Z;
				vehicle.physics1.Y = y + (vin.y - (num3 >> 5));
				num3 = x;
				if (x < 0)
				{
					num3 = x + 31;
				}
				vehicle.physics1.Z = x + (vin.z - (num3 >> 5));
				if (tags == 0)
				{
					sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 56, vigTransform.position, param5: true);
					tags = 1;
					FUN_30B78();
					DAT_80 = vehicle;
				}
				else
				{
					if (num < 10241 && vehicle.physics1.W < 1525)
					{
						tags = 2;
						vehicle.vTransform.position.y += vigTransform.position.y - v.y;
						DAT_AC = vTransform.position.z;
						int param3 = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E628(param3, vData.sndList, 1, vTransform.position);
						vehicle.state = _VEHICLE_TYPE.Crane;
						vehicle.physics1.X = 0;
						vehicle.flags |= 67108864u;
						vehicle.physics1.Y = 0;
						vehicle.physics1.Z = 0;
						if (DAT_18 != 0)
						{
							GameManager.instance.FUN_1DE78(DAT_18);
							DAT_18 = 0;
						}
						param3 = (DAT_A4 = GameManager.instance.FUN_1DD9C());
						GameManager.instance.FUN_1E628(param3, vData.sndList, 6, vTransform.position, param5: true);
						DAT_B4 = -91;
						DAT_A8 = 0;
						DAT_B0 = 6;
						Utilities.FUN_2A454(vigTransform, vehicle.vTransform, out DAT_84_2);
					}
					DAT_80 = vehicle;
				}
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			switch (tags)
			{
			case 1:
				if (DAT_80 == null)
				{
					FUN_30BA8();
					tags = 0;
					if (DAT_18 != 0)
					{
						GameManager.instance.FUN_1DE78(DAT_18);
						DAT_18 = 0;
					}
					break;
				}
				if (arg2 == 0)
				{
					return 0u;
				}
				if ((GameManager.FUN_2AC5C() & 1) != 0)
				{
					VigObject child2 = base.child2;
					Magnet2 obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Magnet2), 8u) as Magnet2;
					BufferedBinaryReader reader = DAT_80.vCollider.reader;
					Vector3Int vector3Int = Utilities.FUN_24148(v: new Vector3Int
					{
						x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2,
						y = reader.ReadInt32(8),
						z = (reader.ReadInt32(12) + reader.ReadInt32(24)) / 2
					}, transform: DAT_80.vTransform);
					int num = (int)GameManager.FUN_2AC5C();
					obj.vTransform.position.x = vector3Int.x + num;
					num = (int)GameManager.FUN_2AC5C();
					obj.vTransform.position.y = vector3Int.y + num;
					num = (int)GameManager.FUN_2AC5C();
					obj.vTransform.position.z = vector3Int.z + num;
					ConfigContainer param = child2.FUN_2C5F4(32768);
					VigTransform vigTransform = GameManager.instance.FUN_2CEAC(child2, param);
					Utilities.FUN_29FC8(new Vector3Int
					{
						x = vigTransform.position.x - vector3Int.x,
						y = vigTransform.position.y - vector3Int.y,
						z = vigTransform.position.z - vector3Int.z
					}, out Vector3Int vout);
					num = vout.x;
					if (num < 0)
					{
						num += 15;
					}
					obj.physics1.Z = num >> 4;
					num = vout.y;
					if (num < 0)
					{
						num += 15;
					}
					obj.physics1.W = num >> 4;
					num = vout.z;
					if (num < 0)
					{
						num += 15;
					}
					obj.physics2.X = num >> 4;
					obj.flags = 180u;
					obj.vTransform.rotation.V00 = 4096;
					obj.vTransform.rotation.V11 = 4096;
					obj.vTransform.rotation.V22 = 4096;
					obj.FUN_305FC();
				}
				DAT_80 = null;
				break;
			case 2:
			{
				VigObject child = base.child2;
				child.FUN_24700((short)DAT_B4, 0, 0);
				child.vTransform.rotation = Utilities.MatrixNormal(child.vTransform.rotation);
				int num = DAT_B4;
				if (num < 0)
				{
					num = -num;
				}
				if (91 < num)
				{
					DAT_B0 = -DAT_B0;
				}
				DAT_B4 += DAT_B0;
				if (DAT_AC - vTransform.position.z < 1638401 && ((Vehicle)DAT_80).state == _VEHICLE_TYPE.Crane)
				{
					if (DAT_A8 < 9830)
					{
						DAT_A8 += 163;
					}
					vTransform.position.z -= DAT_A8;
					ConfigContainer param = child.FUN_2C5F4(32768);
					VigTransform m = GameManager.instance.FUN_2CEAC(child, param);
					DAT_80.vTransform = Utilities.CompMatrixLV(m, DAT_84_2);
					return 0u;
				}
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param2, vData.sndList, 1, vTransform.position);
				((Vehicle)DAT_80).FUN_41FEC();
				DAT_80 = null;
				tags = 3;
				break;
			}
			case 3:
			{
				vTransform.position.z += 9830;
				base.child2.FUN_24700((short)DAT_B4, 0, 0);
				base.child2.vTransform.rotation = Utilities.MatrixNormal(base.child2.vTransform.rotation);
				int num = DAT_B4;
				if (num < 0)
				{
					num = -num;
				}
				if (91 < num)
				{
					DAT_B0 = -DAT_B0;
				}
				DAT_B4 += DAT_B0;
				if (vTransform.position.z < DAT_AC)
				{
					return 0u;
				}
				vTransform.position.z = DAT_AC;
				tags = 4;
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param2, vData.sndList, 1, vTransform.position);
				if (DAT_A4 == 0)
				{
					return 0u;
				}
				GameManager.instance.FUN_1DE78(DAT_A4);
				DAT_A4 = 0;
				break;
			}
			case 4:
			{
				VigObject child = base.child2;
				child.FUN_24700((short)DAT_B4, 0, 0);
				child.vTransform.rotation = Utilities.MatrixNormal(child.vTransform.rotation);
				if (child.vTransform.rotation.V11 < 4092)
				{
					int num = DAT_B4;
					if (num < 0)
					{
						num = -num;
					}
					if (91 < num)
					{
						DAT_B0 = -DAT_B0;
					}
				}
				else
				{
					FUN_30BA8();
					tags = 0;
				}
				DAT_B4 += DAT_B0;
				break;
			}
			}
			break;
		case 1:
			type = 3;
			flags |= 256u;
			break;
		case 8:
			FUN_32B90((uint)arg2);
			return 0u;
		}
		return 0u;
	}
}
