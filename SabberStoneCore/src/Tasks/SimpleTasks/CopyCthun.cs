using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class CopyCthun : SimpleTask
	{
		public override TaskState Process()
		{
			if (!(Source is IPlayable source))
				return TaskState.STOP;

			if (Controller.ProxyCthun == 0)
				return TaskState.STOP;

			IPlayable proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];


			if (Game.History)
			{
				if (source.AppliedEnchantments == null)
					source.AppliedEnchantments = new List<Enchantment>();
				
				proxyCthun.AppliedEnchantments?.ForEach(e =>
				{
					Enchantment instance = Enchantment.GetInstance(Controller, (IPlayable)Target, Target, e.Card);
					if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
					{
						instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
							instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
					}

					Source.AppliedEnchantments.Add(instance);
				});
			}

			proxyCthun.OngoingEffect?.Clone((IPlayable)Source);
			Target[GameTag.ATK] = proxyCthun[GameTag.ATK];
			Target[GameTag.HEALTH] = proxyCthun[GameTag.HEALTH];
			Target[GameTag.TAUNT] = proxyCthun[GameTag.TAUNT];

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new CopyCthun();
			clone.Copy(this);
			return clone;
		}
	}
}
