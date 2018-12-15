#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
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
