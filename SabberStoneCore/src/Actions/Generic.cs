#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCore.Actions
{
	/// <summary>
	/// Container of game logic functionality, which is invoked by processing a selected option
	/// through <see cref="Game.Process(PlayerTask)"/>.
	/// </summary>
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<IPlayable, ICharacter, int, bool, int> DamageCharFunc
			=> (source, target, amount, applySpellDmg) =>
			{
				if (applySpellDmg)
				{
					amount += ((Spell)source).ReceveivesDoubleSpellDamage
						? source.Controller.CurrentSpellPower * 2
						: source.Controller.CurrentSpellPower;
					if (source.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE] > 0)
						amount *= (int)Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE]);
				}
				else if (source is HeroPower)
				{
					// TODO: Consider this part only when TGT or Rumble is loaded
					// amount += source.Controller.Hero.HeroPowerDamage; 
					if (source.Controller.ControllerAuraEffects[GameTag.HERO_POWER_DOUBLE] > 0)
						amount *= (int)Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.HERO_POWER_DOUBLE]);
				}
				return target.TakeDamage(source, amount);
			};

		public static Func<Controller, int, bool> AddTempMana
			=> delegate (Controller c, int amount)
			{
				if (c.RemainingMana + amount > 10)
					c.TemporaryMana += 10 - c.RemainingMana;
				else
					c.TemporaryMana += amount;
				return true;
			};

		public static Func<Controller, int, bool, bool> ChangeManaCrystal
			=> delegate (Controller c, int amount, bool fill)
			{
				int baseMana = c.BaseMana;

				if (baseMana + amount > c.MaxResources)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", !c.Game.Logging ? "" : $"{c.Name} is already capped in {c.MaxResources} mana crystals.");
					if (!fill)
						c.UsedMana += c.MaxResources - c.BaseMana;
					c.BaseMana = c.MaxResources;

				}
				else if (baseMana + amount < 0)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", !c.Game.Logging ? "" : $"{c.Name} is back to minimum of 0 mana crystals.");
					c.BaseMana = 0;
				}
				else
				{
					c.BaseMana = baseMana + amount;
					if (!fill)
						c.UsedMana += amount;
				}

				return true;
			};

		public static Func<Controller, Minion, bool> ReturnToHandBlock
			=> delegate (Controller c, Minion minion)
			{
				if (!RemoveFromZone.Invoke(c, minion))
					return false;

				// reset minion
				minion.Reset();

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ReturnToHandBlock", !c.Game.Logging ? "" : $"{c.Name} gets {minion} returned.");

				if (!AddHandPhase.Invoke(c, minion))
					return false;

				return true;
			};

		public static Func<Controller, IPlayable, bool> RemoveFromZone
			=> delegate (Controller c, IPlayable playable)
			{
				playable.Zone.Remove(playable);
				return true;
			};

		public static Func<Controller, IPlayable, bool> AddHandPhase
			=> delegate (Controller c, IPlayable playable)
			{
				if (c.HandZone.IsFull)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", !c.Game.Logging ? "" : $"Hand ist full. Card {playable} drawn is burnt to graveyard.");
					c.GraveyardZone.Add(playable);
					return false;
				}

				// add draw block show entity 
				if (c.Game.History && playable != null)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(playable));

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", !c.Game.Logging ? "" : $"adding to hand {playable}.");
				c.HandZone.Add(playable);

				return true;
			};

		public static Func<Controller, IPlayable, bool> DiscardBlock
			=> delegate (Controller c, IPlayable playable)
			{
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnDiscardTrigger(playable);
				IPlayable discard = c.HandZone.Remove(playable);
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscardBlock", !c.Game.Logging ? "" : $"{discard} is beeing discarded.");
				c.GraveyardZone.Add(discard);

				c.DiscardedEntities.Add(discard.Id);
				c.LastCardDiscarded = discard.Id;
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();
				return true;
			};

		public static Func<Controller, CardType, IPlayable> JoustBlock
			=> delegate (Controller c, CardType type)
			{
				IPlayable[] stack = c.DeckZone.GetAll(p => p.Card.Type == type);
				IPlayable[] opStack = c.Opponent.DeckZone.GetAll(p => p.Card.Type == type);

				IPlayable card = stack.Length > 0 ? Util.Choose(stack) : null;
				IPlayable cardOp = opStack.Length > 0 ? Util.Choose(opStack) : null;

				if (c.Game.History)
				{
					// TODO: should create new entities?

					var info = new List<int>();
					if (card != null)
					{
						info.Add(card.Id);
						card[GameTag.REVEALED] = 1;
					}
					if (cardOp != null)
					{
						info.Add(cardOp.Id);
						cardOp[GameTag.REVEALED] = 1;
					}
					if (card != null)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.FullEntity(card));
					if (cardOp != null)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.FullEntity(cardOp));
					if (card != null)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(card));
					if (cardOp != null)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(cardOp));
					var metaData = new PowerHistoryMetaData()
					{
						Type = MetaDataType.JOUST,

						Info = info
					};
					c.Game.PowerHistory.Add(metaData);
					if (card != null)
					{
						c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(card));
						card[GameTag.REVEALED] = 0;
					}
					if (cardOp != null)
					{
						c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(cardOp));
						cardOp[GameTag.REVEALED] = 0;
					}

					// if new entities are created, must be moved to setaside
				}

				bool success = (card?.Cost ?? -1) > (cardOp?.Cost ?? -1);
				c.Game.Log(LogLevel.INFO, BlockType.JOUST, "JoustBlock", !c.Game.Logging ? "" : $"{c.Name} initiatets joust with {card} {card?.Cost} vs. {cardOp?.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");

				// TODO shuffle deck .... or ... just let it be?
				return success ? card : null;
			};

		public static Func<Controller, IEntity, IPlayable, bool> ShuffleIntoDeck
			=> delegate (Controller c, IEntity sender, IPlayable playable)
			{
				if (c.DeckZone.IsFull)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ShuffleIntoDeck",
						!c.Game.Logging ? "" : "Can't add a card to full deck.");
					return false;
				}

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ShuffleIntoDeck", !c.Game.Logging ? "" : $"adding to deck {playable}.");

				// don't activate powers when shuffling cards back into the deck
				c.DeckZone.Add(playable, c.DeckZone.Count == 0 ? -1 : Util.Random.Next(c.DeckZone.Count + 1));

				if (sender is IPlayable p && c.Game.TriggerManager.HasShuffleIntoDeckTrigger)
				{
					EventMetaData temp = c.Game.CurrentEventData;

					c.Game.CurrentEventData = new EventMetaData(p, playable);

					c.Game.TriggerManager.OnShuffleIntoDeckTrigger(playable);

					c.Game.CurrentEventData = temp;
				}

				// add hide entity 
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(playable));

				return true;
			};

		public static Func<Controller, Card, Minion, bool> TransformBlock
			=> delegate (Controller c, Card card, Minion oldMinion)
			{
				if (oldMinion.Zone?.Type != Zone.PLAY)
					return false;

				if (!(Entity.FromCard(c, card) is Minion newMinion))
				{
					c.Game.Log(LogLevel.WARNING, BlockType.PLAY, "TransformBlock", !c.Game.Logging ? "" : $"missing final tranformation.");
					return false;
				}

				//oldMinion[GameTag.LINKED_ENTITY] = newMinion.Id;
				//newMinion[GameTag.LINKED_ENTITY] = oldMinion.Id;
				if (c.Game.CurrentEventData?.EventSource == oldMinion)
					c.Game.CurrentEventData.EventSource = newMinion;

				c.BoardZone.Replace(oldMinion, newMinion);
				if (!newMinion.HasCharge)
					newMinion.IsExhausted = true;

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "TransformBlock", !c.Game.Logging ? "" : $"{oldMinion} got transformed into {newMinion}.");
				return true;
			};

		/// <summary>
		/// Controller, Card, Creator, Target, ScriptTag1, ScriptTag2, UseEntityId
		/// </summary>
		public static Func<Controller, Card, IPlayable, IEntity, int, int, bool, bool> AddEnchantmentBlock
			=> delegate (Controller c, Card enchantmentCard, IPlayable creator, IEntity target, int num1, int num2, bool useEntityId)
			{
				Power power = enchantmentCard.Power;

				if (power.Enchant is OngoingEnchant && target is IPlayable entity && entity.OngoingEffect is OngoingEnchant ongoingEnchant)
				{
					ongoingEnchant.Count++;
					return true;
				}

				if (c.Game.History)
				{
					Enchantment enchantment = Enchantment.GetInstance(in c, in creator, in target, in enchantmentCard);

					if (num1 > 0)
					{
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = num1;
						if (num2 > 0)
							enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] = num2;
					}

					power.Aura?.Activate(enchantment);
					power.Trigger?.Activate(enchantment);
					power.Enchant?.ActivateTo(target, enchantment);

					if (power.Enchant?.RemoveWhenPlayed ?? false)
						Enchant.RemoveWhenPlayedTrigger.Activate(enchantment);

					if (power.DeathrattleTask != null)
						((IPlayable)target).HasDeathrattle = true;

					if (useEntityId)
						enchantment.CapturedCard = c.Game.IdEntityDic[num1].Card;
				}
				else
				{
					if (power.Aura != null || power.Trigger != null || power.DeathrattleTask != null)
					{
						Enchantment instance = Enchantment.GetInstance(in c, in creator, in target, in enchantmentCard);
						if (num1 > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = num1;
							if (num2 > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = num2;
						}
						power.Aura?.Activate(instance);
						power.Trigger?.Activate(instance);

						if (power.Enchant?.RemoveWhenPlayed ?? false)
							Enchant.RemoveWhenPlayedTrigger.Activate(instance);

						if (useEntityId)
							instance.CapturedCard = c.Game.IdEntityDic[num1].Card;
					}

					//	no indicator enchantment entities when History option is off
					power.Enchant?.ActivateTo(target, null, num1, num2);
				}
				return true;
			};

		public static Func<Controller, IPlayable, Card, bool, IPlayable> ChangeEntityBlock
			=> delegate(Controller c, IPlayable p, Card newCard, bool removeEnchantments)
			{
				c.Game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "ChangeEntityBlock",
					!c.Game.Logging ? "" : $"{p} is changed into {newCard}.");

				//if (!(p.Zone is HandZone hand))
				//	throw new InvalidOperationException($"{p} is not in Hand. ({p.Zone})");

				if (removeEnchantments)
				{
					// 12.0 Game Mechanics Update: Clear all applied enchantments when shifting
					if (p.AppliedEnchantments != null)
						for (int i = p.AppliedEnchantments.Count - 1; i >= 0; i--)
							p.AppliedEnchantments[i].Remove();

					if (p is Minion m)
					{
						m._modifiedATK = m.Card.ATK;
						m._modifiedHealth = m.Card.Health;
					}

					((Playable)p).ResetCost();
				}

				p.ActivatedTrigger?.Remove();
				p.OngoingEffect?.Remove();

				HandZone hand = p.Zone as HandZone;
				BoardZone board = p.Zone as BoardZone;

				// Detach the target from Auras
				if (hand != null)
					hand.Auras.ForEach(a => a.Detach(p.Id));
				else if
					(board != null)
					board.Auras.ForEach(a => a.Detach(p.Id));


				// TODO: PowerHistoryChangeEntity
				// send tag variations and the id of the new Card
				// Tag.REAL_TIME_TRANSFORM = 0

				if (p.Card.Type == newCard.Type)
					p.Card = newCard;
				else
				{
					IPlayable entity;
					switch (newCard.Type)
					{
						case CardType.MINION:
							entity = new Minion(c, newCard, p.NativeTags, p.Id);
							break;
						case CardType.SPELL:
							entity = new Spell(c, newCard, p.NativeTags, p.Id);
							break;
						case CardType.HERO:
							entity = new Hero(c, newCard, p.NativeTags, p.Id);
							break;
						case CardType.WEAPON:
							entity = new Weapon(c, newCard, p.NativeTags, p.Id);
							break;
						default:
							throw new ArgumentNullException();
					}

					if (hand != null)
						hand.ChangeEntity(p, entity);
					else if
						(board != null)
						board.ChangeEntity((Minion)p, (Minion)entity);
					else if (p.Zone is DeckZone deck)
						entity.Zone = deck;
					
					c.Game.IdEntityDic[p.Id] = entity;
					p = entity;
				}

				if (newCard.ChooseOne)
				{
					if (p.ChooseOnePlayables == null)
						p.ChooseOnePlayables = new IPlayable[2];

					EntityData tags = null;
					if (c.Game.History)
					{
						tags = new EntityData
						{
							{GameTag.CREATOR, p.Id},
							{GameTag.PARENT_CARD, p.Id}
						};
					}

					p.ChooseOnePlayables[0] = Entity.FromCard(c, Cards.FromId(newCard.Id + "a"), tags, c.SetasideZone);
					p.ChooseOnePlayables[1] = Entity.FromCard(c, Cards.FromId(newCard.Id + "b"), tags, c.SetasideZone);
				}

				switch (p.Zone.Type)
				{
					case Zone.HAND:
						p.Power?.Trigger?.Activate(p, TriggerActivation.HAND);
						if (p.Power?.Aura is AdaptiveCostEffect e)
							e.Activate((Playable)p);
						break;
					case Zone.DECK:
						p.Power?.Trigger?.Activate(p, TriggerActivation.DECK);
						break;
					case Zone.PLAY:
						BoardZone.ActivateAura((Minion) p);
						break;
				}


				// Reapply auras
				if (hand != null)
					hand.Auras.ForEach(a => a.EntityAdded(p));
				else if
					(board != null)
					board.Auras.ForEach(a => a.EntityAdded(p));

				// Not sure C'Thun from Shifter Zerus will have Proxy's buffs

				return p;
			};

		// Work in progress
		public static void RevealCardBlock(IPlayable source, IPlayable target)
		{
			Game game = source.Game;
			if (!game.History) return;

			game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.REVEAL_CARD, source.Id, "", 0, target.Id));
			target.NativeTags[GameTag.REVEALED] = 1;
			game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(target));
			game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(target));
			target[GameTag.REVEALED] = 0;
			// ShowEntity with Zone = SETASIDE ????
		}

		// TODO: Posionous Block
		public static Func<bool, ICharacter, ICharacter, bool> PoisonousBlock
			=> delegate(bool history, ICharacter source, ICharacter target)
			{
				if (source[GameTag.POISONOUS] != 1)
					return false;

				if (history)
				{
					source.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.TRIGGER, source.Id, "", -1,
						0)); //	SubOption = -1, TriggerKeyWord = POISONOUS
					//[DebugPrintPower] META_DATA - Meta=TARGET Data = 0 Info=1
					//[DebugPrintPower] Info[0] = [entityName=Goldshire Footman id=47 zone=PLAY zonePos=1 cardId=CS1_042 player=2]
				}

				target.ToBeDestroyed = true;


				if (history)
					source.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
