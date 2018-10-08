using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestProgressTask : SimpleTask
	{
		private readonly string _questRewardId;

		public QuestProgressTask(string questRewardId)
		{
			_questRewardId = questRewardId;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var spell = source as Spell;
			if (spell == null)
				return TaskState.STOP;

			spell.QuestProgress++;
			game.Log(LogLevel.INFO, BlockType.PLAY, "QuestProgressTask",
				!game.Logging
					? ""
					: $"{controller} {spell}'s Quest {spell.QuestProgress} / {spell.QuestTotalProgress} progress!");

			if (spell.QuestProgress == spell.QuestTotalProgress)
				game.TaskQueue.EnqueueBase(new QuestRewardTask(_questRewardId), in controller, spell, null);

			return TaskState.COMPLETE;
		}
	}
}
