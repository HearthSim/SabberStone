using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class PlayCardTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static PlayCardTask Any(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0)
		{
			return new PlayCardTask(controller, source, target, zonePosition, chooseOne);
		}
		public static PlayCardTask Minion(Controller controller, IEntity source, int chooseOne = 0)
		{
			return new PlayCardTask(controller, source, null, -1, chooseOne);
		}
		public static PlayCardTask MinionTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0)
		{
			return new PlayCardTask(controller, source, target, -1, chooseOne);
		}
		public static PlayCardTask Spell(Controller controller, IEntity source, int chooseOne = 0)
		{
			return new PlayCardTask(controller, source, null, -1, chooseOne);
		}
		public static PlayCardTask SpellTarget(Controller controller, IEntity source, IEntity target, int chooseOne = 0)
		{
			return new PlayCardTask(controller, source, target, -1, chooseOne);
		}

		private PlayCardTask(Controller controller, IEntity source, IEntity target = null, int zonePosition = -1, int chooseOne = 0)
		{
			if(controller == null) throw new ArgumentNullException(nameof(controller));
			if(source == null) throw new ArgumentNullException(nameof(source));

			PlayerTaskType = PlayerTaskType.PLAY_CARD;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
			ZonePosition = zonePosition;
			ChooseOne = chooseOne;
		}

		#endregion

		public PlayCardTask Copy()
		{
			return new PlayCardTask(Controller, Source, Target, ZonePosition, ChooseOne);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = Generic.PlayCard(Controller, Source as IPlayable, Target as ICharacter, ZonePosition, ChooseOne);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new PlayCardTask(Controller.ClonedFrom(newGame), Source.ClonedFrom(newGame),
				Target.ClonedFrom(newGame), ZonePosition, ChooseOne);
		}

		public override string FullPrint()
		{
			return $"PlayCardTask => [{Controller.Name}] play {Source}({Source.Card.Type})" +
				   $"{(Target != null ? $" {Target}" : "")}{(ZonePosition > -1 ? $" to Pos[{ZonePosition}]" : "")}" +
				   $"{(ChooseOne != 0 ? $" Option {ChooseOne}" : "")}";
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}