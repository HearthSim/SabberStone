using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class BuffStealthTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public BuffStealthTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				var minion = p as Minion;
				if (minion == null)
					return;

				var buff = new BuffTask(Buffs.StealthTurn(minion.NumAttacksThisTurn), Type);
				buff.Stamp(this);
				buff.Process();
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new BuffStealthTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}