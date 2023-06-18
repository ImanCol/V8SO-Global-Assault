using Unity.Burst;
using UnityEngine;
using V2UnityDiscordIntercept;

[BurstCompile]
public class ClientSend : MonoBehaviour
{
    private static void SendTCPData(Packet _packet, long userId)
    {
        Debug.Log("SendTCPData: " + _packet + " " + userId);
        _packet.WriteLength();
        if (userId == 0L)
        {
            Debug.Log("Go userId: " + userId);
            if (DiscordController.instance)
                //DiscordController.instance.SendNetworkMessage(0, _packet.ToArray());
                DiscordController.SendNetworkMessage(0, _packet.ToArray());
        }
        else
        {
            Debug.Log("Go else: " + userId);
            if (DiscordController.instance)
                //DiscordController.instance.SendNetworkMessageToUser(userId, 0, _packet.ToArray());
                DiscordController.SendNetworkMessageToUser(userId, 0, _packet.ToArray());
        }
    }

    private static void SendUDPData(Packet _packet, long userId)
    {
        _packet.WriteLength();
        if (userId == 0L)
        {
            //DiscordController.instance.SendNetworkMessage(1, _packet.ToArray());
            DiscordController.SendNetworkMessage(1, _packet.ToArray());
        }
        else
        {
            //DiscordController.instance.SendNetworkMessageToUser(userId, 1, _packet.ToArray());
            DiscordController.SendNetworkMessageToUser(userId, 1, _packet.ToArray());
        }
    }

    //public static void Joined()
    public static bool Joined()
    {
        using (Packet packet = new Packet(1))
        {
            packet.Write(Plugin.Username);
            Plugin.Client.SendTCPData(packet, 0L);
        }
        return false;
        //---------//
        //using (Packet packet = new Packet(1))
        //{
        //    GameManager.instance.gameTagPlayerLocal = packet.ToString();
        //    packet.Write(DiscordController.instance.userManager.GetCurrentUser().Username);
        //    Debug.Log(DiscordController.instance.userManager.GetCurrentUser().Username + " Se unio");
        //    SendTCPData(packet, 0L);
        //}
    }


    //public static void Welcome(long userId)

    public static bool Welcome(long userId)
    {
        using (Packet packet = new Packet(2))
        {
            packet.Write(Plugin.Username);
            packet.Write(GameManager.instance.ready);
            packet.Write(GameManager.instance.vehicles[0]);
            Plugin.Client.SendTCPData(packet, userId);
        }
        return false;
        //---------//
        //using (Packet packet = new Packet(2))
        //{
        //    Debug.Log("Welcome " + packet);
        //    packet.Write(DiscordController.instance.userManager.GetCurrentUser().Username);
        //    packet.Write(GameManager.instance.ready);
        //    packet.Write(GameManager.instance.vehicles[0]);
        //    SendTCPData(packet, userId);
        //}
    }

    public static void Ready(long userId = 0L)
    {
        using (Packet packet = new Packet(3))
        {
            packet.Write(GameManager.instance.vehicles[0]);
            SendTCPData(packet, userId);
        }
    }

    public static void NotReady(long userId = 0L)
    {
        using (Packet packet = new Packet(4))
        {
            packet.Write(GameManager.instance.vehicles[0]);
            SendTCPData(packet, userId);
        }
    }

    public static void Load()
    {
        using (Packet packet = new Packet(5))
        {
            SendTCPData(packet, 0L);
        }
    }
    public static void Mode(long userId = 0L)
    {
        using (Packet packet = new Packet(6))
        {
            packet.Write((int)GameManager.instance.gameMode);
            SendTCPData(packet, userId);
        }
    }

    public static void Map(long userId = 0L)
    {
        using (Packet packet = new Packet(7))
        {
            packet.Write(GameManager.instance.map);
            SendTCPData(packet, userId);
        }
    }

