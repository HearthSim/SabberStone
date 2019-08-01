using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Auras
{
	public class SummoningPortalAura : Aura
	{
		public SummoningPortalAura() : base(AuraType.HAND) { }
		
		private SummoningPortalAura(SummoningPortalAura prototype, IPlayable owner) : base(prototype, owner)
		{
			
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			var instance = new SummoningPortalAura(this, owner);
			owner.OngoingEffect = instance;
			owner.Controller.HandZone.Auras.Add(instance);
			owner.Game.Auras.Add(instance);
			if (!cloning)
				instance.AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.AddAll), 1);
		}

		public override void Update()
		{
			bool addAllProcessed = false;
			while (AuraUpdateInstructionsQueue.Count > 0)
			{
				AuraUpdateInstruction inst = AuraUpdateInstructionsQueue.Dequeue();
				switch (inst.Instruction)
				{
					case Instruction.RemoveAll:
						RemoveAll();
						return;
					case Instruction.AddAll:
						addAllProcessed = true;
						AddAll();
						break;
					case Instruction.Add:
						if (addAllProcessed) break;
						Apply(inst.Src);
						AppliedEntityIdCollection.Add(inst.Src.Id);
						break;
					case Instruction.Remove:
						if (!AppliedEntityIdCollection.Remove(inst.Src.Id))
							break;
						DeApply(inst.Src);
						break;
				}
			}
		}

		private void AddAll()
		{
			Owner.Controller.HandZone.ForEach(p =>
			{
				Apply(p);
				AppliedEntityIdCollection.Add(p.Id);
			});
		}

		private void RemoveAll()
		{
			AppliedEntityIdCollection.ForEach(Game.IdEntityDic,
				(i, dict) => DeApply(dict[i]));
			Game.Auras.Remove(this);
		}

		private static void Apply(IPlayable playable)
		{
			if (!(playable is Minion m)) return;

			// The effect of Summoning Portal is always applied before any other effects.

			int cardValue = m.Card.Cost;
			int cost = cardValue > 2 ? cardValue - 2 : 1;

			int? eValue = m._modifiedCost;

			m.Cost = eValue.HasValue ? cost - cardValue + eValue.Value : cost;

			m._costManager?.QueueUpdate();
		}

		private new static void DeApply(IPlayable playable)
		{
			Playable p = (Playable)playable;

			if (p._modifiedCost == null) return;

			int cardValue = p.Card.Cost;
			int delta = cardValue > 2 ? 2 : cardValue > 1 ? 1 : 0;

			p.Cost = p._modifiedCost.Value + delta;

			p._costManager?.QueueUpdate();

			//playable[GameTag.COST] += delta;
			//playable.AuraEffects.ToBeUpdated = true;
		}
		
		public override void Clone(IPlayable clone)
		{
			Activate(clone, true);
		}
	}
}
