using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using System.Linq;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class PlayCardTask : PlayerTask
	{
		public static PlayCardTask Any(in Controller controller, in IPlayable source, in ICharacter target = null, in int zonePosition = -1, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, in source, in target, in zonePosition, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask Any(in Controller controller, string cardName, in ICharacter target = null, in int zonePosition = -1, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), in target, in zonePosition, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask Minion(in Controller controller, in IPlayable source, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, in source, null, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask Minion(in Controller controller, string cardName, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), null, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask MinionTarget(in Controller controller, in IPlayable source, in ICharacter target, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, in source, in target, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask MinionTarget(in Controller controller, string cardName, in ICharacter target, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), in target, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask Spell(in Controller controller, in IPlayable source, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, in source, null, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask Spell(in Controller controller, string cardName, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), null, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask SpellTarget(in Controller controller, in IPlayable source, in ICharacter target, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, in source, in target, -1, in chooseOne, in skipPrePhase);
		}
		public static PlayCardTask SpellTarget(in Controller controller, string cardName, in ICharacter target, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new PlayCardTask(in controller, controller.HandZone.Where(p => p.Card.Name == cardName).First(), in target, -1, in chooseOne, in skipPrePhase);
		}
		private PlayCardTask(in Controller controller, in IPlayable source, in ICharacter target = null, in int zonePosition = -1, in int chooseOne = 0, in bool skipPrePhase = false)
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

		public int ZonePosition { get; set; }

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
