using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SplitTask : SimpleTask
	{
		public SplitTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			//if (entities.Count == 0)
			//	return TaskState.STOP;

			IEnumerable<IPlayable> entities =
				IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);

			if (game.Splitting && game.Splits.Count == 0)
			{
				if (Amount == 1)
				{
					//entities.ForEach(p =>
					foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target,
						stack?.Playables))
					{
						//game.Dump("SplitTask", $"{sets.IndexOf(p)}: {string.Join(";", p)}");
						stack.Playables = new List<IPlayable> {p};
						State = TaskState.COMPLETE;
						Game clone = game.Clone();
						game.Splits.Add(clone);
					}

					;
				}
				else
				{
					List<IEnumerable<IPlayable>> sets = Util.GetPowerSet(entities.ToList())
						.Where(plist => plist.Count() == Amount).ToList();
					foreach (IEnumerable<IPlayable> plist in sets)
					{
						game.Dump("SplitTask", $"{sets.IndexOf(plist)}: {String.Join(";", plist)}");
						stack.Playables = plist.ToList();
						State = TaskState.COMPLETE;
						Game clone = game.Clone();
						game.Splits.Add(clone);
					}
				}

				//game.TaskQueue.TaskList.Clear();
				game.TaskQueue.ClearCurrentEvent();
				return TaskState.STOP;
			}


			stack.Playables = entities is List<IPlayable> list ? list : entities.ToList();

			return TaskState.COMPLETE;
		}
	}

	public class RandomTask : SimpleTask
	{
		public RandomTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			IEnumerable<IPlayable> temp =
				IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			List<IPlayable> entities = temp is List<IPlayable> list ? list : temp.ToList();

			if (entities.Count == 0)
				return TaskState.STOP;

			stack.Playables = new List<IPlayable>();
			for (int i = 0; i < Amount && entities.Count > 0; i++)
			{
				IPlayable randPlayable = Util.Choose(entities);
				entities.Remove(randPlayable);
				stack?.Playables.Add(randPlayable);
			}

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
