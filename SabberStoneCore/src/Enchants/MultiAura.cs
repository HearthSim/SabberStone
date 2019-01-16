#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
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
