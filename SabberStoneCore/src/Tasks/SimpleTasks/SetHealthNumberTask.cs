using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetHealthNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public SetHealthNumberTask(EntityType entityType)
		{
			Type = entityType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.TrueForAll(p =>
			{
				var target = p as Minion;
				if (target == null)
				{
					return false;
				}

				// work around health buffs
				p.Enchants.ForEach(t =>
				{
					if (t.Effects.ContainsKey(GameTag.HEALTH))
					{
						t.Effects.Remove(GameTag.HEALTH);
					}
				});

				target.Health = Number;
				return true;
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(SetHealthNumberTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetHealthNumberTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}