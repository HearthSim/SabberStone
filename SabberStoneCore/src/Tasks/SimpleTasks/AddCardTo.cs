﻿using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddCardTo : SimpleTask
	{
		private readonly int _amount;
		private readonly Card _card;
		private readonly EntityType _type;

		public AddCardTo(Card card, EntityType type, int amount = 1)
		{
			_card = card;
			_type = type;
			_amount = amount;
		}

		public AddCardTo(string cardId, EntityType type, int amount = 1)
		{
			_card = Cards.FromId(cardId);
			_type = type;
			_amount = amount;
		}


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var entities = new IPlayable[_amount];

			switch (_type)
			{
				case EntityType.DECK:
					for (int i = 0; i < entities.Length; i++)
					{
						entities[i] = Entity.FromCard(in controller, in _card);
						entities[i][GameTag.DISPLAYED_CREATOR] = source.Id;
					}

					for (int i = 0; i < entities.Length && !controller.DeckZone.IsFull; i++)
						Generic.ShuffleIntoDeck.Invoke(controller, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.HAND:
					for (int i = 0; i < entities.Length; i++)
					{
						entities[i] = Entity.FromCard(controller, _card);
						entities[i][GameTag.DISPLAYED_CREATOR] = source.Id;
					}

					for (int i = 0; i < entities.Length; i++)
						Generic.AddHandPhase.Invoke(controller, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					for (int i = 0; i < entities.Length; i++)
					{
						entities[i] = Entity.FromCard(controller.Opponent, _card);
						entities[i][GameTag.DISPLAYED_CREATOR] = source.Id;
					}

					for (int i = 0; i < entities.Length; i++)
						Generic.AddHandPhase.Invoke(controller.Opponent, entities[i]);
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					for (int i = 0; i < entities.Length; i++)
					{
						entities[i] = Entity.FromCard(controller.Opponent, _card);
						entities[i][GameTag.DISPLAYED_CREATOR] = source.Id;
					}

					for (int i = 0; i < entities.Length && !controller.Opponent.DeckZone.IsFull; i++)
						Generic.ShuffleIntoDeck.Invoke(controller.Opponent, entities[i]);
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}
	}
}
