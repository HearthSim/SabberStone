using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonOpTask : SimpleTask
	{
		public SummonOpTask(Card card = null)
		{
			Card = card;
		}

		public SummonOpTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

		public Card Card { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (controller.Opponent.BoardZone.IsFull)
				return TaskState.STOP;

			if (Card == null && stack?.Playables.Count < 1)
				return TaskState.STOP;

			Minion summonEntity = Card != null
				? Entity.FromCard(controller.Opponent, Card) as Minion
				: stack?.Playables[0] as Minion;

			if (summonEntity == null)
				return TaskState.STOP;

			bool success = Generic.SummonBlock.Invoke(game, summonEntity, -1);

			return TaskState.COMPLETE;
		}
	}
}
