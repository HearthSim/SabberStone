//namespace SabberStoneCore.Tasks.SimpleTasks
//{
	//public class ActivateEnchantment : SimpleTask
	//{
	//	public ActivateEnchantment(EntityType entityType, PowerActivation activation)
	//	{
	//		Type = entityType;
	//		Activation = activation;
	//	}

	//	public EntityType Type { get; set; }

	//	public PowerActivation Activation { get; set; }

	//	public override TaskState Process()
	//	{

	//		System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, in controller, source, target, stack?.Playables);

	//		entities.ForEach(p =>
	//		{
	//			p.Powers.ForEach(t =>
	//			{
	//				if (t.Activation == Activation)
	//				{
	//					//t.Activate(controller, p, target as IPlayable);
	//				}
	//			});

	//		});

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new ActivateEnchantment(Type, Activation);
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
//}
