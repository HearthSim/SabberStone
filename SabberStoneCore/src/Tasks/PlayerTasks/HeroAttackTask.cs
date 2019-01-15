using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		public static HeroAttackTask Any(Controller controller, ICharacter target, bool skipPrePhase = false)
		{
			return new HeroAttackTask(controller, target, skipPrePhase);
		}
		private HeroAttackTask(Controller controller, ICharacter target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override bool Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target, SkipPrePhase);
			return success;
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}
	}
}
