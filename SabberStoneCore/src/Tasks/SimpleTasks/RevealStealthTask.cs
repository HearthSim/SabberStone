using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	/// <summary>  
	///  Reveals the target(s), effectively removing their stealth attribute.  
	/// </summary> 
	public class RevealStealthTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public RevealStealthTask(EntityType type)
		{
			Type = type;
		}
		public override TaskState Process()
		{
			//System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			//entities.ForEach(p =>
			foreach (IPlayable p in IncludeTask.GetEntities(Type, Controller, Source, Target, Playables))
			{
				if (!(p is Minion minion))
					continue;
				minion.HasStealth = false;
			};

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new RevealStealthTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
