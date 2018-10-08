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

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			//	Controller Auras (OTEs)
			if (_entityType == EntityType.CONTROLLER)
			{
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source, controller, 0, 0);
				return TaskState.COMPLETE;
			}

			if (_entityType == EntityType.OP_CONTROLLER)
			{
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source,
					controller.Opponent, 0, 0);
				return TaskState.COMPLETE;
			}

			int n1, n2;
			if (stack != null)
			{
				n1 = stack.Number;
				n2 = stack.Number1;
			}
			else
			{
				n1 = 0;
				n2 = 0;
			}

			foreach (IPlayable p in IncludeTask.GetEntities(_entityType, in controller, source, target,
				stack?.Playables))
				Generic.AddEnchantmentBlock.Invoke(controller, _enchantmentCard, (IPlayable) source, p, n1, n2);

			return TaskState.COMPLETE;
		}
	}
}
