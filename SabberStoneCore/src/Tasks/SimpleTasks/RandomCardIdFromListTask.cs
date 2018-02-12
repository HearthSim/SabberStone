using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class RandomCardIdFromListTask : SimpleTask
	//{
	//	public override TaskState Process()
	//	{
	//		if (CardIds.Count == 0)
	//			return TaskState.STOP;

	//		IPlayable randomCard = Entity.FromCard(Controller, Cards.FromId(Util.Choose<string>(CardIds)));
	//		Playables.Clear();
	//		Playables.Add(randomCard);

	//		Game.OnRandomHappened(true);

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
