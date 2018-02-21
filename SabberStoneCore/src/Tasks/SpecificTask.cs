﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Tasks
{
	internal class SpecificTask
	{
		public static ISimpleTask LivingMana
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					var result = new List<IPlayable>();
					Controller controller = p[0].Controller;
					int manaCrystal = (new[] { controller.BoardZone.MaxSize - controller.BoardZone.Count, controller.BaseMana }).Min();
					for (int i = 0; i < manaCrystal; i++)
					{
						result.Add(Entity.FromCard(controller, Cards.FromId("UNG_111t1")));
					}
					return result;
				}),
				new CountTask(EntityType.STACK),
				new SummonCopyTask(EntityType.STACK),
				new MathMultiplyTask(-1),
				new ManaCrystalEmptyTask(0, false, true)
			);

		public static ISimpleTask PatchesThePirate
			=> ComplexTask.Create(
				new ConditionTask(EntityType.HERO, SelfCondition.IsNotBoardFull),
				new FlagTask(true, new RemoveFromDeck(EntityType.SOURCE)),
				new FlagTask(true, new SummonTask())
			);

		public static ISimpleTask TotemicCall
			=> ComplexTask.Create(
				new FuncNumberTask(p =>
				{
					Minion[] minions = p.Controller.BoardZone.GetAll();
					var notContained = new List<Card>(4);
					for (int i = 0; i < p.Card.Entourage.Length; i++)
					{
						string id = p.Card.Entourage[i];
						bool flag = false;
						for (int j = 0; j < minions.Length; j++)
						{
							Minion m = minions[j];
							if (id == m.Card.Id)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
							notContained.Add(Cards.FromId(id));
					}
					Entity.FromCard(p.Controller, notContained[Util.Random.Next(notContained.Count)],
						null, p.Controller.BoardZone);
					return 0;
				}));

		public static ISimpleTask Betrayal
			=> ComplexTask.Create(
				new GetGameTagTask(GameTag.ATK, EntityType.TARGET),
				new IncludeTask(EntityType.OP_MINIONS),
				new FilterStackTask(EntityType.TARGET, RelaCondition.IsSideBySide),
				new DamageNumberTask(EntityType.STACK));

		public static ISimpleTask JusticarTrueheart
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					switch (controller.Hero.HeroPower.Card.Id)
					{
						case "CS1h_001":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_PRIEST")) };
						case "CS2_017":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_DRUID")) };
						case "CS2_034":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_MAGE")) };
						case "CS2_049":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_SHAMAN")) };
						case "CS2_056":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_WARLOCK")) };
						case "CS2_083b":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_ROGUE")) };
						case "CS2_101":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_PALADIN")) };
						case "CS2_102":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_WARRIOR")) };
						case "DS1h_292":
							return new List<IPlayable> { Entity.FromCard(controller, Cards.FromId("AT_132_HUNTER")) };
					}
					return new List<IPlayable>();
				}),
				new ReplaceHeroPower()
			);

		public static ISimpleTask Doppelgangster
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					IPlayable s = p[0];
					Controller c = s.Controller;
					Minion left = null;
					Minion right = null;
					int space = c.BoardZone.MaxSize - c.BoardZone.Count;
					switch (s.Card.Id)
					{
						case "CFM_668":
							if (space > 0)
								left = (Minion) Entity.FromCard(c, Cards.FromId("CFM_668t"));
							if (space > 1)
								right = (Minion) Entity.FromCard(c, Cards.FromId("CFM_668t2"));
							break;
						case "CFM_668t":
							if (space > 0)
								left = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668t2"));
							if (space > 1)
								right = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668"));
							break;
						case "CFM_668t2":
							if (space > 0)
								left = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668t"));
							if (space > 1)
								right = (Minion)Entity.FromCard(c, Cards.FromId("CFM_668"));
							break;
						default:
							throw new NotImplementedException();
					}
					if (left != null)
					{
						Generic.SummonBlock.Invoke(c, left, s.ZonePosition);
						s.AppliedEnchantments?.ForEach(e => Enchantment.GetInstance(c, left, left, e.Card));
						left[GameTag.ATK] = s[GameTag.ATK];
						left[GameTag.HEALTH] = s[GameTag.HEALTH];

						if (right != null)
						{
							Generic.SummonBlock.Invoke(c, right, s.ZonePosition + 1);
							s.AppliedEnchantments?.ForEach(e => Enchantment.GetInstance(c, right, right, e.Card));
							right[GameTag.ATK] = s[GameTag.ATK];
							right[GameTag.HEALTH] = s[GameTag.HEALTH];
						}
					}
					return null;
				})
			);

		public static ISimpleTask MayorNoggenfogger =>
			ComplexTask.Create(
				new IncludeTask(EntityType.TARGET),
				new FuncPlayablesTask(list =>
				{
					IPlayable p = list[0];
					//int boardCount = p.Controller.BoardZone.CountExceptUntouchables;
					int opBoardCount = p.Controller.Opponent.BoardZone.CountExceptUntouchables;

					if (p is ICharacter c && c.IsAttacking)
					{
						int index = Util.Random.Next(opBoardCount + 1);
						c.Game.ProposedDefender = index == opBoardCount
							? c.Controller.Opponent.Hero.Id
							: c.Controller.Opponent.BoardZone.HasUntouchables
								? c.Controller.Opponent.BoardZone.GetAll(null)[index].Id
								: c.Controller.Opponent.BoardZone[index].Id;
						return null;
					}

					p.CardTarget = Util.Choose((List<ICharacter>) p.ValidPlayTargets).Id;
					return null;
				}));

		// TODO
		public static ISimpleTask CuriousGlimmerroot
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					IEntity source = p[0];
					Controller controller = p[0].Controller;
					Controller opponent = p[0].Controller.Opponent;
					if (_glimmerrootMemory1 == null)
					{
						lock (locker)
						{
							var opClassCards = new List<Card>();
							_glimmerrootMemory2 = new HashSet<int>();
							_glimmerrootMemory3 = Cards.FormatTypeClassCards(controller.Game.FormatType)[opponent.BaseClass].Where(c => c.Class == opponent.BaseClass).ToList().AsReadOnly();
							foreach (Card card in opponent.DeckCards)
							{
								if (card.Class != opponent.BaseClass)
									continue;
								if (_glimmerrootMemory2.Contains(card.AssetId))
									continue;
								opClassCards.Add(card);
								_glimmerrootMemory2.Add(card.AssetId);
							}
							_glimmerrootMemory1 = opClassCards.AsReadOnly();
						}
					}

					var result = new List<Card> { Util.Choose(_glimmerrootMemory1) };
					while (result.Count < 3)
					{
						Card pick = Util.Choose(_glimmerrootMemory3);
						if (_glimmerrootMemory2.Contains(pick.AssetId) || result.Contains(pick))
							continue;
						result.Add(pick);
					}

					for (int i = 0; i < 3; i++)
					{
						int j = Util.Random.Next(i, 3);
						Card temp = result[i];
						result[i] = result[j];
						result[j] = temp;
					}
					Generic.CreateChoiceCards.Invoke(controller, source, null, ChoiceType.GENERAL, ChoiceAction.GLIMMERROOT, result, null, null);
					controller.Game.OnRandomHappened(true);
					return p;
				}));
		private static ReadOnlyCollection<Card> _glimmerrootMemory1;
		private static HashSet<int> _glimmerrootMemory2;
		private static ReadOnlyCollection<Card> _glimmerrootMemory3;
		private static readonly object locker = new object();

		public static ISimpleTask UngoroPack
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					int space = controller.MaxHandSize - controller.HandZone.Count;
					if (space >= 5)
						space = 5;
					else if (space == 0)
						return null;
					//var pack = new List<IPlayable>(space);

					if (_ungoroPackMemory == null)
					{
						lock (locker)
						{
							var dic = new Dictionary<Rarity, Card[]>(4);
							var ungCards = Cards.All.Where(c => c.Set == CardSet.UNGORO && !c.IsQuest).ToArray();
							dic.Add(Rarity.COMMON, ungCards.Where(c => c.Rarity == Rarity.COMMON).ToArray());
							dic.Add(Rarity.RARE, ungCards.Where(c => c.Rarity == Rarity.RARE).ToArray());
							dic.Add(Rarity.EPIC, ungCards.Where(c => c.Rarity == Rarity.EPIC).ToArray());
							dic.Add(Rarity.LEGENDARY, ungCards.Where(c => c.Rarity == Rarity.LEGENDARY).ToArray());
							_ungoroPackMemory = new ReadOnlyDictionary<Rarity, Card[]>(dic);
						}
					}

					for (int i = 0; i < space; ++i)
					{
						var tags = new EntityData.Data
						{
							{GameTag.CREATOR, p[0].Id}
						};
						Rarity rarity;
						double rnd = Util.Random.NextDouble();

						// empirical result
						if (rnd < 0.19)
							rarity = Rarity.LEGENDARY;
						else if (rnd < 0.43)
							rarity = Rarity.EPIC;
						else if (rnd < 0.71)
							rarity = Rarity.RARE;
						else
							rarity = Rarity.COMMON;

						Card[] cards = _ungoroPackMemory[rarity];
						Card pick = cards[Util.Random.Next(cards.Length)];
						IPlayable entity = Entity.FromCard(controller, pick, tags, controller.HandZone);
						entity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, p[0].Id);
						//pack.Add(entity);
					}
					return null;
				}));
		private static ReadOnlyDictionary<Rarity, Card[]> _ungoroPackMemory;

		public static ISimpleTask BuildABeast
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;

					if (_firstBeastsMemory == null)
					{
						lock (locker)
						{
							IEnumerable<Card> all = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5) : Cards.Wild[CardClass.HUNTER].Where(c => c.Race == Race.BEAST && c.Cost <= 5);
							var firstBeasts = new List<Card>();
							var secondBeasts = new List<Card>();
							foreach (Card card in all)
							{
								if (card.Power != null)
									firstBeasts.Add(card);
								else
									secondBeasts.Add(card);
							}

							_firstBeastsMemory = firstBeasts.AsReadOnly();
							_secondBeastsMemory = secondBeasts.AsReadOnly();
						}
					}



					var first = new List<Card>();
					var second = new List<Card>();
					int numToSelect = 3;
					int numLeft = _firstBeastsMemory.Count;
					foreach (Card item in _firstBeastsMemory)
					{
						double prob = numToSelect / (double)numLeft;
						if (Util.Random.NextDouble() < prob)
						{
							first.Add(item);
							numToSelect--;
							if (numToSelect == 0)
								break;
						}
						numLeft--;
					}
					numToSelect = 3;
					numLeft = _secondBeastsMemory.Count;
					foreach (Card item in _secondBeastsMemory)
					{
						double prob = numToSelect / (double)numLeft;
						if (Util.Random.NextDouble() < prob)
						{
							second.Add(item);
							numToSelect--;
							if (numToSelect == 0)
								break;
						}
						numLeft--;
					}


					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, first, null, null);
					Generic.CreateChoiceCards.Invoke(controller, p[0], null, ChoiceType.GENERAL,
						ChoiceAction.BUILDABEAST, second, null, null);

					return p;
				}));
		private static ReadOnlyCollection<Card> _firstBeastsMemory;
		private static ReadOnlyCollection<Card> _secondBeastsMemory;

		public static ISimpleTask RandomHunterSecretPlay
			=> ComplexTask.Create(
				new IncludeTask(EntityType.TARGET),
				new FuncPlayablesTask(p =>
				{
					Controller controller = p[0].Controller;
					var activeSecrets = controller.SecretZone.Select(secret => secret.Card.Id).ToList();
					//activeSecrets.Add(p[0].Card.Id);
					IEnumerable<Card> cards = controller.Game.FormatType == FormatType.FT_STANDARD ? Cards.Standard[CardClass.HUNTER] : Cards.Wild[CardClass.HUNTER];
					IEnumerable<Card> cardsList = cards.Where(card => card.Type == CardType.SPELL && card.Tags.ContainsKey(GameTag.SECRET) && !activeSecrets.Contains(card.Id));
					var spell = (Spell)Entity.FromCard(controller, Util.Choose(cardsList.ToList()));
					//spell.ApplyPowers(PowerActivation.SECRET_OR_QUEST, Zone.PLAY);
					spell.ActivateTask();
					controller.SecretZone.Add(spell);
					controller.Game.OnRandomHappened(true);
					return new List<IPlayable>();
				})
			);

		public static ISimpleTask Simulacrum
			=> ComplexTask.Create(
				new IncludeTask(EntityType.HAND),
				new FilterStackTask(SelfCondition.IsMinion),
				new FuncPlayablesTask(list =>
				{
					if (!list.Any())
						return new List<IPlayable>();
					int minCost = list.Min(p => p.Cost);
					list.Where(p => p.Cost == minCost).ToList();
					return list.Where(p => p.Cost == minCost).ToList();
				}),
				new RandomTask(1, EntityType.STACK),
				new CopyTask(EntityType.STACK, 1),
				new AddStackTo(EntityType.HAND));

		public static ISimpleTask DeathsShadow
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new FuncPlayablesTask(list =>
				{
					IPlayable p = list[0];
					if (p.Controller.HandZone.IsFull)
						return new List<IPlayable>(0);
					IPlayable entity = Entity.FromCard(p.Controller, Cards.FromId("ICC_827t"),
						new EntityData.Data
						{
							{GameTag.CREATOR, p.Id}
						}, p.Controller.HandZone);
					return new List<IPlayable> {entity};
				}),
				new AddEnchantmentTask("ICC_827e", EntityType.STACK));

		public static ISimpleTask ShadowReflection
			=> ComplexTask.Create(
				new IncludeTask(EntityType.SOURCE),
				new IncludeTask(EntityType.TARGET, null, true),
				new FuncPlayablesTask(pList =>
				{
					Enchantment e = pList[0] as Enchantment;
					IPlayable previous = (IPlayable) e.Target;
					e.Remove();

					IPlayable newEntity = Generic.ChangeEntityBlock.Invoke(e.Controller, previous, pList[1].Card);

					if (newEntity[GameTag.DISPLAYED_CREATOR] == 0)
						newEntity[GameTag.DISPLAYED_CREATOR] = e.Creator.Id;

					Generic.AddEnchantmentBlock(e.Controller, e.Card, e, newEntity, 0, 0);

					// TODO choose ones

					return null;
				}));

		public static ISimpleTask ExplosiveRunes
			=> ComplexTask.Create(
				new ConditionTask(EntityType.TARGET, SelfCondition.IsNotDead, SelfCondition.IsNotUntouchable),
				new FlagTask(true, ComplexTask.Secret(
					new IncludeTask(EntityType.SOURCE),
					new IncludeTask(EntityType.TARGET, null, true),
					new FuncPlayablesTask(list =>
					{
						var target = (Minion) list[1];
						int health = target.Health;
						int amount = 6 + target.Controller.CurrentSpellPower;
						amount *= (int) Math.Pow(2, target.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE]);
						if (health >= amount)
						{
							Generic.DamageCharFunc(list[0], target, 6, true);
							return null;
						}
						target.TakeDamage(list[0], health);
						target.Controller.Hero.TakeDamage(list[0], amount - health);
						return null;
					}))));

		public static ISimpleTask DiamondSpellstone(int i)
		{
			return ComplexTask.Create(
				new IncludeTask(EntityType.GRAVEYARD),
				new FuncPlayablesTask(list => list
					.Where(p => p is Minion && p.ToBeDestroyed)
					.Select(p => p.Card.Id)
					.Distinct()
					.OrderBy(p => Util.Random)
					.Take(i)
					.Select(p => Entity.FromCard(list[0].Controller, Cards.FromId(p)))
					.ToList()),
				new SummonStackTask());
		}

		public static ISimpleTask Kingsbane
			=> ComplexTask.Create(
				new FuncNumberTask(p =>
				{
					var tags = new EntityData.Data
					{
						{GameTag.ATK, p[GameTag.ATK]},
						{GameTag.POISONOUS, p[GameTag.POISONOUS]},
						{GameTag.LIFESTEAL, p[GameTag.LIFESTEAL]}
					};
					IPlayable newWeapon = Entity.FromCard(p.Controller, p.Card, tags);
					p.AppliedEnchantments?.ForEach(e =>
					{
						Enchantment instance = Enchantment.GetInstance(p.Controller, newWeapon, newWeapon, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
						}
					});

					Generic.ShuffleIntoDeck(p.Controller, newWeapon);
					return 0;
				}));

		public class RenonunceDarkness : SimpleTask
		{
			private static readonly Card EnchantmentCard = Cards.FromId("OG_118e");
			private static readonly Effect CostReduceEffect = Effects.ReduceCost(1);

			public override TaskState Process()
			{
				// get a new class
				CardClass randClass = 0;
				do
				{
					randClass = (CardClass) Random.Next(2, 11);
				} while (randClass == CardClass.WARLOCK);
					
				// replace Hero Power
				Card heroPowerCard = null;
				switch (randClass)
				{
					case CardClass.DRUID:
						heroPowerCard = Cards.FromId("CS2_017");
						break;
					case CardClass.HUNTER:
						heroPowerCard = Cards.FromId("DS1h_292");
						break;
					case CardClass.MAGE:
						heroPowerCard = Cards.FromId("CS2_034");
						break;
					case CardClass.PALADIN:
						heroPowerCard = Cards.FromId("CS2_101");
						break;
					case CardClass.PRIEST:
						heroPowerCard = Cards.FromId("CS1h_001");
						break;
					case CardClass.ROGUE:
						heroPowerCard = Cards.FromId("CS2_083b");
						break;
					case CardClass.SHAMAN:
						heroPowerCard = Cards.FromId("CS2_049");
						break;
					case CardClass.WARRIOR:
						heroPowerCard = Cards.FromId("CS2_102");
						break;
				}
				HeroPower heroPower =
					(HeroPower) Entity.FromCard(Controller, heroPowerCard, new EntityData.Data
					{
						{GameTag.CREATOR, Source.Id},
						{GameTag.ZONE, (int)Zone.PLAY}
					});
				Controller.SetasideZone.Add(Controller.Hero.HeroPower);
				Controller.Hero.HeroPower = heroPower;

				var cards = Cards.FormatTypeClassCards(Game.FormatType)[randClass].Where(p => p.Class == randClass).ToList();

				// replace cards in hand
				for (int i = 0; i < Controller.HandZone.Count; i++)
				{
					IPlayable entity = Controller.HandZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;
					Controller.HandZone.Remove(entity);
					Controller.SetasideZone.Add(entity);
					var tags = new EntityData.Data
					{
						{GameTag.ZONE_POSITION, i + 1},
					};
					if (Game.History)
						tags.Add(GameTag.CREATOR, Source.Id);
					IPlayable newEntity = Entity.FromCard(Controller, Util.Choose(cards), tags, Controller.HandZone, -1, i);
					newEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, Source.Id);
					CostReduceEffect.Apply(newEntity.AuraEffects);
				}

				// replace cards in deck
				for (int i = Controller.DeckZone.Count - 1; i >= 0; i--)
				{
					IPlayable entity = Controller.DeckZone[i];
					if (entity.Card.Class != CardClass.WARLOCK) continue;

					Card randCard = Util.Choose(cards);
					IPlayable newEntity = Entity.FromCard(Controller, randCard, null, Controller.DeckZone);
					newEntity.NativeTags.Add(GameTag.DISPLAYED_CREATOR, Source.Id);

					//Enchantment.GetInstance(Controller, (IPlayable) Source, newEntity, EnchantmentCard);

					Controller.DeckZone.Remove(entity);
					Controller.SetasideZone.Add(entity);

					CostReduceEffect.Apply(newEntity.AuraEffects);
				}

				return TaskState.COMPLETE;
			}

			public override ISimpleTask Clone()
			{
				return new RenonunceDarkness();
			}
		}
	}
}


