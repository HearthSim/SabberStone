using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class MagneticTask : SimpleTask
	{
		public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
			in TaskStack stack = null)
		{
			var s = (Minion) source;

			if (s == null || s[GameTag.MODULAR] == 0)
			{
				game.Log(LogLevel.ERROR, BlockType.POWER, "Magnetic", $"{source}'s not a Magnetic Minion");
				return TaskState.STOP;
			}

			Minion t;
			int pos = s.ZonePosition;
			if (pos < s.Zone.Count - 1)
				t = s.Controller.BoardZone[pos + 1];
			else
				return TaskState.STOP;

			if (t.Race != Race.MECHANICAL)
				return TaskState.STOP;

			if (game.History)
				s[GameTag.TAG_SCRIPT_DATA_NUM_1] = t.Id;

			Generic.AddEnchantmentBlock.Invoke(controller, Cards.FromId(s.Card.Id + "e"), s, t, s.AttackDamage,
				s.BaseHealth, false);

			// Aggregate triggers
			if (s.Power.Trigger != null)
			{
				if (t.ActivatedTrigger != null)
				{
					var aggregatedTrigger = new MultiTrigger(t.ActivatedTrigger, s.Power.Trigger);
					t.ActivatedTrigger.Remove();
					t.ActivatedTrigger = null;
					aggregatedTrigger.Activate(t);
				}
				else
				{
					s.Power.Trigger.Activate(t);
				}
			}

			// Tag 871 ??
			// Tag 1037 ??

			// Moves source to Setaside
			s.Controller.SetasideZone.Add(s.Zone.Remove(s));

			return TaskState.COMPLETE;
		}
	}
}
