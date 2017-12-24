using System;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class Power
	{
		public string InfoCardId { get; set; } = null;

		public PowerArea Area { get; set; } = PowerArea.NONE;

		public PowerActivation Activation { get; set; } = PowerActivation.NONE;

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
				case PowerArea.TARGET:
					if (target != null)
					{
						Enchant?.Activate(source.Card.Id, target.Enchants, target);
						Trigger?.Activate(source.Card.Id, target.Triggers, target);
					}
					break;
				case PowerArea.HAND:
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					break;
				case PowerArea.OP_HAND:
					Enchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
					break;
				case PowerArea.HANDS:
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
					break;
				case PowerArea.HAND_AND_BOARD:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
					break;
				case PowerArea.BOARD:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					break;
				case PowerArea.OP_BOARD:
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case PowerArea.OP_BOARD_AND_OP_HERO:
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case PowerArea.BOARDS:
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case PowerArea.SECRET:
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					break;
				case PowerArea.SECRETS:
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.SecretZone.Triggers, source);
					break;
				case PowerArea.HERO:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					break;
				case PowerArea.OP_HERO:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case PowerArea.HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					break;
				case PowerArea.SELF:
					Enchant?.Activate(source.Card.Id, source.Enchants, source);
					Trigger?.Activate(source.Card.Id, source.Triggers, source);
					break;
				case PowerArea.CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					break;
				case PowerArea.OP_CONTROLLER:
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case PowerArea.CONTROLLERS:
					Enchant?.Activate(source.Card.Id, controller.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
					break;
				case PowerArea.GAME:
					Enchant?.Activate(source.Card.Id, controller.Game.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Game.Triggers, source);
					break;
				case PowerArea.BOARDS_HEROES:
					Enchant?.Activate(source.Card.Id, controller.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.Hero.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
					break;
				case PowerArea.GRAVEYARD:
					Enchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
					break;
				case PowerArea.GRAVEYARD_AND_SECRET:
					Enchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
					Enchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
					break;
				case PowerArea.OP_GRAVEYARD:
					Enchant?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Enchants, source);
					Trigger?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Triggers, source);
					break;
				case PowerArea.OP_GRAVEYARD_AND_OP_SECRET:
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
