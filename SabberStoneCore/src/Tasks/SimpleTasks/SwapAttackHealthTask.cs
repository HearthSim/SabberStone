using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SwapAttackHealthTask : SimpleTask
	{
		private readonly Card _enchantmentCard;

		/// <summary>
		///     Changes the attack attribute of the given entity.
		/// </summary>
		public SwapAttackHealthTask(EntityType entityType, string enchantmentId)
		{
			Type = entityType;
			_enchantmentCard = Cards.FromId(enchantmentId);
		}

		private SwapAttackHealthTask(EntityType entityType, Card card)
		{
			Type = entityType;
			_enchantmentCard = card;
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			IEnumerable<IPlayable> entities =
				IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			foreach (IPlayable p in entities)
			{
				var m = p as Minion;

				int atk = m.AttackDamage;
				int health = m.Health;

				if (game.History)
				{
					Enchantment instance =
						Enchantment.GetInstance(controller, (IPlayable) source, p, in _enchantmentCard);
					instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = atk;
					instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = health;
				}

				//new Effect(GameTag.ATK, EffectOperator.SET, health).ApplyTo(p);
				//new Effect(GameTag.HEALTH, EffectOperator.SET, atk).ApplyTo(p);
				//new AttackEffect(EffectOperator.SET, health).ApplyTo(p);
				//new HealthEffect(EffectOperator.SET, atk).ApplyTo(p);
				Effects.SetAttack(health).ApplyTo(p);
				Effects.SetMaxHealth(atk).ApplyTo(p);
			}

			return TaskState.COMPLETE;
		}
	}
}
