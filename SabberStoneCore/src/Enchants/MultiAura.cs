using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public class MultiAura : IAura, IReadOnlyList<Aura>
	{
		private readonly IReadOnlyList<Aura> _auras;

		public IPlayable Owner { get; set; }
		public bool On { get; set; } = true;

		public MultiAura(params Aura[] auras)
		{
			_auras = auras;
		}

		public void Update()
		{
			if (!On)
				Owner.Game.Auras.Remove(this);
			for (int i = 0; i < _auras.Count; i++)
				_auras[i].Update();
		}

		public void Remove()
		{
			On = false;
			Owner.OngoingEffect = null;
			for (int i = 0; i < _auras.Count; i++)
				_auras[i].Remove();
		}

		void IAura.Activate(IPlayable owner)
		{
			ActivateInternal(owner);
		}

		public void Clone(IPlayable clone)
		{
			ActivateInternal(clone, true);
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

		public override string ToString()
		{
			var sb = new StringBuilder("[MA:");
			foreach (Aura a in _auras)
				sb.Append($"{{{a}}}");
			sb.Append("]");
			return sb.ToString();
		}

		private void ActivateInternal(IPlayable owner, bool cloning = false)
		{
			Aura[] auras = new Aura[_auras.Count];

			for (int i = 0; i < _auras.Count; i++)
			{
				_auras[i].Activate(owner, cloning);
				var inst = (Aura)owner.OngoingEffect;
				auras[i] = inst;
				owner.Game.Auras.RemoveAt(owner.Game.Auras.Count - 1);
			}

			var instance = new MultiAura(auras)
			{
				Owner = owner,
			};
			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}


	}
}
