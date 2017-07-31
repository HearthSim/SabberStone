using SabberStoneCore.Actions;
using SabberStoneCore.Extensions;
using SabberStoneCore.Model;

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