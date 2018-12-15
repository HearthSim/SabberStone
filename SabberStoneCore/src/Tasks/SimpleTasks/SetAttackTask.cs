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
	//public class SetAttackTask : SimpleTask
	//{
	//	/// <summary>
	//	///  Changes the attack attribute of the given entity.
	//	/// </summary>
	//	public SetAttackTask(int amount, EntityType entityType)
	//	{
	//		Amount = amount;
	//		Type = entityType;
	//	}

	//	public EntityType Type { get; set; }

	//	public int Amount { get; set; }

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

	//			// work around attack buffs
	//			//p.OldEnchants.ForEach(t =>
	//			//{
	//			//	if (t.Effects.ContainsKey(GameTag.ATK))
	//			//	{
	//			//		t.Effects.Remove(GameTag.ATK);
	//			//	}
	//			//});

	//			target.AttackDamage = Amount;
	//			return true;
	//		});

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new SetAttackTask(Amount, Type);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
