using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroPowerTask : PlayerTask
	{
		public static HeroPowerTask Any(Controller controller, IEntity target = null, int chooseOne = 0, bool skipPrePhase = false)
		{
			return new HeroPowerTask(controller, target, chooseOne, skipPrePhase);
		}

		private HeroPowerTask(Controller controller, IEntity target, int chooseOne, bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_POWER;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			ChooseOne = chooseOne;
			SkipPrePhase = skipPrePhase;
		}

		public override IEntity Source => null;

		public override TaskState Process()
		{
			bool success = Generic.HeroPower(Controller, Target as ICharacter, ChooseOne, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroPowerTask => [{Controller.Name}] using {Controller.Hero.HeroPower}" +
				   $"{(Target != null ? $" attack {Target}" : "")}";
		}
	}
}
