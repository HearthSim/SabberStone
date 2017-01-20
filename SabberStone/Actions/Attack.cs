using System;
using System.Reflection;
using HearthDb.Enums;
using log4net;
using SabberStone.Model;

namespace SabberStone.Actions
{
    public partial class Generic
    {
        public static Func<Controller, ICharacter, ICharacter, bool> AttackBlock
            => delegate(Controller c, ICharacter source, ICharacter target)
            {
                if (!PreAttackPhase.Invoke(c, source, target))
                    return false;
                if (!OnAttackTrigger.Invoke(c, source, target))
                    return false;
                if (!AttackPhase.Invoke(c, source))
                    return false;
                return true;
            };

        private static Func<Controller, ICharacter, ICharacter, bool> PreAttackPhase
            => delegate(Controller c, ICharacter source, ICharacter target)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                if (c != source.Controller || c == target.Controller)
                {
                    log.Info("[PreAttackPhase] wrong controller in phase.");
                    c.Game.PlayTaskLog.AppendLine($"[PreAttackPhase] wrong controller in phase.");
                    return false;
                }
                if (!source.CanAttack || !source.IsValidAttackTarget(target))
                {
                    log.Info("[PreAttackPhase] can't attack with this card.");
                    c.Game.PlayTaskLog.AppendLine("[PreAttackPhase] can't attack with this card.");
                    return false;
                }
                var hero = source as Hero;
                log.Info(
                    $"[PreAttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
                    $"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}is attacking " +
                    $"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
                c.Game.PlayTaskLog.AppendLine($"[PreAttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
                    $"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}is attacking " +
                    $"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
                // TODO need to be manipulated for 50% chance to attack  someone else 
                source.ProposedAttacker = source.Id;
                source.ProposedDefender = target.Id;

                return true;
            };

        private static Func<Controller, ICharacter, ICharacter, bool> OnAttackTrigger
            => delegate(Controller c, ICharacter source, ICharacter target)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                source.IsAttacking = true;
                target.IsDefending = true;
                c.Game.DeathProcessingAndAuraUpdate();
                if (source.IsDead || target.IsDead)
                {
                    log.Info("[OnAttackTrigger] Oh shizzle, something died to the shizzeling of triggering ...");
                    c.Game.PlayTaskLog.AppendLine("[OnAttackTrigger] Oh shizzle, something died to the shizzeling of triggering ...");
                    return false;
                }
                return true;
            };

        private static Func<Controller, ICharacter, bool> AttackPhase
            => delegate(Controller c, ICharacter source)
            {
                var log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                var hero = source as Hero;
                var minion = source as Minion;
                source.ProposedAttacker = source.Id;
                var target = c.Game.IdEntityDic[source.ProposedDefender] as ICharacter;
                if (target == null)
                {
                    log.Info($"[AttackPhase] target wasn't found by proposed defender call.");
                    c.Game.PlayTaskLog.AppendLine($"[AttackPhase] target wasn't found by proposed defender call.");
                    return false;
                }
                c.Game.Step = Step.MAIN_COMBAT;

                // Save defender's attack as it might change after being damaged (e.g. enrage)
                var targetHero = target as Hero;
                var targetAttack = targetHero != null ? 0 : target.AttackDamage;
                var sourceAttack = hero?.TotalAttackDamage ?? source.AttackDamage;

                var targetDamaged = target.TakeDamage(source, sourceAttack);

                // freeze target if attacker is freezer
                if (targetDamaged && minion != null && minion.Freeze)
                    target.IsFrozen = true;

                // ignore damage from defenders with 0 attack
                if (targetAttack > 0)
                {
                    var sourceDamaged = source.TakeDamage(target, targetAttack);

                    // freeze source if defender is freezer
                    var targetMinion = target as Minion;
                    if (sourceDamaged && targetMinion != null && targetMinion.Freeze)
                        source.IsFrozen = true;
                }

                if (minion != null && minion.HasStealth)
                {
                    minion.HasStealth = false;
                }

                // remove durability from weapon if hero attack
                if (hero?.Weapon != null)
                {
                    hero.Weapon.Durability -= hero.Weapon.Durability > 0 ? 1 : 0;
                }

                source.IsAttacking = false;
                target.IsDefending = false;

                source.NumAttacksThisTurn++;
                c.NumOptionsPlayedThisTurn++;
                if (minion != null)
                    c.NumFriendlyMinionsThatAttackedThisTurn++;

                // set exhausted ...
                if (source.NumAttacksThisTurn > 0 && !source.HasWindfury ||
                    source.NumAttacksThisTurn > 1 && source.HasWindfury)
                {
                    log.Info($"[AttackPhase] {source} is now exhausted.");
                    c.Game.PlayTaskLog.AppendLine($"[AttackPhase] {source} is now exhausted.");
                    source.IsExhausted = true;
                }

                log.Info(
                    $"[AttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
                    $"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}attacked " +
                    $"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
                c.Game.PlayTaskLog.AppendLine($"[AttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
                    $"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}attacked " +
                    $"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
                return true;
            };
    }
}