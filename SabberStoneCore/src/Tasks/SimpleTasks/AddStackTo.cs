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
using System;
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddStackTo : SimpleTask
	{
		public AddStackTo(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			Playables.ForEach(p => p[Enums.GameTag.DISPLAYED_CREATOR] = Source.Id);
			switch (Type)
			{
				case EntityType.DECK:
					Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.HAND:
					Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{
			var clone = new AddStackTo(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
