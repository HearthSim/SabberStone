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

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TempManaTask : SimpleTask
	{
		public TempManaTask(int amount)
		{
			Amount = amount;
		}
		public int Amount { get; set; }
		public override TaskState Process()
		{
			Generic.AddTempMana.Invoke(Controller, Amount);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new TempManaTask(Amount);
			clone.Copy(this);
			return clone;
		}
	}
}