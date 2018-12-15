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
	/// <summary>  
	///  Reveals the target(s), effectively removing their stealth attribute.  
	/// </summary> 
	public class RevealStealthTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public RevealStealthTask(EntityType type)
		{
			Type = type;
		}
		public override TaskState Process()
		{
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.HasStealth = false;
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RevealStealthTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
