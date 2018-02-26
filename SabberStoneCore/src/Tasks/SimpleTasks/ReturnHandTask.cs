using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReturnHandTask : SimpleTask
	{
		public ReturnHandTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				var target = p as Minion;
				if (target == null)
					break;
				Generic.ReturnToHandBlock.Invoke(target.Controller, target);
			}

				return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ReturnHandTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
