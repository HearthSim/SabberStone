using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RandomTask : SimpleTask
    {
        public RandomTask(int amount, EntityType type)
        {
            Amount = amount;
            Type = type;
        }

        public int Amount { get; set; }

        public EntityType Type { get; set; }

        public override TaskState Process()
        {
            var entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

            if (entities.Count == 0)
                return TaskState.STOP;

            if (Game.Splitting)
            {
                //Sets = Util.GetPowerSet(entities).Where(p => p.Count() == Amount);
                //Playables = Util.RandomElement(Sets).ToList();
            }
            else
            {
                Playables = new List<IPlayable>();
                for (var i = 0; i < Amount; i++)
                {
                    var randPlayable = Util<IPlayable>.Choose(entities);
                    entities.Remove(randPlayable);
                    Playables.Add(randPlayable);
                }
                
            }
            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new RandomTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }
    }
}