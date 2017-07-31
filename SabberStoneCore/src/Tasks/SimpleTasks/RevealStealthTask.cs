using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    /// <summary>  
    ///  Reveals the target(s), effectively removing their stealth attribute.  
    /// </summary> 
    public class RevealStealthTask : SimpleTask
    {
        public EntityType Type { get; set; }

        public RevealStealthTask(EntityType type)
        {
            Type = type;
        }
        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
            entities.ForEach(p =>
            {
                var minion = p as Minion;
                if (minion == null)
                    return;
                minion.HasStealth = false;
            });

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RevealStealthTask(Type);
            clone.Copy(this);
            return clone;
        }
    }
}