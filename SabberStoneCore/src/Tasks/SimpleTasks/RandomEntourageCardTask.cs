using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomEntourageTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || source.Card.Entourage.Count < 1)
			{
				return TaskState.STOP;
			}

			IPlayable randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose(source.Card.Entourage)));
			Playables.Add(randomCard);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RandomEntourageTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}