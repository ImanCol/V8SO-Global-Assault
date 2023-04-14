using System;
using System.Collections.Generic;
using UnityEngine;

public class CraneSmall : VigObject
{
	public VigTransform DAT_84_2;

	public int DAT_A4;

	public short DAT_A8;

	public short DAT_AA;

	public int DAT_B4;

	public int DAT_B8;

	public int DAT_BC;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2, uint arg3)
	{
		Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
		dictionary.Add(210, typeof(VigChild));
		dictionary.Add(211, typeof(VigChild));
		dictionary.Add(213, typeof(VigChild));
		dictionary.Add(215, typeof(VigChild));
		VigObject vigObject = arg1.ini.FUN_2C17C((ushort)arg2, typeof(CraneSmall), arg3, dictionary);
		FUN_14C0((VigChild)vigObject.child2, _CHILD_TYPE.Default);
		return vigObject;
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
		return 1u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			base.child2.type = 3;
			FUN_14C0((VigChild)base.child2, _CHILD_TYPE.Child);
			FUN_1518(base.child2, 3);
			short num3 = id;
			short dAT_AA;
			if (num3 == 114)
			{
				DAT_A8 = 512;
				base.child2.vr.y = 512;
				dAT_AA = -512;
			}
			else
			{
				if (114 < num3)
				{
					if (num3 == 115)
					{
						DAT_A8 = 0;
						DAT_AA = -1877;
						return 0u;
					}
					return 0u;
				}
				if (num3 != 113)
				{
					return 0u;
				}
				DAT_A8 = -512;
				base.child2.vr.y = -512;
				dAT_AA = 1024;
			}
			DAT_AA = dAT_AA;
			base.child2.ApplyTransformation();
			return 0u;
		}
		default:
			return 0u;
		case 8:
			if (!FUN_32B90((uint)arg2))
			{
				return 0u;
			}
			return 1u;
		case 0:
			switch (tags)
			{
			case 1:
			{
				VigObject child = base.child2;
				Vehicle vehicle = DAT_80 as Vehicle;
				VigObject child2 = child.child2;
				VigObject child4 = child2.child2;
				if (child2 == null || child4 == null)
				{
					return 0u;
				}
				DAT_A4--;
				child2.vr.x += DAT_B4;
				child4.vr.x -= DAT_B4;
				child2.ApplyTransformation();
				child4.ApplyTransformation();
				int dAT_B;
				if (DAT_80 == null)
				{
					dAT_B = DAT_A4;
				}
				else
				{
					BufferedBinaryReader reader = vehicle.vCollider.reader;
					ConfigContainer param2 = child4.FUN_2C5F4(32768);
					VigTransform m = GameManager.instance.FUN_2CEAC(child4, param2);
					Vector3Int vector3Int = default(Vector3Int);
					vector3Int.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
					vector3Int.z = (reader.ReadInt32(12) + reader.ReadInt32(24)) / 2;
					vector3Int.y = reader.ReadInt32(8);
					Vector3Int vector3Int2 = Utilities.FUN_24148(vehicle.vTransform, vector3Int);
					Vector3Int phy = default(Vector3Int);
					phy.x = m.position.x - vector3Int2.x;
					phy.y = m.position.y - vector3Int2.y;
					phy.z = m.position.z - vector3Int2.z;
					dAT_B = Utilities.FUN_29E84(phy);
					if (dAT_B < 327681)
					{
						int num = vehicle.vTransform.rotation.V12;
						vehicle.physics1.X = phy.x * 4 + vehicle.physics1.X / 2;
						vehicle.physics1.Y = phy.y + vehicle.physics1.Y / 2;
						vehicle.physics2.X = 0;
						vehicle.physics2.Y = 0;
						vehicle.physics2.Z = 0;
						vehicle.physics1.Z = phy.z * 4 + vehicle.physics1.Z / 2;
						if (num < 0)
						{
							num += 7;
						}
						int num2 = -vehicle.vTransform.rotation.V10;
						if (0 < vehicle.vTransform.rotation.V10)
						{
							num2 += 7;
						}
						vehicle.FUN_24700((short)(num >> 3), 0, (short)(num2 >> 3));
						vehicle.vTransform.rotation = Utilities.MatrixNormal(vehicle.vTransform.rotation);
						if (DAT_A4 == 0)
						{
							if (dAT_B < 98305)
							{
								tags = 3;
								int param3 = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E628(param3, vData.sndList, 2, vTransform.position);
								LevelManager.instance.FUN_4DD54(vehicle, vector3Int, 142);
								vehicle.vTransform.position.x += m.position.x - vector3Int2.x;
								vehicle.vTransform.position.y += m.position.y - vector3Int2.y;
								vehicle.vTransform.position.z += m.position.z - vector3Int2.z;
								short num3 = (short)child.vr.y;
								DAT_BC = 0;
								DAT_B8 = (DAT_AA - num3) / 120;
								VigTransform m2 = Utilities.FUN_2A3EC(m);
								DAT_84_2 = Utilities.CompMatrixLV(m2, vehicle.vTransform);
								vehicle.physics1.X = 0;
								vehicle.physics1.Y = 0;
								vehicle.physics1.Z = 0;
								vehicle.state = _VEHICLE_TYPE.CraneSmall;
							}
							else
							{
								tags = 2;
							}
							DAT_B4 = -4;
							return 0u;
						}
						return 0u;
					}
					dAT_B = DAT_A4;
					DAT_80 = null;
				}
				if (dAT_B != 0)
				{
					return 0u;
				}
				tags = 2;
				DAT_B4 = -1;
				break;
			}
			case 2:
			{
				VigObject child2 = base.child2.child2;
				VigObject child6 = child2.child2;
				if (child2 == null || child6 == null)
				{
					return 0u;
				}
				child6.vr.x -= DAT_B4;
				short num5 = (short)(child2.vr.x + DAT_B4);
				child2.vr.x = num5;
				if (num5 << 16 < 1)
				{
					child2.vr.x = 0;
					child6.vr.x = 0;
					tags = 0;
					FUN_30BA8();
					if (DAT_18 != 0)
					{
						GameManager.instance.FUN_1DE78(DAT_18);
						DAT_18 = 0;
					}
				}
				child6.ApplyTransformation();
				child2.ApplyTransformation();
				return 0u;
			}
			case 3:
			{
				VigObject child = base.child2;
				VigObject child2 = child.child2;
				VigObject child3 = child2.child2;
				if (child2 == null || child3 == null)
				{
					return 0u;
				}
				if (-512 < child2.vr.x)
				{
					child2.vr.x += DAT_B4;
					child3.vr.x -= DAT_B4;
					child3.ApplyTransformation();
					child2.ApplyTransformation();
				}
				int dAT_B = DAT_B8;
				if (dAT_B < 1)
				{
					if (dAT_B < DAT_BC)
					{
						dAT_B = --DAT_BC;
					}
				}
				else if (DAT_BC < dAT_B)
				{
					dAT_B = ++DAT_BC;
				}
				child.vr.y += DAT_BC;
				child.ApplyTransformation();
				dAT_B = DAT_AA - child.vr.y;
				if (DAT_BC < 0)
				{
					dAT_B = -dAT_B;
				}
				if (10 < dAT_B)
				{
					ConfigContainer param2 = child3.FUN_2C5F4(32768);
					VigTransform m = GameManager.instance.FUN_2CEAC(child3, param2);
					DAT_80.vTransform = Utilities.CompMatrixLV(m, DAT_84_2);
					return 0u;
				}
				tags = 4;
				if (DAT_18 != 0)
				{
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				int param3 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param3, vData.sndList, 2, vTransform.position);
				DAT_A4 = 60;
				DAT_B4 = 11;
				DAT_BC = 0;
				DAT_B8 = -DAT_B8;
				((Vehicle)DAT_80).FUN_41FEC();
				DAT_80 = null;
				break;
			}
			case 4:
			{
				if (0 < --DAT_A4)
				{
					return 0u;
				}
				tags = 5;
				sbyte param = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, vData.sndList, 1, vTransform.position);
				goto case 5;
			}
			case 5:
			{
				VigObject child = base.child2;
				VigObject child2 = child.child2;
				VigObject child5 = child2.child2;
				if (child2 == null || child5 == null)
				{
					return 0u;
				}
				if (child2.vr.x < 5)
				{
					child2.vr.x += DAT_B4;
					child5.vr.x -= DAT_B4;
					child5.ApplyTransformation();
					child2.ApplyTransformation();
				}
				int dAT_B = DAT_B8;
				if (dAT_B < 1)
				{
					if (dAT_B < DAT_BC)
					{
						dAT_B = --DAT_BC;
					}
				}
				else if (DAT_BC < dAT_B)
				{
					dAT_B = ++DAT_BC;
				}
				child.vr.y += DAT_BC;
				child.ApplyTransformation();
				int num4 = DAT_A8 - child.vr.y;
				if (DAT_BC < 0)
				{
					num4 = -num4;
				}
				if ((num4 & 0xFFF) < 11)
				{
					tags = 0;
					FUN_30BA8();
					if (DAT_18 == 0)
					{
						return 0u;
					}
					GameManager.instance.FUN_1DE78(DAT_18);
					DAT_18 = 0;
				}
				break;
			}
			}
			return 0u;
		}
	}

	private static void FUN_14C0(VigChild param1, _CHILD_TYPE param2)
	{
		if (!(param1 != null))
		{
			return;
		}
		do
		{
			param1.state = param2;
			if (param1.child2 != null)
			{
				FUN_14C0((VigChild)param1.child2, param2);
			}
			param1 = (VigChild)param1.child;
		}
		while (param1 != null);
	}

	private static void FUN_1518(VigObject param1, int param2)
	{
		if (!(param1 != null))
		{
			return;
		}
		do
		{
			param1.type = (byte)param2;
			if (param1.child2 != null)
			{
				FUN_1518(param1.child2, param2);
			}
			param1 = param1.child;
		}
		while (param1 != null);
	}
}
