using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AttackTask : SimpleTask
    {
	    private readonly EntityType _aType;
	    private readonly EntityType _dType;

	    public AttackTask(EntityType attacker, EntityType defender)
	    {
			_aType = attacker;
			_dType = defender;
	    }

	    public override TaskState Process()
	    {
		    ICharacter attacker = (ICharacter)IncludeTask.GetEntities(_aType, Controller, Source, Target, Playables)[0];
		    ICharacter defender = (ICharacter)IncludeTask.GetEntities(_dType, Controller, Source, Target, Playables)[0];

			if (defender.Card.Untouchable) return TaskState.STOP;

		    Generic.AttackBlock.Invoke(attacker.Controller, attacker, defender, true);
		    attacker.Controller.NumOptionsPlayedThisTurn--;

			return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new AttackTask(_aType, _dType);
	    }
    }
}
