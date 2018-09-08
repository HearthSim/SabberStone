using SabberStoneCore.Enums;
using System.Collections.Generic;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetGameTagTask : SimpleTask
	{
		public GetGameTagTask(GameTag tag, EntityType entityType, int entityIndex = 0, int numberIndex = 0)
		{
			Tag = tag;
			Type = entityType;
			EntityIndex = entityIndex;
			NumberIndex = numberIndex;
		}

		public GameTag Tag { get; set; }
		public EntityType Type { get; set; }
		public int EntityIndex { get; set; }
		public int NumberIndex { get; set; }

		public override TaskState Process()
		{
			IList<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			if (entities == null || entities.Count == 0)
			{
				return TaskState.STOP;
			}

			int value;
			if (entities[EntityIndex] is Character c)
			{
				switch (Tag)
				{
					case GameTag.ATK:
						value = c.AttackDamage;
						break;
					case GameTag.HEALTH:
						value = c.BaseHealth;
						break;
					case GameTag.DAMAGE:
						value = c.Damage;
						break;
					default:
						value = c[Tag];
						break;
				}
			}
			else
				value = entities[EntityIndex][Tag];


			if (NumberIndex == 0)
			{
				Number = value;
			}
			else if (entities.Count > EntityIndex)
			{
				switch (NumberIndex)
				{
					case 1:
						Number1 = value;
						break;
					case 2:
						Number2 = value;
						break;
					case 3:
						Number3 = value;
						break;
					case 4:
						Number4 = value;
						break;
				}
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new GetGameTagTask(Tag, Type, EntityIndex, NumberIndex);
			clone.Copy(this);
			return clone;
		}
	}

	/// <summary>
	/// Gets number of the current event and stores it to the stack.
	/// (e.g. the amount damage dealt or heal taken)
	/// </summary>
	public class GetEventNumberTask : SimpleTask
	{
		private readonly int _numberIndex;

		public GetEventNumberTask(int numberIndex = 0)
		{
			_numberIndex = numberIndex;
		}

		public override TaskState Process()
		{
			switch (_numberIndex)
			{
				case 0:
					Number = Game.CurrentEventData?.EventNumber ?? 0;
					break;
				case 1:
					Number1 = Game.CurrentEventData?.EventNumber ?? 0;
					break;
				case 2:
					Number2 = Game.CurrentEventData?.EventNumber ?? 0;
					break;
				case 3:
					Number3 = Game.CurrentEventData?.EventNumber ?? 0;
					break;
				case 4:
					Number4 = Game.CurrentEventData?.EventNumber ?? 0;
					break;
				default:
					throw new System.ArgumentOutOfRangeException();
			}
			
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return new GetEventNumberTask(_numberIndex);
		}
	}
}
