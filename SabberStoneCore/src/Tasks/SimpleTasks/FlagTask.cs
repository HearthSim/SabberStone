using System.Diagnostics;

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

			TaskToDo.Game = Game;
			TaskToDo.Controller = Controller;
			TaskToDo.Source = Source;
			TaskToDo.Target = Target;
			TaskToDo.Playables = Playables;
			//TaskToDo.CardIds = CardIds;
			TaskToDo.Flag = Flag;
			TaskToDo.Number = Number;
			TaskToDo.Number1 = Number1;
			TaskToDo.Number2 = Number2;
			TaskToDo.Number3 = Number3;
			TaskToDo.Number4 = Number4;
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
