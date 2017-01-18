using System.Reflection;
using log4net;
using SabberStone.Actions;
using SabberStone.Model;

namespace SabberStone.Tasks.SimpleTasks
{
    public class DamageNumberTask : SimpleTask
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public DamageNumberTask(EntityType type, bool spellDmg = false)
        {
            Type = type;
            SpellDmg = spellDmg;
        }

        public EntityType Type { get; set; }

        public bool SpellDmg { get; set; }

        public override TaskState Process()
        {
            if (Number < 1)
            {
                return TaskState.STOP;
            }

            IncludeTask.GetEntites(Type, Controller, Source, Target, Playables)
                .ForEach(p => Generic.DamageCharFunc.Invoke(Source as IPlayable, p as ICharacter, Number,
                    SpellDmg ? Controller.Hero.SpellPower : 0));

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new DamageNumberTask(Type, SpellDmg);
            clone.Copy(this);
            return clone;
        }
    }
}