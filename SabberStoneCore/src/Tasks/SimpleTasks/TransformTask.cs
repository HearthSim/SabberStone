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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class TransformTask : SimpleTask
	{
		private readonly Card _card;
		private readonly EntityType _type;
		private readonly bool _useOldMechanism;

		public TransformTask(Card card, EntityType type)
		{
			_card = card;
			_type = type;
		}

		public TransformTask(string cardId, EntityType type, bool useOldMechanism = false)
		{
			_card = Cards.FromId(cardId);
			_type = type;
			_useOldMechanism = useOldMechanism;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			IList<IPlayable> entities = IncludeTask.GetEntities(in _type, in controller, source, target, stack?.Playables);

			if (_useOldMechanism)
				for (int i = 0; i < entities.Count; i++)
					Generic.TransformBlock(entities[i].Controller, _card, entities[i] as Minion);
			else
				for (int i = 0; i < entities.Count; i++)
					Generic.ChangeEntityBlock(controller, entities[i], _card, true);

			return TaskState.COMPLETE;
		}
	}
}
