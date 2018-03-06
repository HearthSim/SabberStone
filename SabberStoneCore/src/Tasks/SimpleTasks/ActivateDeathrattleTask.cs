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
			    if (p.Controller.ControllerAuraEffects[Enums.GameTag.EXTRA_DEATHRATTLES] == 1)
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
