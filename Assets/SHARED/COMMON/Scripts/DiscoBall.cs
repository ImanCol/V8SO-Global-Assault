using UnityEngine;

public class DiscoBall : VigObject
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
			if (self.type == 2)
			{
				self.physics1.Y = -195200;
				self.physics2.Y = 50000;
				if (self.id < 0)
				{
					GameManager.instance.FUN_15B00(~self.id, byte.MaxValue, 2, 128);
				}
			}
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, vTransform.position);
			LevelManager.instance.FUN_4DE54(vTransform.position, 42);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 != 2)
		{
			if (arg1 >= 3)
			{
				return 0u;
			}
			if (arg1 != 0)
			{
				return 0u;
			}
			vTransform.position.x += physics1.Z;
			vTransform.position.y += physics1.W;
			vTransform.position.z += physics2.X;
			int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			if (vTransform.position.y <= num)
			{
				return 0u;
			}
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, vTransform.position);
			LevelManager.instance.FUN_4DE54(vTransform.position, 42);
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
			if (vigObject == null)
			{
				Vector3Int vector3Int = Utilities.FUN_24094(vigTransform.rotation, screen);
				physics1.Z = vector3Int.x;
				physics1.W = vector3Int.y;
				physics2.X = vector3Int.z;
				physics1.Z = physics1.Z << 9 >> 12;
				physics1.W = physics1.W << 9 >> 12;
				physics2.X = physics2.X << 9 >> 12;
			}
			else
			{
				Vector3Int vin = default(Vector3Int);
				vin.x = vigObject.screen.x - vigTransform.position.x;
				vin.y = vigObject.screen.y - vigTransform.position.y;
				vin.z = vigObject.screen.z - vigTransform.position.z;
				Utilities.FUN_29FC8(vin, out Vector3Int vout);
				physics1.Z = vout.x * 22888 >> 12;
				physics1.W = vout.y * 22888 >> 12;
				physics2.X = vout.z * 22888 >> 12;
			}
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
