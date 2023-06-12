using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientHandle : MonoBehaviour
{
    public static void Joined(Packet _packet, long userId)
    {
        if (SceneManager.GetActiveScene().name == "MENU-Driver")
        {
            //Get Username
            GameManager.instance.SetPlayer(_packet);
            //StatsPanel.instance.SpawnVehicle(2, 0);
        }
        string text = _packet.ReadString();
        UnityEngine.Debug.Log(text + " joined." + " User ID: " + userId.ToString());
        GameManager.instance.networkMembers.Add(userId, null);
        Demo.instance.playerReady.Add(userId, value: false);
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
            ClientSend.Lives(GameManager.instance.playerSpawns, userId);
        }
    }

    public static void Welcome(Packet _packet, long userId)
    {
        string value = _packet.ReadString();
        bool value2 = _packet.ReadBool();
        byte value3 = _packet.ReadByte();
        GameManager.instance.networkMembers.Add(userId, null);
        Demo.instance.playerReady.Add(userId, value2);
        Demo.instance.playerNames.Add(userId, value);
        Demo.instance.playerVehicles.Add(userId, value3);
        Demo.instance.InstantiateText(userId);
        Demo.instance.UpdatePlayerStatus(userId);
    }

    public static void Ready(Packet _packet, long userId)
    {
        byte b = _packet.ReadByte();
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
        byte b = _packet.ReadByte();
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
        GameManager.instance.LoadMultiplayerLevel(isHost: false);
    }

    public static void Mode(Packet _packet, long userId)
    {
        _GAME_MODE gAME_MODE = (_GAME_MODE)_packet.ReadInt();
        GameManager.instance.gameMode = gAME_MODE;
        Demo.instance.modeText.text = "MODE: " + Demo.modeNames[(int)gAME_MODE];
        switch (gAME_MODE)
        {
            case _GAME_MODE.Versus2:
                Demo.instance.damageText.gameObject.SetActive(value: true);
                Demo.instance.difficultyText.gameObject.SetActive(value: false);
                Demo.instance.livesText.gameObject.SetActive(value: true);
                return;
            case _GAME_MODE.Coop2:
                for (int i = 0; i < 6; i++)
                {
                    GameManager.instance.DAT_1030[i] = 1;
                }
                break;
        }
        Demo.instance.damageText.gameObject.SetActive(value: true);
        Demo.instance.difficultyText.gameObject.SetActive(value: true);
        Demo.instance.livesText.gameObject.SetActive(value: false);
    }

    public static void Map(Packet _packet, long userId)
    {
        int num = _packet.ReadInt();
        GameManager.instance.map = num;
        Demo.instance.mapText.text = "MAP: " + Demo.mapNames[num - 1];
    }

    public static void Damage(Packet _packet, long userId)
    {
        sbyte b = _packet.ReadSByte();
        GameManager.instance.damageMode[0] = b;
        GameManager.instance.damageMode[1] = b;
        Demo.instance.damageText.text = "DAMAGE: " + Demo.damageNames[b];
    }

    public static void Difficulty(Packet _packet, long userId)
    {
        byte b = _packet.ReadByte();
        GameManager.instance.difficultyMode = b;
        if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
        {
            Demo.instance.damageText.text = "DAMAGE: " + Demo.damageNames[b];
        }
        else
        {
            Demo.instance.difficultyText.text = "DIFFICULTY: " + Demo.difficultyNames[b];
        }
    }

    public static void Lives(Packet _packet, long userId)
    {
        byte b = _packet.ReadByte();
        GameManager.instance.playerSpawns = (sbyte)b;
        for (int i = 0; i < GameManager.instance.networkMembers.Count; i++)
        {
            GameManager.instance.DAT_1030[i] = (sbyte)b;
        }
        Demo.instance.livesText.text = "LIVES: " + b.ToString();
    }

    public static void Spawn(Packet _packet, long userId)
    {
        byte b = _packet.ReadByte();
        short num = 1;
        if (GameManager.instance.networkIds.ContainsKey(userId))
        {
            num = GameManager.instance.networkIds[userId];
        }
        else
        {
            while (GameManager.instance.networkIds.ContainsValue(num))
            {
                num = (short)(num + 1);
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
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 66, vehicle.vTransform.position);
            LevelManager.instance.FUN_4DE54(vehicle.vTransform.position, 39);
            GameManager.instance.FUN_309A0(vehicle);
        }
        if (GameManager.instance.gameMode == _GAME_MODE.Versus2)
        {
            GameManager.instance.vehicles[num + 1] = b;
            GameManager.instance.DAT_1030[num - 1]--;
            GameManager.instance.networkMembers[userId] = GameManager.instance.FUN_3208C(num, num);
        }
        else
        {
            GameManager.instance.networkMembers[userId] = GameManager.instance.FUN_3208C(-2, num);
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
                V00 = _packet.ReadShort(),
                V01 = _packet.ReadShort(),
                V02 = _packet.ReadShort(),
                V10 = _packet.ReadShort(),
                V11 = _packet.ReadShort(),
                V12 = _packet.ReadShort(),
                V20 = _packet.ReadShort(),
                V21 = _packet.ReadShort(),
                V22 = _packet.ReadShort()
            };
            vehicle.vTransform.position = new Vector3Int(_packet.ReadInt(), _packet.ReadInt(), _packet.ReadInt());
        }
    }

    public static void Physics(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        if (vehicle != null)
        {
            vehicle.physics1.X = _packet.ReadInt();
            vehicle.physics1.Y = _packet.ReadInt();
            vehicle.physics1.Z = _packet.ReadInt();
            vehicle.physics2.X = _packet.ReadInt();
            vehicle.physics2.Y = _packet.ReadInt();
            vehicle.physics2.Z = _packet.ReadInt();
        }
    }

    public static void Control(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        if (!(vehicle != null))
        {
            return;
        }
        vehicle.turning = _packet.ReadShort();
        vehicle.acceleration = _packet.ReadShort();
        vehicle.direction = _packet.ReadSByte();
        vehicle.weaponSlot = _packet.ReadByte();
        vehicle.breaking = _packet.ReadSByte();
        long num = _packet.ReadLong();
        if (num != 0L)
        {
            if (num == DiscordController.GetUserId())
            {
                vehicle.target = GameManager.instance.playerObjects[0];
            }
            else if (num > 0 && num <= 6)
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
        if (vehicle.mgun != null && _packet.ReadSByte() != 0)
        {
            vehicle.mgun.UpdateW(12, vehicle);
        }
    }

    public static void Status(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        if (vehicle != null)
        {
            vehicle.maxHalfHealth = _packet.ReadUShort();
            vehicle.maxFullHealth = _packet.ReadUShort();
            if (vehicle.body[0] != null)
            {
                vehicle.body[0].maxHalfHealth = _packet.ReadUShort();
                vehicle.body[1].maxHalfHealth = _packet.ReadUShort();
            }
            vehicle.ignition = _packet.ReadShort();
            vehicle.transformation = _packet.ReadUShort();
            vehicle.doubleDamage = _packet.ReadUShort();
            vehicle.shield = _packet.ReadUShort();
            vehicle.jammer = _packet.ReadUShort();
        }
    }

    public static void Pickup(Packet _packet, long userId)
    {
        int num = _packet.ReadInt();
        ushort num2 = _packet.ReadUShort();
        sbyte b = _packet.ReadSByte();
        byte weaponSlot = 0;
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        for (int i = 0; i < 3; i++)
        {
            if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
            {
                weaponSlot = (byte)i;
            }
        }
        int param2;
        _WHEELS param;
        ConfigContainer configContainer;
        VigObject vigObject;
        switch (num)
        {
            default:
                return;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return;
            case 10:
                param2 = 2;
                goto IL_00d0;
            case 11:
                param2 = 3;
                goto IL_00d0;
            case 12:
                param2 = 1;
                goto IL_00d0;
            case 13:
                param2 = 5;
                goto IL_00d0;
            case 14:
                param2 = 4;
                goto IL_00d0;
            case 15:
                param2 = 6;
                goto IL_00d0;
            case 6:
                param2 = 7;
                goto IL_00d0;
            case 8:
                param = _WHEELS.Sea;
                break;
            case 9:
                param = _WHEELS.Snow;
                break;
            case 16:
                param = _WHEELS.Ground;
                break;
            case 7:
                {
                    param = _WHEELS.Air;
                    break;
                }
            IL_00d0:
                vehicle.weaponSlot = weaponSlot;
                configContainer = vehicle.FUN_4AE5C(param2);
                if (configContainer == null)
                {
                    return;
                }
                vigObject = vehicle.FUN_4AE94(param2);
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
                    if ((vigObject.flags & 0x80) == 0)
                    {
                        vigObject.FUN_30B78();
                    }
                    vehicle.FUN_3A3D4(vigObject);
                    int param3 = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 42, vehicle.vTransform.position);
                }
                return;
        }
        vehicle.FUN_3E32C(param, 500);
    }

    public static void Weapon(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        sbyte b = _packet.ReadSByte();
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
        ushort arg = _packet.ReadUShort();
        sbyte b = _packet.ReadSByte();
        for (int i = 0; i < 3; i++)
        {
            if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
            {
                vehicle.weapons[i].UpdateW(0, vehicle);
                vehicle.weapons[i].UpdateW(10, arg);
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
                    V00 = _packet.ReadShort(),
                    V01 = _packet.ReadShort(),
                    V02 = _packet.ReadShort(),
                    V10 = _packet.ReadShort(),
                    V11 = _packet.ReadShort(),
                    V12 = _packet.ReadShort(),
                    V20 = _packet.ReadShort(),
                    V21 = _packet.ReadShort(),
                    V22 = _packet.ReadShort()
                };
                trailer.vTransform.position = new Vector3Int(_packet.ReadInt(), _packet.ReadInt(), _packet.ReadInt());
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
            IEnumerator routine = UIManager.instance.Printf(str + " TOTALED!");
            UIManager.instance.StopAllCoroutines();
            UIManager.instance.StartCoroutine(routine);
        }
        vehicle.FUN_38870();
        UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(byte.MaxValue, 0, 0, 8));
        vehicle.physics2.Y = 50000;
        vehicle.physics1.Y -= 976512;
        GameManager.instance.playerObjects[0].FUN_3AC4C();
        GameManager.instance.playerObjects[0].DAT_BF++;
    }

    public static void DropWeapon(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.networkMembers[userId];
        sbyte b = _packet.ReadSByte();
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
        short param = _packet.ReadShort();
        sbyte b = _packet.ReadSByte();
        short num = _packet.ReadShort();
        bool num2 = _packet.ReadBool();
        VigObject vigObject = GameManager.instance.FUN_30250(GameManager.instance.worldObjs, param);
        if (vigObject != null && vigObject.type == 3)
        {
            GameManager.instance.FUN_309A0(vigObject);
        }
        Pickup pickup = GameManager.instance.FUN_30250(GameManager.instance.DAT_1078, param) as Pickup;
        if (num2)
        {
            pickup = (pickup.child as Pickup);
        }
        if (pickup != null)
        {
            pickup.tags = b;
            pickup.DAT_1A = (short)((b == 1) ? 5 : num);
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
        int index = _packet.ReadInt();
        VigObject vigObject = GameManager.instance.networkObjs[index];
        if (!(vigObject != null))
        {
            return;
        }
        if ((vigObject.flags & 0x40000) == 0)
        {
            if (vigObject.FUN_4DC94())
            {
                LevelManager.instance.level.UpdateW(vigObject, 18, 0);
            }
            return;
        }
        int num = (int)GameManager.FUN_2AC5C();
        Vector3Int param = default(Vector3Int);
        param.x = (num * 3051 >> 15) - 1525;
        param.y = -4577;
        num = (int)GameManager.FUN_2AC5C();
        param.z = (num * 3051 >> 15) - 1525;
        LevelManager.instance.FUN_4AA24((ushort)GameManager.DAT_63FA4[GameManager.instance.DAT_1004], vigObject.vTransform.position, param).flags |= 33816576u;
        vigObject.flags &= 4294705151u;
    }

    public static void RandomNumber(Packet _packet, long userId)
    {
        GameManager.DAT_63A64 = _packet.ReadUInt();
        GameManager.DAT_63A68 = _packet.ReadUInt();
    }

    public static void SpawnAI(Packet _packet, long userId)
    {
        short num = _packet.ReadShort();
        byte b = _packet.ReadByte();
        uint flags = _packet.ReadUInt();
        GameManager.instance.vehicles[num + 1] = b;
        GameManager.instance.DAT_1030[num - 1]--;
        GameManager.instance.enemiesDictionary[num] = GameManager.instance.FUN_3208C(num, (num - 1) % 4 + 1);
        GameManager.instance.enemiesDictionary[num].flags = flags;
        GameManager.instance.enemiesDictionary[num].FUN_3066C();
    }

    public static void TransformAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle != null)
        {
            vehicle.vTransform.rotation = new Matrix3x3
            {
                V00 = _packet.ReadShort(),
                V01 = _packet.ReadShort(),
                V02 = _packet.ReadShort(),
                V10 = _packet.ReadShort(),
                V11 = _packet.ReadShort(),
                V12 = _packet.ReadShort(),
                V20 = _packet.ReadShort(),
                V21 = _packet.ReadShort(),
                V22 = _packet.ReadShort()
            };
            vehicle.vTransform.position = new Vector3Int(_packet.ReadInt(), _packet.ReadInt(), _packet.ReadInt());
        }
    }

    public static void PhysicsAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle != null)
        {
            vehicle.physics1.X = _packet.ReadInt();
            vehicle.physics1.Y = _packet.ReadInt();
            vehicle.physics1.Z = _packet.ReadInt();
            vehicle.physics2.X = _packet.ReadInt();
            vehicle.physics2.Y = _packet.ReadInt();
            vehicle.physics2.Z = _packet.ReadInt();
        }
    }

    public static void ControlAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (!(vehicle != null))
        {
            return;
        }
        vehicle.turning = _packet.ReadShort();
        vehicle.acceleration = _packet.ReadShort();
        vehicle.direction = _packet.ReadSByte();
        vehicle.weaponSlot = _packet.ReadByte();
        vehicle.breaking = _packet.ReadSByte();
        long num = _packet.ReadLong();
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
        if (vehicle.mgun != null && _packet.ReadSByte() != 0)
        {
            vehicle.mgun.UpdateW(12, vehicle);
        }
    }

    public static void StatusAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle != null)
        {
            vehicle.maxHalfHealth = _packet.ReadUShort();
            vehicle.maxFullHealth = _packet.ReadUShort();
            if (vehicle.body[0] != null)
            {
                vehicle.body[0].maxHalfHealth = _packet.ReadUShort();
                vehicle.body[1].maxHalfHealth = _packet.ReadUShort();
            }
            vehicle.ignition = _packet.ReadShort();
            vehicle.transformation = _packet.ReadUShort();
            vehicle.doubleDamage = _packet.ReadUShort();
            vehicle.shield = _packet.ReadUShort();
            vehicle.jammer = _packet.ReadUShort();
        }
    }

    public static void PickupAI(Packet _packet, long userId)
    {
        short key = _packet.ReadShort();
        int num = _packet.ReadInt();
        ushort num2 = _packet.ReadUShort();
        sbyte b = _packet.ReadSByte();
        byte weaponSlot = 0;
        Vehicle vehicle = GameManager.instance.enemiesDictionary[key];
        for (int i = 0; i < 3; i++)
        {
            if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
            {
                weaponSlot = (byte)i;
            }
        }
        int param2;
        _WHEELS param;
        ConfigContainer configContainer;
        VigObject vigObject;
        switch (num)
        {
            default:
                return;
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return;
            case 10:
                param2 = 2;
                goto IL_00da;
            case 11:
                param2 = 3;
                goto IL_00da;
            case 12:
                param2 = 1;
                goto IL_00da;
            case 13:
                param2 = 5;
                goto IL_00da;
            case 14:
                param2 = 4;
                goto IL_00da;
            case 15:
                param2 = 6;
                goto IL_00da;
            case 6:
                param2 = 7;
                goto IL_00da;
            case 8:
                param = _WHEELS.Sea;
                break;
            case 9:
                param = _WHEELS.Snow;
                break;
            case 16:
                param = _WHEELS.Ground;
                break;
            case 7:
                {
                    param = _WHEELS.Air;
                    break;
                }
            IL_00da:
                vehicle.weaponSlot = weaponSlot;
                configContainer = vehicle.FUN_4AE5C(param2);
                if (configContainer == null)
                {
                    return;
                }
                vigObject = vehicle.FUN_4AE94(param2);
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
                    if ((vigObject.flags & 0x80) == 0)
                    {
                        vigObject.FUN_30B78();
                    }
                    vehicle.FUN_3A3D4(vigObject);
                    int param3 = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E628(param3, GameManager.instance.DAT_C2C, 42, vehicle.vTransform.position);
                }
                return;
        }
        vehicle.FUN_3E32C(param, 500);
    }

    public static void WeaponAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        sbyte b = _packet.ReadSByte();
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
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        ushort arg = _packet.ReadUShort();
        sbyte b = _packet.ReadSByte();
        for (int i = 0; i < 3; i++)
        {
            if (vehicle.weapons[i] != null && vehicle.weapons[i].tags == b)
            {
                vehicle.weapons[i].UpdateW(10, arg);
                if (vehicle.weapons[i] != null)
                {
                    vehicle.weapons[i].id = 0;
                }
            }
        }
    }

    public static void TrailerTransformAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle != null)
        {
            Trailer2 trailer = vehicle.trailer;
            if (trailer != null)
            {
                trailer.vTransform.rotation = new Matrix3x3
                {
                    V00 = _packet.ReadShort(),
                    V01 = _packet.ReadShort(),
                    V02 = _packet.ReadShort(),
                    V10 = _packet.ReadShort(),
                    V11 = _packet.ReadShort(),
                    V12 = _packet.ReadShort(),
                    V20 = _packet.ReadShort(),
                    V21 = _packet.ReadShort(),
                    V22 = _packet.ReadShort()
                };
                trailer.vTransform.position = new Vector3Int(_packet.ReadInt(), _packet.ReadInt(), _packet.ReadInt());
            }
        }
    }

    public static void TrailerDetachAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
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
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle.state != _VEHICLE_TYPE.Chasis)
        {
            vehicle.FUN_38C40_2();
        }
    }

    public static void WreckedAI(Packet _packet, long userId)
    {
        GameManager.instance.enemiesDictionary[_packet.ReadShort()].FUN_38DA8_2();
    }

    public static void TotaledAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        if (vehicle.id < 0)
        {
            string str = vehicle.FUN_38398();
            IEnumerator routine = UIManager.instance.Printf(str + " TOTALED!");
            UIManager.instance.StopAllCoroutines();
            UIManager.instance.StartCoroutine(routine);
        }
        vehicle.FUN_38870();
        UIManager.instance.FUN_4E414(vehicle.vTransform.position, new Color32(byte.MaxValue, 0, 0, 8));
        vehicle.physics2.Y = 50000;
        vehicle.physics1.Y -= 976512;
        GameManager.instance.playerObjects[0].FUN_3AC4C();
        GameManager.instance.playerObjects[0].DAT_BF++;
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
        }
        else
        {
            do
            {
                vehicle.FUN_38A38(param1: false);
                num++;
            }
            while (num < 3);
        }
    }

    public static void DropWeaponAI(Packet _packet, long userId)
    {
        Vehicle vehicle = GameManager.instance.enemiesDictionary[_packet.ReadShort()];
        sbyte b = _packet.ReadSByte();
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
