using System.Collections.Generic;
using System.Linq;
using log4net;
using SabberStone.Tasks;

namespace SabberStone.Model
{
    public class TaskQueue
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ISimpleTask> TaskList = new List<ISimpleTask>();

        public int Count => TaskList.Count;

        public Game Game { get; set; }

        public ISimpleTask CurrentTask { get; set; }

        public TaskQueue(Game game)
        {
            Game = game;
        }

        public void Stamp(TaskQueue taskQueue)
        {
            TaskList = new List<ISimpleTask>();
            taskQueue.TaskList.ForEach(p => TaskList.Add(p.Clone()));
            CurrentTask = taskQueue.CurrentTask?.Clone();
            TaskList.ForEach(p =>
            {
                p.Reset();
                p.Game = Game;
            });
        }

        public void Execute(ISimpleTask task, Controller controller, IPlayable source, IPlayable target)
        {
            var clone = task.Clone();
            clone.Game = controller.Game;
            clone.Controller = controller;
            clone.Source = source;
            clone.Target = target;
            Log.Info($"PriorityTask[{clone.Source}]: '{clone.GetType().Name}' is processed!" +
                     $"'{clone.Source.Card.Text?.Replace("\n", " ")}'");
            clone.Process();
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
            Log.Info($"LazyTask[{CurrentTask.Source}]: '{CurrentTask}' is processed!");
            Log.Info($"'{CurrentTask.Source.Card.Text?.Replace("\n", " ")}'");
            Game.PlayTaskLog.AppendLine($"LazyTask[{CurrentTask.Source}]: '{CurrentTask.GetType().Name}' is processed!" +
                                        $"'{CurrentTask.Source.Card.Text?.Replace("\n", " ")}'");

            var success = CurrentTask.Process();

            //if (Game.Splits.Count == 0 && CurrentTask.Splits != null && CurrentTask.Splits.Count > 0)
            //{
            //    Log.Info($"Parallel-threading splits '{CurrentTask.Splits.Count}' starting now! [Info: {Game.Splits.Count}]");
            //    Game.Splits = CurrentTask.Splits;                
            //}
            return success;
        }
    }
}
