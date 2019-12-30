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
	public class TrollCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - WARRIOR
			// [TRLA_200h] War Master Voone (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>The Warmaster is a triple threat:_He_rocks. He_rolls._He_trolls!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_200h", new CardDef(new Power
			{
				// TODO [TRLA_200h] War Master Voone && Test: War Master Voone_TRLA_200h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TRLA_201h] Zentimo (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>This creepy swamp shaman is packing some_bad_voodoo.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 687
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_201h", new CardDef(new Power
			{
				// TODO [TRLA_201h] Zentimo && Test: Zentimo_TRLA_201h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TRLA_202h] Captain Hooktusk (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Those who say her cheating goes over[d]board_soon_follow_suit.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 730
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_202h", new CardDef(new Power
			{
				// TODO [TRLA_202h] Captain Hooktusk && Test: Captain Hooktusk_TRLA_202h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TRLA_203h] High Priest Thekal (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Floats like a feather. Stings like a troll punching_your_face.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 472
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_203h", new CardDef(new Power
			{
				// TODO [TRLA_203h] High Priest Thekal && Test: High Priest Thekal_TRLA_203h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TRLA_204h] Zul'jin (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Zul'jin's not ready to bury the hatchet. Unless it's in your shrine.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 53943
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_204h", new CardDef(new Power
			{
				// TODO [TRLA_204h] Zul'jin && Test: Zul'jin_TRLA_204h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TRLA_205h] Wardruid Loti (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>She and her raptors aim to prove the wild side is_the_winning_side.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1123
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_205h", new CardDef(new Power
			{
				// TODO [TRLA_205h] Wardruid Loti && Test: Wardruid Loti_TRLA_205h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TRLA_206h] High Priestess Jeklik (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Her blood magic brings on spells,_demons, and_hurt_feelings.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 300
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_206h", new CardDef(new Power
			{
				// TODO [TRLA_206h] High Priestess Jeklik && Test: High Priestess Jeklik_TRLA_206h
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TRLA_207h] Hex Lord Malacrass (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Malacrass is on fire this year! And sometimes frost.</I>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_207h", new CardDef(new Power
			{
				// TODO [TRLA_207h] Hex Lord Malacrass && Test: Hex Lord Malacrass_TRLA_207h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TRLA_208h] Princess Talanji (*) - COST:0 [ATK:0/HP:10] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <i>Her family bargained with the loa of death. That's_bad._For_you.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_208h", new CardDef(new Power
			{
				// TODO [TRLA_208h] Princess Talanji && Test: Princess Talanji_TRLA_208h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [TRLA_209h] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h", new CardDef(new Power
			{
				// TODO [TRLA_209h] Rikkar && Test: Rikkar_TRLA_209h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - DRUID
			// [TRLA_209h_Druid] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 1123
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Druid", new CardDef(new Power
			{
				// TODO [TRLA_209h_Druid] Rikkar && Test: Rikkar_TRLA_209h_Druid
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - HUNTER
			// [TRLA_209h_Hunter] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Hunter", new CardDef(new Power
			{
				// TODO [TRLA_209h_Hunter] Rikkar && Test: Rikkar_TRLA_209h_Hunter
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [TRLA_209h_Mage] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 807
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Mage", new CardDef(new Power
			{
				// TODO [TRLA_209h_Mage] Rikkar && Test: Rikkar_TRLA_209h_Mage
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - PALADIN
			// [TRLA_209h_Paladin] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 472
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Paladin", new CardDef(new Power
			{
				// TODO [TRLA_209h_Paladin] Rikkar && Test: Rikkar_TRLA_209h_Paladin
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [TRLA_209h_Priest] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 479
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Priest", new CardDef(new Power
			{
				// TODO [TRLA_209h_Priest] Rikkar && Test: Rikkar_TRLA_209h_Priest
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [TRLA_209h_Rogue] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 730
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Rogue", new CardDef(new Power
			{
				// TODO [TRLA_209h_Rogue] Rikkar && Test: Rikkar_TRLA_209h_Rogue
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [TRLA_209h_Shaman] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 687
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Shaman", new CardDef(new Power
			{
				// TODO [TRLA_209h_Shaman] Rikkar && Test: Rikkar_TRLA_209h_Shaman
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [TRLA_209h_Warlock] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 300
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Warlock", new CardDef(new Power
			{
				// TODO [TRLA_209h_Warlock] Rikkar && Test: Rikkar_TRLA_209h_Warlock
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [TRLA_209h_Warrior] Rikkar (*) - COST:0 [ATK:0/HP:20] 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_209h_Warrior", new CardDef(new Power
			{
				// TODO [TRLA_209h_Warrior] Rikkar && Test: Rikkar_TRLA_209h_Warrior
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ HERO_POWER - HUNTER
			// [TRLA_065p] Steady Throw (*) - COST:2 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage to the enemy hero.@<b>Hero Power</b>
			//       Deal $2 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 1086 = 2738
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_STEADY_SHOT = 0
			// - REQ_MINION_OR_ENEMY_HERO = 0
			// --------------------------------------------------------
			cards.Add("TRLA_065p", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_STEADY_SHOT,0},{PlayReq.REQ_MINION_OR_ENEMY_HERO,0}}, new Power
			{
				// TODO [TRLA_065p] Steady Throw && Test: Steady Throw_TRLA_065p
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRLA_115e] Gonk's Mark (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_115e", new CardDef(new Power
			{
				// TODO [TRLA_115e] Gonk's Mark && Test: Gonk's Mark_TRLA_115e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_115e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRLA_124e] Empowered (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_124e", new CardDef(new Power
			{
				// TODO [TRLA_124e] Empowered && Test: Empowered_TRLA_124e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_124e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [TRLA_125e] The Fan Favorite (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +10 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_125e", new CardDef(new Power
			{
				// TODO [TRLA_125e] The Fan Favorite && Test: The Fan Favorite_TRLA_125e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_125e")
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_112] Gonk's Armament (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Whenever you gain Armor,
			//       refresh your Mana
			//       Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1876
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2046
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_112", new CardDef(new Power
			{
				// TODO [TRLA_112] Gonk's Armament && Test: Gonk's Armament_TRLA_112
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_112t] Gonk's Armament (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50902
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_112t", new CardDef(new Power
			{
				// TODO [TRLA_112t] Gonk's Armament && Test: Gonk's Armament_TRLA_112t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_115] Gonk's Mark (*) - COST:0 [ATK:0/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you summon a
			//       minion, give it +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1877
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2045
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_115", new CardDef(new Power
			{
				// TODO [TRLA_115] Gonk's Mark && Test: Gonk's Mark_TRLA_115
				InfoCardId = "TRLA_115e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_115t] Gonk's Mark (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50952
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_115t", new CardDef(new Power
			{
				// TODO [TRLA_115t] Gonk's Mark && Test: Gonk's Mark_TRLA_115t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_116] Bonds of Balance (*) - COST:0 [ATK:0/HP:7] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       At the end of your turn,
			//       gain Attack equal to your
			//       hero's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1882
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2044
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2212
			// --------------------------------------------------------
			cards.Add("TRLA_116", new CardDef(new Power
			{
				// TODO [TRLA_116] Bonds of Balance && Test: Bonds of Balance_TRLA_116
				InfoCardId = "TRLA_116e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_116t] Bonds of Balance (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50953
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_116t", new CardDef(new Power
			{
				// TODO [TRLA_116t] Bonds of Balance && Test: Bonds of Balance_TRLA_116t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_121] Water Spirit (*) - COST:0 [ATK:2/HP:1] 
			// - Race: elemental, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Start of Game:</b> Draw this.
			//       <b>Deathrattle:</b> Gain 2 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_121", new CardDef(new Power
			{
				// TODO [TRLA_121] Water Spirit && Test: Water Spirit_TRLA_121
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_122] Direhorn Stomper (*) - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Summon a minion from your deck with the highest Attack.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_122", new CardDef(new Power
			{
				// TODO [TRLA_122] Direhorn Stomper && Test: Direhorn Stomper_TRLA_122
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_123] Succoring Skyscreamer (*) - COST:3 [ATK:3/HP:4] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]Whenever you gain
			//       Armor, draw a card.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_123", new CardDef(new Power
			{
				// TODO [TRLA_123] Succoring Skyscreamer && Test: Succoring Skyscreamer_TRLA_123
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_124] Zandalari Striker (*) - COST:5 [ATK:2/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: After your hero attacks, give your minions
			//       +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_124", new CardDef(new Power
			{
				// TODO [TRLA_124] Zandalari Striker && Test: Zandalari Striker_TRLA_124
				InfoCardId = "TRLA_124e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_125] The Fan Favorite (*) - COST:6 [ATK:10/HP:10] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Give your hero +10 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_125", new CardDef(new Power
			{
				// TODO [TRLA_125] The Fan Favorite && Test: The Fan Favorite_TRLA_125
				InfoCardId = "TRLA_125e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [TRLA_127] Astral Raptor (*) - COST:3 [ATK:3/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill:</b> Summon another Astral Raptor.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_127", new CardDef(new Power
			{
				// TODO [TRLA_127] Astral Raptor && Test: Astral Raptor_TRLA_127
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_01] Natural Defense (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_447, UNG_108, LOOT_051, CS2_005, OG_047, ICC_079, GIL_637, LOOT_054, LOOT_309, TRL_010
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_01", new CardDef(new[] {"BOT_447","UNG_108","LOOT_051","CS2_005","OG_047","ICC_079","GIL_637","LOOT_054","LOOT_309","TRL_010"}, new Power
			{
				// TODO [TRLA_Druid_01] Natural Defense && Test: Natural Defense_TRLA_Druid_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_02] Feral (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_243, CS2_005, TRL_223, TRL_240, TRL_507, OG_047, CS2_011, ICC_079, TRL_241, AT_039, EX1_570
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_02", new CardDef(new[] {"TRL_243","CS2_005","TRL_223","TRL_240","TRL_507","OG_047","CS2_011","ICC_079","TRL_241","AT_039","EX1_570"}, new Power
			{
				// TODO [TRLA_Druid_02] Feral && Test: Feral_TRLA_Druid_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_03] Nature's Blessing (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_614, CS2_009, EX1_160, OG_048, EX1_155, TRL_254, GVG_041, OG_195
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_03", new CardDef(new[] {"CFM_614","CS2_009","EX1_160","OG_048","EX1_155","TRL_254","GVG_041","OG_195"}, new Power
			{
				// TODO [TRLA_Druid_03] Nature's Blessing && Test: Nature's Blessing_TRLA_Druid_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_04] Saplings (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_419, GIL_663, BOT_420, FP1_019, EX1_158, EX1_571, UNG_111, TRL_341, BOT_422, EX1_573, BOT_523
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_04", new CardDef(new[] {"BOT_419","GIL_663","BOT_420","FP1_019","EX1_158","EX1_571","UNG_111","TRL_341","BOT_422","EX1_573","BOT_523"}, new Power
			{
				// TODO [TRLA_Druid_04] Saplings && Test: Saplings_TRLA_Druid_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_05] Big Draws (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_223, GIL_637, GVG_032, GIL_833, TRL_015, LOOT_054, GIL_584, EX1_164, CFM_328, BRM_031, ICC_085
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_05", new CardDef(new[] {"TRL_223","GIL_637","GVG_032","GIL_833","TRL_015","LOOT_054","GIL_584","EX1_164","CFM_328","BRM_031","ICC_085"}, new Power
			{
				// TODO [TRLA_Druid_05] Big Draws && Test: Big Draws_TRLA_Druid_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_06] Wise Decisions (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_037, LOE_115, EX1_154, EX1_166, OG_044, ICC_047, EX1_164, BOT_422, NEW1_008, EX1_573, TRL_343
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_06", new CardDef(new[] {"AT_037","LOE_115","EX1_154","EX1_166","OG_044","ICC_047","EX1_164","BOT_422","NEW1_008","EX1_573","TRL_343"}, new Power
			{
				// TODO [TRLA_Druid_06] Wise Decisions && Test: Wise Decisions_TRLA_Druid_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_07] Beasts (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: KAR_300, LOOT_413, LOE_050, UNG_075, LOE_047, TRL_241, AT_039, NEW1_041, AT_090, TRL_232, LOOT_314, TRL_542, TRL_343
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_07", new CardDef(new[] {"KAR_300","LOOT_413","LOE_050","UNG_075","LOE_047","TRL_241","AT_039","NEW1_041","AT_090","TRL_232","LOOT_314","TRL_542","TRL_343"}, new Power
			{
				// TODO [TRLA_Druid_07] Beasts && Test: Beasts_TRLA_Druid_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_10] Nature's Wrath (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_161, AT_037, EX1_154, EX1_012, FP1_019, CS2_012, EX1_284, ICC_054, EX1_095, EX1_563, ICC_085
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_10", new CardDef(new[] {"EX1_161","AT_037","EX1_154","EX1_012","FP1_019","CS2_012","EX1_284","ICC_054","EX1_095","EX1_563","ICC_085"}, new Power
			{
				// TODO [TRLA_Druid_10] Nature's Wrath && Test: Nature's Wrath_TRLA_Druid_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_13] Rumble Kings (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_552, EX1_298, ICC_314, GVG_114, UNG_099, AT_045, TRL_542, UNG_852, OG_042, CFM_308
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_13", new CardDef(new[] {"BOT_552","EX1_298","ICC_314","GVG_114","UNG_099","AT_045","TRL_542","UNG_852","OG_042","CFM_308"}, new Power
			{
				// TODO [TRLA_Druid_13] Rumble Kings && Test: Rumble Kings_TRLA_Druid_13
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [TRLA_Druid_14] Going Wild (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_223, TRL_407, TRL_507, AT_080, GIL_561, GIL_534, AT_085, AT_039, TRL_241, AT_099, AT_127, AT_132
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Druid_14", new CardDef(new[] {"TRL_223","TRL_407","TRL_507","AT_080","GIL_561","GIL_534","AT_085","AT_039","TRL_241","AT_099","AT_127","AT_132"}, new Power
			{
				// TODO [TRLA_Druid_14] Going Wild && Test: Going Wild_TRLA_Druid_14
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_162e] Halazzi's Hunt (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> Reduce the cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1907
			// - 858 = 48510
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_162e", new CardDef(new Power
			{
				// TODO [TRLA_162e] Halazzi's Hunt && Test: Halazzi's Hunt_TRLA_162e
				InfoCardId = "TRLA_162e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_162e")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_162e2] Halazzi's Hunt Enchantment (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_162e2", new CardDef(new Power
			{
				// TODO [TRLA_162e2] Halazzi's Hunt Enchantment && Test: Halazzi's Hunt Enchantment_TRLA_162e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_162e2")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_163e] Halazzi's Haste (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_163e", new CardDef(new Power
			{
				// TODO [TRLA_163e] Halazzi's Haste && Test: Halazzi's Haste_TRLA_163e
				InfoCardId = "TRLA_163e3",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_163e")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_163e3] Halazzi's Protector (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_163e3", new CardDef(new Power
			{
				// TODO [TRLA_163e3] Halazzi's Protector && Test: Halazzi's Protector_TRLA_163e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_163e3")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_163e4] Halazzi's Wrath (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_163e4", new CardDef(new Power
			{
				// TODO [TRLA_163e4] Halazzi's Wrath && Test: Halazzi's Wrath_TRLA_163e4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_163e4")
			}));

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [TRLA_169e] Slamm'd N Jamm'd (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: This minion's Attack has been doubled.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_169e", new CardDef(new Power
			{
				// TODO [TRLA_169e] Slamm'd N Jamm'd && Test: Slamm'd N Jamm'd_TRLA_169e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_169e")
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_110] Halazzi's Trap (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you cast a spell, put
			//       a random Hunter Secret
			//       into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1907
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2049
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_110", new CardDef(new Power
			{
				// TODO [TRLA_110] Halazzi's Trap && Test: Halazzi's Trap_TRLA_110
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_110t] Halazzi's Trap (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50901
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_110t", new CardDef(new Power
			{
				// TODO [TRLA_110t] Halazzi's Trap && Test: Halazzi's Trap_TRLA_110t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_162] Halazzi's Hunt (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your minions have
			//       "<b>Overkill</b>: Cards in your
			//       hand cost (1) less."
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1906
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2047
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2199
			// --------------------------------------------------------
			// RefTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRLA_162", new CardDef(new Power
			{
				// TODO [TRLA_162] Halazzi's Hunt && Test: Halazzi's Hunt_TRLA_162
				InfoCardId = "TRLA_162e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_162t] Halazzi's Hunt (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52993
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_162t", new CardDef(new Power
			{
				// TODO [TRLA_162t] Halazzi's Hunt && Test: Halazzi's Hunt_TRLA_162t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_163] Halazzi's Guise (*) - COST:0 [ATK:0/HP:6] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Whenever you summon a
			//       Beast, it gains <b>Rush</b>,
			//       <b>Taunt</b>, or <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1909
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2048
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2209
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRLA_163", new CardDef(new Power
			{
				// TODO [TRLA_163] Halazzi's Guise && Test: Halazzi's Guise_TRLA_163
				InfoCardId = "TRLA_163e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_163t] Halazzi's Guise (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52995
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_163t", new CardDef(new Power
			{
				// TODO [TRLA_163t] Halazzi's Guise && Test: Halazzi's Guise_TRLA_163t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_164] Shadowmaw Panther (*) - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: Your Beasts have <b>Rush</b>.
			//       <b>Start of Game:</b> Draw this.
			// --------------------------------------------------------
			// GameTag:
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRLA_164", new CardDef(new Power
			{
				// TODO [TRLA_164] Shadowmaw Panther && Test: Shadowmaw Panther_TRLA_164
				InfoCardId = "TRLA_164e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_165] Battlestarved Lynx (*) - COST:4 [ATK:3/HP:4] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw Beasts until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_165", new CardDef(new Power
			{
				// TODO [TRLA_165] Battlestarved Lynx && Test: Battlestarved Lynx_TRLA_165
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_166] Troll Harbinger (*) - COST:5 [ATK:8/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       After a minion dies, add a random Hunter spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_166", new CardDef(new Power
			{
				// TODO [TRLA_166] Troll Harbinger && Test: Troll Harbinger_TRLA_166
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_167] Rabid Saurolisk (*) - COST:3 [ATK:4/HP:1] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Deathrattle:</b> Deal 1 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - POISONOUS = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_167", new CardDef(new Power
			{
				// TODO [TRLA_167] Rabid Saurolisk && Test: Rabid Saurolisk_TRLA_167
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_168] Streetsmuggler (*) - COST:4 [ATK:3/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: After a friendly Secret is revealed, put a random Hunter Secret into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_168", new CardDef(new Power
			{
				// TODO [TRLA_168] Streetsmuggler && Test: Streetsmuggler_TRLA_168
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [TRLA_169] Slamma Jamma (*) - COST:5 [ATK:5/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Double the Attack of all your other_minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_169", new CardDef(new Power
			{
				// TODO [TRLA_169] Slamma Jamma && Test: Slamma Jamma_TRLA_169
				InfoCardId = "TRLA_169e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_01] Fresh Meat (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: DS1_175, EX1_162, FP1_002, OG_179, LOE_046, UNG_075, UNG_915, ICC_419, LOOT_078, CFM_316, GIL_607t, TRL_348, TRL_901, FP1_011, TRL_505, CFM_315
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_01", new CardDef(new[] {"DS1_175","EX1_162","FP1_002","OG_179","LOE_046","UNG_075","UNG_915","ICC_419","LOOT_078","CFM_316","GIL_607t","TRL_348","TRL_901","FP1_011","TRL_505","CFM_315"}, new Power
			{
				// TODO [TRLA_Hunter_01] Fresh Meat && Test: Fresh Meat_TRLA_Hunter_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_02] Big Beasts (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_028, DS1_178, EX1_534, NEW1_041, OG_308, UNG_087, UNG_099, UNG_801, ICC_905, LOOT_511, TRL_900, TRL_542, TRL_550
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_02", new CardDef(new[] {"EX1_028","DS1_178","EX1_534","NEW1_041","OG_308","UNG_087","UNG_099","UNG_801","ICC_905","LOOT_511","TRL_900","TRL_542","TRL_550"}, new Power
			{
				// TODO [TRLA_Hunter_02] Big Beasts && Test: Big Beasts_TRLA_Hunter_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_03] Trick Shots (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_084, DS1_183, EX1_537, EX1_609, DS1_185, EX1_617, GVG_073, AT_056, ICC_049, LOOT_077, TRL_347, GIL_518, BRM_013
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_03", new CardDef(new[] {"CS2_084","DS1_183","EX1_537","EX1_609","DS1_185","EX1_617","GVG_073","AT_056","ICC_049","LOOT_077","TRL_347","GIL_518","BRM_013"}, new Power
			{
				// TODO [TRLA_Hunter_03] Trick Shots && Test: Trick Shots_TRLA_Hunter_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_04] Beast Caller (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: NEW1_031, EX1_595, EX1_538, EX1_531, FP1_002, OG_211, LOOT_511, TRL_348, TRL_347, TRL_566, TRL_405, TRL_542, TRL_901, TRL_900, KAR_004, AT_060, EX1_554, OG_216, NEW1_019
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_04", new CardDef(new[] {"NEW1_031","EX1_595","EX1_538","EX1_531","FP1_002","OG_211","LOOT_511","TRL_348","TRL_347","TRL_566","TRL_405","TRL_542","TRL_901","TRL_900","KAR_004","AT_060","EX1_554","OG_216","NEW1_019"}, new Power
			{
				// TODO [TRLA_Hunter_04] Beast Caller && Test: Beast Caller_TRLA_Hunter_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_05] Secrets (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_554, EX1_611, EX1_610, AT_060, EX1_609, EX1_533, EX1_536, ICC_200, ICC_204, LOOT_079, LOOT_080, FP1_004, KAR_006, BOT_402, CFM_026, TRL_530, BOT_573, DS1_184
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_05", new CardDef(new[] {"EX1_554","EX1_611","EX1_610","AT_060","EX1_609","EX1_533","EX1_536","ICC_200","ICC_204","LOOT_079","LOOT_080","FP1_004","KAR_006","BOT_402","CFM_026","TRL_530","BOT_573","DS1_184"}, new Power
			{
				// TODO [TRLA_Hunter_05] Secrets && Test: Secrets_TRLA_Hunter_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_06] Beast Training (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_539, DS1_178, DS1_070, AT_010, CFM_316, UNG_915, UNG_916, UNG_917, GIL_650, TRL_119, TRL_405, TRL_339, GVG_017, EX1_549, DS1_184
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_06", new CardDef(new[] {"EX1_539","DS1_178","DS1_070","AT_010","CFM_316","UNG_915","UNG_916","UNG_917","GIL_650","TRL_119","TRL_405","TRL_339","GVG_017","EX1_549","DS1_184"}, new Power
			{
				// TODO [TRLA_Hunter_06] Beast Training && Test: Beast Training_TRLA_Hunter_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_09] Deathrattle (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_534, GVG_026, OG_133, OG_292, OG_309, KAR_005, UNG_800, ICC_021, ICC_052, ICC_243, ICC_825, LOOT_520, LOOT_161, LOOT_511, BOT_039, FP1_011, KAR_005, CFM_316, OG_216
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_09", new CardDef(new[] {"EX1_534","GVG_026","OG_133","OG_292","OG_309","KAR_005","UNG_800","ICC_021","ICC_052","ICC_243","ICC_825","LOOT_520","LOOT_161","LOOT_511","BOT_039","FP1_011","KAR_005","CFM_316","OG_216"}, new Power
			{
				// TODO [TRLA_Hunter_09] Deathrattle && Test: Deathrattle_TRLA_Hunter_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_10] Legendary (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: GIL_650, ICC_204, TRL_900, CFM_333, OG_309, GVG_049, UNG_919, LOOT_511, EX1_543, EX1_116, BOT_548, BOT_573, GVG_110, GVG_114, ICC_314, TRL_542
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_10", new CardDef(new[] {"GIL_650","ICC_204","TRL_900","CFM_333","OG_309","GVG_049","UNG_919","LOOT_511","EX1_543","EX1_116","BOT_548","BOT_573","GVG_110","GVG_114","ICC_314","TRL_542"}, new Power
			{
				// TODO [TRLA_Hunter_10] Legendary && Test: Legendary_TRLA_Hunter_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_11] Survival Tactics (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_611, EX1_610, EX1_093, EX1_538, FP1_012, GVG_069, AT_060, LOOT_522, GIL_905, BOT_548, GIL_623, TRL_550, DS1_184
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_11", new CardDef(new[] {"EX1_611","EX1_610","EX1_093","EX1_538","FP1_012","GVG_069","AT_060","LOOT_522","GIL_905","BOT_548","GIL_623","TRL_550","DS1_184"}, new Power
			{
				// TODO [TRLA_Hunter_11] Survival Tactics && Test: Survival Tactics_TRLA_Hunter_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [TRLA_Hunter_12] Scrapyard (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_035, GVG_048, BOT_251, GVG_082, GVG_006, GVG_085, LOOT_111, GIL_681, GVG_078, GVG_096, BOT_548, BOT_066, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Hunter_12", new CardDef(new[] {"BOT_035","GVG_048","BOT_251","GVG_082","GVG_006","GVG_085","LOOT_111","GIL_681","GVG_078","GVG_096","BOT_548","BOT_066","GVG_114"}, new Power
			{
				// TODO [TRLA_Hunter_12] Scrapyard && Test: Scrapyard_TRLA_Hunter_12
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [TRLA_108] Jan'alai's Mantle (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Has <b>Spell Damage +1</b> for
			//       each spell in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1887
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2052
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2207
			// --------------------------------------------------------
			cards.Add("TRLA_108", new CardDef(new Power
			{
				// TODO [TRLA_108] Jan'alai's Mantle && Test: Jan'alai's Mantle_TRLA_108
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_108t] Jan'alai's Mantle (*) - COST:0 [ATK:0/HP:10] 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50844
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_108t", new CardDef(new Power
			{
				// TODO [TRLA_108t] Jan'alai's Mantle && Test: Jan'alai's Mantle_TRLA_108t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_128] Jan'alai's Flame (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your Hero Power costs (0).
			//       Whenever it kills
			//       a minion, refresh it.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - AURA = 1
			// - HERO_DECK_ID = 1888
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2051
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_128", new CardDef(new Power
			{
				// TODO [TRLA_128] Jan'alai's Flame && Test: Jan'alai's Flame_TRLA_128
				InfoCardId = "TRLA_128e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_128t] Jan'alai's Flame (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 51804
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_128t", new CardDef(new Power
			{
				// TODO [TRLA_128t] Jan'alai's Flame && Test: Jan'alai's Flame_TRLA_128t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_129] Jan'alai's Progeny (*) - COST:0 [ATK:0/HP:7] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Whenever you <b>Freeze</b> a
			//       character, put a Frostfire
			//       into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1889
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2050
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2200
			// --------------------------------------------------------
			cards.Add("TRLA_129", new CardDef(new Power
			{
				// TODO [TRLA_129] Jan'alai's Progeny && Test: Jan'alai's Progeny_TRLA_129
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_129t] Jan'alai's Progeny (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 51808
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_129t", new CardDef(new Power
			{
				// TODO [TRLA_129t] Jan'alai's Progeny && Test: Jan'alai's Progeny_TRLA_129t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_130] Razzle Dazzler (*) - COST:4 [ATK:2/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry</b>: Fill your hand with Arcane Missiles.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_130", new CardDef(new Power
			{
				// TODO [TRLA_130] Razzle Dazzler && Test: Razzle Dazzler_TRLA_130
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_131] Glyph Guardian (*) - COST:4 [ATK:4/HP:6] 
			// - Race: dragon, Set: troll, 
			// --------------------------------------------------------
			// Text: Whenever a character is <b>Frozen</b>, gain <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_131", new CardDef(new Power
			{
				// TODO [TRLA_131] Glyph Guardian && Test: Glyph Guardian_TRLA_131
				InfoCardId = "TRLA_131e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_132] Frostweaver (*) - COST:2 [ATK:2/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your Hero Power also <b><b>Freeze</b>s</b> the target.
			//       If the target is a <b>Frozen</b> minion, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_132", new CardDef(new Power
			{
				// TODO [TRLA_132] Frostweaver && Test: Frostweaver_TRLA_132
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_133] Fireslinger (*) - COST:5 [ATK:3/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: After you cast a spell,
			//       cast a Fireball at a random_enemy.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_133", new CardDef(new Power
			{
				// TODO [TRLA_133] Fireslinger && Test: Fireslinger_TRLA_133
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_134] Showstopping Conjurer (*) - COST:3 [ATK:3/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Draw a spell from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_134", new CardDef(new Power
			{
				// TODO [TRLA_134] Showstopping Conjurer && Test: Showstopping Conjurer_TRLA_134
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [TRLA_135] Fan of Flames (*) - COST:1 [ATK:2/HP:2] 
			// - Race: elemental, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Start of Game</b>: Draw this.
			//       <b>Battlecry:</b> Upgrade your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_135", new CardDef(new Power
			{
				// TODO [TRLA_135] Fan of Flames && Test: Fan of Flames_TRLA_135
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_129s] Frostfire (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TRLA_129s", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [TRLA_129s] Frostfire && Test: Frostfire_TRLA_129s
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_01] Heroic Power (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_390, AT_003, ICC_068, TRL_319, TRL_315, TRL_316, GIL_646, AT_099, AT_090, AT_006, AT_127, AT_132
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_01", new CardDef(new[] {"TRL_390","AT_003","ICC_068","TRL_319","TRL_315","TRL_316","GIL_646","AT_099","AT_090","AT_006","AT_127","AT_132"}, new Power
			{
				// TODO [TRLA_Mage_01] Heroic Power && Test: Heroic Power_TRLA_Mage_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_02] Elementals (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_018, TRL_313, LOOT_103, UNG_021, GIL_645, CS2_033, TRL_311, UNG_205, UNG_816, UNG_847, UNG_846, LOOT_231, UNG_027, EX1_298
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_02", new CardDef(new[] {"UNG_018","TRL_313","LOOT_103","UNG_021","GIL_645","CS2_033","TRL_311","UNG_205","UNG_816","UNG_847","UNG_846","LOOT_231","UNG_027","EX1_298"}, new Power
			{
				// TODO [TRLA_Mage_02] Elementals && Test: Elementals_TRLA_Mage_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_03] Big Spells (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_317, CS2_032, KAR_076, CFM_623, UNG_955, LOOT_535, CS2_028, OG_090, LOOT_130
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_03", new CardDef(new[] {"TRL_317","CS2_032","KAR_076","CFM_623","UNG_955","LOOT_535","CS2_028","OG_090","LOOT_130"}, new Power
			{
				// TODO [TRLA_Mage_03] Big Spells && Test: Big Spells_TRLA_Mage_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_04] Fire (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_315, TRL_316, TRL_390, UNG_018, GIL_147, BRM_002, LOE_002, CFM_065, CS2_029, TRL_317, EX1_298, GIL_645, UNG_809, UNG_027
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_04", new CardDef(new[] {"TRL_315","TRL_316","TRL_390","UNG_018","GIL_147","BRM_002","LOE_002","CFM_065","CS2_029","TRL_317","EX1_298","GIL_645","UNG_809","UNG_027"}, new Power
			{
				// TODO [TRLA_Mage_04] Fire && Test: Fire_TRLA_Mage_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_05] Frost (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: ICC_068, CS2_024, GVG_002, CS2_026, EX1_275, CS2_033, CS2_028, UNG_205, GIL_801, ICC_252
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_05", new CardDef(new[] {"ICC_068","CS2_024","GVG_002","CS2_026","EX1_275","CS2_033","CS2_028","UNG_205","GIL_801","ICC_252"}, new Power
			{
				// TODO [TRLA_Mage_05] Frost && Test: Frost_TRLA_Mage_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_06] Magical Friends (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_807, BRM_002, EX1_559, EX1_608, NEW1_012, GIL_664, LOOT_231, EX1_095, EX1_055, LOOT_231
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_06", new CardDef(new[] {"CFM_807","BRM_002","EX1_559","EX1_608","NEW1_012","GIL_664","LOOT_231","EX1_095","EX1_055","LOOT_231"}, new Power
			{
				// TODO [TRLA_Mage_06] Magical Friends && Test: Magical Friends_TRLA_Mage_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_07] Spell Power (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_004, BOT_531, BOT_604, AT_006, BOT_254, EX1_012, EX1_284, EX1_563, TRL_312
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_07", new CardDef(new[] {"AT_004","BOT_531","BOT_604","AT_006","BOT_254","EX1_012","EX1_284","EX1_563","TRL_312"}, new Power
			{
				// TODO [TRLA_Mage_07] Spell Power && Test: Spell Power_TRLA_Mage_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_08] Hand Power (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_315, OG_090, GIL_645, GIL_691, BOT_101, BOT_103, TRL_317, BOT_601, TRL_318, BOT_256, AT_009, TRL_509
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_08", new CardDef(new[] {"TRL_315","OG_090","GIL_645","GIL_691","BOT_101","BOT_103","TRL_317","BOT_601","TRL_318","BOT_256","AT_009","TRL_509"}, new Power
			{
				// TODO [TRLA_Mage_08] Hand Power && Test: Hand Power_TRLA_Mage_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_09] Gurubashi Legends (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_316, OG_122, ICC_314, EX1_572, BOT_257, EX1_559, AT_132, KAR_097, EX1_563, AT_009, OG_134, AT_127
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_09", new CardDef(new[] {"TRL_316","OG_122","ICC_314","EX1_572","BOT_257","EX1_559","AT_132","KAR_097","EX1_563","AT_009","OG_134","AT_127"}, new Power
			{
				// TODO [TRLA_Mage_09] Gurubashi Legends && Test: Gurubashi Legends_TRLA_Mage_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [TRLA_Mage_10] Chaos (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: LOOT_104, KAR_009, BOT_101, UNG_846, GVG_003, UNG_941, AT_007, OG_090, LOOT_106, TRL_317
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Mage_10", new CardDef(new[] {"LOOT_104","KAR_009","BOT_101","UNG_846","GVG_003","UNG_941","AT_007","OG_090","LOOT_106","TRL_317"}, new Power
			{
				// TODO [TRLA_Mage_10] Chaos && Test: Chaos_TRLA_Mage_10
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [TRLA_105] Shirvallah's Protection (*) - COST:0 [ATK:0/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After a friendly minion
			//       survives damage, give it
			//       <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1890
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2054
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2206
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_105", new CardDef(new Power
			{
				// TODO [TRLA_105] Shirvallah's Protection && Test: Shirvallah's Protection_TRLA_105
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_105t] Shirvallah's Protection (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50840
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_105t", new CardDef(new Power
			{
				// TODO [TRLA_105t] Shirvallah's Protection && Test: Shirvallah's Protection_TRLA_105t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_137] Shirvallah's Vengeance (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After your hero takes
			//       damage, deal 5 damage
			//       to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1891
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2055
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1176 = 1
			// - 1179 = 1
			// - 1249 = 2211
			// --------------------------------------------------------
			cards.Add("TRLA_137", new CardDef(new Power
			{
				// TODO [TRLA_137] Shirvallah's Vengeance && Test: Shirvallah's Vengeance_TRLA_137
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_137t] Shirvallah's Vengeance (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 51920
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_137t", new CardDef(new Power
			{
				// TODO [TRLA_137t] Shirvallah's Vengeance && Test: Shirvallah's Vengeance_TRLA_137t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_138] Shirvallah's Grace (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you cast a spell
			//       on a friendly minion, cast a
			//         copy of it on this one.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1892
			// - 858 = 48510
			// - SHRINE = 1
			// - 1059 = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2053
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_138", new CardDef(new Power
			{
				// TODO [TRLA_138] Shirvallah's Grace && Test: Shirvallah's Grace_TRLA_138
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_138t] Shirvallah's Grace (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 51921
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_138t", new CardDef(new Power
			{
				// TODO [TRLA_138t] Shirvallah's Grace && Test: Shirvallah's Grace_TRLA_138t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_139] Parading Marshal (*) - COST:3 [ATK:3/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Start of Game:</b> Draw this.
			//       <b>Battlecry:</b> Equip a Truesilver Champion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_139", new CardDef(new Power
			{
				// TODO [TRLA_139] Parading Marshal && Test: Parading Marshal_TRLA_139
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_140] Blessed One (*) - COST:4 [ATK:4/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw spells until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_140", new CardDef(new Power
			{
				// TODO [TRLA_140] Blessed One && Test: Blessed One_TRLA_140
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_141] Lightchucker (*) - COST:3 [ATK:4/HP:6] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: After a character is healed, destroy a random
			//       enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_141", new CardDef(new Power
			{
				// TODO [TRLA_141] Lightchucker && Test: Lightchucker_TRLA_141
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_142] The Walking Fort (*) - COST:6 [ATK:2/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       This minion can only take
			//       1_damage_at_a_time.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_142", new CardDef(new Power
			{
				// TODO [TRLA_142] The Walking Fort && Test: The Walking Fort_TRLA_142
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_143] Gloryseeker (*) - COST:4 [ATK:3/HP:1] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, your hero takes it instead.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_143", new CardDef(new Power
			{
				// TODO [TRLA_143] Gloryseeker && Test: Gloryseeker_TRLA_143
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [TRLA_144] Exactor of Justice (*) - COST:5 [ATK:5/HP:7] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       <b>Overkill:</b> Gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_144", new CardDef(new Power
			{
				// TODO [TRLA_144] Exactor of Justice && Test: Exactor of Justice_TRLA_144
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_01] Magnetic (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_906, GVG_058, GVG_006, BOT_021, BOT_911, BOT_312, GVG_096, BOT_563, BOT_548, BOT_537, BOT_912
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_01", new CardDef(new[] {"BOT_906","GVG_058","GVG_006","BOT_021","BOT_911","BOT_312","GVG_096","BOT_563","BOT_548","BOT_537","BOT_912"}, new Power
			{
				// TODO [TRLA_Paladin_01] Magnetic && Test: Magnetic_TRLA_Paladin_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_02] Healing (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: OG_198, BOT_236, TRL_570, TRL_307, LOOT_398, TRL_308, CFM_815, GIL_817, TRL_545, BOT_548, OG_229, TRL_300, GVG_069
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_02", new CardDef(new[] {"OG_198","BOT_236","TRL_570","TRL_307","LOOT_398","TRL_308","CFM_815","GIL_817","TRL_545","BOT_548","OG_229","TRL_300","GVG_069"}, new Power
			{
				// TODO [TRLA_Paladin_02] Healing && Test: Healing_TRLA_Paladin_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_03] Recruits (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_960, LOOT_363, GVG_061, UNG_962, OG_273, GVG_060, LOOT_333, LOOT_313, UNG_015, UNG_950
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_03", new CardDef(new[] {"UNG_960","LOOT_363","GVG_061","UNG_962","OG_273","GVG_060","LOOT_333","LOOT_313","UNG_015","UNG_950"}, new Power
			{
				// TODO [TRLA_Paladin_03] Recruits && Test: Recruits_TRLA_Paladin_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_04] Self-Sacrifice (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_543, BOT_447, AT_105, EX1_082, TRL_546, CS2_181, EX1_097, GVG_090, BOT_448, BOT_107
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_04", new CardDef(new[] {"TRL_543","BOT_447","AT_105","EX1_082","TRL_546","CS2_181","EX1_097","GVG_090","BOT_448","BOT_107"}, new Power
			{
				// TODO [TRLA_Paladin_04] Self-Sacrifice && Test: Self-Sacrifice_TRLA_Paladin_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_05] Teambuilding (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_305, CFM_759, CFM_753, FP1_003, LOOT_363, TRL_517, LOE_077, ICC_466, CFM_639, TRL_304, CFM_668, BOT_910
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_05", new CardDef(new[] {"CFM_305","CFM_759","CFM_753","FP1_003","LOOT_363","TRL_517","LOE_077","ICC_466","CFM_639","TRL_304","CFM_668","BOT_910"}, new Power
			{
				// TODO [TRLA_Paladin_05] Teambuilding && Test: Teambuilding_TRLA_Paladin_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_06] Reinforce (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: ICC_092, CS2_087, TRL_306, GIL_145, AT_074, CS2_092, KAR_077, EX1_093, UNG_952, LOOT_500, LOOT_216
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_06", new CardDef(new[] {"ICC_092","CS2_087","TRL_306","GIL_145","AT_074","CS2_092","KAR_077","EX1_093","UNG_952","LOOT_500","LOOT_216"}, new Power
			{
				// TODO [TRLA_Paladin_06] Reinforce && Test: Reinforce_TRLA_Paladin_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_07] Holy Arsenal (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_543, CS2_091, EX1_366, LOOT_286, CS2_097, TRL_304, LOOT_500, UNG_950, GIL_596
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_07", new CardDef(new[] {"TRL_543","CS2_091","EX1_366","LOOT_286","CS2_097","TRL_304","LOOT_500","UNG_950","GIL_596"}, new Power
			{
				// TODO [TRLA_Paladin_07] Holy Arsenal && Test: Holy Arsenal_TRLA_Paladin_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_08] Secrets (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_130, FP1_020, EX1_136, EX1_379, AT_073, CFM_800, BOT_908, GIL_903, EX1_080, UNG_011, TRL_530, GIL_634, AT_079
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_08", new CardDef(new[] {"EX1_130","FP1_020","EX1_136","EX1_379","AT_073","CFM_800","BOT_908","GIL_903","EX1_080","UNG_011","TRL_530","GIL_634","AT_079"}, new Power
			{
				// TODO [TRLA_Paladin_08] Secrets && Test: Secrets_TRLA_Paladin_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_09] Dragons (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: GIL_635, TRL_523, GIL_681, KAR_010, GIL_601, TRL_526, BRM_018, TRL_569, UNG_848, EX1_572, LOOT_137, NEW1_030
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_09", new CardDef(new[] {"GIL_635","TRL_523","GIL_681","KAR_010","GIL_601","TRL_526","BRM_018","TRL_569","UNG_848","EX1_572","LOOT_137","NEW1_030"}, new Power
			{
				// TODO [TRLA_Paladin_09] Dragons && Test: Dragons_TRLA_Paladin_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [TRLA_Paladin_10] Divine Legends (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_236, TRL_308, GIL_817, TRL_096, ICC_858, LOOT_500, UNG_015, TRL_564, GIL_578, EX1_383, TRL_541, TRL_300
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Paladin_10", new CardDef(new[] {"BOT_236","TRL_308","GIL_817","TRL_096","ICC_858","LOOT_500","UNG_015","TRL_564","GIL_578","EX1_383","TRL_541","TRL_300"}, new Power
			{
				// TODO [TRLA_Paladin_10] Divine Legends && Test: Divine Legends_TRLA_Paladin_10
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRLA_114e] Bwonsamdi's Sanctum Player Enchant (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_114e", new CardDef(new Power
			{
				// TODO [TRLA_114e] Bwonsamdi's Sanctum Player Enchant && Test: Bwonsamdi's Sanctum Player Enchant_TRLA_114e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_114e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRLA_148e] Repurposed Steel (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_148e", new CardDef(new Power
			{
				// TODO [TRLA_148e] Repurposed Steel && Test: Repurposed Steel_TRLA_148e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_148e")
			}));

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [TRLA_153e] Attentive Conjuring (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_153e", new CardDef(new Power
			{
				// TODO [TRLA_153e] Attentive Conjuring && Test: Attentive Conjuring_TRLA_153e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_153e")
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_114] Bwonsamdi's Sanctum (*) - COST:0 [ATK:0/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your <b>Deathrattles</b> trigger
			//       two additional times.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1901
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2057
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2203
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_114", new CardDef(new Power
			{
				// TODO [TRLA_114] Bwonsamdi's Sanctum && Test: Bwonsamdi's Sanctum_TRLA_114
				InfoCardId = "TRLA_114e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_114t] Bwonsamdi's Sanctum (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50904
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_114t", new CardDef(new Power
			{
				// TODO [TRLA_114t] Bwonsamdi's Sanctum && Test: Bwonsamdi's Sanctum_TRLA_114t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_146] Bwonsamdi's Tome (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you cast a spell,
			//       add a random Priest spell
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1902
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2058
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2213
			// --------------------------------------------------------
			cards.Add("TRLA_146", new CardDef(new Power
			{
				// TODO [TRLA_146] Bwonsamdi's Tome && Test: Bwonsamdi's Tome_TRLA_146
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_146t] Bwonsamdi's Tome (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52037
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_146t", new CardDef(new Power
			{
				// TODO [TRLA_146t] Bwonsamdi's Tome && Test: Bwonsamdi's Tome_TRLA_146t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_147] Bwonsamdi's Covenant (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Healing enemies
			//       damages them instead.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1903
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2056
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2215
			// --------------------------------------------------------
			cards.Add("TRLA_147", new CardDef(new Power
			{
				// TODO [TRLA_147] Bwonsamdi's Covenant && Test: Bwonsamdi's Covenant_TRLA_147
				InfoCardId = "TRLA_147e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_147t] Bwonsamdi's Covenant (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52038
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_147t", new CardDef(new Power
			{
				// TODO [TRLA_147t] Bwonsamdi's Covenant && Test: Bwonsamdi's Covenant_TRLA_147t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_148] Weaponized Zombie (*) - COST:1 [ATK:2/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Start of Game:</b> Draw this.
			//       <b>Deathrattle:</b> Give a random friendly_minion_+1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_148", new CardDef(new Power
			{
				// TODO [TRLA_148] Weaponized Zombie && Test: Weaponized Zombie_TRLA_148
				InfoCardId = "TRLA_148e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_149] Ghastcoiler (*) - COST:6 [ATK:7/HP:7] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon
			//       2 random <b>Deathrattle</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// - 1429 = 58424
			// - TECH_LEVEL = 6
			// --------------------------------------------------------
			cards.Add("TRLA_149", new CardDef(new Power
			{
				// TODO [TRLA_149] Ghastcoiler && Test: Ghastcoiler_TRLA_149
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_150] Bloodwash Medic (*) - COST:3 [ATK:3/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Add 3 healing spells to your hand.
			// --------------------------------------------------------
			// Entourage: EX1_621, TRL_128, UNG_030, AT_055, GVG_012, AT_013, GIL_661, CFM_604, CS1_112, EX1_624
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_150", new CardDef(new[] {"EX1_621","TRL_128","UNG_030","AT_055","GVG_012","AT_013","GIL_661","CFM_604","CS1_112","EX1_624"}, new Power
			{
				// TODO [TRLA_150] Bloodwash Medic && Test: Bloodwash Medic_TRLA_150
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_151] Bwonsamdi's Keeper (*) - COST:4 [ATK:4/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore all minions to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_151", new CardDef(new Power
			{
				// TODO [TRLA_151] Bwonsamdi's Keeper && Test: Bwonsamdi's Keeper_TRLA_151
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_152] Soulsapper (*) - COST:5 [ATK:6/HP:6] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Steal 2 spells from your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_152", new CardDef(new Power
			{
				// TODO [TRLA_152] Soulsapper && Test: Soulsapper_TRLA_152
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [TRLA_153] Conjuring Attendant (*) - COST:3 [ATK:2/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your spells cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_153", new CardDef(new Power
			{
				// TODO [TRLA_153] Conjuring Attendant && Test: Conjuring Attendant_TRLA_153
				InfoCardId = "TRLA_153e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_01] Dying Words (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_032, BOT_558, TRL_502, TRL_537, GIL_805, LOOT_161, BOT_509, BOT_566, BOT_258, OG_256, LOE_006, LOOT_187, UNG_037, ICC_214, OG_335, FP1_028
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_01", new CardDef(new[] {"UNG_032","BOT_558","TRL_502","TRL_537","GIL_805","LOOT_161","BOT_509","BOT_566","BOT_258","OG_256","LOE_006","LOOT_187","UNG_037","ICC_214","OG_335","FP1_028"}, new Power
			{
				// TODO [TRLA_Priest_01] Dying Words && Test: Dying Words_TRLA_Priest_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_02] Healing (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_030, GVG_012, CS2_235, GIL_835, EX1_621, TRL_128, OG_234, CFM_067, GIL_190
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_02", new CardDef(new[] {"UNG_030","GVG_012","CS2_235","GIL_835","EX1_621","TRL_128","OG_234","CFM_067","GIL_190"}, new Power
			{
				// TODO [TRLA_Priest_02] Healing && Test: Healing_TRLA_Priest_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_03] Inspired by the Light (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_350, AT_080, AT_085, AT_132, GIL_646, AT_018, AT_127, AT_090, AT_099, AT_119
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_03", new CardDef(new[] {"EX1_350","AT_080","AT_085","AT_132","GIL_646","AT_018","AT_127","AT_090","AT_099","AT_119"}, new Power
			{
				// TODO [TRLA_Priest_03] Inspired by the Light && Test: Inspired by the Light_TRLA_Priest_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_04] Double Down (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: GIL_142, UNG_032, BOT_435, GIL_813, BOT_529, BOT_567, TRL_097, ICC_215, UNG_029, UNG_022, OG_335, GIL_134, BOT_258, TRL_259
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_04", new CardDef(new[] {"GIL_142","UNG_032","BOT_435","GIL_813","BOT_529","BOT_567","TRL_097","ICC_215","UNG_029","UNG_022","OG_335","GIL_134","BOT_258","TRL_259"}, new Power
			{
				// TODO [TRLA_Priest_04] Double Down && Test: Double Down_TRLA_Priest_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_05] Elementals (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_032, GIL_156, UNG_034, EX1_335, UNG_963, KAR_036, UNG_928, EX1_298, UNG_816, UNG_847, GIL_119
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_05", new CardDef(new[] {"UNG_032","GIL_156","UNG_034","EX1_335","UNG_963","KAR_036","UNG_928","EX1_298","UNG_816","UNG_847","GIL_119"}, new Power
			{
				// TODO [TRLA_Priest_05] Elementals && Test: Elementals_TRLA_Priest_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_06] Inner Strength (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS1_129, CS2_004, GIL_840, CS2_236, GVG_010, LOE_053, AT_131
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_06", new CardDef(new[] {"CS1_129","CS2_004","GIL_840","CS2_236","GVG_010","LOE_053","AT_131"}, new Power
			{
				// TODO [TRLA_Priest_06] Inner Strength && Test: Inner Strength_TRLA_Priest_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_07] Resilient (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_219, TRL_500, ICC_210, FP1_023, CFM_626, LOOT_278, OG_094, EX1_623, OG_256, LOE_061, KAR_035, ICC_212
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_07", new CardDef(new[] {"BOT_219","TRL_500","ICC_210","FP1_023","CFM_626","LOOT_278","OG_094","EX1_623","OG_256","LOE_061","KAR_035","ICC_212"}, new Power
			{
				// TODO [TRLA_Priest_07] Resilient && Test: Resilient_TRLA_Priest_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_08] Army of the Dead (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_260, TRL_502, BRM_017, LOOT_187, ICC_213, KAR_204, LOOT_507, ICC_257, ICC_098, OG_133
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_08", new CardDef(new[] {"TRL_260","TRL_502","BRM_017","LOOT_187","ICC_213","KAR_204","LOOT_507","ICC_257","ICC_098","OG_133"}, new Power
			{
				// TODO [TRLA_Priest_08] Army of the Dead && Test: Army of the Dead_TRLA_Priest_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_09] Wrath (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_234, EX1_622, OG_100, LOE_104, ICC_802, TRL_258, GVG_008, LOOT_008, EX1_626
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_09", new CardDef(new[] {"CS2_234","EX1_622","OG_100","LOE_104","ICC_802","TRL_258","GVG_008","LOOT_008","EX1_626"}, new Power
			{
				// TODO [TRLA_Priest_09] Wrath && Test: Wrath_TRLA_Priest_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [TRLA_Priest_10] Legends of the Light (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_018, TRL_260, TRL_259, OG_133, UNG_963, BOT_258, TRL_537, EX1_012, GVG_014, EX1_350
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Priest_10", new CardDef(new[] {"AT_018","TRL_260","TRL_259","OG_133","UNG_963","BOT_258","TRL_537","EX1_012","GVG_014","EX1_350"}, new Power
			{
				// TODO [TRLA_Priest_10] Legends of the Light && Test: Legends of the Light_TRLA_Priest_10
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TRLA_106e] Bottled Terror (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_106e", new CardDef(new Power
			{
				// TODO [TRLA_106e] Bottled Terror && Test: Bottled Terror_TRLA_106e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_106e")
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_106] Bottled Terror (*) - COST:0 [ATK:0/HP:2] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your other minions have <b>Stealth</b>.
			//        <b>Deathrattle:</b> Give your minions
			//       +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1904
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2043
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2202
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TRLA_106", new CardDef(new Power
			{
				// TODO [TRLA_106] Bottled Terror && Test: Bottled Terror_TRLA_106
				InfoCardId = "TRLA_106e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_106t] Bottled Terror (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50841
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_106t", new CardDef(new Power
			{
				// TODO [TRLA_106t] Bottled Terror && Test: Bottled Terror_TRLA_106t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_186] Treasure from Below (*) - COST:0 [ATK:0/HP:2] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       At the start of your turn, steal
			//       a card from your opponent's
			//       deck. It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1908
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2059
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_186", new CardDef(new Power
			{
				// TODO [TRLA_186] Treasure from Below && Test: Treasure from Below_TRLA_186
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_186t] Treasure from Below (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 53034
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_186t", new CardDef(new Power
			{
				// TODO [TRLA_186t] Treasure from Below && Test: Treasure from Below_TRLA_186t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_187] Pirate's Mark (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you cast a spell,
			//       cast it again
			//       <i>(on the same target).</i>
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1910
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2060
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2201
			// --------------------------------------------------------
			cards.Add("TRLA_187", new CardDef(new Power
			{
				// TODO [TRLA_187] Pirate's Mark && Test: Pirate's Mark_TRLA_187
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_187t] Pirate's Mark (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 53036
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_187t", new CardDef(new Power
			{
				// TODO [TRLA_187t] Pirate's Mark && Test: Pirate's Mark_TRLA_187t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_188] Pesky Rascal (*) - COST:3 [ATK:1/HP:1] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Immune</b>
			//       <b>Start of Game:</b> Draw this.
			// --------------------------------------------------------
			// GameTag:
			// - 309 = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_188", new CardDef(new Power
			{
				// TODO [TRLA_188] Pesky Rascal && Test: Pesky Rascal_TRLA_188
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_189] Parrot Mascot (*) - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Combo:</b> Add a copy of
			//       each card you've played
			//       this turn to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_189", new CardDef(new Power
			{
				// TODO [TRLA_189] Parrot Mascot && Test: Parrot Mascot_TRLA_189
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_190] Salty Looter (*) - COST:6 [ATK:6/HP:6] 
			// - Race: pirate, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry</b> and <b>Deathrattle:</b> Steal a card from your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_190", new CardDef(new Power
			{
				// TODO [TRLA_190] Salty Looter && Test: Salty Looter_TRLA_190
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_191] Sharktoothed Harpooner (*) - COST:2 [ATK:4/HP:3] 
			// - Race: pirate, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding any cards that didn't start in your deck, reduce their Cost by (4).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_191", new CardDef(new Power
			{
				// TODO [TRLA_191] Sharktoothed Harpooner && Test: Sharktoothed Harpooner_TRLA_191
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_192] Lobstrok Tastetester (*) - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]After you cast a spell, draw
			//       a spell from your deck.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_192", new CardDef(new Power
			{
				// TODO [TRLA_192] Lobstrok Tastetester && Test: Lobstrok Tastetester_TRLA_192
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [TRLA_193] Raging Contender (*) - COST:6 [ATK:8/HP:4] 
			// - Race: pirate, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Fill your board with random Pirates.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_193", new CardDef(new Power
			{
				// TODO [TRLA_193] Raging Contender && Test: Raging Contender_TRLA_193
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_01] Burgle (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_856, KAR_069, OG_330, GIL_827, AT_033, CFM_781, ICC_811, UNG_061, GIL_672, KAR_070, GIL_598
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_01", new CardDef(new[] {"UNG_856","KAR_069","OG_330","GIL_827","AT_033","CFM_781","ICC_811","UNG_061","GIL_672","KAR_070","GIL_598"}, new Power
			{
				// TODO [TRLA_Rogue_01] Burgle && Test: Burgle_TRLA_Rogue_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_02] Pirates (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_029, CFM_637, CS2_146, KAR_069, TRL_071, NEW1_018, TRL_507, GVG_075, TRL_124, NEW1_027, CFM_651, TRL_015, NEW1_024, TRL_127, TRL_126
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_02", new CardDef(new[] {"AT_029","CFM_637","CS2_146","KAR_069","TRL_071","NEW1_018","TRL_507","GVG_075","TRL_124","NEW1_027","CFM_651","TRL_015","NEW1_024","TRL_127","TRL_126"}, new Power
			{
				// TODO [TRLA_Rogue_02] Pirates && Test: Pirates_TRLA_Rogue_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_03] Battlecry (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_144, EX1_050, EX1_613, EX1_134, LOOT_516, LOOT_211, LOOT_026, GVG_069, EX1_284, TRL_409, TRL_092, UNG_064, NEW1_004
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_03", new CardDef(new[] {"EX1_144","EX1_050","EX1_613","EX1_134","LOOT_516","LOOT_211","LOOT_026","GVG_069","EX1_284","TRL_409","TRL_092","UNG_064","NEW1_004"}, new Power
			{
				// TODO [TRLA_Rogue_03] Battlecry && Test: Battlecry_TRLA_Rogue_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_04] Aggressive Tactics (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_072, GIL_506, EX1_124, UNG_057, EX1_278, EX1_129, OG_176, TRL_127, GIL_687, EX1_012, EX1_284, EX1_095
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_04", new CardDef(new[] {"CS2_072","GIL_506","EX1_124","UNG_057","EX1_278","EX1_129","OG_176","TRL_127","GIL_687","EX1_012","EX1_284","EX1_095"}, new Power
			{
				// TODO [TRLA_Rogue_04] Aggressive Tactics && Test: Aggressive Tactics_TRLA_Rogue_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_05] Tricks of the Trade (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_630, EX1_145, CS2_073, CS2_074, UNG_856, EX1_581, UNG_060, TRL_157, OG_073, NEW1_004, CS2_077, EX1_095
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_05", new CardDef(new[] {"CFM_630","EX1_145","CS2_073","CS2_074","UNG_856","EX1_581","UNG_060","TRL_157","OG_073","NEW1_004","CS2_077","EX1_095"}, new Power
			{
				// TODO [TRLA_Rogue_05] Tricks of the Trade && Test: Tricks of the Trade_TRLA_Rogue_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_06] Weapons (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_074, BOT_083, UNG_823, BOT_286, CFM_651, OG_267, NEW1_024, ICC_850, GVG_022, CS2_080, TRL_074
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_06", new CardDef(new[] {"CS2_074","BOT_083","UNG_823","BOT_286","CFM_651","OG_267","NEW1_024","ICC_850","GVG_022","CS2_080","TRL_074"}, new Power
			{
				// TODO [TRLA_Rogue_06] Weapons && Test: Weapons_TRLA_Rogue_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_07] Deathrattle (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: FP1_007, OG_330, UNG_083, BOT_286, LOE_019, LOE_012, OG_272, TRL_409, BOT_243, LOOT_161, EX1_110, BOT_066
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_07", new CardDef(new[] {"FP1_007","OG_330","UNG_083","BOT_286","LOE_019","LOE_012","OG_272","TRL_409","BOT_243","LOOT_161","EX1_110","BOT_066"}, new Power
			{
				// TODO [TRLA_Rogue_07] Deathrattle && Test: Deathrattle_TRLA_Rogue_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_08] For the Money (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_630, AT_031, LOE_012, GIL_687, GVG_028, CFM_669, EX1_095, CFM_060, NEW1_026, KAR_711
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_08", new CardDef(new[] {"CFM_630","AT_031","LOE_012","GIL_687","GVG_028","CFM_669","EX1_095","CFM_060","NEW1_026","KAR_711"}, new Power
			{
				// TODO [TRLA_Rogue_08] For the Money && Test: For the Money_TRLA_Rogue_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_09] Bounce (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_144, LOOT_204, CFM_693, BOT_288, LOE_077, EX1_050, EX1_613, LOOT_165, LOOT_211, LOOT_026, TRL_092, NEW1_004
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_09", new CardDef(new[] {"EX1_144","LOOT_204","CFM_693","BOT_288","LOE_077","EX1_050","EX1_613","LOOT_165","LOOT_211","LOOT_026","TRL_092","NEW1_004"}, new Power
			{
				// TODO [TRLA_Rogue_09] Bounce && Test: Bounce_TRLA_Rogue_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [TRLA_Rogue_10] Misfits (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_809, KAR_069, FP1_002, OG_330, GIL_534, LOOT_165, UNG_075, LOOT_026, LOE_012, BOT_576, OG_291, UNG_064
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Rogue_10", new CardDef(new[] {"UNG_809","KAR_069","FP1_002","OG_330","GIL_534","LOOT_165","UNG_075","LOOT_026","LOE_012","BOT_576","OG_291","UNG_064"}, new Power
			{
				// TODO [TRLA_Rogue_10] Misfits && Test: Misfits_TRLA_Rogue_10
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [TRLA_109e] Overcharged (*) - COST:0 [ATK:0/HP:9] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1 Attack for each Mana Crystal you've Overloaded.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_DECK_ID = 1803
			// - 858 = 48510
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_109e", new CardDef(new Power
			{
				// TODO [TRLA_109e] Overcharged && Test: Overcharged_TRLA_109e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_109e")
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_109] Krag'wa's Lure (*) - COST:0 [ATK:0/HP:2] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you <b>Overload</b>,
			//       give your minions that
			//       much Attack.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1911
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2062
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2208
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_109", new CardDef(new Power
			{
				// TODO [TRLA_109] Krag'wa's Lure && Test: Krag'wa's Lure_TRLA_109
				InfoCardId = "TRLA_109e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_109t] Krag'wa's Lure (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50900
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_109t", new CardDef(new Power
			{
				// TODO [TRLA_109t] Krag'wa's Lure && Test: Krag'wa's Lure_TRLA_109t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_154] Tribute from the Tides (*) - COST:0 [ATK:0/HP:3] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your <b>Battlecries</b> trigger
			//       two additional times.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1913
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2063
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2216
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TRLA_154", new CardDef(new Power
			{
				// TODO [TRLA_154] Tribute from the Tides && Test: Tribute from the Tides_TRLA_154
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_154t] Tribute from the Tides (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52855
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_154t", new CardDef(new Power
			{
				// TODO [TRLA_154t] Tribute from the Tides && Test: Tribute from the Tides_TRLA_154t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_155] Krag'wa's Grace (*) - COST:0 [ATK:0/HP:10] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your spells cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1912
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2061
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2214
			// --------------------------------------------------------
			cards.Add("TRLA_155", new CardDef(new Power
			{
				// TODO [TRLA_155] Krag'wa's Grace && Test: Krag'wa's Grace_TRLA_155
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_155t] Krag'wa's Grace (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52891
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_155t", new CardDef(new Power
			{
				// TODO [TRLA_155t] Krag'wa's Grace && Test: Krag'wa's Grace_TRLA_155t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_156] Deepsea Diver (*) - COST:1 [ATK:2/HP:2] 
			// - Race: murloc, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b> Draw this.
			//       <b>Battlecry:</b> Unlock your
			//       <b>  Overloaded</b> Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_156", new CardDef(new Power
			{
				// TODO [TRLA_156] Deepsea Diver && Test: Deepsea Diver_TRLA_156
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_157] Leap Frog (*) - COST:4 [ATK:3/HP:6] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 3 damage
			//       to a random enemy minion.
			//       If it dies, repeat this.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_157", new CardDef(new Power
			{
				// TODO [TRLA_157] Leap Frog && Test: Leap Frog_TRLA_157
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_158] Overcharged Totem (*) - COST:0 [ATK:0/HP:4] 
			// - Race: totem, Set: troll, 
			// --------------------------------------------------------
			// Text: After you <b>Overload</b>,
			//       deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_158", new CardDef(new Power
			{
				// TODO [TRLA_158] Overcharged Totem && Test: Overcharged Totem_TRLA_158
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_159] Croak Jouster (*) - COST:3 [ATK:4/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry</b>: <b>Discover</b> a spell.
			//       If you're <b>Overloaded</b>,
			//       keep_all_3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_159", new CardDef(new Power
			{
				// TODO [TRLA_159] Croak Jouster && Test: Croak Jouster_TRLA_159
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_160] Naga Tonguelasher (*) - COST:1 [ATK:4/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Overload</b> 3 of your opponent's Mana_Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("TRLA_160", new CardDef(new Power
			{
				// TODO [TRLA_160] Naga Tonguelasher && Test: Naga Tonguelasher_TRLA_160
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [TRLA_161] War Heralder (*) - COST:3 [ATK:3/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Add 3 random Shaman spells to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_161", new CardDef(new Power
			{
				// TODO [TRLA_161] War Heralder && Test: War Heralder_TRLA_161
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_01] Elemental Fury (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_025, KAR_073, OG_206, EX1_259, AT_051, GVG_038, LOOT_060, BRM_011, EX1_238, EX1_241, BOT_411, TRL_060, TRL_345
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_01", new CardDef(new[] {"UNG_025","KAR_073","OG_206","EX1_259","AT_051","GVG_038","LOOT_060","BRM_011","EX1_238","EX1_241","BOT_411","TRL_060","TRL_345"}, new Power
			{
				// TODO [TRLA_Shaman_01] Elemental Fury && Test: Elemental Fury_TRLA_Shaman_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_02] Spellchasers (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_522, GIL_531, BOT_411, TRL_060, TRL_085, BOT_291, KAR_021, OG_209, GIL_807, TRL_345, EX1_012, EX1_284
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_02", new CardDef(new[] {"TRL_522","GIL_531","BOT_411","TRL_060","TRL_085","BOT_291","KAR_021","OG_209","GIL_807","TRL_345","EX1_012","EX1_284"}, new Power
			{
				// TODO [TRLA_Shaman_02] Spellchasers && Test: Spellchasers_TRLA_Shaman_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_03] Blessings (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: LOOT_373, CS2_041, GVG_069, CFM_061, CFM_120, GVG_039, UNG_817, UNG_938, OG_209, AT_048
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_03", new CardDef(new[] {"LOOT_373","CS2_041","GVG_069","CFM_061","CFM_120","GVG_039","UNG_817","UNG_938","OG_209","AT_048"}, new Power
			{
				// TODO [TRLA_Shaman_03] Blessings && Test: Blessings_TRLA_Shaman_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_04] Mutations (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: LOOT_504, CFM_696, EX1_246, OG_328, OG_174, LOOT_150, CFM_697, BOT_099, BOT_245, TRL_082, CS2_046
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_04", new CardDef(new[] {"LOOT_504","CFM_696","EX1_246","OG_328","OG_174","LOOT_150","CFM_697","BOT_099","BOT_245","TRL_082","CS2_046"}, new Power
			{
				// TODO [TRLA_Shaman_04] Mutations && Test: Mutations_TRLA_Shaman_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_05] Battlecrier (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_054, CS2_042, UNG_202, LOOT_358, LOOT_517, UNG_072, ICC_466, CFM_668, FP1_030, CFM_852, ICC_705, BRM_012, GIL_836, GIL_820, TRL_345, GIL_622, CFM_853
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_05", new CardDef(new[] {"AT_054","CS2_042","UNG_202","LOOT_358","LOOT_517","UNG_072","ICC_466","CFM_668","FP1_030","CFM_852","ICC_705","BRM_012","GIL_836","GIL_820","TRL_345","GIL_622","CFM_853"}, new Power
			{
				// TODO [TRLA_Shaman_05] Battlecrier && Test: Battlecrier_TRLA_Shaman_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_06] Elementals (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_211, UNG_816, UNG_928, UNG_070, UNG_907, UNG_809, UNG_202, UNG_847, UNG_845, LOOT_517, NEW1_010, EX1_298, UNG_208, GIL_807, BOT_093, BOT_533, TRL_059, UNG_082, UNG_938, EX1_250
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_06", new CardDef(new[] {"UNG_211","UNG_816","UNG_928","UNG_070","UNG_907","UNG_809","UNG_202","UNG_847","UNG_845","LOOT_517","NEW1_010","EX1_298","UNG_208","GIL_807","BOT_093","BOT_533","TRL_059","UNG_082","UNG_938","EX1_250"}, new Power
			{
				// TODO [TRLA_Shaman_06] Elementals && Test: Elementals_TRLA_Shaman_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_07] Murlocs (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_942, CFM_310, LOE_113, EX1_509, EX1_506, EX1_506, UNG_073, EX1_050, EX1_103, UNG_937, UNG_089, EX1_062, CFM_344, EX1_507, GIL_678
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_07", new CardDef(new[] {"UNG_942","CFM_310","LOE_113","EX1_509","EX1_506","EX1_506","UNG_073","EX1_050","EX1_103","UNG_937","UNG_089","EX1_062","CFM_344","EX1_507","GIL_678"}, new Power
			{
				// TODO [TRLA_Shaman_07] Murlocs && Test: Murlocs_TRLA_Shaman_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_08] Overload (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_313, LOE_018, AT_053, OG_026, ICC_081, EX1_248, EX1_258, OG_024, EX1_250, LOOT_064, ICC_090, AT_052, LOE_018, BRM_011, OG_026, EX1_567, GIL_600, BOT_246, BOT_407, TRL_352, TRL_351
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_08", new CardDef(new[] {"CFM_313","LOE_018","AT_053","OG_026","ICC_081","EX1_248","EX1_258","OG_024","EX1_250","LOOT_064","ICC_090","AT_052","LOE_018","BRM_011","OG_026","EX1_567","GIL_600","BOT_246","BOT_407","TRL_352","TRL_351"}, new Power
			{
				// TODO [TRLA_Shaman_08] Overload && Test: Overload_TRLA_Shaman_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_09] Totems (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: OG_023, LOOT_062, LOOT_518, LOOT_344, EX1_575, AT_046, KAR_021, AT_049, OG_028, AT_052, EX1_565, GIL_583, TRL_012
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_09", new CardDef(new[] {"OG_023","LOOT_062","LOOT_518","LOOT_344","EX1_575","AT_046","KAR_021","AT_049","OG_028","AT_052","EX1_565","GIL_583","TRL_012"}, new Power
			{
				// TODO [TRLA_Shaman_09] Totems && Test: Totems_TRLA_Shaman_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_11] Jade Lotus (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CFM_717, CFM_707, CFM_312, CFM_715, CFM_902
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_11", new CardDef(new[] {"CFM_717","CFM_707","CFM_312","CFM_715","CFM_902"}, new Power
			{
				// TODO [TRLA_Shaman_11] Jade Lotus && Test: Jade Lotus_TRLA_Shaman_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_12] Farseer (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_053, CS2_038, CS2_053, UNG_956, GVG_029, LOOT_506, EX1_110, FP1_025, CFM_324, FP1_013, ICC_257, LOOT_161, TRL_345, TRL_060, TRL_522, TRL_058
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_12", new CardDef(new[] {"AT_053","CS2_038","CS2_053","UNG_956","GVG_029","LOOT_506","EX1_110","FP1_025","CFM_324","FP1_013","ICC_257","LOOT_161","TRL_345","TRL_060","TRL_522","TRL_058"}, new Power
			{
				// TODO [TRLA_Shaman_12] Farseer && Test: Farseer_TRLA_Shaman_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [TRLA_Shaman_13] Mechanized (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: GVG_036, GVG_085, EX1_556, GVG_096, GVG_105, GVG_107, OG_145, GVG_105, GVG_114, GVG_006, GVG_006, GVG_103, LOE_039, GVG_037
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Shaman_13", new CardDef(new[] {"GVG_036","GVG_085","EX1_556","GVG_096","GVG_105","GVG_107","OG_145","GVG_105","GVG_114","GVG_006","GVG_006","GVG_103","LOE_039","GVG_037"}, new Power
			{
				// TODO [TRLA_Shaman_13] Mechanized && Test: Mechanized_TRLA_Shaman_13
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [TRLA_113e] Blood Pact Player Enchantment (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_113e", new CardDef(new Power
			{
				// TODO [TRLA_113e] Blood Pact Player Enchantment && Test: Blood Pact Player Enchantment_TRLA_113e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_113e")
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_113] Blood Pact (*) - COST:0 [ATK:0/HP:10] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your spells cost Health
			//       instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - AURA = 1
			// - HERO_DECK_ID = 1894
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2041
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2204
			// --------------------------------------------------------
			cards.Add("TRLA_113", new CardDef(new Power
			{
				// TODO [TRLA_113] Blood Pact && Test: Blood Pact_TRLA_113
				InfoCardId = "TRLA_113e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_113t] Blood Pact (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50903
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_113t", new CardDef(new Power
			{
				// TODO [TRLA_113t] Blood Pact && Test: Blood Pact_TRLA_113t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_178] Dark Reliquary (*) - COST:0 [ATK:0/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Whenever you discard a
			//       card, summon a
			//       random Demon.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1883
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2069
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_178", new CardDef(new Power
			{
				// TODO [TRLA_178] Dark Reliquary && Test: Dark Reliquary_TRLA_178
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_178t] Dark Reliquary (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 53008
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_178t", new CardDef(new Power
			{
				// TODO [TRLA_178t] Dark Reliquary && Test: Dark Reliquary_TRLA_178t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_179] Hir'eek's Hunger (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Whenever your hero takes
			//       damage on your turn, the enemy
			//       hero takes it instead.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1893
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2042
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2210
			// --------------------------------------------------------
			cards.Add("TRLA_179", new CardDef(new Power
			{
				// TODO [TRLA_179] Hir'eek's Hunger && Test: Hir'eek's Hunger_TRLA_179
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_179t] Hir'eek's Hunger (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 53011
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_179t", new CardDef(new Power
			{
				// TODO [TRLA_179t] Hir'eek's Hunger && Test: Hir'eek's Hunger_TRLA_179t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_180] Leering Bat (*) - COST:2 [ATK:3/HP:3] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]Your hero is <b>Immune</b>
			//       on your turn.
			//          <b>Start of Game:</b> Draw this.
			// --------------------------------------------------------
			// GameTag:
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_180", new CardDef(new Power
			{
				// TODO [TRLA_180] Leering Bat && Test: Leering Bat_TRLA_180
				InfoCardId = "TRLA_180e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_181] Ravenous Familiar (*) - COST:2 [ATK:3/HP:4] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Overkill</b>: Discard your
			//       lowest Cost card and
			//       draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - DISCARD_CARDS = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_181", new CardDef(new Power
			{
				// TODO [TRLA_181] Ravenous Familiar && Test: Ravenous Familiar_TRLA_181
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_182] Vile Necrodoctor (*) - COST:5 [ATK:3/HP:6] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Battlecry:</b> Deal 3 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - LIFESTEAL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_182", new CardDef(new Power
			{
				// TODO [TRLA_182] Vile Necrodoctor && Test: Vile Necrodoctor_TRLA_182
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_183] Warp Stalker (*) - COST:3 [ATK:3/HP:5] 
			// - Race: beast, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       You can use your Hero Power
			//       any_number_of_times.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_183", new CardDef(new Power
			{
				// TODO [TRLA_183] Warp Stalker && Test: Warp Stalker_TRLA_183
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_184] Dark Diviner (*) - COST:4 [ATK:4/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Fill your hand with random spells.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_184", new CardDef(new Power
			{
				// TODO [TRLA_184] Dark Diviner && Test: Dark Diviner_TRLA_184
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [TRLA_185] Blood Portal (*) - COST:2 [ATK:0/HP:6] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Whenever your hero takes damage, add a random Warlock spell to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_185", new CardDef(new Power
			{
				// TODO [TRLA_185] Blood Portal && Test: Blood Portal_TRLA_185
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_01] Hir'eek's Legion (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_065, EX1_319, GVG_018, CFM_611, LOOT_013, BRM_006, AT_019, GVG_019, BRM_005, GVG_045, BOT_913, BOT_224, EX1_181, NEW1_019
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_01", new CardDef(new[] {"CS2_065","EX1_319","GVG_018","CFM_611","LOOT_013","BRM_006","AT_019","GVG_019","BRM_005","GVG_045","BOT_913","BOT_224","EX1_181","NEW1_019"}, new Power
			{
				// TODO [TRLA_Warlock_01] Hir'eek's Legion && Test: Hir'eek's Legion_TRLA_Warlock_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_02] Discard (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_310, OG_109, AT_021, KAR_089, UNG_829, UNG_833, ICC_841, EX1_308, UNG_836, LOOT_417, TRL_247, TRL_551, TRL_252, TRL_245, AT_025, BOT_568
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_02", new CardDef(new[] {"EX1_310","OG_109","AT_021","KAR_089","UNG_829","UNG_833","ICC_841","EX1_308","UNG_836","LOOT_417","TRL_247","TRL_551","TRL_252","TRL_245","AT_025","BOT_568"}, new Power
			{
				// TODO [TRLA_Warlock_02] Discard && Test: Discard_TRLA_Warlock_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_03] Life Takers (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_061, EX1_309, GVG_018, ICC_055, ICC_810, LOOT_043, ICC_905, GIL_565, GIL_527, TRL_252, GIL_143
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_03", new CardDef(new[] {"CS2_061","EX1_309","GVG_018","ICC_055","ICC_810","LOOT_043","ICC_905","GIL_565","GIL_527","TRL_252","GIL_143"}, new Power
			{
				// TODO [TRLA_Warlock_03] Life Takers && Test: Life Takers_TRLA_Warlock_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_04] Taunt (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: CS2_065, EX1_058, FP1_012, UNG_049, ICC_466, LOOT_131, ICC_314, LOOT_013, UNG_928, EX1_093, TRL_252, TRL_551, UNG_833
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_04", new CardDef(new[] {"CS2_065","EX1_058","FP1_012","UNG_049","ICC_466","LOOT_131","ICC_314","LOOT_013","UNG_928","EX1_093","TRL_252","TRL_551","UNG_833"}, new Power
			{
				// TODO [TRLA_Warlock_04] Taunt && Test: Taunt_TRLA_Warlock_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_06] Wrath (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, EX1_312, OG_239, CFM_094, ICC_041, LOOT_417, GIL_825, CS2_062
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_06", new CardDef(new[] {"NEW1_021","EX1_312","OG_239","CFM_094","ICC_041","LOOT_417","GIL_825","CS2_062"}, new Power
			{
				// TODO [TRLA_Warlock_06] Wrath && Test: Wrath_TRLA_Warlock_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_07] Sacrifice (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_303, EX1_316, EX1_304, AT_025, ICC_469, ICC_903, UNG_831, OG_239, LOOT_161, TRL_249, TRL_257
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_07", new CardDef(new[] {"EX1_303","EX1_316","EX1_304","AT_025","ICC_469","ICC_903","UNG_831","OG_239","LOOT_161","TRL_249","TRL_257"}, new Power
			{
				// TODO [TRLA_Warlock_07] Sacrifice && Test: Sacrifice_TRLA_Warlock_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_08] Blood (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: UNG_835, CS2_062, CFM_094, EX1_620, LOOT_013, LOOT_043, GIL_693, BOT_226, TRL_251, GIL_508, BOT_222
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_08", new CardDef(new[] {"UNG_835","CS2_062","CFM_094","EX1_620","LOOT_013","LOOT_043","GIL_693","BOT_226","TRL_251","GIL_508","BOT_222"}, new Power
			{
				// TODO [TRLA_Warlock_08] Blood && Test: Blood_TRLA_Warlock_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_09] Dire Demons (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: FP1_022, LOOT_420, EX1_310, CS2_064, CFM_663, CFM_751, GVG_021, LOOT_018, EX1_317, ICC_075, GVG_019, LOOT_306
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_09", new CardDef(new[] {"FP1_022","LOOT_420","EX1_310","CS2_064","CFM_663","CFM_751","GVG_021","LOOT_018","EX1_317","ICC_075","GVG_019","LOOT_306"}, new Power
			{
				// TODO [TRLA_Warlock_09] Dire Demons && Test: Dire Demons_TRLA_Warlock_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_10] A Dark Hand (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_043, EX1_105, EX1_620, AT_127, AT_027, BRM_028, BRM_031, EX1_095, TRL_253, TRL_251, BOT_443, LOOT_014
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_10", new CardDef(new[] {"EX1_043","EX1_105","EX1_620","AT_127","AT_027","BRM_028","BRM_031","EX1_095","TRL_253","TRL_251","BOT_443","LOOT_014"}, new Power
			{
				// TODO [TRLA_Warlock_10] A Dark Hand && Test: A Dark Hand_TRLA_Warlock_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [TRLA_Warlock_11] Jinx (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Entourage: GIL_191, BOT_913, GIL_543, CS2_062, LOOT_043, KAR_711, AT_127, EX1_320, BOT_521, EX1_303
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warlock_11", new CardDef(new[] {"GIL_191","BOT_913","GIL_543","CS2_062","LOOT_043","KAR_711","AT_127","EX1_320","BOT_521","EX1_303"}, new Power
			{
				// TODO [TRLA_Warlock_11] Jinx && Test: Jinx_TRLA_Warlock_11
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRLA_171e] Fury of the Rhino (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Overkill:</b> This minion can attack again.
			// --------------------------------------------------------
			// GameTag:
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_171e", new CardDef(new Power
			{
				// TODO [TRLA_171e] Fury of the Rhino && Test: Fury of the Rhino_TRLA_171e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_171e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRLA_172e] Quilboar Rally (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_172e", new CardDef(new Power
			{
				// TODO [TRLA_172e] Quilboar Rally && Test: Quilboar Rally_TRLA_172e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_172e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRLA_174e] Rocking Out (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Can't be reduced below 1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_174e", new CardDef(new Power
			{
				// TODO [TRLA_174e] Rocking Out && Test: Rocking Out_TRLA_174e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_174e")
			}));

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TRLA_176e] Flamed (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_176e", new CardDef(new Power
			{
				// TODO [TRLA_176e] Flamed && Test: Flamed_TRLA_176e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_176e")
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_104] Akali's Champion (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       This minion's Attack
			//       is always equal to
			//       your Armor.
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1900
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2065
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_104", new CardDef(new Power
			{
				// TODO [TRLA_104] Akali's Champion && Test: Akali's Champion_TRLA_104
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_104t] Akali's Champion (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50772
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_104t", new CardDef(new Power
			{
				// TODO [TRLA_104t] Akali's Champion && Test: Akali's Champion_TRLA_104t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_170] Akali's War Drum (*) - COST:0 [ATK:0/HP:8] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       After you summon a Dragon,
			//       reduce the Costs of Dragons
			//       in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1899
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2067
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2205
			// --------------------------------------------------------
			cards.Add("TRLA_170", new CardDef(new Power
			{
				// TODO [TRLA_170] Akali's War Drum && Test: Akali's War Drum_TRLA_170
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_170t] Akali's War Drum (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52997
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_170t", new CardDef(new Power
			{
				// TODO [TRLA_170t] Akali's War Drum && Test: Akali's War Drum_TRLA_170t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_171] Akali's Horn (*) - COST:0 [ATK:0/HP:5] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Shrine</b>
			//       Your minions have
			//       "<b>Overkill</b>: This can
			//       attack again."
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 1898
			// - 858 = 48510
			// - SHRINE = 1
			// - PLAYER_BASE_SHRINE_DECK_ID = 2066
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// - 1249 = 2198
			// --------------------------------------------------------
			// RefTag:
			// - OVERKILL = 1
			// --------------------------------------------------------
			cards.Add("TRLA_171", new CardDef(new Power
			{
				// TODO [TRLA_171] Akali's Horn && Test: Akali's Horn_TRLA_171
				InfoCardId = "TRLA_171e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_171t] Akali's Horn (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 52999
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_171t", new CardDef(new Power
			{
				// TODO [TRLA_171t] Akali's Horn && Test: Akali's Horn_TRLA_171t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_172] Rallying Quilboar (*) - COST:1 [ATK:2/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]Adjacent minions have <b>Taunt</b>.
			//       <b>Start of Game:</b> Draw this.
			// --------------------------------------------------------
			// GameTag:
			// - START_OF_GAME = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TRLA_172", new CardDef(new Power
			{
				// TODO [TRLA_172] Rallying Quilboar && Test: Rallying Quilboar_TRLA_172
				InfoCardId = "TRLA_172e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_173] Redcrest Rocker (*) - COST:1 [ATK:3/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       <b>Overkill:</b> <b>Discover</b> a Dragon.
			//       If you control a Dragon,
			//       keep all 3.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - RUSH = 1
			// - OVERKILL = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("TRLA_173", new CardDef(new Power
			{
				// TODO [TRLA_173] Redcrest Rocker && Test: Redcrest Rocker_TRLA_173
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_174] Ironhorn Drummer (*) - COST:5 [ATK:4/HP:4] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your minions can't be reduced below 1 Health on your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_174", new CardDef(new Power
			{
				// TODO [TRLA_174] Ironhorn Drummer && Test: Ironhorn Drummer_TRLA_174
				InfoCardId = "TRLA_174e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_175] Seasoned Pitbrawler (*) - COST:4 [ATK:3/HP:6] 
			// - Race: dragon, Set: troll, 
			// --------------------------------------------------------
			// Text: Whenever you gain Armor, gain twice as much.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_175", new CardDef(new Power
			{
				// TODO [TRLA_175] Seasoned Pitbrawler && Test: Seasoned Pitbrawler_TRLA_175
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_176] Herald of Flame (*) - COST:4 [ATK:7/HP:7] 
			// - Race: dragon, Set: troll, 
			// --------------------------------------------------------
			// Text: Whenever you play a Dragon, give it <b>Rush</b> and draw a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TRLA_176", new CardDef(new Power
			{
				// TODO [TRLA_176] Herald of Flame && Test: Herald of Flame_TRLA_176
				InfoCardId = "TRLA_176e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [TRLA_177] Unbound Punisher (*) - COST:8 [ATK:4/HP:10] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all
			//       enemy minions.
			//       Gain 2 Armor for each minion destroyed.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// - 1175 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TRLA_177", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_DAMAGED_TARGET,0}}, new Power
			{
				// TODO [TRLA_177] Unbound Punisher && Test: Unbound Punisher_TRLA_177
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_01] Tank Up! (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_059, UNG_923, EX1_410, EX1_402, LOOT_044, ICC_837, LOOT_367, BOT_042, AT_064, ICC_062, EX1_606, CFM_756, TRL_323, KAR_091, GVG_053, TRL_324, LOOT_285, LOOT_519, LOOT_413, TRL_010
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_01", new CardDef(new[] {"BOT_059","UNG_923","EX1_410","EX1_402","LOOT_044","ICC_837","LOOT_367","BOT_042","AT_064","ICC_062","EX1_606","CFM_756","TRL_323","KAR_091","GVG_053","TRL_324","LOOT_285","LOOT_519","LOOT_413","TRL_010"}, new Power
			{
				// TODO [TRLA_Warrior_01] Tank Up! && Test: Tank Up!_TRLA_Warrior_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_02] Berserker (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: EX1_607, CS2_104, EX1_414, EX1_392, EX1_603, NEW1_036, OG_149, FP1_021, ICC_064, EX1_604, TRL_010, TRL_528, NEW1_011, GIL_654
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_02", new CardDef(new[] {"EX1_607","CS2_104","EX1_414","EX1_392","EX1_603","NEW1_036","OG_149","FP1_021","ICC_064","EX1_604","TRL_010","TRL_528","NEW1_011","GIL_654"}, new Power
			{
				// TODO [TRLA_Warrior_02] Berserker && Test: Berserker_TRLA_Warrior_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_03] Legendary (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_132, GIL_547, TRL_328, TRL_329, LOOT_519, EX1_414, ICC_405, LOOT_516, NEW1_024, EX1_116, GVG_110, ICC_314, BRM_030, EX1_562, EX1_572, NEW1_030, OG_317, TRL_542, BOT_548, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_03", new CardDef(new[] {"AT_132","GIL_547","TRL_328","TRL_329","LOOT_519","EX1_414","ICC_405","LOOT_516","NEW1_024","EX1_116","GVG_110","ICC_314","BRM_030","EX1_562","EX1_572","NEW1_030","OG_317","TRL_542","BOT_548","GVG_114"}, new Power
			{
				// TODO [TRLA_Warrior_03] Legendary && Test: Legendary_TRLA_Warrior_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_04] Smash (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_321, CS2_108, EX1_391, AT_064, GVG_052, OG_314, CS2_105, EX1_408, EX1_410, CS2_114, TRL_325
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_04", new CardDef(new[] {"TRL_321","CS2_108","EX1_391","AT_064","GVG_052","OG_314","CS2_105","EX1_408","EX1_410","CS2_114","TRL_325"}, new Power
			{
				// TODO [TRLA_Warrior_04] Smash && Test: Smash_TRLA_Warrior_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_05] Metalhead (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_059, GVG_006, BOT_299, GVG_055, BOT_218, LOOT_111, BOT_021, GIL_681, GVG_096, GVG_107, BOT_401, BOT_563, BOT_548, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_05", new CardDef(new[] {"BOT_059","GVG_006","BOT_299","GVG_055","BOT_218","LOOT_111","BOT_021","GIL_681","GVG_096","GVG_107","BOT_401","BOT_563","BOT_548","GVG_114"}, new Power
			{
				// TODO [TRLA_Warrior_05] Metalhead && Test: Metalhead_TRLA_Warrior_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_06] Rush (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: GIL_547, GIL_113, TRL_329, TRL_327, GIL_580, TRL_550, TRL_542, TRL_020, GIL_601, GIL_803, GIL_653
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_06", new CardDef(new[] {"GIL_547","GIL_113","TRL_329","TRL_327","GIL_580","TRL_550","TRL_542","TRL_020","GIL_601","GIL_803","GIL_653"}, new Power
			{
				// TODO [TRLA_Warrior_06] Rush && Test: Rush_TRLA_Warrior_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_07] Fervent Fans (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: NEW1_023, EX1_402, EX1_007, EX1_603, LOOT_367, NEW1_011, EX1_043, GIL_681, BOT_059, UNG_072, TRL_010, CFM_754, ICC_062, GIL_113, GIL_803, EX1_604, GIL_155, TRL_363, TRL_523
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_07", new CardDef(new[] {"NEW1_023","EX1_402","EX1_007","EX1_603","LOOT_367","NEW1_011","EX1_043","GIL_681","BOT_059","UNG_072","TRL_010","CFM_754","ICC_062","GIL_113","GIL_803","EX1_604","GIL_155","TRL_363","TRL_523"}, new Power
			{
				// TODO [TRLA_Warrior_07] Fervent Fans && Test: Fervent Fans_TRLA_Warrior_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_08] Protection (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: BOT_059, EX1_402, LOOT_367, AT_069, LOE_022, OG_218, CFM_756, TRL_535, TRL_550, TRL_515, TRL_513, TRL_514, UNG_926, TRL_323, BOT_218
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_08", new CardDef(new[] {"BOT_059","EX1_402","LOOT_367","AT_069","LOE_022","OG_218","CFM_756","TRL_535","TRL_550","TRL_515","TRL_513","TRL_514","UNG_926","TRL_323","BOT_218"}, new Power
			{
				// TODO [TRLA_Warrior_08] Protection && Test: Protection_TRLA_Warrior_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_09] Dragon Heart (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: AT_071, TRL_362, TRL_326, TRL_323, TRL_328, NEW1_023, TRL_523, KAR_062, BRM_033, GIL_681, LOOT_118, GIL_601, EX1_043, AT_017, EX1_284, BRM_034, ICC_029, TRL_526, ICC_027, BRM_024, TRL_569, UNG_848, BRM_030, LOOT_137, EX1_572, TRL_328
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_09", new CardDef(new[] {"AT_071","TRL_362","TRL_326","TRL_323","TRL_328","NEW1_023","TRL_523","KAR_062","BRM_033","GIL_681","LOOT_118","GIL_601","EX1_043","AT_017","EX1_284","BRM_034","ICC_029","TRL_526","ICC_027","BRM_024","TRL_569","UNG_848","BRM_030","LOOT_137","EX1_572","TRL_328"}, new Power
			{
				// TODO [TRLA_Warrior_09] Dragon Heart && Test: Dragon Heart_TRLA_Warrior_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [TRLA_Warrior_10] Overkill (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Entourage: TRL_542, TRL_528, TRL_020, TRL_521, TRL_015, TRL_010, TRL_329, TRL_325
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_Warrior_10", new CardDef(new[] {"TRL_542","TRL_528","TRL_020","TRL_521","TRL_015","TRL_010","TRL_329","TRL_325"}, new Power
			{
				// TODO [TRLA_Warrior_10] Overkill && Test: Overkill_TRLA_Warrior_10
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_116e] Gonk's Bond (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_116e", new CardDef(new Power
			{
				// TODO [TRLA_116e] Gonk's Bond && Test: Gonk's Bond_TRLA_116e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_116e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_128e] Jan'alai's Flame Player Enchant (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Your Hero Power costs (0) this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_128e", new CardDef(new Power
			{
				// TODO [TRLA_128e] Jan'alai's Flame Player Enchant && Test: Jan'alai's Flame Player Enchant_TRLA_128e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_128e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_131e] Empowered Glyph (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Increased Spell Damage.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_131e", new CardDef(new Power
			{
				// TODO [TRLA_131e] Empowered Glyph && Test: Empowered Glyph_TRLA_131e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_131e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_147e] Bwonsamdi's Covenant (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Healing enemies damages them instead.
			// --------------------------------------------------------
			cards.Add("TRLA_147e", new CardDef(new Power
			{
				// TODO [TRLA_147e] Bwonsamdi's Covenant && Test: Bwonsamdi's Covenant_TRLA_147e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_147e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_164e] Panther's Lead (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Has <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_164e", new CardDef(new Power
			{
				// TODO [TRLA_164e] Panther's Lead && Test: Panther's Lead_TRLA_164e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_164e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_180e] Leering (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: Player Enchant
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_180e", new CardDef(new Power
			{
				// TODO [TRLA_180e] Leering && Test: Leering_TRLA_180e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_180e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_801e] Sacred (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_801e", new CardDef(new Power
			{
				// TODO [TRLA_801e] Sacred && Test: Sacred_TRLA_801e
				InfoCardId = "TRLA_801e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_801e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_801e2] Sacred Ritual Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_801e2", new CardDef(new Power
			{
				// TODO [TRLA_801e2] Sacred Ritual Player Enchant && Test: Sacred Ritual Player Enchant_TRLA_801e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_801e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_802e] Favored (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Adjacent minions gain <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_802e", new CardDef(new Power
			{
				// TODO [TRLA_802e] Favored && Test: Favored_TRLA_802e
				InfoCardId = "TRLA_802e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_802e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_802e2] Favor of the Gods Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_802e2", new CardDef(new Power
			{
				// TODO [TRLA_802e2] Favor of the Gods Player Enchant && Test: Favor of the Gods Player Enchant_TRLA_802e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_802e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_803e] Fortified (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: Restores to full Health each turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_803e", new CardDef(new Power
			{
				// TODO [TRLA_803e] Fortified && Test: Fortified_TRLA_803e
				InfoCardId = "TRLA_803e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_803e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_803e2] Fortified Spirit Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_803e2", new CardDef(new Power
			{
				// TODO [TRLA_803e2] Fortified Spirit Player Enchant && Test: Fortified Spirit Player Enchant_TRLA_803e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_803e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_805e] Pact with the Loa Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_805e", new CardDef(new Power
			{
				// TODO [TRLA_805e] Pact with the Loa Player Enchant && Test: Pact with the Loa Player Enchant_TRLA_805e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_805e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_806e] Wrath of the Loa Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_806e", new CardDef(new Power
			{
				// TODO [TRLA_806e] Wrath of the Loa Player Enchant && Test: Wrath of the Loa Player Enchant_TRLA_806e
				InfoCardId = "TRLA_806e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_806e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_806e2] Wrath of the Loas (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle</b>: Destroy all enemy <b>Shrines</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_806e2", new CardDef(new Power
			{
				// TODO [TRLA_806e2] Wrath of the Loas && Test: Wrath of the Loas_TRLA_806e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_806e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_807e] Boon Reaper Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_807e", new CardDef(new Power
			{
				// TODO [TRLA_807e] Boon Reaper Player Enchant && Test: Boon Reaper Player Enchant_TRLA_807e
				InfoCardId = "TRLA_807e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_807e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_807e2] Boon Reaper (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw cards until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_807e2", new CardDef(new Power
			{
				// TODO [TRLA_807e2] Boon Reaper && Test: Boon Reaper_TRLA_807e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_807e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_808e] Roaring Edifice Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_808e", new CardDef(new Power
			{
				// TODO [TRLA_808e] Roaring Edifice Player Enchant && Test: Roaring Edifice Player Enchant_TRLA_808e
				InfoCardId = "TRLA_808e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_808e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_808e2] Roaring Edifice (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Reduce the cost of cards in your hand by (2).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_808e2", new CardDef(new Power
			{
				// TODO [TRLA_808e2] Roaring Edifice && Test: Roaring Edifice_TRLA_808e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_808e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_809e] Windfall Blessing Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_809e", new CardDef(new Power
			{
				// TODO [TRLA_809e] Windfall Blessing Player Enchant && Test: Windfall Blessing Player Enchant_TRLA_809e
				InfoCardId = "TRLA_809e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_809e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_809e2] Windfall Glyph (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle</b>: Give all minions in your deck +1/+1."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_809e2", new CardDef(new Power
			{
				// TODO [TRLA_809e2] Windfall Glyph && Test: Windfall Glyph_TRLA_809e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_809e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TRLA_809e3] Windfall Blessing (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("TRLA_809e3", new CardDef(new Power
			{
				// TODO [TRLA_809e3] Windfall Blessing && Test: Windfall Blessing_TRLA_809e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("TRLA_809e3")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRLA_107] Tribal Shrine (*) - COST:0 [ATK:0/HP:1] 
			// - Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Shrine</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// - HERO_DECK_ID = 2001
			// - 858 = 2322
			// - SHRINE = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 50
			// - 1179 = 1
			// --------------------------------------------------------
			cards.Add("TRLA_107", new CardDef(new Power
			{
				// TODO [TRLA_107] Tribal Shrine && Test: Tribal Shrine_TRLA_107
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [TRLA_107t] Tribal Shrine (*) - COST:0 
			// - Set: troll, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - SCORE_VALUE_2 = 3
			// - DORMANT = 1
			// - HIDE_WATERMARK = 1
			// - ALTERNATE_MOUSE_OVER_CARD = 50842
			// - ENCHANTMENT_BANNER_TEXT = 3
			// - MOUSE_OVER_CARD_APPEARANCE = 4
			// --------------------------------------------------------
			cards.Add("TRLA_107t", new CardDef(new Power
			{
				// TODO [TRLA_107t] Tribal Shrine && Test: Tribal Shrine_TRLA_107t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_801] Sacred Ritual (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Shrines</b> have "Your spells cost (1) less."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_801", new CardDef(new Power
			{
				// TODO [TRLA_801] Sacred Ritual && Test: Sacred Ritual_TRLA_801
				InfoCardId = "TRLA_801e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_802] Favor of the Gods (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Minions adjacent to your <b>Shrines</b> have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_802", new CardDef(new Power
			{
				// TODO [TRLA_802] Favor of the Gods && Test: Favor of the Gods_TRLA_802
				InfoCardId = "TRLA_802e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_803] Fortified Spirit (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of each turn, restore your <b>Shrines</b> to
			//       full Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_803", new CardDef(new Power
			{
				// TODO [TRLA_803] Fortified Spirit && Test: Fortified Spirit_TRLA_803
				InfoCardId = "TRLA_803e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_804] Everlasting Devotion (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Start the game with a copy of your <b>Shrine</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_804", new CardDef(new Power
			{
				// TODO [TRLA_804] Everlasting Devotion && Test: Everlasting Devotion_TRLA_804
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_805] Pact with the Loa (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Shrines</b> revive in
			//       2 turns instead of 3.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_805", new CardDef(new Power
			{
				// TODO [TRLA_805] Pact with the Loa && Test: Pact with the Loa_TRLA_805
				InfoCardId = "TRLA_805e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_806] Wrath of the Loas (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Shrines</b> have "<b>Deathrattle</b>: Destroy
			//       all enemy <b>Shrines</b>."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_806", new CardDef(new Power
			{
				// TODO [TRLA_806] Wrath of the Loas && Test: Wrath of the Loas_TRLA_806
				InfoCardId = "TRLA_806e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_807] Boon Reaper (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Shrines</b> have "<b>Deathrattle</b>: Draw cards until your hand is full."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_807", new CardDef(new Power
			{
				// TODO [TRLA_807] Boon Reaper && Test: Boon Reaper_TRLA_807
				InfoCardId = "TRLA_807e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_808] Roaring Edifice (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive</b>
			//       Your <b>Shrines</b> have
			//       "<b>Deathrattle</b>: Cards in your
			//       hand cost (2) less."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_808", new CardDef(new Power
			{
				// TODO [TRLA_808] Roaring Edifice && Test: Roaring Edifice_TRLA_808
				InfoCardId = "TRLA_808e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [TRLA_809] Windfall Blessing (*) - COST:0 
			// - Fac: neutral, Set: troll, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Shrines</b> have "<b>Deathrattle</b>: Give minions in your deck +1/+1."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// - HIDE_WATERMARK = 1
			// - DECK_LIST_SORT_ORDER = 100
			// - 1200 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SHRINE = 1
			// --------------------------------------------------------
			cards.Add("TRLA_809", new CardDef(new Power
			{
				// TODO [TRLA_809] Windfall Blessing && Test: Windfall Blessing_TRLA_809
				InfoCardId = "TRLA_809e",
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
