using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddCardTo : SimpleTask
	{
		private readonly int _amount;

		public AddCardTo(Card card, EntityType type, int amount = 1)
		{
			Card = card;
			Type = type;
			_amount = amount;
		}
		public AddCardTo(string cardId, EntityType type, int amount = 1)
		{
			Card = Cards.FromId(cardId);
			Type = type;
			_amount = amount;
		}

		public Card Card { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			IPlayable[] entities = new IPlayable[_amount];
			for (int i = 0; i < entities.Length; i++)
			{
				entities[i] = Entity.FromCard(Controller, Card);
				entities[i][Enums.GameTag.DISPLAYED_CREATOR] = Source.Id;
			}

			switch (Type)
			{
				case EntityType.DECK:
					for (int i = 0; i < entities.Length && !Controller.DeckZone.IsFull; i++)
						Generic.ShuffleIntoDeck.Invoke(Controller, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.HAND:
					for (int i = 0; i < entities.Length; i++)
						Generic.AddHandPhase.Invoke(Controller, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					for (int i = 0; i < entities.Length; i++)
						Generic.AddHandPhase.Invoke(Controller.Opponent, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					for (int i = 0; i < entities.Length && !Controller.Opponent.DeckZone.IsFull; i++)
						Generic.ShuffleIntoDeck.Invoke(Controller.Opponent, entities[i]);
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{ 
			var clone = new AddCardTo(Card, Type, _amount);
			clone.Copy(this);
			return clone;
		}
	}
}
