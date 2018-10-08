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
	//		System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
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
