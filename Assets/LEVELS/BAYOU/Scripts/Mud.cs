using UnityEngine;

public class Mud : VigObject
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
		if (arg1 == 0)
		{
			Vehicle vehicle = (Vehicle)child;
			int num = vehicle.physics1.W - 4577;
			if (num < 0)
			{
				num = vehicle.physics1.W - 4574;
			}
			num >>= 2;
			int num2 = 0;
			int num3 = 0;
			do
			{
				Wheel wheel = vehicle.wheels[num3];
				if (wheel != null)
				{
					int num4 = wheel.physics1.Z - wheel.physics2.X;
					if (0 < num4)
					{
						Vector3Int v = default(Vector3Int);
						v.x = wheel.screen.x;
						v.y = wheel.screen.y + wheel.physics2.X;
						v.z = wheel.screen.z;
						Vector3Int vector3Int = Utilities.FUN_24148(vehicle.vTransform, v);
						TileData tileByPosition = GameManager.instance.terrain.GetTileByPosition((uint)vector3Int.x, (uint)vector3Int.z);
						int num5 = num4;
						if (tileByPosition.DAT_10[3] == 0)
						{
							if (256 < num4)
							{
								num5 = 256;
							}
							wheel.physics2.X += num5;
						}
						else if (0 < num)
						{
							if (num < num4)
							{
								num5 = num;
							}
							wheel.physics2.X += num5;
						}
						num2 += num4;
					}
				}
				num3++;
			}
			while (num3 < 4);
			if (num2 == 0)
			{
				vehicle.flags &= 4294836223u;
				for (int i = 0; i < 6; i++)
				{
					if (vehicle.wheels[i] != null)
					{
						vehicle.wheels[i].flags &= 3221225471u;
					}
				}
				GameManager.instance.FUN_30904(this);
				return uint.MaxValue;
			}
		}
		return 0u;
	}
}
