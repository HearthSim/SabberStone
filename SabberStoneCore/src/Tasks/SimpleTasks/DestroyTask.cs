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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DestroyTask : SimpleTask
	{
		private EntityType _type;
		private readonly bool _forcedDeathPhase;

		public DestroyTask(EntityType entityType, bool forcedDeathPhase = false)
		{
			_type = entityType;
			_forcedDeathPhase = forcedDeathPhase;
		}

		public override TaskState Process()
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
				p.Destroy();

			if (_forcedDeathPhase)
			{
				Game.DeathProcessingAndAuraUpdate();
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DestroyTask(_type, _forcedDeathPhase);
			clone.Copy(this);
			return clone;
		}
	}
}
