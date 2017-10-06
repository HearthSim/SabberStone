using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestProgressTask : SimpleTask
	{
		public override TaskState Process()
		{
			var source = Source as Spell;
			if (source == null)
			{
				return TaskState.STOP;
			}

			source.QuestProgress++;
			if (Game.Logging)
				Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestProgressTask", $"{Controller} {source}'s Quest {source.QuestProgress} / {source.QuestTotalProgress} progress!");
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new QuestProgressTask();
			clone.Copy(this);
			return clone;
		}
	}
}
