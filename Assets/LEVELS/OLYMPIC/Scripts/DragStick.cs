using UnityEngine;

public class DragStick : VigObject
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
		VigObject self = hit.self;
		if (self.type != 2)
		{
			return 0u;
		}
		Vehicle vehicle = (Vehicle)self;
		if (-1 < self.id)
		{
			return 0u;
		}
		if (DAT_4A + 36864 < 34816)
		{
			return 0u;
		}
		BufferedBinaryReader reader = self.vCollider.reader;
		DAT_80 = self;
		ushort num = (!(vehicle.body[0] == null)) ? ((ushort)(vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth)) : vehicle.maxHalfHealth;
		physics1.Z = num - 100;
		flags |= 32u;
		physics1.W = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
		physics2.X = reader.ReadInt32(20);
		physics2.Y = reader.ReadInt32(24);
		FUN_30B78();
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E580(param, LevelManager.instance.xobfList[42].sndList, 5, vTransform.position);
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			Vehicle vehicle = DAT_80 as Vehicle;
			if (vehicle == null)
			{
				VigObject child = child2;
				int num = -child.vTransform.rotation.V22 + 4096;
				if (num < 0)
				{
					num = -child.vTransform.rotation.V22 + 4111;
				}
				child.vTransform.rotation.V22 += (short)(num >> 4);
				num = -vTransform.rotation.V11;
				if (0 < vTransform.rotation.V11)
				{
					num += 15;
				}
				int num2 = vTransform.rotation.V10;
				if (num2 < 0)
				{
					num2 += 15;
				}
				FUN_24700((short)(num >> 4), (short)(num2 >> 4), 0);
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
				return 0u;
			}
			Vector3Int v = Utilities.FUN_24148(vehicle.vTransform, new Vector3Int(physics1.W, physics2.X, physics2.Y));
			Vector3Int vector3Int = default(Vector3Int);
			vector3Int.x = v.x - vTransform.position.x;
			vector3Int.y = v.y - vTransform.position.y;
			vector3Int.z = v.z - vTransform.position.z;
			int num3 = Utilities.FUN_29FC8(vector3Int, out Vector3Int vout);
			vTransform.rotation = Utilities.FUN_2A724(vout);
			num3 = (num3 << 12) / physics1.Y;
			if (num3 < 8192 && (InputManager.controllers[~vehicle.id].GetAxis() & 0x1000000) == 0 && 34815u < (uint)(ushort)(DAT_4A - 28672))
			{
				if (vehicle.body[0] != null)
				{
					if (physics1.Z <= vehicle.body[0].maxHalfHealth + vehicle.body[1].maxHalfHealth)
					{
						child2.vTransform.rotation.V22 = (short)num3;
						if (num3 < 4097)
						{
							return 0u;
						}
						num3 = 4096 - num3;
						vector3Int.x = vout.x * num3;
						if (vector3Int.x < 0)
						{
							vector3Int.x += 127;
						}
						vector3Int.y = vout.y * num3;
						vector3Int.x >>= 7;
						if (vector3Int.y < 0)
						{
							vector3Int.y += 127;
						}
						vector3Int.y >>= 7;
						num3 = vout.z * num3;
						if (num3 < 0)
						{
							num3 += 127;
						}
						vector3Int.z = num3 >> 7;
						vehicle.FUN_2B370(vector3Int, v);
						return 0u;
					}
					DAT_80 = null;
					goto IL_03f2;
				}
				if (physics1.Z <= vehicle.maxHalfHealth)
				{
					child2.vTransform.rotation.V22 = (short)num3;
					if (num3 < 4097)
					{
						return 0u;
					}
					num3 = 4096 - num3;
					vector3Int.x = vout.x * num3;
					if (vector3Int.x < 0)
					{
						vector3Int.x += 127;
					}
					vector3Int.y = vout.y * num3;
					vector3Int.x >>= 7;
					if (vector3Int.y < 0)
					{
						vector3Int.y += 127;
					}
					vector3Int.y >>= 7;
					num3 = vout.z * num3;
					if (num3 < 0)
					{
						num3 += 127;
					}
					vector3Int.z = num3 >> 7;
					vehicle.FUN_2B370(vector3Int, v);
					return 0u;
				}
			}
			DAT_80 = null;
			goto IL_03f2;
		}
		case 1:
		{
			vr.x = -1024;
			flags |= 256u;
			ConfigContainer configContainer = child2.FUN_2C5F4(32768);
			physics1.Y = configContainer.v3_1.z;
			ApplyTransformation();
			break;
		}
		case 2:
			{
				FUN_30BA8();
				flags &= 4294967263u;
				break;
			}
			IL_03f2:
			GameManager.instance.FUN_30CB0(this, 60);
			return 0u;
		}
		return 0u;
	}
}
