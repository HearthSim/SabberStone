using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceHeroPower : SimpleTask
	{
		private ReplaceHeroPower(HeroPower power, Card cardPower)
		{
			Power = power;
			PowerCard = cardPower;
		}

		public ReplaceHeroPower()
		{
			Power = null;
			PowerCard = null;
		}

		public ReplaceHeroPower(HeroPower power)
		{
			Power = power;
			PowerCard = null;
		}

		public ReplaceHeroPower(Card cardPower)
		{
			Power = null;
			PowerCard = cardPower;
		}

		public HeroPower Power { get; set; }

		public Card PowerCard { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (controller == null) return TaskState.STOP;

			if (PowerCard == null && Power == null)
			{
				if (stack?.Playables.Count != 1 || !(stack?.Playables[0] is HeroPower)) return TaskState.STOP;

				Power = (HeroPower) stack?.Playables[0];
			}

			if (PowerCard != null) Power = Entity.FromCard(controller, PowerCard) as HeroPower;

			Power[GameTag.CREATOR] = controller.Hero.Id;
			game.Log(LogLevel.INFO, BlockType.PLAY, "ReplaceHeroPower",
				!game.Logging ? "" : $"{controller.Hero} power replaced by {Power}");

			controller.SetasideZone.MoveTo(controller.Hero.HeroPower, controller.SetasideZone.Count);
			controller.Hero.HeroPower = Power;

			return TaskState.COMPLETE;
		}
	}
}
