using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddEnchantmentTask : SimpleTask
    {
	    private readonly Card _enchantmentCard;

		private readonly EntityType _entityType;

	    public AddEnchantmentTask(Card enchantmentCard, EntityType entityType)
	    {
		    _enchantmentCard = enchantmentCard;
		    _entityType = entityType;
	    }

	    public override TaskState Process()
	    {
		    List<IPlayable> entities = IncludeTask.GetEntites(_entityType, Controller, Source, Target, Playables);

		    foreach (IPlayable entity in entities)
		    {
			    Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable) Source, entity, _enchantmentCard);

				//	should make this as a method of Enchantment, Power or Enchant
			    foreach (Power power in enchantment.Powers)
			    {
				    for (int i = 0; i < power.Enchant.Effects.Length; i++)
					    power.Enchant.Effects[i].Apply(entity);
			    }
		    }

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			throw new NotImplementedException();
		}
	}
}
