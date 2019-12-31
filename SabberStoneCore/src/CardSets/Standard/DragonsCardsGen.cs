using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Triggers;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Standard
{
	public class DragonsCardsGen
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - WARLOCK
			// [DRG_600] Galakrond, the Wretched - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon
			//       1 random Demon.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55807
			// - 676 = 1
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_600", new CardDef(new Power
			{
				// TODO [DRG_600] Galakrond, the Wretched && Test: Galakrond, the Wretched_DRG_600
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DRG_600t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon
			//       2 random Demons.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55807
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_600t2", new CardDef(new Power
			{
				// TODO [DRG_600t2] Galakrond, the Apocalypse && Test: Galakrond, the Apocalypse_DRG_600t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARLOCK
			// [DRG_600t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon
			//       4 random Demons.
			//       Equip a 5/2 Claw.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55807
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_600t3", new CardDef(new Power
			{
				// TODO [DRG_600t3] Galakrond, Azeroth's End && Test: Galakrond, Azeroth's End_DRG_600t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DRG_610] Galakrond, the Nightmare - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 1 card.
			//       It costs (0).
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55806
			// - 676 = 1
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_610", new CardDef(new Power
			{
				// TODO [DRG_610] Galakrond, the Nightmare && Test: Galakrond, the Nightmare_DRG_610
				InfoCardId = "DRG_610e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DRG_610t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 2 cards.
			//       They cost (0).
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55806
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_610t2", new CardDef(new Power
			{
				// TODO [DRG_610t2] Galakrond, the Apocalypse && Test: Galakrond, the Apocalypse_DRG_610t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- HERO - ROGUE
			// [DRG_610t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 4 cards.
			//       They cost (0).
			//       Equip a 5/2 Claw.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55806
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_610t3", new CardDef(new Power
			{
				// TODO [DRG_610t3] Galakrond, Azeroth's End && Test: Galakrond, Azeroth's End_DRG_610t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DRG_620] Galakrond, the Tempest - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two
			//       2/2 Storms with <b>Rush</b>.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55808
			// - 676 = 1
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620", new CardDef(new Power
			{
				// TODO [DRG_620] Galakrond, the Tempest && Test: Galakrond, the Tempest_DRG_620
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DRG_620t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two
			//       4/4 Storms with <b>Rush</b>.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55808
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620t2", new CardDef(new Power
			{
				// TODO [DRG_620t2] Galakrond, the Apocalypse && Test: Galakrond, the Apocalypse_DRG_620t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - SHAMAN
			// [DRG_620t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two
			//       8/8 Storms with <b>Rush</b>.
			//       Equip a 5/2 Claw.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55808
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620t3", new CardDef(new Power
			{
				// TODO [DRG_620t3] Galakrond, Azeroth's End && Test: Galakrond, Azeroth's End_DRG_620t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DRG_650] Galakrond, the Unbreakable - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 1 minion.
			//       Give it +4/+4.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55805
			// - 676 = 1
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_650", new CardDef(new Power
			{
				// TODO [DRG_650] Galakrond, the Unbreakable && Test: Galakrond, the Unbreakable_DRG_650
				InfoCardId = "DRG_650e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DRG_650t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 2 minions.
			//       Give them +4/+4.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55805
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_650t2", new CardDef(new Power
			{
				// TODO [DRG_650t2] Galakrond, the Apocalypse && Test: Galakrond, the Apocalypse_DRG_650t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [DRG_650t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw 4 minions.
			//       Give them +4/+4.
			//       Equip a 5/2 Claw.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55805
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_650t3", new CardDef(new Power
			{
				// TODO [DRG_650t3] Galakrond, Azeroth's End && Test: Galakrond, Azeroth's End_DRG_650t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DRG_660] Galakrond, the Unspeakable - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy 1
			//       random enemy minion.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55810
			// - 676 = 1
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_660", new CardDef(new Power
			{
				// TODO [DRG_660] Galakrond, the Unspeakable && Test: Galakrond, the Unspeakable_DRG_660
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DRG_660t2] Galakrond, the Apocalypse (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy 2
			//       random enemy minions.
			//       <i>(@)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55810
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_660t2", new CardDef(new Power
			{
				// TODO [DRG_660t2] Galakrond, the Apocalypse && Test: Galakrond, the Apocalypse_DRG_660t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ HERO - PRIEST
			// [DRG_660t3] Galakrond, Azeroth's End (*) - COST:7 [ATK:0/HP:30]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy 4
			//       random enemy minions.
			//       Equip a 5/2 Claw.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 55810
			// - GALAKROND_HERO_CARD = 1
			// --------------------------------------------------------
			cards.Add("DRG_660t3", new CardDef(new Power
			{
				// TODO [DRG_660t3] Galakrond, Azeroth's End && Test: Galakrond, Azeroth's End_DRG_660t3
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - WARRIOR
			// [DRG_238p] Galakrond's Might (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your hero +3_Attack this turn.
			// --------------------------------------------------------
			cards.Add("DRG_238p", new CardDef(new Power
			{
				// TODO [DRG_238p] Galakrond's Might && Test: Galakrond's Might_DRG_238p
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------- HERO_POWER - ROGUE
			// [DRG_238p2] Galakrond's Guile (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a <b>Lackey</b> to
			//       your hand.
			// --------------------------------------------------------
			cards.Add("DRG_238p2", new CardDef(new Power
			{
				// TODO [DRG_238p2] Galakrond's Guile && Test: Galakrond's Guile_DRG_238p2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARLOCK
			// [DRG_238p3] Galakrond's Malice (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon two 1/1 Imps.
			// --------------------------------------------------------
			cards.Add("DRG_238p3", new CardDef(new Power
			{
				// TODO [DRG_238p3] Galakrond's Malice && Test: Galakrond's Malice_DRG_238p3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - SHAMAN
			// [DRG_238p4] Galakrond's Fury (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 2/1 Elemental with <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_238p4", new CardDef(new Power
			{
				// TODO [DRG_238p4] Galakrond's Fury && Test: Galakrond's Fury_DRG_238p4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------ HERO_POWER - PRIEST
			// [DRG_238p5] Galakrond's Wit (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Priest minion to your hand.
			// --------------------------------------------------------
			cards.Add("DRG_238p5", new CardDef(new Power
			{
				// TODO [DRG_238p5] Galakrond's Wit && Test: Galakrond's Wit_DRG_238p5
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Druid(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [DRG_312] Shrubadier - COST:2 [ATK:1/HP:1]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/2_Treant.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_312", new CardDef(new Power
			{
				// TODO [DRG_312] Shrubadier && Test: Shrubadier_DRG_312
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [DRG_313] Emerald Explorer - COST:6 [ATK:4/HP:8]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_313", new CardDef(new Power
			{
				// TODO [DRG_313] Emerald Explorer && Test: Emerald Explorer_DRG_313
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [DRG_319] Goru the Mightree - COST:7 [ATK:5/HP:10]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> For the rest of
			//       the game, your Treants
			//       have +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_319", new CardDef(new Power
			{
				// TODO [DRG_319] Goru the Mightree && Test: Goru the Mightree_DRG_319
				InfoCardId = "DRG_319e4",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - DRUID
			// [DRG_320] Ysera, Unleashed - COST:9 [ATK:4/HP:12]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 7 Dream
			//       Portals into your deck.
			//       When drawn, summon
			//       a random Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_320", new CardDef(new Power
			{
				// TODO [DRG_320] Ysera, Unleashed && Test: Ysera, Unleashed_DRG_320
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_051] Strength in Numbers - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Sidequest:</b> Spend 10 Mana on minions.
			//       <b>Reward:</b> Summon a minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 10
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_051", new CardDef(new Power
			{
				// TODO [DRG_051] Strength in Numbers && Test: Strength in Numbers_DRG_051
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_311] Treenforcements - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Give a
			//       minion +2 Health and
			//       <b>Taunt</b>; or Summon a
			//       2/2 Treant.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_311", new CardDef(new Power
			{
				// TODO [DRG_311] Treenforcements && Test: Treenforcements_DRG_311
				InfoCardId = "DRG_311e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_314] Aeroponics - COST:5
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			//       Costs (2) less for each Treant you control.
			// --------------------------------------------------------
			cards.Add("DRG_314", new CardDef(new Power
			{
				// TODO [DRG_314] Aeroponics && Test: Aeroponics_DRG_314
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_315] Embiggen - COST:0
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Give all minions in your deck +2/+2. They cost (1) more <i>(up to 10)</i>.
			// --------------------------------------------------------
			cards.Add("DRG_315", new CardDef(new Power
			{
				// TODO [DRG_315] Embiggen && Test: Embiggen_DRG_315
				//PowerTask = ComplexTask.Create(
				//	new FlagTask(true, ComplexTask.Create(
				//		new IncludeTask(EntityType.DECK),
				//		new FilterStackTask(SelfCondition.IsMinion),
				//		new AddEnchantmentTask("DRG_315e", EntityType.STACK))))
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_317] Secure the Deck - COST:1
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Sidequest:</b> Attack twice with your hero. <b>Reward:</b> Add 3 'Claw' spells to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 2
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_317", new CardDef(new Power
			{
				// TODO [DRG_317] Secure the Deck && Test: Secure the Deck_DRG_317
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_318] Breath of Dreams - COST:2
			// - Fac: neutral, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card. If you're holding a Dragon, gain an empty Mana Crystal.
			// --------------------------------------------------------
			cards.Add("DRG_318", new CardDef(new Power
			{
				// TODO [DRG_318] Breath of Dreams && Test: Breath of Dreams_DRG_318
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void DruidNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [DRG_315e] Embiggened (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DRG_315e", new CardDef(new Power
			{
				// TODO [DRG_315e] Embiggened && Test: Embiggened_DRG_315e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_315e")
			}));

			// ------------------------------------ ENCHANTMENT - DRUID
			// [DRG_315e2] Costly Embiggening (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			cards.Add("DRG_315e2", new CardDef(new Power
			{
				// TODO [DRG_315e2] Costly Embiggening && Test: Costly Embiggening_DRG_315e2
				Enchant = new Enchant(Effects.AddCost(1))
			}));

			// ----------------------------------------- MINION - DRUID
			// [DRG_311t] Treant (*) - COST:2 [ATK:2/HP:2]
			// - Fac: neutral, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_311t", new CardDef(new Power
			{
				// TODO [DRG_311t] Treant && Test: Treant_DRG_311t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_311a] Spin 'em Up (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Summon a 2/2 Treant.
			// --------------------------------------------------------
			cards.Add("DRG_311a", new CardDef(new Power
			{
				// TODO [DRG_311a] Spin 'em Up && Test: Spin 'em Up_DRG_311a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_311b] Small Repairs (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Give a minion +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_311b", new CardDef(new Power
			{
				// TODO [DRG_311b] Small Repairs && Test: Small Repairs_DRG_311b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - DRUID
			// [DRG_320t] Dream Portal (*) - COST:9
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Summon a random Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("DRG_320t", new CardDef(new Power
			{
				// TODO [DRG_320t] Dream Portal && Test: Dream Portal_DRG_320t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Hunter(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [DRG_010] Diving Gryphon - COST:3 [ATK:4/HP:1]
			// - Race: beast, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Draw a <b>Rush</b> minion_from_your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_010", new CardDef(new Power
			{
				// TODO [DRG_010] Diving Gryphon && Test: Diving Gryphon_DRG_010
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_095] Veranus - COST:6 [ATK:7/HP:6]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Change the Health of all enemy minions to 1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_095", new CardDef(new Power
			{
				// TODO [DRG_095] Veranus && Test: Veranus_DRG_095
				InfoCardId = "DRG_095e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_252] Phase Stalker - COST:2 [ATK:2/HP:3]
			// - Race: beast, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you use your Hero
			//       Power, cast a <b>Secret</b>
			//       from your deck.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("DRG_252", new CardDef(new Power
			{
				// TODO [DRG_252] Phase Stalker && Test: Phase Stalker_DRG_252
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_253] Dwarven Sharpshooter - COST:1 [ATK:1/HP:3]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Your Hero Power can target_minions.
			// --------------------------------------------------------
			cards.Add("DRG_253", new CardDef(new Power
			{
				// TODO [DRG_253] Dwarven Sharpshooter && Test: Dwarven Sharpshooter_DRG_253
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_254] Primordial Explorer - COST:3 [ATK:2/HP:3]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - POISONOUS = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_254", new CardDef(new Power
			{
				// TODO [DRG_254] Primordial Explorer && Test: Primordial Explorer_DRG_254
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_256] Dragonbane - COST:4 [ATK:3/HP:5]
			// - Race: mechanical, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you use your Hero Power, deal 5 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_256", new CardDef(new Power
			{
				// TODO [DRG_256] Dragonbane && Test: Dragonbane_DRG_256
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DRG_006] Corrosive Breath - COST:2
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Deal $3 damage to a
			//       minion. If you're holding
			//       a Dragon, it also hits
			//       the enemy hero. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_006", new CardDef(new Power
			{
				// TODO [DRG_006] Corrosive Breath && Test: Corrosive Breath_DRG_006
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DRG_251] Clear the Way - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Sidequest:</b> Summon
			//       3 <b>Rush</b> minions.
			//       <b>Reward:</b> Summon a
			//       4/4 Gryphon with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 3
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_251", new CardDef(new Power
			{
				// TODO [DRG_251] Clear the Way && Test: Clear the Way_DRG_251
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - HUNTER
			// [DRG_255] Toxic Reinforcements - COST:1
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Sidequest:</b> Use your Hero
			//       Power three times.
			//       <b>Reward:</b> Summon three
			//       1/1 Leper Gnomes.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 3
			// - QUEST_REWARD_DATABASE_ID = 41127
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_255", new CardDef(new Power
			{
				// TODO [DRG_255] Toxic Reinforcements && Test: Toxic Reinforcements_DRG_255
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- WEAPON - HUNTER
			// [DRG_007] Stormhammer - COST:3 [ATK:3/HP:0]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Doesn't lose Durability while you control a_Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("DRG_007", new CardDef(new Power
			{
				// TODO [DRG_007] Stormhammer && Test: Stormhammer_DRG_007
				InfoCardId = "DRG_007e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [DRG_095e] Intimidated (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			cards.Add("DRG_095e", new CardDef(new Power
			{
				// TODO [DRG_095e] Intimidated && Test: Intimidated_DRG_095e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_095e")
			}));

			// ---------------------------------------- MINION - HUNTER
			// [DRG_251t] Gryphon (*) - COST:4 [ATK:4/HP:4]
			// - Race: beast, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_251t", new CardDef(new Power
			{
				// TODO [DRG_251t] Gryphon && Test: Gryphon_DRG_251t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Mage(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [DRG_102] Azure Explorer - COST:4 [ATK:2/HP:3]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_102", new CardDef(new Power
			{
				// TODO [DRG_102] Azure Explorer && Test: Azure Explorer_DRG_102
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_104] Chenvaala - COST:3 [ATK:2/HP:5]
			// - Race: elemental, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast three spells in a turn, summon a 5/5_Elemental.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_104", new CardDef(new Power
			{
				// TODO [DRG_104] Chenvaala && Test: Chenvaala_DRG_104
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_107] Violet Spellwing - COST:1 [ATK:1/HP:1]
			// - Race: elemental, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add an 'Arcane Missiles' spell to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_107", new CardDef(new Power
			{
				// TODO [DRG_107] Violet Spellwing && Test: Violet Spellwing_DRG_107
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_109] Mana Giant - COST:8 [ATK:8/HP:8]
			// - Race: elemental, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Costs (1) less for each
			//       card you've played this
			//       game that didn't start
			//       in your deck.
			// --------------------------------------------------------
			cards.Add("DRG_109", new CardDef(new Power
			{
				// TODO [DRG_109] Mana Giant && Test: Mana Giant_DRG_109
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_270] Malygos, Aspect of Magic - COST:5 [ATK:2/HP:8]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding
			//       a Dragon, <b>Discover</b> an
			//        upgraded Mage spell.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_270", new CardDef(new Power
			{
				// TODO [DRG_270] Malygos, Aspect of Magic && Test: Malygos, Aspect of Magic_DRG_270
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_322] Dragoncaster - COST:6 [ATK:4/HP:4]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, your next spell this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_322", new CardDef(new Power
			{
				// TODO [DRG_322] Dragoncaster && Test: Dragoncaster_DRG_322
				InfoCardId = "DRG_322e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_106] Arcane Breath - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If you're holding a Dragon, <b>Discover</b> a spell. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_106", new CardDef(new Power
			{
				// TODO [DRG_106] Arcane Breath && Test: Arcane Breath_DRG_106
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_321] Rolling Fireball - COST:5
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $8 damage to a minion. Any excess damage continues to
			//       the left or right. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("DRG_321", new CardDef(new Power
			{
				// TODO [DRG_321] Rolling Fireball && Test: Rolling Fireball_DRG_321
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_323] Learn Draconic - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Sidequest:</b> Spend
			//       8 Mana on spells.
			//       <b>Reward:</b> Summon a
			//       6/6 Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 8
			// - QUEST_REWARD_DATABASE_ID = 55282
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_323", new CardDef(new Power
			{
				// TODO [DRG_323] Learn Draconic && Test: Learn Draconic_DRG_323
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_324] Elemental Allies - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Sidequest:</b> Play an
			//       Elemental 2 turns in a row.
			//       <b>Reward:</b> Draw 3 spells
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 2
			// - QUEST_REWARD_DATABASE_ID = 395
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_324", new CardDef(new Power
			{
				// TODO [DRG_324] Elemental Allies && Test: Elemental Allies_DRG_324
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [DRG_322e] Draconic Magic (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("DRG_322e", new CardDef(new Power
			{
				// TODO [DRG_322e] Draconic Magic && Test: Draconic Magic_DRG_322e
				Aura = new Aura(AuraType.HAND, Effects.SetCost(0))
				{
					RemoveTrigger = (TriggerType.CAST_SPELL, null)
				}
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_104t2] Snow Elemental (*) - COST:5 [ATK:5/HP:5]
			// - Race: elemental, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_104t2", new CardDef(new Power
			{
				// TODO [DRG_104t2] Snow Elemental && Test: Snow Elemental_DRG_104t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_270t6t] Malygos's Sheep (*) - COST:1 [ATK:1/HP:1]
			// - Race: beast, Fac: neutral, Set: dragons,
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t6t", new CardDef(new Power
			{
				// TODO [DRG_270t6t] Malygos's Sheep && Test: Malygos's Sheep_DRG_270t6t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ MINION - MAGE
			// [DRG_323t] Draconic Emissary (*) - COST:6 [ATK:6/HP:6]
			// - Race: dragon, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_323t", new CardDef(new Power
			{
				// TODO [DRG_323t] Draconic Emissary && Test: Draconic Emissary_DRG_323t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t1] Malygos's Intellect (*) - COST:3
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t1", new CardDef(new Power
			{
				// TODO [DRG_270t1] Malygos's Intellect && Test: Malygos's Intellect_DRG_270t1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t11] Malygos's Missiles (*) - COST:1
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal $6 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t11", new CardDef(new Power
			{
				// TODO [DRG_270t11] Malygos's Missiles && Test: Malygos's Missiles_DRG_270t11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t2] Malygos's Tome (*) - COST:1
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Add 3 random Mage spells to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t2", new CardDef(new Power
			{
				// TODO [DRG_270t2] Malygos's Tome && Test: Malygos's Tome_DRG_270t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t4] Malygos's Explosion (*) - COST:2
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal $2 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t4", new CardDef(new Power
			{
				// TODO [DRG_270t4] Malygos's Explosion && Test: Malygos's Explosion_DRG_270t4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t5] Malygos's Nova (*) - COST:1
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Freeze</b> all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t5", new CardDef(new Power
			{
				// TODO [DRG_270t5] Malygos's Nova && Test: Malygos's Nova_DRG_270t5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t6] Malygos's Polymorph (*) - COST:1
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Transform a minion
			//       into a 1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t6", new CardDef(new Power
			{
				// TODO [DRG_270t6] Malygos's Polymorph && Test: Malygos's Polymorph_DRG_270t6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t7] Malygos's Flamestrike (*) - COST:7
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal $8 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t7", new CardDef(new Power
			{
				// TODO [DRG_270t7] Malygos's Flamestrike && Test: Malygos's Flamestrike_DRG_270t7
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t8] Malygos's Frostbolt (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal $3 damage to a_character and <b>Freeze</b> it. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t8", new CardDef(new Power
			{
				// TODO [DRG_270t8] Malygos's Frostbolt && Test: Malygos's Frostbolt_DRG_270t8
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [DRG_270t9] Malygos's Fireball (*) - COST:4
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal $8 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_270t9", new CardDef(new Power
			{
				// TODO [DRG_270t9] Malygos's Fireball && Test: Malygos's Fireball_DRG_270t9
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Paladin(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [DRG_225] Sky Claw - COST:3 [ATK:1/HP:2]
			// - Race: mechanical, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Your other Mechs
			//       have +1 Attack.
			//       <b>Battlecry:</b> Summon two 1/1 Microcopters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DRG_225", new CardDef(new Power
			{
				// TODO [DRG_225] Sky Claw && Test: Sky Claw_DRG_225
				InfoCardId = "DRG_225e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_226] Amber Watcher - COST:5 [ATK:4/HP:6]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore #8_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_226", new CardDef(new Power
			{
				// TODO [DRG_226] Amber Watcher && Test: Amber Watcher_DRG_226
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_229] Bronze Explorer - COST:3 [ATK:2/HP:3]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Battlecry:</b> <b>Discover</b> a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - LIFESTEAL = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_229", new CardDef(new Power
			{
				// TODO [DRG_229] Bronze Explorer && Test: Bronze Explorer_DRG_229
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_231] Lightforged Crusader - COST:7 [ATK:7/HP:7]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck
			//       has no Neutral cards,
			//       add 5 random Paladin
			//       cards to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_231", new CardDef(new Power
			{
				// TODO [DRG_231] Lightforged Crusader && Test: Lightforged Crusader_DRG_231
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_232] Lightforged Zealot - COST:4 [ATK:4/HP:2]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no Neutral cards, equip a __4/2_Truesilver_Champion._
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_232", new CardDef(new Power
			{
				// TODO [DRG_232] Lightforged Zealot && Test: Lightforged Zealot_DRG_232
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_235] Dragonrider Talritha - COST:3 [ATK:3/HP:3]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a Dragon in your hand +3/+3 and this <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_235", new CardDef(new Power
			{
				// TODO [DRG_235] Dragonrider Talritha && Test: Dragonrider Talritha_DRG_235
				InfoCardId = "DRG_235e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_309] Nozdormu the Timeless - COST:4 [ATK:8/HP:8]
			// - Race: dragon, Fac: neutral, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Set each player to 10 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_309", new CardDef(new Power
			{
				// TODO [DRG_309] Nozdormu the Timeless && Test: Nozdormu the Timeless_DRG_309
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DRG_008] Righteous Cause - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Sidequest:</b> Summon 5 minions.
			//       <b>Reward:</b> Give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 5
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			cards.Add("DRG_008", new CardDef(new Power
			{
				// TODO [DRG_008] Righteous Cause && Test: Righteous Cause_DRG_008
				InfoCardId = "DRG_008e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DRG_233] Sand Breath - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Give a minion +1/+2.
			//       Give it <b>Divine Shield</b> if
			//       you're holding a Dragon.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("DRG_233", new CardDef(new Power
			{
				// TODO [DRG_233] Sand Breath && Test: Sand Breath_DRG_233
				InfoCardId = "DRG_233e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - PALADIN
			// [DRG_258] Sanctuary - COST:2
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Sidequest:</b> Take no
			//       damage for a turn.
			//       <b>Reward:</b> Summon a 3/6
			//       minion with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - QUEST_PROGRESS_TOTAL = 1
			// - QUEST_REWARD_DATABASE_ID = 57723
			// - SIDEQUEST = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_258", new CardDef(new Power
			{
				// TODO [DRG_258] Sanctuary && Test: Sanctuary_DRG_258
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PaladinNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [DRG_225t] Microcopter (*) - COST:1 [ATK:1/HP:1]
			// - Race: mechanical, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_225t", new CardDef(new Power
			{
				// TODO [DRG_225t] Microcopter && Test: Microcopter_DRG_225t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - PALADIN
			// [DRG_258t] Indomitable Champion (*) - COST:4 [ATK:3/HP:6]
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_258t", new CardDef(new Power
			{
				// TODO [DRG_258t] Indomitable Champion && Test: Indomitable Champion_DRG_258t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - PALADIN
			// [DRG_232t] Truesilver Champion (*) - COST:4 [ATK:4/HP:0]
			// - Fac: neutral, Set: dragons, Rarity: free
			// --------------------------------------------------------
			// Text: Whenever your hero attacks, restore #2_Health to it.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("DRG_232t", new CardDef(new Power
			{
				// TODO [DRG_232t] Truesilver Champion && Test: Truesilver Champion_DRG_232t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Priest(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [DRG_090] Murozond the Infinite - COST:8 [ATK:8/HP:8]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Play all cards your opponent played last_turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_090", new CardDef(new Power
			{
				// TODO [DRG_090] Murozond the Infinite && Test: Murozond the Infinite_DRG_090
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DRG_300] Fate Weaver - COST:4 [ATK:3/HP:6]
			// - Race: dragon, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
			//       twice, reduce the Cost of
			//       cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_300", new CardDef(new Power
			{
				// TODO [DRG_300] Fate Weaver && Test: Fate Weaver_DRG_300
				InfoCardId = "DRG_300e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DRG_303] Disciple of Galakrond - COST:1 [ATK:1/HP:2]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_303", new CardDef(new Power
			{
				// TODO [DRG_303] Disciple of Galakrond && Test: Disciple of Galakrond_DRG_303
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DRG_304] Chronobreaker - COST:5 [ATK:4/HP:5]
			// - Race: dragon, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> If you're holding
			//       a Dragon, deal 3 damage
			//       to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_304", new CardDef(new Power
			{
				// TODO [DRG_304] Chronobreaker && Test: Chronobreaker_DRG_304
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DRG_306] Envoy of Lazul - COST:2 [ATK:2/HP:2]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Look at 3 cards.
			//       Guess which one is in
			//       your opponent's hand
			//       to get a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_306", new CardDef(new Power
			{
				// TODO [DRG_306] Envoy of Lazul && Test: Envoy of Lazul_DRG_306
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - PRIEST
			// [DRG_308] Mindflayer Kaahrj - COST:3 [ATK:3/HP:3]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose an
			//       enemy minion.
			//       <b>Deathrattle:</b> Summon a new copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_308", new CardDef(new Power
			{
				// TODO [DRG_308] Mindflayer Kaahrj && Test: Mindflayer Kaahrj_DRG_308
				InfoCardId = "DRG_308e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DRG_246] Time Rip - COST:5
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy a minion.
			//       <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_246", new CardDef(new Power
			{
				// TODO [DRG_246] Time Rip && Test: Time Rip_DRG_246
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DRG_301] Whispers of EVIL - COST:0
			// - Fac: neutral, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Add a <b>Lackey</b> to your_hand.
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DRG_301", new CardDef(new Power
			{
				// TODO [DRG_301] Whispers of EVIL && Test: Whispers of EVIL_DRG_301
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DRG_302] Grave Rune - COST:4
			// - Fac: neutral, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Summon 2 copies of this."
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_302", new CardDef(new Power
			{
				// TODO [DRG_302] Grave Rune && Test: Grave Rune_DRG_302
				InfoCardId = "DRG_302e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - PRIEST
			// [DRG_307] Breath of the Infinite - COST:3
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all minions. If you're holding a Dragon, only damage enemies. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_307", new CardDef(new Power
			{
				// TODO [DRG_307] Breath of the Infinite && Test: Breath of the Infinite_DRG_307
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void PriestNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [DRG_300e] Draconic Fate (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("DRG_300e", new CardDef(new Power
			{
				// TODO [DRG_300e] Draconic Fate && Test: Draconic Fate_DRG_300e
				Enchant = new Enchant(Effects.ReduceCost(1))
			}));

		}

		private static void Rogue(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [DRG_027] Umbral Skulker - COST:4 [ATK:3/HP:3]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
			//       twice, add 3 Coins to
			//       your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_027", new CardDef(new Power
			{
				// TODO [DRG_027] Umbral Skulker && Test: Umbral Skulker_DRG_027
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_031] Necrium Apothecary - COST:4 [ATK:2/HP:5]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Draw a <b>Deathrattle</b> minion from your deck and gain its <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_031", new CardDef(new Power
			{
				// TODO [DRG_031] Necrium Apothecary && Test: Necrium Apothecary_DRG_031
				InfoCardId = "DRG_031e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_034] Stowaway - COST:5 [ATK:4/HP:4]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If there are cards
			//       in your deck that didn't start
			//       there, draw 2 of them.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_034", new CardDef(new Power
			{
				// TODO [DRG_034] Stowaway && Test: Stowaway_DRG_034
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_035] Bloodsail Flybooter - COST:1 [ATK:1/HP:1]
			// - Race: pirate, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add two 1/1 Pirates to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_035", new CardDef(new Power
			{
				// TODO [DRG_035] Bloodsail Flybooter && Test: Bloodsail Flybooter_DRG_035
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_036] Waxadred - COST:5 [ATK:7/HP:5]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Shuffle a
			//       Candle into your deck that
			//       resummons Waxadred
			//       when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_036", new CardDef(new Power
			{
				// TODO [DRG_036] Waxadred && Test: Waxadred_DRG_036
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_037] Flik Skyshiv - COST:6 [ATK:4/HP:4]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Destroy a
			//       minion and all copies of it
			//       <i>(wherever they are)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_037", new CardDef(new Power
			{
				// TODO [DRG_037] Flik Skyshiv && Test: Flik Skyshiv_DRG_037
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DRG_028] Dragon's Hoard - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Legendary</b>_minion from another class.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_028", new CardDef(new Power
			{
				// TODO [DRG_028] Dragon's Hoard && Test: Dragon's Hoard_DRG_028
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DRG_030] Praise Galakrond! - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Give a minion +1 Attack.
			//       <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_030", new CardDef(new Power
			{
				// TODO [DRG_030] Praise Galakrond! && Test: Praise Galakrond!_DRG_030
				InfoCardId = "DRG_030e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DRG_033] Candle Breath - COST:6
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 3 cards. Costs (3)_less while you're holding a Dragon.
			// --------------------------------------------------------
			cards.Add("DRG_033", new CardDef(new Power
			{
				// TODO [DRG_033] Candle Breath && Test: Candle Breath_DRG_033
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DRG_247] Seal Fate - COST:3
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $3 damage to an undamaged character. <b>Invoke</b> Galakrond. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_247", new CardDef(new Power
			{
				// TODO [DRG_247] Seal Fate && Test: Seal Fate_DRG_247
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void RogueNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [DRG_030e] Praise Galakrond! (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DRG_030e", new CardDef(new Power
			{
				// TODO [DRG_030e] Praise Galakrond! && Test: Praise Galakrond!_DRG_030e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_030e")
			}));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [DRG_074e] Camouflaged (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("DRG_074e", new CardDef(
				// TODO [DRG_074e] Camouflaged && Test: Camouflaged_DRG_074e
				Power.OneTurnStealthEnchantmentPower
			));

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [DRG_610e] Galakrond's Wonder (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("DRG_610e", new CardDef(new Power
			{
				// TODO [DRG_610e] Galakrond's Wonder && Test: Galakrond's Wonder_DRG_610e
				Enchant = new Enchant(Effects.SetCost(0))
			}));

			// ----------------------------------------- MINION - ROGUE
			// [DRG_035t] Sky Pirate (*) - COST:1 [ATK:1/HP:1]
			// - Race: pirate, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_035t", new CardDef(new Power
			{
				// TODO [DRG_035t] Sky Pirate && Test: Sky Pirate_DRG_035t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------ SPELL - ROGUE
			// [DRG_036t] Waxadred's Candle (*) - COST:5
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Casts When Drawn</b>
			//       Summon Waxadred.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CASTSWHENDRAWN = 1
			// --------------------------------------------------------
			cards.Add("DRG_036t", new CardDef(new Power
			{
				// TODO [DRG_036t] Waxadred's Candle && Test: Waxadred's Candle_DRG_036t
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Shaman(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [DRG_096] Bandersmosh - COST:5 [ATK:5/HP:5]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Each turn this is in your
			//       hand, transform it into a
			//       5/5 copy of a random
			//       <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_096", new CardDef(new Power
			{
				// TODO [DRG_096] Bandersmosh && Test: Bandersmosh_DRG_096
				InfoCardId = "DRG_096e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_211] Squallhunter - COST:4 [ATK:5/HP:7]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			//       <b>Overload:</b> (2)
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// - OVERLOAD = 2
			// --------------------------------------------------------
			cards.Add("DRG_211", new CardDef(new Power
			{
				// TODO [DRG_211] Squallhunter && Test: Squallhunter_DRG_211
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_216] Surging Tempest - COST:1 [ATK:1/HP:3]
			// - Race: elemental, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Has +1 Attack while you_have <b>Overloaded</b> Mana Crystals.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("DRG_216", new CardDef(new Power
			{
				// TODO [DRG_216] Surging Tempest && Test: Surging Tempest_DRG_216
				InfoCardId = "DRG_216e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_218] Corrupt Elementalist - COST:5 [ATK:3/HP:3]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond twice.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_218", new CardDef(new Power
			{
				// TODO [DRG_218] Corrupt Elementalist && Test: Corrupt Elementalist_DRG_218
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_223] Cumulo-Maximus - COST:5 [ATK:5/HP:5]
			// - Race: elemental, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have <b>Overloaded</b> Mana Crystals, deal 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("DRG_223", new CardDef(new Power
			{
				// TODO [DRG_223] Cumulo-Maximus && Test: Cumulo-Maximus_DRG_223
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_224] Nithogg - COST:6 [ATK:5/HP:5]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon two
			//       0/3 Eggs. Next turn they
			//       hatch into 4/4 Drakes
			//       with <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_224", new CardDef(new Power
			{
				// TODO [DRG_224] Nithogg && Test: Nithogg_DRG_224
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DRG_215] Storm's Wrath - COST:1
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			//       <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("DRG_215", new CardDef(new Power
			{
				// TODO [DRG_215] Storm's Wrath && Test: Storm's Wrath_DRG_215
				InfoCardId = "DRG_215e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DRG_217] Dragon's Pack - COST:5
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon two 2/3 Spirit Wolves with <b>Taunt</b>. If you've <b>Invoked</b> twice, give them +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_217", new CardDef(new Power
			{
				// TODO [DRG_217] Dragon's Pack && Test: Dragon's Pack_DRG_217
				InfoCardId = "DRG_217e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DRG_219] Lightning Breath - COST:3
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage to a
			//       minion. If you're holding
			//       a Dragon, also damage
			//       its neighbors. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_219", new CardDef(new Power
			{
				// TODO [DRG_219] Lightning Breath && Test: Lightning Breath_DRG_219
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- SPELL - SHAMAN
			// [DRG_248] Invocation of Frost - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> an enemy.
			//       <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DRG_248", new CardDef(new Power
			{
				// TODO [DRG_248] Invocation of Frost && Test: Invocation of Frost_DRG_248
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void ShamanNonCollect(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [DRG_068e] Toasty (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Can't be <b>Frozen</b>.
			// --------------------------------------------------------
			cards.Add("DRG_068e", new CardDef(new Power
			{
				// TODO [DRG_068e] Toasty && Test: Toasty_DRG_068e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_068e")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [DRG_096e2] Smoshing (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: 5/5.
			// --------------------------------------------------------
			cards.Add("DRG_096e2", new CardDef(new Power
			{
				// TODO [DRG_096e2] Smoshing && Test: Smoshing_DRG_096e2
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_096e2")
			}));

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [DRG_216e] Surging (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DRG_216e", new CardDef(new Power
			{
				// TODO [DRG_216e] Surging && Test: Surging_DRG_216e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_216e")
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_217t] Spirit Wolf (*) - COST:2 [ATK:2/HP:3]
			// - Fac: neutral, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_217t", new CardDef(new Power
			{
				// TODO [DRG_217t] Spirit Wolf && Test: Spirit Wolf_DRG_217t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_224t] Storm Egg (*) - COST:1 [ATK:0/HP:3]
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: At the start of your turn, transform into a 4/4_Storm_Drake with <b>Rush</b>.
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_224t", new CardDef(new Power
			{
				// TODO [DRG_224t] Storm Egg && Test: Storm Egg_DRG_224t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_224t2] Storm Drake (*) - COST:4 [ATK:4/HP:4]
			// - Race: dragon, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_224t2", new CardDef(new Power
			{
				// TODO [DRG_224t2] Storm Drake && Test: Storm Drake_DRG_224t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_238t14t3] Windswept Elemental (*) - COST:2 [ATK:2/HP:1]
			// - Race: elemental, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_238t14t3", new CardDef(new Power
			{
				// TODO [DRG_238t14t3] Windswept Elemental && Test: Windswept Elemental_DRG_238t14t3
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_620t4] Brewing Storm (*) - COST:2 [ATK:2/HP:2]
			// - Race: elemental, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620t4", new CardDef(new Power
			{
				// TODO [DRG_620t4] Brewing Storm && Test: Brewing Storm_DRG_620t4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_620t5] Living Storm (*) - COST:4 [ATK:4/HP:4]
			// - Race: elemental, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620t5", new CardDef(new Power
			{
				// TODO [DRG_620t5] Living Storm && Test: Living Storm_DRG_620t5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - SHAMAN
			// [DRG_620t6] Raging Storm (*) - COST:8 [ATK:8/HP:8]
			// - Race: elemental, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_620t6", new CardDef(new Power
			{
				// TODO [DRG_620t6] Raging Storm && Test: Raging Storm_DRG_620t6
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Warlock(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [DRG_201] Crazed Netherwing - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Fac: neutral, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding
			//       a Dragon, deal 3 damage to all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_201", new CardDef(new Power
			{
				// TODO [DRG_201] Crazed Netherwing && Test: Crazed Netherwing_DRG_201
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_202] Dragonblight Cultist - COST:3 [ATK:1/HP:1]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Invoke</b> Galakrond.
			//       Gain +1 Attack for each
			//       other friendly minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_202", new CardDef(new Power
			{
				// TODO [DRG_202] Dragonblight Cultist && Test: Dragonblight Cultist_DRG_202
				InfoCardId = "DRG_202e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_203] Veiled Worshipper - COST:4 [ATK:5/HP:4]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you've <b>Invoked</b>
			//       twice, draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// --------------------------------------------------------
			// RefTag:
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_203", new CardDef(new Power
			{
				// TODO [DRG_203] Veiled Worshipper && Test: Veiled Worshipper_DRG_203
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_207] Abyssal Summoner - COST:6 [ATK:2/HP:2]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       Demon with <b>Taunt</b> and stats
			//       equal to your hand size.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_207", new CardDef(new Power
			{
				// TODO [DRG_207] Abyssal Summoner && Test: Abyssal Summoner_DRG_207
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_208] Valdris Felgorge - COST:7 [ATK:4/HP:4]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Increase your maximum hand size to 12. Draw 4 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_208", new CardDef(new Power
			{
				// TODO [DRG_208] Valdris Felgorge && Test: Valdris Felgorge_DRG_208
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_209] Zzeraku the Warped - COST:8 [ATK:4/HP:12]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever your hero
			//       takes damage, summon
			//       a 6/6 Nether Drake.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_209", new CardDef(new Power
			{
				// TODO [DRG_209] Zzeraku the Warped && Test: Zzeraku the Warped_DRG_209
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DRG_204] Dark Skies - COST:3
			// - Fac: neutral, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $1 damage to a
			//       random minion. Repeat
			//       for each card in your hand. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_204", new CardDef(new Power
			{
				// TODO [DRG_204] Dark Skies && Test: Dark Skies_DRG_204
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DRG_205] Nether Breath - COST:2
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       If you're holding a Dragon, deal $4 damage with <b>Lifesteal</b> instead. @spelldmg
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("DRG_205", new CardDef(new Power
			{
				// TODO [DRG_205] Nether Breath && Test: Nether Breath_DRG_205
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DRG_206] Rain of Fire - COST:1
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $1 damage to all_characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_206", new CardDef(new Power
			{
				// TODO [DRG_206] Rain of Fire && Test: Rain of Fire_DRG_206
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARLOCK
			// [DRG_250] Fiendish Rites - COST:3
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Invoke</b> Galakrond.
			//       Give your minions +1_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_250", new CardDef(new Power
			{
				// TODO [DRG_250] Fiendish Rites && Test: Fiendish Rites_DRG_250
				InfoCardId = "DRG_250e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [DRG_202e] Power of the Cult (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("DRG_202e", new CardDef(new Power
			{
				// TODO [DRG_202e] Power of the Cult && Test: Power of the Cult_DRG_202e
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_207t] Abyssal Destroyer (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_207t", new CardDef(new Power
			{
				// TODO [DRG_207t] Abyssal Destroyer && Test: Abyssal Destroyer_DRG_207t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_209t] Nether Drake (*) - COST:6 [ATK:6/HP:6]
			// - Race: dragon, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_209t", new CardDef(new Power
			{
				// TODO [DRG_209t] Nether Drake && Test: Nether Drake_DRG_209t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [DRG_238t12t2] Draconic Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_238t12t2", new CardDef(new Power
			{
				// TODO [DRG_238t12t2] Draconic Imp && Test: Draconic Imp_DRG_238t12t2
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Warrior(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [DRG_019] Scion of Ruin - COST:3 [ATK:3/HP:2]
			// - Race: dragon, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>. <b>Battlecry:</b> If you've <b>Invoked</b> twice, summon 2_copies of this.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// - RUSH = 1
			// --------------------------------------------------------
			// RefTag:
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_019", new CardDef(new Power
			{
				// TODO [DRG_019] Scion of Ruin && Test: Scion of Ruin_DRG_019
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DRG_020] EVIL Quartermaster - COST:3 [ATK:2/HP:3]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to your hand. Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - MARK_OF_EVIL = 1
			// --------------------------------------------------------
			cards.Add("DRG_020", new CardDef(new Power
			{
				// TODO [DRG_020] EVIL Quartermaster && Test: EVIL Quartermaster_DRG_020
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DRG_023] Skybarge - COST:3 [ATK:2/HP:5]
			// - Race: mechanical, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       Pirate, deal 2 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("DRG_023", new CardDef(new Power
			{
				// TODO [DRG_023] Skybarge && Test: Skybarge_DRG_023
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DRG_024] Sky Raider - COST:1 [ATK:1/HP:2]
			// - Race: pirate, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Pirate to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_024", new CardDef(new Power
			{
				// TODO [DRG_024] Sky Raider && Test: Sky Raider_DRG_024
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [DRG_026] Deathwing, Mad Aspect - COST:8 [ATK:12/HP:12]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Attack ALL
			//       other minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_026", new CardDef(new Power
			{
				// TODO [DRG_026] Deathwing, Mad Aspect && Test: Deathwing, Mad Aspect_DRG_026
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DRG_022] Ramming Speed - COST:3
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Force a minion to attack one of its neighbors.
			// --------------------------------------------------------
			cards.Add("DRG_022", new CardDef(new Power
			{
				// TODO [DRG_022] Ramming Speed && Test: Ramming Speed_DRG_022
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DRG_249] Awaken! - COST:3
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Invoke</b> Galakrond. Deal_$1 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_249", new CardDef(new Power
			{
				// TODO [DRG_249] Awaken! && Test: Awaken!_DRG_249
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - WARRIOR
			// [DRG_500] Molten Breath - COST:4
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage to a
			//       minion. If you're holding
			//       a Dragon, gain 5 Armor. @spelldmg
			// --------------------------------------------------------
			cards.Add("DRG_500", new CardDef(new Power
			{
				// TODO [DRG_500] Molten Breath && Test: Molten Breath_DRG_500
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [DRG_021] Ritual Chopper - COST:2 [ATK:1/HP:0]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_021", new CardDef(new Power
			{
				// TODO [DRG_021] Ritual Chopper && Test: Ritual Chopper_DRG_021
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - WARRIOR
			// [DRG_025] Ancharrr - COST:3 [ATK:2/HP:0]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks, draw a Pirate from your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("DRG_025", new CardDef(new Power
			{
				// TODO [DRG_025] Ancharrr && Test: Ancharrr_DRG_025
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [DRG_238t10e] Galakrond's Might (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("DRG_238t10e", new CardDef(new Power
			{
				// TODO [DRG_238t10e] Galakrond's Might && Test: Galakrond's Might_DRG_238t10e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_238t10e")
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [DRG_049] Tasty Flyfish - COST:2 [ATK:2/HP:2]
			// - Race: murloc, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a Dragon in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_049", new CardDef(new Power
			{
				// TODO [DRG_049] Tasty Flyfish && Test: Tasty Flyfish_DRG_049
				InfoCardId = "DRG_049e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_050] Devoted Maniac - COST:4 [ATK:2/HP:2]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - 676 = 1
			// - RUSH = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_050", new CardDef(new Power
			{
				// TODO [DRG_050] Devoted Maniac && Test: Devoted Maniac_DRG_050
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_054] Big Ol' Whelp - COST:5 [ATK:5/HP:5]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_054", new CardDef(new Power
			{
				// TODO [DRG_054] Big Ol' Whelp && Test: Big Ol' Whelp_DRG_054
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_055] Hoard Pillager - COST:4 [ATK:4/HP:2]
			// - Race: pirate, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip one of your destroyed weapons.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_055", new CardDef(new Power
			{
				// TODO [DRG_055] Hoard Pillager && Test: Hoard Pillager_DRG_055
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_056] Parachute Brigand - COST:2 [ATK:2/HP:2]
			// - Race: pirate, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: [x]After you play a Pirate,
			//       summon this minion
			//       from your hand.
			// --------------------------------------------------------
			cards.Add("DRG_056", new CardDef(new Power
			{
				// TODO [DRG_056] Parachute Brigand && Test: Parachute Brigand_DRG_056
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_057] Hot Air Balloon - COST:1 [ATK:1/HP:2]
			// - Race: mechanical, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, gain +1 Health.
			// --------------------------------------------------------
			cards.Add("DRG_057", new CardDef(new Power
			{
				// TODO [DRG_057] Hot Air Balloon && Test: Hot Air Balloon_DRG_057
				InfoCardId = "DRG_057e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_058] Wing Commander - COST:4 [ATK:2/HP:5]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Has +2 Attack for each Dragon in your hand.
			// --------------------------------------------------------
			cards.Add("DRG_058", new CardDef(new Power
			{
				// TODO [DRG_058] Wing Commander && Test: Wing Commander_DRG_058
				InfoCardId = "DRG_058e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_059] Goboglide Tech - COST:3 [ATK:3/HP:3]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control a_Mech, gain +1/+1 and_<b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_059", new CardDef(new Power
			{
				// TODO [DRG_059] Goboglide Tech && Test: Goboglide Tech_DRG_059
				InfoCardId = "DRG_059e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_060] Fire Hawk - COST:3 [ATK:1/HP:3]
			// - Race: elemental, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1 Attack for each card in your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_060", new CardDef(new Power
			{
				// TODO [DRG_060] Fire Hawk && Test: Fire Hawk_DRG_060
				InfoCardId = "DRG_060e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_061] Gyrocopter - COST:6 [ATK:4/HP:5]
			// - Race: mechanical, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_061", new CardDef(new Power
			{
				// TODO [DRG_061] Gyrocopter && Test: Gyrocopter_DRG_061
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_062] Wyrmrest Purifier - COST:2 [ATK:3/HP:2]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform all
			//       Neutral cards in your deck
			//       into random cards from
			//       your class.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_062", new CardDef(new Power
			{
				// TODO [DRG_062] Wyrmrest Purifier && Test: Wyrmrest Purifier_DRG_062
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_063] Dragonmaw Poacher - COST:4 [ATK:4/HP:4]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent controls a Dragon, gain +4/+4 and <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_063", new CardDef(new Power
			{
				// TODO [DRG_063] Dragonmaw Poacher && Test: Dragonmaw Poacher_DRG_063
				InfoCardId = "DRG_063e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_064] Zul'Drak Ritualist - COST:4 [ATK:3/HP:9]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//        <b>Battlecry:</b> Summon three
			//       random 1-Cost minions
			//       for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_064", new CardDef(new Power
			{
				// TODO [DRG_064] Zul'Drak Ritualist && Test: Zul'Drak Ritualist_DRG_064
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_065] Hippogryph - COST:4 [ATK:2/HP:6]
			// - Race: beast, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_065", new CardDef(new Power
			{
				// TODO [DRG_065] Hippogryph && Test: Hippogryph_DRG_065
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_066] Evasive Chimaera - COST:2 [ATK:2/HP:1]
			// - Race: beast, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("DRG_066", new CardDef(new Power
			{
				// TODO [DRG_066] Evasive Chimaera && Test: Evasive Chimaera_DRG_066
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_067] Troll Batrider - COST:4 [ATK:3/HP:3]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_067", new CardDef(new Power
			{
				// TODO [DRG_067] Troll Batrider && Test: Troll Batrider_DRG_067
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_068] Living Dragonbreath - COST:3 [ATK:3/HP:4]
			// - Race: elemental, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Your minions can't be_<b>Frozen</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("DRG_068", new CardDef(new Power
			{
				// TODO [DRG_068] Living Dragonbreath && Test: Living Dragonbreath_DRG_068
				InfoCardId = "DRG_068e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_069] Platebreaker - COST:5 [ATK:5/HP:5]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_069", new CardDef(new Power
			{
				// TODO [DRG_069] Platebreaker && Test: Platebreaker_DRG_069
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_070] Dragon Breeder - COST:2 [ATK:2/HP:3]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly Dragon. Add a copy of it to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_070", new CardDef(new Power
			{
				// TODO [DRG_070] Dragon Breeder && Test: Dragon Breeder_DRG_070
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_071] Bad Luck Albatross - COST:3 [ATK:4/HP:3]
			// - Race: beast, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle two 1/1 Albatross into your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_071", new CardDef(new Power
			{
				// TODO [DRG_071] Bad Luck Albatross && Test: Bad Luck Albatross_DRG_071
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_072] Skyfin - COST:5 [ATK:3/HP:3]
			// - Race: murloc, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, summon 2 random Murlocs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_072", new CardDef(new Power
			{
				// TODO [DRG_072] Skyfin && Test: Skyfin_DRG_072
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_073] Evasive Feywing - COST:4 [ATK:5/HP:4]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DRG_073", new CardDef(new Power
			{
				// TODO [DRG_073] Evasive Feywing && Test: Evasive Feywing_DRG_073
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_074] Camouflaged Dirigible - COST:6 [ATK:6/HP:6]
			// - Race: mechanical, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other Mechs <b>Stealth</b> until your_next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("DRG_074", new CardDef(new Power
			{
				// TODO [DRG_074] Camouflaged Dirigible && Test: Camouflaged Dirigible_DRG_074
				InfoCardId = "DRG_074e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_075] Cobalt Spellkin - COST:5 [ATK:3/HP:5]
			// - Race: dragon, Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add two 1-Cost spells from your class to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_075", new CardDef(new Power
			{
				// TODO [DRG_075] Cobalt Spellkin && Test: Cobalt Spellkin_DRG_075
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_076] Faceless Corruptor - COST:5 [ATK:5/HP:4]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>. <b>Battlecry:</b> Transform
			//       one of your minions into
			//       a copy of this.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("DRG_076", new CardDef(new Power
			{
				// TODO [DRG_076] Faceless Corruptor && Test: Faceless Corruptor_DRG_076
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_077] Utgarde Grapplesniper - COST:6 [ATK:5/HP:5]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Both players draw a card. If it's a Dragon, summon it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_077", new CardDef(new Power
			{
				// TODO [DRG_077] Utgarde Grapplesniper && Test: Utgarde Grapplesniper_DRG_077
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_078] Depth Charge - COST:1 [ATK:0/HP:5]
			// - Set: dragons, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 5 damage to ALL_minions.
			// --------------------------------------------------------
			cards.Add("DRG_078", new CardDef(new Power
			{
				// TODO [DRG_078] Depth Charge && Test: Depth Charge_DRG_078
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_079] Evasive Wyrm - COST:6 [ATK:5/HP:3]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>. <b>Rush</b>.
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// - RUSH = 1
			// - 1211 = 1
			// --------------------------------------------------------
			cards.Add("DRG_079", new CardDef(new Power
			{
				// TODO [DRG_079] Evasive Wyrm && Test: Evasive Wyrm_DRG_079
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_081] Scalerider - COST:3 [ATK:3/HP:3]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_081", new CardDef(new Power
			{
				// TODO [DRG_081] Scalerider && Test: Scalerider_DRG_081
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_082] Kobold Stickyfinger - COST:5 [ATK:4/HP:4]
			// - Race: pirate, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Steal your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_082", new CardDef(new Power
			{
				// TODO [DRG_082] Kobold Stickyfinger && Test: Kobold Stickyfinger_DRG_082
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_084] Tentacled Menace - COST:5 [ATK:6/HP:5]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Each player draws a card. Swap their_Costs.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_084", new CardDef(new Power
			{
				// TODO [DRG_084] Tentacled Menace && Test: Tentacled Menace_DRG_084
				InfoCardId = "DRG_084e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_086] Chromatic Egg - COST:5 [ATK:0/HP:3]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Secretly <b>Discover</b>
			//       a Dragon to hatch into.
			//       <b>Deathrattle:</b> Hatch!
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_086", new CardDef(new Power
			{
				// TODO [DRG_086] Chromatic Egg && Test: Chromatic Egg_DRG_086
				InfoCardId = "DRG_086e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_088] Dread Raven - COST:3 [ATK:3/HP:4]
			// - Race: beast, Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Has +3 Attack for each other Dread Raven you_control.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("DRG_088", new CardDef(new Power
			{
				// TODO [DRG_088] Dread Raven && Test: Dread Raven_DRG_088
				InfoCardId = "DRG_088e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_089] Dragonqueen Alexstrasza - COST:9 [ATK:8/HP:8]
			// - Race: dragon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no duplicates, add 2 random Dragons to your hand. They cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_089", new CardDef(new Power
			{
				// TODO [DRG_089] Dragonqueen Alexstrasza && Test: Dragonqueen Alexstrasza_DRG_089
				InfoCardId = "DRG_089e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_091] Shu'ma - COST:7 [ATK:1/HP:7]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn,
			//       fill your board with 1/1_Tentacles.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("DRG_091", new CardDef(new Power
			{
				// TODO [DRG_091] Shu'ma && Test: Shu'ma_DRG_091
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_092] Transmogrifier - COST:2 [ATK:2/HP:3]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you draw a card, transform it into a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			cards.Add("DRG_092", new CardDef(new Power
			{
				// TODO [DRG_092] Transmogrifier && Test: Transmogrifier_DRG_092
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_099] Kronx Dragonhoof - COST:6 [ATK:6/HP:6]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw Galakrond.
			//       If you're already Galakrond,
			//       unleash a Devastation.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("DRG_099", new CardDef(new Power
			{
				// TODO [DRG_099] Kronx Dragonhoof && Test: Kronx Dragonhoof_DRG_099
				InfoCardId = "DRG_099t3e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_213] Twin Tyrant - COST:8 [ATK:4/HP:10]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 4 damage to two random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_213", new CardDef(new Power
			{
				// TODO [DRG_213] Twin Tyrant && Test: Twin Tyrant_DRG_213
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_239] Blazing Battlemage - COST:1 [ATK:2/HP:2]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			cards.Add("DRG_239", new CardDef(new Power
			{
				// TODO [DRG_239] Blazing Battlemage && Test: Blazing Battlemage_DRG_239
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_242] Shield of Galakrond - COST:5 [ATK:4/HP:5]
			// - Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> <b>Invoke</b> Galakrond.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// - 676 = 1
			// - EMPOWER = 1
			// --------------------------------------------------------
			cards.Add("DRG_242", new CardDef(new Power
			{
				// TODO [DRG_242] Shield of Galakrond && Test: Shield of Galakrond_DRG_242
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_257] Frizz Kindleroost - COST:4 [ATK:5/HP:4]
			// - Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the Cost of Dragons in your deck by_(2).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_257", new CardDef(new Power
			{
				// TODO [DRG_257] Frizz Kindleroost && Test: Frizz Kindleroost_DRG_257
				InfoCardId = "DRG_257e3",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_310] Evasive Drakonid - COST:7 [ATK:7/HP:7]
			// - Race: dragon, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("DRG_310", new CardDef(new Power
			{
				// TODO [DRG_310] Evasive Drakonid && Test: Evasive Drakonid_DRG_310
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_401] Grizzled Wizard - COST:2 [ATK:3/HP:2]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap Hero Powers with your opponent until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_401", new CardDef(new Power
			{
				// TODO [DRG_401] Grizzled Wizard && Test: Grizzled Wizard_DRG_401
				InfoCardId = "DRG_401e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_402] Sathrovarr - COST:9 [ATK:5/HP:5]
			// - Race: demon, Set: dragons, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Add a copy of it to_your hand, deck, and battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("DRG_402", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_TARGET_IF_AVAILABLE,0}}, new Power
			{
				// TODO [DRG_402] Sathrovarr && Test: Sathrovarr_DRG_402
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_403] Blowtorch Saboteur - COST:3 [ATK:3/HP:4]
			// - Set: dragons, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent's next Hero Power costs (3).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("DRG_403", new CardDef(new Power
			{
				// TODO [DRG_403] Blowtorch Saboteur && Test: Blowtorch Saboteur_DRG_403
				InfoCardId = "DRG_403e",
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_008e] Righteous Cause (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DRG_008e", new CardDef(new Power
			{
				// TODO [DRG_008e] Righteous Cause && Test: Righteous Cause_DRG_008e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_008e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_049e] Well Fed (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DRG_049e", new CardDef(new Power
			{
				// TODO [DRG_049e] Well Fed && Test: Well Fed_DRG_049e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_049e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_058e] Commanding (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("DRG_058e", new CardDef(new Power
			{
				// TODO [DRG_058e] Commanding && Test: Commanding_DRG_058e
				Enchant = Enchants.Enchants.AddAttackScriptTag
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_059e] Gobogliding (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DRG_059e", new CardDef(new Power
			{
				// TODO [DRG_059e] Gobogliding && Test: Gobogliding_DRG_059e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_059e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_063e] Poaching (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("DRG_063e", new CardDef(new Power
			{
				// TODO [DRG_063e] Poaching && Test: Poaching_DRG_063e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_063e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_084e] Tentacle Confusion (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Cost swapped by Tentacled Menace.
			// --------------------------------------------------------
			cards.Add("DRG_084e", new CardDef(new Power
			{
				// TODO [DRG_084e] Tentacle Confusion && Test: Tentacle Confusion_DRG_084e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_084e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_086e] What's in the Egg? (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: It's a mystery...@{0} is inside! <i>(Only you can see this.)</i>
			// --------------------------------------------------------
			cards.Add("DRG_086e", new CardDef(new Power
			{
				// TODO [DRG_086e] What's in the Egg? && Test: What's in the Egg?_DRG_086e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_086e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_088e] Conspiracy of Ravens (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +3 Attack for each other Dread Raven.
			// --------------------------------------------------------
			cards.Add("DRG_088e", new CardDef(new Power
			{
				// TODO [DRG_088e] Conspiracy of Ravens && Test: Conspiracy of Ravens_DRG_088e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_088e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_089e] A Queen's Discount (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("DRG_089e", new CardDef(new Power
			{
				// TODO [DRG_089e] A Queen's Discount && Test: A Queen's Discount_DRG_089e
				Enchant = new Enchant(Effects.SetCost(0))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_096e] Smoshing (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Transforming into random <b>Legendary</b> minions.
			// --------------------------------------------------------
			cards.Add("DRG_096e", new CardDef(new Power
			{
				// TODO [DRG_096e] Smoshing && Test: Smoshing_DRG_096e
				InfoCardId = "DRG_096e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_096e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_099t3e] Dominating (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("DRG_099t3e", new CardDef(new Power
			{
				// TODO [DRG_099t3e] Dominating && Test: Dominating_DRG_099t3e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_099t3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_215e] Storm's Wrath (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("DRG_215e", new CardDef(new Power
			{
				// TODO [DRG_215e] Storm's Wrath && Test: Storm's Wrath_DRG_215e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_215e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_217e] Galakrond's Power (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("DRG_217e", new CardDef(new Power
			{
				// TODO [DRG_217e] Galakrond's Power && Test: Galakrond's Power_DRG_217e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_217e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_225e] Mechanical Might (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1 Attack from Sky Claw.
			// --------------------------------------------------------
			cards.Add("DRG_225e", new CardDef(new Power
			{
				// TODO [DRG_225e] Mechanical Might && Test: Mechanical Might_DRG_225e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_225e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_233e] Sand Breath (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1/+2.
			// --------------------------------------------------------
			cards.Add("DRG_233e", new CardDef(new Power
			{
				// TODO [DRG_233e] Sand Breath && Test: Sand Breath_DRG_233e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_233e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_235e] Rider Talritha (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +3/+3 and <b>Deathrattle:</b> Give a Dragon in your hand this enchant.
			// --------------------------------------------------------
			cards.Add("DRG_235e", new CardDef(new Power
			{
				// TODO [DRG_235e] Rider Talritha && Test: Rider Talritha_DRG_235e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_235e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_250e] Fiendish Rites (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("DRG_250e", new CardDef(new Power
			{
				// TODO [DRG_250e] Fiendish Rites && Test: Fiendish Rites_DRG_250e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_250e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_257e3] Ready to Hatch! (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Reduced Cost.
			// --------------------------------------------------------
			cards.Add("DRG_257e3", new CardDef(new Power
			{
				// TODO [DRG_257e3] Ready to Hatch! && Test: Ready to Hatch!_DRG_257e3
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_257e3")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_308e] Shadowborn (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon {0}.
			// --------------------------------------------------------
			cards.Add("DRG_308e", new CardDef(new Power
			{
				// TODO [DRG_308e] Shadowborn && Test: Shadowborn_DRG_308e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_308e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_311e] Spore Hardened (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("DRG_311e", new CardDef(new Power
			{
				// TODO [DRG_311e] Spore Hardened && Test: Spore Hardened_DRG_311e
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_311e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_319e4] Treant Powerup (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Your Treants have +1/+1.
			// --------------------------------------------------------
			cards.Add("DRG_319e4", new CardDef(new Power
			{
				// TODO [DRG_319e4] Treant Powerup && Test: Treant Powerup_DRG_319e4
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_319e4")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_401e] Grizzled Power (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Swap Hero Powers with your opponent next turn.
			// --------------------------------------------------------
			cards.Add("DRG_401e", new CardDef(new Power
			{
				// TODO [DRG_401e] Grizzled Power && Test: Grizzled Power_DRG_401e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_401e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_403e] Hot Hot Hot! (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Costs (3).
			// --------------------------------------------------------
			cards.Add("DRG_403e", new CardDef(new Power
			{
				// TODO [DRG_403e] Hot Hot Hot! && Test: Hot Hot Hot!_DRG_403e
				Enchant = new Enchant(Effects.SetCost(3))
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_650e] Galakrond's Strength (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("DRG_650e", new CardDef(new Power
			{
				// TODO [DRG_650e] Galakrond's Strength && Test: Galakrond's Strength_DRG_650e
				InfoCardId = "DRG_650e2",
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_650e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_650e2] Galakrond's Strength (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("DRG_650e2", new CardDef(new Power
			{
				// TODO [DRG_650e2] Galakrond's Strength && Test: Galakrond's Strength_DRG_650e2
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_650e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [DRG_650e3] Galakrond's Strength (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("DRG_650e3", new CardDef(new Power
			{
				// TODO [DRG_650e3] Galakrond's Strength && Test: Galakrond's Strength_DRG_650e3
				Enchant = Enchants.Enchants.GetAutoEnchantFromText("DRG_650e3")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_052] Draconic Lackey (*) - COST:1 [ATK:1/HP:1]
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// - MARK_OF_EVIL = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("DRG_052", new CardDef(new Power
			{
				// TODO [DRG_052] Draconic Lackey && Test: Draconic Lackey_DRG_052
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_091t] Tentacle (*) - COST:1 [ATK:1/HP:1]
			// - Set: dragons,
			// --------------------------------------------------------
			cards.Add("DRG_091t", new CardDef(new Power
			{
				// TODO [DRG_091t] Tentacle && Test: Tentacle_DRG_091t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_099t2t] Reanimated Dragon (*) - COST:8 [ATK:8/HP:8]
			// - Race: dragon, Set: dragons,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("DRG_099t2t", new CardDef(new Power
			{
				// TODO [DRG_099t2t] Reanimated Dragon && Test: Reanimated Dragon_DRG_099t2t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [DRG_255t2] Leper Gnome (*) - COST:1 [ATK:1/HP:1]
			// - Fac: neutral, Set: dragons, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("DRG_255t2", new CardDef(new Power
			{
				// TODO [DRG_255t2] Leper Gnome && Test: Leper Gnome_DRG_255t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_099t1] Decimation (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal 5 damage to the enemy hero. Restore 5 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_099t1", new CardDef(new Power
			{
				// TODO [DRG_099t1] Decimation && Test: Decimation_DRG_099t1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_099t2] Reanimation (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Summon an 8/8 Dragon with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_099t2", new CardDef(new Power
			{
				// TODO [DRG_099t2] Reanimation && Test: Reanimation_DRG_099t2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_099t3] Domination (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Give your other minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_099t3", new CardDef(new Power
			{
				// TODO [DRG_099t3] Domination && Test: Domination_DRG_099t3
				InfoCardId = "DRG_099t3e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_099t4] Annihilation (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Deal 5 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_099t4", new CardDef(new Power
			{
				// TODO [DRG_099t4] Annihilation && Test: Annihilation_DRG_099t4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_235d] Dragonrider Talritha Effect Dummy (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_235d", new CardDef(new Power
			{
				// TODO [DRG_235d] Dragonrider Talritha Effect Dummy && Test: Dragonrider Talritha Effect Dummy_DRG_235d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [DRG_401d] Grizzled Power Dummy (*) - COST:0
			// - Set: dragons,
			// --------------------------------------------------------
			// Text: Dummy Hook Up for DRG_401e
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// - 1200 = 1
			// --------------------------------------------------------
			cards.Add("DRG_401d", new CardDef(new Power
			{
				// TODO [DRG_401d] Grizzled Power Dummy && Test: Grizzled Power Dummy_DRG_401d
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
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
