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
using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesGilneasTest
	{
		// ------------------------------------------ HERO - HUNTER
		// [GILA_400h] Houndmaster Shaw (*) - COST:0 [ATK:0/HP:20] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Entourage: GILA_414, GILA_415, GILA_805
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48419
		// - 793 = 1646
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoundmasterShaw_GILA_400h()
		{
			// TODO HoundmasterShaw_GILA_400h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Houndmaster Shaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Houndmaster Shaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Houndmaster Shaw"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_500h3] Tess Greymane (*) - COST:0 [ATK:0/HP:20] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Entourage: GILA_513, GILA_511, GILA_506
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48590
		// - 793 = 1596
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TessGreymane_GILA_500h3()
		{
			// TODO TessGreymane_GILA_500h3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tess Greymane"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tess Greymane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tess Greymane"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_500h4] Tess Greymane (*) - COST:8 [ATK:0/HP:30] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 8 damage
		//       to all minions and choose
		//       a <b>Passive</b> Treasure.
		// --------------------------------------------------------
		// Entourage: GILA_513, GILA_511, LOOTA_832
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 48590
		// - 793 = 1749
		// - 960 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TessGreymane_GILA_500h4()
		{
			// TODO TessGreymane_GILA_500h4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tess Greymane"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tess Greymane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tess Greymane"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_600h] Darius Crowley (*) - COST:0 [ATK:0/HP:20] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Entourage: GILA_604, GILA_603, GILA_814
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47847
		// - 793 = 1583
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DariusCrowley_GILA_600h()
		{
			// TODO DariusCrowley_GILA_600h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darius Crowley"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darius Crowley"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darius Crowley"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_600h2] Darius Crowley (*) - COST:5 [ATK:0/HP:30] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 5 damage
		//       to all minions and choose
		//       a <b>Passive</b> Treasure.
		// --------------------------------------------------------
		// Entourage: GILA_603, GILA_805, GILA_607
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 47847
		// - 793 = 1747
		// - 960 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DariusCrowley_GILA_600h2()
		{
			// TODO DariusCrowley_GILA_600h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darius Crowley"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darius Crowley"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darius Crowley"));
		}

		// -------------------------------------------- HERO - MAGE
		// [GILA_900h] Toki, Time-Tinker (*) - COST:0 [ATK:0/HP:20] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Entourage: GILA_913, GILA_813, LOOTA_825
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48553
		// - 793 = 1649
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TokiTimeTinker_GILA_900h()
		{
			// TODO TokiTimeTinker_GILA_900h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toki, Time-Tinker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toki, Time-Tinker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toki, Time-Tinker"));
		}

		// -------------------------------------------- HERO - MAGE
		// [GILA_900h2] Toki, Time-Tinker (*) - COST:3 [ATK:0/HP:30] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 3 damage
		//       to all minions and choose
		//       a <b>Passive</b> Treasure.
		// --------------------------------------------------------
		// Entourage: GILA_913, GILA_813, LOOTA_825
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 48553
		// - 793 = 1746
		// - 960 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TokiTimeTinker_GILA_900h2()
		{
			// TODO TokiTimeTinker_GILA_900h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toki, Time-Tinker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toki, Time-Tinker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toki, Time-Tinker"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_20h] A Mangy Wolf (*) - COST:0 [ATK:0/HP:15] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Unearthly howls drive the wildlife mad.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47902
		// - 793 = 1594
		// - 843 = 48387
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AMangyWolf_GILA_BOSS_20h()
		{
			// TODO AMangyWolf_GILA_BOSS_20h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("A Mangy Wolf"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("A Mangy Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "A Mangy Wolf"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_21h] Rottooth (*) - COST:0 [ATK:0/HP:15] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Incorporeal or not, those claws hurt!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48057
		// - 793 = 1608
		// - 843 = 48388
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rottooth_GILA_BOSS_21h()
		{
			// TODO Rottooth_GILA_BOSS_21h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rottooth"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rottooth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rottooth"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_22h] Cutthroat Willie (*) - COST:0 [ATK:0/HP:25] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>WANTED: For doing exactly what his name suggests.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48071
		// - 793 = 1614
		// - 843 = 48391
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CutthroatWillie_GILA_BOSS_22h()
		{
			// TODO CutthroatWillie_GILA_BOSS_22h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cutthroat Willie"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cutthroat Willie"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cutthroat Willie"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_BOSS_23h] Grubb the Swampdrinker (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>An iron gut, and quite the throwing arm.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_23t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48143
		// - 793 = 1616
		// - 843 = 48368
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrubbTheSwampdrinker_GILA_BOSS_23h()
		{
			// TODO GrubbTheSwampdrinker_GILA_BOSS_23h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grubb the Swampdrinker"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grubb the Swampdrinker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grubb the Swampdrinker"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_24h] Groddo the Bogwarden (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Dead emerge from the swamp. It's not a pleasant scent.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48150
		// - 793 = 1617
		// - 843 = 48354
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GroddoTheBogwarden_GILA_BOSS_24h()
		{
			// TODO GroddoTheBogwarden_GILA_BOSS_24h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Groddo the Bogwarden"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Groddo the Bogwarden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Groddo the Bogwarden"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_25h] Manhunter Ivan (*) - COST:0 [ATK:0/HP:25] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Watch your step, this traitor is an expert trapper.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48180
		// - 793 = 1618
		// - 843 = 48375
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManhunterIvan_GILA_BOSS_25h()
		{
			// TODO ManhunterIvan_GILA_BOSS_25h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Manhunter Ivan"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Manhunter Ivan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Manhunter Ivan"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_26h] Gnomenapper (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>A collector of gnomes. Real ones.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_26t2
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48194
		// - 793 = 1620
		// - 843 = 48264
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gnomenapper_GILA_BOSS_26h()
		{
			// TODO Gnomenapper_GILA_BOSS_26h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnomenapper"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnomenapper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnomenapper"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [GILA_BOSS_27h] Experiment 3C (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>It's a Murloc! It's a Dragon! It's... everything?</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_27t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48270
		// - 793 = 1621
		// - 843 = 48268
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Experiment3c_GILA_BOSS_27h()
		{
			// TODO Experiment3c_GILA_BOSS_27h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Experiment 3C"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Experiment 3C"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Experiment 3C"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_29h] Sazzmi Gentlehorn (*) - COST:0 [ATK:0/HP:35] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<i>This satyr has a
		//       tendency to attract
		//       more than just rats.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_29t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48297
		// - 793 = 1623
		// - 843 = 48296
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SazzmiGentlehorn_GILA_BOSS_29h()
		{
			// TODO SazzmiGentlehorn_GILA_BOSS_29h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sazzmi Gentlehorn"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sazzmi Gentlehorn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sazzmi Gentlehorn"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_30h] Blood Witch Gretta (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Magic is powerful in her grove… but it comes at a cost.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48302
		// - 793 = 1624
		// - 843 = 48399
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodWitchGretta_GILA_BOSS_30h()
		{
			// TODO BloodWitchGretta_GILA_BOSS_30h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Witch Gretta"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Witch Gretta"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Witch Gretta"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_31h] Gnarlroot (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Gnarled, twisting roots, splintering to life.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48310
		// - 793 = 1625
		// - 843 = 48372
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gnarlroot_GILA_BOSS_31h()
		{
			// TODO Gnarlroot_GILA_BOSS_31h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnarlroot"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnarlroot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnarlroot"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_32h] Niira the Trickster (*) - COST:0 [ATK:0/HP:25] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>She plays with wee critters… until they’re big critters.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48313
		// - 793 = 1626
		// - 843 = 48383
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NiiraTheTrickster_GILA_BOSS_32h()
		{
			// TODO NiiraTheTrickster_GILA_BOSS_32h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Niira the Trickster"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Niira the Trickster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Niira the Trickster"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_33h] The Scarecrow (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>His enchanted scythe drinks deep from every_harvest.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_33t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48316
		// - 793 = 1627
		// - 843 = 48318
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheScarecrow_GILA_BOSS_33h()
		{
			// TODO TheScarecrow_GILA_BOSS_33h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Scarecrow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Scarecrow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Scarecrow"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_34h] Inquisitor Hav'nixx (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>A mind is a terrible thing to waste. It's far too delicious.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48323
		// - 793 = 1628
		// - 843 = 48352
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InquisitorHavnixx_GILA_BOSS_34h()
		{
			// TODO InquisitorHavnixx_GILA_BOSS_34h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Inquisitor Hav'nixx"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inquisitor Hav'nixx"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Inquisitor Hav'nixx"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_35h] Chupacabran (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>It used to feed on local livestock. Now it hungers for more.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_35t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48327
		// - 793 = 1629
		// - 843 = 48329
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chupacabran_GILA_BOSS_35h()
		{
			// TODO Chupacabran_GILA_BOSS_35h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chupacabran"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chupacabran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chupacabran"));
		}

		// -------------------------------------------- HERO - MAGE
		// [GILA_BOSS_36h] Griselda (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Watch those lips, she'll kiss just about anything.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48336
		// - 793 = 1640
		// - 843 = 48335
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Griselda_GILA_BOSS_36h()
		{
			// TODO Griselda_GILA_BOSS_36h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Griselda"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Griselda"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Griselda"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [GILA_BOSS_37h] Wharrgarbl (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The Witchwood's curse has not been kind to the local Murlocs.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_37t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48331
		// - 793 = 1639
		// - 843 = 48330
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wharrgarbl_GILA_BOSS_37h()
		{
			// TODO Wharrgarbl_GILA_BOSS_37h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wharrgarbl"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wharrgarbl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wharrgarbl"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_38h] Ravencaller Cozzlewurt (*) - COST:0 [ATK:0/HP:15] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The feathered fiends of Gilneas flock to his sinister call.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48579
		// - 793 = 1653
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavencallerCozzlewurt_GILA_BOSS_38h()
		{
			// TODO RavencallerCozzlewurt_GILA_BOSS_38h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravencaller Cozzlewurt"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ravencaller Cozzlewurt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravencaller Cozzlewurt"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_39h] Forlorn Lovers (*) - COST:0 [ATK:0/HP:70] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Bound by vows, she just won't let go.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48591
		// - 793 = 1654
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForlornLovers_GILA_BOSS_39h()
		{
			// TODO ForlornLovers_GILA_BOSS_39h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forlorn Lovers"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forlorn Lovers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forlorn Lovers"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_40h] Splintergraft (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>She'll take a piece of you and make it her own.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48595
		// - 793 = 1680
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Splintergraft_GILA_BOSS_40h()
		{
			// TODO Splintergraft_GILA_BOSS_40h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splintergraft"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splintergraft"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Splintergraft"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_BOSS_41h] Brushwood Centurion (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>This once-stalwart defender of the woods now sows chaos.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48597
		// - 793 = 1655
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrushwoodCenturion_GILA_BOSS_41h()
		{
			// TODO BrushwoodCenturion_GILA_BOSS_41h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brushwood Centurion"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brushwood Centurion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brushwood Centurion"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_BOSS_42h] Baran the Blind (*) - COST:0 [ATK:0/HP:30] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Poor vision doesn't matter with strength like his.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48603
		// - 793 = 1656
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaranTheBlind_GILA_BOSS_42h()
		{
			// TODO BaranTheBlind_GILA_BOSS_42h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baran the Blind"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baran the Blind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baran the Blind"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_43h] Gravekeeper Damph (*) - COST:0 [ATK:0/HP:35] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The rattle of bones remain a comfort to him.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_43t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48610
		// - 793 = 1657
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GravekeeperDamph_GILA_BOSS_43h()
		{
			// TODO GravekeeperDamph_GILA_BOSS_43h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gravekeeper Damph"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gravekeeper Damph"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gravekeeper Damph"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_44h] Doctor Sezavo (*) - COST:0 [ATK:0/HP:20] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>It’s good to give blood. But not to him. He’s not a real doctor.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48623
		// - 793 = 1658
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DoctorSezavo_GILA_BOSS_44h()
		{
			// TODO DoctorSezavo_GILA_BOSS_44h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doctor Sezavo"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doctor Sezavo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doctor Sezavo"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_45h] Cultist S'thara (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>A silver tongue to accompany her silver daggers.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48633
		// - 793 = 1662
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CultistSthara_GILA_BOSS_45h()
		{
			// TODO CultistSthara_GILA_BOSS_45h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cultist S'thara"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cultist S'thara"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cultist S'thara"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [GILA_BOSS_46h] Vitus the Exiled (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Corrupted. Banished. Hungry.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48729
		// - 793 = 1665
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VitusTheExiled_GILA_BOSS_46h()
		{
			// TODO VitusTheExiled_GILA_BOSS_46h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vitus the Exiled"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vitus the Exiled"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vitus the Exiled"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_47h] Shudderwock (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<i>And 'lo in uffish
		//       thought he stood, crying
		//       "Battle" in the wood.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48736
		// - 793 = 1666
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shudderwock_GILA_BOSS_47h()
		{
			// TODO Shudderwock_GILA_BOSS_47h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shudderwock"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shudderwock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shudderwock"));
		}

		// -------------------------------------------- HERO - MAGE
		// [GILA_BOSS_48h] Infinite Toki (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>One either dies a hero or mangles time enough to become a villain.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48763
		// - 793 = 1667
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InfiniteToki_GILA_BOSS_48h()
		{
			// TODO InfiniteToki_GILA_BOSS_48h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infinite Toki"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infinite Toki"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Infinite Toki"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_49h] Glinda Crowskin (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The leader of Hagatha’s dark cult hides behind her loyal minions.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48791
		// - 793 = 1668
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlindaCrowskin_GILA_BOSS_49h()
		{
			// TODO GlindaCrowskin_GILA_BOSS_49h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glinda Crowskin"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glinda Crowskin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glinda Crowskin"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_50h] The Whisperer (*) - COST:0 [ATK:0/HP:25] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Do you hear the echoes of his whispers?</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48813
		// - 793 = 1670
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheWhisperer_GILA_BOSS_50h()
		{
			// TODO TheWhisperer_GILA_BOSS_50h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Whisperer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Whisperer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Whisperer"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_51h] Garrow, the Rancorous (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Missing? Dead? He'll still collect.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48869
		// - 793 = 1681
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GarrowTheRancorous_GILA_BOSS_51h()
		{
			// TODO GarrowTheRancorous_GILA_BOSS_51h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garrow, the Rancorous"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garrow, the Rancorous"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Garrow, the Rancorous"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_52h] Crooked Pete (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The locals report
		//       that Pete is up to
		//       no good again.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48873
		// - 793 = 1683
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrookedPete_GILA_BOSS_52h()
		{
			// TODO CrookedPete_GILA_BOSS_52h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crooked Pete"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crooked Pete"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crooked Pete"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_52h2] Beastly Pete (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48872
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeastlyPete_GILA_BOSS_52h2()
		{
			// TODO BeastlyPete_GILA_BOSS_52h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beastly Pete"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beastly Pete"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beastly Pete"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_54h] Cragtorr (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Seeds sewn from hatred, sustained by dark magic.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48935
		// - 793 = 1692
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cragtorr_GILA_BOSS_54h()
		{
			// TODO Cragtorr_GILA_BOSS_54h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cragtorr"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cragtorr"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cragtorr"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_55h] Azalina Soulthief (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<i>Her children's safety
		//       is her top priority.
		//       At any cost.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48939
		// - 793 = 1693
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzalinaSoulthief_GILA_BOSS_55h()
		{
			// TODO AzalinaSoulthief_GILA_BOSS_55h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azalina Soulthief"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azalina Soulthief"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Azalina Soulthief"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_56h] Face Collector (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<i>Beware his terrible
		//       minions and their
		//       ever-shifting faces.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48941
		// - 793 = 1621
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FaceCollector_GILA_BOSS_56h()
		{
			// TODO FaceCollector_GILA_BOSS_56h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Face Collector"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Face Collector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Face Collector"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_57h] Raeth Ghostsong (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>There's a reason you should burn the dead.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_57t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48943
		// - 793 = 1696
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaethGhostsong_GILA_BOSS_57h()
		{
			// TODO RaethGhostsong_GILA_BOSS_57h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raeth Ghostsong"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raeth Ghostsong"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raeth Ghostsong"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [GILA_BOSS_58h] Grum (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Grum likes to smash. He also likes to bash. And crash.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48946
		// - 793 = 1701
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grum_GILA_BOSS_58h()
		{
			// TODO Grum_GILA_BOSS_58h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grum"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grum"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grum"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_59h] Lord Godfrey (*) - COST:0 [ATK:0/HP:60] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>The Lord of Shadowfang Keep has a bullet to pick with Crowley.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48948
		// - 793 = 1728
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordGodfrey_GILA_BOSS_59h()
		{
			// TODO LordGodfrey_GILA_BOSS_59h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Godfrey"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Godfrey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Godfrey"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [GILA_BOSS_60h] Captain Shivers (*) - COST:0 [ATK:0/HP:75] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Vowing vengeance, his cursed crew haunts Gilnean shores.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48952
		// - 793 = 1729
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaptainShivers_GILA_BOSS_60h()
		{
			// TODO CaptainShivers_GILA_BOSS_60h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captain Shivers"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Captain Shivers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Captain Shivers"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [GILA_BOSS_61h] Hagatha the Witch (*) - COST:0 [ATK:0/HP:100] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - HERO_POWER = 47631
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HagathaTheWitch_GILA_BOSS_61h()
		{
			// TODO HagathaTheWitch_GILA_BOSS_61h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hagatha the Witch"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hagatha the Witch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hagatha the Witch"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_62h] Gustave, the Gutripper (*) - COST:0 [ATK:0/HP:50] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Hagatha’s pet eats his way from the bottom of the food chain up.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 48999
		// - 793 = 1697
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GustaveTheGutripper_GILA_BOSS_62h()
		{
			// TODO GustaveTheGutripper_GILA_BOSS_62h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gustave, the Gutripper"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gustave, the Gutripper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gustave, the Gutripper"));
		}

		// ------------------------------------------- HERO - DRUID
		// [GILA_BOSS_63h] Sephira Dusktalon (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Even your own magic can be twisted by these woods.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49000
		// - 793 = 1698
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SephiraDusktalon_GILA_BOSS_63h()
		{
			// TODO SephiraDusktalon_GILA_BOSS_63h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sephira Dusktalon"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sephira Dusktalon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sephira Dusktalon"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_64h] Winslow Tobtock (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>His tricks will leave you both in a daze.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49001
		// - 793 = 1699
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WinslowTobtock_GILA_BOSS_64h()
		{
			// TODO WinslowTobtock_GILA_BOSS_64h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Winslow Tobtock"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Winslow Tobtock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Winslow Tobtock"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [GILA_BOSS_65h] Gobbles (*) - COST:0 [ATK:0/HP:10] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Every dying beast makes this dreaded carrion bird stronger.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49002
		// - 793 = 1700
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gobbles_GILA_BOSS_65h()
		{
			// TODO Gobbles_GILA_BOSS_65h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gobbles"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gobbles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gobbles"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [GILA_BOSS_66h] The Mute (*) - COST:0 [ATK:0/HP:25] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>. . .</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49209
		// - 793 = 1714
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMute_GILA_BOSS_66h()
		{
			// TODO TheMute_GILA_BOSS_66h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Mute"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Mute"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Mute"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_67h] Ratcatcher Hannigul (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Rats aren't always the most loyal pets.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49352
		// - 793 = 1719
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RatcatcherHannigul_GILA_BOSS_67h()
		{
			// TODO RatcatcherHannigul_GILA_BOSS_67h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ratcatcher Hannigul"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ratcatcher Hannigul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ratcatcher Hannigul"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [GILA_BOSS_68h] Plaguemaster Rancel (*) - COST:0 [ATK:0/HP:40] 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <i>Dying to his touch is terrible. Living is even_worse.</i>
		// --------------------------------------------------------
		// Entourage: GILA_BOSS_68t
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 49683
		// - 793 = 1769
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlaguemasterRancel_GILA_BOSS_68h()
		{
			// TODO PlaguemasterRancel_GILA_BOSS_68h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plaguemaster Rancel"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plaguemaster Rancel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plaguemaster Rancel"));
		}

	}

	public class HeroPowersGilneasTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_400p] Dog Whistle (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Bloodhound with <b>Rush</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DogWhistle_GILA_400p()
		{
			// TODO DogWhistle_GILA_400p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dog Whistle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dog Whistle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dog Whistle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_500p2] Scavenge (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       <b>Discover</b> a class spell
		//       that has been played
		//       this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HAND_NOT_FULL = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Scavenge_GILA_500p2()
		{
			// TODO Scavenge_GILA_500p2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scavenge"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scavenge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scavenge"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_600p] Fire! (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Fire your Cannons!
		//       If they kill any minions, refresh this.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_EXACT_COST = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fire_GILA_600p()
		{
			// TODO Fire_GILA_600p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_900p] Temporal Loop (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Start your turn over.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TemporalLoop_GILA_900p()
		{
			// TODO TemporalLoop_GILA_900p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temporal Loop"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temporal Loop"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temporal Loop"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_20p] Guttural Howl (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a random minion in your hand +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GutturalHowl_GILA_BOSS_20p()
		{
			// TODO GutturalHowl_GILA_BOSS_20p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Guttural Howl"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Guttural Howl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Guttural Howl"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_21p] Fading Bite (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Gain +2_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FadingBite_GILA_BOSS_21p()
		{
			// TODO FadingBite_GILA_BOSS_21p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fading Bite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fading Bite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fading Bite"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_22p] Shank (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage to a minion. Draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shank_GILA_BOSS_22p()
		{
			// TODO Shank_GILA_BOSS_22p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shank"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shank"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shank"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_23p] Chuck (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a friendly minion and deal its Attack to the enemy hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chuck_GILA_BOSS_23p()
		{
			// TODO Chuck_GILA_BOSS_23p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chuck"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chuck"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chuck"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_24p] From the Swamp (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever an enemy dies, raise a 1/3 Bloated Zombie.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FromTheSwamp_GILA_BOSS_24p()
		{
			// TODO FromTheSwamp_GILA_BOSS_24p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("From the Swamp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("From the Swamp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "From the Swamp"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_25p] Trap Preparation (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a random <b>Secret</b> from your deck into the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrapPreparation_GILA_BOSS_25p()
		{
			// TODO TrapPreparation_GILA_BOSS_25p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trap Preparation"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trap Preparation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trap Preparation"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_26p] Nab (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put an enemy minion into a sack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nab_GILA_BOSS_26p()
		{
			// TODO Nab_GILA_BOSS_26p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nab"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nab"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nab"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_27p] Consume (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power:</b>
		//       Destroy a friendly minion, then draw 3 cards.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Consume_GILA_BOSS_27p()
		{
			// TODO Consume_GILA_BOSS_27p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Consume"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Consume"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Consume"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_29p] Infatuation (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain control of enemy minions with 1 or less Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Infatuation_GILA_BOSS_29p()
		{
			// TODO Infatuation_GILA_BOSS_29p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Infatuation"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infatuation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Infatuation"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_30p] Blood Red Apple (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Spells cost Health instead of Mana.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodRedApple_GILA_BOSS_30p()
		{
			// TODO BloodRedApple_GILA_BOSS_30p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Red Apple"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Red Apple"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Red Apple"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_31p] Splinter (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Take 2 damage.
		//       Summon a 2/2 Treant.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Splinter_GILA_BOSS_31p()
		{
			// TODO Splinter_GILA_BOSS_31p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splinter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splinter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Splinter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_32p] Unstable Growth (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give all minions +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstableGrowth_GILA_BOSS_32p()
		{
			// TODO UnstableGrowth_GILA_BOSS_32p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Growth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Growth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Growth"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_33p] Harvest (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a friendly minion. Restore 8_Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 43128
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_GILA_BOSS_33p()
		{
			// TODO Harvest_GILA_BOSS_33p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_34p] Devour Soul (*) - COST:4 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Halve the enemy hero's Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DevourSoul_GILA_BOSS_34p()
		{
			// TODO DevourSoul_GILA_BOSS_34p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devour Soul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devour Soul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Devour Soul"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_35p] Bloodthirst (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a friendly minion <b>Lifesteal</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodthirst_GILA_BOSS_35p()
		{
			// TODO Bloodthirst_GILA_BOSS_35p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodthirst"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodthirst"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodthirst"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_36p] Witch's Kiss (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Tranform a random minion into a 0/1 Frog with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WitchsKiss_GILA_BOSS_36p()
		{
			// TODO WitchsKiss_GILA_BOSS_36p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witch's Kiss"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witch's Kiss"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witch's Kiss"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_37p] It's Raining Fin (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 3 Murlocs from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ItsRainingFin_GILA_BOSS_37p()
		{
			// TODO ItsRainingFin_GILA_BOSS_37p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("It's Raining Fin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("It's Raining Fin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "It's Raining Fin"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_38p] Call of the Raven (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random 1-Cost minion to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallOfTheRaven_GILA_BOSS_38p()
		{
			// TODO CallOfTheRaven_GILA_BOSS_38p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call of the Raven"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call of the Raven"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call of the Raven"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_39p] Together Forever (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a friendly minion dies, shuffle a copy into your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TogetherForever_GILA_BOSS_39p()
		{
			// TODO TogetherForever_GILA_BOSS_39p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Together Forever"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Together Forever"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Together Forever"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_40p] Grafted Bark (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Choose a minion. Add a 2/2 copy to your hand that costs (2).
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GraftedBark_GILA_BOSS_40p()
		{
			// TODO GraftedBark_GILA_BOSS_40p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grafted Bark"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grafted Bark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grafted Bark"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_41p] Survival of the Fittest (*) - COST:3 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       All minions attack random enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 75
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SurvivalOfTheFittest_GILA_BOSS_41p()
		{
			// TODO SurvivalOfTheFittest_GILA_BOSS_41p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Survival of the Fittest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Survival of the Fittest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Survival of the Fittest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_42p] Bulldoze (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Spend all your armor. Deal that much damage to a random minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bulldoze_GILA_BOSS_42p()
		{
			// TODO Bulldoze_GILA_BOSS_42p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bulldoze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bulldoze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bulldoze"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_43p] Grave Mistake (*) - COST:3 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Trigger all minions' <b>Deathrattles</b> twice.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GraveMistake_GILA_BOSS_43p()
		{
			// TODO GraveMistake_GILA_BOSS_43p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grave Mistake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grave Mistake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grave Mistake"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_44p] Hollow Needle (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage to a minion. If it dies, restore #3 Health to your hero. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HollowNeedle_GILA_BOSS_44p()
		{
			// TODO HollowNeedle_GILA_BOSS_44p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hollow Needle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hollow Needle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hollow Needle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_45p] Poisoned Drink (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Whenever a player
		//       draws a card, deal 1
		//       damage to them.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedDrink_GILA_BOSS_45p()
		{
			// TODO PoisonedDrink_GILA_BOSS_45p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poisoned Drink"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poisoned Drink"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poisoned Drink"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_46p] Monstrous Aura (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your minions have +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MonstrousAura_GILA_BOSS_46p()
		{
			// TODO MonstrousAura_GILA_BOSS_46p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Monstrous Aura"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Monstrous Aura"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Monstrous Aura"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_47p] Frumiousity (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All <b>Battlecries</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Frumiousity_GILA_BOSS_47p()
		{
			// TODO Frumiousity_GILA_BOSS_47p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frumiousity"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frumiousity"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frumiousity"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_48p] Chronoacceleration (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Give a friendly minion
		//       <b>Mega-Windfury</b>. At the
		//       end of your turn, it dies.
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 846
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chronoacceleration_GILA_BOSS_48p()
		{
			// TODO Chronoacceleration_GILA_BOSS_48p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chronoacceleration"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chronoacceleration"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chronoacceleration"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_49p] False Heart (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       While you control
		//       a minion, your hero
		//       is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FalseHeart_GILA_BOSS_49p()
		{
			// TODO FalseHeart_GILA_BOSS_49p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("False Heart"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("False Heart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "False Heart"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_50p] Echoes of the Witchwood (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All spells have <b>Echo</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EchoesOfTheWitchwood_GILA_BOSS_50p()
		{
			// TODO EchoesOfTheWitchwood_GILA_BOSS_50p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Echoes of the Witchwood"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Echoes of the Witchwood"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Echoes of the Witchwood"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_51p] Death and Taxes (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to your opponent for each minion they control.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathAndTaxes_GILA_BOSS_51p()
		{
			// TODO DeathAndTaxes_GILA_BOSS_51p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Death and Taxes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death and Taxes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Death and Taxes"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_52p] Soot Up (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a friendly minion <b>Stealth</b> until your next turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SootUp_GILA_BOSS_52p()
		{
			// TODO SootUp_GILA_BOSS_52p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soot Up"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soot Up"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soot Up"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_52p2] Beast Within (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your minions +1_Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeastWithin_GILA_BOSS_52p2()
		{
			// TODO BeastWithin_GILA_BOSS_52p2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beast Within"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beast Within"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beast Within"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_54p] One with the Trees (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Reduce the cost of minions in your hand by (1).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OneWithTheTrees_GILA_BOSS_54p()
		{
			// TODO OneWithTheTrees_GILA_BOSS_54p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("One with the Trees"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("One with the Trees"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "One with the Trees"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_55p] Unfinished Business (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon three 1/1 Wisps.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnfinishedBusiness_GILA_BOSS_55p()
		{
			// TODO UnfinishedBusiness_GILA_BOSS_55p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unfinished Business"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unfinished Business"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unfinished Business"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_56p] A New Face (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Transform a minion into a random one that costs (2) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ANewFace_GILA_BOSS_56p()
		{
			// TODO ANewFace_GILA_BOSS_56p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("A New Face"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("A New Face"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "A New Face"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_57p] Desecrate (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage to all minions. If any die, refresh this. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Desecrate_GILA_BOSS_57p()
		{
			// TODO Desecrate_GILA_BOSS_57p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desecrate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desecrate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Desecrate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_58p] Terrify (*) - COST:4 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Shuffle a minion into
		//       its owner's deck.
		//       It costs (4) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Terrify_GILA_BOSS_58p()
		{
			// TODO Terrify_GILA_BOSS_58p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terrify"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terrify"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terrify"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_59p] Pistol Barrage (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to a minion and the minions next to it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 858 = 2638
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PistolBarrage_GILA_BOSS_59p()
		{
			// TODO PistolBarrage_GILA_BOSS_59p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pistol Barrage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pistol Barrage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pistol Barrage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_60p] Plunder (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a weapon from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - 858 = 42763
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Plunder_GILA_BOSS_60p()
		{
			// TODO Plunder_GILA_BOSS_60p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plunder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plunder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plunder"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_62p] Cull the Meek (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a minion with the lowest Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CullTheMeek_GILA_BOSS_62p()
		{
			// TODO CullTheMeek_GILA_BOSS_62p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cull the Meek"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cull the Meek"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cull the Meek"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_63p] Tangled Wrath (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever your opponent casts a spell, draw a spell from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TangledWrath_GILA_BOSS_63p()
		{
			// TODO TangledWrath_GILA_BOSS_63p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tangled Wrath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tangled Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tangled Wrath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_64p] Hypnotize (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Each player shuffles their
		//       hand into their deck and
		//       draws that many cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hypnotize_GILA_BOSS_64p()
		{
			// TODO Hypnotize_GILA_BOSS_64p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hypnotize"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hypnotize"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hypnotize"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_65p] Starving (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a friendly Beast dies, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Starving_GILA_BOSS_65p()
		{
			// TODO Starving_GILA_BOSS_65p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Starving"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Starving"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Starving"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_66p] . . . (*) - COST:1 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Silence</b> a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void _GILA_BOSS_66p()
		{
			// TODO _GILA_BOSS_66p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName(". . ."),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(". . ."));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, ". . ."));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_67p] Cannibalism (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a minion dies, give the adjacent minions +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cannibalism_GILA_BOSS_67p()
		{
			// TODO Cannibalism_GILA_BOSS_67p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cannibalism"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cannibalism"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cannibalism"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GILA_BOSS_68p] Poison Flask (*) - COST:2 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonFlask_GILA_BOSS_68p()
		{
			// TODO PoisonFlask_GILA_BOSS_68p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Flask"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Flask"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Flask"));
		}

	}

}
