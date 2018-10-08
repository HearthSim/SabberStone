using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomMinionNumberTask : SimpleTask
	{
		public RandomMinionNumberTask(GameTag tag)
		{
			Tag = tag;
		}

		public GameTag Tag { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			List<Card> cardsList;
			if (Tag == GameTag.COST)
			{
				Cards.CostMinionCards(game.FormatType).TryGetValue(stack.Number, out cardsList);
				if (cardsList == null)
					return TaskState.STOP;
			}
			else
			{
				IEnumerable<Card> cards = game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
				int num = stack.Number;
				cardsList = cards.Where(p => p.Type == CardType.MINION && p[Tag] == num).ToList();
				if (!cardsList.Any())
					return TaskState.STOP;
			}

			IPlayable playable = Entity.FromCard(controller, Util.Choose(cardsList));
			stack.Playables = new List<IPlayable> {playable};

			game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}
	}
}
