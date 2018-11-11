using System;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class SummoningPortalAura : IAura
	{
		public IPlayable Owner { get; }

		public SummoningPortalAura()
		{

		}

		private SummoningPortalAura(IPlayable owner)
		{
			Owner = owner;
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public void Activate(IPlayable owner)
		{
			var instance = new SummoningPortalAura(owner);
			owner.OngoingEffect = instance;
			owner.Game.Auras.Add(instance);
		}

		public void Clone(IPlayable clone)
		{
			throw new NotImplementedException();
		}
	}
}
