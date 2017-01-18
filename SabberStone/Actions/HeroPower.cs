using System;
using System.Reflection;
using log4net;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Actions
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
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                if (!c.Hero.Power.IsPlayable || !c.Hero.Power.IsValidPlayTarget(target))
                {
                    return false;
                }

                PayPhase.Invoke(c, c.Hero.Power);

                var targtTxt = target != null ? $" targeting {target}" : "";
                log.Info($"[HeroPowerBlock] Play HeroPower {c.Hero.Power}[{c.Hero.Power.Card.Id}]{targtTxt}.");
                c.Game.PlayTaskLog.AppendLine($"[HeroPowerBlock] Play HeroPower {c.Hero.Power}[{c.Hero.Power.Card.Id}]{targtTxt}.");

                c.Hero.Power.ApplyEnchantments(EnchantmentActivation.SPELL, HearthDb.Enums.Zone.PLAY, target);

                c.Hero.Power.IsExhausted = true;
                c.HeroPowerActivationsThisTurn++;
                c.NumTimesHeroPowerUsedThisGame++;

                return true;
            };
    }

}
