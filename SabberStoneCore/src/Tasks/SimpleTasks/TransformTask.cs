using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformTask : SimpleTask
	{
		public Card Card { get; set; }
		public EntityType Type { get; set; }

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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
				.ForEach(p => Generic.TransformBlock.Invoke(p.Controller, Card, p as Minion));

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(TransformTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new TransformTask(Card, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}