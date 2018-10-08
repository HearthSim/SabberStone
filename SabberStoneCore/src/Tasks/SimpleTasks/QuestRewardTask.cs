using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class QuestRewardTask : SimpleTask
	{
		private QuestRewardTask(Card card)
		{
			Card = card;
		}

		public QuestRewardTask(string cardId)
		{
			Card = Cards.FromId(cardId);
		}

		public Card Card { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var spell = source as Spell;
			if (spell == null) return TaskState.STOP;

			// creating reward card ...
			IPlayable reward = Entity.FromCard(controller, Card);
			reward[GameTag.DISPLAYED_CREATOR] = spell.Id;
			game.Log(LogLevel.INFO, BlockType.PLAY, "QuestRewardTask",
				!game.Logging ? "" : $"{controller} Quest finished, reward {reward}!");

			// adding reward to hand
			Generic.AddHandPhase.Invoke(controller, reward);
			spell[GameTag.REVEALED] = 1;

			// moving quest to graveyard
			controller.SecretZone.Quest = null;
			controller.GraveyardZone.Add(spell);
			//Controller.GraveyardZone.Add(source.Zone.Remove(source));

			return TaskState.COMPLETE;
		}
	}
}
