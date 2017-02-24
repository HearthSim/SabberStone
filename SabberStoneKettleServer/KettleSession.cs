using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Kettle;
using Newtonsoft.Json.Linq;

namespace SabberStoneKettleServer
{
    class KettleSession
    {
        private Socket Client;
        private KettleAdapter Adapter;
        private Game _game;

        public KettleSession(Socket client)
        {
            Client = client;
            Adapter = new KettleAdapter(new NetworkStream(client));
            Adapter.OnCreateGame += OnCreateGame;
            Adapter.OnConcede += OnConcede;
            Adapter.OnChooseEntities += OnChooseEntities;
            Adapter.OnSendOption += OnSendOption;
        }

        public void Enter()
        {
            while (true)
            {
                Console.WriteLine("Handling next packet..");
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
                Console.WriteLine("Done!");
            }
        }

        public void OnConcede(int entityid)
        {
            Console.WriteLine($"player[{entityid}] concedes");
            var concedingPlayer = _game.ControllerById(entityid);
            _game.Process(ConcedeTask.Any(concedingPlayer));
            SendPowerHistory(_game.PowerHistory.Last);
        }

        public void OnSendOption(KettleSendOption sendOption)
        {
            Console.WriteLine("simulator OnSendOption called");
            // TODO play the selected option
            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        public void OnChooseEntities(List<int> chooseEntities)
        {
            Console.WriteLine("simulator OnChooiseEntities called");
            // TODO choose the selected entities
            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        public void OnCreateGame(KettleCreateGame createGame)
        {
            Console.WriteLine("creating game");
            _game = new Game(new GameConfig
                    {
                        StartPlayer = 1,
                        Player1HeroClass = CardClass.PRIEST,
                        Player2HeroClass = CardClass.HUNTER,
                        SkipMulligan = false,
                        FillDecks = true
                    });

            // Start the game and send the following powerhistory to the client
            _game.StartGame();

            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        private void SendChoicesOrOptions()
        {
            // getting choices mulligan choices for players ...
            var entityChoicesPlayer1 = PowerChoicesBuilder.EntityChoices(_game.Player1.Choice);
            var entityChoicesPlayer2 = PowerChoicesBuilder.EntityChoices(_game.Player2.Choice);

            // getting options for currentPlayer ...
            var options = PowerOptionsBuilder.AllOptions(_game.CurrentPlayer.Options());

            if (entityChoicesPlayer1 != null)
                SendEntityChoices(entityChoicesPlayer1);

            if (entityChoicesPlayer2 != null)
                SendEntityChoices(entityChoicesPlayer2);

            if (options != null)
                SendOptions(options);
        }

        private void SendEntityChoices(PowerEntityChoices choices)
        {
            Adapter.SendMessage(new KettleEntityChoices(choices));
        }

        private void SendOptions(PowerAllOptions options)
        {
            Adapter.SendMessage(new KettleOptionsBlock(options, _game.CurrentPlayer.PlayerId));
        }

        private void SendPowerHistory(List<IPowerHistoryEntry> history)
        {
            List<KettlePayload> message = new List<KettlePayload>();
            foreach (var entry in history)
            {
                message.Add(KettleHistoryEntry.From(entry));
            }
            Adapter.SendMessage(message);
        }
    }
}
