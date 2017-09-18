using System;
using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddStackTo : SimpleTask
	{
		public AddStackTo(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			Playables.ForEach(p => p[Enums.GameTag.DISPLAYED_CREATOR] = Source.Id);
			switch (Type)
			{
				case EntityType.DECK:
					Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.HAND:
					Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}

		public override ISimpleTask Clone()
		{
			var clone = new AddStackTo(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
