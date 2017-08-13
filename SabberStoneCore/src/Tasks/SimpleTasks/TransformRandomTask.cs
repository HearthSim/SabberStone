using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformMinionTask : SimpleTask
	{
		public EntityType Type { get; set; }
		public int CostChange { get; set; }

		public TransformMinionTask(EntityType type, int costChange)
		{
			Type = type;
			CostChange = costChange;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				var minions = cards.Where(t => t.Cost == p.Card.Cost + CostChange && t.Type == CardType.MINION).ToList();
				if (minions.Any())
				{
					Generic.TransformBlock.Invoke(p.Controller, Util.RandomElement(minions), p as Minion);
				}
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new TransformMinionTask(Type, CostChange);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}