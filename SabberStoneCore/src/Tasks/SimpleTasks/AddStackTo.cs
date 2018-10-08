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
			foreach (IPlayable p in stack?.Playables)
				p[GameTag.DISPLAYED_CREATOR] = source.Id;

			switch (Type)
			{
				case EntityType.DECK:
					stack?.Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.HAND:
					stack?.Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_HAND:
					stack?.Playables.ForEach(p => Generic.AddHandPhase.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				case EntityType.OP_DECK:
					stack?.Playables.ForEach(p => Generic.ShuffleIntoDeck.Invoke(p.Controller, p));
					return TaskState.COMPLETE;

				default:
					throw new NotImplementedException();
			}
		}
	}
}
