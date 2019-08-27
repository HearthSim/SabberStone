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
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
    public static partial class Generic
    {
	    public static Action<Controller, Game, Spell, ICharacter, int> CastSpell
		    => delegate(Controller c, Game game, Spell spell, ICharacter target, int chooseOne)
		    {
				if (game.Logging)
				{
					var sb = new StringBuilder();
					sb.Append("Spell ");
					sb.Append(spell);
					sb.Append(" is cast");
					if (target != null)
					{
						sb.Append(" to ");
						sb.Append(target);
					}
					sb.Append(".");
					if (chooseOne > 0)
						sb.Append($"(ChooseOne: {{{chooseOne}}}.)");

					game.Log(LogLevel.INFO, BlockType.PLAY, "CastSpell", sb.ToString());
				}

				game.TaskQueue.StartEvent();
			    if (spell.IsSecret || spell.IsQuest)
			    {
				    spell.Power.Trigger?.Activate(spell);
				    c.SecretZone.Add(spell);
				    spell.IsExhausted = true;
			    }
			    else
			    {
				    //spell.Power?.Trigger?.Activate(spell);
				    if (spell.Power?.Trigger != null && spell.ActivatedTrigger == null)
					    spell.Power.Trigger.Activate(spell);
				    spell.Power?.Aura?.Activate(spell);

				    if (spell.Combo && c.IsComboActive)
					    spell.ActivateTask(PowerActivation.COMBO, target);
				    else
					    spell.ActivateTask(PowerActivation.POWER, target, chooseOne);

				    if (spell.IsTwinSpell)
				    {
					    Entity.FromCard(in c, Cards.FromAssetId(spell.Card[GameTag.TWINSPELL_COPY]), zone: c.HandZone);
				    }

				    // process power tasks
				    game.ProcessTasks();

				    OverloadBlock(c, spell, game.History);

				    c.GraveyardZone.Add(spell);
			    }
			    game.TaskQueue.EndEvent();
		    };
    }
}
