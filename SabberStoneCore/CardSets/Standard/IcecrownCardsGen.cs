using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Loader.Generated.CardSets
{
	public class IcecrownCardsGen
	{
		private static void Heroes(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_481", new List<Enchantment> {
				// TODO [ICC_481] Thrall, Deathseer && Test: Thrall, Deathseer_ICC_481
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_827", new List<Enchantment> {
				// TODO [ICC_827] Valeera the Hollow && Test: Valeera the Hollow_ICC_827
				new Enchantment
				{
					InfoCardId = "ICC_827e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_828", new List<Enchantment> {
				// TODO [ICC_828] Deathstalker Rexxar && Test: Deathstalker Rexxar_ICC_828
				new Enchantment
				{
					InfoCardId = "ICC_828e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_829", new List<Enchantment> {
				// TODO [ICC_829] Uther of the Ebon Blade && Test: Uther of the Ebon Blade_ICC_829
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_830", new List<Enchantment> {
				// TODO [ICC_830] Shadowreaper Anduin && Test: Shadowreaper Anduin_ICC_830
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_831", new List<Enchantment> {
				// TODO [ICC_831] Bloodreaver Gul'dan && Test: Bloodreaver Gul'dan_ICC_831
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_832", new List<Enchantment> {
				// TODO [ICC_832] Malfurion the Pestilent && Test: Malfurion the Pestilent_ICC_832
				new Enchantment
				{
					InfoCardId = "ICC_832e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_833", new List<Enchantment> {
				// TODO [ICC_833] Frost Lich Jaina && Test: Frost Lich Jaina_ICC_833
				new Enchantment
				{
					InfoCardId = "ICC_833e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_834", new List<Enchantment> {
				// TODO [ICC_834] Scourgelord Garrosh && Test: Scourgelord Garrosh_ICC_834
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA01_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("ICCA01_001", new List<Enchantment> {
				// TODO [ICCA01_001] The Lich King && Test: The Lich King_ICCA01_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - PALADIN
			// [ICCA01_013] Tirion Fordring (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t1, ICC_314t6, ICC_314t5, ICC_314t7, ICC_314t8
			// --------------------------------------------------------
			cards.Add("ICCA01_013", new List<Enchantment> {
				// TODO [ICCA01_013] Tirion Fordring && Test: Tirion Fordring_ICCA01_013
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA03_001] Secrets of the Citadel (*) - COST:0 [ATK:0/HP:100] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA03_001", new List<Enchantment> {
				// TODO [ICCA03_001] Secrets of the Citadel && Test: Secrets of the Citadel_ICCA03_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA04_001] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45627
			// --------------------------------------------------------
			cards.Add("ICCA04_001", new List<Enchantment> {
				// TODO [ICCA04_001] Sindragosa && Test: Sindragosa_ICCA04_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA05_001] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 43194
			// --------------------------------------------------------
			cards.Add("ICCA05_001", new List<Enchantment> {
				// TODO [ICCA05_001] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_ICCA05_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA06_001] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42447
			// --------------------------------------------------------
			cards.Add("ICCA06_001", new List<Enchantment> {
				// TODO [ICCA06_001] Lord Marrowgar && Test: Lord Marrowgar_ICCA06_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA07_001] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42876
			// --------------------------------------------------------
			cards.Add("ICCA07_001", new List<Enchantment> {
				// TODO [ICCA07_001] Professor Putricide && Test: Professor Putricide_ICCA07_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA07_001h2] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42876
			// --------------------------------------------------------
			cards.Add("ICCA07_001h2", new List<Enchantment> {
				// TODO [ICCA07_001h2] Professor Putricide && Test: Professor Putricide_ICCA07_001h2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA07_001h3] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42876
			// --------------------------------------------------------
			cards.Add("ICCA07_001h3", new List<Enchantment> {
				// TODO [ICCA07_001h3] Professor Putricide && Test: Professor Putricide_ICCA07_001h3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA08_001] The Lich King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("ICCA08_001", new List<Enchantment> {
				// TODO [ICCA08_001] The Lich King && Test: The Lich King_ICCA08_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA09_002] Deathbringer Saurfang (*) - COST:0 [ATK:0/HP:20] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 43038
			// --------------------------------------------------------
			cards.Add("ICCA09_002", new List<Enchantment> {
				// TODO [ICCA09_002] Deathbringer Saurfang && Test: Deathbringer Saurfang_ICCA09_002
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [ICCA10_009] Lady Deathwhisper (*) - COST:0 [ATK:0/HP:30] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45605
			// --------------------------------------------------------
			cards.Add("ICCA10_009", new List<Enchantment> {
				// TODO [ICCA10_009] Lady Deathwhisper && Test: Lady Deathwhisper_ICCA10_009
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
			// [ICC_481p] Transmute Spirit (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_481p", new List<Enchantment> {
				// TODO [ICC_481p] Transmute Spirit && Test: Transmute Spirit_ICC_481p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_827p", new List<Enchantment> {
				// TODO [ICC_827p] Death's Shadow && Test: Death's Shadow_ICC_827p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_828p", new List<Enchantment> {
				// TODO [ICC_828p] Build-A-Beast && Test: Build-A-Beast_ICC_828p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_829p", new List<Enchantment> {
				// TODO [ICC_829p] The Four Horsemen && Test: The Four Horsemen_ICC_829p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ HERO_POWER - PRIEST
			// [ICC_830p] Voidform (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage.
			//       After you play a card,
			//       refresh this. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_830p", new List<Enchantment> {
				// TODO [ICC_830p] Voidform && Test: Voidform_ICC_830p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_831p] Siphon Life (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal $3 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_831p", new List<Enchantment> {
				// TODO [ICC_831p] Siphon Life && Test: Siphon Life_ICC_831p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICC_832p", new List<Enchantment> {
				// TODO [ICC_832p] Plague Lord && Test: Plague Lord_ICC_832p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICC_833h] Icy Touch (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage. If this kills a minion, summon a Water Elemental. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_833h", new List<Enchantment> {
				// TODO [ICC_833h] Icy Touch && Test: Icy Touch_ICC_833h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - WARRIOR
			// [ICC_834h] Bladestorm (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal $1 damage to all_minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_834h", new List<Enchantment> {
				// TODO [ICC_834h] Bladestorm && Test: Bladestorm_ICC_834h
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA04_008p] Frost Breath (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Permanently <b>Freeze</b> all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA04_008p", new List<Enchantment> {
				// TODO [ICCA04_008p] Frost Breath && Test: Frost Breath_ICCA04_008p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA04_009p] Frost Breath (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Triggered Power</b>
			//       At 20 Health, transforms all enemy minions into blocks of ice.
			// --------------------------------------------------------
			cards.Add("ICCA04_009p", new List<Enchantment> {
				// TODO [ICCA04_009p] Frost Breath && Test: Frost Breath_ICCA04_009p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA04_010p] Frost Breath (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Triggered Power</b>
			//       At 10 Health, transforms all enemy minions into blocks of ice.
			// --------------------------------------------------------
			cards.Add("ICCA04_010p", new List<Enchantment> {
				// TODO [ICCA04_010p] Frost Breath && Test: Frost Breath_ICCA04_010p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA04_011p] Ice Claw (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal $2 damage. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICCA04_011p", new List<Enchantment> {
				// TODO [ICCA04_011p] Ice Claw && Test: Ice Claw_ICCA04_011p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA05_002p] Vampiric Bite (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a non-Vampire +2/+2. You <i>must</i> use this.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_NOT_VAMPIRE = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICCA05_002p", new List<Enchantment> {
				// TODO [ICCA05_002p] Vampiric Bite && Test: Vampiric Bite_ICCA05_002p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA05_004p] Vampiric Leech (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Lifesteal</b>
			//       Deal $3 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICCA05_004p", new List<Enchantment> {
				// TODO [ICCA05_004p] Vampiric Leech && Test: Vampiric Leech_ICCA05_004p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA06_002p] Skeletal Reconstruction (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Restore your hero to full Health.
			// --------------------------------------------------------
			cards.Add("ICCA06_002p", new List<Enchantment> {
				// TODO [ICCA06_002p] Skeletal Reconstruction && Test: Skeletal Reconstruction_ICCA06_002p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA07_002p] Mad Science (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All <b>Secrets</b> cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICCA07_002p", new List<Enchantment> {
				// TODO [ICCA07_002p] Mad Science && Test: Mad Science_ICCA07_002p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA07_003p] Madder Science (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All weapons cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICCA07_003p", new List<Enchantment> {
				// TODO [ICCA07_003p] Madder Science && Test: Madder Science_ICCA07_003p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA07_005p] Maddest Science (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       All cards cost (5).
			//       Because SCIENCE!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// RefTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA07_005p", new List<Enchantment> {
				// TODO [ICCA07_005p] Maddest Science && Test: Maddest Science_ICCA07_005p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA08_002p] The Scourge (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_002p", new List<Enchantment> {
				// TODO [ICCA08_002p] The Scourge && Test: The Scourge_ICCA08_002p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------- HERO_POWER - DEATHKNIGHT
			// [ICCA08_030p] Remorseless Winter (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal @ damage to the enemy hero. +1 Damage each time.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_030p", new List<Enchantment> {
				// TODO [ICCA08_030p] Remorseless Winter && Test: Remorseless Winter_ICCA08_030p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA08_032p] Harvest of Souls (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       You are <b>Immune</b> if you control a Trapped Soul.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_032p", new List<Enchantment> {
				// TODO [ICCA08_032p] Harvest of Souls && Test: Harvest of Souls_ICCA08_032p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA09_001p] Blood Rune (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Can only take damage from weapons.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("ICCA09_001p", new List<Enchantment> {
				// TODO [ICCA09_001p] Blood Rune && Test: Blood Rune_ICCA09_001p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [ICCA10_009p] Whisper of Death (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Damage all enemy
			//       minions until they have
			//       1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA10_009p", new List<Enchantment> {
				// TODO [ICCA10_009p] Whisper of Death && Test: Whisper of Death_ICCA10_009p
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void DeathknightNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------ ENCHANTMENT - DEATHKNIGHT
			// [ICCA08_023e] Plagued (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("ICCA08_023e", new List<Enchantment> {
				// TODO [ICCA08_023e] Plagued && Test: Plagued_ICCA08_023e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t2] Army of the Dead (*) - COST:6 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Remove the top 5 cards of your deck. Summon any minions removed.
			// --------------------------------------------------------
			cards.Add("ICC_314t2", new List<Enchantment> {
				// TODO [ICC_314t2] Army of the Dead && Test: Army of the Dead_ICC_314t2
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_314t3", new List<Enchantment> {
				// TODO [ICC_314t3] Doom Pact && Test: Doom Pact_ICC_314t3
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t4] Death Grip (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Steal a minion from your opponent's deck and add it to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_314t4", new List<Enchantment> {
				// TODO [ICC_314t4] Death Grip && Test: Death Grip_ICC_314t4
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t5] Death Coil (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $5 damage to an enemy, or restore #5 Health to a friendly character. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_314t5", new List<Enchantment> {
				// TODO [ICC_314t5] Death Coil && Test: Death Coil_ICC_314t5
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_314t6", new List<Enchantment> {
				// TODO [ICC_314t6] Obliterate && Test: Obliterate_ICC_314t6
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_314t7", new List<Enchantment> {
				// TODO [ICC_314t7] Anti-Magic Shell && Test: Anti-Magic Shell_ICC_314t7
				new Enchantment
				{
					InfoCardId = "ICC_314t7e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICC_314t8] Death and Decay (*) - COST:3 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemies. *spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_314t8", new List<Enchantment> {
				// TODO [ICC_314t8] Death and Decay && Test: Death and Decay_ICC_314t8
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA01_003] Blood Tap (*) - COST:1 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (0).
			// --------------------------------------------------------
			cards.Add("ICCA01_003", new List<Enchantment> {
				// TODO [ICCA01_003] Blood Tap && Test: Blood Tap_ICCA01_003
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA01_004] Army of the Dead (*) - COST:10 
			// - Fac: neutral, Set: icecrown, 
			// --------------------------------------------------------
			// Text: Summon seven 3/3 Ghouls with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICCA01_004", new List<Enchantment> {
				// TODO [ICCA01_004] Army of the Dead && Test: Army of the Dead_ICCA01_004
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_021] The True Lich (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Set the enemy hero's remaining Health to 1.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_021", new List<Enchantment> {
				// TODO [ICCA08_021] The True Lich && Test: The True Lich_ICCA08_021
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_022] Fallen Champions (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Whenever an enemy dies this game, take control of it.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_022", new List<Enchantment> {
				// TODO [ICCA08_022] Fallen Champions && Test: Fallen Champions_ICCA08_022
				new Enchantment
				{
					InfoCardId = "ICCA08_022e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_023] Necrotic Plague (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Set minions in your opponent's hand and deck to 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_023", new List<Enchantment> {
				// TODO [ICCA08_023] Necrotic Plague && Test: Necrotic Plague_ICCA08_023
				new Enchantment
				{
					InfoCardId = "ICCA08_023e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_024] The Hunted (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to your opponent for each minion in their deck. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_024", new List<Enchantment> {
				// TODO [ICCA08_024] The Hunted && Test: The Hunted_ICCA08_024
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_025] Purge the Weak (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Destroy all enemy minions that cost (3) or less, wherever they are.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_025", new List<Enchantment> {
				// TODO [ICCA08_025] Purge the Weak && Test: Purge the Weak_ICCA08_025
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_026] Soul Reaper (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $2 damage for each duplicate in opponent’s deck. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICCA08_026", new List<Enchantment> {
				// TODO [ICCA08_026] Soul Reaper && Test: Soul Reaper_ICCA08_026
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_027] The True King (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Gain 100 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_027", new List<Enchantment> {
				// TODO [ICCA08_027] The True King && Test: The True King_ICCA08_027
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_028] The Price of Power (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Destroy every spell in your opponent's hand and deck.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_028", new List<Enchantment> {
				// TODO [ICCA08_028] The Price of Power && Test: The Price of Power_ICCA08_028
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [ICCA08_029] Shut up, Priest (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Your opponent can't emote.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_029", new List<Enchantment> {
				// TODO [ICCA08_029] Shut up, Priest && Test: Shut up, Priest_ICCA08_029
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICC_314t1] Frostmourne (*) - COST:7 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon every minion killed by this weapon.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_314t1", new List<Enchantment> {
				// TODO [ICC_314t1] Frostmourne && Test: Frostmourne_ICC_314t1
				new Enchantment
				{
					InfoCardId = "ICC_314t1e",
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					InfoCardId = "ICC_314t1e",
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICCA01_005] Frostmourne (*) - COST:2 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("ICCA01_005", new List<Enchantment> {
				// TODO [ICCA01_005] Frostmourne && Test: Frostmourne_ICCA01_005
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICCA08_020] Frostmourne (*) - COST:7 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Remove all your minions. <b>Deathrattle:</b> Resummon them.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - BATTLECRY = 1
			// - IMMUNE = 1
			// - CANT_BE_DESTROYED = 1
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA08_020", new List<Enchantment> {
				// TODO [ICCA08_020] Frostmourne && Test: Frostmourne_ICCA08_020
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ----------------------------------- WEAPON - DEATHKNIGHT
			// [ICCA09_003t4] Abominable Knuckles (*) - COST:4 [ATK:4/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("ICCA09_003t4", new List<Enchantment> {
				// TODO [ICCA09_003t4] Abominable Knuckles && Test: Abominable Knuckles_ICCA09_003t4
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Druid(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_047", new List<Enchantment> {
				// TODO [ICC_047] Fatespinner && Test: Fatespinner_ICC_047
				new Enchantment
				{
					InfoCardId = "ICC_047e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_051", new List<Enchantment> {
				// TODO [ICC_051] Druid of the Swarm && Test: Druid of the Swarm_ICC_051
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_807", new List<Enchantment> {
				// TODO [ICC_807] Strongshell Scavenger && Test: Strongshell Scavenger_ICC_807
				new Enchantment
				{
					InfoCardId = "ICC_807e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_808", new List<Enchantment> {
				// TODO [ICC_808] Crypt Lord && Test: Crypt Lord_ICC_808
				new Enchantment
				{
					InfoCardId = "ICC_808e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_835", new List<Enchantment> {
				// TODO [ICC_835] Hadronox && Test: Hadronox_ICC_835
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_050", new List<Enchantment> {
				// TODO [ICC_050] Webweave && Test: Webweave_ICC_050
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_054] Spreading Plague - COST:5 
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
			cards.Add("ICC_054", new List<Enchantment> {
				// TODO [ICC_054] Spreading Plague && Test: Spreading Plague_ICC_054
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_079", new List<Enchantment> {
				// TODO [ICC_079] Gnash && Test: Gnash_ICC_079
				new Enchantment
				{
					InfoCardId = "ICC_079e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_085] Ultimate Infestation - COST:10 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage. Draw
			//       5 cards. Gain 5 Armor.
			//       Summon a 5/5 Ghoul. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_085", new List<Enchantment> {
				// TODO [ICC_085] Ultimate Infestation && Test: Ultimate Infestation_ICC_085
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_047e] Growth (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047e", new List<Enchantment> {
				// TODO [ICC_047e] Growth && Test: Growth_ICC_047e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_079e", new List<Enchantment> {
				// TODO [ICC_079e] Gnash && Test: Gnash_ICC_079e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [ICC_808e] Might of Ner'ub (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Health.
			// --------------------------------------------------------
			cards.Add("ICC_808e", new List<Enchantment> {
				// TODO [ICC_808e] Might of Ner'ub && Test: Might of Ner'ub_ICC_808e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_047t", new List<Enchantment> {
				// TODO [ICC_047t] Fatespinner && Test: Fatespinner_ICC_047t
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_047t2] Fatespinner (*) - COST:5 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all minions +2/+2, then deal 3 damage to them.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_047t2", new List<Enchantment> {
				// TODO [ICC_047t2] Fatespinner && Test: Fatespinner_ICC_047t2
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_051t", new List<Enchantment> {
				// TODO [ICC_051t] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_051t2", new List<Enchantment> {
				// TODO [ICC_051t2] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_051t3", new List<Enchantment> {
				// TODO [ICC_051t3] Druid of the Swarm && Test: Druid of the Swarm_ICC_051t3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_085t] Ghoul Infestor (*) - COST:5 [ATK:5/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_085t", new List<Enchantment> {
				// TODO [ICC_085t] Ghoul Infestor && Test: Ghoul Infestor_ICC_085t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- MINION - DRUID
			// [ICC_832t3] Frost Widow (*) - COST:2 [ATK:1/HP:2] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_832t3", new List<Enchantment> {
				// TODO [ICC_832t3] Frost Widow && Test: Frost Widow_ICC_832t3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_832t4", new List<Enchantment> {
				// TODO [ICC_832t4] Scarab Beetle && Test: Scarab Beetle_ICC_832t4
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047a] Growth (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give all minions +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_047a", new List<Enchantment> {
				// TODO [ICC_047a] Growth && Test: Growth_ICC_047a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_047b] Decay (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 3 damage to all minions.
			// --------------------------------------------------------
			cards.Add("ICC_047b", new List<Enchantment> {
				// TODO [ICC_047b] Decay && Test: Decay_ICC_047b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051a] Spider Form (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("ICC_051a", new List<Enchantment> {
				// TODO [ICC_051a] Spider Form && Test: Spider Form_ICC_051a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_051b] Scarab Form (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_051b", new List<Enchantment> {
				// TODO [ICC_051b] Scarab Form && Test: Scarab Form_ICC_051b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832a] Scarab Plague (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Summon two 1/5 Scarabs with <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832a", new List<Enchantment> {
				// TODO [ICC_832a] Scarab Plague && Test: Scarab Plague_ICC_832a
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832b] Spider Plague (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: [x]Summon two 1/2
			//       Spiders with <b>Poisonous</b>.
			// --------------------------------------------------------
			cards.Add("ICC_832b", new List<Enchantment> {
				// TODO [ICC_832b] Spider Plague && Test: Spider Plague_ICC_832b
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pa] Scarab Shell (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Armor.
			// --------------------------------------------------------
			cards.Add("ICC_832pa", new List<Enchantment> {
				// TODO [ICC_832pa] Scarab Shell && Test: Scarab Shell_ICC_832pa
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [ICC_832pb] Spider Fangs (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_832pb", new List<Enchantment> {
				// TODO [ICC_832pb] Spider Fangs && Test: Spider Fangs_ICC_832pb
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_021", new List<Enchantment> {
				// TODO [ICC_021] Exploding Bloatbat && Test: Exploding Bloatbat_ICC_021
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_204", new List<Enchantment> {
				// TODO [ICC_204] Professor Putricide && Test: Professor Putricide_ICC_204
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_243", new List<Enchantment> {
				// TODO [ICC_243] Corpse Widow && Test: Corpse Widow_ICC_243
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_415", new List<Enchantment> {
				// TODO [ICC_415] Stitched Tracker && Test: Stitched Tracker_ICC_415
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_419", new List<Enchantment> {
				// TODO [ICC_419] Bearshark && Test: Bearshark_ICC_419
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_825", new List<Enchantment> {
				// TODO [ICC_825] Abominable Bowman && Test: Abominable Bowman_ICC_825
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_049] Toxic Arrow - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_049", new List<Enchantment> {
				// TODO [ICC_049] Toxic Arrow && Test: Toxic Arrow_ICC_049
				new Enchantment
				{
					InfoCardId = "ICC_049e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - HUNTER
			// [ICC_052] Play Dead - COST:1 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Trigger a friendly minion's <b>Deathrattle</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_052", new List<Enchantment> {
				// TODO [ICC_052] Play Dead && Test: Play Dead_ICC_052
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_200", new List<Enchantment> {
				// TODO [ICC_200] Venomstrike Trap && Test: Venomstrike Trap_ICC_200
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_828e", new List<Enchantment> {
				// TODO [ICC_828e] Stitched && Test: Stitched_ICC_828e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------------- MINION - HUNTER
			// [ICC_828t] Zombeast (*) - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("ICC_828t", new List<Enchantment> {
				// TODO [ICC_828t] Zombeast && Test: Zombeast_ICC_828t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_068", new List<Enchantment> {
				// TODO [ICC_068] Ice Walker && Test: Ice Walker_ICC_068
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_069", new List<Enchantment> {
				// TODO [ICC_069] Ghastly Conjurer && Test: Ghastly Conjurer_ICC_069
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_083", new List<Enchantment> {
				// TODO [ICC_083] Doomed Apprentice && Test: Doomed Apprentice_ICC_083
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FROZEN_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_252", new List<Enchantment> {
				// TODO [ICC_252] Coldwraith && Test: Coldwraith_ICC_252
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_838", new List<Enchantment> {
				// TODO [ICC_838] Sindragosa && Test: Sindragosa_ICC_838
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_082", new List<Enchantment> {
				// TODO [ICC_082] Frozen Clone && Test: Frozen Clone_ICC_082
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_086", new List<Enchantment> {
				// TODO [ICC_086] Glacial Mysteries && Test: Glacial Mysteries_ICC_086
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_823] Simulacrum - COST:3 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Copy the lowest Cost minion in your hand.
			// --------------------------------------------------------
			cards.Add("ICC_823", new List<Enchantment> {
				// TODO [ICC_823] Simulacrum && Test: Simulacrum_ICC_823
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICC_836] Breath of Sindragosa - COST:1 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_836", new List<Enchantment> {
				// TODO [ICC_836] Breath of Sindragosa && Test: Breath of Sindragosa_ICC_836
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_833t", new List<Enchantment> {
				// TODO [ICC_833t] Water Elemental && Test: Water Elemental_ICC_833t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_838t", new List<Enchantment> {
				// TODO [ICC_838t] Frozen Champion && Test: Frozen Champion_ICC_838t
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [ICCA04_002] Unchained Magic (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $3 damage to the enemy hero for each spell in their hand. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA04_002", new List<Enchantment> {
				// TODO [ICCA04_002] Unchained Magic && Test: Unchained Magic_ICCA04_002
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [ICC_034] Arrogant Crusader - COST:4 [ATK:5/HP:2] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_034", new List<Enchantment> {
				// TODO [ICC_034] Arrogant Crusader && Test: Arrogant Crusader_ICC_034
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_038", new List<Enchantment> {
				// TODO [ICC_038] Righteous Protector && Test: Righteous Protector_ICC_038
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_245] Blackguard - COST:6 [ATK:3/HP:9] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your hero is healed, deal that much damage to a random enemy minion.
			// --------------------------------------------------------
			cards.Add("ICC_245", new List<Enchantment> {
				// TODO [ICC_245] Blackguard && Test: Blackguard_ICC_245
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_801", new List<Enchantment> {
				// TODO [ICC_801] Howling Commander && Test: Howling Commander_ICC_801
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_820", new List<Enchantment> {
				// TODO [ICC_820] Chillblade Champion && Test: Chillblade Champion_ICC_820
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_858", new List<Enchantment> {
				// TODO [ICC_858] Bolvar, Fireblood && Test: Bolvar, Fireblood_ICC_858
				new Enchantment
				{
					InfoCardId = "ICC_858e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_039", new List<Enchantment> {
				// TODO [ICC_039] Dark Conviction && Test: Dark Conviction_ICC_039
				new Enchantment
				{
					InfoCardId = "ICC_039e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [ICC_244] Desperate Stand - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_244", new List<Enchantment> {
				// TODO [ICC_244] Desperate Stand && Test: Desperate Stand_ICC_244
				new Enchantment
				{
					InfoCardId = "ICC_244e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_071", new List<Enchantment> {
				// TODO [ICC_071] Light's Sorrow && Test: Light's Sorrow_ICC_071
				new Enchantment
				{
					InfoCardId = "ICC_071e",
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_071e] Dying Light (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_071e", new List<Enchantment> {
				// TODO [ICC_071e] Dying Light && Test: Dying Light_ICC_071e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_244e] Redeemed (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Return this to life with 1 Health.
			// --------------------------------------------------------
			cards.Add("ICC_244e", new List<Enchantment> {
				// TODO [ICC_244e] Redeemed && Test: Redeemed_ICC_244e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [ICC_858e] Fading Light (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_858e", new List<Enchantment> {
				// TODO [ICC_858e] Fading Light && Test: Fading Light_ICC_858e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t2] Deathlord Nazgrim (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t2", new List<Enchantment> {
				// TODO [ICC_829t2] Deathlord Nazgrim && Test: Deathlord Nazgrim_ICC_829t2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t3] Thoras Trollbane (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t3", new List<Enchantment> {
				// TODO [ICC_829t3] Thoras Trollbane && Test: Thoras Trollbane_ICC_829t3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t4] Inquisitor Whitemane (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t4", new List<Enchantment> {
				// TODO [ICC_829t4] Inquisitor Whitemane && Test: Inquisitor Whitemane_ICC_829t4
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - PALADIN
			// [ICC_829t5] Darion Mograine (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t5", new List<Enchantment> {
				// TODO [ICC_829t5] Darion Mograine && Test: Darion Mograine_ICC_829t5
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- WEAPON - PALADIN
			// [ICC_829t] Grave Vengeance (*) - COST:8 [ATK:5/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_829t", new List<Enchantment> {
				// TODO [ICC_829t] Grave Vengeance && Test: Grave Vengeance_ICC_829t
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [ICC_210] Shadow Ascendant - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       give another random
			//       friendly minion +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_210", new List<Enchantment> {
				// TODO [ICC_210] Shadow Ascendant && Test: Shadow Ascendant_ICC_210
				new Enchantment
				{
					InfoCardId = "ICC_210e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_212", new List<Enchantment> {
				// TODO [ICC_212] Acolyte of Agony && Test: Acolyte of Agony_ICC_212
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------------- MINION - PRIEST
			// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8] 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>. <b>Lifesteal</b>.
			//        <b>Deathrattle:</b> Destroy a
			//        random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_214", new List<Enchantment> {
				// TODO [ICC_214] Obsidian Statue && Test: Obsidian Statue_ICC_214
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_215", new List<Enchantment> {
				// TODO [ICC_215] Archbishop Benedictus && Test: Archbishop Benedictus_ICC_215
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_207] Devour Mind - COST:5 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Copy 3 cards in your opponent's deck and add them to your hand.
			// --------------------------------------------------------
			cards.Add("ICC_207", new List<Enchantment> {
				// TODO [ICC_207] Devour Mind && Test: Devour Mind_ICC_207
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_213] Eternal Servitude - COST:4 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("ICC_213", new List<Enchantment> {
				// TODO [ICC_213] Eternal Servitude && Test: Eternal Servitude_ICC_213
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_235", new List<Enchantment> {
				// TODO [ICC_235] Shadow Essence && Test: Shadow Essence_ICC_235
				new Enchantment
				{
					InfoCardId = "ICC_235e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [ICC_802] Spirit Lash - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $1 damage to_all_minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("ICC_802", new List<Enchantment> {
				// TODO [ICC_802] Spirit Lash && Test: Spirit Lash_ICC_802
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_849", new List<Enchantment> {
				// TODO [ICC_849] Embrace Darkness && Test: Embrace Darkness_ICC_849
				new Enchantment
				{
					InfoCardId = "ICC_849e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [ICC_210e] Ascended (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Stats increased.
			// --------------------------------------------------------
			cards.Add("ICC_210e", new List<Enchantment> {
				// TODO [ICC_210e] Ascended && Test: Ascended_ICC_210e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_065", new List<Enchantment> {
				// TODO [ICC_065] Bone Baron && Test: Bone Baron_ICC_065
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_240", new List<Enchantment> {
				// TODO [ICC_240] Runeforge Haunter && Test: Runeforge Haunter_ICC_240
				new Enchantment
				{
					InfoCardId = "ICC_240e",
					//Activation = null,
					//SingleTask = null,
				}
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
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_809", new List<Enchantment> {
				// TODO [ICC_809] Plague Scientist && Test: Plague Scientist_ICC_809
				new Enchantment
				{
					InfoCardId = "ICC_809e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_811", new List<Enchantment> {
				// TODO [ICC_811] Lilian Voss && Test: Lilian Voss_ICC_811
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_910", new List<Enchantment> {
				// TODO [ICC_910] Spectral Pillager && Test: Spectral Pillager_ICC_910
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_201", new List<Enchantment> {
				// TODO [ICC_201] Roll the Bones && Test: Roll the Bones_ICC_201
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_221", new List<Enchantment> {
				// TODO [ICC_221] Leeching Poison && Test: Leeching Poison_ICC_221
				new Enchantment
				{
					InfoCardId = "ICC_221e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("ICC_233", new List<Enchantment> {
				// TODO [ICC_233] Doomerang && Test: Doomerang_ICC_233
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_850", new List<Enchantment> {
				// TODO [ICC_850] Shadowblade && Test: Shadowblade_ICC_850
				new Enchantment
				{
					InfoCardId = "ICC_850e",
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					InfoCardId = "ICC_850e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_018e] Witty Weaponplay (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_018e", new List<Enchantment> {
				// TODO [ICC_018e] Witty Weaponplay && Test: Witty Weaponplay_ICC_018e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_221e] Leeching Poison (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("ICC_221e", new List<Enchantment> {
				// TODO [ICC_221e] Leeching Poison && Test: Leeching Poison_ICC_221e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_240e] Resilient Weapon (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: No durability loss.
			// --------------------------------------------------------
			cards.Add("ICC_240e", new List<Enchantment> {
				// TODO [ICC_240e] Resilient Weapon && Test: Resilient Weapon_ICC_240e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_809e", new List<Enchantment> {
				// TODO [ICC_809e] Test Subject && Test: Test Subject_ICC_809e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e] Shadow Reflection (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Always copy your last played card.
			// --------------------------------------------------------
			cards.Add("ICC_827e", new List<Enchantment> {
				// TODO [ICC_827e] Shadow Reflection && Test: Shadow Reflection_ICC_827e
				new Enchantment
				{
					InfoCardId = "ICC_827e3",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [ICC_827e3] Veil of Shadows (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b> until your next turn.
			// --------------------------------------------------------
			cards.Add("ICC_827e3", new List<Enchantment> {
				// TODO [ICC_827e3] Veil of Shadows && Test: Veil of Shadows_ICC_827e3
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_850e", new List<Enchantment> {
				// TODO [ICC_850e] Shaded && Test: Shaded_ICC_850e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_827t", new List<Enchantment> {
				// TODO [ICC_827t] Shadow Reflection && Test: Shadow Reflection_ICC_827t
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
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
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_058", new List<Enchantment> {
				// TODO [ICC_058] Brrrloc && Test: Brrrloc_ICC_058
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Overload</b>: (3)
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			cards.Add("ICC_081", new List<Enchantment> {
				// TODO [ICC_081] Drakkari Defender && Test: Drakkari Defender_ICC_081
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_088", new List<Enchantment> {
				// TODO [ICC_088] Voodoo Hexxer && Test: Voodoo Hexxer_ICC_088
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_090", new List<Enchantment> {
				// TODO [ICC_090] Snowfury Giant && Test: Snowfury Giant_ICC_090
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_289", new List<Enchantment> {
				// TODO [ICC_289] Moorabi && Test: Moorabi_ICC_289
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_056] Cryostasis - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Give a minion +3/+3 and <b>Freeze</b> it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("ICC_056", new List<Enchantment> {
				// TODO [ICC_056] Cryostasis && Test: Cryostasis_ICC_056
				new Enchantment
				{
					InfoCardId = "ICC_056e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_078] Avalanche - COST:4 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_078", new List<Enchantment> {
				// TODO [ICC_078] Avalanche && Test: Avalanche_ICC_078
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [ICC_089] Ice Fishing - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 Murlocs from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_089", new List<Enchantment> {
				// TODO [ICC_089] Ice Fishing && Test: Ice Fishing_ICC_089
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("ICC_236", new List<Enchantment> {
				// TODO [ICC_236] Ice Breaker && Test: Ice Breaker_ICC_236
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [ICC_075] Despicable Dreadlord - COST:5 [ATK:4/HP:5] 
			// - Race: demon, Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to all enemy minions.
			// --------------------------------------------------------
			cards.Add("ICC_075", new List<Enchantment> {
				// TODO [ICC_075] Despicable Dreadlord && Test: Despicable Dreadlord_ICC_075
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - WARLOCK
			// [ICC_218] Howlfiend - COST:3 [ATK:3/HP:6] 
			// - Race: demon, Fac: neutral, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, discard a_random card.
			// --------------------------------------------------------
			cards.Add("ICC_218", new List<Enchantment> {
				// TODO [ICC_218] Howlfiend && Test: Howlfiend_ICC_218
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_407", new List<Enchantment> {
				// TODO [ICC_407] Gnomeferatu && Test: Gnomeferatu_ICC_407
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_841", new List<Enchantment> {
				// TODO [ICC_841] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_ICC_841
				new Enchantment
				{
					InfoCardId = "ICC_841e",
					//Activation = null,
					//SingleTask = null,
				}
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("ICC_903", new List<Enchantment> {
				// TODO [ICC_903] Sanguine Reveler && Test: Sanguine Reveler_ICC_903
				new Enchantment
				{
					InfoCardId = "ICC_903t",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_041] Defile - COST:2 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $1 damage to all minions. If any die, cast this again. *spelldmg
			// --------------------------------------------------------
			cards.Add("ICC_041", new List<Enchantment> {
				// TODO [ICC_041] Defile && Test: Defile_ICC_041
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_055] Drain Soul - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			//       Deal $2 damage
			//       to a minion. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_055", new List<Enchantment> {
				// TODO [ICC_055] Drain Soul && Test: Drain Soul_ICC_055
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_206] Treachery - COST:3 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Choose a friendly minion and give it to_your opponent.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_206", new List<Enchantment> {
				// TODO [ICC_206] Treachery && Test: Treachery_ICC_206
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICC_469] Unwilling Sacrifice - COST:3 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Choose a friendly minion. Destroy it and a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_469", new List<Enchantment> {
				// TODO [ICC_469] Unwilling Sacrifice && Test: Unwilling Sacrifice_ICC_469
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
			// [ICCA05_020] Bite of the Blood-Queen (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Turn a hero into a Vampire.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("ICCA05_020", new List<Enchantment> {
				// TODO [ICCA05_020] Bite of the Blood-Queen && Test: Bite of the Blood-Queen_ICCA05_020
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [ICCA05_021] Blood Essence (*) - COST:1 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Transform 2 random minions in your opponent's hand into spells.
			// --------------------------------------------------------
			cards.Add("ICCA05_021", new List<Enchantment> {
				// TODO [ICCA05_021] Blood Essence && Test: Blood Essence_ICCA05_021
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
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
			// --------------------------------------------------------
			cards.Add("ICC_062", new List<Enchantment> {
				// TODO [ICC_062] Mountainfire Armor && Test: Mountainfire Armor_ICC_062
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_238] Animated Berserker - COST:1 [ATK:1/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: After you play a minion, deal 1 damage to it.
			// --------------------------------------------------------
			cards.Add("ICC_238", new List<Enchantment> {
				// TODO [ICC_238] Animated Berserker && Test: Animated Berserker_ICC_238
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_405] Rotface - COST:8 [ATK:4/HP:6] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       survives damage,
			//       summon a random
			//       <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICC_405", new List<Enchantment> {
				// TODO [ICC_405] Rotface && Test: Rotface_ICC_405
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - WARRIOR
			// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Whenever this minion
			//       survives damage,
			//       summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_408", new List<Enchantment> {
				// TODO [ICC_408] Val'kyr Soulclaimer && Test: Val'kyr Soulclaimer_ICC_408
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_450", new List<Enchantment> {
				// TODO [ICC_450] Death Revenant && Test: Death Revenant_ICC_450
				new Enchantment
				{
					InfoCardId = "ICC_450e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_091] Dead Man's Hand - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle a copy of your hand into your deck.
			// --------------------------------------------------------
			cards.Add("ICC_091", new List<Enchantment> {
				// TODO [ICC_091] Dead Man's Hand && Test: Dead Man's Hand_ICC_091
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_281] Forge of Souls - COST:2 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Draw 2 weapons from your deck.
			// --------------------------------------------------------
			cards.Add("ICC_281", new List<Enchantment> {
				// TODO [ICC_281] Forge of Souls && Test: Forge of Souls_ICC_281
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [ICC_837] Bring It On! - COST:2 
			// - Set: icecrown, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837", new List<Enchantment> {
				// TODO [ICC_837] Bring It On! && Test: Bring It On!_ICC_837
				new Enchantment
				{
					InfoCardId = "ICC_837e",
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b>
			//       Deal 1 damage to all minions.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("ICC_064", new List<Enchantment> {
				// TODO [ICC_064] Blood Razor && Test: Blood Razor_ICC_064
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- WEAPON - WARRIOR
			// [ICC_834w] Shadowmourne (*) - COST:8 [ATK:4/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever your hero attacks.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("ICC_834w", new List<Enchantment> {
				// TODO [ICC_834w] Shadowmourne && Test: Shadowmourne_ICC_834w
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
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
			cards.Add("ICC_018", new List<Enchantment> {
				// TODO [ICC_018] Phantom Freebooter && Test: Phantom Freebooter_ICC_018
				new Enchantment
				{
					InfoCardId = "ICC_018e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_019", new List<Enchantment> {
				// TODO [ICC_019] Skelemancer && Test: Skelemancer_ICC_019
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_023] Snowflipper Penguin - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			cards.Add("ICC_023", new List<Enchantment> {
				// TODO [ICC_023] Snowflipper Penguin && Test: Snowflipper Penguin_ICC_023
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_025", new List<Enchantment> {
				// TODO [ICC_025] Rattling Rascal && Test: Rattling Rascal_ICC_025
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_026", new List<Enchantment> {
				// TODO [ICC_026] Grim Necromancer && Test: Grim Necromancer_ICC_026
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_027", new List<Enchantment> {
				// TODO [ICC_027] Bone Drake && Test: Bone Drake_ICC_027
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_028", new List<Enchantment> {
				// TODO [ICC_028] Sunborne Val'kyr && Test: Sunborne Val'kyr_ICC_028
				new Enchantment
				{
					InfoCardId = "ICC_028e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_029] Cobalt Scalebane - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give another random friendly minion +3 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_029", new List<Enchantment> {
				// TODO [ICC_029] Cobalt Scalebane && Test: Cobalt Scalebane_ICC_029
				new Enchantment
				{
					InfoCardId = "ICC_029e",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_031] Night Howler - COST:4 [ATK:3/HP:4] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion takes
			//       damage, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031", new List<Enchantment> {
				// TODO [ICC_031] Night Howler && Test: Night Howler_ICC_031
				new Enchantment
				{
					InfoCardId = "ICC_031e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_032", new List<Enchantment> {
				// TODO [ICC_032] Venomancer && Test: Venomancer_ICC_032
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			// --------------------------------------------------------
			cards.Add("ICC_067", new List<Enchantment> {
				// TODO [ICC_067] Vryghoul && Test: Vryghoul_ICC_067
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("ICC_092", new List<Enchantment> {
				// TODO [ICC_092] Acherus Veteran && Test: Acherus Veteran_ICC_092
				new Enchantment
				{
					InfoCardId = "ICC_092e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("ICC_093", new List<Enchantment> {
				// TODO [ICC_093] Tuskarr Fisherman && Test: Tuskarr Fisherman_ICC_093
				new Enchantment
				{
					InfoCardId = "ICC_093e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("ICC_094", new List<Enchantment> {
				// TODO [ICC_094] Fallen Sun Cleric && Test: Fallen Sun Cleric_ICC_094
				new Enchantment
				{
					InfoCardId = "ICC_094e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_096", new List<Enchantment> {
				// TODO [ICC_096] Furnacefire Colossus && Test: Furnacefire Colossus_ICC_096
				new Enchantment
				{
					InfoCardId = "ICC_096e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_097] Grave Shambler - COST:4 [ATK:4/HP:4] 
			// - Race: elemental, Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your weapon is destroyed, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_097", new List<Enchantment> {
				// TODO [ICC_097] Grave Shambler && Test: Grave Shambler_ICC_097
				new Enchantment
				{
					InfoCardId = "ICC_097e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_098", new List<Enchantment> {
				// TODO [ICC_098] Tomb Lurker && Test: Tomb Lurker_ICC_098
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_099", new List<Enchantment> {
				// TODO [ICC_099] Ticking Abomination && Test: Ticking Abomination_ICC_099
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_220", new List<Enchantment> {
				// TODO [ICC_220] Deadscale Knight && Test: Deadscale Knight_ICC_220
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICC_257", new List<Enchantment> {
				// TODO [ICC_257] Corpse Raiser && Test: Corpse Raiser_ICC_257
				new Enchantment
				{
					InfoCardId = "ICC_257e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_314", new List<Enchantment> {
				// TODO [ICC_314] The Lich King && Test: The Lich King_ICC_314
				new Enchantment
				{
					InfoCardId = "ICC_314t1e",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_466", new List<Enchantment> {
				// TODO [ICC_466] Saronite Chain Gang && Test: Saronite Chain Gang_ICC_466
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("ICC_467", new List<Enchantment> {
				// TODO [ICC_467] Deathspeaker && Test: Deathspeaker_ICC_467
				new Enchantment
				{
					InfoCardId = "ICC_467e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_468] Wretched Tiller - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, deal 2 damage to_the enemy hero.
			// --------------------------------------------------------
			cards.Add("ICC_468", new List<Enchantment> {
				// TODO [ICC_468] Wretched Tiller && Test: Wretched Tiller_ICC_468
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_700] Happy Ghoul - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Costs (0) if your hero was healed this turn.
			// --------------------------------------------------------
			cards.Add("ICC_700", new List<Enchantment> {
				// TODO [ICC_700] Happy Ghoul && Test: Happy Ghoul_ICC_700
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_701", new List<Enchantment> {
				// TODO [ICC_701] Skulking Geist && Test: Skulking Geist_ICC_701
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_702", new List<Enchantment> {
				// TODO [ICC_702] Shallow Gravedigger && Test: Shallow Gravedigger_ICC_702
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_705] Bonemare - COST:7 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICC_705", new List<Enchantment> {
				// TODO [ICC_705] Bonemare && Test: Bonemare_ICC_705
				new Enchantment
				{
					InfoCardId = "ICC_705e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_706", new List<Enchantment> {
				// TODO [ICC_706] Nerubian Unraveler && Test: Nerubian Unraveler_ICC_706
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_810", new List<Enchantment> {
				// TODO [ICC_810] Deathaxe Punisher && Test: Deathaxe Punisher_ICC_810
				new Enchantment
				{
					InfoCardId = "ICC_810e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_812", new List<Enchantment> {
				// TODO [ICC_812] Meat Wagon && Test: Meat Wagon_ICC_812
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_851", new List<Enchantment> {
				// TODO [ICC_851] Prince Keleseth && Test: Prince Keleseth_ICC_851
				new Enchantment
				{
					InfoCardId = "ICC_851e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - REQ_DRAG_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("ICC_852", new List<Enchantment> {
				// TODO [ICC_852] Prince Taldaram && Test: Prince Taldaram_ICC_852
				new Enchantment
				{
					InfoCardId = "ICC_852e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_853", new List<Enchantment> {
				// TODO [ICC_853] Prince Valanar && Test: Prince Valanar_ICC_853
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_854", new List<Enchantment> {
				// TODO [ICC_854] Arfus && Test: Arfus_ICC_854
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
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
			cards.Add("ICC_855", new List<Enchantment> {
				// TODO [ICC_855] Hyldnir Frostrider && Test: Hyldnir Frostrider_ICC_855
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_856", new List<Enchantment> {
				// TODO [ICC_856] Spellweaver && Test: Spellweaver_ICC_856
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900] Necrotic Geist - COST:6 [ATK:5/HP:3] 
			// - Set: icecrown, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever one of your other minions dies, summon a 2/2 Ghoul.
			// --------------------------------------------------------
			cards.Add("ICC_900", new List<Enchantment> {
				// TODO [ICC_900] Necrotic Geist && Test: Necrotic Geist_ICC_900
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_901", new List<Enchantment> {
				// TODO [ICC_901] Drakkari Enchanter && Test: Drakkari Enchanter_ICC_901
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_902] Mindbreaker - COST:3 [ATK:2/HP:5] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Hero Powers are disabled.
			// --------------------------------------------------------
			cards.Add("ICC_902", new List<Enchantment> {
				// TODO [ICC_902] Mindbreaker && Test: Mindbreaker_ICC_902
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_904", new List<Enchantment> {
				// TODO [ICC_904] Wicked Skeleton && Test: Wicked Skeleton_ICC_904
				new Enchantment
				{
					InfoCardId = "ICC_904e",
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_905", new List<Enchantment> {
				// TODO [ICC_905] Bloodworm && Test: Bloodworm_ICC_905
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_911] Keening Banshee - COST:4 [ATK:5/HP:5] 
			// - Set: icecrown, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you play a card, remove the top 3 cards of_your deck.
			// --------------------------------------------------------
			cards.Add("ICC_911", new List<Enchantment> {
				// TODO [ICC_911] Keening Banshee && Test: Keening Banshee_ICC_911
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_912", new List<Enchantment> {
				// TODO [ICC_912] Corpsetaker && Test: Corpsetaker_ICC_912
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("ICC_913", new List<Enchantment> {
				// TODO [ICC_913] Tainted Zealot && Test: Tainted Zealot_ICC_913
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_028e] Blessing of the Val'kyr (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2 Health.
			// --------------------------------------------------------
			cards.Add("ICC_028e", new List<Enchantment> {
				// TODO [ICC_028e] Blessing of the Val'kyr && Test: Blessing of the Val'kyr_ICC_028e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_029e] Dragonscales (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Attack increased.
			// --------------------------------------------------------
			cards.Add("ICC_029e", new List<Enchantment> {
				// TODO [ICC_029e] Dragonscales && Test: Dragonscales_ICC_029e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_031e] Awooooo! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: This minion has increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_031e", new List<Enchantment> {
				// TODO [ICC_031e] Awooooo! && Test: Awooooo!_ICC_031e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_039e] Convinced (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Stats changed to 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_039e", new List<Enchantment> {
				// TODO [ICC_039e] Convinced && Test: Convinced_ICC_039e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_049e] Toxic Arrow (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Poisonous.
			// --------------------------------------------------------
			cards.Add("ICC_049e", new List<Enchantment> {
				// TODO [ICC_049e] Toxic Arrow && Test: Toxic Arrow_ICC_049e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_056e] Frozen Blood (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			cards.Add("ICC_056e", new List<Enchantment> {
				// TODO [ICC_056e] Frozen Blood && Test: Frozen Blood_ICC_056e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_092e] Veteran's Favor (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("ICC_092e", new List<Enchantment> {
				// TODO [ICC_092e] Veteran's Favor && Test: Veteran's Favor_ICC_092e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_093e] Fresh Fish! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>.
			// --------------------------------------------------------
			cards.Add("ICC_093e", new List<Enchantment> {
				// TODO [ICC_093e] Fresh Fish! && Test: Fresh Fish!_ICC_093e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_094e] Cleric's Blessing (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_094e", new List<Enchantment> {
				// TODO [ICC_094e] Cleric's Blessing && Test: Cleric's Blessing_ICC_094e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_096e] Me Bigger (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_096e", new List<Enchantment> {
				// TODO [ICC_096e] Me Bigger && Test: Me Bigger_ICC_096e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_097e] Armed and Dangerous (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_097e", new List<Enchantment> {
				// TODO [ICC_097e] Armed and Dangerous && Test: Armed and Dangerous_ICC_097e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_235e] Shadow Essence (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Attack and Health set to 5.
			// --------------------------------------------------------
			cards.Add("ICC_235e", new List<Enchantment> {
				// TODO [ICC_235e] Shadow Essence && Test: Shadow Essence_ICC_235e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_257e] Ready to Return (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion.
			// --------------------------------------------------------
			cards.Add("ICC_257e", new List<Enchantment> {
				// TODO [ICC_257e] Ready to Return && Test: Ready to Return_ICC_257e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_314t1e] Trapped Soul (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: {0}
			// --------------------------------------------------------
			cards.Add("ICC_314t1e", new List<Enchantment> {
				// TODO [ICC_314t1e] Trapped Soul && Test: Trapped Soul_ICC_314t1e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_314t7e", new List<Enchantment> {
				// TODO [ICC_314t7e] Anti-Magic Shell && Test: Anti-Magic Shell_ICC_314t7e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_450e] Bloodthirsty (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_450e", new List<Enchantment> {
				// TODO [ICC_450e] Bloodthirsty && Test: Bloodthirsty_ICC_450e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_467e", new List<Enchantment> {
				// TODO [ICC_467e] Deathward && Test: Deathward_ICC_467e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_483e] Frostmourne Enchantment (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_483e", new List<Enchantment> {
				// TODO [ICC_483e] Frostmourne Enchantment && Test: Frostmourne Enchantment_ICC_483e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_705e] Bonemare's Boon (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +4/+4 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("ICC_705e", new List<Enchantment> {
				// TODO [ICC_705e] Bonemare's Boon && Test: Bonemare's Boon_ICC_705e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_807e] Strongshell (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("ICC_807e", new List<Enchantment> {
				// TODO [ICC_807e] Strongshell && Test: Strongshell_ICC_807e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_810e] Bloodthirsty (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2 from Deathaxe Punisher.
			// --------------------------------------------------------
			cards.Add("ICC_810e", new List<Enchantment> {
				// TODO [ICC_810e] Bloodthirsty && Test: Bloodthirsty_ICC_810e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_832e", new List<Enchantment> {
				// TODO [ICC_832e] Fangs && Test: Fangs_ICC_832e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_833e", new List<Enchantment> {
				// TODO [ICC_833e] Frost Lich && Test: Frost Lich_ICC_833e
				new Enchantment
				{
					InfoCardId = "ICC_833e2",
					//Activation = null,
					//SingleTask = null,
				}
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
			cards.Add("ICC_833e2", new List<Enchantment> {
				// TODO [ICC_833e2] Icy Veins && Test: Icy Veins_ICC_833e2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_837e] Challenged (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Minion cost reduced by (2).
			// --------------------------------------------------------
			cards.Add("ICC_837e", new List<Enchantment> {
				// TODO [ICC_837e] Challenged && Test: Challenged_ICC_837e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_841e] Vampiric Bite (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("ICC_841e", new List<Enchantment> {
				// TODO [ICC_841e] Vampiric Bite && Test: Vampiric Bite_ICC_841e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_849e] Embraced (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of the next turn, lose control of this minion.
			// --------------------------------------------------------
			cards.Add("ICC_849e", new List<Enchantment> {
				// TODO [ICC_849e] Embraced && Test: Embraced_ICC_849e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_851e] Keleseth's Blessing (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			cards.Add("ICC_851e", new List<Enchantment> {
				// TODO [ICC_851e] Keleseth's Blessing && Test: Keleseth's Blessing_ICC_851e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_852e] Taldaram's Visage (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: 3/3.
			// --------------------------------------------------------
			cards.Add("ICC_852e", new List<Enchantment> {
				// TODO [ICC_852e] Taldaram's Visage && Test: Taldaram's Visage_ICC_852e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_903t] Bloodthirst (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_903t", new List<Enchantment> {
				// TODO [ICC_903t] Bloodthirst && Test: Bloodthirst_ICC_903t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICC_904e] Extra Calcium (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("ICC_904e", new List<Enchantment> {
				// TODO [ICC_904e] Extra Calcium && Test: Extra Calcium_ICC_904e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICCA05_002e] Bitten! (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: +2/+2. Can't be bitten again.
			// --------------------------------------------------------
			cards.Add("ICCA05_002e", new List<Enchantment> {
				// TODO [ICCA05_002e] Bitten! && Test: Bitten!_ICCA05_002e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICCA07_004e] Grow (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: The ooze is growing.
			// --------------------------------------------------------
			cards.Add("ICCA07_004e", new List<Enchantment> {
				// TODO [ICCA07_004e] Grow && Test: Grow_ICCA07_004e
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICCA08_022e] Join the Ranks Player Enchantment (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA08_022e", new List<Enchantment> {
				// TODO [ICCA08_022e] Join the Ranks Player Enchantment && Test: Join the Ranks Player Enchantment_ICCA08_022e
				new Enchantment
				{
					InfoCardId = "ICCA08_022e2",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [ICCA08_022e2] Join the Ranks (*) - COST:0 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: When this dies, resummon it for your oponent.
			// --------------------------------------------------------
			cards.Add("ICCA08_022e2", new List<Enchantment> {
				// TODO [ICCA08_022e2] Join the Ranks && Test: Join the Ranks_ICCA08_022e2
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_019t] Skeletal Flayer (*) - COST:8 [ATK:8/HP:8] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_019t", new List<Enchantment> {
				// TODO [ICC_019t] Skeletal Flayer && Test: Skeletal Flayer_ICC_019t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_025t] Skeletal Enforcer (*) - COST:5 [ATK:5/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_025t", new List<Enchantment> {
				// TODO [ICC_025t] Skeletal Enforcer && Test: Skeletal Enforcer_ICC_025t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_026t] Skeleton (*) - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_026t", new List<Enchantment> {
				// TODO [ICC_026t] Skeleton && Test: Skeleton_ICC_026t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_800h3t] Zombeast (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			cards.Add("ICC_800h3t", new List<Enchantment> {
				// TODO [ICC_800h3t] Zombeast && Test: Zombeast_ICC_800h3t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_900t] Ghoul (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICC_900t", new List<Enchantment> {
				// TODO [ICC_900t] Ghoul && Test: Ghoul_ICC_900t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_004t] Ghoul (*) - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("ICCA01_004t", new List<Enchantment> {
				// TODO [ICCA01_004t] Ghoul && Test: Ghoul_ICCA01_004t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_007] Eager Rogue (*) - COST:1 [ATK:3/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deals no damage while attacking.
			// --------------------------------------------------------
			cards.Add("ICCA01_007", new List<Enchantment> {
				// TODO [ICCA01_007] Eager Rogue && Test: Eager Rogue_ICCA01_007
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_008] Terrible Tank (*) - COST:2 [ATK:2/HP:3] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA01_008", new List<Enchantment> {
				// TODO [ICCA01_008] Terrible Tank && Test: Terrible Tank_ICCA01_008
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_009] Needy Hunter (*) - COST:3 [ATK:3/HP:3] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Whenever this minion attacks, add a Coin to your hand.
			// --------------------------------------------------------
			cards.Add("ICCA01_009", new List<Enchantment> {
				// TODO [ICCA01_009] Needy Hunter && Test: Needy Hunter_ICCA01_009
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_010] A. F. Kay (*) - COST:4 [ATK:5/HP:2] 
			// - Set: icecrown, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("ICCA01_010", new List<Enchantment> {
				// TODO [ICCA01_010] A. F. Kay && Test: A. F. Kay_ICCA01_010
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA01_011] Warlock on Fire (*) - COST:5 [ATK:7/HP:1] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to this minion.
			// --------------------------------------------------------
			cards.Add("ICCA01_011", new List<Enchantment> {
				// TODO [ICCA01_011] Warlock on Fire && Test: Warlock on Fire_ICCA01_011
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA04_004] Block of Ice (*) - COST:3 [ATK:0/HP:7] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("ICCA04_004", new List<Enchantment> {
				// TODO [ICCA04_004] Block of Ice && Test: Block of Ice_ICCA04_004
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA05_003] Sleeping Acolyte (*) - COST:1 [ATK:0/HP:10] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA05_003", new List<Enchantment> {
				// TODO [ICCA05_003] Sleeping Acolyte && Test: Sleeping Acolyte_ICCA05_003
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA06_005] Bone Spike (*) - COST:4 [ATK:0/HP:8] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 15 damage to the enemy hero.
			// --------------------------------------------------------
			cards.Add("ICCA06_005", new List<Enchantment> {
				// TODO [ICCA06_005] Bone Spike && Test: Bone Spike_ICCA06_005
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA07_004] Growing Ooze (*) - COST:1 [ATK:1/HP:1] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of your turn, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("ICCA07_004", new List<Enchantment> {
				// TODO [ICCA07_004] Growing Ooze && Test: Growing Ooze_ICCA07_004
				new Enchantment
				{
					InfoCardId = "ICCA07_004e",
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA07_008] Festergut (*) - COST:4 [ATK:3/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 3 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("ICCA07_008", new List<Enchantment> {
				// TODO [ICCA07_008] Festergut && Test: Festergut_ICCA07_008
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA08_002t] Ghoul (*) - COST:2 [ATK:2/HP:2] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA08_002t", new List<Enchantment> {
				// TODO [ICCA08_002t] Ghoul && Test: Ghoul_ICCA08_002t
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA08_017] Val'kyr Shadowguard (*) - COST:3 [ATK:0/HP:5] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy a random enemy minion and this one.
			// --------------------------------------------------------
			cards.Add("ICCA08_017", new List<Enchantment> {
				// TODO [ICCA08_017] Val'kyr Shadowguard && Test: Val'kyr Shadowguard_ICCA08_017
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA08_033] Trapped Soul (*) - COST:3 [ATK:2/HP:6] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			cards.Add("ICCA08_033", new List<Enchantment> {
				// TODO [ICCA08_033] Trapped Soul && Test: Trapped Soul_ICCA08_033
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA09_001t1] Blood Beast (*) - COST:3 [ATK:2/HP:4] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: At the start of your turn, restore 3 Health to your hero.
			// --------------------------------------------------------
			cards.Add("ICCA09_001t1", new List<Enchantment> {
				// TODO [ICCA09_001t1] Blood Beast && Test: Blood Beast_ICCA09_001t1
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA10_001] Valithria Dreamwalker (*) - COST:5 [ATK:30/HP:5] 
			// - Race: dragon, Set: icecrown, 
			// --------------------------------------------------------
			// Text: Can't attack or be attacked while damaged.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HERO_POWER = 45289
			// --------------------------------------------------------
			// RefTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("ICCA10_001", new List<Enchantment> {
				// TODO [ICCA10_001] Valithria Dreamwalker && Test: Valithria Dreamwalker_ICCA10_001
				new Enchantment
				{
					//Activation = null,
					//SingleTask = null,
				}
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICCA11_001] Skeletal Knight (*) - COST:1 [ATK:2/HP:3] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a
			//        <b>Knights of the Frozen Throne</b> card to your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("ICCA11_001", new List<Enchantment> {
				// TODO [ICCA11_001] Skeletal Knight && Test: Skeletal Knight_ICCA11_001
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [ICCA06_004] Bone Storm (*) - COST:2 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: Deal $1 damage to all enemies. Draw a card. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("ICCA06_004", new List<Enchantment> {
				// TODO [ICCA06_004] Bone Storm && Test: Bone Storm_ICCA06_004
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [ICCA06_003] Bryn'troll, the Bone Arbiter (*) - COST:6 [ATK:3/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 6
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("ICCA06_003", new List<Enchantment> {
				// TODO [ICCA06_003] Bryn'troll, the Bone Arbiter && Test: Bryn'troll, the Bone Arbiter_ICCA06_003
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [ICCA07_020] Tentacles (*) - COST:6 [ATK:3/HP:0] 
			// - Set: icecrown, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 6
			// --------------------------------------------------------
			cards.Add("ICCA07_020", new List<Enchantment> {
				// TODO [ICCA07_020] Tentacles && Test: Tentacles_ICCA07_020
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
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
