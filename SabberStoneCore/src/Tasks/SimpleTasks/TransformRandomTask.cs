using System.Linq;
using System.Collections.Generic;
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
			//System.Collections.Generic.IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				//var minions = cards.Where(t => t.Type == CardType.MINION && t.Cost == p.Card.Cost + CostChange);
				int cost = p.Card.Cost + CostChange;
				Cards.CostMinionCards(Game.FormatType).TryGetValue(cost, out List<Card> minions);
				if (minions != null)
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
