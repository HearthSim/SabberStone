using System;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class Enchantment
	{
		public string InfoCardId { get; set; } = null;

		public EnchantmentArea Area { get; set; } = EnchantmentArea.NONE;

		public EnchantmentActivation Activation { get; set; } = EnchantmentActivation.NONE;

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
				ISimpleTask clone = SingleTask.Clone();
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
				case EnchantmentArea.TARGET:
					if (target != null)
					{
						Enchant?.Activate(source.Card.Id, target.Enchants, target);
						Trigger?.Activate(source.Card.Id, target.Triggers, target);
					}
					break;
				case EnchantmentArea.HAND:
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					break;
				case EnchantmentArea.OP_HAND:
					Enchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
					break;
				case EnchantmentArea.HANDS:
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
					break;
				case EnchantmentArea.HAND_AND_BOARD:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					break;
				case EnchantmentArea.BOARD:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					break;
				case EnchantmentArea.OP_BOARD:
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case EnchantmentArea.OP_BOARD_AND_OP_HERO:
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case EnchantmentArea.BOARDS:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case EnchantmentArea.SECRET:
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					break;
				case EnchantmentArea.SECRETS:
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.SecretZone.Triggers, source);
					break;
				case EnchantmentArea.HERO:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					break;
				case EnchantmentArea.HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case EnchantmentArea.SELF:
					Enchant?.Activate(source.Card.Id, source.Enchants, source);
					Trigger?.Activate(source.Card.Id, source.Triggers, source);
					break;
				case EnchantmentArea.CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					break;
				case EnchantmentArea.OP_CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case EnchantmentArea.CONTROLLERS:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case EnchantmentArea.GAME:
					Enchant?.Activate(source.Card.Id, controller.Game.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Game.Triggers, source);
					break;
				case EnchantmentArea.BOARDS_HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case EnchantmentArea.GRAVEYARD:
					Enchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
					break;
				case EnchantmentArea.GRAVEYARD_AND_SECRET:
					Enchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					break;
				case EnchantmentArea.OP_GRAVEYARD:
					Enchant?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Triggers, source);
					break;
				case EnchantmentArea.OP_GRAVEYARD_AND_OP_SECRET:
					Enchant?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.SecretZone.Triggers, source);
					break;

				default:
					throw new NotImplementedException();
			}

		}
	}
}
