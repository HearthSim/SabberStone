using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageTask : SimpleTask
	{
		public DamageTask(int amount, int randAmount, EntityType entityType, bool spellDmg = false)
		{
			Amount = amount;
			RandAmount = randAmount;
			Type = entityType;
			SpellDmg = spellDmg;
		}

		public DamageTask(int amount, EntityType entityType, bool spellDmg = false)
		{
			Amount = amount;
			RandAmount = 0;
			Type = entityType;
			SpellDmg = spellDmg;
		}

		public int Amount { get; set; }

		public int RandAmount { get; set; }

		public EntityType Type { get; set; }

		public bool SpellDmg { get; set; }

		public override TaskState Process()
		{
			if (Amount < 1 && RandAmount < 1)
				return TaskState.STOP;

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				int randAmount = 0;
				if (RandAmount > 0)
				{
					randAmount = Random.Next(0, RandAmount + 1);
					Game.OnRandomHappened(true);
				}

				int amount = Amount + randAmount;

				Controller.Game.Log(LogLevel.WARNING, BlockType.ACTION, "DamageTask", !Controller.Game.Logging? "":$"Amount is {amount} damage of {Source}.");

				int damage = Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, amount, SpellDmg);

				if ((Source as IPlayable).HasLifeSteal)
				{
					Controller.Hero.TakeHeal((Source as IPlayable), damage);
				}
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DamageTask(Amount, RandAmount, Type, SpellDmg);
			clone.Copy(this);
			return clone;
		}
	}
}
