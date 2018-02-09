﻿using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ConditionTask : SimpleTask
	{
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

		public SelfCondition[] SelfConditions { get; set; }
		public RelaCondition[] RelaConditions { get; set; }
		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			IEnumerable<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			if (!entities.Any())
				return TaskState.STOP;

			var source = (IPlayable)Source;

			int i;
			Flag = true;
			foreach (IPlayable p in entities)
			{
				for (i = 0; i < SelfConditions.Length; i++)
					Flag = Flag && SelfConditions[i].Eval(p);

				for (i = 0; i < RelaConditions.Length; i++)
					Flag = Flag && RelaConditions[i].Eval(source, p);
			}


			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ConditionTask(Type, SelfConditions, RelaConditions);
			clone.Copy(this);
			return clone;
		}
	}
}
