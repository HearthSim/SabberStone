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
using System.Diagnostics;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using System.Threading.Tasks;
using SabberStoneCore.Model.Entities;
using System.Text;
using System.IO;

namespace SabberStoneCoreConsole
{
	internal class Program
	{
		private static readonly Random Rnd = new Random();

		static void Main(string[] args)
		{
			//SimpleTest();

			Console.WriteLine("Start Test!");

			//ChameleosPintSizedSummonerDouble();

			//AugmentedElekk();

			Console.WriteLine(Cards.Statistics());
			//StabilityTest.CloneStabilityTest();
			StabilityTest.TestRun();
			//for (int i = 0; i < 10000; i++)
			//	StabilityTest.ThreadSafetyTest();
			//EntityChangeTest();
			//YoggTest();
			//TessGreymane();
			//Shudderwock();

			//BasicBuffTest();
			//CardsTest();
			//WhileCardTest();
			//CloneStampTest();
			//CloneSameSame();
			//OptionsTest();
			//GameMulliganTest();
			//GameSplitTest();
			//Console.WriteLine(Cards.Statistics());
			//KabalCourierDiscover();
			//PowerHistoryTest();
			//ChooseOneTest();
			//Kazakus();
			//BrainDeadTest();
			//ParallelTest();
			//CloneAdapt();
			//QuestDrawFirstTest();
			//TortollanPrimalist();

			

			//TestLoader.GetGameTags();
			//var test = TestLoader.Load();
			//Console.WriteLine(test.Count());

			//GatherTagsUsedByEnchantsOrTriggers();

			//Console.WriteLine(Cards.AllStandard.Where(p => p.Race == Race.BEAST && p.Collectible).Count());

			//Cards.Standard[CardClass.PALADIN].ForEach(p => Console.WriteLine($" {p.Id} {p.Type} {p}"));

			Console.WriteLine("Finished! Press key now.");
			Console.ReadKey();
		}

