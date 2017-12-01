using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Zones
{
	public class SecretZone : LimitedZone<Spell>
	{
		/// <summary>
		/// An unique field for Quest.
		/// Gets or sets the quest in this SecretZone.
		/// null means absence.
		/// </summary>
		public Spell Quest { get; set; }


		public override void Add(IPlayable entity, int zonePosition = -1, bool applyEnchantment = true)
		{
			if (entity.Card[GameTag.QUEST] == 1)
			{
				if (Quest != null)
					throw new ZoneException($"Another quest is already in play");

				Quest = (Spell)entity;
				Quest.SetNativeGameTag(GameTag.ZONE, (int)Type);
				Quest.Zone = this;

				Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

				entity.OrderOfPlay = Game.NextOop;

				return;
			}

			base.Add(entity, zonePosition);

			entity.OrderOfPlay = Game.NextOop;
		}

		public SecretZone(Controller controller)
		{
			Game = controller.Game;
			Controller = controller;
			MaxSize = 5;
			Entities = new Spell[MaxSize];
			Type = Zone.SECRET;
		}

		public override IEnumerator<Spell> GetEnumerator()
		{
			for (int i = 0; i < _count; i++)
				yield return Entities[i];
			if (Quest != null)
				yield return Quest;
		}
	}
}
