using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RemoveEnchantmentTask : SimpleTask
    {
		private readonly Card _enchantmentCard;

	    public RemoveEnchantmentTask(string enchantmentCardId)
	    {
		    _enchantmentCard = Cards.FromId(enchantmentCardId);
	    }

	    private RemoveEnchantmentTask(Card enchantmentCard)
	    {
		    _enchantmentCard = enchantmentCard;
	    }

		public override TaskState Process()
	    {
			//	TODO
		    if (_enchantmentCard.Power.Aura != null)
		    {
			    ((IPlayable) Source).OngoingEffect?.Remove();
		    }

		    if (_enchantmentCard[Enums.GameTag.TAG_ONE_TURN_EFFECT] != 1)
				foreach (Effect effect in _enchantmentCard.Power.Enchant?.Effects)
					effect.Remove(Source is Enchantment ec ? ec.Target : Source);

			ISimpleTask task = _enchantmentCard.Power.Enchant?.TaskToDoWhenThisIsRemoved;
		    if (task != null)
			    Game.TaskQueue.Execute(task, Controller, (IPlayable)Source, (IPlayable)Target);

		    if (Source is Enchantment e)
			    e.Remove();

		    return TaskState.COMPLETE;
	    }
		
	    public override ISimpleTask Clone()
	    {
		    return new RemoveEnchantmentTask(_enchantmentCard);
	    }
    }
}
