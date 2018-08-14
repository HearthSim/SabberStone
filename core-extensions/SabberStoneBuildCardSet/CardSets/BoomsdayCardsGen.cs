using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class BoomsdayCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - WARRIOR
			// [BOT_238] Dr. Boom, Mad Genius - COST:7 [ATK:0/HP:30] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For the rest of the game, your Mechs have <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 7
			// - HERO_POWER = 48145
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_238", new Power {
				// TODO [BOT_238] Dr. Boom, Mad Genius && Test: Dr. Boom, Mad Genius_BOT_238
				InfoCardId = "BOT_238e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- HERO - WHIZBANG
			// [BOT_914h] Whizbang the Wonderful (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, Rarity: free
			// --------------------------------------------------------
			cards.Add("BOT_914h", new Power {
				// TODO [BOT_914h] Whizbang the Wonderful && Test: Whizbang the Wonderful_BOT_914h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_01h2] Test Subject (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52176
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_01h2", new Power {
				// TODO [BOTA_BOSS_01h2] Test Subject && Test: Test Subject_BOTA_BOSS_01h2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_03h] Astromancer Arwyn (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52175
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_03h", new Power {
				// TODO [BOTA_BOSS_03h] Astromancer Arwyn && Test: Astromancer Arwyn_BOTA_BOSS_03h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_04h] Stargazer Luna (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52175
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_04h", new Power {
				// TODO [BOTA_BOSS_04h] Stargazer Luna && Test: Stargazer Luna_BOTA_BOSS_04h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_05h] Zerek, Master Cloner (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52176
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_05h", new Power {
				// TODO [BOTA_BOSS_05h] Zerek, Master Cloner && Test: Zerek, Master Cloner_BOTA_BOSS_05h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_06h] Dexter the Dendrologist (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52177
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_06h", new Power {
				// TODO [BOTA_BOSS_06h] Dexter the Dendrologist && Test: Dexter the Dendrologist_BOTA_BOSS_06h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_07h] Flobbidinous Floop (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52177
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_07h", new Power {
				// TODO [BOTA_BOSS_07h] Flobbidinous Floop && Test: Flobbidinous Floop_BOTA_BOSS_07h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_08h] Demonologist Draan (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52178
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_08h", new Power {
				// TODO [BOTA_BOSS_08h] Demonologist Draan && Test: Demonologist Draan_BOTA_BOSS_08h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_09h] Dr. Morrigan (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52178
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_09h", new Power {
				// TODO [BOTA_BOSS_09h] Dr. Morrigan && Test: Dr. Morrigan_BOTA_BOSS_09h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_10h] Poisonmaster Pollark (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52180
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_10h", new Power {
				// TODO [BOTA_BOSS_10h] Poisonmaster Pollark && Test: Poisonmaster Pollark_BOTA_BOSS_10h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_12h] Lil' Stormy (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52179
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_12h", new Power {
				// TODO [BOTA_BOSS_12h] Lil' Stormy && Test: Lil' Stormy_BOTA_BOSS_12h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_13h] Electra Stormsurge (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52179
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_13h", new Power {
				// TODO [BOTA_BOSS_13h] Electra Stormsurge && Test: Electra Stormsurge_BOTA_BOSS_13h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_14h] Myra Rotspring (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52180
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_14h", new Power {
				// TODO [BOTA_BOSS_14h] Myra Rotspring && Test: Myra Rotspring_BOTA_BOSS_14h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_15h] Boomnician Breena (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52181
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_15h", new Power {
				// TODO [BOTA_BOSS_15h] Boomnician Breena && Test: Boomnician Breena_BOTA_BOSS_15h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_16h] Boommaster Flark (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52182
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_16h", new Power {
				// TODO [BOTA_BOSS_16h] Boommaster Flark && Test: Boommaster Flark_BOTA_BOSS_16h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_17h] Glow-Tron 2000 (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52183
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_17h", new Power {
				// TODO [BOTA_BOSS_17h] Glow-Tron 2000 && Test: Glow-Tron 2000_BOTA_BOSS_17h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_18h] Crystalsmith Kangor (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 52184
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_18h", new Power {
				// TODO [BOTA_BOSS_18h] Crystalsmith Kangor && Test: Crystalsmith Kangor_BOTA_BOSS_18h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_20h] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47494
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20h", new Power {
				// TODO [BOTA_BOSS_20h] Dr. Boom && Test: Dr. Boom_BOTA_BOSS_20h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [BOTA_BOSS_20h2] Dr. Boom (*) - COST:0 [ATK:0/HP:30] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47494
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20h2", new Power {
				// TODO [BOTA_BOSS_20h2] Dr. Boom && Test: Dr. Boom_BOTA_BOSS_20h2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p] Big Red Button (*) - COST:2 
			// - Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Activate this turn's
			//       Mech Suit power!
			// --------------------------------------------------------
			// Entourage: BOT_238p1, BOT_238p2, BOT_238p3, BOT_238p4, BOT_238p6
			// --------------------------------------------------------
			cards.Add("BOT_238p", new Power {
				// TODO [BOT_238p] Big Red Button && Test: Big Red Button_BOT_238p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p1] Zap Cannon (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $3 damage.
			//       Swaps each turn. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BOT_238p1", new Power {
				// TODO [BOT_238p1] Zap Cannon && Test: Zap Cannon_BOT_238p1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p2] Blast Shield (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 7 Armor.
			//       Swaps each turn.
			// --------------------------------------------------------
			cards.Add("BOT_238p2", new Power {
				// TODO [BOT_238p2] Blast Shield && Test: Blast Shield_BOT_238p2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p3] KABOOM! (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $1 damage to all enemies. Swaps each turn. @spelldmg
			// --------------------------------------------------------
			cards.Add("BOT_238p3", new Power {
				// TODO [BOT_238p3] KABOOM! && Test: KABOOM!_BOT_238p3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p4] Delivery Drone (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a Mech.
			//       Swaps_each_turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// - GEARS = 1
			// --------------------------------------------------------
			cards.Add("BOT_238p4", new Power {
				// TODO [BOT_238p4] Delivery Drone && Test: Delivery Drone_BOT_238p4
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [BOT_238p6] Micro-Squad (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon three 1/1 Microbots.
			//       Swaps_each_turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_238p6", new Power {
				// TODO [BOT_238p6] Micro-Squad && Test: Micro-Squad_BOT_238p6
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_04p] Duality (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>There's symmetry in the stars.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_04p", new Power {
				// TODO [BOTA_BOSS_04p] Duality && Test: Duality_BOTA_BOSS_04p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_05p] Perfection (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>Everything must be perfect.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_05p", new Power {
				// TODO [BOTA_BOSS_05p] Perfection && Test: Perfection_BOTA_BOSS_05p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_07p] Gloop Sprayer (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>The most effective fertilizer this side of Outland.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_07p", new Power {
				// TODO [BOTA_BOSS_07p] Gloop Sprayer && Test: Gloop Sprayer_BOTA_BOSS_07p
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_BOSS_09p", new Power {
				// TODO [BOTA_BOSS_09p] Soul Battery && Test: Soul Battery_BOTA_BOSS_09p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_13p] Stormsurge (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>These puzzles are elementary.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_13p", new Power {
				// TODO [BOTA_BOSS_13p] Stormsurge && Test: Stormsurge_BOTA_BOSS_13p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_14p] Experimental Necrium (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>Good poisons work instantly.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_14p", new Power {
				// TODO [BOTA_BOSS_14p] Experimental Necrium && Test: Experimental Necrium_BOTA_BOSS_14p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_15p] Firework Volley (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_15p", new Power {
				// TODO [BOTA_BOSS_15p] Firework Volley && Test: Firework Volley_BOTA_BOSS_15p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_16p] Firework Barrage (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_16p", new Power {
				// TODO [BOTA_BOSS_16p] Firework Barrage && Test: Firework Barrage_BOTA_BOSS_16p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_17p] Glowing Laser (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 29
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_17p", new Power {
				// TODO [BOTA_BOSS_17p] Glowing Laser && Test: Glowing Laser_BOTA_BOSS_17p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_18p] Radiant Laser (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Heal to full to survive this experiment!
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 40
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_18p", new Power {
				// TODO [BOTA_BOSS_18p] Radiant Laser && Test: Radiant Laser_BOTA_BOSS_18p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p1] True Perfection (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>Have you ever seen such a magnificent reflection?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p1", new Power {
				// TODO [BOTA_BOSS_20p1] True Perfection && Test: True Perfection_BOTA_BOSS_20p1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p2] Fusion Core (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>Why stop at souls?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p2", new Power {
				// TODO [BOTA_BOSS_20p2] Fusion Core && Test: Fusion Core_BOTA_BOSS_20p2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BOTA_BOSS_20p3] Kadoom Bot (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <i>The fuse is lit.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("BOTA_BOSS_20p3", new Power {
				// TODO [BOTA_BOSS_20p3] Kadoom Bot && Test: Kadoom Bot_BOTA_BOSS_20p3
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_BOSS_20p4", new Power {
				// TODO [BOTA_BOSS_20p4] Death Ray && Test: Death Ray_BOTA_BOSS_20p4
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [BOT_419] Dendrologist - COST:2 [ATK:2/HP:3] 
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a Treant, <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_419", new Power {
				// TODO [BOT_419] Dendrologist && Test: Dendrologist_BOT_419
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BOT_422] Tending Tauren - COST:6 [ATK:3/HP:4] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Give your
			//       other minions +1/+1;
			//       or Summon two
			//       2/2 Treants.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("BOT_422", new Power {
				// TODO [BOT_422] Tending Tauren && Test: Tending Tauren_BOT_422
				InfoCardId = "BOT_422ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BOT_423] Dreampetal Florist - COST:7 [ATK:4/HP:4] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of a random minion in your hand by (7).
			// --------------------------------------------------------
			cards.Add("BOT_423", new Power {
				// TODO [BOT_423] Dreampetal Florist && Test: Dreampetal Florist_BOT_423
				InfoCardId = "BOT_423e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BOT_434] Flobbidinous Floop - COST:4 [ATK:3/HP:4] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: While in your hand, this is a 3/4 copy of the last minion you played.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_434", new Power {
				// TODO [BOT_434] Flobbidinous Floop && Test: Flobbidinous Floop_BOT_434
				InfoCardId = "BOT_434e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BOT_507] Gloop Sprayer - COST:8 [ATK:4/HP:4] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of each adjacent minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_507", new Power {
				// TODO [BOT_507] Gloop Sprayer && Test: Gloop Sprayer_BOT_507
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [BOT_523] Mulchmuncher - COST:10 [ATK:8/HP:8] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>. Costs (1) less for each friendly Treant that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_523", new Power {
				// TODO [BOT_523] Mulchmuncher && Test: Mulchmuncher_BOT_523
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_054] Biology Project - COST:1 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player gains 2_Mana Crystals.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_054", new Power {
				// TODO [BOT_054] Biology Project && Test: Biology Project_BOT_054
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_404] Juicy Psychmelon - COST:4 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a 7, 8, 9, and
			//       10-Cost minion
			//        from your deck.
			// --------------------------------------------------------
			cards.Add("BOT_404", new Power {
				// TODO [BOT_404] Juicy Psychmelon && Test: Juicy Psychmelon_BOT_404
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_420] Landscaping - COST:3 
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_420", new Power {
				// TODO [BOT_420] Landscaping && Test: Landscaping_BOT_420
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_444] Floop's Glorious Gloop - COST:1 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever a minion dies this turn, gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_444", new Power {
				// TODO [BOT_444] Floop's Glorious Gloop && Test: Floop's Glorious Gloop_BOT_444
				InfoCardId = "BOT_444e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_423e] Floral Arrangement (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Costs (7) less.
			// --------------------------------------------------------
			cards.Add("BOT_423e", new Power {
				// TODO [BOT_423e] Floral Arrangement && Test: Floral Arrangement_BOT_423e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_434e] Floopy (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Transforming into recent minions.
			// --------------------------------------------------------
			cards.Add("BOT_434e", new Power {
				// TODO [BOT_434e] Floopy && Test: Floopy_BOT_434e
				InfoCardId = "BOT_434e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_434e2] Floopy (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: 3/4.
			// --------------------------------------------------------
			cards.Add("BOT_434e2", new Power {
				// TODO [BOT_434e2] Floopy && Test: Floopy_BOT_434e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOT_444e] Gloopy (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Whenever a minion dies this turn, gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_444e", new Power {
				// TODO [BOT_444e] Gloopy && Test: Gloopy_BOT_444e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [BOTA_241e] Contaminated (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("BOTA_241e", new Power {
				// TODO [BOTA_241e] Contaminated && Test: Contaminated_BOTA_241e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_422a] Old Growth (*) - COST:0 
			// - Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			// Text: Give your other minions +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_422a", new Power {
				// TODO [BOT_422a] Old Growth && Test: Old Growth_BOT_422a
				InfoCardId = "BOT_422ae",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [BOT_422b] New Growth (*) - COST:0 
			// - Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			// Text: Summon two 2/2 Treants.
			// --------------------------------------------------------
			cards.Add("BOT_422b", new Power {
				// TODO [BOT_422b] New Growth && Test: New Growth_BOT_422b
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_241", new Power {
				// TODO [BOTA_241] Contamination && Test: Contamination_BOTA_241
				InfoCardId = "BOTA_241e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [BOT_034] Boommaster Flark - COST:7 [ATK:5/HP:5] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon four 0/2 Goblin Bombs.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_034", new Power {
				// TODO [BOT_034] Boommaster Flark && Test: Boommaster Flark_BOT_034
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [BOT_035] Venomizer - COST:2 [ATK:2/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_035", new Power {
				// TODO [BOT_035] Venomizer && Test: Venomizer_BOT_035
				InfoCardId = "BOT_035e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [BOT_038] Fireworks Tech - COST:2 [ATK:2/HP:1] 
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a friendly
			//       Mech +1/+1. If it has
			//       <b>Deathrattle</b>, trigger it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 17
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_038", new Power {
				// TODO [BOT_038] Fireworks Tech && Test: Fireworks Tech_BOT_038
				InfoCardId = "BOT_038e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [BOT_039] Necromechanic - COST:5 [ATK:3/HP:6] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Your <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_039", new Power {
				// TODO [BOT_039] Necromechanic && Test: Necromechanic_BOT_039
				InfoCardId = "BOT_039e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [BOT_251] Spider Bomb - COST:3 [ATK:2/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Deathrattle:</b> Destroy a random_enemy_minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_251", new Power {
				// TODO [BOT_251] Spider Bomb && Test: Spider Bomb_BOT_251
				InfoCardId = "BOT_251e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_033] Bomb Toss - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage. Summon a 0/2 Goblin_Bomb. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("BOT_033", new Power {
				// TODO [BOT_033] Bomb Toss && Test: Bomb Toss_BOT_033
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_402] Secret Plan - COST:1 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Secret</b>.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_402", new Power {
				// TODO [BOT_402] Secret Plan && Test: Secret Plan_BOT_402
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_429] Flark's Boom-Zooka - COST:8 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Summon 3 minions from
			//       your deck. They attack
			//       enemy minions, then die.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_429", new Power {
				// TODO [BOT_429] Flark's Boom-Zooka && Test: Flark's Boom-Zooka_BOT_429
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_437] Goblin Prank - COST:2 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a friendly minion +3/+3 and <b>Rush</b>. It_dies at end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_437", new Power {
				// TODO [BOT_437] Goblin Prank && Test: Goblin Prank_BOT_437
				InfoCardId = "BOT_437e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [BOT_438] Cybertech Chip - COST:2 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Add a random Mech to your_hand."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_438", new Power {
				// TODO [BOT_438] Cybertech Chip && Test: Cybertech Chip_BOT_438
				InfoCardId = "BOT_438e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_038e] Primed (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_038e", new Power {
				// TODO [BOT_038e] Primed && Test: Primed_BOT_038e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_251e] Spider Bomb (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Destroy a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_251e", new Power {
				// TODO [BOT_251e] Spider Bomb && Test: Spider Bomb_BOT_251e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [BOT_438e] Chipped (*) - COST:0 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Mech to your_hand.
			// --------------------------------------------------------
			cards.Add("BOT_438e", new Power {
				// TODO [BOT_438e] Chipped && Test: Chipped_BOT_438e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [BOT_103] Stargazer Luna - COST:3 [ATK:2/HP:4] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play the
			//       right-most card in your hand, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_103", new Power {
				// TODO [BOT_103] Stargazer Luna && Test: Stargazer Luna_BOT_103
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [BOT_256] Astromancer - COST:7 [ATK:5/HP:5] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       random minion with Cost
			//       equal to your hand size.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_256", new Power {
				// TODO [BOT_256] Astromancer && Test: Astromancer_BOT_256
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [BOT_531] Celestial Emissary - COST:2 [ATK:2/HP:1] 
			// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next spell_this turn has <b>Spell_Damage +2</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("BOT_531", new Power {
				// TODO [BOT_531] Celestial Emissary && Test: Celestial Emissary_BOT_531
				InfoCardId = "BOT_531e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [BOT_601] Meteorologist - COST:6 [ATK:3/HP:3] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For each card in your hand, deal 1 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_601", new Power {
				// TODO [BOT_601] Meteorologist && Test: Meteorologist_BOT_601
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [BOT_604] Cosmic Anomaly - COST:4 [ATK:4/HP:3] 
			// - Race: elemental, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("BOT_604", new Power {
				// TODO [BOT_604] Cosmic Anomaly && Test: Cosmic Anomaly_BOT_604
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BOT_101] Astral Rift - COST:2 
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random minions to your hand.
			// --------------------------------------------------------
			cards.Add("BOT_101", new Power {
				// TODO [BOT_101] Astral Rift && Test: Astral Rift_BOT_101
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BOT_254] Unexpected Results - COST:4 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon two random
			//       $2-Cost minions <i>(improved
			//       by <b>Spell Damage</b>)</i>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_254", new Power {
				// TODO [BOT_254] Unexpected Results && Test: Unexpected Results_BOT_254
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BOT_257] Luna's Pocket Galaxy - COST:7 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Change the Cost of minions in your
			//       deck to (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_257", new Power {
				// TODO [BOT_257] Luna's Pocket Galaxy && Test: Luna's Pocket Galaxy_BOT_257
				InfoCardId = "BOT_257e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BOT_453] Shooting Star - COST:1 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to a minion and the minions next to it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_453", new Power {
				// TODO [BOT_453] Shooting Star && Test: Shooting Star_BOT_453
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [BOT_600] Research Project - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player draws 2_cards.
			// --------------------------------------------------------
			cards.Add("BOT_600", new Power {
				// TODO [BOT_600] Research Project && Test: Research Project_BOT_600
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_257e] Starstruck (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("BOT_257e", new Power {
				// TODO [BOT_257e] Starstruck && Test: Starstruck_BOT_257e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_531e] Celestial Power (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> for your next spell this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_531e", new Power {
				// TODO [BOT_531e] Celestial Power && Test: Celestial Power_BOT_531e
				InfoCardId = "BOT_531e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [BOT_531e2] Celestial Power (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage +2</b> for your next spell this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_531e2", new Power {
				// TODO [BOT_531e2] Celestial Power && Test: Celestial Power_BOT_531e2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [BOT_236] Crystalsmith Kangor - COST:2 [ATK:1/HP:2] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>, <b>Lifesteal</b>
			//       Your healing is doubled.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_236", new Power {
				// TODO [BOT_236] Crystalsmith Kangor && Test: Crystalsmith Kangor_BOT_236
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [BOT_537] Mechano-Egg - COST:5 [ATK:0/HP:5] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon an 8/8 Robosaur.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_537", new Power {
				// TODO [BOT_537] Mechano-Egg && Test: Mechano-Egg_BOT_537
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [BOT_906] Glow-Tron - COST:1 [ATK:1/HP:3] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_906", new Power {
				// TODO [BOT_906] Glow-Tron && Test: Glow-Tron_BOT_906
				InfoCardId = "BOT_906e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [BOT_910] Glowstone Technician - COST:6 [ATK:3/HP:4] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_910", new Power {
				// TODO [BOT_910] Glowstone Technician && Test: Glowstone Technician_BOT_910
				InfoCardId = "BOT_910e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [BOT_911] Annoy-o-Module - COST:4 [ATK:2/HP:4] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Divine Shield</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_911", new Power {
				// TODO [BOT_911] Annoy-o-Module && Test: Annoy-o-Module_BOT_911
				InfoCardId = "BOT_911e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_234] Shrink Ray - COST:5 
			// - Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Set the Attack and Health of all minions
			//       to 1.
			// --------------------------------------------------------
			cards.Add("BOT_234", new Power {
				// TODO [BOT_234] Shrink Ray && Test: Shrink Ray_BOT_234
				InfoCardId = "BOT_234e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_436] Prismatic Lens - COST:4 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw a minion and a spell from your deck. Swap their Costs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_436", new Power {
				// TODO [BOT_436] Prismatic Lens && Test: Prismatic Lens_BOT_436
				InfoCardId = "BOT_436e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_908] Autodefense Matrix - COST:1 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, give it <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_908", new Power {
				// TODO [BOT_908] Autodefense Matrix && Test: Autodefense Matrix_BOT_908
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_909] Crystology - COST:2 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Draw two 1-Attack
			//       minions from your deck.
			// --------------------------------------------------------
			cards.Add("BOT_909", new Power {
				// TODO [BOT_909] Crystology && Test: Crystology_BOT_909
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [BOT_912] Kangor's Endless Army - COST:7 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Resurrect 3 friendly Mechs. They keep any <b>Magnetic</b> upgrades.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 17
			// --------------------------------------------------------
			// RefTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_912", new Power {
				// TODO [BOT_912] Kangor's Endless Army && Test: Kangor's Endless Army_BOT_912
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_436e] Swapped Cost (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Cost swapped.
			// --------------------------------------------------------
			cards.Add("BOT_436e", new Power {
				// TODO [BOT_436e] Swapped Cost && Test: Swapped Cost_BOT_436e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_910e] Light Infused (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_910e", new Power {
				// TODO [BOT_910e] Light Infused && Test: Light Infused_BOT_910e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [BOT_911e] Annoy-o-Module (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>, <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_911e", new Power {
				// TODO [BOT_911e] Annoy-o-Module && Test: Annoy-o-Module_BOT_911e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [BOT_537t] Robosaur (*) - COST:8 [ATK:8/HP:8] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			cards.Add("BOT_537t", new Power {
				// TODO [BOT_537t] Robosaur && Test: Robosaur_BOT_537t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [BOT_216] Omega Medic - COST:3 [ATK:3/HP:4] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 10 Mana Crystals, restore #10 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_216", new Power {
				// TODO [BOT_216] Omega Medic && Test: Omega Medic_BOT_216
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [BOT_258] Zerek, Master Cloner - COST:6 [ATK:5/HP:5] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If you've cast any spells on this minion, resummon it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 537 = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_258", new Power {
				// TODO [BOT_258] Zerek, Master Cloner && Test: Zerek, Master Cloner_BOT_258
				InfoCardId = "BOT_258e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [BOT_509] Dead Ringer - COST:2 [ATK:2/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a <b>Deathrattle</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_509", new Power {
				// TODO [BOT_509] Dead Ringer && Test: Dead Ringer_BOT_509
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [BOT_558] Test Subject - COST:1 [ATK:0/HP:2] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Return any
			//       spells you cast on this
			//       minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 537 = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_558", new Power {
				// TODO [BOT_558] Test Subject && Test: Test Subject_BOT_558
				InfoCardId = "BOT_558e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [BOT_566] Reckless Experimenter - COST:5 [ATK:4/HP:6] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle</b> minions you
			//       play cost (3) less, but die
			//       at the end of the turn.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_566", new Power {
				// TODO [BOT_566] Reckless Experimenter && Test: Reckless Experimenter_BOT_566
				InfoCardId = "BOT_566e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_219] Extra Arms - COST:3 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2.
			//       Add 'More Arms!' to your
			//       hand that gives +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_219", new Power {
				// TODO [BOT_219] Extra Arms && Test: Extra Arms_BOT_219
				InfoCardId = "BOT_219e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_435] Cloning Device - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a copy of a minion in your opponent's deck.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_435", new Power {
				// TODO [BOT_435] Cloning Device && Test: Cloning Device_BOT_435
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_517] Topsy Turvy - COST:0 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_517", new Power {
				// TODO [BOT_517] Topsy Turvy && Test: Topsy Turvy_BOT_517
				InfoCardId = "BOT_517e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_529] Power Word: Replicate - COST:5 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Summon a 5/5 copy of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_529", new Power {
				// TODO [BOT_529] Power Word: Replicate && Test: Power Word: Replicate_BOT_529
				InfoCardId = "BOT_529e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_567] Zerek's Cloning Gallery - COST:9 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Summon a 1/1 copy of_each minion in your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_567", new Power {
				// TODO [BOT_567] Zerek's Cloning Gallery && Test: Zerek's Cloning Gallery_BOT_567
				InfoCardId = "BOT_567e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_219e] Armed (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_219e", new Power {
				// TODO [BOT_219e] Armed && Test: Armed_BOT_219e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_219te] More Armed (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_219te", new Power {
				// TODO [BOT_219te] More Armed && Test: More Armed_BOT_219te
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_258e] Cloning Vector (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Prepared to summon Zerek, Master Cloner
			// --------------------------------------------------------
			cards.Add("BOT_258e", new Power {
				// TODO [BOT_258e] Cloning Vector && Test: Cloning Vector_BOT_258e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_529e] Replicated (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: 5/5.
			// --------------------------------------------------------
			cards.Add("BOT_529e", new Power {
				// TODO [BOT_529e] Replicated && Test: Replicated_BOT_529e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_558e] Stored Data (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Storing spell.
			// --------------------------------------------------------
			cards.Add("BOT_558e", new Power {
				// TODO [BOT_558e] Stored Data && Test: Stored Data_BOT_558e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_566e] Reckless Experiment (*) - COST:0 
			// - Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			// Text: This minion will die a reckless death at the end of the turn.
			// --------------------------------------------------------
			cards.Add("BOT_566e", new Power {
				// TODO [BOT_566e] Reckless Experiment && Test: Reckless Experiment_BOT_566e
				InfoCardId = "BOT_566e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_566e2] Reckless Experiment (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Costs (3) less.
			// --------------------------------------------------------
			cards.Add("BOT_566e2", new Power {
				// TODO [BOT_566e2] Reckless Experiment && Test: Reckless Experiment_BOT_566e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [BOT_567e] Cloned (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_567e", new Power {
				// TODO [BOT_567e] Cloned && Test: Cloned_BOT_567e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [BOT_219t] More Arms! (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Give a minion +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_219t", new Power {
				// TODO [BOT_219t] More Arms! && Test: More Arms!_BOT_219t
				InfoCardId = "BOT_219te",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [BOT_243] Myra Rotspring - COST:5 [ATK:4/HP:2] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       <b>Deathrattle</b> minion. Also
			//       gain its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_243", new Power {
				// TODO [BOT_243] Myra Rotspring && Test: Myra Rotspring_BOT_243
				InfoCardId = "BOT_243e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [BOT_283] Pogo-Hopper - COST:2 [ATK:1/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +2/+2 for
			//       each other Pogo-Hopper
			//       you played this game.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_283", new Power {
				// TODO [BOT_283] Pogo-Hopper && Test: Pogo-Hopper_BOT_283
				InfoCardId = "BOT_283e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [BOT_288] Lab Recruiter - COST:2 [ATK:3/HP:2] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle 3 copies of a friendly minion into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_288", new Power {
				// TODO [BOT_288] Lab Recruiter && Test: Lab Recruiter_BOT_288
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [BOT_565] Blightnozzle Crawler - COST:4 [ATK:2/HP:4] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Ooze with <b>Poisonous</b> and <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_565", new Power {
				// TODO [BOT_565] Blightnozzle Crawler && Test: Blightnozzle Crawler_BOT_565
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [BOT_576] Crazed Chemist - COST:5 [ATK:4/HP:4] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give a friendly minion +4 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_576", new Power {
				// TODO [BOT_576] Crazed Chemist && Test: Crazed Chemist_BOT_576
				InfoCardId = "BOT_576e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_084] Violet Haze - COST:3 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Add 2 random <b>Deathrattle</b> cards to_your hand.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_084", new Power {
				// TODO [BOT_084] Violet Haze && Test: Violet Haze_BOT_084
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_087] Academic Espionage - COST:4 
			// - Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 10 cards from your opponent's class into your deck. They_cost (1).
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_087", new Power {
				// TODO [BOT_087] Academic Espionage && Test: Academic Espionage_BOT_087
				InfoCardId = "BOT_087e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_242] Myra's Unstable Element - COST:5 
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Draw the rest of
			//       your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_242", new Power {
				// TODO [BOT_242] Myra's Unstable Element && Test: Myra's Unstable Element_BOT_242
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [BOT_508] Necrium Vial - COST:5 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Trigger a friendly minion's <b>Deathrattle</b> twice.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_508", new Power {
				// TODO [BOT_508] Necrium Vial && Test: Necrium Vial_BOT_508
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [BOT_286] Necrium Blade - COST:3 [ATK:3/HP:0] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Trigger the <b>Deathrattle</b> of a random friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_286", new Power {
				// TODO [BOT_286] Necrium Blade && Test: Necrium Blade_BOT_286
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_087e] Academic Espionage (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("BOT_087e", new Power {
				// TODO [BOT_087e] Academic Espionage && Test: Academic Espionage_BOT_087e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_243e] Necroalchemy (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("BOT_243e", new Power {
				// TODO [BOT_243e] Necroalchemy && Test: Necroalchemy_BOT_243e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_283e] Kinetic Energy (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("BOT_283e", new Power {
				// TODO [BOT_283e] Kinetic Energy && Test: Kinetic Energy_BOT_283e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [BOT_576e] Overcharged (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +4 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_576e", new Power {
				// TODO [BOT_576e] Overcharged && Test: Overcharged_BOT_576e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [BOT_565t] Radioactive Ooze (*) - COST:1 [ATK:1/HP:1] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_565t", new Power {
				// TODO [BOT_565t] Radioactive Ooze && Test: Radioactive Ooze_BOT_565t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [BOT_291] Storm Chaser - COST:4 [ATK:3/HP:4] 
			// - Race: elemental, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a spell from your deck that costs_(5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_291", new Power {
				// TODO [BOT_291] Storm Chaser && Test: Storm Chaser_BOT_291
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_407] Thunderhead - COST:4 [ATK:3/HP:5] 
			// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After you play a card with
			//       <b>Overload</b>, summon two
			//       1/1 Sparks with <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_407", new Power {
				// TODO [BOT_407] Thunderhead && Test: Thunderhead_BOT_407
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_411] Electra Stormsurge - COST:3 [ATK:3/HP:3] 
			// - Race: elemental, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_411", new Power {
				// TODO [BOT_411] Electra Stormsurge && Test: Electra Stormsurge_BOT_411
				InfoCardId = "BOT_411e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_533] Menacing Nimbus - COST:2 [ATK:2/HP:2] 
			// - Race: elemental, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Elemental to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_533", new Power {
				// TODO [BOT_533] Menacing Nimbus && Test: Menacing Nimbus_BOT_533
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [BOT_543] Omega Mind - COST:2 [ATK:2/HP:3] 
			// - Fac: neutral, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, your spells
			//        have <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_543", new Power {
				// TODO [BOT_543] Omega Mind && Test: Omega Mind_BOT_543
				InfoCardId = "BOT_543e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_093] Elementary Reaction - COST:2 
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card. Copy it if_you played an Elemental last turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			cards.Add("BOT_093", new Power {
				// TODO [BOT_093] Elementary Reaction && Test: Elementary Reaction_BOT_093
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_099] Eureka! - COST:6 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a copy of_a_random minion from your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_099", new Power {
				// TODO [BOT_099] Eureka! && Test: Eureka!_BOT_099
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_245] The Storm Bringer - COST:7 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Transform your minions into random <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_245", new Power {
				// TODO [BOT_245] The Storm Bringer && Test: The Storm Bringer_BOT_245
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_246] Beakered Lightning - COST:0 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. <b>Overload:</b> (2) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 2
			// - OVERLOAD_OWED = 2
			// --------------------------------------------------------
			cards.Add("BOT_246", new Power {
				// TODO [BOT_246] Beakered Lightning && Test: Beakered Lightning_BOT_246
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [BOT_451] Voltaic Burst - COST:1 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 1/1 Sparks with <b>Rush</b>. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_451", new Power {
				// TODO [BOT_451] Voltaic Burst && Test: Voltaic Burst_BOT_451
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BOT_411e] Electric (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_411e", new Power {
				// TODO [BOT_411e] Electric && Test: Electric_BOT_411e
				InfoCardId = "BOT_411e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [BOT_411e2] Electricking (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your next spell this turn casts twice.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_411e2", new Power {
				// TODO [BOT_411e2] Electricking && Test: Electricking_BOT_411e2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [BOT_224] Doubling Imp - COST:3 [ATK:2/HP:2] 
			// - Race: demon, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_224", new Power {
				// TODO [BOT_224] Doubling Imp && Test: Doubling Imp_BOT_224
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [BOT_226] Nethersoul Buster - COST:3 [ATK:1/HP:5] 
			// - Race: demon, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1 Attack for each damage your hero has taken this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_226", new Power {
				// TODO [BOT_226] Nethersoul Buster && Test: Nethersoul Buster_BOT_226
				InfoCardId = "BOT_226e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [BOT_433] Dr. Morrigan - COST:8 [ATK:5/HP:5] 
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Swap this with a minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("BOT_433", new Power {
				// TODO [BOT_433] Dr. Morrigan && Test: Dr. Morrigan_BOT_433
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [BOT_443] Void Analyst - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all Demons in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_443", new Power {
				// TODO [BOT_443] Void Analyst && Test: Void Analyst_BOT_443
				InfoCardId = "BOT_443e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [BOT_536] Omega Agent - COST:5 [ATK:4/HP:5] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you have 10
			//       Mana Crystals, summon
			//       _2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_536", new Power {
				// TODO [BOT_536] Omega Agent && Test: Omega Agent_BOT_536
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_222] Spirit Bomb - COST:2 
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion and your hero. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_222", new Power {
				// TODO [BOT_222] Spirit Bomb && Test: Spirit Bomb_BOT_222
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_263] Soul Infusion - COST:1 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Give the
			//       left-most minion in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_263", new Power {
				// TODO [BOT_263] Soul Infusion && Test: Soul Infusion_BOT_263
				InfoCardId = "BOT_263e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_521] Ectomancy - COST:6 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon copies of all Demons you control.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BOT_521", new Power {
				// TODO [BOT_521] Ectomancy && Test: Ectomancy_BOT_521
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_568] The Soularium - COST:1 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			//       At the end of your turn, discard them.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BOT_568", new Power {
				// TODO [BOT_568] The Soularium && Test: The Soularium_BOT_568
				InfoCardId = "BOT_568e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [BOT_913] Demonic Project - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player transforms a random minion in their hand into a Demon.
			// --------------------------------------------------------
			cards.Add("BOT_913", new Power {
				// TODO [BOT_913] Demonic Project && Test: Demonic Project_BOT_913
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_226e] Nethercharged (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("BOT_226e", new Power {
				// TODO [BOT_226e] Nethercharged && Test: Nethercharged_BOT_226e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_263e] Infused (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("BOT_263e", new Power {
				// TODO [BOT_263e] Infused && Test: Infused_BOT_263e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_443e] Well-Studied (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1/+1 from Void Analyst.
			// --------------------------------------------------------
			cards.Add("BOT_443e", new Power {
				// TODO [BOT_443e] Well-Studied && Test: Well-Studied_BOT_443e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [BOT_568e] Fleeting Soul (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Discards at the end of your turn.
			// --------------------------------------------------------
			cards.Add("BOT_568e", new Power {
				// TODO [BOT_568e] Fleeting Soul && Test: Fleeting Soul_BOT_568e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [BOTA_603] Soul Repressor (*) - COST:3 [ATK:0/HP:4] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put the lowest Cost Demon from your hand into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_603", new Power {
				// TODO [BOTA_603] Soul Repressor && Test: Soul Repressor_BOTA_603
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_601", new Power {
				// TODO [BOTA_601] Phasing Portal && Test: Phasing Portal_BOTA_601
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [BOT_059] Eternium Rover - COST:1 [ATK:1/HP:3] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, gain 2_Armor.
			// --------------------------------------------------------
			cards.Add("BOT_059", new Power {
				// TODO [BOT_059] Eternium Rover && Test: Eternium Rover_BOT_059
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [BOT_104] Dyn-o-matic - COST:5 [ATK:3/HP:4] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 5 damage randomly split among all minions_except_Mechs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_104", new Power {
				// TODO [BOT_104] Dyn-o-matic && Test: Dyn-o-matic_BOT_104
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [BOT_218] Security Rover - COST:6 [ATK:2/HP:5] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       takes damage, summon a
			//       2/3 Mech with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BOT_218", new Power {
				// TODO [BOT_218] Security Rover && Test: Security Rover_BOT_218
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [BOT_237] Beryllium Nullifier - COST:7 [ATK:3/HP:8] 
			// - Race: mechanical, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_237", new Power {
				// TODO [BOT_237] Beryllium Nullifier && Test: Beryllium Nullifier_BOT_237
				InfoCardId = "BOT_237e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_042] Weapons Project - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Each player equips a 2/3 Weapon and
			//       gains 6 Armor.
			// --------------------------------------------------------
			cards.Add("BOT_042", new Power {
				// TODO [BOT_042] Weapons Project && Test: Weapons Project_BOT_042
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_067] Rocket Boots - COST:2 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion <b>Rush</b>. Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_067", new Power {
				// TODO [BOT_067] Rocket Boots && Test: Rocket Boots_BOT_067
				InfoCardId = "BOT_067e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_069] The Boomship - COST:9 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: Summon 3 random minions from your hand. Give them <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_069", new Power {
				// TODO [BOT_069] The Boomship && Test: The Boomship_BOT_069
				InfoCardId = "BOT_069e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [BOT_299] Omega Assembly - COST:1 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Discover</b> a Mech. If you
			//       have 10 Mana Crystals,
			//       keep all 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// RefTag:
			// - GEARS = 1
			// --------------------------------------------------------
			cards.Add("BOT_299", new Power {
				// TODO [BOT_299] Omega Assembly && Test: Omega Assembly_BOT_299
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [BOT_406] Supercollider - COST:5 [ATK:1/HP:0] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After you attack a minion,
			//       force it to attack one
			//       of its neighbors.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("BOT_406", new Power {
				// TODO [BOT_406] Supercollider && Test: Supercollider_BOT_406
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [BOT_067e] Rocket Boots (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("BOT_067e", new Power {
				// TODO [BOT_067e] Rocket Boots && Test: Rocket Boots_BOT_067e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [BOT_069e] Rocketeer (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("BOT_069e", new Power {
				// TODO [BOT_069e] Rocketeer && Test: Rocketeer_BOT_069e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [BOT_218t] Guard Bot (*) - COST:2 [ATK:2/HP:3] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BOT_218t", new Power {
				// TODO [BOT_218t] Guard Bot && Test: Guard Bot_BOT_218t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [BOT_042t] Gearblade (*) - COST:2 [ATK:2/HP:0] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("BOT_042t", new Power {
				// TODO [BOT_042t] Gearblade && Test: Gearblade_BOT_042t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [BOT_020] Skaterbot - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_020", new Power {
				// TODO [BOT_020] Skaterbot && Test: Skaterbot_BOT_020
				InfoCardId = "BOT_020e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_021] Bronze Gatekeeper - COST:3 [ATK:1/HP:5] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_021", new Power {
				// TODO [BOT_021] Bronze Gatekeeper && Test: Bronze Gatekeeper_BOT_021
				InfoCardId = "BOT_021e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_031] Goblin Bomb - COST:1 [ATK:0/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Deal 2 damage
			//       to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_031", new Power {
				// TODO [BOT_031] Goblin Bomb && Test: Goblin Bomb_BOT_031
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_050] Rusty Recycler - COST:5 [ATK:2/HP:6] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("BOT_050", new Power {
				// TODO [BOT_050] Rusty Recycler && Test: Rusty Recycler_BOT_050
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_066] Mechanical Whelp - COST:6 [ATK:2/HP:2] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 7/7 Mechanical Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_066", new Power {
				// TODO [BOT_066] Mechanical Whelp && Test: Mechanical Whelp_BOT_066
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_079] Faithful Lumi - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_079", new Power {
				// TODO [BOT_079] Faithful Lumi && Test: Faithful Lumi_BOT_079
				InfoCardId = "BOT_079e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_083] Toxicologist - COST:2 [ATK:2/HP:2] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_083", new Power {
				// TODO [BOT_083] Toxicologist && Test: Toxicologist_BOT_083
				InfoCardId = "BOT_083e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_098] Unpowered Mauler - COST:2 [ATK:2/HP:4] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: Can only attack if you cast a spell this turn.
			// --------------------------------------------------------
			cards.Add("BOT_098", new Power {
				// TODO [BOT_098] Unpowered Mauler && Test: Unpowered Mauler_BOT_098
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_102] Spark Drill - COST:6 [ATK:5/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Add two
			//       1/1 Sparks with <b>Rush</b> to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_102", new Power {
				// TODO [BOT_102] Spark Drill && Test: Spark Drill_BOT_102
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_107] Missile Launcher - COST:6 [ATK:4/HP:4] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Magnetic</b>
			//       At the end of your turn,
			//       deal 1 damage to all
			//       other characters.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_107", new Power {
				// TODO [BOT_107] Missile Launcher && Test: Missile Launcher_BOT_107
				InfoCardId = "BOT_107e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_267] Piloted Reaper - COST:4 [ATK:4/HP:3] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random minion from
			//       your hand that costs (2) or less.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_267", new Power {
				// TODO [BOT_267] Piloted Reaper && Test: Piloted Reaper_BOT_267
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_270] Giggling Inventor - COST:5 [ATK:2/HP:1] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/2 Mechs with <b>Taunt</b> and_<b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_270", new Power {
				// TODO [BOT_270] Giggling Inventor && Test: Giggling Inventor_BOT_270
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_280] Holomancer - COST:5 [ATK:3/HP:3] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: After your opponent plays a minion, summon a 1/1_copy of it.
			// --------------------------------------------------------
			cards.Add("BOT_280", new Power {
				// TODO [BOT_280] Holomancer && Test: Holomancer_BOT_280
				InfoCardId = "BOT_280e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_296] Omega Defender - COST:4 [ATK:2/HP:6] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> If you have
			//       10 Mana Crystals,
			//       gain +10 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_296", new Power {
				// TODO [BOT_296] Omega Defender && Test: Omega Defender_BOT_296
				InfoCardId = "BOT_296e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_308] Spring Rocket - COST:3 [ATK:2/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("BOT_308", new Power {
				// TODO [BOT_308] Spring Rocket && Test: Spring Rocket_BOT_308
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_309] Upgradeable Framebot - COST:2 [ATK:1/HP:5] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			cards.Add("BOT_309", new Power {
				// TODO [BOT_309] Upgradeable Framebot && Test: Upgradeable Framebot_BOT_309
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_312] Replicating Menace - COST:4 [ATK:3/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b>Deathrattle:</b> Summon three 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - MODULAR = 1
			// - 853 = 48548
			// --------------------------------------------------------
			cards.Add("BOT_312", new Power {
				// TODO [BOT_312] Replicating Menace && Test: Replicating Menace_BOT_312
				InfoCardId = "BOT_312e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_401] Weaponized Piñata - COST:4 [ATK:4/HP:3] 
			// - Race: mechanical, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Legendary</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_401", new Power {
				// TODO [BOT_401] Weaponized Piñata && Test: Weaponized Piñata_BOT_401
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_413] Brainstormer - COST:3 [ATK:3/HP:1] 
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain +1 Health
			//       for each spell in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_413", new Power {
				// TODO [BOT_413] Brainstormer && Test: Brainstormer_BOT_413
				InfoCardId = "BOT_413e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_414] Cloakscale Chemist - COST:2 [ATK:1/HP:2] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_414", new Power {
				// TODO [BOT_414] Cloakscale Chemist && Test: Cloakscale Chemist_BOT_414
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_424] Mecha'thun - COST:10 [ATK:10/HP:10] 
			// - Race: mechanical, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> If you have no
			//       cards in your deck, hand,
			//       and battlefield, destroy
			//       the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_424", new Power {
				// TODO [BOT_424] Mecha'thun && Test: Mecha'thun_BOT_424
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_431] Whirliglider - COST:2 [ATK:2/HP:1] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/2_Goblin Bomb.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_431", new Power {
				// TODO [BOT_431] Whirliglider && Test: Whirliglider_BOT_431
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_445] Mecharoo - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 Jo-E Bot.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_445", new Power {
				// TODO [BOT_445] Mecharoo && Test: Mecharoo_BOT_445
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_447] Crystallizer - COST:1 [ATK:1/HP:3] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 5 damage
			//       to your hero. Gain 5 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_447", new Power {
				// TODO [BOT_447] Crystallizer && Test: Crystallizer_BOT_447
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_448] Damaged Stegotron - COST:6 [ATK:5/HP:12] 
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Deal 6 damage to this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_448", new Power {
				// TODO [BOT_448] Damaged Stegotron && Test: Damaged Stegotron_BOT_448
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_511] Seaforium Bomber - COST:5 [ATK:5/HP:5] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
			//       into your opponent's deck.
			//       When drawn, it explodes
			//       for 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_511", new Power {
				// TODO [BOT_511] Seaforium Bomber && Test: Seaforium Bomber_BOT_511
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_532] Explodinator - COST:4 [ATK:3/HP:2] 
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 0/2 Goblin Bombs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_532", new Power {
				// TODO [BOT_532] Explodinator && Test: Explodinator_BOT_532
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_534] Bull Dozer - COST:9 [ATK:9/HP:7] 
			// - Race: mechanical, Fac: alliance, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_534", new Power {
				// TODO [BOT_534] Bull Dozer && Test: Bull Dozer_BOT_534
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_535] Microtech Controller - COST:3 [ATK:2/HP:1] 
			// - Fac: neutral, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_535", new Power {
				// TODO [BOT_535] Microtech Controller && Test: Microtech Controller_BOT_535
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_538] Spark Engine - COST:2 [ATK:2/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a 
			//       1/1 Spark with <b>Rush</b> to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_538", new Power {
				// TODO [BOT_538] Spark Engine && Test: Spark Engine_BOT_538
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_539] Arcane Dynamo - COST:6 [ATK:3/HP:4] 
			// - Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a spell that costs (5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("BOT_539", new Power {
				// TODO [BOT_539] Arcane Dynamo && Test: Arcane Dynamo_BOT_539
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_540] E.M.P. Operative - COST:5 [ATK:3/HP:3] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a Mech.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 17
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BOT_540", new Power {
				// TODO [BOT_540] E.M.P. Operative && Test: E.M.P. Operative_BOT_540
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_544] Loose Specimen - COST:5 [ATK:6/HP:6] 
			// - Race: beast, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage randomly split among other friendly minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_544", new Power {
				// TODO [BOT_544] Loose Specimen && Test: Loose Specimen_BOT_544
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_548] Zilliax - COST:5 [ATK:3/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			//       <b><b>Divine Shield</b>, <b>Taunt</b>, Lifesteal, Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_548", new Power {
				// TODO [BOT_548] Zilliax && Test: Zilliax_BOT_548
				InfoCardId = "BOT_548e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_550] Electrowright - COST:3 [ATK:3/HP:3] 
			// - Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_550", new Power {
				// TODO [BOT_550] Electrowright && Test: Electrowright_BOT_550
				InfoCardId = "BOT_550e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_552] Star Aligner - COST:7 [ATK:7/HP:7] 
			// - Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control 3
			//       minions with 7 Health, deal
			//       7 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_552", new Power {
				// TODO [BOT_552] Star Aligner && Test: Star Aligner_BOT_552
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_555] Harbinger Celestia - COST:4 [ATK:5/HP:6] 
			// - Fac: neutral, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       After your opponent plays
			//       a minion, become a
			//       copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("BOT_555", new Power {
				// TODO [BOT_555] Harbinger Celestia && Test: Harbinger Celestia_BOT_555
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_559] Augmented Elekk - COST:3 [ATK:3/HP:4] 
			// - Race: beast, Set: boomsday, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you shuffle a card into a deck, shuffle in_an extra copy.
			// --------------------------------------------------------
			cards.Add("BOT_559", new Power {
				// TODO [BOT_559] Augmented Elekk && Test: Augmented Elekk_BOT_559
				InfoCardId = "BOT_559e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_562] Coppertail Imposter - COST:4 [ATK:4/HP:4] 
			// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("BOT_562", new Power {
				// TODO [BOT_562] Coppertail Imposter && Test: Coppertail Imposter_BOT_562
				InfoCardId = "BOT_562e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_563] Wargear - COST:5 [ATK:5/HP:5] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Magnetic</b>
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// --------------------------------------------------------
			cards.Add("BOT_563", new Power {
				// TODO [BOT_563] Wargear && Test: Wargear_BOT_563
				InfoCardId = "BOT_563e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_573] Subject 9 - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw 5 different <b>Secrets</b> from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("BOT_573", new Power {
				// TODO [BOT_573] Subject 9 && Test: Subject 9_BOT_573
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_603] Steel Rager - COST:4 [ATK:5/HP:1] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_603", new Power {
				// TODO [BOT_603] Steel Rager && Test: Steel Rager_BOT_603
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_606] Kaboom Bot - COST:3 [ATK:2/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 4_damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BOT_606", new Power {
				// TODO [BOT_606] Kaboom Bot && Test: Kaboom Bot_BOT_606
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_907] Galvanizer - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Reduce the
			//       Cost of Mechs in your
			//       hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BOT_907", new Power {
				// TODO [BOT_907] Galvanizer && Test: Galvanizer_BOT_907
				InfoCardId = "BOT_907e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_914] Whizbang the Wonderful - COST:4 [ATK:4/HP:5] 
			// - Set: boomsday, Rarity: legendary
			// --------------------------------------------------------
			// Text: You start the game with one of Whizbang's Wonderful Decks!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DECK_RULE_MOD_DECK_SIZE = 1
			// --------------------------------------------------------
			cards.Add("BOT_914", new Power {
				// TODO [BOT_914] Whizbang the Wonderful && Test: Whizbang the Wonderful_BOT_914
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_020e] Skaterbot (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_020e", new Power {
				// TODO [BOT_020e] Skaterbot && Test: Skaterbot_BOT_020e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_021e] Bronze Gatekeeper (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_021e", new Power {
				// TODO [BOT_021e] Bronze Gatekeeper && Test: Bronze Gatekeeper_BOT_021e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_035e] Venomizer (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_035e", new Power {
				// TODO [BOT_035e] Venomizer && Test: Venomizer_BOT_035e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_039e] Necromechanical (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			cards.Add("BOT_039e", new Power {
				// TODO [BOT_039e] Necromechanical && Test: Necromechanical_BOT_039e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_079e] Illuminated (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_079e", new Power {
				// TODO [BOT_079e] Illuminated && Test: Illuminated_BOT_079e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_083e] Toxic (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_083e", new Power {
				// TODO [BOT_083e] Toxic && Test: Toxic_BOT_083e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_107e] Missile Launcher (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: When your turn ends, deal 1 damage to other characters.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_107e", new Power {
				// TODO [BOT_107e] Missile Launcher && Test: Missile Launcher_BOT_107e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_234e] Shrink Ray (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_234e", new Power {
				// TODO [BOT_234e] Shrink Ray && Test: Shrink Ray_BOT_234e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_237e] Beryllium Nullifier (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_237e", new Power {
				// TODO [BOT_237e] Beryllium Nullifier && Test: Beryllium Nullifier_BOT_237e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_238e] Boomtastic (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your Mechs have <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("BOT_238e", new Power {
				// TODO [BOT_238e] Boomtastic && Test: Boomtastic_BOT_238e
				InfoCardId = "BOT_238e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_238e2] Boomtastic (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Dr. Boom is granting your Mechs <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_238e2", new Power {
				// TODO [BOT_238e2] Boomtastic && Test: Boomtastic_BOT_238e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_280e] Hologram (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("BOT_280e", new Power {
				// TODO [BOT_280e] Hologram && Test: Hologram_BOT_280e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_296e] Omega Surge (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +10 Attack.
			// --------------------------------------------------------
			cards.Add("BOT_296e", new Power {
				// TODO [BOT_296e] Omega Surge && Test: Omega Surge_BOT_296e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_312e] Replicating Menace (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon three 1/1 Microbots.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_312e", new Power {
				// TODO [BOT_312e] Replicating Menace && Test: Replicating Menace_BOT_312e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_413e] Brain Power (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("BOT_413e", new Power {
				// TODO [BOT_413e] Brain Power && Test: Brain Power_BOT_413e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_422ae] Old Growth (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_422ae", new Power {
				// TODO [BOT_422ae] Old Growth && Test: Old Growth_BOT_422ae
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_437e] Slimed (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +3/+3 and <b>Rush</b>. Dies a slimy death at the end of the turn.
			// --------------------------------------------------------
			cards.Add("BOT_437e", new Power {
				// TODO [BOT_437e] Slimed && Test: Slimed_BOT_437e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_517e] Downside Up (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Topsy Turvy.
			// --------------------------------------------------------
			cards.Add("BOT_517e", new Power {
				// TODO [BOT_517e] Downside Up && Test: Downside Up_BOT_517e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_543e] Mind Meld (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your spells have <b>Lifesteal</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOT_543e", new Power {
				// TODO [BOT_543e] Mind Meld && Test: Mind Meld_BOT_543e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_548e] Zilliax (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b><b>Divine Shield</b>, <b>Taunt</b>, Lifesteal, Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_548e", new Power {
				// TODO [BOT_548e] Zilliax && Test: Zilliax_BOT_548e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_550e] Electrified (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("BOT_550e", new Power {
				// TODO [BOT_550e] Electrified && Test: Electrified_BOT_550e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_559e] Dealing (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			cards.Add("BOT_559e", new Power {
				// TODO [BOT_559e] Dealing && Test: Dealing_BOT_559e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_562e] Disguised (*) - COST:0 
			// - Fac: horde, Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Stealthed</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("BOT_562e", new Power {
				// TODO [BOT_562e] Disguised && Test: Disguised_BOT_562e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_563e] Wargear (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_563e", new Power {
				// TODO [BOT_563e] Wargear && Test: Wargear_BOT_563e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_906e] Glow-Tron (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			// GameTag:
			// - MODULAR = 1
			// - 871 = 1
			// --------------------------------------------------------
			cards.Add("BOT_906e", new Power {
				// TODO [BOT_906e] Glow-Tron && Test: Glow-Tron_BOT_906e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOT_907e] Galvanized (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("BOT_907e", new Power {
				// TODO [BOT_907e] Galvanized && Test: Galvanized_BOT_907e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_203e] FREEDOM! (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_203e", new Power {
				// TODO [BOTA_203e] FREEDOM! && Test: FREEDOM!_BOTA_203e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_208e] Demonic Research Player Enchant (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: This turn, your cards cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("BOTA_208e", new Power {
				// TODO [BOTA_208e] Demonic Research Player Enchant && Test: Demonic Research Player Enchant_BOTA_208e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BOTA_231e] Incubating (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a {0}.
			// --------------------------------------------------------
			cards.Add("BOTA_231e", new Power {
				// TODO [BOTA_231e] Incubating && Test: Incubating_BOTA_231e
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_242e", new Power {
				// TODO [BOTA_242e] Steel Rattler && Test: Steel Rattler_BOTA_242e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_066t] Mechanical Dragon (*) - COST:7 [ATK:7/HP:7] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			cards.Add("BOT_066t", new Power {
				// TODO [BOT_066t] Mechanical Dragon && Test: Mechanical Dragon_BOT_066t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_102t] Spark (*) - COST:1 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("BOT_102t", new Power {
				// TODO [BOT_102t] Spark && Test: Spark_BOT_102t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_270t] Annoy-o-Tron (*) - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: boomsday, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("BOT_270t", new Power {
				// TODO [BOT_270t] Annoy-o-Tron && Test: Annoy-o-Tron_BOT_270t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_312t] Microbot (*) - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			cards.Add("BOT_312t", new Power {
				// TODO [BOT_312t] Microbot && Test: Microbot_BOT_312t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOT_445t] Jo-E Bot (*) - COST:1 [ATK:1/HP:1] 
			// - Race: mechanical, Fac: neutral, Set: boomsday, 
			// --------------------------------------------------------
			cards.Add("BOT_445t", new Power {
				// TODO [BOT_445t] Jo-E Bot && Test: Jo-E Bot_BOT_445t
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_101", new Power {
				// TODO [BOTA_101] Spud M.E. && Test: Spud M.E._BOTA_101
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_200", new Power {
				// TODO [BOTA_200] Undercover Reporter && Test: Undercover Reporter_BOTA_200
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_210] Galvanized Golem (*) - COST:3 [ATK:5/HP:2] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Your 1-Attack minions cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("BOTA_210", new Power {
				// TODO [BOTA_210] Galvanized Golem && Test: Galvanized Golem_BOTA_210
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_211] Super Soldier (*) - COST:3 [ATK:2/HP:3] 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with 3 or less Attack, give it <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_211", new Power {
				// TODO [BOTA_211] Super Soldier && Test: Super Soldier_BOTA_211
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_212] Cure-All (*) - COST:3 [ATK:3/HP:3] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			// Text: Whenever a minion is healed, deal 2 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("BOTA_212", new Power {
				// TODO [BOTA_212] Cure-All && Test: Cure-All_BOTA_212
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_214", new Power {
				// TODO [BOTA_214] Turret Sentinel && Test: Turret Sentinel_BOTA_214
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BOTA_223] Gelbin's Coil (*) - COST:1 [ATK:1/HP:2] 
			// - Race: mechanical, Set: boomsday, 
			// --------------------------------------------------------
			// Text: After you play a spell, deal 1 damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("BOTA_223", new Power {
				// TODO [BOTA_223] Gelbin's Coil && Test: Gelbin's Coil_BOTA_223
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_229", new Power {
				// TODO [BOTA_229] Boom-in-a-Box && Test: Boom-in-a-Box_BOTA_229
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_231", new Power {
				// TODO [BOTA_231] Incubator && Test: Incubator_BOTA_231
				InfoCardId = "BOTA_231e",
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_242", new Power {
				// TODO [BOTA_242] Steel Rattler && Test: Steel Rattler_BOTA_242
				InfoCardId = "BOTA_242e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOT_511t] Bomb (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: [x]You take 5 damage.
			//       Draw a card. This
			//       explodes when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("BOT_511t", new Power {
				// TODO [BOT_511t] Bomb && Test: Bomb_BOT_511t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_102] Battery Pack (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Refresh all your Mana Crystals.
			// --------------------------------------------------------
			cards.Add("BOTA_102", new Power {
				// TODO [BOTA_102] Battery Pack && Test: Battery Pack_BOTA_102
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_202", new Power {
				// TODO [BOTA_202] Uplink && Test: Uplink_BOTA_202
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_203] Breakout (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Give your minions <b>Charge</b>.
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("BOTA_203", new Power {
				// TODO [BOTA_203] Breakout && Test: Breakout_BOTA_203
				InfoCardId = "BOTA_203e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_207] The Swap (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Swap minions with your opponent.
			// --------------------------------------------------------
			cards.Add("BOTA_207", new Power {
				// TODO [BOTA_207] The Swap && Test: The Swap_BOTA_207
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_208] Demonic Research (*) - COST:8 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: This turn, your cards cost Health instead of Mana.
			// --------------------------------------------------------
			cards.Add("BOTA_208", new Power {
				// TODO [BOTA_208] Demonic Research && Test: Demonic Research_BOTA_208
				InfoCardId = "BOTA_208e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_232] Cosmic Projection (*) - COST:0 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Swap hands with your opponent.
			// --------------------------------------------------------
			cards.Add("BOTA_232", new Power {
				// TODO [BOTA_232] Cosmic Projection && Test: Cosmic Projection_BOTA_232
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_234] The Stars Align (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Arrange your minions by their Health.
			// --------------------------------------------------------
			cards.Add("BOTA_234", new Power {
				// TODO [BOTA_234] The Stars Align && Test: The Stars Align_BOTA_234
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_235] Unbeakered Lightning (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Deal $8 damage to all minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("BOTA_235", new Power {
				// TODO [BOTA_235] Unbeakered Lightning && Test: Unbeakered Lightning_BOTA_235
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_240] Back-up Plan (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Destroy all friendly minions.
			// --------------------------------------------------------
			cards.Add("BOTA_240", new Power {
				// TODO [BOTA_240] Back-up Plan && Test: Back-up Plan_BOTA_240
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_244] Ray of Roasting (*) - COST:10 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Deal 10 damage to all minions 10 times.
			// --------------------------------------------------------
			cards.Add("BOTA_244", new Power {
				// TODO [BOTA_244] Ray of Roasting && Test: Ray of Roasting_BOTA_244
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_301] Cold Blooded (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_301", new Power {
				// TODO [BOTA_301] Cold Blooded && Test: Cold Blooded_BOTA_301
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_302] Frostbite (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_302", new Power {
				// TODO [BOTA_302] Frostbite && Test: Frostbite_BOTA_302
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_303] Battle Boar (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_303", new Power {
				// TODO [BOTA_303] Battle Boar && Test: Battle Boar_BOTA_303
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_304] Stand By Me (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_304", new Power {
				// TODO [BOTA_304] Stand By Me && Test: Stand By Me_BOTA_304
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_305] Frothing Fighters (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_305", new Power {
				// TODO [BOTA_305] Frothing Fighters && Test: Frothing Fighters_BOTA_305
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_306] Leeroy Returns (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_306", new Power {
				// TODO [BOTA_306] Leeroy Returns && Test: Leeroy Returns_BOTA_306
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_307] Cosmic Fire (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_307", new Power {
				// TODO [BOTA_307] Cosmic Fire && Test: Cosmic Fire_BOTA_307
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_309] Quick and Quiet (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_309", new Power {
				// TODO [BOTA_309] Quick and Quiet && Test: Quick and Quiet_BOTA_309
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_310] Dinosaur Domination (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_310", new Power {
				// TODO [BOTA_310] Dinosaur Domination && Test: Dinosaur Domination_BOTA_310
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_311] Hot Potato (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_311", new Power {
				// TODO [BOTA_311] Hot Potato && Test: Hot Potato_BOTA_311
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_312] A Dim Flame (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_312", new Power {
				// TODO [BOTA_312] A Dim Flame && Test: A Dim Flame_BOTA_312
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_313] Lethal Lepers (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_313", new Power {
				// TODO [BOTA_313] Lethal Lepers && Test: Lethal Lepers_BOTA_313
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_314] Full Draw (*) - COST:8 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_314", new Power {
				// TODO [BOTA_314] Full Draw && Test: Full Draw_BOTA_314
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_315] Plan B (*) - COST:9 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 1-9.
			// --------------------------------------------------------
			cards.Add("BOTA_315", new Power {
				// TODO [BOTA_315] Plan B && Test: Plan B_BOTA_315
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_316] The Wall (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_316", new Power {
				// TODO [BOTA_316] The Wall && Test: The Wall_BOTA_316
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_317] Four Horsemen (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_317", new Power {
				// TODO [BOTA_317] Four Horsemen && Test: Four Horsemen_BOTA_317
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_318] Light and Fire (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_318", new Power {
				// TODO [BOTA_318] Light and Fire && Test: Light and Fire_BOTA_318
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_319] Hostile Hoppers (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_319", new Power {
				// TODO [BOTA_319] Hostile Hoppers && Test: Hostile Hoppers_BOTA_319
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_320] A Corrupted Spirit (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_320", new Power {
				// TODO [BOTA_320] A Corrupted Spirit && Test: A Corrupted Spirit_BOTA_320
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_321] The Best Offense (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_321", new Power {
				// TODO [BOTA_321] The Best Offense && Test: The Best Offense_BOTA_321
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_322] Healing Hammers (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_322", new Power {
				// TODO [BOTA_322] Healing Hammers && Test: Healing Hammers_BOTA_322
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_323] Toasted Hydra (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_323", new Power {
				// TODO [BOTA_323] Toasted Hydra && Test: Toasted Hydra_BOTA_323
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_324] C'Thun! C'Thun! C'THUN! (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 3-7.
			// --------------------------------------------------------
			cards.Add("BOTA_324", new Power {
				// TODO [BOTA_324] C'Thun! C'Thun! C'THUN! && Test: C'Thun! C'Thun! C'THUN!_BOTA_324
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_327] Tossing Taters (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_327", new Power {
				// TODO [BOTA_327] Tossing Taters && Test: Tossing Taters_BOTA_327
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_328] Pride's Fall (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_328", new Power {
				// TODO [BOTA_328] Pride's Fall && Test: Pride's Fall_BOTA_328
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_329] Keepers of the Gate (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_329", new Power {
				// TODO [BOTA_329] Keepers of the Gate && Test: Keepers of the Gate_BOTA_329
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_330] A Shaman's Strength (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_330", new Power {
				// TODO [BOTA_330] A Shaman's Strength && Test: A Shaman's Strength_BOTA_330
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_331] Selective Stampede (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_331", new Power {
				// TODO [BOTA_331] Selective Stampede && Test: Selective Stampede_BOTA_331
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_332] Spell Addiction (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle 4-6.
			// --------------------------------------------------------
			cards.Add("BOTA_332", new Power {
				// TODO [BOTA_332] Spell Addiction && Test: Spell Addiction_BOTA_332
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_333] Of Pirates and Patrons (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_333", new Power {
				// TODO [BOTA_333] Of Pirates and Patrons && Test: Of Pirates and Patrons_BOTA_333
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_334] Erratic Explosive (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_334", new Power {
				// TODO [BOTA_334] Erratic Explosive && Test: Erratic Explosive_BOTA_334
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_336] Never Go Full Northshire (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_336", new Power {
				// TODO [BOTA_336] Never Go Full Northshire && Test: Never Go Full Northshire_BOTA_336
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_337] Full Northshire (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Lethal Puzzle B-4
			// --------------------------------------------------------
			cards.Add("BOTA_337", new Power {
				// TODO [BOTA_337] Full Northshire && Test: Full Northshire_BOTA_337
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_420] Quick Attack (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_420", new Power {
				// TODO [BOTA_420] Quick Attack && Test: Quick Attack_BOTA_420
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_421] Holy Extermination (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_421", new Power {
				// TODO [BOTA_421] Holy Extermination && Test: Holy Extermination_BOTA_421
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_422] Stomp the Snail (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_422", new Power {
				// TODO [BOTA_422] Stomp the Snail && Test: Stomp the Snail_BOTA_422
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_423] Sticky Scarecrows (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_423", new Power {
				// TODO [BOTA_423] Sticky Scarecrows && Test: Sticky Scarecrows_BOTA_423
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_424] The Power of Pigs (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_424", new Power {
				// TODO [BOTA_424] The Power of Pigs && Test: The Power of Pigs_BOTA_424
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_425] Position Perfection (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_425", new Power {
				// TODO [BOTA_425] Position Perfection && Test: Position Perfection_BOTA_425
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_426] Scorched Earth (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_426", new Power {
				// TODO [BOTA_426] Scorched Earth && Test: Scorched Earth_BOTA_426
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_427] Dragon Removal Service (*) - COST:8 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_427", new Power {
				// TODO [BOTA_427] Dragon Removal Service && Test: Dragon Removal Service_BOTA_427
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_429] Fighter's Finale (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_429", new Power {
				// TODO [BOTA_429] Fighter's Finale && Test: Fighter's Finale_BOTA_429
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_430] No More N'Zoth (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_430", new Power {
				// TODO [BOTA_430] No More N'Zoth && Test: No More N'Zoth_BOTA_430
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_431] Contamination! (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_431", new Power {
				// TODO [BOTA_431] Contamination! && Test: Contamination!_BOTA_431
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_432] A Stolen Shadow (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_432", new Power {
				// TODO [BOTA_432] A Stolen Shadow && Test: A Stolen Shadow_BOTA_432
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_433] Hurricane of Horrors (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_433", new Power {
				// TODO [BOTA_433] Hurricane of Horrors && Test: Hurricane of Horrors_BOTA_433
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_434] Curious Crustacean (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_434", new Power {
				// TODO [BOTA_434] Curious Crustacean && Test: Curious Crustacean_BOTA_434
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_435] Shocking Spells (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_435", new Power {
				// TODO [BOTA_435] Shocking Spells && Test: Shocking Spells_BOTA_435
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_437] Tiny Terrors (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_437", new Power {
				// TODO [BOTA_437] Tiny Terrors && Test: Tiny Terrors_BOTA_437
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_438] Defiling Demons (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_438", new Power {
				// TODO [BOTA_438] Defiling Demons && Test: Defiling Demons_BOTA_438
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_439] A Warrior's Weapons (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_439", new Power {
				// TODO [BOTA_439] A Warrior's Weapons && Test: A Warrior's Weapons_BOTA_439
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_440] Poultry Provoked (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_440", new Power {
				// TODO [BOTA_440] Poultry Provoked && Test: Poultry Provoked_BOTA_440
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_441] Bot Battle (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_441", new Power {
				// TODO [BOTA_441] Bot Battle && Test: Bot Battle_BOTA_441
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_444] Airborne Assault (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_444", new Power {
				// TODO [BOTA_444] Airborne Assault && Test: Airborne Assault_BOTA_444
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_445] Dog Days (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_445", new Power {
				// TODO [BOTA_445] Dog Days && Test: Dog Days_BOTA_445
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_446] Grumble's Rumble (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_446", new Power {
				// TODO [BOTA_446] Grumble's Rumble && Test: Grumble's Rumble_BOTA_446
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_447] Toxic Treants (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_447", new Power {
				// TODO [BOTA_447] Toxic Treants && Test: Toxic Treants_BOTA_447
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_448] A Dance with Death (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_448", new Power {
				// TODO [BOTA_448] A Dance with Death && Test: A Dance with Death_BOTA_448
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_450] A Storm of Souls (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_450", new Power {
				// TODO [BOTA_450] A Storm of Souls && Test: A Storm of Souls_BOTA_450
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_451] Plugging Away (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_451", new Power {
				// TODO [BOTA_451] Plugging Away && Test: Plugging Away_BOTA_451
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_452] Warlock's Apprentice (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_452", new Power {
				// TODO [BOTA_452] Warlock's Apprentice && Test: Warlock's Apprentice_BOTA_452
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_453] The Test (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Board Clear Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_453", new Power {
				// TODO [BOTA_453] The Test && Test: The Test_BOTA_453
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_500] First Steps (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_500", new Power {
				// TODO [BOTA_500] First Steps && Test: First Steps_BOTA_500
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_501] Smoldering Shield (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_501", new Power {
				// TODO [BOTA_501] Smoldering Shield && Test: Smoldering Shield_BOTA_501
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_502] In a Flash (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_502", new Power {
				// TODO [BOTA_502] In a Flash && Test: In a Flash_BOTA_502
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_503] Adorable Sacrifice (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_503", new Power {
				// TODO [BOTA_503] Adorable Sacrifice && Test: Adorable Sacrifice_BOTA_503
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_504] Pursuit of Knowledge (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_504", new Power {
				// TODO [BOTA_504] Pursuit of Knowledge && Test: Pursuit of Knowledge_BOTA_504
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_505] Brazed Pork (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_505", new Power {
				// TODO [BOTA_505] Brazed Pork && Test: Brazed Pork_BOTA_505
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_506] Shields Up! (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_506", new Power {
				// TODO [BOTA_506] Shields Up! && Test: Shields Up!_BOTA_506
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_507] Three Odd Yetis (*) - COST:8 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_507", new Power {
				// TODO [BOTA_507] Three Odd Yetis && Test: Three Odd Yetis_BOTA_507
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_509] Loss and Gain (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_509", new Power {
				// TODO [BOTA_509] Loss and Gain && Test: Loss and Gain_BOTA_509
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_510] Explosive Assault (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_510", new Power {
				// TODO [BOTA_510] Explosive Assault && Test: Explosive Assault_BOTA_510
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_511] Dragonslayer (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_511", new Power {
				// TODO [BOTA_511] Dragonslayer && Test: Dragonslayer_BOTA_511
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_512] Nature's Wispers (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_512", new Power {
				// TODO [BOTA_512] Nature's Wispers && Test: Nature's Wispers_BOTA_512
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_513] Burning Volley (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_513", new Power {
				// TODO [BOTA_513] Burning Volley && Test: Burning Volley_BOTA_513
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_514] Divine Alignment (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_514", new Power {
				// TODO [BOTA_514] Divine Alignment && Test: Divine Alignment_BOTA_514
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_515] Aha! (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 2-7.
			// --------------------------------------------------------
			cards.Add("BOTA_515", new Power {
				// TODO [BOTA_515] Aha! && Test: Aha!_BOTA_515
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_516] Cruel Souls (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_516", new Power {
				// TODO [BOTA_516] Cruel Souls && Test: Cruel Souls_BOTA_516
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_517] Ride the Wave (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_517", new Power {
				// TODO [BOTA_517] Ride the Wave && Test: Ride the Wave_BOTA_517
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_518] Hello Darkness (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_518", new Power {
				// TODO [BOTA_518] Hello Darkness && Test: Hello Darkness_BOTA_518
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_519] The Ray of Roasting (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_519", new Power {
				// TODO [BOTA_519] The Ray of Roasting && Test: The Ray of Roasting_BOTA_519
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_520] The Ol' Switcheroo (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_520", new Power {
				// TODO [BOTA_520] The Ol' Switcheroo && Test: The Ol' Switcheroo_BOTA_520
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_521] It's in the Stars (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_521", new Power {
				// TODO [BOTA_521] It's in the Stars && Test: It's in the Stars_BOTA_521
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_522] Nether Side Up (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_522", new Power {
				// TODO [BOTA_522] Nether Side Up && Test: Nether Side Up_BOTA_522
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_524] A Quest for Three (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_524", new Power {
				// TODO [BOTA_524] A Quest for Three && Test: A Quest for Three_BOTA_524
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_525] Chilling Winds (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_525", new Power {
				// TODO [BOTA_525] Chilling Winds && Test: Chilling Winds_BOTA_525
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_526] Filthy Rodent (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_526", new Power {
				// TODO [BOTA_526] Filthy Rodent && Test: Filthy Rodent_BOTA_526
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_529] Noble Sacrifices (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_529", new Power {
				// TODO [BOTA_529] Noble Sacrifices && Test: Noble Sacrifices_BOTA_529
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_530] Shrinking Solutions (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_530", new Power {
				// TODO [BOTA_530] Shrinking Solutions && Test: Shrinking Solutions_BOTA_530
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_531] Perfect Patrons (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_531", new Power {
				// TODO [BOTA_531] Perfect Patrons && Test: Perfect Patrons_BOTA_531
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_532] Deathwing Dilemma (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_532", new Power {
				// TODO [BOTA_532] Deathwing Dilemma && Test: Deathwing Dilemma_BOTA_532
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_533] Infestation! (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Mirror Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_533", new Power {
				// TODO [BOTA_533] Infestation! && Test: Infestation!_BOTA_533
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_611] Don't Panic (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-1.
			// --------------------------------------------------------
			cards.Add("BOTA_611", new Power {
				// TODO [BOTA_611] Don't Panic && Test: Don't Panic_BOTA_611
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_612] A Gentle Touch (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-2.
			// --------------------------------------------------------
			cards.Add("BOTA_612", new Power {
				// TODO [BOTA_612] A Gentle Touch && Test: A Gentle Touch_BOTA_612
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_613] Cleansing Corruption (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-3.
			// --------------------------------------------------------
			cards.Add("BOTA_613", new Power {
				// TODO [BOTA_613] Cleansing Corruption && Test: Cleansing Corruption_BOTA_613
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_614] A Dire Situation (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-4.
			// --------------------------------------------------------
			cards.Add("BOTA_614", new Power {
				// TODO [BOTA_614] A Dire Situation && Test: A Dire Situation_BOTA_614
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_615] Double Dip (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-5.
			// --------------------------------------------------------
			cards.Add("BOTA_615", new Power {
				// TODO [BOTA_615] Double Dip && Test: Double Dip_BOTA_615
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_616] A Priest's Feast (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-6.
			// --------------------------------------------------------
			cards.Add("BOTA_616", new Power {
				// TODO [BOTA_616] A Priest's Feast && Test: A Priest's Feast_BOTA_616
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_617] Splash! (*) - COST:7 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-7.
			// --------------------------------------------------------
			cards.Add("BOTA_617", new Power {
				// TODO [BOTA_617] Splash! && Test: Splash!_BOTA_617
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_621] Up for Auction (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-1.
			// --------------------------------------------------------
			cards.Add("BOTA_621", new Power {
				// TODO [BOTA_621] Up for Auction && Test: Up for Auction_BOTA_621
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_622] Sowing Seeds (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-2.
			// --------------------------------------------------------
			cards.Add("BOTA_622", new Power {
				// TODO [BOTA_622] Sowing Seeds && Test: Sowing Seeds_BOTA_622
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_623] Mechanical Medic (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-3.
			// --------------------------------------------------------
			cards.Add("BOTA_623", new Power {
				// TODO [BOTA_623] Mechanical Medic && Test: Mechanical Medic_BOTA_623
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_624] Lifesteel (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-4.
			// --------------------------------------------------------
			cards.Add("BOTA_624", new Power {
				// TODO [BOTA_624] Lifesteel && Test: Lifesteel_BOTA_624
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_625] Double Trouble (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-5.
			// --------------------------------------------------------
			cards.Add("BOTA_625", new Power {
				// TODO [BOTA_625] Double Trouble && Test: Double Trouble_BOTA_625
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_626] Revived and Refreshed (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 2-6.
			// --------------------------------------------------------
			cards.Add("BOTA_626", new Power {
				// TODO [BOTA_626] Revived and Refreshed && Test: Revived and Refreshed_BOTA_626
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_631] That's the Spirit (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-1.
			// --------------------------------------------------------
			cards.Add("BOTA_631", new Power {
				// TODO [BOTA_631] That's the Spirit && Test: That's the Spirit_BOTA_631
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_632] Underhanded Dealing (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-2.
			// --------------------------------------------------------
			cards.Add("BOTA_632", new Power {
				// TODO [BOTA_632] Underhanded Dealing && Test: Underhanded Dealing_BOTA_632
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_633] Pesky Priest (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-3.
			// --------------------------------------------------------
			cards.Add("BOTA_633", new Power {
				// TODO [BOTA_633] Pesky Priest && Test: Pesky Priest_BOTA_633
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_634] Hallazeal? Hallaheal (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-4.
			// --------------------------------------------------------
			cards.Add("BOTA_634", new Power {
				// TODO [BOTA_634] Hallazeal? Hallaheal && Test: Hallazeal? Hallaheal_BOTA_634
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_635] Primal Investment (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-5.
			// --------------------------------------------------------
			cards.Add("BOTA_635", new Power {
				// TODO [BOTA_635] Primal Investment && Test: Primal Investment_BOTA_635
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_636] Healing Hands (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 3-6.
			// --------------------------------------------------------
			cards.Add("BOTA_636", new Power {
				// TODO [BOTA_636] Healing Hands && Test: Healing Hands_BOTA_636
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_641] Just Jaraxxus (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-1.
			// --------------------------------------------------------
			cards.Add("BOTA_641", new Power {
				// TODO [BOTA_641] Just Jaraxxus && Test: Just Jaraxxus_BOTA_641
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_642] Strike Me Down (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-2.
			// --------------------------------------------------------
			cards.Add("BOTA_642", new Power {
				// TODO [BOTA_642] Strike Me Down && Test: Strike Me Down_BOTA_642
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_643] For Me? (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-3.
			// --------------------------------------------------------
			cards.Add("BOTA_643", new Power {
				// TODO [BOTA_643] For Me? && Test: For Me?_BOTA_643
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_644] Risky Research (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-4.
			// --------------------------------------------------------
			cards.Add("BOTA_644", new Power {
				// TODO [BOTA_644] Risky Research && Test: Risky Research_BOTA_644
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_645] Tempting Demons (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 4-5.
			// --------------------------------------------------------
			cards.Add("BOTA_645", new Power {
				// TODO [BOTA_645] Tempting Demons && Test: Tempting Demons_BOTA_645
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_649] Mal'Ganis and Me (*) - COST:1 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-1.
			// --------------------------------------------------------
			cards.Add("BOTA_649", new Power {
				// TODO [BOTA_649] Mal'Ganis and Me && Test: Mal'Ganis and Me_BOTA_649
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_650] Sharing is Caring (*) - COST:2 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-2.
			// --------------------------------------------------------
			cards.Add("BOTA_650", new Power {
				// TODO [BOTA_650] Sharing is Caring && Test: Sharing is Caring_BOTA_650
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_651] The Path to Victory (*) - COST:3 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-3.
			// --------------------------------------------------------
			cards.Add("BOTA_651", new Power {
				// TODO [BOTA_651] The Path to Victory && Test: The Path to Victory_BOTA_651
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_652] Doomed! (*) - COST:4 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-4.
			// --------------------------------------------------------
			cards.Add("BOTA_652", new Power {
				// TODO [BOTA_652] Doomed! && Test: Doomed!_BOTA_652
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_653] Copycats (*) - COST:5 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-5.
			// --------------------------------------------------------
			cards.Add("BOTA_653", new Power {
				// TODO [BOTA_653] Copycats && Test: Copycats_BOTA_653
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_654] Fungal Frugality (*) - COST:6 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle B-6.
			// --------------------------------------------------------
			cards.Add("BOTA_654", new Power {
				// TODO [BOTA_654] Fungal Frugality && Test: Fungal Frugality_BOTA_654
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BOTA_655] Visions of Vitality (*) - COST:8 
			// - Set: boomsday, 
			// --------------------------------------------------------
			// Text: Start Survival Puzzle 1-8.
			// --------------------------------------------------------
			cards.Add("BOTA_655", new Power {
				// TODO [BOTA_655] Visions of Vitality && Test: Visions of Vitality_BOTA_655
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_700", new Power {
				// TODO [BOTA_700] Mirror && Test: Mirror_BOTA_700
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_701", new Power {
				// TODO [BOTA_701] Survival && Test: Survival_BOTA_701
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_702", new Power {
				// TODO [BOTA_702] Lethal && Test: Lethal_BOTA_702
				//PowerTask = null,
				//Trigger = null,
			});

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
			cards.Add("BOTA_706", new Power {
				// TODO [BOTA_706] Board Clear && Test: Board Clear_BOTA_706
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			MageNonCollect(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
