using System;
using System.Collections.Generic;
using UnityEngine;

public class Aurora : VigObject
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
		if (hit.self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)hit.self;
		if (hit.object1 != this)
		{
			LevelManager.instance.FUN_39AF8(vehicle);
			return 0u;
		}
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		if (Utilities.FUN_24238(vTransform.rotation, hitDetection.normal1).z < 2049)
		{
			return 0u;
		}
		Vector3Int v = default(Vector3Int);
		v.x = vehicle.physics1.X + physics1.X * -128;
		v.y = vehicle.physics1.Y + physics1.Y * -128;
		v.z = vehicle.physics1.Z + physics1.Z * -128;
		long num = Utilities.FUN_2AD3C(v, hitDetection.normal1);
		uint num2 = (uint)((int)((uint)num >> 11) | ((int)(num >> 32) << 21));
		if (-1 < (int)num2)
		{
			return 0u;
		}
		uint num3 = (uint)(hitDetection.normal2.x << 16 >> 16);
		uint num4 = (uint)(-((int)num2 + hitDetection.distance));
		int num5 = -((num4 != 0) ? 1 : 0) - ((int)num2 + hitDetection.distance >> 31);
		long num6 = (long)num3 * (long)num4;
		Vector3Int v2 = default(Vector3Int);
		v2.x = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num3 * num5 + (int)num4 * (hitDetection.normal2.x << 16 >> 31)) * 1048576));
		num3 = (uint)(hitDetection.normal2.y << 16 >> 16);
		num6 = (long)num3 * (long)num4;
		v2.y = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num3 * num5 + (int)num4 * (hitDetection.normal2.y << 16 >> 31)) * 1048576));
		num3 = (uint)(hitDetection.normal2.z << 16 >> 16);
		num6 = (long)num3 * (long)num4;
		v2.z = ((int)((uint)num6 >> 12) | (((int)((ulong)num6 >> 32) + (int)num3 * num5 + (int)num4 * (hitDetection.normal2.z << 16 >> 31)) * 1048576));
		vehicle.FUN_2B1FC(v2, hitDetection.position);
		vehicle.FUN_3A020((int)(num2 + 8191) >> 13, hitDetection.position, param3: true);
		Vector3Int vector3Int = Utilities.FUN_24148(vehicle.vTransform, hitDetection.position);
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 7, vector3Int);
		LevelManager.instance.FUN_4E8C8(vector3Int, 48);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			screen.x += physics1.X;
			screen.y += physics1.Y;
			screen.z += physics1.Z;
			vTransform.position = screen;
			switch (((byte)tags - 1) * 16777216 >> 24)
			{
			case 0:
			{
				int y = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
				screen.y = y;
				int num2 = physics1.W + 100;
				int num = 3051;
				if (num2 < 3051)
				{
					num = num2;
				}
				num2 = vTransform.rotation.V02 * num;
				physics1.W = num;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				num = vTransform.rotation.V22 * physics1.W;
				physics1.X = num2 >> 12;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Z = num >> 12;
				if (screen.x < 75563008)
				{
					tags = 2;
				}
				break;
			}
			case 1:
			{
				vr.y -= 8;
				ApplyTransformation();
				int num = vTransform.rotation.V02 * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.X = num >> 12;
				num = vTransform.rotation.V22 * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Z = num >> 12;
				if (vr.y < 2049)
				{
					tags = 3;
				}
				break;
			}
			case 2:
				if (screen.z < 83217193)
				{
					tags = 4;
				}
				break;
			case 3:
			{
				vr.y += 8;
				ApplyTransformation();
				int num = vTransform.rotation.V02 * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.X = num >> 12;
				num = vTransform.rotation.V22 * 3051;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Z = num >> 12;
				if (3071 < vr.y)
				{
					tags = 5;
				}
				break;
			}
			case 4:
				if (screen.x < 70647808)
				{
					tags = 6;
				}
				break;
			case 5:
			{
				int num = physics1.W - 101;
				int num2 = vTransform.rotation.V02 * num;
				physics1.W = num;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics1.X = num2 >> 12;
				if (physics1.W < 0)
				{
					tags = 7;
				}
				break;
			}
			case 6:
				vr.y -= 8;
				ApplyTransformation();
				if (vr.y < 1025)
				{
					GameManager.instance.FUN_30CB0(this, 180);
					tags = 8;
				}
				break;
			case 8:
				if (physics1.X < 22888)
				{
					physics1.X += 64;
				}
				if (74055680 < screen.x)
				{
					tags = 10;
				}
				break;
			case 9:
			{
				vr.z++;
				vr.y++;
				if (vr.x < 227)
				{
					vr.x++;
				}
				ApplyTransformation();
				int num = vTransform.rotation.V02 * 22888;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.X = num >> 12;
				num = vTransform.rotation.V12 * 22888;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Y = num >> 12;
				num = vTransform.rotation.V22 * 22888;
				if (num < 0)
				{
					num += 4095;
				}
				physics1.Z = num >> 12;
				if (341 < vr.z)
				{
					GameManager.instance.FUN_1E14C(DAT_18, GameManager.instance.DAT_C2C, 64);
					GameManager.instance.FUN_309A0(this);
					SCRTBASE.instance.DAT_2C74 = 0;
					GameManager.instance.FUN_31924(10, 1000);
				}
				break;
			}
			}
			if (arg2 == 0)
			{
				return 0u;
			}
			uint volume = GameManager.instance.FUN_1E478(screen);
			GameManager.instance.FUN_1E2C8(DAT_18, volume);
			return 0u;
		}
		case 1:
		{
			DAT_A0 = new Vector3Int(64, 64, 64);
			flags |= 8u;
			GameObject gameObject = new GameObject();
			VigMesh param2 = vData.FUN_2CB74(gameObject, 574u, init: true);
			FUN_4C7AC(param2, gameObject);
			return 0u;
		}
		case 2:
		{
			if (tags != 8)
			{
				return 0u;
			}
			int y = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(y, GameManager.instance.DAT_C2C, 64);
			UIManager.instance.FUN_4E414(screen, new Color32(0, 0, byte.MaxValue, 8));
			VigObject param3 = child2.FUN_2CCBC();
			GameManager.instance.FUN_307CC(param3);
			ConfigContainer cont = FUN_2C5F4(32768);
			VigObject obj = vData.ini.FUN_2C17C(613, typeof(VigObject), 8u);
			Utilities.FUN_2CA94(this, cont, obj);
			Utilities.ParentChildren(this, this);
			tags = 9;
			break;
		}
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		case 10:
			if (arg2 != id)
			{
				if (arg2 != 1000)
				{
					return 0u;
				}
				if ((flags & 0x1000000) == 0)
				{
					return 0u;
				}
			}
			if (SCRTBASE.instance.DAT_2C74 == 0)
			{
				Tuple<List<VigTuple>, VigTuple> tuple = GameManager.instance.FUN_318A8(this);
				tuple.Item1.Remove(tuple.Item2);
				GameManager.instance.worldObjs.Add(tuple.Item2);
				sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E098(param, vData.sndList, 5, 0u, param5: true);
				VigTuple2 vigTuple = GameManager.instance.FUN_2FFD0(id);
				LevelManager.instance.FUN_359CC(vigTuple.array, 36736u);
				tags = 1;
				flags |= 256u;
				ConfigContainer cont = FUN_2C5F4(32768);
				VigObject obj = vData.ini.FUN_2C17C(611, typeof(VigObject), 8u);
				Utilities.FUN_2CA94(this, cont, obj);
				Utilities.ParentChildren(this, this);
				flags |= 2048u;
				FUN_30B78();
				FUN_30BF0();
				SCRTBASE.instance.DAT_2C74 = 1;
			}
			else
			{
				flags |= 16777216u;
			}
			break;
		}
		return 0u;
	}
}
