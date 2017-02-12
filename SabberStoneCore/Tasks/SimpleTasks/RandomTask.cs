using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class SplitTask : SimpleTask
    {
        public SplitTask(int amount, EntityType type)
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

            if (Game.Splitting != SplitType.NONE && Game.Splits.Count == 0)
            {
                var sets = Util.GetPowerSet(entities).Where(p => p.Count() == Amount).ToList();
                sets.ForEach(p =>
                {
                    Playables = p.ToList();
                    State = TaskState.COMPLETE;
                    //Game.Log(LogLevel.ERROR, BlockType.SCRIPT, "", "got " + Game.TaskQueue.Count + " in orginal game");
                    var clone = Game.Clone();
                    Game.Splits.Add(clone);
                });
                //Playables = Util.RandomElement(Sets).ToList();
            }

            Playables = entities;

            return TaskState.COMPLETE;
        }

        public override ISimpleTask Clone()
        {
            var clone = new SplitTask(Amount, Type);
            clone.Copy(this);
            return clone;
        }

    }

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

            Playables = new List<IPlayable>();
            for (var i = 0; i < Amount && entities.Count > 0; i++)
            {
                var randPlayable = Util<IPlayable>.Choose(entities);
                entities.Remove(randPlayable);
                Playables.Add(randPlayable);
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