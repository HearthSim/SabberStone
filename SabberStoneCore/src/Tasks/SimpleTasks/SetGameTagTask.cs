using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetGameTagTask : SimpleTask
	{
		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public bool IgnoreDamage { get; set; }

		public SetGameTagTask(GameTag tag, int amount, EntityType entityType, bool ignoreDamage = false)
		{
			Tag = tag;
			Amount = amount;
			Type = entityType;
			IgnoreDamage = ignoreDamage;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				if (IgnoreDamage)
				{
					p.IsIgnoreDamage = true;
					p[Tag] = Amount;
					p.IsIgnoreDamage = false;
				}
				else
				{
					p[Tag] = Amount;
				}
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetGameTagTask(Tag, Amount, Type, IgnoreDamage);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}