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
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageNumberTask : SimpleTask
	{
		public DamageNumberTask(EntityType type, bool spellDmg = false)
		{
			Type = type;
			SpellDmg = spellDmg;
		}

		public EntityType Type { get; set; }

		public bool SpellDmg { get; set; }

		public override TaskState Process()
		{
			if (Number < 1)
			{
				return TaskState.STOP;
			}


			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
				Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Number, SpellDmg);

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DamageNumberTask(Type, SpellDmg);
			clone.Copy(this);
			return clone;
		}
	}
}
