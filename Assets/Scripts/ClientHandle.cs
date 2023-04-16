using System;
using System.Collections;
using UnityEngine;

public class ClientHandle : MonoBehaviour
{
	public static void Joined(Packet _packet, long userId)
	{
		string text = _packet.ReadString(true);
		UnityEngine.Debug.Log(text + "joined.");
		GameManager.instance.networkMembers.Add(userId, null);
		Demo.instance.playerReady.Add(userId, false);
		Demo.instance.playerNames.Add(userId, text);
		Demo.instance.playerVehicles.Add(userId, 0);
		Demo.instance.InstantiateText(userId);
		ClientSend.Welcome(userId);
		if (GameManager.instance.ready)
		{
			ClientSend.Ready(userId);
		}
		else
		{
			ClientSend.NotReady(userId);
		}
		if (DiscordController.IsOwner())
		{
			ClientSend.Mode(userId);
			ClientSend.Map(userId);
			ClientSend.Damage(userId);
			ClientSend.Difficulty(userId);
			ClientSend.Lives((int)GameManager.instance.playerSpawns, userId);
		}
	}

	public static void Welcome(Packet _packet, long userId)
	{
		string value = _packet.ReadString(true);
		bool value2 = _packet.ReadBool(true);
		byte value3 = _packet.ReadByte(true);
		GameManager.instance.networkMembers.Add(userId, null);
		Demo.instance.playerReady.Add(userId, value2);
		Demo.instance.playerNames.Add(userId, value);
		Demo.instance.playerVehicles.Add(userId, value3);
		Demo.instance.InstantiateText(userId);
		Demo.instance.UpdatePlayerStatus(userId);
	}

	public static void Ready(Packet _packet, long userId)
	{
		byte b = _packet.ReadByte(true);
		Demo.instance.playerReady[userId] = true;
		Demo.instance.playerVehicles[userId] = b;
		Demo.instance.UpdatePlayerStatus(userId);
		if (GameManager.instance.gameMode > _GAME_MODE.Versus2)
		{
			GameManager.instance.vehicles[1] = b;
		}
	}

	public static void NotReady(Packet _packet, long userId)
	{
		byte b = _packet.ReadByte(true);
		Demo.instance.playerReady[userId] = false;
		Demo.instance.playerVehicles[userId] = b;
		Demo.instance.UpdatePlayerStatus(userId);
		if (GameManager.instance.gameMode > _GAME_MODE.Versus2)
		{
			GameManager.instance.vehicles[1] = b;
		}
	}

	public static void Load(Packet _packet, long userId)
	{
		GameManager.instance.LoadMultiplayerLevel(false);
	}

	public static void Mode(Packet _packet, long userId)
	{
		_GAME_MODE game_MODE = (_GAME_MODE)_packet.ReadInt(true);
		GameManager.instance.gameMode = game_MODE;
		Demo.instance.modeText.text = "MODE: " + Demo.modeNames[(int)game_MODE];
		if (game_MODE != _GAME_MODE.Versus2)
		{
			if (game_MODE == _GAME_MODE.Coop2)
			{
				for (int i = 0; i < 6; i++)
				{
					GameManager.instance.DAT_1030[i] = 1;
				}
			}
			Demo.instance.damageText.gameObject.SetActive(true);
			Demo.instance.difficultyText.gameObject.SetActive(true);
			Demo.instance.livesText.gameObject.SetActive(false);
			return;
		}
		Demo.instance.damageText.gameObject.SetActive(true);
		Demo.instance.difficultyText.gameObject.SetActive(false);
		Demo.instance.livesText.gameObject.SetActive(true);
	}

	public static void Map(Packet _packet, long userId)
	{
		int num = _packet.ReadInt(true);
		GameManager.instance.map = num;
		Demo.instance.mapText.text = "MAP: " + Demo.mapNames[num - 1];
	}

	public static void Damage(Packet _packet, long userId)
	{
		sbyte b = _packet.ReadSByte(true);
		GameManager.instance.DAT_C80[0] = b;
		GameManager.instance.DAT_C80[1] = b;
		Demo.instance.damageText.text = "DAMAGE: " + Demo.damageNames[(int)b];
	}

