using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;

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

                var targtTxt = target != null ? $" targeting {target}" : "";
                c.Game.Log(LogLevel.INFO, BlockType.ACTION, "HeroPowerBlock", $"Play HeroPower {c.Hero.Power}[{c.Hero.Power.Card.Id}]{targtTxt}.");

                c.Hero.Power.ApplyEnchantments(EnchantmentActivation.SPELL, Zone.PLAY, target);

                c.Hero.Power.IsExhausted = true;
                c.HeroPowerActivationsThisTurn++;
                c.NumTimesHeroPowerUsedThisGame++;

                return true;
            };
    }

}
