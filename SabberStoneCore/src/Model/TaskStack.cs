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
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model
{
	public class TaskStack
	{
		public IList<IPlayable> Playables { get; set; }
		public bool Flag { get; set; }
		public int Number { get; set; } = -1;
		public int Number1 { get; set; } = -1;
		public int Number2 { get; set; }
		public int Number3 { get; set; }
		public int Number4 { get; set; }

		public void AddPlayables(IEnumerable<IPlayable> playables)
		{
			if (Playables is List<IPlayable> list)
				list.AddRange(playables);
			else
			{
				var toList = Playables.ToList();
				toList.AddRange(playables);
				Playables = toList;
			}
		}
		
		public void AddPlayable(IPlayable playable)
		{
			if (Playables is List<IPlayable> list)
				list.Add(playable);
			else
			{
				if (Playables == null)
					Playables = new List<IPlayable> {playable};
				else
				{
					List<IPlayable> toList = Playables.ToList();
					toList.Add(playable);
					Playables = toList;
				}
			}
		}
		
		public TaskStack Clone(Game game)
		{

			var clone = new TaskStack()
			{
				Playables = new List<IPlayable>(),
				Flag = Flag,
				Number = Number,
				Number1 = Number1,
				Number2 = Number2,
				Number3 = Number3,
				Number4 = Number4
			};

			if (Playables.Count > 0)
				clone.AddPlayables(Playables.Select(p => game.IdEntityDic[p.Id]));

			return clone;
		}
	}
}
