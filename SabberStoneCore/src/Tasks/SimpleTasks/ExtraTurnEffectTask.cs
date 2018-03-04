using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ExtraTurnEffectTask : SimpleTask
    {
	    //private readonly bool _opposite;

	    public ExtraTurnEffectTask(/*bool opposite = false*/)
	    {
		    //_opposite = opposite;
	    }

	    public override TaskState Process()
	    {
		    Controller c = /*_opposite ? Controller.Opponent :*/ Controller;

		    if (c[Enums.GameTag.CURRENT_PLAYER] == 1)
			    c.NumTurnsLeft++;
		    else
			    throw new NotImplementedException();

			return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new ExtraTurnEffectTask(/*_opposite*/);
	    }
    }
}
