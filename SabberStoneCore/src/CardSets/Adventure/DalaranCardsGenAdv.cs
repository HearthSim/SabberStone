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
	public class DalaranCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ HERO - HUNTER
			// [DALA_Barkeye] Ol' Barkeye (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Barkeye", new CardDef(new Power
			{
				// TODO [DALA_Barkeye] Ol' Barkeye && Test: Ol' Barkeye_DALA_Barkeye
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_01h] Chomper (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Chomper survives the sewers by snacking on smaller minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53751
			// - HERO_DECK_ID = 2028
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2242
			// - HEROIC_HERO_POWER = 55987
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_01h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_01h] Chomper && Test: Chomper_DALA_BOSS_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_02h] Awilo, Cooking Trainer (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This chef is cooking
			//       up some REALLY healthy food.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53781
			// - HERO_DECK_ID = 2005
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1205 = 10
			// - 1279 = 2243
			// - HEROIC_HERO_POWER = 55988
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_02h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_02h] Awilo, Cooking Trainer && Test: Awilo, Cooking Trainer_DALA_BOSS_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_03h] The Great Akazamzarak (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>It's not real magic. He's got cards tucked into his sleeve.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53668
			// - HERO_DECK_ID = 1995
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1204 = 10
			// - 1206 = 10
			// - 1279 = 2244
			// - HEROIC_HERO_POWER = 55989
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03h] The Great Akazamzarak && Test: The Great Akazamzarak_DALA_BOSS_03h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_04h] Kaye Toogie (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Step 1: Open portal.
			//       Step 2: Minions fight.
			//       Step_3:_...Victory?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53559
			// - HERO_DECK_ID = 2038
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1205 = 10
			// - 1279 = 2245
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_04h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_04h] Kaye Toogie && Test: Kaye Toogie_DALA_BOSS_04h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_05h] The Amazing "Bonepaw" (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>What's amazing is how far he's gotten copying other_people's_spells.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53573
			// - HERO_DECK_ID = 2004
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1206 = 5
			// - 1279 = 2246
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_05h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_05h] The Amazing "Bonepaw" && Test: The Amazing "Bonepaw"_DALA_BOSS_05h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_06dk] "Scourgelord" Dazzik (*) - COST:8 [ATK:0/HP:30] 
			// - Set: dalaran, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 10
			// - HERO_POWER = 45585
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_06dk", new CardDef(new Power
			{
				// TODO [DALA_BOSS_06dk] "Scourgelord" Dazzik && Test: "Scourgelord" Dazzik_DALA_BOSS_06dk
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_06h] Dazzik "Hellscream" (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Something about
			//       the Warchief seems
			//       a_little..._off.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53640
			// - HERO_DECK_ID = 2006
			// - HIDE_WATERMARK = 1
			// - 1205 = 25
			// - 1279 = 2247
			// - HEROIC_HERO_POWER = 55990
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_06h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_06h] Dazzik "Hellscream" && Test: Dazzik "Hellscream"_DALA_BOSS_06h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_07h] Flight Master Belnaara (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>When it comes to Fight or Flight, Belnaara chooses both.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54078
			// - HERO_DECK_ID = 2196
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2248
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_07h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_07h] Flight Master Belnaara && Test: Flight Master Belnaara_DALA_BOSS_07h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_08h] Applebough (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This old tree is full of
			//       knowledge to drop.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53308
			// - HERO_DECK_ID = 1980
			// - HIDE_WATERMARK = 1
			// - 1204 = 30
			// - 1279 = 2249
			// - HEROIC_HERO_POWER = 55991
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_08h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_08h] Applebough && Test: Applebough_DALA_BOSS_08h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_BOSS_09h] Archivist Oshi (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Those who forget history are doomed to resummon it.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53563
			// - HERO_DECK_ID = 2019
			// - HIDE_WATERMARK = 1
			// - 1206 = 30
			// - 1279 = 2250
			// - HEROIC_HERO_POWER = 55992
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_09h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_09h] Archivist Oshi && Test: Archivist Oshi_DALA_BOSS_09h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_10h] Mo Eniwhiskers (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Mo's money creates Mo's problems.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53484
			// - HERO_DECK_ID = 1990
			// - HIDE_WATERMARK = 1
			// - 1202 = 30
			// - 1279 = 2251
			// - HEROIC_HERO_POWER = 56359
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_10h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_10h] Mo Eniwhiskers && Test: Mo Eniwhiskers_DALA_BOSS_10h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_11h] Noz Timbertail (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This kobold pirate has elevated sneak attacks to an art form.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53716
			// - HERO_DECK_ID = 2007
			// - HIDE_WATERMARK = 1
			// - 1202 = 30
			// - 1279 = 2252
			// - HEROIC_HERO_POWER = 55993
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_11h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_11h] Noz Timbertail && Test: Noz Timbertail_DALA_BOSS_11h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_12h] Cravitz Lorent (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Your battle with this romance novelist won't have_a_happy_ending.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53784
			// - HERO_DECK_ID = 2008
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2253
			// - HEROIC_HERO_POWER = 56321
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_12h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_12h] Cravitz Lorent && Test: Cravitz Lorent_DALA_BOSS_12h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_13h] Albin Eastoft (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Friend? Foe? He's on a beastial rampage, he's not particular.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53735
			// - HERO_DECK_ID = 2106
			// - HIDE_WATERMARK = 1
			// - 1204 = 30
			// - 1279 = 2334
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_13h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_13h] Albin Eastoft && Test: Albin Eastoft_DALA_BOSS_13h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_14h] Tierra Blythe (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Be sure to tip
			//       your wait staff!
			//       (Or else.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53638
			// - HERO_DECK_ID = 2073
			// - HIDE_WATERMARK = 1
			// - 1204 = 20
			// - 1279 = 2340
			// - HEROIC_HERO_POWER = 55995
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_14h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_14h] Tierra Blythe && Test: Tierra Blythe_DALA_BOSS_14h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_BOSS_15h] Moon Priestess Nici (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Time heals all wounds. But if you're in a hurry, call Nici!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54099
			// - HERO_DECK_ID = 2074
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - 1203 = 10
			// - 1204 = 10
			// - 1206 = 10
			// - 1279 = 2254
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_15h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_15h] Moon Priestess Nici && Test: Moon Priestess Nici_DALA_BOSS_15h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_16h] Alchemist Wendy (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This alchemist mixes up decks, attempting to create_golden_cards.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53569
			// - HERO_DECK_ID = 2075
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1204 = 10
			// - HEROIC_HERO_POWER = 55996
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_16h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_16h] Alchemist Wendy && Test: Alchemist Wendy_DALA_BOSS_16h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_17h] Tala Stonerage (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Druids walk many paths.
			//       Tala walks them all.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54101
			// - HERO_DECK_ID = 2076
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2255
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_17h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_17h] Tala Stonerage && Test: Tala Stonerage_DALA_BOSS_17h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_18h] Disidra Stormglory (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Terribly tenacious.
			//       Truly thaumaturgic.
			//       Totally_totemic.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53665
			// - HERO_DECK_ID = 1992
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - 1203 = 10
			// - 1206 = 10
			// - 1279 = 2256
			// - HEROIC_HERO_POWER = 55997
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_18h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_18h] Disidra Stormglory && Test: Disidra Stormglory_DALA_BOSS_18h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_19h] Linzi Redgrin (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This teeny-tiny
			//       rogue dishes out
			//       some big big hurt.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53777
			// - HERO_DECK_ID = 2009
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2339
			// - HEROIC_HERO_POWER = 55998
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_19h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_19h] Linzi Redgrin && Test: Linzi Redgrin_DALA_BOSS_19h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_20h] Vas'no (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This troll water shaman is into undertows and overloads.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54105
			// - HERO_DECK_ID = 1991
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2257
			// - HEROIC_HERO_POWER = 55999
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_20h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_20h] Vas'no && Test: Vas'no_DALA_BOSS_20h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_21h] Whirt the All-Knowing (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>What's the secret to knowing all secrets? It's a secret.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53561
			// - HERO_DECK_ID = 2021
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_21h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_21h] Whirt the All-Knowing && Test: Whirt the All-Knowing_DALA_BOSS_21h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_BOSS_22h] Bookmaster Bae Chao (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Quiet, please.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53539
			// - HERO_DECK_ID = 2012
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1206 = 20
			// - 1279 = 2258
			// - HEROIC_HERO_POWER = 56000
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_22h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_22h] Bookmaster Bae Chao && Test: Bookmaster Bae Chao_DALA_BOSS_22h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_23h] Sharky McFin (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This McShark feeds
			//       on the McWeak.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53674
			// - HERO_DECK_ID = 2013
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2266
			// - HEROIC_HERO_POWER = 56002
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_23h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_23h] Sharky McFin && Test: Sharky McFin_DALA_BOSS_23h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_24h] Ranger Ar'ha (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Battlecry havoc,
			//       and let slip the
			//       Alleycats_of_war!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53757
			// - HERO_DECK_ID = 2015
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2259
			// - HEROIC_HERO_POWER = 56003
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_24h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_24h] Ranger Ar'ha && Test: Ranger Ar'ha_DALA_BOSS_24h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_25h] Jepetto Joybuzz (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Some assembly required.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53542
			// - HERO_DECK_ID = 2079
			// - HIDE_WATERMARK = 1
			// - 1204 = 20
			// - 1279 = 2260
			// - HEROIC_HERO_POWER = 56004
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_25h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_25h] Jepetto Joybuzz && Test: Jepetto Joybuzz_DALA_BOSS_25h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_26h] Dalaran Fountain Golem (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Ice cold this fountain flows frostin' up foes with_lyrical_ice_floes.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54106
			// - HERO_DECK_ID = 2080
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2261
			// - HEROIC_HERO_POWER = 56005
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_26h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_26h] Dalaran Fountain Golem && Test: Dalaran Fountain Golem_DALA_BOSS_26h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_27h] Rasil Fireborne (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Some say art is subjective. Rasil
			//       prefers_destructive.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53600
			// - HERO_DECK_ID = 2081
			// - HIDE_WATERMARK = 1
			// - 1204 = 30
			// - 1279 = 2262
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_27h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_27h] Rasil Fireborne && Test: Rasil Fireborne_DALA_BOSS_27h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_28h] Xur'ios (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Master of spellcasting.
			//       [x]Lousy at spell-aiming.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53881
			// - HERO_DECK_ID = 2010
			// - HIDE_WATERMARK = 1
			// - 1201 = 5
			// - 1204 = 15
			// - 1279 = 2342
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_28h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_28h] Xur'ios && Test: Xur'ios_DALA_BOSS_28h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_29h] Mama Diggs (*) - COST:0 [ATK:0/HP:40] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She's always digging into her deck for elementals.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53585
			// - HERO_DECK_ID = 2031
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2263
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_29h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_29h] Mama Diggs && Test: Mama Diggs_DALA_BOSS_29h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_30h] The Rat King (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>There must always
			//       be a rat king.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53602
			// - HERO_DECK_ID = 2082
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2299
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_30h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_30h] The Rat King && Test: The Rat King_DALA_BOSS_30h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_31h] Timothy Jones (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Timothy has never dusted a golden.
			//       Not even once!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53588
			// - HERO_DECK_ID = 2083
			// - HIDE_WATERMARK = 1
			// - 1204 = 30
			// - 1279 = 2265
			// - HEROIC_HERO_POWER = 56007
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_31h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_31h] Timothy Jones && Test: Timothy Jones_DALA_BOSS_31h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_32h] Kizi Copperclip (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>A skilled stylist, but get on her bad side and she's_a_bit_snippy.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53626
			// - HERO_DECK_ID = 1996
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1204 = 10
			// - 1279 = 2300
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_32h] Kizi Copperclip && Test: Kizi Copperclip_DALA_BOSS_32h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_33h] Gold Elemental (*) - COST:0 [ATK:0/HP:40] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Something has gone awry at the bottom of the wishing well.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53565
			// - HERO_DECK_ID = 1993
			// - HIDE_WATERMARK = 1
			// - 1202 = 30
			// - 1279 = 2301
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_33h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_33h] Gold Elemental && Test: Gold Elemental_DALA_BOSS_33h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_34h] Carousel Gryphon (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Round and round your minions go...</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53803
			// - HERO_DECK_ID = 2002
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - 1205 = 5
			// - 1206 = 10
			// - 1279 = 2302
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_34h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_34h] Carousel Gryphon && Test: Carousel Gryphon_DALA_BOSS_34h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_BOSS_35h] Soothsayer Zoie (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This healer will fight
			//       for her city. Break
			//       out_the_sooths!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53623
			// - HERO_DECK_ID = 2084
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2309
			// - HEROIC_HERO_POWER = 56010
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_35h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_35h] Soothsayer Zoie && Test: Soothsayer Zoie_DALA_BOSS_35h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_36h] Draemus (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Importer of rare and exotic pets. Many of them dangerous.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 55320
			// - HERO_DECK_ID = 2096
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1204 = 10
			// - 1279 = 2303
			// - HEROIC_HERO_POWER = 56013
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_36h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_36h] Draemus && Test: Draemus_DALA_BOSS_36h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_37h] Ol' Toomba (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>His hunt for treasure consumed his life...
			//       and_maybe_yours_too.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53811
			// - HERO_DECK_ID = 2085
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2305
			// - HEROIC_HERO_POWER = 56014
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_37h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_37h] Ol' Toomba && Test: Ol' Toomba_DALA_BOSS_37h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_38h] Tipsi Wobblerune (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She's a portable
			//       portal party!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53816
			// - HERO_DECK_ID = 2086
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2306
			// - HEROIC_HERO_POWER = 56015
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_38h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_38h] Tipsi Wobblerune && Test: Tipsi Wobblerune_DALA_BOSS_38h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_39h] Aki the Brilliant (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Handbuffing isn't particularly brilliant but the name stuck.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53818
			// - HERO_DECK_ID = 2087
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2307
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_39h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_39h] Aki the Brilliant && Test: Aki the Brilliant_DALA_BOSS_39h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_40h] Oxana Demonslay (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Slaying demons is her profession, but beating you_is_her_passion.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53821
			// - HERO_DECK_ID = 2088
			// - HIDE_WATERMARK = 1
			// - 1201 = 5
			// - 1205 = 25
			// - 1279 = 2273
			// - HEROIC_HERO_POWER = 56018
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_40h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_40h] Oxana Demonslay && Test: Oxana Demonslay_DALA_BOSS_40h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_41h] Ungan Oddkind (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>He conjures up animals. And insults. And_insulting_animals.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53871
			// - HERO_DECK_ID = 2017
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2304
			// - HEROIC_HERO_POWER = 56020
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_41h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_41h] Ungan Oddkind && Test: Ungan Oddkind_DALA_BOSS_41h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_42h] P.O.G.O. (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This bionic bouncing machine has gone completely_rogue!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53904
			// - HERO_DECK_ID = 2025
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1202 = 20
			// - 1279 = 2308
			// - HEROIC_HERO_POWER = 56021
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_42h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_42h] P.O.G.O. && Test: P.O.G.O._DALA_BOSS_42h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_43h] Magistrix Norroa (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>There's no time
			//       to read her card text.
			//       Go,_go,_GO!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54156
			// - HERO_DECK_ID = 2090
			// - HIDE_WATERMARK = 1
			// - 1206 = 10
			// - 1279 = 2310
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_43h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_43h] Magistrix Norroa && Test: Magistrix Norroa_DALA_BOSS_43h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_44h] Erekem (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This Arakkoa can see the future... and he's stacking_the_deck.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54304
			// - HERO_DECK_ID = 2097
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2311
			// - HEROIC_HERO_POWER = 56023
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_44h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_44h] Erekem && Test: Erekem_DALA_BOSS_44h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_45h] Moragg (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>"Prisoner #54293. Indefinite suspension.
			//       Avoid_eye_contact."</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54294
			// - HERO_DECK_ID = 2098
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2297
			// - HEROIC_HERO_POWER = 56025
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_45h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_45h] Moragg && Test: Moragg_DALA_BOSS_45h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_46h] Ichoron (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This elemental is
			//       double the trouble and
			//       triple_the_bubble.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53605
			// - HERO_DECK_ID = 2030
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2312
			// - HEROIC_HERO_POWER = 56026
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_46h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_46h] Ichoron && Test: Ichoron_DALA_BOSS_46h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_47h] Lavanthor (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>"What's in your mouth Lavanthor? Spit it out! Bad core hound!"</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53598
			// - HERO_DECK_ID = 2099
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2313
			// - HEROIC_HERO_POWER = 56027
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_47h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_47h] Lavanthor && Test: Lavanthor_DALA_BOSS_47h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_48h] Zuramat the Obliterator (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Imprisoned because the Kirin Tor mostly frowns on obliterations.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53595
			// - HERO_DECK_ID = 2104
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2314
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_48h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_48h] Zuramat the Obliterator && Test: Zuramat the Obliterator_DALA_BOSS_48h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_49h] Cyanigosa (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This master of chaotic magic was the chosen agent of Malygos.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53593
			// - HERO_DECK_ID = 2100
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2315
			// - HEROIC_HERO_POWER = 56028
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_49h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_49h] Cyanigosa && Test: Cyanigosa_DALA_BOSS_49h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_50h] Nozari (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>When time travel fails, bronze dragons often resort_to_random_sand.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54300
			// - HERO_DECK_ID = 2101
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1206 = 10
			// - 1279 = 2316
			// - HEROIC_HERO_POWER = 56029
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_50h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_50h] Nozari && Test: Nozari_DALA_BOSS_50h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_51h] Millificent Manastorm (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Dread spouse of Millhouse, whom she'd like_to_have_a_word_with.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54307
			// - HERO_DECK_ID = 2102
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2317
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_51h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_51h] Millificent Manastorm && Test: Millificent Manastorm_DALA_BOSS_51h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_52h] Lieutenant Sinclari (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She told them the Hold needed more security. She_told_them!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54335
			// - HERO_DECK_ID = 2103
			// - HIDE_WATERMARK = 1
			// - 1203 = 50
			// - 1279 = 2338
			// - HEROIC_HERO_POWER = 56030
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_52h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_52h] Lieutenant Sinclari && Test: Lieutenant Sinclari_DALA_BOSS_52h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_53h] Dancin' Deryl (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Can't stop, won't stop, the boogie woogie!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53557
			// - HERO_DECK_ID = 2035
			// - HIDE_WATERMARK = 1
			// - 1205 = 30
			// - 1279 = 2298
			// - HEROIC_HERO_POWER = 56032
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_53h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_53h] Dancin' Deryl && Test: Dancin' Deryl_DALA_BOSS_53h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_54h] Locksmith Zibb (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Mages in Dalaran rely on Zibb's skills to lock up their spells.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54337
			// - HERO_DECK_ID = 2132
			// - HIDE_WATERMARK = 1
			// - 1204 = 30
			// - 1279 = 2318
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_54h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_54h] Locksmith Zibb && Test: Locksmith Zibb_DALA_BOSS_54h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_55h] Captain Hannigan (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Guards!
			//       GUARDS!!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54339
			// - HERO_DECK_ID = 2107
			// - HIDE_WATERMARK = 1
			// - 1204 = 15
			// - 1279 = 2319
			// - HEROIC_HERO_POWER = 56033
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_55h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_55h] Captain Hannigan && Test: Captain Hannigan_DALA_BOSS_55h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_56h] Queen Wagtoggle (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>The kobold Queen is ALSO robbing the bank. And your minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54341
			// - HERO_DECK_ID = 2177
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - 1279 = 2320
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_56h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_56h] Queen Wagtoggle && Test: Queen Wagtoggle_DALA_BOSS_56h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_57h] Trade Prince Gallywix (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>The goblin Prince has rigged the market. Against you.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54343
			// - HERO_DECK_ID = 2178
			// - HIDE_WATERMARK = 1
			// - 1202 = 10
			// - 1279 = 2296
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_57h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_57h] Trade Prince Gallywix && Test: Trade Prince Gallywix_DALA_BOSS_57h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_58h] Boommaster Flark (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Former Boom protégé, Flark has a blast messing_with_minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54345
			// - HERO_DECK_ID = 2126
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - 1279 = 2321
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_58h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_58h] Boommaster Flark && Test: Boommaster Flark_DALA_BOSS_58h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_BOSS_59h] Madam Goya (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>"Extortion" is such an ugly word. Goya prefers "Licensing_Fees."</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54347
			// - HERO_DECK_ID = 2191
			// - HIDE_WATERMARK = 1
			// - 1205 = 10
			// - 1279 = 2322
			// - HEROIC_HERO_POWER = 56034
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59h] Madam Goya && Test: Madam Goya_DALA_BOSS_59h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_60h] Archmage Khadgar (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Ingenuous. Inscrutable. Indefatigable. In..._your..._way.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54349
			// - HERO_DECK_ID = 2128
			// - HIDE_WATERMARK = 1
			// - 1206 = 10
			// - 1279 = 2323
			// - HEROIC_HERO_POWER = 56035
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_60h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_60h] Archmage Khadgar && Test: Archmage Khadgar_DALA_BOSS_60h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_61h] Sael'orn (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Traps prey like a spider... toys with
			//       them_like_a_demon.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54351
			// - HERO_DECK_ID = 2117
			// - HIDE_WATERMARK = 1
			// - 1203 = 10
			// - 1279 = 2324
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_61h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_61h] Sael'orn && Test: Sael'orn_DALA_BOSS_61h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_BOSS_62h] Haro Setting-Sun (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>With one hoof in the shadows, weakness is his strength.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54353
			// - HERO_DECK_ID = 2116
			// - HIDE_WATERMARK = 1
			// - 1201 = 5
			// - 1206 = 10
			// - 1279 = 2274
			// - HEROIC_HERO_POWER = 56036
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_62h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_62h] Haro Setting-Sun && Test: Haro Setting-Sun_DALA_BOSS_62h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_63h] Dagg Cruelmight (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>You never kick a man when he's down.
			//       Unless_you're_Dagg.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54355
			// - HERO_DECK_ID = 2115
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2325
			// - HEROIC_HERO_POWER = 56037
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_63h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_63h] Dagg Cruelmight && Test: Dagg Cruelmight_DALA_BOSS_63h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_BOSS_64h] Banker Biggs (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>His minions are compound-interesting.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54357
			// - HERO_DECK_ID = 2113
			// - HIDE_WATERMARK = 1
			// - 1202 = 30
			// - 1279 = 2326
			// - HEROIC_HERO_POWER = 56256
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_64h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_64h] Banker Biggs && Test: Banker Biggs_DALA_BOSS_64h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_65h] Valdera Highborne (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>His smile is disarming, but his fancy armor is the real threat.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54359
			// - HERO_DECK_ID = 2114
			// - HIDE_WATERMARK = 1
			// - 1202 = 30
			// - 1279 = 2327
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_65h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_65h] Valdera Highborne && Test: Valdera Highborne_DALA_BOSS_65h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_66h] Marei Loom (*) - COST:0 [ATK:0/HP:10] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She'll exploit your finances, but she won't finance_your_exploits.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54361
			// - HERO_DECK_ID = 2133
			// - HIDE_WATERMARK = 1
			// - 1202 = 20
			// - 1279 = 2328
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_66h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_66h] Marei Loom && Test: Marei Loom_DALA_BOSS_66h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_67h] Archmage Vargoth (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Trapped for years in Outland, Vargoth found new_sources_of_magic.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54438
			// - HERO_DECK_ID = 2127
			// - HIDE_WATERMARK = 1
			// - 1206 = 10
			// - 1279 = 2336
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_67h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_67h] Archmage Vargoth && Test: Archmage Vargoth_DALA_BOSS_67h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_68h] Lilayell Suntear (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She makes the instability of the universe_work_for_her.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54440
			// - HERO_DECK_ID = 2112
			// - HIDE_WATERMARK = 1
			// - 1206 = 30
			// - 1279 = 2329
			// - HEROIC_HERO_POWER = 56038
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_68h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_68h] Lilayell Suntear && Test: Lilayell Suntear_DALA_BOSS_68h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_BOSS_69h] Archmage Kalec (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>It's just a matter of time before he's the next Malygos.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54363
			// - HERO_DECK_ID = 2267
			// - HIDE_WATERMARK = 1
			// - 1206 = 10
			// - 1279 = 2264
			// - HEROIC_HERO_POWER = 56039
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_69h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_69h] Archmage Kalec && Test: Archmage Kalec_DALA_BOSS_69h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [DALA_BOSS_70h] Sky Captain Smiggs (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>The only thing bigger than his moustache is his broadside.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54365
			// - HERO_DECK_ID = 2120
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2330
			// - HEROIC_HERO_POWER = 56040
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_70h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_70h] Sky Captain Smiggs && Test: Sky Captain Smiggs_DALA_BOSS_70h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_BOSS_71h] Anarii Duskgrove (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This druid speaks for the trees, and they have nothing_nice_to_say.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54442
			// - HERO_DECK_ID = 2109
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2295
			// - HEROIC_HERO_POWER = 56041
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_71h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_71h] Anarii Duskgrove && Test: Anarii Duskgrove_DALA_BOSS_71h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_72h] Kazamon Steelskin (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>To say he's reckless is an understatement. Zero_recks_are_given.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54444
			// - HERO_DECK_ID = 2108
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2332
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_72h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_72h] Kazamon Steelskin && Test: Kazamon Steelskin_DALA_BOSS_72h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_BOSS_73h] Hesutu Stonewind (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>This shaman has a way of whipping his minions into a frenzy.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54446
			// - HERO_DECK_ID = 2110
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2331
			// - HEROIC_HERO_POWER = 56042
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_73h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_73h] Hesutu Stonewind && Test: Hesutu Stonewind_DALA_BOSS_73h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_BOSS_74h] Kara Stamper (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>She would sell a soul for more minions. Not hers, of course.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54448
			// - HERO_DECK_ID = 2111
			// - HIDE_WATERMARK = 1
			// - 1201 = 10
			// - 1279 = 2333
			// - HEROIC_HERO_POWER = 56357
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_74h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_74h] Kara Stamper && Test: Kara Stamper_DALA_BOSS_74h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_75h] Commander Bolan (*) - COST:0 [ATK:0/HP:30] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Be careful, he's got an enormous exclamation point_over_his_head.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 54450
			// - HERO_DECK_ID = 2355
			// - 1206 = 2
			// - 1279 = 2356
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75h", new CardDef(new Power
			{
				// TODO [DALA_BOSS_75h] Commander Bolan && Test: Commander Bolan_DALA_BOSS_75h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_98h] Bartendotron (*) - COST:0 [ATK:0/HP:40] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Sometimes you want to go where everybody knows your deck.</i>
			// --------------------------------------------------------
			// Entourage: BRM_028, EX1_298, ICC_314, EX1_572, GVG_114, FP1_013, EX1_016
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1572
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_98h", new CardDef(new[] {"BRM_028","EX1_298","ICC_314","EX1_572","GVG_114","FP1_013","EX1_016"}, new Power
			{
				// TODO [DALA_BOSS_98h] Bartendotron && Test: Bartendotron_DALA_BOSS_98h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_BOSS_99h] Bartender Bob (*) - COST:0 [ATK:0/HP:40] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <i>Sometimes you want to go where everybody knows your deck.</i>
			// --------------------------------------------------------
			// Entourage: BRM_028, EX1_298, ICC_314, EX1_572, GVG_114, FP1_013, EX1_016
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1572
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_99h", new CardDef(new[] {"BRM_028","EX1_298","ICC_314","EX1_572","GVG_114","FP1_013","EX1_016"}, new Power
			{
				// TODO [DALA_BOSS_99h] Bartender Bob && Test: Bartender Bob_DALA_BOSS_99h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DALA_Chu] Mr. Chu (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Chu", new CardDef(new Power
			{
				// TODO [DALA_Chu] Mr. Chu && Test: Mr. Chu_DALA_Chu
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DALA_Eudora] Captain Eudora (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 730
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Eudora", new CardDef(new Power
			{
				// TODO [DALA_Eudora] Captain Eudora && Test: Captain Eudora_DALA_Eudora
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [DALA_George] George the Fallen (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 472
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_George", new CardDef(new Power
			{
				// TODO [DALA_George] George the Fallen && Test: George the Fallen_DALA_George
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DALA_Kriziki] Kriziki (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Kriziki", new CardDef(new Power
			{
				// TODO [DALA_Kriziki] Kriziki && Test: Kriziki_DALA_Kriziki
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [DALA_Rakanishu] Rakanishu (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rakanishu", new CardDef(new Power
			{
				// TODO [DALA_Rakanishu] Rakanishu && Test: Rakanishu_DALA_Rakanishu
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [DALA_Squeamlish] Squeamlish (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1123
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Squeamlish", new CardDef(new Power
			{
				// TODO [DALA_Squeamlish] Squeamlish && Test: Squeamlish_DALA_Squeamlish
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DALA_Tekahn] Tekahn (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 300
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Tekahn", new CardDef(new Power
			{
				// TODO [DALA_Tekahn] Tekahn && Test: Tekahn_DALA_Tekahn
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DALA_Vessina] Vessina (*) - COST:0 [ATK:0/HP:15] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 687
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Vessina", new CardDef(new Power
			{
				// TODO [DALA_Vessina] Vessina && Test: Vessina_DALA_Vessina
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_01p] Chomp (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal 1 damage to a minion.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - 858 = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_01p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_01p] Chomp && Test: Chomp_DALA_BOSS_01p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_01px] Chomp (*) - COST:3 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal 2 damage to a minion.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_01px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_01px] Chomp && Test: Chomp_DALA_BOSS_01px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_02p] The Feast (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you cast a spell,
			//       restore #3_Health
			//       to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_02p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_02p] The Feast && Test: The Feast_DALA_BOSS_02p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_02px] The Feast (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you cast a spell,
			//       restore #5_Health
			//       to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_02px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_02px] The Feast && Test: The Feast_DALA_BOSS_02px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_03p] Prestidigitation (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random magical feat to your hand.
			// --------------------------------------------------------
			// Entourage: DALA_BOSS_03t, DALA_BOSS_03t2, DALA_BOSS_03t3, DALA_BOSS_03t4
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2895
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03p", new CardDef(new[] {"DALA_BOSS_03t","DALA_BOSS_03t2","DALA_BOSS_03t3","DALA_BOSS_03t4"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_03p] Prestidigitation && Test: Prestidigitation_DALA_BOSS_03p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_03px] Prestidigitation (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random magical feat to your hand.
			// --------------------------------------------------------
			// Entourage: DALA_BOSS_03t, DALA_BOSS_03t2, DALA_BOSS_03t3, DALA_BOSS_03t4
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03px", new CardDef(new[] {"DALA_BOSS_03t","DALA_BOSS_03t2","DALA_BOSS_03t3","DALA_BOSS_03t4"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_03px] Prestidigitation && Test: Prestidigitation_DALA_BOSS_03px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_04p] Open Wormhole (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Both players summon a minion from their deck. They fight.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2314
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_04p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_04p] Open Wormhole && Test: Open Wormhole_DALA_BOSS_04p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_05p] Mana Echoes (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Cast a random spell that
			//       was cast this game
			//       <i>(targets chosen randomly)</i>
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 46032
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_05p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_05p] Mana Echoes && Test: Mana Echoes_DALA_BOSS_05p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_06p] "Armor Up" (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 2 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_06p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_06p] "Armor Up" && Test: "Armor Up"_DALA_BOSS_06p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_06px] "Tank Up!" (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 4 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2745
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_06px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_06px] "Tank Up!" && Test: "Tank Up!"_DALA_BOSS_06px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_07p] Take Flight! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After taking 15 damage,
			//       Belnaara will take flight.
			//       <i>(@ damage remaining)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 15
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_07p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_07p] Take Flight! && Test: Take Flight!_DALA_BOSS_07p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_07p2] Flying! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Belnaara will land in 2 turns.
			//       <i>(@ turns remaining)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_07p2", new CardDef(new Power
			{
				// TODO [DALA_BOSS_07p2] Flying! && Test: Flying!_DALA_BOSS_07p2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_08p] Apple Toss (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal $1 damage to the
			//       lowest Health enemy.
			//       If it dies, repeat this. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_08p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_08p] Apple Toss && Test: Apple Toss_DALA_BOSS_08p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_08px] Apple Toss (*) - COST:3 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal $2 damage to the
			//       lowest Health enemy.
			//       If it dies, repeat this. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_08px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_08px] Apple Toss && Test: Apple Toss_DALA_BOSS_08px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_09p] Repeat History (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random friendly minion that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 1794
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_TURN = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_09p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_TURN,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_09p] Repeat History && Test: Repeat History_DALA_BOSS_09p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_09px] Repeat History (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random friendly minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2298
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_09px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1},{PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME,0}}, new Power
			{
				// TODO [DALA_BOSS_09px] Repeat History && Test: Repeat History_DALA_BOSS_09px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_10p] Street Smarts (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever you play a Coin, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_10p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_10p] Street Smarts && Test: Street Smarts_DALA_BOSS_10p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_10px] Street Smarts (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Whenever a player plays
			//       a Coin, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_10px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_10px] Street Smarts && Test: Street Smarts_DALA_BOSS_10px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_11p] Backstabber (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Whenever a <b><b>Stealth</b>ed</b>
			//       minion is summoned,
			//       give it +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_11p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_11p] Backstabber && Test: Backstabber_DALA_BOSS_11p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_11px] Backstabber (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Whenever a <b>Stealthed</b>
			//       minion is summoned,
			//       give it +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_11px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_11px] Backstabber && Test: Backstabber_DALA_BOSS_11px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_12p] Forbidden Love (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a random minion for each player.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2537
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_12p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [DALA_BOSS_12p] Forbidden Love && Test: Forbidden Love_DALA_BOSS_12p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_12px] Forbidden Love (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a random minion for each player.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2537
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_12px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [DALA_BOSS_12px] Forbidden Love && Test: Forbidden Love_DALA_BOSS_12px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_13p] Slice and Dice (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1-$3 damage to three random minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2058
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_13p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [DALA_BOSS_13p] Slice and Dice && Test: Slice and Dice_DALA_BOSS_13p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_14p] Order Up! (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 2/2 Kind Waitress.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 42457
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_14p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_14p] Order Up! && Test: Order Up!_DALA_BOSS_14p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_14px] Order Up! (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 2/2 Kind Waitresses.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_14px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_14px] Order Up! && Test: Order Up!_DALA_BOSS_14px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_15p] Blessing of Elune (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All healing is doubled.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_15p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_15p] Blessing of Elune && Test: Blessing of Elune_DALA_BOSS_15p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_16p] Equivalent Exchange (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Swap a random card in each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_16p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_16p] Equivalent Exchange && Test: Equivalent Exchange_DALA_BOSS_16p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_16px] Equivalent Exchange (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Swap a random card in each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_16px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_16px] Equivalent Exchange && Test: Equivalent Exchange_DALA_BOSS_16px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_17p] Twin Paths (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Your <b>Choose One</b> cards
			//       and powers have both
			//       effects combined.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_17p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_17p] Twin Paths && Test: Twin Paths_DALA_BOSS_17p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_18p] Totemic Summons (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon ANY random Totem.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 38725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_18p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_18p] Totemic Summons && Test: Totemic Summons_DALA_BOSS_18p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_18px] Totemic Summons (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon ANY random Totem.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_18px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_18px] Totemic Summons && Test: Totemic Summons_DALA_BOSS_18px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_19p] Lil' Eviscerate (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage
			//       <b>Combo:</b> 2 instead.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// - 858 = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_19p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_19p] Lil' Eviscerate && Test: Lil' Eviscerate_DALA_BOSS_19p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_19px] Lil' Eviscerate (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage
			//       <b>Combo:</b> 2 instead.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_19px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_19px] Lil' Eviscerate && Test: Lil' Eviscerate_DALA_BOSS_19px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_20p] Stormswell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your spells with <b>Overload</b> cast twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_20p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_20p] Stormswell && Test: Stormswell_DALA_BOSS_20p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_20px] Stormswell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your spells with <b>Overload</b> cast thrice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_20px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_20px] Stormswell && Test: Stormswell_DALA_BOSS_20px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_21p] Prediction (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a random class <b>Secret</b> into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 41139
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_21p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_21p] Prediction && Test: Prediction_DALA_BOSS_21p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_22p] Shhh! (*) - COST:3 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Silence</b> ALL minions.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 1189
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_22p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_22p] Shhh! && Test: Shhh!_DALA_BOSS_22p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_22px] Shhh! (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After a minion is summoned, <b>Silence</b> it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_22px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_22px] Shhh! && Test: Shhh!_DALA_BOSS_22px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_23p] Sharkbite (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a random damaged minion.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 41425
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_23p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_23p] Sharkbite && Test: Sharkbite_DALA_BOSS_23p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_23px] Sharkbite (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a random damaged enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_23px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_23px] Sharkbite && Test: Sharkbite_DALA_BOSS_23px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_24p] Ar'ha's Call (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Your next <b>Battlecry</b> triggers an additional time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_24p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_24p] Ar'ha's Call && Test: Ar'ha's Call_DALA_BOSS_24p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_24px] Ar'ha's Call (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Your next <b>Battlecry</b> triggers an additional time.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_24px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_24px] Ar'ha's Call && Test: Ar'ha's Call_DALA_BOSS_24px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_25p] Assembly (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After a player draws a
			//       minion, they summon
			//       a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_25p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_25p] Assembly && Test: Assembly_DALA_BOSS_25p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_25px] Assembly (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you draw a minion,
			//       summon a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_25px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_25px] Assembly && Test: Assembly_DALA_BOSS_25px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_26p] Cold Water (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       <b>Freeze</b> the first minion that attacks you each turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_26p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_26p] Cold Water && Test: Cold Water_DALA_BOSS_26p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_26px] Cold Water (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After a minion attacks you, <b>Freeze</b> it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_26px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_26px] Cold Water && Test: Cold Water_DALA_BOSS_26px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_27p] Masterpiece! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Spend all your Mana.
			//       Summon a random minion
			//       that costs that much.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 38434
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_27p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_27p] Masterpiece! && Test: Masterpiece!_DALA_BOSS_27p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_28p] Scroll Savvy (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Spells cost (0) the turn they are drawn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_28p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_28p] Scroll Savvy && Test: Scroll Savvy_DALA_BOSS_28p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_29p] Excavate (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage to a friendly Elemental. Find out what's inside.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 47033
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_RACE = 18
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_29p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_TARGET_WITH_RACE,18},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_29p] Excavate && Test: Excavate_DALA_BOSS_29p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_30p] A Tale of Kings (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon an Underbelly Rat.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 50731
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_30p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_30p] A Tale of Kings && Test: A Tale of Kings_DALA_BOSS_30p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_31p] Bling it On! (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Make a minion Golden. If it's already Golden, give it +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 38749
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_31p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_31p] Bling it On! && Test: Bling it On!_DALA_BOSS_31p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_31px] Bling it On! (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Make a minion Golden. If it's already Golden, give it +8/+8.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_31px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_31px] Bling it On! && Test: Bling it On!_DALA_BOSS_31px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [DALA_BOSS_32p] Makeover (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion a random haircut.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_32p] Makeover && Test: Makeover_DALA_BOSS_32p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_33p] Made of Coins (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever you take damage, add a Coin
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_33p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_33p] Made of Coins && Test: Made of Coins_DALA_BOSS_33p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_34p] Merry Go Round (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       At the end of your turn,
			//       merrily rotate all minions
			//       around the board.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_34p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_34p] Merry Go Round && Test: Merry Go Round_DALA_BOSS_34p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_35p] Healing Hands (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       At the start of your turn,
			//       restore #2 Health to
			//       all friendly minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_35p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_35p] Healing Hands && Test: Healing Hands_DALA_BOSS_35p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_35px] Healing Hands (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       At the start of your turn,
			//       restore all friendly
			//       minions to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_35px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_35px] Healing Hands && Test: Healing Hands_DALA_BOSS_35px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_36p] Import "Pet" (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Craft a custom Exotic Pet.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43183
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_36p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_BOSS_36p] Import "Pet" && Test: Import "Pet"_DALA_BOSS_36p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_36px] Import "Pet" (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Craft a custom Exotic Pet.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43183
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_36px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_BOSS_36px] Import "Pet" && Test: Import "Pet"_DALA_BOSS_36px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_37p] Tales of Fortune (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Shuffle a random old Treasure into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2951
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_37p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_37p] Tales of Fortune && Test: Tales of Fortune_DALA_BOSS_37p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_37px] Tales of Fortune (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Shuffle three random old Treasure into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_37px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_37px] Tales of Fortune && Test: Tales of Fortune_DALA_BOSS_37px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_38p] Portal Party (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Portal to your hand.
			// --------------------------------------------------------
			// Entourage: GVG_003, KAR_077, KAR_075, KAR_073, KAR_091, KAR_076, DALA_BOSS_38t
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 39169
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_38p", new CardDef(new[] {"GVG_003","KAR_077","KAR_075","KAR_073","KAR_091","KAR_076","DALA_BOSS_38t"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_BOSS_38p] Portal Party && Test: Portal Party_DALA_BOSS_38p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_38px] Portal Party (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Portal to your hand.
			// --------------------------------------------------------
			// Entourage: GVG_003, KAR_077, KAR_075, KAR_073, KAR_091, KAR_076, DALA_BOSS_38t
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_38px", new CardDef(new[] {"GVG_003","KAR_077","KAR_075","KAR_073","KAR_091","KAR_076","DALA_BOSS_38t"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_BOSS_38px] Portal Party && Test: Portal Party_DALA_BOSS_38px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_39p] For The Light! (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 46346
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_39p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_39p] For The Light! && Test: For The Light!_DALA_BOSS_39p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_40p] Immolation Aura (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After a minion attacks you,
			//       deal 2 damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_40p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_40p] Immolation Aura && Test: Immolation Aura_DALA_BOSS_40p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_40px] Immolation Aura (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After a minion attacks you,
			//       deal 3 damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_40px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_40px] Immolation Aura && Test: Immolation Aura_DALA_BOSS_40px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_41p] Summon Companion (*) - COST:4 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random
			//       Animal Companion.
			// --------------------------------------------------------
			// Entourage: NEW1_034, NEW1_032, NEW1_033
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 437
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_41p", new CardDef(new[] {"NEW1_034","NEW1_032","NEW1_033"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_41p] Summon Companion && Test: Summon Companion_DALA_BOSS_41p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_41px] Summon Companions (*) - COST:5 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two random
			//       Animal Companions.
			// --------------------------------------------------------
			// Entourage: NEW1_034, NEW1_032, NEW1_033
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_41px", new CardDef(new[] {"NEW1_034","NEW1_032","NEW1_033"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [DALA_BOSS_41px] Summon Companions && Test: Summon Companions_DALA_BOSS_41px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_42p] Pogoshuffle (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Choose a minion. Shuffle 3 copies of it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 2304
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_42p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_42p] Pogoshuffle && Test: Pogoshuffle_DALA_BOSS_42p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_42px] Pogoshuffle (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Choose a minion. Shuffle 3 copies of it into your deck. Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_42px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_42px] Pogoshuffle && Test: Pogoshuffle_DALA_BOSS_42px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_43p] Kaironomaly (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your opponent has 25 seconds to take their turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_43p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_43p] Kaironomaly && Test: Kaironomaly_DALA_BOSS_43p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_44p] Dark Tidings (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Reveal a minion from your
			//       deck. Give it +2/+2 and
			//       put it on top.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 40743
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_44p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_44p] Dark Tidings && Test: Dark Tidings_DALA_BOSS_44p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_44px] Dark Tidings (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Reveal a minion from your
			//       deck. Give it +4/+4 and
			//       put it on top.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 40743
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_44px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_44px] Dark Tidings && Test: Dark Tidings_DALA_BOSS_44px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_45p] Ray of Suffering (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal @ damage to
			//       the enemy hero.
			//       <i>(increases each use)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - 858 = 45698
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_45p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_45p] Ray of Suffering && Test: Ray of Suffering_DALA_BOSS_45p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_45px] Ray of Suffering (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal @ damage to
			//       the enemy hero.
			//       <i>(increases each use)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_45px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_45px] Ray of Suffering && Test: Ray of Suffering_DALA_BOSS_45px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_46p] Protective Bubble (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Give a friendly minion
			//       <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 727
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_46p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_46p] Protective Bubble && Test: Protective Bubble_DALA_BOSS_46p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_46px] Protective Bubble (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all your minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 46170
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_46px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_46px] Protective Bubble && Test: Protective Bubble_DALA_BOSS_46px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_47p] Lava Belch (*) - COST:1 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 0/3 Molten Rock.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 48700
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_47p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_47p] Lava Belch && Test: Lava Belch_DALA_BOSS_47p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_47px] Lava Belch (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 0/3 Molten Rock.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 48700
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_47px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_47px] Lava Belch && Test: Lava Belch_DALA_BOSS_47px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_48p] To The Void (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Banish a minion to the Void.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 345
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_48p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_48p] To The Void && Test: To The Void_DALA_BOSS_48p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_49p] Uncontrollable Energy (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you cast a spell,
			//       deal $1 damage to all
			//       enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_49p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_49p] Uncontrollable Energy && Test: Uncontrollable Energy_DALA_BOSS_49p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_49px] Uncontrollable Energy (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you cast a spell,
			//       deal $2 damage to all
			//       enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_49px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_49px] Uncontrollable Energy && Test: Uncontrollable Energy_DALA_BOSS_49px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_50p] Sand Breath (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 43502
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_50p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_50p] Sand Breath && Test: Sand Breath_DALA_BOSS_50p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_50px] Sand Breath (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $4 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - 858 = 43502
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_50px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_50px] Sand Breath && Test: Sand Breath_DALA_BOSS_50px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_51p] Tinker (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 0/4 Squirrel Bomb.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 49161
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_51p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_51p] Tinker && Test: Tinker_DALA_BOSS_51p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_52p] Hold the Gates! (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 213
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_52p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_52p] Hold the Gates! && Test: Hold the Gates!_DALA_BOSS_52p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_52px] Hold the Gates! (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 213
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_52px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_52px] Hold the Gates! && Test: Hold the Gates!_DALA_BOSS_52px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_53p] Boogie Woogie (*) - COST:3 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Give a friendly minion
			//        "<b>Deathrattle:</b> Resummon
			//        this minion."
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 404
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_53p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_53p] Boogie Woogie && Test: Boogie Woogie_DALA_BOSS_53p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_53px] Boogie Woogie (*) - COST:2 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Give a friendly minion
			//        "<b>Deathrattle:</b> Resummon
			//        this minion."
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 404
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_53px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_53px] Boogie Woogie && Test: Boogie Woogie_DALA_BOSS_53px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_54p] Spell Lock (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Spells <b>Overload</b> for their cost.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_54p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_54p] Spell Lock && Test: Spell Lock_DALA_BOSS_54p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_55p] Raise the Alarm (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/4
			//       Kirin Tor Guard.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_55p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_55p] Raise the Alarm && Test: Raise the Alarm_DALA_BOSS_55p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_55px] Raise the Alarm (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/4
			//       Kirin Tor Guard.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_55px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_55px] Raise the Alarm && Test: Raise the Alarm_DALA_BOSS_55px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_56p] Bribery (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a minion from your opponent's deck. When it dies, give it back.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_56p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_56p] Bribery && Test: Bribery_DALA_BOSS_56p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_57p] Greed is Good (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Buy a copy of the first card your opponent plays each turn for a Coin.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_57p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_57p] Greed is Good && Test: Greed is Good_DALA_BOSS_57p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_58p] Blast Powder (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Coat a minion in Blast
			//       Powder. When it takes
			//       damage, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 982
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_58p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_58p] Blast Powder && Test: Blast Powder_DALA_BOSS_58p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_59p] Blackmail (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Replace a random card in
			//       your opponent's hand
			//       with an 'Extortion.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59p] Blackmail && Test: Blackmail_DALA_BOSS_59p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_59px] Blackmail (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Replace a random card in
			//       your opponent's hand
			//       with an 'Extortion.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59px] Blackmail && Test: Blackmail_DALA_BOSS_59px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_60p] Summon Elemental (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 2/3 Elemental.
			//       It copies your spells.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43345
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_60p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_60p] Summon Elemental && Test: Summon Elemental_DALA_BOSS_60p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_60px] Summon Elemental (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 2/3 Elemental.
			//       It copies your spells.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43345
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_60px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_60px] Summon Elemental && Test: Summon Elemental_DALA_BOSS_60px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_61p] Web Grab (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Your opponent summons a minion from their hand.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 41567
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_61p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_61p] Web Grab && Test: Web Grab_DALA_BOSS_61p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_62p] Darken (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all minions -2_Attack until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 47555
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_62p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_62p] Darken && Test: Darken_DALA_BOSS_62p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_62px] Darken (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your opponent's minions have -1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_62px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_62px] Darken && Test: Darken_DALA_BOSS_62px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_63p] Bully (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to a damaged minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 877
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_63p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_DAMAGED_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_63p] Bully && Test: Bully_DALA_BOSS_63p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_63px] Bully (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $4 damage to a damaged minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 877
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_DAMAGED_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_63px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_DAMAGED_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_63px] Bully && Test: Bully_DALA_BOSS_63px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_64p] Invest! (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Return a friendly minion to your hand. Give it +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 365
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_64p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_64p] Invest! && Test: Invest!_DALA_BOSS_64p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_64px] Invest! (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Return a friendly minion to your hand, then give it +4/+4 and copy it.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 365
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_64px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_64px] Invest! && Test: Invest!_DALA_BOSS_64px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_65p] Impervious (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your hero can only take up to 3 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_65p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_65p] Impervious && Test: Impervious_DALA_BOSS_65p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_66p] Next... (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Swap the left-most card in
			//       each player's hand with
			//       one in their deck.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_66p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_66p] Next... && Test: Next..._DALA_BOSS_66p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_67p] Arcane Runes (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Arcane spell to your hand.
			// --------------------------------------------------------
			// Entourage: AT_004, CFM_623, EX1_277, CS2_023, CS2_025
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 39169
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_67p", new CardDef(new[] {"AT_004","CFM_623","EX1_277","CS2_023","CS2_025"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_BOSS_67p] Arcane Runes && Test: Arcane Runes_DALA_BOSS_67p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_68p] Mini Portal (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After you cast a spell, summon a random 1-cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_68p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_68p] Mini Portal && Test: Mini Portal_DALA_BOSS_68p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_68px] Mega Portal (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After you cast a spell, summon a random minion of the same cost.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_68px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_68px] Mega Portal && Test: Mega Portal_DALA_BOSS_68px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_69p] Dragonwrath (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your Hero
			//       <b>Spell Damage +1</b>.
			//       <i>(+@ currently)</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_69p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_69p] Dragonwrath && Test: Dragonwrath_DALA_BOSS_69p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_69px] Dragonwrath (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your Hero
			//       <b>Spell Damage +1</b>.
			//       <i>(+@ currently)</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_69px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_69px] Dragonwrath && Test: Dragonwrath_DALA_BOSS_69px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_70p] Bombardment (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to all minions. Takes 2 turns to reload. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 40297
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_70p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_70p] Bombardment && Test: Bombardment_DALA_BOSS_70p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_70px] Bombardment (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage to all enemy minions. Takes 2 turns to reload. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 40297
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_70px", new CardDef(new Power
			{
				// TODO [DALA_BOSS_70px] Bombardment && Test: Bombardment_DALA_BOSS_70px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_71p] Summon Protectors (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 2/2 Treant with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 42457
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_71p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_71p] Summon Protectors && Test: Summon Protectors_DALA_BOSS_71p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_71px] Summon Protectors (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 2/2 Treants with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 42457
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_71px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_71px] Summon Protectors && Test: Summon Protectors_DALA_BOSS_71px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_72p] Steelskin (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       You can't damage yourself.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_72p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_72p] Steelskin && Test: Steelskin_DALA_BOSS_72p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_73p] Earthmother's Rage (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 51
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_73p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_73p] Earthmother's Rage && Test: Earthmother's Rage_DALA_BOSS_73p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_73px] Earthmother's Rage (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion <b>Mega-Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 51
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - MEGA_WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_73px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_73px] Earthmother's Rage && Test: Earthmother's Rage_DALA_BOSS_73px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_74p] Soul Weave (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Discard a card. Summon a random minion of the same cost.
			// --------------------------------------------------------
			// GameTag:
			// - DISCARD_CARDS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_74p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_74p] Soul Weave && Test: Soul Weave_DALA_BOSS_74p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_74px] Soul Weave (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Discard a card. Summon a random minion of the same cost.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 54448
			// - DISCARD_CARDS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_74px", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_74px] Soul Weave && Test: Soul Weave_DALA_BOSS_74px
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [DALA_BOSS_75p] A Quest! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your opponent a Quest!
			// --------------------------------------------------------
			// GameTag:
			// - 759 = 999
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75p", new CardDef(new Power
			{
				// TODO [DALA_BOSS_75p] A Quest! && Test: A Quest!_DALA_BOSS_75p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - DRUID
			// [DALA_Druid_HP1] Lifebloom (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore a minion to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Druid_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Druid_HP1] Lifebloom && Test: Lifebloom_DALA_Druid_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - DRUID
			// [DALA_Druid_HP2] Touch of Bark (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Druid_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Druid_HP2] Touch of Bark && Test: Touch of Bark_DALA_Druid_HP2
				InfoCardId = "DALA_Druid_HP2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - HUNTER
			// [DALA_Hunter_HP1] Opportunist (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion +2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Hunter_HP1] Opportunist && Test: Opportunist_DALA_Hunter_HP1
				InfoCardId = "DALA_Hunter_HP1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - HUNTER
			// [DALA_Hunter_HP2] Pet Training (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a 1/1 Shifting Chameleon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_Hunter_HP2] Pet Training && Test: Pet Training_DALA_Hunter_HP2
				InfoCardId = "DALA_Hunter_HP2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------- HERO_POWER - MAGE
			// [DALA_Mage_HP1] Burning Wit (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Reduce the cost of a
			//       random card in your
			//       hand by (2).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Mage_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Mage_HP1] Burning Wit && Test: Burning Wit_DALA_Mage_HP1
				InfoCardId = "DALA_Mage_HP1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------- HERO_POWER - MAGE
			// [DALA_Mage_HP2] Frostburn (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Freeze</b> a character.
			//       If it's already <b>Frozen</b>, deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_Mage_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_Mage_HP2] Frostburn && Test: Frostburn_DALA_Mage_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - PALADIN
			// [DALA_Paladin_HP1] Backup (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add three 1/1 Silver Hand Recruits to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_Paladin_HP1] Backup && Test: Backup_DALA_Paladin_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - PALADIN
			// [DALA_Paladin_HP2] Boon of Light (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a friendly minion <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_Paladin_HP2] Boon of Light && Test: Boon of Light_DALA_Paladin_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [DALA_Priest_HP1] Distort (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_Priest_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_Priest_HP1] Distort && Test: Distort_DALA_Priest_HP1
				InfoCardId = "DALA_Priest_HP1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [DALA_Priest_HP2] Soothe (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion -2_Attack until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_Priest_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_Priest_HP2] Soothe && Test: Soothe_DALA_Priest_HP2
				InfoCardId = "DALA_Priest_HP2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [DALA_Rogue_HP1] Yoink! (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Add a random
			//       card to your hand
			//       <i>(from another class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_HAND_NOT_FULL,0}}, new Power
			{
				// TODO [DALA_Rogue_HP1] Yoink! && Test: Yoink!_DALA_Rogue_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [DALA_Rogue_HP2] Cut-less (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to an undamaged minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_UNDAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_UNDAMAGED_TARGET,0}}, new Power
			{
				// TODO [DALA_Rogue_HP2] Cut-less && Test: Cut-less_DALA_Rogue_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - SHAMAN
			// [DALA_Shaman_HP1] Evolution (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Transform a friendly minion into one that costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_Shaman_HP1] Evolution && Test: Evolution_DALA_Shaman_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - SHAMAN
			// [DALA_Shaman_HP2] Refresh (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card.
			//       <b>Overload:</b> (1).
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_HP2", new CardDef(new Power
			{
				// TODO [DALA_Shaman_HP2] Refresh && Test: Refresh_DALA_Shaman_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [DALA_Warlock_HP1] Pain Split (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Take $2 damage.
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_Warlock_HP1] Pain Split && Test: Pain Split_DALA_Warlock_HP1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [DALA_Warlock_HP2] The Pact (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Take $2 damage.
			//       Summon a 2/2 Imp. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_Warlock_HP2] The Pact && Test: The Pact_DALA_Warlock_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [DALA_Warrior_HP1] Invigorating Brew (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal $1 damage to
			//       a minion and give
			//       it +2_Attack. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_HP1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Warrior_HP1] Invigorating Brew && Test: Invigorating Brew_DALA_Warrior_HP1
				InfoCardId = "DALA_Warrior_HP1e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [DALA_Warrior_HP2] Undermine (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Shuffle two Explosives
			//       into your opponent's
			//       deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_HP2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_Warrior_HP2] Undermine && Test: Undermine_DALA_Warrior_HP2
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [DALA_801] Random Druid Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_801", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_801] Random Druid Deck && Test: Random Druid Deck_DALA_801
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_01] Swarm (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_354, CS2_188, FP1_003, FP1_002, GVG_104, ICC_808, EX1_597, KAR_044, OG_313, AT_037, CFM_614, DAL_733, EX1_160, DAL_351, CS2_011, OG_195, DAL_256
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_01", new CardDef(new[] {"DAL_354","CS2_188","FP1_003","FP1_002","GVG_104","ICC_808","EX1_597","KAR_044","OG_313","AT_037","CFM_614","DAL_733","EX1_160","DAL_351","CS2_011","OG_195","DAL_256"}, new Power
			{
				// TODO [DALA_Druid_01] Swarm && Test: Swarm_DALA_Druid_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_02] Recovery (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_544, CFM_120, CS2_117, LOOT_388, DAL_355, GIL_622, GVG_069, GIL_667, DAL_799, NEW1_008, DAL_357, DAL_350, DAL_733, CS2_007, KAR_075, GVG_033
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_02", new CardDef(new[] {"DAL_544","CFM_120","CS2_117","LOOT_388","DAL_355","GIL_622","GVG_069","GIL_667","DAL_799","NEW1_008","DAL_357","DAL_350","DAL_733","CS2_007","KAR_075","GVG_033"}, new Power
			{
				// TODO [DALA_Druid_02] Recovery && Test: Recovery_DALA_Druid_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_03] Choices, Choices (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: AT_042, ICC_051, DAL_732, GIL_188, TRL_343, OG_044, EX1_165, EX1_178, CFM_308, DAL_350, CFM_602, AT_037, LOE_115, EX1_154, GVG_041, OG_195, ICC_832
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_03", new CardDef(new[] {"AT_042","ICC_051","DAL_732","GIL_188","TRL_343","OG_044","EX1_165","EX1_178","CFM_308","DAL_350","CFM_602","AT_037","LOE_115","EX1_154","GVG_041","OG_195","ICC_832"}, new Power
			{
				// TODO [DALA_Druid_03] Choices, Choices && Test: Choices, Choices_DALA_Druid_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_04] All Bark (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_419, TRL_341, BOT_422, NEW1_008, EX1_178, EX1_573, BOT_523, GIL_663, BOT_420, AT_044, FP1_019, EX1_158, EX1_571, UNG_111, DAL_256, LOOT_392
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_04", new CardDef(new[] {"BOT_419","TRL_341","BOT_422","NEW1_008","EX1_178","EX1_573","BOT_523","GIL_663","BOT_420","AT_044","FP1_019","EX1_158","EX1_571","UNG_111","DAL_256","LOOT_392"}, new Power
			{
				// TODO [DALA_Druid_04] All Bark && Test: All Bark_DALA_Druid_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_05] Nature's Wrath (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_012, EX1_284, AT_127, EX1_095, DAL_774, EX1_563, KAR_711, OG_134, EX1_161, AT_037, DAL_733, DAL_352, EX1_154, CS2_012, NEW1_007, EX1_173, DAL_256, ICC_085
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_05", new CardDef(new[] {"EX1_012","EX1_284","AT_127","EX1_095","DAL_774","EX1_563","KAR_711","OG_134","EX1_161","AT_037","DAL_733","DAL_352","EX1_154","CS2_012","NEW1_007","EX1_173","DAL_256","ICC_085"}, new Power
			{
				// TODO [DALA_Druid_05] Nature's Wrath && Test: Nature's Wrath_DALA_Druid_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_06] Feral Bite (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: TRL_223, TRL_240, AT_039, LOOT_048, EX1_116, TRL_241, TRL_243, LOOT_051, UNG_108, CS2_005, GIL_637, EX1_570, CS2_012, OG_047, LOOT_054
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_06", new CardDef(new[] {"TRL_223","TRL_240","AT_039","LOOT_048","EX1_116","TRL_241","TRL_243","LOOT_051","UNG_108","CS2_005","GIL_637","EX1_570","CS2_012","OG_047","LOOT_054"}, new Power
			{
				// TODO [DALA_Druid_06] Feral Bite && Test: Feral Bite_DALA_Druid_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_07] Nurture and Grow (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_096, AT_038, EX1_050, LOOT_351, GVG_032, OG_202, GIL_833, EX1_284, NEW1_008, BRM_031, BOT_444, BOT_054, CFM_713, EX1_164, ICC_085
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_07", new CardDef(new[] {"EX1_096","AT_038","EX1_050","LOOT_351","GVG_032","OG_202","GIL_833","EX1_284","NEW1_008","BRM_031","BOT_444","BOT_054","CFM_713","EX1_164","ICC_085"}, new Power
			{
				// TODO [DALA_Druid_07] Nurture and Grow && Test: Nurture and Grow_DALA_Druid_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_08] Roar! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_623, UNG_087, KAR_702, GVG_035, LOOT_153, GVG_080, UNG_086, TRL_232, TRL_550, BOT_423, UNG_099, TRL_542, UNG_852, GIL_571, TRL_244, TRL_255
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_08", new CardDef(new[] {"GIL_623","UNG_087","KAR_702","GVG_035","LOOT_153","GVG_080","UNG_086","TRL_232","TRL_550","BOT_423","UNG_099","TRL_542","UNG_852","GIL_571","TRL_244","TRL_255"}, new Power
			{
				// TODO [DALA_Druid_08] Roar! && Test: Roar!_DALA_Druid_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_09] Protectors (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_072, EX1_093, ICC_466, ICC_807, FP1_012, GIL_623, LOOT_383, CFM_343, DAL_357, DAL_560, ICC_314, UNG_848, ICC_835, CS2_009, ICC_054
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_09", new CardDef(new[] {"UNG_072","EX1_093","ICC_466","ICC_807","FP1_012","GIL_623","LOOT_383","CFM_343","DAL_357","DAL_560","ICC_314","UNG_848","ICC_835","CS2_009","ICC_054"}, new Power
			{
				// TODO [DALA_Druid_09] Protectors && Test: Protectors_DALA_Druid_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_10] Beasts and Buffs (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_300, LOOT_258, TRL_505, GIL_558, FP1_002, LOE_029, GIL_143, OG_313, LOE_050, UNG_075, AT_040, CFM_816, OG_048, CS2_009, EX1_155, UNG_103, TRL_254, GVG_041
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_10", new CardDef(new[] {"KAR_300","LOOT_258","TRL_505","GIL_558","FP1_002","LOE_029","GIL_143","OG_313","LOE_050","UNG_075","AT_040","CFM_816","OG_048","CS2_009","EX1_155","UNG_103","TRL_254","GVG_041"}, new Power
			{
				// TODO [DALA_Druid_10] Beasts and Buffs && Test: Beasts and Buffs_DALA_Druid_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_11] Big Friends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_109, NEW1_008, EX1_178, UNG_086, TRL_232, TRL_528, BOT_552, CS2_232, BOT_507, ICC_705, BRM_031, NEW1_038, OG_173, DAL_553, AT_045, UNG_078, LOOT_233
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_11", new CardDef(new[] {"UNG_109","NEW1_008","EX1_178","UNG_086","TRL_232","TRL_528","BOT_552","CS2_232","BOT_507","ICC_705","BRM_031","NEW1_038","OG_173","DAL_553","AT_045","UNG_078","LOOT_233"}, new Power
			{
				// TODO [DALA_Druid_11] Big Friends && Test: Big Friends_DALA_Druid_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DALA_Druid_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: TRL_343, BOT_434, FP1_030, LOOT_329, CFM_902, EX1_110, BRM_028, EX1_016, FP1_013, GVG_110, GVG_035, GVG_118, EX1_298, GVG_114, ICC_314, EX1_572, AT_045, EX1_573, CFM_308, UNG_852
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_12", new CardDef(new[] {"TRL_343","BOT_434","FP1_030","LOOT_329","CFM_902","EX1_110","BRM_028","EX1_016","FP1_013","GVG_110","GVG_035","GVG_118","EX1_298","GVG_114","ICC_314","EX1_572","AT_045","EX1_573","CFM_308","UNG_852"}, new Power
			{
				// TODO [DALA_Druid_12] Legends && Test: Legends_DALA_Druid_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [DALA_Hunter_HP2t] Shifting Chameleon (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Each turn this is in your
			//       hand, transform into a
			//       random 1-cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HP2t", new CardDef(new Power
			{
				// TODO [DALA_Hunter_HP2t] Shifting Chameleon && Test: Shifting Chameleon_DALA_Hunter_HP2t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_802] Random Hunter Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_802", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_802] Random Hunter Deck && Test: Random Hunter Deck_DALA_802
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_01] Spells (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_587, DAL_372, DAL_379, KAR_711, DAL_373, DS1_184, UNG_910, AT_061, BRM_013, DAL_371, NEW1_031, EX1_617, DS1_183, LOOT_077, TRL_347, DAL_378, OG_211, LOOT_085, TRL_065
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_01", new CardDef(new[] {"DAL_587","DAL_372","DAL_379","KAR_711","DAL_373","DS1_184","UNG_910","AT_061","BRM_013","DAL_371","NEW1_031","EX1_617","DS1_183","LOOT_077","TRL_347","DAL_378","OG_211","LOOT_085","TRL_065"}, new Power
			{
				// TODO [DALA_Hunter_01] Spells && Test: Spells_DALA_Hunter_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_02] Secretive (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_080, FP1_004, DAL_086, GVG_089, TRL_530, KAR_006, ICC_204, BOT_573, BOT_402, AT_060, KAR_004, EX1_610, EX1_611, EX1_533, GIL_577, LOOT_079, EX1_609, LOOT_080, EX1_536
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_02", new CardDef(new[] {"EX1_080","FP1_004","DAL_086","GVG_089","TRL_530","KAR_006","ICC_204","BOT_573","BOT_402","AT_060","KAR_004","EX1_610","EX1_611","EX1_533","GIL_577","LOOT_079","EX1_609","LOOT_080","EX1_536"}, new Power
			{
				// TODO [DALA_Hunter_02] Secretive && Test: Secretive_DALA_Hunter_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_03] Deathrattle (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_029, OG_292, CFM_316, UNG_900, ICC_021, OG_216, ICC_243, BOT_039, OG_309, LOOT_161, EX1_534, LOOT_520, LOOT_511, TRL_537, OG_133, ICC_052, GVG_026, LOE_105, OG_045, DAL_377
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_03", new CardDef(new[] {"EX1_029","OG_292","CFM_316","UNG_900","ICC_021","OG_216","ICC_243","BOT_039","OG_309","LOOT_161","EX1_534","LOOT_520","LOOT_511","TRL_537","OG_133","ICC_052","GVG_026","LOE_105","OG_045","DAL_377"}, new Power
			{
				// TODO [DALA_Hunter_03] Deathrattle && Test: Deathrattle_DALA_Hunter_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_04] Technological (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_079, BOT_907, GVG_006, GVG_076, BOT_038, BOT_035, GVG_048, BOT_251, GVG_096, DAL_604, BOT_563, BOT_066, DAL_376, BOT_034, GVG_114, BOT_033, BOT_438
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_04", new CardDef(new[] {"BOT_079","BOT_907","GVG_006","GVG_076","BOT_038","BOT_035","GVG_048","BOT_251","GVG_096","DAL_604","BOT_563","BOT_066","DAL_376","BOT_034","GVG_114","BOT_033","BOT_438"}, new Power
			{
				// TODO [DALA_Hunter_04] Technological && Test: Technological_DALA_Hunter_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_05] Big Beasts (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_333, EX1_534, OG_152, TRL_550, ICC_825, GVG_049, UNG_919, LOOT_153, OG_308, LOOT_511, AT_103, EX1_543, TRL_542, GIL_128, GIL_828, DAL_589, BOT_429, ICC_828
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_05", new CardDef(new[] {"CFM_333","EX1_534","OG_152","TRL_550","ICC_825","GVG_049","UNG_919","LOOT_153","OG_308","LOOT_511","AT_103","EX1_543","TRL_542","GIL_128","GIL_828","DAL_589","BOT_429","ICC_828"}, new Power
			{
				// TODO [DALA_Hunter_05] Big Beasts && Test: Big Beasts_DALA_Hunter_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_06] Tiny Trouble (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_315, OG_179, UNG_912, UNG_914, DAL_587, TRL_348, DS1_175, FP1_011, LOOT_258, ICC_092, UNG_809, TRL_505, DAL_372, GIL_607, UNG_913, OG_061, UNG_916, EX1_554
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_06", new CardDef(new[] {"CFM_315","OG_179","UNG_912","UNG_914","DAL_587","TRL_348","DS1_175","FP1_011","LOOT_258","ICC_092","UNG_809","TRL_505","DAL_372","GIL_607","UNG_913","OG_061","UNG_916","EX1_554"}, new Power
			{
				// TODO [DALA_Hunter_06] Tiny Trouble && Test: Tiny Trouble_DALA_Hunter_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_07] Empowering (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_531, UNG_915, CFM_338, AT_057, UNG_075, LOOT_125, ICC_854, GIL_624, LOE_047, DS1_070, CFM_335, AT_010, AT_090, LOE_105, EX1_539, TRL_339, GIL_828, TRL_111
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_07", new CardDef(new[] {"EX1_531","UNG_915","CFM_338","AT_057","UNG_075","LOOT_125","ICC_854","GIL_624","LOE_047","DS1_070","CFM_335","AT_010","AT_090","LOE_105","EX1_539","TRL_339","GIL_828","TRL_111"}, new Power
			{
				// TODO [DALA_Hunter_07] Empowering && Test: Empowering_DALA_Hunter_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_08] Aggression (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: TRL_348, GIL_607t, GIL_143, GIL_650, GIL_562, TRL_900, DS1_178, EX1_116, BOT_102, TRL_550, DAL_592, UNG_099, TRL_542, EX1_543, TRL_119, BOT_437, EX1_538, DAL_378, GVG_043
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_08", new CardDef(new[] {"TRL_348","GIL_607t","GIL_143","GIL_650","GIL_562","TRL_900","DS1_178","EX1_116","BOT_102","TRL_550","DAL_592","UNG_099","TRL_542","EX1_543","TRL_119","BOT_437","EX1_538","DAL_378","GVG_043"}, new Power
			{
				// TODO [DALA_Hunter_08] Aggression && Test: Aggression_DALA_Hunter_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_09] Overwhelm (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_315, TRL_348, FP1_002, EX1_531, KAR_044, CFM_316, TRL_901, OG_216, TRL_020, TRL_900, CS2_237, DAL_566, DAL_751, LOOT_153, EX1_554, EX1_538, AT_062, CFM_337
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_09", new CardDef(new[] {"CFM_315","TRL_348","FP1_002","EX1_531","KAR_044","CFM_316","TRL_901","OG_216","TRL_020","TRL_900","CS2_237","DAL_566","DAL_751","LOOT_153","EX1_554","EX1_538","AT_062","CFM_337"}, new Power
			{
				// TODO [DALA_Hunter_09] Overwhelm && Test: Overwhelm_DALA_Hunter_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_10] Professional (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, TRL_349, BOT_251, GVG_119, EX1_005, EX1_002, AT_063, EX1_544, EX1_617, EX1_537, TRL_347, LOOT_522, LOOT_222, GVG_043, EX1_536, CFM_337, DS1_188
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_10", new CardDef(new[] {"NEW1_021","TRL_349","BOT_251","GVG_119","EX1_005","EX1_002","AT_063","EX1_544","EX1_617","EX1_537","TRL_347","LOOT_522","LOOT_222","GVG_043","EX1_536","CFM_337","DS1_188"}, new Power
			{
				// TODO [DALA_Hunter_10] Professional && Test: Professional_DALA_Hunter_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_11] Battlecry (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_315, UNG_912, TRL_348, UNG_915, AT_058, CFM_338, ICC_415, DAL_546, LOE_077, UNG_072, CFM_335, GIL_905, AT_010, FP1_030, LOOT_167, CFM_685, UNG_848, LOOT_511, ICC_705, GIL_128
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_11", new CardDef(new[] {"CFM_315","UNG_912","TRL_348","UNG_915","AT_058","CFM_338","ICC_415","DAL_546","LOE_077","UNG_072","CFM_335","GIL_905","AT_010","FP1_030","LOOT_167","CFM_685","UNG_848","LOOT_511","ICC_705","GIL_128"}, new Power
			{
				// TODO [DALA_Hunter_11] Battlecry && Test: Battlecry_DALA_Hunter_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DALA_Hunter_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: AT_063t, GIL_650, CFM_333, BRM_028, EX1_577, GVG_049, UNG_919, DAL_379, GIL_198, GVG_118, FP1_013, EX1_298, GVG_114, ICC_314, EX1_563, TRL_542, EX1_572, EX1_543, GIL_128, OG_133
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_12", new CardDef(new[] {"AT_063t","GIL_650","CFM_333","BRM_028","EX1_577","GVG_049","UNG_919","DAL_379","GIL_198","GVG_118","FP1_013","EX1_298","GVG_114","ICC_314","EX1_563","TRL_542","EX1_572","EX1_543","GIL_128","OG_133"}, new Power
			{
				// TODO [DALA_Hunter_12] Legends && Test: Legends_DALA_Hunter_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [DALA_501] Cheerful Spirit (*) - COST:2 [ATK:2/HP:4] 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Whenever you draw a spell, add a copy of it to your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_501", new CardDef(new Power
			{
				// TODO [DALA_501] Cheerful Spirit && Test: Cheerful Spirit_DALA_501
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_800] Random Mage Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_800", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_800] Random Mage Deck && Test: Random Mage Deck_DALA_800
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_01] Multi-Cast (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_009, DAL_603, EX1_012, DAL_182, BOT_103, GIL_640, EX1_050, LOE_003, EX1_559, TRL_318, DAL_609, DAL_608, DAL_577, EX1_180, UNG_941, BOT_600, CS2_023, DAL_177, LOOT_108
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_01", new CardDef(new[] {"KAR_009","DAL_603","EX1_012","DAL_182","BOT_103","GIL_640","EX1_050","LOE_003","EX1_559","TRL_318","DAL_609","DAL_608","DAL_577","EX1_180","UNG_941","BOT_600","CS2_023","DAL_177","LOOT_108"}, new Power
			{
				// TODO [DALA_Mage_01] Multi-Cast && Test: Multi-Cast_DALA_Mage_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_02] Coldsnap (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_205, GVG_002, ICC_252, OG_085, CS2_033, EX1_283, DAL_577, ICC_836, CS2_024, GIL_801, CS2_026, ICC_082, EX1_289, EX1_295, EX1_275, CS2_028, ICC_833
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_02", new CardDef(new[] {"UNG_205","GVG_002","ICC_252","OG_085","CS2_033","EX1_283","DAL_577","ICC_836","CS2_024","GIL_801","CS2_026","ICC_082","EX1_289","EX1_295","EX1_275","CS2_028","ICC_833"}, new Power
			{
				// TODO [DALA_Mage_02] Coldsnap && Test: Coldsnap_DALA_Mage_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_03] Summoning (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_575, DAL_163, GIL_664, OG_207, BOT_256, KAR_076, GVG_114, GVG_116, DAL_553, CS2_027, AT_002, TRL_400, EX1_294, UNG_948, BOT_254, DAL_177, DAL_578
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_03", new CardDef(new[] {"DAL_575","DAL_163","GIL_664","OG_207","BOT_256","KAR_076","GVG_114","GVG_116","DAL_553","CS2_027","AT_002","TRL_400","EX1_294","UNG_948","BOT_254","DAL_177","DAL_578"}, new Power
			{
				// TODO [DALA_Mage_03] Summoning && Test: Summoning_DALA_Mage_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_04] Powered Up (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_608, EX1_012, BOT_531, ICC_093, GVG_123, DAL_089, BOT_604, AT_006, DAL_576, EX1_584, EX1_284, DAL_434, DAL_548, DAL_096, EX1_563, AT_004, BOT_254, LOOT_108
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_04", new CardDef(new[] {"EX1_608","EX1_012","BOT_531","ICC_093","GVG_123","DAL_089","BOT_604","AT_006","DAL_576","EX1_584","EX1_284","DAL_434","DAL_548","DAL_096","EX1_563","AT_004","BOT_254","LOOT_108"}, new Power
			{
				// TODO [DALA_Mage_04] Powered Up && Test: Powered Up_DALA_Mage_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_05] Go Big (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_539, BOT_539, BOT_601, BOT_256, LOOT_539, LOOT_414, LOOT_535, DAL_609, CS2_022, OG_090, LOOT_172, CS2_028, UNG_955, KAR_076, CS2_032, CFM_623, BOT_257, DAL_578, EX1_279
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_05", new CardDef(new[] {"DAL_539","BOT_539","BOT_601","BOT_256","LOOT_539","LOOT_414","LOOT_535","DAL_609","CS2_022","OG_090","LOOT_172","CS2_028","UNG_955","KAR_076","CS2_032","CFM_623","BOT_257","DAL_578","EX1_279"}, new Power
			{
				// TODO [DALA_Mage_05] Go Big && Test: Go Big_DALA_Mage_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_06] BURN! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_809, UNG_027, BRM_002, GVG_123, EX1_559, OG_086, UNG_018, GVG_001, LOE_002, CFM_065, LOOT_101, EX1_594, GIL_147, CS2_029, UNG_948, TRL_317, UNG_955, CS2_032, EX1_279
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_06", new CardDef(new[] {"UNG_809","UNG_027","BRM_002","GVG_123","EX1_559","OG_086","UNG_018","GVG_001","LOE_002","CFM_065","LOOT_101","EX1_594","GIL_147","CS2_029","UNG_948","TRL_317","UNG_955","CS2_032","EX1_279"}, new Power
			{
				// TODO [DALA_Mage_06] BURN! && Test: BURN!_DALA_Mage_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_07] Elements (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_809, LOOT_231, UNG_027, BOT_604, UNG_021, CS2_033, UNG_816, GIL_645, TRL_311, DAL_548, EX1_249, UNG_847, OG_120, EX1_298, UNG_907, TRL_310, UNG_018, LOOT_103, TRL_313
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_07", new CardDef(new[] {"UNG_809","LOOT_231","UNG_027","BOT_604","UNG_021","CS2_033","UNG_816","GIL_645","TRL_311","DAL_548","EX1_249","UNG_847","OG_120","EX1_298","UNG_907","TRL_310","UNG_018","LOOT_103","TRL_313"}, new Power
			{
				// TODO [DALA_Mage_07] Elements && Test: Elements_DALA_Mage_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_08] Technology (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GVG_082, GVG_002, GVG_085, GVG_006, BOT_907, GVG_123, GVG_004, BOT_312, GVG_096, GVG_111, BOT_563, BOT_548, GVG_117, BOT_066, GVG_105, BOT_270, GVG_007, GVG_114, GVG_001
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_08", new CardDef(new[] {"GVG_082","GVG_002","GVG_085","GVG_006","BOT_907","GVG_123","GVG_004","BOT_312","GVG_096","GVG_111","BOT_563","BOT_548","GVG_117","BOT_066","GVG_105","BOT_270","GVG_007","GVG_114","GVG_001"}, new Power
			{
				// TODO [DALA_Mage_08] Technology && Test: Technology_DALA_Mage_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_09] Fate's Hand (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_009, UNG_846, DAL_603, AT_007, LOOT_537, TRL_096, GIL_549, DAL_553, OG_134, LOOT_104, EX1_277, BOT_101, GVG_003, UNG_941, BOT_254, OG_090, LOOT_106, KAR_076, CFM_623
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_09", new CardDef(new[] {"KAR_009","UNG_846","DAL_603","AT_007","LOOT_537","TRL_096","GIL_549","DAL_553","OG_134","LOOT_104","EX1_277","BOT_101","GVG_003","UNG_941","BOT_254","OG_090","LOOT_106","KAR_076","CFM_623"}, new Power
			{
				// TODO [DALA_Mage_09] Fate's Hand && Test: Fate's Hand_DALA_Mage_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_10] Trade Secrets (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_066, EX1_080, UNG_020, FP1_004, KAR_092, EX1_612, GVG_089, TRL_530, GIL_116, EX1_274, BOT_573, CFM_760, EX1_287, FP1_018, EX1_295, EX1_289, UNG_024, EX1_294, tt_010
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_10", new CardDef(new[] {"CFM_066","EX1_080","UNG_020","FP1_004","KAR_092","EX1_612","GVG_089","TRL_530","GIL_116","EX1_274","BOT_573","CFM_760","EX1_287","FP1_018","EX1_295","EX1_289","UNG_024","EX1_294","tt_010"}, new Power
			{
				// TODO [DALA_Mage_10] Trade Secrets && Test: Trade Secrets_DALA_Mage_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_11] Inspired (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: AT_082, TRL_390, AT_003, TRL_319, AT_080, TRL_407, TRL_315, CFM_807, GIL_561, AT_115, AT_085, AT_006, AT_119, AT_090, AT_127, AT_099, TRL_316, AT_120
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_11", new CardDef(new[] {"AT_082","TRL_390","AT_003","TRL_319","AT_080","TRL_407","TRL_315","CFM_807","GIL_561","AT_115","AT_085","AT_006","AT_119","AT_090","AT_127","AT_099","TRL_316","AT_120"}, new Power
			{
				// TODO [DALA_Mage_11] Inspired && Test: Inspired_DALA_Mage_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DALA_Mage_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_691, BOT_103, DAL_558, AT_127, BRM_028, GIL_549, EX1_249, GVG_110, EX1_559, TRL_318, AT_009, ICC_838, KAR_097, EX1_298, GVG_114, ICC_314, EX1_563, EX1_572, OG_134, EX1_016
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_12", new CardDef(new[] {"GIL_691","BOT_103","DAL_558","AT_127","BRM_028","GIL_549","EX1_249","GVG_110","EX1_559","TRL_318","AT_009","ICC_838","KAR_097","EX1_298","GVG_114","ICC_314","EX1_563","EX1_572","OG_134","EX1_016"}, new Power
			{
				// TODO [DALA_Mage_12] Legends && Test: Legends_DALA_Mage_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [DALA_803] Random Paladin Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_803", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_803] Random Paladin Deck && Test: Random Paladin Deck_DALA_803
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_01] Secret Whispers (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_080, FP1_004, UNG_011, DAL_086, DAL_573, GIL_634, AT_079, DAL_570, DAL_141, FP1_020, CFM_800, EX1_132, GIL_903, EX1_130, EX1_136, LOE_027, DAL_571
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_01", new CardDef(new[] {"EX1_080","FP1_004","UNG_011","DAL_086","DAL_573","GIL_634","AT_079","DAL_570","DAL_141","FP1_020","CFM_800","EX1_132","GIL_903","EX1_130","EX1_136","LOE_027","DAL_571"}, new Power
			{
				// TODO [DALA_Paladin_01] Secret Whispers && Test: Secret Whispers_DALA_Paladin_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_02] Small Army (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_008, ICC_038, LOOT_363, FP1_003, UNG_808, GVG_104, LOOT_125, OG_310, UNG_015, AT_073, BOT_909, DAL_727, EX1_349, LOOT_093, TRL_543, EX1_366
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_02", new CardDef(new[] {"EX1_008","ICC_038","LOOT_363","FP1_003","UNG_808","GVG_104","LOOT_125","OG_310","UNG_015","AT_073","BOT_909","DAL_727","EX1_349","LOOT_093","TRL_543","EX1_366"}, new Power
			{
				// TODO [DALA_Paladin_02] Small Army && Test: Small Army_DALA_Paladin_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_03] Dragons (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_635, DAL_146, KAR_010, DAL_147, BRM_026, BRM_018, ICC_029, TRL_526, ICC_027, OG_271, TRL_569, UNG_848, EX1_562, EX1_572, EX1_563, DAL_581, BOT_436, DAL_731
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_03", new CardDef(new[] {"GIL_635","DAL_146","KAR_010","DAL_147","BRM_026","BRM_018","ICC_029","TRL_526","ICC_027","OG_271","TRL_569","UNG_848","EX1_562","EX1_572","EX1_563","DAL_581","BOT_436","DAL_731"}, new Power
			{
				// TODO [DALA_Paladin_03] Dragons && Test: Dragons_DALA_Paladin_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_04] Holy Infusions (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: TRL_306, TRL_309, UNG_953, BRM_020, LOOT_216, CS2_087, EX1_363, GIL_145, ICC_244, DAL_568, AT_074, CS2_092, KAR_077, EX1_355, UNG_952, LOOT_500
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_04", new CardDef(new[] {"TRL_306","TRL_309","UNG_953","BRM_020","LOOT_216","CS2_087","EX1_363","GIL_145","ICC_244","DAL_568","AT_074","CS2_092","KAR_077","EX1_355","UNG_952","LOOT_500"}, new Power
			{
				// TODO [DALA_Paladin_04] Holy Infusions && Test: Holy Infusions_DALA_Paladin_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_05] Healing Hands (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_544, BOT_236, TRL_308, LOOT_398, GIL_817, TRL_545, KAR_057, ICC_245, CS2_088, OG_229, TRL_300, DAL_581, OG_198, LOOT_091, TRL_307, EX1_354, CS2_097
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_05", new CardDef(new[] {"DAL_544","BOT_236","TRL_308","LOOT_398","GIL_817","TRL_545","KAR_057","ICC_245","CS2_088","OG_229","TRL_300","DAL_581","OG_198","LOOT_091","TRL_307","EX1_354","CS2_097"}, new Power
			{
				// TODO [DALA_Paladin_05] Healing Hands && Test: Healing Hands_DALA_Paladin_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_06] Handbuff (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_759, CFM_753, CFM_853, GIL_685, TRL_517, CFM_639, CFM_668, BOT_910, BRM_028, CFM_685, CFM_305, OG_311, DAL_727, TRL_304, LOOT_500, LOE_077
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_06", new CardDef(new[] {"CFM_759","CFM_753","CFM_853","GIL_685","TRL_517","CFM_639","CFM_668","BOT_910","BRM_028","CFM_685","CFM_305","OG_311","DAL_727","TRL_304","LOOT_500","LOE_077"}, new Power
			{
				// TODO [DALA_Paladin_06] Handbuff && Test: Handbuff_DALA_Paladin_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_07] Murglgglgl (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_650, EX1_509, DAL_077, UNG_011, UNG_953, OG_156, CS2_173, UNG_073, EX1_050, GIL_681, EX1_507, UNG_937, TRL_520, EX1_062, AT_076, CFM_344, LOE_026
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_07", new CardDef(new[] {"CFM_650","EX1_509","DAL_077","UNG_011","UNG_953","OG_156","CS2_173","UNG_073","EX1_050","GIL_681","EX1_507","UNG_937","TRL_520","EX1_062","AT_076","CFM_344","LOE_026"}, new Power
			{
				// TODO [DALA_Paladin_07] Murglgglgl && Test: Murglgglgl_DALA_Paladin_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_08] Robotic (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_906, GVG_058, GVG_006, GVG_085, BOT_911, GVG_096, GVG_062, BOT_563, GVG_111, BOT_548, GVG_105, BOT_270, GVG_113, GVG_114, GVG_116, GVG_121, BOT_234, BOT_912
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_08", new CardDef(new[] {"BOT_906","GVG_058","GVG_006","GVG_085","BOT_911","GVG_096","GVG_062","BOT_563","GVG_111","BOT_548","GVG_105","BOT_270","GVG_113","GVG_114","GVG_116","GVG_121","BOT_234","BOT_912"}, new Power
			{
				// TODO [DALA_Paladin_08] Robotic && Test: Robotic_DALA_Paladin_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_09] The Silver Hand (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: LOOT_363, AT_075, AT_100, UNG_962, GVG_060, UNG_015, LOOT_313, EX1_383, AT_073, UNG_960, GVG_061, OG_273, LOOT_333, LOOT_286, UNG_950, GIL_596
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_09", new CardDef(new[] {"LOOT_363","AT_075","AT_100","UNG_962","GVG_060","UNG_015","LOOT_313","EX1_383","AT_073","UNG_960","GVG_061","OG_273","LOOT_333","LOOT_286","UNG_950","GIL_596"}, new Power
			{
				// TODO [DALA_Paladin_09] The Silver Hand && Test: The Silver Hand_DALA_Paladin_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_10] Protectors (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_038, EX1_362, GVG_058, CFM_815, LOOT_124, FP1_012, ICC_858, BOT_548, EX1_067, EX1_032, EX1_383, BOT_908, LOOT_088, TRL_302, TRL_305, GVG_059, ICC_071
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_10", new CardDef(new[] {"ICC_038","EX1_362","GVG_058","CFM_815","LOOT_124","FP1_012","ICC_858","BOT_548","EX1_067","EX1_032","EX1_383","BOT_908","LOOT_088","TRL_302","TRL_305","GVG_059","ICC_071"}, new Power
			{
				// TODO [DALA_Paladin_10] Protectors && Test: Protectors_DALA_Paladin_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_11] Judgment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_913, EX1_012, NEW1_020, AT_127, KAR_057, DAL_548, EX1_563, TRL_300, EX1_619, CS2_093, CS2_094, DAL_731, EX1_365, EX1_384, UNG_952, ICC_829
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_11", new CardDef(new[] {"ICC_913","EX1_012","NEW1_020","AT_127","KAR_057","DAL_548","EX1_563","TRL_300","EX1_619","CS2_093","CS2_094","DAL_731","EX1_365","EX1_384","UNG_952","ICC_829"}, new Power
			{
				// TODO [DALA_Paladin_11] Judgment && Test: Judgment_DALA_Paladin_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DALA_Paladin_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_236, CFM_815, GIL_694, UNG_015, EX1_016, AT_081, NEW1_038, KAR_097, ICC_314, OG_229, EX1_383, BRM_030, GVG_116, NEW1_030, TRL_541, OG_042, DAL_581, TRL_300
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_12", new CardDef(new[] {"BOT_236","CFM_815","GIL_694","UNG_015","EX1_016","AT_081","NEW1_038","KAR_097","ICC_314","OG_229","EX1_383","BRM_030","GVG_116","NEW1_030","TRL_541","OG_042","DAL_581","TRL_300"}, new Power
			{
				// TODO [DALA_Paladin_12] Legends && Test: Legends_DALA_Paladin_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [DALA_804] Random Priest Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_804", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_804] Random Priest Deck && Test: Random Priest Deck_DALA_804
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_01] Curatives (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_120, CS2_235, TRL_570, CFM_606, GVG_072, CS2_117, BOT_216, AT_011, OG_234, GIL_156, EX1_621, TRL_128, UNG_030, GVG_012, AT_013, GIL_661, CFM_604, CS1_112, EX1_624
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_01", new CardDef(new[] {"CFM_120","CS2_235","TRL_570","CFM_606","GVG_072","CS2_117","BOT_216","AT_011","OG_234","GIL_156","EX1_621","TRL_128","UNG_030","GVG_012","AT_013","GIL_661","CFM_604","CS1_112","EX1_624"}, new Power
			{
				// TODO [DALA_Priest_01] Curatives && Test: Curatives_DALA_Priest_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_02] Afterlife (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_030, BOT_509, LOE_006, DAL_413, LOOT_534, LOOT_534, UNG_037, DAL_040, UNG_900, DAL_039, BOT_566, GIL_805, EX1_016, DAL_775, TRL_537, GVG_114, ICC_214, OG_133, LOOT_187
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_02", new CardDef(new[] {"DAL_030","BOT_509","LOE_006","DAL_413","LOOT_534","LOOT_534","UNG_037","DAL_040","UNG_900","DAL_039","BOT_566","GIL_805","EX1_016","DAL_775","TRL_537","GVG_114","ICC_214","OG_133","LOOT_187"}, new Power
			{
				// TODO [DALA_Priest_02] Afterlife && Test: Afterlife_DALA_Priest_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_03] From the Graves (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_204, UNG_963, DAL_721, ICC_314, EX1_350, AT_018, EX1_298, FP1_013, EX1_563, ICC_214, OG_042, BRM_017, UNG_029, DAL_065, ICC_213, ICC_235, LOOT_507, DAL_724, BOT_567
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_03", new CardDef(new[] {"KAR_204","UNG_963","DAL_721","ICC_314","EX1_350","AT_018","EX1_298","FP1_013","EX1_563","ICC_214","OG_042","BRM_017","UNG_029","DAL_065","ICC_213","ICC_235","LOOT_507","DAL_724","BOT_567"}, new Power
			{
				// TODO [DALA_Priest_03] From the Graves && Test: From the Graves_DALA_Priest_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_04] Shadows (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GVG_009, DAL_030, TRL_501, ICC_210, ICC_212, AT_014, EX1_591, EX1_334, OG_101, DAL_723, DAL_011, CFM_603, DS1_233, CS2_234, UNG_029, EX1_622, TRL_500, ICC_235, ICC_830
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_04", new CardDef(new[] {"GVG_009","DAL_030","TRL_501","ICC_210","ICC_212","AT_014","EX1_591","EX1_334","OG_101","DAL_723","DAL_011","CFM_603","DS1_233","CS2_234","UNG_029","EX1_622","TRL_500","ICC_235","ICC_830"}, new Power
			{
				// TODO [DALA_Priest_04] Shadows && Test: Shadows_DALA_Priest_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_05] What's Mind is Mine (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_142, UNG_032, DAL_729, OG_335, EX1_091, EX1_016, ICC_215, TRL_259, CS2_003, LOOT_353, TRL_097, BOT_435, EX1_339, EX1_345, EX1_334, GIL_134, ICC_207, CS1_113
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_05", new CardDef(new[] {"GIL_142","UNG_032","DAL_729","OG_335","EX1_091","EX1_016","ICC_215","TRL_259","CS2_003","LOOT_353","TRL_097","BOT_435","EX1_339","EX1_345","EX1_334","GIL_134","ICC_207","CS1_113"}, new Power
			{
				// TODO [DALA_Priest_05] What's Mind is Mine && Test: What's Mind is Mine_DALA_Priest_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_06] Old God (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: OG_281, OG_284, OG_162, OG_286, OG_283, OG_334, OG_096, OG_321, OG_339, OG_131, OG_255, OG_280
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_06", new CardDef(new[] {"OG_281","OG_284","OG_162","OG_286","OG_283","OG_334","OG_096","OG_321","OG_339","OG_131","OG_255","OG_280"}, new Power
			{
				// TODO [DALA_Priest_06] Old God && Test: Old God_DALA_Priest_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_07] Pint-Sized (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_544, FP1_001, UNG_809, DAL_030, TRL_502, UNG_022, TRL_131, DAL_773, LOOT_394, GIL_212, NEW1_026, KAR_114, GIL_620, OG_316, TRL_260, GVG_110, LOOT_278, GIL_813, BOT_567
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_07", new CardDef(new[] {"DAL_544","FP1_001","UNG_809","DAL_030","TRL_502","UNG_022","TRL_131","DAL_773","LOOT_394","GIL_212","NEW1_026","KAR_114","GIL_620","OG_316","TRL_260","GVG_110","LOOT_278","GIL_813","BOT_567"}, new Power
			{
				// TODO [DALA_Priest_07] Pint-Sized && Test: Pint-Sized_DALA_Priest_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_08] Dragonfire (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BRM_004, AT_116, LOOT_528, LOOT_410, CFM_605, TRL_526, GIL_190, TRL_569, LOOT_538, BRM_031, UNG_848, LOOT_540, EX1_563, BRM_030, EX1_572, LOOT_137, CFM_662, GVG_008, LOOT_209
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_08", new CardDef(new[] {"BRM_004","AT_116","LOOT_528","LOOT_410","CFM_605","TRL_526","GIL_190","TRL_569","LOOT_538","BRM_031","UNG_848","LOOT_540","EX1_563","BRM_030","EX1_572","LOOT_137","CFM_662","GVG_008","LOOT_209"}, new Power
			{
				// TODO [DALA_Priest_08] Dragonfire && Test: Dragonfire_DALA_Priest_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_09] Twisted (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_034, GVG_011, DAL_735, EX1_045, UNG_844, LOE_107, EX1_048, CFM_657, GVG_014, DAL_434, EX1_332, CFM_661, AT_016, KAR_013, EX1_626, TRL_258, LOE_111, LOE_104, LOOT_008
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_09", new CardDef(new[] {"UNG_034","GVG_011","DAL_735","EX1_045","UNG_844","LOE_107","EX1_048","CFM_657","GVG_014","DAL_434","EX1_332","CFM_661","AT_016","KAR_013","EX1_626","TRL_258","LOE_111","LOE_104","LOOT_008"}, new Power
			{
				// TODO [DALA_Priest_09] Twisted && Test: Twisted_DALA_Priest_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_10] Strength Within (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_558, ICC_094, ICC_210, OG_256, FP1_023, CFM_626, AT_129, BRM_020, UNG_037, BOT_258, GIL_840, ICC_705, CS1_129, CS2_236, BOT_219, LOOT_278, GVG_010, TRL_500, OG_094
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_10", new CardDef(new[] {"BOT_558","ICC_094","ICC_210","OG_256","FP1_023","CFM_626","AT_129","BRM_020","UNG_037","BOT_258","GIL_840","ICC_705","CS1_129","CS2_236","BOT_219","LOOT_278","GVG_010","TRL_500","OG_094"}, new Power
			{
				// TODO [DALA_Priest_10] Strength Within && Test: Strength Within_DALA_Priest_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_11] Miracles (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_558, EX1_055, UNG_034, NEW1_020, EX1_044, TRL_131, KAR_035, NEW1_026, UNG_963, BOT_258, EX1_095, TRL_408, CS2_004, UNG_029, ICC_802, BOT_219, LOOT_278, BOT_529, LOOT_209
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_11", new CardDef(new[] {"BOT_558","EX1_055","UNG_034","NEW1_020","EX1_044","TRL_131","KAR_035","NEW1_026","UNG_963","BOT_258","EX1_095","TRL_408","CS2_004","UNG_029","ICC_802","BOT_219","LOOT_278","BOT_529","LOOT_209"}, new Power
			{
				// TODO [DALA_Priest_11] Miracles && Test: Miracles_DALA_Priest_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DALA_Priest_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_012, LOOT_516, LOE_077, ICC_854, EX1_558, FP1_030, UNG_963, EX1_110, BRM_028, EX1_614, TRL_564, EX1_002, GVG_118, AT_018, EX1_350, NEW1_038, KAR_097, LOOT_357, EX1_298, LOE_092, TRL_541
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_12", new CardDef(new[] {"EX1_012","LOOT_516","LOE_077","ICC_854","EX1_558","FP1_030","UNG_963","EX1_110","BRM_028","EX1_614","TRL_564","EX1_002","GVG_118","AT_018","EX1_350","NEW1_038","KAR_097","LOOT_357","EX1_298","LOE_092","TRL_541"}, new Power
			{
				// TODO [DALA_Priest_12] Legends && Test: Legends_DALA_Priest_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [DALA_805] Random Rogue Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_805", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_805] Random Rogue Deck && Test: Random Rogue Deck_DALA_805
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_01] Combo (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: OG_070, EX1_131, EX1_613, DAL_415, EX1_134, LOOT_211, TRL_092, UNG_064, GIL_557, CS2_073, EX1_124, CFM_690
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_01", new CardDef(new[] {"OG_070","EX1_131","EX1_613","DAL_415","EX1_134","LOOT_211","TRL_092","UNG_064","GIL_557","CS2_073","EX1_124","CFM_690"}, new Power
			{
				// TODO [DALA_Rogue_01] Combo && Test: Combo_DALA_Rogue_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_02] Thief (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_069, OG_330, DAL_714, GIL_827, GIL_677, CFM_781, DAL_416, ICC_811, KAR_070, GVG_028, GIL_598, GIL_598, BRM_030, UNG_856, DAL_716, GIL_672
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_02", new CardDef(new[] {"KAR_069","OG_330","DAL_714","GIL_827","GIL_677","CFM_781","DAL_416","ICC_811","KAR_070","GVG_028","GIL_598","GIL_598","BRM_030","UNG_856","DAL_716","GIL_672"}, new Power
			{
				// TODO [DALA_Rogue_02] Thief && Test: Thief_DALA_Rogue_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_03] Trickery (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_288, DAL_400, DAL_415, LOOT_165, BOT_559, LOOT_026, LOOT_412, DAL_417, DAL_719, TRL_541, DAL_010, EX1_581, AT_035, BOT_087, DAL_366, OG_073, DAL_720, ICC_827
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_03", new CardDef(new[] {"BOT_288","DAL_400","DAL_415","LOOT_165","BOT_559","LOOT_026","LOOT_412","DAL_417","DAL_719","TRL_541","DAL_010","EX1_581","AT_035","BOT_087","DAL_366","OG_073","DAL_720","ICC_827"}, new Power
			{
				// TODO [DALA_Rogue_03] Trickery && Test: Trickery_DALA_Rogue_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_04] Kingslayer (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: LOOT_033, GVG_023, NEW1_018, BOT_083, GIL_534, NEW1_024, CS2_074, ICC_233, ICC_221, UNG_823, CS2_233, GVG_022, LOOT_542
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_04", new CardDef(new[] {"LOOT_033","GVG_023","NEW1_018","BOT_083","GIL_534","NEW1_024","CS2_074","ICC_233","ICC_221","UNG_823","CS2_233","GVG_022","LOOT_542"}, new Power
			{
				// TODO [DALA_Rogue_04] Kingslayer && Test: Kingslayer_DALA_Rogue_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_05] Deathrattle (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_691, LOE_019, LOE_012, FP1_031, DAL_749, BOT_243, DAL_775, TRL_537, AT_036, OG_133, OG_072, BOT_084, BOT_508, LOOT_503, BOT_286
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_05", new CardDef(new[] {"CFM_691","LOE_019","LOE_012","FP1_031","DAL_749","BOT_243","DAL_775","TRL_537","AT_036","OG_133","OG_072","BOT_084","BOT_508","LOOT_503","BOT_286"}, new Power
			{
				// TODO [DALA_Rogue_05] Deathrattle && Test: Deathrattle_DALA_Rogue_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_06] Cogs and Gears (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_283, BOT_907, GVG_006, GVG_027, EX1_556, BOT_565, GVG_096, GVG_078, BOT_548, BOT_066, GVG_096, GVG_114, GVG_116, BOT_424
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_06", new CardDef(new[] {"BOT_283","BOT_907","GVG_006","GVG_027","EX1_556","BOT_565","GVG_096","GVG_078","BOT_548","BOT_066","GVG_096","GVG_114","GVG_116","BOT_424"}, new Power
			{
				// TODO [DALA_Rogue_06] Cogs and Gears && Test: Cogs and Gears_DALA_Rogue_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_07] Scallywags (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_069, CS2_146, GVG_075, TRL_071, NEW1_027, AT_032, TRL_015, OG_267, NEW1_024, AT_070, TRL_126, TRL_124, TRL_157, GIL_687, TRL_127, TRL_074
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_07", new CardDef(new[] {"KAR_069","CS2_146","GVG_075","TRL_071","NEW1_027","AT_032","TRL_015","OG_267","NEW1_024","AT_070","TRL_126","TRL_124","TRL_157","GIL_687","TRL_127","TRL_074"}, new Power
			{
				// TODO [DALA_Rogue_07] Scallywags && Test: Scallywags_DALA_Rogue_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_08] Cutthroat (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CS2_188, EX1_008, EX1_162, UNG_075, AT_087, EX1_046, ICC_029, DAL_749, EX1_116, DAL_592, CS2_073, EX1_124, GVG_022
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_08", new CardDef(new[] {"CS2_188","EX1_008","EX1_162","UNG_075","AT_087","EX1_046","ICC_029","DAL_749","EX1_116","DAL_592","CS2_073","EX1_124","GVG_022"}, new Power
			{
				// TODO [DALA_Rogue_08] Cutthroat && Test: Cutthroat_DALA_Rogue_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_09] Draw! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_012, EX1_096, EX1_007, EX1_050, LOOT_211, DAL_582, DAL_565, BRM_031, EX1_145, EX1_278, UNG_060, EX1_129, BOT_242, OG_073, CS2_077
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_09", new CardDef(new[] {"EX1_012","EX1_096","EX1_007","EX1_050","LOOT_211","DAL_582","DAL_565","BRM_031","EX1_145","EX1_278","UNG_060","EX1_129","BOT_242","OG_073","CS2_077"}, new Power
			{
				// TODO [DALA_Rogue_09] Draw! && Test: Draw!_DALA_Rogue_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_10] Battlecry (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_283, LOE_077, GIL_827, LOOT_165, GVG_107, LOOT_026, DAL_416, TRL_092, OG_080, TRL_409, ICC_257, OG_291, TRL_077, UNG_848, ICC_705, EX1_144, DAL_728, DAL_010, NEW1_004
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_10", new CardDef(new[] {"BOT_283","LOE_077","GIL_827","LOOT_165","GVG_107","LOOT_026","DAL_416","TRL_092","OG_080","TRL_409","ICC_257","OG_291","TRL_077","UNG_848","ICC_705","EX1_144","DAL_728","DAL_010","NEW1_004"}, new Power
			{
				// TODO [DALA_Rogue_10] Battlecry && Test: Battlecry_DALA_Rogue_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_11] Spellslinger (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_012, UNG_058, NEW1_026, DAL_095, EX1_284, EX1_095, EX1_563, OG_134, CS2_072, EX1_145, GIL_506, EX1_124, CFM_690, EX1_278, EX1_129, OG_176, EX1_044
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_11", new CardDef(new[] {"EX1_012","UNG_058","NEW1_026","DAL_095","EX1_284","EX1_095","EX1_563","OG_134","CS2_072","EX1_145","GIL_506","EX1_124","CFM_690","EX1_278","EX1_129","OG_176","EX1_044"}, new Power
			{
				// TODO [DALA_Rogue_11] Spellslinger && Test: Spellslinger_DALA_Rogue_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DALA_Rogue_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_613, GIL_677, BOT_243, FP1_030, EX1_116, BRM_028, EX1_110, EX1_016, ICC_314, AT_036, EX1_563, EX1_572, FP1_010, GVG_110, LOOT_357, EX1_298, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_12", new CardDef(new[] {"EX1_613","GIL_677","BOT_243","FP1_030","EX1_116","BRM_028","EX1_110","EX1_016","ICC_314","AT_036","EX1_563","EX1_572","FP1_010","GVG_110","LOOT_357","EX1_298","GVG_114"}, new Power
			{
				// TODO [DALA_Rogue_12] Legends && Test: Legends_DALA_Rogue_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_806] Random Shaman Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_806", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_806] Random Shaman Deck && Test: Random Shaman Deck_DALA_806
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_01] Flood (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_565, UNG_201, AT_046, LOOT_167, DAL_566, ICC_900, BOT_102, LOE_089, UNG_010, CS2_222, EX1_562, TRL_012, BOT_451, KAR_073, EX1_248, UNG_956, CFM_310, CS2_046, TRL_351
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_01", new CardDef(new[] {"EX1_565","UNG_201","AT_046","LOOT_167","DAL_566","ICC_900","BOT_102","LOE_089","UNG_010","CS2_222","EX1_562","TRL_012","BOT_451","KAR_073","EX1_248","UNG_956","CFM_310","CS2_046","TRL_351"}, new Power
			{
				// TODO [DALA_Shaman_01] Flood && Test: Flood_DALA_Shaman_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_02] Spirits (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_096, FP1_007, ICC_702, ICC_854, FP1_031, UNG_900, CFM_324, LOOT_161, EX1_097, ICC_257, EX1_110, EX1_016, TRL_537, OG_133, CS2_038, FP1_025, UNG_956, GVG_096
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_02", new CardDef(new[] {"EX1_096","FP1_007","ICC_702","ICC_854","FP1_031","UNG_900","CFM_324","LOOT_161","EX1_097","ICC_257","EX1_110","EX1_016","TRL_537","OG_133","CS2_038","FP1_025","UNG_956","GVG_096"}, new Power
			{
				// TODO [DALA_Shaman_02] Spirits && Test: Spirits_DALA_Shaman_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_03] Fishy (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_077, GIL_678, DAL_049, UNG_073, EX1_507, EX1_103, UNG_937, UNG_089, TRL_520, EX1_062, GVG_040, DAL_726, CFM_344, OG_161, GVG_042, ICC_089, DAL_710, CFM_310, LOE_113
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_03", new CardDef(new[] {"DAL_077","GIL_678","DAL_049","UNG_073","EX1_507","EX1_103","UNG_937","UNG_089","TRL_520","EX1_062","GVG_040","DAL_726","CFM_344","OG_161","GVG_042","ICC_089","DAL_710","CFM_310","LOE_113"}, new Power
			{
				// TODO [DALA_Shaman_03] Fishy && Test: Fishy_DALA_Shaman_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_04] Overload (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_433, LOE_018, OG_026, ICC_081, EX1_258, OG_024, BOT_407, ICC_090, CFM_313, AT_053, LOOT_060, BRM_011, AT_051, EX1_248, UNG_025, LOOT_064, EX1_247, TRL_352
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_04", new CardDef(new[] {"DAL_433","LOE_018","OG_026","ICC_081","EX1_258","OG_024","BOT_407","ICC_090","CFM_313","AT_053","LOOT_060","BRM_011","AT_051","EX1_248","UNG_025","LOOT_064","EX1_247","TRL_352"}, new Power
			{
				// TODO [DALA_Shaman_04] Overload && Test: Overload_DALA_Shaman_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_05] Big Shaman (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_912, DAL_052, BOT_548, CFM_324, NEW1_010, DAL_047, GIL_616, ICC_314, EX1_563, EX1_572, DAL_553, OG_042, CS2_039, BOT_099, EX1_298
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_05", new CardDef(new[] {"ICC_912","DAL_052","BOT_548","CFM_324","NEW1_010","DAL_047","GIL_616","ICC_314","EX1_563","EX1_572","DAL_553","OG_042","CS2_039","BOT_099","EX1_298"}, new Power
			{
				// TODO [DALA_Shaman_05] Big Shaman && Test: Big Shaman_DALA_Shaman_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_06] Elemental Wrath (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: UNG_809, UNG_202, BOT_533, GIL_581, UNG_070, UNG_816, EX1_250, CS2_042, UNG_208, EX1_249, UNG_847, EX1_298, UNG_211, DAL_047, UNG_907, BOT_093
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_06", new CardDef(new[] {"UNG_809","UNG_202","BOT_533","GIL_581","UNG_070","UNG_816","EX1_250","CS2_042","UNG_208","EX1_249","UNG_847","EX1_298","UNG_211","DAL_047","UNG_907","BOT_093"}, new Power
			{
				// TODO [DALA_Shaman_06] Elemental Wrath && Test: Elemental Wrath_DALA_Shaman_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_07] Battlecry (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_058, LOOT_517, LOE_077, LOOT_516, LOE_016, DAL_546, ICC_466, CFM_668, FP1_030, LOOT_167, ICC_257, LOOT_358, AT_054, UNG_848, GIL_820, DAL_431, GIL_836
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_07", new CardDef(new[] {"ICC_058","LOOT_517","LOE_077","LOOT_516","LOE_016","DAL_546","ICC_466","CFM_668","FP1_030","LOOT_167","ICC_257","LOOT_358","AT_054","UNG_848","GIL_820","DAL_431","GIL_836"}, new Power
			{
				// TODO [DALA_Shaman_07] Battlecry && Test: Battlecry_DALA_Shaman_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_08] Sssspells (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_531, TRL_060, BOT_411, KAR_021, EX1_284, GIL_807, EX1_563, OG_134, EX1_245, EX1_238, GVG_038, KAR_073, EX1_241, TRL_058, EX1_259, DAL_009, LOOT_506, GIL_504
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_08", new CardDef(new[] {"GIL_531","TRL_060","BOT_411","KAR_021","EX1_284","GIL_807","EX1_563","OG_134","EX1_245","EX1_238","GVG_038","KAR_073","EX1_241","TRL_058","EX1_259","DAL_009","LOOT_506","GIL_504"}, new Power
			{
				// TODO [DALA_Shaman_08] Sssspells && Test: Sssspells_DALA_Shaman_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_09] Carvings (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_565, LOOT_062, UNG_201, AT_052, GIL_681, EX1_575, AT_046, AT_047, GIL_583, KAR_021, AT_049, LOOT_518, OG_028, OG_023, TRL_012, LOOT_344
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_09", new CardDef(new[] {"EX1_565","LOOT_062","UNG_201","AT_052","GIL_681","EX1_575","AT_046","AT_047","GIL_583","KAR_021","AT_049","LOOT_518","OG_028","OG_023","TRL_012","LOOT_344"}, new Power
			{
				// TODO [DALA_Shaman_09] Carvings && Test: Carvings_DALA_Shaman_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_10] Regeneration (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: DAL_544, CFM_120, UNG_938, CS2_117, LOOT_291, GIL_622, CFM_061, OG_209, GIL_667, GVG_069, GIL_118, DAL_432, LOOT_373, AT_048, UNG_817
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_10", new CardDef(new[] {"DAL_544","CFM_120","UNG_938","CS2_117","LOOT_291","GIL_622","CFM_061","OG_209","GIL_667","GVG_069","GIL_118","DAL_432","LOOT_373","AT_048","UNG_817"}, new Power
			{
				// TODO [DALA_Shaman_10] Regeneration && Test: Regeneration_DALA_Shaman_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_11] Shifting Scales (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: OG_123, EX1_083, TRL_085, CFM_697, EX1_564, CFM_668, DAL_052, LOE_053, GIL_198, DAL_431, OG_027, LOOT_504, TRL_082, CFM_696, UNG_956, EX1_246, ICC_481
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_11", new CardDef(new[] {"OG_123","EX1_083","TRL_085","CFM_697","EX1_564","CFM_668","DAL_052","LOE_053","GIL_198","DAL_431","OG_027","LOOT_504","TRL_082","CFM_696","UNG_956","EX1_246","ICC_481"}, new Power
			{
				// TODO [DALA_Shaman_11] Shifting Scales && Test: Shifting Scales_DALA_Shaman_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DALA_Shaman_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_411, TRL_085, DAL_546, OG_209, CFM_324, BOT_548, TRL_345, LOOT_358, AT_054, BRM_028, EX1_016, KAR_097, FP1_013, LOOT_357, EX1_298, ICC_314, DAL_431, EX1_572
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_12", new CardDef(new[] {"BOT_411","TRL_085","DAL_546","OG_209","CFM_324","BOT_548","TRL_345","LOOT_358","AT_054","BRM_028","EX1_016","KAR_097","FP1_013","LOOT_357","EX1_298","ICC_314","DAL_431","EX1_572"}, new Power
			{
				// TODO [DALA_Shaman_12] Legends && Test: Legends_DALA_Shaman_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [DALA_Warlock_HP2t] Devious Imp (*) - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_HP2t", new CardDef(new Power
			{
				// TODO [DALA_Warlock_HP2t] Devious Imp && Test: Devious Imp_DALA_Warlock_HP2t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_807] Random Warlock Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_807", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_807] Random Warlock Deck && Test: Random Warlock Deck_DALA_807
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_01] Big Demons (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: FP1_022, ICC_075, EX1_310, DAL_185, CS2_064, CFM_663, LOOT_306, AT_023, EX1_614, CFM_751, DAL_607, EX1_323, LOOT_368, GVG_021, DAL_561, GVG_019, EX1_320, BOT_521, LOOT_420, ICC_831
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_01", new CardDef(new[] {"FP1_022","ICC_075","EX1_310","DAL_185","CS2_064","CFM_663","LOOT_306","AT_023","EX1_614","CFM_751","DAL_607","EX1_323","LOOT_368","GVG_021","DAL_561","GVG_019","EX1_320","BOT_521","LOOT_420","ICC_831"}, new Power
			{
				// TODO [DALA_Warlock_01] Big Demons && Test: Big Demons_DALA_Warlock_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_02] Swarming (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: LOOT_014, OG_241, LOE_116, ICC_903, LOE_023, DAL_606, TRL_251, UNG_835, OG_113, BRM_006, AT_019, UNG_047, TRL_257, OG_114, EX1_316, GIL_191, KAR_025, TRL_555
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_02", new CardDef(new[] {"LOOT_014","OG_241","LOE_116","ICC_903","LOE_023","DAL_606","TRL_251","UNG_835","OG_113","BRM_006","AT_019","UNG_047","TRL_257","OG_114","EX1_316","GIL_191","KAR_025","TRL_555"}, new Power
			{
				// TODO [DALA_Warlock_02] Swarming && Test: Swarming_DALA_Warlock_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_03] Draw (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: LOOT_014, OG_109, GIL_815, BOT_559, EX1_050, LOE_079, DAL_582, LOOT_526, UNG_851, EX1_284, DAL_565, DAL_185, DAL_607, TRL_541, EX1_302, BOT_568, DAL_602, OG_239
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_03", new CardDef(new[] {"LOOT_014","OG_109","GIL_815","BOT_559","EX1_050","LOE_079","DAL_582","LOOT_526","UNG_851","EX1_284","DAL_565","DAL_185","DAL_607","TRL_541","EX1_302","BOT_568","DAL_602","OG_239"}, new Power
			{
				// TODO [DALA_Warlock_03] Draw && Test: Draw_DALA_Warlock_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_04] Sacrifice (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_903, DAL_606, EX1_301, GIL_515, EX1_304, UNG_047, LOOT_161, NEW1_003, EX1_316, CS2_063, TRL_249, ICC_469, UNG_831, BOT_913, LOE_007, EX1_303, CFM_608, DAL_173
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_04", new CardDef(new[] {"ICC_903","DAL_606","EX1_301","GIL_515","EX1_304","UNG_047","LOOT_161","NEW1_003","EX1_316","CS2_063","TRL_249","ICC_469","UNG_831","BOT_913","LOE_007","EX1_303","CFM_608","DAL_173"}, new Power
			{
				// TODO [DALA_Warlock_04] Sacrifice && Test: Sacrifice_DALA_Warlock_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_05] Pain (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_447, EX1_319, LOOT_014, GIL_508, LOOT_013, UNG_835, BOT_226, EX1_313, GIL_693, GIL_565, GVG_100, CS2_064, CFM_751, EX1_620, GIL_543, BOT_222, CS2_062, LOOT_043, CFM_094
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_05", new CardDef(new[] {"BOT_447","EX1_319","LOOT_014","GIL_508","LOOT_013","UNG_835","BOT_226","EX1_313","GIL_693","GIL_565","GVG_100","CS2_064","CFM_751","EX1_620","GIL_543","BOT_222","CS2_062","LOOT_043","CFM_094"}, new Power
			{
				// TODO [DALA_Warlock_05] Pain && Test: Pain_DALA_Warlock_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_06] Discard (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: KAR_089, UNG_836, OG_109, AT_021, TRL_551, KAR_205, TRL_252, UNG_833, ICC_841, EX1_310, UNG_830, TRL_247, NEW1_030, TRL_245, EX1_308, BOT_568, LOOT_417, AT_022
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_06", new CardDef(new[] {"KAR_089","UNG_836","OG_109","AT_021","TRL_551","KAR_205","TRL_252","UNG_833","ICC_841","EX1_310","UNG_830","TRL_247","NEW1_030","TRL_245","EX1_308","BOT_568","LOOT_417","AT_022"}, new Power
			{
				// TODO [DALA_Warlock_06] Discard && Test: Discard_DALA_Warlock_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_07] In Control (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_012, NEW1_021, EX1_058, EX1_043, OG_174, ICC_075, LOOT_415, GIL_618, BRM_028, GIL_124, CFM_751, GIL_825, ICC_314, LOOT_368, EX1_105, EX1_620, ICC_041, EX1_303, LOOT_043, EX1_309
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_07", new CardDef(new[] {"EX1_012","NEW1_021","EX1_058","EX1_043","OG_174","ICC_075","LOOT_415","GIL_618","BRM_028","GIL_124","CFM_751","GIL_825","ICC_314","LOOT_368","EX1_105","EX1_620","ICC_041","EX1_303","LOOT_043","EX1_309"}, new Power
			{
				// TODO [DALA_Warlock_07] In Control && Test: In Control_DALA_Warlock_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_08] Destruction (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, GIL_614, LOOT_161, EX1_002, AT_023, GVG_015, CS2_057, LOOT_417, CS2_062, EX1_303, AT_025, CFM_094, EX1_309, DAL_173, TRL_246, EX1_312, OG_239
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_08", new CardDef(new[] {"NEW1_021","GIL_614","LOOT_161","EX1_002","AT_023","GVG_015","CS2_057","LOOT_417","CS2_062","EX1_303","AT_025","CFM_094","EX1_309","DAL_173","TRL_246","EX1_312","OG_239"}, new Power
			{
				// TODO [DALA_Warlock_08] Destruction && Test: Destruction_DALA_Warlock_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_09] Lil' Demons (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CS2_059, EX1_319, KAR_089, CS2_065, GVG_018, BOT_443, LOOT_013, BOT_224, BRM_006, CFM_610, DAL_751, DAL_561, TRL_249, BOT_263, EX1_596, BRM_005, DAL_007, DAL_605, GVG_045
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_09", new CardDef(new[] {"CS2_059","EX1_319","KAR_089","CS2_065","GVG_018","BOT_443","LOOT_013","BOT_224","BRM_006","CFM_610","DAL_751","DAL_561","TRL_249","BOT_263","EX1_596","BRM_005","DAL_007","DAL_605","GVG_045"}, new Power
			{
				// TODO [DALA_Warlock_09] Lil' Demons && Test: Lil' Demons_DALA_Warlock_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_10] Empowering (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: ICC_092, EX1_004, TRL_251, ICC_094, OG_256, BOT_224, TRL_517, DAL_563, BOT_536, EX1_093, CFM_668, ICC_029, AT_090, LOOT_167, TRL_253, BOT_263, TRL_249, CFM_611
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_10", new CardDef(new[] {"ICC_092","EX1_004","TRL_251","ICC_094","OG_256","BOT_224","TRL_517","DAL_563","BOT_536","EX1_093","CFM_668","ICC_029","AT_090","LOOT_167","TRL_253","BOT_263","TRL_249","CFM_611"}, new Power
			{
				// TODO [DALA_Warlock_10] Empowering && Test: Empowering_DALA_Warlock_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_11] Curatives (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_120, GIL_558, GVG_018, GIL_143, CS2_117, GIL_622, TRL_252, GIL_565, BOT_548, ICC_905, GIL_667, DAL_185, LOOT_017, OG_118, ICC_055, CS2_061, LOOT_043, EX1_309
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_11", new CardDef(new[] {"CFM_120","GIL_558","GVG_018","GIL_143","CS2_117","GIL_622","TRL_252","GIL_565","BOT_548","ICC_905","GIL_667","DAL_185","LOOT_017","OG_118","ICC_055","CS2_061","LOOT_043","EX1_309"}, new Power
			{
				// TODO [DALA_Warlock_11] Curatives && Test: Curatives_DALA_Warlock_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DALA_Warlock_12] Legend (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: FP1_030, GIL_618, BRM_028, LOOT_415, EX1_016, GIL_825, DAL_422, GVG_110, BRM_031, FP1_013, DAL_607, KAR_097, EX1_298, ICC_314, BOT_433, LOE_092, GVG_021, EX1_572, OG_134, OG_042
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_12", new CardDef(new[] {"FP1_030","GIL_618","BRM_028","LOOT_415","EX1_016","GIL_825","DAL_422","GVG_110","BRM_031","FP1_013","DAL_607","KAR_097","EX1_298","ICC_314","BOT_433","LOE_092","GVG_021","EX1_572","OG_134","OG_042"}, new Power
			{
				// TODO [DALA_Warlock_12] Legend && Test: Legend_DALA_Warlock_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_808] Random Warrior Deck (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Start the run with a deck of random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 1076 = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 999
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_808", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_808] Random Warrior Deck && Test: Random Warrior Deck_DALA_808
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_01] Mercenaries (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: OG_312, CFM_637, CS2_146, NEW1_018, TRL_507, GVG_075, OG_315, GIL_681, NEW1_027, NEW1_022, CFM_651, TRL_015, NEW1_024, GVG_070, AT_070, CS2_106, FP1_021, CS2_112, KAR_028, CFM_631
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_01", new CardDef(new[] {"OG_312","CFM_637","CS2_146","NEW1_018","TRL_507","GVG_075","OG_315","GIL_681","NEW1_027","NEW1_022","CFM_651","TRL_015","NEW1_024","GVG_070","AT_070","CS2_106","FP1_021","CS2_112","KAR_028","CFM_631"}, new Power
			{
				// TODO [DALA_Warrior_01] Mercenaries && Test: Mercenaries_DALA_Warrior_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_02] Damaged (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_402, EX1_603, EX1_604, OG_149, ICC_408, OG_218, BRM_016, BOT_218, GIL_152, ICC_405, EX1_607, DAL_769, OG_314, EX1_400, EX1_392, CS2_108, UNG_927, TRL_360, FP1_021, ICC_834
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_02", new CardDef(new[] {"EX1_402","EX1_603","EX1_604","OG_149","ICC_408","OG_218","BRM_016","BOT_218","GIL_152","ICC_405","EX1_607","DAL_769","OG_314","EX1_400","EX1_392","CS2_108","UNG_927","TRL_360","FP1_021","ICC_834"}, new Power
			{
				// TODO [DALA_Warrior_02] Damaged && Test: Damaged_DALA_Warrior_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_03] Big Minions (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: LOE_009, UNG_838, EX1_298, GIL_616, ICC_314, LOOT_153, EX1_414, ICC_405, OG_173, BOT_534, AT_072, DAL_070, OG_042, EX1_620, LOOT_370, BOT_069, DAL_059, LOOT_380
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_03", new CardDef(new[] {"LOE_009","UNG_838","EX1_298","GIL_616","ICC_314","LOOT_153","EX1_414","ICC_405","OG_173","BOT_534","AT_072","DAL_070","OG_042","EX1_620","LOOT_370","BOT_069","DAL_059","LOOT_380"}, new Power
			{
				// TODO [DALA_Warrior_03] Big Minions && Test: Big Minions_DALA_Warrior_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_04] Bombs Away! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: EX1_082, BOT_431, GIL_815, LOE_077, BOT_532, DAL_060, BOT_559, EX1_050, GVG_099, CFM_667, GVG_090, BOT_511, GVG_056, DAL_064, GVG_110, ICC_091, DAL_063
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_04", new CardDef(new[] {"EX1_082","BOT_431","GIL_815","LOE_077","BOT_532","DAL_060","BOT_559","EX1_050","GVG_099","CFM_667","GVG_090","BOT_511","GVG_056","DAL_064","GVG_110","ICC_091","DAL_063"}, new Power
			{
				// TODO [DALA_Warrior_04] Bombs Away! && Test: Bombs Away!_DALA_Warrior_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_05] Rush (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: TRL_327, GIL_580, GIL_155, GIL_113, GIL_803, NEW1_011, EX1_116, GIL_547, EX1_067, TRL_550, TRL_329, EX1_414, GIL_202, DAL_070, NEW1_036, DAL_062, CS2_105, BOT_069, GIL_653
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_05", new CardDef(new[] {"TRL_327","GIL_580","GIL_155","GIL_113","GIL_803","NEW1_011","EX1_116","GIL_547","EX1_067","TRL_550","TRL_329","EX1_414","GIL_202","DAL_070","NEW1_036","DAL_062","CS2_105","BOT_069","GIL_653"}, new Power
			{
				// TODO [DALA_Warrior_05] Rush && Test: Rush_DALA_Warrior_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_06] Iron and Steel (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GVG_051, DAL_759, GVG_085, BOT_907, GVG_006, DAL_060, DAL_770, BOT_312, BOT_563, BOT_548, BOT_104, BOT_107, GVG_056, BOT_218, BOT_237, GVG_114, DAL_070, BOT_299, GVG_050, BOT_406, BOT_238
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_06", new CardDef(new[] {"GVG_051","DAL_759","GVG_085","BOT_907","GVG_006","DAL_060","DAL_770","BOT_312","BOT_563","BOT_548","BOT_104","BOT_107","GVG_056","BOT_218","BOT_237","GVG_114","DAL_070","BOT_299","GVG_050","BOT_406","BOT_238"}, new Power
			{
				// TODO [DALA_Warrior_06] Iron and Steel && Test: Iron and Steel_DALA_Warrior_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_07] Dragon (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: AT_071, TRL_326, TRL_328, TRL_323, BRM_034, ICC_027, AT_123, TRL_569, GIL_526, BRM_031, UNG_848, LOOT_540, EX1_563, EX1_562, EX1_572, LOOT_137, NEW1_030, OG_317, TRL_362, EX1_284, ICC_029
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_07", new CardDef(new[] {"AT_071","TRL_326","TRL_328","TRL_323","BRM_034","ICC_027","AT_123","TRL_569","GIL_526","BRM_031","UNG_848","LOOT_540","EX1_563","EX1_562","EX1_572","LOOT_137","NEW1_030","OG_317","TRL_362","EX1_284","ICC_029"}, new Power
			{
				// TODO [DALA_Warrior_07] Dragon && Test: Dragon_DALA_Warrior_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_08] Armored Up (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: BOT_059, BOT_447, LOOT_413, EX1_402, LOOT_367, DAL_759, ICC_062, CFM_756, LOOT_365, GVG_053, LOOT_519, EX1_410, ICC_837, BOT_042, AT_064, DAL_008, LOOT_364, EX1_606, KAR_091, LOOT_285
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_08", new CardDef(new[] {"BOT_059","BOT_447","LOOT_413","EX1_402","LOOT_367","DAL_759","ICC_062","CFM_756","LOOT_365","GVG_053","LOOT_519","EX1_410","ICC_837","BOT_042","AT_064","DAL_008","LOOT_364","EX1_606","KAR_091","LOOT_285"}, new Power
			{
				// TODO [DALA_Warrior_08] Armored Up && Test: Armored Up_DALA_Warrior_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_09] Arsenal (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CS2_146, NEW1_018, CFM_643, BOT_083, CFM_755, AT_066, EX1_398, NEW1_024, OG_220, EX1_409, GIL_537, LOOT_203, UNG_929, CFM_631, ICC_064, CS2_112, BOT_406, TRL_325, EX1_411
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_09", new CardDef(new[] {"CS2_146","NEW1_018","CFM_643","BOT_083","CFM_755","AT_066","EX1_398","NEW1_024","OG_220","EX1_409","GIL_537","LOOT_203","UNG_929","CFM_631","ICC_064","CS2_112","BOT_406","TRL_325","EX1_411"}, new Power
			{
				// TODO [DALA_Warrior_09] Arsenal && Test: Arsenal_DALA_Warrior_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_10] All Might (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, NEW1_041, AT_130, EX1_002, GIL_124, UNG_933, BOT_424, NEW1_030, TRL_321, CFM_716, EX1_391, CS2_104, CS2_114, CS2_108, EX1_407, GVG_052, GVG_054
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_10", new CardDef(new[] {"NEW1_021","NEW1_041","AT_130","EX1_002","GIL_124","UNG_933","BOT_424","NEW1_030","TRL_321","CFM_716","EX1_391","CS2_104","CS2_114","CS2_108","EX1_407","GVG_052","GVG_054"}, new Power
			{
				// TODO [DALA_Warrior_10] All Might && Test: All Might_DALA_Warrior_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_11] Taunt (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: CFM_790, UNG_808, AT_069, UNG_928, UNG_072, GIL_207, LOE_022, CFM_756, UNG_957, FP1_012, GIL_667, DAL_088, UNG_925, UNG_838, UNG_848, OG_340, CFM_940, AT_068, AT_065, BOT_548
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_11", new CardDef(new[] {"CFM_790","UNG_808","AT_069","UNG_928","UNG_072","GIL_207","LOE_022","CFM_756","UNG_957","FP1_012","GIL_667","DAL_088","UNG_925","UNG_838","UNG_848","OG_340","CFM_940","AT_068","AT_065","BOT_548"}, new Power
			{
				// TODO [DALA_Warrior_11] Taunt && Test: Taunt_DALA_Warrior_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DALA_Warrior_12] Legends (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Entourage: GIL_547, FP1_030, BRM_028, EX1_016, GVG_056, OG_220, EX1_249, GVG_110, GVG_118, EX1_414, ICC_405, GVG_113, FP1_013, EX1_298, ICC_314, EX1_572, AT_072, TRL_541, UNG_933, BRM_030
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_12", new CardDef(new[] {"GIL_547","FP1_030","BRM_028","EX1_016","GVG_056","OG_220","EX1_249","GVG_110","GVG_118","EX1_414","ICC_405","GVG_113","FP1_013","EX1_298","ICC_314","EX1_572","AT_072","TRL_541","UNG_933","BRM_030"}, new Power
			{
				// TODO [DALA_Warrior_12] Legends && Test: Legends_DALA_Warrior_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_502e] Rich (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_502e", new CardDef(new Power
			{
				// TODO [DALA_502e] Rich && Test: Rich_DALA_502e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_502e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_701e] Sifting (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Transforming into random treasures.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_701e", new CardDef(new Power
			{
				// TODO [DALA_701e] Sifting && Test: Sifting_DALA_701e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_701e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_702e] Tooled Up! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Granted <b>Charge</b>,
			//       <b>Windfury</b>, <b>Divine Shield</b>,
			//       <b>Lifesteal</b>, <b>Poisonous</b>,
			//       <b>Taunt</b>, and <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_702e", new CardDef(new Power
			{
				// TODO [DALA_702e] Tooled Up! && Test: Tooled Up!_DALA_702e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_702e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_707e] Scheming (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_707e", new CardDef(new Power
			{
				// TODO [DALA_707e] Scheming && Test: Scheming_DALA_707e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_707e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_715e] Overpowered (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_715e", new CardDef(new Power
			{
				// TODO [DALA_715e] Overpowered && Test: Overpowered_DALA_715e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_715e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_723e] Hyperblaster Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_723e", new CardDef(new Power
			{
				// TODO [DALA_723e] Hyperblaster Enchantment && Test: Hyperblaster Enchantment_DALA_723e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_723e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_724e] Big Boomba Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy all minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_724e", new CardDef(new Power
			{
				// TODO [DALA_724e] Big Boomba Player Enchantment && Test: Big Boomba Player Enchantment_DALA_724e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_724e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_725e] Glowing Green (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_725e", new CardDef(new Power
			{
				// TODO [DALA_725e] Glowing Green && Test: Glowing Green_DALA_725e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_725e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_727e] Seeds Sown (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_727e", new CardDef(new Power
			{
				// TODO [DALA_727e] Seeds Sown && Test: Seeds Sown_DALA_727e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_727e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_728e] Recycling Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_728e", new CardDef(new Power
			{
				// TODO [DALA_728e] Recycling Player Enchantment && Test: Recycling Player Enchantment_DALA_728e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_728e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_731e] Rocket Backpacks Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_731e", new CardDef(new Power
			{
				// TODO [DALA_731e] Rocket Backpacks Player Enchantment && Test: Rocket Backpacks Player Enchantment_DALA_731e
				InfoCardId = "DALA_731e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_731e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_731e2] Rocket Backpack (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_731e2", new CardDef(new Power
			{
				// TODO [DALA_731e2] Rocket Backpack && Test: Rocket Backpack_DALA_731e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_731e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_733e] Emerald Goggles Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_733e", new CardDef(new Power
			{
				// TODO [DALA_733e] Emerald Goggles Player Enchantment && Test: Emerald Goggles Player Enchantment_DALA_733e
				InfoCardId = "DALA_733e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_733e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_733e2] Emerald Goggles (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Cost reduced by (2).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_733e2", new CardDef(new Power
			{
				// TODO [DALA_733e2] Emerald Goggles && Test: Emerald Goggles_DALA_733e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_733e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_735e] Robes of Gaudiness Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Your cards cost half, but you can only play two cards each turn.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_735e", new CardDef(new Power
			{
				// TODO [DALA_735e] Robes of Gaudiness Player Enchantment && Test: Robes of Gaudiness Player Enchantment_DALA_735e
				InfoCardId = "DALA_735e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_735e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_735e2] Robes of Gaudiness (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs half.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_735e2", new CardDef(new Power
			{
				// TODO [DALA_735e2] Robes of Gaudiness && Test: Robes of Gaudiness_DALA_735e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_735e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_735e3] Too Gaudy (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Can't play cards this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_735e3", new CardDef(new Power
			{
				// TODO [DALA_735e3] Too Gaudy && Test: Too Gaudy_DALA_735e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_735e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_736e] Stargazing Player Enchant (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_736e", new CardDef(new Power
			{
				// TODO [DALA_736e] Stargazing Player Enchant && Test: Stargazing Player Enchant_DALA_736e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_736e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_737e] E.V.I.L. Upgrade (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1 Attack and +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_737e", new CardDef(new Power
			{
				// TODO [DALA_737e] E.V.I.L. Upgrade && Test: E.V.I.L. Upgrade_DALA_737e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_737e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_738e] A Prince's Ring Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_738e", new CardDef(new Power
			{
				// TODO [DALA_738e] A Prince's Ring Enchantment && Test: A Prince's Ring Enchantment_DALA_738e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_738e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_740e] Wondrous Wisdomball Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_740e", new CardDef(new Power
			{
				// TODO [DALA_740e] Wondrous Wisdomball Player Enchantment && Test: Wondrous Wisdomball Player Enchantment_DALA_740e
				InfoCardId = "DALA_740e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_740e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_740e2] Wondrous Wisdomball Ice Block (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_740e2", new CardDef(new Power
			{
				// TODO [DALA_740e2] Wondrous Wisdomball Ice Block && Test: Wondrous Wisdomball Ice Block_DALA_740e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_740e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_740e3] Wondrous Wisdomball Extra Spellcast (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_740e3", new CardDef(new Power
			{
				// TODO [DALA_740e3] Wondrous Wisdomball Extra Spellcast && Test: Wondrous Wisdomball Extra Spellcast_DALA_740e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_740e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_741e] Togwaggle's Dice Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of your turn, randomize the cost of all cards in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_741e", new CardDef(new Power
			{
				// TODO [DALA_741e] Togwaggle's Dice Player Enchantment && Test: Togwaggle's Dice Player Enchantment_DALA_741e
				InfoCardId = "DALA_741e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_741e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_741e2] Roll the Dice (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Cost manipulated by Togwaggle's Dice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_741e2", new CardDef(new Power
			{
				// TODO [DALA_741e2] Roll the Dice && Test: Roll the Dice_DALA_741e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_741e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_743e] Sleepy (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_743e", new CardDef(new Power
			{
				// TODO [DALA_743e] Sleepy && Test: Sleepy_DALA_743e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_743e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_744e] Hagatha's Embrace Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the start of your turn, give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_744e", new CardDef(new Power
			{
				// TODO [DALA_744e] Hagatha's Embrace Player Enchantment && Test: Hagatha's Embrace Player Enchantment_DALA_744e
				InfoCardId = "DALA_744e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_744e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_744e2] Hagatha's Embrace (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_744e2", new CardDef(new Power
			{
				// TODO [DALA_744e2] Hagatha's Embrace && Test: Hagatha's Embrace_DALA_744e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_744e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_746e] Elixir of Vigor Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After you play a minion, shuffle two copies of it into your deck. They cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_746e", new CardDef(new Power
			{
				// TODO [DALA_746e] Elixir of Vigor Player Enchantment && Test: Elixir of Vigor Player Enchantment_DALA_746e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_746e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_747e] Elixir of Vim Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Draw 2 additional cards each turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_747e", new CardDef(new Power
			{
				// TODO [DALA_747e] Elixir of Vim Player Enchantment && Test: Elixir of Vim Player Enchantment_DALA_747e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_747e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_748e] Elixir of Vile Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Your spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_748e", new CardDef(new Power
			{
				// TODO [DALA_748e] Elixir of Vile Player Enchantment && Test: Elixir of Vile Player Enchantment_DALA_748e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_748e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_831e] Undesirable Stench Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All minions' Attack and Health are swapped.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_831e", new CardDef(new Power
			{
				// TODO [DALA_831e] Undesirable Stench Player Enchantment && Test: Undesirable Stench Player Enchantment_DALA_831e
				InfoCardId = "DALA_831e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_831e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_831e2] Stinky (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Attack and Health are swapped.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_831e2", new CardDef(new Power
			{
				// TODO [DALA_831e2] Stinky && Test: Stinky_DALA_831e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_831e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_850e] Anomaly - Arcane Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All spells cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_850e", new CardDef(new Power
			{
				// TODO [DALA_850e] Anomaly - Arcane Player Enchantment && Test: Anomaly - Arcane Player Enchantment_DALA_850e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_850e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_851e] Anomaly - Summons Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a spell is played, a minion of the same cost is summoned.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_851e", new CardDef(new Power
			{
				// TODO [DALA_851e] Anomaly - Summons Player Enchantment && Test: Anomaly - Summons Player Enchantment_DALA_851e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_851e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_852e] Anomaly - Crying Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_852e", new CardDef(new Power
			{
				// TODO [DALA_852e] Anomaly - Crying Player Enchantment && Test: Anomaly - Crying Player Enchantment_DALA_852e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_852e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_853e] Anomaly - Rattling Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_853e", new CardDef(new Power
			{
				// TODO [DALA_853e] Anomaly - Rattling Player Enchantment && Test: Anomaly - Rattling Player Enchantment_DALA_853e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_853e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_854e] Anomaly - Nesting Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is played, it gains "<b>Deathrattle:</b> Summon a 1/1 copy of this minion."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_854e", new CardDef(new Power
			{
				// TODO [DALA_854e] Anomaly - Nesting Player Enchantment && Test: Anomaly - Nesting Player Enchantment_DALA_854e
				InfoCardId = "DALA_854e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_854e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_854e2] Nested (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Granted "<b>Deathrattle:</b> Summon a 1/1 copy of this minion."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_854e2", new CardDef(new Power
			{
				// TODO [DALA_854e2] Nested && Test: Nested_DALA_854e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_854e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_854e3] Popped Out (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_854e3", new CardDef(new Power
			{
				// TODO [DALA_854e3] Popped Out && Test: Popped Out_DALA_854e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_854e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_855e] Anomaly - Refreshing Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of each player's turn, that player draws until they have 5 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_855e", new CardDef(new Power
			{
				// TODO [DALA_855e] Anomaly - Refreshing Player Enchantment && Test: Anomaly - Refreshing Player Enchantment_DALA_855e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_855e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_856e] Anomaly - Wild Magic Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All spells cast an additional time. <i>(targets chosen randomly)</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_856e", new CardDef(new Power
			{
				// TODO [DALA_856e] Anomaly - Wild Magic Player Enchantment && Test: Anomaly - Wild Magic Player Enchantment_DALA_856e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_856e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_857e] Anomaly - Glittering Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a player plays a card that costs (8) or more, that player adds a Treasure to their hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_857e", new CardDef(new Power
			{
				// TODO [DALA_857e] Anomaly - Glittering Player Enchantment && Test: Anomaly - Glittering Player Enchantment_DALA_857e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_857e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_858e] Anomaly - Fishy Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Murlocs occasionally join the battle.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_858e", new CardDef(new Power
			{
				// TODO [DALA_858e] Anomaly - Fishy Player Enchantment && Test: Anomaly - Fishy Player Enchantment_DALA_858e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_858e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_860e] Anomaly - Dragon Soul Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a player casts 3 spells in a turn, that player summons a 5/5 Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_860e", new CardDef(new Power
			{
				// TODO [DALA_860e] Anomaly - Dragon Soul Player Enchantment && Test: Anomaly - Dragon Soul Player Enchantment_DALA_860e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_860e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_861e] Anomaly - Ogreish Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All minions have a 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_861e", new CardDef(new Power
			{
				// TODO [DALA_861e] Anomaly - Ogreish Player Enchantment && Test: Anomaly - Ogreish Player Enchantment_DALA_861e
				InfoCardId = "DALA_861e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_861e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_861e2] Ogreish (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: 50% chance to attack the wrong enemy
			// --------------------------------------------------------
			// GameTag:
			// - FORGETFUL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_861e2", new CardDef(new Power
			{
				// TODO [DALA_861e2] Ogreish && Test: Ogreish_DALA_861e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_861e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_862e] Anomaly - Reductive Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of each player's turn, reduce the cost of cards in their hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_862e", new CardDef(new Power
			{
				// TODO [DALA_862e] Anomaly - Reductive Player Enchantment && Test: Anomaly - Reductive Player Enchantment_DALA_862e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_862e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_864e] Anomaly - Growing Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Minions gain +1/+1 at the end of their owner's turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_864e", new CardDef(new Power
			{
				// TODO [DALA_864e] Anomaly - Growing Player Enchantment && Test: Anomaly - Growing Player Enchantment_DALA_864e
				InfoCardId = "DALA_864e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_864e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_864e2] Growth Anomaly (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_864e2", new CardDef(new Power
			{
				// TODO [DALA_864e2] Growth Anomaly && Test: Growth Anomaly_DALA_864e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_864e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_865e] Anomaly - Explosive Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is summoned, it gains "<b>Deathrattle</b>: Deal 1 damage to all minions."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_865e", new CardDef(new Power
			{
				// TODO [DALA_865e] Anomaly - Explosive Player Enchantment && Test: Anomaly - Explosive Player Enchantment_DALA_865e
				InfoCardId = "DALA_865e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_865e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_865e2] Explosive (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Granted '<b>Deathrattle</b>: Deal 1 damage to all minions.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_865e2", new CardDef(new Power
			{
				// TODO [DALA_865e2] Explosive && Test: Explosive_DALA_865e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_865e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_866e] Anomaly - Rejuvenating Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]At the start of each
			//       player's turn, that
			//       player restores 2 Health
			//       to their hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_866e", new CardDef(new Power
			{
				// TODO [DALA_866e] Anomaly - Rejuvenating Player Enchantment && Test: Anomaly - Rejuvenating Player Enchantment_DALA_866e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_866e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_867e] Anomaly - Infused Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is summoned, it gains <b>Taunt</b>, <b>Divine Shield</b>, <b>Rush</b>, or <b>Windfury</b> at random.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_867e", new CardDef(new Power
			{
				// TODO [DALA_867e] Anomaly - Infused Player Enchantment && Test: Anomaly - Infused Player Enchantment_DALA_867e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_867e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_903e] Lucky! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - HIDE_WATERMARK = 1
			// - UI_BUFF_SET_COST_ZERO = 1
			// --------------------------------------------------------
			cards.Add("DALA_903e", new CardDef(new Power
			{
				// TODO [DALA_903e] Lucky! && Test: Lucky!_DALA_903e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_903e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_905e] Right Hand Man (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Always starts in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_905e", new CardDef(new Power
			{
				// TODO [DALA_905e] Right Hand Man && Test: Right Hand Man_DALA_905e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_905e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_906e] Merriment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - HIDE_WATERMARK = 1
			// - UI_BUFF_HEALTH_UP = 1
			// - UI_BUFF_ATK_UP = 1
			// --------------------------------------------------------
			cards.Add("DALA_906e", new CardDef(new Power
			{
				// TODO [DALA_906e] Merriment && Test: Merriment_DALA_906e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_906e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_908e] Stories Told (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - HIDE_WATERMARK = 1
			// - UI_BUFF_HEALTH_UP = 2
			// - UI_BUFF_ATK_UP = 2
			// --------------------------------------------------------
			cards.Add("DALA_908e", new CardDef(new Power
			{
				// TODO [DALA_908e] Stories Told && Test: Stories Told_DALA_908e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_908e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_914e] The Upper Hand (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - HIDE_WATERMARK = 1
			// - UI_BUFF_COST_DOWN = 3
			// --------------------------------------------------------
			cards.Add("DALA_914e", new CardDef(new Power
			{
				// TODO [DALA_914e] The Upper Hand && Test: The Upper Hand_DALA_914e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_914e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_03e] Reductomara'd (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03e] Reductomara'd && Test: Reductomara'd_DALA_BOSS_03e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_03e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_03t3e] Presto Legendaro Marker (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03t3e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03t3e] Presto Legendaro Marker && Test: Presto Legendaro Marker_DALA_BOSS_03t3e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_03t3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_07e] Flying! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Belnaara is <b>Immune</b> for now.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_07e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_07e] Flying! && Test: Flying!_DALA_BOSS_07e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_07e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_11e] Backstabby (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_11e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_11e] Backstabby && Test: Backstabby_DALA_BOSS_11e
				InfoCardId = "DALA_BOSS_11ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_11e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_11ex] Backstabby (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_11ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_11ex] Backstabby && Test: Backstabby_DALA_BOSS_11ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_11ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_16e] Equivalent Exchange Marker (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_16e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_16e] Equivalent Exchange Marker && Test: Equivalent Exchange Marker_DALA_BOSS_16e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_16e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_22ex] Shushed (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b><b>Silence</b>d</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_22ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_22ex] Shushed && Test: Shushed_DALA_BOSS_22ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_22ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_24e] Ar'ha's Call Player Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Triggers additional <b>Battlecries.</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_24e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_24e] Ar'ha's Call Player Enchantment && Test: Ar'ha's Call Player Enchantment_DALA_BOSS_24e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_24e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_25e] Toyification (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Stats changed to 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_25e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_25e] Toyification && Test: Toyification_DALA_BOSS_25e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_25e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_28e] Savvy (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (0) this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_28e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_28e] Savvy && Test: Savvy_DALA_BOSS_28e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_28e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_31e] Blinged Out! (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has +4/+4. This minion is STUNNING!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_31e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_31e] Blinged Out! && Test: Blinged Out!_DALA_BOSS_31e
				InfoCardId = "DALA_BOSS_31ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_31e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_31ex] Blinged Out! (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has +8/+8. This minion is GORGEOUS!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_31ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_31ex] Blinged Out! && Test: Blinged Out!_DALA_BOSS_31ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_31ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_32e1] Nondescript Fade (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32e1", new CardDef(new Power
			{
				// TODO [DALA_BOSS_32e1] Nondescript Fade && Test: Nondescript Fade_DALA_BOSS_32e1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_32e1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_32e2] Intrusive Pompadour (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32e2", new CardDef(new Power
			{
				// TODO [DALA_BOSS_32e2] Intrusive Pompadour && Test: Intrusive Pompadour_DALA_BOSS_32e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_32e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_32e3] Incredible Quiff (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Health
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32e3", new CardDef(new Power
			{
				// TODO [DALA_BOSS_32e3] Incredible Quiff && Test: Incredible Quiff_DALA_BOSS_32e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_32e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_32e4] Aggressive Mohawk (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Attack
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_32e4", new CardDef(new Power
			{
				// TODO [DALA_BOSS_32e4] Aggressive Mohawk && Test: Aggressive Mohawk_DALA_BOSS_32e4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_32e4")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_39e] Light-imbued (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_39e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_39e] Light-imbued && Test: Light-imbued_DALA_BOSS_39e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_39e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_44e] Forseen (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_44e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_44e] Forseen && Test: Forseen_DALA_BOSS_44e
				InfoCardId = "DALA_BOSS_44ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_44e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_44ex] Forseen (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_44ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_44ex] Forseen && Test: Forseen_DALA_BOSS_44ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_44ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_48e] Voided (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: In the Void.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_48e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_48e] Voided && Test: Voided_DALA_BOSS_48e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_48e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_52e] Hold Fast! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_52e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_52e] Hold Fast! && Test: Hold Fast!_DALA_BOSS_52e
				InfoCardId = "DALA_BOSS_52ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_52e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_52ex] Hold Fast! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +4 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_52ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_52ex] Hold Fast! && Test: Hold Fast!_DALA_BOSS_52ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_52ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_53e] Boogie Beyond (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Granted "<b>Deathrattle:</b> Resummon this minion."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_53e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_53e] Boogie Beyond && Test: Boogie Beyond_DALA_BOSS_53e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_53e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_57e] Tracking Coin Played Enchantment (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_57e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_57e] Tracking Coin Played Enchantment && Test: Tracking Coin Played Enchantment_DALA_BOSS_57e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_57e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_58e] Blast Powder (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: If this minion takes damage, it will be destroyed.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_58e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_58e] Blast Powder && Test: Blast Powder_DALA_BOSS_58e
				InfoCardId = "DALA_BOSS_58e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_58e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_59e] Payday (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59e] Payday && Test: Payday_DALA_BOSS_59e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_59e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_62e] Darkened (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: -2 Attack until next turn
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_62e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_62e] Darkened && Test: Darkened_DALA_BOSS_62e
				InfoCardId = "DALA_BOSS_62ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_62e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_62ex] Darkened (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: -1 Attack
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_62ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_62ex] Darkened && Test: Darkened_DALA_BOSS_62ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_62ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_64e] Capital Gains (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_64e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_64e] Capital Gains && Test: Capital Gains_DALA_BOSS_64e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_64e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_73e] Earthmother's Rancor (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_73e", new CardDef(new Power
			{
				// TODO [DALA_BOSS_73e] Earthmother's Rancor && Test: Earthmother's Rancor_DALA_BOSS_73e
				InfoCardId = "DALA_BOSS_73ex",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_73e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_73ex] Earthmother's Rancor (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Mega-Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_73ex", new CardDef(new Power
			{
				// TODO [DALA_BOSS_73ex] Earthmother's Rancor && Test: Earthmother's Rancor_DALA_BOSS_73ex
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_73ex")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_75e1] Bear Liver Quest (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75e1", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_75e1] Bear Liver Quest && Test: Bear Liver Quest_DALA_BOSS_75e1
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_75e1")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_75e2] Murloc Quest (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75e2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_BOSS_75e2] Murloc Quest && Test: Murloc Quest_DALA_BOSS_75e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_75e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_75e3] Turtle Escort Quest (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75e3", new CardDef(new Power
			{
				// TODO [DALA_BOSS_75e3] Turtle Escort Quest && Test: Turtle Escort Quest_DALA_BOSS_75e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_75e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_75e4] Herbalist Quest (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75e4", new CardDef(new Power
			{
				// TODO [DALA_BOSS_75e4] Herbalist Quest && Test: Herbalist Quest_DALA_BOSS_75e4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_75e4")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_BOSS_75e5] Hogger Quest (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// - ENCHANTMENT_INVISIBLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_75e5", new CardDef(new Power
			{
				// TODO [DALA_BOSS_75e5] Hogger Quest && Test: Hogger Quest_DALA_BOSS_75e5
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_BOSS_75e5")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Druid_HP2e] Barky (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_HP2e", new CardDef(new Power
			{
				// TODO [DALA_Druid_HP2e] Barky && Test: Barky_DALA_Druid_HP2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Druid_HP2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Druid_HPe] Druid Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Druid_HPe", new CardDef(new Power
			{
				// TODO [DALA_Druid_HPe] Druid Hero Power Watcher && Test: Druid Hero Power Watcher_DALA_Druid_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Druid_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Hunter_HP1e] Opportunist (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HP1e", new CardDef(new Power
			{
				// TODO [DALA_Hunter_HP1e] Opportunist && Test: Opportunist_DALA_Hunter_HP1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Hunter_HP1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Hunter_HP2e] Shifting (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Transforming into a random 1-cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HP2e", new CardDef(new Power
			{
				// TODO [DALA_Hunter_HP2e] Shifting && Test: Shifting_DALA_Hunter_HP2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Hunter_HP2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Hunter_HPe] Hunter Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Hunter_HPe", new CardDef(new Power
			{
				// TODO [DALA_Hunter_HPe] Hunter Hero Power Watcher && Test: Hunter Hero Power Watcher_DALA_Hunter_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Hunter_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Mage_HP1e] Witty (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_HP1e", new CardDef(new Power
			{
				// TODO [DALA_Mage_HP1e] Witty && Test: Witty_DALA_Mage_HP1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Mage_HP1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Mage_HPe] Mage Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Mage_HPe", new CardDef(new Power
			{
				// TODO [DALA_Mage_HPe] Mage Hero Power Watcher && Test: Mage Hero Power Watcher_DALA_Mage_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Mage_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Paladin_HPe] Paladin Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Paladin_HPe", new CardDef(new Power
			{
				// TODO [DALA_Paladin_HPe] Paladin Hero Power Watcher && Test: Paladin Hero Power Watcher_DALA_Paladin_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Paladin_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Priest_HP1e] Distorted (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Distort.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_HP1e", new CardDef(new Power
			{
				// TODO [DALA_Priest_HP1e] Distorted && Test: Distorted_DALA_Priest_HP1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Priest_HP1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Priest_HP2e] Soothed (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: -2 Attack until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_HP2e", new CardDef(new Power
			{
				// TODO [DALA_Priest_HP2e] Soothed && Test: Soothed_DALA_Priest_HP2e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Priest_HP2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Priest_HPe] Priest Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Priest_HPe", new CardDef(new Power
			{
				// TODO [DALA_Priest_HPe] Priest Hero Power Watcher && Test: Priest Hero Power Watcher_DALA_Priest_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Priest_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Rogue_HPe] Rogue Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Rogue_HPe", new CardDef(new Power
			{
				// TODO [DALA_Rogue_HPe] Rogue Hero Power Watcher && Test: Rogue Hero Power Watcher_DALA_Rogue_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Rogue_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Shaman_HPe] Shaman Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Shaman_HPe", new CardDef(new Power
			{
				// TODO [DALA_Shaman_HPe] Shaman Hero Power Watcher && Test: Shaman Hero Power Watcher_DALA_Shaman_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Shaman_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Warlock_HPe] Warlock Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warlock_HPe", new CardDef(new Power
			{
				// TODO [DALA_Warlock_HPe] Warlock Hero Power Watcher && Test: Warlock Hero Power Watcher_DALA_Warlock_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Warlock_HPe")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Warrior_HP1e] Invigorated (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_HP1e", new CardDef(new Power
			{
				// TODO [DALA_Warrior_HP1e] Invigorated && Test: Invigorated_DALA_Warrior_HP1e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Warrior_HP1e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DALA_Warrior_HPe] Warrior Hero Power Watcher (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1137 = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_HPe", new CardDef(new Power
			{
				// TODO [DALA_Warrior_HPe] Warrior Hero Power Watcher && Test: Warrior Hero Power Watcher_DALA_Warrior_HPe
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DALA_Warrior_HPe")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_502] Infuriated Banker (*) - COST:2 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Whenever a Coin is played, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_502", new CardDef(new Power
			{
				// TODO [DALA_502] Infuriated Banker && Test: Infuriated Banker_DALA_502
				InfoCardId = "DALA_502e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_503] Kirin Tor Guard (*) - COST:2 [ATK:1/HP:4] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Has +1_Attack for each other friendly Kirin Tor Guard.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_503", new CardDef(new Power
			{
				// TODO [DALA_503] Kirin Tor Guard && Test: Kirin Tor Guard_DALA_503
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_504] Kirin Tor Elemental (*) - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Your spells cast an additional time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_504", new CardDef(new Power
			{
				// TODO [DALA_504] Kirin Tor Elemental && Test: Kirin Tor Elemental_DALA_504
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_703] The Muscle (*) - COST:4 [ATK:4/HP:5] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add three random cards to your hand. They cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_703", new CardDef(new Power
			{
				// TODO [DALA_703] The Muscle && Test: The Muscle_DALA_703
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_705] Grimmer Patron (*) - COST:3 [ATK:3/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_705", new CardDef(new Power
			{
				// TODO [DALA_705] Grimmer Patron && Test: Grimmer Patron_DALA_705
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_707] Loyal Henchman (*) - COST:1 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b> Draw this.
			//       <b>Taunt</b>. Each turn this is in
			//       your hand, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_707", new CardDef(new Power
			{
				// TODO [DALA_707] Loyal Henchman && Test: Loyal Henchman_DALA_707
				InfoCardId = "DALA_707e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_709] Golden Candle (*) - COST:4 [ATK:7/HP:7] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Replace ALL other cards with random Legendary minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_709", new CardDef(new Power
			{
				// TODO [DALA_709] Golden Candle && Test: Golden Candle_DALA_709
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_713] Elder Taggawag (*) - COST:3 [ATK:4/HP:4] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 4 damage
			//       to all enemy minions.
			//       <b>Deathrattle:</b> Shuffle
			//       this into your deck
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// - 542 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_713", new CardDef(new Power
			{
				// TODO [DALA_713] Elder Taggawag && Test: Elder Taggawag_DALA_713
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_718] Elistra the Immortal (*) - COST:3 [ATK:1/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Recast all spells you've cast on this minion this run.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_718", new CardDef(new Power
			{
				// TODO [DALA_718] Elistra the Immortal && Test: Elistra the Immortal_DALA_718
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_729] Dagwik Stickytoe (*) - COST:3 [ATK:2/HP:5] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       After this minion attacks
			//       a hero, steal a card from
			//          your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_729", new CardDef(new Power
			{
				// TODO [DALA_729] Dagwik Stickytoe && Test: Dagwik Stickytoe_DALA_729
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_730] Murgatha (*) - COST:3 [ATK:3/HP:6] 
			// - Race: murloc, Set: dalaran, 
			// --------------------------------------------------------
			// Text: Whenever you play
			//       a card, <b>Overload</b> one
			//       of your opponent's
			//       Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("DALA_730", new CardDef(new Power
			{
				// TODO [DALA_730] Murgatha && Test: Murgatha_DALA_730
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_829t] Cache of Cash (*) - COST:1 [ATK:0/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give each player two Coins.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_829t", new CardDef(new Power
			{
				// TODO [DALA_829t] Cache of Cash && Test: Cache of Cash_DALA_829t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_832t] Violet Prison (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 55690
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("DALA_832t", new CardDef(new Power
			{
				// TODO [DALA_832t] Violet Prison && Test: Violet Prison_DALA_832t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_833t] Fruit Cart (*) - COST:1 [ATK:0/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_833t", new CardDef(new Power
			{
				// TODO [DALA_833t] Fruit Cart && Test: Fruit Cart_DALA_833t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_833t2] Fish Cart (*) - COST:1 [ATK:0/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_833t2", new CardDef(new Power
			{
				// TODO [DALA_833t2] Fish Cart && Test: Fish Cart_DALA_833t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_833t3] Meat Cart (*) - COST:1 [ATK:0/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_833t3", new CardDef(new Power
			{
				// TODO [DALA_833t3] Meat Cart && Test: Meat Cart_DALA_833t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_833t4] Dessert Cart (*) - COST:1 [ATK:0/HP:1] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_833t4", new CardDef(new Power
			{
				// TODO [DALA_833t4] Dessert Cart && Test: Dessert Cart_DALA_833t4
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_14t] "Kind" Waitress (*) - COST:2 [ATK:2/HP:2] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Enemies attacking this
			//       have a 50% chance to
			//       attack someone else.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 50430
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_14t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_14t] "Kind" Waitress && Test: "Kind" Waitress_DALA_BOSS_14t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_30t] Underbelly Rat (*) - COST:3 [ATK:10/HP:1] 
			// - Race: beast, Set: dalaran, 
			// --------------------------------------------------------
			// Text: When your hero dies, the eldest Underbelly Rat replaces your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_30t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_30t] Underbelly Rat && Test: Underbelly Rat_DALA_BOSS_30t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_36t] Exotic Pet (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_36t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_36t] Exotic Pet && Test: Exotic Pet_DALA_BOSS_36t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_47t] Molten Rock (*) - COST:1 [ATK:0/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all characters.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_47t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_47t] Molten Rock && Test: Molten Rock_DALA_BOSS_47t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_51t] Elementium Squirrel Bomb (*) - COST:2 [ATK:0/HP:4] 
			// - Race: mechanical, Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this and deal 2 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_51t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_51t] Elementium Squirrel Bomb && Test: Elementium Squirrel Bomb_DALA_BOSS_51t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_51t2] Thorium Chicken (*) - COST:3 [ATK:5/HP:1] 
			// - Race: mechanical, Set: dalaran, 
			// --------------------------------------------------------
			// Text: After your opponent plays a card, deal 3 damage to their hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_51t2", new CardDef(new Power
			{
				// TODO [DALA_BOSS_51t2] Thorium Chicken && Test: Thorium Chicken_DALA_BOSS_51t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_56t] Rival Accomplice (*) - COST:3 [ATK:4/HP:4] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_56t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_56t] Rival Accomplice && Test: Rival Accomplice_DALA_BOSS_56t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_58t] The Wire (*) - COST:3 [ATK:3/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: While wires are touching, take 5 damage at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_58t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_58t] The Wire && Test: The Wire_DALA_BOSS_58t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_58t2] The Other Wire (*) - COST:3 [ATK:3/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: While wires are touching, take 5 damage at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_58t2", new CardDef(new Power
			{
				// TODO [DALA_BOSS_58t2] The Other Wire && Test: The Other Wire_DALA_BOSS_58t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_59t] Lotus Bruiser (*) - COST:3 [ATK:2/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Whenever an 'Extortion' is played, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59t] Lotus Bruiser && Test: Lotus Bruiser_DALA_BOSS_59t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_59t2] Fruit Slasher (*) - COST:4 [ATK:4/HP:2] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to an enemy. <b>Combo:</b> And 1 damage to all other enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - COMBO = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59t2", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_59t2] Fruit Slasher && Test: Fruit Slasher_DALA_BOSS_59t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DALA_BOSS_61t] Phase Spider (*) - COST:3 [ATK:3/HP:3] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Immune</b>. <b>Can't Attack</b> while a minion is opposite of this.
			// --------------------------------------------------------
			// GameTag:
			// - 309 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_61t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_61t] Phase Spider && Test: Phase Spider_DALA_BOSS_61t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_700] Continuum Collider (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Take an extra turn. Your opponent takes an extra turn after.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_700", new CardDef(new Power
			{
				// TODO [DALA_700] Continuum Collider && Test: Continuum Collider_DALA_700
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_701] The Box (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a random treasure.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_CANNOT_PLAY_THIS = 0
			// --------------------------------------------------------
			cards.Add("DALA_701", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_CANNOT_PLAY_THIS,0}}, new Power
			{
				// TODO [DALA_701] The Box && Test: The Box_DALA_701
				InfoCardId = "DALA_701e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_702] Gnomish Army Knife (*) - COST:5 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Give a minion <b>Charge</b>,
			//       <b>Windfury</b>, <b>Divine Shield</b>,
			//       <b>Lifesteal</b>, <b>Poisonous</b>,
			//       <b>Taunt</b>, and <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - STEALTH = 1
			// - DIVINE_SHIELD = 1
			// - CHARGE = 1
			// - POISONOUS = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DALA_702", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_702] Gnomish Army Knife && Test: Gnomish Army Knife_DALA_702
				InfoCardId = "DALA_702e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_704] Super Simian Sphere (*) - COST:5 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Summon King Mukla.
			//       Give it <b>Immune</b> and
			//       'Can't be targeted by
			//       spells or Hero Powers.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("DALA_704", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_704] Super Simian Sphere && Test: Super Simian Sphere_DALA_704
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_706] EVIL Propaganda (*) - COST:10 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Take control of all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_706", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				// TODO [DALA_706] EVIL Propaganda && Test: EVIL Propaganda_DALA_706
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_708] Untold Splendor (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Shuffle 5 random treasures into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_708", new CardDef(new Power
			{
				// TODO [DALA_708] Untold Splendor && Test: Untold Splendor_DALA_708
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_711] Dreamgrove Ring (*) - COST:9 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Legendary</b> minion. Summon five copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DALA_711", new CardDef(new Power
			{
				// TODO [DALA_711] Dreamgrove Ring && Test: Dreamgrove Ring_DALA_711
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_712] Orb of the Untold (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Deal $20 damage split between all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_712", new CardDef(new Power
			{
				// TODO [DALA_712] Orb of the Untold && Test: Orb of the Untold_DALA_712
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_714] THE... Candles? (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Twinspell.</b> <b>Twinspell.</b> <b>Twinspell.</b>
			//       Deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - TWINSPELL_COPY = 55859
			// - TWINSPELL = 1
			// --------------------------------------------------------
			cards.Add("DALA_714", new CardDef(new Power
			{
				// TODO [DALA_714] THE... Candles? && Test: THE... Candles?_DALA_714
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_714a] THE... Candles? (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Twinspell.</b> <b>Twinspell.</b>
			//       Deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - TWINSPELL_COPY = 55860
			// - TWINSPELL = 1
			// --------------------------------------------------------
			cards.Add("DALA_714a", new CardDef(new Power
			{
				// TODO [DALA_714a] THE... Candles? && Test: THE... Candles?_DALA_714a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_714b] THE... Candles? (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Twinspell.</b>
			//       Deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - TWINSPELL_COPY = 55861
			// - TWINSPELL = 1
			// --------------------------------------------------------
			cards.Add("DALA_714b", new CardDef(new Power
			{
				// TODO [DALA_714b] THE... Candles? && Test: THE... Candles?_DALA_714b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_714c] THE... Candles? (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_714c", new CardDef(new Power
			{
				// TODO [DALA_714c] THE... Candles? && Test: THE... Candles?_DALA_714c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_715] Overpowered (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After you play a card this turn, replay it
			//       <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_715", new CardDef(new Power
			{
				// TODO [DALA_715] Overpowered && Test: Overpowered_DALA_715
				InfoCardId = "DALA_715e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_716] Fly-By (*) - COST:5 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Shuffle a Kadoom Bot
			//       into your opponent's deck.
			//       When drawn, it explodes
			//       for 50 damage.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_716", new CardDef(new Power
			{
				// TODO [DALA_716] Fly-By && Test: Fly-By_DALA_716
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_716t] Kadoom Bot (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       You take 50 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("DALA_716t", new CardDef(new Power
			{
				// TODO [DALA_716t] Kadoom Bot && Test: Kadoom Bot_DALA_716t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_717] Case Study (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Quest</b> <b>Reward</b>.
			// --------------------------------------------------------
			// Entourage: UNG_940t8, UNG_116t, UNG_067t1, UNG_954t1, UNG_942t, UNG_829t1, UNG_920t1, UNG_934t1, UNG_028t
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// RefTag:
			// - QUEST = 1
			// --------------------------------------------------------
			cards.Add("DALA_717", new CardDef(new[] {"UNG_940t8","UNG_116t","UNG_067t1","UNG_954t1","UNG_942t","UNG_829t1","UNG_920t1","UNG_934t1","UNG_028t"}, new Power
			{
				// TODO [DALA_717] Case Study && Test: Case Study_DALA_717
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_720] Swampqueen's Call (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Transform your minions into random <b>Legendary</b> minions. Repeatable this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - NON_KEYWORD_ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_720", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_720] Swampqueen's Call && Test: Swampqueen's Call_DALA_720
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_721] Duplatransmogrifier (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Replace all minions in your Adventure deck with copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_721", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_721] Duplatransmogrifier && Test: Duplatransmogrifier_DALA_721
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_722] Annoy-o Horn (*) - COST:7 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Fill your board with annoying minions.
			// --------------------------------------------------------
			// Entourage: BOT_911, GVG_085, OG_145
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_722", new CardDef(new[] {"BOT_911","GVG_085","OG_145"}, new Power
			{
				// TODO [DALA_722] Annoy-o Horn && Test: Annoy-o Horn_DALA_722
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_724] Big Boomba (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Destroy ALL minions. Do it again at the start of your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_724", new CardDef(new Power
			{
				// TODO [DALA_724] Big Boomba && Test: Big Boomba_DALA_724
				InfoCardId = "DALA_724e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_724d] Big Boomba Dummy Effects (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Holds an effect for Big Boomba Player Enchantment (DALA_724e)
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_724d", new CardDef(new Power
			{
				// TODO [DALA_724d] Big Boomba Dummy Effects && Test: Big Boomba Dummy Effects_DALA_724d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_725] Banana Split (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Give a friendly minion +2/+2. Summon two copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_725", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_725] Banana Split && Test: Banana Split_DALA_725
				InfoCardId = "DALA_725e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_726] Master Scheme (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Deal $@ damage. Draw
			//       @ |4(card, cards). Gain @ Armor.
			//       Summon @ <b>Boom |4(Bot, Bots)</b>.
			//       <i>(Upgrades each turn!)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_726", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_726] Master Scheme && Test: Master Scheme_DALA_726
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_727] Sow the Seeds (*) - COST:5 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_727", new CardDef(new Power
			{
				// TODO [DALA_727] Sow the Seeds && Test: Sow the Seeds_DALA_727
				InfoCardId = "DALA_727e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_728] Recycling (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       After a friendly minion dies, gain 2 armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_728", new CardDef(new Power
			{
				// TODO [DALA_728] Recycling && Test: Recycling_DALA_728
				InfoCardId = "DALA_728e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_728d] Recycling Dummy Effects (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Holds an effect for Recycling Player Enchantment (DALA_728e)
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_728d", new CardDef(new Power
			{
				// TODO [DALA_728d] Recycling Dummy Effects && Test: Recycling Dummy Effects_DALA_728d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_731] Rocket Backpacks (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions have <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DALA_731", new CardDef(new Power
			{
				// TODO [DALA_731] Rocket Backpacks && Test: Rocket Backpacks_DALA_731
				InfoCardId = "DALA_731e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_733] Emerald Goggles (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       The left-most card in your hand costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_733", new CardDef(new Power
			{
				// TODO [DALA_733] Emerald Goggles && Test: Emerald Goggles_DALA_733
				InfoCardId = "DALA_733e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_735] Robes of Gaudiness (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your cards cost half, but you can only play two cards each turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_735", new CardDef(new Power
			{
				// TODO [DALA_735] Robes of Gaudiness && Test: Robes of Gaudiness_DALA_735
				InfoCardId = "DALA_735e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_736] Stargazing (*) - COST:0 
			// - Set: dalaran, 
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
			cards.Add("DALA_736", new CardDef(new Power
			{
				// TODO [DALA_736] Stargazing && Test: Stargazing_DALA_736
				InfoCardId = "DALA_736e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_737] Resourcefulness (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, equip a random weapon. Give it +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_737", new CardDef(new Power
			{
				// TODO [DALA_737] Resourcefulness && Test: Resourcefulness_DALA_737
				InfoCardId = "DALA_737e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_738] A Prince's Ring (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Replace your starting Hero Power with a random Death Knight one.
			// --------------------------------------------------------
			// Entourage: ICC_831p, ICC_828p, ICC_833h, ICC_832p, ICC_834h, ICC_830p, ICC_481p, ICC_829p, ICC_827p
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_738", new CardDef(new[] {"ICC_831p","ICC_828p","ICC_833h","ICC_832p","ICC_834h","ICC_830p","ICC_481p","ICC_829p","ICC_827p"}, new Power
			{
				// TODO [DALA_738] A Prince's Ring && Test: A Prince's Ring_DALA_738
				InfoCardId = "DALA_738e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_739] Book of Wonders (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, shuffle 10 'Scrolls of Wonder' into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_739", new CardDef(new Power
			{
				// TODO [DALA_739] Book of Wonders && Test: Book of Wonders_DALA_739
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740] Wondrous Wisdomball (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Occasionally gives helpful advice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_740", new CardDef(new Power
			{
				// TODO [DALA_740] Wondrous Wisdomball && Test: Wondrous Wisdomball_DALA_740
				InfoCardId = "DALA_740e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740ts] Wondrous Wisdomball Copy Cards Tokenspell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Chance to give you 2 - 5 extra copies of a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_740ts", new CardDef(new Power
			{
				// TODO [DALA_740ts] Wondrous Wisdomball Copy Cards Tokenspell && Test: Wondrous Wisdomball Copy Cards Tokenspell_DALA_740ts
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740ts2] Wondrous Wisdomball Empty Hand Tokenspell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Chance to give you 5 random cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_740ts2", new CardDef(new Power
			{
				// TODO [DALA_740ts2] Wondrous Wisdomball Empty Hand Tokenspell && Test: Wondrous Wisdomball Empty Hand Tokenspell_DALA_740ts2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740ts3] Wondrous Wisdomball Free Minions Tokenspell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Chance to give you 3 random minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_740ts3", new CardDef(new Power
			{
				// TODO [DALA_740ts3] Wondrous Wisdomball Free Minions Tokenspell && Test: Wondrous Wisdomball Free Minions Tokenspell_DALA_740ts3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740ts4] Wondrous Wisdomball Random Legendary Tokenspell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Transform a minion into a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_740ts4", new CardDef(new Power
			{
				// TODO [DALA_740ts4] Wondrous Wisdomball Random Legendary Tokenspell && Test: Wondrous Wisdomball Random Legendary Tokenspell_DALA_740ts4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_740ts5] Wondrous Wisdomball Summon Taunts Tokenspell (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Summon 3 random <b>Taunt</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_740ts5", new CardDef(new Power
			{
				// TODO [DALA_740ts5] Wondrous Wisdomball Summon Taunts Tokenspell && Test: Wondrous Wisdomball Summon Taunts Tokenspell_DALA_740ts5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_741] Togwaggle's Dice (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the end of your turn, randomize the cost of all cards in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_741", new CardDef(new Power
			{
				// TODO [DALA_741] Togwaggle's Dice && Test: Togwaggle's Dice_DALA_741
				InfoCardId = "DALA_741e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_743] Dr. Boom's Remote (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, summon three 1/1 Boom Bots.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_743", new CardDef(new Power
			{
				// TODO [DALA_743] Dr. Boom's Remote && Test: Dr. Boom's Remote_DALA_743
				InfoCardId = "DALA_743e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_744] Hagatha's Embrace (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of your turn, give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_744", new CardDef(new Power
			{
				// TODO [DALA_744] Hagatha's Embrace && Test: Hagatha's Embrace_DALA_744
				InfoCardId = "DALA_744e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_744d] Hagatha's Embrace Dummy Effects (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Holds an effect for Hagatha's Embrace Player Enchantment (DALA_744e)
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_744d", new CardDef(new Power
			{
				// TODO [DALA_744d] Hagatha's Embrace Dummy Effects && Test: Hagatha's Embrace Dummy Effects_DALA_744d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_745] The Hand of Rafaam (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, give your opponent two 'Cursed!' cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_745", new CardDef(new Power
			{
				// TODO [DALA_745] The Hand of Rafaam && Test: The Hand of Rafaam_DALA_745
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_746] Elixir of Vigor (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       After you play a minion, shuffle two copies of it into your deck. They cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_746", new CardDef(new Power
			{
				// TODO [DALA_746] Elixir of Vigor && Test: Elixir of Vigor_DALA_746
				InfoCardId = "DALA_746e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_746d] Elixir of Vigor Dummy (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Holds and effect for Elixir of Vigor Player Enchantment (DALA_746e)
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DALA_746d", new CardDef(new Power
			{
				// TODO [DALA_746d] Elixir of Vigor Dummy && Test: Elixir of Vigor Dummy_DALA_746d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_747] Elixir of Vim (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       You draw an additional two cards each turn. You are <b>Immune</b> to <b>Fatigue</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// - FATIGUEREFERENCE = 1
			// --------------------------------------------------------
			cards.Add("DALA_747", new CardDef(new Power
			{
				// TODO [DALA_747] Elixir of Vim && Test: Elixir of Vim_DALA_747
				InfoCardId = "DALA_747e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_748] Elixir of Vile (*) - COST:0 
			// - Fac: neutral, Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_748", new CardDef(new Power
			{
				// TODO [DALA_748] Elixir of Vile && Test: Elixir of Vile_DALA_748
				InfoCardId = "DALA_748e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_829] Twist - The Coffers (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Your opponent starts the game with a 'Cache of Cash.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 1
			// --------------------------------------------------------
			cards.Add("DALA_829", new CardDef(new Power
			{
				// TODO [DALA_829] Twist - The Coffers && Test: Twist - The Coffers_DALA_829
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_830] Twist - The Finale (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: This run has four additional powerful bosses.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_830", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_830] Twist - The Finale && Test: Twist - The Finale_DALA_830
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_831] Twist - The Stench (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All minions' Attack and Health are swapped.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_831", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_831] Twist - The Stench && Test: Twist - The Stench_DALA_831
				InfoCardId = "DALA_831e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_832] Twist - The Prisons (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Both players start the game with a 'Violet Prison.'
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_832", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_832] Twist - The Prisons && Test: Twist - The Prisons_DALA_832
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_833] Twist - The Carts (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Both players can only have four minions.
			// --------------------------------------------------------
			// Entourage: DALA_833t2, DALA_833t, DALA_833t3, DALA_833t4
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_833", new CardDef(new[] {"DALA_833t2","DALA_833t","DALA_833t3","DALA_833t4"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_833] Twist - The Carts && Test: Twist - The Carts_DALA_833
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_850] Anomaly - Arcane (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All spells cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_850", new CardDef(new Power
			{
				// TODO [DALA_850] Anomaly - Arcane && Test: Anomaly - Arcane_DALA_850
				InfoCardId = "DALA_850e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_851] Anomaly - Summons (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a spell is played, a minion of the same cost is summoned.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_851", new CardDef(new Power
			{
				// TODO [DALA_851] Anomaly - Summons && Test: Anomaly - Summons_DALA_851
				InfoCardId = "DALA_851e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_852] Anomaly - Crying (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DALA_852", new CardDef(new Power
			{
				// TODO [DALA_852] Anomaly - Crying && Test: Anomaly - Crying_DALA_852
				InfoCardId = "DALA_852e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_853] Anomaly - Rattling (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DALA_853", new CardDef(new Power
			{
				// TODO [DALA_853] Anomaly - Rattling && Test: Anomaly - Rattling_DALA_853
				InfoCardId = "DALA_853e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_854] Anomaly - Nesting (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is played, it gains "<b>Deathrattle:</b> Summon a 1/1 copy of this minion."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DALA_854", new CardDef(new Power
			{
				// TODO [DALA_854] Anomaly - Nesting && Test: Anomaly - Nesting_DALA_854
				InfoCardId = "DALA_854e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_855] Anomaly - Refreshing (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of each player's turn, that player draws until they have 5 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_855", new CardDef(new Power
			{
				// TODO [DALA_855] Anomaly - Refreshing && Test: Anomaly - Refreshing_DALA_855
				InfoCardId = "DALA_855e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_856] Anomaly - Wild Magic (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All spells cast an additional time. <i>(targets chosen randomly)</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_856", new CardDef(new Power
			{
				// TODO [DALA_856] Anomaly - Wild Magic && Test: Anomaly - Wild Magic_DALA_856
				InfoCardId = "DALA_856e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_857] Anomaly - Glittering (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a player plays a card that costs (8) or more, that player adds a Treasure to their hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_857", new CardDef(new Power
			{
				// TODO [DALA_857] Anomaly - Glittering && Test: Anomaly - Glittering_DALA_857
				InfoCardId = "DALA_857e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_858] Anomaly - Fishy (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Murlocs occasionally join the battle.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_858", new CardDef(new Power
			{
				// TODO [DALA_858] Anomaly - Fishy && Test: Anomaly - Fishy_DALA_858
				InfoCardId = "DALA_858e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_859] Anomaly - Gorged (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Both players start the game with two extra cards and Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_859", new CardDef(new Power
			{
				// TODO [DALA_859] Anomaly - Gorged && Test: Anomaly - Gorged_DALA_859
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_860] Anomaly - Dragon Soul (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a player casts 3 spells in a turn, that player summons a 5/5 Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_860", new CardDef(new Power
			{
				// TODO [DALA_860] Anomaly - Dragon Soul && Test: Anomaly - Dragon Soul_DALA_860
				InfoCardId = "DALA_860e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_861] Anomaly - Ogreish (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: All minions have a 50% chance to attack the wrong enemy.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_861", new CardDef(new Power
			{
				// TODO [DALA_861] Anomaly - Ogreish && Test: Anomaly - Ogreish_DALA_861
				InfoCardId = "DALA_861e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_862] Anomaly - Reductive (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: At the end of each player's turn, reduce the cost of cards in their hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_862", new CardDef(new Power
			{
				// TODO [DALA_862] Anomaly - Reductive && Test: Anomaly - Reductive_DALA_862
				InfoCardId = "DALA_862e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_863] Anomaly - Hallucinating (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Both players start the game with 10 'Hallucinations' in their deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_863", new CardDef(new Power
			{
				// TODO [DALA_863] Anomaly - Hallucinating && Test: Anomaly - Hallucinating_DALA_863
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_864] Anomaly - Growing (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Minions gain +1/+1 at the end of their owner's turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_864", new CardDef(new Power
			{
				// TODO [DALA_864] Anomaly - Growing && Test: Anomaly - Growing_DALA_864
				InfoCardId = "DALA_864e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_865] Anomaly - Explosive (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is summoned, it gains "<b>Deathrattle</b>: Deal 1 damage to all minions."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DALA_865", new CardDef(new Power
			{
				// TODO [DALA_865] Anomaly - Explosive && Test: Anomaly - Explosive_DALA_865
				InfoCardId = "DALA_865e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_866] Anomaly - Rejuvenating (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]At the start of each
			//       player's turn, that
			//       player restores 2 Health
			//       to their hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			cards.Add("DALA_866", new CardDef(new Power
			{
				// TODO [DALA_866] Anomaly - Rejuvenating && Test: Anomaly - Rejuvenating_DALA_866
				InfoCardId = "DALA_866e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_867] Anomaly - Infused (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: After a minion is summoned, it gains <b>Taunt</b>, <b>Divine Shield</b>, <b>Rush</b>, or <b>Windfury</b> at random.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 2
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DALA_867", new CardDef(new Power
			{
				// TODO [DALA_867] Anomaly - Infused && Test: Anomaly - Infused_DALA_867
				InfoCardId = "DALA_867e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_901] Recruit (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Choose an enemy minion. Add it to your Adventure Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("DALA_901", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [DALA_901] Recruit && Test: Recruit_DALA_901
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_902] Dismiss (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Remove it from your Adventure Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_902", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_902] Dismiss && Test: Dismiss_DALA_902
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_903] Take a Chance (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Reduce the cost of a random card in your Adventure Deck to (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_903", new CardDef(new Power
			{
				// TODO [DALA_903] Take a Chance && Test: Take a Chance_DALA_903
				InfoCardId = "DALA_903e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_904] Good Food (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Increase your starting Health by 5.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_904", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_904] Good Food && Test: Good Food_DALA_904
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_905] Right Hand Man (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Choose a friendly minion. It always starts in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_905", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_905] Right Hand Man && Test: Right Hand Man_DALA_905
				InfoCardId = "DALA_905e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_906] Round of Drinks (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Add all enemy minions
			//       to your Adventure Deck.
			//       They gain +1/+1
			//       for this run.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_906", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_906] Round of Drinks && Test: Round of Drinks_DALA_906
				InfoCardId = "DALA_906e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_907] Recruit a Veteran (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Legendary</b> minion. Add it to your Adventure Deck.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DALA_907", new CardDef(new Power
			{
				// TODO [DALA_907] Recruit a Veteran && Test: Recruit a Veteran_DALA_907
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_908] Tell a Story (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Give a friendly minion +2/+2 for this run.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_908", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_908] Tell a Story && Test: Tell a Story_DALA_908
				InfoCardId = "DALA_908e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_909] You're All Fired! (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Remove all friendly minions in play from your Adventure Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_909", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_909] You're All Fired! && Test: You're All Fired!_DALA_909
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_910] The Gang's All Here! (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Add three new copies of it to your Adventure Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_910", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [DALA_910] The Gang's All Here! && Test: The Gang's All Here!_DALA_910
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_911] Kindle (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Look at four spells from your Adventure Deck. Choose one to remove.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_911", new CardDef(new Power
			{
				// TODO [DALA_911] Kindle && Test: Kindle_DALA_911
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_912] Brood (*) - COST:0 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Fill the tavern with new minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_912", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_912] Brood && Test: Brood_DALA_912
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_913] Tall Tales (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: [x]Choose a friendly minion.
			//       It gains +4/+4 but costs
			//       (2) more for this run.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_913", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_913] Tall Tales && Test: Tall Tales_DALA_913
				InfoCardId = "DALA_913e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_914] The Upper Hand (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Look at four spells from your deck. Reduce the cost of one by (3) for this run.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_914", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_914] The Upper Hand && Test: The Upper Hand_DALA_914
				InfoCardId = "DALA_914e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_03t] Reductomara (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Reduce the cost of all spells in both player's hand and deck by (1).
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 614
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03t] Reductomara && Test: Reductomara_DALA_BOSS_03t
				InfoCardId = "DALA_BOSS_03t3e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_03t2] Bunnifitronus (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Transform a random minion into a random critter.
			// --------------------------------------------------------
			// Entourage: EX1_tk28, CS2_tk1, hexfrog
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 48336
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03t2", new CardDef(new[] {"EX1_tk28","CS2_tk1","hexfrog"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [DALA_BOSS_03t2] Bunnifitronus && Test: Bunnifitronus_DALA_BOSS_03t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_03t3] Presto Legendaro (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Give each player a random Golden <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 1754
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03t3", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03t3] Presto Legendaro && Test: Presto Legendaro_DALA_BOSS_03t3
				InfoCardId = "DALA_BOSS_03t3e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_03t4] Yoggers Poggers (*) - COST:1 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Shuffle three Scrolls of Wonder into each player's deck.
			// --------------------------------------------------------
			// GameTag:
			// - 858 = 43424
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_03t4", new CardDef(new Power
			{
				// TODO [DALA_BOSS_03t4] Yoggers Poggers && Test: Yoggers Poggers_DALA_BOSS_03t4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_25t] Hoard of Toys (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Summon 1/1 copies of five random minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_25t", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [DALA_BOSS_25t] Hoard of Toys && Test: Hoard of Toys_DALA_BOSS_25t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_38t] PARTY PORTAL! (*) - COST:4 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Summon a random Partygoer.
			// --------------------------------------------------------
			// Entourage: KARA_13_20, GIL_805, KARA_13_22, DAL_721, BRM_019, CFM_659
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_38t", new CardDef(new[] {"KARA_13_20","GIL_805","KARA_13_22","DAL_721","BRM_019","CFM_659"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [DALA_BOSS_38t] PARTY PORTAL! && Test: PARTY PORTAL!_DALA_BOSS_38t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_48t] Void Shift (*) - COST:3 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Summon all minions from the Void.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_48t", new CardDef(new Power
			{
				// TODO [DALA_BOSS_48t] Void Shift && Test: Void Shift_DALA_BOSS_48t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_BOSS_59t3] Extortion (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: Return your '{0}' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_BOSS_59t3", new CardDef(new Power
			{
				// TODO [DALA_BOSS_59t3] Extortion && Test: Extortion_DALA_BOSS_59t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DALA_Warrior_HP2t] Improvised Explosive (*) - COST:2 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Take 3 damage.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_Warrior_HP2t", new CardDef(new Power
			{
				// TODO [DALA_Warrior_HP2t] Improvised Explosive && Test: Improvised Explosive_DALA_Warrior_HP2t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [DALA_719] Soulreaper's Scythe (*) - COST:5 [ATK:6/HP:0] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon all minions killed by this weapon this run.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DALA_719", new CardDef(new Power
			{
				// TODO [DALA_719] Soulreaper's Scythe && Test: Soulreaper's Scythe_DALA_719
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [DALA_723] Hyperblaster (*) - COST:3 [ATK:1/HP:0] 
			// - Set: dalaran, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			//       Your hero is <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 5
			// - POISONOUS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("DALA_723", new CardDef(new Power
			{
				// TODO [DALA_723] Hyperblaster && Test: Hyperblaster_DALA_723
				InfoCardId = "DALA_723e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DruidNonCollect(cards);
			HunterNonCollect(cards);
			MageNonCollect(cards);
			PaladinNonCollect(cards);
			PriestNonCollect(cards);
			RogueNonCollect(cards);
			ShamanNonCollect(cards);
			WarlockNonCollect(cards);
			WarriorNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
