using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _ANT2_TYPE
{
    Default, 
    Ant2 //FUN_2CAC (ROUTE66.DLL)
};


public class Ant2 : Destructible
{
	private static Vector3Int DAT_138 = new Vector3Int(28672, 28672, 28672);

	private static Vector3Int DAT_148 = new Vector3Int(0, -524288, 0);

	private static Vector3Int DAT_154 = new Vector3Int(30720, 30720, 30720);

	public _ANT2_TYPE state;

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
		if (state == _ANT2_TYPE.Ant2 && FUN_32CF0(hit))
		{
			FUN_2B5C();
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (state == _ANT2_TYPE.Ant2)
		{
			if (arg1 == 2)
			{
				if (tags == 0)
				{
					FUN_30B78();
					int num = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E188(num, GameManager.instance.DAT_C2C, 58);
					GameManager.instance.FUN_1E30C(num, 2048);
				}
			}
			else if (arg1 < 3)
			{
				if (arg1 == 0 && tags == 0)
				{
					FUN_2AF20();
					if (vTransform.position.y < screen.y)
					{
						sbyte b = (sbyte)(DAT_19 - 1);
						DAT_19 = (byte)b;
						if (b == 0)
						{
							Ballistic obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(109, typeof(Ballistic), 8u) as Ballistic;
							uint num2 = GameManager.FUN_2AC5C();
							DAT_19 = (byte)((num2 & 3) + 5);
							obj.flags = 1076u;
							obj.id = 0;
							obj.vTransform.position.x = vTransform.position.x + (int)(((num2 & 3) - 2) * 32768);
							obj.vTransform.position.y = vTransform.position.y;
							obj.vTransform.position.z = vTransform.position.z + ((((int)num2 >> 2) & 3) - 2) * 32768;
							FUN_50F0(ref obj.vTransform.rotation, DAT_154);
							obj.FUN_305FC();
						}
					}
					else
					{
						int num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
						int num3 = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E188(num3, GameManager.instance.DAT_C2C, 66);
						GameManager.instance.FUN_1E30C(num3, 3645);
						num3 = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E188(num3, GameManager.instance.DAT_C2C, 63);
						GameManager.instance.FUN_1E30C(num3, 3645);
						UIManager.instance.FUN_4E338(new Color32(byte.MaxValue, 0, 0, 4));
						Ant3 ant = new GameObject().AddComponent<Ant3>();
						ant.physics1.Y = 1376256;
						ant.physics1.Z = 68812;
						GameManager.instance.FUN_30CB0(ant, 0);
						screen.y = num;
						int num4 = 0;
						int num5;
						short z;
						do
						{
							num4++;
							GameManager.FUN_2AC5C();
							Ballistic obj2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(150, typeof(Ballistic), 8u) as Ballistic;
							obj2.type = 7;
							obj2.flags = 1076u;
							num5 = (int)GameManager.FUN_2AC5C();
							obj2.screen.x = screen.x + (num5 * 819200 >> 15) - 409600;
							num5 = (int)GameManager.FUN_2AC5C();
							obj2.screen.y = screen.y - (num5 * 20480 >> 15) - 61440;
							num5 = (int)GameManager.FUN_2AC5C();
							obj2.screen.z = screen.z + (num5 * 819200 >> 15) - 409600;
							z = (short)GameManager.FUN_2AC5C();
							obj2.vr.z = z;
							obj2.FUN_3066C();
							FUN_50F0(ref obj2.vTransform.rotation, DAT_138);
						}
						while (num4 < 12);
						num4 = (int)GameManager.FUN_2AC5C();
						num5 = (int)GameManager.FUN_2AC5C();
						if (GameManager.instance.worldObjs != null)
						{
							List<VigTuple> worldObjs = GameManager.instance.worldObjs;
							for (int i = 0; i < worldObjs.Count; i++)
							{
								VigObject vObject = worldObjs[i].vObject;
								if (vObject.type == 2 && vObject.maxHalfHealth != 0)
								{
									Vector3Int v = default(Vector3Int);
									v.x = vObject.vTransform.position.x + (num4 * 10240 >> 15) - 5120;
									v.y = vObject.vTransform.position.y;
									v.z = vObject.vTransform.position.z + (num5 * 10240 >> 15) - 5120;
									vObject.FUN_2B370(DAT_148, v);
								}
							}
						}
						Ant4 obj3 = vData.ini.FUN_2C17C(21, typeof(Ant4), 8u, typeof(VigChild)) as Ant4;
						obj3.type = 8;
						z = id;
						obj3.flags = 260u;
						obj3.id = z;
						obj3.screen = screen;
						obj3.maxHalfHealth = 4;
						obj3.FUN_3066C();
						screen = vTransform.position;
						vr = new Vector3Int(0, 0, 0);
						ApplyTransformation();
						tags = 1;
					}
				}
			}
			else
			{
				if (arg1 != 8)
				{
					return 0u;
				}
				if (FUN_32B90((uint)arg2))
				{
					FUN_2B5C();
				}
			}
		}
		return 0u;
	}

	private void FUN_2B5C()
	{
		int num = GameManager.instance.terrain.FUN_1B750((uint)screen.x, (uint)screen.z);
		Ant ant = vData.ini.FUN_2C17C_2(16, typeof(Ant), 8u) as Ant;
		Utilities.ParentChildren(ant, ant);
		ant.flags = 388u;
		VigObject child = ant.child2;
		ant.physics2.Y = screen.x;
		ant.physics2.Z = num;
		ant.physics2.W = screen.z;
		ant.screen.x = screen.x;
		ant.screen.y = num;
		ant.screen.z = screen.z;
		ant.FUN_3066C();
		child.vTransform.rotation.V22 = 2048;
		child.vTransform.rotation.V11 = 2048;
		child.vTransform.rotation.V00 = 2048;
		ant.physics1.X = 32768;
		ant.physics1.Y = 18;
		VigObject vigObject = ant.child2.child2.child2;
		while (vigObject != null && vigObject.id != 1)
		{
			vigObject = vigObject.child;
		}
		ant.DAT_8C = vigObject;
		((Body)vigObject.child2).state = _BODY_TYPE.Ant;
		sbyte param = ant.DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, ant.vData.sndList, 0, ant.vTransform.position, param5: true);
	}

	public static void FUN_50F0(ref Matrix3x3 param1, Vector3Int param2)
	{
		int x = param2.x;
		int y = param2.y;
		int z = param2.z;
		param1.V00 = (short)(param1.V00 * x >> 12);
		param1.V01 = (short)(param1.V01 * y >> 12);
		param1.V02 = (short)(param1.V02 * z >> 12);
		param1.V10 = (short)(param1.V10 * x >> 12);
		param1.V11 = (short)(param1.V11 * y >> 12);
		param1.V12 = (short)(param1.V12 * z >> 12);
		param1.V20 = (short)(param1.V20 * x >> 12);
		param1.V21 = (short)(param1.V21 * y >> 12);
		param1.V22 = (short)(param1.V22 * z >> 12);
	}
}
