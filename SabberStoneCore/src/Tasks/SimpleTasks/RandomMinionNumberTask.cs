using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RandomMinionNumberTask : SimpleTask
	{
		public GameTag Tag { get; set; }

		public RandomMinionNumberTask(GameTag tag)
		{
			Tag = tag;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{

			IEnumerable<Card> cards = Game.FormatType == FormatType.FT_STANDARD ? Cards.AllStandard : Cards.AllWild;
			var cardsList = cards.Where(p => p.Type == CardType.MINION && p[Tag] == Number).ToList();
			if (!cardsList.Any())
			{
				return TaskState.STOP;
			}

			IPlayable playable = Entity.FromCard(Controller, Util.Choose(cardsList));
			Playables = new List<IPlayable> { playable };

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RandomMinionNumberTask(Tag);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}