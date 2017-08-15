using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		public bool ToStack { get; set; }

		public DrawTask(bool toStack = false)
		{
			ToStack = toStack;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IPlayable drawedCard = Generic.Draw(Controller);

			if (drawedCard == null)
			{
				return TaskState.STOP;
			}

			if (ToStack)
			{
				Playables.Add(drawedCard);
			}

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(DrawTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DrawTask(ToStack);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}