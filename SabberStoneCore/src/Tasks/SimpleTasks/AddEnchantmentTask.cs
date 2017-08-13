using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class AddEnchantmentTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public Enchantment Enchantment { get; set; }

		public bool Activate { get; set; }

		public AddEnchantmentTask(EntityType type, Enchantment enchantment, bool activate = false)
		{
			Type = type;
			Enchantment = enchantment;
			Activate = activate;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			List<IPlayable> entities = IncludeTask.GetEntites(Type, Controller, Source, Target, Playables);
			entities.ForEach(p =>
			{
				var minion = p as Minion;
				if (minion != null)
				{

					minion.HasDeathrattle = Enchantment.Activation == EnchantmentActivation.DEATHRATTLE ? true : false;
					minion.Enchantments.Add(Enchantment);
					if (Activate)
					{
						Enchantment.Activate(Controller, minion);
					}
				}
			});
			return TaskState.COMPLETE;
		}

		public override ISimpleTask InternalClone()
		{
			return new AddEnchantmentTask(Type, Enchantment, Activate);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}