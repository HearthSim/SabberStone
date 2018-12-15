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
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class AddAuraEffect : SimpleTask
    {
		private readonly Effect _effect;
		private readonly EntityType _type;

	    public AddAuraEffect(Effect effect, EntityType entityType)
	    {
			_effect = effect;
		    _type = entityType;
	    }

	    public override TaskState Process()
	    {
		    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
			    _effect.Apply(p.AuraEffects);

		    return TaskState.COMPLETE;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new AddAuraEffect(_effect, _type);
	    }
    }
}
