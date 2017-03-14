using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Kettle;
using Newtonsoft.Json.Linq;
using SabberStoneCore.Tasks;
using SabberStoneKettle;

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
                if (!Adapter.HandleNextPacket())
                {
                    Console.WriteLine("Kettle session ended.");
                    return;
                }
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

            var sendOptionId = sendOption.Id;
            var sendOptionMainOption = sendOption.MainOption;
            var sendOptionPosition = sendOption.Position-1;
            var sendOptionSubOption = sendOption.SubOption;
            var sendOptionTarget = sendOption.Target;

            Console.WriteLine($"Id={sendOption.Id} MainOption={sendOption.MainOption} Position={sendOption.Position} SubOption={sendOption.SubOption} Target={sendOption.Target}");
            var allOptions = _game.AllOptionsMap[sendOptionId];
            Console.WriteLine(allOptions.Print());

            var tasks = allOptions.PlayerTaskList;
            var powerOption = allOptions.PowerOptionList[sendOptionMainOption];
            var optionType = powerOption.OptionType;

            PlayerTask task = null;
            switch (optionType)
            {
                case OptionType.END_TURN:
                    task = EndTurnTask.Any(_game.CurrentPlayer);
                    break;

                case OptionType.POWER:

                    var mainOption = powerOption.MainOption;
                    IPlayable source = _game.IdEntityDic[mainOption.EntityId];
                    IPlayable target = sendOptionTarget > 0 ? _game.IdEntityDic[sendOptionTarget] : null;
                    var subObtions = powerOption.SubOptions;

                    if (source.Zone?.Type == Zone.PLAY)
                    {
                        task = MinionAttackTask.Any(_game.CurrentPlayer, source, target);
                    }
                    else
                    {
                        switch (source.Card.Type)
                        {
                            case CardType.HERO:
                                task = HeroAttackTask.Any(_game.CurrentPlayer, target);
                                break;
                            case CardType.HERO_POWER:
                                task = HeroPowerTask.Any(_game.CurrentPlayer, target);
                                break;
                            default:
                                task = PlayCardTask.Any(_game.CurrentPlayer, source, target, sendOptionPosition,
                                    sendOptionSubOption);
                                break;
                        }
                    }
                    break;

                case OptionType.PASS:
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            _game.Process(task);
            ShowLog(_game, LogLevel.VERBOSE);

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
            ShowLog(_game, LogLevel.VERBOSE);

            SendPowerHistory(_game.PowerHistory.Last);
            SendChoicesOrOptions();

            if (_game.Step == Step.BEGIN_MULLIGAN
                && _game.Player1.MulliganState == Mulligan.DONE
                && _game.Player2.MulliganState == Mulligan.DONE)
            {
                _game.MainBegin();

                while (_game.Step != Step.MAIN_ACTION)
                    Thread.Sleep(500);

                ShowLog(_game, LogLevel.VERBOSE);

                SendPowerHistory(_game.PowerHistory.Last);
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
            _game = new Game(new GameConfig
            {
                Player1HeroClass = hero1Class,
                DeckPlayer1 = player1Deck,
                Player2HeroClass = hero2Class,
                DeckPlayer2 = player2Deck,
                SkipMulligan = false
            });

            // Start the game and send the following powerhistory to the client
            _game.StartGame();
            ShowLog(_game, LogLevel.VERBOSE);

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
            Console.WriteLine($"SendEntityChoices => {choices.Print()}");
            Adapter.SendMessage(new KettleEntityChoices(choices));
        }

        private void SendOptions(PowerAllOptions options)
        {
            Console.WriteLine($"SendOptions => {options.Print()}");
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
