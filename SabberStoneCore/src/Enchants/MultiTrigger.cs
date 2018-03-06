using System.Collections;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
    public class MultiTrigger : Trigger, IReadOnlyList<Trigger>
    {
		private readonly IReadOnlyList<Trigger> _triggers;

		public MultiTrigger(params Trigger[] triggers) : base(TriggerType.MULTITRIGGER)
	    {
			for (int i = 0; i < triggers.Length; i++)
				triggers[i].IsAncillaryTrigger = true;
		    _triggers = triggers;
	    }

	    private MultiTrigger(Trigger[] triggers, MultiTrigger protoType, IPlayable owner) : base(protoType, owner)
	    {
			_triggers = triggers;
	    }

		public override Trigger Activate(IPlayable source, TriggerActivation activation = TriggerActivation.PLAY, bool cloning = false)
		{
			if (source.ActivatedTrigger != null && !IsAncillaryTrigger)
				throw new Exceptions.EntityException($"{source} already has an activatd trigger.");

			Trigger[] triggers = new Trigger[_triggers.Count];

			bool flag = false;
			for (int i = 0; i < _triggers.Count; i++)
			{
				triggers[i] = _triggers[i]?.Activate(source, activation, cloning);
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
