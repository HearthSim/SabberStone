using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public partial class Generic
	{
		public static Func<Controller, ICharacter, ICharacter, bool> AttackBlock
			=> delegate (Controller c, ICharacter source, ICharacter target)
			{
				if (!PreAttackPhase.Invoke(c, source, target))
					return false;
				if (!OnAttackTrigger.Invoke(c, source, target))
				{
					// end block
					if (c.Game.History)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					return false;
				}
				if (!AttackPhase.Invoke(c, source))
				{
					// end block
					if (c.Game.History)
						c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					return false;
				}
				// end block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
				return true;
			};

		private static Func<Controller, ICharacter, ICharacter, bool> PreAttackPhase
			=> delegate (Controller c, ICharacter source, ICharacter target)
			{
				if (c != source.Controller || c == target.Controller)
				{
					c.Game.Log(LogLevel.ERROR, BlockType.ATTACK, "PreAttackPhase", "wrong controller in phase.");
					return false;
				}
				if (!source.CanAttack || !source.IsValidAttackTarget(target))
				{
					c.Game.Log(LogLevel.ERROR, BlockType.ATTACK, "PreAttackPhase", "can't attack with this card.");
					return false;
				}
				var hero = source as Hero;

				c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "PreAttackPhase", $"[PreAttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
					$"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}is attacking " +
					$"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");

				// attack block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.ATTACK, source.Id, "", -1, target.Id));

				// TODO need to be manipulated for 50% chance to attack  someone else 
				source.ProposedAttacker = source.Id;
				source.ProposedDefender = target.Id;

				return true;
			};

		private static Func<Controller, ICharacter, ICharacter, bool> OnAttackTrigger
			=> delegate (Controller c, ICharacter source, ICharacter target)
			{
				source.IsAttacking = true;
				target.IsDefending = true;
				c.Game.DeathProcessingAndAuraUpdate();
				if (source.IsDead || target.IsDead)
				{
					c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "OnAttackTrigger", "Oh shizzle, something died to the shizzeling of triggering ...");
					return false;
				}
				return true;
			};

		private static Func<Controller, ICharacter, bool> AttackPhase
			=> delegate (Controller c, ICharacter source)
			{
				var hero = source as Hero;
				var minion = source as Minion;
				source.ProposedAttacker = source.Id;
				var target = c.Game.EntityContainer[source.ProposedDefender] as ICharacter;
				if (target == null)
				{
					c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", "target wasn't found by proposed defender call.");
					return false;
				}

				// Force the game into MAIN_COMBAT step!
				c.Game.Step = Step.MAIN_COMBAT;

				// Save defender's attack as it might change after being damaged (e.g. enrage)
				var targetHero = target as Hero;
				var targetAttack = targetHero != null ? 0 : target.AttackDamage;
				var sourceAttack = hero?.TotalAttackDamage ?? source.AttackDamage;

				var targetDamaged = target.TakeDamage(source, sourceAttack);

				// freeze target if attacker is freezer
				if (targetDamaged && minion != null && minion.Freeze)
				{
					target.IsFrozen = true;
				}

				// destroy target if attacker is poisonous
				if (targetDamaged && targetHero == null && (minion != null && minion.Poisonous || hero?.Weapon != null && hero.Weapon.Poisonous))
				{
					target.Destroy();
				}

				// ignore damage from defenders with 0 attack
				if (targetAttack > 0)
				{
					var sourceDamaged = source.TakeDamage(target, targetAttack);

					// freeze source if defender is freezer
					var targetMinion = target as Minion;
					if (sourceDamaged && targetMinion != null && targetMinion.Freeze)
					{
						source.IsFrozen = true;
					}

					// destroy source if defender is poisonous
					if (sourceDamaged && targetMinion != null && targetMinion.Poisonous)
					{
						source.Destroy();
					}
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
					c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", $"{source} is now exhausted.");
					source.IsExhausted = true;
				}

				c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", $"[AttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
					$"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}attacked " +
					$"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
				return true;
			};
	}
}