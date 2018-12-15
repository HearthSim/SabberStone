#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ManaCrystalEmptyTask : SimpleTask
	{
		public ManaCrystalEmptyTask(int amount, bool opponent = false, bool useNumber = false)
		{
			Amount = amount;
			Opponent = opponent;
			UseNumber = useNumber;
		}

		public int Amount { get; set; }
		public bool Opponent { get; set; }
		public bool UseNumber { get; set; }

		public override TaskState Process()
		{
			if (UseNumber)
			{
				Amount = Number;
			}

			bool success = Generic.ChangeManaCrystal.Invoke(!Opponent ? Controller : Controller.Opponent, Amount, false);
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ManaCrystalEmptyTask(Amount, Opponent, UseNumber);
			clone.Copy(this);
			return clone;
		}
	}
}