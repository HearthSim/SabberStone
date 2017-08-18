using System.Linq;
using SabberStoneCore.Conditions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FilterStackTask : SimpleTask
	{

		private FilterStackTask(EntityType type, SelfCondition[] selfConditions, RelaCondition[] relaConditions)
		{
			Type = type;
			SelfConditions = selfConditions;
			RelaConditions = relaConditions;
		}

		public FilterStackTask(params SelfCondition[] selfConditions)
		{
			SelfConditions = selfConditions;
		}

		public FilterStackTask(EntityType type, params RelaCondition[] relaConditions)
		{
			Type = type;
			RelaConditions = relaConditions;
		}

		public EntityType Type { get; set; }

		public SelfCondition[] SelfConditions { get; set; }

		public RelaCondition[] RelaConditions { get; set; }

		public override TaskState Process()
		{
			if (RelaConditions != null)
			{
				System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

				if (entities.Count != 1)
					return TaskState.STOP;

				Playables = Playables
					.Where(p1 => RelaConditions.ToList().TrueForAll(p2 => p2.Eval(entities[0], p1)))
					.ToList();
			}

			if (SelfConditions != null)
			{
				var selfConditionList = SelfConditions.Where(x => x != null).ToList();
				Playables = Playables
					.Where(p1 => selfConditionList.TrueForAll(p2 => p2.Eval(p1)))
					.ToList();
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new FilterStackTask(Type, SelfConditions, RelaConditions);
			clone.Copy(this);
			return clone;
		}
	}
}