using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	//public class CopyDeathrattleTask : SimpleTask
	//{
	//	public EntityType Type { get; set; }

	//	public override TaskState Process()
	//	{
	//		var source = Source as Minion;
	//		var target = Target as Minion;

	//		Game.Log(LogLevel.INFO, BlockType.SCRIPT, "CopyDeathrattleTask", !Game.Logging? "":"Inside the Task.");

	//		if (source == null || target == null)
	//		{
	//			return TaskState.STOP;
	//		}

	//		//target.Powers.ForEach(p =>
	//		//{
	//		//	if (p.Activation == PowerActivation.DEATHRATTLE)
	//		//	{
	//		//		source.Powers.Add(p);
	//		//		source.HasDeathrattle = true;
	//		//	}
	//		//});


	//		return TaskState.COMPLETE;
	//	}

	//	public override ISimpleTask Clone()
	//	{
	//		var clone = new CopyDeathrattleTask();
	//		clone.Copy(this);
	//		return clone;
	//	}
	//}
}
