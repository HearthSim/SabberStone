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
	public class RemoveEnchantmentTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			// Remove applied effects of this enchantment
			//  if (_enchantmentCard != null &&
			//      _enchantmentCard[Enums.GameTag.TAG_ONE_TURN_EFFECT] != 1 &&
			//      _enchantmentCard.Power.Enchant?.Effects != null)
			//foreach (Effect effect in _enchantmentCard.Power.Enchant.Effects)
			//	effect.Remove(source is Enchantment ec ? ec.Target : source);

			if (!(source is Enchantment e)) throw new NotImplementedException();

			if (e.Power.Enchant?.Effects != null)
				if (!e.IsOneTurnActive || game.Step != Step.MAIN_CLEANUP)
					foreach (IEffect effect in e.Power.Enchant.Effects)
						effect.RemoveFrom(target);

			e.Remove();

			// Remove the enchantment entity
			//if (source is Enchantment e)
			// e.Remove();

			return TaskState.COMPLETE;
		}
	}
}
