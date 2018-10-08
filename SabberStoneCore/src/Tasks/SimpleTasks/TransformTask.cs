using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformTask : SimpleTask
	{
		public TransformTask(Card card, EntityType type)
		{
			Card = card;
			Type = type;
		}

		public TransformTask(string cardId, EntityType type)
		{
			Card = Cards.FromId(cardId);
			Type = type;
		}

		public Card Card { get; set; }
		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
				Generic.TransformBlock.Invoke(p.Controller, Card, p as Minion);

			return TaskState.COMPLETE;
		}
	}
}
