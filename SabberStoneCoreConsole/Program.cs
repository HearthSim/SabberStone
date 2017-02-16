using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
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
            //CardsTest();
            //WhileCardTest();
            //CloneStampTest();
            //OptionsTest();
            //GameMulliganTest();
            //GameSplitTest();
            //Console.WriteLine(Cards.Statistics());
            //KabalCourierDiscover();
            PowerHistoryTest();

            Console.WriteLine("Finished! Press key now.");
            Console.ReadKey();
        }

        private static void PowerHistoryTest()
        {
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = true
                });
            game.StartGame();
            ShowLog(game, LogLevel.VERBOSE);
            Console.WriteLine("*** - PowerHistory - ****");
            Console.WriteLine(game.PowerHistory.Print());
        }

        public static void GameSplitTest()
        {
            Game game = null;
            bool goOnFlag = true;
            while (goOnFlag)
            {
                game =
                    new Game(new GameConfig
                    {
                        StartPlayer = 1,
                        Player1HeroClass = CardClass.PRIEST,
                        DeckPlayer1 = new List<Card>()
                        {
                            Cards.FromName("Loot Hoarder"),       // 1
                            Cards.FromName("Loot Hoarder"),       // 2
                            Cards.FromName("Huge Toad"),          // 3
                            Cards.FromName("Mad Bomber"),         // 4
                            Cards.FromName("Stonetusk Boar"),     // 5
                            Cards.FromName("Magma Rager"),        // 6
                            Cards.FromName("War Golem"),          // 7
                            Cards.FromName("Reckless Rocketeer"), // 8
                            Cards.FromName("Wolfrider"),          // 9
                            Cards.FromName("Sen'jin Shieldmasta"),// 10
                            Cards.FromName("Voodoo Doctor"),      // 11
                            Cards.FromName("River Crocolisk"),    // 12
                            Cards.FromName("Oasis Snapjaw"),      // 13
                            Cards.FromName("Novice Engineer"),    // 14
                            Cards.FromName("Core Hound"),         // 15
                            Cards.FromName("Booty Bay Bodyguard"),// 16
                            Cards.FromName("Ogre Magi"),          // 17
                            Cards.FromName("Chillwind Yeti"),     // 18
                            Cards.FromName("Acidic Swamp Ooze"),  // 19
                            Cards.FromName("Ironfur Grizzly"),    // 20
                            Cards.FromName("Bluegill Warrior"),   // 21
                            Cards.FromName("Murloc Tidehunter"),  // 22
                            Cards.FromName("Frostwolf Grunt"),    // 23
                            Cards.FromName("Ironforge Rifleman"), // 24
                            Cards.FromName("Kobold Geomancer"),   // 25
                            Cards.FromName("Razorfen Hunter"),    // 26
                            Cards.FromName("Gnomish Inventor"),   // 27
                            Cards.FromName("Stormwind Knight"),   // 28
                            Cards.FromName("Gurubashi Berserker"),// 29
                            Cards.FromName("Elven Archer"),       // 30
                        },
                        Player2HeroClass = CardClass.HUNTER,
                        DeckPlayer2 = new List<Card>()
                        {
                            Cards.FromName("Loot Hoarder"),       // 1
                            Cards.FromName("Loot Hoarder"),       // 2
                            Cards.FromName("Huge Toad"),          // 3
                            Cards.FromName("Mad Bomber"),         // 4
                            Cards.FromName("Stonetusk Boar"),     // 5
                            Cards.FromName("Magma Rager"),        // 6
                            Cards.FromName("War Golem"),          // 7
                            Cards.FromName("Reckless Rocketeer"), // 8
                            Cards.FromName("Wolfrider"),          // 9
                            Cards.FromName("Sen'jin Shieldmasta"),// 10
                            Cards.FromName("Voodoo Doctor"),      // 11
                            Cards.FromName("River Crocolisk"),    // 12
                            Cards.FromName("Oasis Snapjaw"),      // 13
                            Cards.FromName("Novice Engineer"),    // 14
                            Cards.FromName("Core Hound"),         // 15
                            Cards.FromName("Booty Bay Bodyguard"),// 16
                            Cards.FromName("Ogre Magi"),          // 17
                            Cards.FromName("Chillwind Yeti"),     // 18
                            Cards.FromName("Acidic Swamp Ooze"),  // 19
                            Cards.FromName("Ironfur Grizzly"),    // 20
                            Cards.FromName("Bluegill Warrior"),   // 21
                            Cards.FromName("Murloc Tidehunter"),  // 22
                            Cards.FromName("Frostwolf Grunt"),    // 23
                            Cards.FromName("Ironforge Rifleman"), // 24
                            Cards.FromName("Kobold Geomancer"),   // 25
                            Cards.FromName("Razorfen Hunter"),    // 26
                            Cards.FromName("Gnomish Inventor"),   // 27
                            Cards.FromName("Stormwind Knight"),   // 28
                            Cards.FromName("Gurubashi Berserker"),// 29
                            Cards.FromName("Elven Archer"),       // 30
                        },
                        FillDecks = false,
                        Shuffle = false,
                        Splitting = true
                    });
                game.StartGame();
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4])); // Coin
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[0])); // Loot Hoarder
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[0])); // Loot Hoarder
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[1])); // Huge Toad
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[0])); // Loot Hoarder
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[1])); // Mad Bomber
                //game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.Hand[2]));

                goOnFlag = false;
            }

            ShowLog(game, LogLevel.VERBOSE);
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

        public static void KabalCourierDiscover()
        {

            var cardSet = Cards.Standard;

            var mageCards =
                cardSet[CardClass.MAGE].Where(p => p.Class == CardClass.MAGE || p.MultiClassGroup != 0).ToList();
            var priestCards =
                cardSet[CardClass.PRIEST].Where(p => p.Class == CardClass.PRIEST || p.MultiClassGroup != 0).ToList();
            var warlockCards =
                cardSet[CardClass.WARLOCK].Where(p => p.Class == CardClass.WARLOCK || p.MultiClassGroup != 0).ToList();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<List<Card>> cardSets = new List<List<Card>>();
            foreach (Card mageCard in mageCards)
            {
                foreach (Card priestCard in priestCards)
                {
                    foreach (Card warlockCard in warlockCards)
                    {
                        cardSets.Add(new List<Card> { mageCard , priestCard, warlockCard});
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("cardSets: {0}", cardSets.Count);
        }

        public static void WhileCardTest()
        {
            bool flag = true;
            Game game = null;
            while (flag)
            {
                game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dirty Rat"));
                var hasMinion = game.CurrentOpponent.Hand.GetAll.Any(p => p is Minion);
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            
                flag = hasMinion ? 1 == game.CurrentOpponent.Board.Count : 0 == game.CurrentOpponent.Board.Count;
            }

            ShowLog(game, LogLevel.VERBOSE);
            Console.WriteLine(game.CurrentOpponent.Hand.FullPrint());
            Console.WriteLine(game.CurrentOpponent.Board.FullPrint());
        }

        public static void CardsTest()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARRIOR,
                Player2HeroClass = CardClass.WARRIOR,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorehowl"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorehowl"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));

            ShowLog(game, LogLevel.VERBOSE);
            Console.WriteLine(game.CurrentPlayer.Board.FullPrint());
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

            const int total = 127000;
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
                Console.Clear();
                ProgressBar(i, total);
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = Cards.BasicHeroes[i % 9],
                    Player2HeroClass = Cards.BasicHeroes[(i + 1) % 9],
                    FillDecks = true,
                    Logging = false
                });
                game.StartGame();

                Console.WriteLine($"{(i > 0 ? turns / i : 0)} AVG. Turns ... " + 
                game.Player1.HeroClass + " vs. " + game.Player2.HeroClass);
  
                while (game.State != State.COMPLETE)
                {
                    var options = game.CurrentPlayer.Options();
                    var option = options[Rnd.Next(options.Count)];
                    //Console.WriteLine(option.FullPrint());
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

        private static void ProgressBar(int progress, int tot)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / tot;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + tot.ToString() + "    "); //blanks at the end remove any excess
        }
    }
}