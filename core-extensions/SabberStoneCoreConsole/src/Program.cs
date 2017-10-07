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
			Console.WriteLine("Start Test!");

			//BasicBuffTest();
			//CardsTest();
			//WhileCardTest();
			//CloneStampTest();
			//CloneSameSame();
			//OptionsTest();
			//GameMulliganTest();
			//GameSplitTest();
			Console.WriteLine(Cards.Statistics());
			//KabalCourierDiscover();
			//PowerHistoryTest();
			//ChooseOneTest();
			//Kazakus();
			//BrainDeadTest();
			//ParallelTest();
			//CloneAdapt();
			//QuestDrawFirstTest();

			//TestLoader.GetGameTags();
			//var test = TestLoader.Load();
			//Console.WriteLine(test.Count());

			//Console.WriteLine(Cards.AllStandard.Where(p => p.Race == Race.BEAST && p.Collectible).Count());

			//Cards.Standard[CardClass.PALADIN].ForEach(p => Console.WriteLine($" {p.Id} {p.Type} {p}"));

			Console.WriteLine("Finished! Press key now.");
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

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
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

			Dictionary<CardClass, IEnumerable<Card>> cardSet = Cards.Standard;

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
				bool hasMinion = game.CurrentOpponent.HandZone.GetAll.Any(p => p is Minion);
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
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodreaver Gul'dan")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodreaver Gul'dan"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			ShowLog(game, LogLevel.VERBOSE);

			//Console.WriteLine(game.CurrentPlayer.BoardZone.FullPrint());
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

		public static void CloneSameSame()
		{
			CardClass[] classes = new[]
			{
				CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
				CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
			};
			bool flag = true;
			int total = 100;
			for (int i = 0; i < total && flag; i++)
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
					List<PlayerTask> options = game.CurrentPlayer.Options();
					PlayerTask option = options[Rnd.Next(options.Count)];
					game.Process(option);
					Game cloneGame = game.Clone();
					string str1 = game.Hash();
					string str2 = cloneGame.Hash();
					flag &= str1.Equals(str2);
					if (!flag)
					{
						Console.WriteLine($"{game.Player1} vs. {game.Player2} ... Option {option}");
						break;
					}
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

		private static void ShowLog(Game game, LogLevel level)
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

					string logStr = $"{logEntry.TimeStamp} - {logEntry.Level} [{logEntry.BlockType}] - {logEntry.Location}: {logEntry.Text}";
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
