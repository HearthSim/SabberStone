using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonCopyTask : SimpleTask
	{
		public SummonCopyTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			if (Controller.BoardZone.IsFull)
				return TaskState.STOP;

			var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

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

		public override ISimpleTask Clone()
		{
			var clone = new SummonCopyTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}