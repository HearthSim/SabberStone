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
	public class CountTask : SimpleTask
	{
		private readonly int _numberIndex;

		public CountTask(EntityType type, int numberIndex = 0)
		{
			Type = type;
			_numberIndex = numberIndex;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			switch (_numberIndex)
			{
				case 0:
					Number = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 1:
					Number1 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 2:
					Number2 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 3:
					Number3 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 4:
					Number4 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				default:
					throw new System.ArgumentOutOfRangeException("Number Index must be in range [0, 4]");
			}
			
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new CountTask(Type, _numberIndex);
			clone.Copy(this);
			return clone;
		}
	}
}
