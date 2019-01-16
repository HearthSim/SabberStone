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
using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public enum PlayerTaskType
	{
		CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
	}

	//[DebuggerTypeProxy(typeof(PlayerTaskDebuggerProxy))]
	public abstract class PlayerTask
	{
		//public TaskState State { get; set; } = TaskState.READY;
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

		public abstract bool Process();

		public abstract string FullPrint();

		//public void ResetState()
		//{
		//	State = TaskState.READY;
		//}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			switch (this)
			{
				case ChooseTask choose:
					sb.Append("[CHOOSE]");
					foreach (int choice in choose.Choices)
						sb.Append($" {Game.IdEntityDic[choice].Card.Name}");
					break;
				case ConcedeTask _:
					sb.Append("[CONCEDE]");
					break;
				case EndTurnTask _:
					sb.Append("[END_TURN]");
					break;
				case HeroAttackTask _:
					sb.Append($"[ATTACK] {Controller.Hero} => {Target}");
					break;
				case HeroPowerTask _:
					sb.Append($"[HEROPOWER]{Controller.Hero.HeroPower}");
					if (Target != null)
						sb.Append($" => {Target}");
					break;
				case MinionAttackTask minionAttack:
					sb.Append($"[ATTACK] {minionAttack.Source} => {minionAttack.Target}");
					break;
				case PlayCardTask playCard:
					sb.Append($"[PLAY_CARD] {playCard.Source}");
					if (playCard.Target != null)
						sb.Append($" => {playCard.Target}");
					if (playCard.Source.Card.Type == Enums.CardType.MINION)
						sb.Append($"(Pos {playCard.ZonePosition})");
					if (playCard.ChooseOne > 0)
						sb.Append($"(Opt {playCard.ChooseOne}");
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			sb.Append($"[P{Controller.PlayerId}]");

			return sb.ToString();
		}
	}
}
