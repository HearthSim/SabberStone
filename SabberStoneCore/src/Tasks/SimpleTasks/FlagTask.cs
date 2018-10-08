using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FlagTask : SimpleTask
	{
		private readonly bool _checkFlag;
		private readonly ISimpleTask _taskToDo;

		public FlagTask(bool checkFlag, ISimpleTask taskToDo)
		{
			_checkFlag = checkFlag;
			_taskToDo = taskToDo;
		}


		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack.Flag != _checkFlag) return TaskState.COMPLETE;

			//if (_taskToDo is StateTaskList list)
			//	list.Stack = game.TaskStack;
			//else
			//{
			//	_taskToDo.Game = Game;
			//	_taskToDo.Controller = Controller;
			//	_taskToDo.source = source;
			//	_taskToDo.Target = target;
			//	_taskToDo.Flag = Flag;
			//}

			return _taskToDo.Process(in game, in controller, in source, in target, in stack);
		}

		public override string ToString()
		{
			return $"[FlagTask][{_checkFlag}:{_taskToDo.GetType().Name}]";
		}
	}
}
