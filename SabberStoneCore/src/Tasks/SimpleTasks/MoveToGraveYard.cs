using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToGraveYard : SimpleTask
	{
		public EntityType Type { get; set; }

		public MoveToGraveYard(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p => p.Controller.GraveyardZone.Add(p.Zone.Remove(p)));
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MoveToGraveYard).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MoveToGraveYard(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}