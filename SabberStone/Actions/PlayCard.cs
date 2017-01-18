using System;
using System.Collections.Generic;
using System.Reflection;
using log4net;
using SabberStone.Enchants;
using SabberStone.Model;

namespace SabberStone.Actions
{
    public partial class Generic
    {
        public static bool PlayCard(Controller c, IPlayable source, ICharacter target = null, int zonePosition = -1, int chooseOne = 0)
        {
            return PlayCardBlock.Invoke(c, source, target, zonePosition, chooseOne);
        }

        public static Func<Controller, IPlayable, ICharacter, int, int, bool> PlayCardBlock
            => delegate (Controller c, IPlayable source, ICharacter target, int zonePosition, int chooseOne)
            {
                if (!PrePlayPhase.Invoke(c, source, target, zonePosition, chooseOne))
                {
                    return false;
                }

                if (!PayPhase.Invoke(c, source))
                {
                    return false;
                }

                c.NumCardsPlayedThisTurn++;

                c.LastCardPlayed = source.Id;

                if (source is Minion)
                {
                    PlayMinion.Invoke(c, (Minion)source, target, zonePosition);
                }
                else if (source is Weapon)
                {
                    // - OnPlay Phase --> OnPlay Trigger (Illidan)
                    //   (death processing, aura updates)
                    OnPlayTrigger.Invoke(c, (Weapon)source);

                    if (!RemoveFromZone.Invoke(c, source))
                        return false;

                    PlayWeapon.Invoke(c, (Weapon)source);
                }
                else if (source is Spell)
                {

                    // - OnPlay Phase --> OnPlay Trigger (Illidan)
                    //   (death processing, aura updates)
                    OnPlayTrigger.Invoke(c, (Spell)source);

                    // remove from hand zone
                    if (!RemoveFromZone.Invoke(c, source))
                        return false;

                    PlaySpell.Invoke(c, (Spell)source, target);
                }

                c.NumOptionsPlayedThisTurn++;

                c.IsComboActive = true;

                return true;
            };

        public static Func<Controller, IPlayable, ICharacter, int, int, bool> PrePlayPhase
            => delegate(Controller c, IPlayable source, ICharacter target, int zonePosition, int chooseOne)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                // can't play because we got already board full
                if (source is Minion && c.Board.IsFull)
                {
                    log.Info($"Board has already {c.Board.MaxSize} minions.");
                    c.Game.PlayTaskLog.AppendLine($"Board has already {c.Board.MaxSize} minions.");
                    return false;
                }

                // TODO ChooseOne implementation: rework on it, later!
                // set choose one option
                source.ChooseOneOption = chooseOne;
                if (source.ChooseOne && chooseOne == 0)
                {
                    log.Info($"Choose One, no option set for this card.");
                    c.Game.PlayTaskLog.AppendLine($"Choose One, no option set for this card.");
                    return false;
                }

                // check if we can play this card and the target is valid
                if (!source.IsPlayable || !source.IsValidPlayTarget(target))
                {
                    return false;
                }

                // copy choose one enchantment to the actual source
                if (source.ChooseOne)
                {
                    source.Enchantments = source.RefCard.Enchantments;
                }

                // replace enchantments with the no combo or combo one ..
                if (source.Combo)
                {
                    if (source.Enchantments.Count > 1)
                    {
                        source.Enchantments = new List<Enchantment> {source.Enchantments[c.IsComboActive ? 1 : 0]};
                    }
                    else if (c.IsComboActive && source.Enchantments.Count > 0)
                    {
                        source.Enchantments = new List<Enchantment> {source.Enchantments[0]};
                    }
                    else
                    {
                        source.Enchantments = new List<Enchantment> {};
                    }
                }

                return true;
            };

