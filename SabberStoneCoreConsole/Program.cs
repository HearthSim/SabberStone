using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Enums;
using System.Diagnostics;

class Program
{
    private static Random Rnd = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Start Test!");

        //BasicBuffTest();
        //CardsTest();
        //CloneStampTest();
        //OptionsTest();

        Console.WriteLine(Cards.Statistics());

        Console.WriteLine("Finished! Press key now.");
        Console.ReadKey();
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
        var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
        game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));

        game.Log(LogLevel.ERROR, BlockType.SCRIPT, "28 = game.CurrentOpponent.Hero.Health", game.CurrentOpponent.Hero.Health.ToString());
        game.Log(LogLevel.ERROR, BlockType.SCRIPT, "8 = ((Minion)game.CurrentPlayer.Setaside[0]).Health", ((Minion)game.CurrentPlayer.Setaside[0]).Health.ToString());
        game.Log(LogLevel.ERROR, BlockType.SCRIPT, "8 = ((Minion)game.CurrentPlayer.Setaside[0]).AttackDamage", ((Minion)game.CurrentPlayer.Setaside[0]).AttackDamage.ToString());


        game.Player1.UsedMana = 0;
        var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
        game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

        game.Log(LogLevel.ERROR, BlockType.SCRIPT, "20 = game.CurrentOpponent.Hero.Health", game.CurrentOpponent.Hero.Health.ToString());
        game.Log(LogLevel.ERROR, BlockType.SCRIPT, "8 = ((Minion)minion).Health", ((Minion)minion).Health.ToString());


        ShowLog(game, LogLevel.VERBOSE);
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