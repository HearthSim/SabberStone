using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawOpTask : SimpleTask
	{
		public DrawOpTask(Card card = null, bool toStack = false)
		{
			Card = card;
			ToStack = toStack;
		}

		public Card Card { get; set; }

		public bool ToStack { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			IPlayable drawedCard = Card != null
				? Generic.DrawCardBlock.Invoke(controller.Opponent, Card)
				: Generic.Draw(controller.Opponent);
			if (ToStack && drawedCard != null) stack?.Playables.Add(drawedCard);

			return TaskState.COMPLETE;
		}
	}
}
