namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CountTask : SimpleTask
	{
		private readonly int _numberIndex;

		public CountTask(EntityType type, int numberIndex = 0)
		{
			Type = type;
			_numberIndex = numberIndex;
		}

		public EntityType Type { get; set; }

		public override TaskState Process()
		{
			switch (_numberIndex)
			{
				case 0:
					Number = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 1:
					Number1 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 2:
					Number2 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 3:
					Number3 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				case 4:
					Number4 = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables).Count;
					break;
				default:
					throw new System.ArgumentOutOfRangeException("Number Index must be in range [0, 4]");
			}
			
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new CountTask(Type, _numberIndex);
			clone.Copy(this);
			return clone;
		}
	}
}
