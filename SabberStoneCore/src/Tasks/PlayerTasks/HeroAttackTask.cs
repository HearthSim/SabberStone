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

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		public static HeroAttackTask Any(Controller controller, ICharacter target, bool skipPrePhase = false)
		{
			return new HeroAttackTask(controller, target, skipPrePhase);
		}
		private HeroAttackTask(Controller controller, ICharacter target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override bool Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target, SkipPrePhase, false);
			return success;
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}
	}
}
