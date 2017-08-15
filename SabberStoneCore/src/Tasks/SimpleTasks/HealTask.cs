using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class HealTask : SimpleTask
	{
		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public HealTask(int amount, EntityType entityType)
		{
			Amount = amount;
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Amount < 1)
			{
				return TaskState.STOP;
			}

			var source = Source as IPlayable;
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var target = p as ICharacter;
				target?.TakeHeal(source, Amount);
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(HealTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new HealTask(Amount, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}