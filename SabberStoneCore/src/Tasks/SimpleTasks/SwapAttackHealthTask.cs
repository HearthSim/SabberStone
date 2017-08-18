using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SwapAttackHealthTask : SimpleTask
	{
		/// <summary>
		///  Changes the attack attribute of the given entity.
		/// </summary>
		public SwapAttackHealthTask(EntityType entityType)
		{
			Type = entityType;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.TrueForAll(p =>
			{
				var target = p as Minion;
				if (target == null)
				{
					return false;
				}

				int atk = p[GameTag.ATK];
				int health = p[GameTag.HEALTH];

				// work around attack buffs
				p.Enchants.ForEach(t =>
				{
					if (t.Effects.ContainsKey(GameTag.ATK))
					{
						t.Effects.Remove(GameTag.ATK);
					}

					if (t.Effects.ContainsKey(GameTag.HEALTH))
					{
						t.Effects.Remove(GameTag.HEALTH);
					}
				});

				target.Health = atk;
				target.AttackDamage = health;
				return true;
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SwapAttackHealthTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}