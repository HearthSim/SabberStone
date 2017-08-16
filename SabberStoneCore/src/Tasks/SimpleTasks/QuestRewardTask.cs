using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestRewardTask : SimpleTask
	{
		public Card Card { get; set; }

		private QuestRewardTask(Card card)
		{
			Card = card;
		}

		public QuestRewardTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as Spell;
			if (source == null)
			{
				return TaskState.STOP;
			}

			// creating reward card ...
			IPlayable reward = Entity.FromCard(Controller, Card);
			Game.Log(LogLevel.INFO, BlockType.PLAY, "QuestRewardTask", $"{Controller} Quest finished, reward {reward}!");

			// adding reward to hand
			Generic.AddHandPhase.Invoke(Controller, reward);
			source[GameTag.REVEALED] = 1;

			// moving quest to graveyard
			Controller.GraveyardZone.Add(source.Zone.Remove(source));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new QuestRewardTask(Card);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}