    public static void Damage(long userId = 0L)
    {
        using (Packet packet = new Packet(8))
        {
            packet.Write(GameManager.instance.damageMode[0]);
            SendTCPData(packet, userId);
        }
    }

    public static void Difficulty(long userId = 0L)
    {
        using (Packet packet = new Packet(9))
        {
            packet.Write(GameManager.instance.difficultyMode);
            SendTCPData(packet, userId);
        }
    }

    public static void Lives(int _lives, long userId = 0L)
    {
        using (Packet packet = new Packet(10))
        {
            packet.Write((byte)_lives);
            SendTCPData(packet, userId);
        }
    }

    public static void Spawn()
    {
        using (Packet packet = new Packet(11))
        //using (Packet packet = new Packet((int)ClientPackets.spawned))
        {
            //packet.Write(GameManager.instance.vehicles[0]);
            //Plugin.Client.SendTCPData(packet, 0L);
            Debug.Log("Spawn Vechile info: " + GameManager.instance.vehicles[0]);
            packet.Write(GameManager.instance.vehicles[0]);
            SendTCPData(packet, 0L);
        }
    }

    public static void Transform(ref VigTransform vTransform)
    {
        using (Packet packet = new Packet(12))
        {
            packet.Write(vTransform.rotation.V00);
            packet.Write(vTransform.rotation.V01);
            packet.Write(vTransform.rotation.V02);
            packet.Write(vTransform.rotation.V10);
            packet.Write(vTransform.rotation.V11);
            packet.Write(vTransform.rotation.V12);
            packet.Write(vTransform.rotation.V20);
            packet.Write(vTransform.rotation.V21);
            packet.Write(vTransform.rotation.V22);
            packet.Write(vTransform.position.x);
            packet.Write(vTransform.position.y);
            packet.Write(vTransform.position.z);
            SendUDPData(packet, 0L);
        }
    }

    public static void Physics(ref Matrix2x4 m1, ref Matrix2x4 m2)
    {
        using (Packet packet = new Packet(13))
        {
            packet.Write(m1.X);
            packet.Write(m1.Y);
            packet.Write(m1.Z);
            packet.Write(m2.X);
            packet.Write(m2.Y);
            packet.Write(m2.Z);
            SendUDPData(packet, 0L);
        }
    }

    public static void Control(Vehicle player)
    {
        using (Packet packet = new Packet(14))
        {
            packet.Write(player.turning);
            packet.Write(player.acceleration);
            packet.Write(player.direction);
            packet.Write(player.weaponSlot);
            packet.Write(player.breaking);
            Vehicle vehicle = player.target as Vehicle;
            if (vehicle != null)
            {
                if (vehicle.userId != 0L)
                {
                    packet.Write(vehicle.userId);
                }
                else
                {
                    packet.Write((long)vehicle.id);
                }
            }
            else
            {
                packet.Write(0L);
            }
            if (player.mgun != null)
            {
                packet.Write(player.mgun.tags);
            }
            SendUDPData(packet, 0L);
        }
    }

    public static void Status(Vehicle player)
    {
        using (Packet packet = new Packet(15))
        {
            packet.Write(player.maxHalfHealth);
            packet.Write(player.maxFullHealth);
            if (player.body[0] != null)
            {
                packet.Write(player.body[0].maxHalfHealth);
                packet.Write(player.body[1].maxHalfHealth);
            }
            packet.Write(player.ignition);
            packet.Write(player.transformation);
            packet.Write(player.doubleDamage);
            packet.Write(player.shield);
            packet.Write(player.jammer);
            SendUDPData(packet, 0L);
        }
    }

    public static void Pickup(int type, ushort ammo = 0, sbyte tags = 0)
    {
        using (Packet packet = new Packet(16))
        {
            packet.Write(type);
            packet.Write(ammo);
            packet.Write(tags);
            SendTCPData(packet, 0L);
        }
    }

