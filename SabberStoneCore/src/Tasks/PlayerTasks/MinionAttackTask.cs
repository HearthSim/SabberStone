using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;
using System;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class MinionAttackTask : PlayerTask
	{
		#region CONSTRUCTORS

		public static MinionAttackTask Any(Controller controller, IEntity source, IEntity target)
		{
			return new MinionAttackTask(controller, source, target);
		}

		private MinionAttackTask(Controller controller, IEntity source, IEntity target)
		{
			if(controller == null) throw new ArgumentNullException(nameof(controller));
			if(source == null) throw new ArgumentNullException(nameof(controller));
			if(target == null) throw new ArgumentNullException(nameof(target));

			PlayerTaskType = PlayerTaskType.MINION_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
		}

		#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Source as Minion, Target as ICharacter);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		protected override PlayerTask InternalClone(Game newGame)
		{
			return new MinionAttackTask(Controller.ClonedFrom(newGame), Source.ClonedFrom(newGame), Target.ClonedFrom(newGame));
		}

		public override string FullPrint()
		{
			return $"MinionAttackTask => [{Controller.Name}] {Source}({Source.Card.Type}) attack {Target}";
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}