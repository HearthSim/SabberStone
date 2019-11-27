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
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromDeck : SimpleTask
	{
		private readonly EntityType _type;
		private readonly bool _addToStack;

		public RemoveFromDeck(EntityType type, bool addToStack = true)
		{
			_type = type;
			_addToStack = addToStack;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			IList<IPlayable> entities = IncludeTask.GetEntities(_type, in controller, source, target, stack.Playables);
			bool history = game.History;

			if (_addToStack)
			{
				List<IPlayable> playables = new List<IPlayable>(entities.Count);
				for (int i = 0; i < entities.Count; i++)
				{
					IPlayable p = entities[i];
					if (p.Zone.Type != Zone.DECK) continue;
					if (history) game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(p));
					if (Generic.RemoveFromZone(p.Controller, p))
						playables.Add(p);
				}
				stack.Playables = playables;
			}
			else
			{
				for (int i = 0; i < entities.Count; i++)
				{
					IPlayable p = entities[i];
					if (p.Zone.Type != Zone.DECK) continue;
					if (history) game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(p));
					Generic.RemoveFromZone(p.Controller, p);
				}
			}

			return TaskState.COMPLETE;
		}
	}
}
