using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetGameTagNumberTask : SimpleTask
	{
		public SetGameTagNumberTask(GameTag tag, EntityType entityType, bool ignoreDamage = false)
		{
			Tag = tag;
			Type = entityType;
			IgnoreDamage = ignoreDamage;
		}

		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public bool IgnoreDamage { get; set; }

		public override TaskState Process()
		{

			//System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				p[Tag] = Number;
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SetGameTagNumberTask(Tag, Type, IgnoreDamage);
			clone.Copy(this);
			return clone;
		}
	}
}
