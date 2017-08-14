using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonCopyTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public SummonCopyTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count < 1)
			{
				return TaskState.STOP;
			}

			entities.ForEach(p =>
			{
				// clone task here
				var task = new SummonTask(p.Card)
				{
					Game = Controller.Game,
					Controller = Controller,
					Source = Source as IPlayable,
					Target = Target as IPlayable
				};

				Controller.Game.TaskQueue.Enqueue(task);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SummonCopyTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}