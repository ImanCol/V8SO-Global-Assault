using UnityEngine;

public class Glacier : Destructible
{
	public static Vector3Int DAT_F8 = new Vector3Int(0, 0, 0);

	public static int[] DAT_29D0 = new int[3]
	{
		20,
		21,
		19
	};

	public Vector3Int DAT_A8;

	public int DAT_B4;

	public int DAT_B8;

	public int DAT_BC;

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
		if (hit.self.type == 2 && tags == 1)
		{
			Vehicle vehicle = (Vehicle)hit.self;
			int num = 32768 / vehicle.DAT_A6;
			int num2 = physics1.X * num;
			Vector3Int v = default(Vector3Int);
			if (num2 < -524288)
			{
				v.x = -524288;
			}
			else
			{
				v.x = 524288;
				if (num2 < 524289)
				{
					v.x = num2;
				}
			}
			num2 = physics1.Y * num;
			v.y = -524288;
			if (-524289 < num2)
			{
				v.y = 524288;
				if (num2 < 524289)
				{
					v.y = num2;
				}
			}
			num2 = physics1.Z * num;
			v.z = -524288;
			if (-524289 < num2)
			{
				v.z = 524288;
				if (num2 < 524289)
				{
					v.z = num2;
				}
			}
			vehicle.FUN_2B370(v, vTransform.position);
			if (vehicle.id < 0)
			{
				GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
			}
			vehicle.FUN_3A064(-180, vTransform.position, param3: true);
		}
		else if (hit.self.type == 4 && hit.self.GetType() == typeof(Orca))
		{
			FUN_4DC94();
			return 4294967294u;
		}
		if (FUN_32CF0(hit))
		{
			return 4294967294u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		sbyte b;
		VigObject vigObject;
		int num;
		int num2;
		switch (arg1)
		{
		case 0:
		{
			num = physics1.X;
			if (num < 0)
			{
				num += 127;
			}
			num2 = physics1.Z;
			vTransform.position.x += num >> 7;
			if (num2 < 0)
			{
				num2 += 127;
			}
			num = (DAT_BC += DAT_B8);
			vTransform.position.z += num2 >> 7;
			vr.y = num >> 16;
			ApplyRotationMatrix();
			num = vTransform.position.x - DAT_A8.x;
			if (num < 0)
			{
				num = -num;
			}
			if (65535 < num)
			{
				return 0u;
			}
			num = vTransform.position.z - DAT_A8.z;
			if (num < 0)
			{
				num = -num;
			}
			if (65535 < num)
			{
				return 0u;
			}
			uint flags;
			if ((sbyte)DAT_19 == -95)
			{
				flags = (uint)((int)base.flags & -16777217);
			}
			else
			{
				if ((sbyte)DAT_19 != -90)
				{
					goto IL_015a;
				}
				flags = (base.flags | 0x1000000);
			}
			base.flags = flags;
			goto IL_015a;
		}
		case 1:
		{
			type = 4;
			base.flags |= 65536u;
			DAT_19 = (byte)id;
			DAT_A8 = screen;
			int dAT_DB = GameManager.instance.DAT_DB0;
			DAT_BC = vr.y << 16;
			vTransform.position.y = dAT_DB;
			break;
		}
		case 2:
			tags = 1;
			FUN_30B78();
			return 0u;
		case 8:
			if (FUN_32B90((uint)arg2))
			{
				return 4294967294u;
			}
			break;
		case 9:
			{
				num = 0;
				if (arg2 != 0)
				{
					do
					{
						ConfigContainer param = FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
						GlacierSmall glacierSmall = vData.ini.FUN_2C17C((ushort)DAT_29D0[num], typeof(GlacierSmall), 8u) as GlacierSmall;
						glacierSmall.vTransform = GameManager.instance.FUN_2CEAC(this, param);
						glacierSmall.flags |= 128u;
						glacierSmall.physics1.X = (glacierSmall.vTransform.position.x - vTransform.position.x) * 2;
						num++;
						glacierSmall.physics1.Z = (glacierSmall.vTransform.position.z - vTransform.position.z) * 2;
						num2 = (int)GameManager.FUN_2AC5C();
						GameManager.instance.FUN_30CB0(glacierSmall, (num2 * 420 >> 15) + 480);
						glacierSmall.FUN_305FC();
					}
					while (num < 3);
					LevelManager.instance.FUN_4AAC0(4269277184u, vTransform.position, DAT_F8);
					Oilfield obj = (Oilfield)LevelManager.instance.level;
					num2 = obj.DAT_A0_2 + 1;
					obj.DAT_9C--;
					obj.DAT_A0_2 = num2;
					GameManager.instance.FUN_309A0(this);
					return 0u;
				}
				break;
			}
			IL_015a:
			b = (((base.flags & 0x1000000) != 0) ? ((sbyte)(DAT_19 - 1)) : ((sbyte)(DAT_19 + 1)));
			DAT_19 = (byte)b;
			vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, DAT_19);
			DAT_A8 = vigObject.screen;
			num = vigObject.vr.y * 65536;
			num2 = num - DAT_BC;
			DAT_B4 = num;
			DAT_B8 = num2;
			if (num2 < 0)
			{
				DAT_B8 = num2 + 268435456;
				DAT_BC -= 268435456;
			}
			DAT_B8 /= 600;
			physics1.X = (DAT_A8.x - vTransform.position.x) * 128 / 600;
			physics1.Z = (DAT_A8.z - vTransform.position.z) * 128 / 600;
			FUN_30BA8();
			tags = 0;
			GameManager.instance.FUN_30CB0(this, 600);
			return 0u;
		}
		return 0u;
	}
}
