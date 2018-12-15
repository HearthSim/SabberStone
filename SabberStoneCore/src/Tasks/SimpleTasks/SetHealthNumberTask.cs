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
namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class SetHealthNumberTask : SimpleTask
	//{
	//	public SetHealthNumberTask(EntityType entityType)
	//	{
	//		Type = entityType;
	//	}

	//	public EntityType Type { get; set; }

	//	public override TaskState Process()
	//	{
	//		System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
	//		entities.TrueForAll(p =>
	//		{
	//			var target = p as Minion;
	//			if (target == null)
	//			{
	//				return false;
	//			}

	//			// work around health buffs
	//			//p.OldEnchants.ForEach(t =>
	//			//{
	//			//	if (t.Effects.ContainsKey(GameTag.HEALTH))
	//			//	{
	//			//		t.Effects.Remove(GameTag.HEALTH);
	//			//	}
	//			//});

	//			target.Health = Number;
	//			return true;
	//		});

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new SetHealthNumberTask(Type);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
