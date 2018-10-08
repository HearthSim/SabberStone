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
	//		var source = source as ICharacter;
	//		if (source == null || Amount < 1)
	//		{
	//			return TaskState.STOP;
	//		}

	//		//IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables).ForEach(p =>
	//		foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
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
