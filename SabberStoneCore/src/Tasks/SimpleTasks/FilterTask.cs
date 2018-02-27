using System.Collections;
using System.Linq;
using SabberStoneCore.Conditions;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FilterStackTask : SimpleTask
	{

		private FilterStackTask(EntityType type, SelfCondition[] selfConditions, RelaCondition[] relaConditions)
		{
			_type = type;
			_selfConditions = selfConditions;
			_relaConditions = relaConditions;
		}

		public FilterStackTask(params SelfCondition[] selfConditions)
		{
			_selfConditions = selfConditions;
		}

		public FilterStackTask(EntityType type, params RelaCondition[] relaConditions)
		{
			_type = type;
			_relaConditions = relaConditions;
		}

		private readonly EntityType _type;
		private readonly SelfCondition[] _selfConditions;
		private readonly RelaCondition[] _relaConditions;

		public override TaskState Process()
		{
			if (_relaConditions != null)
			{
				IList<IPlayable> entities = IncludeTask.GetEntities(_type, Controller, Source, Target, Playables);

				if (entities.Count != 1)
					return TaskState.STOP;

				var filtered = new List<IPlayable>(entities.Count);
				foreach (IPlayable p in Playables)
				{
					bool flag = true;
					for (int i = 0; i < _relaConditions.Length; i++)
						flag = flag && _relaConditions[i].Eval(entities[0], p);
					if (flag)
						filtered.Add(p);
				}
				Playables = filtered;
			}

			if (_selfConditions != null)
			{
				var filtered = new List<IPlayable>(Playables.Count);
				foreach (IPlayable p in Playables)
				{
					bool flag = true;
					for (int i = 0; i < _selfConditions.Length; i++)
					{
						if (_selfConditions[i] != null)
							flag = flag && _selfConditions[i].Eval(p);
					}

					if (flag)
						filtered.Add(p);
				}

				Playables = filtered;
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new FilterStackTask(_type, _selfConditions, _relaConditions);
			clone.Copy(this);
			return clone;
		}
	}
}
