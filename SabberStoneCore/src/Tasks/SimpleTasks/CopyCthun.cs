using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{

	public class CopyCthun : SimpleTask
	{
		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null)
			{
				return TaskState.STOP;
			}

			if (Controller.ProxyCthun == 0)
			{
				return TaskState.STOP;
			}

			IPlayable proxyCthun = Game.IdEntityDic[Controller.ProxyCthun];

			proxyCthun.OldEnchants.ForEach(p => p.Activate(p.SourceId, source.OldEnchants, source));

			source[GameTag.TAUNT] = proxyCthun[GameTag.TAUNT];

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