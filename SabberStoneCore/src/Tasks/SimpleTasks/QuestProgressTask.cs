#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion

using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestProgressTask : SimpleTask
	{
		//private readonly string _questRewardId;
		private readonly Card _card;

		public QuestProgressTask(string questRewardId)
		{
			_card = Cards.FromId(questRewardId);
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
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
			{
				// creating reward card ...
				IPlayable reward = Entity.FromCard(controller, _card);
				reward[GameTag.DISPLAYED_CREATOR] = spell.Id;

				game.Log(LogLevel.INFO, BlockType.PLAY, "QuestProgressTask",
					!game.Logging ? "" : $"{controller} Quest finished, reward {reward}!");

				// adding reward to hand
				Generic.AddHandPhase.Invoke(controller, reward);
				spell[GameTag.REVEALED] = 1;

				// moving quest to graveyard
				controller.SecretZone.Quest = null;
				controller.GraveyardZone.Add(spell);
				//Controller.GraveyardZone.Add(source.Zone.Remove(source));

				return TaskState.COMPLETE;
			}

			return TaskState.COMPLETE;
		}
	}
}
