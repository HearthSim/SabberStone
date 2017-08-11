using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomEntourageTask : SimpleTask
	{
		public override TaskState Process()
		{

			var source = Source as IPlayable;
			if (source == null || source.Card.Entourage.Count < 1)
			{
				return TaskState.STOP;
			}

			var randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose<string>(source.Card.Entourage)));
			Playables.Add(randomCard);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomEntourageTask();
			clone.Copy(this);
			return clone;
		}
	}
}