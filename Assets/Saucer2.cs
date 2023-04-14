using System.IO;
using UnityEngine;

public class Saucer2 : VigObject
{
	private static uint[] DAT_2C60 = new uint[4]
	{
		2147483648u,
		2113929216u,
		7864320u,
		7864320u
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
		uint num;
		if (hit.self.type == 2)
		{
			Vehicle obj = (Vehicle)hit.self;
			num = (uint)(((ushort)obj.DAT_A6 << 8) / (int)(ushort)DAT_A6);
			GameManager.instance.FUN_2F798(this, hit);
			int num2 = obj.physics1.X * (int)num;
			if (num2 < 0)
			{
				num2 += 255;
			}
			Vector3Int v = new Vector3Int
			{
				x = physics1.X - (num2 >> 8)
			};
			num2 = obj.physics1.Y * (int)num;
			if (num2 < 0)
			{
				num2 += 255;
			}
			v.y = physics1.Y - (num2 >> 8);
			int num3 = obj.physics1.Z * (int)num;
			if (num3 < 0)
			{
				num3 += 255;
			}
			v.z = physics1.Z - (num3 >> 8);
			long num4 = Utilities.FUN_2AD3C(v, hit.normal1);
			num = (uint)((int)((uint)num4 >> 13) | ((int)(num4 >> 32) << 19));
			if (-1 < (int)num)
			{
				return 0u;
			}
			Vector3Int v2 = Utilities.FUN_24210(vTransform.rotation, hit.normal1);
			num = (uint)(-(hit.distance * 2 + (int)num));
			num3 = (int)num >> 31;
			v2.x = ((int)((uint)((long)(uint)v2.x * (long)num) >> 12) | (((int)((ulong)((long)(uint)v2.x * (long)num) >> 32) + v2.x * num3 + (int)num * (v2.x >> 31)) * 1048576));
			v2.y = ((int)((uint)((long)(uint)v2.y * (long)num) >> 12) | (((int)((ulong)((long)(uint)v2.y * (long)num) >> 32) + v2.y * num3 + (int)num * (v2.y >> 31)) * 1048576));
			v2.z = ((int)((uint)((long)(uint)v2.z * (long)num) >> 12) | (((int)((ulong)((long)(uint)v2.z * (long)num) >> 32) + v2.z * num3 + (int)num * (v2.z >> 31)) * 1048576));
			FUN_2B1FC(v2, hit.position);
			return 0u;
		}
		HitDetection hit2 = GameManager.instance.FUN_2F798(this, hit);
		FUN_2B834(hit2);
		if (hit.self.type != 8)
		{
			return 0u;
		}
		if ((flags & 0x1000000) != 0)
		{
			return 0u;
		}
		bool num5 = FUN_32B90(hit.self.maxHalfHealth);
		num = 0u;
		if (num5)
		{
			flags |= 16777216u;
			Vector3Int v2 = default(Vector3Int);
			do
			{
				num++;
				int num3 = (int)GameManager.FUN_2AC5C();
				v2.x = (num3 * 3051 >> 15) - 1525;
				v2.y = -4577;
				num3 = (int)GameManager.FUN_2AC5C();
				v2.z = (num3 * 3051 >> 15) - 1525;
				uint param = DAT_2C60[num - 1];
				LevelManager.instance.FUN_4AAC0(param, screen, v2);
			}
			while (num < 4);
			return 0u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			if ((flags & 0x1000000) != 0)
			{
				if (type == 0)
				{
					return 0u;
				}
				vCollider.reader.Seek(4L, SeekOrigin.Current);
				FUN_2B4F8(vCollider.reader);
				vCollider.reader.Seek(-4L, SeekOrigin.Current);
				return 0u;
			}
			int num3 = FUN_2CFBC(vTransform.position);
			num3 -= vTransform.position.y;
			if (num3 < 0)
			{
				num3 += 255;
			}
			num3 >>= 8;
			int x = physics2.X + 512;
			if (vTransform.rotation.V12 < 1)
			{
				x = physics2.X - 512;
			}
			physics2.X = x;
			x = ((vTransform.rotation.V10 >= 0) ? (physics2.Z - 512) : (physics2.Z + 512));
			physics2.Z = x;
			if (type == 0)
			{
				physics1.Z = 0;
				physics1.X = 0;
			}
			x = num3;
			if (num3 < 0)
			{
				x = -num3;
			}
			int num4 = 2048;
			if (2048 < num3 * x)
			{
				num4 = num3 * x;
			}
			physics1.Y = physics1.Y + 7168 - 293601280 / num4;
			FUN_2AF20();
			physics2.X = physics2.X * 3968 >> 12;
			physics2.Y = physics2.Y * 3968 >> 12;
			physics2.Z = physics2.Z * 3968 >> 12;
			x = physics1.X;
			num3 = x;
			if (x < 0)
			{
				num3 = x + 63;
			}
			num4 = physics1.Y;
			physics1.X = x - (num3 >> 6);
			num3 = num4;
			if (num4 < 0)
			{
				num3 = num4 + 63;
			}
			x = physics1.Z;
			physics1.Y = num4 - (num3 >> 6);
			num3 = x;
			if (x < 0)
			{
				num3 = x + 63;
			}
			physics1.Z = x - (num3 >> 6);
			break;
		}
		case 1:
		{
			bool flag = false;
			if (GameManager.instance.gameMode == _GAME_MODE.Quest || GameManager.instance.gameMode == _GAME_MODE.Quest2)
			{
				flag = true;
			}
			if (type == 0)
			{
				if (!flag)
				{
					return uint.MaxValue;
				}
			}
			else if (flag)
			{
				return uint.MaxValue;
			}
			flags |= 136u;
			FUN_4C9C8();
			DAT_A0 = new Vector3Int(64, 64, 64);
			DAT_A6 = 4096;
			break;
		}
		case 8:
		{
			if ((flags & 0x1000000) != 0)
			{
				return 0u;
			}
			bool num = FUN_32B90((uint)arg2);
			uint num2 = 0u;
			if (num)
			{
				flags |= 16777216u;
				Vector3Int param = default(Vector3Int);
				do
				{
					num2++;
					int num3 = (int)GameManager.FUN_2AC5C();
					param.x = (num3 * 3051 >> 15) - 1525;
					param.y = -4577;
					num3 = (int)GameManager.FUN_2AC5C();
					param.z = (num3 * 3051 >> 15) - 1525;
					uint param2 = DAT_2C60[num2 - 1];
					LevelManager.instance.FUN_4AAC0(param2, screen, param);
				}
				while (num2 < 4);
				return 0u;
			}
			break;
		}
		}
		return 0u;
	}
}