		private static void AugmentedElekk()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Augmented Elekk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Augmented Elekk"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Augmented Elekk"));

			int deckCount = game.CurrentPlayer.DeckZone.Count;

			game.Process(PlayCardTask.Any(game.CurrentPlayer,
				Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fal'dorei Strider"))));

			ShowLog(game, LogLevel.VERBOSE);
		}

		private static void SimpleTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				FillDecks = false,
				History = false,
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.Process(PlayCardTask.Any(game.CurrentPlayer,
				Entity.FromCard(game.CurrentPlayer, Cards.FromName("Emerald Hive Queen"), zone: game.CurrentPlayer.HandZone)));
			game.Process(PlayCardTask.Any(game.CurrentPlayer,
				Entity.FromCard(game.CurrentPlayer, Cards.FromName("Emerald Hive Queen"), zone: game.CurrentPlayer.HandZone)));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var clone = game.Clone();

			var rnd = new Random();

			var hand = clone.CurrentOpponent.HandZone;
			var deck = clone.CurrentOpponent.DeckZone;
			var n = hand.Count;
			for (var i = n; i > 0;)
			{
				var card = hand[--i];

				deck.Add(hand.Remove(card));
				hand.Add(deck.Remove(deck[rnd.Next(deck.Count)]));
				
			}
			deck.Shuffle();

			clone.AuraUpdate();

			var bomb = (Minion)Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Spider Bomb"));
			clone.Process(PlayCardTask.Any(clone.CurrentPlayer, bomb));

			bomb.AttackDamage += 10;

			bomb.HasCharge = true;

			clone.Process(MinionAttackTask.Any(clone.CurrentPlayer, bomb, clone.CurrentOpponent.BoardZone[0]));
		}

		private static void ShowCardAsAsic()
		{

		}

		private static void GatherTagsUsedByEnchantsOrTriggers()
		{
			//var gameTagCounts = new Dictionary<GameTag, int>();
			//foreach (Card card in Cards.All)
			//{
			//	if (card.Powers != null)
			//	{
			//		foreach (Power power in card.Powers)
			//		{
			//			if (power.OldEnchant?.Effects != null)
			//			{
			//				foreach (KeyValuePair<GameTag, int> keyValue in power.OldEnchant.Effects)
			//				{
			//					if (gameTagCounts.ContainsKey(keyValue.Key))
			//					{
			//						gameTagCounts[keyValue.Key] += 1;
			//					}
			//					else
			//					{
			//						gameTagCounts[keyValue.Key] = 1;
			//					}
			//				}
			//			}
			//		}
			//	}
			//}

			//foreach (KeyValuePair<GameTag, int> keyValue in gameTagCounts)
			//{
			//	Console.WriteLine($"{keyValue.Value} -> {keyValue.Key}");
			//}
		}

		static void EntityChangeTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable molten = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Blade"));
			for (int i = 0; i < 5; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
				Console.WriteLine($"{molten.Card.Name}");
			}

			game.Process(PlayCardTask.Any(game.CurrentPlayer, molten));

			if (game.CurrentPlayer.Hero.Weapon == null || molten.AppliedEnchantments.Find(p => p.Card.Id == "UNG_929e") != null)
			{
				Console.WriteLine("Something goes wrong!");
			}
		}

		static void ChameleosPintSizedSummonerDouble()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1Deck = new List<Card>
				{
					Cards.FromId("GIL_142"),
					Cards.FromName("Pint-Sized Summoner"),
					Cards.FromName("Mirage Caller"),
					Cards.FromName("Pint-Sized Summoner"),
					Cards.FromName("Wisp"),
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Hallucination"),
					Cards.FromName("Hallucination"),
					Cards.FromName("Hallucination"),
					Cards.FromName("Hallucination"),
					Cards.FromName("Hallucination"),
				},
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var chameleosId = game.Player1.HandZone[0].Id;

			//do
			//{
			//	game.Process(EndTurnTask.Any(game.Player1));
			//	game.Process(EndTurnTask.Any(game.Player2));
			//} while (game.IdEntityDic[chameleosId].Card.Name == "Mountain Giant");

			//if (game.IdEntityDic[chameleosId].Card.Name != "Hallucination")
			//	throw new Exception();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pint-Sized Summoner"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mirage Caller", game.CurrentPlayer.BoardZone[0]));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			for (int i = game.CurrentPlayer.HandZone.Count - 1; i >= 0; i--)
				game.CurrentPlayer.HandZone.Remove(game.CurrentPlayer.HandZone[i]);

			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Berserker"));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));

			Console.ReadKey();
		}

		static void CloneAdapt()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elder Longneck"));
			Game clone1 = game.Clone();
			Game clone2 = game.Clone();
			Game clone3 = game.Clone();
			Game clone4 = game.Clone();

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));

			clone1.Process(PlayCardTask.Minion(clone1.CurrentPlayer, clone1.CurrentPlayer.HandZone[4]));
			clone1.Process(ChooseTask.Pick(clone1.CurrentPlayer, clone1.CurrentPlayer.Choice.Choices[0]));

			clone2.Process(PlayCardTask.Minion(clone2.CurrentPlayer, clone2.CurrentPlayer.HandZone[4]));
			clone2.Process(ChooseTask.Pick(clone2.CurrentPlayer, clone2.CurrentPlayer.Choice.Choices[0]));

			clone3.Process(PlayCardTask.Minion(clone3.CurrentPlayer, clone3.CurrentPlayer.HandZone[4]));
			clone3.Process(ChooseTask.Pick(clone3.CurrentPlayer, clone3.CurrentPlayer.Choice.Choices[0]));

			clone4.Process(PlayCardTask.Minion(clone4.CurrentPlayer, clone4.CurrentPlayer.HandZone[4]));
			clone4.Process(ChooseTask.Pick(clone4.CurrentPlayer, clone4.CurrentPlayer.Choice.Choices[0]));
		}

		static void ParallelTest()
		{
			int parallel = 100000;
			int ensemble = 2;

			//Create new game and go to MainReady();
			for (int i = 0; i < parallel; i++)
			{
				var game = new Game(new GameConfig
				{
					//StartPlayer = 1,
					FormatType = FormatType.FT_STANDARD,
					Player1HeroClass = Cards.HeroClasses[i % 9],
					Player1Deck = new List<Card>()
					{
						//Cards.FromName("Gorehowl"),
						//Cards.FromName("Alarm-o-Bot"),
						//Cards.FromName("Ironbark Protector"),
						//Cards.FromName("Healing Touch"),
						//Cards.FromName("Healing Touch"),
						//Cards.FromName("Moonfire"),
						//Cards.FromName("Moonfire"),
						//Cards.FromName("Swipe"),
						//Cards.FromName("Swipe"),
						//Cards.FromName("Novice Engineer"),
						//Cards.FromName("Novice Engineer"),
						//Cards.FromName("Voodoo Doctor"),
						//Cards.FromName("Voodoo Doctor"),
						//Cards.FromName("Dragonling Mechanic"),
						//Cards.FromName("Dragonling Mechanic"),
						//Cards.FromName("Acidic Swamp Ooze"),
						//Cards.FromName("Acidic Swamp Ooze"),
						//Cards.FromName("Gurubashi Berserker"),
						//Cards.FromName("Gurubashi Berserker"),
						//Cards.FromName("Murloc Tidehunter"),
						//Cards.FromName("Murloc Tidehunter"),
						//Cards.FromName("Grimscale Oracle"),
						//Cards.FromName("Grimscale Oracle"),
						//Cards.FromName("Dalaran Mage"),
						//Cards.FromName("Dalaran Mage"),
						//Cards.FromName("Nightblade"),
						//Cards.FromName("Nightblade"),
						//Cards.FromName("War Golem"),
						//Cards.FromName("War Golem"),
						//Cards.FromName("Chillwind Yeti"),
						//Cards.FromName("Chillwind Yeti")
					},
					Player2HeroClass = Cards.HeroClasses[(i + 1) % 9],
					Player2Deck = new List<Card>()
					{
						//Cards.FromName("Gorehowl"),
						//Cards.FromName("Alarm-o-Bot"),
						//Cards.FromName("Ironbark Protector"),
						//Cards.FromName("Healing Touch"),
						//Cards.FromName("Healing Touch"),
						//Cards.FromName("Moonfire"),
						//Cards.FromName("Moonfire"),
						//Cards.FromName("Swipe"),
						//Cards.FromName("Swipe"),
						//Cards.FromName("Novice Engineer"),
						//Cards.FromName("Novice Engineer"),
						//Cards.FromName("Voodoo Doctor"),
						//Cards.FromName("Voodoo Doctor"),
						//Cards.FromName("Dragonling Mechanic"),
						//Cards.FromName("Dragonling Mechanic"),
						//Cards.FromName("Acidic Swamp Ooze"),
						//Cards.FromName("Acidic Swamp Ooze"),
						//Cards.FromName("Gurubashi Berserker"),
						//Cards.FromName("Gurubashi Berserker"),
						//Cards.FromName("Murloc Tidehunter"),
						//Cards.FromName("Murloc Tidehunter"),
						//Cards.FromName("Grimscale Oracle"),
						//Cards.FromName("Grimscale Oracle"),
						//Cards.FromName("Dalaran Mage"),
						//Cards.FromName("Dalaran Mage"),
						//Cards.FromName("Nightblade"),
						//Cards.FromName("Nightblade"),
						//Cards.FromName("War Golem"),
						//Cards.FromName("War Golem"),
						//Cards.FromName("Chillwind Yeti"),
						//Cards.FromName("Elder Longneck")
					},
					Shuffle = true,
					FillDecks = true,
					Logging = true,
					History = false
				});
				game.StartGame();

				Task task = Task.Factory.StartNew(() => ParallelGames(game, ensemble));
				task.Wait();
				ProgressBar(i, parallel);
			}
		}

		public static void ParallelGames(Game g, int ensemble)
		{
			var games = new List<Game>();

			for (int i = 0; i < ensemble; i++)
				games.Add(g.Clone());

			ParallelLoopResult result = Parallel.ForEach(games, game =>
			{
				string maliciousCard = RandomUntilTerminal2(game);
				if (maliciousCard != String.Empty)
					Console.WriteLine(maliciousCard);
			});

		}

		private static string RandomUntilTerminal2(Game g)
		{
			int simcount = 0;
			while (simcount < 1000)
			{

				// try
				// {
				g.Process(g.CurrentPlayer.Options()[Util.Random.Next(g.CurrentPlayer.Options().Count)]);
				//}
				//catch (Exception ex)
				//{
				//    ShowLog(g, LogLevel.VERBOSE);

				//                    throw;
				//return g.IdEntityDic[67].Card.Name;
				//               }

				if (g.State == State.COMPLETE)
				{
					return String.Empty;
				}
				simcount++;
			}
			return String.Empty;
		}

		public static void QuestDrawFirstTest()
		{
			var game = new Game(
			new GameConfig()
			{
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Fire Plume's Heart")
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>
				{
					Cards.FromName("The Marsh Queen")
				},
				FillDecks = true,
				Shuffle = true,
				SkipMulligan = false
			});
			game.StartGame();

			ShowLog(game, LogLevel.VERBOSE);
			Console.WriteLine(game.CurrentOpponent.HandZone.FullPrint());
			Console.WriteLine(game.CurrentOpponent.BoardZone.FullPrint());
		}

		private static void BrainDeadTest()
		{
			const int total = 5000;
			var totCards = Cards.AllStandard.ToList();
			int totCardsCount = totCards.Count;
			int turns = 0;
			int[] wins = new[] { 0, 0 };

			var watch = Stopwatch.StartNew();
			for (int i = 0; i < total; i++)
			{
				Console.Clear();
				ProgressBar(i, total);
				var game = new Game(new GameConfig
				{
					//StartPlayer = 1,
					FormatType = FormatType.FT_STANDARD,
					Player1HeroClass = Cards.HeroClasses[i % 9],
					Player2HeroClass = Cards.HeroClasses[(i + 1) % 9],
					FillDecks = true,
					Logging = true,
					History = false
				});
				game.StartGame();

				Console.WriteLine($"{(i > 0 ? turns / i : 0)} AVG. Turns, " +
								  $"{totCards.Count} Stand. -> " +
								  $"{game.Player1.HeroClass} vs. {game.Player2.HeroClass}");

				int loopCount = 0;
				int prevOptionsCount = 0;
				while (game.State != State.COMPLETE)
				{
					List<PlayerTask> options = game.CurrentPlayer.Options();
					PlayerTask option = options[Rnd.Next(options.Count)];

					if (options.Count > 1 && option is EndTurnTask)
					{
						continue;
					}

					if (prevOptionsCount == options.Count)
					{
						loopCount++;
					}
					else
					{
						loopCount = 0;
					}

					prevOptionsCount = options.Count;


					if (loopCount > 10)
					{
						Console.WriteLine("Found bug ... need to be analysed!");
						Console.WriteLine("");
						Console.WriteLine($"is current player board full? {game.CurrentPlayer.BoardZone.IsFull}");
						Console.WriteLine("");
						Console.WriteLine(game.FullPrint());
						Console.WriteLine("");
						options.ForEach(p =>
						{
							Console.WriteLine(p.FullPrint());
						});


						ShowLog(game, LogLevel.VERBOSE);

						Console.ReadKey();
					}

					game.Process(option);
				}
				game.Logs.Clear();

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

		private static void ChooseOneTest()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player1Deck = new List<Card>()
					{
						Cards.FromName("Stonetusk Boar"),
						Cards.FromName("Bloodfen Raptor"),
						Cards.FromName("Raven Idol"),
						Cards.FromName("Living Roots"),
						Cards.FromName("Druid of the Saber"),
						Cards.FromName("Wrath"),
						Cards.FromName("Power of the Wild"),
					},
					Player2HeroClass = CardClass.DRUID,
					Player2Deck = new List<Card>()
					{
						Cards.FromName("Stonetusk Boar"),
						Cards.FromName("Bloodfen Raptor"),
						Cards.FromName("Raven Idol"),
						Cards.FromName("Living Roots"),
						Cards.FromName("Druid of the Saber"),
						Cards.FromName("Wrath"),
						Cards.FromName("Power of the Wild"),
					},
					SkipMulligan = true,
					Shuffle = false,
					FillDecks = true
				});
			game.StartGame();
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			List<PlayerTask> options = game.CurrentPlayer.Options();
			Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
			options.ForEach(p => Console.WriteLine(p.FullPrint()));
			Console.WriteLine($" *** - PowerOptions - ***");
			Console.WriteLine(PowerOptionsBuilder.AllOptions(game, options)?.Print());
			//ShowLog(game, LogLevel.VERBOSE);
		}

		private static void PowerHistoryTest()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					//DeckPlayer1 = new List<Card>
					//{
					//    Cards.FromName("Raven Idol")
					//},
					Player2HeroClass = CardClass.MAGE,
					SkipMulligan = false,
					Shuffle = false,
					FillDecks = true
				});
			game.StartGame();

			//List<PlayerTask> options;
			//options = game.CurrentPlayer.Options();
			//Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
			//options.ForEach(p => Console.WriteLine(p.FullPrint()));

			//Console.WriteLine("*** - START GAME - ***");
			//Console.WriteLine(game.PowerHistory.Print(false));
			//Console.WriteLine("*** - MULLIGAN PLAYER 1 - ***");
			//Console.WriteLine(PowerChoicesBuilder.EntityChoices(game, game.Player1.Choice).Print());
			//Console.WriteLine("*** - MULLIGAN PLAYER 2 - ***");
			//Console.WriteLine(PowerChoicesBuilder.EntityChoices(game, game.Player2.Choice).Print());

			game.Process(ChooseTask.Mulligan(game.Player1, new List<int>(game.Player1.Choice.Choices)));

			//options = game.CurrentPlayer.Options();
			//Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
			//options.ForEach(p => Console.WriteLine(p.FullPrint()));
			//Console.WriteLine(game.PowerHistory.Print(false));

			game.Process(ChooseTask.Mulligan(game.Player2, new List<int> { }));

			//options = game.CurrentPlayer.Options();
			//Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
			//options.ForEach(p => Console.WriteLine(p.FullPrint()));

			//Console.WriteLine(game.PowerHistory.Print(false));

			game.MainReady();

			//options = game.CurrentPlayer.Options();
			//Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
			//options.ForEach(p => Console.WriteLine(p.FullPrint()));

			//Console.WriteLine(game.PowerHistory.Print(false));

			//game.Process(ConcedeTask.Any(game.CurrentPlayer));
			//Console.Write("*** - CONCEDE - ***");
			//Console.Write(game.PowerHistory.Print(false));
			//ShowLog(game, LogLevel.VERBOSE);
			//Console.WriteLine(PowerOptionsBuilder.AllOptions(game.CurrentPlayer.Id, game.CurrentPlayer.Options()).Print());
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//ShowLog(game, LogLevel.VERBOSE);
			//Console.WriteLine(PowerOptionsBuilder.AllOptions(game.CurrentPlayer.Id, game.CurrentPlayer.Options()).Print());

			while (game.State != State.COMPLETE)
			{
				List<PlayerTask> options = game.CurrentPlayer.Options();
				Console.WriteLine($" *** - {game.CurrentPlayer.Name} options on {game.Turn}. - ***");
				options.ForEach(p => Console.WriteLine(p.FullPrint()));

				Console.WriteLine(PowerOptionsBuilder.AllOptions(game, options)?.Print());
				PowerChoicesBuilder.EntityChoices(game, game.CurrentPlayer.Choice);

				PlayerTask option = options[Rnd.Next(options.Count)];
				game.Process(option);
			}

			//foreach (var powerAllOptionse in game.AllOptionsMap)
			//    Console.WriteLine($"{powerAllOptionse.Key} => {powerAllOptionse.Value.Print()}");

			//foreach (var entityChoice in game.EntityChoicesMap)
			//    Console.WriteLine($"{entityChoice.Key} => {entityChoice.Value.Print()}");

			//foreach (var playables in game.IdEntityDic)
			//{
			//    Console.WriteLine($"{playables.Key} => {playables.Value}");
			//}

			ShowLog(game, LogLevel.VERBOSE);
		}

		public static void GameSplitTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
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
				Player2Deck = new List<Card>()
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
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "The Coin"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Loot Hoarder"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Loot Hoarder"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Huge Toad"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Loot Hoarder"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Console.WriteLine(game.CurrentOpponent.DeckZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Mad Bomber"));


			ShowLog(game, LogLevel.VERBOSE);
		}

		public static void GameSplitTest1()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
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
				Player2Deck = new List<Card>()
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
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "The Coin"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Loot Hoarder"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Huge Toad"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Mad Bomber"));

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
				game.Player1.Choice.Choices.Where(p => game.IdEntityDic[p].Cost > 3).ToList()));

			game.Process(ChooseTask.Mulligan(game.Player2,
				game.Player2.Choice.Choices.Where(p => game.IdEntityDic[p].Cost > 3).ToList()));

			game.MainReady();

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

			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion));

			ShowLog(game, LogLevel.VERBOSE);
		}

		public static void KabalCourierDiscover()
		{

			Dictionary<CardClass, IReadOnlyList<Card>> cardSet = Cards.Standard;

			var mageCards =
				cardSet[CardClass.MAGE].Where(p => p.Class == CardClass.MAGE || p.MultiClassGroup != 0).ToList();
			var priestCards =
				cardSet[CardClass.PRIEST].Where(p => p.Class == CardClass.PRIEST || p.MultiClassGroup != 0).ToList();
			var warlockCards =
				cardSet[CardClass.WARLOCK].Where(p => p.Class == CardClass.WARLOCK || p.MultiClassGroup != 0).ToList();

			var stopwatch = new Stopwatch();

			stopwatch.Start();

			var cardSets = new List<List<Card>>();
			foreach (Card mageCard in mageCards)
			{
				foreach (Card priestCard in priestCards)
				{
					foreach (Card warlockCard in warlockCards)
					{
						cardSets.Add(new List<Card> { mageCard, priestCard, warlockCard });
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
				IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dirty Rat"));
				bool hasMinion = game.CurrentOpponent.HandZone.Any(p => p is Minion);
				game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

				flag = hasMinion ? 1 == game.CurrentOpponent.BoardZone.Count : 0 == game.CurrentOpponent.BoardZone.Count;
			}

			ShowLog(game, LogLevel.VERBOSE);
			Console.WriteLine(game.CurrentOpponent.HandZone.FullPrint());
			Console.WriteLine(game.CurrentOpponent.BoardZone.FullPrint());
		}

		public static void CardsTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grim Patron")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Reckless Rocketeer"),
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Grim Patron"));
			Minion grim = game.CurrentPlayer.BoardZone[0];
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			IPlayable boar = game.CurrentPlayer.BoardZone[0] as Minion;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Reckless Rocketeer"));
			IPlayable rocke = game.CurrentPlayer.BoardZone[1] as Minion;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, boar, grim));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, rocke, grim));

			ShowLog(game, LogLevel.VERBOSE);

			Console.WriteLine(game.CurrentOpponent.BoardZone.FullPrint());
			//Console.WriteLine(game.CurrentPlayer.HandZone.FullPrint());
			//Console.WriteLine(game.CurrentPlayer.DeckZone.FullPrint());
		}

		public static void Kazakus()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>() { },
				Player2HeroClass = CardClass.DRUID,
				Player2Deck = new List<Card>() { },
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kazakus"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));

			ShowLog(game, LogLevel.VERBOSE);
		}

		public static void TortollanPrimalist()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>() { },
				Player2HeroClass = CardClass.DRUID,
				Player2Deck = new List<Card>() { },
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tortollan Primalist"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			ShowLog(game, LogLevel.VERBOSE);
		}

		public static void YoggTest()
		{
			while (true)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.DRUID,
					FillDecks = true,
				});
				game.StartGame();
				game.Player1.BaseMana = 10;
				game.Player2.BaseMana = 10;

				game.CurrentPlayer.NumSpellsPlayedThisGame = 30;

				IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(@"Yogg-Saron, Hope's End"));
				game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

				ShowLog(game, LogLevel.VERBOSE);

				if (Console.ReadKey().Key != ConsoleKey.Spacebar)
					break;
			}
		}

		public static void TessGreymane()
		{
			while (true)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.ROGUE,
					FillDecks = true,
				});
				game.StartGame();
				game.Player1.BaseMana = 10;
				game.Player2.BaseMana = 10;

				Card[] randomCards = Cards.Standard[CardClass.MAGE].Where(p => p.Class != CardClass.NEUTRAL).ToArray().ChooseNElements(20);

				foreach (Card card in randomCards)
				{
					Console.WriteLine($"{card.Name} is add to play history");
					game.CurrentPlayer.PlayHistory.Add(new PlayHistoryEntry(card));
				}

				IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tess Greymane"));
				game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

				ShowLog(game, LogLevel.VERBOSE);

				if (Console.ReadKey().Key != ConsoleKey.Spacebar)
					break;
			}
		}

		public static void Shudderwock()
		{
			while (true)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.ROGUE,
					FillDecks = true,
				});
				game.StartGame();
				game.Player1.BaseMana = 10;
				game.Player2.BaseMana = 10;

				Card[] randomCards = Cards.AllStandard
					.Where(p => p.Collectible && p[GameTag.BATTLECRY] == 1)
					.ToArray()
					.ChooseNElements(10);

				foreach (Card card in randomCards)
				{
					Console.WriteLine($"{card.Name} is add to play history");
					game.CurrentPlayer.PlayHistory.Add(new PlayHistoryEntry(card));
				}

				IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shudderwock"));
				game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

				ShowLog(game, LogLevel.DEBUG);

				if (Console.ReadKey().Key != ConsoleKey.Spacebar)
					break;
			}
		}

		public static void CloneSameSame()
		{
			CardClass[] classes = new[]
			{
				CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
				CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
			};
			bool flag = true;
			int total = 10000;
			for (int i = 0; i < total && flag; i++)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = classes[Rnd.Next(classes.Length)],
					Player2HeroClass = classes[Rnd.Next(classes.Length)],
					FillDecks = true,
					History = false,
					Logging = false
				});
				game.StartGame();

				while (game.State != State.COMPLETE)
				{
					List<PlayerTask> options = game.CurrentPlayer.Options();
					PlayerTask option = options[Rnd.Next(options.Count)];
					//try
					//{
						game.Process(option);
					//}
					//catch (Exception e)
					//{
					//	ShowLog(game, LogLevel.DEBUG);
					//	Console.WriteLine(e.Message);
					//	Console.WriteLine(e.StackTrace);
					//	Console.ReadKey();
					//}

					//try
					//{
					//	Game cloneGame = game.Clone();
					//	string str1 = game.Hash();
					//	string str2 = cloneGame.Hash();
					//	flag &= str1.Equals(str2);
					//}
					//catch (Exception e)
					//{
					//	Console.WriteLine(e.Message);
					//	flag = false;
					//}
					//if (!flag)
					//{
					//	Console.WriteLine($"{game.Player1} vs. {game.Player2} ... Option {option}");
					//	ShowLog(game, LogLevel.DEBUG);
					//	break;
					//}
				}

				ProgressBar(i, total);

			}
			Console.WriteLine($"Same whole game? {flag}");
		}

		public static void CloneStampTest()
		{
			int turns = 25;

			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				Logging = false
			});
			game.StartGame();

			for (int i = 0; i < turns; i++)
			{
				List<PlayerTask> options = game.CurrentPlayer.Options();
				PlayerTask option = options[Rnd.Next(options.Count)];
				game.Process(option);
			}

			Console.WriteLine($"GameState: {game.State}");

			Console.WriteLine($"{game.FullPrint()}");

			const int total = 10000;
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < total; i++)
			{
				Game cloneGame = game.Clone();
			}
			watch.Stop();

			Console.WriteLine($"{total} games cloned took {watch.ElapsedMilliseconds} ms => " +
							  $"Avg. {watch.ElapsedMilliseconds / total} per clone!");
		}

		public static void OptionsTest()
		{
			const int total = 5000;
			var totCards = Cards.AllStandard.ToList();
			int totCardsCount = totCards.Count;
			int turns = 0;
			int[] wins = new[] { 0, 0 };

			var watch = Stopwatch.StartNew();
			for (int i = 0; i < total; i++)
			{
				Console.Clear();
				ProgressBar(i, total);
				var game = new Game(new GameConfig
				{
					//StartPlayer = 1,
					FormatType = FormatType.FT_STANDARD,
					Player1HeroClass = Cards.HeroClasses[i % 9],
					Player2HeroClass = Cards.HeroClasses[(i + 1) % 9],
					FillDecks = true,
					Logging = false,
					History = false
				});
				game.StartGame();

				//watch.Stop();
				//game.Player1.Deck.ToList().ForEach(p => totCards.Where(n => n == p.Card).ToList().ForEach(n => totCards.Remove(n)));
				//game.Player2.Deck.ToList().ForEach(p => totCards.Where(n => n == p.Card).ToList().ForEach(n => totCards.Remove(n)));
				//watch.Start();

				Console.WriteLine($"{(i > 0 ? turns / i : 0)} AVG. Turns, " +
								  //$"{((double)totCardsCount/ totCards.Count):0.0%} Stand." +
								  $"{totCards.Count} Stand. -> " +
								  $"{game.Player1.HeroClass} vs. {game.Player2.HeroClass}");

				while (game.State != State.COMPLETE)
				{
					List<PlayerTask> options = game.CurrentPlayer.Options();
					//try
					//{
					PlayerTask option = options[Rnd.Next(options.Count)];

					if (option.PlayerTaskType == PlayerTaskType.PLAY_CARD)
					{
						totCards.Where(n => n == option.Source.Card).ToList().ForEach(n => totCards.Remove(n));
					}

					//Console.WriteLine(option.FullPrint());
					game.Process(option);
					//}
					//catch (Exception e)
					//{
					//    Console.WriteLine(e);
					//    ShowLog(game, LogLevel.VERBOSE);
					//    throw;
					//}

				}
				game.Logs.Clear();

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

			totCards.OrderBy(o => o.Id).ToList().ForEach(p => Console.WriteLine($" {p.Id} {p.Type} {p}"));
		}

		internal static void ShowLog(Game game, LogLevel level)
		{
			var str = new StringBuilder();
			while (game.Logs.Count > 0)
			{
				LogEntry logEntry = game.Logs.Dequeue();
				if (logEntry.Level <= level)
				{
					ConsoleColor foreground = ConsoleColor.White;
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
							foreground = logEntry.Location.Equals("Game") ? ConsoleColor.Yellow :
										 logEntry.Location.StartsWith("Quest") ? ConsoleColor.Cyan :
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

					string logStr = $"{logEntry.TimeStamp.ToLongTimeString()} - {logEntry.Level} [{logEntry.BlockType}] - {logEntry.Location}: {logEntry.Text}";
					str.Append(logStr + "\n");
					Console.WriteLine(logStr);
				}
			}
			Console.ResetColor();

			File.WriteAllText(Directory.GetCurrentDirectory() + @"\dump.log", str.ToString());
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
