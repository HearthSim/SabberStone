using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ChangeUnidentifiedTask : SimpleTask
    {
	    public override TaskState Process()
	    {
		    Generic.ChangeEntityBlock(Controller, (IPlayable)Source, Cards.FromId(Util.Choose(Source.Card.Entourage)));
		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new ChangeUnidentifiedTask();
	    }
    }
}
