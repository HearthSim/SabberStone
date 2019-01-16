﻿using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//System.Collections.Generic.List<Model.Entities.IPlayable> entities = IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			//entities.ForEach(p =>
			GameTag t = Tag;
			int a = Amount;
			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
			{
				if (t == GameTag.EXHAUSTED)
				{
					p.IsExhausted = a > 0;
					continue;
				}

				if (p is Character c)
					switch (t)
					{
						case GameTag.ATK:
							ATK.Effect(EffectOperator.SET, a).ApplyTo(c);
							break;
						case GameTag.HEALTH:
							Health.Effect(EffectOperator.SET, a).ApplyTo(c);
							break;
						case GameTag.DAMAGE:
							c.Damage = a;
							break;
						case GameTag.STEALTH:
							c.HasStealth = a > 0;
							break;
						case GameTag.TAUNT:
							c.HasTaunt = a > 0;
							break;
						case GameTag.IMMUNE:
							c.IsImmune = a > 0;
							break;
						default:
							c[t] = a;
							break;
					}
				else
					p[Tag] = Amount;

				if (Tag == GameTag.DIVINE_SHIELD && Amount == 0 && p[GameTag.DIVINE_SHIELD] != 0)
					game.TriggerManager.OnLoseDivineShield(p);
				else if
					(Tag == GameTag.FROZEN && Amount == 1)
					game.TriggerManager.OnFreezeTrigger(p);
			}

			return TaskState.COMPLETE;
		}
	}
}
