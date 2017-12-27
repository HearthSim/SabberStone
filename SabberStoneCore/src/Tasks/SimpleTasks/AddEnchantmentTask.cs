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

				Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable)Source, entity, _enchantmentCard);

				foreach (Power power in _enchantmentCard.Powers)
				{
					power.Trigger?.Activate(Game, enchantment.Id);

					if (power.Enchant is OngoingEffect && entity.OngoingEffect != null)
				    {
					    entity.OngoingEffect.Count++;
				    }
					else
					{
						power.Enchant.ActivateTo(entity, enchantment);
					}
				}
			}

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			var clone = new AddEnchantmentTask(_enchantmentCard, _entityType);
			return clone;
		}
	}
}
