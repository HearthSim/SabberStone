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
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MagneticTask : SimpleTask
	{
		public override TaskState Process()
		{
			Minion s = (Minion)Source;

			if (s == null || s[GameTag.MODULAR] == 0)
			{
				Game.Log(Model.LogLevel.ERROR, BlockType.POWER, "Magnetic", $"{Source}'s not a Magnetic Minion");
				return TaskState.STOP;
			}

			Minion t;
			int pos = s.ZonePosition;
			if (pos < s.Zone.Count - 1)
				t = s.Controller.BoardZone[pos + 1];
			else
				return TaskState.STOP;

			if (t.Race != Race.MECHANICAL)
				return TaskState.STOP;

			if (Game.History)
				s[GameTag.TAG_SCRIPT_DATA_NUM_1] = t.Id;

			Generic.AddEnchantmentBlock.Invoke(Controller, Cards.FromId(s.Card.Id + "e"), s, t, s.AttackDamage, s.BaseHealth);

			// Tag 871 ??
			// Tag 1037 ??

			// Moves source to Setaside
			s.Controller.SetasideZone.Add(s.Zone.Remove(s));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return new MagneticTask();
		}
	}
}
