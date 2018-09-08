using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SetGameTagTask : SimpleTask
	{
		public SetGameTagTask(GameTag tag, int amount, EntityType entityType)
		{
			Tag = tag;
			Amount = amount;
			Type = entityType;
		}

		public GameTag Tag { get; set; }

		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public override TaskState Process()
		{
			//System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			var t = Tag;
			var a = Amount;
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (p is Character c)
				{
					switch (t)
					{
						case GameTag.ATK:
							new AttackEffect(EffectOperator.SET, a).ApplyTo(c);
							break;
						case GameTag.HEALTH:
							new HealthEffect(EffectOperator.SET, a).ApplyTo(c);
							break;
						case GameTag.DAMAGE:
							c.Damage = a;
							break;
						default:
							c[t] = a;
							break;
					}
				}
				else
					p[Tag] = Amount;

				if (Tag == GameTag.DIVINE_SHIELD && Amount == 0 && p[GameTag.DIVINE_SHIELD] != 0)
					Game.TriggerManager.OnLoseDivineShield(p);
				else if
					(Tag == GameTag.FROZEN && Amount == 1)
					Game.TriggerManager.OnFreezeTrigger(p);
				
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SetGameTagTask(Tag, Amount, Type);
			clone.Copy(this);
			return clone;
		}
	}
}
