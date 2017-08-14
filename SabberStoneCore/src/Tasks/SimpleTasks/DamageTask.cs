using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageTask : SimpleTask
	{
		public int Amount { get; set; }

		public int RandAmount { get; set; }

		public EntityType Type { get; set; }

		public bool SpellDmg { get; set; }

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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Amount < 1 && RandAmount < 1)
				return TaskState.STOP;

			int spellDmgValue = 0;
			if (Source is HeroPower)
			{
				spellDmgValue = Controller.Hero.HeroPowerDamage;
			}
			else if (SpellDmg)
			{
				spellDmgValue = Source is Spell && ((Spell)Source).ReceveivesDoubleSpellDamage
					? Controller.Hero.SpellPowerDamage * 2
					: Controller.Hero.SpellPowerDamage;
			}

			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p => Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter,
						Amount + (RandAmount > 0 ? Random.Next(0, RandAmount + 1) : 0),
						spellDmgValue));
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DamageTask(Amount, RandAmount, Type, SpellDmg);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}