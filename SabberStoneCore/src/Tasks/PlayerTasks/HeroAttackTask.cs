using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static HeroAttackTask Any(Controller controller, IEntity target)
		{
			return new HeroAttackTask(controller, target);
		}

		private HeroAttackTask(Controller controller, IEntity target)
		{
			if (controller == null) throw new ArgumentNullException(nameof(controller));
			if (target == null) throw new ArgumentNullException(nameof(target));

			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
		}

		#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target as ICharacter);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new HeroAttackTask(Controller.ClonedFrom(newGame), Target.ClonedFrom(newGame));
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}

		#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}