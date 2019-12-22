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
	public class BoomsdayCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_01h2] Test Subject (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52176
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_01h2", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_01h2] Test Subject && Test: Test Subject_BOTA_BOSS_01h2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_03h] Astromancer Arwyn (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52175
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_03h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_03h] Astromancer Arwyn && Test: Astromancer Arwyn_BOTA_BOSS_03h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_04h] Stargazer Luna (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52175
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_04h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_04h] Stargazer Luna && Test: Stargazer Luna_BOTA_BOSS_04h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_05h] Zerek, Master Cloner (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52176
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_05h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_05h] Zerek, Master Cloner && Test: Zerek, Master Cloner_BOTA_BOSS_05h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_06h] Dexter the Dendrologist (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52177
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_06h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_06h] Dexter the Dendrologist && Test: Dexter the Dendrologist_BOTA_BOSS_06h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_07h] Flobbidinous Floop (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52177
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_07h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_07h] Flobbidinous Floop && Test: Flobbidinous Floop_BOTA_BOSS_07h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_08h] Demonologist Draan (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52178
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_08h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_08h] Demonologist Draan && Test: Demonologist Draan_BOTA_BOSS_08h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_09h] Dr. Morrigan (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52178
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_09h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_09h] Dr. Morrigan && Test: Dr. Morrigan_BOTA_BOSS_09h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_10h] Poisonmaster Pollark (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52180
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_10h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_10h] Poisonmaster Pollark && Test: Poisonmaster Pollark_BOTA_BOSS_10h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_12h] Lil' Stormy (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52179
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_12h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_12h] Lil' Stormy && Test: Lil' Stormy_BOTA_BOSS_12h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_13h] Electra Stormsurge (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52179
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_13h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_13h] Electra Stormsurge && Test: Electra Stormsurge_BOTA_BOSS_13h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_14h] Myra Rotspring (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52180
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_14h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_14h] Myra Rotspring && Test: Myra Rotspring_BOTA_BOSS_14h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_15h] Boomnician Breena (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52181
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_15h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_15h] Boomnician Breena && Test: Boomnician Breena_BOTA_BOSS_15h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_16h] Boommaster Flark (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52182
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_16h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_16h] Boommaster Flark && Test: Boommaster Flark_BOTA_BOSS_16h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_17h] Glow-Tron 2000 (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52183
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_17h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_17h] Glow-Tron 2000 && Test: Glow-Tron 2000_BOTA_BOSS_17h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_18h] Crystalsmith Kangor (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52184
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_18h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_18h] Crystalsmith Kangor && Test: Crystalsmith Kangor_BOTA_BOSS_18h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_20h] Dr. Boom (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47494
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20h", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20h] Dr. Boom && Test: Dr. Boom_BOTA_BOSS_20h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_20h2] Dr. Boom (*) - COST:0 [ATK:0/HP:30]
			// - Set: boomsday,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47494
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20h2", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20h2] Dr. Boom && Test: Dr. Boom_BOTA_BOSS_20h2
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_04p] Duality (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>There's symmetry in the stars.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_04p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_04p] Duality && Test: Duality_BOTA_BOSS_04p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_05p] Perfection (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>Everything must be perfect.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_05p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_05p] Perfection && Test: Perfection_BOTA_BOSS_05p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_07p] Gloop Sprayer (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>The most effective fertilizer this side of Outland.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_07p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_07p] Gloop Sprayer && Test: Gloop Sprayer_BOTA_BOSS_07p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_09p] Soul Battery (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>Stores souls...
			//       for science.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_09p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_09p] Soul Battery && Test: Soul Battery_BOTA_BOSS_09p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_13p] Stormsurge (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>These puzzles are elementary.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_13p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_13p] Stormsurge && Test: Stormsurge_BOTA_BOSS_13p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_14p] Experimental Necrium (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>Good poisons work instantly.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_14p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_14p] Experimental Necrium && Test: Experimental Necrium_BOTA_BOSS_14p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_15p] Firework Volley (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_15p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_15p] Firework Volley && Test: Firework Volley_BOTA_BOSS_15p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_16p] Firework Barrage (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_16p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_16p] Firework Barrage && Test: Firework Barrage_BOTA_BOSS_16p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_17p] Glowing Laser (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_17p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_17p] Glowing Laser && Test: Glowing Laser_BOTA_BOSS_17p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_18p] Radiant Laser (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 40
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_18p", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_18p] Radiant Laser && Test: Radiant Laser_BOTA_BOSS_18p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p1] True Perfection (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>Have you ever seen such a magnificent reflection?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p1", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20p1] True Perfection && Test: True Perfection_BOTA_BOSS_20p1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p2] Fusion Core (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>Why stop at souls?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p2", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20p2] Fusion Core && Test: Fusion Core_BOTA_BOSS_20p2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p3] Kadoom Bot (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <i>The fuse is lit.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p3", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20p3] Kadoom Bot && Test: Kadoom Bot_BOTA_BOSS_20p3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p4] Death Ray (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 40 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 40
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p4", new CardDef(new Power
			{
				// TODO [BOTA_BOSS_20p4] Death Ray && Test: Death Ray_BOTA_BOSS_20p4
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOTA_241e] Contaminated (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("BOTA_241e", new CardDef(new Power
			{
				// TODO [BOTA_241e] Contaminated && Test: Contaminated_BOTA_241e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [BOTA_241] Contamination (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Give a minion <b>Poisonous</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_241", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [BOTA_241] Contamination && Test: Contamination_BOTA_241
				InfoCardId = "BOTA_241e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BOTA_603] Soul Repressor (*) - COST:3 [ATK:0/HP:4]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put the lowest Cost Demon from your hand into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_603", new CardDef(new Power
			{
				// TODO [BOTA_603] Soul Repressor && Test: Soul Repressor_BOTA_603
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [BOTA_601] Phasing Portal (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Choose a minion.
			//       Put it on the bottom of your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOTA_601", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [BOTA_601] Phasing Portal && Test: Phasing Portal_BOTA_601
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_203e] FREEDOM! (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_203e", new CardDef(new Power
			{
				// TODO [BOTA_203e] FREEDOM! && Test: FREEDOM!_BOTA_203e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_208e] Demonic Research Player Enchant (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: This turn, your cards cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOTA_208e", new CardDef(new Power
			{
				// TODO [BOTA_208e] Demonic Research Player Enchant && Test: Demonic Research Player Enchant_BOTA_208e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_231e] Incubating (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a {0}.
			// --------------------------------------------------------
			cards.Add("BOTA_231e", new CardDef(new Power
			{
				// TODO [BOTA_231e] Incubating && Test: Incubating_BOTA_231e
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_242e] Steel Rattler (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOTA_242e", new CardDef(new Power
			{
				// TODO [BOTA_242e] Steel Rattler && Test: Steel Rattler_BOTA_242e
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_101] Spud M.E. (*) - COST:5 [ATK:0/HP:10]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: After this minion survives damage, switch sides.
			//       <b>Deathrattle:</b>_Destroy your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_101", new CardDef(new Power
			{
				// TODO [BOTA_101] Spud M.E. && Test: Spud M.E._BOTA_101
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_200] Undercover Reporter (*) - COST:2 [ATK:1/HP:2]
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion. Put two copies of it on top of your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("BOTA_200", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [BOTA_200] Undercover Reporter && Test: Undercover Reporter_BOTA_200
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_210] Galvanized Golem (*) - COST:3 [ATK:5/HP:2]
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Your 1-Attack minions cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("BOTA_210", new CardDef(new Power
			{
				// TODO [BOTA_210] Galvanized Golem && Test: Galvanized Golem_BOTA_210
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_211] Super Soldier (*) - COST:3 [ATK:2/HP:3]
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with 3 or less Attack, give it <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_211", new CardDef(new Power
			{
				// TODO [BOTA_211] Super Soldier && Test: Super Soldier_BOTA_211
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_212] Cure-All (*) - COST:3 [ATK:3/HP:3]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: Whenever a minion is healed, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("BOTA_212", new CardDef(new Power
			{
				// TODO [BOTA_212] Cure-All && Test: Cure-All_BOTA_212
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_214] Turret Sentinel (*) - COST:4 [ATK:4/HP:8]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: [x]After your opponent plays
			//       a minion, attack it.
			//       <b>Deathrattle:</b> Refresh ALL
			//       Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_214", new CardDef(new Power
			{
				// TODO [BOTA_214] Turret Sentinel && Test: Turret Sentinel_BOTA_214
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_223] Gelbin's Coil (*) - COST:1 [ATK:1/HP:2]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: After you play a spell, deal 1 damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("BOTA_223", new CardDef(new Power
			{
				// TODO [BOTA_223] Gelbin's Coil && Test: Gelbin's Coil_BOTA_223
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_229] Boom-in-a-Box (*) - COST:10 [ATK:0/HP:10]
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Deathrattle:</b>Deal 100 damage to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_229", new CardDef(new Power
			{
				// TODO [BOTA_229] Boom-in-a-Box && Test: Boom-in-a-Box_BOTA_229
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_231] Incubator (*) - COST:3 [ATK:1/HP:1]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion.
			//       <b>Deathrattle:</b> Summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOTA_231", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [BOTA_231] Incubator && Test: Incubator_BOTA_231
				InfoCardId = "BOTA_231e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_242] Steel Rattler (*) - COST:2 [ATK:1/HP:2]
			// - Race: mechanical, Set: boomsday,
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOTA_242", new CardDef(new Power
			{
				// TODO [BOTA_242] Steel Rattler && Test: Steel Rattler_BOTA_242
				InfoCardId = "BOTA_242e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_102] Battery Pack (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Refresh all your Mana Crystals.
			// --------------------------------------------------------
			cards.Add("BOTA_102", new CardDef(new Power
			{
				// TODO [BOTA_102] Battery Pack && Test: Battery Pack_BOTA_102
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_202] Uplink (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Take control of an enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_202", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [BOTA_202] Uplink && Test: Uplink_BOTA_202
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_203] Breakout (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Give your minions <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_203", new CardDef(new Power
			{
				// TODO [BOTA_203] Breakout && Test: Breakout_BOTA_203
				InfoCardId = "BOTA_203e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_207] The Swap (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Swap minions with your opponent.
			// --------------------------------------------------------
			cards.Add("BOTA_207", new CardDef(new Power
			{
				// TODO [BOTA_207] The Swap && Test: The Swap_BOTA_207
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_208] Demonic Research (*) - COST:8
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: This turn, your cards cost Health instead of Mana.
			// --------------------------------------------------------
			cards.Add("BOTA_208", new CardDef(new Power
			{
				// TODO [BOTA_208] Demonic Research && Test: Demonic Research_BOTA_208
				InfoCardId = "BOTA_208e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_232] Cosmic Projection (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Swap hands with your opponent.
			// --------------------------------------------------------
			cards.Add("BOTA_232", new CardDef(new Power
			{
				// TODO [BOTA_232] Cosmic Projection && Test: Cosmic Projection_BOTA_232
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_234] The Stars Align (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Arrange your minions by their Health.
			// --------------------------------------------------------
			cards.Add("BOTA_234", new CardDef(new Power
			{
				// TODO [BOTA_234] The Stars Align && Test: The Stars Align_BOTA_234
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_235] Unbeakered Lightning (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Deal $8 damage to all minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("BOTA_235", new CardDef(new Power
			{
				// TODO [BOTA_235] Unbeakered Lightning && Test: Unbeakered Lightning_BOTA_235
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_240] Back-up Plan (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Destroy all friendly minions.
			// --------------------------------------------------------
			cards.Add("BOTA_240", new CardDef(new Power
			{
				// TODO [BOTA_240] Back-up Plan && Test: Back-up Plan_BOTA_240
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_244] Ray of Roasting (*) - COST:10
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Deal 10 damage to all minions 10 times.
			// --------------------------------------------------------
			cards.Add("BOTA_244", new CardDef(new Power
			{
				// TODO [BOTA_244] Ray of Roasting && Test: Ray of Roasting_BOTA_244
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_301] Cold Blooded (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_301", new CardDef(new Power
			{
				// TODO [BOTA_301] Cold Blooded && Test: Cold Blooded_BOTA_301
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_302] Frostbite (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_302", new CardDef(new Power
			{
				// TODO [BOTA_302] Frostbite && Test: Frostbite_BOTA_302
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_303] Battle Boar (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_303", new CardDef(new Power
			{
				// TODO [BOTA_303] Battle Boar && Test: Battle Boar_BOTA_303
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_304] Stand By Me (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_304", new CardDef(new Power
			{
				// TODO [BOTA_304] Stand By Me && Test: Stand By Me_BOTA_304
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_305] Frothing Fighters (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_305", new CardDef(new Power
			{
				// TODO [BOTA_305] Frothing Fighters && Test: Frothing Fighters_BOTA_305
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_306] Leeroy Returns (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_306", new CardDef(new Power
			{
				// TODO [BOTA_306] Leeroy Returns && Test: Leeroy Returns_BOTA_306
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_307] Cosmic Fire (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_307", new CardDef(new Power
			{
				// TODO [BOTA_307] Cosmic Fire && Test: Cosmic Fire_BOTA_307
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_309] Quick and Quiet (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_309", new CardDef(new Power
			{
				// TODO [BOTA_309] Quick and Quiet && Test: Quick and Quiet_BOTA_309
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_310] Dinosaur Domination (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_310", new CardDef(new Power
			{
				// TODO [BOTA_310] Dinosaur Domination && Test: Dinosaur Domination_BOTA_310
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_311] Hot Potato (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_311", new CardDef(new Power
			{
				// TODO [BOTA_311] Hot Potato && Test: Hot Potato_BOTA_311
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_312] A Dim Flame (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_312", new CardDef(new Power
			{
				// TODO [BOTA_312] A Dim Flame && Test: A Dim Flame_BOTA_312
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_313] Lethal Lepers (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_313", new CardDef(new Power
			{
				// TODO [BOTA_313] Lethal Lepers && Test: Lethal Lepers_BOTA_313
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_314] Full Draw (*) - COST:8
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_314", new CardDef(new Power
			{
				// TODO [BOTA_314] Full Draw && Test: Full Draw_BOTA_314
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_315] Plan B (*) - COST:9
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-9.
			// --------------------------------------------------------
			cards.Add("BOTA_315", new CardDef(new Power
			{
				// TODO [BOTA_315] Plan B && Test: Plan B_BOTA_315
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_316] The Wall (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_316", new CardDef(new Power
			{
				// TODO [BOTA_316] The Wall && Test: The Wall_BOTA_316
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_317] Four Horsemen (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_317", new CardDef(new Power
			{
				// TODO [BOTA_317] Four Horsemen && Test: Four Horsemen_BOTA_317
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_318] Light and Fire (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_318", new CardDef(new Power
			{
				// TODO [BOTA_318] Light and Fire && Test: Light and Fire_BOTA_318
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_319] Hostile Hoppers (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_319", new CardDef(new Power
			{
				// TODO [BOTA_319] Hostile Hoppers && Test: Hostile Hoppers_BOTA_319
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_320] A Corrupted Spirit (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_320", new CardDef(new Power
			{
				// TODO [BOTA_320] A Corrupted Spirit && Test: A Corrupted Spirit_BOTA_320
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_321] The Best Offense (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_321", new CardDef(new Power
			{
				// TODO [BOTA_321] The Best Offense && Test: The Best Offense_BOTA_321
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_322] Healing Hammers (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_322", new CardDef(new Power
			{
				// TODO [BOTA_322] Healing Hammers && Test: Healing Hammers_BOTA_322
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_323] Toasted Hydra (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_323", new CardDef(new Power
			{
				// TODO [BOTA_323] Toasted Hydra && Test: Toasted Hydra_BOTA_323
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_324] C'Thun! C'Thun! C'THUN! (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-7.
			// --------------------------------------------------------
			cards.Add("BOTA_324", new CardDef(new Power
			{
				// TODO [BOTA_324] C'Thun! C'Thun! C'THUN! && Test: C'Thun! C'Thun! C'THUN!_BOTA_324
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_327] Tossing Taters (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_327", new CardDef(new Power
			{
				// TODO [BOTA_327] Tossing Taters && Test: Tossing Taters_BOTA_327
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_328] Pride's Fall (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_328", new CardDef(new Power
			{
				// TODO [BOTA_328] Pride's Fall && Test: Pride's Fall_BOTA_328
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_329] Keepers of the Gate (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_329", new CardDef(new Power
			{
				// TODO [BOTA_329] Keepers of the Gate && Test: Keepers of the Gate_BOTA_329
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_330] A Shaman's Strength (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_330", new CardDef(new Power
			{
				// TODO [BOTA_330] A Shaman's Strength && Test: A Shaman's Strength_BOTA_330
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_331] Selective Stampede (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_331", new CardDef(new Power
			{
				// TODO [BOTA_331] Selective Stampede && Test: Selective Stampede_BOTA_331
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_332] Spell Addiction (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-6.
			// --------------------------------------------------------
			cards.Add("BOTA_332", new CardDef(new Power
			{
				// TODO [BOTA_332] Spell Addiction && Test: Spell Addiction_BOTA_332
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_333] Of Pirates and Patrons (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_333", new CardDef(new Power
			{
				// TODO [BOTA_333] Of Pirates and Patrons && Test: Of Pirates and Patrons_BOTA_333
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_334] Erratic Explosive (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_334", new CardDef(new Power
			{
				// TODO [BOTA_334] Erratic Explosive && Test: Erratic Explosive_BOTA_334
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_336] Never Go Full Northshire (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_336", new CardDef(new Power
			{
				// TODO [BOTA_336] Never Go Full Northshire && Test: Never Go Full Northshire_BOTA_336
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_337] Full Northshire (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-4
			// --------------------------------------------------------
			cards.Add("BOTA_337", new CardDef(new Power
			{
				// TODO [BOTA_337] Full Northshire && Test: Full Northshire_BOTA_337
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_420] Quick Attack (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_420", new CardDef(new Power
			{
				// TODO [BOTA_420] Quick Attack && Test: Quick Attack_BOTA_420
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_421] Holy Extermination (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_421", new CardDef(new Power
			{
				// TODO [BOTA_421] Holy Extermination && Test: Holy Extermination_BOTA_421
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_422] Stomp the Snail (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_422", new CardDef(new Power
			{
				// TODO [BOTA_422] Stomp the Snail && Test: Stomp the Snail_BOTA_422
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_423] Sticky Scarecrows (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_423", new CardDef(new Power
			{
				// TODO [BOTA_423] Sticky Scarecrows && Test: Sticky Scarecrows_BOTA_423
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_424] The Power of Pigs (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_424", new CardDef(new Power
			{
				// TODO [BOTA_424] The Power of Pigs && Test: The Power of Pigs_BOTA_424
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_425] Position Perfection (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_425", new CardDef(new Power
			{
				// TODO [BOTA_425] Position Perfection && Test: Position Perfection_BOTA_425
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_426] Scorched Earth (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_426", new CardDef(new Power
			{
				// TODO [BOTA_426] Scorched Earth && Test: Scorched Earth_BOTA_426
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_427] Dragon Removal Service (*) - COST:8
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_427", new CardDef(new Power
			{
				// TODO [BOTA_427] Dragon Removal Service && Test: Dragon Removal Service_BOTA_427
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_429] Fighter's Finale (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_429", new CardDef(new Power
			{
				// TODO [BOTA_429] Fighter's Finale && Test: Fighter's Finale_BOTA_429
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_430] No More N'Zoth (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_430", new CardDef(new Power
			{
				// TODO [BOTA_430] No More N'Zoth && Test: No More N'Zoth_BOTA_430
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_431] Contamination! (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_431", new CardDef(new Power
			{
				// TODO [BOTA_431] Contamination! && Test: Contamination!_BOTA_431
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_432] A Stolen Shadow (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_432", new CardDef(new Power
			{
				// TODO [BOTA_432] A Stolen Shadow && Test: A Stolen Shadow_BOTA_432
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_433] Hurricane of Horrors (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_433", new CardDef(new Power
			{
				// TODO [BOTA_433] Hurricane of Horrors && Test: Hurricane of Horrors_BOTA_433
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_434] Curious Crustacean (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_434", new CardDef(new Power
			{
				// TODO [BOTA_434] Curious Crustacean && Test: Curious Crustacean_BOTA_434
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_435] Shocking Spells (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_435", new CardDef(new Power
			{
				// TODO [BOTA_435] Shocking Spells && Test: Shocking Spells_BOTA_435
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_437] Tiny Terrors (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_437", new CardDef(new Power
			{
				// TODO [BOTA_437] Tiny Terrors && Test: Tiny Terrors_BOTA_437
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_438] Defiling Demons (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_438", new CardDef(new Power
			{
				// TODO [BOTA_438] Defiling Demons && Test: Defiling Demons_BOTA_438
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_439] A Warrior's Weapons (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_439", new CardDef(new Power
			{
				// TODO [BOTA_439] A Warrior's Weapons && Test: A Warrior's Weapons_BOTA_439
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_440] Poultry Provoked (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_440", new CardDef(new Power
			{
				// TODO [BOTA_440] Poultry Provoked && Test: Poultry Provoked_BOTA_440
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_441] Bot Battle (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_441", new CardDef(new Power
			{
				// TODO [BOTA_441] Bot Battle && Test: Bot Battle_BOTA_441
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_444] Airborne Assault (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_444", new CardDef(new Power
			{
				// TODO [BOTA_444] Airborne Assault && Test: Airborne Assault_BOTA_444
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_445] Dog Days (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_445", new CardDef(new Power
			{
				// TODO [BOTA_445] Dog Days && Test: Dog Days_BOTA_445
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_446] Grumble's Rumble (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_446", new CardDef(new Power
			{
				// TODO [BOTA_446] Grumble's Rumble && Test: Grumble's Rumble_BOTA_446
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_447] Toxic Treants (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_447", new CardDef(new Power
			{
				// TODO [BOTA_447] Toxic Treants && Test: Toxic Treants_BOTA_447
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_448] A Dance with Death (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_448", new CardDef(new Power
			{
				// TODO [BOTA_448] A Dance with Death && Test: A Dance with Death_BOTA_448
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_450] A Storm of Souls (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_450", new CardDef(new Power
			{
				// TODO [BOTA_450] A Storm of Souls && Test: A Storm of Souls_BOTA_450
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_451] Plugging Away (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_451", new CardDef(new Power
			{
				// TODO [BOTA_451] Plugging Away && Test: Plugging Away_BOTA_451
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_452] Warlock's Apprentice (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_452", new CardDef(new Power
			{
				// TODO [BOTA_452] Warlock's Apprentice && Test: Warlock's Apprentice_BOTA_452
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_453] The Test (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_453", new CardDef(new Power
			{
				// TODO [BOTA_453] The Test && Test: The Test_BOTA_453
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_500] First Steps (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_500", new CardDef(new Power
			{
				// TODO [BOTA_500] First Steps && Test: First Steps_BOTA_500
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_501] Smoldering Shield (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_501", new CardDef(new Power
			{
				// TODO [BOTA_501] Smoldering Shield && Test: Smoldering Shield_BOTA_501
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_502] In a Flash (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_502", new CardDef(new Power
			{
				// TODO [BOTA_502] In a Flash && Test: In a Flash_BOTA_502
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_503] Adorable Sacrifice (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_503", new CardDef(new Power
			{
				// TODO [BOTA_503] Adorable Sacrifice && Test: Adorable Sacrifice_BOTA_503
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_504] Pursuit of Knowledge (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_504", new CardDef(new Power
			{
				// TODO [BOTA_504] Pursuit of Knowledge && Test: Pursuit of Knowledge_BOTA_504
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_505] Brazed Pork (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_505", new CardDef(new Power
			{
				// TODO [BOTA_505] Brazed Pork && Test: Brazed Pork_BOTA_505
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_506] Shields Up! (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_506", new CardDef(new Power
			{
				// TODO [BOTA_506] Shields Up! && Test: Shields Up!_BOTA_506
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_507] Three Odd Yetis (*) - COST:8
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_507", new CardDef(new Power
			{
				// TODO [BOTA_507] Three Odd Yetis && Test: Three Odd Yetis_BOTA_507
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_509] Loss and Gain (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_509", new CardDef(new Power
			{
				// TODO [BOTA_509] Loss and Gain && Test: Loss and Gain_BOTA_509
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_510] Explosive Assault (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_510", new CardDef(new Power
			{
				// TODO [BOTA_510] Explosive Assault && Test: Explosive Assault_BOTA_510
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_511] Dragonslayer (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_511", new CardDef(new Power
			{
				// TODO [BOTA_511] Dragonslayer && Test: Dragonslayer_BOTA_511
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_512] Nature's Wispers (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_512", new CardDef(new Power
			{
				// TODO [BOTA_512] Nature's Wispers && Test: Nature's Wispers_BOTA_512
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_513] Burning Volley (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_513", new CardDef(new Power
			{
				// TODO [BOTA_513] Burning Volley && Test: Burning Volley_BOTA_513
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_514] Divine Alignment (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_514", new CardDef(new Power
			{
				// TODO [BOTA_514] Divine Alignment && Test: Divine Alignment_BOTA_514
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_515] Aha! (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_515", new CardDef(new Power
			{
				// TODO [BOTA_515] Aha! && Test: Aha!_BOTA_515
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_516] Cruel Souls (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_516", new CardDef(new Power
			{
				// TODO [BOTA_516] Cruel Souls && Test: Cruel Souls_BOTA_516
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_517] Ride the Wave (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_517", new CardDef(new Power
			{
				// TODO [BOTA_517] Ride the Wave && Test: Ride the Wave_BOTA_517
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_518] Hello Darkness (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_518", new CardDef(new Power
			{
				// TODO [BOTA_518] Hello Darkness && Test: Hello Darkness_BOTA_518
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_519] The Ray of Roasting (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_519", new CardDef(new Power
			{
				// TODO [BOTA_519] The Ray of Roasting && Test: The Ray of Roasting_BOTA_519
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_520] The Ol' Switcheroo (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_520", new CardDef(new Power
			{
				// TODO [BOTA_520] The Ol' Switcheroo && Test: The Ol' Switcheroo_BOTA_520
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_521] It's in the Stars (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_521", new CardDef(new Power
			{
				// TODO [BOTA_521] It's in the Stars && Test: It's in the Stars_BOTA_521
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_522] Nether Side Up (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_522", new CardDef(new Power
			{
				// TODO [BOTA_522] Nether Side Up && Test: Nether Side Up_BOTA_522
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_524] A Quest for Three (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_524", new CardDef(new Power
			{
				// TODO [BOTA_524] A Quest for Three && Test: A Quest for Three_BOTA_524
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_525] Chilling Winds (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_525", new CardDef(new Power
			{
				// TODO [BOTA_525] Chilling Winds && Test: Chilling Winds_BOTA_525
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_526] Filthy Rodent (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_526", new CardDef(new Power
			{
				// TODO [BOTA_526] Filthy Rodent && Test: Filthy Rodent_BOTA_526
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_529] Noble Sacrifices (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_529", new CardDef(new Power
			{
				// TODO [BOTA_529] Noble Sacrifices && Test: Noble Sacrifices_BOTA_529
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_530] Shrinking Solutions (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_530", new CardDef(new Power
			{
				// TODO [BOTA_530] Shrinking Solutions && Test: Shrinking Solutions_BOTA_530
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_531] Perfect Patrons (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_531", new CardDef(new Power
			{
				// TODO [BOTA_531] Perfect Patrons && Test: Perfect Patrons_BOTA_531
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_532] Deathwing Dilemma (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_532", new CardDef(new Power
			{
				// TODO [BOTA_532] Deathwing Dilemma && Test: Deathwing Dilemma_BOTA_532
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_533] Infestation! (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_533", new CardDef(new Power
			{
				// TODO [BOTA_533] Infestation! && Test: Infestation!_BOTA_533
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_611] Don't Panic (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_611", new CardDef(new Power
			{
				// TODO [BOTA_611] Don't Panic && Test: Don't Panic_BOTA_611
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_612] A Gentle Touch (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_612", new CardDef(new Power
			{
				// TODO [BOTA_612] A Gentle Touch && Test: A Gentle Touch_BOTA_612
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_613] Cleansing Corruption (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_613", new CardDef(new Power
			{
				// TODO [BOTA_613] Cleansing Corruption && Test: Cleansing Corruption_BOTA_613
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_614] A Dire Situation (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_614", new CardDef(new Power
			{
				// TODO [BOTA_614] A Dire Situation && Test: A Dire Situation_BOTA_614
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_615] Double Dip (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_615", new CardDef(new Power
			{
				// TODO [BOTA_615] Double Dip && Test: Double Dip_BOTA_615
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_616] A Priest's Feast (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_616", new CardDef(new Power
			{
				// TODO [BOTA_616] A Priest's Feast && Test: A Priest's Feast_BOTA_616
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_617] Splash! (*) - COST:7
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_617", new CardDef(new Power
			{
				// TODO [BOTA_617] Splash! && Test: Splash!_BOTA_617
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_621] Up for Auction (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_621", new CardDef(new Power
			{
				// TODO [BOTA_621] Up for Auction && Test: Up for Auction_BOTA_621
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_622] Sowing Seeds (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_622", new CardDef(new Power
			{
				// TODO [BOTA_622] Sowing Seeds && Test: Sowing Seeds_BOTA_622
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_623] Mechanical Medic (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_623", new CardDef(new Power
			{
				// TODO [BOTA_623] Mechanical Medic && Test: Mechanical Medic_BOTA_623
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_624] Lifesteel (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_624", new CardDef(new Power
			{
				// TODO [BOTA_624] Lifesteel && Test: Lifesteel_BOTA_624
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_625] Double Trouble (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_625", new CardDef(new Power
			{
				// TODO [BOTA_625] Double Trouble && Test: Double Trouble_BOTA_625
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_626] Revived and Refreshed (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_626", new CardDef(new Power
			{
				// TODO [BOTA_626] Revived and Refreshed && Test: Revived and Refreshed_BOTA_626
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_631] That's the Spirit (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_631", new CardDef(new Power
			{
				// TODO [BOTA_631] That's the Spirit && Test: That's the Spirit_BOTA_631
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_632] Underhanded Dealing (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_632", new CardDef(new Power
			{
				// TODO [BOTA_632] Underhanded Dealing && Test: Underhanded Dealing_BOTA_632
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_633] Pesky Priest (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_633", new CardDef(new Power
			{
				// TODO [BOTA_633] Pesky Priest && Test: Pesky Priest_BOTA_633
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_634] Hallazeal? Hallaheal (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_634", new CardDef(new Power
			{
				// TODO [BOTA_634] Hallazeal? Hallaheal && Test: Hallazeal? Hallaheal_BOTA_634
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_635] Primal Investment (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_635", new CardDef(new Power
			{
				// TODO [BOTA_635] Primal Investment && Test: Primal Investment_BOTA_635
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_636] Healing Hands (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_636", new CardDef(new Power
			{
				// TODO [BOTA_636] Healing Hands && Test: Healing Hands_BOTA_636
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_641] Just Jaraxxus (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_641", new CardDef(new Power
			{
				// TODO [BOTA_641] Just Jaraxxus && Test: Just Jaraxxus_BOTA_641
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_642] Strike Me Down (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_642", new CardDef(new Power
			{
				// TODO [BOTA_642] Strike Me Down && Test: Strike Me Down_BOTA_642
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_643] For Me? (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_643", new CardDef(new Power
			{
				// TODO [BOTA_643] For Me? && Test: For Me?_BOTA_643
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_644] Risky Research (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_644", new CardDef(new Power
			{
				// TODO [BOTA_644] Risky Research && Test: Risky Research_BOTA_644
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_645] Tempting Demons (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_645", new CardDef(new Power
			{
				// TODO [BOTA_645] Tempting Demons && Test: Tempting Demons_BOTA_645
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_649] Mal'Ganis and Me (*) - COST:1
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_649", new CardDef(new Power
			{
				// TODO [BOTA_649] Mal'Ganis and Me && Test: Mal'Ganis and Me_BOTA_649
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_650] Sharing is Caring (*) - COST:2
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_650", new CardDef(new Power
			{
				// TODO [BOTA_650] Sharing is Caring && Test: Sharing is Caring_BOTA_650
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_651] The Path to Victory (*) - COST:3
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_651", new CardDef(new Power
			{
				// TODO [BOTA_651] The Path to Victory && Test: The Path to Victory_BOTA_651
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_652] Doomed! (*) - COST:4
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_652", new CardDef(new Power
			{
				// TODO [BOTA_652] Doomed! && Test: Doomed!_BOTA_652
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_653] Copycats (*) - COST:5
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-5.
			// --------------------------------------------------------
			cards.Add("BOTA_653", new CardDef(new Power
			{
				// TODO [BOTA_653] Copycats && Test: Copycats_BOTA_653
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_654] Fungal Frugality (*) - COST:6
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-6.
			// --------------------------------------------------------
			cards.Add("BOTA_654", new CardDef(new Power
			{
				// TODO [BOTA_654] Fungal Frugality && Test: Fungal Frugality_BOTA_654
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_655] Visions of Vitality (*) - COST:8
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_655", new CardDef(new Power
			{
				// TODO [BOTA_655] Visions of Vitality && Test: Visions of Vitality_BOTA_655
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_700] Mirror (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Match the boss's
			//       side of the
			//       battlefield exactly.
			// --------------------------------------------------------
			// GameTag:
			// - PUZZLE = 1
			// - PUZZLE_TYPE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_700", new CardDef(new Power
			{
				// TODO [BOTA_700] Mirror && Test: Mirror_BOTA_700
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_701] Survival (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Survive the boss's
			//       Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - PUZZLE = 1
			// - PUZZLE_TYPE = 3
			// --------------------------------------------------------
			cards.Add("BOTA_701", new CardDef(new Power
			{
				// TODO [BOTA_701] Survival && Test: Survival_BOTA_701
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_702] Lethal (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Destroy the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - PUZZLE = 1
			// - PUZZLE_TYPE = 2
			// --------------------------------------------------------
			cards.Add("BOTA_702", new CardDef(new Power
			{
				// TODO [BOTA_702] Lethal && Test: Lethal_BOTA_702
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_706] Board Clear (*) - COST:0
			// - Set: boomsday,
			// --------------------------------------------------------
			// Text: Clear the battlefield
			//       of all minions!
			// --------------------------------------------------------
			// GameTag:
			// - PUZZLE = 1
			// - PUZZLE_TYPE = 4
			// --------------------------------------------------------
			cards.Add("BOTA_706", new CardDef(new Power
			{
				// TODO [BOTA_706] Board Clear && Test: Board Clear_BOTA_706
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DruidNonCollect(cards);
			WarlockNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
