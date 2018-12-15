#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
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
