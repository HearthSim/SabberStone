using System.Collections.Generic;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.CardSets.Undefined
{
	public class GilneasCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ HERO - SHAMAN
			// [GIL_504] Hagatha the Witch - COST:8 [ATK:0/HP:30] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 47631
			// --------------------------------------------------------
			cards.Add("GIL_504", new Power {
				// TODO [GIL_504] Hagatha the Witch && Test: Hagatha the Witch_GIL_504
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [GIL_504h] Bewitch (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       After you play a minion,
			//       add a random Shaman
			//       spell to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_504h", new Power {
				// TODO [GIL_504h] Bewitch && Test: Bewitch_GIL_504h
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [GIL_130] Gloom Stag - COST:5 [ATK:2/HP:6] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> If your deck has only odd-Cost cards, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_130", new Power {
				// TODO [GIL_130] Gloom Stag && Test: Gloom Stag_GIL_130
				InfoCardId = "GIL_130e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_188] Druid of the Scythe - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Transform
			//       into a 4/2 with <b>Rush</b>;
			//       or a 2/4 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188", new Power {
				// TODO [GIL_188] Druid of the Scythe && Test: Druid of the Scythe_GIL_188
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_507] Bewitched Guardian - COST:5 [ATK:4/HP:1] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Gain +1 Health
			//       _for each card in your hand._
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_507", new Power {
				// TODO [GIL_507] Bewitched Guardian && Test: Bewitched Guardian_GIL_507
				InfoCardId = "GIL_507e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_658] Splintergraft - COST:8 [ATK:8/HP:8] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Choose a friendly
			//       minion. Add a 10/10 copy to
			//       your hand that costs (10).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_658", new Power {
				// TODO [GIL_658] Splintergraft && Test: Splintergraft_GIL_658
				InfoCardId = "GIL_658e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_800] Duskfallen Aviana - COST:5 [ATK:3/HP:7] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: On each player's turn, the first card played costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GIL_800", new Power {
				// TODO [GIL_800] Duskfallen Aviana && Test: Duskfallen Aviana_GIL_800
				InfoCardId = "GIL_800e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_833] Forest Guide - COST:4 [ATK:1/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, both players draw a card.
			// --------------------------------------------------------
			cards.Add("GIL_833", new Power {
				// TODO [GIL_833] Forest Guide && Test: Forest Guide_GIL_833
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_553] Wispering Woods - COST:4 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon a 1/1 Wisp for
			//       each card in your hand.
			// --------------------------------------------------------
			cards.Add("GIL_553", new Power {
				// TODO [GIL_553] Wispering Woods && Test: Wispering Woods_GIL_553
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_571] Witching Hour - COST:3 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a random friendly Beast that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 20
			// --------------------------------------------------------
			cards.Add("GIL_571", new Power {
				// TODO [GIL_571] Witching Hour && Test: Witching Hour_GIL_571
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_637] Ferocious Howl - COST:3 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Draw a card.
			//       Gain 1 Armor for each card in your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_637", new Power {
				// TODO [GIL_637] Ferocious Howl && Test: Ferocious Howl_GIL_637
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_663] Witchwood Apple - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Add three 2/2 Treants to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_663", new Power {
				// TODO [GIL_663] Witchwood Apple && Test: Witchwood Apple_GIL_663
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [GIL_188t] Druid of the Scythe (*) - COST:3 [ATK:4/HP:2] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t", new Power {
				// TODO [GIL_188t] Druid of the Scythe && Test: Druid of the Scythe_GIL_188t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_188t2] Druid of the Scythe (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t2", new Power {
				// TODO [GIL_188t2] Druid of the Scythe && Test: Druid of the Scythe_GIL_188t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_188t3] Druid of the Scythe (*) - COST:3 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_188t3", new Power {
				// TODO [GIL_188t3] Druid of the Scythe && Test: Druid of the Scythe_GIL_188t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_553t] Wisp (*) - COST:0 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_553t", new Power {
				// TODO [GIL_553t] Wisp && Test: Wisp_GIL_553t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [GIL_663t] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_663t", new Power {
				// TODO [GIL_663t] Treant && Test: Treant_GIL_663t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_188a] Dire Panther Form (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Attack and <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("GIL_188a", new Power {
				// TODO [GIL_188a] Dire Panther Form && Test: Dire Panther Form_GIL_188a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [GIL_188b] Dire Wolf Form (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("GIL_188b", new Power {
				// TODO [GIL_188b] Dire Wolf Form && Test: Dire Wolf Form_GIL_188b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [GIL_128] Emeriss - COST:10 [ATK:8/HP:8] 
			// - Race: dragon, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Double the Attack and Health of all minions in_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_128", new Power {
				// TODO [GIL_128] Emeriss && Test: Emeriss_GIL_128
				InfoCardId = "GIL_128e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_200] Duskhaven Hunter - COST:3 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GIL_200", new Power {
				// TODO [GIL_200] Duskhaven Hunter && Test: Duskhaven Hunter_GIL_200
				InfoCardId = "GIL_200e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_562] Vilebrood Skitterer - COST:5 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_562", new Power {
				// TODO [GIL_562] Vilebrood Skitterer && Test: Vilebrood Skitterer_GIL_562
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_607] Toxmonger - COST:4 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Whenever you play a 1-Cost
			//       minion, give it <b>Poisonous</b>.
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_607", new Power {
				// TODO [GIL_607] Toxmonger && Test: Toxmonger_GIL_607
				InfoCardId = "GIL_607e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_607t] Hunting Mastiff - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_607t", new Power {
				// TODO [GIL_607t] Hunting Mastiff && Test: Hunting Mastiff_GIL_607t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_650] Houndmaster Shaw - COST:4 [ATK:3/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your other minions have
			//       <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_650", new Power {
				// TODO [GIL_650] Houndmaster Shaw && Test: Houndmaster Shaw_GIL_650
				InfoCardId = "GIL_650e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_905] Carrion Drake - COST:5 [ATK:3/HP:7] 
			// - Race: dragon, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If a minion died this turn, gain <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_905", new Power {
				// TODO [GIL_905] Carrion Drake && Test: Carrion Drake_GIL_905
				InfoCardId = "GIL_905e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_518] Wing Blast - COST:4 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. If a minion died this turn, this costs (1). @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_518", new Power {
				// TODO [GIL_518] Wing Blast && Test: Wing Blast_GIL_518
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_577] Rat Trap - COST:2 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Secret:</b> After your
			//       opponent plays three
			//       cards in a turn, summon
			//       a 6/6 Rat.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_577", new Power {
				// TODO [GIL_577] Rat Trap && Test: Rat Trap_GIL_577
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [GIL_828] Dire Frenzy - COST:4 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Give a Beast +3/+3. Shuffle 3 copies into your deck with +3/+3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("GIL_828", new Power {
				// TODO [GIL_828] Dire Frenzy && Test: Dire Frenzy_GIL_828
				InfoCardId = "GIL_828e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [GIL_200t] Duskhaven Hunter (*) - COST:3 [ATK:5/HP:2] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("GIL_200t", new Power {
				// TODO [GIL_200t] Duskhaven Hunter && Test: Duskhaven Hunter_GIL_200t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [GIL_577t] Doom Rat (*) - COST:6 [ATK:6/HP:6] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_577t", new Power {
				// TODO [GIL_577t] Doom Rat && Test: Doom Rat_GIL_577t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t5] Hunting Mastiff (*) - COST:2 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Rush</b>@<b>Echo</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t5", new Power {
				// TODO [ICC_828t5] Hunting Mastiff && Test: Hunting Mastiff_ICC_828t5
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t6] Vilebrood Skitterer (*) - COST:5 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			//       <b>Rush</b>@<b>Poisonous</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t6", new Power {
				// TODO [ICC_828t6] Vilebrood Skitterer && Test: Vilebrood Skitterer_ICC_828t6
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [GIL_116] Arcane Keysmith - COST:4 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>. Put it into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_116", new Power {
				// TODO [GIL_116] Arcane Keysmith && Test: Arcane Keysmith_GIL_116
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_549] Toki, Time-Tinker - COST:6 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a random
			//       <b>Legendary</b> minion from
			//       the past to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_549", new Power {
				// TODO [GIL_549] Toki, Time-Tinker && Test: Toki, Time-Tinker_GIL_549
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_640] Curio Collector - COST:5 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you draw a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_640", new Power {
				// TODO [GIL_640] Curio Collector && Test: Curio Collector_GIL_640
				InfoCardId = "GIL_640e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_645] Bonfire Elemental - COST:5 [ATK:5/HP:5] 
			// - Race: elemental, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you played an_Elemental last turn, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_645", new Power {
				// TODO [GIL_645] Bonfire Elemental && Test: Bonfire Elemental_GIL_645
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_664] Vex Crow - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, summon a random
			//       2-Cost minion.
			// --------------------------------------------------------
			cards.Add("GIL_664", new Power {
				// TODO [GIL_664] Vex Crow && Test: Vex Crow_GIL_664
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_691] Archmage Arugal - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a minion, add a copy of it to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_691", new Power {
				// TODO [GIL_691] Archmage Arugal && Test: Archmage Arugal_GIL_691
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [GIL_838] Black Cat - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			//        <b>Battlecry:</b> If your deck has only odd-Cost cards, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_838", new Power {
				// TODO [GIL_838] Black Cat && Test: Black Cat_GIL_838
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_147] Cinderstorm - COST:3 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("GIL_147", new Power {
				// TODO [GIL_147] Cinderstorm && Test: Cinderstorm_GIL_147
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_548] Book of Specters - COST:2 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw 3 cards. Discard any spells drawn.
			// --------------------------------------------------------
			cards.Add("GIL_548", new Power {
				// TODO [GIL_548] Book of Specters && Test: Book of Specters_GIL_548
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [GIL_801] Snap Freeze - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion.
			//       If it's already <b>Frozen</b>, destroy it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("GIL_801", new Power {
				// TODO [GIL_801] Snap Freeze && Test: Snap Freeze_GIL_801
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [GIL_545] Ghostly Charger - COST:5 [ATK:3/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_545", new Power {
				// TODO [GIL_545] Ghostly Charger && Test: Ghostly Charger_GIL_545
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_634] Bellringer Sentry - COST:4 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_634", new Power {
				// TODO [GIL_634] Bellringer Sentry && Test: Bellringer Sentry_GIL_634
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_635] Cathedral Gargoyle - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GIL_635", new Power {
				// TODO [GIL_635] Cathedral Gargoyle && Test: Cathedral Gargoyle_GIL_635
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_685] Paragon of Light - COST:3 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: While this minion has 3 or more Attack, it has <b>Taunt</b> and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_685", new Power {
				// TODO [GIL_685] Paragon of Light && Test: Paragon of Light_GIL_685
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_694] Prince Liam - COST:5 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Transform all
			//       1-Cost cards in your deck
			//       _into <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_694", new Power {
				// TODO [GIL_694] Prince Liam && Test: Prince Liam_GIL_694
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [GIL_817] The Glass Knight - COST:4 [ATK:4/HP:3] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       Whenever you restore Health,
			//       gain <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("GIL_817", new Power {
				// TODO [GIL_817] The Glass Knight && Test: The Glass Knight_GIL_817
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_145] Sound the Bells! - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Give a minion +1/+2.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_145", new Power {
				// TODO [GIL_145] Sound the Bells! && Test: Sound the Bells!_GIL_145
				InfoCardId = "GIL_145e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_203] Rebuke - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Enemy spells cost (5) more next turn.
			// --------------------------------------------------------
			cards.Add("GIL_203", new Power {
				// TODO [GIL_203] Rebuke && Test: Rebuke_GIL_203
				InfoCardId = "GIL_203e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [GIL_903] Hidden Wisdom - COST:1 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Secret:</b> After your
			//       opponent plays three
			//       cards in a turn, draw
			//       2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_903", new Power {
				// TODO [GIL_903] Hidden Wisdom && Test: Hidden Wisdom_GIL_903
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [GIL_596] Silver Sword - COST:8 [ATK:3/HP:0] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: After your hero attacks, give your minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("GIL_596", new Power {
				// TODO [GIL_596] Silver Sword && Test: Silver Sword_GIL_596
				InfoCardId = "GIL_596e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [GIL_145e] DING DONG! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+2.
			// --------------------------------------------------------
			cards.Add("GIL_145e", new Power {
				// TODO [GIL_145e] DING DONG! && Test: DING DONG!_GIL_145e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [GIL_142] Chameleos - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a card your opponent is holding.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_142", new Power {
				// TODO [GIL_142] Chameleos && Test: Chameleos_GIL_142
				InfoCardId = "GIL_142e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_156] Quartz Elemental - COST:5 [ATK:5/HP:8] 
			// - Race: elemental, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Can't attack while damaged.
			// --------------------------------------------------------
			cards.Add("GIL_156", new Power {
				// TODO [GIL_156] Quartz Elemental && Test: Quartz Elemental_GIL_156
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_190] Nightscale Matriarch - COST:7 [ATK:4/HP:9] 
			// - Race: dragon, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion is healed, summon a 3/3_Whelp.
			// --------------------------------------------------------
			cards.Add("GIL_190", new Power {
				// TODO [GIL_190] Nightscale Matriarch && Test: Nightscale Matriarch_GIL_190
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_805] Coffin Crasher - COST:6 [ATK:6/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a <b>Deathrattle</b> minion from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_805", new Power {
				// TODO [GIL_805] Coffin Crasher && Test: Coffin Crasher_GIL_805
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_835] Squashling - COST:2 [ATK:2/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Echo</b>
			//       <b>Battlecry:</b> Restore 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GIL_835", new Power {
				// TODO [GIL_835] Squashling && Test: Squashling_GIL_835
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_837] Glitter Moth - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has only odd-Cost cards, double the Health of your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_837", new Power {
				// TODO [GIL_837] Glitter Moth && Test: Glitter Moth_GIL_837
				InfoCardId = "GIL_837e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_840] Lady in White - COST:6 [ATK:5/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast 'Inner Fire'
			//       _on every minion in your deck_
			//       <i>(set Attack equal to Health).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_840", new Power {
				// TODO [GIL_840] Lady in White && Test: Lady in White_GIL_840
				InfoCardId = "GIL_840e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_134] Holy Water - COST:5 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. If that kills it, add a copy of it to your_hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_134", new Power {
				// TODO [GIL_134] Holy Water && Test: Holy Water_GIL_134
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_661] Divine Hymn - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #6 Health to all friendly characters.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_661", new Power {
				// TODO [GIL_661] Divine Hymn && Test: Divine Hymn_GIL_661
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [GIL_813] Vivid Nightmare - COST:3 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Choose a friendly minion.
			//       Summon a copy of it with
			//       1 Health remaining.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_813", new Power {
				// TODO [GIL_813] Vivid Nightmare && Test: Vivid Nightmare_GIL_813
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [GIL_840e] Angelic Fortitude (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Has Attack equal to its Health.
			// --------------------------------------------------------
			cards.Add("GIL_840e", new Power {
				// TODO [GIL_840e] Angelic Fortitude && Test: Angelic Fortitude_GIL_840e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [GIL_190t] Nightscale Whelp (*) - COST:3 [ATK:3/HP:3] 
			// - Race: dragon, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_190t", new Power {
				// TODO [GIL_190t] Nightscale Whelp && Test: Nightscale Whelp_GIL_190t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [GIL_510] Mistwraith - COST:4 [ATK:3/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play an <b>Echo</b>_card, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_510", new Power {
				// TODO [GIL_510] Mistwraith && Test: Mistwraith_GIL_510
				InfoCardId = "GIL_510e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_557] Cursed Castaway - COST:6 [ATK:5/HP:3] 
			// - Race: pirate, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Deathrattle:</b> Draw a <b>Combo</b> card from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			// RefTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("GIL_557", new Power {
				// TODO [GIL_557] Cursed Castaway && Test: Cursed Castaway_GIL_557
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_598] Tess Greymane - COST:8 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Replay every card
			//       from another class you've
			//       played this game <i>(targets
			//       chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_598", new Power {
				// TODO [GIL_598] Tess Greymane && Test: Tess Greymane_GIL_598
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_677] Face Collector - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Battlecry:</b> Add a random <b>Legendary</b> minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_677", new Power {
				// TODO [GIL_677] Face Collector && Test: Face Collector_GIL_677
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_827] Blink Fox - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_827", new Power {
				// TODO [GIL_827] Blink Fox && Test: Blink Fox_GIL_827
				InfoCardId = "GIL_827e1",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [GIL_902] Cutthroat Buccaneer - COST:3 [ATK:2/HP:4] 
			// - Race: pirate, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			cards.Add("GIL_902", new Power {
				// TODO [GIL_902] Cutthroat Buccaneer && Test: Cutthroat Buccaneer_GIL_902
				InfoCardId = "GIL_902e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_506] Cheap Shot - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//        Deal $2 damage to a_minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_506", new Power {
				// TODO [GIL_506] Cheap Shot && Test: Cheap Shot_GIL_506
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_687] WANTED! - COST:4 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. If that kills it, add a Coin to your hand. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_687", new Power {
				// TODO [GIL_687] WANTED! && Test: WANTED!_GIL_687
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [GIL_696] Pick Pocket - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Add a random card to your hand <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_696", new Power {
				// TODO [GIL_696] Pick Pocket && Test: Pick Pocket_GIL_696
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [GIL_672] Spectral Cutlass - COST:4 [ATK:2/HP:0] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Whenever you play a card
			//       from another class,
			//       gain +1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_672", new Power {
				// TODO [GIL_672] Spectral Cutlass && Test: Spectral Cutlass_GIL_672
				InfoCardId = "GIL_672e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e1] Pounce (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e1", new Power {
				// TODO [GIL_827e1] Pounce && Test: Pounce_GIL_827e1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e2] Bite (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e2", new Power {
				// TODO [GIL_827e2] Bite && Test: Bite_GIL_827e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e3] Rabid (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e3", new Power {
				// TODO [GIL_827e3] Rabid && Test: Rabid_GIL_827e3
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [GIL_827e4] Flurry (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("GIL_827e4", new Power {
				// TODO [GIL_827e4] Flurry && Test: Flurry_GIL_827e4
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [GIL_530] Murkspark Eel - COST:2 [ATK:2/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has only even-Cost cards, deal_2 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("GIL_530", new Power {
				// TODO [GIL_530] Murkspark Eel && Test: Murkspark Eel_GIL_530
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_531] Witch's Apprentice - COST:1 [ATK:0/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Add a random Shaman spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_531", new Power {
				// TODO [GIL_531] Witch's Apprentice && Test: Witch's Apprentice_GIL_531
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_583] Totem Cruncher - COST:4 [ATK:2/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Destroy your Totems. Gain +2/+2 for each destroyed.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_583", new Power {
				// TODO [GIL_583] Totem Cruncher && Test: Totem Cruncher_GIL_583
				InfoCardId = "GIL_583e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_678] Ghost Light Angler - COST:2 [ATK:2/HP:2] 
			// - Race: murloc, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_678", new Power {
				// TODO [GIL_678] Ghost Light Angler && Test: Ghost Light Angler_GIL_678
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_807] Bogshaper - COST:7 [ATK:4/HP:8] 
			// - Race: elemental, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a minion from your_deck.
			// --------------------------------------------------------
			cards.Add("GIL_807", new Power {
				// TODO [GIL_807] Bogshaper && Test: Bogshaper_GIL_807
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [GIL_820] Shudderwock - COST:9 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Repeat all other
			//       <b>Battlecries</b> from cards you
			//       played this game <i>(targets
			//       chosen randomly)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - 960 = 1
			// --------------------------------------------------------
			cards.Add("GIL_820", new Power {
				// TODO [GIL_820] Shudderwock && Test: Shudderwock_GIL_820
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_586] Earthen Might - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2.
			//       If it's an Elemental, add
			//       a random Elemental
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_586", new Power {
				// TODO [GIL_586] Earthen Might && Test: Earthen Might_GIL_586
				InfoCardId = "GIL_586e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_600] Zap! - COST:0 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. <b>Overload:</b> (1) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_600", new Power {
				// TODO [GIL_600] Zap! && Test: Zap!_GIL_600
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [GIL_836] Blazing Invocation - COST:1 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Battlecry</b> minion.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_836", new Power {
				// TODO [GIL_836] Blazing Invocation && Test: Blazing Invocation_GIL_836
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [GIL_508] Duskbat - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hero took damage this turn, summon two 1/1 Bats.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_508", new Power {
				// TODO [GIL_508] Duskbat && Test: Duskbat_GIL_508
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_515] Ratcatcher - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Destroy a friendly minion and gain its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("GIL_515", new Power {
				// TODO [GIL_515] Ratcatcher && Test: Ratcatcher_GIL_515
				InfoCardId = "GIL_515e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_565] Deathweb Spider - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your hero
			//       took damage this turn, gain <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_565", new Power {
				// TODO [GIL_565] Deathweb Spider && Test: Deathweb Spider_GIL_565
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_608] Witchwood Imp - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//       <b>Deathrattle:</b> Give a random
			//         friendly minion +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_608", new Power {
				// TODO [GIL_608] Witchwood Imp && Test: Witchwood Imp_GIL_608
				InfoCardId = "GIL_608e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_618] Glinda Crowskin - COST:6 [ATK:3/HP:7] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Minions in your hand have_<b>Echo</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_618", new Power {
				// TODO [GIL_618] Glinda Crowskin && Test: Glinda Crowskin_GIL_618
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_693] Blood Witch - COST:4 [ATK:3/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 1 damage to your_hero.
			// --------------------------------------------------------
			cards.Add("GIL_693", new Power {
				// TODO [GIL_693] Blood Witch && Test: Blood Witch_GIL_693
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_825] Lord Godfrey - COST:7 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage to
			//       all other minions. If any die,
			//       repeat this <b>Battlecry</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_825", new Power {
				// TODO [GIL_825] Lord Godfrey && Test: Lord Godfrey_GIL_825
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_191] Fiendish Circle - COST:4 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Summon four 1/1 Imps.
			// --------------------------------------------------------
			cards.Add("GIL_191", new Power {
				// TODO [GIL_191] Fiendish Circle && Test: Fiendish Circle_GIL_191
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_543] Dark Possession - COST:1 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a friendly character. <b>Discover</b> a Demon. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("GIL_543", new Power {
				// TODO [GIL_543] Dark Possession && Test: Dark Possession_GIL_543
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [GIL_665] Curse of Weakness - COST:2 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Give all enemy minions -2_Attack until your next_turn.
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_665", new Power {
				// TODO [GIL_665] Curse of Weakness && Test: Curse of Weakness_GIL_665
				InfoCardId = "GIL_665e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [GIL_608e] Infusion (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("GIL_608e", new Power {
				// TODO [GIL_608e] Infusion && Test: Infusion_GIL_608e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_191t] Imp (*) - COST:1 [ATK:1/HP:1] 
			// - Race: demon, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_191t", new Power {
				// TODO [GIL_191t] Imp && Test: Imp_GIL_191t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [GIL_508t] Bat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_508t", new Power {
				// TODO [GIL_508t] Bat && Test: Bat_GIL_508t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [GIL_113] Rabid Worgen - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_113", new Power {
				// TODO [GIL_113] Rabid Worgen && Test: Rabid Worgen_GIL_113
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_152] Blackhowl Gunspire - COST:7 [ATK:3/HP:8] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Can't attack. Whenever
			//       this minion takes damage,
			//       deal 3 damage to a
			//       random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("GIL_152", new Power {
				// TODO [GIL_152] Blackhowl Gunspire && Test: Blackhowl Gunspire_GIL_152
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_155] Redband Wasp - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       Has +3 Attack while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_155", new Power {
				// TODO [GIL_155] Redband Wasp && Test: Redband Wasp_GIL_155
				InfoCardId = "GIL_155e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_547] Darius Crowley - COST:5 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       After this attacks and kills
			//       a minion, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_547", new Power {
				// TODO [GIL_547] Darius Crowley && Test: Darius Crowley_GIL_547
				InfoCardId = "GIL_547e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_580] Town Crier - COST:1 [ATK:1/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a <b>Rush</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_580", new Power {
				// TODO [GIL_580] Town Crier && Test: Town Crier_GIL_580
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_655] Festeroot Hulk - COST:5 [ATK:2/HP:7] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: After a friendly minion attacks, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_655", new Power {
				// TODO [GIL_655] Festeroot Hulk && Test: Festeroot Hulk_GIL_655
				InfoCardId = "GIL_655e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [GIL_803] Militia Commander - COST:4 [ATK:2/HP:5] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Gain +3_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_803", new Power {
				// TODO [GIL_803] Militia Commander && Test: Militia Commander_GIL_803
				InfoCardId = "GIL_803e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GIL_537] Deadly Arsenal - COST:6 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Reveal a weapon from your deck. Deal its Attack to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_537", new Power {
				// TODO [GIL_537] Deadly Arsenal && Test: Deadly Arsenal_GIL_537
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [GIL_654] Warpath - COST:2 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       Deal $1 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_654", new Power {
				// TODO [GIL_654] Warpath && Test: Warpath_GIL_654
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [GIL_653] Woodcutter's Axe - COST:2 [ATK:2/HP:0] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give +2/+1 to a random friendly <b>Rush</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_653", new Power {
				// TODO [GIL_653] Woodcutter's Axe && Test: Woodcutter's Axe_GIL_653
				InfoCardId = "GIL_653e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [GIL_803e] Reckless (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("GIL_803e", new Power {
				// TODO [GIL_803e] Reckless && Test: Reckless_GIL_803e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [GIL_117] Worgen Abomination - COST:7 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to all other damaged minions.
			// --------------------------------------------------------
			cards.Add("GIL_117", new Power {
				// TODO [GIL_117] Worgen Abomination && Test: Worgen Abomination_GIL_117
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_118] Deranged Doctor - COST:8 [ATK:8/HP:8] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 8 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_118", new Power {
				// TODO [GIL_118] Deranged Doctor && Test: Deranged Doctor_GIL_118
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_119] Cauldron Elemental - COST:8 [ATK:7/HP:7] 
			// - Race: elemental, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Your other Elementals have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("GIL_119", new Power {
				// TODO [GIL_119] Cauldron Elemental && Test: Cauldron Elemental_GIL_119
				InfoCardId = "GIL_119e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_120] Furious Ettin - COST:7 [ATK:5/HP:9] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_120", new Power {
				// TODO [GIL_120] Furious Ettin && Test: Furious Ettin_GIL_120
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_121] Darkmire Moonkin - COST:7 [ATK:2/HP:8] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("GIL_121", new Power {
				// TODO [GIL_121] Darkmire Moonkin && Test: Darkmire Moonkin_GIL_121
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_124] Mossy Horror - COST:6 [ATK:2/HP:7] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all other_minions with 2_or_less_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_124", new Power {
				// TODO [GIL_124] Mossy Horror && Test: Mossy Horror_GIL_124
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_125] Mad Hatter - COST:4 [ATK:3/HP:2] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Randomly toss
			//       3 hats to other minions.
			//       Each hat gives +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 11
			// --------------------------------------------------------
			cards.Add("GIL_125", new Power {
				// TODO [GIL_125] Mad Hatter && Test: Mad Hatter_GIL_125
				InfoCardId = "GIL_125e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_143] Vicious Scalehide - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_143", new Power {
				// TODO [GIL_143] Vicious Scalehide && Test: Vicious Scalehide_GIL_143
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_198] Azalina Soulthief - COST:7 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace your hand with a copy of your_opponent's.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_198", new Power {
				// TODO [GIL_198] Azalina Soulthief && Test: Azalina Soulthief_GIL_198
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_201] Pumpkin Peasant - COST:3 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_201", new Power {
				// TODO [GIL_201] Pumpkin Peasant && Test: Pumpkin Peasant_GIL_201
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_202] Gilnean Royal Guard - COST:8 [ATK:3/HP:8] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_202", new Power {
				// TODO [GIL_202] Gilnean Royal Guard && Test: Gilnean Royal Guard_GIL_202
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_207] Phantom Militia - COST:3 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_207", new Power {
				// TODO [GIL_207] Phantom Militia && Test: Phantom Militia_GIL_207
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_212] Ravencaller - COST:3 [ATK:2/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add two
			//       random 1-Cost minions
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_212", new Power {
				// TODO [GIL_212] Ravencaller && Test: Ravencaller_GIL_212
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_213] Tanglefur Mystic - COST:3 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random
			//       2-Cost minion to each player's hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_213", new Power {
				// TODO [GIL_213] Tanglefur Mystic && Test: Tanglefur Mystic_GIL_213
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_513] Lost Spirit - COST:2 [ATK:1/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your minions +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_513", new Power {
				// TODO [GIL_513] Lost Spirit && Test: Lost Spirit_GIL_513
				InfoCardId = "GIL_513e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_526] Wyrmguard - COST:7 [ATK:3/HP:11] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_526", new Power {
				// TODO [GIL_526] Wyrmguard && Test: Wyrmguard_GIL_526
				InfoCardId = "GIL_526e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_527] Felsoul Inquisitor - COST:4 [ATK:1/HP:6] 
			// - Race: demon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_527", new Power {
				// TODO [GIL_527] Felsoul Inquisitor && Test: Felsoul Inquisitor_GIL_527
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_528] Swift Messenger - COST:4 [ATK:2/HP:6] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_528", new Power {
				// TODO [GIL_528] Swift Messenger && Test: Swift Messenger_GIL_528
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_529] Spellshifter - COST:2 [ATK:1/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Spell Damage +1</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_529", new Power {
				// TODO [GIL_529] Spellshifter && Test: Spellshifter_GIL_529
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_534] Hench-Clan Thug - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: After your hero attacks, give this minion +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_534", new Power {
				// TODO [GIL_534] Hench-Clan Thug && Test: Hench-Clan Thug_GIL_534
				InfoCardId = "GIL_534t",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_558] Swamp Leech - COST:1 [ATK:2/HP:1] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_558", new Power {
				// TODO [GIL_558] Swamp Leech && Test: Swamp Leech_GIL_558
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_561] Blackwald Pixie - COST:3 [ATK:3/HP:4] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Refresh your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_561", new Power {
				// TODO [GIL_561] Blackwald Pixie && Test: Blackwald Pixie_GIL_561
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_578] Countess Ashmore - COST:7 [ATK:6/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw a <b>Rush</b>,
			//       <b>Lifesteal</b>, and <b>Deathrattle</b>
			//       card from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_578", new Power {
				// TODO [GIL_578] Countess Ashmore && Test: Countess Ashmore_GIL_578
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_581] Sandbinder - COST:4 [ATK:2/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw an Elemental from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_581", new Power {
				// TODO [GIL_581] Sandbinder && Test: Sandbinder_GIL_581
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_584] Witchwood Piper - COST:4 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Draw the lowest
			//       Cost minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_584", new Power {
				// TODO [GIL_584] Witchwood Piper && Test: Witchwood Piper_GIL_584
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_601] Scaleworm - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_601", new Power {
				// TODO [GIL_601] Scaleworm && Test: Scaleworm_GIL_601
				InfoCardId = "GIL_601e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_614] Voodoo Doll - COST:3 [ATK:1/HP:1] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a minion. <b>Deathrattle:</b> Destroy the chosen minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_614", new Power {
				// TODO [GIL_614] Voodoo Doll && Test: Voodoo Doll_GIL_614
				InfoCardId = "GIL_614e1",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616] Splitting Festeroot - COST:8 [ATK:4/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 2/2 Splitting Saplings.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_616", new Power {
				// TODO [GIL_616] Splitting Festeroot && Test: Splitting Festeroot_GIL_616
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_620] Dollmaster Dorian - COST:5 [ATK:2/HP:6] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever you draw a minion, summon a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("GIL_620", new Power {
				// TODO [GIL_620] Dollmaster Dorian && Test: Dollmaster Dorian_GIL_620
				InfoCardId = "GIL_620e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_622] Lifedrinker - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 3 damage to
			//       the enemy hero. Restore
			//       3 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_622", new Power {
				// TODO [GIL_622] Lifedrinker && Test: Lifedrinker_GIL_622
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_623] Witchwood Grizzly - COST:5 [ATK:3/HP:12] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Lose 1 Health
			//       for each card in your
			//       opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_623", new Power {
				// TODO [GIL_623] Witchwood Grizzly && Test: Witchwood Grizzly_GIL_623
				InfoCardId = "GIL_623e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_624] Night Prowler - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If this is the only minion in the battlefield, gain +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("GIL_624", new Power {
				// TODO [GIL_624] Night Prowler && Test: Night Prowler_GIL_624
				InfoCardId = "GIL_624e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_646] Clockwork Automaton - COST:5 [ATK:4/HP:4] 
			// - Race: mechanical, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: Double the damage and_healing of your Hero_Power.
			// --------------------------------------------------------
			cards.Add("GIL_646", new Power {
				// TODO [GIL_646] Clockwork Automaton && Test: Clockwork Automaton_GIL_646
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_648] Chief Inspector - COST:5 [ATK:4/HP:6] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("GIL_648", new Power {
				// TODO [GIL_648] Chief Inspector && Test: Chief Inspector_GIL_648
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_667] Rotten Applebaum - COST:5 [ATK:4/HP:5] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Restore 4 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_667", new Power {
				// TODO [GIL_667] Rotten Applebaum && Test: Rotten Applebaum_GIL_667
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_680] Walnut Sprite - COST:3 [ATK:3/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Echo</b>
			// --------------------------------------------------------
			// GameTag:
			// - ECHO = 1
			// --------------------------------------------------------
			cards.Add("GIL_680", new Power {
				// TODO [GIL_680] Walnut Sprite && Test: Walnut Sprite_GIL_680
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_681] Nightmare Amalgam - COST:3 [ATK:3/HP:4] 
			// - Race: all, Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<i>This is an Elemental, Mech,
			//       Demon, Murloc, Dragon,
			//       Beast, Pirate and Totem.</i>
			// --------------------------------------------------------
			cards.Add("GIL_681", new Power {
				// TODO [GIL_681] Nightmare Amalgam && Test: Nightmare Amalgam_GIL_681
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_682] Muck Hunter - COST:5 [ATK:5/HP:8] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			//       <b>Battlecry:</b> Summon two 2/1_Mucklings for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_682", new Power {
				// TODO [GIL_682] Muck Hunter && Test: Muck Hunter_GIL_682
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_683] Marsh Drake - COST:3 [ATK:5/HP:4] 
			// - Race: dragon, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/1 <b>Poisonous</b> Drakeslayer for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_683", new Power {
				// TODO [GIL_683] Marsh Drake && Test: Marsh Drake_GIL_683
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_692] Genn Greymane - COST:6 [ATK:6/HP:5] 
			// - Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b>
			//       If your deck has only even-
			//       Cost cards, your starting
			//       Hero Power costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COLLECTIONMANAGER_FILTER_MANA_EVEN = 1
			// - START_OF_GAME = 1
			// --------------------------------------------------------
			cards.Add("GIL_692", new Power {
				// TODO [GIL_692] Genn Greymane && Test: Genn Greymane_GIL_692
				InfoCardId = "GIL_692e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_809] Unpowered Steambot - COST:4 [ATK:0/HP:9] 
			// - Race: mechanical, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("GIL_809", new Power {
				// TODO [GIL_809] Unpowered Steambot && Test: Unpowered Steambot_GIL_809
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_815] Baleful Banker - COST:2 [ATK:2/HP:2] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy of it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("GIL_815", new Power {
				// TODO [GIL_815] Baleful Banker && Test: Baleful Banker_GIL_815
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_816] Swamp Dragon Egg - COST:1 [ATK:0/HP:3] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_816", new Power {
				// TODO [GIL_816] Swamp Dragon Egg && Test: Swamp Dragon Egg_GIL_816
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_819] Witch's Cauldron - COST:3 [ATK:0/HP:4] 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: After a friendly minion dies, add a random Shaman spell to your hand.
			// --------------------------------------------------------
			cards.Add("GIL_819", new Power {
				// TODO [GIL_819] Witch's Cauldron && Test: Witch's Cauldron_GIL_819
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_826] Baku the Mooneater - COST:9 [ATK:7/HP:8] 
			// - Race: beast, Set: gilneas, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Start of Game:</b>
			//       If your deck has only odd-
			//       Cost cards, upgrade
			//       your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - COLLECTIONMANAGER_FILTER_MANA_ODD = 1
			// - START_OF_GAME = 1
			// --------------------------------------------------------
			cards.Add("GIL_826", new Power {
				// TODO [GIL_826] Baku the Mooneater && Test: Baku the Mooneater_GIL_826
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_000] Echo Enchant (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Destroy card if in hand at the end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - GHOSTLY = 1
			// --------------------------------------------------------
			cards.Add("GIL_000", new Power {
				// TODO [GIL_000] Echo Enchant && Test: Echo Enchant_GIL_000
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_119e] Toil and Trouble (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Cauldron Elemental is granting this +2 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_119e", new Power {
				// TODO [GIL_119e] Toil and Trouble && Test: Toil and Trouble_GIL_119e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_125e] Hat (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_125e", new Power {
				// TODO [GIL_125e] Hat && Test: Hat_GIL_125e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_128e] Mark of Emeriss (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Doubled Attack and Health.
			// --------------------------------------------------------
			cards.Add("GIL_128e", new Power {
				// TODO [GIL_128e] Mark of Emeriss && Test: Mark of Emeriss_GIL_128e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_130e] Fable (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GIL_130e", new Power {
				// TODO [GIL_130e] Fable && Test: Fable_GIL_130e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_142e] Shifting (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Transforming into random card from your opponent's hand.
			// --------------------------------------------------------
			cards.Add("GIL_142e", new Power {
				// TODO [GIL_142e] Shifting && Test: Shifting_GIL_142e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_155e] Enraged (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("GIL_155e", new Power {
				// TODO [GIL_155e] Enraged && Test: Enraged_GIL_155e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_200e] Swapped Stats (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// GameTag:
			// - ENCHANTMENT_INVISIBLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_200e", new Power {
				// TODO [GIL_200e] Swapped Stats && Test: Swapped Stats_GIL_200e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_203e] Rebuked (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your spells cost (5) more this turn.
			// --------------------------------------------------------
			cards.Add("GIL_203e", new Power {
				// TODO [GIL_203e] Rebuked && Test: Rebuked_GIL_203e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_507e] Bewitched (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("GIL_507e", new Power {
				// TODO [GIL_507e] Bewitched && Test: Bewitched_GIL_507e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_510e] Misty (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_510e", new Power {
				// TODO [GIL_510e] Misty && Test: Misty_GIL_510e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_513e] Spooky Sacrifice (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_513e", new Power {
				// TODO [GIL_513e] Spooky Sacrifice && Test: Spooky Sacrifice_GIL_513e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_515e] Engorged (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_515e", new Power {
				// TODO [GIL_515e] Engorged && Test: Engorged_GIL_515e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_526e] For the Dragonhoard! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("GIL_526e", new Power {
				// TODO [GIL_526e] For the Dragonhoard! && Test: For the Dragonhoard!_GIL_526e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_534t] Reinforced (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_534t", new Power {
				// TODO [GIL_534t] Reinforced && Test: Reinforced_GIL_534t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_547e] Bloodfang (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_547e", new Power {
				// TODO [GIL_547e] Bloodfang && Test: Bloodfang_GIL_547e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_583e] Crunched (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_583e", new Power {
				// TODO [GIL_583e] Crunched && Test: Crunched_GIL_583e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_586e] Storm Hardened (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("GIL_586e", new Power {
				// TODO [GIL_586e] Storm Hardened && Test: Storm Hardened_GIL_586e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_596e] Sterling (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("GIL_596e", new Power {
				// TODO [GIL_596e] Sterling && Test: Sterling_GIL_596e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_601e] Bold Worm (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack and <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("GIL_601e", new Power {
				// TODO [GIL_601e] Bold Worm && Test: Bold Worm_GIL_601e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_607e] Viletoxin (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_607e", new Power {
				// TODO [GIL_607e] Viletoxin && Test: Viletoxin_GIL_607e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_614e1] Voodoo Doll Cursed (*) - COST:0 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroyed when Voodoo Doll is destroyed.
			// --------------------------------------------------------
			cards.Add("GIL_614e1", new Power {
				// TODO [GIL_614e1] Voodoo Doll Cursed && Test: Voodoo Doll Cursed_GIL_614e1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_614e2] Voodoo Doll Cursing (*) - COST:0 
			// - Set: gilneas, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Destroy {0}.
			// --------------------------------------------------------
			cards.Add("GIL_614e2", new Power {
				// TODO [GIL_614e2] Voodoo Doll Cursing && Test: Voodoo Doll Cursing_GIL_614e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_620e] Creepy Doll (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Dollmaster Dorian made a 1/1 copy.
			// --------------------------------------------------------
			cards.Add("GIL_620e", new Power {
				// TODO [GIL_620e] Creepy Doll && Test: Creepy Doll_GIL_620e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_623e] Grizzled (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Decreased Health.
			// --------------------------------------------------------
			cards.Add("GIL_623e", new Power {
				// TODO [GIL_623e] Grizzled && Test: Grizzled_GIL_623e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_624e] Stalking (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("GIL_624e", new Power {
				// TODO [GIL_624e] Stalking && Test: Stalking_GIL_624e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_640e] Rare Find! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("GIL_640e", new Power {
				// TODO [GIL_640e] Rare Find! && Test: Rare Find!_GIL_640e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_650e] Hounded! (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Houndmaster Shaw grants <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("GIL_650e", new Power {
				// TODO [GIL_650e] Hounded! && Test: Hounded!_GIL_650e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_653e] Woodcutter (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +2/+1.
			// --------------------------------------------------------
			cards.Add("GIL_653e", new Power {
				// TODO [GIL_653e] Woodcutter && Test: Woodcutter_GIL_653e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_655e] Grown (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("GIL_655e", new Power {
				// TODO [GIL_655e] Grown && Test: Grown_GIL_655e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_658e] Splintergrafted (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Splintergraft made this 10/10.
			// --------------------------------------------------------
			cards.Add("GIL_658e", new Power {
				// TODO [GIL_658e] Splintergrafted && Test: Splintergrafted_GIL_658e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_665e] Curse of Weakness (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: -2 Attack until next turn.
			// --------------------------------------------------------
			cards.Add("GIL_665e", new Power {
				// TODO [GIL_665e] Curse of Weakness && Test: Curse of Weakness_GIL_665e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_672e] Spooky (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Increased Durability.
			// --------------------------------------------------------
			cards.Add("GIL_672e", new Power {
				// TODO [GIL_672e] Spooky && Test: Spooky_GIL_672e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_692e] Curse of Ur (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (1).
			// --------------------------------------------------------
			cards.Add("GIL_692e", new Power {
				// TODO [GIL_692e] Curse of Ur && Test: Curse of Ur_GIL_692e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_800e2] Badsong (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("GIL_800e2", new Power {
				// TODO [GIL_800e2] Badsong && Test: Badsong_GIL_800e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_828e] Dire Frenzy (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("GIL_828e", new Power {
				// TODO [GIL_828e] Dire Frenzy && Test: Dire Frenzy_GIL_828e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_837e] Moth Dust (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: Doubled Health.
			// --------------------------------------------------------
			cards.Add("GIL_837e", new Power {
				// TODO [GIL_837e] Moth Dust && Test: Moth Dust_GIL_837e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_902e] Sharpened (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("GIL_902e", new Power {
				// TODO [GIL_902e] Sharpened && Test: Sharpened_GIL_902e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [GIL_905e] Corrosive Breath (*) - COST:0 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("GIL_905e", new Power {
				// TODO [GIL_905e] Corrosive Breath && Test: Corrosive Breath_GIL_905e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_201t] Pumpkin Peasant (*) - COST:3 [ATK:4/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("GIL_201t", new Power {
				// TODO [GIL_201t] Pumpkin Peasant && Test: Pumpkin Peasant_GIL_201t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_202t] Gilnean Royal Guard (*) - COST:8 [ATK:8/HP:3] 
			// - Set: gilneas, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>, <b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_202t", new Power {
				// TODO [GIL_202t] Gilnean Royal Guard && Test: Gilnean Royal Guard_GIL_202t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_528t] Swift Messenger (*) - COST:4 [ATK:6/HP:2] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Rush</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("GIL_528t", new Power {
				// TODO [GIL_528t] Swift Messenger && Test: Swift Messenger_GIL_528t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_529t] Spellshifter (*) - COST:2 [ATK:4/HP:1] 
			// - Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Spell Damage +1</b>
			//       Each turn this is in your hand,
			//       swap its Attack and Health.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("GIL_529t", new Power {
				// TODO [GIL_529t] Spellshifter && Test: Spellshifter_GIL_529t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616t] Splitting Sapling (*) - COST:3 [ATK:2/HP:2] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Woodchips.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("GIL_616t", new Power {
				// TODO [GIL_616t] Splitting Sapling && Test: Splitting Sapling_GIL_616t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_616t2] Woodchip (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_616t2", new Power {
				// TODO [GIL_616t2] Woodchip && Test: Woodchip_GIL_616t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_682t] Muckling (*) - COST:1 [ATK:2/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			cards.Add("GIL_682t", new Power {
				// TODO [GIL_682t] Muckling && Test: Muckling_GIL_682t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [GIL_683t] Drakeslayer (*) - COST:1 [ATK:2/HP:1] 
			// - Set: gilneas, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("GIL_683t", new Power {
				// TODO [GIL_683t] Drakeslayer && Test: Drakeslayer_GIL_683t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_828t7] Vicious Scalehide (*) - COST:2 [ATK:1/HP:3] 
			// - Race: beast, Set: gilneas, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       <b>Rush</b>@<b>Lifesteal</b>, <b>Rush</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t7", new Power {
				// TODO [ICC_828t7] Vicious Scalehide && Test: Vicious Scalehide_ICC_828t7
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
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
