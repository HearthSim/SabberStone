using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetGameTagTask : SimpleTask
	{
		public SetGameTagTask(GameTag tag, int amount, EntityType entityType)
		{
			Tag = tag;
			Amount = amount;
			Type = entityType;
		}

		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public override TaskState Process()
		{
			//System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (Tag == GameTag.DIVINE_SHIELD && Amount == 0 && p[GameTag.DIVINE_SHIELD] != 0)
					Game.TriggerManager.OnLoseDivineShield(p);
				p[Tag] = Amount;

			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SetGameTagTask(Tag, Amount, Type);
			clone.Copy(this);
			return clone;
		}
	}
}
