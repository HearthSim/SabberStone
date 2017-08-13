using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomTask : SimpleTask
	{
		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public RandomTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count == 0)
				return TaskState.STOP;

			Playables = new List<IPlayable>();
			for (int i = 0; i < Amount && entities.Count > 0; i++)
			{
				IPlayable randPlayable = Util.Choose(entities);
				entities.Remove(randPlayable);
				Playables.Add(randPlayable);
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new RandomTask(Amount, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}