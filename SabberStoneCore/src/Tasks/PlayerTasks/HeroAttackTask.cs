using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		public static HeroAttackTask Any(Controller controller, IEntity target)
		{
			return new HeroAttackTask(controller, target);
		}
		private HeroAttackTask(Controller controller, IEntity target)
		{
			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
		}
		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target as ICharacter);
			Controller.Game.NextStep = Step.MAIN_CLEANUP;
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}
	}
}