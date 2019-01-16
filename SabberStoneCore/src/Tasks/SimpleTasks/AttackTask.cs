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
using SabberStoneCore.Model;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var attacker =
				(ICharacter) IncludeTask.GetEntities(_aType, in controller, source, target, stack?.Playables)[0];
			var defender =
				(ICharacter) IncludeTask.GetEntities(_dType, in controller, source, target, stack?.Playables)[0];

			if (defender.Card.Untouchable) return TaskState.STOP;

			Generic.AttackBlock.Invoke(attacker.Controller, attacker, defender, true);
			attacker.Controller.NumOptionsPlayedThisTurn--;

			return TaskState.COMPLETE;
		}
	}
}
