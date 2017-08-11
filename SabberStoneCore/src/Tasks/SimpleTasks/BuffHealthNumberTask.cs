using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class BuffHealthNumberTask : SimpleTask
	{
		public BuffHealthNumberTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Number == 0)
			{
				return TaskState.STOP;
			}

			var buff = new BuffTask(Buffs.Health(Number), Type, null);
			buff.Copy(this);

			return buff.Process();
		}

		public override ISimpleTask Clone()
		{
			var clone = new BuffHealthNumberTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}