using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class BuffAttackNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public BuffAttackNumberTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Number == 0)
			{
				return TaskState.STOP;
			}

			var buff = new BuffTask(Buffs.Attack(Number), Type, null);
			buff.Stamp(this);

			return buff.Process();
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new BuffAttackNumberTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}