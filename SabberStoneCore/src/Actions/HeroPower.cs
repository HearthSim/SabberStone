using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
    public partial class Generic
    {
        public static bool HeroPower(Controller c, ICharacter target = null)
        {
            return HeroPowerBlock.Invoke(c, target);
        }

        public static Func<Controller, ICharacter, bool> HeroPowerBlock
            => delegate(Controller c, ICharacter target)
            {
                if (!c.Hero.Power.IsPlayable || !c.Hero.Power.IsValidPlayTarget(target))
                {
                    return false;
                }

                PayPhase.Invoke(c, c.Hero.Power);

                // play block
                if (c.Game.HistoryEnabled)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.PLAY, c.Hero.Power.Id, "", 0, target?.Id ?? 0));

                var targtTxt = target != null ? $" targeting {target}" : "";
                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "HeroPowerBlock", $"Play HeroPower {c.Hero.Power}[{c.Hero.Power.Card.Id}]{targtTxt}.");

                c.Hero.Power.ApplyEnchantments(EEnchantmentActivation.SPELL, EZone.PLAY, target);

                c.Hero.Power.IsExhausted = true;
                c.HeroPowerActivationsThisTurn++;
                c.NumTimesHeroPowerUsedThisGame++;

                if (c.Game.HistoryEnabled)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

                return true;
            };
    }

}
