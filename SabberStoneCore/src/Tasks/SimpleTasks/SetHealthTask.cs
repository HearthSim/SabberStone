using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetHealthTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public SetHealthTask(int amount, EntityType entityType)
		{
			Amount = amount;
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

				target.Health = Amount;
				return true;
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(SetHealthTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetHealthTask(Amount, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}