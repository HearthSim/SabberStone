using System;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Actions
{
    public partial class Generic
    {
        public static Func<IPlayable, ICharacter, int, int, bool> DamageCharFunc
            => (source, target, amount, spelldmg) => target.TakeDamage(source, amount + spelldmg);

        public static Func<Controller, int, bool> AddTempMana
            => delegate(Controller c, int amount)
            {
                if (c.BaseMana + c.TemporaryMana + amount > 10)
                    c.TemporaryMana += 10 - c.BaseMana;
                else
                    c.TemporaryMana += amount;
                return true;
            };

        public static Func<Controller, int, bool, bool> ChangeManaCrystal
            => delegate(Controller c, int amount, bool fill)
            {
                if (c.BaseMana + amount > c.MaxResources)
                {
                    c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", $"{c.Name} is already capped in {c.MaxResources} mana crystals.");
                    c.UsedMana += c.MaxResources - c.BaseMana;
                    c.BaseMana = c.MaxResources;
                }
                else if (c.BaseMana + amount < 0)
                {
                    c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ChangeManaCrystal", $"{c.Name} is back to minimum of 0 mana crystals.");
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
            => delegate(Controller c, Minion minion)
            {
                if (!RemoveFromZone.Invoke(c, minion))
                    return false;

                // reset minion
                minion.Reset();

                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ReturnToHandBlock", $"{c.Name} gets {minion} returned.");

                if (!AddHandPhase.Invoke(c, minion))
                    return false;

                return true;
            };

        public static Func<Controller, IPlayable, bool> RemoveFromZone
            => delegate(Controller c, IPlayable playable)
            {
                playable.Zone.Remove(playable);
                return true;
            };

        public static Func<Controller, IPlayable, bool> AddHandPhase
            => delegate(Controller c, IPlayable playable)
            {
                if (c.Hand.IsFull)
                {
                    c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", $"Hand ist full. Card {playable} drawn is burnt to graveyard.");
                    c.Graveyard.Add(playable);
                    return false;
                }
                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "AddHandPhase", $"adding to hand {playable}.");
                c.Hand.Add(playable);
                return true;
            };

        public static Func<Controller, IPlayable, bool> DiscardBlock
            => delegate(Controller c, IPlayable playable)
            {
                var discard = c.Hand.Remove(playable);
                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "DiscardBlock", $"{discard} is beeing discarded.");
                c.Graveyard.Add(discard);

                c.LastCardDiscarded = discard.Id;

                return true;
            };

        public static Func<Controller, IPlayable> JoustBlock
            => delegate (Controller c)
            {
                if (c.Deck.Count == 0)
                {
                    return null;
                }

                if (c.Opponent.Deck.Count == 0)
                {
                    return null;
                }

                var card = Util<IPlayable>.Choose(c.Deck.GetAll);
                var cardOp = Util<IPlayable>.Choose(c.Opponent.Deck.GetAll);
                var success = card.Cost > cardOp.Cost;
                c.Game.Log(LogLevel.INFO, BlockType.JOUST, "JoustBlock", $"{c.Name} initiatets joust with {card} {card.Cost} vs. {cardOp.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");
                
                // TODO shuffle deck .... or ... just let it be?
                return success ? card : null;
            };

        public static Func<Controller, IPlayable, bool> ShuffleIntoDeck
            => delegate (Controller c, IPlayable playable)
            {
                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "ShuffleIntoDeck", $"adding to deck {playable}.");
                c.Deck.Add(playable, c.Deck.Count == 0 ? -1 : Util.Random.Next(c.Deck.Count + 1));
                
                // add hide entity 
                if (c.Game.History)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.HideEntity(playable));

                return true;
            };

        public static Func<Controller, Card, Minion, bool> TransformBlock
            => delegate(Controller c, Card card, Minion oldMinion)
            {
                var newMinion = Entity.FromCard(c, card) as Minion;
                if (newMinion == null)
                {
                    c.Game.Log(LogLevel.WARNING, BlockType.PLAY, "TransformBlock", $"missing final tranformation.");
                    return false;
                }
                if (!newMinion.HasCharge)
                    newMinion.IsExhausted = true;
                var oldEntity = oldMinion.Zone.Replace(oldMinion, newMinion);
                oldMinion.Controller.Setaside.Add(oldEntity);
                c.Game.Log(LogLevel.INFO, BlockType.PLAY, "TransformBlock", $"{oldEntity} got transformed into {newMinion}.");
                return true;
            };
    }
}