using UnityEngine;

public class Hook : VigObject
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
			FUN_42330(arg2);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		switch (arg1)
		{
		case 1:
		{
			type = 3;
			if (GameManager.instance.gameMode != _GAME_MODE.Versus2)
			{
				maxHalfHealth = 6;
			}
			else
			{
				maxHalfHealth = 3;
			}
			flags |= 16384u;
			VigObject vigObject = vData.ini.FUN_2C17C(2, typeof(VigObject), 8u);
			result = 0u;
			if (vigObject != null)
			{
				ConfigContainer cont = FUN_2C5F4(32768);
				Utilities.FUN_2CA94(this, cont, vigObject);
				Utilities.ParentChildren(this, this);
				vigObject.FUN_30BF0();
				PDAT_78 = vigObject;
				result = 0u;
			}
			break;
		}
		case 0:
			FUN_42330(arg2);
			result = 0u;
			break;
		case 12:
		{
			Vehicle vehicle = (Vehicle)arg2;
			if (vehicle.target == null || (flags & 0x8000000) != 0 || (vehicle.target.flags & 0x4000) == 0)
			{
				return 0u;
			}
			vehicle.tags = 3;
			VigObject param = PDAT_78.FUN_2CCBC();
			GameManager.instance.FUN_308C4(param);
			DAT_19 = 1;
			PDAT_78 = null;
			maxHalfHealth--;
			Hook2 hook = vData.ini.FUN_2C17C(1, typeof(Hook2), 8u) as Hook2;
			hook.DAT_80 = vehicle.target;
			ConfigContainer configContainer = hook.DAT_A4 = FUN_2C5F4(32768);
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
			hook.DAT_84 = this;
			BufferedBinaryReader reader = hook.DAT_80.vCollider.reader;
			hook.physics1.W = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
			hook.physics2.X = reader.ReadInt32(20);
			hook.physics2.Y = reader.ReadInt32(24);
			Vector3Int vector3Int = Utilities.FUN_24148(hook.DAT_80.vTransform, new Vector3Int(hook.physics1.W, hook.physics2.X, hook.physics2.Y));
			Vector3Int vector3Int2 = default(Vector3Int);
			vector3Int2.x = vector3Int.x - vigTransform.position.x;
			vector3Int2.y = vector3Int.y - vigTransform.position.y;
			vector3Int2.z = vector3Int.z - vigTransform.position.z;
			Vector3Int vector3Int3 = Utilities.FUN_2426C(vigTransform.rotation, new Matrix2x4(vector3Int2.x, vector3Int2.y, vector3Int2.z, 0));
			Utilities.FUN_29FC8(vector3Int3, out Vector3Int vout);
			hook.vTransform.rotation = Utilities.FUN_2A724(vout);
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param2, vData.sndList, 4, vigTransform.position);
			VigObject target = hook.child2;
			target.vTransform.rotation.V11 = 4096;
			target.vTransform.rotation.V00 = 4096;
			target.vTransform.rotation.V22 = 1024;
			hook.vTransform.position = configContainer.v3_1;
			int num = Utilities.FUN_29E84(vector3Int3);
			num /= 2;
			if (458752 < num)
			{
				num = 458752;
			}
			hook.physics2.Z = num;
			hook.physics2.W = 16384;
			hook.tags = 0;
			hook.DAT_A0_2 = (num - 16384) / 3;
			Utilities.FUN_2CC48(this, hook);
			Utilities.ParentChildren(this, this);
			hook.FUN_30B78();
			hook.FUN_30BF0();
			GameManager.instance.FUN_30CB0(hook, 2);
			VigObject vigObject = hook.DAT_88 = vData.ini.FUN_2C17C(3, typeof(VigObject), 8u);
			vigObject.DAT_80 = hook;
			ConfigContainer cont = hook.FUN_2C5F4(32768);
			Utilities.FUN_2CA94(hook, cont, vigObject);
			Utilities.ParentChildren(hook, hook);
			flags |= 134217728u;
			param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param2, vData.sndList, 2);
			result = 480u;
			if (arg2.id < 0)
			{
				result = 480u;
			}
			break;
		}
		default:
		{
			result = 0u;
			if (arg1 != 13 || GameManager.instance.DAT_1084 != 0)
			{
				break;
			}
			Vehicle vehicle = (Vehicle)arg2;
			VigObject target = vehicle.target;
			int num = vehicle.vTransform.position.x - target.vTransform.position.x;
			if (num < 0)
			{
				num = -num;
			}
			result = 0u;
			if (num >= 262144)
			{
				break;
			}
			num = vehicle.vTransform.position.y - target.vTransform.position.y;
			if (num < 0)
			{
				num = -num;
			}
			result = 0u;
			if (num < 262144)
			{
				num = vehicle.vTransform.position.z - target.vTransform.position.z;
				if (num < 0)
				{
					num = -num;
				}
				result = (uint)(((262143 < num) ? 1 : 0) ^ 1);
			}
			break;
		}
		}
		return result;
	}
}
