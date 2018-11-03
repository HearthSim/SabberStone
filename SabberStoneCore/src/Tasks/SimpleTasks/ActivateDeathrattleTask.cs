using SabberStoneCore.Enums;
using SabberStoneCore.Model;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, controller, source, target, stack?.Playables))
			{
				p.ActivateTask(PowerActivation.DEATHRATTLE);
				if (p.AppliedEnchantments != null)
					foreach (Enchantment e in p.AppliedEnchantments)
					{
						ISimpleTask task = e.Power.DeathrattleTask;
						if (task == null) continue;
						game.TaskQueue.Enqueue(in task, e.Target.Controller, e.Target, e);
					}

				;
				if (p.Controller.ControllerAuraEffects[GameTag.EXTRA_DEATHRATTLES] == 1)
				{
					p.ActivateTask(PowerActivation.DEATHRATTLE);
					if (p.AppliedEnchantments != null)
						foreach (Enchantment e in p.AppliedEnchantments)
						{
							ISimpleTask task = e.Power.DeathrattleTask;
							if (task == null) continue;
							game.TaskQueue.Enqueue(in task, e.Target.Controller, e.Target, e);
						}
				}
			}

			return TaskState.COMPLETE;
		}
	}
}
