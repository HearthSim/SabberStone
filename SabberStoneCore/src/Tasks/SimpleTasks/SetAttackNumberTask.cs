namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class SetAttackNumberTask : SimpleTask
	//{
	//	/// <summary>
	//	///  Changes the attack attribute of the given entity.
	//	/// </summary>
	//	public SetAttackNumberTask(EntityType entityType)
	//	{
	//		Type = entityType;
	//	}

	//	public EntityType Type { get; set; }

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

	//			target.AttackDamage = stack.Number;
	//			return true;
	//		});

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new SetAttackNumberTask(Type);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
