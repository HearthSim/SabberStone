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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RemoveEnchantmentTask : SimpleTask
    {
		public override TaskState Process()
	    {
			// Remove applied effects of this enchantment
		  //  if (_enchantmentCard != null &&
		  //      _enchantmentCard[Enums.GameTag.TAG_ONE_TURN_EFFECT] != 1 &&
		  //      _enchantmentCard.Power.Enchant?.Effects != null)
				//foreach (Effect effect in _enchantmentCard.Power.Enchant.Effects)
				//	effect.Remove(Source is Enchantment ec ? ec.Target : Source);

		    if (!(Source is Enchantment e)) throw new NotImplementedException();

			if (!e.IsOneTurnActive && e.Power.Enchant?.Effects != null)
				foreach (Effect effect in e.Power.Enchant.Effects)
					effect.Remove(Target);

		    e.Remove();

			// Remove the enchantment entity
		    //if (Source is Enchantment e)
			   // e.Remove();

			return TaskState.COMPLETE;
	    }
		
	    public override ISimpleTask Clone()
	    {
		    return new RemoveEnchantmentTask();
	    }
    }
}
