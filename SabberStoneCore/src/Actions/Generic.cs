using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	/// <summary>
	/// Container of game logic functionality, which is invoked by processing a selected option
	/// through <see cref="Game.Process(Tasks.PlayerTask)"/>.
	/// </summary>
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<IPlayable, ICharacter, int, bool, int> DamageCharFunc
			=> (source, target, amount, applySpellDmg) =>
			{
				if (applySpellDmg)
				{
					amount += ((Spell) source).ReceveivesDoubleSpellDamage
						? source.Controller.CurrentSpellPower * 2
						: source.Controller.CurrentSpellPower;
					if (source.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE] > 0)
						amount *= (int)Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.SPELLPOWER_DOUBLE]);
				}
				else if (source is HeroPower)
				{
					amount += source.Controller.Hero.HeroPowerDamage;
					if (source.Controller.ControllerAuraEffects[GameTag.HERO_POWER_DOUBLE] > 0)
						amount *= (int) Math.Pow(2, source.Controller.ControllerAuraEffects[GameTag.HERO_POWER_DOUBLE]);
				}
				return target.TakeDamage(source, amount);
			};

		public static Func<Controller, int, bool> AddTempMana
			=> delegate (Controller c, int amount)
			{
				if (c.BaseMana + c.TemporaryMana + amount > 10)
					c.TemporaryMana += 10 - c.BaseMana;
				else
					c.TemporaryMana += amount;
				return true;
			};

		public static Func<Controller, int, bool, bool> ChangeManaCrystal
			=> delegate (Controller c, int amount, bool fill)
			{
				if (c.BaseMana + amount > c.MaxResources)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", !c.Game.Logging? "":$"{c.Name} is already capped in {c.MaxResources} mana crystals.");
					c.UsedMana += c.MaxResources - c.BaseMana;
					c.BaseMana = c.MaxResources;
				}
				else if (c.BaseMana + amount < 0)
				{
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", !c.Game.Logging? "":$"{c.Name} is back to minimum of 0 mana crystals.");
					c.BaseMana = 0;
				}
				else
				{
					c.BaseMana += amount;
					c.UsedMana += amount;
				}

				if (fill)
				{
					c.UsedMana = 0;
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

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ReturnToHandBlock", !c.Game.Logging? "":$"{c.Name} gets {minion} returned.");

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
					c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", !c.Game.Logging? "":$"Hand ist full. Card {playable} drawn is burnt to graveyard.");
					c.GraveyardZone.Add(playable);
					return false;
				}

				// add draw block show entity 
				if (c.Game.History && playable != null)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(playable));

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", !c.Game.Logging? "":$"adding to hand {playable}.");
				c.HandZone.Add(playable);

				return true;
			};

		public static Func<Controller, IPlayable, bool> DiscardBlock
			=> delegate (Controller c, IPlayable playable)
			{
				c.Game.TriggerManager.OnDiscardTrigger(playable);
				IPlayable discard = c.HandZone.Remove(playable);
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscardBlock", !c.Game.Logging? "":$"{discard} is beeing discarded.");
				c.GraveyardZone.Add(discard);

				c.LastCardDiscarded = discard.Id;

				return true;
			};

		public static Func<Controller, IPlayable> JoustBlock
			=> delegate (Controller c)
			{
				if (c.DeckZone.Count == 0)
				{
					return null;
				}

				if (c.Opponent.DeckZone.Count == 0)
				{
					return null;
				}

				IPlayable card = c.DeckZone.Random;
				IPlayable cardOp = c.Opponent.DeckZone.Random;
				bool success = card.Cost > cardOp.Cost;
				c.Game.Log(LogLevel.INFO, BlockType.JOUST, "JoustBlock", !c.Game.Logging? "":$"{c.Name} initiatets joust with {card} {card.Cost} vs. {cardOp.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");

				// TODO shuffle deck .... or ... just let it be?
				return success ? card : null;
			};

		public static Func<Controller, IPlayable, bool> ShuffleIntoDeck
			=> delegate (Controller c, IPlayable playable)
			{
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ShuffleIntoDeck", !c.Game.Logging? "":$"adding to deck {playable}.");

				// don't activate powers when shuffling cards back into the deck
				c.DeckZone.Add(playable, c.DeckZone.Count == 0 ? -1 : Util.Random.Next(c.DeckZone.Count + 1), false);

				// add hide entity 
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(playable));

				return true;
			};

		public static Func<Controller, Card, Minion, bool> TransformBlock
			=> delegate (Controller c, Card card, Minion oldMinion)
			{
				if (!(Entity.FromCard(c, card) is Minion newMinion))
				{
					c.Game.Log(LogLevel.WARNING, BlockType.PLAY, "TransformBlock", !c.Game.Logging? "":$"missing final tranformation.");
					return false;
				}

				c.BoardZone.Replace(oldMinion, newMinion);
				if (!newMinion.HasCharge)
					newMinion.IsExhausted = true;

				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "TransformBlock", !c.Game.Logging? "":$"{oldMinion} got transformed into {newMinion}.");
				return true;
			};

		public static Func<Controller, Card, IPlayable, IEntity, int, int, bool> AddEnchantmentBlock
			=> delegate(Controller c, Card enchantmentCard, IPlayable creator, IEntity target, int num1, int num2)
			{
				Power power = enchantmentCard.Power;

				if (power.Enchant is OngoingEnchant && target is IPlayable entity && entity.OngoingEffect != null)
				{
					((OngoingEnchant)(entity.OngoingEffect)).Count++;
					return true;
				}

				if (c.Game.History)
				{
					Enchantment enchantment = Enchantment.GetInstance(c, creator, target, enchantmentCard);

					if (num1 > 0)
					{
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = num1;
						if (num2 > 0)
							enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] = num2;
					}

					power.Aura?.Activate(enchantment);
					power.Trigger?.Activate(enchantment);
					power.Enchant?.ActivateTo(target, enchantment);

					if (power.DeathrattleTask != null)
						((IPlayable)target).HasDeathrattle = true;
				}
				else
				{
					if (power.Aura != null || power.Trigger != null || power.DeathrattleTask != null)
					{
						Enchantment instance = Enchantment.GetInstance(c, creator, target, enchantmentCard);
						power.Aura?.Activate(instance);
						power.Trigger?.Activate(instance);
					}

					//	no indicator enchantment entities when History option is off
					power.Enchant?.ActivateTo(target, null, num1, num2);

					if (power.DeathrattleTask != null)
						((IPlayable)target).HasDeathrattle = true;
				}

				return true;
			};

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
