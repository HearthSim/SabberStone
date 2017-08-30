using System;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
			=> delegate (Controller c, Card card)
			{
				IPlayable playable = Entity.FromCard(c, card);
				//c.NumCardsDrawnThisTurn++;
				AddHandPhase.Invoke(c, playable);
				return playable;
			};

		public static Func<Controller, IPlayable, IPlayable> DrawBlock
			=> delegate (Controller c, IPlayable cardToDraw)
			{
				if (!PreDrawPhase.Invoke(c))
					return null;

				IPlayable playable = DrawPhase.Invoke(c, cardToDraw);
				//c.NumCardsToDraw--; 

				AddHandPhase.Invoke(c, playable);

				return playable;
			};

		private static Func<Controller, bool> PreDrawPhase
			=> delegate (Controller c)
			{
				if (c.DeckZone.IsEmpty)
				{
					int fatigueDamage = c.Hero.Fatigue == 0 ? 1 : c.Hero.Fatigue + 1;
					DamageCharFunc(c.Hero, c.Hero, fatigueDamage, 0);
					return false;
				}
				return true;
			};

		private static Func<Controller, IPlayable, IPlayable> DrawPhase
			=> delegate (Controller c, IPlayable cardToDraw)
			{
				IPlayable playable = c.DeckZone.Remove(cardToDraw ?? c.DeckZone[0]);
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "DrawPhase", $"{c.Name} draws {playable}");

				c.NumCardsDrawnThisTurn++;
				c.LastCardDrawn = playable.Id;

				return playable;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
