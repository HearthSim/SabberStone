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
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyCthun : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (!(source is IPlayable playableSource))
				return TaskState.STOP;

			if (controller.ProxyCthun == 0)
				return TaskState.STOP;

			var proxyCthun = (Minion) game.IdEntityDic[controller.ProxyCthun];
			var minionTarget = (Minion) target;

			if (game.History)
			{
				if (playableSource.AppliedEnchantments == null)
					playableSource.AppliedEnchantments = new List<Enchantment>();

				if (proxyCthun.AppliedEnchantments != null)
					foreach (Enchantment e in proxyCthun.AppliedEnchantments)
					{
						Enchantment instance =
							Enchantment.GetInstance(in controller, minionTarget, minionTarget, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
						}
					}
			}

			proxyCthun.OngoingEffect?.Clone(playableSource);

			minionTarget.AttackDamage = proxyCthun.AttackDamage;
			minionTarget.BaseHealth = proxyCthun.BaseHealth;
			minionTarget.HasTaunt = proxyCthun.HasTaunt;

			return TaskState.COMPLETE;
		}
	}
}
