using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets
{
	/// <summary>
	/// Naxxramas cardset.
	/// </summary>
	public class NaxxCardsGen
	{
		private static void Druid(IDictionary<string, List<Power>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [FP1_019] Poison Seeds - COST:4 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy all minions and summon 2/2 Treants to replace them.
			// --------------------------------------------------------
			cards.Add("FP1_019", new List<Power> {
				// TODO [FP1_019] Poison Seeds && Test: Poison Seeds_FP1_019
				new Power
				{
					Activation = PowerActivation.SPELL,
					PowerTask = null,
				},
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Power>> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [FP1_019t] Treant (*) - COST:1 [ATK:2/HP:2] 
			// - Set: naxx, 
			// --------------------------------------------------------
			cards.Add("FP1_019t", new List<Power> {
				// TODO [FP1_019t] Treant && Test: Treant_FP1_019t
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Hunter(IDictionary<string, List<Power>> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [FP1_011] Webspinner - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Beast card to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_011", new List<Power> {
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = ComplexTask.Create(
						new RandomMinionTask(GameTag.CARDRACE, (int)Race.BEAST),
						new AddStackTo(EntityType.HAND))
				}
			});
		}

		private static void Mage(IDictionary<string, List<Power>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [FP1_018] Duplicate - COST:3 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, put 2 copies of it into your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET_OR_QUEST = 1
			// --------------------------------------------------------
			cards.Add("FP1_018", new List<Power> {
				// TODO [FP1_018] Duplicate && Test: Duplicate_FP1_018
				new Power
				{
					Activation = PowerActivation.SPELL,
					PowerTask = null,
				},
			});

		}

		private static void Paladin(IDictionary<string, List<Power>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [FP1_020] Avenge - COST:1 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions dies, give a random friendly minion +3/+2.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET_OR_QUEST = 1
			// --------------------------------------------------------
			cards.Add("FP1_020", new List<Power> {
				// TODO [FP1_020] Avenge && Test: Avenge_FP1_020
				new Power
				{
					Activation = PowerActivation.SPELL,
					PowerTask = null,
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Power>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FP1_020e] Vengeance (*) - COST:0 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: +3/+2.
			// --------------------------------------------------------
			cards.Add("FP1_020e", new List<Power> {
				// TODO [FP1_020e] Vengeance && Test: Vengeance_FP1_020e
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Priest(IDictionary<string, List<Power>> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [FP1_023] Dark Cultist - COST:3 [ATK:3/HP:4] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a random friendly minion +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_023", new List<Power> {
				// TODO [FP1_023] Dark Cultist && Test: Dark Cultist_FP1_023
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Power>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FP1_023e] Power of the Ziggurat (*) - COST:0 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("FP1_023e", new List<Power> {
				// TODO [FP1_023e] Power of the Ziggurat && Test: Power of the Ziggurat_FP1_023e
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Rogue(IDictionary<string, List<Power>> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [FP1_026] Anub'ar Ambusher - COST:4 [ATK:5/HP:5] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return a random friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("FP1_026", new List<Power> {
				// TODO [FP1_026] Anub'ar Ambusher && Test: Anub'ar Ambusher_FP1_026
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

		}

		private static void Shaman(IDictionary<string, List<Power>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [FP1_025] Reincarnate - COST:2 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion, then return it to life with full Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FP1_025", new List<Power> {
				// TODO [FP1_025] Reincarnate && Test: Reincarnate_FP1_025
				new Power
				{
					Activation = PowerActivation.SPELL,
					PowerTask = null,
				},
			});

		}

		private static void Warlock(IDictionary<string, List<Power>> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [FP1_022] Voidcaller - COST:4 [ATK:3/HP:4] 
			// - Race: demon, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put a random Demon from your hand into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_022", new List<Power> {
				// TODO [FP1_022] Voidcaller && Test: Voidcaller_FP1_022
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

		}

		private static void Warrior(IDictionary<string, List<Power>> cards)
		{
			// --------------------------------------- WEAPON - WARRIOR
			// [FP1_021] Death's Bite - COST:4 [ATK:4/HP:0] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_021", new List<Power> {
				// TODO [FP1_021] Death's Bite && Test: Death's Bite_FP1_021
				new Power
				{
					Activation = PowerActivation.WEAPON,
					PowerTask = null,
				},
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

		}

		private static void Neutral(IDictionary<string, List<Power>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [FP1_001] Zombie Chow - COST:1 [ATK:2/HP:3] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_001", new List<Power> {
				// TODO [FP1_001] Zombie Chow && Test: Zombie Chow_FP1_001
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_002] Haunted Creeper - COST:2 [ATK:1/HP:2] 
			// - Race: beast, Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon two 1/1 Spectral Spiders.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_002", new List<Power> {
				// TODO [FP1_002] Haunted Creeper && Test: Haunted Creeper_FP1_002
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_003] Echoing Ooze - COST:2 [ATK:1/HP:2] 
			// - Set: naxx, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon an exact copy of this minion at the end of the turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_003", new List<Power> {
				// TODO [FP1_003] Echoing Ooze && Test: Echoing Ooze_FP1_003
				new Power
				{
					Activation = PowerActivation.BATTLECRY,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_004] Mad Scientist - COST:2 [ATK:2/HP:2] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET_OR_QUEST = 1
			// --------------------------------------------------------
			cards.Add("FP1_004", new List<Power> {
				// TODO [FP1_004] Mad Scientist && Test: Mad Scientist_FP1_004
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_005] Shade of Naxxramas - COST:3 [ATK:2/HP:2] 
			// - Set: naxx, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth.</b> At the start of your turn, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("FP1_005", new List<Power> {
				// TODO [FP1_005] Shade of Naxxramas && Test: Shade of Naxxramas_FP1_005
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_007] Nerubian Egg - COST:2 [ATK:0/HP:2] 
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 4/4 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_007", new List<Power> {

				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = new SummonTask("FP1_007t", SummonSide.DEATHRATTLE),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_008] Spectral Knight - COST:5 [ATK:4/HP:6] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_ABILITIES = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("FP1_008", new List<Power> {
				// TODO [FP1_008] Spectral Knight && Test: Spectral Knight_FP1_008
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_009] Deathlord - COST:3 [ATK:2/HP:8] 
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt. Deathrattle:</b> Your opponent puts a minion from their deck into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_009", new List<Power> {
				// TODO [FP1_009] Deathlord && Test: Deathlord_FP1_009
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_010] Maexxna - COST:6 [ATK:2/HP:8] 
			// - Race: beast, Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: Destroy any minion damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("FP1_010", new List<Power> {
				// TODO [FP1_010] Maexxna && Test: Maexxna_FP1_010
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_012] Sludge Belcher - COST:5 [ATK:3/HP:5] 
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt
			//       Deathrattle:</b> Summon a 1/2 Slime with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_012", new List<Power> {
				// TODO [FP1_012] Sludge Belcher && Test: Sludge Belcher_FP1_012
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_013] Kel'Thuzad - COST:8 [ATK:6/HP:8] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of each turn, summon all friendly minions that died this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("FP1_013", new List<Power> {
				// TODO [FP1_013] Kel'Thuzad && Test: Kel'Thuzad_FP1_013
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_014] Stalagg - COST:5 [ATK:7/HP:4] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If Feugen also died this game, summon Thaddius.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_014", new List<Power> {
				// TODO [FP1_014] Stalagg && Test: Stalagg_FP1_014
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_015] Feugen - COST:5 [ATK:4/HP:7] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If Stalagg also died this game, summon Thaddius.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_015", new List<Power> {
				// TODO [FP1_015] Feugen && Test: Feugen_FP1_015
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_016] Wailing Soul - COST:4 [ATK:3/HP:5] 
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry: Silence</b> your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("FP1_016", new List<Power> {
				// TODO [FP1_016] Wailing Soul && Test: Wailing Soul_FP1_016
				new Power
				{
					Activation = PowerActivation.BATTLECRY,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_017] Nerub'ar Weblord - COST:2 [ATK:1/HP:4] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Minions with <b>Battlecry</b> cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_017", new List<Power> {
				// TODO [FP1_017] Nerub'ar Weblord && Test: Nerub'ar Weblord_FP1_017
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_024] Unstable Ghoul - COST:2 [ATK:1/HP:3] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 1 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_024", new List<Power> {
				// TODO [FP1_024] Unstable Ghoul && Test: Unstable Ghoul_FP1_024
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_027] Stoneskin Gargoyle - COST:3 [ATK:1/HP:4] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, restore this minion to full Health.
			// --------------------------------------------------------
			cards.Add("FP1_027", new List<Power> {
				// TODO [FP1_027] Stoneskin Gargoyle && Test: Stoneskin Gargoyle_FP1_027
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_028] Undertaker - COST:1 [ATK:1/HP:2] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with <b>Deathrattle</b>, gain +1 Attack.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_028", new List<Power> {
				// TODO [FP1_028] Undertaker && Test: Undertaker_FP1_028
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_029] Dancing Swords - COST:3 [ATK:4/HP:4] 
			// - Set: naxx, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your opponent draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_029", new List<Power> {
				// TODO [FP1_029] Dancing Swords && Test: Dancing Swords_FP1_029
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_030] Loatheb - COST:5 [ATK:5/HP:5] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy spells cost (5) more next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("FP1_030", new List<Power> {
				// TODO [FP1_030] Loatheb && Test: Loatheb_FP1_030
				new Power
				{
					Activation = PowerActivation.BATTLECRY,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_031] Baron Rivendare - COST:4 [ATK:1/HP:7] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// Text: Your minions trigger their <b>Deathrattles</b> twice.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_031", new List<Power> {
				// TODO [FP1_031] Baron Rivendare && Test: Baron Rivendare_FP1_031
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Power>> cards)
		{


			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_005e] Consume (*) - COST:0 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FP1_005e", new List<Power> {
				// TODO [FP1_005e] Consume && Test: Consume_FP1_005e
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_028e] Darkness Calls (*) - COST:0 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FP1_028e", new List<Power> {
				// TODO [FP1_028e] Darkness Calls && Test: Darkness Calls_FP1_028e
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FP1_030e] Necrotic Aura (*) - COST:0 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: Your spells cost (5) more this turn.
			// --------------------------------------------------------
			cards.Add("FP1_030e", new List<Power> {
				// TODO [FP1_030e] Necrotic Aura && Test: Necrotic Aura_FP1_030e
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_002t] Spectral Spider (*) - COST:1 [ATK:1/HP:1] 
			// - Set: naxx, 
			// --------------------------------------------------------
			cards.Add("FP1_002t", new List<Power> {
				// TODO [FP1_002t] Spectral Spider && Test: Spectral Spider_FP1_002t
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_006] Deathcharger (*) - COST:1 [ATK:2/HP:3] 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: <b>Charge. Deathrattle:</b> Deal 3 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FP1_006", new List<Power> {
				// TODO [FP1_006] Deathcharger && Test: Deathcharger_FP1_006
				new Power
				{
					Activation = PowerActivation.DEATHRATTLE,
					PowerTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_007t] Nerubian (*) - COST:4 [ATK:4/HP:4] 
			// - Set: naxx, Rarity: rare
			// --------------------------------------------------------
			cards.Add("FP1_007t", new List<Power> {
				// TODO [FP1_007t] Nerubian && Test: Nerubian_FP1_007t
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_012t] Slime (*) - COST:1 [ATK:1/HP:2] 
			// - Set: naxx, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FP1_012t", new List<Power> {
				// TODO [FP1_012t] Slime && Test: Slime_FP1_012t
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FP1_014t] Thaddius (*) - COST:10 [ATK:11/HP:11] 
			// - Set: naxx, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("FP1_014t", new List<Power> {
				// TODO [FP1_014t] Thaddius && Test: Thaddius_FP1_014t
				new Power
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		public static void AddAll(Dictionary<string, List<Power>> cards)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		{
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			Mage(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			Shaman(cards);
			Warlock(cards);
			Warrior(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
