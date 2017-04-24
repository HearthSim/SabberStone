using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneKettle;

namespace SabberStoneKettleSimulator
{
    class KettleSession
    {
        public Game Game;
        private Socket Client;
        private KettleAdapter Adapter;
        private List<Thread> AiThreads;

        public KettleSession(Socket client)
        {
            Client = client;
            AiThreads = new List<Thread>();
            Adapter = new KettleAdapter(new NetworkStream(client));
            Adapter.OnCreateGame += OnCreateGame;
            Adapter.OnConcede += OnConcede;
            Adapter.OnChooseEntities += OnChooseEntities;
            Adapter.OnSendOption += OnSendOption;
            Adapter.OnStartClient += OnStartClient;
        }

        public void Enter()
        {
            while (true)
            {
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
            }
        }

        public void OnStartClient(KettleStartClient startClient)
        {
            var session = new KettleAISession(this, startClient);
            var thread = new Thread(session.Enter);
            AiThreads.Add(thread);
            thread.Start();
        }

        public void OnConcede(int entityid)
        {
            Console.WriteLine($"player[{entityid}] concedes");
            var concedingPlayer = Game.ControllerById(entityid);
            Game.Process(ConcedeTask.Any(concedingPlayer));
            SendPowerHistory(Game.PowerHistory.Last);
        }

        public void OnSendOption(KettleSendOption sendOption)
        {
            Console.WriteLine("simulator OnSendOption called");

            var sendOptionId = sendOption.Id;
            var sendOptionMainOption = sendOption.MainOption;
            var sendOptionPosition = sendOption.Position-1;
            var sendOptionSubOption = sendOption.SubOption;
            var sendOptionTarget = sendOption.Target;

            Console.WriteLine($"Id={sendOption.Id} MainOption={sendOption.MainOption} Position={sendOption.Position} SubOption={sendOption.SubOption} Target={sendOption.Target}");
            PlayerTask task = SabberStoneKettleSimulator.Util.KettleOptionToPlayerTask(Game, sendOptionId, sendOptionMainOption, sendOptionTarget, sendOptionPosition, sendOptionSubOption);

            Game.Process(task);
            ShowLog(Game, LogLevel.VERBOSE);

            SendPowerHistory(Game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        public void OnChooseEntities(KettleChooseEntities chooseEntities)
        {
            Console.WriteLine("simulator OnChooseEntities called");

            var entityChoices = Game.EntityChoicesMap[chooseEntities.Id];
            var chooseTask = entityChoices.ChoiceType == ChoiceType.MULLIGAN
                ? ChooseTask.Mulligan(entityChoices.PlayerId == 1 ? Game.Player1 : Game.Player2, chooseEntities.Choices)
                : ChooseTask.Pick(entityChoices.PlayerId == 1 ? Game.Player1 : Game.Player2, chooseEntities.Choices[0]);

            Console.WriteLine($"processing => {chooseTask.FullPrint()}");

            Adapter.SendMessage(new KettleEntitiesChosen
            {
                ChoiceType = (int)entityChoices.ChoiceType,
                PlayerId = entityChoices.PlayerId,
                ChooseEntities = chooseEntities,
            });

            Game.Process(chooseTask);
            ShowLog(Game, LogLevel.VERBOSE);

            SendPowerHistory(Game.PowerHistory.Last);
            SendChoicesOrOptions();

            if (Game.Step == Step.BEGIN_MULLIGAN
                && Game.Player1.MulliganState == Mulligan.DONE
                && Game.Player2.MulliganState == Mulligan.DONE)
            {
                Game.MainBegin();

                while (Game.Step != Step.MAIN_ACTION)
                    Thread.Sleep(500);

                ShowLog(Game, LogLevel.VERBOSE);

                SendPowerHistory(Game.PowerHistory.Last);
                SendChoicesOrOptions();
            }

        }

        public void OnCreateGame(KettleCreateGame createGame)
        {
            var player1 = createGame.Players[0];
            var player2 = createGame.Players[1];
            var hero1 = player1.Hero;
            var hero2 = player2.Hero;
            var hero1Class = Cards.FromId(hero1).Class;
            var hero2Class = Cards.FromId(hero2).Class;
            var player1Deck = player1.Cards.Select(Cards.FromId).ToList();
            var player2Deck = player2.Cards.Select(Cards.FromId).ToList();

            Console.WriteLine("creating game");
            Game = new Game(new GameConfig
            {
                Player1HeroClass = hero1Class,
                DeckPlayer1 = player1Deck,
                Player2HeroClass = hero2Class,
                DeckPlayer2 = player2Deck,
                SkipMulligan = false,
                StartPlayer = 1,
            });

            // Start the game and send the following powerhistory to the client
            Game.StartGame();
            ShowLog(Game, LogLevel.VERBOSE);

            SendPowerHistory(Game.PowerHistory.Last);
            SendChoicesOrOptions();
        }

        private void SendChoicesOrOptions()
        {
            // getting choices mulligan choices for players ...
            var entityChoicesPlayer1 = PowerChoicesBuilder.EntityChoices(Game, Game.Player1.Choice);
            var entityChoicesPlayer2 = PowerChoicesBuilder.EntityChoices(Game, Game.Player2.Choice);

            // getting options for currentPlayer ...
            var options = PowerOptionsBuilder.AllOptions(Game, Game.CurrentPlayer.Options());

            if (entityChoicesPlayer1 != null)
                SendEntityChoices(entityChoicesPlayer1);

            if (entityChoicesPlayer2 != null)
                SendEntityChoices(entityChoicesPlayer2);

            if (options != null)
                SendOptions(options);
        }

        private void SendEntityChoices(PowerEntityChoices choices)
        {
            Console.WriteLine($"SendEntityChoices => {choices.Print()}");
            Adapter.SendMessage(new KettleEntityChoices(choices));
        }

        private void SendOptions(PowerAllOptions options)
        {
            Console.WriteLine($"SendOptions => {options.Print()}");
            Adapter.SendMessage(new KettleOptionsBlock(options, Game.CurrentPlayer.PlayerId));
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

        private static void ShowLog(Game game, LogLevel level)
        {
            while (game.Logs.Count > 0)
            {
                var logEntry = game.Logs.Dequeue();
                if (logEntry.Level <= level)
                {
                    var foreground = ConsoleColor.White;
                    switch (logEntry.Level)
                    {
                        case LogLevel.DUMP:
                            foreground = ConsoleColor.DarkCyan;
                            break;
                        case LogLevel.ERROR:
                            foreground = ConsoleColor.Red;
                            break;
                        case LogLevel.WARNING:
                            foreground = ConsoleColor.DarkRed;
                            break;
                        case LogLevel.INFO:
                            foreground = logEntry.Location.Equals("Game") ?
                                ConsoleColor.Yellow :
                                ConsoleColor.Green;
                            break;
                        case LogLevel.VERBOSE:
                            foreground = ConsoleColor.DarkGreen;
                            break;
                        case LogLevel.DEBUG:
                            foreground = ConsoleColor.DarkGray;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    Console.ForegroundColor = foreground;

                    Console.WriteLine(
                        $"{logEntry.TimeStamp} - {logEntry.Level} [{logEntry.BlockType}] - {logEntry.Location}: {logEntry.Text}");
                }
            }
            Console.ResetColor();
        }
    }
}
