using System;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Actions
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
                var playable = c.Deck.Remove(cardToDraw ?? c.Deck[0]);
                c.NumCardsDrawnThisTurn++;
                c.Game.Log(LogLevel.INFO, BlockType.ACTION, "DrawPhase", $"{c.Name} draws {playable}");
                return playable;
            };
    }
}