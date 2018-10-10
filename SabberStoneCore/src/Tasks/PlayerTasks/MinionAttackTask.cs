using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class MinionAttackTask : PlayerTask
	{
		public static MinionAttackTask Any(in Controller controller, in IPlayable source, in ICharacter target, in bool skipPrePhase = false)
		{
			return new MinionAttackTask(in controller, in source, in target, in skipPrePhase);
		}

		private MinionAttackTask(in Controller controller, in IPlayable source, in ICharacter target, in bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.MINION_ATTACK;
			Game = controller.Game;
			Controller = controller;
			Source = source;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override TaskState Process()
		{
			bool success = Generic.AttackBlock.Invoke(Controller, Source as Minion, Target, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"MinionAttackTask => [{Controller.Name}] {Source}({Source.Card.Type}) attack {Target}";
		}
	}
}
