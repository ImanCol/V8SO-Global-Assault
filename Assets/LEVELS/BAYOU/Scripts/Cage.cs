using UnityEngine;

public class Cage : Destructible
{
	private static Vector3Int DAT_D8 = new Vector3Int(0, 0, 0);

	public Cage DAT_8C;

	public VigObject DAT_90;

	public VigObject DAT_94;

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
		sbyte tags = base.tags;
		if (tags != 1)
		{
			if (tags < 2)
			{
				if (tags != 0)
				{
					return 0u;
				}
				if (hit.self.type != 2 && hit.self.GetType() != typeof(Aligator))
				{
					return 0u;
				}
				base.tags = 1;
				FUN_30B78();
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 43, vTransform.position);
				GameManager.instance.FUN_309A0(DAT_90);
				DAT_90 = null;
			}
			else if (tags < 4)
			{
				if (base.tags == 2 && DAT_94 == null)
				{
					VigObject self = hit.self;
					if (self.type == 2 || self.GetType() == typeof(Aligator))
					{
						DAT_94 = self;
						hit.self.flags |= 32u;
						FUN_30B78();
						int param = GameManager.instance.FUN_1DD9C();
						GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 39, vTransform.position);
						Vector3Int vector3Int = default(Vector3Int);
						vector3Int.x = DAT_94.vTransform.position.x;
						vector3Int.z = DAT_94.vTransform.position.z;
						vector3Int.y = GameManager.instance.DAT_DB0;
						Particle1 particle = LevelManager.instance.FUN_4DE54(vector3Int, 146);
						if (particle != null)
						{
							particle.flags &= 4294967279u;
							short y = (short)GameManager.FUN_2AC5C();
							particle.vr.y = y;
							particle.ApplyTransformation();
						}
						if (hit.self.type == 2)
						{
							return 0u;
						}
						int num = (int)GameManager.FUN_2AC5C();
						vector3Int.x = (num * 3051 >> 15) - 1525;
						vector3Int.y = -4577;
						num = (int)GameManager.FUN_2AC5C();
						vector3Int.z = (num * 3051 >> 15) - 1525;
						LevelManager.instance.FUN_4AAC0(4194304u, hit.self.vTransform.position, vector3Int);
						num = (int)GameManager.FUN_2AC5C();
						vector3Int.x = (num * 3051 >> 15) - 1525;
						vector3Int.y = -4577;
						num = (int)GameManager.FUN_2AC5C();
						vector3Int.z = (num * 3051 >> 15) - 1525;
						LevelManager.instance.FUN_4AAC0(2147483648u, hit.self.vTransform.position, vector3Int);
						num = (int)GameManager.FUN_2AC5C();
						vector3Int.x = (num * 3051 >> 15) - 1525;
						vector3Int.y = -4577;
						num = (int)GameManager.FUN_2AC5C();
						vector3Int.z = (num * 3051 >> 15) - 1525;
						LevelManager.instance.FUN_4AAC0(2151677952u, hit.self.vTransform.position, vector3Int);
						return 0u;
					}
				}
				if (!FUN_32CF0(hit))
				{
					return 0u;
				}
				return uint.MaxValue;
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (arg1)
		{
		case 0:
		{
			sbyte tags = base.tags;
			if (tags == 1)
			{
				int num = physics1.Y + 720;
				physics1.Y = num;
				int y = vTransform.position.y;
				vTransform.position.y = y + num;
				if (y + num < physics2.Z + 215040)
				{
					return 0u;
				}
				FUN_30BA8();
				base.tags = 2;
				vTransform.position.y = physics2.Z + 215040;
				GameManager.instance.FUN_30CB0(this, 30);
				physics1.Y = -1365;
				maxHalfHealth = 100;
				int param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, vData.sndList, 1, vTransform.position);
				param = GameManager.instance.FUN_1DD9C();
				GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 38, vTransform.position);
				GameManager.instance.FUN_1E30C(param, 6144);
				return 0u;
			}
			if (0 < tags)
			{
				if (3 < tags)
				{
					return 0u;
				}
				VigObject dAT_ = DAT_94;
				if (dAT_ == null)
				{
					return 0u;
				}
				int num2 = vTransform.position.x - dAT_.vTransform.position.x;
				int y = vTransform.position.y - dAT_.vTransform.position.y;
				int num = vTransform.position.z - dAT_.vTransform.position.z;
				if (num2 < 0)
				{
					num2 += 3;
				}
				if (y < 0)
				{
					y += 3;
				}
				if (num < 0)
				{
					num += 3;
				}
				VigObject dAT_2 = DAT_94;
				dAT_2.vTransform.position.x += num2 >> 2;
				dAT_2.vTransform.position.y += y >> 2;
				dAT_2.vTransform.position.z += num >> 2;
				if (DAT_94.type != 2)
				{
					return 0u;
				}
				((Vehicle)DAT_94).FUN_39DCC(-1, DAT_D8, param3: true);
				if (arg2 == 0)
				{
					return 0u;
				}
				if ((GameManager.FUN_2AC5C() & 7) != 0)
				{
					return 0u;
				}
				Vector3Int param2 = default(Vector3Int);
				param2.x = DAT_94.vTransform.position.x;
				param2.z = DAT_94.vTransform.position.z;
				param2.y = GameManager.instance.DAT_DB0;
				Particle1 particle = LevelManager.instance.FUN_4DE54(param2, 146);
				if (particle != null)
				{
					particle.flags &= 4294967279u;
					short y2 = (short)GameManager.FUN_2AC5C();
					particle.vr.y = y2;
					particle.ApplyTransformation();
					return 0u;
				}
			}
			break;
		}
		case 1:
			base.tags = -1;
			GameManager.instance.FUN_30CB0(this, 2);
			break;
		case 2:
			if (base.tags == 2)
			{
				GameManager.instance.FUN_30CB0(this, 300);
				base.tags = 3;
				break;
			}
			if (base.tags != 3)
			{
				return 0u;
			}
			if (!GetType().IsSubclassOf(typeof(VigObject)))
			{
				break;
			}
			UpdateW(8, 1000);
			return 0u;
		case 8:
			if (1u < (uint)((byte)base.tags - 2) && arg2 != 1000)
			{
				return 0u;
			}
			if (!FUN_32B90((uint)arg2))
			{
				return 0u;
			}
			return uint.MaxValue;
		case 9:
			{
				if (arg2 == 0)
				{
					return 0u;
				}
				if (DAT_90 != null)
				{
					GameManager.instance.FUN_309A0(DAT_90);
					DAT_90 = null;
				}
				if (type == 4)
				{
					Bayou.FUN_7F0(DAT_19);
					VigObject dAT_ = DAT_94;
					if (dAT_ != null)
					{
						dAT_.flags &= 4294967263u;
						DAT_94 = null;
					}
				}
				else
				{
					VigObject dAT_8C = DAT_8C;
					if (dAT_8C == null)
					{
						goto IL_046d;
					}
					if (dAT_8C != null)
					{
						dAT_8C.UpdateW(8, 1000);
					}
				}
				if (DAT_8C != null)
				{
					DAT_8C.DAT_8C = null;
				}
				goto IL_046d;
			}
			IL_046d:
			GameManager.instance.FUN_309A0(this);
			return 0u;
		}
		return 0u;
	}
}
