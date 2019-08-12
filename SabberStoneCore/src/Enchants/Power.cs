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

using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;
using SabberStoneCore.Triggers;

namespace SabberStoneCore.Enchants
{
	public class Power
	{
		public string InfoCardId { get; set; } = null;

		public IAura Aura { get; set; }

		public Enchant Enchant { get; set; }

		public Trigger Trigger { get; set; }

		public ISimpleTask PowerTask { get; set; }

		public ISimpleTask DeathrattleTask { get; set; }

		public ISimpleTask ComboTask { get; set; }

		public ISimpleTask TopdeckTask { get; set; }

		public ISimpleTask OverkillTask { get; set; }

		internal static Power OneTurnStealthEnchantmentPower =>
			new Power
			{
				Enchant = new Enchant(Effects.StealthEff),
				Trigger = new Trigger(TriggerType.TURN_START)
				{
					SingleTask = RemoveEnchantmentTask.Task,
					RemoveAfterTriggered = true,
				}
			};
	}
}
