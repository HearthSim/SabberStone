using SabberStoneCore.Model.Entities;

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
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);

			if (entities.Count > 0)
			{
				entities.ForEach(p =>
				{
					((Minion)p).Silence();
				});

				foreach (Minion minion in Game.Player1.BoardZone)
					minion.Enchants.ForEach(p => p.IsEnabled());
				foreach (Minion minion in Game.Player2.BoardZone)
					minion.Enchants.ForEach(p => p.IsEnabled());
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
