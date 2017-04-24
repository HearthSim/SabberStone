using System;
using System.Collections.Generic;
using System.Net.Sockets;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneKettle;

namespace SabberStoneKettleSimulator
{
    class KettleAISession
    {
        private KettleStartClient StartClient;
        private KettleAdapter Adapter;
        private int PlayerId;
        private KettleSession Session;

        private static readonly Random Rand = new Random();

        public KettleAISession(KettleSession session, KettleStartClient startClient)
        {
            this.StartClient = startClient;
            this.Session = session;
        }

        public void Enter()
        {
            // first we connect to the gameserver
            var socket = new Socket(SocketType.Stream, ProtocolType.IP);
            socket.Connect(StartClient.IP, StartClient.Port);
            Adapter = new KettleAdapter(new NetworkStream(socket));
            Adapter.OnGameJoined += OnGameJoined;
            Adapter.OnEntityChoices += OnEntityChoices;
            Adapter.OnEntitiesChosen += OnEntitiesChosen;
            Adapter.OnOptionsBlock += OnOptionsBlock;
            Adapter.OnUserUI += OnUserUI;
            Adapter.OnHistory += OnHistory;

            Adapter.SendMessage(StartClient.JoinGame);

            // and then we keep listening on the socket
            while (true)
            {
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
            }
        }

        public void OnGameJoined(KettleGameJoined gameJoined)
        {
            Console.WriteLine("AI OnGameJoined called.");
        }

        public void OnEntityChoices(KettleEntityChoices entityChoices)
        {
            Console.WriteLine("AI EntityChoices called.");
        }

        public void OnEntitiesChosen(KettleEntitiesChosen entitiesChosen)
        {
            Console.WriteLine("AI OnEntitiesChosen called.");
        }

        public void OnOptionsBlock(KettleOptionsBlock optionsBlock)
        {
            Console.WriteLine("AI OnOptionsBlock called.");
        }

        public void OnUserUI(KettleUserUI userUi)
        {
            Console.WriteLine("AI OnUserUI called.");
        }

        public void OnHistory(List<KettleHistoryEntry> history)
        {
            Console.WriteLine("AI OnHistory called.");
        }
    }
}
