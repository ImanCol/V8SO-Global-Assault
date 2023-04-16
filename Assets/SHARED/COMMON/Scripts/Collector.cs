using UnityEngine;

public class Collector : VigObject
{
	private static Vector3Int DAT_20 = new Vector3Int(0, 0, 0);

	private static Vector3Int DAT_710 = new Vector3Int(0, -524288, 262144);

	private static int[] DAT_720 = new int[4]
	{
		14,
		24,
		19,
		24
	};

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public static VigObject OnInitialize(XOBF_DB arg1, int arg2)
	{
		return arg1.ini.FUN_2C17C(2, typeof(Collector), 8u);
	}

	public override uint OnCollision(HitDetection hit)
	{
		VigObject self = hit.self;
		uint result = 0u;
		if (self.type == 2 && (PDAT_74 == null || PDAT_74 == self))
		{
			Vehicle vehicle = (Vehicle)self;
			ConfigContainer configContainer = FUN_2C5F4(32768);
			VigTransform vigTransform = GameManager.instance.FUN_2CEAC(this, configContainer);
			vehicle.vTransform.position.x += (vigTransform.position.x - vehicle.vTransform.position.x) / 2;
			vehicle.vTransform.position.y += (vigTransform.position.y - vehicle.vTransform.position.y) / 2;
			vehicle.vTransform.position.z += (vigTransform.position.z - vehicle.vTransform.position.z) / 2;
			int num = IDAT_78 - 1;
			PDAT_74 = hit.self;
			IDAT_78 = num;
			VigObject vigObject;
			int param;
			if (num < 1)
			{
				uint num2 = GameManager.FUN_2AC5C();
				IDAT_78 = (int)((num2 & 0x1F) + 15);
				UIManager.instance.FUN_4E414(vigTransform.position, new Color32(128, 128, 128, 8));
				if ((num2 & 0x1C0) == 0 && vehicle.shield == 0)
				{
					if (vehicle.weapons[0] != null && vehicle.weapons[0].tags < 8)
					{
						if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
						{
							if (GameManager.instance.gameMode >= _GAME_MODE.Versus2)
							{
								ClientSend.DropWeapon(vehicle.weapons[0].tags);
							}
							vehicle.weapons[0].FUN_3A368();
							return 0u;
						}
						if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
						{
							ClientSend.DropWeaponAI(vehicle.id, vehicle.weapons[0].tags);
							vehicle.weapons[0].FUN_3A368();
							return 0u;
						}
					}
					LevelManager.instance.FUN_4DE54(vigTransform.position, 142);
				}
				else
				{
					param = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, DAT_720[num2 & 3], vigTransform.position);
					if ((num2 & 1) == 0)
					{
						Vector3Int param2 = new Vector3Int(vigTransform.rotation.V02, vigTransform.rotation.V12, vigTransform.rotation.V22);
						LevelManager.instance.FUN_4EAE8(vigTransform.position, param2, 148);
					}
					else
					{
						LevelManager.instance.FUN_4E56C(vigTransform, 123);
					}
				}
				vigObject = Utilities.FUN_2CD78(this);
				num2 = GameManager.FUN_2AC5C();
				Vector3Int v = default(Vector3Int);
				v.x = (int)(((num2 & 0x7F) - 64) * 128);
				v.y = 73728;
				v.z = 0;
				vigObject.FUN_2B1FC(v, configContainer.v3_1);
			}
			Utilities.FUN_248C4(vehicle.vTransform.rotation, vigTransform.rotation, out vigTransform.rotation);
			int num3 = -vigTransform.rotation.V10;
			if (0 < vigTransform.rotation.V10)
			{
				num3 += 7;
			}
			int num4 = vigTransform.rotation.V00 + vigTransform.rotation.V22;
			if (num4 < 0)
			{
				num4 += 7;
			}
			int num5 = -vigTransform.rotation.V12;
			if (0 < vigTransform.rotation.V12)
			{
				num5 += 7;
			}
			vehicle.FUN_24700((short)(num3 >> 3), (short)(num4 >> 3), (short)(num5 >> 3));
			vehicle.vTransform.rotation = Utilities.MatrixNormal(vehicle.vTransform.rotation);
			if (vehicle.id < 0)
			{
				uint num2 = GameManager.FUN_2AC5C();
				if ((num2 & 0x1F) == 0)
				{
					GameManager.instance.FUN_15AA8(~vehicle.id, 8, byte.MaxValue, 0, 16);
				}
			}
			vigObject = Utilities.FUN_2CD78(this);
			num5 = -1;
			if (((Vehicle)vigObject).doubleDamage != 0)
			{
				num5 = -2;
			}
			param = vehicle.FUN_3B078(vigObject, (ushort)DAT_1A, num5, 1u);
			vehicle.FUN_3A020(param, DAT_20, param3: true);
			result = 1u;
		}
		return result;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
			FUN_42330(arg2);
			return 0u;
		default:
			return 0u;
		case 2:
		{
			ApplyTransformation();
			child2.ApplyTransformation();
			sbyte b = (sbyte)(DAT_19 + 1);
			DAT_19 = (byte)b;
			if (b != 2)
			{
				return 0u;
			}
			FUN_30BA8();
			if (DAT_18 != 0)
			{
				GameManager.instance.FUN_1DE78(DAT_18);
				DAT_18 = 0;
			}
			VigObject pDAT_ = PDAT_74;
			if (pDAT_ != null)
			{
				ConfigContainer param = FUN_2C5F4(32768);
				if (Utilities.FUN_29F6C(GameManager.instance.FUN_2CEAC(this, param).position, pDAT_.vTransform.position) < 65536)
				{
					pDAT_.flags &= 4294967263u;
					VigObject obj = Utilities.FUN_2CD78(this);
					Vector3Int v = Utilities.FUN_24094(GameManager.instance.FUN_2CDF4(obj).rotation, DAT_710);
					pDAT_.FUN_2B370(v, pDAT_.vTransform.position);
					pDAT_.physics2.Z = -131072;
					int param2 = GameManager.instance.FUN_1DD9C();
					GameManager.instance.FUN_1E628(param2, GameManager.instance.DAT_C2C, 46, pDAT_.vTransform.position);
				}
			}
			FUN_2C124(2);
			Utilities.ParentChildren(this, this);
			DAT_19 = 0;
			flags |= 32u;
			if (maxHalfHealth == 0)
			{
				FUN_3A368();
				return 0u;
			}
			goto default;
		}
		case 4:
			if (DAT_18 == 0)
			{
				return 0u;
			}
			GameManager.instance.FUN_1DE78(DAT_18);
			DAT_18 = 0;
			goto default;
		}
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		uint result;
		if (arg1 <= 1)
		{
			if (arg1 != 0)
			{
				if (arg1 == 1)
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
				}
				goto IL_0050;
			}
			FUN_42330(arg2);
			result = 0u;
		}
		else if (arg1 != 12)
		{
			if (arg1 != 13)
			{
				goto IL_0050;
			}
			result = 0u;
			if (DAT_19 == 0)
			{
				Vector3Int vector3Int = Utilities.FUN_24304(arg2.vTransform, ((Vehicle)arg2).target.vTransform.position);
				result = 0u;
				if ((uint)(vector3Int.z - 1) < 143359u)
				{
					if (vector3Int.x < 0)
					{
						vector3Int.x = -vector3Int.x;
					}
					bool flag = vector3Int.x < 65536;
					if (65536 < vector3Int.z)
					{
						flag = (vector3Int.x < vector3Int.z);
					}
					result = 0u;
					if (flag)
					{
						result = 1u;
					}
				}
			}
		}
		else
		{
			if (DAT_19 != 0)
			{
				return 0u;
			}
			arg2.tags = 3;
			DAT_19 = 1;
			FUN_2C124(1);
			FUN_30B78();
			Utilities.ParentChildren(this, this);
			GameManager.instance.FUN_30CB0(this, 239);
			sbyte param = DAT_18 = (sbyte)GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E14C(param, vData.sndList, 3, param4: true);
			int param2 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E188(param2, vData.sndList, 2);
			Utilities.FUN_2CD78(this).flags |= 2048u;
			IDAT_78 = 0;
			PDAT_74 = null;
			flags &= 4294967263u;
			maxHalfHealth--;
			result = 900u;
			if (arg2.id < 0)
			{
				result = 600u;
			}
		}
		goto IL_01d5;
		IL_01d5:
		return result;
		IL_0050:
		result = 0u;
		goto IL_01d5;
	}
}
