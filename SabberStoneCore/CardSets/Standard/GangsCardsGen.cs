using System.Collections.Generic;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Standard
{
	public class GangsCardsGen
	{
		private static void Druid(IDictionary<string, List<Enchantment>> cards)
		{
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
			cards.Add("CFM_602",
                //CHOOSE_ONE
                null);

			// ------------------------------------------ SPELL - DRUID
			// [CFM_614] Mark of the Lotus - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_614", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.MINIONS)
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_616] Pilfered Power - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Gain an empty Mana Crystal for each friendly minion.
			// --------------------------------------------------------
			cards.Add("CFM_616", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        ComplexTask.ExcessManaCheck,
                        new CountTask(EntityType.MINIONS),
                        new ManaCrystalEmptyTask(0, false, true))
                },
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_713] Jade Blossom - COST:3 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_713", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        ComplexTask.SummonJadeGolem(),
                        new ManaCrystalEmptyTask(1))
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_811] Lunar Visions - COST:5 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Draw 2 cards. Minions drawn cost (2) less.
			// --------------------------------------------------------
			cards.Add("CFM_811", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(2, ComplexTask.Create(
                        new DrawTask(true),
                        new BuffTask(Buffs.Cost(-2), EntityType.STACK)))
				},
			});

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
			cards.Add("CFM_308",
                //CHOOSE_ONE
                null);

            // ----------------------------------------- MINION - DRUID
            // [CFM_343] Jade Behemoth - COST:6 [ATK:3/HP:6] 
            // - Set: gangs, Rarity: common
            // --------------------------------------------------------
            // Text: [x]<b>Taunt</b>
            //       <b>Battlecry:</b> Summon a{1}
            //       {0} <b>Jade Golem</b>.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_343", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.SummonJadeGolem(),
				}
			});

			// ----------------------------------------- MINION - DRUID
			// [CFM_617] Celestial Dreamer - COST:3 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If a friendly minion has 5 or more Attack, gain +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_617", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.HasBoardMinion(GameTag.ATK, 5, RelaSign.GEQ)),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(2), EntityType.SOURCE))),
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 20
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_816", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.AttackHealth(2), EntityType.TARGET)
				},
			});

		}

		private static void DruidNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [CFM_308a] Forgotten Armor (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			cards.Add("CFM_308a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new ArmorTask(10)
				}
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_308b] Forgotten Mana (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Refresh your Mana Crystals.
			// --------------------------------------------------------
			cards.Add("CFM_308b", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new SetControllerGameTagTask(GameTag.RESOURCES_USED, 0)
				},
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
			cards.Add("CFM_602a", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.SummonJadeGolem()
				},
			});

			// ------------------------------------------ SPELL - DRUID
			// [CFM_602b] Jade Idol (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Shuffle 3 Jade Idols into your deck.
			// --------------------------------------------------------
			cards.Add("CFM_602b", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(3, new AddCardTo("CFM_602", EntityType.DECK))
				},
			});

		}

		private static void Hunter(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - HUNTER
			// [CFM_026] Hidden Cache - COST:2 
			// - Fac: neutral, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("CFM_026", new List<Enchantment> {
				new Enchantment
				{
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(ComplexTask.Secret(
                            ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(2), SelfCondition.IsMinion)))
                        .Build()
                },
			});

			// ----------------------------------------- SPELL - HUNTER
			// [CFM_334] Smuggler's Crate - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give a random Beast in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_334", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(2), SelfCondition.IsRace(Race.BEAST))
				},
			});

			// ---------------------------------------- MINION - HUNTER
			// [CFM_315] Alleycat - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 1/1_Cat.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_315", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new SummonTask("CFM_315t")
				},
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
			cards.Add("CFM_316", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
                        new EnqueueNumberTask(new SummonTask("CFM_316t")))
				},
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
			cards.Add("CFM_333", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.ATTACKING, -1)
                        .SingleTask(ComplexTask.Create(
                            new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsProposedDefender(CardType.MINION)),
                            new FlagTask(true, ComplexTask.Create(
                                new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
                                new DamageNumberTask(EntityType.OP_HERO)))))
                        .Build()
                }
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
			cards.Add("CFM_335", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
                        new DamageNumberTask(EntityType.TARGET))
                },
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
			cards.Add("CFM_336", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(2), new SelfCondition[]{ }),
				},
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
			cards.Add("CFM_338", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(1), SelfCondition.IsRace(Race.BEAST))
                },
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
			cards.Add("CFM_337", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.WEAPON,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsThisWeaponEquiped)
                        .TriggerEffect(GameTag.ATTACKING, -1)
                        .SingleTask(new SummonTask("CFM_337t"))
                        .Build()
                }
            });

		}

		private static void HunterNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_026e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2 from Hidden Cache.
			// --------------------------------------------------------
			cards.Add("CFM_026e", null);

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [CFM_338e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Trogg Beastrager.
			// --------------------------------------------------------
			cards.Add("CFM_338e", null);

            // ---------------------------------------- MINION - HUNTER
            // [CFM_315t] Tabbycat (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_315t", null);

			// ---------------------------------------- MINION - HUNTER
			// [CFM_316t] Rat (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_316t", null);

            // ---------------------------------------- MINION - HUNTER
            // [CFM_337t] Piranha (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_337t", null);

        }

		private static void Mage(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [CFM_021] Freezing Potion - COST:0 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> an enemy.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_021", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Freeze(EntityType.TARGET)
				},
			});

			// ------------------------------------------- SPELL - MAGE
			// [CFM_065] Volcanic Potion - COST:3 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to all_minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_065", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(2, EntityType.ALLMINIONS, true)
				},
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
			cards.Add("CFM_620", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_BOARD,
                    Activation = EnchantmentActivation.SECRET,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsSecretActive)
                        .TriggerEffect(GameTag.JUST_PLAYED, -1)
                        .SingleTask(ComplexTask.Secret(
                            new TransformTask("CFM_621_m5", EntityType.TARGET)))
                        .Build()
                },
            });

			// ------------------------------------------- SPELL - MAGE
			// [CFM_623] Greater Arcane Missiles - COST:7 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Shoot three missiles at random enemies that deal $3 damage each. *spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_623", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, ComplexTask.DamageRandomTargets(1, EntityType.ENEMIES, 3), true)
                },
			});

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
			cards.Add("CFM_066", new List<Enchantment> {
				// TODO [CFM_066] Kabal Lackey && Test: Kabal Lackey_CFM_066
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_660", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new CopyTask(EntityType.TARGET, 1),
                        new AddStackTo(EntityType.DECK))
				},
			});

			// ------------------------------------------ MINION - MAGE
			// [CFM_671] Cryomancer - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain +2/+2
			//       if an enemy is <b>Frozen</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("CFM_671", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.HasOpBoardMinion(GameTag.FROZEN, 1)),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(2), EntityType.SOURCE))),
                }
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
			cards.Add("CFM_687", new List<Enchantment> {
				// TODO [CFM_687] Inkmaster Solia && Test: Inkmaster Solia_CFM_687
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_760", new List<Enchantment> {
				// TODO [CFM_760] Kabal Crystal Runner && Test: Kabal Crystal Runner_CFM_760
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void MageNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [CFM_687e] Free Spell (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: The next spell you cast this turn costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CFM_687e", null);

        }

		private static void Paladin(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - PALADIN
			// [CFM_305] Smuggler's Run - COST:1 
			// - Fac: neutral, Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_305", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.HAND, SelfCondition.IsMinion)
				}
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
			cards.Add("CFM_800", new List<Enchantment> {
				// TODO [CFM_800] Getaway Kodo && Test: Getaway Kodo_CFM_800
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - PALADIN
			// [CFM_905] Small-Time Recruits - COST:3 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Draw three 1-Cost
			//       minions from your deck.
			// --------------------------------------------------------
			cards.Add("CFM_905", new List<Enchantment> {
				new Enchantment
				{
                    // TODO check if this is an ordinary Draw ... ???
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(3, ComplexTask.DrawFromDeck(SelfCondition.IsTagValue(GameTag.COST, 1), SelfCondition.IsMinion))
				},
			});

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
			cards.Add("CFM_062", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(EntityType.SOURCE, RelaCondition.IsSideBySide),
                        new SetGameTagTask(GameTag.DIVINE_SHIELD, 1, EntityType.STACK))
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_639] Grimestreet Enforcer - COST:5 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, give all minions in your hand +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_639", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.HAND),
                            new FilterStackTask(SelfCondition.IsMinion),
                            new BuffTask(Buffs.AttackHealth(1), EntityType.STACK)))
                        .Build()
                }
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
			cards.Add("CFM_650", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(1), RelaCondition.IsSameRace)
				},
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
			cards.Add("CFM_753", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.AttackHealth(1), EntityType.HAND, SelfCondition.IsMinion)
				}
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
			cards.Add("CFM_759", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsTagValue(GameTag.ATK, 2, RelaSign.GEQ)),
                        new FlagTask(true, new DrawTask()))
				},
			});

			// --------------------------------------- MINION - PALADIN
			// [CFM_815] Wickerflame Burnbristle - COST:3 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>. <b>Taunt</b>.
			//       Damage dealt by this minion
			//       also heals your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("CFM_815", new List<Enchantment> {
				// TODO [CFM_815] Wickerflame Burnbristle && Test: Wickerflame Burnbristle_CFM_815
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void PaladinNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [CFM_305e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1/+1 from Smuggler's Run.
			// --------------------------------------------------------
			cards.Add("CFM_305e", null);

		}

		private static void Priest(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - PRIEST
			// [CFM_603] Potion of Madness - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Gain control of an enemy minion with 2 or less Attack until end of turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// - REQ_TARGET_MAX_ATTACK = 2
			// --------------------------------------------------------
			cards.Add("CFM_603", new List<Enchantment> {
				// TODO [CFM_603] Potion of Madness && Test: Potion of Madness_CFM_603
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_604] Greater Healing Potion - COST:4 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Restore 12 Health to a friendly character.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_604", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new HealTask(12, EntityType.TARGET)
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_661] Pint-Size Potion - COST:1 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]Give all enemy minions
			//       -3 Attack this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_661", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.AttackTurn(-3), EntityType.OP_MINIONS),
				},
			});

			// ----------------------------------------- SPELL - PRIEST
			// [CFM_662] Dragonfire Potion - COST:6 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Deal $5 damage to all
			//       minions except Dragons. *spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_662", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.ALLMINIONS),
                        new FilterStackTask(SelfCondition.IsNotRace(Race.DRAGON)),
                        new DamageTask(5, EntityType.STACK, true))
				},
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_020] Raza the Chained - COST:5 [ATK:5/HP:5] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]  <b>Battlecry:</b> If your deck has  
			//       no duplicates, your Hero
			//        Power costs (0) this game.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_020", new List<Enchantment> {
				// TODO [CFM_020] Raza the Chained && Test: Raza the Chained_CFM_020
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("CFM_605", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsDragonInHand),
                        new FlagTask(true, new DiscoverTask(DiscoverType.OP_DECK)))
                },
			});

			// ---------------------------------------- MINION - PRIEST
			// [CFM_606] Mana Geode - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this minion is_healed, summon a 2/2_Crystal.
			// --------------------------------------------------------
			cards.Add("CFM_606", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(
                            SelfCondition.IsNotDead,
                            SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.DAMAGE, -1)
                        .SingleTask(new SummonTask("CFM_606t"))
                        .Build()
                }
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_626", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.Health(3), EntityType.TARGET)
				},
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
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_657", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new SilenceTask(EntityType.TARGET)
				},
			});

		}

		private static void PriestNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_603e] Madness Potion (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: This minion has switched controllers this turn.
			// --------------------------------------------------------
			cards.Add("CFM_603e", null);

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [CFM_661e] Shrunk (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: -3 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - OneTurnEffect = 1
			// --------------------------------------------------------
			cards.Add("CFM_661e", null);

            // ---------------------------------------- MINION - PRIEST
            // [CFM_606t] Crystal (*) - COST:2 [ATK:2/HP:2] 
            // - Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_606t", null);

        }

		private static void Rogue(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [CFM_630] Counterfeit Coin - COST:0 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("CFM_630", new List<Enchantment> {
				new Enchantment
				{
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new TempManaTask(1)
                }
			});

			// ------------------------------------------ SPELL - ROGUE
			// [CFM_690] Jade Shuriken - COST:2 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $2 damage.
			//       <b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.
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
			cards.Add("CFM_690", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(2, EntityType.TARGET)
				},
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new DamageTask(2, EntityType.TARGET),
                        ComplexTask.SummonJadeGolem())
                },
            });

			// ----------------------------------------- MINION - ROGUE
			// [CFM_342] Luckydo Buccaneer - COST:6 [ATK:5/HP:5] 
			// - Race: pirate, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_342", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.WEAPON, SelfCondition.IsTagValue(GameTag.ATK, 3, RelaSign.GEQ)),
                        new FlagTask(true, new BuffTask(Buffs.AttackHealth(4), EntityType.SOURCE)))
				},
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
			cards.Add("CFM_634", new List<Enchantment> {
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_636", null);

            // ----------------------------------------- MINION - ROGUE
            // [CFM_691] Jade Swarmer - COST:2 [ATK:1/HP:1] 
            // - Set: gangs, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Stealth</b>
            //       <b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
            // --------------------------------------------------------
            // GameTag:
            // - STEALTH = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_691", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.SummonJadeGolem(),
				},
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
			// - REQ_TARGET_FOR_COMBO = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("CFM_693", new List<Enchantment> {
                // Combo
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new ReturnHandTask(EntityType.TARGET)
                }
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
			// - REQ_STEALTHED_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("CFM_694", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new BuffTask(Buffs.AttackHealth(2), EntityType.TARGET)
				},
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
			cards.Add("CFM_781", new List<Enchantment> {
				// TODO [CFM_781] Shaku, the Collector && Test: Shaku, the Collector_CFM_781
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void RogueNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_342e] Looted Blade (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +4/+4.
			// --------------------------------------------------------
			cards.Add("CFM_342e", null);

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [CFM_694e] Trained (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_694e", null);

        }

		private static void Shaman(IDictionary<string, List<Enchantment>> cards)
		{
			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_310] Call in the Finishers - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Summon four 1/1 Murlocs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("CFM_310", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(4, new SummonTask("CFM_310t")),
				},
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("CFM_313", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DiscoverTask(DiscoverType.OVERLOAD)
				},
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
			cards.Add("CFM_696", new List<Enchantment> {
				// TODO [CFM_696] Devolve && Test: Devolve_CFM_696
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [CFM_707] Jade Lightning - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>. *spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_707", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DamageTask(4, EntityType.TARGET, true),
                        ComplexTask.SummonJadeGolem()),
				},
			});

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
			cards.Add("CFM_061", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new HealTask(6, EntityType.TARGET),
				},
			});

            // ---------------------------------------- MINION - SHAMAN
            // [CFM_312] Jade Chieftain - COST:7 [ATK:5/HP:5] 
            // - Set: gangs, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. 
            //       Give it <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_312", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        ComplexTask.SummonJadeGolem(),
                        ComplexTask.Taunt(EntityType.STACK)),
				},
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
			cards.Add("CFM_324", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = new AddCardTo("CFM_324t", EntityType.DECK)
				},
			});

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_697] Lotus Illusionist - COST:4 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]After this minion attacks
			//       a hero, transform it into a
			//       _random 6-Cost minion.
			// --------------------------------------------------------
			cards.Add("CFM_697", new List<Enchantment> {
				// TODO [CFM_697] Lotus Illusionist && Test: Lotus Illusionist_CFM_697
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [CFM_717] Jade Claws - COST:2 [ATK:2/HP:0] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.
			//       <b><b>Overload</b>:</b>
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
			cards.Add("CFM_717", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.SummonJadeGolem(),
				},
			});

		}

		private static void ShamanNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [CFM_310t] Murloc Razorgill (*) - COST:1 [ATK:1/HP:1] 
			// - Race: murloc, Fac: neutral, Set: gangs, 
			// --------------------------------------------------------
			cards.Add("CFM_310t", null);

			// ---------------------------------------- MINION - SHAMAN
			// [CFM_324t] The Storm Guardian (*) - COST:5 [ATK:10/HP:10] 
			// - Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_324t", null);

		}

		private static void Warlock(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_094] Felfire Potion - COST:6 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $5 damage to all characters. *spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_094", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(5, EntityType.ALL, true)
				}
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [CFM_608] Blastcrystal Potion - COST:4 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a minion and one of your Mana Crystals.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_608", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new DestroyTask(EntityType.TARGET),
                        new ManaCrystalEmptyTask(-1)),
				},
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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_611", new List<Enchantment> {
				// TODO [CFM_611] Bloodfury Potion && Test: Bloodfury Potion_CFM_611
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_610] Crystalweaver - COST:4 [ATK:5/HP:4] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your Demons +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_610", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new IncludeTask(EntityType.MINIONS),
                        new FilterStackTask(SelfCondition.IsRace(Race.DEMON)),
                        new BuffTask(Buffs.AttackHealth(1), EntityType.STACK))
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_663] Kabal Trafficker - COST:6 [ATK:6/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]At the end of your turn,
			//       add a random Demon
			//       to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_663", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(ComplexTask.Create(
                            new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
                            new AddStackTo(EntityType.HAND)))
                        .Build()
                }
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
			cards.Add("CFM_699", new List<Enchantment> {
				// TODO [CFM_699] Seadevil Stinger && Test: Seadevil Stinger_CFM_699
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_750", new List<Enchantment> {
				// TODO [CFM_750] Krul the Unshackled && Test: Krul the Unshackled_CFM_750
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_751", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DamageTask(3, EntityType.ALL_NOSOURCE)
				},
			});

			// --------------------------------------- MINION - WARLOCK
			// [CFM_900] Unlicensed Apothecary - COST:3 [ATK:5/HP:5] 
			// - Race: demon, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever you summon a minion, deal 5 damage to_your Hero.
			// --------------------------------------------------------
			cards.Add("CFM_900", new List<Enchantment> {
				// TODO [CFM_900] Unlicensed Apothecary && Test: Unlicensed Apothecary_CFM_900
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

		}

		private static void Warrior(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_716] Sleep with the Fishes - COST:2 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Deal $3 damage to all damaged minions. *spelldmg
			// --------------------------------------------------------
			cards.Add("CFM_716", new List<Enchantment> {
				// TODO [CFM_716] Sleep with the Fishes && Test: Sleep with the Fishes_CFM_716
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
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
			cards.Add("CFM_752", new List<Enchantment> {
				// TODO [CFM_752] Stolen Goods && Test: Stolen Goods_CFM_752
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = null,
				},
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [CFM_940] I Know a Guy - COST:1 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Taunt</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - TREASURE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_940", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DiscoverTask(DiscoverType.TAUNT),
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_300] Public Defender - COST:2 [ATK:0/HP:7] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("CFM_300", null);

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
			cards.Add("CFM_643", new List<Enchantment> {
				// TODO [CFM_643] Hobart Grapplehammer && Test: Hobart Grapplehammer_CFM_643
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - WARRIOR
			// [CFM_754] Grimy Gadgeteer - COST:4 [ATK:4/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion in your hand +2/+2.
			// --------------------------------------------------------
			cards.Add("CFM_754", new List<Enchantment> {
				// TODO [CFM_754] Grimy Gadgeteer && Test: Grimy Gadgeteer_CFM_754
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_755", new List<Enchantment> {
				// TODO [CFM_755] Grimestreet Pawnbroker && Test: Grimestreet Pawnbroker_CFM_755
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_756", new List<Enchantment> {
				// TODO [CFM_756] Alley Armorsmith && Test: Alley Armorsmith_CFM_756
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_631", new List<Enchantment> {
				// TODO [CFM_631] Brass Knuckles && Test: Brass Knuckles_CFM_631
				new Enchantment
				{
					Activation = EnchantmentActivation.WEAPON,
					SingleTask = null,
				},
			});

		}

		private static void WarriorNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [CFM_643e] Smuggling (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: +1 Attack from Hobart Grapplehammer.
			// --------------------------------------------------------
			cards.Add("CFM_643e", null);

            // ---------------------------------- ENCHANTMENT - WARRIOR
            // [CFM_643e2] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1 Attack from Hobart Grapplehammer.
            // --------------------------------------------------------
            cards.Add("CFM_643e2", null);

        }

		private static void Neutral(IDictionary<string, List<Enchantment>> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [CFM_025] Wind-up Burglebot - COST:6 [ATK:5/HP:5] 
			// - Race: mechanical, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever this attacks a minion and survives, draw_a card.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			cards.Add("CFM_025", new List<Enchantment> {
				// TODO [CFM_025] Wind-up Burglebot && Test: Wind-up Burglebot_CFM_025
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_039", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.HERO,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SpellDamage(1)
                }
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_060] Red Mana Wyrm - COST:5 [ATK:2/HP:6] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever  you cast a spell, gain +2 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_060", new List<Enchantment> {
				// TODO [CFM_060] Red Mana Wyrm && Test: Red Mana Wyrm_CFM_060
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_063", new List<Enchantment> {
				// TODO [CFM_063] Kooky Chemist && Test: Kooky Chemist_CFM_063
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_064", new List<Enchantment> {
				// TODO [CFM_064] Blubber Baron && Test: Blubber Baron_CFM_064
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_067", new List<Enchantment> {
				// TODO [CFM_067] Hozen Healer && Test: Hozen Healer_CFM_067
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_095] Weasel Tunneler - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_095", new List<Enchantment> {
				// TODO [CFM_095] Weasel Tunneler && Test: Weasel Tunneler_CFM_095
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_120] Mistress of Mixtures - COST:1 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Restore 4 Health to both players.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("CFM_120", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.Create(
                        new HealTask(4, EntityType.HERO),
                        new HealTask(4, EntityType.OP_HERO)),
				},
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("CFM_321", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DiscoverTask(DiscoverType.HUNTER_PALADIN_WARRIOR),
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_325] Small-Time Buccaneer - COST:1 [ATK:1/HP:2] 
			// - Race: pirate, Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Has +2 Attack while you have a weapon equipped.
			// --------------------------------------------------------
			cards.Add("CFM_325", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.SELF,
                    Activation = EnchantmentActivation.BOARD,
                    Enchant = Auras.SimpleInclSelf(GameTag.ATK, 2, RelaCondition.IsMe(SelfCondition.IsWeaponEquiped))
                }
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
			cards.Add("CFM_328", new List<Enchantment> {
				// TODO [CFM_328] Fight Promoter && Test: Fight Promoter_CFM_328
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_341", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.Create(
                        new GetGameTagTask(GameTag.ATK, EntityType.SOURCE),
                        new DamageNumberTask(EntityType.ENEMIES)),
				},
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
			cards.Add("CFM_344", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.SELF,
					Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.ATTACKING, -1)
                        .SingleTask(ComplexTask.Create(
                            new IncludeTask(EntityType.SOURCE),
                            new FuncTask(p =>
                            {
                                var result = new List<IPlayable>();
                                var minion = p[0] as Minion;
                                if (minion == null)
                                    return result;
                                var target = minion.Game.IdEntityDic[minion.ProposedDefender] as Minion;
                                if (target != null)
                                   result.Add(target);
                                return result; }),
                            new SelfConditionTask(EntityType.STACK, SelfCondition.IsDead),
                            ComplexTask.True(new EnqueueTask(2,
                                ComplexTask.SummonRandomMinion(EntityType.DECK, RelaCondition.IsSameRace)))))
                        .Build()
                }
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_609] Fel Orc Soulfiend - COST:3 [ATK:3/HP:7] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 2 damage to this_minion.
			// --------------------------------------------------------
			cards.Add("CFM_609", new List<Enchantment> {
				// TODO [CFM_609] Fel Orc Soulfiend && Test: Fel Orc Soulfiend_CFM_609
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_619] Kabal Chemist - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Add a random Potion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - MULTIPLE_CLASSES = 296
			// - MULTI_CLASS_GROUP = 3
			// - KABAL = 1
			// --------------------------------------------------------
			cards.Add("CFM_619", new List<Enchantment> {
				// TODO [CFM_619] Kabal Chemist && Test: Kabal Chemist_CFM_619
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_621", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new SelfConditionTask(EntityType.SOURCE, SelfCondition.IsNoDupeInDeck),
                        new FlagTask(true, new PotionGenerating()))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_637] Patches the Pirate - COST:1 [ATK:1/HP:1] 
			// - Race: pirate, Set: gangs, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Charge</b>
			//       After you play a Pirate,
			//       summon this minion
			//       from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("CFM_637", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
					Activation = EnchantmentActivation.DECK,
					Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInDeckZone)
                        .ApplyConditions(RelaCondition.IsSameRace)
                        .TriggerEffect(GameTag.SUMMONED, 1)
                        .SingleTask(SpecificTask.PatchesThePirate)
                        .Build()
				}
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
			cards.Add("CFM_646", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.DEATHRATTLE,
                    SingleTask = new DamageTask(2, EntityType.OP_HERO)
                }
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
			cards.Add("CFM_647", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DamageTask(1, EntityType.TARGET)
                }
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
			cards.Add("CFM_648", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new SummonTask("CFM_648t")
				},
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("CFM_649", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new DiscoverTask(DiscoverType.MAGE_PRIEST_WARLOCK)
                },
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
			cards.Add("CFM_651", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new BuffTask(Buffs.WeaponAtk(1), EntityType.WEAPON)
                }
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
			cards.Add("CFM_652", new List<Enchantment> {
				// TODO [CFM_652] Second-Rate Bruiser && Test: Second-Rate Bruiser_CFM_652
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_653", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_654] Friendly Bartender - COST:2 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 1 Health to your_hero.
			// --------------------------------------------------------
			cards.Add("CFM_654", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.CONTROLLER,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .TriggerEffect(GameTag.TURN_START, -1)
                        .SingleTask(new HealTask(1, EntityType.HERO))
                        .Build()
                }
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
			cards.Add("CFM_655", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                            new GetGameTagTask(GameTag.DURABILITY, EntityType.OP_WEAPON),
                            new MathSubstractionTask(1),
                            new SetGameTagNumberTask(GameTag.DURABILITY, EntityType.OP_WEAPON)),
				},
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
			cards.Add("CFM_656", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new RevealStealthTask(EntityType.OP_MINIONS)
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_658] Backroom Bouncer - COST:4 [ATK:4/HP:4] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever a friendly minion dies, gain +1 Attack.
			// --------------------------------------------------------
			cards.Add("CFM_658", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.BOARD,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                                .EnableConditions(SelfCondition.IsNotDead,  SelfCondition.IsNotSilenced)
                                .TriggerEffect(GameTag.TO_BE_DESTROYED, 1)
                                .SingleTask(new BuffTask(Buffs.Attack(1), EntityType.SOURCE))
                                .Build()
                }
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
			cards.Add("CFM_659", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new HealTask(2, EntityType.TARGET)
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_665] Worgen Greaser - COST:4 [ATK:6/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			cards.Add("CFM_665", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_666] Grook Fu Master - COST:5 [ATK:3/HP:5] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("CFM_666", null);

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
            // - REQ_MINION_TARGET = 0
            // - REQ_ENEMY_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE = 0
            // --------------------------------------------------------
            cards.Add("CFM_667", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DamageTask(5, EntityType.TARGET)
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask =  new DamageTask(5, EntityType.HERO)
                },
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
			cards.Add("CFM_668", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new EnqueueTask(2, new SummonTask("CFM_668t"))
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_669] Burgly Bully - COST:5 [ATK:4/HP:6] 
			// - Set: gangs, Rarity: epic
			// --------------------------------------------------------
			// Text: Whenever your opponent casts a spell, add a Coin to your hand.
			// --------------------------------------------------------
			cards.Add("CFM_669", new List<Enchantment> {
                new Enchantment
                {
                    Area = EnchantmentArea.OP_HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new AddCardTo("GAME_005", EntityType.HAND))
                        .Build()
                }
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
			cards.Add("CFM_670", new List<Enchantment> {
				// TODO [CFM_670] Mayor Noggenfogger && Test: Mayor Noggenfogger_CFM_670
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("CFM_672", new List<Enchantment> {
				// TODO [CFM_672] Madam Goya && Test: Madam Goya_CFM_672
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_685", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(5), SelfCondition.IsMinion)
				},
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
			cards.Add("CFM_688", new List<Enchantment> {
				// TODO [CFM_688] Spiked Hogrider && Test: Spiked Hogrider_CFM_688
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_715] Jade Spirit - COST:4 [ATK:2/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - JADE_GOLEM = 1
			// - MULTIPLE_CLASSES = 194
			// - MULTI_CLASS_GROUP = 2
			// - JADE_LOTUS = 1
			// --------------------------------------------------------
			cards.Add("CFM_715", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.SummonJadeGolem(),
				},
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
			cards.Add("CFM_790", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.Create(
                        new RandomTask(1, EntityType.OP_HAND),
                        new FilterStackTask(SelfCondition.IsMinion),
                        new RemoveFromHand(EntityType.STACK),
                        new SummonOpTask())
				},
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
			cards.Add("CFM_806", new List<Enchantment> {
				// TODO [CFM_806] Wrathion && Test: Wrathion_CFM_806
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_807", new List<Enchantment> {
				new Enchantment
                {
                    Area = EnchantmentArea.HAND,
                    Activation = EnchantmentActivation.BOARD,
                    Trigger = new TriggerBuilder().Create()
                        .EnableConditions(SelfCondition.IsInPlayZone, SelfCondition.IsNotSilenced)
                        .ApplyConditions(RelaCondition.IsOther(SelfCondition.IsSpell))
                        .TriggerEffect(GameTag.JUST_PLAYED, 1)
                        .SingleTask(new SetGameTagTask(GameTag.EXHAUSTED, 0, EntityType.HERO_POWER))
                        .Build()
                }
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
			cards.Add("CFM_808", new List<Enchantment> {
				// TODO [CFM_808] Genzo, the Shark && Test: Genzo, the Shark_CFM_808
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			cards.Add("CFM_809", new List<Enchantment> {
				// TODO [CFM_809] Tanaris Hogchopper && Test: Tanaris Hogchopper_CFM_809
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
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
			cards.Add("CFM_810", new List<Enchantment> {
				// TODO [CFM_810] Leatherclad Hogleader && Test: Leatherclad Hogleader_CFM_810
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = null,
				},
			});

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_851] Daring Reporter - COST:4 [ATK:3/HP:3] 
			// - Set: gangs, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever your opponent draws a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("CFM_851", new List<Enchantment> {
				// TODO [CFM_851] Daring Reporter && Test: Daring Reporter_CFM_851
				new Enchantment
				(
					//Activation = null,
					//SingleTask = null,
				)
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
			// - TREASURE = 1
			// --------------------------------------------------------
			cards.Add("CFM_852", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new DiscoverTask(DiscoverType.DRUID_ROGUE_SHAMAN)
				},
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
			cards.Add("CFM_853", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.BuffRandomMinion(EntityType.HAND, Buffs.AttackHealth(1), SelfCondition.IsMinion),
				},
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
			cards.Add("CFM_854", null);

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
			// - REQ_NONSELF_TARGET = 0
			// - REQ_TARGET_WITH_DEATHRATTLE = 0
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("CFM_855", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = new SilenceTask(EntityType.TARGET)
				},
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
			cards.Add("CFM_902", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.BATTLECRY,
					SingleTask = ComplexTask.SummonJadeGolem()
				},
				new Enchantment
				{
					Activation = EnchantmentActivation.DEATHRATTLE,
					SingleTask = ComplexTask.SummonJadeGolem()
				},
			});

		}

		private static void NeutralNonCollect(IDictionary<string, List<Enchantment>> cards)
		{
			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t] Kazakus Potion (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t", null);

            // ---------------------------------------- SPELL - NEUTRAL
            // [CFM_621t10] Netherbloom (*) - COST:1 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Summon a 2/2 Demon.
            // --------------------------------------------------------
            // GameTag:
            // - TAG_SCRIPT_DATA_NUM_1 = 2
            // --------------------------------------------------------
            cards.Add("CFM_621t10", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new SummonTask("CFM_621_m4"),
				},
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
			cards.Add("CFM_621t11", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t12] Greater Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 5-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1088
			// --------------------------------------------------------
			cards.Add("CFM_621t12", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t13] Superior Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Create a 10-Cost spell.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1089
			// --------------------------------------------------------
			cards.Add("CFM_621t13", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t14] Kazakus Potion (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t14", null);

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t15] Kazakus Potion (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: {0}
			//       {1}
			// --------------------------------------------------------
			cards.Add("CFM_621t15", null);

            // ---------------------------------------- SPELL - NEUTRAL
            // [CFM_621t16] Heart of Fire (*) - COST:5 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Deal $5 damage. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - TAG_SCRIPT_DATA_NUM_1 = 5
            // - AFFECTED_BY_SPELL_POWER = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            cards.Add("CFM_621t16", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(5, EntityType.TARGET, true),
                }
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
			cards.Add("CFM_621t17", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(7)
                }
            });

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t18] Felbloom (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $4 damage to all minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t18", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(4, EntityType.ALLMINIONS, true)
				}
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
			cards.Add("CFM_621t19", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new RandomTask(2, EntityType.ENEMIES),
                        ComplexTask.Freeze(EntityType.STACK))
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t2] Heart of Fire (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $3 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 4
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t2", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DamageTask(3, EntityType.TARGET, true),
				}
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
			cards.Add("CFM_621t20", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new SummonTask("CFM_621_m2"),
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t21] Mystic Wool (*) - COST:5 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Transform a random enemy minion into a 1/1 Sheep.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t21", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = ComplexTask.Create(
                        new RandomTask(1, EntityType.OP_MINIONS),
                        new TransformTask("CFM_621_m5", EntityType.STACK))
				}
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
			cards.Add("CFM_621t22", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(2, new DrawTask())
				}
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
			cards.Add("CFM_621t23", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(2, ComplexTask.Create(
                        new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
                        new CopyToHand()))
				},
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
			cards.Add("CFM_621t24", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.Health(4), EntityType.MINIONS)
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t25] Heart of Fire (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $8 damage. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 5
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CFM_621t25", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(8, EntityType.TARGET, true),
                }
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
			cards.Add("CFM_621t26", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new ArmorTask(10)
				}
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
			cards.Add("CFM_621t27", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new RandomTask(3, EntityType.ENEMIES),
                        ComplexTask.Freeze(EntityType.STACK))
                }
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
			cards.Add("CFM_621t28", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new SummonTask("CFM_621_m3"),
                }
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
			cards.Add("CFM_621t29", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new TransformTask("CFM_621_m5", EntityType.ALLMINIONS))
                }
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
			cards.Add("CFM_621t3", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.SPELL,
                    SingleTask = new ArmorTask(4)
                }
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
			cards.Add("CFM_621t30", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(3, new DrawTask()),
                }
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
			cards.Add("CFM_621t31", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(3, ComplexTask.Create(
                        new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
                        new CopyToHand()))
                }
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
			cards.Add("CFM_621t32", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.Health(6), EntityType.MINIONS)
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t33] Felbloom (*) - COST:10 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $6 damage to all minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 2
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t33", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(6, EntityType.ALLMINIONS, true)
                }
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
			cards.Add("CFM_621t37", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.SummonRandomMinionThatDied()
                }
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
			cards.Add("CFM_621t38", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new EnqueueTask(2, ComplexTask.SummonRandomMinionThatDied())
                }
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
			cards.Add("CFM_621t39", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new EnqueueTask(3, ComplexTask.SummonRandomMinionThatDied())
				}
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [CFM_621t4] Felbloom (*) - COST:1 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Deal $2 damage to all minions. *spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_1 = 1
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("CFM_621t4", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = new DamageTask(2, EntityType.ALLMINIONS, true)
                }
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
			cards.Add("CFM_621t5", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new RandomTask(1, EntityType.ENEMIES),
                        ComplexTask.Freeze(EntityType.STACK))
                }
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
			cards.Add("CFM_621t6", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new BuffTask(Buffs.Health(2), EntityType.MINIONS)
				}
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
			cards.Add("CFM_621t8", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
					SingleTask = new DrawTask(),
				}
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
			cards.Add("CFM_621t9", new List<Enchantment> {
				new Enchantment
				{
					Activation = EnchantmentActivation.SPELL,
                    SingleTask = ComplexTask.Create(
                        new RandomMinionTask(GameTag.CARDRACE, (int)Race.DEMON),
                        new CopyToHand())
                }
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [CFM_020e] Raza Enchant (*) - COST:0 
			// - Set: gangs, 
			// --------------------------------------------------------
			// Text: Your <b>Hero Power</b> costs (0).
			// --------------------------------------------------------
			cards.Add("CFM_020e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_060e] Mana Heist (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("CFM_060e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_063e] Kooky Chemistry (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Attack and Health have been swapped by Kooky Chemist.
            // --------------------------------------------------------
            cards.Add("CFM_063e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_064e] Size Increase (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("CFM_064e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_325e] Equipped (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2 Attack.
            // --------------------------------------------------------
            cards.Add("CFM_325e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_334e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2/+2 from Smuggler's Crate.
            // --------------------------------------------------------
            cards.Add("CFM_334e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_336e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2/+2 from Shaky Zipgunner.
            // --------------------------------------------------------
            cards.Add("CFM_336e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_610e] Serrated Shadows (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("CFM_610e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_611e] Demonic Draught (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +3 Attack.
            // --------------------------------------------------------
            cards.Add("CFM_611e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_611e2] Demonic Draught (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +3/+3.
            // --------------------------------------------------------
            cards.Add("CFM_611e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_614e] Savage Mark (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1.
            // --------------------------------------------------------
            cards.Add("CFM_614e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_617e] Visions of Hypnos (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("CFM_617e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_621e] Goldthorn (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2 Health.
            // --------------------------------------------------------
            cards.Add("CFM_621e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_621e2] Goldthorn (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +4 Health.
            // --------------------------------------------------------
            cards.Add("CFM_621e2", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_621e3] Goldthorn (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +6 Health.
            // --------------------------------------------------------
            cards.Add("CFM_621e3", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_626e] Fortitude (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +3 Health.
            // --------------------------------------------------------
            cards.Add("CFM_626e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_631e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased stats from Brass Knuckles.
            // --------------------------------------------------------
            cards.Add("CFM_631e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_639e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased stats from Grimestreet Enforcer.
            // --------------------------------------------------------
            cards.Add("CFM_639e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_650e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1 from Grimscale Chum.
            // --------------------------------------------------------
            cards.Add("CFM_650e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_651e] Extra Sharp (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1 Attack.
            // --------------------------------------------------------
            cards.Add("CFM_651e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_658e] Cut Off (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased Attack.
            // --------------------------------------------------------
            cards.Add("CFM_658e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_671e] We All Scream (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("CFM_671e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_685e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +5/+5 from Don Han'Cho.
            // --------------------------------------------------------
            cards.Add("CFM_685e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_699e] Seadevil Enchant (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // GameTag:
            // - OneTurnEffect = 1
            // --------------------------------------------------------
            cards.Add("CFM_699e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_752e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +3/+3 from Stolen Goods.
            // --------------------------------------------------------
            cards.Add("CFM_752e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_753e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1 from Grimestreet Outfitter.
            // --------------------------------------------------------
            cards.Add("CFM_753e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_754e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased stats from Grimy Gadgeteer.
            // --------------------------------------------------------
            cards.Add("CFM_754e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_755e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1 from Grimestreet Pawnbroker.
            // --------------------------------------------------------
            cards.Add("CFM_755e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_816e] Get Big (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +2/+2.
            // --------------------------------------------------------
            cards.Add("CFM_816e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_851e] The Scoop (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: Increased stats.
            // --------------------------------------------------------
            cards.Add("CFM_851e", null);

            // ---------------------------------- ENCHANTMENT - NEUTRAL
            // [CFM_853e] Smuggling (*) - COST:0 
            // - Set: gangs, 
            // --------------------------------------------------------
            // Text: +1/+1 from Grimestreet Smuggler.
            // --------------------------------------------------------
            cards.Add("CFM_853e", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_621_m2] Kabal Demon (*) - COST:5 [ATK:5/HP:5] 
            // - Race: demon, Fac: neutral, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_621_m2", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_621_m3] Kabal Demon (*) - COST:8 [ATK:8/HP:8] 
            // - Race: demon, Fac: neutral, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_621_m3", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_621_m4] Kabal Demon (*) - COST:2 [ATK:2/HP:2] 
            // - Race: demon, Fac: neutral, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_621_m4", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_621_m5] Sheep (*) - COST:1 [ATK:1/HP:1] 
            // - Race: beast, Fac: neutral, Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_621_m5", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_648t] "Little Friend" (*) - COST:6 [ATK:6/HP:6] 
            // - Set: gangs, 
            // --------------------------------------------------------
            cards.Add("CFM_648t", null);

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_668t] Doppelgangster (*) - COST:5 [ATK:2/HP:2] 
			// - Set: gangs, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("CFM_668t", new List<Enchantment> {
				new Enchantment
				{
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new SummonTask("CFM_668t2"))
                },
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
			cards.Add("CFM_668t2", new List<Enchantment> {
                new Enchantment
                {
                    Activation = EnchantmentActivation.BATTLECRY,
                    SingleTask = new EnqueueTask(2, new SummonTask("CFM_668t2"))
                },
            });

			// --------------------------------------- MINION - NEUTRAL
			// [CFM_712_t01] Jade Golem (*) - COST:1 [ATK:1/HP:1] 
			// - Set: gangs, 
			// --------------------------------------------------------
			// RefTag:
			// - JADE_GOLEM = 1
			// --------------------------------------------------------
			cards.Add("CFM_712_t01", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t02] Jade Golem (*) - COST:2 [ATK:2/HP:2] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t02", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t03] Jade Golem (*) - COST:3 [ATK:3/HP:3] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t03", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t04] Jade Golem (*) - COST:4 [ATK:4/HP:4] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t04", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t05] Jade Golem (*) - COST:5 [ATK:5/HP:5] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t05", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t06] Jade Golem (*) - COST:6 [ATK:6/HP:6] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t06", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t07] Jade Golem (*) - COST:7 [ATK:7/HP:7] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t07", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t08] Jade Golem (*) - COST:8 [ATK:8/HP:8] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t08", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t09] Jade Golem (*) - COST:9 [ATK:9/HP:9] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t09", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t10] Jade Golem (*) - COST:10 [ATK:10/HP:10] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t10", null);
            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t11] Jade Golem (*) - COST:10 [ATK:11/HP:11] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t11", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t12] Jade Golem (*) - COST:10 [ATK:12/HP:12] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t12", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t13] Jade Golem (*) - COST:10 [ATK:13/HP:13] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t13", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t14] Jade Golem (*) - COST:10 [ATK:14/HP:14] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t14", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t15] Jade Golem (*) - COST:10 [ATK:15/HP:15] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t15", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t16] Jade Golem (*) - COST:10 [ATK:16/HP:16] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t16", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t17] Jade Golem (*) - COST:10 [ATK:17/HP:17] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t17", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t18] Jade Golem (*) - COST:10 [ATK:18/HP:18] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t18", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t19] Jade Golem (*) - COST:10 [ATK:19/HP:19] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t19", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t20] Jade Golem (*) - COST:10 [ATK:20/HP:20] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t20", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t21] Jade Golem (*) - COST:10 [ATK:21/HP:21] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t21", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t22] Jade Golem (*) - COST:10 [ATK:22/HP:22] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t22", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t23] Jade Golem (*) - COST:10 [ATK:23/HP:23] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t23", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t24] Jade Golem (*) - COST:10 [ATK:24/HP:24] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t24", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t25] Jade Golem (*) - COST:10 [ATK:25/HP:25] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t25", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t26] Jade Golem (*) - COST:10 [ATK:26/HP:26] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t26", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t27] Jade Golem (*) - COST:10 [ATK:27/HP:27] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t27", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t28] Jade Golem (*) - COST:10 [ATK:28/HP:28] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t28", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t29] Jade Golem (*) - COST:10 [ATK:29/HP:29] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t29", null);

            // --------------------------------------- MINION - NEUTRAL
            // [CFM_712_t30] Jade Golem (*) - COST:10 [ATK:30/HP:30] 
            // - Set: gangs, 
            // --------------------------------------------------------
            // RefTag:
            // - JADE_GOLEM = 1
            // --------------------------------------------------------
            cards.Add("CFM_712_t30", null);

		}

		public static void AddAll(Dictionary<string, List<Enchantment>> cards)
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
