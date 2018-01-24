using System.Collections.Generic;
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
			//	Controller Auras (OTEs)
		    if (_entityType == EntityType.CONTROLLER)
		    {
			    Power power = _enchantmentCard.Power;
				Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable) Source, Controller, _enchantmentCard);
				power.Aura?.Activate(enchantment);
				power.Trigger?.Activate(enchantment);

			    return TaskState.COMPLETE;
		    }

		    //List<IPlayable> entities = IncludeTask.GetEntities(_entityType, Controller, Source, Target, Playables);
		    IEnumerable<IPlayable> entities = IncludeTask.GetEntities(_entityType, Controller, Source, Target, Playables);

			//	no indicator enchantment entities when History option is off
		    if (Game.History)
			    foreach (IPlayable entity in entities)
			    {
				    Power power = _enchantmentCard.Power;

					if (power.Enchant is OngoingEnchant && entity.OngoingEffect != null)
					{
						((OngoingEnchant)entity.OngoingEffect).Count++;
						continue;
					}

					Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable)Source, entity, _enchantmentCard);

					if (_useScriptTag)
					{
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = Number;
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] = Number1;
					}

					power.Aura?.Activate(enchantment);
					power.Trigger?.Activate(enchantment);
					power.Enchant?.ActivateTo(entity, enchantment);

					if (power.DeathrattleTask != null)
						entity.HasDeathrattle = true;
			    }
		    else
			    foreach (IPlayable entity in entities)
			    {
				    Power power = _enchantmentCard.Power;

				    power.Aura?.Activate(entity);
				    power.Trigger?.Activate(entity);
				    if (power.Aura != null || power.Trigger != null || power.DeathrattleTask != null)
				    {
					    Enchantment instance = Enchantment.GetInstance(Controller, (IPlayable) Source, entity, _enchantmentCard);
					    power.Aura?.Activate(instance);
					    power.Trigger?.Activate(instance);
				    }

				    if (power.Enchant is OngoingEnchant && entity.OngoingEffect != null)
					    ((OngoingEnchant) entity.OngoingEffect).Count++;
				    else
					    power.Enchant?.ActivateTo(entity, null, Number, Number1);

				    if (power.DeathrattleTask != null)
					    entity.HasDeathrattle = true;
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
