using SabberStoneCore.Actions;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class RevealTask : SimpleTask
    {
        public RevealTask(ISimpleTask taskToDo)
        {
            TaskToDo = taskToDo;
        }

        public ISimpleTask TaskToDo { get; set; }

        public override TaskState Process()
        {
            if (!Generic.JoustBlock.Invoke(Controller))
            {
                return TaskState.STOP;
            }

            TaskToDo.Game = Game;
            TaskToDo.Controller = Controller;
            TaskToDo.Source = Source;
            TaskToDo.Target = Target;
            TaskToDo.Playables = Playables;
            TaskToDo.CardIds = CardIds;
            TaskToDo.Flag = Flag;
            TaskToDo.Number = Number;
            return TaskToDo.Process();
        }

        public override ISimpleTask Clone()
        {
            var clone = new RevealTask(TaskToDo);
            clone.Copy(this);
            return clone;
        }
    }
}