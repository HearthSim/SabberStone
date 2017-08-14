using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReturnHandTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public ReturnHandTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).TrueForAll(p =>
			{
				var target = p as Minion;
				if (target == null)
				{
					return false;
				}
				return Generic.ReturnToHandBlock.Invoke(target.Controller, target);
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ReturnHandTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}