using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DestroyTask : SimpleTask
	{
		private EntityType _type;
		private readonly bool _forcedDeathPhase;

		public DestroyTask(EntityType entityType, bool forcedDeathPhase = false)
		{
			_type = entityType;
			_forcedDeathPhase = false;
		}

		public override TaskState Process()
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, Controller, Source, Target, Playables))
				p.Destroy();

			if (_forcedDeathPhase)
			{
				Game.DeathProcessingAndAuraUpdate();
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new DestroyTask(_type, _forcedDeathPhase);
			clone.Copy(this);
			return clone;
		}
	}
}
