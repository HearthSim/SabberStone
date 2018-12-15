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
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ChanceTask : SimpleTask
	{
		public ChanceTask(bool useFlag = false)
		{
			UseFlag = useFlag;
		}

		public bool UseFlag { get; set; }

		public override TaskState Process()
		{
			int random = Util.Random.Next(0, 2);

			if (!UseFlag)
			{
				return random == 0 ? TaskState.COMPLETE : TaskState.STOP;
			}

			Flag = random != 0;
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new ChanceTask(UseFlag);
			clone.Copy(this);
			return clone;
		}
	}
}