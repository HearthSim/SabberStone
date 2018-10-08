using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RecruitTask : SimpleTask
	{
		private readonly SelfCondition[] _conditions;

		public RecruitTask(bool recruitFromStack = false, SummonSide side = SummonSide.DEFAULT,
			bool removeFromStack = false)
		{
			Side = side;
			RemoveFromStack = removeFromStack;
			RecruitFromStack = recruitFromStack;
		}

		/// <summary>
		///     Recruits a random minion satisfying the given conditions.
		/// </summary>
		/// <param name=""></param>
		public RecruitTask(params SelfCondition[] conditions)
		{
			_conditions = conditions;
		}

		public SummonSide Side { get; set; }
		public bool RemoveFromStack { get; set; }
		public bool RecruitFromStack { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			Minion summonEntity = null;
			if (controller.BoardZone.IsFull) return TaskState.STOP;

			if (_conditions != null)
			{
				IPlayable[] candidates = controller.DeckZone.GetAll(p =>
				{
					if (!(p is Minion)) return false;

					bool flag = true;
					for (int i = 0; i < _conditions.Length; i++)
						flag &= _conditions[i].Eval(p);
					return flag;
				});

				if (candidates.Length == 0)
					return TaskState.STOP;

				summonEntity = (Minion) Util.Choose(candidates);
			}
			else if (RecruitFromStack)
			{
				var playableMinions = new List<Minion>();
				foreach (IPlayable entity in stack.Playables)
					if (entity.Zone.Type == Zone.DECK && entity is Minion)
						playableMinions.Add((Minion) entity);

				if (playableMinions.Count > 0)
				{
					summonEntity = Util.Choose(playableMinions);
					if (RemoveFromStack) stack.Playables.Remove(summonEntity);
				}
			}
			else
			{
				var playableMinions = new List<Minion>();
				foreach (IPlayable entity in controller.DeckZone)
					if (entity.Zone.Type == Zone.DECK && entity is Minion)
						playableMinions.Add((Minion) entity);

				if (playableMinions.Count > 0) summonEntity = Util.Choose(playableMinions);
			}

			if (summonEntity == null) return TaskState.STOP;

			Generic.RemoveFromZone.Invoke(summonEntity.Controller, summonEntity);

			int c = 0;
			int summonPosition = SummonTask.GetPosition(in source, Side, stack?.Number ?? 0, ref c);

			bool success = Generic.SummonBlock.Invoke(controller, summonEntity, summonPosition);

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
