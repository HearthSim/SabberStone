﻿using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using System.Linq;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class PlayCardTask : PlayerTask
	{
		public static PlayCardTask Any(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, source, target, zonePosition, chooseOne, skipPrePhase);
		}
		public static PlayCardTask Any(Controller controller, string cardName, IEntity target = null, int zonePosition = -1, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), target, zonePosition, chooseOne, skipPrePhase);
		}
		public static PlayCardTask Minion(Controller controller, IEntity source, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, source, null, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask Minion(Controller controller, string cardName, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), null, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask MinionTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, source, target, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask MinionTarget(Controller controller, string cardName, IEntity target, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), target, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask Spell(Controller controller, IEntity source, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, source, null, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask Spell(Controller controller, string cardName, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), null, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask SpellTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, source, target, -1, chooseOne, skipPrePhase);
		}
		public static PlayCardTask SpellTarget(Controller controller, string cardName, IEntity target, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new PlayCardTask(controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), target, -1, chooseOne, skipPrePhase);
		}
		private PlayCardTask(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0, bool skipPrePhase = false)
		{
			PlayerTaskType = PlayerTaskType.PLAY_CARD;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
			ZonePosition = zonePosition;
			ChooseOne = chooseOne;
			SkipPrePhase = skipPrePhase;
		}

		public PlayCardTask Copy()
		{
			return new PlayCardTask(Controller, Source, Target, ZonePosition, ChooseOne);
		}

		public override TaskState Process()
		{
			bool success = Generic.PlayCard(Controller, Source as IPlayable, Target as ICharacter, ZonePosition, ChooseOne, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"PlayCardTask => [{Controller.Name}] play {Source}({Source.Card.Type})" +
				   $"{(Target != null ? $" {Target}" : "")}{(ZonePosition > -1 ? $" to Pos[{ZonePosition}]" : "")}" +
				   $"{(ChooseOne != 0 ? $" Option {ChooseOne}" : "")}";
		}
	}
}
