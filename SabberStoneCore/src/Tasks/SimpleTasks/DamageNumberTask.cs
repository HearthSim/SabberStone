using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class DamageNumberTask : SimpleTask
	{
		public DamageNumberTask(EntityType type, bool spellDmg = false)
		{
			Type = type;
			SpellDmg = spellDmg;
		}

		public EntityType Type { get; set; }

		public bool SpellDmg { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (stack.Number < 1) return TaskState.STOP;


			foreach (IPlayable p in IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables))
				Generic.DamageCharFunc.Invoke(source as IPlayable, p as ICharacter, stack.Number, SpellDmg);

			return TaskState.COMPLETE;
		}
	}
}
