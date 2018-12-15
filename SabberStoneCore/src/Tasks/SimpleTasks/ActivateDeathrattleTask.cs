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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
    public class ActivateDeathrattleTask : SimpleTask
    {
	    private readonly EntityType _type;

	    public ActivateDeathrattleTask(EntityType type)
	    {
		    _type = type;
	    }

	    public override TaskState Process()
	    {
		    foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
		    {
			    p.ActivateTask(Enums.PowerActivation.DEATHRATTLE);
			    p.AppliedEnchantments?.ForEach(e =>
			    {
				    if (e.Power.DeathrattleTask == null) return;
				    ISimpleTask clone = e.Power.DeathrattleTask.Clone();
				    clone.Game = Game;
				    clone.Controller = e.Target.Controller;
				    clone.Source = e.Target;
				    clone.Target = e;

				    Game.TaskQueue.Enqueue(clone);
			    });
			    if (p.Controller.ControllerAuraEffects[Enums.GameTag.EXTRA_MINION_DEATHRATTLES_BASE] == 1)
			    {
				    p.ActivateTask(Enums.PowerActivation.DEATHRATTLE);
				    p.AppliedEnchantments?.ForEach(e =>
				    {
					    if (e.Power.DeathrattleTask == null) return;
					    ISimpleTask clone = e.Power.DeathrattleTask.Clone();
					    clone.Game = Game;
					    clone.Controller = e.Target.Controller;
					    clone.Source = e.Target;
					    clone.Target = e;

					    Game.TaskQueue.Enqueue(clone);
				    });
				}

			}

		    return TaskState.STOP;
	    }

	    public override ISimpleTask Clone()
	    {
		    return new ActivateDeathrattleTask(_type);
	    }
    }
}
