using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FlagTask : SimpleTask
	{
		public bool CheckFlag { get; set; }
		public ISimpleTask TaskToDo { get; set; }

		public FlagTask(bool checkFlag, ISimpleTask taskToDo)
		{
			CheckFlag = checkFlag;
			TaskToDo = taskToDo;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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

			// ISimpleTask is an interface for SimpleTask and PlayerTask.
			// The first delegates it's game arguments into TaskStack, owned by Game.
			// The second stores it's params inside the task itself, that's why we MUST
			// keep these assignments setup.
			TaskToDo.Playables = Playables;
			TaskToDo.CardIds = CardIds;
			TaskToDo.Flag = Flag;
			TaskToDo.Number = Number;
			TaskToDo.Number1 = Number1;
			TaskToDo.Number2 = Number2;
			TaskToDo.Number3 = Number3;
			TaskToDo.Number4 = Number4;

			return TaskToDo.Process();
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(FlagTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new FlagTask(CheckFlag, TaskToDo.Clone(newGame));
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}