    public static void Weapon(sbyte type)
    {
        using (Packet packet = new Packet(17))
        {
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void Combo(ushort input, sbyte type)
    {
        using (Packet packet = new Packet(18))
        {
            packet.Write(input);
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void TrailerTransform(ref VigTransform vTransform)
    {
        using (Packet packet = new Packet(19))
        {
            packet.Write(vTransform.rotation.V00);
            packet.Write(vTransform.rotation.V01);
            packet.Write(vTransform.rotation.V02);
            packet.Write(vTransform.rotation.V10);
            packet.Write(vTransform.rotation.V11);
            packet.Write(vTransform.rotation.V12);
            packet.Write(vTransform.rotation.V20);
            packet.Write(vTransform.rotation.V21);
            packet.Write(vTransform.rotation.V22);
            packet.Write(vTransform.position.x);
            packet.Write(vTransform.position.y);
            packet.Write(vTransform.position.z);
            SendUDPData(packet, 0L);
        }
    }

    public static void TrailerDetach()
    {
        using (Packet packet = new Packet(20))
        {
            SendTCPData(packet, 0L);
        }
    }

    public static void Destroyed()
    {
        using (Packet packet = new Packet(21))
        {
            SendTCPData(packet, 0L);
        }
    }

    public static void Wrecked()
    {
        using (Packet packet = new Packet(22))
        {
            SendTCPData(packet, 0L);
        }
    }

    public static void Totaled()
    {
        using (Packet packet = new Packet(23))
        {
            SendTCPData(packet, 0L);
        }
    }

    public static void DropWeapon(sbyte type)
    {
        using (Packet packet = new Packet(24))
        {
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void SpawnPickup(short id, sbyte tags, short type, bool child)
    {
        using (Packet packet = new Packet(25))
        {
            packet.Write(id);
            packet.Write(tags);
            packet.Write(type);
            packet.Write(child);
            SendTCPData(packet, 0L);
        }
    }

    public static void ObjectDestroyed(int id)
    {
        using (Packet packet = new Packet(26))
        {
            packet.Write(id);
            SendTCPData(packet, 0L);
        }
    }

    public static void RandomNumber(uint number1, uint number2)
    {
        using (Packet packet = new Packet(27))
        {
            packet.Write(number1);
            packet.Write(number2);
            SendUDPData(packet, 0L);
        }
    }

    public static void SpawnAI(short id, byte vehicle, uint flags)
    {
        using (Packet packet = new Packet(28))
        {
            packet.Write(id);
            packet.Write(vehicle);
            packet.Write(flags);
            SendTCPData(packet, 0L);
        }
    }

    public static void TransformAI(short id, ref VigTransform vTransform)
    {
        using (Packet packet = new Packet(29))
        {
            packet.Write(id);
            packet.Write(vTransform.rotation.V00);
            packet.Write(vTransform.rotation.V01);
            packet.Write(vTransform.rotation.V02);
            packet.Write(vTransform.rotation.V10);
            packet.Write(vTransform.rotation.V11);
            packet.Write(vTransform.rotation.V12);
            packet.Write(vTransform.rotation.V20);
            packet.Write(vTransform.rotation.V21);
            packet.Write(vTransform.rotation.V22);
            packet.Write(vTransform.position.x);
            packet.Write(vTransform.position.y);
            packet.Write(vTransform.position.z);
            SendUDPData(packet, 0L);
        }
    }

    public static void PhysicsAI(short id, ref Matrix2x4 m1, ref Matrix2x4 m2)
    {
        using (Packet packet = new Packet(30))
        {
            packet.Write(id);
            packet.Write(m1.X);
            packet.Write(m1.Y);
            packet.Write(m1.Z);
            packet.Write(m2.X);
            packet.Write(m2.Y);
            packet.Write(m2.Z);
            SendUDPData(packet, 0L);
        }
    }

    public static void ControlAI(Vehicle player)
    {
        using (Packet packet = new Packet(31))
        {
            packet.Write(player.id);
            packet.Write(player.turning);
            packet.Write(player.acceleration);
            packet.Write(player.direction);
            packet.Write(player.weaponSlot);
            packet.Write(player.breaking);
            Vehicle vehicle = player.target as Vehicle;
            if (vehicle != null)
            {
                packet.Write(vehicle.userId);
            }
            else
            {
                packet.Write(0L);
            }
            if (player.mgun != null)
            {
                packet.Write(player.mgun.tags);
            }
            SendUDPData(packet, 0L);
        }
    }

    public static void StatusAI(Vehicle player)
    {
        using (Packet packet = new Packet(32))
        {
            packet.Write(player.id);
            packet.Write(player.maxHalfHealth);
            packet.Write(player.maxFullHealth);
            if (player.body[0] != null)
            {
                packet.Write(player.body[0].maxHalfHealth);
                packet.Write(player.body[1].maxHalfHealth);
            }
            packet.Write(player.ignition);
            packet.Write(player.transformation);
            packet.Write(player.doubleDamage);
            packet.Write(player.shield);
            packet.Write(player.jammer);
            SendUDPData(packet, 0L);
        }
    }

    public static void PickupAI(short id, int type, ushort ammo = 0, sbyte tags = 0)
    {
        using (Packet packet = new Packet(33))
        {
            packet.Write(id);
            packet.Write(type);
            packet.Write(ammo);
            packet.Write(tags);
            SendTCPData(packet, 0L);
        }
    }

    public static void WeaponAI(short id, sbyte type)
    {
        using (Packet packet = new Packet(34))
        {
            packet.Write(id);
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void ComboAI(short id, ushort input, sbyte type)
    {
        using (Packet packet = new Packet(35))
        {
            packet.Write(id);
            packet.Write(input);
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void TrailerTransformAI(short id, ref VigTransform vTransform)
    {
        using (Packet packet = new Packet(36))
        {
            packet.Write(id);
            packet.Write(vTransform.rotation.V00);
            packet.Write(vTransform.rotation.V01);
            packet.Write(vTransform.rotation.V02);
            packet.Write(vTransform.rotation.V10);
            packet.Write(vTransform.rotation.V11);
            packet.Write(vTransform.rotation.V12);
            packet.Write(vTransform.rotation.V20);
            packet.Write(vTransform.rotation.V21);
            packet.Write(vTransform.rotation.V22);
            packet.Write(vTransform.position.x);
            packet.Write(vTransform.position.y);
            packet.Write(vTransform.position.z);
            SendUDPData(packet, 0L);
        }
    }

    public static void TrailerDetachAI(short id)
    {
        using (Packet packet = new Packet(37))
        {
            packet.Write(id);
            SendTCPData(packet, 0L);
        }
    }

    public static void DestroyedAI(short id)
    {
        using (Packet packet = new Packet(38))
        {
            packet.Write(id);
            SendTCPData(packet, 0L);
        }
    }

    public static void WreckedAI(short id)
    {
        using (Packet packet = new Packet(39))
        {
            packet.Write(id);
            SendTCPData(packet, 0L);
        }
    }

    public static void TotaledAI(short id)
    {
        using (Packet packet = new Packet(40))
        {
            packet.Write(id);
            SendTCPData(packet, 0L);
        }
    }

    public static void DropWeaponAI(short id, sbyte type)
    {
        using (Packet packet = new Packet(41))
        {
            packet.Write(id);
            packet.Write(type);
            SendTCPData(packet, 0L);
        }
    }

    public static void Pause()
    {
        using (Packet packet = new Packet(42))
        {
            SendTCPData(packet, 0L);
        }
    }

    //Espera al Host
    public static void waitLoad()
    {
        using (Packet packet = new Packet(45))
        {
            SendTCPData(packet, 0L);
        }
    }

}