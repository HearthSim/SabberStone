using System;
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
	public partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<IPlayable, ICharacter, int, bool, int> DamageCharFunc
			=> (source, target, amount, applySpellDmg) =>
			{
				if (applySpellDmg)
				{
					amount += ((Spell)source).ReceveivesDoubleSpellDamage
						? source.Controller.Hero.SpellPowerDamage * 2
						: source.Controller.Hero.SpellPowerDamage;
					if (source.Controller[GameTag.SPELLPOWER_DOUBLE] > 0)
						amount *= (int)Math.Pow(2, source.Controller[GameTag.SPELLPOWER_DOUBLE]);
				}
				else if (source is HeroPower)
				{
					amount += source.Controller.Hero.HeroPowerDamage;
					if (source.Controller[GameTag.HERO_POWER_DOUBLE] > 0)
						amount *= (int) Math.Pow(2, source.Controller[GameTag.HERO_POWER_DOUBLE]);
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

				IPlayable card = Util.Choose<IPlayable>(c.DeckZone.GetAll);
				IPlayable cardOp = Util.Choose<IPlayable>(c.Opponent.DeckZone.GetAll);
				bool success = card.Cost > cardOp.Cost;
				c.Game.Log(LogLevel.INFO, BlockType.JOUST, "JoustBlock", !c.Game.Logging? "":$"{c.Name} initiatets joust with {card} {card.Cost} vs. {cardOp.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");

				// TODO shuffle deck .... or ... just let it be?
				return success ? card : null;
			};

		public static Func<Controller, IPlayable, bool> ShuffleIntoDeck
			=> delegate (Controller c, IPlayable playable)
			{
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ShuffleIntoDeck", !c.Game.Logging? "":$"adding to deck {playable}.");

				// don't activate enchantments when shuffling cards back into the deck
				c.DeckZone.Add(playable, c.DeckZone.Count == 0 ? -1 : Util.Random.Next(c.DeckZone.Count + 1), false);

				// add hide entity 
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(playable));

				return true;
			};

		public static Func<Controller, Card, Minion, bool> TransformBlock
			=> delegate (Controller c, Card card, Minion oldMinion)
			{
				var newMinion = Entity.FromCard(c, card) as Minion;
				if (newMinion == null)
				{
					c.Game.Log(LogLevel.WARNING, BlockType.PLAY, "TransformBlock", !c.Game.Logging? "":$"missing final tranformation.");
					return false;
				}
				if (!newMinion.HasCharge)
					newMinion.IsExhausted = true;

				//newMinion.ApplyEnchantments(EnchantmentActivation.SETASIDE_ZONE, Zone.SETASIDE);
				newMinion.ApplyEnchantments(EnchantmentActivation.BOARD_ZONE, Zone.PLAY);
				newMinion.ApplyEnchantments(EnchantmentActivation.HAND_ZONE, Zone.HAND);
				newMinion.ApplyEnchantments(EnchantmentActivation.DECK_ZONE, Zone.DECK);

				IPlayable oldEntity = oldMinion.Zone.Replace(oldMinion, newMinion);
				oldMinion.Controller.SetasideZone.Add(oldEntity);
				c.Game.Log(LogLevel.INFO, BlockType.PLAY, "TransformBlock", !c.Game.Logging? "":$"{oldEntity} got transformed into {newMinion}.");
				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
