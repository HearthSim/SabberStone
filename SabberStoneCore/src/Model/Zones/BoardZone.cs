using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	public class BoardZone : PositioningZone<Minion>
	{
		public BoardZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
			//MaxSize = Game.MAX_MINIONS_ON_BOARD;
			MaxSize = 7;
			Entities = new Minion[MaxSize];
			Type = Zone.PLAY;
		}

		//public override bool IsFull => Entities[MaxSize - 1] != null;

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			base.Add(entity, zonePosition);

			if (entity[GameTag.CHARGE] != 1)
				entity.IsExhausted = true;

			entity.OrderOfPlay = Game.NextOop;

			ActivateAura(entity);

			Game.TriggerManager.OnZoneTrigger(entity);
		}

		public override IPlayable Remove(IPlayable entity)
		{
			RemoveAura(entity);
			return base.Remove(entity);
		}

		/// <summary>
		/// Replaces an entity in this zone to new entity and returns the old entity.
		/// The position of the new entity is the same position the old entity had.
		/// </summary>
		/// <param name="oldEntity">The entity to be replaced.</param>
		/// <param name="newEntity">The new entity.</param>
		/// <returns></returns>
		public void Replace(Minion oldEntity, Minion newEntity)
		{
			int pos = oldEntity.ZonePosition;
			Entities[pos] = newEntity;
			newEntity.ZonePosition = pos;
			newEntity.SetNativeGameTag(GameTag.ZONE, (int)Type);
			newEntity.Zone = this;

			// Remove old Entity
			RemoveAura(oldEntity);
			for (int i = 0; i < Auras.Count; i++)
				Auras[i].EntityRemoved(oldEntity);
			oldEntity.ActivatedTrigger?.Remove();

			Controller.SetasideZone.Add(oldEntity);

			// Add new Entity
			newEntity.OrderOfPlay = Game.NextOop;
			ActivateAura(newEntity);
		}

		private static void ActivateAura(IPlayable entity)
		{
			entity.Power?.Trigger?.Activate(entity);
			entity.Power?.Aura?.Activate(entity);

			if (entity.Card[GameTag.SPELLPOWER] > 0)
				entity.Controller.CurrentSpellPower += entity.Card.Tags[GameTag.SPELLPOWER];
		}

		private static void RemoveAura(IPlayable entity)
		{
			entity.OngoingEffect?.Remove();

			if (entity.Controller.CurrentSpellPower > 0 && entity[GameTag.SPELLPOWER] > 0)
				entity.Controller.CurrentSpellPower -= entity[GameTag.SPELLPOWER];
		}
	}
}
