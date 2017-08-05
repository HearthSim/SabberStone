using System;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class Enchantment
	{
		public string InfoCardId { get; set; } = null;

		public EEnchantmentArea Area { get; set; } = EEnchantmentArea.NONE;

		public EEnchantmentActivation Activation { get; set; } = EEnchantmentActivation.NONE;

		public Enchant Enchant { get; set; }

		public Trigger Trigger { get; set; }

		public ISimpleTask SingleTask { get; set; }

		public bool RemoveAfterActivation { get; set; } = false;

		public void Activate(Controller controller, IPlayable source, IPlayable target = null)
		{
			// execute task straight over
			if (SingleTask != null)
			{
				// clone task here
				var clone = SingleTask.Clone();
				clone.Game = controller.Game;
				clone.Controller = controller;
				clone.Source = source;
				clone.Target = target;

				controller.Game.TaskQueue.Enqueue(clone);
			}

			// only apply enchant and triggers if there is ...
			if (Enchant == null && Trigger == null)
			{
				return;
			}

			switch (Area)
			{
				case EEnchantmentArea.TARGET:
					if (target != null)
					{
						Enchant?.Activate(source.Card.Id, target.Enchants, target);
						Trigger?.Activate(source.Card.Id, target.Triggers, target);
					}
					break;
				case EEnchantmentArea.HAND:
					Enchant?.Activate(source.Card.Id, controller.Hand.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hand.Triggers, source);
					break;
				case EEnchantmentArea.OP_HAND:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hand.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hand.Triggers, source);
					break;
				case EEnchantmentArea.HANDS:
					Enchant?.Activate(source.Card.Id, controller.Hand.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hand.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hand.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hand.Triggers, source);
					break;
				case EEnchantmentArea.HAND_AND_BOARD:
					Enchant?.Activate(source.Card.Id, controller.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Board.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Hand.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hand.Triggers, source);
					break;
				case EEnchantmentArea.BOARD:
					Enchant?.Activate(source.Card.Id, controller.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Board.Triggers, source);
					break;
				case EEnchantmentArea.OP_BOARD:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Board.Triggers, source);
					break;
				case EEnchantmentArea.OP_BOARD_AND_OP_HERO:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Board.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case EEnchantmentArea.BOARDS:
					Enchant?.Activate(source.Card.Id, controller.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Board.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Board.Triggers, source);
					break;
				case EEnchantmentArea.SECRET:
					Enchant?.Activate(source.Card.Id, controller.Secrets.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Secrets.Triggers, source);
					break;
				case EEnchantmentArea.HERO:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					break;
				case EEnchantmentArea.HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case EEnchantmentArea.SELF:
					Enchant?.Activate(source.Card.Id, source.Enchants, source);
					Trigger?.Activate(source.Card.Id, source.Triggers, source);
					break;
				case EEnchantmentArea.CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					break;
				case EEnchantmentArea.OP_CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case EEnchantmentArea.CONTROLLERS:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case EEnchantmentArea.GAME:
					Enchant?.Activate(source.Card.Id, controller.Game.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Game.Triggers, source);
					break;
				case EEnchantmentArea.BOARDS_HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Board.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Board.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Board.Triggers, source);
					break;

				default:
					throw new NotImplementedException();
			}

		}
	}
}