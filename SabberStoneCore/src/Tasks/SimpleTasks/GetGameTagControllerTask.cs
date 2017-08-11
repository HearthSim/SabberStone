using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagControllerTask : SimpleTask
	{
		public GetGameTagControllerTask(GameTag tag)
		{
			Tag = tag;
		}

		public GameTag Tag { get; set; }

		public override TaskState Process()
		{
			Number = Controller[Tag];
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetGameTagControllerTask(Tag);
			clone.Copy(this);
			return clone;
		}
	}
}