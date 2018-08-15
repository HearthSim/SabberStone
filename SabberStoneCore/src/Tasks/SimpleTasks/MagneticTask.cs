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
