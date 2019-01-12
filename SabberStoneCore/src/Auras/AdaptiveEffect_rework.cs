using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Auras
{
	public class AdaptiveEffect_rework : IAura
	{
		private readonly Minion _owner;
		private readonly IEffect _effect;
		private readonly Func<Minion, int> _valueFunc;

		public AdaptiveEffect_rework(IEffect effect, Func<Minion, int> valueFunc)
		{
			_effect = effect;
			_valueFunc = valueFunc;
		}

		private AdaptiveEffect_rework(AdaptiveEffect_rework prototype, Minion owner)
		{
			_owner = owner;

			_effect = prototype._effect;
			_valueFunc = prototype._valueFunc;
		}

		public IPlayable Owner => _owner;
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
			IAura instance = new AdaptiveEffect_rework(this, (Minion) owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public void Clone(IPlayable clone)
		{
			throw new NotImplementedException();
		}
	}
}
