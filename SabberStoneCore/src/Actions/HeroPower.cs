using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static bool HeroPower(Controller c, ICharacter target = null, int chooseOne = 0, bool skipPrePhase = false)
		{
			return HeroPowerBlock.Invoke(c, target, chooseOne, skipPrePhase);
		}

		public static Func<Controller, ICharacter, int, bool, bool> HeroPowerBlock
			=> delegate (Controller c, ICharacter target, int chooseOne, bool skipPrePhase)
			{
				if (!skipPrePhase)
					if (!c.Hero.HeroPower.IsPlayable || !c.Hero.HeroPower.IsValidPlayTarget(target))
						return false;

				PayPhase.Invoke(c, c.Hero.HeroPower);

				if (target != null)
					Trigger.ValidateTriggers(c.Game, c.Hero.HeroPower, SequenceType.Target);

				// play block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.PLAY, c.Hero.HeroPower.Id, "", 0, target?.Id ?? 0));

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "HeroPowerBlock", !c.Game.Logging? "":$"Play HeroPower {c.Hero.HeroPower}[{c.Hero.HeroPower.Card.Id}]{(target != null ? $" targeting {target}" : "")}.");

				c.Game.TaskQueue.StartEvent();
				c.Hero.HeroPower.ActivateTask(PowerActivation.POWER, target, chooseOne);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				c.Hero.HeroPower.IsExhausted = true;
				c.HeroPowerActivationsThisTurn++;
				c.NumTimesHeroPowerUsedThisGame++;

				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnInspireTrigger(target);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
