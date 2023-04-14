using System;
using System.Collections.Generic;
using UnityEngine;

public class LaunchRocket3 : VigObject
{
	public static Vector3Int DAT_C4 = new Vector3Int(0, -2048, 4096);

	public static Vector3Int DAT_D4 = new Vector3Int(0, 0, 0);

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
		uint result = 0u;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			Vector3Int v = Utilities.FUN_24094(vTransform.rotation, DAT_C4);
			vehicle.FUN_2B370(v, vTransform.position);
			int param = -6;
			if (vehicle.id < 0)
			{
				param = -12;
			}
			vehicle.FUN_3A064(param, DAT_D4, param3: true);
			LevelManager.instance.FUN_39AF8(vehicle);
			result = 0u;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 == 2)
		{
			GameManager.instance.FUN_309A0(this);
			result = uint.MaxValue;
		}
		else if (arg1 < 3)
		{
			result = 0u;
			if (arg1 == 0)
			{
				uint num = GameManager.FUN_2AC5C();
				result = 0u;
				if ((num & 7) == 0)
				{
					Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
					dictionary.Add(115, typeof(LaunchRocketChild));
					LaunchRocket4 launchRocket = LevelManager.instance.xobfList[19].ini.FUN_2C17C(114, typeof(LaunchRocket4), 8u, dictionary) as LaunchRocket4;
					Utilities.ParentChildren(launchRocket, launchRocket);
					Vector3Int vector3Int = new Vector3Int(0, 0, 0);
					int num2 = (int)GameManager.FUN_2AC5C();
					vector3Int.x = (num2 & 0xFF) - 128 << 4;
					num2 = (int)GameManager.FUN_2AC5C();
					vector3Int.y = (num2 & 0xFF) - 128 << 4;
					num2 = (int)GameManager.FUN_2AC5C();
					vector3Int.z = 1536 - (num2 & 0xFF) << 4;
					Vector3Int v = vector3Int;
					launchRocket.flags = 180u;
					launchRocket.type = 3;
					launchRocket.maxHalfHealth = 5;
					short z = (short)GameManager.FUN_2AC5C();
					launchRocket.vr.z = z;
					launchRocket.vTransform = vTransform;
					v = (launchRocket.screen = Utilities.ApplyMatrixSV(launchRocket.vTransform.rotation, v));
					launchRocket.FUN_305FC();
					LaunchRocketChild launchRocketChild = launchRocket.child2 as LaunchRocketChild;
					if (launchRocketChild == null)
					{
						result = 0u;
					}
					else
					{
						do
						{
							launchRocketChild.euler = new Vector3(0f, 0f - launchRocket.vTransform.rotation.Matrix2Quaternion.eulerAngles.y, 0f);
							launchRocketChild = (launchRocketChild.child as LaunchRocketChild);
						}
						while (launchRocketChild != null);
						result = 0u;
					}
				}
			}
		}
		else
		{
			result = 0u;
		}
		return result;
	}
}
