namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class RandomCardIdFromListTask : SimpleTask
	//{
	//	public override TaskState Process()
	//	{
	//		if (CardIds.Count == 0)
	//			return TaskState.STOP;

	//		IPlayable randomCard = Entity.FromCard(controller, Cards.FromId(Util.Choose<string>(CardIds)));
	//		stack?.Playables.Clear();
	//		stack?.Playables.Add(randomCard);

	//		game.OnRandomHappened(true);

	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new RandomCardIdFromListTask();
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
