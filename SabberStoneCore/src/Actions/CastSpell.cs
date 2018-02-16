using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
    public static partial class Generic
    {
	    public static Action<Controller, Spell, ICharacter, int> CastSpell
		    => delegate(Controller c, Spell spell, ICharacter target, int chooseOne)
		    {
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

			    c.Game.DeathProcessingAndAuraUpdate();
		    };
    }
}
