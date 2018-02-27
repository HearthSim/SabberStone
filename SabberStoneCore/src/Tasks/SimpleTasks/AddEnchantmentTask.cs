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
