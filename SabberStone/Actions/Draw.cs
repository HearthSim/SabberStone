using System;
using System.Linq;
using System.Reflection;
using log4net;
using SabberStone.Model;

namespace SabberStone.Actions
{
    public partial class Generic
    {
        public static IPlayable DrawCard(Controller c, Card card)
        {
            return DrawCardBlock.Invoke(c, card);
        }

        public static IPlayable Draw(Controller c, IPlayable cardToDraw = null)
        {
            return DrawBlock.Invoke(c, cardToDraw);
        }

        public static Func<Controller, Card, IPlayable> DrawCardBlock
            => delegate(Controller c, Card card)
            {
                var playable = Entity.FromCard(c, card);
                c.NumCardsDrawnThisTurn++;
                AddHandPhase.Invoke(c, playable);
                return playable;
            };

        public static Func<Controller, IPlayable, IPlayable> DrawBlock
            => delegate(Controller c, IPlayable cardToDraw)
            {
                if (!PreDrawPhase.Invoke(c))
                    return null;
                var playable = DrawPhase.Invoke(c, cardToDraw);
                AddHandPhase.Invoke(c, playable);
                return playable;
            };

        private static Func<Controller, bool> PreDrawPhase
            => delegate(Controller c)
            {
                if (c.Deck.IsEmpty)
                {
                    var fatigueDamage = c.Hero.Fatigue == 0 ? 1 : c.Hero.Fatigue * 2;
                    DamageCharFunc(c.Hero, c.Hero, fatigueDamage, 0);
                    return false;
                }
                return true;
            };

        private static Func<Controller, IPlayable, IPlayable> DrawPhase
            => delegate(Controller c, IPlayable cardToDraw)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                var playable = c.Deck.Remove(cardToDraw == null ? c.Deck[0] : c.Deck.First(p => p.Id == cardToDraw.Id));
                c.NumCardsDrawnThisTurn++;
                log.Info($"[DrawPhase] {c.Name} draws {playable}.");
                c.Game.PlayTaskLog.AppendLine($"[DrawPhase] {c.Name} draws {playable}.");
                return playable;
            };
    }
}