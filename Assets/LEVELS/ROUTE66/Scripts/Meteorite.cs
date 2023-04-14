using UnityEngine;

public class Meteorite : VigObject
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
		if (arg1 == 2)
		{
			int num = (int)GameManager.FUN_2AC5C();
			num = num * 12 >> 15;
			int num2 = (int)GameManager.FUN_2AC5C();
			Vector3Int n = default(Vector3Int);
			n.x = (num2 << 8 >> 15) + 2944;
			n.y = 4096;
			num2 = (int)GameManager.FUN_2AC5C();
			n.z = (num2 << 8 >> 15) + 2944;
			VigObject vigObject = GameManager.instance.FUN_31950(33);
			uint num3;
			int param;
			if (vigObject == null)
			{
				param = 900;
			}
			else
			{
				Vehicle vehicle = vigObject.PDAT_78 as Vehicle;
				param = 900;
				if (vehicle != null)
				{
					num3 = 2147418112u;
					if (vehicle.target != null)
					{
						int num4 = 0;
						Vector3Int[] dAT_ = Route66.DAT_5268;
						do
						{
							VigObject target = vehicle.target;
							Vector3Int v = default(Vector3Int);
							v.x = dAT_[num4].x - target.screen.x;
							v.y = dAT_[num4].y - target.screen.y;
							v.z = dAT_[num4].z - target.screen.z;
							Vector2Int vector2Int = Utilities.FUN_2A1C0(v);
							uint num5 = (uint)((int)((uint)vector2Int.x >> 16) | (vector2Int.y << 16));
							if ((int)num5 < (int)num3)
							{
								num3 = num5;
								num = num4;
							}
							num4++;
						}
						while (num4 < 13);
						param = 360;
					}
				}
			}
			GameManager.instance.FUN_30CB0(this, param);
			Meteorite2 meteorite = LevelManager.instance.xobfList[42].ini.FUN_2C17C(11, typeof(Meteorite2), 0u) as Meteorite2;
			meteorite.screen = Route66.DAT_5268[num];
			num = (int)GameManager.FUN_2AC5C();
			meteorite.screen.x = meteorite.screen.x - 409600 + (num * 819200 >> 15);
			num = (int)GameManager.FUN_2AC5C();
			meteorite.id = 1000;
			meteorite.maxHalfHealth = 100;
			meteorite.DAT_19 = 1;
			meteorite.screen.z = meteorite.screen.z - 409600 + (num * 819200 >> 15);
			meteorite.flags |= 384u;
			n = Utilities.VectorNormal(n);
			meteorite.vTransform.position.x = meteorite.screen.x + n.x * -750;
			meteorite.vTransform.position.y = meteorite.screen.y + n.y * -750;
			meteorite.vTransform.position.z = meteorite.screen.z + n.z * -750;
			num = n.x * 30517;
			if (num < 0)
			{
				num += 4095;
			}
			meteorite.physics1.X = num >> 12 << 7;
			num = n.y * 30517;
			if (num < 0)
			{
				num += 4095;
			}
			meteorite.physics1.Y = num >> 12 << 7;
			num = n.z * 30517;
			if (num < 0)
			{
				num += 4095;
			}
			meteorite.physics1.Z = num >> 12 << 7;
			num3 = GameManager.FUN_2AC5C();
			meteorite.physics2.X = (int)((num3 & 0x1FF) << 7);
			num3 = GameManager.FUN_2AC5C();
			meteorite.physics2.Z = (int)((num3 & 0x1FF) << 7);
			meteorite.FUN_2D1DC();
			meteorite.ApplyRotationMatrix();
			meteorite.FUN_305FC();
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 58);
			GameManager.instance.FUN_1E30C(param, 3194);
		}
		return 0u;
	}
}
