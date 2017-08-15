using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MoveToSetaside : SimpleTask
	{
		public EntityType Type { get; set; }

		public MoveToSetaside(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				IPlayable removedEntity = p.Zone.Remove(p);
				Game.Log(LogLevel.INFO, BlockType.PLAY, "MoveToSetaside", $"{p.Controller.Name}'s {p} is moved to the setaside zone.");
				p.Controller.SetasideZone.Add(removedEntity);
			});
			return TaskState.COMPLETE;
		}


		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(MoveToSetaside).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new MoveToSetaside(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}