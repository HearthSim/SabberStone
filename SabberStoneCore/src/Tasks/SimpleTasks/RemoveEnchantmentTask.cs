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
		    if (_enchantmentCard.Powers[0].Aura != null)
			    Game.Auras.Find(p => p.EnchantmentCardId == _enchantmentCard.Id).Remove();

		    foreach (Effect effect in _enchantmentCard.Powers[0].Enchant?.Effects)
			    effect.Remove(Target);

			ISimpleTask task = _enchantmentCard.Powers[0].Enchant?.TaskToDoWhenThisIsRemoved;
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
