using UnityEngine;

public class CropDuster : Destructible
{
	private static Vector3Int[] orangeGroves = new Vector3Int[2]
	{
		new Vector3Int(53614790, 3051609, 80010258),
		new Vector3Int(60536922, 3055244, 80001003)
	};

	private static Vector3Int[] roads = new Vector3Int[4]
	{
		new Vector3Int(55581339, 3057279, 78355592),
		new Vector3Int(53732725, 3069589, 78611697),
		new Vector3Int(58709972, 3057295, 78298618),
		new Vector3Int(60509052, 3056724, 78451276)
	};

	private static Vector3Int[] stations = new Vector3Int[2]
	{
		new Vector3Int(54645420, 3057302, 83609378),
		new Vector3Int(59150104, 3050330, 84728226)
	};

	public Vehicle.AI ai;

	public int pathID;

	public bool drop;

	public int pesticideID;

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
		if (hit.self.type != 8 || tags != -1 || DAT_1A == 46)
		{
			return 0u;
		}
		if (hit.self.GetType() == typeof(Bullet))
		{
			StartFlight();
		}
		else
		{
			FUN_32CF0(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 1:
		{
			GameObject gameObject = new GameObject();
			VigObject vigObject = gameObject.AddComponent<VigObject>();
			vigObject.vr = new Vector3Int(0, 2048, 0);
			vigObject.vData = vData;
			vigObject.DAT_1A = DAT_1A;
			vigObject.id = id;
			vigObject.vMesh = vData.FUN_1FD18(gameObject, 10u, init: true);
			vMesh = null;
			Utilities.FUN_2CC48(this, vigObject);
			vigObject.transform.parent = base.transform;
			vigObject.ApplyTransformation();
			GameObject gameObject2 = new GameObject();
			VigObject vigObject2 = gameObject2.AddComponent<VigObject>();
			vigObject2.vData = vData;
			vigObject2.DAT_1A = DAT_1A;
			vigObject2.id = id;
			vigObject2.vMesh = vData.FUN_1FD18(gameObject2, 100u, init: true);
			Utilities.FUN_2CC48(vigObject, vigObject2);
			vigObject2.transform.parent = vigObject.transform;
			vigObject2.screen = new Vector3Int(-1000, -15000, -90000);
			vigObject2.vr.x = -120;
			vigObject2.ApplyTransformation();
			tags = -1;
			ai.DAT_00 = -1;
			pathID = 0;
			flags |= 128u;
			vr.y += 2048;
			FUN_305FC();
			ApplyTransformation();
			GameManager.instance.FUN_30CB0(this, 6800);
			break;
		}
		case 0:
		{
			if (DAT_1A == 46)
			{
				return 0u;
			}
			int num4;
			int x;
			int num2;
			int num;
			int x2;
			int num6;
			uint num5;
			switch (tags)
			{
			case 5:
				num5 = (uint)Utilities.FUN_51E08(this, ref ai, 65536);
				goto IL_0204;
			case 0:
			case 2:
			case 3:
			case 4:
				num5 = (uint)Utilities.FUN_51E08(this, ref ai, 524288);
				goto IL_0204;
			case 1:
				{
					int y = orangeGroves[pathID].x - screen.x;
					x = orangeGroves[pathID].z - screen.z;
					num = (int)Utilities.Ratan2(y, x);
					num = (num - vr.y) * 1048576 >> 16;
					num2 = -512;
					if (-513 < num)
					{
						num2 = 512;
						if (num < 513)
						{
							num2 = num;
						}
					}
					int num3 = num2 - vr.z >> 4;
					num2 = -16;
					if (-17 < num3)
					{
						num2 = 16;
						if (num3 < 17)
						{
							num2 = num3;
						}
					}
					num2 = vr.z + num2;
					vr.z = num2;
					vr.y += num2 * 65536 >> 22;
					y = vTransform.rotation.V02 * 1525 * 3;
					if (y < 0)
					{
						y += 4095;
					}
					x = vTransform.rotation.V22 * 1525 * 3;
					screen.x += y >> 12;
					if (x < 0)
					{
						x += 4095;
					}
					screen.z += x >> 12;
					child2.child2.vr.z += 96;
					num4 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
					if (screen.y < 2674161)
					{
						screen.y += 2048;
					}
					if (!drop)
					{
						GameManager.instance.FUN_30CB0(this, 40);
						drop = true;
					}
					if (num > 16385)
					{
						tags++;
						drop = false;
						ai.FUN_51C54(screen, roads[pathID * 2 + 1], uint.MaxValue, 0u);
					}
					ApplyTransformation();
					child2.child2.ApplyTransformation();
					break;
				}
				IL_0204:
				num = (int)num5;
				num = (num - vr.y) * 1048576 >> 16;
				num2 = -512;
				if (-513 < num)
				{
					num2 = 512;
					if (num < 513)
					{
						num2 = num;
					}
				}
				num4 = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z) - 24576;
				x = 1;
				if (screen.z < 83268183)
				{
					if (screen.y < 2426353)
					{
						int num3 = num2 - vr.z >> 4;
						num2 = -16;
						if (-17 < num3)
						{
							num2 = 16;
							if (num3 < 17)
							{
								num2 = num3;
							}
						}
						num2 = vr.z + num2;
						vr.z = num2;
						x = 3;
						child2.child2.vr.z += 96;
					}
					else
					{
						screen.y -= 2048;
						child2.child2.vr.z += 64;
					}
				}
				else if (num4 - screen.y > 0)
				{
					if (screen.z > 83595863 || pathID == 0)
					{
						screen.y += 2048;
						vr.z = 0;
						child2.child2.vr.z += 64;
					}
				}
				else
				{
					screen.y = num4;
					child2.child2.vr.z += 32;
				}
				vr.y += num2 * 65536 >> 22;
				num = (int)((num5 & 0xFFF) * 2);
				num6 = vTransform.rotation.V02 * 1525 * x;
				if (num6 < 0)
				{
					num6 += 4095;
				}
				x2 = screen.x + (num6 >> 12);
				screen.x = x2;
				num6 = vTransform.rotation.V22 * 1525 * x;
				if (num6 < 0)
				{
					num6 += 4095;
				}
				screen.z += num6 >> 12;
				ApplyTransformation();
				child2.child2.ApplyTransformation();
				if (ai.DAT_00 < 0)
				{
					if (tags != 5)
					{
						tags++;
					}
					if (tags == 3)
					{
						ai.FUN_51C54(screen, roads[pathID * 2], uint.MaxValue, 0u);
					}
					else if (tags == 4)
					{
						ai.FUN_51C54(screen, stations[pathID], uint.MaxValue, 0u);
					}
					else if (tags == 5 && screen.y >= num4 && screen.z > stations[pathID].z)
					{
						tags = -1;
						GameManager.instance.FUN_1DE78(DAT_18);
						GameManager.instance.FUN_30CB0(this, 6800);
					}
				}
				break;
			}
			if (tags != -1)
			{
				num5 = GameManager.instance.FUN_1E7A8(screen);
				GameManager.instance.FUN_1E2C8(DAT_18, num5 << 1);
			}
			break;
		}
		case 2:
			if (DAT_1A != 45)
			{
				break;
			}
			if (tags == -1)
			{
				StartFlight();
				return 0u;
			}
			if (tags == 1)
			{
				if (vTransform.rotation.V10 < 500 && vTransform.rotation.V10 > -500 && ((screen.x > 54365819 && screen.x < 55469339) || (screen.x > 55695109 && screen.x < 56786580) || (screen.x > 57495227 && screen.x < 58629552) || (screen.x > 58819226 && screen.x < 59946479)))
				{
					DropPesticide();
				}
				drop = false;
			}
			break;
		case 4:
			ai.FUN_51CC0();
			break;
		case 8:
			if (tags == -1 && DAT_1A == 45)
			{
				StartFlight();
				return 0u;
			}
			break;
		}
		return 0u;
	}

	private void StartFlight()
	{
		tags = 0;
		ai.FUN_51C54(screen, orangeGroves[pathID], uint.MaxValue, 0u);
		int num = GameManager.instance.FUN_1DD9C();
		DAT_18 = (sbyte)num;
		GameManager.instance.FUN_1E098(num, vData.sndList, 7, 0u, param5: true);
		pathID = ((pathID == 0) ? 1 : 0);
	}

	private void DropPesticide()
	{
		uint num = 0u;
		uint num2 = 65024u;
		Vector3Int v = new Vector3Int(0, 0, 0);
		v.y = 2048;
		do
		{
			Pesticide obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(23, typeof(Pesticide), 8u) as Pesticide;
			obj.flags = 1073742740u;
			obj.type = 8;
			obj.maxHalfHealth = 40;
			obj.DAT_80 = null;
			obj.id = 0;
			obj.vTransform.rotation = new Matrix3x3
			{
				V00 = 4096,
				V01 = 0,
				V02 = 0,
				V10 = 0,
				V11 = 4096,
				V12 = 0,
				V20 = 0,
				V21 = 0,
				V22 = 4096
			};
			obj.vTransform.position = vTransform.position;
			if ((num & 1) == 0)
			{
				v.x = (short)num2;
			}
			else
			{
				v.x = (short)num * 1024 - 512;
			}
			Vector3Int vector3Int = Utilities.ApplyMatrixSV(vTransform.rotation, v);
			int num3 = 128;
			if (num3 < 0)
			{
				num3 += 127;
			}
			obj.physics1.Z = (num3 >> 7) * vector3Int.x;
			num3 = -65536;
			if (num3 < 0)
			{
				num3 += 127;
			}
			obj.physics1.W = (num3 >> 7) + vector3Int.y;
			num3 = 128;
			if (num3 < 0)
			{
				num3 += 127;
			}
			obj.physics2.X = (num3 >> 7) * vector3Int.z;
			obj.FUN_305FC();
			num++;
			num2 -= 1024;
		}
		while (7 >= (int)num);
	}
}