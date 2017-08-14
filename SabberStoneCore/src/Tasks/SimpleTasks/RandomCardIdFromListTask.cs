using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomCardIdFromListTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (CardIds.Count == 0)
				return TaskState.STOP;

			IPlayable randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose(CardIds)));
			Playables.Add(randomCard);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RandomCardIdFromListTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}