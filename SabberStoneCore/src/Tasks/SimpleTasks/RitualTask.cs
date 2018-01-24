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
		public RitualTask(string enchantmentId = "", bool useScriptTag = false)
		{
			_enchantmentCard = Cards.FromId(enchantmentId);
			_useScriptTag = useScriptTag;
		}

		private RitualTask(Card enchantmentCard, bool useScriptTag)
		{
			_enchantmentCard = enchantmentCard;
			_useScriptTag = useScriptTag;
		}

		private readonly Card _enchantmentCard;
		private readonly bool _useScriptTag;

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

			var entities = new List<IPlayable> { Game.IdEntityDic[Controller.ProxyCthun] };
			entities.AddRange(Controller.BoardZone.Where(p => p.Card.Id.Equals("OG_280")));
			entities.AddRange(Controller.HandZone.Where(p => p.Card.Id.Equals("OG_280")));

			if (_enchantmentCard != null)
			{
				entities.ForEach(p =>
				{
					Enchantment enchantment =
						Game.History ? Enchantment.GetInstance(Controller, (IPlayable) Source, p, _enchantmentCard) : null;
					if (_useScriptTag && Game.History)
					{
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1] = Number;
						enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] = Number1;
					}
					_enchantmentCard.Power.Enchant.ActivateTo(p, enchantment, Number, Number1);
				});
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RitualTask(_enchantmentCard, _useScriptTag);
			return clone;
		}
	}
}
