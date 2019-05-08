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
using System.Collections;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Triggers
{
	public class MultiTrigger : Trigger, IReadOnlyList<Trigger>
	{
		private readonly IReadOnlyList<Trigger> _triggers;

		public MultiTrigger(params Trigger[] triggers) : base(TriggerType.MULTITRIGGER)
		{
			//for (int i = 0; i < triggers.Length; i++)
			//	triggers[i].IsAncillaryTrigger = true;
			_triggers = triggers;
		}

		private MultiTrigger(Trigger[] triggers, MultiTrigger protoType, IPlayable owner) : base(protoType, owner)
		{
			_triggers = triggers;
		}

		public override Trigger Activate(IPlayable source, TriggerActivation activation = TriggerActivation.PLAY, bool cloning = false, bool asAncillary = false)
		{
			if (source.ActivatedTrigger != null && !IsAncillaryTrigger)
				throw new Exceptions.EntityException($"{source} already has an activated trigger.");

			var triggers = new Trigger[_triggers.Count];

			bool flag = false;
			for (int i = 0; i < triggers.Length; i++)
			{
				triggers[i] = _triggers[i]?.Activate(source, activation, cloning, true);
				if (triggers[i] != null)
					flag = true;
			}

			if (!flag) return null;

			var instance = new MultiTrigger(triggers, this, source);

			if (!IsAncillaryTrigger)
				source.ActivatedTrigger = instance;

			return instance;
		}

		public int Count => _triggers.Count;

		public Trigger this[int index] => _triggers[index];

		public override void Remove()
		{
			for (int i = 0; i < _triggers.Count; i++)
				_triggers[i]?.Remove();

			if (!IsAncillaryTrigger)
				_owner.ActivatedTrigger = null;
		}

		public IEnumerator<Trigger> GetEnumerator()
		{
			return _triggers.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
