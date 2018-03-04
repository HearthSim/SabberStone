namespace SabberStoneCore.Tasks.SimpleTasks
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

			if (TaskToDo is StateTaskList list)
				list.Stack = Game.TaskStack;
			else
			{
				TaskToDo.Game = Game;
				TaskToDo.Controller = Controller;
				TaskToDo.Source = Source;
				TaskToDo.Target = Target;
				TaskToDo.Flag = Flag;
			}

			return TaskToDo.Process();
		}

		public override ISimpleTask Clone()
		{
			var clone = new FlagTask(CheckFlag, TaskToDo.Clone());
			clone.Copy(this);
			return clone;
		}

		public override string ToString()
		{
			return $"[FlagTask][{CheckFlag}:{TaskToDo.GetType().Name}]";
		}
	}
}
