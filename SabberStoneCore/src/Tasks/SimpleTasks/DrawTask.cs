using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		public DrawTask(bool toStack = false, int count = 1)
		{
			ToStack = toStack;
			_count = count;
		}

		public bool ToStack { get; set; }
		private readonly int _count;

		public override TaskState Process()
		{
			//Model.Entities.IPlayable drawedCard = Generic.Draw(Controller);
			var cards = new IPlayable[_count];
			for (int i = 0; i < _count; i++)
				cards[i] = Generic.Draw(Controller);

			if (cards[0] == null)
			{
				return TaskState.COMPLETE;
			}

			if (ToStack)
			{
				Playables.Add(cards[0]);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DrawTask(ToStack, _count);
			clone.Copy(this);
			return clone;
		}
	}
}
