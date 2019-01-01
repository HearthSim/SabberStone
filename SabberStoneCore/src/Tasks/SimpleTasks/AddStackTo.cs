using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddStackTo : SimpleTask
	{
		public AddStackTo(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in stack.Playables)
				p[GameTag.DISPLAYED_CREATOR] = source.Id;

			switch (Type)
			{
				case EntityType.DECK:
					foreach (IPlayable p in stack.Playables) Generic.ShuffleIntoDeck.Invoke(p.Controller, source, p);
					return TaskState.COMPLETE;

				case EntityType.HAND:
					foreach (IPlayable p in stack.Playables) Generic.AddHandPhase.Invoke(p.Controller, p);
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					foreach (IPlayable p in stack.Playables) Generic.AddHandPhase.Invoke(p.Controller, p);
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					foreach (IPlayable p in stack.Playables) Generic.ShuffleIntoDeck.Invoke(p.Controller, source, p);
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}
	}
}
