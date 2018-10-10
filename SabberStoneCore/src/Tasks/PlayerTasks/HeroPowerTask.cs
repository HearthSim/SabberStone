using SabberStoneCore.Actions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.PlayerTasks
{
	public class HeroPowerTask : PlayerTask
	{
		public static HeroPowerTask Any(in Controller controller, in ICharacter target = null, in int chooseOne = 0, in bool skipPrePhase = false)
		{
			return new HeroPowerTask(in controller, in target, in chooseOne, in skipPrePhase);
		}

		private HeroPowerTask(in Controller controller, in ICharacter target, in int chooseOne, in bool skipPrePhase)
		{
			PlayerTaskType = PlayerTaskType.HERO_POWER;
			Game = controller.Game;
			Controller = controller;
			Target = target;
			ChooseOne = chooseOne;
			SkipPrePhase = skipPrePhase;
		}

		public override TaskState Process()
		{
			bool success = Generic.HeroPower(Controller, Target, ChooseOne, SkipPrePhase);
			return TaskState.COMPLETE;
		}

		public override string FullPrint()
		{
			return $"HeroPowerTask => [{Controller.Name}] using {Controller.Hero.HeroPower}" +
				   $"{(Target != null ? $" attack {Target}" : "")}";
		}
	}
}
