using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _GUARDTOWER2_TYPE
{
    Default, 
    Type1 //FUN_2FEC (LAUNCH.DLL)
}

public class GuardTower2 : VigObject
{
	public _GUARDTOWER2_TYPE state;

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
		int param;
		switch (arg1)
		{
		case 0:
		{
			if (2 < base.tags)
			{
				return 0u;
			}
			if (base.tags < 1)
			{
				return 0u;
			}
			Vehicle vehicle = PDAT_78 as Vehicle;
			VigTransform vigTransform = GameManager.instance.FUN_2CDF4(this);
			Vector3Int vector3Int = default(Vector3Int);
			Vector3Int v2 = default(Vector3Int);
			vector3Int.x = vehicle.screen.x - vigTransform.position.x;
			vector3Int.y = vehicle.screen.y - vigTransform.position.y;
			vector3Int.z = vehicle.screen.z - vigTransform.position.z;
			v2.x = vigTransform.rotation.V02;
			v2.y = vigTransform.rotation.V12;
			v2.z = vigTransform.rotation.V22;
			Utilities.FUN_29FC8(vector3Int, out Vector3Int vout);
			Vector3Int v = Utilities.FUN_2A1E0(v2, vout);
			int num3 = v.y;
			if (num3 < 0)
			{
				num3 += 3;
			}
			int num2 = screen.y;
			int num = (num3 >> 2) - num2;
			if ((num ^ num2) < 0)
			{
				num3 = num2 + 2;
				if (num < 1)
				{
					num3 = num2 - 2;
				}
			}
			else
			{
				num3 = num2 + 1;
				if (num < 1)
				{
					num3 = num2 - 1;
				}
			}
			screen.y = num3;
			int y = screen.y;
			num3 = -4;
			if (-5 < y)
			{
				num3 = 4;
				if (y < 5)
				{
					num3 = y;
				}
			}
			screen.y = num3;
			vr.y = (short)(((ushort)vr.y + (ushort)screen.y) * 16 >> 4);
			v = Utilities.FUN_24238(vigTransform.rotation, v);
			num3 = v.x;
			if (num3 < 0)
			{
				num3 += 3;
			}
			num2 = screen.x;
			num = (num3 >> 2) - num2;
			if ((num ^ num2) < 0)
			{
				num3 = num2 + 2;
				if (num < 1)
				{
					num3 = num2 - 2;
				}
			}
			else
			{
				num3 = num2 + 1;
				if (num < 1)
				{
					num3 = num2 - 1;
				}
			}
			screen.x = num3;
			y = screen.x;
			num3 = -16;
			if (-17 < y)
			{
				num3 = 16;
				if (y < 17)
				{
					num3 = y;
				}
			}
			screen.x = num3;
			y = (short)(((ushort)vr.x + (ushort)screen.x) * 1048576 >> 20);
			num3 = -512;
			if (-513 < y)
			{
				num3 = 512;
				if (y < 513)
				{
					num3 = y;
				}
			}
			vr.x = num3;
			ApplyRotationMatrix();
			if (base.tags == 1)
			{
				num3 = Utilities.FUN_29E24(v);
				if (31 < num3)
				{
					return 0u;
				}
				GameManager.instance.FUN_30CB0(this, 120);
				DAT_19 = 8;
				base.tags = 2;
				return 0u;
			}
			if (base.tags != 2)
			{
				return 0u;
			}
			sbyte tags = (sbyte)(DAT_19 - 1);
			DAT_19 = (byte)tags;
			if (tags != 0)
			{
				return 0u;
			}
			Ballistic ballistic = LevelManager.instance.xobfList[19].ini.FUN_2C17C(2, typeof(Ballistic), 8u) as Ballistic;
			Bullet bullet = LevelManager.instance.xobfList[19].ini.FUN_2C17C(210, typeof(Bullet), 8u) as Bullet;
			ConfigContainer configContainer = FUN_2C5F4(32768);
			VigTransform m = Utilities.FUN_2C77C(configContainer);
			bullet.vTransform = Utilities.CompMatrixLV(vigTransform, m);
			bullet.DAT_80 = this;
			VigObject vigObject2 = Utilities.FUN_2CD78(this);
			ushort maxHalfHealth = 7;
			short id = vigObject2.id;
			bullet.type = 8;
			bullet.id = id;
			bullet.vTransform = vigTransform;
			bullet.screen = bullet.vTransform.position;
			bullet.flags = 640u;
			if (vehicle.doubleDamage != 0)
			{
				maxHalfHealth = 14;
			}
			bullet.maxHalfHealth = maxHalfHealth;
			if (ballistic != null)
			{
				ballistic.vTransform = GameManager.FUN_2A39C();
				ballistic.vTransform.position = configContainer.v3_1;
				Utilities.FUN_2CC48(this, ballistic);
				Utilities.ParentChildren(this, this);
			}
			bullet.physics1.Z = bullet.vTransform.rotation.V02 << 3;
			bullet.physics1.W = bullet.vTransform.rotation.V12 << 3;
			bullet.physics2.X = bullet.vTransform.rotation.V22 << 3;
			bullet.physics2.M2 = 90;
			bullet.FUN_305FC();
			ballistic.FUN_30BF0();
			param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 41, bullet.screen);
			DAT_19 = 8;
			return 0u;
		}
		default:
			return 0u;
		case 2:
			{
				sbyte tags = base.tags;
				if (tags == 1)
				{
					FUN_30BA8();
					goto IL_063c;
				}
				if (tags < 2)
				{
					if (tags != 0)
					{
						return 0u;
					}
					Vector3Int vector3Int = GameManager.instance.FUN_2CE50(this);
					int num = 9437184;
					VigObject vigObject = null;
					if (GameManager.instance.worldObjs != null)
					{
						List<VigTuple> worldObjs = GameManager.instance.worldObjs;
						for (int i = 0; i < worldObjs.Count; i++)
						{
							VigTuple vigTuple = worldObjs[i];
							VigObject vObject = vigTuple.vObject;
							if (vObject.type == 2 && vObject.maxHalfHealth != 0)
							{
								Vector3Int v = default(Vector3Int);
								v.x = vObject.screen.x - vector3Int.x;
								v.y = vObject.screen.y - vector3Int.y;
								v.z = vObject.screen.z - vector3Int.z;
								Vector2Int vector2Int = Utilities.FUN_2A1C0(v);
								int num2 = (int)((uint)vector2Int.x >> 16) | (vector2Int.y << 16);
								if (num2 < num)
								{
									vigObject = vigTuple.vObject;
									num = num2;
								}
							}
						}
					}
					if (vigObject == null)
					{
						param = 8;
					}
					else
					{
						base.tags = 1;
						screen = new Vector3Int(0, 0, 0);
						PDAT_78 = vigObject;
						FUN_30B78();
						param = 600;
					}
				}
				else
				{
					if (tags != 2)
					{
						if (tags != 3)
						{
							return 0u;
						}
						goto IL_063c;
					}
					base.tags = 3;
					FUN_30BA8();
					param = 90;
				}
				goto IL_0647;
			}
			IL_063c:
			base.tags = 0;
			param = 60;
			goto IL_0647;
			IL_0647:
			GameManager.instance.FUN_30CB0(this, param);
			return 0u;
		}
	}
}
