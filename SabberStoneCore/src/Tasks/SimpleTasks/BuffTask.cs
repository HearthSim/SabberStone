//using System.Linq;
//using SabberStoneCore.Conditions;
//using SabberStoneCore.Enchants;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Tasks.SimpleTasks
//{
//	public class BuffTask : SimpleTask
//	{
//		public BuffTask(OldEnchant buff, EntityType type, SelfCondition condition = null)
//		{
//			Buff = buff;
//			Type = type;
//			Condition = condition;
//		}

//		public OldEnchant Buff { get; set; }

//		public EntityType Type { get; set; }

//		public SelfCondition Condition { get; set; }

//		public override TaskState Process()
//		{
//			var source = Source as IPlayable;
//			if (source == null || Buff == null)
//			{
//				return TaskState.STOP;
//			}
//			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);

//			if (Condition != null)
//			{
//				entities = entities.Where(p => Condition.Eval(p)).ToList();
//			}

//			//entities.ForEach(p => Buff.Activate(source.Card.Id, p.OldEnchants, p));

//			return TaskState.COMPLETE;
//		}

//		public override ISimpleTask Clone()
//		{
//			var clone = new BuffTask(Buff, Type, Condition);
//			clone.Copy(this);
//			return clone;
//		}
//	}
//}
