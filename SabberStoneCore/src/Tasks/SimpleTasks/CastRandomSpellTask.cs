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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CastRandomSpellTask : SimpleTask
	{
		private static readonly ConcurrentDictionary<int, Card[]> CachedCardLists =
			new ConcurrentDictionary<int, Card[]>();

		private readonly Func<Card, bool> _condition;
		private readonly bool _phaseShift;

		public CastRandomSpellTask(Func<Card, bool> condition = null, bool phaseShift = true)
		{
			_condition = condition;
			_phaseShift = phaseShift;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (_condition != null && !CachedCardLists.TryGetValue(source.Card.AssetId, out Card[] cards))
			{
				cards = Cards.FormatTypeCards(game.FormatType)
					.Where(card => card.Type == CardType.SPELL && _condition(card)).ToArray();

				CachedCardLists.TryAdd(source.Card.AssetId, cards);
			}
			else if (!CachedCardLists.TryGetValue(0, out cards))
			{
				cards = Cards.FormatTypeCards(game.FormatType)
					.Where(card => card.Type == CardType.SPELL && !card.IsQuest).ToArray();
				CachedCardLists.TryAdd(0, cards);
			}

			Controller c = source.Controller;

			Card randCard;
			do
			{
				randCard = cards[Random.Next(cards.Length)];
			} while (!randCard.Implemented || randCard.HideStat);

			game.OnRandomHappened(true);

			Spell spellToCast = (Spell) target ?? (Spell) Entity.FromCard(c, randCard);

			game.Log(LogLevel.INFO, BlockType.POWER, "CastRandomSpellTask",
				!game.Logging ? "" : $"{source} casted {c.Name}'s {spellToCast}.");

			if (spellToCast.IsSecret && c.SecretZone.IsFull)
			{
				c.GraveyardZone.Add(spellToCast);
				return TaskState.COMPLETE;
			}

			ICharacter randTarget = null;
			if (randCard.TargetingType != TargetingType.None)
			{
				var targets = (List<ICharacter>) spellToCast.ValidPlayTargets;

				randTarget = targets.Count > 0 ? Util.RandomElement(targets) : null;

				spellToCast.CardTarget = randTarget?.Id ?? -1;

				game.Log(LogLevel.INFO, BlockType.POWER, "CastRandomSpellTask",
					!game.Logging ? "" : $"{spellToCast}'s target is randomly selected to {randTarget}");
			}

			int randChooseOne = Random.Next(1, 3);

			if (randCard.HasOverload)
				c.OverloadOwed = randCard.Overload;

			Choice choiceTemp = c.Choice;
			c.Choice = null;

			game.TaskQueue.StartEvent();
			Generic.CastSpell.Invoke(c, spellToCast, randTarget, randChooseOne, true);
			// forced death processing & AA (Yogg)
			if (_phaseShift)
				game.DeathProcessingAndAuraUpdate();
			game.TaskQueue.EndEvent();


			//game.TaskQueue.Execute(spellToCast.Power.PowerTask, source.Controller, spellToCast, randTarget, randChooseOne);
			//game.DeathProcessingAndAuraUpdate();

			while (c.Choice != null)
			{
				game.TaskQueue.StartEvent();
				Generic.ChoicePick.Invoke(c, Util.Choose(c.Choice.Choices));
				game.ProcessTasks();
				game.TaskQueue.EndEvent();
				game.DeathProcessingAndAuraUpdate();
			}

			c.Choice = choiceTemp;

			return TaskState.COMPLETE;
		}
	}
}
