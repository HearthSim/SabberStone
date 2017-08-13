using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagControllerTask : SimpleTask
	{
		public GameTag Tag { get; set; }

		public GetGameTagControllerTask(GameTag tag)
		{
			Tag = tag;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number = Controller[Tag];
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new GetGameTagControllerTask(Tag);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}