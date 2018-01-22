using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealFullTask : SimpleTask
	{
		public HealFullTask(EntityType entityType)
		{
			Type = entityType;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}

			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				var target = p as ICharacter;
				target?.TakeFullHeal(source);
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new HealFullTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
