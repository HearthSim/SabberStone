using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public int Amount { get; set; }

		public bool Opposite { get; set; }


		public CopyTask(EntityType type, int amount, bool opposite = false)
		{
			Type = type;
			Amount = amount;
			Opposite = opposite;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var result = new List<IPlayable>();
			switch (Type)
			{
				case EntityType.TARGET:
					var target = Target as IPlayable;
					if (target == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Opposite ?
							Entity.FromCard(target.Controller.Opponent, Cards.FromId(target.Card.Id)) :
							Entity.FromCard(Controller, Cards.FromId(target.Card.Id)));
					}
					break;
				case EntityType.SOURCE:
					var source = Source as IPlayable;
					if (source == null)
					{
						return TaskState.STOP;
					}
					for (int i = 0; i < Amount; i++)
					{
						result.Add(Opposite ?
							Entity.FromCard(source.Controller.Opponent, Cards.FromId(source.Card.Id)) :
							Entity.FromCard(Controller, Cards.FromId(source.Card.Id)));
					}
					break;
				case EntityType.STACK:
					if (Playables.Count < 1)
					{
						return TaskState.STOP;
					}
					Playables.ForEach(p =>
					{
						for (int i = 0; i < Amount; i++)
						{
							result.Add(Opposite ?
								Entity.FromCard(p.Controller.Opponent, Cards.FromId(p.Card.Id)) :
								Entity.FromCard(Controller, Cards.FromId(p.Card.Id)));
						}
					});
					break;
				case EntityType.OP_HERO_POWER:
					result.Add(Entity.FromCard(Controller, Cards.FromId(Controller.Opponent.Hero.Power.Card.Id)));
					break;
				default:
					throw new NotImplementedException();
			}

			Playables = result;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(CopyTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new CopyTask(Type, Amount, Opposite);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}