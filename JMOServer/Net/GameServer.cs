using JMOServer.Util;
using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JMOServer.Net
{
    /// <summary>
    /// Reprensents the game server
    /// </summary>
    public class GameServer : INetEventListener
    {
        private NetManager netManager = null;
        private NetPacketProcessor packetProcessor = null;

        private readonly NetDataWriter netWriter = new NetDataWriter();

        private bool running = false;

        public GameServer()
        {
            packetProcessor = new NetPacketProcessor();
            netManager = new NetManager(this)
            {
                AutoRecycle = true
            };
            running = InitiateServer();

            while (running)
            {
                netManager.PollEvents();
                Thread.Sleep(Settings.SERVER_CYCLE_TIME);
            }
            netManager.Stop();
        }

        public bool InitiateServer()
        {
            if (netManager.IsRunning)
            {
                Logger.Log(typeof(GameServer), "Was unable to start the server because it is already running");
                return false;
            }
            netManager.Start(Settings.PORT);
            return true;
        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            if (netManager.PeersCount < Settings.MAX_USERS)
                request.AcceptIfKey(Settings.CONNECTION_KEY);
            else
                request.Reject();
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            throw new NotImplementedException();
        }

        public void OnPeerConnected(NetPeer peer)
        {
            Logger.Log(typeof(GameServer), $"A peer {peer.EndPoint} has connected");
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            throw new NotImplementedException();
        }
    }
}
