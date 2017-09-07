using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagGameTask : SimpleTask
	{
		public GetGameTagGameTask(GameTag tag)
		{
			Tag = tag;
		}

		public GameTag Tag { get; set; }

		public override TaskState Process()
		{
			Number = Game[Tag];
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetGameTagGameTask(Tag);
			clone.Copy(this);
			return clone;
		}
	}
}
