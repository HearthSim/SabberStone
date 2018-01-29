using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class TransformCopyTask : SimpleTask
    {
	    public override TaskState Process()
	    {
			Minion target = (Minion)Target;
			if (target == null)
				return TaskState.STOP;

			Minion source = (Minion)Source;
		    var tags = new EntityData.Data
		    {
			    {GameTag.CREATOR, Source.Id},
		    };
		    if (Game.History)
			    tags.Add(GameTag.PREMIUM, target[GameTag.PREMIUM]);

		    Minion copy = (Minion) Entity.FromCard(Controller, target.Card, tags);

		    Trigger trigger = target.ActivatedTrigger;
		    IAura aura = target.OngoingEffect;

		    // LINKED_ENTITY
		    source.Controller.BoardZone.Replace(source, copy);

			// Copy Enchantments
			if (Game.History && target.AppliedEnchantments != null)
		    {
			    foreach (Enchantment e in target.AppliedEnchantments)
			    {
				    var instance = Enchantment.GetInstance(Controller, copy, copy, e.Card);
				    if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
					{
						instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
							instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
					}
				}
		    }

			foreach (KeyValuePair<GameTag, int> kvp in target._data.Tags)
			{
				switch (kvp.Key)
				{
					case GameTag.ENTITY_ID:
					case GameTag.CONTROLLER:
					case GameTag.ZONE:
					case GameTag.ZONE_POSITION:
					case GameTag.CREATOR:
					case GameTag.PREMIUM:
						continue;
					default:
						copy._data.Tags.Add(kvp.Key, kvp.Value);
						break;
				}
			}

			if (aura != null && copy.OngoingEffect == null)
				aura?.Clone(copy);

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
	    {
			return this;
	    }
    }
}
