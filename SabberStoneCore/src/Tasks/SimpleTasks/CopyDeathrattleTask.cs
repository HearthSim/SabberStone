using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyDeathrattleTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public CopyDeathrattleTask()
		{
			Type = EntityType.TARGET;
		}

		public CopyDeathrattleTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as Minion;
			var target = Target as Minion;

			Game.Log(LogLevel.INFO, BlockType.SCRIPT, "CopyDeathrattleTask", "Inside the Task.");

			if (source == null || target == null)
			{
				return TaskState.STOP;
			}

			target.Enchantments.ForEach(p =>
			{
				if (p.Activation == EnchantmentActivation.DEATHRATTLE)
				{
					source.Enchantments.Add(p);
					source.HasDeathrattle = true;
				}
			});


			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new CopyDeathrattleTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}