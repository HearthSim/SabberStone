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

		public override TaskState Process()
		{
			IEnumerable<Card> cardsList;
			if (Tag == GameTag.COST)
			{
				Cards.CostMinionCards(Game.FormatType).TryGetValue(Number, out cardsList);
				if (cardsList == null)
					return TaskState.STOP;
			}
			else
			{
				IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
				cardsList = cards.Where(p => p.Type == CardType.MINION && p[Tag] == Number);
				if (!cardsList.Any())
					return TaskState.STOP;
			}

			IPlayable playable = Entity.FromCard(Controller, Util.RandomElement(cardsList));
			Playables = new List<IPlayable> { playable };

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomMinionNumberTask(Tag);
			clone.Copy(this);
			return clone;
		}
	}
}
