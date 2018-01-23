using System;
using SabberStoneCore.Tasks;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class Power
	{
		public string InfoCardId { get; set; } = null;

		public Aura Aura { get; set; }

		public Enchant Enchant { get; set; }

		public Trigger Trigger { get; set; }

		public ISimpleTask PowerTask { get; set; }

		public ISimpleTask DeathrattleTask { get; set; }

		public ISimpleTask ComboTask { get; set; }

		//public void Activate(Controller controller, IPlayable source, IPlayable target = null)
		//{
		//	// execute task straight over
		//	if (PowerTask != null)
		//	{
		//		// clone task here
		//		ISimpleTask clone = PowerTask.Clone();
		//		clone.Game = controller.Game;
		//		clone.Controller = controller;
		//		clone.Source = source;
		//		clone.Target = target;

		//		controller.Game.TaskQueue.Enqueue(clone);
		//	}

		//	// only apply enchant and triggers if there is ...
		//	if (OldEnchant == null && OldTrigger == null)
		//	{
		//		return;
		//	}

		//	switch (Area)
		//	{
		//		case PowerArea.TARGET:
		//			if (target != null)
		//			{
		//				OldEnchant?.Activate(source.Card.Id, target.OldEnchants, target);
		//				OldTrigger?.Activate(source.Card.Id, target.Triggers, target);
		//			}
		//			break;
		//		case PowerArea.HAND:
		//			OldEnchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
		//			break;
		//		case PowerArea.OP_HAND:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
		//			break;
		//		case PowerArea.HANDS:
		//			OldEnchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.HandZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.HandZone.Triggers, source);
		//			break;
		//		case PowerArea.HAND_AND_BOARD:
		//			OldEnchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.HandZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.HandZone.Triggers, source);
		//			break;
		//		case PowerArea.BOARD:
		//			OldEnchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
		//			break;
		//		case PowerArea.OP_BOARD:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
		//			break;
		//		case PowerArea.OP_BOARD_AND_OP_HERO:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
		//			break;
		//		case PowerArea.BOARDS:
		//			OldEnchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
		//			break;
		//		case PowerArea.SECRET:
		//			OldEnchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
		//			break;
		//		case PowerArea.SECRETS:
		//			OldEnchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.SecretZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.SecretZone.Triggers, source);
		//			break;
		//		case PowerArea.HERO:
		//			OldEnchant?.Activate(source.Card.Id, controller.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
		//			break;
		//		case PowerArea.OP_HERO:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
		//			break;
		//		case PowerArea.HEROES:
		//			OldEnchant?.Activate(source.Card.Id, controller.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
		//			break;
		//		case PowerArea.SELF:
		//			OldEnchant?.Activate(source.Card.Id, source.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, source.Triggers, source);
		//			break;
		//		case PowerArea.CONTROLLER:
		//			OldEnchant?.Activate(source.Card.Id, controller.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Triggers, source);
		//			break;
		//		case PowerArea.OP_CONTROLLER:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
		//			break;
		//		case PowerArea.CONTROLLERS:
		//			OldEnchant?.Activate(source.Card.Id, controller.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Triggers, source);
		//			break;
		//		case PowerArea.GAME:
		//			OldEnchant?.Activate(source.Card.Id, controller.Game.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Game.Triggers, source);
		//			break;
		//		case PowerArea.BOARDS_HEROES:
		//			OldEnchant?.Activate(source.Card.Id, controller.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Hero.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.Hero.OldEnchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.Hero.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.BoardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.BoardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.BoardZone.Triggers, source);
		//			break;
		//		case PowerArea.GRAVEYARD:
		//			OldEnchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
		//			break;
		//		case PowerArea.GRAVEYARD_AND_SECRET:
		//			OldEnchant?.Activate(source.Card.Id, controller.GraveyardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.GraveyardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.SecretZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.SecretZone.Triggers, source);
		//			break;
		//		case PowerArea.OP_GRAVEYARD:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Triggers, source);
		//			break;
		//		case PowerArea.OP_GRAVEYARD_AND_OP_SECRET:
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.GraveyardZone.Triggers, source);
		//			OldEnchant?.Activate(source.Card.Id, controller.Opponent.SecretZone.Enchants, source);
		//			OldTrigger?.Activate(source.Card.Id, controller.Opponent.SecretZone.Triggers, source);
		//			break;

		//		default:
		//			throw new NotImplementedException();
		//	}

		//}
	}
}
