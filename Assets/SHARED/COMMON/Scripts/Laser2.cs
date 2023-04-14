using UnityEngine;

public class Laser2 : VigObject
{
	private static byte[] COLLDR = new byte[32]
	{
		1,
		0,
		0,
		0,
		147,
		230,
		255,
		255,
		127,
		235,
		255,
		255,
		0,
		0,
		0,
		0,
		163,
		108,
		0,
		0,
		130,
		20,
		0,
		0,
		129,
		139,
		1,
		0,
		0,
		0,
		0,
		0
	};

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
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, vData.sndList, 5, vTransform.position);
		LevelManager.instance.FUN_4DE54(vector3Int, 143);
		flags |= 32u;
		uint result = 0u;
		if (hit.self.type == 2)
		{
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vehicle obj = (Vehicle)hit.self;
			obj.FUN_2B370(new Vector3Int
			{
				x = vigTransform.rotation.V02 << 6,
				y = vigTransform.rotation.V12 << 6,
				z = vigTransform.rotation.V22 << 6
			}, Utilities.FUN_24148(obj.vTransform, vector3Int));
			UIManager.instance.FUN_4E414(hit.self.vTransform.position, new Color32(128, 0, 0, 8));
			obj.vTransform.position.y -= 5120;
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
						Vector3Int vector3Int = Utilities.FUN_24148(vTransform, new Vector3Int(15, 22, 101249));
						int num = GameManager.instance.terrain.FUN_1B750((uint)vector3Int.x, (uint)vector3Int.z);
						if (vector3Int.y < num)
						{
							Laser2 obj = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(Laser2), 8u) as Laser2;
							short id = base.id;
							obj.type = 8;
							obj.flags = 536871300u;
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
							LevelManager.instance.FUN_4DE54(vector3Int, 143);
							result = 0u;
						}
					}
				}
			}
			if (arg1 == 1)
			{
				vCollider = new VigCollider(COLLDR);
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
