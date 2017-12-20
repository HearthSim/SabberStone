using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetNativeGameTagTask : SimpleTask
	{
		public GetNativeGameTagTask(GameTag tag, EntityType entityType, bool selfBuffs, int numberIndex = 0)
		{
			Tag = tag;
			Type = entityType;
			SelfBuffs = selfBuffs;
			_index = numberIndex;
		}

		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public bool SelfBuffs { get; set; }
		private readonly int _index;

		public override TaskState Process()
		{
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			if (entities.Count != 1)
			{
				return TaskState.STOP;
			}

			int num = ((Entity)entities[0]).GetNativeGameTag(Tag);

			if (SelfBuffs)
			{
				entities[0].Enchants.ForEach(p => num = p.Apply((Entity)entities[0], Tag, num));
			}

			switch (_index)
			{
				case 0:
					Number = num;
					break;
				case 1:
					Number1 = num;
					break;
				case 2:
					Number2 = num;
					break;
				case 3:
					Number3 = num;
					break;
				case 4:
					Number4 = num;
					break;
				default:
					Number = num;
					break;
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetNativeGameTagTask(Tag, Type, SelfBuffs, _index);
			clone.Copy(this);
			return clone;
		}
	}
}
