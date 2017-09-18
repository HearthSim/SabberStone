using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		public DrawTask(bool toStack = false)
		{
			ToStack = toStack;
		}

		public bool ToStack { get; set; }

		public override TaskState Process()
		{
			Model.Entities.IPlayable drawedCard = Generic.Draw(Controller);

			if (drawedCard == null)
			{
				return TaskState.COMPLETE;
			}

			if (ToStack)
			{
				Playables.Add(drawedCard);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DrawTask(ToStack);
			clone.Copy(this);
			return clone;
		}
	}
}
