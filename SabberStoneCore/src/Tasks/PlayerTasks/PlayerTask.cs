using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public enum PlayerTaskType
	{
		CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
	}

	public class PlayerTask
	{
		public TaskState State { get; set; } = TaskState.READY;
		public PlayerTaskType PlayerTaskType { get; set; }
		public Game Game { get; set; }

		public Controller Controller { get; set; }
		public IPlayable Source { get; set; }
		public ICharacter Target { get; set; }
		public int ChooseOne { get; set; }
		public bool SkipPrePhase { get; set; }

		//public List<Game> Splits { get; set; } = new List<Game>();
		//public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

		public bool HasSource => Source != null;
		public bool HasTarget => Target != null;

		public virtual List<PlayerTask> Build(in Game game, in Controller controller, in IPlayable source, in ICharacter target)
		{
			Game = game;
			Controller = controller;
			Source = source;
			Target = target;
			return new List<PlayerTask> { this };
		}

		public virtual TaskState Process()
		{
			return TaskState.COMPLETE;
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
			State = TaskState.READY;
		}
	}
}
