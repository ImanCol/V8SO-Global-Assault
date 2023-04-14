using UnityEngine;

public class Windmill2 : VigObject
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
		if (hit.self.type == 7)
		{
			return 0u;
		}
		GameManager.instance.FUN_1DE78(DAT_18);
		VigObject self = hit.self;
		if (self.type == 2)
		{
			Vehicle vehicle = (Vehicle)self;
			Vector3Int v = default(Vector3Int);
			int num = (maxHalfHealth << 11) / (int)(ushort)vehicle.DAT_A6;
			v.x = physics1.Z * num;
			v.y = physics1.W * num;
			v.z = physics2.X * num;
			vehicle.FUN_2B370(v, vTransform.position);
		}
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, vData.sndList, 2, vTransform.position);
		UIManager.instance.FUN_4E414(vTransform.position, new Color32(64, 0, 0, 8));
		flags |= 32u;
		GameManager.instance.FUN_30CB0(this, 30);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		if (arg1 == 2)
		{
			LevelManager.instance.FUN_4DE54(vTransform.position, 13);
			GameManager.instance.FUN_1E628(DAT_18, GameManager.instance.DAT_C2C, 14, vTransform.position);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		if (arg1 < 3)
		{
			if (arg1 != 0)
			{
				return 0u;
			}
			vr.z += 136;
			int num5;
			if ((flags & 1) == 0)
			{
				screen.x += physics1.Z;
				screen.y += physics1.W;
				screen.z += physics2.X;
				VigObject dAT_ = DAT_84;
				physics1.W += 56;
				if (dAT_ != null)
				{
					Vector3Int vector3Int = default(Vector3Int);
					vector3Int.x = dAT_.screen.x - screen.x;
					vector3Int.y = dAT_.screen.y - screen.y;
					vector3Int.z = dAT_.screen.z - screen.z;
					uint num = (uint)((long)vector3Int.z * (long)vector3Int.z);
					int num2 = (int)((ulong)((long)vector3Int.z * (long)vector3Int.z) >> 32);
					uint num3 = (uint)((int)((long)vector3Int.x * (long)vector3Int.x) + (int)num);
					Utilities.FUN_2ABC4(num3, (int)((ulong)((long)vector3Int.x * (long)vector3Int.x) >> 32) + num2 + ((num3 < num) ? 1 : 0));
					long num4 = (long)physics1.W * (long)physics1.W;
					num = (uint)num4;
					num2 = (int)((ulong)num4 >> 32);
					num3 = (uint)(vector3Int.y * 112);
					num5 = Utilities.FUN_2ABC4(num + num3, num2 + ((int)num3 >> 31) + ((num + num3 < num3) ? 1 : 0));
					num5 -= physics1.W;
					if (num5 != 0)
					{
						int num6 = vector3Int.x * 56 / num5 - physics1.Z;
						if (num6 < 0)
						{
							num6 += 15;
						}
						physics1.Z += num6 >> 4;
						num5 = vector3Int.z * 56 / num5 - physics2.X;
						if (num5 < 0)
						{
							num5 += 15;
						}
						physics2.X += num5 >> 4;
					}
				}
			}
			ApplyTransformation();
			num5 = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
			if (num5 <= vTransform.position.y)
			{
				LevelManager.instance.FUN_4DE54(vTransform.position, 13);
				GameManager.instance.FUN_1E628(DAT_18, GameManager.instance.DAT_C2C, 14, vTransform.position);
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			}
		}
		return 0u;
	}
}
