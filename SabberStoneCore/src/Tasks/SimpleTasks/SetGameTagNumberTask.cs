using SabberStoneCore.Enums;

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

			System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				if (IgnoreDamage)
				{
					p.IsIgnoreDamage = true;
					p[Tag] = Number;
					p.IsIgnoreDamage = false;
				}
				else
				{
					p[Tag] = Number;
				}
			});

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