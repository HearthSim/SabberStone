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
