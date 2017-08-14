using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawOpTask : SimpleTask
	{
		public Card Card { get; set; }

		public bool ToStack { get; set; }

		public DrawOpTask(Card card = null, bool toStack = false)
		{
			Card = card;
			ToStack = toStack;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IPlayable drawedCard = Card != null ? Generic.DrawCardBlock.Invoke(Controller.Opponent, Card) : Generic.Draw(Controller.Opponent);
			if (ToStack && drawedCard != null)
			{
				Playables.Add(drawedCard);
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DrawOpTask(Card, ToStack);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}