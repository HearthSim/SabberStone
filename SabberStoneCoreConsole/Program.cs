using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Enums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start Test!");
        CardsTest();
        Console.ReadKey();
    }


    public static void CardsTest()
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

        Console.WriteLine(game.Logs.Count);
        game.Logs.ForEach(p => Console.WriteLine($"{p.TimeStamp} - {p.Level} [{p.BlockType}] - {p.Location}: {p.Text}"));
    }
}