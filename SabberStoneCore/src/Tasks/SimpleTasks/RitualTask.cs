using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RitualTask : SimpleTask
	{
		public Enchant Enchant { get; set; }

		public bool Taunt { get; set; }

		public RitualTask(Enchant enchant = null, bool taunt = false)
		{
			Enchant = enchant;
			Taunt = taunt;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			//[irc] Patashu @darkfriend77 yeah, that's the general idea. 
			// there's two kinds of triggers, one when a c'thun is summoned or 
			// generated in hand or moved to hand that copies the ritual buffs 
			// on the proxy to that c'thun, one when a new c'thun buff is made 
			// (or maybe it's a card effect not a trigger? or even an aura style 
			// effect ??) that copies the additional effect to c'thuns in your 
			// hand and board that aren't silenced

			if (!Controller.SeenCthun)
			{
				IPlayable proxyCthun = Entity.FromCard(Controller, Cards.FromId("OG_279"));
				proxyCthun[GameTag.REVEALED] = 1;
				Controller.SetasideZone.Add(proxyCthun);
				Controller.ProxyCthun = proxyCthun.Id;
				Controller.SeenCthun = true;
			}

			var entities = new List<IPlayable> { Game.EntityContainer[Controller.ProxyCthun] };
			entities.AddRange(Controller.BoardZone.GetAll.Where(p => p.Card.Id.Equals("OG_280")));
			entities.AddRange(Controller.HandZone.GetAll.Where(p => p.Card.Id.Equals("OG_280")));

			if (Enchant != null)
			{
				// activate enchants on the sources
				entities.ForEach(p => Enchant.Activate(Source.Card.Id, p.Enchants, p));
			}

			if (Taunt)
			{
				entities.ForEach(p => p[GameTag.TAUNT] = 1);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalDeepClone(Game newGame)
		{
			// TODO; Check if this enchant needs to be copied.
			return new RitualTask(Enchant, Taunt);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}