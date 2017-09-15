﻿using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
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
			System.Collections.Generic.IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				var minions = cards.Where(t => t.Cost == p.Card.Cost + CostChange && t.Type == CardType.MINION).ToList();
				if (minions.Any())
				{
					Generic.TransformBlock.Invoke(p.Controller, Util.RandomElement(minions), p as Minion);
				}
			});

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