using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class BuffStealthTask : SimpleTask
	{
		public BuffStealthTask(EntityType type)
		{
			Type = type;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			IncludeTask.GetEntites(Type, Controller, Source, Target, Playables).ForEach(p =>
			{
				var character = p as ICharacter;
				if (character == null)
					return;
				var buff = new BuffTask(Buffs.StealthTurn(character.NumAttacksThisTurn), Type);
				buff.Copy(this);
				buff.Process();
			});

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new BuffStealthTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}