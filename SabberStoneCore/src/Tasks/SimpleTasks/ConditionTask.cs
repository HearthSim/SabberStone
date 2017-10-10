using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model.Entities;

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
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count == 0)
			{
				return TaskState.STOP;
			}

			var source = (IPlayable)Source;

			//Flag = entities.TrueForAll(p =>
			//	SelfConditions.ToList().TrueForAll(c => c.Eval(p)) &&
			//	RelaConditions.ToList().TrueForAll(c => c.Eval(source, p)));
			int i;
			Flag = SelfConditions.Length != 0 || RelaConditions.Length != 0;
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
