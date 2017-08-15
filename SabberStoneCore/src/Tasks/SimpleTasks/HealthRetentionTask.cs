using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealthRetentionTask : SimpleTask
	{
		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public HealthRetentionTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as ICharacter;
			if (source == null || Amount < 1)
			{
				return TaskState.STOP;
			}

			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				var target = p as ICharacter;
				if (target != null)
				{
					target.IsIgnoreDamage = true;
					target.Damage -= Amount;
					target.IsIgnoreDamage = false;
				}
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(HealthRetentionTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new HealthRetentionTask(Amount, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}