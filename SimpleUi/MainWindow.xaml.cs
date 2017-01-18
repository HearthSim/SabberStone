using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using HearthDb.Enums;
using SabberStone.Config;
using SabberStone.Model;
using SabberStone.Splits;
using SabberStone.Tasks;
using SabberStone.Visualizer;
using SimpleAi.Meta;
using SimpleAi.Nodes;
using SimpleAi.Score;
using SimpleUi.AsciiVisual;

namespace SimpleUi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game CurrentGame;

        public List<PlayerTask> CurrentSolution;

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var parameters = e.Argument as List<object>;

            var maxDepth = (int) parameters[0];
            var maxWidth = (int) parameters[1];
            var scoring = (IScore) parameters[2];

            var depthNodes = new Dictionary<string, OptionNode> { ["root"] = new OptionNode(null, CurrentGame, CurrentGame.CurrentPlayer.Id, null, scoring) };
            var endTurnNodes = new List<OptionNode>();
            for (var i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
            {
                var nextDepthNodes = new Dictionary<string, OptionNode>();
                var countNodes = 0;
                var countNodesTot = depthNodes.Values.Count;
                foreach (var option in depthNodes.Values)
                {
                    countNodes++;
                    worker?.ReportProgress(countNodes, countNodesTot);
                    option.Options(ref nextDepthNodes);
                }

                endTurnNodes.AddRange(nextDepthNodes.Values.Where(p => p.IsEndTurn || p.IsWon));

                depthNodes = nextDepthNodes
                    .Where(p => !p.Value.IsEndTurn && p.Value.IsRunning)
                    .OrderByDescending(p => p.Value.Score)
                    .Take(maxWidth)
                    .ToDictionary(p => p.Key, p => p.Value);

                worker?.ReportProgress(i + 1, $"Depth: {i + 1} --> {depthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{endTurnNodes.Count}]");

            }

            //var btween = new List<PlayerTask>();
            //endTurnNodes.OrderByDescending(p => p.Score).First().PlayerTasks(ref btween);
            //btween.ForEach(p => worker?.ReportProgress(0, btween.IndexOf(p) + ") " + p.FullPrint()));

            //for (var i = 0; i < 1; i++)
            //{
            //    endTurnNodes = GetOpTurn($"Op{i}", 10, 100, worker, endTurnNodes);
            //    endTurnNodes = GetOpTurn($"Pl{i}", 10, 100, worker, endTurnNodes);
            //}

            // add results ....
            e.Result = endTurnNodes;
        }

        private List<OptionNode> GetOpTurn(string playerTag, int maxDepth, int maxWidth, BackgroundWorker worker, List<OptionNode> endTurnNodes)
        {

            var opDepthNodes = new Dictionary<string, OptionNode>();
            endTurnNodes.ForEach(p =>
            {
                if (!opDepthNodes.ContainsKey(p.Hash))
                {
                    p.Switch();
                    opDepthNodes.Add(p.Hash, p);

                }
            });

            var opEndTurnNodes = new List<OptionNode>();
            for (var i = 0; opDepthNodes.Count > 0 && i < maxDepth; i++)
            {
                var nextDepthNodes = new Dictionary<string, OptionNode>();
                var countNodes = 0;
                var countNodesTot = opDepthNodes.Values.Count;
                foreach (var option in opDepthNodes.Values)
                {
                    countNodes++;
                    worker?.ReportProgress(countNodes, countNodesTot);
                    option.Options(ref nextDepthNodes);
                }

                opEndTurnNodes.AddRange(nextDepthNodes.Values.Where(p => p.IsEndTurn || p.IsWon));

                opDepthNodes = nextDepthNodes
                    .Where(p => !p.Value.IsEndTurn && p.Value.IsRunning)
                    .OrderByDescending(p => p.Value.Score)
                    .Take(maxWidth)
                    .ToDictionary(p => p.Key, p => p.Value);

                worker?.ReportProgress(i + 1, $"{playerTag}: {i + 1} --> {opDepthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{opEndTurnNodes.Count}]");

            }

            return opEndTurnNodes;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var test = e.ProgressPercentage;

            if (e.UserState is int)
            {
                PgrBarDepth.Value = (double) test * 100 / (int)e.UserState;

            } else if (e.UserState != null)
            {
                TxtPlayer1.AppendText(e.UserState.ToString() + Environment.NewLine);
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var endTurnNodes = (List<OptionNode>) e.Result;
            CurrentSolution = new List<PlayerTask>();
            endTurnNodes.OrderByDescending(p => p.Score).First().PlayerTasks(ref CurrentSolution);
            ShowCurrentSolution();
            BtnStart.IsEnabled = true;
            SlidMaxDepth.IsEnabled = true;
            SlidMaxWidth.IsEnabled = true;
        }

        public MainWindow()
        {
            InitializeComponent();
            CboxDeck1.ItemsSource = Enum.GetValues(typeof(DeckTypes)).Cast<DeckTypes>();
            CboxDeck1.SelectedIndex = 0;
            CboxDeck2.ItemsSource = Enum.GetValues(typeof(DeckTypes)).Cast<DeckTypes>();
            CboxDeck2.SelectedIndex = 2;
            CboxAi1.ItemsSource = Enum.GetValues(typeof(Strategy)).Cast<Strategy>();
            CboxAi1.SelectedIndex = 0;
            CboxAi2.ItemsSource = Enum.GetValues(typeof(Strategy)).Cast<Strategy>();
            CboxAi2.SelectedIndex = 1;

            var help = CardAsciiBuilder.PrintHelp();

            ViewBox.Text =
                help[0] + Environment.NewLine +
                help[1] + Environment.NewLine +
                help[2] + Environment.NewLine +
                help[3] + Environment.NewLine +
                help[4] + Environment.NewLine +
                help[5] + Environment.NewLine +
                Environment.NewLine +
                help[6] + Environment.NewLine +
                help[7] + Environment.NewLine +
                help[8] + Environment.NewLine +
                help[9] + Environment.NewLine +
                help[10] + Environment.NewLine +
                help[11] + Environment.NewLine +
                Environment.NewLine +
                help[12] + Environment.NewLine +
                help[13] + Environment.NewLine +
                help[14] + Environment.NewLine +
                help[15] + Environment.NewLine +
                help[16] + Environment.NewLine +
                help[17] + Environment.NewLine;

        }

        public void Actualize()
        {
            ViewBox.Text = Visualizer.Visualize(CurrentGame);
            TxtPlayLog.Text = CurrentGame.PlayTaskLog.ToString();
            TxtPlayLog.ScrollToEnd();

            if (CurrentGame.State == State.RUNNING && !BtnStart.IsEnabled)
            {
                TxtPlayer1.Text = $"* Calculating solutions *** {CurrentGame.CurrentPlayer} ***" + Environment.NewLine;
                TxtPlayer1.AppendText($"... with depth: {(int)SlidMaxDepth.Value} and width: {(int)SlidMaxWidth.Value} ..." + Environment.NewLine);
                var worker = new BackgroundWorker {WorkerReportsProgress = true};
                worker.DoWork += worker_DoWork;
                worker.ProgressChanged += worker_ProgressChanged;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                var scoring = CurrentGame.CurrentPlayer == CurrentGame.Player1 ? GetScoring((Strategy) CboxAi1.SelectedValue) : GetScoring((Strategy)CboxAi2.SelectedValue);
                worker.RunWorkerAsync(new List<object> {(int)SlidMaxDepth.Value, (int)SlidMaxWidth.Value, scoring});
                BtnStart.Content = $"{CurrentGame.CurrentPlayer} Move!";
            }
            else if (CurrentGame.State == State.COMPLETE)
            {
                TxtPlayer1.Text = ".. Game is finished!" + Environment.NewLine +
                                  $"P1: {CurrentGame.Player1} => {CurrentGame.Player1.PlayState}" + Environment.NewLine +
                                  $"P2: {CurrentGame.Player2} => {CurrentGame.Player2.PlayState}" + Environment.NewLine;
                BtnStart.IsEnabled = true;
                BtnStart.Content = "Finished!" + Environment.NewLine + "..new game?";

                CboxDeck1.IsEnabled = true;
                CboxDeck2.IsEnabled = true;
                CboxAi1.IsEnabled = true;
                CboxAi2.IsEnabled = true;
            }
        }

        private void ShowCurrentSolution()
        {
            TxtPlayer1.Text = $"* Best Moves *** {CurrentGame.CurrentPlayer.Name} ***" + Environment.NewLine;
            CurrentSolution.ForEach(p => TxtPlayer1.AppendText(CurrentSolution.IndexOf(p) + ") " + p.FullPrint() + Environment.NewLine));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentGame?.State == State.RUNNING)
            {
                var curPlayer = CurrentGame.CurrentPlayer;
                var nextTask = CurrentSolution[0];
                CurrentSolution.Remove(nextTask);
                CurrentGame.Process(nextTask);
                ShowCurrentSolution();
                if (CurrentGame.CurrentPlayer != curPlayer || CurrentGame.CurrentPlayer.Choice != null)
                {
                    BtnStart.IsEnabled = false;
                    SlidMaxDepth.IsEnabled = false;
                    SlidMaxWidth.IsEnabled = false;
                }
            }
            else
            {
                TxtPlayer1.Text = "* Starting a new Game .... ***";

                CurrentGame = new Game(CreateGameConfig());
                CurrentGame.StartGame();
                CboxDeck1.IsEnabled = false;
                CboxDeck2.IsEnabled = false;
                CboxAi1.IsEnabled = false;
                CboxAi2.IsEnabled = false;
                BtnStart.IsEnabled = false;
                SlidMaxDepth.IsEnabled = false;
                SlidMaxWidth.IsEnabled = false;
            }

            Actualize();
        }

        private GameConfig CreateGameConfig()
        {
            CardClass heroClass1;
            CardClass heroClass2;
            var deck1 = GetDeck(((DeckTypes) CboxDeck1.SelectedItem), out heroClass1);
            var deck2 = GetDeck(((DeckTypes) CboxDeck2.SelectedItem), out heroClass2);

            return new GameConfig()
            {
                StartPlayer = 1,
                Player1Name = "FitzVonGerald",
                Player1HeroClass = heroClass1,
                DeckPlayer1 = deck1,
                Player2Name = "RehHausZuckFuchs",
                Player2HeroClass = heroClass2,
                DeckPlayer2 = deck2,
                FillDecks = false,
                Shuffle = true
            };
        }

        private IScore GetScoring(Strategy s)
        {
            switch (s)
            {
                case Strategy.Aggro:
                    return new AggroScore();
                case Strategy.Midrange:
                    return new MidRangeScore();
                case Strategy.Control:
                    return new ControlScore();
                case Strategy.Ramp:
                    return new RampScore();
                case Strategy.Fatigue:
                    return new FatigueScore();
                default:
                    throw new ArgumentOutOfRangeException(nameof(s), s, null);
            }
        }

        private List<Card> GetDeck(DeckTypes s, out CardClass heroClass)
        {
            switch (s)
            {
                case DeckTypes.AggroPirateWarrior:
                    heroClass = CardClass.WARRIOR;
                    return Decks.AggroPirateWarrior;
                case DeckTypes.MurlocDruid:
                    heroClass = CardClass.DRUID;
                    return Decks.MurlocDruid;
                case DeckTypes.MidrangeBuffPaladin:
                    heroClass = CardClass.PALADIN;
                    return Decks.MidrangeBuffPaladin;
                case DeckTypes.MidrangeJadeShaman:
                    heroClass = CardClass.SHAMAN;
                    return Decks.MidrangeJadeShaman;
                case DeckTypes.MidrangeSecretHunter:
                    heroClass = CardClass.HUNTER;
                    return Decks.MidrangeSecretHunter;
                case DeckTypes.MiraclePirateRogue:
                    heroClass = CardClass.ROGUE;
                    return Decks.MiraclePirateRogue;
                case DeckTypes.RenoKazakusDragonPriest:
                    heroClass = CardClass.PRIEST;
                    return Decks.RenoKazakusDragonPriest;
                case DeckTypes.RenoKazakusMage:
                    heroClass = CardClass.MAGE;
                    return Decks.RenoKazakusMage;
                case DeckTypes.ZooDiscardWarlock:
                    heroClass = CardClass.WARLOCK;
                    return Decks.ZooDiscardWarlock;
                default:
                    LblInfo.Content = s + " not implemented ...";
                    heroClass = CardClass.INVALID;
                    return null;
            }
        }

    }
}