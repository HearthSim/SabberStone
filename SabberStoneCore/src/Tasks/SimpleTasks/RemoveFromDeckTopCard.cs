using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromDeckTopCard : SimpleTask
	{
		public RemoveFromDeckTopCard()
		{
		}

		public override TaskState Process()
		{
			if (Controller.DeckZone.Count == 0)
				return TaskState.STOP;

			IPlayable playable = Controller.DeckZone.Remove(Controller.DeckZone[0]);
			Playables = new List<IPlayable>() { playable };
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RemoveFromDeckTopCard();
			clone.Copy(this);
			return clone;
		}
	}
}
