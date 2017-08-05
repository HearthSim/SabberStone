using SabberStoneCore.Actions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageTask : SimpleTask
    {
        public DamageTask(int amount, int randAmount, EEntityType entityType, bool spellDmg = false)
        {
            Amount = amount;
            RandAmount = randAmount;
            Type = entityType;
            SpellDmg = spellDmg;
        }

        public DamageTask(int amount, EEntityType entityType, bool spellDmg = false)
        {
            Amount = amount;
            RandAmount = 0;
            Type = entityType;
            SpellDmg = spellDmg;
        }

        public int Amount { get; set; }

        public int RandAmount { get; set; }

        public EEntityType Type { get; set; }

        public bool SpellDmg { get; set; }

        public override ETaskState Process()
        {
            if (Amount < 1 && RandAmount < 1)
                return ETaskState.STOP;

            var spellDmgValue = 0;
            if (Source is HeroPower)
            {
                spellDmgValue = Controller.Hero.HeroPowerDamage;
            }
            else if (SpellDmg)
            {
                spellDmgValue = Source is Spell && ((Spell) Source).ReceveivesDoubleSpellDamage
                    ? Controller.Hero.SpellPowerDamage * 2
                    : Controller.Hero.SpellPowerDamage;
            }

            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p => Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, 
                        Amount + (RandAmount > 0 ? Random.Next(0, RandAmount + 1) : 0),
                        spellDmgValue));
            return ETaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DamageTask(Amount, RandAmount, Type, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}