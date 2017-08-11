using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetNativeGameTagTask : SimpleTask
	{
		public GetNativeGameTagTask(GameTag tag, EntityType entityType, bool selfBuffs)
		{
			Tag = tag;
			Type = entityType;
			SelfBuffs = selfBuffs;
		}

		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public bool SelfBuffs { get; set; }

		public override TaskState Process()
		{
			var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count != 1)
			{
				return TaskState.STOP;
			}

			Number = ((Entity)entities[0]).GetNativeGameTag(Tag);

			if (SelfBuffs)
			{
				entities[0].Enchants.ForEach(p => Number = p.Apply((Entity)entities[0], Tag, Number));
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetNativeGameTagTask(Tag, Type, SelfBuffs);
			clone.Copy(this);
			return clone;
		}
	}
}