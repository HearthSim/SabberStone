using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetAttackNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		/// <summary>
		///  Changes the attack attribute of the given entity.
		/// </summary>
		public SetAttackNumberTask(EntityType entityType)
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

				// work around attack buffs
				p.Enchants.ForEach(t =>
				{
					if (t.Effects.ContainsKey(GameTag.ATK))
					{
						t.Effects.Remove(GameTag.ATK);
					}
				});

				target.AttackDamage = Number;
				return true;
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new SetAttackNumberTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}