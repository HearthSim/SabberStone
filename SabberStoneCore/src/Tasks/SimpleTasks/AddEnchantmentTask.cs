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
			//	Controller Auras (OTEs)
		    if (_entityType == EntityType.CONTROLLER)
		    {
			    Power power = _enchantmentCard.Powers[0];
				if (Game.History)
			    {
				    Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable) Source, Controller, _enchantmentCard);
				    power.Aura?.Activate(enchantment);
				    power.Trigger?.Activate(enchantment);
				    return TaskState.COMPLETE;
			    }

			    power.Aura?.Activate(Controller.Hero);
			    power.Trigger?.Activate(Controller.Hero);

			    return TaskState.COMPLETE;
		    }

		    List<IPlayable> entities = IncludeTask.GetEntites(_entityType, Controller, Source, Target, Playables);

			//	no indicator enchantment entities when History option is off
		    if (Game.History)
			    foreach (IPlayable entity in entities)
			    {
				    Enchantment enchantment = Enchantment.GetInstance(Controller, (IPlayable) Source, entity, _enchantmentCard);

				    if (_useScriptTag)
					{
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = Number;
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] = Number1;
					}

					if (entity.AppliedEnchantments != null)
					    entity.AppliedEnchantments.Add(enchantment);
				    else
					    entity.AppliedEnchantments = new List<Enchantment> {enchantment};

				    foreach (Power power in _enchantmentCard.Powers)
				    {
					    power.Aura?.Activate(enchantment);
					    power.Trigger?.Activate(enchantment);

					    if (power.Enchant is OngoingEnchant && entity.OngoingEffect != null)
						    ((OngoingEnchant) entity.OngoingEffect).Count++;
					    else
						    power.Enchant?.ActivateTo(entity, enchantment);

					    if (power.DeathrattleTask != null)
						    entity.HasDeathrattle = true;

					    ISimpleTask task = power.Enchant?.TaskToDoWhenThisIsApplied;
				    }
			    }
		    else
			    foreach (IPlayable entity in entities)
					foreach (Power power in _enchantmentCard.Powers)
					{
						power.Aura?.Activate(entity);
						power.Trigger?.Activate(entity);
						Enchantment instance = null;
						if (power.Aura != null || power.Trigger != null)
						{
							instance = Enchantment.GetInstance(Controller, (IPlayable) Source, entity, _enchantmentCard);
							power.Aura?.Activate(instance);
							power.Trigger?.Activate(instance);
						}

						if (power.Enchant is OngoingEnchant && entity.OngoingEffect != null)
							((OngoingEnchant) entity.OngoingEffect).Count++;
						else
							power.Enchant?.ActivateTo(entity, null, Number);

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
