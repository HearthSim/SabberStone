using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>  
	///  Reveals the target(s), effectively removing their stealth attribute.  
	/// </summary> 
	public class RevealStealthTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public RevealStealthTask(EntityType type)
		{
			Type = type;
		}
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var minion = p as Minion;
				if (minion == null)
					return;
				minion.HasStealth = false;
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(RevealStealthTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new RevealStealthTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}