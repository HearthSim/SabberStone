using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, in controller, source, target, stack?.Playables))
				_effect.ApplyTo(p.AuraEffects);

			return TaskState.COMPLETE;
		}
	}
}
