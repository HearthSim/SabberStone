using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreConsole
{
    internal class Program
    {
        private static readonly Random Rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Start Test!");

            //BasicBuffTest();
            CardsTest();
            //CloneStampTest();
            //OptionsTest();
            //GameMulliganTest();
            //Console.WriteLine(Cards.Statistics());

            Console.WriteLine("Finished! Press key now.");
            Console.ReadKey();
        }

        public static void GameMulliganTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = true,
                    SkipMulligan = false
                });
            game.StartGame();

            game.Process(ChooseTask.Mulligan(game.Player1, 
                game.Player1.Choice.Choices.Where(p => p.Cost > 3).ToList()));

            game.Process(ChooseTask.Mulligan(game.Player2,
                game.Player2.Choice.Choices.Where(p => p.Cost > 3).ToList()));

            game.MainBegin();

            ShowLog(game, LogLevel.VERBOSE);

            Console.WriteLine(game.Player1.Choice?.FullPrint());
            Console.WriteLine(game.Player2.Choice?.FullPrint());
        }

        public static void BasicBuffTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = true
                });

            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            game.StartGame();

            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion));

            ShowLog(game, LogLevel.VERBOSE);
        }

        public static void CardsTest()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

            game.CurrentPlayer.UsedMana = 0;

            var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gormok the Impaler"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));

            game.CurrentPlayer.UsedMana = 0;

            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gormok the Impaler"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));

            ShowLog(game, LogLevel.VERBOSE);
            Console.WriteLine(game.CurrentPlayer.Hand.FullPrint());
        }

        public static void Kazakus()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.DRUID,
                DeckPlayer1 = new List<Card>() { },
                Player2HeroClass = CardClass.DRUID,
                DeckPlayer2 = new List<Card>() { },
                FillDecks = false
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kazakus"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));

            ShowLog(game, LogLevel.VERBOSE);
        }

        public static void CloneSameSame()
        {
            var classes = new[]
            {
                CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
                CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
            };
            var flag = true;
            for (var i = 0; i < 10 && flag; i++)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = classes[Rnd.Next(classes.Length)],
                    Player2HeroClass = classes[Rnd.Next(classes.Length)],
                    FillDecks = true
                });
                game.StartGame();

                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    game.Process(option);
                    var cloneGame = game.Clone();
                    var str1 = game.Hash();
                    var str2 = cloneGame.Hash();
                    flag &= str1.Equals(str2);
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Same whole game? {flag}");

        }

        public static void CloneStampTest()
        {
            var turns = 25;

            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.HUNTER,
                FillDecks = true,
                Logging = false
            });
            game.StartGame();

            for (var i = 0; i < turns; i++)
            {
                var options = game.CurrentPlayer.Options();
                var option = options[Rnd.Next(options.Count)];
                game.Process(option);
            }

            Console.WriteLine($"GameState: {game.State}");

            Console.WriteLine($"{game.FullPrint()}");

            const int total = 10000;
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < total; i++)
            {
                var cloneGame = game.Clone();
            }
            watch.Stop();

            Console.WriteLine($"{total} games cloned took {watch.ElapsedMilliseconds} ms => " +
                              $"Avg. {watch.ElapsedMilliseconds / total} per clone!");
        }

        public static void OptionsTest()
        {
            const int total = 1000;
            var watch = Stopwatch.StartNew();

            var turns = 0;
            var wins = new[] { 0, 0 };
            for (var i = 0; i < total; i++)
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = true,
                    Logging = false
                });
                game.StartGame();

                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    game.Process(option);
                }
                turns += game.Turn;
                if (game.Player1.PlayState == PlayState.WON)
                    wins[0]++;
                if (game.Player2.PlayState == PlayState.WON)
                    wins[1]++;

            }
            watch.Stop();

            Console.WriteLine($"{total} games with {turns} turns took {watch.ElapsedMilliseconds} ms => " +
                              $"Avg. {watch.ElapsedMilliseconds / total} per game " +
                              $"and {watch.ElapsedMilliseconds / (total * turns)} per turn!");
            Console.WriteLine($"playerA {wins[0] * 100 / total}% vs. playerB {wins[1] * 100 / total}%!");
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