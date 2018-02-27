using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class RitualTask : SimpleTask
	{
		public enum RitualType
		{
			Check,
			Buff,
			Taunt,
			Blade
		}

		public RitualTask(RitualType type = RitualType.Check)
		{
			_type = type;
		}

		public RitualTask(int amount)
		{
			_type = RitualType.Buff;
			_amount = amount;
		}

		private RitualTask(RitualType type, int amount)
		{
			_type = type;
			_amount = amount;
		}

		private readonly RitualType _type;
		private readonly int _amount;

		private static readonly Card BuffEnchantmentCard = Cards.FromId("OG_281e");
		private static readonly Card BladeofCThunEnchantmentCard = Cards.FromId("OG_282e");
		private static readonly Card TauntEnchantmentCard = Cards.FromId("OG_284e");

		public override TaskState Process()
		{
			//[irc] Patashu @darkfriend77 yeah, that's the general idea. 
			// there's two kinds of triggers, one when a c'thun is summoned or 
			// generated in hand or moved to hand that copies the ritual buffs 
			// on the proxy to that c'thun, one when a new c'thun buff is made 
			// (or maybe it's a card effect not a trigger? or even an aura style 
			// effect ??) that copies the additional effect to c'thuns in your 
			// hand and board that aren't silenced

			IPlayable proxyCthun;
			if (!Controller.SeenCthun)
			{
				proxyCthun = Entity.FromCard(Controller, Cards.FromId("OG_279"));
				proxyCthun[GameTag.REVEALED] = 1;
				Controller.SetasideZone.Add(proxyCthun);
				Controller.ProxyCthun = proxyCthun.Id;
				Controller.SeenCthun = true;
			}
			else
				proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];

			var entities = new List<IPlayable> {proxyCthun};
			entities.AddRange(Controller.BoardZone.GetAll(p => p.Card.Id.Equals("OG_280")));
			entities.AddRange(Controller.HandZone.GetAll(p => p.Card.Id.Equals("OG_280")));

			switch (_type)
			{
				case RitualType.Buff:
					if (proxyCthun.OngoingEffect == null)
					{
						entities.ForEach(p =>
						{
							Generic.AddEnchantmentBlock.Invoke(Controller, BuffEnchantmentCard, (IPlayable) Source, p, 0, 0);

							((OngoingEnchant) p.OngoingEffect).Count += (_amount - 1);
						});
						break;
					}
					entities.ForEach(p =>
					{
						if (p[GameTag.SILENCED] == 1)
							Generic.AddEnchantmentBlock.Invoke(Controller, BuffEnchantmentCard, (IPlayable) Source, p, 0, 0);
						
						((OngoingEnchant) p.OngoingEffect).Count += _amount;
					});
					break;

				case RitualType.Taunt:
					if (proxyCthun[GameTag.TAUNT] == 1) break;
					entities.ForEach(p =>
					{
						Generic.AddEnchantmentBlock.Invoke(Controller, TauntEnchantmentCard, (IPlayable)Source, p, 0, 0);
					});
					break;

				case RitualType.Blade:
					entities.ForEach(p =>
					{
						Generic.AddEnchantmentBlock.Invoke(Controller, BladeofCThunEnchantmentCard, (IPlayable) Source, p, Number,
							Number1);
					});
					break;
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RitualTask(_type, _amount);
			return clone;
		}
	}
}
