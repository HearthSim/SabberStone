using System.Collections.Generic;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.CardSets.Undefined
{
	public class GangsCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [CFM_308] Kun the Forgotten King - COST:10 [ATK:7/HP:7] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Gain 10 Armor; or Refresh your Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("CFM_308", new Power {
				// TODO [CFM_308] Kun the Forgotten King && Test: Kun the Forgotten King_CFM_308
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_343] Jade Behemoth - COST:6 [ATK:3/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Summon a{1}
			//       {0} <b>Jade Golem</b>.@[x]<b>Taunt</b>
			//       <b>Battlecry:</b> Summon a
			//       <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_343", new Power {
				// TODO [CFM_343] Jade Behemoth && Test: Jade Behemoth_CFM_343
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_617] Celestial Dreamer - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control a
			//       minion with 5 or more
			//       Attack, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_617", new Power {
				// TODO [CFM_617] Celestial Dreamer && Test: Celestial Dreamer_CFM_617
				InfoCardId = "CFM_617e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_816] Virmen Sensei - COST:5 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// --------------------------------------------------------
			cards.Add("CFM_816", new Power {
				// TODO [CFM_816] Virmen Sensei && Test: Virmen Sensei_CFM_816
				InfoCardId = "CFM_816e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602] Jade Idol - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Summon a{1} {0} <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.@<b>Choose One -</b> Summon a <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_602", new Power {
				// TODO [CFM_602] Jade Idol && Test: Jade Idol_CFM_602
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_614] Mark of the Lotus - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_614", new Power {
				// TODO [CFM_614] Mark of the Lotus && Test: Mark of the Lotus_CFM_614
				InfoCardId = "CFM_614e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_616] Pilfered Power - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain an empty Mana Crystal for each friendly minion.
			// --------------------------------------------------------
			cards.Add("CFM_616", new Power {
				// TODO [CFM_616] Pilfered Power && Test: Pilfered Power_CFM_616
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_713] Jade Blossom - COST:3 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.@Summon a <b>Jade Golem</b>. Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_713", new Power {
				// TODO [CFM_713] Jade Blossom && Test: Jade Blossom_CFM_713
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_811] Lunar Visions - COST:5 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw 2 cards. Minions drawn cost (2) less.
			// --------------------------------------------------------
			cards.Add("CFM_811", new Power {
				// TODO [CFM_811] Lunar Visions && Test: Lunar Visions_CFM_811
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [CFM_308a] Forgotten Armor (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			cards.Add("CFM_308a", new Power {
				// TODO [CFM_308a] Forgotten Armor && Test: Forgotten Armor_CFM_308a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_308b] Forgotten Mana (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Refresh your Mana Crystals.
			// --------------------------------------------------------
			cards.Add("CFM_308b", new Power {
				// TODO [CFM_308b] Forgotten Mana && Test: Forgotten Mana_CFM_308b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602a] Jade Idol (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a{1} {0} <b>Jade Golem</b>.
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_602a", new Power {
				// TODO [CFM_602a] Jade Idol && Test: Jade Idol_CFM_602a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602b] Jade Idol (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Shuffle 3 Jade Idols into your deck.
			// --------------------------------------------------------
			cards.Add("CFM_602b", new Power {
				// TODO [CFM_602b] Jade Idol && Test: Jade Idol_CFM_602b
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [CFM_315] Alleycat - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Cat.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_315", new Power {
				// TODO [CFM_315] Alleycat && Test: Alleycat_CFM_315
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_316] Rat Pack - COST:3 [ATK:2/HP:2] 
			// - Race: beast, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Summon a
			//       number of 1/1 Rats equal
			//       _to this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_316", new Power {
				// TODO [CFM_316] Rat Pack && Test: Rat Pack_CFM_316
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_333] Knuckles - COST:5 [ATK:3/HP:7] 
			// - Race: beast, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: After this attacks a
			//       minion, it also hits the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_333", new Power {
				// TODO [CFM_333] Knuckles && Test: Knuckles_CFM_333
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_335] Dispatch Kodo - COST:4 [ATK:2/HP:4] 
			// - Race: beast, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_335", new Power {
				// TODO [CFM_335] Dispatch Kodo && Test: Dispatch Kodo_CFM_335
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_336] Shaky Zipgunner - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Give a random
			//       minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_336", new Power {
				// TODO [CFM_336] Shaky Zipgunner && Test: Shaky Zipgunner_CFM_336
				InfoCardId = "CFM_336e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_338] Trogg Beastrager - COST:2 [ATK:3/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random Beast in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_338", new Power {
				// TODO [CFM_338] Trogg Beastrager && Test: Trogg Beastrager_CFM_338
				InfoCardId = "CFM_338e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CFM_026] Hidden Cache - COST:2 
			// - Fac: neutral, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_026", new Power {
				// TODO [CFM_026] Hidden Cache && Test: Hidden Cache_CFM_026
				InfoCardId = "CFM_026e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CFM_334] Smuggler's Crate - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give a random Beast in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_334", new Power {
				// TODO [CFM_334] Smuggler's Crate && Test: Smuggler's Crate_CFM_334
				InfoCardId = "CFM_334e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [CFM_337] Piranha Launcher - COST:5 [ATK:2/HP:0] 
			// - Fac: neutral, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After your hero attacks,
			//       summon a 1/1 Piranha.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 4
			// --------------------------------------------------------
			cards.Add("CFM_337", new Power {
				// TODO [CFM_337] Piranha Launcher && Test: Piranha Launcher_CFM_337
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_026e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Hidden Cache.
			// --------------------------------------------------------
			cards.Add("CFM_026e", new Power {
				// TODO [CFM_026e] Smuggling && Test: Smuggling_CFM_026e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_338e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Trogg Beastrager.
			// --------------------------------------------------------
			cards.Add("CFM_338e", new Power {
				// TODO [CFM_338e] Smuggling && Test: Smuggling_CFM_338e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_315t] Tabbycat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_315t", new Power {
				// TODO [CFM_315t] Tabbycat && Test: Tabbycat_CFM_315t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_316t] Rat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_316t", new Power {
				// TODO [CFM_316t] Rat && Test: Rat_CFM_316t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_337t] Piranha (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_337t", new Power {
				// TODO [CFM_337t] Piranha && Test: Piranha_CFM_337t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [CFM_066] Kabal Lackey - COST:1 [ATK:2/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> The next <b>Secret</b>
			//       you play this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_066", new Power {
				// TODO [CFM_066] Kabal Lackey && Test: Kabal Lackey_CFM_066
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_660] Manic Soulcaster - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_660", new Power {
				// TODO [CFM_660] Manic Soulcaster && Test: Manic Soulcaster_CFM_660
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_671] Cryomancer - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_671", new Power {
				// TODO [CFM_671] Cryomancer && Test: Cryomancer_CFM_671
				InfoCardId = "CFM_671e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_687] Inkmaster Solia - COST:7 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck has
			//       no duplicates, the next
			//       spell you cast this turn
			//       costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_687", new Power {
				// TODO [CFM_687] Inkmaster Solia && Test: Inkmaster Solia_CFM_687
				InfoCardId = "CFM_687e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_760] Kabal Crystal Runner - COST:6 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Costs (2) less for each <b>Secret</b> you've played this_game.
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_760", new Power {
				// TODO [CFM_760] Kabal Crystal Runner && Test: Kabal Crystal Runner_CFM_760
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_021] Freezing Potion - COST:0 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> an enemy.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_021", new Power {
				// TODO [CFM_021] Freezing Potion && Test: Freezing Potion_CFM_021
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_065] Volcanic Potion - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all_minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_065", new Power {
				// TODO [CFM_065] Volcanic Potion && Test: Volcanic Potion_CFM_065
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_620] Potion of Polymorph - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, transform it into a
			//       1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_620", new Power {
				// TODO [CFM_620] Potion of Polymorph && Test: Potion of Polymorph_CFM_620
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_623] Greater Arcane Missiles - COST:7 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Shoot three missiles at random enemies that deal $3 damage each. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_623", new Power {
				// TODO [CFM_623] Greater Arcane Missiles && Test: Greater Arcane Missiles_CFM_623
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [CFM_687e] Free Spell (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_687e", new Power {
				// TODO [CFM_687e] Free Spell && Test: Free Spell_CFM_687e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [CFM_062] Grimestreet Protector - COST:7 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Give adjacent
			//       _minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("CFM_062", new Power {
				// TODO [CFM_062] Grimestreet Protector && Test: Grimestreet Protector_CFM_062
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_639] Grimestreet Enforcer - COST:5 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_639", new Power {
				// TODO [CFM_639] Grimestreet Enforcer && Test: Grimestreet Enforcer_CFM_639
				InfoCardId = "CFM_639e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_650] Grimscale Chum - COST:1 [ATK:2/HP:1] 
			// - Race: murloc, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Give a random
			//       Murloc in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_650", new Power {
				// TODO [CFM_650] Grimscale Chum && Test: Grimscale Chum_CFM_650
				InfoCardId = "CFM_650e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_753] Grimestreet Outfitter - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_753", new Power {
				// TODO [CFM_753] Grimestreet Outfitter && Test: Grimestreet Outfitter_CFM_753
				InfoCardId = "CFM_753e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_759] Meanstreet Marshal - COST:1 [ATK:1/HP:2] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If this minion has 2 or more Attack, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_759", new Power {
				// TODO [CFM_759] Meanstreet Marshal && Test: Meanstreet Marshal_CFM_759
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_815] Wickerflame Burnbristle - COST:3 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Divine Shield, Taunt, Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_815", new Power {
				// TODO [CFM_815] Wickerflame Burnbristle && Test: Wickerflame Burnbristle_CFM_815
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_305] Smuggler's Run - COST:1 
			// - Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_305", new Power {
				// TODO [CFM_305] Smuggler's Run && Test: Smuggler's Run_CFM_305
				InfoCardId = "CFM_305e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_800] Getaway Kodo - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_800", new Power {
				// TODO [CFM_800] Getaway Kodo && Test: Getaway Kodo_CFM_800
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_905] Small-Time Recruits - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Draw three 1-Cost
			//       minions from your deck.
			// --------------------------------------------------------
			cards.Add("CFM_905", new Power {
				// TODO [CFM_905] Small-Time Recruits && Test: Small-Time Recruits_CFM_905
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CFM_305e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Smuggler's Run.
			// --------------------------------------------------------
			cards.Add("CFM_305e", new Power {
				// TODO [CFM_305e] Smuggling && Test: Smuggling_CFM_305e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [CFM_020] Raza the Chained - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]  <b>Battlecry:</b> If your deck has  
			//       no duplicates, your Hero
			//        Power costs (1) this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_020", new Power {
				// TODO [CFM_020] Raza the Chained && Test: Raza the Chained_CFM_020
				InfoCardId = "CFM_020e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_605] Drakonid Operative - COST:5 [ATK:5/HP:6] 
			// - Race: dragon, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you're holding a
			//       Dragon, <b>Discover</b> a card in
			//       _your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_605", new Power {
				// TODO [CFM_605] Drakonid Operative && Test: Drakonid Operative_CFM_605
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_606] Mana Geode - COST:2 [ATK:2/HP:3] 
			// - Race: elemental, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this minion is_healed, summon a 2/2_Crystal.
			// --------------------------------------------------------
			cards.Add("CFM_606", new Power {
				// TODO [CFM_606] Mana Geode && Test: Mana Geode_CFM_606
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_626] Kabal Talonpriest - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +3 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_626", new Power {
				// TODO [CFM_626] Kabal Talonpriest && Test: Kabal Talonpriest_CFM_626
				InfoCardId = "CFM_626e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_657] Kabal Songstealer - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_657", new Power {
				// TODO [CFM_657] Kabal Songstealer && Test: Kabal Songstealer_CFM_657
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_603] Potion of Madness - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 2 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 2
			// --------------------------------------------------------
			cards.Add("CFM_603", new Power {
				// TODO [CFM_603] Potion of Madness && Test: Potion of Madness_CFM_603
				InfoCardId = "CFM_603e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_604] Greater Healing Potion - COST:4 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore #12 Health to a friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_604", new Power {
				// TODO [CFM_604] Greater Healing Potion && Test: Greater Healing Potion_CFM_604
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_661] Pint-Size Potion - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give all enemy minions
			//       -3 Attack this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_661", new Power {
				// TODO [CFM_661] Pint-Size Potion && Test: Pint-Size Potion_CFM_661
				InfoCardId = "CFM_661e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_662] Dragonfire Potion - COST:6 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage to all
			//       minions except Dragons. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_662", new Power {
				// TODO [CFM_662] Dragonfire Potion && Test: Dragonfire Potion_CFM_662
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_603e] Madness Potion (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: This minion has switched controllers this turn.
			// --------------------------------------------------------
			cards.Add("CFM_603e", new Power {
				// TODO [CFM_603e] Madness Potion && Test: Madness Potion_CFM_603e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_661e] Shrunk (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: -3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_661e", new Power {
				// TODO [CFM_661e] Shrunk && Test: Shrunk_CFM_661e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_606t] Crystal (*) - COST:2 [ATK:2/HP:2] 
			// - Race: elemental, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_606t", new Power {
				// TODO [CFM_606t] Crystal && Test: Crystal_CFM_606t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [CFM_342] Luckydo Buccaneer - COST:6 [ATK:5/HP:5] 
			// - Race: pirate, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_342", new Power {
				// TODO [CFM_342] Luckydo Buccaneer && Test: Luckydo Buccaneer_CFM_342
				InfoCardId = "CFM_342e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_634] Lotus Assassin - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. Whenever this attacks and kills a minion, gain <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_634", new Power {
				// TODO [CFM_634] Lotus Assassin && Test: Lotus Assassin_CFM_634
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_636] Shadow Rager - COST:3 [ATK:5/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_636", new Power {
				// TODO [CFM_636] Shadow Rager && Test: Shadow Rager_CFM_636
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_691] Jade Swarmer - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>.@<b>Stealth</b>
			//       <b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_691", new Power {
				// TODO [CFM_691] Jade Swarmer && Test: Jade Swarmer_CFM_691
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_693] Gadgetzan Ferryman - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Return a friendly minion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_FOR_COMBO = 0
			// --------------------------------------------------------
			cards.Add("CFM_693", new Power {
				// TODO [CFM_693] Gadgetzan Ferryman && Test: Gadgetzan Ferryman_CFM_693
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_694] Shadow Sensei - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a <b>Stealthed</b> minion +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_STEALTHED_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_694", new Power {
				// TODO [CFM_694] Shadow Sensei && Test: Shadow Sensei_CFM_694
				InfoCardId = "CFM_694e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [CFM_781] Shaku, the Collector - COST:3 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>. Whenever this
			//       attacks, add a random card
			//       to your hand <i>(from your
			//       opponent's class).</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_781", new Power {
				// TODO [CFM_781] Shaku, the Collector && Test: Shaku, the Collector_CFM_781
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CFM_630] Counterfeit Coin - COST:0 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_630", new Power {
				// TODO [CFM_630] Counterfeit Coin && Test: Counterfeit Coin_CFM_630
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CFM_690] Jade Shuriken - COST:2 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       <b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.@Deal $2 damage.
			//       <b>Combo:</b> Summon a <b>Jade Golem</b>. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("CFM_690", new Power {
				// TODO [CFM_690] Jade Shuriken && Test: Jade Shuriken_CFM_690
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_342e] Looted Blade (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("CFM_342e", new Power {
				// TODO [CFM_342e] Looted Blade && Test: Looted Blade_CFM_342e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_694e] Trained (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_694e", new Power {
				// TODO [CFM_694e] Trained && Test: Trained_CFM_694e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CFM_061] Jinyu Waterspeaker - COST:4 [ATK:3/HP:6] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Restore 6 Health.
			//       <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_061", new Power {
				// TODO [CFM_061] Jinyu Waterspeaker && Test: Jinyu Waterspeaker_CFM_061
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_312] Jade Chieftain - COST:7 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. Give it <b>Taunt</b>. @<b>Battlecry:</b> Summon a <b>Jade Golem</b>. Give it <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_312", new Power {
				// TODO [CFM_312] Jade Chieftain && Test: Jade Chieftain_CFM_312
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_324] White Eyes - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Shuffle
			//       'The Storm Guardian' into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_324", new Power {
				// TODO [CFM_324] White Eyes && Test: White Eyes_CFM_324
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_697] Lotus Illusionist - COST:4 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After this minion attacks
			//       a hero, transform it into a
			//       _random 6-Cost minion.
			// --------------------------------------------------------
			cards.Add("CFM_697", new Power {
				// TODO [CFM_697] Lotus Illusionist && Test: Lotus Illusionist_CFM_697
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_310] Call in the Finishers - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon four 1/1 Murlocs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CFM_310", new Power {
				// TODO [CFM_310] Call in the Finishers && Test: Call in the Finishers_CFM_310
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_313] Finders Keepers - COST:1 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card with_<b>Overload</b>. <b>Overload:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_313", new Power {
				// TODO [CFM_313] Finders Keepers && Test: Finders Keepers_CFM_313
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_696] Devolve - COST:2 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Transform all enemy minions into random ones that cost (1) less.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_HERO_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_696", new Power {
				// TODO [CFM_696] Devolve && Test: Devolve_CFM_696
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_707] Jade Lightning - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_707", new Power {
				// TODO [CFM_707] Jade Lightning && Test: Jade Lightning_CFM_707
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [CFM_717] Jade Claws - COST:2 [ATK:2/HP:0] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.
			//       <b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.
			//       <b><b>Overload</b>:</b> (1)
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - OVERLOAD = 1
			// - BATTLECRY = 1
			// - OVERLOAD_OWED = 1
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_717", new Power {
				// TODO [CFM_717] Jade Claws && Test: Jade Claws_CFM_717
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CFM_310t] Murloc Razorgill (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_310t", new Power {
				// TODO [CFM_310t] Murloc Razorgill && Test: Murloc Razorgill_CFM_310t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_324t] The Storm Guardian (*) - COST:5 [ATK:10/HP:10] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_324t", new Power {
				// TODO [CFM_324t] The Storm Guardian && Test: The Storm Guardian_CFM_324t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [CFM_610] Crystalweaver - COST:4 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your Demons +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_610", new Power {
				// TODO [CFM_610] Crystalweaver && Test: Crystalweaver_CFM_610
				InfoCardId = "CFM_610e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_663] Kabal Trafficker - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       add a random Demon
			//       to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_663", new Power {
				// TODO [CFM_663] Kabal Trafficker && Test: Kabal Trafficker_CFM_663
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_699] Seadevil Stinger - COST:4 [ATK:4/HP:2] 
			// - Race: murloc, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> The next Murloc
			//       you play this turn costs
			//       _Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_699", new Power {
				// TODO [CFM_699] Seadevil Stinger && Test: Seadevil Stinger_CFM_699
				InfoCardId = "CFM_699e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_750] Krul the Unshackled - COST:9 [ATK:7/HP:9] 
			// - Race: demon, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck has
			//       no duplicates, summon all
			//       _Demons from your hand._
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_750", new Power {
				// TODO [CFM_750] Krul the Unshackled && Test: Krul the Unshackled_CFM_750
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_751] Abyssal Enforcer - COST:7 [ATK:6/HP:6] 
			// - Race: demon, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage to all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_751", new Power {
				// TODO [CFM_751] Abyssal Enforcer && Test: Abyssal Enforcer_CFM_751
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_900] Unlicensed Apothecary - COST:3 [ATK:5/HP:5] 
			// - Race: demon, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: After you summon a minion, deal 5 damage to_your hero.
			// --------------------------------------------------------
			cards.Add("CFM_900", new Power {
				// TODO [CFM_900] Unlicensed Apothecary && Test: Unlicensed Apothecary_CFM_900
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_094] Felfire Potion - COST:6 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_094", new Power {
				// TODO [CFM_094] Felfire Potion && Test: Felfire Potion_CFM_094
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_608] Blastcrystal Potion - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion and one of your Mana Crystals.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_608", new Power {
				// TODO [CFM_608] Blastcrystal Potion && Test: Blastcrystal Potion_CFM_608
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_611] Bloodfury Potion - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give a minion +3 Attack.
			//       If it's a Demon, also
			//       give it +3 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_611", new Power {
				// TODO [CFM_611] Bloodfury Potion && Test: Bloodfury Potion_CFM_611
				InfoCardId = "CFM_611e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [CFM_300] Public Defender - COST:2 [ATK:0/HP:7] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_300", new Power {
				// TODO [CFM_300] Public Defender && Test: Public Defender_CFM_300
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_643] Hobart Grapplehammer - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all weapons in your hand and deck +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_643", new Power {
				// TODO [CFM_643] Hobart Grapplehammer && Test: Hobart Grapplehammer_CFM_643
				InfoCardId = "CFM_643e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_754] Grimy Gadgeteer - COST:4 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_754", new Power {
				// TODO [CFM_754] Grimy Gadgeteer && Test: Grimy Gadgeteer_CFM_754
				InfoCardId = "CFM_754e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_755] Grimestreet Pawnbroker - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random weapon in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_755", new Power {
				// TODO [CFM_755] Grimestreet Pawnbroker && Test: Grimestreet Pawnbroker_CFM_755
				InfoCardId = "CFM_755e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_756] Alley Armorsmith - COST:5 [ATK:2/HP:7] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Whenever this minion
			//       deals damage, gain
			//       that much Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_756", new Power {
				// TODO [CFM_756] Alley Armorsmith && Test: Alley Armorsmith_CFM_756
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_716] Sleep with the Fishes - COST:2 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $3 damage to all damaged minions. @spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_716", new Power {
				// TODO [CFM_716] Sleep with the Fishes && Test: Sleep with the Fishes_CFM_716
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_752] Stolen Goods - COST:2 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a random <b>Taunt</b> minion in your hand +3/+3.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_752", new Power {
				// TODO [CFM_752] Stolen Goods && Test: Stolen Goods_CFM_752
				InfoCardId = "CFM_752e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_940] I Know a Guy - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Taunt</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_940", new Power {
				// TODO [CFM_940] I Know a Guy && Test: I Know a Guy_CFM_940
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [CFM_631] Brass Knuckles - COST:4 [ATK:2/HP:0] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After your hero attacks,
			//       give a random minion in
			//       your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("CFM_631", new Power {
				// TODO [CFM_631] Brass Knuckles && Test: Brass Knuckles_CFM_631
				InfoCardId = "CFM_631e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CFM_643e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack from Hobart Grapplehammer.
			// --------------------------------------------------------
			cards.Add("CFM_643e", new Power {
				// TODO [CFM_643e] Smuggling && Test: Smuggling_CFM_643e
				InfoCardId = "CFM_643e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CFM_643e2] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack from Hobart Grapplehammer.
			// --------------------------------------------------------
			cards.Add("CFM_643e2", new Power {
				// TODO [CFM_643e2] Smuggling && Test: Smuggling_CFM_643e2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CFM_025] Wind-up Burglebot - COST:6 [ATK:5/HP:5] 
			// - Race: mechanical, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this attacks a minion and survives, draw_a card.
			// --------------------------------------------------------
			cards.Add("CFM_025", new Power {
				// TODO [CFM_025] Wind-up Burglebot && Test: Wind-up Burglebot_CFM_025
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_039] Street Trickster - COST:3 [ATK:0/HP:7] 
			// - Race: demon, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_039", new Power {
				// TODO [CFM_039] Street Trickster && Test: Street Trickster_CFM_039
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_060] Red Mana Wyrm - COST:5 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever  you cast a spell, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_060", new Power {
				// TODO [CFM_060] Red Mana Wyrm && Test: Red Mana Wyrm_CFM_060
				InfoCardId = "CFM_060e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_063] Kooky Chemist - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_063", new Power {
				// TODO [CFM_063] Kooky Chemist && Test: Kooky Chemist_CFM_063
				InfoCardId = "CFM_063e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_064] Blubber Baron - COST:3 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you summon a <b>Battlecry</b> minion while this_is in your hand, gain_+1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_064", new Power {
				// TODO [CFM_064] Blubber Baron && Test: Blubber Baron_CFM_064
				InfoCardId = "CFM_064e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_067] Hozen Healer - COST:4 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry</b>: Restore a minion to full Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_067", new Power {
				// TODO [CFM_067] Hozen Healer && Test: Hozen Healer_CFM_067
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_095] Weasel Tunneler - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - 542 = 1
			// --------------------------------------------------------
			cards.Add("CFM_095", new Power {
				// TODO [CFM_095] Weasel Tunneler && Test: Weasel Tunneler_CFM_095
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_120] Mistress of Mixtures - COST:1 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_120", new Power {
				// TODO [CFM_120] Mistress of Mixtures && Test: Mistress of Mixtures_CFM_120
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_321] Grimestreet Informant - COST:2 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
			//       Hunter, Paladin, or Warrior
			//       card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_321", new Power {
				// TODO [CFM_321] Grimestreet Informant && Test: Grimestreet Informant_CFM_321
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_325] Small-Time Buccaneer - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a weapon equipped.
			// --------------------------------------------------------
			cards.Add("CFM_325", new Power {
				// TODO [CFM_325] Small-Time Buccaneer && Test: Small-Time Buccaneer_CFM_325
				InfoCardId = "CFM_325e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_328] Fight Promoter - COST:6 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If you control
			//       a minion with 6 or more
			//       _Health, draw two cards.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_328", new Power {
				// TODO [CFM_328] Fight Promoter && Test: Fight Promoter_CFM_328
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_341] Sergeant Sally - COST:3 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_341", new Power {
				// TODO [CFM_341] Sergeant Sally && Test: Sergeant Sally_CFM_341
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_344] Finja, the Flying Star - COST:5 [ATK:2/HP:4] 
			// - Race: murloc, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Stealth</b>
			//          Whenever this attacks and   
			//       kills a minion, summon 2
			//       _Murlocs from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_344", new Power {
				// TODO [CFM_344] Finja, the Flying Star && Test: Finja, the Flying Star_CFM_344
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_609] Fel Orc Soulfiend - COST:3 [ATK:3/HP:7] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to this_minion.
			// --------------------------------------------------------
			cards.Add("CFM_609", new Power {
				// TODO [CFM_609] Fel Orc Soulfiend && Test: Fel Orc Soulfiend_CFM_609
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_619] Kabal Chemist - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Potion to your hand.
			// --------------------------------------------------------
			// Entourage: CFM_065, CFM_021, CFM_603, CFM_604, CFM_611, CFM_620, CFM_094, CFM_661, CFM_662, CFM_608
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_619", new Power {
				// TODO [CFM_619] Kabal Chemist && Test: Kabal Chemist_CFM_619
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621] Kazakus - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your deck
			//       has no duplicates,
			//       _create a custom spell.
			// --------------------------------------------------------
			// Entourage: CFM_621t11, CFM_621t12, CFM_621t13
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_621", new Power {
				// TODO [CFM_621] Kazakus && Test: Kazakus_CFM_621
				InfoCardId = "CFM_621e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_637] Patches the Pirate - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]After you play a Pirate,
			//       summon this minion
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_637", new Power {
				// TODO [CFM_637] Patches the Pirate && Test: Patches the Pirate_CFM_637
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_646] Backstreet Leper - COST:3 [ATK:3/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Deal 2 damage
			//       to the enemy hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_646", new Power {
				// TODO [CFM_646] Backstreet Leper && Test: Backstreet Leper_CFM_646
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_647] Blowgill Sniper - COST:2 [ATK:2/HP:1] 
			// - Race: murloc, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_647", new Power {
				// TODO [CFM_647] Blowgill Sniper && Test: Blowgill Sniper_CFM_647
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_648] Big-Time Racketeer - COST:6 [ATK:1/HP:1] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 6/6_Ogre.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_648", new Power {
				// TODO [CFM_648] Big-Time Racketeer && Test: Big-Time Racketeer_CFM_648
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_649] Kabal Courier - COST:3 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_649", new Power {
				// TODO [CFM_649] Kabal Courier && Test: Kabal Courier_CFM_649
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_651] Naga Corsair - COST:4 [ATK:5/HP:4] 
			// - Race: pirate, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_651", new Power {
				// TODO [CFM_651] Naga Corsair && Test: Naga Corsair_CFM_651
				InfoCardId = "CFM_651e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_652] Second-Rate Bruiser - COST:5 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       Costs (2) less if your
			//       opponent has at least
			//       three minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_652", new Power {
				// TODO [CFM_652] Second-Rate Bruiser && Test: Second-Rate Bruiser_CFM_652
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_653] Hired Gun - COST:3 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_653", new Power {
				// TODO [CFM_653] Hired Gun && Test: Hired Gun_CFM_653
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_654] Friendly Bartender - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 1 Health to your_hero.
			// --------------------------------------------------------
			cards.Add("CFM_654", new Power {
				// TODO [CFM_654] Friendly Bartender && Test: Friendly Bartender_CFM_654
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_655] Toxic Sewer Ooze - COST:3 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_655", new Power {
				// TODO [CFM_655] Toxic Sewer Ooze && Test: Toxic Sewer Ooze_CFM_655
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_656] Streetwise Investigator - COST:5 [ATK:4/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_656", new Power {
				// TODO [CFM_656] Streetwise Investigator && Test: Streetwise Investigator_CFM_656
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_658] Backroom Bouncer - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_658", new Power {
				// TODO [CFM_658] Backroom Bouncer && Test: Backroom Bouncer_CFM_658
				InfoCardId = "CFM_658e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_659] Gadgetzan Socialite - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_659", new Power {
				// TODO [CFM_659] Gadgetzan Socialite && Test: Gadgetzan Socialite_CFM_659
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_665] Worgen Greaser - COST:4 [ATK:6/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			cards.Add("CFM_665", new Power {
				// TODO [CFM_665] Worgen Greaser && Test: Worgen Greaser_CFM_665
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_666] Grook Fu Master - COST:5 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CFM_666", new Power {
				// TODO [CFM_666] Grook Fu Master && Test: Grook Fu Master_CFM_666
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_667] Bomb Squad - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Deal 5 damage
			//       to an enemy minion.
			//       <b>Deathrattle:</b> Deal 5 damage
			//       to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_667", new Power {
				// TODO [CFM_667] Bomb Squad && Test: Bomb Squad_CFM_667
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668] Doppelgangster - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668", new Power {
				// TODO [CFM_668] Doppelgangster && Test: Doppelgangster_CFM_668
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_669] Burgly Bully - COST:5 [ATK:4/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, add a Coin to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_669", new Power {
				// TODO [CFM_669] Burgly Bully && Test: Burgly Bully_CFM_669
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_670] Mayor Noggenfogger - COST:9 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: All targets are chosen randomly.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_670", new Power {
				// TODO [CFM_670] Mayor Noggenfogger && Test: Mayor Noggenfogger_CFM_670
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_672] Madam Goya - COST:6 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_672", new Power {
				// TODO [CFM_672] Madam Goya && Test: Madam Goya_CFM_672
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_685] Don Han'Cho - COST:7 [ATK:5/HP:6] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random minion in your hand +5/+5.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_685", new Power {
				// TODO [CFM_685] Don Han'Cho && Test: Don Han'Cho_CFM_685
				InfoCardId = "CFM_685e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_688] Spiked Hogrider - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain_<b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_688", new Power {
				// TODO [CFM_688] Spiked Hogrider && Test: Spiked Hogrider_CFM_688
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_715] Jade Spirit - COST:4 [ATK:2/HP:3] 
			// - Race: elemental, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.@<b>Battlecry:</b> Summon a <b>Jade_Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - JADE_GOLEM = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			cards.Add("CFM_715", new Power {
				// TODO [CFM_715] Jade Spirit && Test: Jade Spirit_CFM_715
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_790] Dirty Rat - COST:2 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//       <b>Battlecry:</b> Your opponent
			//       summons a random minion
			//       from their hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_790", new Power {
				// TODO [CFM_790] Dirty Rat && Test: Dirty Rat_CFM_790
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_806] Wrathion - COST:6 [ATK:4/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_806", new Power {
				// TODO [CFM_806] Wrathion && Test: Wrathion_CFM_806
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_807] Auctionmaster Beardo - COST:3 [ATK:3/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast a spell, refresh your Hero Power.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_807", new Power {
				// TODO [CFM_807] Auctionmaster Beardo && Test: Auctionmaster Beardo_CFM_807
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_808] Genzo, the Shark - COST:4 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: Whenever this attacks, both players draw until they have 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("CFM_808", new Power {
				// TODO [CFM_808] Genzo, the Shark && Test: Genzo, the Shark_CFM_808
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_809] Tanaris Hogchopper - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> If your opponent's
			//       hand is empty, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_809", new Power {
				// TODO [CFM_809] Tanaris Hogchopper && Test: Tanaris Hogchopper_CFM_809
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_810] Leatherclad Hogleader - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_810", new Power {
				// TODO [CFM_810] Leatherclad Hogleader && Test: Leatherclad Hogleader_CFM_810
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_851] Daring Reporter - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent draws a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_851", new Power {
				// TODO [CFM_851] Daring Reporter && Test: Daring Reporter_CFM_851
				InfoCardId = "CFM_851e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_852] Lotus Agents - COST:5 [ATK:5/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("CFM_852", new Power {
				// TODO [CFM_852] Lotus Agents && Test: Lotus Agents_CFM_852
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_853] Grimestreet Smuggler - COST:3 [ATK:2/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a random minion in your hand +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 532
			// - MULTI_CLASS_GROUP = 1
			// - GRIMY_GOONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_853", new Power {
				// TODO [CFM_853] Grimestreet Smuggler && Test: Grimestreet Smuggler_CFM_853
				InfoCardId = "CFM_853e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_854] Ancient of Blossoms - COST:6 [ATK:3/HP:8] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_854", new Power {
				// TODO [CFM_854] Ancient of Blossoms && Test: Ancient of Blossoms_CFM_854
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_855] Defias Cleaner - COST:6 [ATK:5/HP:7] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_855", new Power {
				// TODO [CFM_855] Defias Cleaner && Test: Defias Cleaner_CFM_855
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_902] Aya Blackpaw - COST:6 [ATK:5/HP:3] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>. @ <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// - JADE_GOLEM = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			cards.Add("CFM_902", new Power {
				// TODO [CFM_902] Aya Blackpaw && Test: Aya Blackpaw_CFM_902
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_020e] Raza Enchant (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (1).
			// --------------------------------------------------------
			cards.Add("CFM_020e", new Power {
				// TODO [CFM_020e] Raza Enchant && Test: Raza Enchant_CFM_020e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_060e] Mana Heist (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("CFM_060e", new Power {
				// TODO [CFM_060e] Mana Heist && Test: Mana Heist_CFM_060e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_063e] Kooky Chemistry (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Kooky Chemist.
			// --------------------------------------------------------
			cards.Add("CFM_063e", new Power {
				// TODO [CFM_063e] Kooky Chemistry && Test: Kooky Chemistry_CFM_063e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_064e] Size Increase (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("CFM_064e", new Power {
				// TODO [CFM_064e] Size Increase && Test: Size Increase_CFM_064e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_325e] Equipped (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_325e", new Power {
				// TODO [CFM_325e] Equipped && Test: Equipped_CFM_325e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_334e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Smuggler's Crate.
			// --------------------------------------------------------
			cards.Add("CFM_334e", new Power {
				// TODO [CFM_334e] Smuggling && Test: Smuggling_CFM_334e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_336e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Shaky Zipgunner.
			// --------------------------------------------------------
			cards.Add("CFM_336e", new Power {
				// TODO [CFM_336e] Smuggling && Test: Smuggling_CFM_336e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_610e] Serrated Shadows (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_610e", new Power {
				// TODO [CFM_610e] Serrated Shadows && Test: Serrated Shadows_CFM_610e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_611e] Demonic Draught (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_611e", new Power {
				// TODO [CFM_611e] Demonic Draught && Test: Demonic Draught_CFM_611e
				InfoCardId = "CFM_611e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_611e2] Demonic Draught (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("CFM_611e2", new Power {
				// TODO [CFM_611e2] Demonic Draught && Test: Demonic Draught_CFM_611e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_614e] Savage Mark (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_614e", new Power {
				// TODO [CFM_614e] Savage Mark && Test: Savage Mark_CFM_614e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_617e] Visions of Hypnos (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_617e", new Power {
				// TODO [CFM_617e] Visions of Hypnos && Test: Visions of Hypnos_CFM_617e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e", new Power {
				// TODO [CFM_621e] Goldthorn && Test: Goldthorn_CFM_621e
				InfoCardId = "CFM_621e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e2] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +4 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e2", new Power {
				// TODO [CFM_621e2] Goldthorn && Test: Goldthorn_CFM_621e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_621e3] Goldthorn (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +6 Health.
			// --------------------------------------------------------
			cards.Add("CFM_621e3", new Power {
				// TODO [CFM_621e3] Goldthorn && Test: Goldthorn_CFM_621e3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_626e] Fortitude (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("CFM_626e", new Power {
				// TODO [CFM_626e] Fortitude && Test: Fortitude_CFM_626e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_631e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Brass Knuckles.
			// --------------------------------------------------------
			cards.Add("CFM_631e", new Power {
				// TODO [CFM_631e] Smuggling && Test: Smuggling_CFM_631e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_639e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Grimestreet Enforcer.
			// --------------------------------------------------------
			cards.Add("CFM_639e", new Power {
				// TODO [CFM_639e] Smuggling && Test: Smuggling_CFM_639e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_650e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimscale Chum.
			// --------------------------------------------------------
			cards.Add("CFM_650e", new Power {
				// TODO [CFM_650e] Smuggling && Test: Smuggling_CFM_650e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_651e] Extra Sharp (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_651e", new Power {
				// TODO [CFM_651e] Extra Sharp && Test: Extra Sharp_CFM_651e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_658e] Cut Off (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("CFM_658e", new Power {
				// TODO [CFM_658e] Cut Off && Test: Cut Off_CFM_658e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_671e] We All Scream (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_671e", new Power {
				// TODO [CFM_671e] We All Scream && Test: We All Scream_CFM_671e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_685e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +5/+5 from Don Han'Cho.
			// --------------------------------------------------------
			cards.Add("CFM_685e", new Power {
				// TODO [CFM_685e] Smuggling && Test: Smuggling_CFM_685e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_699e] Seadevil Enchant (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("CFM_699e", new Power {
				// TODO [CFM_699e] Seadevil Enchant && Test: Seadevil Enchant_CFM_699e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_752e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +3/+3 from Stolen Goods.
			// --------------------------------------------------------
			cards.Add("CFM_752e", new Power {
				// TODO [CFM_752e] Smuggling && Test: Smuggling_CFM_752e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_753e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Outfitter.
			// --------------------------------------------------------
			cards.Add("CFM_753e", new Power {
				// TODO [CFM_753e] Smuggling && Test: Smuggling_CFM_753e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_754e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats from Grimy Gadgeteer.
			// --------------------------------------------------------
			cards.Add("CFM_754e", new Power {
				// TODO [CFM_754e] Smuggling && Test: Smuggling_CFM_754e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_755e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Pawnbroker.
			// --------------------------------------------------------
			cards.Add("CFM_755e", new Power {
				// TODO [CFM_755e] Smuggling && Test: Smuggling_CFM_755e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_816e] Get Big (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_816e", new Power {
				// TODO [CFM_816e] Get Big && Test: Get Big_CFM_816e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_851e] The Scoop (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("CFM_851e", new Power {
				// TODO [CFM_851e] The Scoop && Test: The Scoop_CFM_851e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_853e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Grimestreet Smuggler.
			// --------------------------------------------------------
			cards.Add("CFM_853e", new Power {
				// TODO [CFM_853e] Smuggling && Test: Smuggling_CFM_853e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BossRumble001hpe] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Han'Cho
			// --------------------------------------------------------
			cards.Add("TB_BossRumble001hpe", new Power {
				// TODO [TB_BossRumble001hpe] Smuggling && Test: Smuggling_TB_BossRumble001hpe
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HealthAttackSwap_Ench] Putricide's Potion (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Putricide
			// --------------------------------------------------------
			cards.Add("TB_HealthAttackSwap_Ench", new Power {
				// TODO [TB_HealthAttackSwap_Ench] Putricide's Potion && Test: Putricide's Potion_TB_HealthAttackSwap_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m2] Kabal Demon (*) - COST:5 [ATK:5/HP:5] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m2", new Power {
				// TODO [CFM_621_m2] Kabal Demon && Test: Kabal Demon_CFM_621_m2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m3] Kabal Demon (*) - COST:8 [ATK:8/HP:8] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m3", new Power {
				// TODO [CFM_621_m3] Kabal Demon && Test: Kabal Demon_CFM_621_m3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m4] Kabal Demon (*) - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m4", new Power {
				// TODO [CFM_621_m4] Kabal Demon && Test: Kabal Demon_CFM_621_m4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_621_m5] Sheep (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_621_m5", new Power {
				// TODO [CFM_621_m5] Sheep && Test: Sheep_CFM_621_m5
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_648t] "Little Friend" (*) - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_648t", new Power {
				// TODO [CFM_648t] "Little Friend" && Test: "Little Friend"_CFM_648t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668t] Doppelgangster (*) - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668t", new Power {
				// TODO [CFM_668t] Doppelgangster && Test: Doppelgangster_CFM_668t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668t2] Doppelgangster (*) - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668t2", new Power {
				// TODO [CFM_668t2] Doppelgangster && Test: Doppelgangster_CFM_668t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t01] Jade Golem (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t01", new Power {
				// TODO [CFM_712_t01] Jade Golem && Test: Jade Golem_CFM_712_t01
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t02] Jade Golem (*) - COST:2 [ATK:2/HP:2] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t02", new Power {
				// TODO [CFM_712_t02] Jade Golem && Test: Jade Golem_CFM_712_t02
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t03] Jade Golem (*) - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t03", new Power {
				// TODO [CFM_712_t03] Jade Golem && Test: Jade Golem_CFM_712_t03
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t04] Jade Golem (*) - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t04", new Power {
				// TODO [CFM_712_t04] Jade Golem && Test: Jade Golem_CFM_712_t04
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t05] Jade Golem (*) - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t05", new Power {
				// TODO [CFM_712_t05] Jade Golem && Test: Jade Golem_CFM_712_t05
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t06] Jade Golem (*) - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t06", new Power {
				// TODO [CFM_712_t06] Jade Golem && Test: Jade Golem_CFM_712_t06
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t07] Jade Golem (*) - COST:7 [ATK:7/HP:7] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t07", new Power {
				// TODO [CFM_712_t07] Jade Golem && Test: Jade Golem_CFM_712_t07
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t08] Jade Golem (*) - COST:8 [ATK:8/HP:8] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t08", new Power {
				// TODO [CFM_712_t08] Jade Golem && Test: Jade Golem_CFM_712_t08
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t09] Jade Golem (*) - COST:9 [ATK:9/HP:9] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t09", new Power {
				// TODO [CFM_712_t09] Jade Golem && Test: Jade Golem_CFM_712_t09
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t10] Jade Golem (*) - COST:10 [ATK:10/HP:10] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t10", new Power {
				// TODO [CFM_712_t10] Jade Golem && Test: Jade Golem_CFM_712_t10
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t11] Jade Golem (*) - COST:10 [ATK:11/HP:11] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t11", new Power {
				// TODO [CFM_712_t11] Jade Golem && Test: Jade Golem_CFM_712_t11
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t12] Jade Golem (*) - COST:10 [ATK:12/HP:12] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t12", new Power {
				// TODO [CFM_712_t12] Jade Golem && Test: Jade Golem_CFM_712_t12
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t13] Jade Golem (*) - COST:10 [ATK:13/HP:13] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t13", new Power {
				// TODO [CFM_712_t13] Jade Golem && Test: Jade Golem_CFM_712_t13
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t14] Jade Golem (*) - COST:10 [ATK:14/HP:14] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t14", new Power {
				// TODO [CFM_712_t14] Jade Golem && Test: Jade Golem_CFM_712_t14
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t15] Jade Golem (*) - COST:10 [ATK:15/HP:15] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t15", new Power {
				// TODO [CFM_712_t15] Jade Golem && Test: Jade Golem_CFM_712_t15
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t16] Jade Golem (*) - COST:10 [ATK:16/HP:16] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t16", new Power {
				// TODO [CFM_712_t16] Jade Golem && Test: Jade Golem_CFM_712_t16
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t17] Jade Golem (*) - COST:10 [ATK:17/HP:17] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t17", new Power {
				// TODO [CFM_712_t17] Jade Golem && Test: Jade Golem_CFM_712_t17
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t18] Jade Golem (*) - COST:10 [ATK:18/HP:18] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t18", new Power {
				// TODO [CFM_712_t18] Jade Golem && Test: Jade Golem_CFM_712_t18
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t19] Jade Golem (*) - COST:10 [ATK:19/HP:19] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t19", new Power {
				// TODO [CFM_712_t19] Jade Golem && Test: Jade Golem_CFM_712_t19
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t20] Jade Golem (*) - COST:10 [ATK:20/HP:20] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t20", new Power {
				// TODO [CFM_712_t20] Jade Golem && Test: Jade Golem_CFM_712_t20
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t21] Jade Golem (*) - COST:10 [ATK:21/HP:21] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t21", new Power {
				// TODO [CFM_712_t21] Jade Golem && Test: Jade Golem_CFM_712_t21
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t22] Jade Golem (*) - COST:10 [ATK:22/HP:22] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t22", new Power {
				// TODO [CFM_712_t22] Jade Golem && Test: Jade Golem_CFM_712_t22
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t23] Jade Golem (*) - COST:10 [ATK:23/HP:23] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t23", new Power {
				// TODO [CFM_712_t23] Jade Golem && Test: Jade Golem_CFM_712_t23
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t24] Jade Golem (*) - COST:10 [ATK:24/HP:24] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t24", new Power {
				// TODO [CFM_712_t24] Jade Golem && Test: Jade Golem_CFM_712_t24
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t25] Jade Golem (*) - COST:10 [ATK:25/HP:25] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t25", new Power {
				// TODO [CFM_712_t25] Jade Golem && Test: Jade Golem_CFM_712_t25
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t26] Jade Golem (*) - COST:10 [ATK:26/HP:26] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t26", new Power {
				// TODO [CFM_712_t26] Jade Golem && Test: Jade Golem_CFM_712_t26
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t27] Jade Golem (*) - COST:10 [ATK:27/HP:27] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t27", new Power {
				// TODO [CFM_712_t27] Jade Golem && Test: Jade Golem_CFM_712_t27
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t28] Jade Golem (*) - COST:10 [ATK:28/HP:28] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t28", new Power {
				// TODO [CFM_712_t28] Jade Golem && Test: Jade Golem_CFM_712_t28
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t29] Jade Golem (*) - COST:10 [ATK:29/HP:29] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t29", new Power {
				// TODO [CFM_712_t29] Jade Golem && Test: Jade Golem_CFM_712_t29
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t30] Jade Golem (*) - COST:10 [ATK:30/HP:30] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t30", new Power {
				// TODO [CFM_712_t30] Jade Golem && Test: Jade Golem_CFM_712_t30
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t] Kazakus Potion (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t", new Power {
				// TODO [CFM_621t] Kazakus Potion && Test: Kazakus Potion_CFM_621t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t10] Netherbloom (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a 2/2 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// --------------------------------------------------------
			cards.Add("CFM_621t10", new Power {
				// TODO [CFM_621t10] Netherbloom && Test: Netherbloom_CFM_621t10
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t11] Lesser Potion (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 1-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1087
			// --------------------------------------------------------
			cards.Add("CFM_621t11", new Power {
				// TODO [CFM_621t11] Lesser Potion && Test: Lesser Potion_CFM_621t11
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t12] Greater Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 5-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1088
			// --------------------------------------------------------
			cards.Add("CFM_621t12", new Power {
				// TODO [CFM_621t12] Greater Potion && Test: Greater Potion_CFM_621t12
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t13] Superior Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 10-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1089
			// --------------------------------------------------------
			cards.Add("CFM_621t13", new Power {
				// TODO [CFM_621t13] Superior Potion && Test: Superior Potion_CFM_621t13
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t14] Kazakus Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t14", new Power {
				// TODO [CFM_621t14] Kazakus Potion && Test: Kazakus Potion_CFM_621t14
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t15] Kazakus Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t15", new Power {
				// TODO [CFM_621t15] Kazakus Potion && Test: Kazakus Potion_CFM_621t15
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t16] Heart of Fire (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $5 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t16", new Power {
				// TODO [CFM_621t16] Heart of Fire && Test: Heart of Fire_CFM_621t16
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t17] Stonescale Oil (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 7 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t17", new Power {
				// TODO [CFM_621t17] Stonescale Oil && Test: Stonescale Oil_CFM_621t17
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t18] Felbloom (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t18", new Power {
				// TODO [CFM_621t18] Felbloom && Test: Felbloom_CFM_621t18
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t19] Icecap (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> 2 random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			cards.Add("CFM_621t19", new Power {
				// TODO [CFM_621t19] Icecap && Test: Icecap_CFM_621t19
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t2] Heart of Fire (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t2", new Power {
				// TODO [CFM_621t2] Heart of Fire && Test: Heart of Fire_CFM_621t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t20] Netherbloom (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a 5/5 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t20", new Power {
				// TODO [CFM_621t20] Netherbloom && Test: Netherbloom_CFM_621t20
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t21] Mystic Wool (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Transform a random enemy minion into a 1/1 Sheep.@Polymorph a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t21", new Power {
				// TODO [CFM_621t21] Mystic Wool && Test: Mystic Wool_CFM_621t21
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t22] Kingsblood (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t22", new Power {
				// TODO [CFM_621t22] Kingsblood && Test: Kingsblood_CFM_621t22
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t23] Shadow Oil (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add 2 random Demons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 10
			// --------------------------------------------------------
			cards.Add("CFM_621t23", new Power {
				// TODO [CFM_621t23] Shadow Oil && Test: Shadow Oil_CFM_621t23
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t24] Goldthorn (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +4 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			cards.Add("CFM_621t24", new Power {
				// TODO [CFM_621t24] Goldthorn && Test: Goldthorn_CFM_621t24
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t25] Heart of Fire (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $8 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t25", new Power {
				// TODO [CFM_621t25] Heart of Fire && Test: Heart of Fire_CFM_621t25
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t26] Stonescale Oil (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t26", new Power {
				// TODO [CFM_621t26] Stonescale Oil && Test: Stonescale Oil_CFM_621t26
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t27] Icecap (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> 3 random enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t27", new Power {
				// TODO [CFM_621t27] Icecap && Test: Icecap_CFM_621t27
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t28] Netherbloom (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon an 8/8 Demon.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t28", new Power {
				// TODO [CFM_621t28] Netherbloom && Test: Netherbloom_CFM_621t28
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t29] Mystic Wool (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Transform all minions into 1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t29", new Power {
				// TODO [CFM_621t29] Mystic Wool && Test: Mystic Wool_CFM_621t29
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t3] Stonescale Oil (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 4 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// --------------------------------------------------------
			cards.Add("CFM_621t3", new Power {
				// TODO [CFM_621t3] Stonescale Oil && Test: Stonescale Oil_CFM_621t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t30] Kingsblood (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t30", new Power {
				// TODO [CFM_621t30] Kingsblood && Test: Kingsblood_CFM_621t30
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t31] Shadow Oil (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add 3 random Demons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 10
			// --------------------------------------------------------
			cards.Add("CFM_621t31", new Power {
				// TODO [CFM_621t31] Shadow Oil && Test: Shadow Oil_CFM_621t31
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t32] Goldthorn (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +6 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			cards.Add("CFM_621t32", new Power {
				// TODO [CFM_621t32] Goldthorn && Test: Goldthorn_CFM_621t32
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t33] Felbloom (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $6 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t33", new Power {
				// TODO [CFM_621t33] Felbloom && Test: Felbloom_CFM_621t33
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t37] Ichor of Undeath (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon a friendly minion that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 3
			// --------------------------------------------------------
			cards.Add("CFM_621t37", new Power {
				// TODO [CFM_621t37] Ichor of Undeath && Test: Ichor of Undeath_CFM_621t37
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t38] Ichor of Undeath (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon 2 friendly minions that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// --------------------------------------------------------
			cards.Add("CFM_621t38", new Power {
				// TODO [CFM_621t38] Ichor of Undeath && Test: Ichor of Undeath_CFM_621t38
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t39] Ichor of Undeath (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Summon 3 friendly minions that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// --------------------------------------------------------
			cards.Add("CFM_621t39", new Power {
				// TODO [CFM_621t39] Ichor of Undeath && Test: Ichor of Undeath_CFM_621t39
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t4] Felbloom (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t4", new Power {
				// TODO [CFM_621t4] Felbloom && Test: Felbloom_CFM_621t4
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t5] Icecap (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 7
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t5", new Power {
				// TODO [CFM_621t5] Icecap && Test: Icecap_CFM_621t5
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t6] Goldthorn (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Give your minions +2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 6
			// --------------------------------------------------------
			cards.Add("CFM_621t6", new Power {
				// TODO [CFM_621t6] Goldthorn && Test: Goldthorn_CFM_621t6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t8] Kingsblood (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 8
			// --------------------------------------------------------
			cards.Add("CFM_621t8", new Power {
				// TODO [CFM_621t8] Kingsblood && Test: Kingsblood_CFM_621t8
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t9] Shadow Oil (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Add a random Demon to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 9
			// --------------------------------------------------------
			cards.Add("CFM_621t9", new Power {
				// TODO [CFM_621t9] Shadow Oil && Test: Shadow Oil_CFM_621t9
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
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
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
