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
namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class RandomCardIdFromListTask : SimpleTask
	//{
	//	public override TaskState Process()
	//	{
	//		if (CardIds.Count == 0)
	//			return TaskState.STOP;

	//		IPlayable randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose<string>(CardIds)));
	//		Playables.Clear();
	//		Playables.Add(randomCard);

	//		Game.OnRandomHappened(true);

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new RandomCardIdFromListTask();
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
