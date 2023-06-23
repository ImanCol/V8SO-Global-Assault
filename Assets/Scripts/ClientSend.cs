using Unity.Burst;
using UnityEngine;
using V2UnityDiscordIntercept;
using System.Threading;
using System.Threading.Tasks;

[BurstCompile]
public class ClientSend : MonoBehaviour
{
    private static async Task SendTCPData(Packet _packet, long userId)
    {
        Debug.Log("SendTCPData: " + _packet.ToArray() + " " + userId);
        _packet.WriteLength();
        if (userId == 0L)
        {
            Debug.Log("Go userId: " + userId);
            if (DiscordController.instance)
                DiscordController.SendNetworkMessage(0, _packet.ToArray());
        }
        else
        {
            Debug.Log("Go else: " + userId);
            if (DiscordController.instance)
                DiscordController.SendNetworkMessageToUser(userId, 0, _packet.ToArray());
        }
        await Task.Yield();
    }

    private static async Task SendUDPData(Packet _packet, long userId)
    {
        _packet.WriteLength();
        if (userId == 0L)
        {
            DiscordController.SendNetworkMessage(1, _packet.ToArray());
        }
        else
        {
            DiscordController.SendNetworkMessageToUser(userId, 1, _packet.ToArray());
        }
        await Task.Yield();
    }

    //public static void Joined()
    public static async Task<bool> Joined()
    {
        using (Packet packet = new Packet(1))
        {
            packet.Write(Plugin.Username);
            await SendTCPData(packet, 0L);
        }
        return false;
    }


    //public static void Welcome(long userId)

    public static async Task<bool> Welcome(long userId)
    {
        using (Packet packet = new Packet(2))
        {
            packet.Write(Plugin.Username);
            packet.Write(GameManager.instance.ready);
            packet.Write(GameManager.instance.vehicles[0]);
            await SendTCPData(packet, userId);
        }
        return false;
    }

    public static async Task Ready(long userId = 0L)
    {
        using (Packet packet = new Packet(3))
        {
            packet.Write(GameManager.instance.vehicles[0]);
            await SendTCPData(packet, userId);
        }
    }

    public static async Task NotReady(long userId = 0L)
    {
        using (Packet packet = new Packet(4))
        {
            packet.Write(GameManager.instance.vehicles[0]);
            await SendTCPData(packet, userId);
        }
    }


    public static async Task Load()
    {
        using (Packet packet = new Packet(5))
        {
            await SendTCPData(packet, 0L);
        }
    }

    public static async Task Mode(long userId = 0L)
    {
        using (Packet packet = new Packet(6))
        {
            packet.Write((int)GameManager.instance.gameMode);
            await SendTCPData(packet, userId);
        }
    }

    public static async Task Map(long userId = 0L)
    {
        using (Packet packet = new Packet(7))
        {
            packet.Write(GameManager.instance.map);
            await SendTCPData(packet, userId);
        }
    }

    public static async Task Damage(long userId = 0L)
    {
        using (Packet packet = new Packet(8))
        {
            packet.Write(GameManager.instance.damageMode[0]);
            await SendTCPData(packet, userId);
        }
    }

    public static async Task Difficulty(long userId = 0L)
    {
        using (Packet packet = new Packet(9))
        {
            packet.Write(GameManager.instance.difficultyMode);
            await SendTCPData(packet, userId);
        }
    }

    public static async Task Lives(int _lives, long userId = 0L)
    {
        using (Packet packet = new Packet(10))
        {
            packet.Write(_lives);
            await SendTCPData(packet, userId);
        }
    }

    public static async void Spawn()
    {
        using (Packet packet = new Packet(11))
        //using (Packet packet = new Packet((int)ClientPackets.spawned))
        {
            //packet.Write(GameManager.instance.vehicles[0]);
            //Plugin.Client.SendTCPData(packet, 0L);
            Debug.Log("Spawn Vechile info: " + GameManager.instance.vehicles[0]);
            packet.Write(GameManager.instance.vehicles[0]);
            await SendTCPData(packet, 0L);
        }
    }

    public static async Task Respawn(long userId = 0L)
    {
        using (Packet packet = new Packet(11))
        {
            await SendTCPData(packet, userId);
        }
    }

