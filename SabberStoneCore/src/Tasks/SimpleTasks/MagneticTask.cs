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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Triggers;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MagneticTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			var s = (Minion) source;

			if (s == null || !s.Card.Modular)
			{
				game.Log(LogLevel.ERROR, BlockType.POWER, "Magnetic", $"{source}'s not a Magnetic Minion");
				return TaskState.STOP;
			}

			Minion t;
			int pos = s.ZonePosition;
			if (pos < s.Zone.Count - 1)
				t = s.Controller.BoardZone[pos + 1];
			else
				return TaskState.STOP;

			if (!t.IsRace(Race.MECHANICAL))
				return TaskState.STOP;

			if (game.History)
				s[GameTag.TAG_SCRIPT_DATA_NUM_1] = t.Id;

			Generic.AddEnchantmentBlock(game, Cards.FromId(s.Card.Id + "e"), s, t, s.AttackDamage,
				s.BaseHealth, 0);

			// Aggregate triggers
			if (s.Power.Trigger != null)
			{
				if (t.ActivatedTrigger != null)
				{
					var aggregatedTrigger = new MultiTrigger(t.ActivatedTrigger, s.Power.Trigger);
					t.ActivatedTrigger.Remove();
					t.ActivatedTrigger = null;
					aggregatedTrigger.Activate(t);
				}
				else
				{
					s.Power.Trigger.Activate(t);
				}
			}

			// Tag 871 ??
			// Tag 1037 ??

			// Moves source to Setaside
			s.Controller.SetasideZone.Add(s.Zone.Remove(s));

			return TaskState.COMPLETE;
		}
	}
}
