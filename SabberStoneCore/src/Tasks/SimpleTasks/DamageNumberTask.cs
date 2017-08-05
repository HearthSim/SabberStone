using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageNumberTask : SimpleTask
    {
        public DamageNumberTask(EEntityType type, bool spellDmg = false)
        {
            Type = type;
            SpellDmg = spellDmg;
        }

        public EEntityType Type { get; set; }

        public bool SpellDmg { get; set; }

        public override ETaskState Process()
        {
            if (Number < 1)
            {
                return ETaskState.STOP;
            }

            var spellDmgValue = SpellDmg ? (Source is Spell && ((Spell)Source).ReceveivesDoubleSpellDamage ? Controller.Hero.SpellPowerDamage * 2 : Controller.Hero.SpellPowerDamage) : 0;
            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
                .ForEach(p => Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Number,
                    spellDmgValue));

            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DamageNumberTask(Type, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}