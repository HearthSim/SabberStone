using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroAttackTask : PlayerTask
	{
		public static HeroAttackTask Any(in Controller controller, in ICharacter target, in bool skipPrePhase = false)
		{
			return new HeroAttackTask(in controller, in target, in skipPrePhase);
		}
		private HeroAttackTask(in Controller controller, in ICharacter target, in bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Controller.Hero, Target, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroAttackTask => [{Controller.Name}] {Controller.Hero} attacks {Target}";
		}
	}
}
