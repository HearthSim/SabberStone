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
	//		System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
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

	//			target.Health = stack.Number;
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
