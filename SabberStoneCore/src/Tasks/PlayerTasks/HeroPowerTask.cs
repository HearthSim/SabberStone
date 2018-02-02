using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroPowerTask : PlayerTask
	{
		public static HeroPowerTask Any(Controller controller, IEntity target = null, bool skipPrePhase = false)
		{
			return new HeroPowerTask(controller, target, skipPrePhase);
		}

		private HeroPowerTask(Controller controller, IEntity target, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_POWER;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			SkipPrePhase = skipPrePhase;
		}

		public override TaskState Process()
		{
			bool success = Generic.HeroPower(Controller, Target as ICharacter, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroPowerTask => [{Controller.Name}] using {Controller.Hero.HeroPower}" +
				   $"{(Target != null ? $" attack {Target}" : "")}";
		}
	}
}
