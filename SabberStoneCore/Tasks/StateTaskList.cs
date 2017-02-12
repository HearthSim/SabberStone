using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks
{
    public enum TaskState
    {
        READY, RUNNING, COMPLETE, STOP
    }

    public class StateTaskList<T> : List<T>, ISimpleTask where T : ISimpleTask
    {
        public TaskState State { get; set; } = TaskState.READY;

        private int _position = 0;
        //public ISimpleTask CurrentTask => this[_position].CurrentTask;

        public Game Game { get; set; }
        private int _controllerId;
        public Controller Controller
        {
            get { return Game.ControllerById(_controllerId); }
            set { _controllerId = value.Id; }
        }

        private int _sourceId;
        public IEntity Source
        {
            get { return Game.IdEntityDic[_sourceId]; }
            set { _sourceId = value.Id; }
        }

        private int _targetId;
        public IEntity Target
        {
            get { return _targetId > -1 ? Game.IdEntityDic[_targetId] : null; }
            set { _targetId = value?.Id ?? -1; }
        }

        public List<IPlayable> Playables
        {
            get { return Game.TaskStack.Playables; }
            set { Game.TaskStack.Playables = value; }
        }
        public List<string> CardIds
        {
            get { return Game.TaskStack.CardIds; }
            set { Game.TaskStack.CardIds = value; }
        }
        public bool Flag
        {
            get { return Game.TaskStack.Flag; }
            set { Game.TaskStack.Flag = value; }
        }
        public int Number
        {
            get { return Game.TaskStack.Number; }
            set { Game.TaskStack.Number = value; }
        }

        public TaskState Process()
        {
            // at the start move over initial parameters ...
            if (State == TaskState.READY)
            {
                Playables = Playables ?? new List<IPlayable>();
                CardIds = CardIds ?? new List<string>();
            }

            State = TaskState.RUNNING;
            for (_position = 0; _position < Count && State == TaskState.RUNNING; _position++)
            {
                ISimpleTask task = this[_position];
                if (task.State == TaskState.COMPLETE)
                    continue;

                task.Game = Game;
                task.Controller = Controller;
                task.Source = Source;
                task.Target = Target;
                //task.Playables = Playables;
                //task.Flag = Flag;
                //task.Number = Number;

                // execution
                if (task.Process() != TaskState.COMPLETE)
                    break;

                // move over in queue
                Game = task.Game;
                Controller = task.Controller;
                Source = task.Source;
                Target = task.Target;
                //Playables = task.Playables;
                //Flag = task.Flag;
                //Number = task.Number;
            }

            return TaskState.COMPLETE;
        }

        public ISimpleTask Clone()
        {
            var cloneList = new StateTaskList<ISimpleTask>();
            cloneList.Copy(this);
            ForEach(p => cloneList.Add(p.Clone()));
            return cloneList;
        }

        public void ResetState()
        {
            State = TaskState.READY;
        }

        public static StateTaskList<ISimpleTask> Chain(params ISimpleTask[] list)
        {
            var newList = new StateTaskList<ISimpleTask>();
            newList.AddRange(list);
            return newList;
        }

        public void Copy(ISimpleTask task)
        {
            State = task.State;

            if (task.Game == null)
                return;

            Game = task.Game;
            Controller = task.Controller;
            Source = task.Source;
            Target = task.Target;

            Playables = task.Playables;
            CardIds = task.CardIds;
            Flag = task.Flag;
            Number = task.Number;

            //Splits = task.Splits;
            //Sets = task.Sets;
        }

    }
}