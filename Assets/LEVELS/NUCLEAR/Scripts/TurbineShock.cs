using System;
using System.Collections.Generic;
using UnityEngine;

public class TurbineShock : VigObject
{
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
		dictionary.Add(1035, typeof(TurbineShock2));
		dictionary.Add(1036, typeof(TurbineShock2));
		dictionary.Add(1037, typeof(TurbineShock2));
		return arg1.ini.FUN_2C17C((ushort)arg2, typeof(TurbineShock), arg3, dictionary);
	}

	public override uint OnCollision(HitDetection hit)
	{
		if (hit.collider1.ReadUInt16(0) == 1)
		{
			if (hit.collider1.ReadUInt16(2) != 3)
			{
				return 0u;
			}
			if (hit.self.type != 2)
			{
				return 0u;
			}
			Vehicle vehicle = (Vehicle)hit.self;
			if (vehicle.type != 2)
			{
				return 0u;
			}
			if ((vehicle.flags & 0x4000) != 0 && (vehicle.flags & 0x4000000) == 0)
			{
				if (tags == 1)
				{
					if ((flags & 0x80) == 0)
					{
						FUN_30B78();
					}
					DAT_80 = hit.self;
				}
				else
				{
					VigObject vigObject = child2;
					while (vigObject != null)
					{
						if ((uint)((ushort)vigObject.id - 1) < 2u)
						{
							((TurbineShock2)vigObject).state = _TURBINESHOCK2_TYPE.Type1;
							vigObject.flags &= 4294967293u;
							vigObject.FUN_2C05C();
							vigObject.FUN_30BF0();
						}
						vigObject = vigObject.child;
					}
					HitDetection hitDetection = new HitDetection(null);
					GameManager.instance.FUN_2FB70(this, hit, hitDetection);
					int num = 0;
					Vector3Int vector3Int = Utilities.FUN_24148(hit.self.vTransform, hitDetection.position);
					LevelManager.instance.FUN_4DE54(vector3Int, 42);
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 75, vector3Int);
					do
					{
						Throwaway obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(49, typeof(Throwaway), 8u) as Throwaway;
						obj.physics1.M0 = 0;
						obj.physics1.M1 = 0;
						obj.physics1.M2 = 0;
						uint num2 = GameManager.FUN_2AC5C();
						obj.physics1.Z = (int)((num2 & 0xFFF) - 2048);
						int num3 = (int)GameManager.FUN_2AC5C();
						if (num3 < 0)
						{
							num3 += 15;
						}
						obj.physics1.W = -(num3 >> 4);
						num2 = GameManager.FUN_2AC5C();
						obj.physics2.X = (int)((num2 & 0xFFF) - 2048);
						obj.type = 7;
						obj.flags |= 436u;
						short id = base.id;
						num++;
						obj.state = _THROWAWAY_TYPE.Type3;
						obj.id = id;
						obj.vTransform = GameManager.FUN_2A39C();
						obj.vTransform.position = vector3Int;
						obj.FUN_2D1DC();
						obj.DAT_87 = 1;
						obj.FUN_305FC();
					}
					while (num < 12);
					Ballistic ballistic = vData.ini.FUN_2C17C(15, typeof(Ballistic), 8u) as Ballistic;
					if (ballistic != null)
					{
						ballistic.vTransform = vTransform;
						ballistic.flags = 4u;
						ballistic.type = 3;
						ballistic.FUN_305FC();
					}
					vehicle.physics1.X /= 2;
					vehicle.physics1.Z /= 2;
					Vector3Int v = default(Vector3Int);
					v.x = hitDetection.normal2.x << 3;
					v.y = hitDetection.normal2.y * 8 - 585856;
					v.z = hitDetection.normal2.z << 3;
					vehicle.FUN_2B1FC(v, hitDetection.position);
					if (vehicle.id < 0)
					{
						UIManager.instance.FUN_4E414(vector3Int, new Color32(0, 0, byte.MaxValue, 8));
					}
					vehicle.FUN_3A064(-100, hitDetection.position, param3: false);
					vehicle.state = _VEHICLE_TYPE.Transformer;
					GameManager.instance.FUN_30CB0(vehicle, 30);
					flags |= 32u;
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
		{
			Vehicle vehicle = DAT_80 as Vehicle;
			if (vehicle == null)
			{
				DAT_19 = 0;
				FUN_30BA8();
				return 0u;
			}
			if (29u < (uint)(++DAT_19) && child2.tags < 9)
			{
				DAT_19 = 0;
				if (vehicle.body[0] != null)
				{
					if (vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth < vehicle.maxHalfHealth << 1)
					{
						vehicle.FUN_3A0C0(60);
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 44, vTransform.position);
						UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 128, 0, 8));
						DAT_80 = null;
						FUN_30BA8();
						child2.tags++;
					}
				}
				else if (vehicle.maxHalfHealth < vehicle.maxFullHealth)
				{
					vehicle.FUN_3A0C0(60);
					int param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 44, vTransform.position);
					UIManager.instance.FUN_4E414(vTransform.position, new Color32(0, 128, 0, 8));
					DAT_80 = null;
					FUN_30BA8();
					child2.tags++;
				}
			}
			PDAT_74 = null;
			break;
		}
		case 1:
		{
			if (arg2 != 0)
			{
				return 0u;
			}
			VigObject vigObject = child2;
			while (vigObject != null)
			{
				vigObject.type = 3;
				if ((uint)((ushort)vigObject.id - 1) < 2u)
				{
					vigObject.flags = (uint)(((int)vigObject.flags & -5) | 2);
				}
				vigObject = vigObject.child;
			}
			child2.tags = 0;
			FUN_2EC7C();
			break;
		}
		case 2:
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}
}
