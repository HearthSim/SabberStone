using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddCardTo : SimpleTask
	{

		public IPlayable Playable { get; set; }

		public Card Card { get; set; }

		public EntityType Type { get; set; }

		private AddCardTo(IPlayable playable, Card card, EntityType type)
		{
			Playable = playable;
			Card = card;
			Type = type;
		}

		public AddCardTo(IPlayable playable, EntityType type)
		{
			Playable = playable;
			Type = type;
		}

		public AddCardTo(Card card, EntityType type)
		{
			Card = card;
			Type = type;
		}

		public AddCardTo(string cardId, EntityType type)
		{
			Card = Cards.FromId(cardId);
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			switch (Type)
			{
				case EntityType.DECK:
					if (Playable == null)
						Playable = Entity.FromCard(Controller, Card);
					Generic.ShuffleIntoDeck.Invoke(Controller, Playable);
					return TaskState.COMPLETE;

				case EntityType.HAND:
					if (Playable == null)
						Playable = Entity.FromCard(Controller, Card);
					Generic.AddHandPhase.Invoke(Controller, Playable);
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					if (Playable == null)
						Playable = Entity.FromCard(Controller.Opponent, Card);
					Generic.AddHandPhase.Invoke(Controller.Opponent, Playable);
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					if (Playable == null)
						Playable = Entity.FromCard(Controller.Opponent, Card);
					Generic.ShuffleIntoDeck.Invoke(Controller.Opponent, Playable);
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask InternalClone()
		{
			return new AddCardTo(Playable, Card, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}