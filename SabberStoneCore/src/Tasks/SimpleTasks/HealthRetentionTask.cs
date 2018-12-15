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
	//public class HealthRetentionTask : SimpleTask
	//{
	//	public int Amount { get; set; }

	//	public EntityType Type { get; set; }

	//	public HealthRetentionTask(int amount, EntityType type)
	//	{
	//		Amount = amount;
	//		Type = type;
	//	}

	//	public override TaskState Process()
	//	{
	//		var source = Source as ICharacter;
	//		if (source == null || Amount < 1)
	//		{
	//			return TaskState.STOP;
	//		}

	//		//IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).ForEach(p =>
	//		foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
	//		{
	//			var target = p as ICharacter;
	//			if (target != null)
	//			{
	//				//int baseHealth = target.Card.Tags[Enums.GameTag.HEALTH];
	//				target.IsIgnoreDamage = true;

	//				//if (target.Health >= baseHealth)
	//				//	target.Health = baseHealth;
	//				//else
	//					target.Damage -= Amount;

	//				target.IsIgnoreDamage = false;
	//			}
	//		};

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new HealthRetentionTask(Amount, Type);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