        public static Func<Controller, IPlayable, bool> PayPhase
            => delegate(Controller c, IPlayable source)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                c.OverloadOwed += source.Overload;
                var cost = source.Cost;
                if (cost > 0)
                {
                    var tempUsed = Math.Min(c.TemporaryMana, cost);
                    c.TemporaryMana -= tempUsed;
                    c.UsedMana += cost - tempUsed;
                    c.TotalManaSpentThisGame += cost;
                }
                log.Info($"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
                c.Game.PlayTaskLog.AppendLine($"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
                return true;
            };

        public static Func<Controller, Minion, ICharacter, int, bool> PlayMinion
            => delegate(Controller c, Minion minion, ICharacter target, int zonePosition)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                // remove from hand zone
                if (!RemoveFromZone.Invoke(c, minion))
                    return false;

                if (!minion.HasCharge)
                    minion.IsExhausted = true;

                log.Info($"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
                         $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");
                c.Game.PlayTaskLog.AppendLine($"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
                         $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");

                c.Board.Add(minion, zonePosition);

                // - OnPlay Phase --> OnPlay Trigger (Illidan)
                //   (death processing, aura updates)
                OnPlayTrigger.Invoke(c, minion);

                // - BattleCry Phase --> Battle Cry Resolves
                //   (death processing, aura updates)
                minion.ApplyEnchantments(EnchantmentActivation.BATTLECRY, HearthDb.Enums.Zone.PLAY, target);
                c.Game.DeathProcessingAndAuraUpdate();

                // - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
                //   (death processing, aura updates)
                minion.JustPlayed = false;
                c.Game.DeathProcessingAndAuraUpdate();

                // - After Summon Phase --> After Summon Trigger
                //   (death processing, aura updates)
                AfterSummonTrigger.Invoke(c, minion);

                c.NumMinionsPlayedThisTurn++;

                return true;
            };

        public static Func<Controller, Spell, ICharacter, bool> PlaySpell
            => delegate(Controller c, Spell spell, ICharacter target)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                log.Info($"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");
                c.Game.PlayTaskLog.AppendLine($"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

                // trigger Spellbender  Phase
                log.Debug($"# After Spellbender Phase ### (not implemented)");
                c.Game.PlayTaskLog.AppendLine($"# After Spellbender Phase ### (not implemented)");

                // trigger SpellText Phase
                log.Debug($"# After SpellText Phase ###");
                c.Game.PlayTaskLog.AppendLine($"# After SpellText Phase ###");
                if (spell.IsSecret)
                {
                    spell.ApplyEnchantments(EnchantmentActivation.SECRET, HearthDb.Enums.Zone.PLAY);
                    c.Secrets.Add(spell);
                }
                else
                {
                    spell.ApplyEnchantments(EnchantmentActivation.SPELL, HearthDb.Enums.Zone.PLAY, target);
                    c.Graveyard.Add(spell);
                }
                c.Game.DeathProcessingAndAuraUpdate();

                // trigger After Play Phase
                log.Debug($"# After Play Phase ###");
                c.Game.PlayTaskLog.AppendLine($"# After Play Phase ###");
                spell.JustPlayed = false;
                c.Game.DeathProcessingAndAuraUpdate();

                return true;
            };

        public static Func<Controller, Weapon, bool> PlayWeapon
            => delegate(Controller c, Weapon weapon)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

                c.Hero.AddWeapon(weapon);

                log.Info($"{c.Hero} gets Weapon {c.Hero.Weapon}.");
                c.Game.PlayTaskLog.AppendLine($"{c.Hero} gets Weapon {c.Hero.Weapon}.");

                // activate battlecry
                weapon.ApplyEnchantments(EnchantmentActivation.WEAPON, HearthDb.Enums.Zone.PLAY);
                weapon.ApplyEnchantments(EnchantmentActivation.BATTLECRY, HearthDb.Enums.Zone.PLAY);

                return true;
            };

        private static Action<Controller, IPlayable> OnPlayTrigger
            => delegate(Controller c, IPlayable playable)
            {
                playable.JustPlayed = true;
                c.Game.DeathProcessingAndAuraUpdate();
            };
    }
}