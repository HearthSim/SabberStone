using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ReplaceHeroPower : SimpleTask
	{
		public HeroPower Power { get; set; }

		public Card PowerCard { get; set; }

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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			if (Controller == null)
			{
				return TaskState.STOP;
			}

			if (PowerCard == null && Power == null)
			{
				if (Playables.Count != 1 || !(Playables[0] is HeroPower))
				{
					return TaskState.STOP;
				}

				Power = (HeroPower)Playables[0];
			}

			if (PowerCard != null)
			{
				Power = Entity.FromCard(Controller, PowerCard) as HeroPower;
			}

			Power[GameTag.CREATOR] = Controller.Hero.Id;
			Game.Log(LogLevel.INFO, BlockType.PLAY, "ReplaceHeroPower", $"{Controller.Hero} power replaced by {Power}");

			Controller.Hero.Power = Power;

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new ReplaceHeroPower(Power, PowerCard);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}