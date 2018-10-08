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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.IEnumerable<Card> cards = game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
				if (Cards.CostMinionCards(game.FormatType)
					.TryGetValue(p.Card.Cost + CostChange, out List<Card> minions))
					Generic.TransformBlock.Invoke(p.Controller, Util.RandomElement(minions), p as Minion);

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
