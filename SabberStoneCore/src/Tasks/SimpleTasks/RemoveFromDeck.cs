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
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class RemoveFromDeck : SimpleTask
	{
		public RemoveFromDeck(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			Playables = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Where(p => p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p)).ToList();
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RemoveFromDeck(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
