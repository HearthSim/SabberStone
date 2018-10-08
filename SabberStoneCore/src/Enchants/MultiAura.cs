using System.Collections;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class MultiAura : Aura, IReadOnlyList<Aura>
	{
		private readonly IReadOnlyList<Aura> _auras;

		public MultiAura(params Aura[] auras) : base(AuraType.MULTIAURA)
		{
			_auras = auras;
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			Aura[] auras = new Aura[_auras.Count];

			for (int i = 0; i < _auras.Count; i++)
			{
				_auras[i].Activate(owner, cloning);
				auras[i] = (Aura)owner.OngoingEffect;
			}

			owner.OngoingEffect = new MultiAura(auras);
		}

		public override void Remove()
		{
			for (int i = 0; i < _auras.Count; i++)
				_auras[i].Remove();
		}

		public IEnumerator<Aura> GetEnumerator()
		{
			return _auras.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public int Count => _auras.Count;

		public Aura this[int index] => _auras[index];
	}
}
