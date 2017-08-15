using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetAttackTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public int Amount { get; set; }

		/// <summary>
		///  Changes the attack attribute of the given entity.
		/// </summary>
		public SetAttackTask(int amount, EntityType entityType)
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

				// work around attack buffs
				p.Enchants.ForEach(t =>
				{
					if (t.Effects.ContainsKey(GameTag.ATK))
					{
						t.Effects.Remove(GameTag.ATK);
					}
				});

				target.AttackDamage = Amount;
				return true;
			});

			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(SetAttackTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new SetAttackTask(Amount, Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}