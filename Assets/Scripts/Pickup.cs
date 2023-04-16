using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _PICKUP_TYPE
{
    Type1, //FUN_49D54
    Type2 //FUN_4A808
}

public class Pickup : VigObject
{
	public _PICKUP_TYPE state;

	public byte DAT_87;

	public bool cannotReach;

	public bool destroy;

	public int counter;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint OnCollision(HitDetection param1)
	{
		if (state == _PICKUP_TYPE.Type1)
		{
			VigObject self = param1.self;
			if (self.type != 2 || self.maxHalfHealth == 0)
			{
				if (self.type == 8)
				{
					return 1u;
				}
				return 0u;
			}
			bool flag = false;
			if (self.id > 0)
			{
				for (int i = 0; i < 3; i++)
				{
					if (((Vehicle)self).weapons[i] != null && ((Vehicle)self).weapons[i].tags == 7)
					{
						flag = true;
						break;
					}
				}
			}
			uint num = 6u;
			bool flag2;
			if ((base.tags == 0 || self.id < 1) | flag)
			{
				num = (ushort)DAT_1A;
				flag2 = (num < 24);
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				int param4;
				int num2;
				_WHEELS param2;
				VigObject vigObject;
				Vehicle vehicle;
				Pickup pickup;
				int param3;
				switch (num)
				{
				case 0u:
					vehicle = (Vehicle)self;
					num2 = vehicle.maxFullHealth * 40 / 100;
					if ((GameManager.instance.gameMode == _GAME_MODE.Survival || GameManager.instance.gameMode == _GAME_MODE.Survival2) && self.id < 0)
					{
						param4 = (int)((long)GameManager.instance.wrenchCount * 1374389535L >> 32);
						param4 = (param4 >> 4) - (GameManager.instance.wrenchCount >> 31);
						GameManager.instance.wrenchCount++;
						int num3 = 2;
						if (param4 < num3)
						{
							num3 = param4;
						}
						num2 >>= num3;
					}
					if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
					{
						vehicle.FUN_3A0C0(num2);
					}
					else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
					{
						vehicle.FUN_3A0C0(num2);
					}
					param3 = GameManager.instance.FUN_1DD9C();
					param4 = 44;
					goto IL_0204;
				case 1u:
				case 5u:
					return 0u;
				case 2u:
					vehicle = (Vehicle)self;
					vehicle.jammer += 900;
					goto IL_01f5;
				case 3u:
					vehicle = (Vehicle)self;
					vehicle.doubleDamage += 900;
					goto IL_01f5;
				case 4u:
					vehicle = (Vehicle)self;
					vehicle.shield += 900;
					goto IL_01f5;
				case 10u:
					num2 = 2;
					goto IL_03be;
				case 11u:
					num2 = 3;
					goto IL_03be;
				case 12u:
					num2 = 1;
					goto IL_03be;
				case 13u:
					num2 = 5;
					goto IL_03be;
				case 14u:
					num2 = 4;
					goto IL_03be;
				case 15u:
					num2 = 6;
					goto IL_03be;
				case 6u:
					num2 = 7;
					goto IL_03be;
				case 8u:
					param2 = _WHEELS.Sea;
					goto IL_06bd;
				case 9u:
					param2 = _WHEELS.Snow;
					goto IL_06bd;
				case 7u:
					{
						param2 = _WHEELS.Air;
						goto IL_06bd;
					}
					IL_06bd:
					vehicle = (Vehicle)self;
					if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || vehicle.id == -1)
					{
						vehicle.FUN_3E32C(param2, 500);
					}
					else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
					{
						vehicle.FUN_3E32C(param2, 500);
					}
					if (vehicle.id == -1)
					{
						UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(64, 64, 64, 8));
					}
					GameManager.instance.FUN_309A0(this);
					if ((flags & 0x1000000) != 0)
					{
						GameManager.instance.DAT_1028--;
					}
					vigObject = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, id);
					if (vigObject != null)
					{
						vigObject.flags &= 4294934527u;
					}
					if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && vehicle.id == -1)
					{
						ClientSend.Pickup((int)num, 0, 0);
					}
					else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
					{
						ClientSend.PickupAI(vehicle.id, (int)num, 0, 0);
					}
					return 4294967294u;
					IL_0204:
					GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, param4, vTransform.position);
					if (vehicle.id == -1)
					{
						UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(64, 64, 64, 8));
					}
					if ((flags & 0x1000000) != 0)
					{
						GameManager.instance.DAT_10F0--;
					}
					GameManager.instance.FUN_309A0(this);
					pickup = (GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, id) as Pickup);
					if (pickup != null)
					{
						param3 = 100 * pickup.counter + 600;
						GameManager.instance.FUN_30CB0(pickup, 600);
						if (self.id < 0)
						{
							pickup.counter++;
						}
					}
					if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && vehicle.id == -1)
					{
						ClientSend.Pickup((int)num, 0, 0);
					}
					else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
					{
						ClientSend.PickupAI(vehicle.id, (int)num, 0, 0);
					}
					return 4294967294u;
					IL_01f5:
					param3 = GameManager.instance.FUN_1DD9C();
					param4 = 43;
					goto IL_0204;
					IL_03be:
					if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || self.id == -1 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && self.id > 0))
					{
						ConfigContainer configContainer = self.FUN_4AE5C(num2);
						if (configContainer != null)
						{
							vehicle = (Vehicle)self;
							VigObject vigObject2 = vehicle.FUN_4AE94(num2);
							if (vigObject2 != null)
							{
								sbyte tags = (sbyte)((vehicle.weapons[vehicle.weaponSlot] != null) ? vehicle.weapons[vehicle.weaponSlot].tags : 0);
								vigObject2.CCDAT_74 = configContainer;
								vigObject2.vr = configContainer.v3_2;
								vigObject2.flags |= 16777216u;
								vigObject2.maxFullHealth = vigObject2.maxHalfHealth;
								if (maxHalfHealth != 0)
								{
									vigObject2.maxHalfHealth = maxHalfHealth;
								}
								if ((vehicle.DAT_F6 & 0x400) != 0 && num2 != 7)
								{
									vigObject2.maxHalfHealth *= 2;
								}
								vigObject2.screen.x = screen.x - self.screen.x;
								vigObject2.screen.y = screen.y - self.screen.y;
								vigObject2.screen.z = screen.z - self.screen.z;
								vigObject2.ApplyTransformation();
								if ((vigObject2.flags & 0x80) == 0)
								{
									vigObject2.FUN_30B78();
								}
								vehicle.FUN_3A3D4(vigObject2);
								param3 = GameManager.instance.FUN_1DD9C();
								GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 42, vTransform.position);
								if (vehicle.id == -1)
								{
									UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(64, 64, 64, 8));
								}
								if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && vehicle.id == -1)
								{
									ClientSend.Pickup((int)num, vigObject2.maxHalfHealth, tags);
								}
								else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && vehicle.id > 0)
								{
									ClientSend.PickupAI(vehicle.id, (int)num, vigObject2.maxHalfHealth, tags);
								}
							}
						}
					}
					if ((flags & 0x1000000) != 0)
					{
						GameManager.instance.DAT_1038--;
					}
					GameManager.instance.FUN_309A0(this);
					pickup = (GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, id) as Pickup);
					if (pickup != null)
					{
						param3 = 10 * pickup.counter + 600;
						GameManager.instance.FUN_30CB0(pickup, 600);
						if (self.id < 0)
						{
							pickup.counter++;
						}
					}
					return 4294967294u;
				}
			}
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, VigObject arg2)
	{
		if (state == _PICKUP_TYPE.Type2 && arg1 == 1)
		{
			type = 3;
			flags = 128u;
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		switch (state)
		{
		case _PICKUP_TYPE.Type1:
			switch (arg1)
			{
			case 0:
				vr.y += 68;
				if (arg2 != 0)
				{
					ApplyTransformation();
					return 0u;
				}
				break;
			case 1:
			{
				LevelManager.instance.DAT_1178 = vData;
				int x;
				int z;
				ushort param;
				if (arg2 == 0)
				{
					type = 3;
					flags = (uint)(((int)flags & -9) | 0x380);
					LevelManager.instance.level.UpdateW(25, this);
					if (DAT_6C == 0)
					{
						DAT_6C = 2048000;
					}
					short dAT_1A = DAT_1A;
					if (dAT_1A == 5)
					{
						int num3 = (int)GameManager.instance.FUN_4A970(flags, (ushort)dAT_1A);
						DAT_1A = GameManager.DAT_63FA4[num3];
						dAT_1A = DAT_1A;
					}
					if (dAT_1A != 8)
					{
						return 0u;
					}
					x = screen.x;
					z = screen.z;
					param = base.maxHalfHealth;
				}
				else
				{
					if ((flags & 0x1000000) == 0)
					{
						return 0u;
					}
					ushort maxHalfHealth = (ushort)LevelManager.instance.FUN_35778(screen.x, screen.z);
					x = screen.x;
					z = screen.z;
					param = 0;
					base.maxHalfHealth = maxHalfHealth;
				}
				LevelManager.instance.FUN_359FC(x, z, param);
				break;
			}
			case 2:
				if (type != 3)
				{
					flags &= 4294934527u;
					return uint.MaxValue;
				}
				LevelManager.instance.FUN_4DF20(screen, 13, 2048);
				GameManager.instance.FUN_309A0(this);
				return uint.MaxValue;
			case 4:
				if (DAT_1A != 8)
				{
					return 0u;
				}
				LevelManager.instance.FUN_359FC(screen.x, screen.z, 0u);
				break;
			}
			break;
		case _PICKUP_TYPE.Type2:
			switch (arg1)
			{
			case 0:
			{
				vTransform.position.x += physics1.Z;
				vTransform.position.y += physics1.W;
				vTransform.position.z += physics2.X;
				physics1.W += 90;
				int num = GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z);
				int num2 = num;
				if (GameManager.instance.DAT_DB0 != 0 && vTransform.position.z < GameManager.instance.DAT_DA0)
				{
					num2 = GameManager.instance.DAT_DB0;
					if (num < GameManager.instance.DAT_DB0)
					{
						num2 = num;
					}
				}
				if (num2 >= vTransform.position.y)
				{
					break;
				}
				vTransform.position.y = num2;
				physics1.W = -physics1.W / 2;
				if (--DAT_87 == 0)
				{
					state = _PICKUP_TYPE.Type1;
					screen = vTransform.position;
					if ((flags & 0x2000000) == 0)
					{
						GameManager.instance.FUN_30CB0(this, 600);
					}
				}
				break;
			}
			case 1:
				type = 3;
				flags = 128u;
				break;
			}
			break;
		}
		return 0u;
	}
}
