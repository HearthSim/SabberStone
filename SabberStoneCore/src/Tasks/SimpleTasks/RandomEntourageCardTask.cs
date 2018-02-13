using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomEntourageTask : SimpleTask
	{
		public override TaskState Process()
		{

			var source = Source as IPlayable;
			if (source == null || source.Card.Entourage.Length < 1)
			{
				return TaskState.STOP;
			}

			IPlayable randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose<string>(source.Card.Entourage)));
			Playables = new List<IPlayable> { randomCard };

			Game.OnRandomHappened(true);

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
