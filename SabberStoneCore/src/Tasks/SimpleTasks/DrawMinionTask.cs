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
using System;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DrawMinionTask : SimpleTask
	{
		private readonly Race _race;
		private readonly int _amount;
		private readonly bool _addToStack;
		private readonly bool _lowestCost;

		public DrawMinionTask(Race race, int amount, bool addToStack)
		{
			_race = race;
			_amount = amount;
			_addToStack = addToStack;
		}

		public DrawMinionTask(bool lowestCost, int amount, bool addToStack)
		{
			_lowestCost = lowestCost;
			_amount = amount;
			_addToStack = addToStack;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IPlayable target,
			in TaskStack stack = null)
		{
			var deck = controller.DeckZone.GetSpan();

			if (deck.Length == 0)
				return TaskState.STOP;

			List<int> indices = new List<int>();
			bool addToStack = _addToStack;
			//int count = 0;
			if (addToStack)
				stack.Playables = new List<IPlayable>(_amount);

			if (_lowestCost)
			{
				int minVal = int.MaxValue;
				for (int i = 0; i < deck.Length; i++)
				{
					if (deck[i].Card.Type != CardType.MINION) continue;

					int cost = deck[i].Cost;
					if (cost < minVal)
					{
						minVal = deck[i].Cost;
						indices.Clear();
						indices.Add(i);
					}
					else if (cost == minVal)
					{
						indices.Add(i);
					}
				}
			}
			else if (_race != Race.INVALID)
			{
				Race race = _race;
				for (int i = 0; i < deck.Length; i++)
				{
					if (deck[i].Card.IsRace(race))
						indices.Add(i);
				}
			}
			else
			{
				for (int i = 0; i < deck.Length; i++)
				{
					if (deck[i].Card.Type == CardType.MINION)
						indices.Add(i);
				}
			}

			if (indices.Count <= _amount)
				for (int i = indices.Count - 1; i >= 0; i--)
				{
					if (addToStack)
						stack.Playables.Add(deck[indices[i]]);
					Generic.Draw(controller, indices[i]);
				}
			else if (_amount == 1)
			{
				int pick = indices[game.Random.Next(indices.Count)];
				if (addToStack)
					stack.Playables.Add(deck[pick]);
				Generic.Draw(controller, pick);
			}
			else
			{
				int amountLeft = _amount;
				int total = indices.Count;
				Util.DeepCloneableRandom rnd = game.Random;
				game.OnRandomHappened(true);

				for (int i = indices.Count - 1; i >= 0; i--)
				{
					double p = (double)amountLeft / total;

					if (rnd.NextDouble() < p)
					{
						if (addToStack)
							stack.Playables.Add(deck[indices[i]]);
						Generic.Draw(controller, indices[i]);
						if (--amountLeft == 0)
							break;
						total--;
					}
					else
						total--;
				}
			}

			return TaskState.COMPLETE;
		}

	}
}
