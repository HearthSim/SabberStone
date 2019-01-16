#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Newtonsoft.Json;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCoreGui.Score;
using SabberStoneCoreGui.Nodes;
using SabberStoneCoreGui.Meta;
using SabberStoneGui.Core;
using SabberStoneGui.Deck;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Visualizer;

namespace SabberStoneGui
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Game CurrentGame;

		public List<PlayerTask> CurrentSolution;

		public List<Card> CurrentDeck = new List<Card>();

		public List<MetaDeck> AllDecks;

		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;
			var parameters = e.Argument as List<object>;

			int maxDepth = (int)parameters[0];
			int maxWidth = (int)parameters[1];
			var scoring = (IScore)parameters[2];

			var depthNodes = new Dictionary<string, OptionNode>
			{
				["root"] = new OptionNode(null, CurrentGame, CurrentGame.CurrentPlayer.Id, null, scoring)
			};
			var endTurnNodes = new List<OptionNode>();
			for (int i = 0; depthNodes.Count > 0 && i < maxDepth; i++)
			{
				//var nextDepthNodes = new Dictionary<string, OptionNode>();
				var nextDepthNodes = new ConcurrentDictionary<string, OptionNode>();
				int countNodes = 0;
				int countNodesTot = depthNodes.Values.Count;
				//foreach (var option in depthNodes.Values)
				//{
				//	countNodes++;
				//	worker?.ReportProgress(countNodes, countNodesTot);
				//	option.Options(ref nextDepthNodes);
				//}
				var tasks = new List<Task>();
				foreach (OptionNode option in depthNodes.Values)
				{
					tasks.Add(new Task(() =>
					{
						option.Options(ref nextDepthNodes);
						Task inner = Task.Factory.StartNew(() =>
						{
							Interlocked.Increment(ref countNodes);
							worker?.ReportProgress(countNodes, countNodesTot);
						}, TaskCreationOptions.AttachedToParent);
					}));
				}
				foreach (Task task in tasks)
					task.Start();
				Task.WaitAll(tasks.ToArray());

				endTurnNodes.AddRange(nextDepthNodes.Values.Where(p => p.IsEndTurn || p.IsWon));

				depthNodes = nextDepthNodes
					.Where(p => !p.Value.IsEndTurn && p.Value.IsRunning)
					.OrderByDescending(p => p.Value.Score)
					.Take(maxWidth)
					.ToDictionary(p => p.Key, p => p.Value);

				worker?.ReportProgress(i + 1,
					$"Depth: {i + 1} --> {depthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{endTurnNodes.Count}]");
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

		private List<OptionNode> GetOpTurn(string playerTag, int maxDepth, int maxWidth, BackgroundWorker worker,
			List<OptionNode> endTurnNodes)
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
			for (int i = 0; opDepthNodes.Count > 0 && i < maxDepth; i++)
			{
				//var nextDepthNodes = new Dictionary<string, OptionNode>();
				var nextDepthNodes = new ConcurrentDictionary<string, OptionNode>();
				int countNodes = 0;
				int countNodesTot = opDepthNodes.Values.Count;
				//foreach (var option in opDepthNodes.Values)
				//{
				//	countNodes++;
				//	worker?.ReportProgress(countNodes, countNodesTot);
				//	option.Options(ref nextDepthNodes);
				//}
				var tasks = new List<Task>();
				foreach (OptionNode option in opDepthNodes.Values)
				{
					countNodes++;
					worker?.ReportProgress(countNodes, countNodesTot);
					tasks.Add(new Task(() => option.Options(ref nextDepthNodes)));
				}
				foreach (Task task in tasks)
					task.Start();
				Task.WaitAll(tasks.ToArray());

				opEndTurnNodes.AddRange(nextDepthNodes.Values.Where(p => p.IsEndTurn || p.IsWon));

				opDepthNodes = nextDepthNodes
					.Where(p => !p.Value.IsEndTurn && p.Value.IsRunning)
					.OrderByDescending(p => p.Value.Score)
					.Take(maxWidth)
					.ToDictionary(p => p.Key, p => p.Value);

				worker?.ReportProgress(i + 1,
					$"{playerTag}: {i + 1} --> {opDepthNodes.Count}/{nextDepthNodes.Count} options! [SOLUTIONS:{opEndTurnNodes.Count}]");
			}

			return opEndTurnNodes;
		}

		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			int test = e.ProgressPercentage;

			if (e.UserState is int)
			{
				PgrBarDepth.Value = (double)test * 100 / (int)e.UserState;
			}
			else if (e.UserState != null)
			{
				TxtPlayer1.AppendText(e.UserState.ToString() + Environment.NewLine);
			}
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var endTurnNodes = (List<OptionNode>)e.Result;
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

			CbxFormat.ItemsSource = GuiHelper.FormatTypes;
			CbxFormat.SelectedIndex = 1;
			CbxClassCard.ItemsSource = GuiHelper.ClassTypes;
			CbxClassCard.SelectedIndex = 1;
			CbxDeckStrategy.ItemsSource = GuiHelper.StrategyTypes;
			CbxDeckStrategy.SelectedIndex = 1;
			if (File.Exists(Environment.CurrentDirectory + @"\allDecks.json"))
			{
				string json = File.ReadAllText(Environment.CurrentDirectory + @"\allDecks.json");
				AllDecks = JsonConvert.DeserializeObject<List<MetaDeck>>(json);
			}
			else
			{
				AllDecks = new List<MetaDeck>();
			}

			DtDeckFiles.ItemsSource = AllDecks;

			CboxAi1.ItemsSource = GuiHelper.StrategyTypes;
			CboxAi2.ItemsSource = GuiHelper.StrategyTypes;

			CboxDeck1.ItemsSource = AllDecks;
			CboxDeck1.SelectedIndex = 1;
			CboxDeck2.ItemsSource = AllDecks;
			CboxDeck2.SelectedIndex = 1;


			string[] help = CardAsciiBuilder.PrintHelp();
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

			while (CurrentGame.Logs.Count > 0)
			{
				LogEntry logEntry = CurrentGame.Logs.Dequeue();
				if (logEntry.Level <= LogLevel.INFO)
					TxtPlayLog.Text += $"[{logEntry.BlockType}] - {logEntry.Location}: {logEntry.Text}\n";
			}


			TxtPlayLog.ScrollToEnd();

			if (CurrentGame.State == State.RUNNING && !BtnStart.IsEnabled)
			{
				TxtPlayer1.Text = $"* Calculating solutions *** {CurrentGame.CurrentPlayer} ***" + Environment.NewLine;
				TxtPlayer1.AppendText(
					$"... with depth: {(int)SlidMaxDepth.Value} and width: {(int)SlidMaxWidth.Value} ..." +
					Environment.NewLine);
				var worker = new BackgroundWorker { WorkerReportsProgress = true };
				worker.DoWork += worker_DoWork;
				worker.ProgressChanged += worker_ProgressChanged;
				worker.RunWorkerCompleted += worker_RunWorkerCompleted;
				IScore scoring = CurrentGame.CurrentPlayer == CurrentGame.Player1
					? GuiHelper.GetScoring((Strategy)CboxAi1.SelectedValue)
					: GuiHelper.GetScoring((Strategy)CboxAi2.SelectedValue);
				worker.RunWorkerAsync(new List<object> { (int)SlidMaxDepth.Value, (int)SlidMaxWidth.Value, scoring });
				BtnStart.Content = $"{CurrentGame.CurrentPlayer} Move!";
			}
			else if (CurrentGame.State == SabberStoneCore.Enums.State.COMPLETE)
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
			CurrentSolution.ForEach(
				p => TxtPlayer1.AppendText(CurrentSolution.IndexOf(p) + ") " + p.FullPrint() + Environment.NewLine));
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (CurrentGame?.State == SabberStoneCore.Enums.State.RUNNING)
			{
				SabberStoneCore.Model.Entities.Controller curPlayer = CurrentGame.CurrentPlayer;
				PlayerTask nextTask = CurrentSolution[0];
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

				CurrentGame = new Game(GuiHelper.CreateGameConfig((MetaDeck)CboxDeck1.SelectedItem, (MetaDeck)CboxDeck2.SelectedItem));
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

		private void CbxFormat_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			BuildCardList();
		}

		private void CbxClassCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			BuildCardList();
		}

		private void BuildCardList()
		{
			if (CbxFormat.SelectedItem == null || CbxClassCard.SelectedItem == null)
				return;

			var formatType = (FormatType)CbxFormat.SelectedItem;
			var cardClass = (CardClass)CbxClassCard.SelectedItem;

			IEnumerable<Card> cards;
			switch (formatType)
			{
				case FormatType.FT_STANDARD:
					cards = Cards.Standard[cardClass];
					break;
				case FormatType.FT_WILD:
					cards = Cards.Wild[cardClass];
					break;
				default:
					throw new NotImplementedException();
			}

			DtGrTest.ItemsSource = cards.OrderBy(p => p.Class).ThenBy(c => c.Cost);
		}

		private void DtGrTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var card = (Card)DtGrTest.SelectedItem;
			if (card != null)
				UpdatedImage(card.Id);
		}

		private void BtnAddCard_Click(object sender, RoutedEventArgs e)
		{
			var card = (Card)DtGrTest.SelectedItem;
			if (CurrentDeck.Count < 30 && CurrentDeck.Count(p => p == card) < card.MaxAllowedInDeck)
			{
				CurrentDeck.Add(card);
				LbCardCountValue.Content = CurrentDeck.Count;
				DtGrDeck.ItemsSource = CurrentDeck.OrderBy(p => p.Class).ThenBy(c => c.Cost);
			}
		}

		private void BtnRemoveCard_Click(object sender, RoutedEventArgs e)
		{
			var card = (Card)DtGrDeck.SelectedItem;
			CurrentDeck.Remove(card);
			LbCardCountValue.Content = CurrentDeck.Count;
			DtGrDeck.ItemsSource = CurrentDeck.OrderBy(p => p.Class).ThenBy(c => c.Cost);
		}

		private void DtGrDeck_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var card = (Card)DtGrDeck.SelectedItem;
			if (card != null)
				UpdatedImage(card.Id);
		}

		private void UpdatedImage(string cardid)
		{
			var bDecoder = BitmapDecoder.Create(new Uri("http://media.services.zam.com/v1/media/byName/hs/cards/enus/" + cardid + ".png"),
				BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);

			if (bDecoder.Frames.Count > 0)
				ImgCard.Source = bDecoder.Frames[0];
		}

		private void BtSave_Click(object sender, RoutedEventArgs e)
		{
			if (CurrentDeck.Count != 30)
			{
				MessageBox.Show("MetaDeck isn't legit!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
			}

			var deck = new MetaDeck
			{
				Name = TxDeckname.Text,
				Description = TxDescription.Text,
				Link = TxDeckLink.Text,
				FormatType = (FormatType)CbxFormat.SelectedItem,
				HeroClass = (CardClass)CbxClassCard.SelectedItem,
				Strategy = (Strategy)CbxDeckStrategy.SelectedItem,
				CardIds = CurrentDeck.Select(p => p.Id).ToList()
			};

			if (AllDecks == null)
				AllDecks = new List<MetaDeck> { deck };
			else
				AllDecks.Add(deck);

			WriteAllDecks();
		}

		private void BtnLoadDeck_Click(object sender, RoutedEventArgs e)
		{
			var file = (MetaDeck)DtDeckFiles.SelectedItem;

			TxDeckname.Text = file.Name;
			TxDescription.Text = file.Description;
			TxDeckLink.Text = file.Link;
			CbxFormat.SelectedItem = file.FormatType;
			CbxClassCard.SelectedItem = file.HeroClass;
			CbxDeckStrategy.SelectedItem = file.Strategy;
			CurrentDeck = file.CardIds.Select(Cards.FromId).ToList();
			LbCardCountValue.Content = CurrentDeck.Count;
			DtGrDeck.ItemsSource = CurrentDeck.OrderBy(p => p.Class).ThenBy(c => c.Cost);
		}

		private void WriteAllDecks()
		{
			File.WriteAllText(Environment.CurrentDirectory + @"\allDecks.json", JsonConvert.SerializeObject(AllDecks, Formatting.Indented));
			DtDeckFiles.ItemsSource = AllDecks.OrderBy(p => p.Name);
		}

		private void BtnDeleteDeck_Click(object sender, RoutedEventArgs e)
		{
			var deck = (MetaDeck)DtDeckFiles.SelectedItem;
			AllDecks.Remove(deck);
			WriteAllDecks();
		}

		private void CboxDeck1_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var metaDeck = CboxDeck1.SelectedItem as MetaDeck;
			if (metaDeck != null)
			{
				LblClass1.Content = metaDeck.HeroClass.ToString();
				CboxAi1.SelectedItem = metaDeck.Strategy;

			}
		}

		private void CboxDeck2_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var metaDeck = CboxDeck2.SelectedItem as MetaDeck;
			if (metaDeck != null)
			{
				LblClass2.Content = metaDeck.HeroClass.ToString();
				CboxAi2.SelectedItem = metaDeck.Strategy;

			}
		}
	}
}
