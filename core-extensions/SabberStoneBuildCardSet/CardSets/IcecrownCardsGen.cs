using System.Collections.Generic;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.CardSets.Undefined
{
	public class IcecrownCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ HERO - SHAMAN
			// [ICC_481] Thrall, Deathseer - COST:5 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform your minions into random ones that cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 42982
			// --------------------------------------------------------
			cards.Add("ICC_481", new Power {
				// TODO [ICC_481] Thrall, Deathseer && Test: Thrall, Deathseer_ICC_481
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- HERO - ROGUE
			// [ICC_827] Valeera the Hollow - COST:9 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43188
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("ICC_827", new Power {
				// TODO [ICC_827] Valeera the Hollow && Test: Valeera the Hollow_ICC_827
				InfoCardId = "ICC_827e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - HUNTER
			// [ICC_828] Deathstalker Rexxar - COST:6 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 2 damage
			//       to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43183
			// --------------------------------------------------------
			cards.Add("ICC_828", new Power {
				// TODO [ICC_828] Deathstalker Rexxar && Test: Deathstalker Rexxar_ICC_828
				InfoCardId = "ICC_828e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - PALADIN
			// [ICC_829] Uther of the Ebon Blade - COST:9 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43013
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_829", new Power {
				// TODO [ICC_829] Uther of the Ebon Blade && Test: Uther of the Ebon Blade_ICC_829
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ HERO - PRIEST
			// [ICC_830] Shadowreaper Anduin - COST:8 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 45397
			// --------------------------------------------------------
			cards.Add("ICC_830", new Power {
				// TODO [ICC_830] Shadowreaper Anduin && Test: Shadowreaper Anduin_ICC_830
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - WARLOCK
			// [ICC_831] Bloodreaver Gul'dan - COST:10 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 43181
			// --------------------------------------------------------
			cards.Add("ICC_831", new Power {
				// TODO [ICC_831] Bloodreaver Gul'dan && Test: Bloodreaver Gul'dan_ICC_831
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- HERO - DRUID
			// [ICC_832] Malfurion the Pestilent - COST:7 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b>
			//       Summon 2 <b>Poisonous</b>
			//       Spiders; or 2 Scarabs
			//       with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - ARMOR = 5
			// - HERO_POWER = 43182
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_832", new Power {
				// TODO [ICC_832] Malfurion the Pestilent && Test: Malfurion the Pestilent_ICC_832
				InfoCardId = "ICC_832e",
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------------- HERO - MAGE
			// [ICC_833] Frost Lich Jaina - COST:9 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       3/6 Water Elemental.
			//       Your Elementals have
			//       <b>Lifesteal</b> this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 42944
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_833", new Power {
				// TODO [ICC_833] Frost Lich Jaina && Test: Frost Lich Jaina_ICC_833
				InfoCardId = "ICC_833e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - WARRIOR
			// [ICC_834] Scourgelord Garrosh - COST:8 [ATK:0/HP:30] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - ARMOR = 5
			// - HERO_POWER = 45585
			// --------------------------------------------------------
			cards.Add("ICC_834", new Power {
				// TODO [ICC_834] Scourgelord Garrosh && Test: Scourgelord Garrosh_ICC_834
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_481p] Transmute Spirit (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_481p", new Power {
				// TODO [ICC_481p] Transmute Spirit && Test: Transmute Spirit_ICC_481p
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [ICC_827p] Death's Shadow (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       During your turn, add a 'Shadow Reflection' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICC_827p", new Power {
				// TODO [ICC_827p] Death's Shadow && Test: Death's Shadow_ICC_827p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_828p] Build-A-Beast (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Craft a custom Zombeast.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HAND_NOT_FULL = 0
			// --------------------------------------------------------
			cards.Add("ICC_828p", new Power {
				// TODO [ICC_828p] Build-A-Beast && Test: Build-A-Beast_ICC_828p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_829p] The Four Horsemen (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 2/2 Horseman.
			//       If you have all 4, destroy
			//       the enemy hero.
			// --------------------------------------------------------
			// Entourage: ICC_829t2, ICC_829t3, ICC_829t4, ICC_829t5
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ICC_829p", new Power {
				// TODO [ICC_829p] The Four Horsemen && Test: The Four Horsemen_ICC_829p
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ HERO_POWER - PRIEST
			// [ICC_830p] Voidform (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Deal $2 damage.
			//       After you play a card,
			//       refresh this. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_830p", new Power {
				// TODO [ICC_830p] Voidform && Test: Voidform_ICC_830p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_831p] Siphon Life (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_831p", new Power {
				// TODO [ICC_831p] Siphon Life && Test: Siphon Life_ICC_831p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_832p] Plague Lord (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       <b>Choose One -</b> +3 Attack
			//       this turn; or Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_832p", new Power {
				// TODO [ICC_832p] Plague Lord && Test: Plague Lord_ICC_832p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_833h] Icy Touch (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage. If this kills a minion, summon a Water Elemental. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_833h", new Power {
				// TODO [ICC_833h] Icy Touch && Test: Icy Touch_ICC_833h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [ICC_834h] Bladestorm (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_834h", new Power {
				// TODO [ICC_834h] Bladestorm && Test: Bladestorm_ICC_834h
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DeathknightNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t2] Army of the Dead (*) - COST:6 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Remove the top 5 cards of your deck. Summon any minions removed.
			// --------------------------------------------------------
			cards.Add("ICC_314t2", new Power {
				// TODO [ICC_314t2] Army of the Dead && Test: Army of the Dead_ICC_314t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t3] Doom Pact (*) - COST:5 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]Destroy all minions. 
			//       Remove the top card 
			//       from your deck for each
			//       minion destroyed.
			// --------------------------------------------------------
			cards.Add("ICC_314t3", new Power {
				// TODO [ICC_314t3] Doom Pact && Test: Doom Pact_ICC_314t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t4] Death Grip (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Steal a minion from your opponent's deck and add it to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_314t4", new Power {
				// TODO [ICC_314t4] Death Grip && Test: Death Grip_ICC_314t4
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t5] Death Coil (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to an enemy, or restore #5 Health to a friendly character. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_314t5", new Power {
				// TODO [ICC_314t5] Death Coil && Test: Death Coil_ICC_314t5
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t6] Obliterate (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Destroy a minion. Your hero takes damage equal to its Health.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_314t6", new Power {
				// TODO [ICC_314t6] Obliterate && Test: Obliterate_ICC_314t6
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t7] Anti-Magic Shell (*) - COST:4 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Give your minions +2/+2 and "Can't be targeted by spells or Hero Powers."
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t7", new Power {
				// TODO [ICC_314t7] Anti-Magic Shell && Test: Anti-Magic Shell_ICC_314t7
				InfoCardId = "ICC_314t7e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t8] Death and Decay (*) - COST:3 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_314t8", new Power {
				// TODO [ICC_314t8] Death and Decay && Test: Death and Decay_ICC_314t8
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICC_314t1] Frostmourne (*) - COST:7 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon every minion killed by this weapon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t1", new Power {
				// TODO [ICC_314t1] Frostmourne && Test: Frostmourne_ICC_314t1
				InfoCardId = "ICC_314t1e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [ICC_047] Fatespinner - COST:5 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose a Deathrattle (Secretly) -</b> Deal 3 damage to all minions; or Give them +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// - 818 = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047", new Power {
				// TODO [ICC_047] Fatespinner && Test: Fatespinner_ICC_047
				InfoCardId = "ICC_047e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_051] Druid of the Swarm - COST:2 [ATK:1/HP:2] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Transform into a 1/2 with <b>Poisonous</b>; or a 1/5 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051", new Power {
				// TODO [ICC_051] Druid of the Swarm && Test: Druid of the Swarm_ICC_051
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_807] Strongshell Scavenger - COST:4 [ATK:2/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your <b>Taunt</b> minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_807", new Power {
				// TODO [ICC_807] Strongshell Scavenger && Test: Strongshell Scavenger_ICC_807
				InfoCardId = "ICC_807e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_808] Crypt Lord - COST:3 [ATK:1/HP:6] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       After you summon a minion,
			//        gain +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_808", new Power {
				// TODO [ICC_808] Crypt Lord && Test: Crypt Lord_ICC_808
				InfoCardId = "ICC_808e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_835] Hadronox - COST:9 [ATK:3/HP:7] 
			// - Race: beast, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon your <b>Taunt</b> minions that
			//       died this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_835", new Power {
				// TODO [ICC_835] Hadronox && Test: Hadronox_ICC_835
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_050] Webweave - COST:5 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Summon two 1/2 <b>Poisonous</b> Spiders.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_050", new Power {
				// TODO [ICC_050] Webweave && Test: Webweave_ICC_050
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_054] Spreading Plague - COST:6 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 1/5 Scarab with <b>Taunt</b>. If your_opponent has more minions, cast this again.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_054", new Power {
				// TODO [ICC_054] Spreading Plague && Test: Spreading Plague_ICC_054
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_079] Gnash - COST:3 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Give your hero +3_Attack this turn. Gain 3 Armor.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_079", new Power {
				// TODO [ICC_079] Gnash && Test: Gnash_ICC_079
				InfoCardId = "ICC_079e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_085] Ultimate Infestation - COST:10 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage. Draw
			//       5 cards. Gain 5 Armor.
			//       Summon a 5/5 Ghoul. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_085", new Power {
				// TODO [ICC_085] Ultimate Infestation && Test: Ultimate Infestation_ICC_085
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_047e] Growth (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047e", new Power {
				// TODO [ICC_047e] Growth && Test: Growth_ICC_047e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_079e] Gnash (*) - COST:0 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_079e", new Power {
				// TODO [ICC_079e] Gnash && Test: Gnash_ICC_079e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_808e] Might of Ner'ub (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("ICC_808e", new Power {
				// TODO [ICC_808e] Might of Ner'ub && Test: Might of Ner'ub_ICC_808e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_047t] Fatespinner (*) - COST:5 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret Deathrattle:</b> Deal 3 damage to all minions; or Give them +2/+2.@<b>Secret Deathrattle:</b> Give +2/+2 to all minions.@<b>Secret Deathrattle:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047t", new Power {
				// TODO [ICC_047t] Fatespinner && Test: Fatespinner_ICC_047t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_047t2] Fatespinner (*) - COST:5 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to all minions and give them +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047t2", new Power {
				// TODO [ICC_047t2] Fatespinner && Test: Fatespinner_ICC_047t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t] Druid of the Swarm (*) - COST:2 [ATK:1/HP:2] 
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t", new Power {
				// TODO [ICC_051t] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t2] Druid of the Swarm (*) - COST:2 [ATK:1/HP:5] 
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t2", new Power {
				// TODO [ICC_051t2] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_051t3] Druid of the Swarm (*) - COST:2 [ATK:1/HP:5] 
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_051t3", new Power {
				// TODO [ICC_051t3] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_085t] Ghoul Infestor (*) - COST:5 [ATK:5/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_085t", new Power {
				// TODO [ICC_085t] Ghoul Infestor && Test: Ghoul Infestor_ICC_085t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_832t3] Frost Widow (*) - COST:1 [ATK:1/HP:2] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_832t3", new Power {
				// TODO [ICC_832t3] Frost Widow && Test: Frost Widow_ICC_832t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_832t4] Scarab Beetle (*) - COST:2 [ATK:1/HP:5] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_832t4", new Power {
				// TODO [ICC_832t4] Scarab Beetle && Test: Scarab Beetle_ICC_832t4
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047a] Growth (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all minions +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047a", new Power {
				// TODO [ICC_047a] Growth && Test: Growth_ICC_047a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047b] Decay (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			cards.Add("ICC_047b", new Power {
				// TODO [ICC_047b] Decay && Test: Decay_ICC_047b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051a] Spider Form (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("ICC_051a", new Power {
				// TODO [ICC_051a] Spider Form && Test: Spider Form_ICC_051a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051b] Scarab Form (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_051b", new Power {
				// TODO [ICC_051b] Scarab Form && Test: Scarab Form_ICC_051b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832a] Scarab Plague (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Summon two 1/5 Scarabs with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832a", new Power {
				// TODO [ICC_832a] Scarab Plague && Test: Scarab Plague_ICC_832a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832b] Spider Plague (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]Summon two 1/2
			//       Spiders with <b>Poisonous</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832b", new Power {
				// TODO [ICC_832b] Spider Plague && Test: Spider Plague_ICC_832b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pa] Scarab Shell (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Armor.
			// --------------------------------------------------------
			cards.Add("ICC_832pa", new Power {
				// TODO [ICC_832pa] Scarab Shell && Test: Scarab Shell_ICC_832pa
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pb] Spider Fangs (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_832pb", new Power {
				// TODO [ICC_832pb] Spider Fangs && Test: Spider Fangs_ICC_832pb
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [ICC_021] Exploding Bloatbat - COST:4 [ATK:2/HP:1] 
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b>
			//       Deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_021", new Power {
				// TODO [ICC_021] Exploding Bloatbat && Test: Exploding Bloatbat_ICC_021
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_204] Professor Putricide - COST:4 [ATK:5/HP:4] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play a <b>Secret</b>,
			//       put a random Hunter <b>Secret</b> into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_204", new Power {
				// TODO [ICC_204] Professor Putricide && Test: Professor Putricide_ICC_204
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_243] Corpse Widow - COST:5 [ATK:4/HP:6] 
			// - Race: beast, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> cards cost_(2) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_243", new Power {
				// TODO [ICC_243] Corpse Widow && Test: Corpse Widow_ICC_243
				InfoCardId = "ICC_243e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_415] Stitched Tracker - COST:3 [ATK:2/HP:2] 
			// - Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a copy of a minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ICC_415", new Power {
				// TODO [ICC_415] Stitched Tracker && Test: Stitched Tracker_ICC_415
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_419] Bearshark - COST:3 [ATK:4/HP:3] 
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Can't be targeted by spells or Hero Powers.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_419", new Power {
				// TODO [ICC_419] Bearshark && Test: Bearshark_ICC_419
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_825] Abominable Bowman - COST:7 [ATK:6/HP:7] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon
			//       a random friendly Beast
			//       that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_825", new Power {
				// TODO [ICC_825] Abominable Bowman && Test: Abominable Bowman_ICC_825
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_049] Toxic Arrow - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_049", new Power {
				// TODO [ICC_049] Toxic Arrow && Test: Toxic Arrow_ICC_049
				InfoCardId = "ICC_049e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_052] Play Dead - COST:1 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Trigger a friendly minion's <b>Deathrattle</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_052", new Power {
				// TODO [ICC_052] Play Dead && Test: Play Dead_ICC_052
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_200] Venomstrike Trap - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When one of your minions is attacked, summon a 2/3_<b>Poisonous</b> Cobra.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_200", new Power {
				// TODO [ICC_200] Venomstrike Trap && Test: Venomstrike Trap_ICC_200
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [ICC_828e] Stitched (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: {0} and {1}.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_SILENCED = 1
			// --------------------------------------------------------
			cards.Add("ICC_828e", new Power {
				// TODO [ICC_828e] Stitched && Test: Stitched_ICC_828e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t] Zombeast (*) - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("ICC_828t", new Power {
				// TODO [ICC_828t] Zombeast && Test: Zombeast_ICC_828t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [ICC_068] Ice Walker - COST:2 [ATK:1/HP:3] 
			// - Race: elemental, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your Hero Power also <b><b>Freeze</b>s</b> the target.
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_068", new Power {
				// TODO [ICC_068] Ice Walker && Test: Ice Walker_ICC_068
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [ICC_069] Ghastly Conjurer - COST:4 [ATK:2/HP:6] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a 'Mirror Image' spell to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_069", new Power {
				// TODO [ICC_069] Ghastly Conjurer && Test: Ghastly Conjurer_ICC_069
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [ICC_083] Doomed Apprentice - COST:3 [ATK:3/HP:2] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Your opponent's spells cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_083", new Power {
				// TODO [ICC_083] Doomed Apprentice && Test: Doomed Apprentice_ICC_083
				InfoCardId = "ICC_083e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [ICC_252] Coldwraith - COST:3 [ATK:3/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FROZEN_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_252", new Power {
				// TODO [ICC_252] Coldwraith && Test: Coldwraith_ICC_252
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [ICC_838] Sindragosa - COST:8 [ATK:8/HP:8] 
			// - Race: dragon, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 0/1 Frozen Champions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_838", new Power {
				// TODO [ICC_838] Sindragosa && Test: Sindragosa_ICC_838
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_082] Frozen Clone - COST:3 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, add two copies of it to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_082", new Power {
				// TODO [ICC_082] Frozen Clone && Test: Frozen Clone_ICC_082
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_086] Glacial Mysteries - COST:8 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Put one of each <b>Secret</b> from your deck into
			//       the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("ICC_086", new Power {
				// TODO [ICC_086] Glacial Mysteries && Test: Glacial Mysteries_ICC_086
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_823] Simulacrum - COST:3 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Copy the lowest Cost minion in your hand.
			// --------------------------------------------------------
			cards.Add("ICC_823", new Power {
				// TODO [ICC_823] Simulacrum && Test: Simulacrum_ICC_823
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_836] Breath of Sindragosa - COST:1 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_836", new Power {
				// TODO [ICC_836] Breath of Sindragosa && Test: Breath of Sindragosa_ICC_836
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [ICC_833t] Water Elemental (*) - COST:4 [ATK:3/HP:6] 
			// - Race: elemental, Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_833t", new Power {
				// TODO [ICC_833t] Water Elemental && Test: Water Elemental_ICC_833t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [ICC_838t] Frozen Champion (*) - COST:1 [ATK:0/HP:1] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Add a
			//       random <b>Legendary</b> minion
			//       to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_838t", new Power {
				// TODO [ICC_838t] Frozen Champion && Test: Frozen Champion_ICC_838t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [ICC_034] Arrogant Crusader - COST:4 [ATK:5/HP:2] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 974 = 1
			// --------------------------------------------------------
			cards.Add("ICC_034", new Power {
				// TODO [ICC_034] Arrogant Crusader && Test: Arrogant Crusader_ICC_034
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_038] Righteous Protector - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_038", new Power {
				// TODO [ICC_038] Righteous Protector && Test: Righteous Protector_ICC_038
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_245] Blackguard - COST:6 [ATK:3/HP:9] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your hero is healed, deal that much damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("ICC_245", new Power {
				// TODO [ICC_245] Blackguard && Test: Blackguard_ICC_245
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_801] Howling Commander - COST:3 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a <b>Divine_Shield</b> minion from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_801", new Power {
				// TODO [ICC_801] Howling Commander && Test: Howling Commander_ICC_801
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_820] Chillblade Champion - COST:4 [ATK:3/HP:2] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_820", new Power {
				// TODO [ICC_820] Chillblade Champion && Test: Chillblade Champion_ICC_820
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_858] Bolvar, Fireblood - COST:5 [ATK:1/HP:7] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       After a friendly minion loses_<b>Divine Shield</b>, gain +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_858", new Power {
				// TODO [ICC_858] Bolvar, Fireblood && Test: Bolvar, Fireblood_ICC_858
				InfoCardId = "ICC_858e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [ICC_039] Dark Conviction - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Set a minion's Attack and Health to 3.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_039", new Power {
				// TODO [ICC_039] Dark Conviction && Test: Dark Conviction_ICC_039
				InfoCardId = "ICC_039e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [ICC_244] Desperate Stand - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_244", new Power {
				// TODO [ICC_244] Desperate Stand && Test: Desperate Stand_ICC_244
				InfoCardId = "ICC_244e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [ICC_071] Light's Sorrow - COST:4 [ATK:1/HP:0] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: After a friendly minion loses <b>Divine Shield</b>, gain +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_071", new Power {
				// TODO [ICC_071] Light's Sorrow && Test: Light's Sorrow_ICC_071
				InfoCardId = "ICC_071e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_071e] Dying Light (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_071e", new Power {
				// TODO [ICC_071e] Dying Light && Test: Dying Light_ICC_071e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_244e] Redeemed (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to life with 1 Health.
			// --------------------------------------------------------
			cards.Add("ICC_244e", new Power {
				// TODO [ICC_244e] Redeemed && Test: Redeemed_ICC_244e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_858e] Fading Light (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_858e", new Power {
				// TODO [ICC_858e] Fading Light && Test: Fading Light_ICC_858e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t2] Deathlord Nazgrim (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t2", new Power {
				// TODO [ICC_829t2] Deathlord Nazgrim && Test: Deathlord Nazgrim_ICC_829t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t3] Thoras Trollbane (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t3", new Power {
				// TODO [ICC_829t3] Thoras Trollbane && Test: Thoras Trollbane_ICC_829t3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t4] Inquisitor Whitemane (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t4", new Power {
				// TODO [ICC_829t4] Inquisitor Whitemane && Test: Inquisitor Whitemane_ICC_829t4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t5] Darion Mograine (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t5", new Power {
				// TODO [ICC_829t5] Darion Mograine && Test: Darion Mograine_ICC_829t5
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [ICC_829t] Grave Vengeance (*) - COST:8 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t", new Power {
				// TODO [ICC_829t] Grave Vengeance && Test: Grave Vengeance_ICC_829t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [ICC_210] Shadow Ascendant - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       give another random
			//       friendly minion +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_210", new Power {
				// TODO [ICC_210] Shadow Ascendant && Test: Shadow Ascendant_ICC_210
				InfoCardId = "ICC_210e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [ICC_212] Acolyte of Agony - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_212", new Power {
				// TODO [ICC_212] Acolyte of Agony && Test: Acolyte of Agony_ICC_212
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt, Lifesteal</b>
			//       <b>Deathrattle:</b> Destroy a
			//        random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_214", new Power {
				// TODO [ICC_214] Obsidian Statue && Test: Obsidian Statue_ICC_214
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [ICC_215] Archbishop Benedictus - COST:7 [ATK:4/HP:6] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Shuffle a copy of_your opponent's deck into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_215", new Power {
				// TODO [ICC_215] Archbishop Benedictus && Test: Archbishop Benedictus_ICC_215
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_207] Devour Mind - COST:5 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Copy 3 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_207", new Power {
				// TODO [ICC_207] Devour Mind && Test: Devour Mind_ICC_207
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_213] Eternal Servitude - COST:4 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ICC_213", new Power {
				// TODO [ICC_213] Eternal Servitude && Test: Eternal Servitude_ICC_213
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_235] Shadow Essence - COST:6 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 5/5 copy of_a random minion in_your deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ICC_235", new Power {
				// TODO [ICC_235] Shadow Essence && Test: Shadow Essence_ICC_235
				InfoCardId = "ICC_235e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_802] Spirit Lash - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $1 damage to_all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_802", new Power {
				// TODO [ICC_802] Spirit Lash && Test: Spirit Lash_ICC_802
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_849] Embrace Darkness - COST:6 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Choose an enemy minion.
			//       At the start of your turn,
			//       gain control of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_849", new Power {
				// TODO [ICC_849] Embrace Darkness && Test: Embrace Darkness_ICC_849
				InfoCardId = "ICC_849e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ICC_210e] Ascended (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Stats increased.
			// --------------------------------------------------------
			cards.Add("ICC_210e", new Power {
				// TODO [ICC_210e] Ascended && Test: Ascended_ICC_210e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [ICC_065] Bone Baron - COST:5 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add two 1/1 Skeletons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_065", new Power {
				// TODO [ICC_065] Bone Baron && Test: Bone Baron_ICC_065
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [ICC_240] Runeforge Haunter - COST:4 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: During your turn, your weapon doesn't lose Durability.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_240", new Power {
				// TODO [ICC_240] Runeforge Haunter && Test: Runeforge Haunter_ICC_240
				InfoCardId = "ICC_240e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [ICC_809] Plague Scientist - COST:3 [ATK:2/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Give a friendly minion <b>Poisonous</b>.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_809", new Power {
				// TODO [ICC_809] Plague Scientist && Test: Plague Scientist_ICC_809
				InfoCardId = "ICC_809e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [ICC_811] Lilian Voss - COST:4 [ATK:4/HP:5] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Replace spells in your hand with random spells <i>(from your opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_811", new Power {
				// TODO [ICC_811] Lilian Voss && Test: Lilian Voss_ICC_811
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [ICC_910] Spectral Pillager - COST:6 [ATK:5/HP:5] 
			// - Fac: neutral, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Combo:</b> Deal damage equal
			//       to the number of other cards
			//       you've played this turn.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("ICC_910", new Power {
				// TODO [ICC_910] Spectral Pillager && Test: Spectral Pillager_ICC_910
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_201] Roll the Bones - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Draw a card.
			//       If it has <b>Deathrattle</b>, cast this again.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_201", new Power {
				// TODO [ICC_201] Roll the Bones && Test: Roll the Bones_ICC_201
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_221] Leeching Poison - COST:2 
			// - Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Give your weapon <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_221", new Power {
				// TODO [ICC_221] Leeching Poison && Test: Leeching Poison_ICC_221
				InfoCardId = "ICC_221e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_233] Doomerang - COST:1 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Throw your weapon at a minion. It deals its damage, then returns to_your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("ICC_233", new Power {
				// TODO [ICC_233] Doomerang && Test: Doomerang_ICC_233
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [ICC_850] Shadowblade - COST:3 [ATK:3/HP:0] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ICC_850", new Power {
				// TODO [ICC_850] Shadowblade && Test: Shadowblade_ICC_850
				InfoCardId = "ICC_850e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_018e] Witty Weaponplay (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_018e", new Power {
				// TODO [ICC_018e] Witty Weaponplay && Test: Witty Weaponplay_ICC_018e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_221e] Leeching Poison (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_221e", new Power {
				// TODO [ICC_221e] Leeching Poison && Test: Leeching Poison_ICC_221e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_240e] Resilient Weapon (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			cards.Add("ICC_240e", new Power {
				// TODO [ICC_240e] Resilient Weapon && Test: Resilient Weapon_ICC_240e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_809e] Test Subject (*) - COST:0 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_809e", new Power {
				// TODO [ICC_809e] Test Subject && Test: Test Subject_ICC_809e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e] Shadow Reflection (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Always copy your last played card.
			// --------------------------------------------------------
			cards.Add("ICC_827e", new Power {
				// TODO [ICC_827e] Shadow Reflection && Test: Shadow Reflection_ICC_827e
				InfoCardId = "ICC_827e3",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e3] Veil of Shadows (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("ICC_827e3", new Power {
				// TODO [ICC_827e3] Veil of Shadows && Test: Veil of Shadows_ICC_827e3
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_850e] Shaded (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_850e", new Power {
				// TODO [ICC_850e] Shaded && Test: Shaded_ICC_850e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [ICC_827t] Shadow Reflection (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Each time you play a card, transform this into a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MUST_PLAY_OTHER_CARD_FIRST = 0
			// --------------------------------------------------------
			cards.Add("ICC_827t", new Power {
				// TODO [ICC_827t] Shadow Reflection && Test: Shadow Reflection_ICC_827t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [ICC_058] Brrrloc - COST:2 [ATK:2/HP:2] 
			// - Race: murloc, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> an_enemy.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_058", new Power {
				// TODO [ICC_058] Brrrloc && Test: Brrrloc_ICC_058
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Overload:</b> (3)
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("ICC_081", new Power {
				// TODO [ICC_081] Drakkari Defender && Test: Drakkari Defender_ICC_081
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_088] Voodoo Hexxer - COST:5 [ATK:2/HP:7] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Freeze</b> any character damaged by this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_088", new Power {
				// TODO [ICC_088] Voodoo Hexxer && Test: Voodoo Hexxer_ICC_088
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_090] Snowfury Giant - COST:11 [ATK:8/HP:8] 
			// - Race: elemental, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each Mana Crystal you've <b><b>Overload</b>ed</b> this game.
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("ICC_090", new Power {
				// TODO [ICC_090] Snowfury Giant && Test: Snowfury Giant_ICC_090
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_289] Moorabi - COST:6 [ATK:4/HP:4] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever another minion is <b>Frozen</b>, add a copy of it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_289", new Power {
				// TODO [ICC_289] Moorabi && Test: Moorabi_ICC_289
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_056] Cryostasis - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a minion +3/+3 and <b>Freeze</b> it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_056", new Power {
				// TODO [ICC_056] Cryostasis && Test: Cryostasis_ICC_056
				InfoCardId = "ICC_056e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_078] Avalanche - COST:4 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_078", new Power {
				// TODO [ICC_078] Avalanche && Test: Avalanche_ICC_078
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_089] Ice Fishing - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Murlocs from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_089", new Power {
				// TODO [ICC_089] Ice Fishing && Test: Ice Fishing_ICC_089
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [ICC_236] Ice Breaker - COST:3 [ATK:1/HP:0] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy any <b>Frozen</b> minion damaged by_this.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_236", new Power {
				// TODO [ICC_236] Ice Breaker && Test: Ice Breaker_ICC_236
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [ICC_075] Despicable Dreadlord - COST:5 [ATK:4/HP:5] 
			// - Race: demon, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all enemy minions.
			// --------------------------------------------------------
			cards.Add("ICC_075", new Power {
				// TODO [ICC_075] Despicable Dreadlord && Test: Despicable Dreadlord_ICC_075
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [ICC_218] Howlfiend - COST:3 [ATK:3/HP:6] 
			// - Race: demon, Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, discard a_random card.
			// --------------------------------------------------------
			cards.Add("ICC_218", new Power {
				// TODO [ICC_218] Howlfiend && Test: Howlfiend_ICC_218
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [ICC_407] Gnomeferatu - COST:2 [ATK:2/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove
			//       the top card of your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_407", new Power {
				// TODO [ICC_407] Gnomeferatu && Test: Gnomeferatu_ICC_407
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [ICC_841] Blood-Queen Lana'thel - COST:5 [ATK:1/HP:6] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Lifesteal</b>
			//       Has +1 Attack for each
			//       card you've discarded
			//       this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_841", new Power {
				// TODO [ICC_841] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_ICC_841
				InfoCardId = "ICC_841e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [ICC_903] Sanguine Reveler - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a friendly minion and gain_+2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_903", new Power {
				// TODO [ICC_903] Sanguine Reveler && Test: Sanguine Reveler_ICC_903
				InfoCardId = "ICC_903t",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_041] Defile - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If any die, cast this again. @spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_041", new Power {
				// TODO [ICC_041] Defile && Test: Defile_ICC_041
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_055] Drain Soul - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $2 damage
			//       to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_055", new Power {
				// TODO [ICC_055] Drain Soul && Test: Drain Soul_ICC_055
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_206] Treachery - COST:3 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a friendly minion and give it to_your opponent.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_206", new Power {
				// TODO [ICC_206] Treachery && Test: Treachery_ICC_206
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_469] Unwilling Sacrifice - COST:3 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Destroy it and a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_469", new Power {
				// TODO [ICC_469] Unwilling Sacrifice && Test: Unwilling Sacrifice_ICC_469
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [ICC_062] Mountainfire Armor - COST:3 [ATK:4/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn,
			//       gain 6 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 974 = 1
			// --------------------------------------------------------
			cards.Add("ICC_062", new Power {
				// TODO [ICC_062] Mountainfire Armor && Test: Mountainfire Armor_ICC_062
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_238] Animated Berserker - COST:1 [ATK:1/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a minion, deal 1 damage to it.
			// --------------------------------------------------------
			cards.Add("ICC_238", new Power {
				// TODO [ICC_238] Animated Berserker && Test: Animated Berserker_ICC_238
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_405] Rotface - COST:8 [ATK:4/HP:6] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]After this minion
			//       survives damage,
			//       summon a random
			//       <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_405", new Power {
				// TODO [ICC_405] Rotface && Test: Rotface_ICC_405
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After this minion
			//       survives damage,
			//       summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_408", new Power {
				// TODO [ICC_408] Val'kyr Soulclaimer && Test: Val'kyr Soulclaimer_ICC_408
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_450] Death Revenant - COST:5 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for each damaged minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_450", new Power {
				// TODO [ICC_450] Death Revenant && Test: Death Revenant_ICC_450
				InfoCardId = "ICC_450e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_091] Dead Man's Hand - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle a copy of your hand into your deck.
			// --------------------------------------------------------
			cards.Add("ICC_091", new Power {
				// TODO [ICC_091] Dead Man's Hand && Test: Dead Man's Hand_ICC_091
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_281] Forge of Souls - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 weapons from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_281", new Power {
				// TODO [ICC_281] Forge of Souls && Test: Forge of Souls_ICC_281
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_837] Bring It On! - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837", new Power {
				// TODO [ICC_837] Bring It On! && Test: Bring It On!_ICC_837
				InfoCardId = "ICC_837e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b>
			//       Deal 1 damage to all_minions.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_064", new Power {
				// TODO [ICC_064] Blood Razor && Test: Blood Razor_ICC_064
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_834w] Shadowmourne (*) - COST:8 [ATK:4/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever your hero_attacks.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("ICC_834w", new Power {
				// TODO [ICC_834w] Shadowmourne && Test: Shadowmourne_ICC_834w
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [ICC_018] Phantom Freebooter - COST:4 [ATK:3/HP:3] 
			// - Race: pirate, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain stats equal to your weapon's.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_018", new Power {
				// TODO [ICC_018] Phantom Freebooter && Test: Phantom Freebooter_ICC_018
				InfoCardId = "ICC_018e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 974 = 1
			// --------------------------------------------------------
			cards.Add("ICC_019", new Power {
				// TODO [ICC_019] Skelemancer && Test: Skelemancer_ICC_019
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_023] Snowflipper Penguin - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			cards.Add("ICC_023", new Power {
				// TODO [ICC_023] Snowflipper Penguin && Test: Snowflipper Penguin_ICC_023
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_025] Rattling Rascal - COST:4 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Summon a
			//       5/5 Skeleton.
			//       <b>Deathrattle:</b> Summon one
			//       for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_025", new Power {
				// TODO [ICC_025] Rattling Rascal && Test: Rattling Rascal_ICC_025
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_026] Grim Necromancer - COST:4 [ATK:2/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Skeletons.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_026", new Power {
				// TODO [ICC_026] Grim Necromancer && Test: Grim Necromancer_ICC_026
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_027] Bone Drake - COST:6 [ATK:6/HP:5] 
			// - Race: dragon, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_027", new Power {
				// TODO [ICC_027] Bone Drake && Test: Bone Drake_ICC_027
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_028] Sunborne Val'kyr - COST:5 [ATK:5/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_028", new Power {
				// TODO [ICC_028] Sunborne Val'kyr && Test: Sunborne Val'kyr_ICC_028
				InfoCardId = "ICC_028e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_029] Cobalt Scalebane - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_029", new Power {
				// TODO [ICC_029] Cobalt Scalebane && Test: Cobalt Scalebane_ICC_029
				InfoCardId = "ICC_029e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_031] Night Howler - COST:4 [ATK:3/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes
			//       damage, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031", new Power {
				// TODO [ICC_031] Night Howler && Test: Night Howler_ICC_031
				InfoCardId = "ICC_031e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_032] Venomancer - COST:5 [ATK:2/HP:5] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_032", new Power {
				// TODO [ICC_032] Venomancer && Test: Venomancer_ICC_032
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_067] Vryghoul - COST:3 [ATK:3/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> If it's your
			//       opponent's turn,
			//       summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 974 = 1
			// --------------------------------------------------------
			cards.Add("ICC_067", new Power {
				// TODO [ICC_067] Vryghoul && Test: Vryghoul_ICC_067
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_092] Acherus Veteran - COST:1 [ATK:2/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_092", new Power {
				// TODO [ICC_092] Acherus Veteran && Test: Acherus Veteran_ICC_092
				InfoCardId = "ICC_092e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_093] Tuskarr Fisherman - COST:2 [ATK:2/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("ICC_093", new Power {
				// TODO [ICC_093] Tuskarr Fisherman && Test: Tuskarr Fisherman_ICC_093
				InfoCardId = "ICC_093e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_094] Fallen Sun Cleric - COST:2 [ATK:2/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_094", new Power {
				// TODO [ICC_094] Fallen Sun Cleric && Test: Fallen Sun Cleric_ICC_094
				InfoCardId = "ICC_094e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_096] Furnacefire Colossus - COST:6 [ATK:6/HP:6] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Discard all weapons from your hand and gain their stats.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_096", new Power {
				// TODO [ICC_096] Furnacefire Colossus && Test: Furnacefire Colossus_ICC_096
				InfoCardId = "ICC_096e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_097] Grave Shambler - COST:4 [ATK:4/HP:4] 
			// - Race: elemental, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your weapon is destroyed, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_097", new Power {
				// TODO [ICC_097] Grave Shambler && Test: Grave Shambler_ICC_097
				InfoCardId = "ICC_097e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_098] Tomb Lurker - COST:5 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Add a random
			//       <b>Deathrattle</b> minion that died
			//       this game to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_098", new Power {
				// TODO [ICC_098] Tomb Lurker && Test: Tomb Lurker_ICC_098
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_099] Ticking Abomination - COST:4 [ATK:5/HP:6] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to your minions.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_099", new Power {
				// TODO [ICC_099] Ticking Abomination && Test: Ticking Abomination_ICC_099
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_220] Deadscale Knight - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_220", new Power {
				// TODO [ICC_220] Deadscale Knight && Test: Deadscale Knight_ICC_220
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_257] Corpse Raiser - COST:5 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a friendly
			//       minion "<b>Deathrattle:</b>
			//         Resummon this minion."
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - DEATH_KNIGHT = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_257", new Power {
				// TODO [ICC_257] Corpse Raiser && Test: Corpse Raiser_ICC_257
				InfoCardId = "ICC_257e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_314] The Lich King - COST:8 [ATK:8/HP:8] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       At the end of your turn,
			//       add a random <b>Death Knight</b>
			//       card to your hand.
			// --------------------------------------------------------
			// Entourage: ICC_314t3, ICC_314t2, ICC_314t7, ICC_314t4, ICC_314t5, ICC_314t6, ICC_314t8, ICC_314t1
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_314", new Power {
				// TODO [ICC_314] The Lich King && Test: The Lich King_ICC_314
				InfoCardId = "ICC_314t1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_466] Saronite Chain Gang - COST:4 [ATK:2/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Summon a copy of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_466", new Power {
				// TODO [ICC_466] Saronite Chain Gang && Test: Saronite Chain Gang_ICC_466
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_467] Deathspeaker - COST:3 [ATK:2/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ICC_467", new Power {
				// TODO [ICC_467] Deathspeaker && Test: Deathspeaker_ICC_467
				InfoCardId = "ICC_467e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_468] Wretched Tiller - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, deal 2 damage to_the enemy hero.
			// --------------------------------------------------------
			cards.Add("ICC_468", new Power {
				// TODO [ICC_468] Wretched Tiller && Test: Wretched Tiller_ICC_468
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_700] Happy Ghoul - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Costs (0) if your hero was healed this turn.
			// --------------------------------------------------------
			cards.Add("ICC_700", new Power {
				// TODO [ICC_700] Happy Ghoul && Test: Happy Ghoul_ICC_700
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_701] Skulking Geist - COST:6 [ATK:4/HP:6] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy all
			//       1-Cost spells in both hands and decks.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_701", new Power {
				// TODO [ICC_701] Skulking Geist && Test: Skulking Geist_ICC_701
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_702] Shallow Gravedigger - COST:3 [ATK:3/HP:1] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_702", new Power {
				// TODO [ICC_702] Shallow Gravedigger && Test: Shallow Gravedigger_ICC_702
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_705] Bonemare - COST:8 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_705", new Power {
				// TODO [ICC_705] Bonemare && Test: Bonemare_ICC_705
				InfoCardId = "ICC_705e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_706] Nerubian Unraveler - COST:6 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Spells cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_706", new Power {
				// TODO [ICC_706] Nerubian Unraveler && Test: Nerubian Unraveler_ICC_706
				InfoCardId = "ICC_706e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_810] Deathaxe Punisher - COST:4 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_810", new Power {
				// TODO [ICC_810] Deathaxe Punisher && Test: Deathaxe Punisher_ICC_810
				InfoCardId = "ICC_810e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_812] Meat Wagon - COST:4 [ATK:1/HP:4] 
			// - Race: mechanical, Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       minion from your deck
			//       with less Attack than
			//       this minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_812", new Power {
				// TODO [ICC_812] Meat Wagon && Test: Meat Wagon_ICC_812
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_851] Prince Keleseth - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has_no 2-Cost cards, give_all minions in your deck +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_851", new Power {
				// TODO [ICC_851] Prince Keleseth && Test: Prince Keleseth_ICC_851
				InfoCardId = "ICC_851e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_852] Prince Taldaram - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has_no 3-Cost cards, transform into a 3/3 copy of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_NO_3_COST_CARD_IN_DECK = 0
			// --------------------------------------------------------
			cards.Add("ICC_852", new Power {
				// TODO [ICC_852] Prince Taldaram && Test: Prince Taldaram_ICC_852
				InfoCardId = "ICC_852e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_853] Prince Valanar - COST:4 [ATK:4/HP:4] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_853", new Power {
				// TODO [ICC_853] Prince Valanar && Test: Prince Valanar_ICC_853
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_854] Arfus - COST:4 [ATK:2/HP:2] 
			// - Race: beast, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your_hand.
			// --------------------------------------------------------
			// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t5, ICC_314t7, ICC_314t8, ICC_314t6, ICC_314t1
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_854", new Power {
				// TODO [ICC_854] Arfus && Test: Arfus_ICC_854
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_855] Hyldnir Frostrider - COST:3 [ATK:4/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Freeze</b> your other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_855", new Power {
				// TODO [ICC_855] Hyldnir Frostrider && Test: Hyldnir Frostrider_ICC_855
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_856] Spellweaver - COST:6 [ATK:4/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +2</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 2
			// --------------------------------------------------------
			cards.Add("ICC_856", new Power {
				// TODO [ICC_856] Spellweaver && Test: Spellweaver_ICC_856
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900] Necrotic Geist - COST:6 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever one of your other minions dies, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_900", new Power {
				// TODO [ICC_900] Necrotic Geist && Test: Necrotic Geist_ICC_900
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_901] Drakkari Enchanter - COST:3 [ATK:1/HP:5] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Your end of turn effects trigger twice.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_901", new Power {
				// TODO [ICC_901] Drakkari Enchanter && Test: Drakkari Enchanter_ICC_901
				InfoCardId = "ICC_901e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_902] Mindbreaker - COST:3 [ATK:2/HP:5] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Hero Powers are disabled.
			// --------------------------------------------------------
			cards.Add("ICC_902", new Power {
				// TODO [ICC_902] Mindbreaker && Test: Mindbreaker_ICC_902
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_904] Wicked Skeleton - COST:4 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +1/+1 for_each minion that died_this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_904", new Power {
				// TODO [ICC_904] Wicked Skeleton && Test: Wicked Skeleton_ICC_904
				InfoCardId = "ICC_904e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_905] Bloodworm - COST:5 [ATK:4/HP:4] 
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_905", new Power {
				// TODO [ICC_905] Bloodworm && Test: Bloodworm_ICC_905
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_911] Keening Banshee - COST:4 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, remove the top 3 cards of_your deck.
			// --------------------------------------------------------
			cards.Add("ICC_911", new Power {
				// TODO [ICC_911] Keening Banshee && Test: Keening Banshee_ICC_911
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_912] Corpsetaker - COST:4 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Gain <b>Taunt</b> if your
			//       deck has a <b>Taunt</b> minion.
			//       Repeat for <b>Divine Shield</b>,
			//       <b>Lifesteal</b>, <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_912", new Power {
				// TODO [ICC_912] Corpsetaker && Test: Corpsetaker_ICC_912
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_913] Tainted Zealot - COST:2 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//       <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("ICC_913", new Power {
				// TODO [ICC_913] Tainted Zealot && Test: Tainted Zealot_ICC_913
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_028e] Blessing of the Val'kyr (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("ICC_028e", new Power {
				// TODO [ICC_028e] Blessing of the Val'kyr && Test: Blessing of the Val'kyr_ICC_028e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_029e] Dragonscales (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("ICC_029e", new Power {
				// TODO [ICC_029e] Dragonscales && Test: Dragonscales_ICC_029e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_031e] Awooooo! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: This minion has increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031e", new Power {
				// TODO [ICC_031e] Awooooo! && Test: Awooooo!_ICC_031e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_039e] Convinced (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_039e", new Power {
				// TODO [ICC_039e] Convinced && Test: Convinced_ICC_039e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_049e] Toxic Arrow (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("ICC_049e", new Power {
				// TODO [ICC_049e] Toxic Arrow && Test: Toxic Arrow_ICC_049e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_056e] Frozen Blood (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("ICC_056e", new Power {
				// TODO [ICC_056e] Frozen Blood && Test: Frozen Blood_ICC_056e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_083e] Dooooooomed! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			cards.Add("ICC_083e", new Power {
				// TODO [ICC_083e] Dooooooomed! && Test: Dooooooomed!_ICC_083e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_092e] Veteran's Favor (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_092e", new Power {
				// TODO [ICC_092e] Veteran's Favor && Test: Veteran's Favor_ICC_092e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_093e] Fresh Fish! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("ICC_093e", new Power {
				// TODO [ICC_093e] Fresh Fish! && Test: Fresh Fish!_ICC_093e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_094e] Cleric's Blessing (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_094e", new Power {
				// TODO [ICC_094e] Cleric's Blessing && Test: Cleric's Blessing_ICC_094e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_096e] Me Bigger (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_096e", new Power {
				// TODO [ICC_096e] Me Bigger && Test: Me Bigger_ICC_096e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_097e] Armed and Dangerous (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_097e", new Power {
				// TODO [ICC_097e] Armed and Dangerous && Test: Armed and Dangerous_ICC_097e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_235e] Shadow Essence (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 5.
			// --------------------------------------------------------
			cards.Add("ICC_235e", new Power {
				// TODO [ICC_235e] Shadow Essence && Test: Shadow Essence_ICC_235e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_243e] Exhumed (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("ICC_243e", new Power {
				// TODO [ICC_243e] Exhumed && Test: Exhumed_ICC_243e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_257e] Ready to Return (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("ICC_257e", new Power {
				// TODO [ICC_257e] Ready to Return && Test: Ready to Return_ICC_257e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_314t1e] Trapped Soul (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: {0}
			// --------------------------------------------------------
			cards.Add("ICC_314t1e", new Power {
				// TODO [ICC_314t1e] Trapped Soul && Test: Trapped Soul_ICC_314t1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_314t7e] Anti-Magic Shell (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2 and "Can't be targeted by spells or Hero Powers."
			// --------------------------------------------------------
			// GameTag:
			// - CANT_BE_TARGETED_BY_SPELLS = 1
			// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t7e", new Power {
				// TODO [ICC_314t7e] Anti-Magic Shell && Test: Anti-Magic Shell_ICC_314t7e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_450e] Bloodthirsty (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_450e", new Power {
				// TODO [ICC_450e] Bloodthirsty && Test: Bloodthirsty_ICC_450e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_467e] Deathward (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_467e", new Power {
				// TODO [ICC_467e] Deathward && Test: Deathward_ICC_467e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_483e] Frostmourne Enchantment (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_483e", new Power {
				// TODO [ICC_483e] Frostmourne Enchantment && Test: Frostmourne Enchantment_ICC_483e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_705e] Bonemare's Boon (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_705e", new Power {
				// TODO [ICC_705e] Bonemare's Boon && Test: Bonemare's Boon_ICC_705e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_706e] Unravelled (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Costs (2) more.
			// --------------------------------------------------------
			cards.Add("ICC_706e", new Power {
				// TODO [ICC_706e] Unravelled && Test: Unravelled_ICC_706e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_807e] Strongshell (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_807e", new Power {
				// TODO [ICC_807e] Strongshell && Test: Strongshell_ICC_807e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_810e] Bloodthirsty (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2 from Deathaxe Punisher.
			// --------------------------------------------------------
			cards.Add("ICC_810e", new Power {
				// TODO [ICC_810e] Bloodthirsty && Test: Bloodthirsty_ICC_810e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_832e] Fangs (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("ICC_832e", new Power {
				// TODO [ICC_832e] Fangs && Test: Fangs_ICC_832e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_833e] Frost Lich (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Your Elementals have <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("ICC_833e", new Power {
				// TODO [ICC_833e] Frost Lich && Test: Frost Lich_ICC_833e
				InfoCardId = "ICC_833e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_833e2] Icy Veins (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Frost Lich Jaina is granting your Elementals <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_833e2", new Power {
				// TODO [ICC_833e2] Icy Veins && Test: Icy Veins_ICC_833e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_837e] Challenged (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Minion cost reduced by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837e", new Power {
				// TODO [ICC_837e] Challenged && Test: Challenged_ICC_837e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_841e] Vampiric Bite (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_841e", new Power {
				// TODO [ICC_841e] Vampiric Bite && Test: Vampiric Bite_ICC_841e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_849e] Embraced (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of the next turn, lose control of this minion.
			// --------------------------------------------------------
			cards.Add("ICC_849e", new Power {
				// TODO [ICC_849e] Embraced && Test: Embraced_ICC_849e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_851e] Keleseth's Blessing (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_851e", new Power {
				// TODO [ICC_851e] Keleseth's Blessing && Test: Keleseth's Blessing_ICC_851e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_852e] Taldaram's Visage (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_852e", new Power {
				// TODO [ICC_852e] Taldaram's Visage && Test: Taldaram's Visage_ICC_852e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_901e] Frost Magics (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Your end of turn effects trigger twice.
			// --------------------------------------------------------
			cards.Add("ICC_901e", new Power {
				// TODO [ICC_901e] Frost Magics && Test: Frost Magics_ICC_901e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_903t] Bloodthirst (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_903t", new Power {
				// TODO [ICC_903t] Bloodthirst && Test: Bloodthirst_ICC_903t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_904e] Extra Calcium (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_904e", new Power {
				// TODO [ICC_904e] Extra Calcium && Test: Extra Calcium_ICC_904e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019t] Skeletal Flayer (*) - COST:8 [ATK:8/HP:8] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_019t", new Power {
				// TODO [ICC_019t] Skeletal Flayer && Test: Skeletal Flayer_ICC_019t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_025t] Skeletal Enforcer (*) - COST:5 [ATK:5/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_025t", new Power {
				// TODO [ICC_025t] Skeletal Enforcer && Test: Skeletal Enforcer_ICC_025t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_026t] Skeleton (*) - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_026t", new Power {
				// TODO [ICC_026t] Skeleton && Test: Skeleton_ICC_026t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_800h3t] Zombeast (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_800h3t", new Power {
				// TODO [ICC_800h3t] Zombeast && Test: Zombeast_ICC_800h3t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900t] Ghoul (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_900t", new Power {
				// TODO [ICC_900t] Ghoul && Test: Ghoul_ICC_900t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DeathknightNonCollect(cards);
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
			Warlock(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
