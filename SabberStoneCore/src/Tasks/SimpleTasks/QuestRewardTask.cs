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
	public class QuestRewardTask : SimpleTask
	{
		private QuestRewardTask(Card card)
		{
			Card = card;
		}

		public QuestRewardTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

		public Card Card { get; set; }

		public override TaskState Process()
		{
			var source = Source as Spell;
			if (source == null)
			{
				return TaskState.STOP;
			}

			// creating reward card ...
			IPlayable reward = Entity.FromCard(Controller, Card);
			reward[GameTag.DISPLAYED_CREATOR] = Source.Id;
			Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestRewardTask", !Game.Logging? "":$"{Controller} Quest finished, reward {reward}!");

			// adding reward to hand
			Generic.AddHandPhase.Invoke(Controller, reward);
			source[GameTag.REVEALED] = 1;

			// moving quest to graveyard
			Controller.SecretZone.Quest = null;
			Controller.GraveyardZone.Add(source);
			//Controller.GraveyardZone.Add(source.Zone.Remove(source));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new QuestRewardTask(Card);
			clone.Copy(this);
			return clone;
		}
	}
}
