using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawCardTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Playables.Count != 1)
			{
				return TaskState.STOP;
			}

			IPlayable drawedCard = Generic.Draw(Controller, Playables[0]);

			if (drawedCard == null)
			{
				return TaskState.STOP;
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new DrawCardTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}