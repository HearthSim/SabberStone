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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ArmorTask : SimpleTask
	{
		private ArmorTask(bool useNumber, int amount)
		{
			UseNumber = useNumber;
			Amount = amount;
		}

		/// <summary>
		/// Adding the amount as Armor.
		/// </summary>
		public ArmorTask(int amount)
		{
			UseNumber = false;
			Amount = amount;
		}

		/// <summary>
		/// Adding the value contained in Number as Armor.
		/// </summary>
		public ArmorTask()
		{
			UseNumber = true;
			Amount = 0;
		}

		public bool UseNumber { get; set; }
		public int Amount { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}
			Controller.Hero.GainArmor(source, UseNumber ? Number : Amount);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ArmorTask(UseNumber, Amount);
			clone.Copy(this);
			return clone;
		}
	}
}