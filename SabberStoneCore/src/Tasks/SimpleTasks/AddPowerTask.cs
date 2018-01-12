using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddPowerTask : SimpleTask
	{
		public AddPowerTask(EntityType type, Power power, bool activate = false)
		{
			Type = type;
			Power = power;
			Activate = activate;
		}

		public EntityType Type { get; set; }

		public Power Power { get; set; }

		public bool Activate { get; set; }

		public override TaskState Process()
		{
			System.Collections.Generic.List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var minion = p as Minion;
				if (minion != null)
				{
					minion.HasDeathrattle = Power.Activation == PowerActivation.DEATHRATTLE ? true : false;
					//if (minion.Powers == null)
					//	minion.Powers = new System.Collections.Generic.List<Power> { Power };
					//else
					//	minion.Powers.Add(Power);
					if (Activate)
					{
						//Power.Activate(Controller, minion);
					}
				}
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new AddPowerTask(Type, Power, Activate);
			clone.Copy(this);
			return clone;
		}
	}
}
