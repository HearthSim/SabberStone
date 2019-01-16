using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class MinionAttackTask : PlayerTask
	{
		public static MinionAttackTask Any(Controller controller, IPlayable source, ICharacter target,
			bool skipPrePhase = false)
		{
			return new MinionAttackTask(controller, source, target, skipPrePhase);
		}

		private MinionAttackTask(Controller controller, IPlayable source, ICharacter target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.MINION_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override bool Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Source as Minion, Target, SkipPrePhase);

			return success;
		}

		public override string FullPrint()
		{
			return $"MinionAttackTask => [{Controller.Name}] {Source}({Source.Card.Type}) attack {Target}";
		}
	}
}
