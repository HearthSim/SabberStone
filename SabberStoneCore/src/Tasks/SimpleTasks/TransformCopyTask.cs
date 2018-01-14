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
		    var tags = new Dictionary<GameTag, int>
		    {
			    {GameTag.CREATOR, Source.Id},
		    };
		    if (Game.History)
			    tags.Add(GameTag.PREMIUM, target[GameTag.PREMIUM]);


		    Minion copy = (Minion) Entity.FromCard(Controller, target.Card, tags);

		    //target.ActivatedTriggers.ForEach(p => p.Activate(copy));
		    //target.OngoingEffect.Clone(copy);

		    var triggers = new List<Trigger>(target.ActivatedTriggers);
		    var aura = target.OngoingEffect;

		    // LINKED_ENTITY
		    source.Controller.BoardZone.Replace(source, copy);

			// Copy Enchantments
			if (Game.History)
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

			foreach (KeyValuePair<GameTag, int> kvp in target.NativeTags)
			{
				switch (kvp.Key)
				{
					case GameTag.ENTITY_ID:
					case GameTag.CONTROLLER:
					case GameTag.ZONE:
					case GameTag.ZONE_POSITION:
						continue;
					default:
						copy.NativeTags.Add(kvp.Key, kvp.Value);
						break;
				}
			}

		    triggers.ForEach(t => t.Activate(copy));
		    aura?.Clone(copy);

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
	    {
			return this;
	    }
    }
}
