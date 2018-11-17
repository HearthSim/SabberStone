using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model;

namespace SabberStoneCore.Auras
{
	public class SummoningPortalAura : Aura
	{
		public SummoningPortalAura() : base(AuraType.HAND) { }

		public SummoningPortalAura(AuraType type, params IEffect[] effects) : base(type, effects)
		{
		}

		public SummoningPortalAura(AuraType type, string enchantmentId) : base(type, enchantmentId)
		{
		}

		protected SummoningPortalAura(Aura prototype, IPlayable owner) : base(prototype, owner)
		{
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			base.Activate(owner, cloning);

			owner.Controller.HandZone.Auras.Add((Aura)owner.OngoingEffect);

		}

		public override void Clone(IPlayable clone)
		{
			base.Clone(clone);
		}

		//public override void Remove()
		//{
		//	base.Remove();
		//}

		//public override void Update()
		//{
		//	if (On)
		//	{
		//		while (AuraUpdateInstructionsQueue.Count > 0)
		//		{
		//			AuraUpdateInstruction inst = AuraUpdateInstructionsQueue.Dequeue();
		//			switch (inst.Instruction)
		//			{
		//				case Instruction.Add:
		//					Apply(inst.Src);
		//					break;
		//				case Instruction.RemoveAll:

		//			}
		//		}
		//	}
		//	else
		//	{
		//		Remove();
		//	}
		//}

		private static void Apply(IPlayable playable)
		{
			int cardValue = playable.Card.Cost;
			int cost = cardValue > 2 ? cardValue - 2 : 1;
			if (playable.NativeTags.TryGetValue(Enums.GameTag.COST, out int tagValue))
			{
				cost = cost - cardValue + tagValue;
				if (cost < 0)
					cost = 0;
			}

			playable.NativeTags[Enums.GameTag.COST] = cost;
			playable.AuraEffects.ToBeUpdated = true;
		}

		private static void RemoveAll(IPlayable playable)
		{
			int cardValue = playable.Card.Cost;
			int cost = cardValue > 2 ? cardValue - 2 : 1;
			int current = playable.NativeTags[Enums.GameTag.COST];
			if (current != cost)
			{

			}
		}
	}
}
