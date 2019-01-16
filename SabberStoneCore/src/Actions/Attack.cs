#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static Func<Controller, ICharacter, ICharacter, bool, bool> AttackBlock
			=> delegate (Controller c, ICharacter source, ICharacter target, bool skipPrePhase)
			{
				Game g = c.Game;

				if (skipPrePhase)
				{
					if (g.History)
					{
						g.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.ATTACK, source.Id, "", -1, target.Id));

						g.ProposedAttacker = source.Id;
						g.ProposedDefender = target.Id;
					}
					g.CurrentEventData = new EventMetaData(source, target);
				}
				else if (!PreAttackPhase.Invoke(c, source, target))
					return false;

				if (!OnAttackTrigger.Invoke(g, source, target))
				{
					// end block
					if (g.History)
						g.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					g.DeathProcessingAndAuraUpdate();
					g.CurrentEventData = null;
					return false;
				}
				Trigger.ValidateTriggers(g, source, SequenceType.Target);
				if (!AttackPhase.Invoke(c, source))
				{
					// end block
					if (g.History)
						g.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
					g.DeathProcessingAndAuraUpdate();
					g.CurrentEventData = null;
					return false;
				}
				// end block
				if (g.History)
					g.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				g.TaskQueue.StartEvent();
				source.OnAfterAttackTrigger();
				g.ProcessTasks();
				g.TaskQueue.EndEvent();


				g.DeathProcessingAndAuraUpdate();
				g.CurrentEventData = null;
				g.NextStep = Step.MAIN_ACTION;

				return true;
			};

		private static Func<Controller, ICharacter, ICharacter, bool> PreAttackPhase
			=> delegate (Controller c, ICharacter source, ICharacter target)
			{
				if (c != source.Controller || c == target.Controller)
				{
					if (source[GameTag.AUTOATTACK] == 1)
						return true;
					c.Game.Log(LogLevel.ERROR, BlockType.ATTACK, "PreAttackPhase", !c.Game.Logging? "":"wrong controller in phase.");
					return false;
				}
				if (!source.CanAttack || !source.IsValidAttackTarget(target))
				{
					if (source[GameTag.AUTOATTACK] == 1)
						return true;
					c.Game.Log(LogLevel.ERROR, BlockType.ATTACK, "PreAttackPhase", !c.Game.Logging? "":"can't attack with this card.");
					return false;
				}
				var hero = source as Hero;

				c.Game.Log(LogLevel.INFO, BlockType.ATTACK, "PreAttackPhase", !c.Game.Logging? "":$"[PreAttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
						$"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}is attacking " +
						$"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");

				// attack block
				if (c.Game.History)
				{
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.ATTACK, source.Id, "", -1, target.Id));

					c.Game.ProposedAttacker = source.Id;
					c.Game.ProposedDefender = target.Id;
				}

				c.Game.CurrentEventData = new EventMetaData(source, target);

				// TODO: need to be manipulated for 50% chance to attack  someone else 

				return true;
			};

		private static Func<Game, ICharacter, ICharacter, bool> OnAttackTrigger
			=> delegate (Game g, ICharacter source, ICharacter target)
			{
				//if (g.History)
				//{

				//}
				source.IsAttacking = true;
				target.IsDefending = true;

				// Invoke onAttackTrigger
				//Trigger.ValidateTriggers(g, source, SequenceType.Attack);

				g.TaskQueue.StartEvent();
				source.Game.TriggerManager.OnAttackTrigger(source);
				g.ProcessTasks();
				g.TaskQueue.EndEvent();
				if (source.ToBeDestroyed || target.ToBeDestroyed || (source.Zone != null && source.Zone.Type != Zone.PLAY) ||
				    (target.Zone != null && target.Zone.Type != Zone.PLAY))
				{
					g.Log(LogLevel.INFO, BlockType.ATTACK, "OnAttackTrigger",
						!g.Logging ? "" : "Oh shizzle, something died to the shizzeling of triggering ...");
					return false;
				}

				return true;
			};

		private static Func<Controller, ICharacter, bool> AttackPhase
			=> delegate (Controller c, ICharacter source)
			{
				Game game = c.Game;

				game.TaskQueue.StartEvent();
				game.TriggerManager.OnTargetTrigger(source);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				var hero = source as Hero;
				var minion = source as Minion;
				//if (!game.IdEntityDic.TryGetValue(game.ProposedDefender, out IPlayable proposedDefender))
				//{
				//	game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", !game.Logging? "":"target wasn't found by proposed defender call.");
				//	source.IsAttacking = false;
				//	source.IsDefending = false;
				//	return false;
				//}

				var target = (ICharacter) game.CurrentEventData.EventTarget;

				// Force the game into MAIN_COMBAT step!
				game.Step = Step.MAIN_COMBAT;

				// Save defender's attack as it might change after being damaged (e.g. enrage)
				var targetHero = target as Hero;
				int targetAttack = /*targetHero != null ? 0 : */target.AttackDamage;
				int sourceAttack = /*hero?.TotalAttackDamage ?? */source.AttackDamage;

				int targetRealDamage = target.TakeDamage(source, sourceAttack);
				bool targetDamaged = targetRealDamage > 0;

				// freeze target if attacker is freezer
				if (targetDamaged && minion != null && minion.Freeze)
				{
					game.Log(LogLevel.VERBOSE, BlockType.ATTACK, "AttackPhase", !game.Logging? "":$"freezer attacker has frozen target.");
					target.IsFrozen = true;
				}

				// destroy target if attacker is poisonous
				if (targetDamaged && targetHero == null && (minion != null && minion.Poisonous || hero?.Weapon != null && hero.Weapon.Poisonous) && !target.ToBeDestroyed)
				{
					game.Log(LogLevel.VERBOSE, BlockType.ATTACK, "AttackPhase", !game.Logging? "":$"poisonous attacker has destroyed target.");
					target.Destroy();
				}

				// ignore damage from defenders with 0 attack
				if (targetAttack > 0)
				{
					int sourceRealDamage = source.TakeDamage(target, targetAttack);
					bool sourceDamaged = sourceRealDamage > 0;

					// freeze source if defender is freezer
					var targetMinion = target as Minion;
					if (sourceDamaged && targetMinion != null && targetMinion.Freeze)
					{
						source.IsFrozen = true;
					}

					// destroy source if defender is poisonous
					if (sourceDamaged && targetMinion != null && targetMinion.Poisonous && !source.ToBeDestroyed)
					{
						source.Destroy();
					}
				}

				if (minion != null && minion.HasStealth)
				{
					minion.HasStealth = false;
				}

				// remove durability from weapon if hero attack
				if (hero?.Weapon != null && !hero.Weapon.IsImmune)
				{
					//hero.Weapon.Durability -= hero.Weapon.Durability > 0 ? 1 : 0;
					hero.Weapon.Damage += 1;
				}

				//if (game.History)
				//{

				//}
				source.IsAttacking = false;
				target.IsDefending = false;

				int numAtk = source.NumAttacksThisTurn + 1;

				c.NumOptionsPlayedThisTurn++;
				if (minion != null)
					c.NumFriendlyMinionsThatAttackedThisTurn++;

				// set exhausted ...
				if (numAtk > 0 && !source.HasWindfury ||
					numAtk > 1 && source.HasWindfury)
				{
					game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", !game.Logging? "":$"{source} is now exhausted.");
					source.IsExhausted = true;
				}

				source.NumAttacksThisTurn = numAtk;

				game.Log(LogLevel.INFO, BlockType.ATTACK, "AttackPhase", !game.Logging? "":$"[AttackPhase]{source}[ATK:{source.AttackDamage}/HP:{source.Health}{(hero != null ? $"/ARM:{hero.Armor}" : "")}] " +
						$"{(hero?.Weapon != null ? $"[{hero.Weapon}[A:{hero.Weapon.AttackDamage}/D:{hero.Weapon.Durability}]] " : "")}attacked " +
						$"{target}[ATK:{target.AttackDamage}/HP:{target.Health}].");
				return true;
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
