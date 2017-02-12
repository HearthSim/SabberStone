using System;
using System.Collections.Generic;
using SabberStoneCore.Model;

namespace SabberStoneCore.Tasks
{
    public interface ISimpleTask
    {
        TaskState State { get; set; }
        //ISimpleTask CurrentTask { get; }

        Game Game { get; set; }
        Controller Controller { get; set; }
        IEntity Source { get; set; }
        IEntity Target { get; set; }

        List<IPlayable> Playables { get; set; }
        List<string> CardIds { get; set; }
        bool Flag { get; set; }
        int Number { get; set; }
       
        //List<Game> Splits { get; set; }
        //IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

        ISimpleTask Clone();

        TaskState Process();

        void Reset();
    }

    public abstract class SimpleTask : ISimpleTask
    {
        internal static Random Random = new Random();

        public TaskState State { get; set; } = TaskState.READY;

        //public ISimpleTask CurrentTask => this;

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
            get { return Game.TaskStack.Number; }
            set { Game.TaskStack.Number = value; }
        }

        public abstract TaskState Process();
        //{
        //    return TaskState.COMPLETE;
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

            //Splits = task.Splits;
            //Sets = task.Sets;
        }

        public void Reset()
        {
            State = TaskState.READY;

            Playables = new List<IPlayable>();
            CardIds = new List<string>();
            Flag = false;
            Number = 0;

            //Splits = new List<Game>();
            //Sets = null;
        }
    }

    public enum PlayerTaskType
    {
        CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
    }

    public class PlayerTask : ISimpleTask
    {
        public TaskState State { get; set; } = TaskState.READY;
        //public ISimpleTask CurrentTask => this;

        public PlayerTaskType PlayerTaskType { get; set; }
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
        public List<IPlayable> Playables { get; set; }
        public List<string> CardIds { get; set; }
        public bool Flag { get; set; } = false;
        public int Number { get; set; } = 0;

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

        public virtual TaskState Process()
        {
            return TaskState.COMPLETE;
        }

        public ISimpleTask Clone()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            Playables = new List<IPlayable>();
            CardIds = new List<string>();
            Flag = false;
            Number = 0;

            Splits = new List<Game>();
            Sets = null;
        }

        public virtual string FullPrint()
        {
            return "PlayerTask";
        }

    }

}