using System;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static bool HeroPower(Controller c, ICharacter target = null)
		{
			return HeroPowerBlock.Invoke(c, target);
		}

		public static Func<Controller, ICharacter, bool> HeroPowerBlock
			=> delegate (Controller c, ICharacter target)
			{
				if (!c.Hero.Power.IsPlayable || !c.Hero.Power.IsValidPlayTarget(target))
				{
					return false;
				}

				PayPhase.Invoke(c, c.Hero.Power);

				// play block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.PLAY, c.Hero.Power.Id, "", 0, target?.Id ?? 0));

				string targtTxt = target != null ? $" targeting {target}" : "";
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "HeroPowerBlock", !c.Game.Logging? "":$"Play HeroPower {c.Hero.Power}[{c.Hero.Power.Card.Id}]{targtTxt}.");

				c.Hero.Power.ApplyEnchantments(EnchantmentActivation.SPELL, Zone.PLAY, target);

				c.Hero.Power.IsExhausted = true;
				c.HeroPowerActivationsThisTurn++;
				c.NumTimesHeroPowerUsedThisGame++;

				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
