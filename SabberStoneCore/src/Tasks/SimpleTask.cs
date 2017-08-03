using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks
{
    public interface ISimpleTask
    {
        ETaskState State { get; set; }
        //ISimpleTask CurrentTask { get; }

        Game Game { get; set; }
        Controller Controller { get; set; }
        IEntity Source { get; set; }
        IEntity Target { get; set; }

        List<IPlayable> Playables { get; set; }
        List<string> CardIds { get; set; }
        bool Flag { get; set; }
        int Number { get; set; }
        int Number1 { get; set; }
        int Number2 { get; set; }
        int Number3 { get; set; }
        int Number4 { get; set; }

        //List<Game> Splits { get; set; }
        //IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

        ISimpleTask Clone();

        ETaskState Process();

        void ResetState();
    }

    public abstract class SimpleTask : ISimpleTask
    {
        internal static Random Random = new Random();

        public ETaskState State { get; set; } = ETaskState.READY;

        //public ISimpleTask CurrentTask => this;

        public Game Game { get; set; }
        private int _controllerId;
        public Controller Controller
        {
            get { return Game.ControllerByEntityID(_controllerId); }
            set { _controllerId = value.Id; }
        }

        private int _sourceId;
        public IEntity Source
        {
            get { return Game.Entities[_sourceId]; }
            set { _sourceId = value.Id; }
        }

        private int _targetId;
        public IEntity Target
        {
            get { return _targetId > -1 ? Game.Entities[_targetId] : null; }
            set { _targetId = value?.Id ?? -1; }
        }
        
        //public List<IPlayable> Playables { get; set; }
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
        //public bool Flag { get; set; }
        public bool Flag
        {
            get { return Game.TaskStack.Flag; }
            set { Game.TaskStack.Flag = value; }
        }
        //public int Number { get; set; }
        public int Number
        {
            get { return Game.TaskStack.Numbers[0]; }
            set { Game.TaskStack.Numbers[0] = value; }
        }
        public int Number1
        {
            get { return Game.TaskStack.Numbers[1]; }
            set { Game.TaskStack.Numbers[1] = value; }
        }
        public int Number2
        {
            get { return Game.TaskStack.Numbers[2]; }
            set { Game.TaskStack.Numbers[2] = value; }
        }
        public int Number3
        {
            get { return Game.TaskStack.Numbers[3]; }
            set { Game.TaskStack.Numbers[3] = value; }
        }
        public int Number4
        {
            get { return Game.TaskStack.Numbers[4]; }
            set { Game.TaskStack.Numbers[4] = value; }
        }
        public abstract ETaskState Process();
        //{
        //    return ETaskState.COMPLETE;
        //}

        public abstract ISimpleTask Clone();

        public void Copy(SimpleTask task)
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
            Number1 = task.Number1;
            Number2 = task.Number2;
            Number3 = task.Number3;
            Number4 = task.Number4;

            //Splits = task.Splits;
            //Sets = task.Sets;
        }

        public void ResetState()
        {
            State = ETaskState.READY;
        }
    }


    public class PlayerTask : ISimpleTask
    {
        public ETaskState State { get; set; } = ETaskState.READY;
        //public ISimpleTask CurrentTask => this;

        public EPlayerTaskType PlayerTaskType { get; set; }
        public Game Game { get; set; }
        private int _controllerId;
        public Controller Controller
        {
            get { return Game.ControllerByEntityID(_controllerId); }
            set { _controllerId = value.Id; }
        }
        private int _sourceId;
        public IEntity Source
        {
            get { return Game.Entities[_sourceId]; }
            set { _sourceId = value.Id; }
        }
        private int _targetId;
        public IEntity Target
        {
            get { return _targetId > -1 ? Game.Entities[_targetId] : null; }
            set { _targetId = value?.Id ?? -1; }
        }
        public List<IPlayable> Playables { get; set; }
        public List<string> CardIds { get; set; }
        public bool Flag { get; set; } = false;
        public int Number { get; set; } = 0;
        public int Number1 { get; set; } = 0;
        public int Number2 { get; set; } = 0;
        public int Number3 { get; set; } = 0;
        public int Number4 { get; set; } = 0;

        public int ZonePosition { get; set; } = -1;
        public int ChooseOne { get; set; }

        public List<Game> Splits { get; set; } = new List<Game>();
        public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

        public virtual List<ISimpleTask> Build(Game game, Controller controller, IPlayable source, IPlayable target)
        {
            Game = game;
            Controller = controller;
            Source = source;
            Target = target;
            return new List<ISimpleTask> { this };
        }

        public virtual ETaskState Process()
        {
            return ETaskState.COMPLETE;
        }

        public ISimpleTask Clone()
        {
            throw new NotImplementedException();
        }

        public virtual string FullPrint()
        {
            return "PlayerTask";
        }

        public void ResetState()
        {
            State = ETaskState.READY;
        }
    }

}