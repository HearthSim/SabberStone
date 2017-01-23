using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCoreGui.Meta;
using SabberStoneCoreGui.Nodes;
using SabberStoneCoreGui.Score;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SabberStoneCoreGui
{
    internal class Program
    {
        private static readonly Random Rnd = new Random();

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting test setup.");

            //OneTurn();
            FullGame();

            Console.WriteLine("Test end!");
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
                Console.WriteLine($"* Calculating solutions *** Player 1 ***");

                var solutions = OptionNode.GetSolutions(game, game.Player1.Id, new AggroScore(), 10, 500);

                var solution = new List<PlayerTask>();
                solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                Console.WriteLine($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");

                foreach (var task in solution)
                {
                    Console.WriteLine(task.FullPrint());
                    game.Process(task);
                    if (game.CurrentPlayer.Choice != null)
                        break;
                }
            }

            Console.WriteLine(game.Player1.Hand.FullPrint());
            Console.WriteLine(game.Player1.Board.FullPrint());
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
                Console.WriteLine("");
                Console.WriteLine($"Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState} - " +
                         $"ROUND {(game.Turn + 1) / 2} - {game.CurrentPlayer.Name}");
                Console.WriteLine($"Hero[P1]: {game.Player1.Hero.Health} / Hero[P2]: {game.Player2.Hero.Health}");
                Console.WriteLine("");
                while (game.State == State.RUNNING && game.CurrentPlayer == game.Player1)
                {
                    Console.WriteLine($"* Calculating solutions *** Player 1 ***");
                    var solutions = OptionNode.GetSolutions(game, game.Player1.Id, new AggroScore(), 10, 500);
                    var solution = new List<PlayerTask>();
                    solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                    Console.WriteLine($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");
                    foreach (var task in solution)
                    {
                        Console.WriteLine(task.FullPrint());
                        game.Process(task);
                        if (game.CurrentPlayer.Choice != null)
                        {
                            Console.WriteLine($"* Recaclulating due to a final solution ...");
                            break;
                        }
                    }
                }

                // Random mode for Player 2
                Console.WriteLine($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
                while (game.State == State.RUNNING && game.CurrentPlayer == game.Player2)
                {
                    //var options = game.Options(game.CurrentPlayer);
                    //var option = options[Rnd.Next(options.Count)];
                    //Log.Info($"[{option.FullPrint()}]");
                    //game.Process(option);
                    Console.WriteLine($"* Calculating solutions *** Player 2 ***");
                    var solutions = OptionNode.GetSolutions(game, game.Player2.Id, new MidRangeScore(), 10, 500);
                    var solution = new List<PlayerTask>();
                    solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
                    Console.WriteLine($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
                    foreach (var task in solution)
                    {
                        Console.WriteLine(task.FullPrint());
                        game.Process(task);
                        if (game.CurrentPlayer.Choice != null)
                        {
                            Console.WriteLine($"* Recaclulating due to a final solution ...");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"Game: {game.State}, Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState}");
        }
    }
}