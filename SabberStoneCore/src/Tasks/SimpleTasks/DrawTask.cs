using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawTask : SimpleTask
	{
		private readonly int _count;
		private readonly bool _toStack;

		public DrawTask(bool toStack = false, int count = 1)
		{
			_toStack = toStack;
			_count = count;
		}

		public DrawTask(int count) : this(false, count)
		{
		}


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//Model.Entities.IPlayable drawedCard = Generic.Draw(controller);
			bool nullFlag = false;
			var cards = new IPlayable[_count];
			for (int i = 0; i < _count; i++)
			{
				IPlayable draw = Generic.Draw(controller);
				if (draw == null)
					nullFlag = true;
				cards[i] = draw;
			}

			if (cards[0] == null) return TaskState.COMPLETE;

			if (_toStack)
			{
				if (nullFlag)
					stack?.Playables.AddRange(cards.Where(p => p != null));
				else
					stack?.Playables.AddRange(cards);
			}

			return TaskState.COMPLETE;
		}
	}
}
