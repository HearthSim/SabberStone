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
using System.Linq;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class CastRandomSpellTask : SimpleTask
    {
		private readonly Func<Card, bool> _condition;
	    private readonly bool _phaseShift;

	    private static readonly ConcurrentDictionary<int, Card[]> CachedCardLists = new ConcurrentDictionary<int, Card[]>();

	    public CastRandomSpellTask(Func<Card, bool> condition = null, bool phaseShift = true)
	    {
		    _condition = condition;
		    _phaseShift = phaseShift;
	    }

	    public override TaskState Process()
	    {
			if (_condition != null && !CachedCardLists.TryGetValue(Source.Card.AssetId, out Card[] cards))
		    {
			    cards = Cards.FormatTypeCards(Game.FormatType)
				    .Where(card => card.Type == CardType.SPELL && _condition(card)).ToArray();

			    CachedCardLists.TryAdd(Source.Card.AssetId, cards);
		    }
			else if (!CachedCardLists.TryGetValue(0, out cards))
			{
				cards = Cards.FormatTypeCards(Game.FormatType).Where(card => card.Type == CardType.SPELL && !card.IsQuest).ToArray();
				CachedCardLists.TryAdd(0, cards);
			}

		    Controller c = Source.Controller;

			Card randCard = null;
		    do
		    {
			    randCard = cards[Random.Next(cards.Length)];
		    } while (!randCard.Implemented || randCard.HideStat);

		    Game.OnRandomHappened(true);

			Spell spellToCast = (Spell)Target ?? (Spell)Entity.FromCard(c, randCard);

		    Game.Log(LogLevel.INFO, BlockType.POWER, "CastRandomSpellTask",
			    !Game.Logging ? "" : $"{Source} casted {c.Name}'s {spellToCast}.");

		    if (spellToCast.IsSecret && c.SecretZone.IsFull)
		    {
				c.GraveyardZone.Add(spellToCast);
			    return TaskState.COMPLETE;
		    }

			ICharacter randTarget = null;
		    if (randCard.RequiresTarget || randCard.RequiresTargetIfAvailable)
		    {
			    List<ICharacter> targets = (List<ICharacter>)spellToCast.ValidPlayTargets;

				randTarget = targets.Count > 0 ? Util.RandomElement(targets) : null;

			    spellToCast.CardTarget = randTarget?.Id ?? -1;

				Game.Log(LogLevel.INFO, BlockType.POWER, "CastRandomSpellTask",
					!Game.Logging ? "" : $"{spellToCast}'s target is randomly selected to {randTarget}");
			}

			int randChooseOne = Random.Next(1, 3);

		    if (randCard.HasOverload)
				c.OverloadOwed = randCard.Overload;

			Choice choiceTemp = c.Choice;
			c.Choice = null;

			Game.TaskQueue.StartEvent();
			Generic.CastSpell.Invoke(c, spellToCast, randTarget, randChooseOne);
			// forced death processing & AA (Yogg)
			if (_phaseShift)
				Game.DeathProcessingAndAuraUpdate();
		    Game.TaskQueue.EndEvent();


		    //Game.TaskQueue.Execute(spellToCast.Power.PowerTask, Source.Controller, spellToCast, randTarget, randChooseOne);
		    //Game.DeathProcessingAndAuraUpdate();

			while (c.Choice != null)
			{
				Game.TaskQueue.StartEvent();
				Generic.ChoicePick.Invoke(c, Util.Choose(c.Choice.Choices));
			    Game.ProcessTasks();
				Game.TaskQueue.EndEvent();
				Game.DeathProcessingAndAuraUpdate();
			}

			c.Choice = choiceTemp;

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new CastRandomSpellTask(_condition, _phaseShift);
	    }
    }
}
