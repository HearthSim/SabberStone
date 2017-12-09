﻿using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Adventure
{
	public class LootapaloozaCardsGenAdv
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_04h] Waxmancer Sturmi (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This kobold can
			//       candle-craft
			//       minions at will.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46149
			// - 793 = 946
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_04h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_04h] Waxmancer Sturmi && Test: Waxmancer Sturmi_LOOTA_BOSS_04h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_05h] Pathmaker Hamm (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>There's more than
			//       one way for a kobold
			//       to_dig_a_tunnel.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46151
			// - 793 = 1465
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_05h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_05h] Pathmaker Hamm && Test: Pathmaker Hamm_LOOTA_BOSS_05h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - DRUID
			// [LOOTA_BOSS_06h] Blackseed (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This furbolg’s dark magic twists the other dungeonfolk.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46153
			// - 793 = 1466
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_06h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_06h] Blackseed && Test: Blackseed_LOOTA_BOSS_06h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// -------------------------------------------- HERO - MAGE
			// [LOOTA_BOSS_09h] Frostfur (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>These furbolg warrens feel unnaturally cold...</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46159
			// - 793 = 27
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_09h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_09h] Frostfur && Test: Frostfur_LOOTA_BOSS_09h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_10h] Graves the Cleric (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This healing adventurer was separated from his old party.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46161
			// - 793 = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_10h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_10h] Graves the Cleric && Test: Graves the Cleric_LOOTA_BOSS_10h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_11h] Overseer Mogark (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This trogg commander is extra "motivational" to underlings.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46163
			// - 793 = 1473
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_11h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_11h] Overseer Mogark && Test: Overseer Mogark_LOOTA_BOSS_11h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_12h] Candlebeard (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This kobold pirate's favorite move is chaaaarrrge!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46165
			// - 793 = 1467
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_12h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_12h] Candlebeard && Test: Candlebeard_LOOTA_BOSS_12h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_13h] Thaddock the Thief (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>One moment her minions are there... the next... gone!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46167
			// - 793 = 1259
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_13h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_13h] Thaddock the Thief && Test: Thaddock the Thief_LOOTA_BOSS_13h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - PALADIN
			// [LOOTA_BOSS_15h] George and Karl (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>These tag-team paladins went missing in Un'goro.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46170
			// - 793 = 1475
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_15h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_15h] George and Karl && Test: George and Karl_LOOTA_BOSS_15h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_16h] Spiritspeaker Azun (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This troll priest speaks with the dead... twice.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46172
			// - 793 = 1261
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_16h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_16h] Spiritspeaker Azun && Test: Spiritspeaker Azun_LOOTA_BOSS_16h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_17h] Battlecrier Jin'zo (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>When he calls in the troops, they listen. Twice.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46174
			// - 793 = 1567
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_17h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_17h] Battlecrier Jin'zo && Test: Battlecrier Jin'zo_LOOTA_BOSS_17h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_18h] Giant Rat (*) - COST:0 [ATK:0/HP:10] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>The bane of every young adventurer.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45894
			// - 793 = 1557
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_18h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_18h] Giant Rat && Test: Giant Rat_LOOTA_BOSS_18h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - SHAMAN
			// [LOOTA_BOSS_19h] Gutmook (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This trogg elder and his minions flock toward sources of magic.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46205
			// - 793 = 1455
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_19h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_19h] Gutmook && Test: Gutmook_LOOTA_BOSS_19h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_20h] Brimstone Warden (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>At all costs, stop him from waking the
			//       ancient_guardians...</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46208
			// - 793 = 1456
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_20h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_20h] Brimstone Warden && Test: Brimstone Warden_LOOTA_BOSS_20h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_21h] Gnosh the Greatworm (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Always looking to devour the largest, tastiest minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46242
			// - 793 = 1458
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_21h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_21h] Gnosh the Greatworm && Test: Gnosh the Greatworm_LOOTA_BOSS_21h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_22h] Tad (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Look, this murloc just wants to fish, okay?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46250
			// - 793 = 1462
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_22h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_22h] Tad && Test: Tad_LOOTA_BOSS_22h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_23h] Bristlesnarl (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This legendary furbolg hunter can quickly call on big friends.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46342
			// - 793 = 1577
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_23h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_23h] Bristlesnarl && Test: Bristlesnarl_LOOTA_BOSS_23h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - PALADIN
			// [LOOTA_BOSS_24h] The Mothergloop (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Don't let its growing, gooey friends get
			//       out of hand.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46346
			// - 793 = 1468
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_24h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_24h] The Mothergloop && Test: The Mothergloop_LOOTA_BOSS_24h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_25h] Vustrasz the Ancient (*) - COST:0 [ATK:0/HP:70] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>His vast treasure stores are for the taking... if you dare!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46350
			// - 793 = 1469
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_25h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_25h] Vustrasz the Ancient && Test: Vustrasz the Ancient_LOOTA_BOSS_25h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARLOCK
			// [LOOTA_BOSS_26h] Xol the Unscathed (*) - COST:0 [ATK:0/HP:70] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>She's got her eyes on you. ALL of her eyes.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47428
			// - 793 = 1568
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26h] Xol the Unscathed && Test: Xol the Unscathed_LOOTA_BOSS_26h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_27h] Waxmancer Sturmi (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This kobold can
			//       candle-craft
			//       minions at will.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46267
			// - 793 = 946
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_27h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_27h] Waxmancer Sturmi && Test: Waxmancer Sturmi_LOOTA_BOSS_27h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_28h] Pathmaker Hamm (*) - COST:0 [ATK:0/HP:60] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>There's more than
			//       one way for a kobold
			//       to_dig_a_tunnel.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46271
			// - 793 = 1465
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_28h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_28h] Pathmaker Hamm && Test: Pathmaker Hamm_LOOTA_BOSS_28h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - DRUID
			// [LOOTA_BOSS_29h] Blackseed (*) - COST:0 [ATK:0/HP:60] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This furbolg’s dark magic twists the other dungeonfolk.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46282
			// - 793 = 1466
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_29h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_29h] Blackseed && Test: Blackseed_LOOTA_BOSS_29h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_30h] Overseer Mogark (*) - COST:0 [ATK:0/HP:60] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This trogg commander is extra "motivational" to underlings.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46314
			// - 793 = 1473
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_30h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_30h] Overseer Mogark && Test: Overseer Mogark_LOOTA_BOSS_30h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_31h] Candlebeard (*) - COST:0 [ATK:0/HP:60] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This kobold pirate's favorite move is chaaaarrrge!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46319
			// - 793 = 1467
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_31h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_31h] Candlebeard && Test: Candlebeard_LOOTA_BOSS_31h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - PALADIN
			// [LOOTA_BOSS_32h] Karl and George (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>These tag-team paladins went missing in Un'goro.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2740
			// - 793 = 1475
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_32h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_32h] Karl and George && Test: Karl and George_LOOTA_BOSS_32h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - SHAMAN
			// [LOOTA_BOSS_33h] Gutmook (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This trogg elder and his minions flock toward sources of magic.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46331
			// - 793 = 1455
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_33h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_33h] Gutmook && Test: Gutmook_LOOTA_BOSS_33h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARLOCK
			// [LOOTA_BOSS_34h] Azari, the Devourer (*) - COST:0 [ATK:0/HP:70] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>The most terrible of demons is loose!
			//       And VERY hungry.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46353
			// - 793 = 1560
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_34h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_34h] Azari, the Devourer && Test: Azari, the Devourer_LOOTA_BOSS_34h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - SHAMAN
			// [LOOTA_BOSS_35h] Elder Brandlemar (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>The bane of magic users, this furbolg can counter any spell.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46358
			// - 793 = 13
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_35h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_35h] Elder Brandlemar && Test: Elder Brandlemar_LOOTA_BOSS_35h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - DRUID
			// [LOOTA_BOSS_36h] Ixlid (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Its deadly spores can kill an adventurer instantly!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46363
			// - 793 = 1471
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_36h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_36h] Ixlid && Test: Ixlid_LOOTA_BOSS_36h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// -------------------------------------------- HERO - MAGE
			// [LOOTA_BOSS_37h] Lyris the Wild Mage (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>She loves fire. Her minions love that she loves fire.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46368
			// - 793 = 1472
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_37h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_37h] Lyris the Wild Mage && Test: Lyris the Wild Mage_LOOTA_BOSS_37h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_38h] Voodoomaster Vex (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>He wants to be a troll. He cries for battle and rattles for death.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47000
			// - 793 = 1531
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_38h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_38h] Voodoomaster Vex && Test: Voodoomaster Vex_LOOTA_BOSS_38h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_39h] Kraxx (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This ancient stone guardian prefers the loot to stay here.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47257
			// - 793 = 1543
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_39h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_39h] Kraxx && Test: Kraxx_LOOTA_BOSS_39h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_40h] Seriona (*) - COST:0 [ATK:0/HP:20] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>A twilight dragon
			//       bent on draining
			//       your minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47260
			// - 793 = 1544
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_40h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_40h] Seriona && Test: Seriona_LOOTA_BOSS_40h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - WARRIOR
			// [LOOTA_BOSS_41h] Whompwhisker (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>A kobold berserker who never fights alone.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47302
			// - 793 = 1545
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_41h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_41h] Whompwhisker && Test: Whompwhisker_LOOTA_BOSS_41h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - DRUID
			// [LOOTA_BOSS_42h] Elder Jari (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This furbolg elder
			//       calls arcane energies to her defense.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47304
			// - 793 = 1546
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_42h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_42h] Elder Jari && Test: Elder Jari_LOOTA_BOSS_42h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - DRUID
			// [LOOTA_BOSS_43h] Jeeru (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Don't rub the lamp! You rubbed the lamp, didn't you?</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47306
			// - 793 = 1547
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_43h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_43h] Jeeru && Test: Jeeru_LOOTA_BOSS_43h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_44h] Wee Whelp (*) - COST:0 [ATK:0/HP:10] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>It's just a baby dragon. But it's still a dragon.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47308
			// - 793 = 1548
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_44h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_44h] Wee Whelp && Test: Wee Whelp_LOOTA_BOSS_44h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_45h] Bink the Burglar (*) - COST:0 [ATK:0/HP:10] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>This low-down thief preys on starting adventurers.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47315
			// - 793 = 1549
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_45h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_45h] Bink the Burglar && Test: Bink the Burglar_LOOTA_BOSS_45h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - SHAMAN
			// [LOOTA_BOSS_46h] Fungalmancer Flurgl (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>The fungalmancer empowers his friends. With fungus.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47319
			// - 793 = 1550
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_46h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_46h] Fungalmancer Flurgl && Test: Fungalmancer Flurgl_LOOTA_BOSS_46h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - SHAMAN
			// [LOOTA_BOSS_47h] Lava-Filled Chamber (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>The kobolds attempted to board up this lava-filled chamber!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47321
			// - 793 = 1551
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_47h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_47h] Lava-Filled Chamber && Test: Lava-Filled Chamber_LOOTA_BOSS_47h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - HUNTER
			// [LOOTA_BOSS_48h] Trapped Room (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Tread carefully. Don't... touch... anything!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47327
			// - 793 = 1553
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_48h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_48h] Trapped Room && Test: Trapped Room_LOOTA_BOSS_48h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_49h] The Darkness (*) - COST:0 [ATK:0/HP:70] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>There's a reason to always keep a light on down here.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47332
			// - 793 = 1552
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_49h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_49h] The Darkness && Test: The Darkness_LOOTA_BOSS_49h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ HERO - PRIEST
			// [LOOTA_BOSS_50h] Mushhuckster Max (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>You probably don't want the potions
			//       he's hocking.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47360
			// - 793 = 1555
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_50h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_50h] Mushhuckster Max && Test: Mushhuckster Max_LOOTA_BOSS_50h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_51h] Russell the Bard (*) - COST:0 [ATK:0/HP:30] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>His tunes are catchy. Just ask your minions.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47363
			// - 793 = 1556
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_51h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_51h] Russell the Bard && Test: Russell the Bard_LOOTA_BOSS_51h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_52h] Treasure Vault (*) - COST:0 [ATK:0/HP:60] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Grab all you can, as fast as you can!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47464
			// - HIDE_STATS = 1
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// - 793 = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_52h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_52h] Treasure Vault && Test: Treasure Vault_LOOTA_BOSS_52h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// -------------------------------------------- HERO - MAGE
			// [LOOTA_BOSS_53h] Chronomancer Inara (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Once she powers
			//       up, beware of her
			//       mastery of time!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47474
			// - 793 = 1470
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_53h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_53h] Chronomancer Inara && Test: Chronomancer Inara_LOOTA_BOSS_53h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// -------------------------------------------- HERO - MAGE
			// [LOOTA_BOSS_53h2] Inara the Mage (*) - COST:0 [ATK:0/HP:50] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47474
			// - 793 = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_53h2", new List<Enchantment> {
				// TODO [LOOTA_BOSS_53h2] Inara the Mage && Test: Inara the Mage_LOOTA_BOSS_53h2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - PALADIN
			// [LOOTA_BOSS_54h] A. F. Kay (*) - COST:0 [ATK:0/HP:40] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Waylay this adventurer while she isn't
			//       paying attention!</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47494
			// - 793 = 1572
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_54h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_54h] A. F. Kay && Test: A. F. Kay_LOOTA_BOSS_54h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------- HERO - ROGUE
			// [LOOTA_BOSS_99h] King Togwaggle (*) - COST:0 [ATK:0/HP:70] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <i>Look out! He's loaded with loot from failed adventurers.</i>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 47209
			// - 793 = 1569
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_99h", new List<Enchantment> {
				// TODO [LOOTA_BOSS_99h] King Togwaggle && Test: King Togwaggle_LOOTA_BOSS_99h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void HeroPowers(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_04p] Sculpt Wax (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 copy of a minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_04p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_04p] Sculpt Wax && Test: Sculpt Wax_LOOTA_BOSS_04p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_05p] Unstable Explosion (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to two random enemies.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_05p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_05p] Unstable Explosion && Test: Unstable Explosion_LOOTA_BOSS_05p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_06p] Evolvomancy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Transform a minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_06p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_06p] Evolvomancy && Test: Evolvomancy_LOOTA_BOSS_06p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_09p] Freeze (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Freeze</b> a minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_09p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_09p] Freeze && Test: Freeze_LOOTA_BOSS_09p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_10p] Light's Will (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore 2 Health to all minions.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_10p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_10p] Light's Will && Test: Light's Will_LOOTA_BOSS_10p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_11p] Cruel Words (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to a friendly minion and give it +2 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_11p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_11p] Cruel Words && Test: Cruel Words_LOOTA_BOSS_11p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_12p] Charge! (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion <b>Charge</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_12p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_12p] Charge! && Test: Charge!_LOOTA_BOSS_12p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_13p] Tactical Retreat (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Return a friendly minion to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_13p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_13p] Tactical Retreat && Test: Tactical Retreat_LOOTA_BOSS_13p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_15p] Divinity (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all your minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_15p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_15p] Divinity && Test: Divinity_LOOTA_BOSS_15p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_16p] Totem of the Dead (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_16p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_16p] Totem of the Dead && Test: Totem of the Dead_LOOTA_BOSS_16p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_17p] Battle Totem (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All <b>Battlecries</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_17p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_17p] Battle Totem && Test: Battle Totem_LOOTA_BOSS_17p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_18p] Rat Race (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 1/1 Rats.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_18p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_18p] Rat Race && Test: Rat Race_LOOTA_BOSS_18p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_19p] Digest Magic (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Whenever your
			//        opponent casts a spell,
			//       summon a Tunnel Trogg.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_19p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_19p] Digest Magic && Test: Digest Magic_LOOTA_BOSS_19p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_20p] Dispel Ward (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Silence</b> your minions.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_20p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_20p] Dispel Ward && Test: Dispel Ward_LOOTA_BOSS_20p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_21p] Swallow Whole (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy the minion with the highest Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_21p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_21p] Swallow Whole && Test: Swallow Whole_LOOTA_BOSS_21p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_22p] Catch and Release (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_22p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_22p] Catch and Release && Test: Catch and Release_LOOTA_BOSS_22p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_23p] Hunter's Call (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_23p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_23p] Hunter's Call && Test: Hunter's Call_LOOTA_BOSS_23p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_24p] Gloop (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_24p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_24p] Gloop && Test: Gloop_LOOTA_BOSS_24p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_25p] Vindictive Breath (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all enemies for each missing Master Chest.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_25p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_25p] Vindictive Breath && Test: Vindictive Breath_LOOTA_BOSS_25p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_26p8] Beam Me Up! (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        At the end of your turn, add a <b>Beam</b> to your_hand.
			// --------------------------------------------------------
			// Entourage: LOOTA_BOSS_26p2, LOOTA_BOSS_26p3, LOOTA_BOSS_26p4, LOOTA_BOSS_26p5, LOOTA_BOSS_26p6, LOOTA_BOSS_26p7
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p8", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p8] Beam Me Up! && Test: Beam Me Up!_LOOTA_BOSS_26p8
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_27p] Harden Sculpture (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a copy of a minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_27p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_27p] Harden Sculpture && Test: Harden Sculpture_LOOTA_BOSS_27p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_28p] Unstable Demolition (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage to three random enemies.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_28p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_28p] Unstable Demolition && Test: Unstable Demolition_LOOTA_BOSS_28p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_29p] Greater Evolution (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Transform a minion into a random one that costs (3) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_29p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_29p] Greater Evolution && Test: Greater Evolution_LOOTA_BOSS_29p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_30p] Searing Lash (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to a friendly minion and give it +5 Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_30p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_30p] Searing Lash && Test: Searing Lash_LOOTA_BOSS_30p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_31p] Charrrrrge! (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After you play a minion, give it <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_31p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_31p] Charrrrrge! && Test: Charrrrrge!_LOOTA_BOSS_31p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_33p] Metabolized Magic (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever your opponent casts a spell, draw a card. It costs (1).
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_33p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_33p] Metabolized Magic && Test: Metabolized Magic_LOOTA_BOSS_33p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_34p] Devour (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Remove the top
			//       2 cards of your opponent's_deck.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_34p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_34p] Devour && Test: Devour_LOOTA_BOSS_34p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_35p] Dampen Magic (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a 'Counterspell' <b>Secret</b> into the battlefield.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_35p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_35p] Dampen Magic && Test: Dampen Magic_LOOTA_BOSS_35p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_36p] Sprouting Spore (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon an <b><i>extremely</i></b>
			//       Deadly_Spore.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_36p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_36p] Sprouting Spore && Test: Sprouting Spore_LOOTA_BOSS_36p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_37p] Arcane Infusion (*) - COST:1 [ATK:1/HP:0] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add 'Arcane Missiles' to your hand.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_37p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_37p] Arcane Infusion && Test: Arcane Infusion_LOOTA_BOSS_37p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_38p] Totem of Chaos (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All <b>Battlecries</b> and <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_38p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_38p] Totem of Chaos && Test: Totem of Chaos_LOOTA_BOSS_38p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_39p] Giant Stomp (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all enemy minions.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_39p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_39p] Giant Stomp && Test: Giant Stomp_LOOTA_BOSS_39p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_40p] Fading Light (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a minion -1_Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_MIN_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_40p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_40p] Fading Light && Test: Fading Light_LOOTA_BOSS_40p
				new Enchantment
				{
					InfoCardId = "LOOTA_BOSS_40pe",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_41p] Join the Fray (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Both players <b>Recruit</b> a_minion.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_41p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_41p] Join the Fray && Test: Join the Fray_LOOTA_BOSS_41p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_42p] Mystic Barrier (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 3 Armor.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_42p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_42p] Mystic Barrier && Test: Mystic Barrier_LOOTA_BOSS_42p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_43p] Three Wee Wishes (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Each player draws 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_43p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_43p] Three Wee Wishes && Test: Three Wee Wishes_LOOTA_BOSS_43p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_44p] Baby Breath (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_44p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_44p] Baby Breath && Test: Baby Breath_LOOTA_BOSS_44p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_45p] Coin (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_45p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_45p] Coin && Test: Coin_LOOTA_BOSS_45p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_46p] Fungal Infection (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_46p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_46p] Fungal Infection && Test: Fungal Infection_LOOTA_BOSS_46p
				new Enchantment
				{
					InfoCardId = "LOOTA_BOSS_46pe",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_47p] The Floor is Lava (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       After a minion is played, deal 2 damage to_it.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_47p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_47p] The Floor is Lava && Test: The Floor is Lava_LOOTA_BOSS_47p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_48p] Alarm (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever you reveal a <b>Secret</b>, summon a 3/3 Sawblade.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_48p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_48p] Alarm && Test: Alarm_LOOTA_BOSS_48p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_49p] Encroaching Darkness (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 5/5 Darkspawn.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_49p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_49p] Encroaching Darkness && Test: Encroaching Darkness_LOOTA_BOSS_49p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_50p] Mushroom, Mushroom (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Craft a custom Mushroom Potion.
			// --------------------------------------------------------
			// Entourage: CFM_621t11
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_50p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_50p] Mushroom, Mushroom && Test: Mushroom, Mushroom_LOOTA_BOSS_50p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_51p] Alluring Tune (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Gain control of an enemy_minion with 2 or less Attack.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_MAX_ATTACK = 2
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_51p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_51p] Alluring Tune && Test: Alluring Tune_LOOTA_BOSS_51p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_52p] Doors Are Closing (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       End the game.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_52p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_52p] Doors Are Closing && Test: Doors Are Closing_LOOTA_BOSS_52p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_53p] Stolen Time (*) - COST:10 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy 3 of your Mana_Crystals.
			//       Take an extra turn.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_53p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_53p] Stolen Time && Test: Stolen Time_LOOTA_BOSS_53p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_54p] Idle (*) - COST:2 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Do nothing.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_54p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_54p] Idle && Test: Idle_LOOTA_BOSS_54p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOOTA_BOSS_99p] Magic Candle (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Find a Treasure!
			// --------------------------------------------------------
			// Entourage: LOOTA_819, LOOTA_821, LOOTA_835, LOOTA_842b, LOOTA_806, LOOTA_812, LOOTA_823, LOOTA_847, LOOTA_836, LOOTA_839, LOOTA_816, LOOTA_827, LOOTA_843, LOOTA_826, LOOT_998k, LOOTA_838
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_99p", new List<Enchantment> {
				// TODO [LOOTA_BOSS_99p] Magic Candle && Test: Magic Candle_LOOTA_BOSS_99p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [LOOTA_820e] Mysterious Power (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("LOOTA_820e", new List<Enchantment> {
				// TODO [LOOTA_820e] Mysterious Power && Test: Mysterious Power_LOOTA_820e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_01] Mana Growth (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_169, CS2_013, AT_038, LOOT_351, GVG_032, CFM_616, OG_202, LOOT_392, EX1_164, AT_043
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_01", new List<Enchantment> {
				// TODO [LOOTA_Druid_01] Mana Growth && Test: Mana Growth_LOOTA_Druid_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_02] Jungle King (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: KAR_300, OG_048, AT_042, AT_039, GVG_080, UNG_100, CFM_816, KAR_065, AT_041, ICC_854, EX1_028, UNG_075, UNG_086, LOE_050
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_02", new List<Enchantment> {
				// TODO [LOOTA_Druid_02] Jungle King && Test: Jungle King_LOOTA_Druid_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_03] Natural Defense (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_005, UNG_108, LOOT_051, LOOT_047, OG_047, ICC_079, LOOT_054, LOOT_048, LOOT_309, ICC_085, LOOT_413
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_03", new List<Enchantment> {
				// TODO [LOOTA_Druid_03] Natural Defense && Test: Natural Defense_LOOTA_Druid_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_04] Jade Fangs (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_902, CFM_343, CFM_715, CFM_602, CFM_713
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_04", new List<Enchantment> {
				// TODO [LOOTA_Druid_04] Jade Fangs && Test: Jade Fangs_LOOTA_Druid_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_05] Stampede (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_037, CFM_614, EX1_160, CS2_011, ICC_808, EX1_571, UNG_111, ICC_047, LOOT_329, FP1_002, EX1_158, UNG_075, ICC_051, UNG_809
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_05", new List<Enchantment> {
				// TODO [LOOTA_Druid_05] Stampede && Test: Stampede_LOOTA_Druid_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_06] Jungle Quest (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_116, UNG_078, CFM_617, UNG_109, EX1_014, LOOT_233, UNG_101, KAR_065, EX1_028, BRM_010, CFM_308, UNG_852
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_06", new List<Enchantment> {
				// TODO [LOOTA_Druid_06] Jungle Quest && Test: Jungle Quest_LOOTA_Druid_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_07] Cult of C'thun (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_293, OG_281, OG_162, OG_286, OG_283, OG_321, OG_131, OG_280, OG_255, OG_188
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_07", new List<Enchantment> {
				// TODO [LOOTA_Druid_07] Cult of C'thun && Test: Cult of C'thun_LOOTA_Druid_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_08] Wise Decisions (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_037, LOE_115, GVG_030, EX1_154, LOOT_054, EX1_166, ICC_047, EX1_164, GVG_041, EX1_178, OG_195, EX1_573, OG_044
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_08", new List<Enchantment> {
				// TODO [LOOTA_Druid_08] Wise Decisions && Test: Wise Decisions_LOOTA_Druid_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_09] Balance (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_008, EX1_154, NEW1_007, EX1_173, EX1_012, EX1_284, FP1_019, EX1_563, CS2_012
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_09", new List<Enchantment> {
				// TODO [LOOTA_Druid_09] Balance && Test: Balance_LOOTA_Druid_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_10] Restoration (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_161, AT_044, CS2_007, KAR_075, GVG_031, GVG_033, CFM_120, CS2_117, AT_111, GVG_069
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_10", new List<Enchantment> {
				// TODO [LOOTA_Druid_10] Restoration && Test: Restoration_LOOTA_Druid_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_11] Taunt (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: ICC_051, ICC_808, ICC_807, EX1_165, ICC_054, ICC_832, LOOT_314, CS2_232, ICC_835, UNG_072, LOOT_383, KAR_061, UNG_848
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_11", new List<Enchantment> {
				// TODO [LOOTA_Druid_11] Taunt && Test: Taunt_LOOTA_Druid_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOTA_Druid_12] Stomp (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_086, AT_045, CFM_308, UNG_852, EX1_298, ICC_314, UNG_848, OG_340, EX1_572, NEW1_030, OG_042, GVG_114, CFM_811
			// --------------------------------------------------------
			cards.Add("LOOTA_Druid_12", new List<Enchantment> {
				// TODO [LOOTA_Druid_12] Stomp && Test: Stomp_LOOTA_Druid_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_01] Wee Beasts (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_315, DS1_175, EX1_162, FP1_002, OG_179, LOE_046, KAR_005, UNG_075, UNG_808, UNG_915, ICC_419, LOOT_078, CFM_316
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_01", new List<Enchantment> {
				// TODO [LOOTA_Hunter_01] Wee Beasts && Test: Wee Beasts_LOOTA_Hunter_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_02] Big Beasts (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_028, DS1_178, EX1_534, NEW1_041, OG_308, UNG_087, UNG_099, UNG_801, ICC_828, ICC_905, LOOT_511
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_02", new List<Enchantment> {
				// TODO [LOOTA_Hunter_02] Big Beasts && Test: Big Beasts_LOOTA_Hunter_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_03] Shots (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_084, DS1_183, EX1_537, EX1_609, DS1_185, EX1_617, GVG_073, BRM_013, AT_056, UNG_910, ICC_049, LOOT_077
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_03", new List<Enchantment> {
				// TODO [LOOTA_Hunter_03] Shots && Test: Shots_LOOTA_Hunter_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_04] Summoner (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: NEW1_031, EX1_595, EX1_538, EX1_531, FP1_002, AT_062, OG_045, OG_211, OG_249, CFM_315, UNG_076, LOOT_149, LOOT_511
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_04", new List<Enchantment> {
				// TODO [LOOTA_Hunter_04] Summoner && Test: Summoner_LOOTA_Hunter_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_05] Secrets (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_554, EX1_611, EX1_610, AT_060, ICC_200, EX1_080, EX1_609, EX1_533, EX1_536, KAR_004, ICC_200, ICC_204, LOOT_079, LOOT_080, LOOT_222, FP1_004, KAR_006
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_05", new List<Enchantment> {
				// TODO [LOOTA_Hunter_05] Secrets && Test: Secrets_LOOTA_Hunter_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_06] Beast Training (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_539, DS1_175, DS1_178, DS1_070, AT_010, CFM_316, UNG_915, UNG_916, UNG_917
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_06", new List<Enchantment> {
				// TODO [LOOTA_Hunter_06] Beast Training && Test: Beast Training_LOOTA_Hunter_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_07] Weapons (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: DS1_188, NEW1_018, EX1_536, GVG_043, GVG_119, CFM_325, CFM_337, LOOT_118, LOOT_222, LOOT_389, ICC_096
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_07", new List<Enchantment> {
				// TODO [LOOTA_Hunter_07] Weapons && Test: Weapons_LOOTA_Hunter_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_08] Tracker (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_096, EX1_544, DS1_184, AT_061, AT_063t, AT_058, LOE_029, LOE_105, ICC_415, ICC_828
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_08", new List<Enchantment> {
				// TODO [LOOTA_Hunter_08] Tracker && Test: Tracker_LOOTA_Hunter_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_09] Deathrattle (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_534, EX1_016, GVG_026, OG_133, OG_292, OG_309, KAR_005, UNG_800, ICC_021, ICC_052, ICC_243, ICC_825, ICC_854, LOOT_520, LOOT_161, LOOT_511
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_09", new List<Enchantment> {
				// TODO [LOOTA_Hunter_09] Deathrattle && Test: Deathrattle_LOOTA_Hunter_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_10] Legendary (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_543, UNG_919, EX1_116, FP1_010, GVG_110, FP1_013, ICC_314, OG_042, KAR_114, GVG_114
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_10", new List<Enchantment> {
				// TODO [LOOTA_Hunter_10] Legendary && Test: Legendary_LOOTA_Hunter_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_11] Defense (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, EX1_611, EX1_610, EX1_093, EX1_538, FP1_009, FP1_012, GVG_069, AT_060, LOOT_522
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_11", new List<Enchantment> {
				// TODO [LOOTA_Hunter_11] Defense && Test: Defense_LOOTA_Hunter_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOTA_Hunter_12] Smugglers (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_335, CFM_334, CFM_026, CFM_338, CFM_336, CFM_668, CFM_685, BRM_028
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Hunter_12", new List<Enchantment> {
				// TODO [LOOTA_Hunter_12] Smugglers && Test: Smugglers_LOOTA_Hunter_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_20] Chaos (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOOT_104, KAR_009, UNG_028, UNG_941, GVG_003, AT_007, OG_090, LOE_003, OG_090, UNG_024, CFM_649, LOOT_537
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_20", new List<Enchantment> {
				// TODO [LOOTA_Mage_20] Chaos && Test: Chaos_LOOTA_Mage_20
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_21] Elementals (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_027, UNG_846, CS2_033, UNG_021, UNG_070, UNG_816, UNG_847, UNG_907, UNG_809, UNG_818, LOOT_103, EX1_298, ICC_833, EX1_249
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_21", new List<Enchantment> {
				// TODO [LOOTA_Mage_21] Elementals && Test: Elementals_LOOTA_Mage_21
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_22] Magical Friends (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: NEW1_012, BRM_002, OG_303, EX1_012, EX1_284, EX1_095, NEW1_026, AT_004, EX1_563, EX1_559, EX1_608
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_22", new List<Enchantment> {
				// TODO [LOOTA_Mage_22] Magical Friends && Test: Magical Friends_LOOTA_Mage_22
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_23] Frost (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_275, CS2_028, CS2_024, GVG_002, UNG_205, ICC_252, ICC_836, CS2_033, CS2_026, OG_081
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_23", new List<Enchantment> {
				// TODO [LOOTA_Mage_23] Frost && Test: Frost_LOOTA_Mage_23
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_24] Fire (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_029, CS2_032, EX1_279, KAR_076, CFM_065, UNG_955, LOOT_172, LOE_002, EX1_298
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_24", new List<Enchantment> {
				// TODO [LOOTA_Mage_24] Fire && Test: Fire_LOOTA_Mage_24
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_25] Heroic Power (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_003, AT_090, AT_006, AT_099, AT_127, ICC_833, AT_119, CFM_807, AT_008
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_25", new List<Enchantment> {
				// TODO [LOOTA_Mage_25] Heroic Power && Test: Heroic Power_LOOTA_Mage_25
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_27] Big Spells (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOOT_130, LOOT_539, LOOT_172, LOOT_535, EX1_279, CS2_032, UNG_955, CS2_028, LOOT_170, LOOT_172, LOOT_414, LOOT_106
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_27", new List<Enchantment> {
				// TODO [LOOTA_Mage_27] Big Spells && Test: Big Spells_LOOTA_Mage_27
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_28] Arcane (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_022, EX1_277, AT_009, AT_005, CFM_620, CS2_027, LOOT_231, CS2_023, LOOT_108
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_28", new List<Enchantment> {
				// TODO [LOOTA_Mage_28] Arcane && Test: Arcane_LOOTA_Mage_28
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_29] Lost Secrets (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_274, FP1_018, UNG_020, ICC_082, KAR_092, EX1_287, EX1_295, EX1_294, CFM_760, FP1_004
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_29", new List<Enchantment> {
				// TODO [LOOTA_Mage_29] Lost Secrets && Test: Lost Secrets_LOOTA_Mage_29
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_30] Giant Army (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: ICC_823, GVG_005, UNG_948, FP1_018, EX1_295, KAR_711, EX1_620, BRM_028, LOOT_161
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_30", new List<Enchantment> {
				// TODO [LOOTA_Mage_30] Giant Army && Test: Giant Army_LOOTA_Mage_30
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_31] Defense (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_026, FP1_012, ICC_314, GVG_069, EX1_295, CS2_027, LOE_119, CS2_028, NEW1_021
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_31", new List<Enchantment> {
				// TODO [LOOTA_Mage_31] Defense && Test: Defense_LOOTA_Mage_31
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOTA_Mage_32] Unique (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOE_011, CFM_621, CFM_687
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Mage_32", new List<Enchantment> {
				// TODO [LOOTA_Mage_32] Unique && Test: Unique_LOOTA_Mage_32
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [LOOTA_BOSS_15e] George and Karl Enchantment (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46170
			// - 793 = 1475
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_15e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_15e] George and Karl Enchantment && Test: George and Karl Enchantment_LOOTA_BOSS_15e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_BOSS_110] Tag Team (*) - COST:0 [ATK:0/HP:15] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Swap George and Karl.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 46170
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_110", new List<Enchantment> {
				// TODO [LOOTA_BOSS_110] Tag Team && Test: Tag Team_LOOTA_BOSS_110
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_01] Secrets (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_130, FP1_020, EX1_136, EX1_080, EX1_379, FP1_004, AT_073, AT_079, CFM_800, UNG_011
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_01", new List<Enchantment> {
				// TODO [LOOTA_Paladin_01] Secrets && Test: Secrets_LOOTA_Paladin_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_04] Healing (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_229, KAR_057, GVG_069, CFM_120, LOOT_291, LOOT_398, LOOT_091, ICC_245, ICC_820, ICC_829, CFM_815
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_04", new List<Enchantment> {
				// TODO [LOOTA_Paladin_04] Healing && Test: Healing_LOOTA_Paladin_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_05] Divine Shield (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: GVG_058, EX1_067, EX1_020, EX1_590, EX1_032, EX1_383, AT_087, AT_095, OG_310, CFM_815, ICC_038, ICC_801, ICC_858, ICC_913, ICC_071
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_05", new List<Enchantment> {
				// TODO [LOOTA_Paladin_05] Divine Shield && Test: Divine Shield_LOOTA_Paladin_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_09] Justice (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOE_017, EX1_382, AT_081, UNG_015, EX1_619, EX1_360, CS2_094, CS2_093, EX1_384, AT_078, ICC_039
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_09", new List<Enchantment> {
				// TODO [LOOTA_Paladin_09] Justice && Test: Justice_LOOTA_Paladin_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_11] Helping Hand (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_639, CFM_753, CFM_305, GVG_063, CFM_650, CFM_685, CFM_853, BRM_028
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_11", new List<Enchantment> {
				// TODO [LOOTA_Paladin_11] Helping Hand && Test: Helping Hand_LOOTA_Paladin_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_12] Dragonmaster (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: BRM_018, BRM_020, EX1_284, BRM_026, BRM_033, BRM_034, KAR_062, CFM_806, EX1_043, BRM_025, UNG_848, BRM_031, OG_271, NEW1_030, OG_317, EX1_563, EX1_562, EX1_572, LOOT_540, LOOT_137
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_12", new List<Enchantment> {
				// TODO [LOOTA_Paladin_12] Dragonmaster && Test: Dragonmaster_LOOTA_Paladin_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_14] Silver Hand (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_273, GVG_061, LOOT_363, GVG_060, AT_100, AT_075, UNG_950, UNG_960, UNG_962, LOOT_333, LOOT_313
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_14", new List<Enchantment> {
				// TODO [LOOTA_Paladin_14] Silver Hand && Test: Silver Hand_LOOTA_Paladin_14
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_16] Legendary (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_298, ICC_314, CFM_807, LOOT_357, GVG_118, GVG_110, AT_127, BRM_028, EX1_002, KAR_061, LOOT_500
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_16", new List<Enchantment> {
				// TODO [LOOTA_Paladin_16] Legendary && Test: Legendary_LOOTA_Paladin_16
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_19] Taunt (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_062, CFM_815, UNG_015, CFM_062, EX1_383, GVG_085, UNG_808, ICC_314, ICC_912, OG_145, FP1_012, LOOT_383, EX1_032, KAR_061
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_19", new List<Enchantment> {
				// TODO [LOOTA_Paladin_19] Taunt && Test: Taunt_LOOTA_Paladin_19
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_20] Sacred Arms (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_097, GVG_059, LOOT_286, GVG_061, OG_222, UNG_950, LOOT_500, LOOT_118, EX1_366, ICC_096
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_20", new List<Enchantment> {
				// TODO [LOOTA_Paladin_20] Sacred Arms && Test: Sacred Arms_LOOTA_Paladin_20
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_21] Murlocs (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_076, OG_006, EX1_509, EX1_508, EX1_062, EX1_506, LOE_026, OG_161, CFM_344, UNG_089, EX1_507, UNG_937, CS2_173, UNG_011
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_21", new List<Enchantment> {
				// TODO [LOOTA_Paladin_21] Murlocs && Test: Murlocs_LOOTA_Paladin_21
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOTA_Paladin_22] Many Blessings (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_087, CS2_092, EX1_363, OG_223, UNG_961, AT_074, KAR_077, EX1_355, UNG_952, UNG_004, UNG_953, LOOT_216, ICC_244, LOOT_088, UNG_843, UNG_954
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Paladin_22", new List<Enchantment> {
				// TODO [LOOTA_Paladin_22] Many Blessings && Test: Many Blessings_LOOTA_Paladin_22
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_01] Holy (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_621, AT_055, GVG_012, CS2_235, AT_011, CS1_112, OG_234, EX1_624, EX1_001, EX1_350, KAR_035, GVG_008
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_01", new List<Enchantment> {
				// TODO [LOOTA_Priest_01] Holy && Test: Holy_LOOTA_Priest_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_02] Last Rites (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOE_006, FP1_002, FP1_009, ICC_702, FP1_031, GVG_096, UNG_900, OG_147, FP1_012, ICC_098, EX1_110, OG_133, FP1_023, UNG_032, UNG_037, OG_335, ICC_214, LOOT_161, KAR_114, UNG_940, LOOT_187, LOOT_161
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_02", new List<Enchantment> {
				// TODO [LOOTA_Priest_02] Last Rites && Test: Last Rites_LOOTA_Priest_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_03] Domination (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_032, CS2_003, CFM_603, UNG_035, EX1_339, EX1_345, EX1_334, OG_335, ICC_207, EX1_091, ICC_849, ICC_215, CS1_113, LOOT_541, LOE_104, LOOT_353
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_03", new List<Enchantment> {
				// TODO [LOOTA_Priest_03] Domination && Test: Domination_LOOTA_Priest_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_04] Resurrection (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: BRM_017, ICC_213, KAR_204, LOOT_507, CS2_181, FP1_013, LOOT_187, EX1_016, UNG_037, ICC_214
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_04", new List<Enchantment> {
				// TODO [LOOTA_Priest_04] Resurrection && Test: Resurrection_LOOTA_Priest_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_05] Bag of Tricks (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_661, CS2_234, ICC_802, AT_015, GVG_011, EX1_622, LOE_111, GVG_008, LOOT_008, LOE_104, ICC_214, LOE_079, UNG_851, OG_100, CFM_657, CFM_807
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_05", new List<Enchantment> {
				// TODO [LOOTA_Priest_05] Bag of Tricks && Test: Bag of Tricks_LOOTA_Priest_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_06] Shadow (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: ICC_210, UNG_022, AT_014, EX1_625, LOOT_529, LOOT_526, GVG_014, OG_316, ICC_235, ICC_830, ICC_212, ICC_802, EX1_591, FP1_001
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_06", new List<Enchantment> {
				// TODO [LOOTA_Priest_06] Shadow && Test: Shadow_LOOTA_Priest_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_07] Dragon Priest (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: BRM_004, AT_116, LOOT_410, CFM_605, CFM_662, KAR_062, BRM_033, LOOT_144, EX1_043, AT_017, EX1_284, KAR_033, ICC_027, EX1_572, OG_317, EX1_563, LOOT_137, LOOT_540, BRM_034
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_07", new List<Enchantment> {
				// TODO [LOOTA_Priest_07] Dragon Priest && Test: Dragon Priest_LOOTA_Priest_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_08] Discipline (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS1_129, CS2_236, GVG_010, LOOT_278, AT_131, AT_129, UNG_843, LOE_053, CS2_004
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_08", new List<Enchantment> {
				// TODO [LOOTA_Priest_08] Discipline && Test: Discipline_LOOTA_Priest_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_10] Unique (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_020, CFM_621, LOE_011
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_10", new List<Enchantment> {
				// TODO [LOOTA_Priest_10] Unique && Test: Unique_LOOTA_Priest_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_12] Elementals (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_032, UNG_034, EX1_335, UNG_963, UNG_928, UNG_070, UNG_816, UNG_847, UNG_907, EX1_298, UNG_809
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_12", new List<Enchantment> {
				// TODO [LOOTA_Priest_12] Elementals && Test: Elementals_LOOTA_Priest_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_13] Cult of C'Thun (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_334, OG_096, OG_281, OG_162, OG_286, OG_283, OG_321, OG_131, OG_280, OG_255
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_13", new List<Enchantment> {
				// TODO [LOOTA_Priest_13] Cult of C'Thun && Test: Cult of C'Thun_LOOTA_Priest_13
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOTA_Priest_9] Combo Caster (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOOT_209, UNG_034, UNG_029, KAR_035, UNG_963, NEW1_020, NEW1_026, LOOT_414, CS2_004, ICC_830
			// --------------------------------------------------------
			cards.Add("LOOTA_Priest_9", new List<Enchantment> {
				// TODO [LOOTA_Priest_9] Combo Caster && Test: Combo Caster_LOOTA_Priest_9
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_01] Adrenaline Rush (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_630, EX1_145, EX1_613, UNG_065, OG_080, ICC_910, EX1_044, NEW1_026, EX1_095, UNG_057, EX1_614, CS2_077, UNG_060
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_01", new List<Enchantment> {
				// TODO [LOOTA_Rogue_01] Adrenaline Rush && Test: Adrenaline Rush_LOOTA_Rogue_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_02] Evasive (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_809, EX1_049, CFM_693, EX1_144, EX1_015, LOOT_204, EX1_145, LOOT_165, UNG_067, NEW1_004
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_02", new List<Enchantment> {
				// TODO [LOOTA_Rogue_02] Evasive && Test: Evasive_LOOTA_Rogue_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_03] Blademaster (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_074, ICC_233, LOOT_542, GVG_023, ICC_221, UNG_823, ICC_850, CS2_233, ICC_240, GVG_022, ICC_097, LOOT_033, LOOT_389, ICC_096
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_03", new List<Enchantment> {
				// TODO [LOOTA_Rogue_03] Blademaster && Test: Blademaster_LOOTA_Rogue_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_04] Death Dealer (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_072, ICC_201, LOE_019, EX1_012, ICC_702, ICC_854, FP1_031, OG_249, GVG_096, UNG_900, OG_272, FP1_012, OG_133, EX1_016, OG_080, OG_330, LOOT_503, LOOT_161
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_04", new List<Enchantment> {
				// TODO [LOOTA_Rogue_04] Death Dealer && Test: Death Dealer_LOOTA_Rogue_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_05] Jade Lotus (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_690, CFM_691, CFM_715, CFM_902
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_05", new List<Enchantment> {
				// TODO [LOOTA_Rogue_05] Jade Lotus && Test: Jade Lotus_LOOTA_Rogue_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_07] Greed (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_630, AT_031, LOE_012, EX1_096, CFM_808, CFM_669, LOOT_357, EX1_050, EX1_284, LOOT_211, EX1_012
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_07", new List<Enchantment> {
				// TODO [LOOTA_Rogue_07] Greed && Test: Greed_LOOTA_Rogue_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_09] Thief (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_856, KAR_069, OG_330, AT_033, CFM_781, ICC_811, UNG_061, KAR_070, GVG_028, EX1_100
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_09", new List<Enchantment> {
				// TODO [LOOTA_Rogue_09] Thief && Test: Thief_LOOTA_Rogue_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_10] Assassin (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_072, CS2_073, EX1_124, EX1_278, EX1_129, OG_176, CS2_076, BRM_008, EX1_522, EX1_134, UNG_064, ICC_809
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_10", new List<Enchantment> {
				// TODO [LOOTA_Rogue_10] Assassin && Test: Assassin_LOOTA_Rogue_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_11] Outlaws (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_029, GVG_025, AT_032, OG_267, CFM_342, CFM_637, CFM_325, CS2_146, NEW1_018, NEW1_027, NEW1_022, ICC_018, NEW1_024, CFM_651, GVG_075
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_11", new List<Enchantment> {
				// TODO [LOOTA_Rogue_11] Outlaws && Test: Outlaws_LOOTA_Rogue_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_13] Bag of Tricks (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_126, LOOT_210, LOOT_214, BRM_007, AT_035, UNG_060, LOOT_026, OG_291, OG_073, EX1_145, EX1_144, ICC_827
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_13", new List<Enchantment> {
				// TODO [LOOTA_Rogue_13] Bag of Tricks && Test: Bag of Tricks_LOOTA_Rogue_13
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_15] Cult of C'thun (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_131, OG_162, OG_255, OG_281, OG_283, OG_284, OG_286, OG_321, OG_280, OG_282
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_15", new List<Enchantment> {
				// TODO [LOOTA_Rogue_15] Cult of C'thun && Test: Cult of C'thun_LOOTA_Rogue_15
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOTA_Rogue_16] Exhaustion (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_144, NEW1_004, LOE_077, FP1_009, EX1_014, EX1_581, EX1_050, KAR_712, BRM_007
			// --------------------------------------------------------
			cards.Add("LOOTA_Rogue_16", new List<Enchantment> {
				// TODO [LOOTA_Rogue_16] Exhaustion && Test: Exhaustion_LOOTA_Rogue_16
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_01] Destruction (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_025, KAR_073, OG_206, EX1_259, AT_051, GVG_038, LOOT_060, BRM_011, EX1_238, EX1_241
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_01", new List<Enchantment> {
				// TODO [LOOTA_Shaman_01] Destruction && Test: Destruction_LOOTA_Shaman_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_02] Frost (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: ICC_058, ICC_056, ICC_236, ICC_078, ICC_088, UNG_205, ICC_289, ICC_855, UNG_079
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_02", new List<Enchantment> {
				// TODO [LOOTA_Shaman_02] Frost && Test: Frost_LOOTA_Shaman_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_03] Restoration (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOOT_373, CS2_041, GVG_069, CFM_061, CFM_120, GVG_039, UNG_817, UNG_938, OG_209, AT_048
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_03", new List<Enchantment> {
				// TODO [LOOTA_Shaman_03] Restoration && Test: Restoration_LOOTA_Shaman_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_04] Mutations (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_027, LOOT_504, CFM_696, EX1_246, OG_328, ICC_481, EX1_083, OG_174, LOOT_150, CFM_697
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_04", new List<Enchantment> {
				// TODO [LOOTA_Shaman_04] Mutations && Test: Mutations_LOOTA_Shaman_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_05] Battlecrier (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_054, CS2_042, UNG_202, LOOT_358, LOOT_517, UNG_072, ICC_466, EX1_284, CFM_668, FP1_030, CFM_852, ICC_705, EX1_112, LOOT_357, BRM_012, LOE_077
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_05", new List<Enchantment> {
				// TODO [LOOTA_Shaman_05] Battlecrier && Test: Battlecrier_LOOTA_Shaman_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_06] Elementals (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_211, UNG_816, UNG_928, UNG_070, UNG_907, UNG_809, UNG_202, UNG_847, UNG_845, LOOT_517, NEW1_010, EX1_298, UNG_208
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_06", new List<Enchantment> {
				// TODO [LOOTA_Shaman_06] Elementals && Test: Elementals_LOOTA_Shaman_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_07] Murlocs (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_942, ICC_089, CFM_310, GVG_040, LOE_113, ICC_220, EX1_509, EX1_506, CS2_173, EX1_506, UNG_073, EX1_050, EX1_103, UNG_937, UNG_089, EX1_062, CFM_344, EX1_507
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_07", new List<Enchantment> {
				// TODO [LOOTA_Shaman_07] Murlocs && Test: Murlocs_LOOTA_Shaman_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_08] Overload (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_313, LOE_018, AT_053, BRM_011, OG_026, ICC_081, EX1_248, EX1_258, OG_024, EX1_250, LOOT_064, ICC_090, AT_052, LOE_018, BRM_011, OG_026, EX1_567
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_08", new List<Enchantment> {
				// TODO [LOOTA_Shaman_08] Overload && Test: Overload_LOOTA_Shaman_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_09] Totems (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_023, LOOT_062, LOOT_518, LOOT_344, EX1_575, AT_046, KAR_021, AT_049, OG_028, AT_052, EX1_565
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_09", new List<Enchantment> {
				// TODO [LOOTA_Shaman_09] Totems && Test: Totems_LOOTA_Shaman_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_11] Jade Lotus (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_717, CFM_707, CFM_312, CFM_715, CFM_902
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_11", new List<Enchantment> {
				// TODO [LOOTA_Shaman_11] Jade Lotus && Test: Jade Lotus_LOOTA_Shaman_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_12] Farseer (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_053, CS2_038, CS2_053, UNG_956, GVG_029, LOOT_506, EX1_110, FP1_025, CFM_324, EX1_016, FP1_013, ICC_257, LOOT_161
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_12", new List<Enchantment> {
				// TODO [LOOTA_Shaman_12] Farseer && Test: Farseer_LOOTA_Shaman_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOTA_Shaman_13] Mechanized (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: GVG_036, GVG_085, EX1_556, GVG_096, GVG_105, GVG_107, OG_145, GVG_105, GVG_114, GVG_006, GVG_006, GVG_103, LOE_039, GVG_037
			// --------------------------------------------------------
			cards.Add("LOOTA_Shaman_13", new List<Enchantment> {
				// TODO [LOOTA_Shaman_13] Mechanized && Test: Mechanized_LOOTA_Shaman_13
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void WarlockNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_01] Little Legion (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_065, EX1_319, GVG_018, CFM_611, LOOT_013, BRM_006, CFM_610, AT_019, GVG_019, BRM_005, GVG_045
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_01", new List<Enchantment> {
				// TODO [LOOTA_Warlock_01] Little Legion && Test: Little Legion_LOOTA_Warlock_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_02] Cult of C'thun (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_131, OG_162, OG_255, OG_281, OG_283, OG_284, OG_286, OG_302, OG_321, OG_280
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_02", new List<Enchantment> {
				// TODO [LOOTA_Warlock_02] Cult of C'thun && Test: Cult of C'thun_LOOTA_Warlock_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_03] Unique (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: LOE_011, CFM_621, CFM_750
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_03", new List<Enchantment> {
				// TODO [LOOTA_Warlock_03] Unique && Test: Unique_LOOTA_Warlock_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_04] Discard (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_310, OG_109, AT_021, KAR_205, KAR_089, UNG_829, UNG_830, UNG_833, ICC_841, EX1_308, UNG_836, LOOT_417
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_04", new List<Enchantment> {
				// TODO [LOOTA_Warlock_04] Discard && Test: Discard_LOOTA_Warlock_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_05] Lifesteal (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_061, EX1_309, GVG_018, ICC_055, ICC_220, ICC_810, LOOT_043, ICC_831, ICC_905
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_05", new List<Enchantment> {
				// TODO [LOOTA_Warlock_05] Lifesteal && Test: Lifesteal_LOOTA_Warlock_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_06] Taunt (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_065, EX1_058, FP1_012, UNG_049, CFM_790, ICC_466, LOOT_131, LOOT_368, ICC_314, LOOT_013, UNG_928, UNG_072, LOOT_383
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_06", new List<Enchantment> {
				// TODO [LOOTA_Warlock_06] Taunt && Test: Taunt_LOOTA_Warlock_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_07] Swarm (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_586, EX1_597, EX1_162, NEW1_019, FP1_002, GVG_045, BRM_006, OG_113, OG_241, UNG_076, LOOT_375, LOOT_014
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_07", new List<Enchantment> {
				// TODO [LOOTA_Warlock_07] Swarm && Test: Swarm_LOOTA_Warlock_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_08] Destruction (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: NEW1_021, NEW1_030, EX1_312, CS2_057, GVG_015, OG_239, CFM_094, CFM_608, ICC_041, LOOT_417
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_08", new List<Enchantment> {
				// TODO [LOOTA_Warlock_08] Destruction && Test: Destruction_LOOTA_Warlock_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_09] Sacrifice (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_303, EX1_316, EX1_304, AT_025, UNG_047, ICC_469, ICC_903, UNG_831, OG_239, NEW1_021, LOOT_017, FP1_007, UNG_083, LOOT_161, EX1_016
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_09", new List<Enchantment> {
				// TODO [LOOTA_Warlock_09] Sacrifice && Test: Sacrifice_LOOTA_Warlock_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_10] Blood (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: UNG_832, GVG_100, OG_121, UNG_835, CS2_062, CFM_094, EX1_620, EX1_319, LOOT_013, LOOT_043
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_10", new List<Enchantment> {
				// TODO [LOOTA_Warlock_10] Blood && Test: Blood_LOOTA_Warlock_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_11] Dire Demons (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: FP1_022, LOOT_420, EX1_310, LOOT_306, CS2_064, CFM_663, CFM_751, EX1_323, GVG_021, LOOT_368, ICC_831
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_11", new List<Enchantment> {
				// TODO [LOOTA_Warlock_11] Dire Demons && Test: Dire Demons_LOOTA_Warlock_11
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOTA_Warlock_12] Huge Hand (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_043, EX1_105, EX1_620, AT_127, AT_027, BRM_028, BRM_031, EX1_058, EX1_093, EX1_323
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_Warlock_12", new List<Enchantment> {
				// TODO [LOOTA_Warlock_12] Huge Hand && Test: Huge Hand_LOOTA_Warlock_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_01] Berserker (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_607, EX1_603, EX1_604, ICC_408, BRM_016, OG_218, ICC_405, EX1_007, OG_318, BRM_019, CS2_108, EX1_414, GVG_052, FP1_021, CS2_104
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_01", new List<Enchantment> {
				// TODO [LOOTA_Warrior_01] Berserker && Test: Berserker_LOOTA_Warrior_01
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_02] Everybody Hurts (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_400, EX1_392, NEW1_036, CFM_716, OG_276, GVG_050, OG_149, ICC_064, FP1_021, EX1_407, UNG_927, UNG_933, FP1_024, UNG_848, CS2_108, ICC_834
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_02", new List<Enchantment> {
				// TODO [LOOTA_Warrior_02] Everybody Hurts && Test: Everybody Hurts_LOOTA_Warrior_02
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_03] Charge! (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CS2_103, NEW1_011, EX1_414, CS2_146, AT_087, EX1_116, EX1_067, AT_070, UNG_099, AT_125, CFM_637
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_03", new List<Enchantment> {
				// TODO [LOOTA_Warrior_03] Charge! && Test: Charge!_LOOTA_Warrior_03
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_04] Weapons (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_409, CS2_106, ICC_281, AT_066, CS2_112, OG_033, EX1_411, LOOT_203, OG_220, LOOT_389, ICC_097, ICC_064, FP1_021, LOOT_118, ICC_096
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_04", new List<Enchantment> {
				// TODO [LOOTA_Warrior_04] Weapons && Test: Weapons_LOOTA_Warrior_04
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_05] Armor (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: EX1_410, EX1_402, LOOT_044, ICC_837, LOOT_367, ICC_062, EX1_606, CFM_756, LOOT_365, KAR_091, LOOT_364, GVG_053, LOOT_285, LOOT_519, AT_064
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_05", new List<Enchantment> {
				// TODO [LOOTA_Warrior_05] Armor && Test: Armor_LOOTA_Warrior_05
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_06] Pirates (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_312, OG_315, CFM_637, CFM_325, NEW1_018, GVG_075, NEW1_027, NEW1_022, CFM_651, NEW1_024, AT_070
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_06", new List<Enchantment> {
				// TODO [LOOTA_Warrior_06] Pirates && Test: Pirates_LOOTA_Warrior_06
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_07] Taunt (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_940, UNG_926, LOE_022, AT_065, OG_218, UNG_957, LOE_009, UNG_072, FP1_012, OG_340, KAR_061, UNG_848, ICC_314, LOOT_383, LOOT_137, UNG_934
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_07", new List<Enchantment> {
				// TODO [LOOTA_Warrior_07] Taunt && Test: Taunt_LOOTA_Warrior_07
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_08] Smash! (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: OG_314, CS2_108, CS2_105, EX1_391, AT_064, EX1_408, KAR_028, GVG_052, CS2_114
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_08", new List<Enchantment> {
				// TODO [LOOTA_Warrior_08] Smash! && Test: Smash!_LOOTA_Warrior_08
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_09] Re-Enforcer (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: CFM_643, CFM_755, CFM_631, CFM_754, CFM_853, BRM_028, CFM_685
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_09", new List<Enchantment> {
				// TODO [LOOTA_Warrior_09] Re-Enforcer && Test: Re-Enforcer_LOOTA_Warrior_09
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_10] Legendary (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_072, LOE_079, LOOT_516, UNG_851, FP1_030, AT_127, EX1_110, UNG_840, AT_132, LOOT_357, EX1_016, EX1_249, NEW1_038, FP1_013, EX1_298, GVG_114, OG_300, ICC_314, LOE_092
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_10", new List<Enchantment> {
				// TODO [LOOTA_Warrior_10] Legendary && Test: Legendary_LOOTA_Warrior_10
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_12] Dragon Heart (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: AT_071, KAR_062, BRM_033, LOOT_144, BRM_026, EX1_284, BRM_034, KAR_033, BRM_024, CFM_806, AT_123, BRM_030, EX1_572, NEW1_030, OG_317, AT_017, EX1_043, UNG_848, LOOT_137, LOOT_540
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_12", new List<Enchantment> {
				// TODO [LOOTA_Warrior_12] Dragon Heart && Test: Dragon Heart_LOOTA_Warrior_12
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOTA_Warrior_13] Recruiter (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Entourage: ICC_091, LOOT_370, LOOT_380, LOOT_184, LOOT_375, CFM_672, OG_042, LOOT_519, LOOT_521
			// --------------------------------------------------------
			cards.Add("LOOTA_Warrior_13", new List<Enchantment> {
				// TODO [LOOTA_Warrior_13] Recruiter && Test: Recruiter_LOOTA_Warrior_13
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_109e] Delicious Magic (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health.
			// --------------------------------------------------------
			cards.Add("LOOTA_109e", new List<Enchantment> {
				// TODO [LOOTA_109e] Delicious Magic && Test: Delicious Magic_LOOTA_109e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_802e] Justicar's Ring Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your Hero Power costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_802e", new List<Enchantment> {
				// TODO [LOOTA_802e] Justicar's Ring Enchantment && Test: Justicar's Ring Enchantment_LOOTA_802e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_803e] Scepter of Summoning Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_803e", new List<Enchantment> {
				// TODO [LOOTA_803e] Scepter of Summoning Enchantment && Test: Scepter of Summoning Enchantment_LOOTA_803e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_812e] Boots of Haste Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your minions cost (0) this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_812e", new List<Enchantment> {
				// TODO [LOOTA_812e] Boots of Haste Enchantment && Test: Boots of Haste Enchantment_LOOTA_812e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_818e] Grom's Amguards Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_818e", new List<Enchantment> {
				// TODO [LOOTA_818e] Grom's Amguards Enchantment && Test: Grom's Amguards Enchantment_LOOTA_818e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_824e] Khadgar's Scrying Orb Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your spells cost (1) less.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_824e", new List<Enchantment> {
				// TODO [LOOTA_824e] Khadgar's Scrying Orb Enchantment && Test: Khadgar's Scrying Orb Enchantment_LOOTA_824e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_825e] Robe of the Magi Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +3 Spell Damage.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_825e", new List<Enchantment> {
				// TODO [LOOTA_825e] Robe of the Magi Enchantment && Test: Robe of the Magi Enchantment_LOOTA_825e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_828e] Banner of Inspiration (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_828e", new List<Enchantment> {
				// TODO [LOOTA_828e] Banner of Inspiration && Test: Banner of Inspiration_LOOTA_828e
				new Enchantment
				{
					InfoCardId = "LOOTA_828e2",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_828e2] Banner of Inspiration Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_828e2", new List<Enchantment> {
				// TODO [LOOTA_828e2] Banner of Inspiration Player Enchant && Test: Banner of Inspiration Player Enchant_LOOTA_828e2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_828e3] Banner of Inspiration (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_828e3", new List<Enchantment> {
				// TODO [LOOTA_828e3] Banner of Inspiration && Test: Banner of Inspiration_LOOTA_828e3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_831e] Glyph of Warding Enchantment (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_831e", new List<Enchantment> {
				// TODO [LOOTA_831e] Glyph of Warding Enchantment && Test: Glyph of Warding Enchantment_LOOTA_831e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_832e] Invisible (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Has <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_832e", new List<Enchantment> {
				// TODO [LOOTA_832e] Invisible && Test: Invisible_LOOTA_832e
				new Enchantment
				{
					InfoCardId = "LOOTA_832e2",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_832e2] Cloak of Invisiblity Player Enchant (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_832e2", new List<Enchantment> {
				// TODO [LOOTA_832e2] Cloak of Invisiblity Player Enchant && Test: Cloak of Invisiblity Player Enchant_LOOTA_832e2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_842be] Armed? (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_842be", new List<Enchantment> {
				// TODO [LOOTA_842be] Armed? && Test: Armed?_LOOTA_842be
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_04e] Waxed (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_04e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_04e] Waxed && Test: Waxed_LOOTA_BOSS_04e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_11e] Whipped Into Shape (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_11e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_11e] Whipped Into Shape && Test: Whipped Into Shape_LOOTA_BOSS_11e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_12e] Charge! (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_12e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_12e] Charge! && Test: Charge!_LOOTA_BOSS_12e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_24e] Glooped (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_24e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_24e] Glooped && Test: Glooped_LOOTA_BOSS_24e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_30e] Whipped into Frenzy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +5 Attack.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_30e", new List<Enchantment> {
				// TODO [LOOTA_BOSS_30e] Whipped into Frenzy && Test: Whipped into Frenzy_LOOTA_BOSS_30e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_40pe] Fading (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Attack reduced.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_40pe", new List<Enchantment> {
				// TODO [LOOTA_BOSS_40pe] Fading && Test: Fading_LOOTA_BOSS_40pe
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOTA_BOSS_46pe] Infected (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Stats increased.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_46pe", new List<Enchantment> {
				// TODO [LOOTA_BOSS_46pe] Infected && Test: Infected_LOOTA_BOSS_46pe
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_102] Starving Crab (*) - COST:3 [ATK:4/HP:1] 
			// - Race: beast, Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 5 damage to your_hero.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_102", new List<Enchantment> {
				// TODO [LOOTA_102] Starving Crab && Test: Starving Crab_LOOTA_102
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_103] Sunken Chest (*) - COST:0 [ATK:0/HP:1] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Add
			//       Tad's Pole to your
			//       opponent's Dungeon Deck 
			//       and lose the game.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_103", new List<Enchantment> {
				// TODO [LOOTA_103] Sunken Chest && Test: Sunken Chest_LOOTA_103
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_104] Reverberating Ooze (*) - COST:4 [ATK:2/HP:4] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Whenever this minion
			//       survives damage, summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_104", new List<Enchantment> {
				// TODO [LOOTA_104] Reverberating Ooze && Test: Reverberating Ooze_LOOTA_104
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_105] Deadly Spore (*) - COST:1 [ATK:1/HP:1] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Poisonous.</b>
			//       <b>Poisonous</b> to heroes.
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_105", new List<Enchantment> {
				// TODO [LOOTA_105] Deadly Spore && Test: Deadly Spore_LOOTA_105
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_107] Shroomsayer (*) - COST:4 [ATK:7/HP:7] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: When this minion
			//       survives damage,
			//       destroy all minions.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - 886 = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_107", new List<Enchantment> {
				// TODO [LOOTA_107] Shroomsayer && Test: Shroomsayer_LOOTA_107
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_109] Gluttonous Trogg (*) - COST:3 [ATK:3/HP:3] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_109", new List<Enchantment> {
				// TODO [LOOTA_109] Gluttonous Trogg && Test: Gluttonous Trogg_LOOTA_109
				new Enchantment
				{
					InfoCardId = "LOOTA_109e",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_816] Party Portal (*) - COST:1 [ATK:0/HP:10] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random minion of the same Cost.
			// --------------------------------------------------------
			cards.Add("LOOTA_816", new List<Enchantment> {
				// TODO [LOOTA_816] Party Portal && Test: Party Portal_LOOTA_816
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_826] Portable Ice Wall (*) - COST:1 [ATK:3/HP:15] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. Can't Attack.
			//        <b>Freeze</b> any character damaged by this_minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - FREEZE = 1
			// - CANT_ATTACK = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_826", new List<Enchantment> {
				// TODO [LOOTA_826] Portable Ice Wall && Test: Portable Ice Wall_LOOTA_826
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_829] Loyal Sidekick (*) - COST:1 [ATK:2/HP:2] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Has +1/+1 for each <b>Boss</b>_you've defeated this_run.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_829", new List<Enchantment> {
				// TODO [LOOTA_829] Loyal Sidekick && Test: Loyal Sidekick_LOOTA_829
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_840] Wax Rager (*) - COST:3 [ATK:5/HP:1] 
			// - Race: elemental, Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_840", new List<Enchantment> {
				// TODO [LOOTA_840] Wax Rager && Test: Wax Rager_LOOTA_840
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_BOSS_18t] Rat (*) - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45894
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_18t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_18t] Rat && Test: Rat_LOOTA_BOSS_18t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_BOSS_20t] Stone Golem (*) - COST:2 [ATK:15/HP:5] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Can't attack.
			//       <b>Deathrattle:</b> Lose a Mana_Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - CANT_ATTACK = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_20t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_20t] Stone Golem && Test: Stone Golem_LOOTA_BOSS_20t
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_BOSS_48t] Sawblade (*) - COST:3 [ATK:3/HP:3] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_48t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_48t] Sawblade && Test: Sawblade_LOOTA_BOSS_48t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_BOSS_49t] Darkspawn (*) - COST:5 [ATK:5/HP:5] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_49t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_49t] Darkspawn && Test: Darkspawn_LOOTA_BOSS_49t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOTA_BOSS_52t] Treasure Coffer (*) - COST:1 [ATK:0/HP:10] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Treasure to the <b>Player's</b> Dungeon Deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_52t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_52t] Treasure Coffer && Test: Treasure Coffer_LOOTA_BOSS_52t
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_800] Potion of Vitality (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Double your
			//       starting Health.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_800", new List<Enchantment> {
				// TODO [LOOTA_800] Potion of Vitality && Test: Potion of Vitality_LOOTA_800
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_801] Crystal Gem (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Start with an extra Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_801", new List<Enchantment> {
				// TODO [LOOTA_801] Crystal Gem && Test: Crystal Gem_LOOTA_801
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_802] Justicar's Ring (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your Hero Power is upgraded and costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_802", new List<Enchantment> {
				// TODO [LOOTA_802] Justicar's Ring && Test: Justicar's Ring_LOOTA_802
				new Enchantment
				{
					InfoCardId = "LOOTA_802e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_803] Scepter of Summoning (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions that
			//       cost (5) or more
			//       cost (5).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_803", new List<Enchantment> {
				// TODO [LOOTA_803] Scepter of Summoning && Test: Scepter of Summoning_LOOTA_803
				new Enchantment
				{
					InfoCardId = "LOOTA_803e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_804] Small Backpacks (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_804", new List<Enchantment> {
				// TODO [LOOTA_804] Small Backpacks && Test: Small Backpacks_LOOTA_804
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_805] Amulet of Domination (*) - COST:2 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Take control of an enemy minion. Add it to your Dungeon Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_805", new List<Enchantment> {
				// TODO [LOOTA_805] Amulet of Domination && Test: Amulet of Domination_LOOTA_805
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_806] Wand of Disintegration (*) - COST:3 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Silence</b> and destroy all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - SILENCE = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_806", new List<Enchantment> {
				// TODO [LOOTA_806] Wand of Disintegration && Test: Wand of Disintegration_LOOTA_806
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_811] Orb of Destruction (*) - COST:3 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Destroy 2 of your opponent's Mana Crystals and they discard 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_811", new List<Enchantment> {
				// TODO [LOOTA_811] Orb of Destruction && Test: Orb of Destruction_LOOTA_811
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_812] Boots of Haste (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your minions cost (0) this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_812", new List<Enchantment> {
				// TODO [LOOTA_812] Boots of Haste && Test: Boots of Haste_LOOTA_812
				new Enchantment
				{
					InfoCardId = "LOOTA_812e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_813] Magic Mirror (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Choose a minion and summon a copy of it. Add it to your Dungeon_Deck.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_813", new List<Enchantment> {
				// TODO [LOOTA_813] Magic Mirror && Test: Magic Mirror_LOOTA_813
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_814] Wish (*) - COST:10 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Fill your board with <b>Legendary</b> minions. Fully heal your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_814", new List<Enchantment> {
				// TODO [LOOTA_814] Wish && Test: Wish_LOOTA_814
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_817] Primordial Wand (*) - COST:4 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]<b>Adapt</b> a friendly minion.
			//       Repeat for each boss
			//       you've defeated this run.@<b>Adapt</b> a friendly minion {0} |4(time, times).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - ADAPT = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_817", new List<Enchantment> {
				// TODO [LOOTA_817] Primordial Wand && Test: Primordial Wand_LOOTA_817
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_818] Grommash's Armguards (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your weapons cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_818", new List<Enchantment> {
				// TODO [LOOTA_818] Grommash's Armguards && Test: Grommash's Armguards_LOOTA_818
				new Enchantment
				{
					InfoCardId = "LOOTA_818e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_820] Aleatoric Cube (*) - COST:2 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Shuffle both decks together and give
			//       half to each player.
			//       Your cards cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_820", new List<Enchantment> {
				// TODO [LOOTA_820] Aleatoric Cube && Test: Aleatoric Cube_LOOTA_820
				new Enchantment
				{
					InfoCardId = "LOOTA_820e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_822] Rod of Roasting (*) - COST:10 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Cast 'Pyroblast' randomly until a_hero_dies.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_822", new List<Enchantment> {
				// TODO [LOOTA_822] Rod of Roasting && Test: Rod of Roasting_LOOTA_822
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_823] Bag of Stuffing (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Draw cards until your hand is full.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_823", new List<Enchantment> {
				// TODO [LOOTA_823] Bag of Stuffing && Test: Bag of Stuffing_LOOTA_823
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_824] Khadgar's Scrying Orb (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your spells cost (1)_less.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_824", new List<Enchantment> {
				// TODO [LOOTA_824] Khadgar's Scrying Orb && Test: Khadgar's Scrying Orb_LOOTA_824
				new Enchantment
				{
					InfoCardId = "LOOTA_824e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_825] Robe of the Magi (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       <b>Spell Damage +3</b>
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_825", new List<Enchantment> {
				// TODO [LOOTA_825] Robe of the Magi && Test: Robe of the Magi_LOOTA_825
				new Enchantment
				{
					InfoCardId = "LOOTA_825e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_827] Embers of Ragnaros (*) - COST:3 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Shoot three fireballs at random enemies that deal $8 damage each. @spelldmg
			// --------------------------------------------------------
			cards.Add("LOOTA_827", new List<Enchantment> {
				// TODO [LOOTA_827] Embers of Ragnaros && Test: Embers of Ragnaros_LOOTA_827
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_828] Captured Flag (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions have_+1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - RITUAL = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_828", new List<Enchantment> {
				// TODO [LOOTA_828] Captured Flag && Test: Captured Flag_LOOTA_828
				new Enchantment
				{
					InfoCardId = "LOOTA_828e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_830] Shifting Hourglass (*) - COST:7 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]Take an extra turn.
			//       Costs (1) less for each 
			//       <b>Boss</b> you've defeated
			//       this run.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_830", new List<Enchantment> {
				// TODO [LOOTA_830] Shifting Hourglass && Test: Shifting Hourglass_LOOTA_830
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_831] Glyph of Warding (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Enemy minions cost (1)_more.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_831", new List<Enchantment> {
				// TODO [LOOTA_831] Glyph of Warding && Test: Glyph of Warding_LOOTA_831
				new Enchantment
				{
					InfoCardId = "LOOTA_831e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_832] Cloak of Invisibility (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your minions have permanent <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_832", new List<Enchantment> {
				// TODO [LOOTA_832] Cloak of Invisibility && Test: Cloak of Invisibility_LOOTA_832
				new Enchantment
				{
					InfoCardId = "LOOTA_832e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_833] Mysterious Tome (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       At the start of the game, play 3 random <b>Secrets</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_833", new List<Enchantment> {
				// TODO [LOOTA_833] Mysterious Tome && Test: Mysterious Tome_LOOTA_833
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_834] Gloves of Mugging (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Steal 3 cards from your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_834", new List<Enchantment> {
				// TODO [LOOTA_834] Gloves of Mugging && Test: Gloves of Mugging_LOOTA_834
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_836] Bag of Coins (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Fill your hand with_Coins.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_836", new List<Enchantment> {
				// TODO [LOOTA_836] Bag of Coins && Test: Bag of Coins_LOOTA_836
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_837] Horn of Cenarius (*) - COST:2 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Recruit</b> 3 minions.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_837", new List<Enchantment> {
				// TODO [LOOTA_837] Horn of Cenarius && Test: Horn of Cenarius_LOOTA_837
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_838] Dr. Boom's Boombox (*) - COST:4 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]Summon 7 'Boom Bots'.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_838", new List<Enchantment> {
				// TODO [LOOTA_838] Dr. Boom's Boombox && Test: Dr. Boom's Boombox_LOOTA_838
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_839] Scroll of Confusion (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Each minion randomly chooses a side of_the_battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_839", new List<Enchantment> {
				// TODO [LOOTA_839] Scroll of Confusion && Test: Scroll of Confusion_LOOTA_839
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_841] Portable Forge (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Legendary weapon and equip it.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_841", new List<Enchantment> {
				// TODO [LOOTA_841] Portable Forge && Test: Portable Forge_LOOTA_841
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_842b] Hilt of Quel'Delar (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Give a minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_842b", new List<Enchantment> {
				// TODO [LOOTA_842b] Hilt of Quel'Delar && Test: Hilt of Quel'Delar_LOOTA_842b
				new Enchantment
				{
					InfoCardId = "LOOTA_842be",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_842t] Forging Quel'Delar (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOTA_842t", new List<Enchantment> {
				// TODO [LOOTA_842t] Forging Quel'Delar && Test: Forging Quel'Delar_LOOTA_842t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_843] THE CANDLE (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to all enemy minions. Shuffle this into your deck. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_843", new List<Enchantment> {
				// TODO [LOOTA_843] THE CANDLE && Test: THE CANDLE_LOOTA_843
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_845] Totem of the Dead (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Deathrattles</b> trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_845", new List<Enchantment> {
				// TODO [LOOTA_845] Totem of the Dead && Test: Totem of the Dead_LOOTA_845
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_846] Battle Totem (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Passive</b>
			//       Your <b>Battlecries</b> trigger_twice.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// - HIDE_STATS = 1
			// - DUNGEON_PASSIVE_BUFF = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOTA_846", new List<Enchantment> {
				// TODO [LOOTA_846] Battle Totem && Test: Battle Totem_LOOTA_846
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_847] Mask of Mimicry (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Choose a minion.
			//       Minions in your hand becomes copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 229
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOTA_847", new List<Enchantment> {
				// TODO [LOOTA_847] Mask of Mimicry && Test: Mask of Mimicry_LOOTA_847
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p2] Beam of Frost (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a random enemy minion and the minions next to it.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p2", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p2] Beam of Frost && Test: Beam of Frost_LOOTA_BOSS_26p2
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p3] Beam of Death (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Destroy all damaged enemy minions.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p3", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p3] Beam of Death && Test: Beam of Death_LOOTA_BOSS_26p3
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p4] Beam of Confusion (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Take control of a random enemy minion.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p4", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p4] Beam of Confusion && Test: Beam of Confusion_LOOTA_BOSS_26p4
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p5] Beam of Fear (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Shuffle a random enemy minion into your opponent's deck.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p5", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p5] Beam of Fear && Test: Beam of Fear_LOOTA_BOSS_26p5
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p6] Beam of Fire (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p6", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p6] Beam of Fire && Test: Beam of Fire_LOOTA_BOSS_26p6
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_26p7] Beam of Decay (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Destroy 1 of your_opponent's Mana_Crystal.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_26p7", new List<Enchantment> {
				// TODO [LOOTA_BOSS_26p7] Beam of Decay && Test: Beam of Decay_LOOTA_BOSS_26p7
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_49t2] Luminous Candle (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Destroy all Darkspawns.
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_49t2", new List<Enchantment> {
				// TODO [LOOTA_BOSS_49t2] Luminous Candle && Test: Luminous Candle_LOOTA_BOSS_49t2
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_50t] Mushroom Potion (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_50t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_50t] Mushroom Potion && Test: Mushroom Potion_LOOTA_BOSS_50t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOTA_BOSS_99t] Rakanishu (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to a random enemy. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - 793 = 1569
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_99t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_99t] Rakanishu && Test: Rakanishu_LOOTA_BOSS_99t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_819] Archmage Staff (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]At the start of your turn,
			//       add a random Mage
			//       spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_819", new List<Enchantment> {
				// TODO [LOOTA_819] Archmage Staff && Test: Archmage Staff_LOOTA_819
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_821] Vorpal Dagger (*) - COST:2 [ATK:1/HP:0] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Mega-Windfury</b>
			//        <i>(Can attack four times a turn.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// - POISONOUS = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_821", new List<Enchantment> {
				// TODO [LOOTA_821] Vorpal Dagger && Test: Vorpal Dagger_LOOTA_821
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_835] Greedy Pickaxe (*) - COST:2 [ATK:3/HP:0] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: After your hero attacks, gain an empty Mana_Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOTA_835", new List<Enchantment> {
				// TODO [LOOTA_835] Greedy Pickaxe && Test: Greedy Pickaxe_LOOTA_835
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_842] Quel'Delar (*) - COST:1 [ATK:6/HP:0] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: After your hero attacks, deal 6 damage to all_enemies.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 6
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_842", new List<Enchantment> {
				// TODO [LOOTA_842] Quel'Delar && Test: Quel'Delar_LOOTA_842
				new Enchantment
				{
					InfoCardId = "LOOTA_842be",
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_842a] Blade of Quel'Delar (*) - COST:1 [ATK:3/HP:0] 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOOTA_842a", new List<Enchantment> {
				// TODO [LOOTA_842a] Blade of Quel'Delar && Test: Blade of Quel'Delar_LOOTA_842a
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOOTA_BOSS_22t] Tad's Pole (*) - COST:1 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       summon a minion
			//       from your
			//       opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// - HERO_POWER = 229
			// --------------------------------------------------------
			cards.Add("LOOTA_BOSS_22t", new List<Enchantment> {
				// TODO [LOOTA_BOSS_22t] Tad's Pole && Test: Tad's Pole_LOOTA_BOSS_22t
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
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
