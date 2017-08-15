using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(DrawCardTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DrawCardTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}