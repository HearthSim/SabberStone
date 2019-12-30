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
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Adventure
{
	public class GilneasCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ HERO - HUNTER
			// [GILA_400h] Houndmaster Shaw (*) - COST:0 [ATK:0/HP:20] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GILA_414, GILA_415, GILA_805
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48419
			// - HERO_DECK_ID = 1646
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_400h", new CardDef(new[] {"GILA_414","GILA_415","GILA_805"}, new Power
			{
				// TODO [GILA_400h] Houndmaster Shaw && Test: Houndmaster Shaw_GILA_400h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_500h3] Tess Greymane (*) - COST:0 [ATK:0/HP:20] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GILA_513, GILA_511, GILA_506
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48590
			// - HERO_DECK_ID = 1596
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_500h3", new CardDef(new[] {"GILA_513","GILA_511","GILA_506"}, new Power
			{
				// TODO [GILA_500h3] Tess Greymane && Test: Tess Greymane_GILA_500h3
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1749
			// - 960 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_500h4", new CardDef(new[] {"GILA_513","GILA_511","LOOTA_832"}, new Power
			{
				// TODO [GILA_500h4] Tess Greymane && Test: Tess Greymane_GILA_500h4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [GILA_600h] Darius Crowley (*) - COST:0 [ATK:0/HP:20] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GILA_604, GILA_603, GILA_814
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_600h", new CardDef(new[] {"GILA_604","GILA_603","GILA_814"}, new Power
			{
				// TODO [GILA_600h] Darius Crowley && Test: Darius Crowley_GILA_600h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1747
			// - 960 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_600h2", new CardDef(new[] {"GILA_603","GILA_805","GILA_607"}, new Power
			{
				// TODO [GILA_600h2] Darius Crowley && Test: Darius Crowley_GILA_600h2
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [GILA_900h] Toki, Time-Tinker (*) - COST:0 [ATK:0/HP:20] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GILA_913, GILA_813, LOOTA_825
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48553
			// - HERO_DECK_ID = 1649
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_900h", new CardDef(new[] {"GILA_913","GILA_813","LOOTA_825"}, new Power
			{
				// TODO [GILA_900h] Toki, Time-Tinker && Test: Toki, Time-Tinker_GILA_900h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1746
			// - 960 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_900h2", new CardDef(new[] {"GILA_913","GILA_813","LOOTA_825"}, new Power
			{
				// TODO [GILA_900h2] Toki, Time-Tinker && Test: Toki, Time-Tinker_GILA_900h2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_20h] A Mangy Wolf (*) - COST:0 [ATK:0/HP:15] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Unearthly howls drive the wildlife mad.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47902
			// - HERO_DECK_ID = 1594
			// - 843 = 48387
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_20h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_20h] A Mangy Wolf && Test: A Mangy Wolf_GILA_BOSS_20h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_21h] Rottooth (*) - COST:0 [ATK:0/HP:15] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Incorporeal or not, those claws hurt!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48057
			// - HERO_DECK_ID = 1608
			// - 843 = 48388
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_21h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_21h] Rottooth && Test: Rottooth_GILA_BOSS_21h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_BOSS_22h] Cutthroat Willie (*) - COST:0 [ATK:0/HP:25] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>WANTED: For doing exactly what his name suggests.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48071
			// - HERO_DECK_ID = 1614
			// - 843 = 48391
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_22h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_22h] Cutthroat Willie && Test: Cutthroat Willie_GILA_BOSS_22h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1616
			// - 843 = 48368
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_23h", new CardDef(new[] {"GILA_BOSS_23t"}, new Power
			{
				// TODO [GILA_BOSS_23h] Grubb the Swampdrinker && Test: Grubb the Swampdrinker_GILA_BOSS_23h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_24h] Groddo the Bogwarden (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Dead emerge from the swamp. It's not a pleasant scent.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48150
			// - HERO_DECK_ID = 1617
			// - 843 = 48354
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_24h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_24h] Groddo the Bogwarden && Test: Groddo the Bogwarden_GILA_BOSS_24h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [GILA_BOSS_25h] Manhunter Ivan (*) - COST:0 [ATK:0/HP:25] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Watch your step, this traitor is an expert trapper.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48180
			// - HERO_DECK_ID = 1618
			// - 843 = 48375
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_25h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_25h] Manhunter Ivan && Test: Manhunter Ivan_GILA_BOSS_25h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1620
			// - 843 = 48264
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_26h", new CardDef(new[] {"GILA_BOSS_26t2"}, new Power
			{
				// TODO [GILA_BOSS_26h] Gnomenapper && Test: Gnomenapper_GILA_BOSS_26h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1621
			// - 843 = 48268
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_27h", new CardDef(new[] {"GILA_BOSS_27t"}, new Power
			{
				// TODO [GILA_BOSS_27h] Experiment 3C && Test: Experiment 3C_GILA_BOSS_27h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1623
			// - 843 = 48296
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_29h", new CardDef(new[] {"GILA_BOSS_29t"}, new Power
			{
				// TODO [GILA_BOSS_29h] Sazzmi Gentlehorn && Test: Sazzmi Gentlehorn_GILA_BOSS_29h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_30h] Blood Witch Gretta (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Magic is powerful in her grove… but it comes at a cost.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48302
			// - HERO_DECK_ID = 1624
			// - 843 = 48399
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_30h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_30h] Blood Witch Gretta && Test: Blood Witch Gretta_GILA_BOSS_30h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_31h] Gnarlroot (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Gnarled, twisting roots, splintering to life.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48310
			// - HERO_DECK_ID = 1625
			// - 843 = 48372
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_31h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_31h] Gnarlroot && Test: Gnarlroot_GILA_BOSS_31h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_32h] Niira the Trickster (*) - COST:0 [ATK:0/HP:25] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>She plays with wee critters… until they’re big critters.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48313
			// - HERO_DECK_ID = 1626
			// - 843 = 48383
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_32h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_32h] Niira the Trickster && Test: Niira the Trickster_GILA_BOSS_32h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1627
			// - 843 = 48318
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_33h", new CardDef(new[] {"GILA_BOSS_33t"}, new Power
			{
				// TODO [GILA_BOSS_33h] The Scarecrow && Test: The Scarecrow_GILA_BOSS_33h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [GILA_BOSS_34h] Inquisitor Hav'nixx (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>A mind is a terrible thing to waste. It's far too delicious.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48323
			// - HERO_DECK_ID = 1628
			// - 843 = 48352
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_34h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_34h] Inquisitor Hav'nixx && Test: Inquisitor Hav'nixx_GILA_BOSS_34h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1629
			// - 843 = 48329
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_35h", new CardDef(new[] {"GILA_BOSS_35t"}, new Power
			{
				// TODO [GILA_BOSS_35h] Chupacabran && Test: Chupacabran_GILA_BOSS_35h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [GILA_BOSS_36h] Griselda (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Watch those lips, she'll kiss just about anything.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48336
			// - HERO_DECK_ID = 1640
			// - 843 = 48335
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_36h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_36h] Griselda && Test: Griselda_GILA_BOSS_36h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1639
			// - 843 = 48330
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_37h", new CardDef(new[] {"GILA_BOSS_37t"}, new Power
			{
				// TODO [GILA_BOSS_37h] Wharrgarbl && Test: Wharrgarbl_GILA_BOSS_37h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [GILA_BOSS_38h] Ravencaller Cozzlewurt (*) - COST:0 [ATK:0/HP:15] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>The feathered fiends of Gilneas flock to his sinister call.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48579
			// - HERO_DECK_ID = 1653
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_38h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_38h] Ravencaller Cozzlewurt && Test: Ravencaller Cozzlewurt_GILA_BOSS_38h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [GILA_BOSS_39h] Forlorn Lovers (*) - COST:0 [ATK:0/HP:70] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Bound by vows, she just won't let go.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48591
			// - HERO_DECK_ID = 1654
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_39h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_39h] Forlorn Lovers && Test: Forlorn Lovers_GILA_BOSS_39h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_40h] Splintergraft (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>She'll take a piece of you and make it her own.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48595
			// - HERO_DECK_ID = 1680
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_40h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_40h] Splintergraft && Test: Splintergraft_GILA_BOSS_40h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [GILA_BOSS_41h] Brushwood Centurion (*) - COST:0 [ATK:0/HP:60] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>This once-stalwart defender of the woods now sows chaos.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48597
			// - HERO_DECK_ID = 1655
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_41h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_41h] Brushwood Centurion && Test: Brushwood Centurion_GILA_BOSS_41h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [GILA_BOSS_42h] Baran the Blind (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Poor vision doesn't matter with strength like his.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48603
			// - HERO_DECK_ID = 1656
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_42h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_42h] Baran the Blind && Test: Baran the Blind_GILA_BOSS_42h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1657
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_43h", new CardDef(new[] {"GILA_BOSS_43t"}, new Power
			{
				// TODO [GILA_BOSS_43h] Gravekeeper Damph && Test: Gravekeeper Damph_GILA_BOSS_43h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_44h] Doctor Sezavo (*) - COST:0 [ATK:0/HP:20] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>It’s good to give blood. But not to him. He’s not a real doctor.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48623
			// - HERO_DECK_ID = 1658
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_44h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_44h] Doctor Sezavo && Test: Doctor Sezavo_GILA_BOSS_44h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_45h] Cultist S'thara (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>A silver tongue to accompany her silver daggers.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48633
			// - HERO_DECK_ID = 1662
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_45h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_45h] Cultist S'thara && Test: Cultist S'thara_GILA_BOSS_45h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [GILA_BOSS_46h] Vitus the Exiled (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Corrupted. Banished. Hungry.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48729
			// - HERO_DECK_ID = 1665
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_46h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_46h] Vitus the Exiled && Test: Vitus the Exiled_GILA_BOSS_46h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1666
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_47h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_47h] Shudderwock && Test: Shudderwock_GILA_BOSS_47h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [GILA_BOSS_48h] Infinite Toki (*) - COST:0 [ATK:0/HP:60] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>One either dies a hero or mangles time enough to become a villain.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48763
			// - HERO_DECK_ID = 1667
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_48h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_48h] Infinite Toki && Test: Infinite Toki_GILA_BOSS_48h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_49h] Glinda Crowskin (*) - COST:0 [ATK:0/HP:50] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>The leader of Hagatha’s dark cult hides behind her loyal minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48791
			// - HERO_DECK_ID = 1668
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_49h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_49h] Glinda Crowskin && Test: Glinda Crowskin_GILA_BOSS_49h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_BOSS_50h] The Whisperer (*) - COST:0 [ATK:0/HP:25] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Do you hear the echoes of his whispers?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48813
			// - HERO_DECK_ID = 1670
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_50h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_50h] The Whisperer && Test: The Whisperer_GILA_BOSS_50h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_BOSS_51h] Garrow, the Rancorous (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Missing? Dead? He'll still collect.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48869
			// - HERO_DECK_ID = 1681
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_51h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_51h] Garrow, the Rancorous && Test: Garrow, the Rancorous_GILA_BOSS_51h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1683
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_52h] Crooked Pete && Test: Crooked Pete_GILA_BOSS_52h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_BOSS_52h2] Beastly Pete (*) - COST:0 [ATK:0/HP:50] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48872
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52h2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_52h2] Beastly Pete && Test: Beastly Pete_GILA_BOSS_52h2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_54h] Cragtorr (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Seeds sewn from hatred, sustained by dark magic.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48935
			// - HERO_DECK_ID = 1692
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_54h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_54h] Cragtorr && Test: Cragtorr_GILA_BOSS_54h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1693
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_55h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_55h] Azalina Soulthief && Test: Azalina Soulthief_GILA_BOSS_55h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1621
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_56h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_56h] Face Collector && Test: Face Collector_GILA_BOSS_56h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1696
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_57h", new CardDef(new[] {"GILA_BOSS_57t"}, new Power
			{
				// TODO [GILA_BOSS_57h] Raeth Ghostsong && Test: Raeth Ghostsong_GILA_BOSS_57h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [GILA_BOSS_58h] Grum (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Grum likes to smash. He also likes to bash. And crash.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48946
			// - HERO_DECK_ID = 1701
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_58h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_58h] Grum && Test: Grum_GILA_BOSS_58h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [GILA_BOSS_59h] Lord Godfrey (*) - COST:0 [ATK:0/HP:60] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>The Lord of Shadowfang Keep has a bullet to pick with Crowley.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48948
			// - HERO_DECK_ID = 1728
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_59h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_59h] Lord Godfrey && Test: Lord Godfrey_GILA_BOSS_59h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [GILA_BOSS_60h] Captain Shivers (*) - COST:0 [ATK:0/HP:75] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Vowing vengeance, his cursed crew haunts Gilnean shores.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48952
			// - HERO_DECK_ID = 1729
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_60h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_60h] Captain Shivers && Test: Captain Shivers_GILA_BOSS_60h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [GILA_BOSS_61h] Hagatha the Witch (*) - COST:0 [ATK:0/HP:100] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 47631
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_61h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_61h] Hagatha the Witch && Test: Hagatha the Witch_GILA_BOSS_61h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [GILA_BOSS_62h] Gustave, the Gutripper (*) - COST:0 [ATK:0/HP:50] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Hagatha’s pet eats his way from the bottom of the food chain up.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 48999
			// - HERO_DECK_ID = 1697
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_62h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_62h] Gustave, the Gutripper && Test: Gustave, the Gutripper_GILA_BOSS_62h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [GILA_BOSS_63h] Sephira Dusktalon (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Even your own magic can be twisted by these woods.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49000
			// - HERO_DECK_ID = 1698
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_63h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_63h] Sephira Dusktalon && Test: Sephira Dusktalon_GILA_BOSS_63h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [GILA_BOSS_64h] Winslow Tobtock (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>His tricks will leave you both in a daze.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49001
			// - HERO_DECK_ID = 1699
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_64h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_64h] Winslow Tobtock && Test: Winslow Tobtock_GILA_BOSS_64h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [GILA_BOSS_65h] Gobbles (*) - COST:0 [ATK:0/HP:10] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Every dying beast makes this dreaded carrion bird stronger.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49002
			// - HERO_DECK_ID = 1700
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_65h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_65h] Gobbles && Test: Gobbles_GILA_BOSS_65h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [GILA_BOSS_66h] The Mute (*) - COST:0 [ATK:0/HP:25] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>. . .</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49209
			// - HERO_DECK_ID = 1714
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_66h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_66h] The Mute && Test: The Mute_GILA_BOSS_66h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [GILA_BOSS_67h] Ratcatcher Hannigul (*) - COST:0 [ATK:0/HP:40] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <i>Rats aren't always the most loyal pets.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 49352
			// - HERO_DECK_ID = 1719
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_67h", new CardDef(new Power
			{
				// TODO [GILA_BOSS_67h] Ratcatcher Hannigul && Test: Ratcatcher Hannigul_GILA_BOSS_67h
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HERO_DECK_ID = 1769
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_68h", new CardDef(new[] {"GILA_BOSS_68t"}, new Power
			{
				// TODO [GILA_BOSS_68h] Plaguemaster Rancel && Test: Plaguemaster Rancel_GILA_BOSS_68h
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_400p] Dog Whistle (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Bloodhound with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_400p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_400p] Dog Whistle && Test: Dog Whistle_GILA_400p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_500p2] Scavenge (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       <b>Discover</b> a class spell
			//       that has been played
			//       this game.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("GILA_500p2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [GILA_500p2] Scavenge && Test: Scavenge_GILA_500p2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_600p] Fire! (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Fire your Cannons!
			//       If they kill any minions, refresh this.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_EXACT_COST = 0
			// --------------------------------------------------------
			cards.Add("GILA_600p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_EXACT_COST,0}}, new Power
			{
				// TODO [GILA_600p] Fire! && Test: Fire!_GILA_600p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_900p] Temporal Loop (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Start your turn over.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_900p", new CardDef(new Power
			{
				// TODO [GILA_900p] Temporal Loop && Test: Temporal Loop_GILA_900p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_20p] Guttural Howl (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_20p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_20p] Guttural Howl && Test: Guttural Howl_GILA_BOSS_20p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_21p] Fading Bite (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Gain +2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_21p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_21p] Fading Bite && Test: Fading Bite_GILA_BOSS_21p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_22p] Shank (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage to a minion. Draw a card. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_22p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_22p] Shank && Test: Shank_GILA_BOSS_22p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_23p] Chuck (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a friendly minion and deal its Attack to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_23p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_23p] Chuck && Test: Chuck_GILA_BOSS_23p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_24p] From the Swamp (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever an enemy dies, raise a 1/3 Bloated Zombie.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_24p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_24p] From the Swamp && Test: From the Swamp_GILA_BOSS_24p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_25p] Trap Preparation (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a random <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_25p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET,0}}, new Power
			{
				// TODO [GILA_BOSS_25p] Trap Preparation && Test: Trap Preparation_GILA_BOSS_25p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_26p] Nab (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put an enemy minion into a sack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_26p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_26p] Nab && Test: Nab_GILA_BOSS_26p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_27p] Consume (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a friendly minion, then draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_27p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_27p] Consume && Test: Consume_GILA_BOSS_27p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_29p] Infatuation (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain control of enemy minions with 1 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_29p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_BOSS_29p] Infatuation && Test: Infatuation_GILA_BOSS_29p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_30p] Blood Red Apple (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_30p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_30p] Blood Red Apple && Test: Blood Red Apple_GILA_BOSS_30p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_31p] Splinter (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Take 2 damage.
			//       Summon a 2/2 Treant.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_31p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_BOSS_31p] Splinter && Test: Splinter_GILA_BOSS_31p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_32p] Unstable Growth (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_32p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_32p] Unstable Growth && Test: Unstable Growth_GILA_BOSS_32p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_33p] Harvest (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a friendly minion. Restore #8_Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43128
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_33p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_33p] Harvest && Test: Harvest_GILA_BOSS_33p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_34p] Devour Soul (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Halve the enemy hero's Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_34p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_34p] Devour Soul && Test: Devour Soul_GILA_BOSS_34p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_35p] Bloodthirst (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_35p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_35p] Bloodthirst && Test: Bloodthirst_GILA_BOSS_35p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_36p] Witch's Kiss (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Transform a random minion into a 0/1 Frog with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_36p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [GILA_BOSS_36p] Witch's Kiss && Test: Witch's Kiss_GILA_BOSS_36p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_37p] It's Raining Fin (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw 3 Murlocs from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_37p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_37p] It's Raining Fin && Test: It's Raining Fin_GILA_BOSS_37p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_38p] Call of the Raven (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random 1-Cost minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_38p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_38p] Call of the Raven && Test: Call of the Raven_GILA_BOSS_38p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_39p] Together Forever (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a friendly minion dies, shuffle a copy into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_39p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_39p] Together Forever && Test: Together Forever_GILA_BOSS_39p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_40p] Grafted Bark (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Choose a minion. Add a 2/2 copy to your hand that costs (2).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_40p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_40p] Grafted Bark && Test: Grafted Bark_GILA_BOSS_40p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_41p] Survival of the Fittest (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       All minions attack random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 75
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_41p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_41p] Survival of the Fittest && Test: Survival of the Fittest_GILA_BOSS_41p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_42p] Bulldoze (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Spend all your armor. Deal that much damage to a random minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_42p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_42p] Bulldoze && Test: Bulldoze_GILA_BOSS_42p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_43p] Grave Mistake (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Trigger all minions' <b>Deathrattles</b> twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_43p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_43p] Grave Mistake && Test: Grave Mistake_GILA_BOSS_43p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_44p] Hollow Needle (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage to a minion. If it dies, restore #3 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_44p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [GILA_BOSS_44p] Hollow Needle && Test: Hollow Needle_GILA_BOSS_44p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_45p] Poisoned Drink (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Whenever a player
			//       draws a card, deal 1
			//       damage to them.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_45p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_45p] Poisoned Drink && Test: Poisoned Drink_GILA_BOSS_45p
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_46p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_46p] Monstrous Aura && Test: Monstrous Aura_GILA_BOSS_46p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_47p] Frumiousity (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_47p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_47p] Frumiousity && Test: Frumiousity_GILA_BOSS_47p
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_48p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_48p] Chronoacceleration && Test: Chronoacceleration_GILA_BOSS_48p
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_49p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_49p] False Heart && Test: False Heart_GILA_BOSS_49p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_50p] Echoes of the Witchwood (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All spells have <b>Echo</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_50p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_50p] Echoes of the Witchwood && Test: Echoes of the Witchwood_GILA_BOSS_50p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_51p] Death and Taxes (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to your opponent for each minion they control.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_51p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_51p] Death and Taxes && Test: Death and Taxes_GILA_BOSS_51p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_52p] Soot Up (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_52p] Soot Up && Test: Soot Up_GILA_BOSS_52p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_52p2] Beast Within (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your minions +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52p2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_52p2] Beast Within && Test: Beast Within_GILA_BOSS_52p2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_54p] One with the Trees (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Reduce the cost of minions in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_54p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_54p] One with the Trees && Test: One with the Trees_GILA_BOSS_54p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_55p] Unfinished Business (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon three 1/1 Wisps.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_55p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_55p] Unfinished Business && Test: Unfinished Business_GILA_BOSS_55p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_56p] A New Face (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Transform a minion into a random one that costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_56p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_56p] A New Face && Test: A New Face_GILA_BOSS_56p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_57p] Desecrate (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage to all minions. If any die, refresh this. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_57p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_57p] Desecrate && Test: Desecrate_GILA_BOSS_57p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_58p] Terrify (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Shuffle a minion into
			//       its owner's deck.
			//       It costs (4) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_58p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_58p] Terrify && Test: Terrify_GILA_BOSS_58p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_59p] Pistol Barrage (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to a minion and the minions next to it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2638
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_59p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_59p] Pistol Barrage && Test: Pistol Barrage_GILA_BOSS_59p
				//PowerTask = null,
				//Trigger = null,
			}));

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
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_60p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_60p] Plunder && Test: Plunder_GILA_BOSS_60p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_62p] Cull the Meek (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a minion with the lowest Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_62p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_62p] Cull the Meek && Test: Cull the Meek_GILA_BOSS_62p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_63p] Tangled Wrath (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever your opponent casts a spell, draw a spell from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_63p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_63p] Tangled Wrath && Test: Tangled Wrath_GILA_BOSS_63p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_64p] Hypnotize (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Each player shuffles their
			//       hand into their deck and
			//       draws that many cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_64p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_64p] Hypnotize && Test: Hypnotize_GILA_BOSS_64p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_65p] Starving (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a friendly Beast dies, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_65p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_65p] Starving && Test: Starving_GILA_BOSS_65p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_66p] . . . (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_66p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_66p] . . . && Test: . . ._GILA_BOSS_66p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_67p] Cannibalism (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a minion dies, give the adjacent minions +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_67p", new CardDef(new Power
			{
				// TODO [GILA_BOSS_67p] Cannibalism && Test: Cannibalism_GILA_BOSS_67p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GILA_BOSS_68p] Poison Flask (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_68p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_68p] Poison Flask && Test: Poison Flask_GILA_BOSS_68p
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [GILA_BOSS_21e] Fangs (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your hero has +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_21e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_21e] Fangs && Test: Fangs_GILA_BOSS_21e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_21e")
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_01] Chaos (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: KAR_009, UNG_846, AT_007, CFM_619, LOOT_537, LOE_003, BRM_030, OG_134, LOOT_104, UNG_028, UNG_941, OG_090
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_01", new CardDef(new[] {"KAR_009","UNG_846","AT_007","CFM_619","LOOT_537","LOE_003","BRM_030","OG_134","LOOT_104","UNG_028","UNG_941","OG_090"}, new Power
			{
				// TODO [GILA_Toki_01] Chaos && Test: Chaos_GILA_Toki_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_02] Wild Magic (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: ICC_836, EX1_277, GVG_001, KAR_076, CFM_623, AT_009, GVG_003, LOOT_106, GIL_147, GIL_664
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_02", new CardDef(new[] {"ICC_836","EX1_277","GVG_001","KAR_076","CFM_623","AT_009","GVG_003","LOOT_106","GIL_147","GIL_664"}, new Power
			{
				// TODO [GILA_Toki_02] Wild Magic && Test: Wild Magic_GILA_Toki_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_03] Erratic Creatures (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GVG_108, NEW1_019, CFM_790, EX1_085, UNG_075, CFM_649, GIL_213, LOOT_347, UNG_072, EX1_083, OG_207, AT_118, EX1_112, UNG_088
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_03", new CardDef(new[] {"GVG_108","NEW1_019","CFM_790","EX1_085","UNG_075","CFM_649","GIL_213","LOOT_347","UNG_072","EX1_083","OG_207","AT_118","EX1_112","UNG_088"}, new Power
			{
				// TODO [GILA_Toki_03] Erratic Creatures && Test: Erratic Creatures_GILA_Toki_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_04] Frosty (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GVG_002, CS2_033, UNG_079, ICC_838, ICC_836, CS2_031, CS2_024, GIL_801, EX1_289, CS2_026, EX1_275, CS2_028, EX1_295
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_04", new CardDef(new[] {"GVG_002","CS2_033","UNG_079","ICC_838","ICC_836","CS2_031","CS2_024","GIL_801","EX1_289","CS2_026","EX1_275","CS2_028","EX1_295"}, new Power
			{
				// TODO [GILA_Toki_04] Frosty && Test: Frosty_GILA_Toki_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_05] Legends (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: CFM_807, GVG_119, EX1_016, EX1_559, GVG_118, ICC_314, FP1_013, LOOT_357, GVG_116, EX1_572, OG_042
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_05", new CardDef(new[] {"CFM_807","GVG_119","EX1_016","EX1_559","GVG_118","ICC_314","FP1_013","LOOT_357","GVG_116","EX1_572","OG_042"}, new Power
			{
				// TODO [GILA_Toki_05] Legends && Test: Legends_GILA_Toki_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_06] Knowledge (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: EX1_096, EX1_015, EX1_012, EX1_557, EX1_050, CS2_147, EX1_284, GIL_640, EX1_095, GIL_548, CS2_023, LOOT_108
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_06", new CardDef(new[] {"EX1_096","EX1_015","EX1_012","EX1_557","EX1_050","CS2_147","EX1_284","GIL_640","EX1_095","GIL_548","CS2_023","LOOT_108"}, new Power
			{
				// TODO [GILA_Toki_06] Knowledge && Test: Knowledge_GILA_Toki_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_07] Elementalist (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: UNG_809, UNG_027, UNG_846, UNG_928, LOOT_537, UNG_070, UNG_816, UNG_816, UNG_847, EX1_298, LOOT_103, CFM_065, CS2_029
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_07", new CardDef(new[] {"UNG_809","UNG_027","UNG_846","UNG_928","LOOT_537","UNG_070","UNG_816","UNG_816","UNG_847","EX1_298","LOOT_103","CFM_065","CS2_029"}, new Power
			{
				// TODO [GILA_Toki_07] Elementalist && Test: Elementalist_GILA_Toki_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_08] Magical Friends (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: LOOT_231, NEW1_012, EX1_608, GIL_664, BRM_002, NEW1_026, ICC_069, LOE_086, LOOT_539, EX1_559, KAR_711, CS2_027, ICC_823, UNG_948, GVG_005
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_08", new CardDef(new[] {"LOOT_231","NEW1_012","EX1_608","GIL_664","BRM_002","NEW1_026","ICC_069","LOE_086","LOOT_539","EX1_559","KAR_711","CS2_027","ICC_823","UNG_948","GVG_005"}, new Power
			{
				// TODO [GILA_Toki_08] Magical Friends && Test: Magical Friends_GILA_Toki_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_09] Lost Secrets (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: KAR_092, FP1_004, UNG_020, EX1_274, GIL_116, CFM_760, FP1_018, ICC_082, EX1_295, EX1_294, EX1_287, UNG_024, EX1_594, FP1_004
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_09", new CardDef(new[] {"KAR_092","FP1_004","UNG_020","EX1_274","GIL_116","CFM_760","FP1_018","ICC_082","EX1_295","EX1_294","EX1_287","UNG_024","EX1_594","FP1_004"}, new Power
			{
				// TODO [GILA_Toki_09] Lost Secrets && Test: Lost Secrets_GILA_Toki_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_10] Mechanical (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GVG_002, GVG_004, GVG_085, GVG_006, GVG_103, EX1_556, LOE_039, GVG_096, GVG_069, GVG_111, OG_145, GVG_105, GVG_114, GVG_117
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_10", new CardDef(new[] {"GVG_002","GVG_004","GVG_085","GVG_006","GVG_103","EX1_556","LOE_039","GVG_096","GVG_069","GVG_111","OG_145","GVG_105","GVG_114","GVG_117"}, new Power
			{
				// TODO [GILA_Toki_10] Mechanical && Test: Mechanical_GILA_Toki_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [GILA_Toki_11] BOOM! (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: LOOT_231, LOOT_170, UNG_928, LOOT_539, GVG_110, KAR_097, LOOT_535, LOOT_172, LOOT_106, CS2_028, UNG_955, KAR_076, CS2_032, EX1_279
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Toki_11", new CardDef(new[] {"LOOT_231","LOOT_170","UNG_928","LOOT_539","GVG_110","KAR_097","LOOT_535","LOOT_172","LOOT_106","CS2_028","UNG_955","KAR_076","CS2_032","EX1_279"}, new Power
			{
				// TODO [GILA_Toki_11] BOOM! && Test: BOOM!_GILA_Toki_11
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_01] Berserker (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: EX1_604, OG_218, BRM_019, ICC_405, GIL_152, FP1_021, OG_318, EX1_007, EX1_400, EX1_392, ICC_064, OG_149
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_01", new CardDef(new[] {"EX1_604","OG_218","BRM_019","ICC_405","GIL_152","FP1_021","OG_318","EX1_007","EX1_400","EX1_392","ICC_064","OG_149"}, new Power
			{
				// TODO [GILA_Darius_01] Berserker && Test: Berserker_GILA_Darius_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_02] Pirates (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: OG_312, CFM_637, NEW1_018, OG_315, NEW1_027, AT_070, CFM_631, GVG_075, NEW1_022, ICC_018, NEW1_024, AT_070, OG_033
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_02", new CardDef(new[] {"OG_312","CFM_637","NEW1_018","OG_315","NEW1_027","AT_070","CFM_631","GVG_075","NEW1_022","ICC_018","NEW1_024","AT_070","OG_033"}, new Power
			{
				// TODO [GILA_Darius_02] Pirates && Test: Pirates_GILA_Darius_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_03] Tactical (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GIL_683, CS2_108, EX1_407, BRM_026, GIL_655, LOOT_154, EX1_391, GVG_052, OG_314, UNG_926, LOOT_383, AT_085
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_03", new CardDef(new[] {"GIL_683","CS2_108","EX1_407","BRM_026","GIL_655","LOOT_154","EX1_391","GVG_052","OG_314","UNG_926","LOOT_383","AT_085"}, new Power
			{
				// TODO [GILA_Darius_03] Tactical && Test: Tactical_GILA_Darius_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_04] Attack! (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: GIL_155, GIL_113, GIL_803, GIL_682, GIL_202, EX1_414, NEW1_011, GIL_528, EX1_116, GIL_578, GIL_653
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_04", new CardDef(new[] {"GIL_155","GIL_113","GIL_803","GIL_682","GIL_202","EX1_414","NEW1_011","GIL_528","EX1_116","GIL_578","GIL_653"}, new Power
			{
				// TODO [GILA_Darius_04] Attack! && Test: Attack!_GILA_Darius_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_05] Vanguard (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: FP1_012, UNG_848, OG_218, FP1_024, CFM_756, LOE_009, UNG_957, ICC_314, LOE_022, CFM_940, AT_065, UNG_072
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_05", new CardDef(new[] {"FP1_012","UNG_848","OG_218","FP1_024","CFM_756","LOE_009","UNG_957","ICC_314","LOE_022","CFM_940","AT_065","UNG_072"}, new Power
			{
				// TODO [GILA_Darius_05] Vanguard && Test: Vanguard_GILA_Darius_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_06] Armory (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: EX1_402, CFM_756, GVG_053, AT_064, KAR_091, EX1_606, LOOT_367, ICC_837, KAR_028, OG_220, LOOT_519, LOOT_285, ICC_062
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_06", new CardDef(new[] {"EX1_402","CFM_756","GVG_053","AT_064","KAR_091","EX1_606","LOOT_367","ICC_837","KAR_028","OG_220","LOOT_519","LOOT_285","ICC_062"}, new Power
			{
				// TODO [GILA_Darius_06] Armory && Test: Armory_GILA_Darius_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_07] Commander (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: AT_082, AT_119, AT_090, AT_099, AT_085, AT_127, EX1_392, NEW1_036, AT_080, GIL_561, AT_091, AT_100
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_07", new CardDef(new[] {"AT_082","AT_119","AT_090","AT_099","AT_085","AT_127","EX1_392","NEW1_036","AT_080","GIL_561","AT_091","AT_100"}, new Power
			{
				// TODO [GILA_Darius_07] Commander && Test: Commander_GILA_Darius_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_08] Legends (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: EX1_298, GVG_114, ICC_314, FP1_013, UNG_933, EX1_572, OG_042, LOOT_380, AT_072, EX1_016, LOE_079, AT_127, GVG_056, LOOT_357
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_08", new CardDef(new[] {"EX1_298","GVG_114","ICC_314","FP1_013","UNG_933","EX1_572","OG_042","LOOT_380","AT_072","EX1_016","LOE_079","AT_127","GVG_056","LOOT_357"}, new Power
			{
				// TODO [GILA_Darius_08] Legends && Test: Legends_GILA_Darius_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_09] Strike (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: CS2_108, EX1_407, FP1_021, EX1_411, GIL_614, CFM_716, AT_064, GIL_537, CS2_112, GIL_654, EX1_391, ICC_064
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_09", new CardDef(new[] {"CS2_108","EX1_407","FP1_021","EX1_411","GIL_614","CFM_716","AT_064","GIL_537","CS2_112","GIL_654","EX1_391","ICC_064"}, new Power
			{
				// TODO [GILA_Darius_09] Strike && Test: Strike_GILA_Darius_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_10] Warcry (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: LOE_077, EX1_046, EX1_284, GVG_099, ICC_705, OG_149, UNG_848, GIL_803, EX1_603, ICC_466, CFM_668, GVG_053
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_10", new CardDef(new[] {"LOE_077","EX1_046","EX1_284","GVG_099","ICC_705","OG_149","UNG_848","GIL_803","EX1_603","ICC_466","CFM_668","GVG_053"}, new Power
			{
				// TODO [GILA_Darius_10] Warcry && Test: Warcry_GILA_Darius_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [GILA_Darius_11] Dragonfire (*) - COST:0 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Entourage: EX1_284, UNG_848, ICC_027, ICC_029, NEW1_023, KAR_062, AT_071, AT_017, NEW1_030, OG_317, EX1_572, CFM_806, BRM_031, BRM_034
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_Darius_11", new CardDef(new[] {"EX1_284","UNG_848","ICC_027","ICC_029","NEW1_023","KAR_062","AT_071","AT_017","NEW1_030","OG_317","EX1_572","CFM_806","BRM_031","BRM_034"}, new Power
			{
				// TODO [GILA_Darius_11] Dragonfire && Test: Dragonfire_GILA_Darius_11
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_411e] Princess's Bone (*) - COST:5 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_411e", new CardDef(new Power
			{
				// TODO [GILA_411e] Princess's Bone && Test: Princess's Bone_GILA_411e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_411e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_412e] Blood Hungry (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_412e", new CardDef(new Power
			{
				// TODO [GILA_412e] Blood Hungry && Test: Blood Hungry_GILA_412e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_412e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_414e] Companionship Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_414e", new CardDef(new Power
			{
				// TODO [GILA_414e] Companionship Player Enchant && Test: Companionship Player Enchant_GILA_414e
				InfoCardId = "GILA_414e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_414e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_414e2] Companionship (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_414e2", new CardDef(new Power
			{
				// TODO [GILA_414e2] Companionship && Test: Companionship_GILA_414e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_414e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_415e] Lunar Signet Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_415e", new CardDef(new Power
			{
				// TODO [GILA_415e] Lunar Signet Player Enchant && Test: Lunar Signet Player Enchant_GILA_415e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_415e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_503e] Insightful (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: This card costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_503e", new CardDef(new Power
			{
				// TODO [GILA_503e] Insightful && Test: Insightful_GILA_503e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_503e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_506e] First Aid Kit Player Enchantment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_506e", new CardDef(new Power
			{
				// TODO [GILA_506e] First Aid Kit Player Enchantment && Test: First Aid Kit Player Enchantment_GILA_506e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_506e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_507e] Veteran's Intuition (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Spell Damage.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_507e", new CardDef(new Power
			{
				// TODO [GILA_507e] Veteran's Intuition && Test: Veteran's Intuition_GILA_507e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_507e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_511e] Sticky Fingers Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_511e", new CardDef(new Power
			{
				// TODO [GILA_511e] Sticky Fingers Player Enchant && Test: Sticky Fingers Player Enchant_GILA_511e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_511e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_513e] Cult of the Wolf Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_513e", new CardDef(new Power
			{
				// TODO [GILA_513e] Cult of the Wolf Player Enchant && Test: Cult of the Wolf Player Enchant_GILA_513e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_513e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_602e2] Victorious Rally Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_602e2", new CardDef(new Power
			{
				// TODO [GILA_602e2] Victorious Rally Player Enchant && Test: Victorious Rally Player Enchant_GILA_602e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_602e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_602e3] Strategic Initiative (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_602e3", new CardDef(new Power
			{
				// TODO [GILA_602e3] Strategic Initiative && Test: Strategic Initiative_GILA_602e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_602e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_603e2] Tactical Reinforcements Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_603e2", new CardDef(new Power
			{
				// TODO [GILA_603e2] Tactical Reinforcements Player Enchant && Test: Tactical Reinforcements Player Enchant_GILA_603e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_603e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_603e3] Inspired (*) - COST:0 [ATK:0/HP:30] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_603e3", new CardDef(new Power
			{
				// TODO [GILA_603e3] Inspired && Test: Inspired_GILA_603e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_603e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_604e2] Extra Powder Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_604e2", new CardDef(new Power
			{
				// TODO [GILA_604e2] Extra Powder Player Enchant && Test: Extra Powder Player Enchant_GILA_604e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_604e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_605e2] Dragonfire Ammo Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_605e2", new CardDef(new Power
			{
				// TODO [GILA_605e2] Dragonfire Ammo Player Enchant && Test: Dragonfire Ammo Player Enchant_GILA_605e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_605e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_607e2] Pillage the Fallen Player Enchantment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_607e2", new CardDef(new Power
			{
				// TODO [GILA_607e2] Pillage the Fallen Player Enchantment && Test: Pillage the Fallen Player Enchantment_GILA_607e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_607e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_612e] Seabreaker Goliath Player Enchantment (*) - COST:0 [ATK:15/HP:15] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (1) less for each time you've fired your Cannons.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_612e", new CardDef(new Power
			{
				// TODO [GILA_612e] Seabreaker Goliath Player Enchantment && Test: Seabreaker Goliath Player Enchantment_GILA_612e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_612e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_804e] Holy Essence (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 10.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_804e", new CardDef(new Power
			{
				// TODO [GILA_804e] Holy Essence && Test: Holy Essence_GILA_804e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_804e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_805e] Entrenchment Player Enchantment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your minions have +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_805e", new CardDef(new Power
			{
				// TODO [GILA_805e] Entrenchment Player Enchantment && Test: Entrenchment Player Enchantment_GILA_805e
				InfoCardId = "GILA_805e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_805e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_805e2] Entrenched (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_805e2", new CardDef(new Power
			{
				// TODO [GILA_805e2] Entrenched && Test: Entrenched_GILA_805e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_805e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_810e] Ambush! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_810e", new CardDef(new Power
			{
				// TODO [GILA_810e] Ambush! && Test: Ambush!_GILA_810e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_810e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_813e] Expedite Player Enchantment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your minions cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_813e", new CardDef(new Power
			{
				// TODO [GILA_813e] Expedite Player Enchantment && Test: Expedite Player Enchantment_GILA_813e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_813e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_814e] Caltrops Player Enchantment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_814e", new CardDef(new Power
			{
				// TODO [GILA_814e] Caltrops Player Enchantment && Test: Caltrops Player Enchantment_GILA_814e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_814e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_824e] Royalty (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_824e", new CardDef(new Power
			{
				// TODO [GILA_824e] Royalty && Test: Royalty_GILA_824e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_824e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_825e] Gentleman's Top Hat (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2. <b>Deathrattle</b>: Give your Top_Hat to another random friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_825e", new CardDef(new Power
			{
				// TODO [GILA_825e] Gentleman's Top Hat && Test: Gentleman's Top Hat_GILA_825e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_825e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_852ae] Morale Boost (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_852ae", new CardDef(new Power
			{
				// TODO [GILA_852ae] Morale Boost && Test: Morale Boost_GILA_852ae
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_852ae")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_852be] Rallied (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_852be", new CardDef(new Power
			{
				// TODO [GILA_852be] Rallied && Test: Rallied_GILA_852be
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_852be")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_852ce] United (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +4/+4, <b>Taunt</b>, and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_852ce", new CardDef(new Power
			{
				// TODO [GILA_852ce] United && Test: United_GILA_852ce
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_852ce")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_911e] Rewind Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_911e", new CardDef(new Power
			{
				// TODO [GILA_911e] Rewind Player Enchant && Test: Rewind Player Enchant_GILA_911e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_911e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_913e] Double Time Player Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_913e", new CardDef(new Power
			{
				// TODO [GILA_913e] Double Time Player Enchant && Test: Double Time Player Enchant_GILA_913e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_913e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_20e] Howling (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_20e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_20e] Howling && Test: Howling_GILA_BOSS_20e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_20e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_29e] Enchanted (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_29e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_29e] Enchanted && Test: Enchanted_GILA_BOSS_29e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_29e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_32e] Growing Strong (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_32e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_32e] Growing Strong && Test: Growing Strong_GILA_BOSS_32e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_32e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_33e] Unbreakable (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_33e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_33e] Unbreakable && Test: Unbreakable_GILA_BOSS_33e
				InfoCardId = "GILA_BOSS_33e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_33e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_33e2] Bloody (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_33e2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_33e2] Bloody && Test: Bloody_GILA_BOSS_33e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_33e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_35e2] Bloodthirsty (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_35e2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_35e2] Bloodthirsty && Test: Bloodthirsty_GILA_BOSS_35e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_35e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_37e2] Murloc Infestation (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle</b>: Summon a random Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_37e2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_37e2] Murloc Infestation && Test: Murloc Infestation_GILA_BOSS_37e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_37e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_40e] Petrified (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Splintergraft made this 2/2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_40e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_40e] Petrified && Test: Petrified_GILA_BOSS_40e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_40e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_46e] Empowered (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Vitus is giving this minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_46e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_46e] Empowered && Test: Empowered_GILA_BOSS_46e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_46e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_48e] Accelerated (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Mega-Windfury</b>. Will die at the end of this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_48e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_48e] Accelerated && Test: Accelerated_GILA_BOSS_48e
				InfoCardId = "GILA_BOSS_48e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_48e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_48e2] Alternate Timelines (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Number of timelines visited
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_48e2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_48e2] Alternate Timelines && Test: Alternate Timelines_GILA_BOSS_48e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_48e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_52e] Beast Mode (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_52e] Beast Mode && Test: Beast Mode_GILA_BOSS_52e
				InfoCardId = "GILA_BOSS_52e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_52e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_52e2] Covered in Soot (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>ed until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_52e2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_52e2] Covered in Soot && Test: Covered in Soot_GILA_BOSS_52e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_52e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_54e] Assimilation (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Cost reduced by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_54e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_54e] Assimilation && Test: Assimilation_GILA_BOSS_54e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_54e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_58e] Terrified (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (4) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_58e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_58e] Terrified && Test: Terrified_GILA_BOSS_58e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_58e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_61te] Spooky (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_61te", new CardDef(new Power
			{
				// TODO [GILA_BOSS_61te] Spooky && Test: Spooky_GILA_BOSS_61te
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_61te")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_67e] Mmm, so tasty! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_67e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_67e] Mmm, so tasty! && Test: Mmm, so tasty!_GILA_BOSS_67e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_67e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GILA_BOSS_68e] Dripping Poison (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_68e", new CardDef(new Power
			{
				// TODO [GILA_BOSS_68e] Dripping Poison && Test: Dripping Poison_GILA_BOSS_68e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("GILA_BOSS_68e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_400t] Bloodhound (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_400t", new CardDef(new Power
			{
				// TODO [GILA_400t] Bloodhound && Test: Bloodhound_GILA_400t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_403] Butch (*) - COST:4 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       Has +1/+1 for each
			//       friendly Beast that
			//       died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_403", new CardDef(new Power
			{
				// TODO [GILA_403] Butch && Test: Butch_GILA_403
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_410] Bubba (*) - COST:7 [ATK:9/HP:9] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Summon six 1/1 Bloodhounds to attack an enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_410", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				// TODO [GILA_410] Bubba && Test: Bubba_GILA_410
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_411] Princess (*) - COST:5 [ATK:5/HP:5] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain the
			//       <b>Deathrattles</b> of 3 random
			//       minions in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_411", new CardDef(new Power
			{
				// TODO [GILA_411] Princess && Test: Princess_GILA_411
				InfoCardId = "GILA_411e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_507] Hunter of Old (*) - COST:3 [ATK:3/HP:6] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain <b>Spell Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_507", new CardDef(new Power
			{
				// TODO [GILA_507] Hunter of Old && Test: Hunter of Old_GILA_507
				InfoCardId = "GILA_507e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_509] Frenzied Trapper (*) - COST:5 [ATK:5/HP:5] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Put 5 random Hunter <b>Secrets</b> into the_battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_509", new CardDef(new Power
			{
				// TODO [GILA_509] Frenzied Trapper && Test: Frenzied Trapper_GILA_509
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_601] Cannon (*) - COST:0 [ATK:0/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Deal @ damage to the enemies opposite of this_minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_601", new CardDef(new Power
			{
				// TODO [GILA_601] Cannon && Test: Cannon_GILA_601
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_610] Grizzled Reinforcement (*) - COST:3 [ATK:4/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon an extra Cannon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_610", new CardDef(new Power
			{
				// TODO [GILA_610] Grizzled Reinforcement && Test: Grizzled Reinforcement_GILA_610
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_611] Tuskarr Raider (*) - COST:4 [ATK:3/HP:9] 
			// - Race: pirate, Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       After this minion attacks, fire your Cannons.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_611", new CardDef(new Power
			{
				// TODO [GILA_611] Tuskarr Raider && Test: Tuskarr Raider_GILA_611
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_612] Seabreaker Goliath (*) - COST:10 [ATK:15/HP:15] 
			// - Race: pirate, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (1) less for each time you've fired your Cannons.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_612", new CardDef(new Power
			{
				// TODO [GILA_612] Seabreaker Goliath && Test: Seabreaker Goliath_GILA_612
				InfoCardId = "GILA_612e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_801] Gattling Gunner (*) - COST:4 [ATK:5/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Whenever you play a card, deal damage equal to its Cost to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_801", new CardDef(new Power
			{
				// TODO [GILA_801] Gattling Gunner && Test: Gattling Gunner_GILA_801
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_802] Cartographer (*) - COST:2 [ATK:1/HP:5] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Treasure.
			// --------------------------------------------------------
			// Entourage: GILA_812, GILA_811, GILA_820, GILA_810, GILA_806, GILA_804, GILA_850b, GILA_853b, GILA_825, GILA_824, GILA_803, GILA_506t, GILA_802, GILA_801, GILA_826, GILA_827, GILA_817, GILA_816a, GILA_851a, GILA_852a, GILA_821a
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("GILA_802", new CardDef(new[] {"GILA_812","GILA_811","GILA_820","GILA_810","GILA_806","GILA_804","GILA_850b","GILA_853b","GILA_825","GILA_824","GILA_803","GILA_506t","GILA_802","GILA_801","GILA_826","GILA_827","GILA_817","GILA_816a","GILA_851a","GILA_852a","GILA_821a"}, new Power
			{
				// TODO [GILA_802] Cartographer && Test: Cartographer_GILA_802
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_803] Gilnean Vigilante (*) - COST:4 [ATK:6/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a
			//       minion and fill your
			//       hand with Coins.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_803", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_803] Gilnean Vigilante && Test: Gilnean Vigilante_GILA_803
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_817t] Weeping Ghost (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_817t", new CardDef(new Power
			{
				// TODO [GILA_817t] Weeping Ghost && Test: Weeping Ghost_GILA_817t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_818t] Weeping Ghost (*) - COST:1 [ATK:2/HP:2] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_818t", new CardDef(new Power
			{
				// TODO [GILA_818t] Weeping Ghost && Test: Weeping Ghost_GILA_818t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_819t] Weeping Ghost (*) - COST:1 [ATK:3/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_819t", new CardDef(new Power
			{
				// TODO [GILA_819t] Weeping Ghost && Test: Weeping Ghost_GILA_819t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_826] Nalaa the Redeemer (*) - COST:6 [ATK:9/HP:9] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>. <b>Taunt</b>.
			//       After this minion survives
			//        damage, gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_826", new CardDef(new Power
			{
				// TODO [GILA_826] Nalaa the Redeemer && Test: Nalaa the Redeemer_GILA_826
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_827] Murloc Holmes (*) - COST:2 [ATK:3/HP:4] 
			// - Race: murloc, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Whenever your opponent draws a card, add a copy to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_827", new CardDef(new Power
			{
				// TODO [GILA_827] Murloc Holmes && Test: Murloc Holmes_GILA_827
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_851a] Gilnean Tracker (*) - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       At the start of your turn,
			//       transform this into a 5/5.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_851a", new CardDef(new Power
			{
				// TODO [GILA_851a] Gilnean Tracker && Test: Gilnean Tracker_GILA_851a
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_851b] Transforming Tracker (*) - COST:3 [ATK:5/HP:5] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       At the start of your turn, transform this into a 7/7 with <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("GILA_851b", new CardDef(new Power
			{
				// TODO [GILA_851b] Transforming Tracker && Test: Transforming Tracker_GILA_851b
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_851c] Worgen Tracker (*) - COST:3 [ATK:7/HP:7] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_851c", new CardDef(new Power
			{
				// TODO [GILA_851c] Worgen Tracker && Test: Worgen Tracker_GILA_851c
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_854] Beastly Beauty (*) - COST:2 [ATK:2/HP:5] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       After this attacks a minion
			//       and survives, transform
			//       this into an 8/8.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_854", new CardDef(new Power
			{
				// TODO [GILA_854] Beastly Beauty && Test: Beastly Beauty_GILA_854
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_854t] Beautiful Beast (*) - COST:2 [ATK:8/HP:8] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_854t", new CardDef(new Power
			{
				// TODO [GILA_854t] Beautiful Beast && Test: Beautiful Beast_GILA_854t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_906] Impetuous Companion (*) - COST:3 [ATK:5/HP:5] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap hands with your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_906", new CardDef(new Power
			{
				// TODO [GILA_906] Impetuous Companion && Test: Impetuous Companion_GILA_906
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_907] Clockwork Assistant (*) - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Has +1/+1 for each spell you've cast this game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_907", new CardDef(new Power
			{
				// TODO [GILA_907] Clockwork Assistant && Test: Clockwork Assistant_GILA_907
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_24t] Bloated Zombie (*) - COST:1 [ATK:1/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b>
			//       Deal 1 damage to all characters.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_24t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_24t] Bloated Zombie && Test: Bloated Zombie_GILA_BOSS_24t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_26t] Stuffed Sack (*) - COST:1 [ATK:0/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return your stolen minion!
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_26t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_26t] Stuffed Sack && Test: Stuffed Sack_GILA_BOSS_26t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_27t2] Amalgamation (*) - COST:1 [ATK:1/HP:1] 
			// - Race: all, Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<i>This is an Elemental, Mech,
			//       Demon, Murloc, Dragon,
			//       Beast, Pirate and Totem.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_27t2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_27t2] Amalgamation && Test: Amalgamation_GILA_BOSS_27t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_49t] Crowskin Faithful (*) - COST:3 [ATK:6/HP:3] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card. Shuffle this minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 542 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_49t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_49t] Crowskin Faithful && Test: Crowskin Faithful_GILA_BOSS_49t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_55t] Wisp (*) - COST:0 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_55t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_55t] Wisp && Test: Wisp_GILA_BOSS_55t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_60t] Cursed Crewmember (*) - COST:2 [ATK:2/HP:1] 
			// - Race: pirate, Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 2 cards, then shuffle a copy of your hand into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 858 = 1016
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_60t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_60t] Cursed Crewmember && Test: Cursed Crewmember_GILA_BOSS_60t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [GILA_BOSS_68t] Infected Quillflinger (*) - COST:4 [ATK:3/HP:7] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, deal 1 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_68t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_68t] Infected Quillflinger && Test: Infected Quillflinger_GILA_BOSS_68t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_401] Sic 'Em (*) - COST:6 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon 3 minions from your deck with the highest attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_401", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_401] Sic 'Em && Test: Sic 'Em_GILA_401
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_412] Blood Moon (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give your minions +1/+1 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GILA_412", new CardDef(new Power
			{
				// TODO [GILA_412] Blood Moon && Test: Blood Moon_GILA_412
				InfoCardId = "GILA_412e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_414] Companionship (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your Bloodhounds have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_414", new CardDef(new Power
			{
				// TODO [GILA_414] Companionship && Test: Companionship_GILA_414
				InfoCardId = "GILA_414e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_415] Lunar Signet (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       After you play a minion, trigger its <b>Deathrattle</b> effect.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_415", new CardDef(new Power
			{
				// TODO [GILA_415] Lunar Signet && Test: Lunar Signet_GILA_415
				InfoCardId = "GILA_415e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_489] Stalking (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: UNG_808, UNG_814, LOOT_125, GIL_905, GIL_562, FP1_010, EX1_017, FP1_005, EX1_028, UNG_812
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_489", new CardDef(new[] {"UNG_808","UNG_814","LOOT_125","GIL_905","GIL_562","FP1_010","EX1_017","FP1_005","EX1_028","UNG_812"}, new Power
			{
				// TODO [GILA_489] Stalking && Test: Stalking_GILA_489
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_490] On the Hunt (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: GIL_607t, ICC_854, DS1_070, DS1_184, EX1_544, LOE_105, EX1_539, EX1_538, LOOT_077, ICC_415
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_490", new CardDef(new[] {"GIL_607t","ICC_854","DS1_070","DS1_184","EX1_544","LOE_105","EX1_539","EX1_538","LOOT_077","ICC_415"}, new Power
			{
				// TODO [GILA_490] On the Hunt && Test: On the Hunt_GILA_490
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_491] Pack Mentality (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_162, EX1_531, tt_004, LOOT_136, CS2_237, AT_090, UNG_916, OG_045, OG_313, EX1_093, CS2_222
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_491", new CardDef(new[] {"EX1_162","EX1_531","tt_004","LOOT_136","CS2_237","AT_090","UNG_916","OG_045","OG_313","EX1_093","CS2_222"}, new Power
			{
				// TODO [GILA_491] Pack Mentality && Test: Pack Mentality_GILA_491
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_492] Go for the Throat (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: GIL_607t, GIL_528, GIL_682, GIL_562, GIL_578, UNG_099, GIL_578, AT_125, EX1_617, EX1_116
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_492", new CardDef(new[] {"GIL_607t","GIL_528","GIL_682","GIL_562","GIL_578","UNG_099","GIL_578","AT_125","EX1_617","EX1_116"}, new Power
			{
				// TODO [GILA_492] Go for the Throat && Test: Go for the Throat_GILA_492
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_493] Unwavering (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: FP1_031, UNG_900, LOOT_520, OG_309, ICC_257, ICC_019, FP1_012, EX1_110, GVG_114, ICC_052, ICC_052, ICC_243, OG_133
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_493", new CardDef(new[] {"FP1_031","UNG_900","LOOT_520","OG_309","ICC_257","ICC_019","FP1_012","EX1_110","GVG_114","ICC_052","ICC_052","ICC_243","OG_133"}, new Power
			{
				// TODO [GILA_493] Unwavering && Test: Unwavering_GILA_493
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_494] Divide and Conquer (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: FP1_028, FP1_011, FP1_002, EX1_556, CFM_316, OG_216, EX1_534, LOOT_153, GIL_616, GVG_026, AT_062, GIL_513
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_494", new CardDef(new[] {"FP1_028","FP1_011","FP1_002","EX1_556","CFM_316","OG_216","EX1_534","LOOT_153","GIL_616","GVG_026","AT_062","GIL_513"}, new Power
			{
				// TODO [GILA_494] Divide and Conquer && Test: Divide and Conquer_GILA_494
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_495] Companions (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: UNG_915, AT_040, CFM_816, AT_010, GVG_080, AT_041, LOOT_511, OG_048, GIL_828, NEW1_031, OG_211, EX1_531, KAR_065
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_495", new CardDef(new[] {"UNG_915","AT_040","CFM_816","AT_010","GVG_080","AT_041","LOOT_511","OG_048","GIL_828","NEW1_031","OG_211","EX1_531","KAR_065"}, new Power
			{
				// TODO [GILA_495] Companions && Test: Companions_GILA_495
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_496] Exotic Beasts (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: LOE_010, LOOT_170, GIL_155, GIL_827, UNG_835, GIL_508, LOE_022, UNG_047, UNG_957, UNG_925, UNG_933, GIL_664
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_496", new CardDef(new[] {"LOE_010","LOOT_170","GIL_155","GIL_827","UNG_835","GIL_508","LOE_022","UNG_047","UNG_957","UNG_925","UNG_933","GIL_664"}, new Power
			{
				// TODO [GILA_496] Exotic Beasts && Test: Exotic Beasts_GILA_496
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_497] Stomp, Stomp, STOMP (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: UNG_002, UNG_919, UNG_086, GVG_049, LOOT_314, EX1_543, UNG_071, UNG_852, EX1_549, GIL_571, UNG_116
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_497", new CardDef(new[] {"UNG_002","UNG_919","UNG_086","GVG_049","LOOT_314","EX1_543","UNG_071","UNG_852","EX1_549","GIL_571","UNG_116"}, new Power
			{
				// TODO [GILA_497] Stomp, Stomp, STOMP && Test: Stomp, Stomp, STOMP_GILA_497
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_498] Thick Hide (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: ICC_808, GVG_097, UNG_072, ICC_807, LOOT_131, UNG_801, UNG_848, LOOT_314, ICC_835, LOOT_137, UNG_108, FP1_012
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_498", new CardDef(new[] {"ICC_808","GVG_097","UNG_072","ICC_807","LOOT_131","UNG_801","UNG_848","LOOT_314","ICC_835","LOOT_137","UNG_108","FP1_012"}, new Power
			{
				// TODO [GILA_498] Thick Hide && Test: Thick Hide_GILA_498
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_499] Unload (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: AT_061, BRM_013, ICC_049, EX1_617, AT_056, GVG_073, EX1_537, AT_061, CS2_013, EX1_164
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_499", new CardDef(new[] {"AT_061","BRM_013","ICC_049","EX1_617","AT_056","GVG_073","EX1_537","AT_061","CS2_013","EX1_164"}, new Power
			{
				// TODO [GILA_499] Unload && Test: Unload_GILA_499
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_500p2t] A Small Rock (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GILA_500p2t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [GILA_500p2t] A Small Rock && Test: A Small Rock_GILA_500p2t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_501] Exterminate (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Echo</b>.
			//       Deal $10 damage to a minion and any excess to the enemy hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - ECHO = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_501", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_501] Exterminate && Test: Exterminate_GILA_501
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_503] Hunter's Insight (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Reduce the cost of all cards in your hand by_(3).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_503", new CardDef(new Power
			{
				// TODO [GILA_503] Hunter's Insight && Test: Hunter's Insight_GILA_503
				InfoCardId = "GILA_503e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_506] First Aid Kit (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the end of your turn, restore 2_Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_506", new CardDef(new Power
			{
				// TODO [GILA_506] First Aid Kit && Test: First Aid Kit_GILA_506
				InfoCardId = "GILA_506e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_506t] Bandage (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Restore all friendly minions to full Health. They can attack again this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("GILA_506t", new CardDef(new Power
			{
				// TODO [GILA_506t] Bandage && Test: Bandage_GILA_506t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_510] Tools of the Trade (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> one of Tess's weapons and equip it. Return this to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("GILA_510", new CardDef(new Power
			{
				// TODO [GILA_510] Tools of the Trade && Test: Tools of the Trade_GILA_510
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_511] Sticky Fingers (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Cards that didn't start in your deck cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_511", new CardDef(new Power
			{
				// TODO [GILA_511] Sticky Fingers && Test: Sticky Fingers_GILA_511
				InfoCardId = "GILA_511e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_513] Cult of the Wolf (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       You can use your Hero Power twice each turn.
			//       It costs (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_513", new CardDef(new Power
			{
				// TODO [GILA_513] Cult of the Wolf && Test: Cult of the Wolf_GILA_513
				InfoCardId = "GILA_513e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_589] Old Bones (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_012, LOOT_413, ICC_702, LOE_019, LOOT_412, OG_080, LOOT_161, ICC_257, EX1_110, EX1_016, GVG_114, AT_036, OG_133, OG_072, ICC_201, LOOT_503
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_589", new CardDef(new[] {"EX1_012","LOOT_413","ICC_702","LOE_019","LOOT_412","OG_080","LOOT_161","ICC_257","EX1_110","EX1_016","GVG_114","AT_036","OG_133","OG_072","ICC_201","LOOT_503"}, new Power
			{
				// TODO [GILA_589] Old Bones && Test: Old Bones_GILA_589
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_590] The Professional (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_522, ICC_809, EX1_005, UNG_064, EX1_002, CS2_073, EX1_609, EX1_617, CS2_076, CS2_077, LOOT_522, EX1_134, BRM_008
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_590", new CardDef(new[] {"EX1_522","ICC_809","EX1_005","UNG_064","EX1_002","CS2_073","EX1_609","EX1_617","CS2_076","CS2_077","LOOT_522","EX1_134","BRM_008"}, new Power
			{
				// TODO [GILA_590] The Professional && Test: The Professional_GILA_590
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_591] Run n' Gun (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: AT_029, LOOT_033, GVG_023, NEW1_018, LOOT_389, ICC_240, OG_322, CS2_221, ICC_233, CS2_233
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_591", new CardDef(new[] {"AT_029","LOOT_033","GVG_023","NEW1_018","LOOT_389","ICC_240","OG_322","CS2_221","ICC_233","CS2_233"}, new Power
			{
				// TODO [GILA_591] Run n' Gun && Test: Run n' Gun_GILA_591
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_592] Mercenaries (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: KAR_069, CFM_637, NEW1_016, GVG_025, GVG_075, GIL_902, AT_032, NEW1_027, NEW1_022, ICC_018, OG_267, CFM_342, AT_070, GVG_047, GIL_672
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_592", new CardDef(new[] {"KAR_069","CFM_637","NEW1_016","GVG_025","GVG_075","GIL_902","AT_032","NEW1_027","NEW1_022","ICC_018","OG_267","CFM_342","AT_070","GVG_047","GIL_672"}, new Power
			{
				// TODO [GILA_592] Mercenaries && Test: Mercenaries_GILA_592
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_593] Resourceful (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_015, EX1_049, EX1_095, UNG_058, LOE_077, CS2_117, LOOT_026, LOOT_291, GVG_069, EX1_144, LOOT_214, LOOT_210, LOOT_204, BRM_007, AT_035
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_593", new CardDef(new[] {"EX1_015","EX1_049","EX1_095","UNG_058","LOE_077","CS2_117","LOOT_026","LOOT_291","GVG_069","EX1_144","LOOT_214","LOOT_210","LOOT_204","BRM_007","AT_035"}, new Power
			{
				// TODO [GILA_593] Resourceful && Test: Resourceful_GILA_593
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_594] Rapid Fire (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_050, EX1_613, EX1_044, NEW1_026, EX1_095, KAR_711, CFM_630, EX1_145, CS2_072, AT_061, EX1_278, EX1_129
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_594", new CardDef(new[] {"EX1_050","EX1_613","EX1_044","NEW1_026","EX1_095","KAR_711","CFM_630","EX1_145","CS2_072","AT_061","EX1_278","EX1_129"}, new Power
			{
				// TODO [GILA_594] Rapid Fire && Test: Rapid Fire_GILA_594
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_595] Copycat (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: KAR_069, EX1_100, OG_330, CFM_781, ICC_811, KAR_070, EX1_564, GVG_028, BRM_030, UNG_856, GIL_696, AT_033, GIL_672, UNG_061, GIL_827
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_595", new CardDef(new[] {"KAR_069","EX1_100","OG_330","CFM_781","ICC_811","KAR_070","EX1_564","GVG_028","BRM_030","UNG_856","GIL_696","AT_033","GIL_672","UNG_061","GIL_827"}, new Power
			{
				// TODO [GILA_595] Copycat && Test: Copycat_GILA_595
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_596] Trapper (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_080, FP1_004, KAR_006, ICC_204, EX1_610, EX1_611, AT_060, GIL_577, EX1_533, LOE_021, LOOT_080, EX1_536
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_596", new CardDef(new[] {"EX1_080","FP1_004","KAR_006","ICC_204","EX1_610","EX1_611","AT_060","GIL_577","EX1_533","LOE_021","LOOT_080","EX1_536"}, new Power
			{
				// TODO [GILA_596] Trapper && Test: Trapper_GILA_596
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_597] Arsenal (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: GVG_119, CS2_074, CS2_074, ICC_221, UNG_823, GVG_022, GVG_043, ICC_850, EX1_536, DS1_188
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_597", new CardDef(new[] {"GVG_119","CS2_074","CS2_074","ICC_221","UNG_823","GVG_022","GVG_043","ICC_850","EX1_536","DS1_188"}, new Power
			{
				// TODO [GILA_597] Arsenal && Test: Arsenal_GILA_597
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_598] Specialist (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: EX1_012, ICC_913, AT_093, EX1_284, EX1_563, CS2_072, EX1_124, GIL_687, GIL_506, OG_176, EX1_129, EX1_137
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_598", new CardDef(new[] {"EX1_012","ICC_913","AT_093","EX1_284","EX1_563","CS2_072","EX1_124","GIL_687","GIL_506","OG_176","EX1_129","EX1_137"}, new Power
			{
				// TODO [GILA_598] Specialist && Test: Specialist_GILA_598
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_599] Jade in the Rough (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add to your deck:
			//       '{0}'
			//       '{1}'
			//       '{2}'
			// --------------------------------------------------------
			// Entourage: CFM_691, LOOT_165, CFM_715, CFM_902, EX1_144, BRM_007, OG_073, CFM_691, CFM_715, CFM_902, CFM_690
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_599", new CardDef(new[] {"CFM_691","LOOT_165","CFM_715","CFM_902","EX1_144","BRM_007","OG_073","CFM_691","CFM_715","CFM_902","CFM_690"}, new Power
			{
				// TODO [GILA_599] Jade in the Rough && Test: Jade in the Rough_GILA_599
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_602] Victorious Rally (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive</b>
			//       Whenever you fire your
			//       Cannons, give your minions
			//       +1 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_602", new CardDef(new Power
			{
				// TODO [GILA_602] Victorious Rally && Test: Victorious Rally_GILA_602
				InfoCardId = "GILA_602e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_603] Tactical Reinforcements (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive</b>
			//       Whenever you fire your
			//       Cannons, reduce the cost of
			//       a card in your hand by (2).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_603", new CardDef(new Power
			{
				// TODO [GILA_603] Tactical Reinforcements && Test: Tactical Reinforcements_GILA_603
				InfoCardId = "GILA_603e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_604] Extra Powder (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]Your Cannons do 2
			//       extra damage this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_604", new CardDef(new Power
			{
				// TODO [GILA_604] Extra Powder && Test: Extra Powder_GILA_604
				InfoCardId = "GILA_604e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_605] Dragonfire Ammo (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your Cannons do
			//       1 extra damage.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47847
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_605", new CardDef(new Power
			{
				// TODO [GILA_605] Dragonfire Ammo && Test: Dragonfire Ammo_GILA_605
				InfoCardId = "GILA_605e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_607] Pillage the Fallen (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Whenever your weapon is destroyed, equip a random weapon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_607", new CardDef(new Power
			{
				// TODO [GILA_607] Pillage the Fallen && Test: Pillage the Fallen_GILA_607
				InfoCardId = "GILA_607e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_608] Safe Harbor (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Choose a minion and put it into your hand.
			//       It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1583
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_608", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_608] Safe Harbor && Test: Safe Harbor_GILA_608
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_804] Holy Book (*) - COST:6 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Silence</b> and destroy a minion. Summon a 10/10 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_804", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_804] Holy Book && Test: Holy Book_GILA_804
				InfoCardId = "GILA_804e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_805] Entrenchment (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions have +2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_805", new CardDef(new Power
			{
				// TODO [GILA_805] Entrenchment && Test: Entrenchment_GILA_805
				InfoCardId = "GILA_805e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_806] Brass Lantern (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a copy of a card in your deck. Repeat this 2 more times.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_806", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_806] Brass Lantern && Test: Brass Lantern_GILA_806
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_810] Sneak Attack (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Put 2 random minions from your hand into the battlefield and give them <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("GILA_810", new CardDef(new Power
			{
				// TODO [GILA_810] Sneak Attack && Test: Sneak Attack_GILA_810
				InfoCardId = "GILA_810e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_811] Spyglass (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Put a copy of a random card in your opponent's hand into yours. It costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_811", new CardDef(new Power
			{
				// TODO [GILA_811] Spyglass && Test: Spyglass_GILA_811
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_812] Bestiary (*) - COST:8 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]Fill your board with
			//       copies of random minions
			//       from your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_812", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_812] Bestiary && Test: Bestiary_GILA_812
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_813] Expedite (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions cost
			//       (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_813", new CardDef(new Power
			{
				// TODO [GILA_813] Expedite && Test: Expedite_GILA_813
				InfoCardId = "GILA_813e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_814] Caltrops (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       After your opponent
			//       plays a minion, deal 1
			//       damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_814", new CardDef(new Power
			{
				// TODO [GILA_814] Caltrops && Test: Caltrops_GILA_814
				InfoCardId = "GILA_814e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_816a] Coin Pouch (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon a random 3-Cost minion. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_816a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_816a] Coin Pouch && Test: Coin Pouch_GILA_816a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_816b] Sack of Coins (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon a random 6-Cost minion. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_816b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_816b] Sack of Coins && Test: Sack of Coins_GILA_816b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_816c] Hefty Sack of Coins (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon a random 3, 6, and 9-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("GILA_816c", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [GILA_816c] Hefty Sack of Coins && Test: Hefty Sack of Coins_GILA_816c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_817] Creepy Curio (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon three 1/1 Ghosts. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_817", new CardDef(new Power
			{
				// TODO [GILA_817] Creepy Curio && Test: Creepy Curio_GILA_817
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_818] Haunted Curio (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon three 2/2 Ghosts. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_818", new CardDef(new Power
			{
				// TODO [GILA_818] Haunted Curio && Test: Haunted Curio_GILA_818
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_819] Cursed Curio (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon three 3/3 Ghosts with <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GILA_819", new CardDef(new Power
			{
				// TODO [GILA_819] Cursed Curio && Test: Cursed Curio_GILA_819
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_820] Ricochet Shot (*) - COST:5 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to a random character. Repeat this 12 times. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_820", new CardDef(new Power
			{
				// TODO [GILA_820] Ricochet Shot && Test: Ricochet Shot_GILA_820
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_821a] Surly Mob (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GILA_821a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [GILA_821a] Surly Mob && Test: Surly Mob_GILA_821a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_821b] Angry Mob (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy 2 random enemy minions. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GILA_821b", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [GILA_821b] Angry Mob && Test: Angry Mob_GILA_821b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_821c] Crazed Mob (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Silence</b> and destroy all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("GILA_821c", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [GILA_821c] Crazed Mob && Test: Crazed Mob_GILA_821c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_824] Royal Gift (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give a minion +2/+2 for each minion you control.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_824", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_824] Royal Gift && Test: Royal Gift_GILA_824
				InfoCardId = "GILA_824e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_825] Gentleman's Top Hat (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2
			//       and "<b>Deathrattle:</b> Give
			//       your Top Hat to another
			//       random friendly minion."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GILA_825", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_825] Gentleman's Top Hat && Test: Gentleman's Top Hat_GILA_825
				InfoCardId = "GILA_825e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_825d] Gentlemanly Reequip Effect Dummy (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: It is a dummy card for holding a effect to play when reequipping Gentleman's Top Hat (GILA_825)
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("GILA_825d", new CardDef(new Power
			{
				// TODO [GILA_825d] Gentlemanly Reequip Effect Dummy && Test: Gentlemanly Reequip Effect Dummy_GILA_825d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_850b] Hallowed Water (*) - COST:7 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Restore your hero
			//       to full Health.
			//        Draw 5 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("GILA_850b", new CardDef(new Power
			{
				// TODO [GILA_850b] Hallowed Water && Test: Hallowed Water_GILA_850b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_852a] Old Militia Horn (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give your minions +1/+1 and <b>Taunt</b>. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GILA_852a", new CardDef(new Power
			{
				// TODO [GILA_852a] Old Militia Horn && Test: Old Militia Horn_GILA_852a
				InfoCardId = "GILA_852ae",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_852b] Militia Horn (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give your minions +2/+2 and <b>Taunt</b>. Upgrade this and shuffle it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GILA_852b", new CardDef(new Power
			{
				// TODO [GILA_852b] Militia Horn && Test: Militia Horn_GILA_852b
				InfoCardId = "GILA_852be",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_852c] Veteran's Militia Horn (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give your minions +4/+4, <b>Taunt</b>, and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GILA_852c", new CardDef(new Power
			{
				// TODO [GILA_852c] Veteran's Militia Horn && Test: Veteran's Militia Horn_GILA_852c
				InfoCardId = "GILA_852ce",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_853b] Pristine Compass (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Draw a card and add 2 extra copies of it to your hand. They cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_853b", new CardDef(new Power
			{
				// TODO [GILA_853b] Pristine Compass && Test: Pristine Compass_GILA_853b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_901] Chaos Theory (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Both players cast all spells in their hand <i>(targets chosen randomly).</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_901", new CardDef(new Power
			{
				// TODO [GILA_901] Chaos Theory && Test: Chaos Theory_GILA_901
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_903] Enhance-a-matic (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Add a random spell from each class to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_903", new CardDef(new Power
			{
				// TODO [GILA_903] Enhance-a-matic && Test: Enhance-a-matic_GILA_903
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_904] Stroke of Midnight (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Destroy a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GILA_904", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [GILA_904] Stroke of Midnight && Test: Stroke of Midnight_GILA_904
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_910] Puzzle Box (*) - COST:1 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Transform all minions into random ones that cost (3) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_910", new CardDef(new Power
			{
				// TODO [GILA_910] Puzzle Box && Test: Puzzle Box_GILA_910
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_911] Rewind (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       When your hero dies, restart the game and remove this from your Dungeon Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_911", new CardDef(new Power
			{
				// TODO [GILA_911] Rewind && Test: Rewind_GILA_911
				InfoCardId = "GILA_911e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_913] Double Time (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       After you cast your first spell in a turn, cast a copy of it
			//       (<i>targets chosen randomly</i>).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_913", new CardDef(new Power
			{
				// TODO [GILA_913] Double Time && Test: Double Time_GILA_913
				InfoCardId = "GILA_913e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_23t] Chuck (*) - COST:6 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Discard all minions
			//       from your hand and
			//       deal their Attack to
			//       the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_23t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_23t] Chuck && Test: Chuck_GILA_BOSS_23t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_26t2] Sack of Gnomes (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Fill your board with random Gnomes.
			// --------------------------------------------------------
			// Entourage: EX1_608, ICC_083, LOOT_306, LOOT_415, UNG_020, GVG_122, ICC_820, GVG_011, EX1_522, OG_302, AT_027, OG_315, GVG_053, GVG_082, GVG_013, EX1_029, AT_029, CFM_659, NEW1_019, EX1_096, NEW1_029, EX1_015, EX1_076, KAR_062, GVG_108, CFM_646, EX1_582, GVG_092, GVG_098, GVG_089, GVG_097, EX1_085, CFM_341, GVG_102, EX1_083, OG_286, KAR_710, CS2_147, GVG_109, OG_323, GVG_070, AT_096
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_26t2", new CardDef(new[] {"EX1_608","ICC_083","LOOT_306","LOOT_415","UNG_020","GVG_122","ICC_820","GVG_011","EX1_522","OG_302","AT_027","OG_315","GVG_053","GVG_082","GVG_013","EX1_029","AT_029","CFM_659","NEW1_019","EX1_096","NEW1_029","EX1_015","EX1_076","KAR_062","GVG_108","CFM_646","EX1_582","GVG_092","GVG_098","GVG_089","GVG_097","EX1_085","CFM_341","GVG_102","EX1_083","OG_286","KAR_710","CS2_147","GVG_109","OG_323","GVG_070","AT_096"}, new Power
			{
				// TODO [GILA_BOSS_26t2] Sack of Gnomes && Test: Sack of Gnomes_GILA_BOSS_26t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_27t] Amalgamate (*) - COST:8 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Summon an Amalgamation with the combined
			//       Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_27t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [GILA_BOSS_27t] Amalgamate && Test: Amalgamate_GILA_BOSS_27t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_29t] Enchanting Tune (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Gain control of all enemy minions. Set their Attack and Health to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_29t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_29t] Enchanting Tune && Test: Enchanting Tune_GILA_BOSS_29t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_35t] Vampiric Fangs (*) - COST:3 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy a minion. Restore its Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_35t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_35t] Vampiric Fangs && Test: Vampiric Fangs_GILA_BOSS_35t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_37t] Murloc Infestation (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Give your minions: "<b>Deathrattle</b>: Summon a random Murloc."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_37t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_37t] Murloc Infestation && Test: Murloc Infestation_GILA_BOSS_37t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_41t] Hack (*) - COST:3 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion. Then do it four more times. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_41t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_41t] Hack && Test: Hack_GILA_BOSS_41t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_43t] Grave Mistake (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Trigger all minions' <b>Deathrattles</b> twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_43t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_43t] Grave Mistake && Test: Grave Mistake_GILA_BOSS_43t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_48t] Alternate Timeline (*) - COST:10 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Start a new game,
			//       but your opponent's Health stays the same.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_48t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_48t] Alternate Timeline && Test: Alternate Timeline_GILA_BOSS_48t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_49t2] Crowskin Pact (*) - COST:5 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Transform a minion into a 'Crowskin Faithful' and take control of it.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_49t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [GILA_BOSS_49t2] Crowskin Pact && Test: Crowskin Pact_GILA_BOSS_49t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_55t2] Soul Assimilation (*) - COST:4 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy your Wisps.
			//       Gain control of a random enemy minion for each Wisp destroyed.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_55t2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_55t2] Soul Assimilation && Test: Soul Assimilation_GILA_BOSS_55t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_57t] Shallow Graves (*) - COST:9 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Summon 7 random minions that died this_game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_57t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME,0}}, new Power
			{
				// TODO [GILA_BOSS_57t] Shallow Graves && Test: Shallow Graves_GILA_BOSS_57t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_61t3] Ominous Fog (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Corrupt all enemy minions. Destroy them at the start of your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43112
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_61t3", new CardDef(new Power
			{
				// TODO [GILA_BOSS_61t3] Ominous Fog && Test: Ominous Fog_GILA_BOSS_61t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_99t] Witchwood's Touch (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Draw a card.
			//       Gain 6 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_99t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_99t] Witchwood's Touch && Test: Witchwood's Touch_GILA_BOSS_99t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_99t2] Witchwood's Touch (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			//       Gain 8 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_99t2", new CardDef(new Power
			{
				// TODO [GILA_BOSS_99t2] Witchwood's Touch && Test: Witchwood's Touch_GILA_BOSS_99t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [GILA_BOSS_99t3] Witchwood's Touch (*) - COST:2 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			//       Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_99t3", new CardDef(new Power
			{
				// TODO [GILA_BOSS_99t3] Witchwood's Touch && Test: Witchwood's Touch_GILA_BOSS_99t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_413] Shaw's Shank (*) - COST:3 [ATK:1/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Has +1_Attack for each friendly minion you control.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 5
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_413", new CardDef(new Power
			{
				// TODO [GILA_413] Shaw's Shank && Test: Shaw's Shank_GILA_413
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_500t] Stake Thrower (*) - COST:1 [ATK:1/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 8
			// - WINDFURY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_500t", new CardDef(new Power
			{
				// TODO [GILA_500t] Stake Thrower && Test: Stake Thrower_GILA_500t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_500t2] Handgonne (*) - COST:1 [ATK:4/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_500t2", new CardDef(new Power
			{
				// TODO [GILA_500t2] Handgonne && Test: Handgonne_GILA_500t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_500t3] Blunderbuss (*) - COST:1 [ATK:2/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever your hero_attacks.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_500t3", new CardDef(new Power
			{
				// TODO [GILA_500t3] Blunderbuss && Test: Blunderbuss_GILA_500t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_508] The Exorcisor (*) - COST:3 [ATK:4/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Silence</b> any minion attacked by this weapon.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("GILA_508", new CardDef(new Power
			{
				// TODO [GILA_508] The Exorcisor && Test: The Exorcisor_GILA_508
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_BOSS_33t] Scythe (*) - COST:3 [ATK:1/HP:0] 
			// - Fac: neutral, Set: gilneas, 
			// --------------------------------------------------------
			// Text: Doesn't lose Durability. When you kill a minion with this weapon, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_33t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_33t] Scythe && Test: Scythe_GILA_BOSS_33t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [GILA_BOSS_61t] Ritual Dagger (*) - COST:2 [ATK:3/HP:0] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       After you cast a spell, this
			//       gains +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - LIFESTEAL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("GILA_BOSS_61t", new CardDef(new Power
			{
				// TODO [GILA_BOSS_61t] Ritual Dagger && Test: Ritual Dagger_GILA_BOSS_61t
				InfoCardId = "GILA_BOSS_61te",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DruidNonCollect(cards);
			MageNonCollect(cards);
			WarriorNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
