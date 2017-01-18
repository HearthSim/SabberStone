namespace SabberStone.Tasks.SimpleTasks
{
    public class FlagTask : SimpleTask
    {
        public FlagTask(bool checkFlag, ISimpleTask taskToDo)
        {
            CheckFlag = checkFlag;
            TaskToDo = taskToDo;
        }

        public bool CheckFlag { get; set; }
        public ISimpleTask TaskToDo { get; set; }

        public override TaskState Process()
        {
            if (Flag != CheckFlag)
            {
                return TaskState.COMPLETE;
            }
            TaskToDo.Game = Game;
            TaskToDo.Controller = Controller;
            TaskToDo.Source = Source;
            TaskToDo.Target = Target;
            TaskToDo.Playables = Playables;
            TaskToDo.Flag = Flag;
            TaskToDo.Number = Number;
            return TaskToDo.Process();
        }

        public override ISimpleTask Clone()
        {
            var clone = new FlagTask(CheckFlag, TaskToDo);
            clone.Copy(this);
            return clone;
        }
    }
}