using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealTask : SimpleTask
	{
		public HealTask(int amount, EntityType entityType)
		{
			Amount = amount;
			Type = entityType;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			if (Amount < 1)
			{
				return TaskState.STOP;
			}

			var source = Source as IPlayable;
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				var target = p as ICharacter;
				target?.TakeHeal(source, Amount);
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new HealTask(Amount, Type);
			clone.Copy(this);
			return clone;
		}
	}
}
