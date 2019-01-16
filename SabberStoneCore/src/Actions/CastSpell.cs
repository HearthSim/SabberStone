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
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
    public static partial class Generic
    {
	    public static Action<Controller, Spell, ICharacter, int, bool> CastSpell
		    => delegate(Controller c, Spell spell, ICharacter target, int chooseOne, bool checkOverload)
		    {
			    if (checkOverload && spell.Card.HasOverload)
			    {
				    int amount = spell.Overload;
				    c.OverloadOwed += amount;
				    c.OverloadThisGame += amount;
				}

			    c.Game.TaskQueue.StartEvent();
			    if (spell.IsSecret || spell.IsQuest)
			    {
				    spell.Power.Trigger?.Activate(spell);
				    c.SecretZone.Add(spell);
				    spell.IsExhausted = true;
			    }
			    else
			    {
				    spell.Power?.Trigger?.Activate(spell);
				    spell.Power?.Aura?.Activate(spell);

				    if (spell.Combo && c.IsComboActive)
					    spell.ActivateTask(PowerActivation.COMBO, target);
				    else
					    spell.ActivateTask(PowerActivation.POWER, target, chooseOne);

				    c.GraveyardZone.Add(spell);
			    }

			    // process power tasks
			    c.Game.ProcessTasks();
			    c.Game.TaskQueue.EndEvent();
		    };
    }
}
