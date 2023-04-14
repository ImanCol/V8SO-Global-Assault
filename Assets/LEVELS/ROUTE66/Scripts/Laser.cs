using UnityEngine;

public class Laser : VigObject
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
		flags |= 32u;
		HitDetection hitDetection = new HitDetection(null);
		GameManager.instance.FUN_2FB70(this, hit, hitDetection);
		Vector3Int vector3Int = new Vector3Int(hitDetection.position.x / 2, hitDetection.position.y / 2, hitDetection.position.z / 2);
		LevelManager.instance.FUN_4DE54(vector3Int, 144);
		flags |= 32u;
		uint result = 0u;
		if (hit.self.type == 2)
		{
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			int num = 0;
			Vehicle obj = (Vehicle)hit.self;
			Vector3Int v = new Vector3Int
			{
				x = vigTransform.rotation.V02 << 6,
				y = vigTransform.rotation.V12 << 6,
				z = vigTransform.rotation.V22 << 6
			};
			vector3Int = Utilities.FUN_24148(obj.vTransform, vector3Int);
			obj.FUN_2B370(v, vector3Int);
			UIManager.instance.FUN_4E414(hit.self.vTransform.position, new Color32(0, 128, 0, 8));
			obj.vTransform.position.y -= 5120;
			do
			{
				Throwaway obj2 = LevelManager.instance.xobfList[19].ini.FUN_2C17C(47, typeof(Throwaway), 8u) as Throwaway;
				obj2.physics1.M0 = 0;
				obj2.physics1.M1 = 0;
				obj2.physics1.M2 = 0;
				uint num2 = GameManager.FUN_2AC5C();
				obj2.physics1.Z = (int)((num2 & 0xFFF) - 2048);
				int num3 = (int)GameManager.FUN_2AC5C();
				if (num3 < 0)
				{
					num3 += 15;
				}
				obj2.physics1.W = -(num3 >> 4);
				num2 = GameManager.FUN_2AC5C();
				obj2.physics2.X = (int)((num2 & 0xFFF) - 2048);
				obj2.type = 7;
				obj2.flags |= 436u;
				short id = base.id;
				num++;
				obj2.state = _THROWAWAY_TYPE.Type3;
				obj2.vTransform = GameManager.FUN_2A39C();
				obj2.vTransform.position = vector3Int;
				obj2.FUN_2D1DC();
				obj2.DAT_87 = 1;
				obj2.FUN_305FC();
			}
			while (num < 12);
			result = 0u;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		if (arg1 < 4)
		{
			result = 0u;
			if (arg1 == 0)
			{
				vTransform.position.x += physics1.Z;
				vTransform.position.y += physics1.W;
				vTransform.position.z += physics2.X;
				screen = vTransform.position;
				short m = physics2.M3;
				physics2.M3 = (short)(m - 1);
				result = 0u;
				if (m == 1)
				{
					if (physics2.M2 == 0)
					{
						result = 0u;
					}
					else
					{
						ConfigContainer configContainer = FUN_2C5F4(32768);
						Vector3Int vector3Int = Utilities.FUN_24148(vTransform, configContainer.v3_1);
						int num = GameManager.instance.terrain.FUN_1B750((uint)vector3Int.x, (uint)vector3Int.z);
						if (vector3Int.y < num)
						{
							Laser obj = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Laser), 8u) as Laser;
							short id = base.id;
							obj.type = 8;
							obj.flags = 132u;
							obj.id = id;
							ushort num2 = obj.maxHalfHealth = maxHalfHealth;
							obj.FUN_3066C();
							m = physics2.M2;
							obj.physics2.M3 = 3;
							obj.physics2.M2 = (short)(m - 1);
							obj.physics1.Z = physics1.Z;
							obj.physics1.W = physics1.W;
							obj.physics2.X = physics2.X;
							obj.DAT_80 = DAT_80;
							obj.vTransform = vTransform;
							obj.vTransform.position = vector3Int;
							result = 0u;
						}
						else
						{
							vector3Int.y = num;
							LevelManager.instance.FUN_4DE54(vector3Int, 144);
							result = 0u;
						}
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

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result = 0u;
		if (arg1 == 5)
		{
			GameManager.instance.FUN_309A0(this);
			result = uint.MaxValue;
		}
		return result;
	}
}
