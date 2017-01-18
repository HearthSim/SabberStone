using System;
using System.Reflection;
using log4net;
using SabberStone.Model;

namespace SabberStone.Actions
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

        public static Func<Controller, int, bool> ChangeManaCrystal
            => delegate(Controller c, int amount)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                if (c.BaseMana + amount > c.MaxResources)
                {
                    log.Info($"{c.Name} is already capped in {c.MaxResources} mana crystals.");
                    c.Game.PlayTaskLog.AppendLine($"{c.Name} is already capped in {c.MaxResources} mana crystals.");
                    c.UsedMana += c.MaxResources - c.BaseMana;
                    c.BaseMana = c.MaxResources;
                }
                else if (c.BaseMana + amount < 0)
                {
                    log.Info($"{c.Name} is back to minimum of 0 mana crystals.");
                    c.Game.PlayTaskLog.AppendLine($"{c.Name} is back to minimum of 0 mana crystals.");
                    c.BaseMana = 0;
                }
                else
                {
                    c.BaseMana += amount;
                    c.UsedMana += amount;
                }
                return true;
            };

        public static Func<Controller, Minion, bool> ReturnToHandBlock
            => delegate(Controller c, Minion minion)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                if (!RemoveFromZone.Invoke(c, minion))
                    return false;
                log.Info($"[ReturnToHandBlock] {c.Name} gets {minion} returned.");
                c.Game.PlayTaskLog.AppendLine($"[ReturnToHandBlock] {c.Name} gets {minion} returned.");
                if (!AddHandPhase.Invoke(c, minion))
                    return false;
                return true;
            };

        public static Func<Controller, IPlayable, bool> RemoveFromZone
            => delegate(Controller c, IPlayable playable)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                playable.Zone.Remove(playable);
                return true;
            };

        public static Func<Controller, IPlayable, bool> AddHandPhase
            => delegate(Controller c, IPlayable playable)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                if (c.Hand.IsFull)
                {
                    log.Info($"[AddHandPhase] Hand ist full. Card {playable} drawn is burnt to graveyard.");
                    c.Game.PlayTaskLog.AppendLine($"[AddHandPhase] Hand ist full. Card {playable} drawn is burnt to graveyard.");
                    c.Graveyard.Add(playable);
                    return false;
                }
                log.Info($"[AddHandPhase] adding to hand {playable}.");
                c.Game.PlayTaskLog.AppendLine($"[AddHandPhase] adding to hand {playable}.");
                c.Hand.Add(playable);
                return true;
            };

        public static Func<Controller, IPlayable, bool> DiscardBlock
            => delegate(Controller c, IPlayable playable)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                var discard = c.Hand.Remove(playable);
                log.Info($"[DiscardBlock] {discard} is beeing discarded.");
                c.Game.PlayTaskLog.AppendLine($"[DiscardBlock] {discard} is beeing discarded.");
                c.Graveyard.Add(discard);
                return true;
            };

        public static Func<Controller, bool> JoustBlock
            => delegate (Controller c)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                if (c.Deck.Count == 0)
                {
                    return false;
                }

                if (c.Opponent.Deck.Count == 0)
                {
                    return true;
                }

                var card = Util<IPlayable>.Choose(c.Deck.GetAll);
                var cardOp = Util<IPlayable>.Choose(c.Opponent.Deck.GetAll);
                var success = card.Cost > cardOp.Cost;
                log.Info($"[JoustBlock] {c.Name} initiatets joust with {card} {card.Cost} vs. {cardOp.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");
                c.Game.PlayTaskLog.AppendLine($"[JoustBlock] {c.Name} initiatets joust with {card} {card.Cost} vs. {cardOp.Cost} {cardOp}, {(success ? "Won" : "Loose")} the joust.");
                // TODO shuffle deck .... or ... just let it be?
                return success;
            };

        public static Func<Controller, IPlayable, bool> ShuffleIntoDeck
            => delegate (Controller c, IPlayable playable)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                log.Info($"[ShuffleIntoDeck] adding to deck {playable}.");
                c.Game.PlayTaskLog.AppendLine($"[ShuffleIntoDeck] adding to deck {playable}.");
                c.Deck.Add(playable, c.Deck.Count == 0 ? -1 : Util.Random.Next(c.Deck.Count + 1));
                return true;
            };

        public static Func<Controller, Card, Minion, bool> TransformBlock
            => delegate(Controller c, Card card, Minion oldMinion)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                var newMinion = Entity.FromCard(c, card) as Minion;
                if (newMinion == null)
                {
                    log.Info("[TransformBlock] missing final tranformation.");
                    c.Game.PlayTaskLog.AppendLine("[TransformBlock] missing final tranformation.");
                    return false;
                }
                if (!newMinion.HasCharge)
                    newMinion.IsExhausted = true;
                var oldEntity = oldMinion.Zone.Replace(oldMinion, newMinion);
                oldMinion.Controller.Setaside.Add(oldEntity);
                log.Info($"[TransformBlock] {oldEntity} got transformed into {newMinion}.");
                c.Game.PlayTaskLog.AppendLine($"[TransformBlock] {oldEntity} got transformed into {newMinion}.");
                return true;
            };
    }
}