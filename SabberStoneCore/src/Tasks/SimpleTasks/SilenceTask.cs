using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SilenceTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public SilenceTask(EntityType type)
		{
			Type = type;
		}
		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count > 0)
			{
				entities.ForEach(p =>
				{
					var minion = p as Minion;
					minion.Silence();

					minion.Enchants.ForEach(z => z.IsEnabled());
					minion.Triggers.ForEach(z => z.IsEnabled());
				});

				Game.AuraUpdate();

				entities.ForEach(p =>
				{
					((Minion)p).IsSilenced = false;
				});
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new SilenceTask(Type);
			clone.Copy(this);
			return clone;
		}
	}
}
