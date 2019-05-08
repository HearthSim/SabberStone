#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SummonOpTask : SimpleTask
	{
		private readonly Card _card;
		private readonly int _amount;

		/// <summary>
		/// Creates a task that summons an entity of the given card or
		/// in the stack for the opponent.
		/// </summary>
		/// <param name="card"></param>
		public SummonOpTask(Card card = null, int amount = 1)
		{
			_card = card;
			_amount = amount;
		}

		public SummonOpTask(string cardId, int amount = 1)
		{
			_card = Cards.FromId(cardId);
			_amount = amount;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			//if (controller.Opponent.BoardZone.IsFull)
			//	return TaskState.STOP;

			if (_card == null && stack?.Playables.Count < 1)
				return TaskState.STOP;

			for (int i = 0; i < _amount; i++)
			{
				if (controller.Opponent.BoardZone.IsFull)
					return TaskState.STOP;

				Minion summonEntity;

				if (_card == null)
				{
					summonEntity = (Minion) stack.Playables[0];
					if (summonEntity.Controller == controller)
						throw new System.Exception("SummonOpTask attempts to summon a friendly minion.");
				}
				else
					summonEntity = (Minion) Entity.FromCard(controller.Opponent, in _card);

				Generic.SummonBlock.Invoke(game, summonEntity, -1, source);
			}

			return TaskState.COMPLETE;
		}
	}
}
