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
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetControllerGameTagTask : SimpleTask
	{
		public SetControllerGameTagTask(GameTag tag, int amount, bool opFlag = false)
		{
			Tag = tag;
			Amount = amount;
			OpFlag = opFlag;
		}

		public GameTag Tag { get; set; }

		public int Amount { get; set; }

		public bool OpFlag { get; set; }

		public override TaskState Process()
		{
			Controller controller = OpFlag ? Controller.Opponent : Controller;

			controller[Tag] = Amount;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SetControllerGameTagTask(Tag, Amount, OpFlag);
			clone.Copy(this);
			return clone;
		}
	}
}