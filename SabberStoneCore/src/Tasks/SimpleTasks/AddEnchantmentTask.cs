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
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddEnchantmentTask : SimpleTask
    {
	    private readonly Card _enchantmentCard;
		private readonly EntityType _entityType;
	    private readonly bool _useScriptTag;

	    public AddEnchantmentTask(Card enchantmentCard, EntityType entityType, bool useScriptTag = false)
	    {
		    _enchantmentCard = enchantmentCard;
		    _entityType = entityType;
		    _useScriptTag = useScriptTag;
		}

	    public AddEnchantmentTask(string enchantmentId, EntityType entityType, bool useScriptTag = false)
	    {
		    _enchantmentCard = Cards.FromId(enchantmentId);
		    _entityType = entityType;
		    _useScriptTag = useScriptTag;
	    }

		public override TaskState Process()
	    {
			//	Controller Auras (OTEs)
		    if (_entityType == EntityType.CONTROLLER)
			{
				Generic.AddEnchantmentBlock.Invoke(Controller, _enchantmentCard, (IPlayable) Source, Controller, 0, 0);
				return TaskState.COMPLETE;
			}
			if (_entityType == EntityType.OP_CONTROLLER)
		    {
			    Generic.AddEnchantmentBlock.Invoke(Controller, _enchantmentCard, (IPlayable)Source, Controller.Opponent, 0, 0);
			    return TaskState.COMPLETE;
			}

		    foreach (IPlayable p in IncludeTask.GetEntities(_entityType, Controller, Source, Target, Playables))
		    {
			    Generic.AddEnchantmentBlock.Invoke(Controller, _enchantmentCard, (IPlayable) Source, p, Number, Number1);
		    }

		    return TaskState.COMPLETE;
	    }

		public override ISimpleTask Clone()
		{
			var clone = new AddEnchantmentTask(_enchantmentCard, _entityType, _useScriptTag);
			return clone;
		}
	}
}
