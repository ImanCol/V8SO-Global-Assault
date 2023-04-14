using System;
using System.Collections.Generic;
using UnityEngine;

public class Invasion : VigObject
{
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
			if (FUN_42330(arg2) < 1)
			{
				return 0u;
			}
			child2.vr.y += 34;
			if (arg2 != 0)
			{
				child2.ApplyRotationMatrix();
				return 0u;
			}
			break;
		case 10:
		{
			if (arg2 != 17427)
			{
				break;
			}
			Vehicle vehicle = Utilities.FUN_2CD78(this) as Vehicle;
			if (vehicle == null || id != 0)
			{
				return 0u;
			}
			ushort num = 3;
			if (vehicle.id < 0)
			{
				num = 5;
			}
			ConfigContainer param = child2.FUN_2C5F4(32768);
			int num2 = 0;
			short num3 = 1;
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(child2, param);
			do
			{
				Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
				dictionary.Add(vData.ini.GetContainerIndex(3, 0), typeof(VigChild));
				Invasion2 invasion = vData.ini.FUN_2C17C(3, typeof(Invasion2), 8u, dictionary) as Invasion2;
				Utilities.ParentChildren(invasion, invasion);
				invasion.type = 4;
				invasion.id = (short)num2;
				invasion.flags = 162u;
				invasion.vTransform = vigTransform;
				invasion.physics2.M3 = num3;
				int num4 = vehicle.physics1.X;
				if (num4 < 0)
				{
					num4 += 127;
				}
				invasion.physics1.Z = (num4 >> 7) + vigTransform.rotation.V02;
				num4 = vehicle.physics1.Y;
				if (num4 < 0)
				{
					num4 += 127;
				}
				invasion.physics1.W = (num4 >> 7) + vigTransform.rotation.V12;
				num4 = vehicle.physics1.Z;
				if (num4 < 0)
				{
					num4 += 127;
				}
				num3 = (short)(num3 + 8);
				num2++;
				invasion.physics2.X = (num4 >> 7) + vigTransform.rotation.V22;
				invasion.FUN_2D1DC();
				invasion.FUN_305FC();
			}
			while (num2 < 4);
			Vector3Int vin = default(Vector3Int);
			vin.x = vehicle.screen.x - vehicle.vTransform.position.x;
			vin.y = vehicle.screen.y - vehicle.vTransform.position.y;
			vin.z = vehicle.screen.z - vehicle.vTransform.position.z;
			num2 = Utilities.FUN_29FC8(vin, out Vector3Int _);
			vin = vehicle.screen;
			num2 = 0;
			num3 = 360;
			do
			{
				Saucer saucer = vData.ini.FUN_2C17C(2, typeof(Saucer), 8u) as Saucer;
				saucer.type = 8;
				saucer.flags = 1610612864u;
				saucer.id = vehicle.id;
				saucer.tags = 1;
				saucer.screen.x = vin.x;
				saucer.screen.y = vin.y - 2097152;
				saucer.maxHalfHealth = num;
				if (vehicle.doubleDamage != 0)
				{
					saucer.maxHalfHealth = (ushort)(num * 2);
				}
				saucer.screen.z = vin.z;
				int num4 = (((num2 << 12) / 3) & 0xFFF) * 2;
				short z = GameManager.DAT_65C90[num4 + 1];
				saucer.physics1.W = 0;
				saucer.physics1.Z = z;
				z = GameManager.DAT_65C90[num4];
				num2++;
				saucer.physics2.M3 = num3;
				num3 = (short)(num3 + 120);
				saucer.DAT_80 = vehicle;
				saucer.DAT_84 = vehicle;
				GameManager.instance.DAT_1084++;
				saucer.physics2.X = z;
				saucer.FUN_3066C();
			}
			while (num2 < 3);
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, vData.sndList, 4, vigTransform.position);
			num3 = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num3;
			if (num3 == 0)
			{
				FUN_3A368();
			}
			if (-1 < vehicle.id)
			{
				id = 1400;
				return 1400u;
			}
			id = 1280;
			return 1280u;
		}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		switch (arg1)
		{
		case 1:
			FUN_2C344(vData, 1, 0u);
			Utilities.ParentChildren(this, this);
			maxHalfHealth = 3;
			flags |= 16384u;
			break;
		case 12:
		{
			VigObject vigObject = ((Vehicle)arg2).target;
			if (vigObject == null)
			{
				vigObject = arg2;
			}
			ConfigContainer param = child2.FUN_2C5F4(32768);
			ushort num2 = 3;
			if (vigObject.id < 0)
			{
				num2 = 5;
			}
			int num3 = 0;
			short num4 = 1;
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(child2, param);
			do
			{
				Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
				dictionary.Add(vData.ini.GetContainerIndex(3, 0), typeof(VigChild));
				Invasion2 invasion = vData.ini.FUN_2C17C(3, typeof(Invasion2), 8u, dictionary) as Invasion2;
				Utilities.ParentChildren(invasion, invasion);
				invasion.type = 4;
				invasion.id = (short)num3;
				invasion.flags = 162u;
				invasion.vTransform = vigTransform;
				invasion.physics2.M3 = num4;
				int num5 = arg2.physics1.X;
				if (num5 < 0)
				{
					num5 += 127;
				}
				invasion.physics1.Z = (num5 >> 7) + vigTransform.rotation.V02;
				num5 = arg2.physics1.Y;
				if (num5 < 0)
				{
					num5 += 127;
				}
				invasion.physics1.W = (num5 >> 7) + vigTransform.rotation.V12;
				num5 = arg2.physics1.Z;
				if (num5 < 0)
				{
					num5 += 127;
				}
				num4 = (short)(num4 + 8);
				num3++;
				invasion.physics2.X = (num5 >> 7) + vigTransform.rotation.V22;
				invasion.FUN_2D1DC();
				invasion.FUN_305FC();
			}
			while (num3 < 4);
			Vector3Int vin = default(Vector3Int);
			vin.x = vigObject.screen.x - arg2.vTransform.position.x;
			vin.y = vigObject.screen.y - arg2.vTransform.position.y;
			vin.z = vigObject.screen.z - arg2.vTransform.position.z;
			num3 = Utilities.FUN_29FC8(vin, out Vector3Int vout);
			if (num3 < 1310720)
			{
				vin = vigObject.screen;
			}
			else
			{
				vin.x = arg2.vTransform.position.x + vout.x * 320;
				vin.y = arg2.vTransform.position.y + vout.y * 320;
				vin.z = arg2.vTransform.position.z + vout.z * 320;
			}
			num3 = 0;
			num4 = 360;
			do
			{
				Saucer saucer = vData.ini.FUN_2C17C(2, typeof(Saucer), 8u) as Saucer;
				saucer.type = 8;
				saucer.flags = 1610612864u;
				if (arg2 != vigObject)
				{
					saucer.id = arg2.id;
				}
				saucer.screen.x = vin.x;
				saucer.screen.y = vin.y - 786432;
				saucer.maxHalfHealth = num2;
				if (((Vehicle)arg2).doubleDamage != 0)
				{
					saucer.maxHalfHealth = (ushort)(num2 * 2);
				}
				saucer.screen.z = vin.z;
				int num5 = (((num3 << 12) / 3) & 0xFFF) * 2;
				short z = GameManager.DAT_65C90[num5 + 1];
				saucer.physics1.W = 0;
				saucer.physics1.Z = z;
				z = GameManager.DAT_65C90[num5];
				num3++;
				saucer.physics2.M3 = num4;
				num4 = (short)(num4 + 60);
				saucer.DAT_80 = arg2;
				saucer.DAT_84 = vigObject;
				GameManager.instance.DAT_1084++;
				saucer.physics2.X = z;
				saucer.FUN_3066C();
			}
			while (num3 < 3);
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param2, vData.sndList, 2);
			param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, vData.sndList, 4, vigTransform.position);
			num4 = (short)(maxHalfHealth - 1);
			maxHalfHealth = (ushort)num4;
			if (num4 == 0)
			{
				FUN_3A368();
			}
			if (-1 < arg2.id)
			{
				return 1200u;
			}
			return 840u;
		}
		default:
			return 0u;
		case 13:
		{
			if (GameManager.instance.DAT_1084 != 0)
			{
				return 0u;
			}
			int num = Utilities.FUN_29F6C(arg2.screen, ((Vehicle)arg2).target.screen);
			if (409600 >= num)
			{
				return 0u;
			}
			return 1u;
		}
		case 0:
		{
			int num = FUN_42330(arg2);
			if (num < 1)
			{
				return 0u;
			}
			child2.vr.y += 34;
			if (arg2 != null)
			{
				child2.ApplyRotationMatrix();
				return 0u;
			}
			break;
		}
		}
		return 0u;
	}
}
