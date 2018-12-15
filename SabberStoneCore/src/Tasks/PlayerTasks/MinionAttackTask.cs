#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class MinionAttackTask : PlayerTask
	{
		public static MinionAttackTask Any(Controller controller, IEntity source, IEntity target, bool skipPrePhase = false)
		{
			return new MinionAttackTask(controller, source, target, skipPrePhase);
		}

		private MinionAttackTask(Controller controller, IEntity source, IEntity target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.MINION_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Source as Minion, Target as ICharacter, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"MinionAttackTask => [{Controller.Name}] {Source}({Source.Card.Type}) attack {Target}";
		}
	}
}
