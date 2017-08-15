using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using System;
using System.Collections;
using System.Text;

namespace SabberStoneCore.Model
{
	// Should be IModelCollection<ISimpleTask>
	public class TaskQueue : IModel<TaskQueue>
	{
		public List<ISimpleTask> TaskList = new List<ISimpleTask>();

		public int Count => TaskList.Count;

		public Game Game { get; set; }

		/// <summary>
		/// Get or set the task currently being executed by the queue.
		/// This value can be null!
		/// <value><see cref="ISimpleTask"/></value>
		/// </summary>
		public ISimpleTask CurrentTask { get; set; }

		public TaskQueue(Game game)
		{
			Game = game;
		}

		public void Execute(ISimpleTask task, Controller controller, IPlayable source, IPlayable target)
		{
			var clone = task.Clone(null);
			clone.Game = controller.Game;
			clone.Controller = controller;
			clone.Source = source;
			clone.Target = target;
			Game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", $"PriorityTask[{clone.Source}]: '{clone.GetType().Name}' is processed!" +
					 $"'{clone.Source.Card.Text?.Replace("\n", " ")}'");

			// power block
			if (controller.Game.History)
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

			clone.Process();

			if (controller.Game.History)
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			Game.TaskStack.Reset();
		}

		/// <summary>
		/// Enqueue tasks that will be proccess by the DeathAndAuraProcessing.
		/// IMPORTANT: only enqueue cloned tasks ....
		/// </summary>
		/// <param name="task"></param>
		public void Enqueue(ISimpleTask task)
		{
			// TODO ... check if necessary ... frothing beserker ... check for duplicates, ex. auras
			//if (_lazyTaskQueue.Contains(task))
			//    return;

			// TODO reset task from previous uses .. maybee need to clone it?
			//task.Reset();

			TaskList.Add(task);
		}

		public TaskState Process()
		{
			CurrentTask = TaskList.OrderBy(p => p.Source.OrderOfPlay).First();
			TaskList.Remove(CurrentTask);
			Game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", $"LazyTask[{CurrentTask.Source}]: '{CurrentTask.GetType().Name}' is processed!" +
										$"'{CurrentTask.Source.Card.Text?.Replace("\n", " ")}'");


			// power block
			if (Game.History)
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, CurrentTask.Source.Id, "", -1, CurrentTask.Target?.Id ?? 0));

			var success = CurrentTask.Process();

			if (Game.History)
				Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// reset between task execution
			Game.TaskStack.Reset();

			//if (Game.Splits.Count == 0 && CurrentTask.Splits != null && CurrentTask.Splits.Count > 0)
			//{
			//    Log.Info($"Parallel-threading splits '{CurrentTask.Splits.Count}' starting now! [Info: {Game.Splits.Count}]");
			//    Game.Splits = CurrentTask.Splits;                
			//}
			return success;
		}

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public TaskQueue Clone(Game newGame)
		{
			var clone = new TaskQueue(newGame)
			{
				// CurrentTask can be null!
				CurrentTask = CurrentTask?.Clone(newGame) as ISimpleTask
			};

			// TODO; Change into our own container to smoothen clone behaviour
			clone.TaskList = new List<ISimpleTask>(TaskList.Capacity);
			for (int i = 0; i < TaskList.Count; ++i)
			{
				clone.TaskList.Add(TaskList[i].Clone(newGame) as ISimpleTask);
			}

			return clone;
		}

		public string ToHash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			str.Append("??TQ??");
			str.AppendFormat("[C:{0}]", Count);
			str.Append("[FRONT:");
			str.Append(CurrentTask?.ToHash());
			str.Append("][QUEUE:");
			TaskList?.ForEach(t => str.Append(t.ToHash()));
			str.Append("]!!TQ!!");
			return str.ToString();
		}

		public void Stamp(IModel other)
		{
			TaskQueue taskQueue = other as TaskQueue ?? throw new InvalidOperationException("other's type is invalid");

			TaskList = new List<ISimpleTask>();
			taskQueue.TaskList.ForEach(p => TaskList.Add(p.Clone(taskQueue.Game)));
			if (taskQueue.CurrentTask != null)
			{
				CurrentTask = taskQueue.CurrentTask.Clone(taskQueue.Game);
				CurrentTask.Game = Game;
			}
			TaskList.ForEach(p =>
			{
				p.Game = Game;
				//p.Reset();
			});
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion
	}
}
