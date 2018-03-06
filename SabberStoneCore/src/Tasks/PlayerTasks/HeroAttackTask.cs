using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		public static HeroAttackTask Any(Controller controller, IEntity target, bool skipPrePhase = false)
		{
			return new HeroAttackTask(controller, target, skipPrePhase);
		}
		private HeroAttackTask(Controller controller, IEntity target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override IEntity Source => null;

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target as ICharacter, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}
	}
}
