using System.Collections.Generic;
using UnityEngine;

public class DiscoBall2 : VigObject
{
	private static byte[] DAT_20 = new byte[32]
	{
		1,
		0,
		0,
		0,
		0,
		192,
		255,
		255,
		0,
		192,
		255,
		255,
		0,
		192,
		255,
		255,
		0,
		64,
		0,
		0,
		0,
		64,
		0,
		0,
		0,
		64,
		0,
		0,
		0,
		0,
		0,
		0
	};

	private static Color32[] DAT_950 = new Color32[3]
	{
		new Color32(128, 0, 0, 8),
		new Color32(0, 128, 0, 8),
		new Color32(0, 0, 128, 8)
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
		if (hit.object2.type != 3)
		{
			VigObject self = hit.self;
			if (self.type == 3)
			{
				return 0u;
			}
			if (self.type == 8 && self.GetType() == typeof(Bullet))
			{
				return 0u;
			}
			VigObject vigObject = null;
			VigObject self2 = hit.self;
			if (self2.type == 8)
			{
				if (self2.GetType() == typeof(Bullet))
				{
					return 0u;
				}
				if (self2.GetType() == typeof(StarPower2))
				{
					return 0u;
				}
			}
			int num = 20480000;
			if (self2.type == 2)
			{
				Vehicle vehicle = (Vehicle)self2;
				vehicle.physics1.Y = -195200;
				vehicle.physics2.Y = 50000;
				int param = vehicle.FUN_3B078(DAT_80, (ushort)DAT_1A, -IDAT_78, 1u);
				vehicle.FUN_3A020(param, new Vector3Int(0, 0, 0), param3: true);
				if (vehicle.id < 0)
				{
					GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
				}
				int param2 = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 65, vTransform.position);
				LevelManager.instance.FUN_4DE54(vTransform.position, 42);
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
			IDAT_74 = hit.object2.id;
			int id = DAT_80.id;
			short num2 = (short)((id >= 0) ? (-1) : GameManager.instance.DAT_1128[~id]);
			List<VigTuple> worldObjs = GameManager.instance.worldObjs;
			for (int i = 0; i < worldObjs.Count; i++)
			{
				VigObject vObject = worldObjs[i].vObject;
				VigObject vigObject2 = vigObject;
				int param = num;
				if (vObject.type != 2 || (vObject.flags & 0x4000) == 0)
				{
					vigObject = vigObject2;
					num = param;
				}
				else if ((id = vObject.id) != IDAT_74 && (0 < id || num2 != GameManager.instance.DAT_1128[~id]))
				{
					param = Utilities.FUN_29F6C(vObject.vTransform.position, vTransform.position);
					vigObject2 = vObject;
					if (param < num)
					{
						vigObject = vigObject2;
						num = param;
					}
				}
			}
			if (vigObject != null)
			{
				Vector3Int vout = new Vector3Int(vigObject.screen.x - vTransform.position.x, vigObject.screen.y - vTransform.position.y, vigObject.screen.z - vTransform.position.z);
				Utilities.FUN_2A098(vout, out vout);
				physics1.Z = vout.x * 6;
				physics1.W = vout.y * 6;
				physics2.X = vout.z * 6;
				flags |= 536870912u;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 2)
		{
			if (arg1 < 3)
			{
				if (arg1 != 0)
				{
					return 0u;
				}
				vTransform.position.x += physics1.Z;
				vTransform.position.y += physics1.W;
				vTransform.position.z += physics2.X;
				physics1.W += 56;
				int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				if (vTransform.position.y <= num)
				{
					return 0u;
				}
				Vector3Int vector3Int = Utilities.VectorNormal(GameManager.instance.terrain.FUN_1B998((uint)vTransform.position.x, (uint)vTransform.position.z));
				screen.y = num;
				num = vector3Int.x * physics1.Z + vector3Int.y * physics1.W + vector3Int.z * physics2.X;
				if (num < 0)
				{
					num += 2047;
				}
				num >>= 11;
				if (-1 < num)
				{
					return 0u;
				}
				int num2 = num * vector3Int.x;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics1.Z -= num2 >> 12;
				num2 = num * vector3Int.y;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics1.W -= num2 >> 12;
				num *= vector3Int.z;
				if (num < 0)
				{
					num += 4095;
				}
				physics2.X -= num >> 12;
				return 0u;
			}
			return 0u;
		}
		GameManager.instance.FUN_309A0(this);
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (arg1 == 5)
		{
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			GameObject gameObject = new GameObject();
			VigObject vigObject = gameObject.AddComponent<VigObject>();
			Utilities.FUN_2CC9C(this, vigObject);
			Utilities.ParentChildren(this, this);
			VigMesh vMesh = base.vMesh;
			vigObject.flags |= 1040u;
			vigObject.vTransform.rotation = vTransform.rotation;
			vigObject.vMesh = vData.FUN_1FD18(gameObject, vMesh.tmdID, init: true);
			UnityEngine.Object.Destroy(base.vMesh.GetRenderer());
			base.vMesh = null;
			vCollider = new VigCollider(DAT_20);
			flags |= 128u;
			FUN_30C20();
			vTransform = GameManager.FUN_2A39C();
			vTransform.position = vigTransform.position;
			vigObject = DAT_84;
			Vector3Int vector3Int = Utilities.FUN_24094(vigTransform.rotation, screen);
			physics1.Z = vector3Int.x;
			physics1.W = vector3Int.y;
			physics2.X = vector3Int.z;
			physics1.Z = physics1.Z << 9 >> 12;
			physics1.W = physics1.W << 9 >> 22;
			physics2.X = physics2.X << 9 >> 12;
			FUN_2CCBC();
			base.transform.parent = null;
			FUN_305FC();
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, vData.sndList, 3, vigTransform.position);
			UIManager.instance.FUN_4E414(vigTransform.position, DAT_950[tags]);
			return uint.MaxValue;
		}
		return 0u;
	}
}