	public static void Difficulty(Packet _packet, long userId)
	{
		byte b = _packet.ReadByte(true);
		GameManager.instance.DAT_C6E = b;
		if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
		{
			Demo.instance.damageText.text = "DAMAGE: " + Demo.damageNames[(int)b];
			return;
		}
		Demo.instance.difficultyText.text = "DIFFICULTY: " + Demo.difficultyNames[(int)b];
	}

	public static void Lives(Packet _packet, long userId)
	{
		byte b = _packet.ReadByte(true);
		GameManager.instance.playerSpawns = (sbyte)b;
		for (int i = 0; i < GameManager.instance.networkMembers.Count; i++)
		{
			GameManager.instance.DAT_1030[i] = (sbyte)b;
		}
		Demo.instance.livesText.text = "LIVES: " + b.ToString();
	}

	public static void Spawn(Packet _packet, long userId)
	{
		byte b = _packet.ReadByte(true);
		short num = 1;
		if (GameManager.instance.networkIds.ContainsKey(userId))
		{
			num = GameManager.instance.networkIds[userId];
		}
		else
		{
			while (GameManager.instance.networkIds.ContainsValue(num))
			{
				num += 1;
			}
		}
		if (!GameManager.instance.networkIds.ContainsKey(userId))
		{
			GameManager.instance.networkIds.Add(userId, num);
		}
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			int param = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 66, vehicle.vTransform.position, false);
			LevelManager.instance.FUN_4DE54(vehicle.vTransform.position, 39);
			GameManager.instance.FUN_309A0(vehicle);
		}
		if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
		{
			GameManager.instance.vehicles[(int)(num + 1)] = b;
			sbyte[] dat_ = GameManager.instance.DAT_1030;
			short num2 = (short)(num - 1);
			dat_[(int)num2] = (sbyte)(dat_[(int)num2] - 1);
			GameManager.instance.networkMembers[userId] = GameManager.instance.FUN_3208C((int)num, (int)num);
		}
		else
		{
			GameManager.instance.networkMembers[userId] = GameManager.instance.FUN_3208C(-2, (int)num);
			GameManager.instance.playerObjects[1] = GameManager.instance.networkMembers[userId];
		}
		GameManager.instance.networkMembers[userId].FUN_3066C();
		GameManager.instance.networkMembers[userId].userId = userId;
	}

	public static void Transform(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			vehicle.vTransform.rotation = new Matrix3x3
			{
				V00 = _packet.ReadShort(true),
				V01 = _packet.ReadShort(true),
				V02 = _packet.ReadShort(true),
				V10 = _packet.ReadShort(true),
				V11 = _packet.ReadShort(true),
				V12 = _packet.ReadShort(true),
				V20 = _packet.ReadShort(true),
				V21 = _packet.ReadShort(true),
				V22 = _packet.ReadShort(true)
			};
			vehicle.vTransform.position = new Vector3Int(_packet.ReadInt(true), _packet.ReadInt(true), _packet.ReadInt(true));
		}
	}

	public static void Physics(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			vehicle.physics1.X = _packet.ReadInt(true);
			vehicle.physics1.Y = _packet.ReadInt(true);
			vehicle.physics1.Z = _packet.ReadInt(true);
			vehicle.physics2.X = _packet.ReadInt(true);
			vehicle.physics2.Y = _packet.ReadInt(true);
			vehicle.physics2.Z = _packet.ReadInt(true);
		}
	}

	public static void Control(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			vehicle.turning = _packet.ReadShort(true);
			vehicle.acceleration = _packet.ReadShort(true);
			vehicle.direction = _packet.ReadSByte(true);
			vehicle.weaponSlot = _packet.ReadByte(true);
			vehicle.breaking = _packet.ReadSByte(true);
			long num = _packet.ReadLong(true);
			if (num != 0L)
			{
				if (num == DiscordController.GetUserId())
				{
					vehicle.target = GameManager.instance.playerObjects[0];
				}
				else if (num > 0L && num <= 6L)
				{
					vehicle.target = GameManager.instance.enemiesDictionary[(short)num];
				}
				else
				{
					vehicle.target = GameManager.instance.networkMembers[num];
				}
			}
			else
			{
				vehicle.target = null;
			}
			vehicle.FUN_3A5FC(0);
			if (vehicle.mgun != null && _packet.ReadSByte(true) != 0)
			{
				vehicle.mgun.UpdateW(12, vehicle);
			}
		}
	}

	public static void Status(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			vehicle.maxHalfHealth = _packet.ReadUShort(true);
			vehicle.maxFullHealth = _packet.ReadUShort(true);
			if (vehicle.body[0] != null)
			{
				vehicle.body[0].maxHalfHealth = _packet.ReadUShort(true);
				vehicle.body[1].maxHalfHealth = _packet.ReadUShort(true);
			}
			vehicle.ignition = _packet.ReadShort(true);
			vehicle.transformation = _packet.ReadUShort(true);
			vehicle.doubleDamage = _packet.ReadUShort(true);
			vehicle.shield = _packet.ReadUShort(true);
			vehicle.jammer = _packet.ReadUShort(true);
		}
	}

	public static void Pickup(Packet _packet, long userId)
	{
		int num = _packet.ReadInt(true);
		ushort num2 = _packet.ReadUShort(true);
		sbyte b = _packet.ReadSByte(true);
		byte weaponSlot = 0;
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				weaponSlot = (byte)i;
			}
		}
		int param;
		_WHEELS param2;
		switch (num)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			return;
		case 6:
			param = 7;
			break;
		case 7:
			param2 = _WHEELS.Air;
			goto IL_1AC;
		case 8:
			param2 = _WHEELS.Sea;
			goto IL_1AC;
		case 9:
			param2 = _WHEELS.Snow;
			goto IL_1AC;
		case 10:
			param = 2;
			break;
		case 11:
			param = 3;
			break;
		case 12:
			param = 1;
			break;
		case 13:
			param = 5;
			break;
		case 14:
			param = 4;
			break;
		case 15:
			param = 6;
			break;
		case 16:
			param2 = _WHEELS.Ground;
			goto IL_1AC;
		default:
			return;
		}
		vehicle.weaponSlot = weaponSlot;
		ConfigContainer configContainer = vehicle.FUN_4AE5C(param);
		if (configContainer == null)
		{
			return;
		}
		VigObject vigObject = vehicle.FUN_4AE94(param);
		if (vigObject != null)
		{
			vigObject.CCDAT_74 = configContainer;
			vigObject.vr = configContainer.v3_2;
			vigObject.flags |= 16777216u;
			vigObject.maxFullHealth = vigObject.maxHalfHealth;
			if (num2 != 0)
			{
				vigObject.maxHalfHealth = num2;
			}
			vigObject.screen = new Vector3Int(0, 0, 0);
			vigObject.ApplyTransformation();
			if ((vigObject.flags & 128u) == 0u)
			{
				vigObject.FUN_30B78();
			}
			vehicle.FUN_3A3D4(vigObject);
			int param3 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 42, vehicle.vTransform.position, false);
			return;
		}
		return;
		IL_1AC:
		vehicle.FUN_3E32C(param2, 500);
	}

	public static void Weapon(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.weaponSlot = (byte)i;
			}
		}
		vehicle.FUN_3A5FC(1);
	}

	public static void Combo(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		ushort arg = _packet.ReadUShort(true);
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.weapons[i].UpdateW(0, vehicle);
				vehicle.weapons[i].UpdateW(10, (int)arg);
				if (vehicle.weapons[i] != null)
				{
					vehicle.weapons[i].id = 0;
				}
			}
		}
	}

	public static void TrailerTransform(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			Trailer2 trailer = vehicle.trailer;
			if (trailer != null)
			{
				trailer.vTransform.rotation = new Matrix3x3
				{
					V00 = _packet.ReadShort(true),
					V01 = _packet.ReadShort(true),
					V02 = _packet.ReadShort(true),
					V10 = _packet.ReadShort(true),
					V11 = _packet.ReadShort(true),
					V12 = _packet.ReadShort(true),
					V20 = _packet.ReadShort(true),
					V21 = _packet.ReadShort(true),
					V22 = _packet.ReadShort(true)
				};
				trailer.vTransform.position = new Vector3Int(_packet.ReadInt(true), _packet.ReadInt(true), _packet.ReadInt(true));
			}
		}
	}

	public static void TrailerDetach(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle != null)
		{
			Trailer2 trailer = vehicle.trailer;
			if (trailer != null)
			{
				GameManager.instance.FUN_30CB0(trailer, 0);
			}
		}
	}

	public static void Destroyed(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle.state != _VEHICLE_TYPE.Chasis)
		{
			vehicle.FUN_38C40_2();
		}
	}

	public static void Wrecked(Packet _packet, long userId)
	{
		GameManager.instance.networkMembers[userId].FUN_38DA8_2();
	}

	public static void Totaled(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		if (vehicle.id < 0)
		{
			string str = vehicle.FUN_38398();
			IEnumerator routine = UIManager.instance.Printf(str + " TOTALED!", true);
			UIManager.instance.StopAllCoroutines();
			UIManager.instance.StartCoroutine(routine);
		}
		vehicle.FUN_38870();
		UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(byte.MaxValue, 0, 0, 8));
		vehicle.physics2.Y = 50000;
		Vehicle vehicle2 = vehicle;
		vehicle2.physics1.Y = vehicle2.physics1.Y - 976512;
		GameManager.instance.playerObjects[0].FUN_3AC4C();
		Vehicle vehicle3 = GameManager.instance.playerObjects[0];
		vehicle3.DAT_BF += 1;
	}

	public static void DropWeapon(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.networkMembers[userId];
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.FUN_3A280((uint)i);
			}
		}
	}

	public static void SpawnPickup(Packet _packet, long userId)
	{
		short param = _packet.ReadShort(true);
		sbyte b = _packet.ReadSByte(true);
		short num = _packet.ReadShort(true);
		bool flag = _packet.ReadBool(true);
		VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, (int)param);
		if (vigObject != null && vigObject.type == 3)
		{
			GameManager.instance.FUN_309A0(vigObject);
		}
		Pickup pickup = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, (int)param) as Pickup;
		if (flag)
		{
			pickup = (pickup.child as Pickup);
		}
		if (pickup != null)
		{
			pickup.tags = b;
			pickup.DAT_1A = ((short)((b == 1) ? 5 : num));
			VigObject vigObject2 = pickup.FUN_31DDC();
			vigObject2.flags |= 16777216u;
			vigObject2.DAT_1A = num;
			pickup.flags |= 32768u;
			vigObject2.flags &= 4278190077u;
			vigObject2.FUN_3066C();
		}
	}

	public static void ObjectDestroyed(Packet _packet, long userId)
	{
		int index = _packet.ReadInt(true);
		VigObject vigObject = GameManager.instance.networkObjs[index];
		if (vigObject != null)
		{
			if ((vigObject.flags & 262144u) == 0u)
			{
				if (vigObject.FUN_4DC94())
				{
					LevelManager.instance.level.UpdateW(vigObject, 18, 0);
					return;
				}
			}
			else
			{
				int num = (int)GameManager.FUN_2AC5C();
				Vector3Int param = default(Vector3Int);
				param.x = (num * 3051 >> 15) - 1525;
				param.y = -4577;
				num = (int)GameManager.FUN_2AC5C();
				param.z = (num * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AA24((ushort)GameManager.DAT_63FA4[(int)GameManager.instance.DAT_1004], vigObject.vTransform.position, param).flags |= 33816576u;
				vigObject.flags &= 4294705151u;
			}
		}
	}

	public static void RandomNumber(Packet _packet, long userId)
	{
		GameManager.DAT_63A64 = _packet.ReadUInt(true);
		GameManager.DAT_63A68 = _packet.ReadUInt(true);
	}

	public static void SpawnAI(Packet _packet, long userId)
	{
		short num = _packet.ReadShort(true);
		byte b = _packet.ReadByte(true);
		uint flags = _packet.ReadUInt(true);
		GameManager.instance.vehicles[(int)(num + 1)] = b;
		sbyte[] dat_ = GameManager.instance.DAT_1030;
		short num2 = (short)(num - 1);
		dat_[(int)num2] = (sbyte)(dat_[(int)num2] - 1);
		GameManager.instance.enemiesDictionary[num] = GameManager.instance.FUN_3208C((int)num, (int)((num - 1) % 4 + 1));
		GameManager.instance.enemiesDictionary[num].flags = flags;
		GameManager.instance.enemiesDictionary[num].FUN_3066C();
	}

	public static void TransformAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			vehicle.vTransform.rotation = new Matrix3x3
			{
				V00 = _packet.ReadShort(true),
				V01 = _packet.ReadShort(true),
				V02 = _packet.ReadShort(true),
				V10 = _packet.ReadShort(true),
				V11 = _packet.ReadShort(true),
				V12 = _packet.ReadShort(true),
				V20 = _packet.ReadShort(true),
				V21 = _packet.ReadShort(true),
				V22 = _packet.ReadShort(true)
			};
			vehicle.vTransform.position = new Vector3Int(_packet.ReadInt(true), _packet.ReadInt(true), _packet.ReadInt(true));
		}
	}

	public static void PhysicsAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			vehicle.physics1.X = _packet.ReadInt(true);
			vehicle.physics1.Y = _packet.ReadInt(true);
			vehicle.physics1.Z = _packet.ReadInt(true);
			vehicle.physics2.X = _packet.ReadInt(true);
			vehicle.physics2.Y = _packet.ReadInt(true);
			vehicle.physics2.Z = _packet.ReadInt(true);
		}
	}

	public static void ControlAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			vehicle.turning = _packet.ReadShort(true);
			vehicle.acceleration = _packet.ReadShort(true);
			vehicle.direction = _packet.ReadSByte(true);
			vehicle.weaponSlot = _packet.ReadByte(true);
			vehicle.breaking = _packet.ReadSByte(true);
			long num = _packet.ReadLong(true);
			if (num != 0L)
			{
				if (num == DiscordController.GetUserId())
				{
					vehicle.target = GameManager.instance.playerObjects[0];
				}
				else
				{
					vehicle.target = GameManager.instance.playerObjects[1];
				}
			}
			else
			{
				vehicle.target = null;
			}
			vehicle.FUN_3A5FC(0);
			if (vehicle.mgun != null && _packet.ReadSByte(true) != 0)
			{
				vehicle.mgun.UpdateW(12, vehicle);
			}
		}
	}

	public static void StatusAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			vehicle.maxHalfHealth = _packet.ReadUShort(true);
			vehicle.maxFullHealth = _packet.ReadUShort(true);
			if (vehicle.body[0] != null)
			{
				vehicle.body[0].maxHalfHealth = _packet.ReadUShort(true);
				vehicle.body[1].maxHalfHealth = _packet.ReadUShort(true);
			}
			vehicle.ignition = _packet.ReadShort(true);
			vehicle.transformation = _packet.ReadUShort(true);
			vehicle.doubleDamage = _packet.ReadUShort(true);
			vehicle.shield = _packet.ReadUShort(true);
			vehicle.jammer = _packet.ReadUShort(true);
		}
	}

	public static void PickupAI(Packet _packet, long userId)
	{
		short key = _packet.ReadShort(true);
		int num = _packet.ReadInt(true);
		ushort num2 = _packet.ReadUShort(true);
		sbyte b = _packet.ReadSByte(true);
		byte weaponSlot = 0;
		Vehicle vehicle = GameManager.instance.enemiesDictionary[key];
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				weaponSlot = (byte)i;
			}
		}
		int param;
		_WHEELS param2;
		switch (num)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			return;
		case 6:
			param = 7;
			break;
		case 7:
			param2 = _WHEELS.Air;
			goto IL_1B6;
		case 8:
			param2 = _WHEELS.Sea;
			goto IL_1B6;
		case 9:
			param2 = _WHEELS.Snow;
			goto IL_1B6;
		case 10:
			param = 2;
			break;
		case 11:
			param = 3;
			break;
		case 12:
			param = 1;
			break;
		case 13:
			param = 5;
			break;
		case 14:
			param = 4;
			break;
		case 15:
			param = 6;
			break;
		case 16:
			param2 = _WHEELS.Ground;
			goto IL_1B6;
		default:
			return;
		}
		vehicle.weaponSlot = weaponSlot;
		ConfigContainer configContainer = vehicle.FUN_4AE5C(param);
		if (configContainer == null)
		{
			return;
		}
		VigObject vigObject = vehicle.FUN_4AE94(param);
		if (vigObject != null)
		{
			vigObject.CCDAT_74 = configContainer;
			vigObject.vr = configContainer.v3_2;
			vigObject.flags |= 16777216u;
			vigObject.maxFullHealth = vigObject.maxHalfHealth;
			if (num2 != 0)
			{
				vigObject.maxHalfHealth = num2;
			}
			vigObject.screen = new Vector3Int(0, 0, 0);
			vigObject.ApplyTransformation();
			if ((vigObject.flags & 128u) == 0u)
			{
				vigObject.FUN_30B78();
			}
			vehicle.FUN_3A3D4(vigObject);
			int param3 = GameManager.instance.FUN_1DD9C();
			GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 42, vehicle.vTransform.position, false);
			return;
		}
		return;
		IL_1B6:
		vehicle.FUN_3E32C(param2, 500);
	}

	public static void WeaponAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.weaponSlot = (byte)i;
			}
		}
		vehicle.FUN_3A5FC(1);
	}

	public static void ComboAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		ushort arg = _packet.ReadUShort(true);
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.weapons[i].UpdateW(10, (int)arg);
				if (vehicle.weapons[i] != null)
				{
					vehicle.weapons[i].id = 0;
				}
			}
		}
	}

	public static void TrailerTransformAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			Trailer2 trailer = vehicle.trailer;
			if (trailer != null)
			{
				trailer.vTransform.rotation = new Matrix3x3
				{
					V00 = _packet.ReadShort(true),
					V01 = _packet.ReadShort(true),
					V02 = _packet.ReadShort(true),
					V10 = _packet.ReadShort(true),
					V11 = _packet.ReadShort(true),
					V12 = _packet.ReadShort(true),
					V20 = _packet.ReadShort(true),
					V21 = _packet.ReadShort(true),
					V22 = _packet.ReadShort(true)
				};
				trailer.vTransform.position = new Vector3Int(_packet.ReadInt(true), _packet.ReadInt(true), _packet.ReadInt(true));
			}
		}
	}

	public static void TrailerDetachAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle != null)
		{
			Trailer2 trailer = vehicle.trailer;
			if (trailer != null)
			{
				GameManager.instance.FUN_30CB0(trailer, 0);
			}
		}
	}

	public static void DestroyedAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle.state != _VEHICLE_TYPE.Chasis)
		{
			vehicle.FUN_38C40_2();
		}
	}

	public static void WreckedAI(Packet _packet, long userId)
	{
		GameManager.instance.enemiesDictionary[_packet.ReadShort(true)].FUN_38DA8_2();
	}

	public static void TotaledAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		if (vehicle.id < 0)
		{
			string str = vehicle.FUN_38398();
			IEnumerator routine = UIManager.instance.Printf(str + " TOTALED!", true);
			UIManager.instance.StopAllCoroutines();
			UIManager.instance.StartCoroutine(routine);
		}
		vehicle.FUN_38870();
		UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(byte.MaxValue, 0, 0, 8));
		vehicle.physics2.Y = 50000;
		Vehicle vehicle2 = vehicle;
		vehicle2.physics1.Y = vehicle2.physics1.Y - 976512;
		GameManager.instance.playerObjects[0].FUN_3AC4C();
		Vehicle vehicle3 = GameManager.instance.playerObjects[0];
		vehicle3.DAT_BF += 1;
		int num = 0;
		if (GameManager.instance.gameMode == _GAME_MODE.Survival2)
		{
			num = (int)GameManager.FUN_2AC5C();
			Vector3Int param = default(Vector3Int);
			param.x = (num * 3051 >> 15) - 1525;
			param.y = -4577;
			num = (int)GameManager.FUN_2AC5C();
			param.z = (num * 3051 >> 15) - 1525;
			LevelManager.instance.FUN_4AA24(0, vehicle.vTransform.position, param);
			return;
		}
		do
		{
			vehicle.FUN_38A38(false);
			num++;
		}
		while (num < 3);
	}

	public static void DropWeaponAI(Packet _packet, long userId)
	{
		Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort(true)];
		sbyte b = _packet.ReadSByte(true);
		for (int i = 0; i < 3; i++)
		{
			if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
			{
				vehicle.FUN_3A280((uint)i);
			}
		}
	}

	public static void Pause(Packet _packet, long userId)
	{
		GameManager.instance.paused = !GameManager.instance.paused;
	}
}
