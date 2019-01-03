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
		private readonly bool _useEntityId;

		public AddEnchantmentTask(string enchantmentId, EntityType entityType, bool useScriptTag = false, bool useEntityId = false)
		{
			_enchantmentCard = Cards.FromId(enchantmentId);
			_entityType = entityType;
			_useScriptTag = useScriptTag;
			_useEntityId = useEntityId;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			int n1 = stack?.Number ?? 0;
			int n2 = stack?.Number1 ?? 0;

			//	Controller Auras (OTEs)
			if (_entityType == EntityType.CONTROLLER)
			{
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source, controller, n1, n2, _useEntityId);
				return TaskState.COMPLETE;
			}

			if (_entityType == EntityType.OP_CONTROLLER)
			{
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source,
					controller.Opponent, n1, n2, _useEntityId);
				return TaskState.COMPLETE;
			}

			foreach (IPlayable p in IncludeTask.GetEntities(_entityType, in controller, source, target,
				stack?.Playables))
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source, p, n1, n2, _useEntityId);

			return TaskState.COMPLETE;
		}
	}
}
