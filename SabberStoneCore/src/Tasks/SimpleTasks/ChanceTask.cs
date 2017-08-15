using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChanceTask : SimpleTask
	{
		public bool UseFlag { get; set; }

		public ChanceTask(bool useFlag = false)
		{
			UseFlag = useFlag;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			int random = Util.Random.Next(0, 2);

			if (!UseFlag)
			{
				return random == 0 ? TaskState.COMPLETE : TaskState.STOP;
			}

			Flag = random != 0;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(ChanceTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new ChanceTask(UseFlag);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}