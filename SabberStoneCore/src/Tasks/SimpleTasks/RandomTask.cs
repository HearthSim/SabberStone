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
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SplitTask : SimpleTask
	{
		public SplitTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			//List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);

			//if (entities.Count == 0)
			//	return TaskState.STOP;

			IEnumerable<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);

			if (Game.Splitting && Game.Splits.Count == 0)
			{
				if (Amount == 1)
				{
					//entities.ForEach(p =>
					foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
					{
						//Game.Dump("SplitTask", $"{sets.IndexOf(p)}: {string.Join(";", p)}");
						Playables = new List<IPlayable> { p };
						State = TaskState.COMPLETE;
						Game clone = Game.Clone();
						Game.Splits.Add(clone);
					};
				}
				else
				{
					var sets = Util.GetPowerSet(entities.ToList()).Where(plist => plist.Count() == Amount).ToList();
					sets.ForEach(plist =>
					{
						Game.Dump("SplitTask", $"{sets.IndexOf(plist)}: {String.Join(";", plist)}");
						Playables = plist.ToList();
						State = TaskState.COMPLETE;
						Game clone = Game.Clone();
						Game.Splits.Add(clone);
					});
				}
				//Game.TaskQueue.TaskList.Clear();
				Game.TaskQueue.ClearCurrentEvent();
				return TaskState.STOP;
			}


			Playables = entities is List<IPlayable> list ? list : entities.ToList();

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SplitTask(Amount, Type);
			clone.Copy(this);
			return clone;
		}

	}

	public class RandomTask : SimpleTask
	{
		public RandomTask(int amount, EntityType type)
		{
			Amount = amount;
			Type = type;
		}

		public int Amount { get; set; }

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			IEnumerable<IPlayable> temp = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			List<IPlayable> entities = temp is List<IPlayable> list ? list : temp.ToList();

			if (entities.Count == 0)
				return TaskState.STOP;

			Playables = new List<IPlayable>();
			for (int i = 0; i < Amount && entities.Count > 0; i++)
			{
				IPlayable randPlayable = Util.Choose<IPlayable>(entities);
				entities.Remove(randPlayable);
				Playables.Add(randPlayable);
			}

			Game.OnRandomHappened(true);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RandomTask(Amount, Type);
			clone.Copy(this);
			return clone;
		}
	}
}
