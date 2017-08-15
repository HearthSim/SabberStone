using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	// TODO; Rename to ReturnToHandTask
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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(ReturnHandTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ReturnHandTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}