using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ConditionTask : SimpleTask
	{
		public SelfCondition[] SelfConditions { get; set; }
		public RelaCondition[] RelaConditions { get; set; }
		public EntityType Type { get; set; }

		private ConditionTask(EntityType entityType,
			SelfCondition[] selfConditions,
			RelaCondition[] relaConditions)
		{
			SelfConditions = selfConditions;
			RelaConditions = relaConditions;
			Type = entityType;
		}

		public ConditionTask(EntityType entityType, params SelfCondition[] selfConditions)
		{
			SelfConditions = selfConditions;
			RelaConditions = new RelaCondition[] { };
			Type = entityType;
		}

		public ConditionTask(EntityType entityType, params RelaCondition[] relaConditions)
		{
			SelfConditions = new SelfCondition[] { };
			RelaConditions = relaConditions;
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count == 0)
			{
				return TaskState.STOP;
			}

			var source = (IPlayable)Source;

			Flag = entities.TrueForAll(p =>
				SelfConditions.ToList().TrueForAll(c => c.Eval(p)) &&
				RelaConditions.ToList().TrueForAll(c => c.Eval(source, p)));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ConditionTask(Type, SelfConditions?.ToArray(), RelaConditions?.ToArray());
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}