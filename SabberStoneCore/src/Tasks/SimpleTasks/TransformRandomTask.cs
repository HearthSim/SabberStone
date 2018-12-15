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
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformMinionTask : SimpleTask
	{
		public TransformMinionTask(EntityType type, int costChange)
		{
			Type = type;
			CostChange = costChange;
		}

		public EntityType Type { get; set; }
		public int CostChange { get; set; }

		public override TaskState Process()
		{
			//System.Collections.Generic.IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
				if (Cards.CostMinionCards(Game.FormatType).TryGetValue(p.Card.Cost + CostChange, out List<Card> minions))
					Generic.TransformBlock.Invoke(p.Controller, Util.RandomElement(minions), p as Minion);

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new TransformMinionTask(Type, CostChange);
			clone.Copy(this);
			return clone;
		}
	}
}
