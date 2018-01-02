using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddEnchantmentTask : SimpleTask
    {
	    private readonly Card _enchantmentCard;
		private readonly EntityType _entityType;
	    private readonly bool _useScriptTag;

	    public AddEnchantmentTask(Card enchantmentCard, EntityType entityType, bool useScriptTag = false)
	    {
		    _enchantmentCard = enchantmentCard;
		    _entityType = entityType;
		    _useScriptTag = useScriptTag;
		}

	    public AddEnchantmentTask(string enchantmentId, EntityType entityType, bool useScriptTag = false)
	    {
		    _enchantmentCard = Cards.FromId(enchantmentId);
		    _entityType = entityType;
		    _useScriptTag = useScriptTag;
	    }

		public override TaskState Process()
	    {
		    List<IPlayable> entities = IncludeTask.GetEntites(_entityType, Controller, Source, Target, Playables);

		    foreach (IPlayable entity in entities)
		    {

				Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable)Source, entity, _enchantmentCard);

			    if (_useScriptTag)
			    {
					enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = Number;
			    }

				foreach (Power power in _enchantmentCard.Powers)
				{
					power.Trigger?.Activate(enchantment);

					if (power.Enchant is OngoingEnchant && entity.OngoingEffect != null)
					{
						((OngoingEnchant) entity.OngoingEffect).Count++;
					}
					else
					{
						power.Enchant?.ActivateTo(entity, enchantment);
					}

					if (power.DeathrattleTask != null)
					{
						entity.HasDeathrattle = true;
					}
				}
			}

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			var clone = new AddEnchantmentTask(_enchantmentCard, _entityType, _useScriptTag);
			return clone;
		}
	}
}
