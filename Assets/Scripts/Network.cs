using Lidgren.Network;
using System.Collections.Generic;
using UnityEngine;

namespace V2UnityDiscordIntercept
{
    public abstract class Network
    {
        public abstract NetPeer Peer { get; }

        protected delegate void PacketHandler(Packet _packet, long userId);

        protected IDictionary<int, PacketHandler> packetHandlers = new Dictionary<int, PacketHandler>();

        public void Update()
        {
            if (Peer == null)
            {
                //Debug.LogWarning("Network Peer Update..." + Peer);

                return;
            }
            //Debug.Log("Network Peer Update..." + Peer);
            ReadMessages();
        }

        public void LateUpdate()
        {
            if (Peer == null)
                return;

            Peer.FlushSendQueue();
        }

        public abstract void ReadMessages();

        public void SendTCPData(Packet _packet, long userId)
        {
            Debug.Log("SendTCPData..." + _packet + " - " + userId);
            _packet.WriteLength();
            if (userId == 0L)
            {
                DiscordController.SendNetworkMessage(0, _packet.ToArray());
                return;
            }
            DiscordController.SendNetworkMessageToUser(userId, 0, _packet.ToArray());
        }

        public void SendUDPData(Packet _packet, long userId)
        {
            Debug.Log("SendUDPData..." + _packet + " - " + userId);
            _packet.WriteLength();
            if (userId == 0L)
            {
                DiscordController.SendNetworkMessage(1, _packet.ToArray());
                return;
            }
            DiscordController.SendNetworkMessageToUser(userId, 1, _packet.ToArray());
        }

        public static NetDeliveryMethod GetDeliveryMethod(int channelId)
        {
            return channelId == 0 ? NetDeliveryMethod.ReliableOrdered : NetDeliveryMethod.UnreliableSequenced;
        }
    }
}