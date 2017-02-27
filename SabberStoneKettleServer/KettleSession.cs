using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

            var allOptions = _game.AllOptionsMap[sendOption.Index];



            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        public void OnChooseEntities(KettleChooseEntities chooseEntities)
        {
            Console.WriteLine("simulator OnChooseEntities called");

            var entityChoices = _game.EntityChoicesMap[chooseEntities.ID];
            var chooseTask = entityChoices.ChoiceType == ChoiceType.MULLIGAN
                ? ChooseTask.Mulligan(entityChoices.PlayerId == 1 ? _game.Player1 : _game.Player2, chooseEntities.Choices)
                : ChooseTask.Pick(entityChoices.PlayerId == 1 ? _game.Player1 : _game.Player2, chooseEntities.Choices[0]);

            Console.WriteLine($"processing => {chooseTask.FullPrint()}");

            Adapter.SendMessage(new KettleEntitiesChosen
            {
                ChoiceType = (int)entityChoices.ChoiceType,
                PlayerID = entityChoices.PlayerId,
                ChooseEntities = chooseEntities,
            });

            _game.Process(chooseTask);

            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();

            if (_game.Step == Step.BEGIN_MULLIGAN
                && _game.Player1.MulliganState == Mulligan.DONE
                && _game.Player2.MulliganState == Mulligan.DONE)
            {
                _game.MainBegin();

                while (_game.Step != Step.MAIN_ACTION)
                    Thread.Sleep(500);
                
                SendPowerHistory(_game.PowerHistory.Last);
                SendChoicesOrOptions();
            }

        }

        public void OnCreateGame(KettleCreateGame createGame)
        {
            Console.WriteLine("creating game");
            _game = new Game(new GameConfig
            {
                StartPlayer = 2,
                Player1HeroClass = CardClass.WARRIOR,
                DeckPlayer1 = new List<Card>
                {
                    Cards.FromId("EX1_016"),
                    Cards.FromId("EX1_606"),
                    Cards.FromId("EX1_410"),
                    Cards.FromId("BRM_015"),
                    Cards.FromId("OG_162"),
                    Cards.FromId("LOE_077"),
                },
                Player2HeroClass = CardClass.MAGE,
                DeckPlayer2 = new List<Card>
                {
                    Cards.FromId("NEW1_012"),
                    Cards.FromId("CS2_187"),
                    Cards.FromId("CS2_162"),
                    Cards.FromId("CS2_029"),
                    Cards.FromId("OG_141"),
                    Cards.FromId("EX1_399"),
                },
                SkipMulligan = false,
                Shuffle = false,
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
            var entityChoicesPlayer1 = PowerChoicesBuilder.EntityChoices(_game, _game.Player1.Choice);
            var entityChoicesPlayer2 = PowerChoicesBuilder.EntityChoices(_game, _game.Player2.Choice);

            // getting options for currentPlayer ...
            var options = PowerOptionsBuilder.AllOptions(_game, _game.CurrentPlayer.Options());

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
