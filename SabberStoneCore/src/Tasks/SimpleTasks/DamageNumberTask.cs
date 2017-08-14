using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public bool SpellDmg { get; set; }

		public DamageNumberTask(EntityType type, bool spellDmg = false)
		{
			Type = type;
			SpellDmg = spellDmg;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Number < 1)
			{
				return TaskState.STOP;
			}

			int spellDmgValue = SpellDmg ? (Source is Spell && ((Spell)Source).ReceveivesDoubleSpellDamage ? Controller.Hero.SpellPowerDamage * 2 : Controller.Hero.SpellPowerDamage) : 0;
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
				.ForEach(p => Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Number,
					spellDmgValue));

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new DamageNumberTask(Type, SpellDmg);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}