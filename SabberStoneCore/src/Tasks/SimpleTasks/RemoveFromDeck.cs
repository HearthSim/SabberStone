using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RemoveFromDeck : SimpleTask
	{
		public EntityType Type { get; set; }

		public RemoveFromDeck(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			var list = new List<IPlayable>();
			entities.ForEach(p =>
			{
				if (p.Zone.Type == Zone.DECK && Generic.RemoveFromZone.Invoke(p.Controller, p))
					list.Add(p);
			});
			Playables = list;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(RemoveFromDeck).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RemoveFromDeck(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}