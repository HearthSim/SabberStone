using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class CopyCthun : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			if (!(source is IPlayable playableSource))
				return TaskState.STOP;

			if (controller.ProxyCthun == 0)
				return TaskState.STOP;

			var proxyCthun = (Minion) game.IdEntityDic[controller.ProxyCthun];
			var minionTarget = (Minion) target;

			if (game.History)
			{
				if (source.AppliedEnchantments == null)
					source.AppliedEnchantments = new List<Enchantment>();

				if (proxyCthun.AppliedEnchantments != null)
					foreach (Enchantment e in proxyCthun.AppliedEnchantments)
					{
						Enchantment instance =
							Enchantment.GetInstance(in controller, minionTarget, minionTarget, e.Card);
						if (e[GameTag.TAG_SCRIPT_DATA_NUM_1] > 0)
						{
							instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = e[GameTag.TAG_SCRIPT_DATA_NUM_1];
							if (e[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
								instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = e[GameTag.TAG_SCRIPT_DATA_NUM_2];
						}
					}
			}

			proxyCthun.OngoingEffect?.Clone((IPlayable) source);

			minionTarget.AttackDamage = proxyCthun.AttackDamage;
			minionTarget.BaseHealth = proxyCthun.BaseHealth;
			minionTarget.HasTaunt = proxyCthun.HasTaunt;

			return TaskState.COMPLETE;
		}
	}
}
