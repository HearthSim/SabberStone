using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class MinionAttackTask : PlayerTask
	{
		public static MinionAttackTask Any(Controller controller, IEntity source, IEntity target)
		{
			return new MinionAttackTask(controller, source, target);
		}

		private MinionAttackTask(Controller controller, IEntity source, IEntity target)
		{
			PlayerTaskType = PlayerTaskType.MINION_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
		}

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Source as Minion, Target as ICharacter);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"MinionAttackTask => [{Controller.Name}] {Source}({Source.Card.Type}) attack {Target}";
		}
	}
}