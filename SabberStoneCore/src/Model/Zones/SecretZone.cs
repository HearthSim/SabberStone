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

		public SecretZone(Controller controller) : base(5)
		{
			Game = controller.Game;
			Controller = controller;
			Type = Zone.SECRET;
		}

		private SecretZone(Controller c, SecretZone zone) : base(c, zone)
		{
			Quest = (Spell) zone.Quest?.Clone(c);
			Type = Zone.SECRET;
		}

		public override void Add(IPlayable entity, int zonePosition = -1, bool applyPowers = true)
		{
			if (entity.Card[GameTag.QUEST] == 1)
			{
				if (Quest != null)
					throw new ZoneException($"Another quest is already in play");

				Quest = (Spell)entity;
				Quest[GameTag.ZONE] = (int)Type;
				Quest.Zone = this;

				Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Zone", !Game.Logging ? "" : $"Entity '{entity} ({entity.Card.Type})' has been added to zone '{Type}' in position '{entity.ZonePosition}'.");

				entity.OrderOfPlay = Game.NextOop;

				return;
			}

			base.Add(entity, zonePosition);

			entity.OrderOfPlay = Game.NextOop;
		}

		public override IEnumerator<Spell> GetEnumerator()
		{
			for (int i = 0; i < _count; i++)
				yield return Entities[i];
			if (Quest != null)
				yield return Quest;
		}

		public SecretZone Clone(Controller c)
		{
			return new SecretZone(c, this);
		}
	}
}