    public static async void Transform(VigTransform vTransform)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void Physics(Matrix2x4 m1, Matrix2x4 m2)
    {
        using (Packet packet = new Packet(13))
        {
            packet.Write(m1.X);
            packet.Write(m1.Y);
            packet.Write(m1.Z);
            packet.Write(m2.X);
            packet.Write(m2.Y);
            packet.Write(m2.Z);
            await SendUDPData(packet, 0L);
        }
    }

    public static async void Control(Vehicle player)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void Status(Vehicle player)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void Pickup(int type, ushort ammo = 0, sbyte tags = 0)
    {
        using (Packet packet = new Packet(16))
        {
            packet.Write(type);
            packet.Write(ammo);
            packet.Write(tags);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Weapon(sbyte type)
    {
        using (Packet packet = new Packet(17))
        {
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Combo(ushort input, sbyte type)
    {
        using (Packet packet = new Packet(18))
        {
            packet.Write(input);
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void TrailerTransform(VigTransform vTransform)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void TrailerDetach()
    {
        using (Packet packet = new Packet(20))
        {
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Destroyed()
    {
        using (Packet packet = new Packet(21))
        {
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Wrecked()
    {
        using (Packet packet = new Packet(22))
        {
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Totaled()
    {
        using (Packet packet = new Packet(23))
        {
            await SendTCPData(packet, 0L);
        }
    }

    public static async void DropWeapon(sbyte type)
    {
        using (Packet packet = new Packet(24))
        {
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void SpawnPickup(short id, sbyte tags, short type, bool child)
    {
        using (Packet packet = new Packet(25))
        {
            packet.Write(id);
            packet.Write(tags);
            packet.Write(type);
            packet.Write(child);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void ObjectDestroyed(int id)
    {
        using (Packet packet = new Packet(26))
        {
            packet.Write(id);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void RandomNumber(uint number1, uint number2)
    {
        using (Packet packet = new Packet(27))
        {
            packet.Write(number1);
            packet.Write(number2);
            await SendUDPData(packet, 0L);
        }
    }

    public static async void SpawnAI(short id, byte vehicle, uint flags)
    {
        using (Packet packet = new Packet(28))
        {
            packet.Write(id);
            packet.Write(vehicle);
            packet.Write(flags);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void TransformAI(short id, VigTransform vTransform)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void PhysicsAI(short id, Matrix2x4 m1, Matrix2x4 m2)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void ControlAI(Vehicle player)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void StatusAI(Vehicle player)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void PickupAI(short id, int type, ushort ammo = 0, sbyte tags = 0)
    {
        using (Packet packet = new Packet(33))
        {
            packet.Write(id);
            packet.Write(type);
            packet.Write(ammo);
            packet.Write(tags);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void WeaponAI(short id, sbyte type)
    {
        using (Packet packet = new Packet(34))
        {
            packet.Write(id);
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void ComboAI(short id, ushort input, sbyte type)
    {
        using (Packet packet = new Packet(35))
        {
            packet.Write(id);
            packet.Write(input);
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void TrailerTransformAI(short id, VigTransform vTransform)
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
            await SendUDPData(packet, 0L);
        }
    }

    public static async void TrailerDetachAI(short id)
    {
        using (Packet packet = new Packet(37))
        {
            packet.Write(id);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void DestroyedAI(short id)
    {
        using (Packet packet = new Packet(38))
        {
            packet.Write(id);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void WreckedAI(short id)
    {
        using (Packet packet = new Packet(39))
        {
            packet.Write(id);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void TotaledAI(short id)
    {
        using (Packet packet = new Packet(40))
        {
            packet.Write(id);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void DropWeaponAI(short id, sbyte type)
    {
        using (Packet packet = new Packet(41))
        {
            packet.Write(id);
            packet.Write(type);
            await SendTCPData(packet, 0L);
        }
    }

    public static async void Pause()
    {
        using (Packet packet = new Packet(42))
        {
            await SendTCPData(packet, 0L);
        }
    }

    //Espera al Host
    public async Task waitLoad()
    {
        using (Packet packet = new Packet(45))
        {
            await SendTCPData(packet, 0L);
        }
    }

}