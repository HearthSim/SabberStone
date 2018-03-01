using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using System.Linq;

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
			bool nullFlag = false;
			var cards = new IPlayable[_count];
			for (int i = 0; i < _count; i++)
			{
				IPlayable draw = Generic.Draw(Controller);
				if (draw == null)
					nullFlag = true;
				cards[i] = draw;
			}

			if (cards[0] == null)
			{
				return TaskState.COMPLETE;
			}

			if (_toStack)
			{
				if (nullFlag)
				{
					Playables.AddRange(cards.Where(p => p != null));
				}
				else
					Playables.AddRange(cards);
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
