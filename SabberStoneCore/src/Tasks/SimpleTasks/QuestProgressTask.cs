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

		public override TaskState Process()
		{
			var source = Source as Spell;
			if (source == null)
			{
				return TaskState.STOP;
			}

			source.QuestProgress++;
			Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestProgressTask", !Game.Logging? "":$"{Controller} {source}'s Quest {source.QuestProgress} / {source.QuestTotalProgress} progress!");

			if (source.QuestProgress == source.QuestTotalProgress)
			{
				var task = new QuestRewardTask(_questRewardId);
				task.Game = Game;
				task.Controller = Controller;
				task.Source = Source;
				task.Target = null;

				Game.TaskQueue.EnqueueBase(task);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new QuestProgressTask(_questRewardId);
			clone.Copy(this);
			return clone;
		}
	}
}
