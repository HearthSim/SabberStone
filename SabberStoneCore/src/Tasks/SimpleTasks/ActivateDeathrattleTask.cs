using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	// TODO
    public class ActivateDeathrattleTask : SimpleTask
    {
	    private readonly EntityType _type;

	    public ActivateDeathrattleTask(EntityType type)
	    {
		    _type = type;
	    }


	    public override TaskState Process()
	    {
		    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
		    {
			    p.ActivateTask(Enums.PowerActivation.DEATHRATTLE);
		    }

		    return TaskState.STOP;
	    }

	    public override ISimpleTask Clone()
	    {
		    throw new NotImplementedException();
	    }
    }
}
