using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		private readonly bool _toStack;
		private readonly int _count;

		public DrawTask(bool toStack = false, int count = 1)
		{
			_toStack = toStack;
			_count = count;
		}

		public DrawTask(int count) : this(false, count)
		{
		}


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

			if (_toStack)
			{
				Playables.Add(cards[0]);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DrawTask(_toStack, _count);
			clone.Copy(this);
			return clone;
		}
	}
}
