using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HearthDb.Enums;
using log4net;
using SabberStone.Config;
using SabberStone.Model;
using SabberStone.Splits;
using SabberStone.Tasks;
using SimpleAi.Meta;
using SimpleAi.Nodes;
using SimpleAi.Score;
using AggroScore = SimpleAi.Score.AggroScore;

namespace SimpleAi
{
    internal class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly Random Rnd = new Random();

        private static void Main(string[] args)
        {
            Log.Info("Starting test setup.");

            //OneTurn();
            FullGame();

            Log.Info("Test end!");
            Console.ReadLine();
        }

        public static void OneTurn()
        {
            var game = new Game(
                new GameConfig()
                {
                    StartPlayer = 1,
                    Player1Name = "FitzVonGerald",
                    Player1HeroClass = CardClass.WARRIOR,
                    DeckPlayer1 = Decks.AggroPirateWarrior,
                    Player2Name = "RehHausZuckFuchs",
                    Player2HeroClass = CardClass.SHAMAN,
                    DeckPlayer2 = Decks.MidrangeJadeShaman,
                    FillDecks = false,
                    Shuffle = false
                });
            game.Player1.BaseMana = 10;
            game.StartGame();

            while (game.CurrentPlayer == game.Player1)
            {
                Log.Info($"* Calculating solutions *** Player 1 ***");
                Util.LogOn(false);
                var solutions = OptionNode.GetSolutions(game, game.Player1.Id, new AggroScore(), 10, 500);
                Util.LogOn(true);
                var solution = new List<PlayerTask>();
                solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                Log.Info($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");

                foreach (var task in solution)
                {
                    Log.Info(task.FullPrint());
                    game.Process(task);
                    if (game.CurrentPlayer.Choice != null)
                        break;
                }
            }

            Log.Info(game.Player1.Hand.FullPrint());
            Log.Info(game.Player1.Board.FullPrint());
        }

        public static void FullGame()
        {
            var game = new Game(
                new GameConfig()
                {
                    StartPlayer = 1,
                    Player1Name = "FitzVonGerald",
                    Player1HeroClass = CardClass.WARRIOR,
                    DeckPlayer1 = Decks.AggroPirateWarrior,
                    Player2Name = "RehHausZuckFuchs",
                    Player2HeroClass = CardClass.SHAMAN,
                    DeckPlayer2 = Decks.MidrangeJadeShaman,
                    FillDecks = false,
                    Shuffle = true
                });
            game.StartGame();
            while (game.State != State.COMPLETE)
            {
                Log.Info("");
                Log.Info($"Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState} - " +
                         $"ROUND {(game.Turn + 1) / 2} - {game.CurrentPlayer.Name}");
                Log.Info($"Hero[P1]: {game.Player1.Hero.Health} / Hero[P2]: {game.Player2.Hero.Health}");
                Log.Info("");
                while (game.State == State.RUNNING && game.CurrentPlayer == game.Player1)
                {
                    Log.Info($"* Calculating solutions *** Player 1 ***");
                    var solutions = OptionNode.GetSolutions(game, game.Player1.Id, new AggroScore(), 10, 500);
                    var solution = new List<PlayerTask>();
                    solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                    Log.Info($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");
                    foreach (var task in solution)
                    {
                        Log.Info(task.FullPrint());
                        game.Process(task);
                        if (game.CurrentPlayer.Choice != null)
                        {
                            Log.Info($"* Recaclulating due to a final solution ...");
                            break;
                        }
                    }
                }

                // Random mode for Player 2
                Log.Info($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
                while (game.State == State.RUNNING && game.CurrentPlayer == game.Player2)
                {
                    //var options = game.Options(game.CurrentPlayer);
                    //var option = options[Rnd.Next(options.Count)];
                    //Log.Info($"[{option.FullPrint()}]");
                    //game.Process(option);
                    Log.Info($"* Calculating solutions *** Player 2 ***");
                    var solutions = OptionNode.GetSolutions(game, game.Player2.Id, new MidRangeScore(), 10, 500);
                    var solution = new List<PlayerTask>();
                    solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                    Log.Info($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
                    foreach (var task in solution)
                    {
                        Log.Info(task.FullPrint());
                        game.Process(task);
                        if (game.CurrentPlayer.Choice != null)
                        {
                            Log.Info($"* Recaclulating due to a final solution ...");
                            break;
                        }
                    }
                }
            }
            Log.Info($"Game: {game.State}, Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState}");
        }
    }
}