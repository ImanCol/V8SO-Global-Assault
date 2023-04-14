using UnityEngine;

public class Silo3 : VigObject
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
		BufferedBinaryReader reader = vCollider.reader;
		Vector3Int v = default(Vector3Int);
		v.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
		v.y = (reader.ReadInt32(8) + reader.ReadInt32(20)) / 2;
		v.z = reader.ReadInt32(24);
		v = Utilities.FUN_24148(vTransform, v);
		v.y = GameManager.instance.terrain.FUN_1B750((uint)v.x, (uint)v.z);
		LevelManager.instance.FUN_4E128(v, 53, 300).flags |= 16u;
		LevelManager.instance.FUN_4DE54(v, 39);
		int param = GameManager.instance.FUN_1DD9C();
		GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, v);
		flags |= 34u;
		GameManager.instance.FUN_30CB0(this, 15);
		FUN_30BA8();
		Quake2 quake = new GameObject().AddComponent<Quake2>();
		quake.screen = v;
		quake.flags = 160u;
		quake.FUN_3066C();
		return uint.MaxValue;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			screen.x += physics1.Z;
			screen.y += physics1.W;
			screen.z += physics2.X;
			vTransform.position = screen;
			if (arg2 != 0)
			{
				uint volume = GameManager.instance.FUN_1E478(screen);
				GameManager.instance.FUN_1E2C8(DAT_18, volume);
			}
			ushort num = (ushort)(physics2.M2 + 1);
			physics2.M2 = (short)num;
			if ((num & 3) == 0)
			{
				Silo4 obj = LevelManager.instance.xobfList[19].ini.FUN_2C17C(12, typeof(Silo4), 8u) as Silo4;
				obj.type = 4;
				obj.flags = 1204u;
				obj.screen = screen;
				obj.vr.z = physics2.M2 * 96;
				obj.physics1.Z = -vTransform.rotation.V02;
				obj.physics1.W = -vTransform.rotation.V12;
				obj.physics2.X = -vTransform.rotation.V22;
				obj.FUN_3066C();
			}
			int num3;
			int num2;
			if (physics2.M2 < 240)
			{
				num2 = vTransform.rotation.V02 * 28;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				num3 = vTransform.rotation.V12 * 28;
				physics1.Z += num2 >> 12;
				if (num3 < 0)
				{
					num3 += 4095;
				}
				num2 = vTransform.rotation.V22 * 28;
				physics1.W += num3 >> 12;
				if (num2 < 0)
				{
					num2 += 4095;
				}
				physics2.X += num2 >> 12;
				return 0u;
			}
			BufferedBinaryReader reader = vCollider.reader;
			VigObject dAT_ = DAT_84;
			Vector3Int v;
			if (dAT_ == null)
			{
				v = new Vector3Int(0, 4096, 0);
			}
			else
			{
				if (dAT_.maxHalfHealth == 0)
				{
					DAT_84 = null;
				}
				if (tags == 0)
				{
					v = default(Vector3Int);
					v.x = dAT_.screen.x - screen.x;
					v.y = 0;
					v.z = dAT_.screen.z - screen.z;
					v = Utilities.FUN_2426C(vTransform.rotation, new Matrix2x4(v.x, v.y, v.z, 0));
				}
				else
				{
					v = Utilities.FUN_24304(vTransform, dAT_.screen);
				}
			}
			int num4 = Utilities.Ratan2(-v.y, v.z);
			num3 = -64;
			if (-65 < num4)
			{
				num3 = 64;
				if (num4 < 65)
				{
					num3 = num4;
				}
			}
			int num5 = Utilities.Ratan2(v.x, v.z);
			num4 = -64;
			if (-65 < num5)
			{
				num4 = 64;
				if (num5 < 65)
				{
					num4 = num5;
				}
			}
			FUN_24700((short)num3, (short)num4, 0);
			if (((GameManager.instance.DAT_28 - DAT_19) & 0x1F) == 0)
			{
				vTransform.rotation = Utilities.MatrixNormal(vTransform.rotation);
			}
			num3 = vTransform.rotation.V02 * 15258;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			num3 = (num3 >> 12) - physics1.Z;
			if (num3 < 0)
			{
				num3 += 15;
			}
			num3 >>= 4;
			num4 = -256;
			if (-257 < num3)
			{
				num4 = 256;
				if (num3 < 257)
				{
					num4 = num3;
				}
			}
			num3 = vTransform.rotation.V12 * 15258;
			physics1.Z += num4;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			num3 = (num3 >> 12) - physics1.W;
			if (num3 < 0)
			{
				num3 += 15;
			}
			num3 >>= 4;
			num4 = -256;
			if (-257 < num3)
			{
				num4 = 256;
				if (num3 < 257)
				{
					num4 = num3;
				}
			}
			num3 = vTransform.rotation.V22 * 15258;
			physics1.W += num4;
			if (num3 < 0)
			{
				num3 += 4095;
			}
			num3 = (num3 >> 12) - physics2.X;
			if (num3 < 0)
			{
				num3 += 15;
			}
			num3 >>= 4;
			num4 = -256;
			if (-257 < num3)
			{
				num4 = 256;
				if (num3 < 257)
				{
					num4 = num3;
				}
			}
			physics2.X += num4;
			if (physics2.M2 < 601)
			{
				if (60 < physics2.M2)
				{
					if (v.z < 0)
					{
						v.z = -v.z;
					}
					if (v.x < 0)
					{
						v.x = -v.x;
					}
					if (v.z < v.x)
					{
						v.z = v.x;
					}
					if (v.z < 1024000)
					{
						tags = 1;
					}
				}
			}
			else
			{
				tags = 1;
			}
			v.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
			v.y = (reader.ReadInt32(8) + reader.ReadInt32(20)) / 2;
			v.z = reader.ReadInt32(24);
			v = Utilities.FUN_24148(vTransform, v);
			num2 = GameManager.instance.terrain.FUN_1B750((uint)v.x, (uint)v.z);
			if (num2 <= v.y)
			{
				reader = vCollider.reader;
				Vector3Int v2 = default(Vector3Int);
				v2.x = (reader.ReadInt32(4) + reader.ReadInt32(16)) / 2;
				v2.y = (reader.ReadInt32(8) + reader.ReadInt32(20)) / 2;
				v2.z = reader.ReadInt32(24);
				v2 = Utilities.FUN_24148(vTransform, v2);
				v2.y = GameManager.instance.terrain.FUN_1B750((uint)v2.x, (uint)v2.z);
				LevelManager.instance.FUN_4E128(v2, 53, 300).flags |= 16u;
				LevelManager.instance.FUN_4DE54(v2, 39);
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 65, v2);
				flags |= 34u;
				GameManager.instance.FUN_30CB0(this, 15);
				FUN_30BA8();
				Quake2 quake = new GameObject().AddComponent<Quake2>();
				quake.screen = v2;
				quake.flags = 160u;
				quake.FUN_3066C();
				return uint.MaxValue;
			}
			break;
		}
		case 1:
		{
			sbyte param2 = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E098(param2, vData.sndList, 2, 0u, param5: true);
			return 0u;
		}
		case 2:
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 66, vTransform.position);
			GameManager.instance.FUN_309A0(this);
			return uint.MaxValue;
		}
		case 4:
			GameManager.instance.FUN_1DE78(DAT_18);
			break;
		}
		return 0u;
	}
}
