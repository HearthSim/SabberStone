#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class TransformCopyTask : SimpleTask
    {
	    private readonly bool _addToStack;

	    public TransformCopyTask(bool addToStack = false)
	    {
		    _addToStack = addToStack;
	    }

	    public override TaskState Process()
	    {
			Minion target = (Minion)Target;
			if (target == null)
				return TaskState.STOP;

			Minion source = (Minion)Source;
			if (source.Zone?.Type != Zone.PLAY)
				return TaskState.STOP;

		    var tags = new EntityData.Data
		    {
			    {GameTag.CREATOR, Source.Id},
		    };
		    if (Game.History)
			    tags.Add(GameTag.PREMIUM, target[GameTag.PREMIUM]);

		    Minion copy = (Minion) Entity.FromCard(Controller, target.Card, tags);

		    Trigger trigger = target.ActivatedTrigger;
		    IAura aura = target.OngoingEffect;

			// LINKED_ENTITY
			if (source == Game.CurrentEventData.EventSource)
				Game.CurrentEventData.EventSource = copy;
		    source.Controller.BoardZone.Replace(source, copy);

			// Copy Enchantments
			if (target.AppliedEnchantments != null)
		    {
			    foreach (Enchantment e in target.AppliedEnchantments)
			    {
				    Enchantment instance = Enchantment.GetInstance(Controller, copy, copy, e.Card);
				    if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
					{
						instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
							instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
					}
				}
		    }

			foreach (KeyValuePair<GameTag, int> kvp in target._data.Tags)
			{
				switch (kvp.Key)
				{
					case GameTag.ENTITY_ID:
					case GameTag.CONTROLLER:
					case GameTag.ZONE:
					case GameTag.ZONE_POSITION:
					case GameTag.CREATOR:
					case GameTag.PREMIUM:
					case GameTag.EXHAUSTED:
						continue;
					default:
						copy._data.Tags.Add(kvp.Key, kvp.Value);
						break;
				}
			}

			if (aura != null && copy.OngoingEffect == null)
				aura.Clone(copy);

			if (!target.HasCharge)
				copy.IsExhausted = true;

		    if (_addToStack)
			    Playables = new List<IPlayable> {copy};

			return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			return new TransformCopyTask(_addToStack);
		}
    }
}
