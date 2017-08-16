using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestProgressTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as Spell;
			if (source == null)
			{
				return TaskState.STOP;
			}

			source.QuestProgress++;
			Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestProgressTask", $"{Controller} {source}'s Quest {source.QuestProgress} / {source.QuestTotalProgress} progress!");
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new QuestProgressTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}