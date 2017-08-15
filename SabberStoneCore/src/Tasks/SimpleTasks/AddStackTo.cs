using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddStackTo : SimpleTask
	{
		public EntityType Type { get; set; }

		public AddStackTo(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
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

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(AddStackTo).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new AddStackTo(Type);
		}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

	}
}