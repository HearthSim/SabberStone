using System.Linq;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class BuffTask : SimpleTask
	{
		public Enchant Buff { get; set; }

		public EntityType Type { get; set; }

		public SelfCondition Condition { get; set; }

		public BuffTask(Enchant buff, EntityType type, SelfCondition condition = null)
		{
			Buff = buff;
			Type = type;
			Condition = condition;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Buff == null)
			{
				return TaskState.STOP;
			}

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (Condition != null)
			{
				entities = entities.Where(p => Condition.Eval(p)).ToList();
			}

			entities.ForEach(p => Buff.Activate(source.Card.Id, p.Enchants, p));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new BuffTask(Buff, Type, Condition);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}