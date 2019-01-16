#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion

//using System.Collections.Generic;
//using System.Linq;
//using SabberStoneCore.Tasks;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Kettle;
//using SabberStoneCore.Model.Entities;
//using System;

//namespace SabberStoneCore.Model
//{
//	public class TaskQueue
//	{
//		//public List<ISimpleTask> TaskList = new List<ISimpleTask>();
//		public Queue<ISimpleTask> TaskList = new Queue<ISimpleTask>();

//		public readonly Queue<ISimpleTask> CurrentEventTasks = new Queue<ISimpleTask>();

//		public int Count => (CurrentTask != null || CurrentEventTasks.Count > 0) ? CurrentEventTasks.Count : TaskList.Count;

//		public Game Game { get; set; }

//		public ISimpleTask CurrentTask { get; set; }

//		public TaskQueue(Game game)
//		{
//			Game = game;
//		}

//		public void Stamp(TaskQueue taskQueue)
//		{
//			//TaskList = new List<ISimpleTask>();
//			//taskQueue.TaskList.ForEach(p => TaskList.Add(p.Clone()));
//			TaskList = new Queue<ISimpleTask>(taskQueue.TaskList.Count);
//			foreach (ISimpleTask task in taskQueue.TaskList)
//				TaskList.Enqueue(task.Clone());
//			foreach (ISimpleTask task in TaskList)
//				task.Game = Game;
//			if (taskQueue.CurrentTask != null)
//			{
//				CurrentTask = taskQueue.CurrentTask.Clone();
//				CurrentTask.Game = Game;
//			}
//			//TaskList.ForEach(p =>
//			//{
//			//	p.Game = Game;
//			//	//p.Reset();
//			//});
//		}

//		public void Execute(ISimpleTask task, Controller controller, IPlayable source, IPlayable target, int number = 0)
//		{
//			ISimpleTask clone = task.Clone();
//			clone.Game = controller.Game;
//			clone.Controller = controller;
//			clone.Source = source;
//			clone.Target = target;
//			clone.Number = number;
//			Game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !Game.Logging ? "" : $"PriorityTask[{clone.Source}]: '{clone.GetType().Name}' is processed!" +
//					 $"'{clone.Source.Card.Text?.Replace("\n", " ")}'");

//			// power block
//			if (controller.Game.History)
//				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

//			CurrentTask = clone;
//			clone.Process();

//			if (controller.Game.History)
//				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

//			Game.TaskStack.Reset();
//		}

//		/// <summary>
//		/// Enqueue tasks that will be proccess by the DeathAndAuraProcessing.
//		/// IMPORTANT: only enqueue cloned tasks ....
//		/// </summary>
//		/// <param name="task"></param>
//		public void Enqueue(ISimpleTask task)
//		{
//			// TODO ... check if necessary ... frothing beserker ... check for duplicates, ex. auras
//			//if (_lazyTaskQueue.Contains(task))
//			//    return;

//			// TODO reset task from previous uses .. maybee need to clone it?
//			//task.Reset();

//			//TaskList.Add(task);
//			if (CurrentTask != null)
//				CurrentEventTasks.Enqueue(task);
//			else
//				TaskList.Enqueue(task);
//		}

//		public TaskState Process()
//		{
//			//CurrentTask = FirstByOrderOfPlay(TaskList);

//			//TaskList.Remove(CurrentTask);

//			CurrentTask = CurrentEventTasks.Count > 0 ? CurrentEventTasks.Dequeue() : TaskList.Dequeue();

//			Game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !Game.Logging ? "" : $"LazyTask[{CurrentTask.Source}]: '{CurrentTask.GetType().Name}' is processed!" +
//										$"'{CurrentTask.Source.Card.Text?.Replace("\n", " ")}'");

//			// power block
//			if (Game.History)
//			{
//				Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(CurrentTask.IsTrigger ? BlockType.TRIGGER : BlockType.POWER, CurrentTask.Source.Id, "", -1, CurrentTask.Target?.Id ?? 0));
//			}

//			TaskState success = CurrentTask.Process();

//			if (Game.History)
//				Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

//			// reset between task execution
//			Game.TaskStack.Reset();

//			//if (Game.Splits.Count == 0 && CurrentTask.Splits != null && CurrentTask.Splits.Count > 0)
//			//{
//			//    Log.Info($"Parallel-threading splits '{CurrentTask.Splits.Count}' starting now! [Info: {Game.Splits.Count}]");
//			//    Game.Splits = CurrentTask.Splits;                
//			//}

//			CurrentTask = null;

//			return success;
//		}

//		private ISimpleTask FirstByOrderOfPlay(List<ISimpleTask> list)
//		{
//			ISimpleTask result = null;
//			int oop = Int32.MaxValue;
//			foreach (ISimpleTask task in list)
//			{
//				int temp = task.Source.OrderOfPlay;
//				if (oop > temp)
//				{
//					oop = temp;
//					result = task;
//				}
//			}
//			return result;
//		}

//	}
//}
