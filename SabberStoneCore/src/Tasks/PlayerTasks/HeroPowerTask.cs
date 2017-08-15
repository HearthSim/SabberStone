using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroPowerTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static HeroPowerTask Any(Controller controller, IEntity target = null)
		{
			return new HeroPowerTask(controller, target);
		}

		private HeroPowerTask(Controller controller, IEntity target)
		{
			if(controller == null) throw new ArgumentNullException(nameof(controller));
			// Target is allowed to be null.

			PlayerTaskType = PlayerTaskType.HERO_POWER;
			Game = controller.Game;
			Controller = controller;
			Target = target;
		}

		#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = Generic.HeroPower(Controller, Target as ICharacter);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new HeroPowerTask(Controller.ClonedFrom(newGame), Target.ClonedFrom(newGame));
		}

		public override string FullPrint()
		{
			return $"HeroPowerTask => [{Controller.Name}] using {Controller.Hero.Power}" +
				   $"{(Target != null ? $" attack {Target}" : "")}";
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}