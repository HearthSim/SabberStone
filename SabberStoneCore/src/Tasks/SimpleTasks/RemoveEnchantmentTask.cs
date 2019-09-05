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
using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	// Remove applied effects of this enchantment
	public class RemoveEnchantmentTask : SimpleTask
	{
		public static readonly RemoveEnchantmentTask Task = new RemoveEnchantmentTask();
		private RemoveEnchantmentTask() {}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (!(source is Enchantment e)) throw new NotImplementedException();

			Enchant enchant = e.Power.Enchant;
			if (enchant != null && (!e.IsOneTurnActive || game.Step != Step.MAIN_CLEANUP))
			{
				if (enchant.UseScriptTag)
					enchant.RemoveEffect(e.Target, e.ScriptTag1, e.ScriptTag2);
				else
					enchant.RemoveEffect(e.Target);

				if (e.IsOneTurnActive)
					foreach (IEffect eff in enchant.Effects)
						game.OneTurnEffects.Remove((e.Target.Id, eff));
			}

			e.Remove();

			return TaskState.COMPLETE;
		}
	}
}
