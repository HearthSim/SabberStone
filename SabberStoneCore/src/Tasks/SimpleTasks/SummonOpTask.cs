using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonOpTask : SimpleTask
	{
		public Card Card { get; set; }

		public SummonOpTask(Card card = null)
		{
			Card = card;
		}

		public SummonOpTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Controller.Opponent.BoardZone.IsFull)
				return TaskState.STOP;

			if (Card == null && Playables.Count < 1)
				return TaskState.STOP;

			Minion summonEntity = Card != null ?
				Entity.FromCard(Controller.Opponent, Card) as Minion :
				Playables[0] as Minion;

			if (summonEntity == null)
				return TaskState.STOP;

			bool success = Generic.SummonBlock.Invoke(Controller.Opponent, summonEntity, -1);

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(SummonOpTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SummonOpTask(Card);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}