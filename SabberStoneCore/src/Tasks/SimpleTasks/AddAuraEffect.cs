using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddAuraEffect : SimpleTask
    {
		private readonly Effect _effect;
		private readonly EntityType _type;
		private readonly TriggerType _removeTrigger;

	    public AddAuraEffect(Effect effect, EntityType entityType)
	    {
			_effect = effect;
		    _type = entityType;
	    }

	    public override TaskState Process()
	    {
		    List<IPlayable> entities = IncludeTask.GetEntites(_type, Controller, Source, Target, Playables);

		    for (int i = 0; i < entities.Count; i++)
			    _effect.Apply(entities[i].AuraEffects);

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new AddAuraEffect(_effect, _type);
	    }
    }
}
