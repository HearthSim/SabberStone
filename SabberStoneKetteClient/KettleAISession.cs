using SabberStoneCore.Model;
using SabberStoneKettle;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SabberStoneKettleClient
{
    class KettleAISession
    {
        private KettleStartClient StartClient;
        private KettleAdapter Adapter;
        private Game _game;

        public KettleAISession(KettleStartClient StartClient)
        {
            this.StartClient = StartClient;
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

        public void OnGameJoined(KettleGameJoined GameJoined)
        {
            Console.WriteLine("AI OnGameJoined called.");
        }

        public void OnEntityChoices(KettleEntityChoices EntityChoices)
        {
            Console.WriteLine("AI EntityChoices called.");
        }

        public void OnEntitiesChosen(KettleEntitiesChosen EntitiesChosen)
        {
            Console.WriteLine("AI OnEntitiesChosen called.");
        }

        public void OnOptionsBlock(KettleOptionsBlock OptionsBlock)
        {
            Console.WriteLine("AI OnOptionsBlock called.");
        }

        public void OnUserUI(KettleUserUI UserUI)
        {
            Console.WriteLine("AI OnUserUI called.");
        }

        public void OnHistory(List<KettleHistoryEntry> History)
        {
            Console.WriteLine("AI OnHistory called.");
        }
    }
}
