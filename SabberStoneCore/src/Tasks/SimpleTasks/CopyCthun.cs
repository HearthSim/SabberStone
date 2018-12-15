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
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class CopyCthun : SimpleTask
	{
		public override TaskState Process()
		{
			if (!(Source is IPlayable source))
				return TaskState.STOP;

			if (Controller.ProxyCthun == 0)
				return TaskState.STOP;

			IPlayable proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];


			if (Game.History)
			{
				if (source.AppliedEnchantments == null)
					source.AppliedEnchantments = new List<Enchantment>();
				
				proxyCthun.AppliedEnchantments?.ForEach(e =>
				{
					Enchantment instance = Enchantment.GetInstance(Controller, (IPlayable)Target, Target, e.Card);
					if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
					{
						instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
							instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
					}
				});
			}

			proxyCthun.OngoingEffect?.Clone((IPlayable)Source);
			Target[GameTag.ATK] = proxyCthun[GameTag.ATK];
			Target[GameTag.HEALTH] = proxyCthun[GameTag.HEALTH];
			Target[GameTag.TAUNT] = proxyCthun[GameTag.TAUNT];

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new CopyCthun();
			clone.Copy(this);
			return clone;
		}
	}
}
