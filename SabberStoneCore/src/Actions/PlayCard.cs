﻿using System;
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public static partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static bool PlayCard(Controller c, IPlayable source, ICharacter target = null, int zonePosition = -1, int chooseOne = 0, bool skipPrePhase = false)
		{
			return PlayCardBlock.Invoke(c, source, target, zonePosition, chooseOne, skipPrePhase);
		}

		public static Func<Controller, IPlayable, ICharacter, int, int, bool, bool> PlayCardBlock
			=> delegate (Controller c, IPlayable source, ICharacter target, int zonePosition, int chooseOne, bool skipPrePhase)
			{
				if (!skipPrePhase)
					if (!PrePlayPhase.Invoke(c, source, target, zonePosition, chooseOne))
						return false;

				// play block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.PLAY, source.Id, "", 0, target?.Id ?? 0));

				if (!PayPhase.Invoke(c, source))
				{
					return false;
				}

				// remove from hand zone
				if (source is Spell)
					source[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = source.Cost;
				if (!RemoveFromZone.Invoke(c, source))
					return false;

				c.NumCardsPlayedThisTurn++;

				c.LastCardPlayed = source.Id;

				//// show entity
				//if (c.Game.History)
				//	c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(source));

				// target is beeing set onto this gametag
				if (target != null)
				{
					source.CardTarget = target.Id;
					Trigger.ValidateTriggers(c.Game, source, SequenceType.Target);
				}

				Trigger.ValidateTriggers(c.Game, source, SequenceType.PlayCard);
				switch (source)
				{
					case Hero hero:
						PlayHero.Invoke(c, hero, target, chooseOne);
						break;
					case Minion minion:
						PlayMinion.Invoke(c, minion, target, zonePosition, chooseOne);
						break;
					case Weapon weapon:
						PlayWeapon.Invoke(c, weapon, target, chooseOne);
						break;
					case Spell spell:
						PlaySpell.Invoke(c, spell, target, chooseOne);
						break;
				}

				c.NumOptionsPlayedThisTurn++;

				if (!c.IsComboActive)
					c.IsComboActive = true;

				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				return true;
			};

		public static Func<Controller, IPlayable, ICharacter, int, int, bool> PrePlayPhase
			=> delegate (Controller c, IPlayable source, ICharacter target, int zonePosition, int chooseOne)
			{
				// can't play because we got already board full
				if (source is Minion && c.BoardZone.IsFull)
				{
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "PrePlayPhase", !c.Game.Logging? "":$"Board has already {c.BoardZone.MaxSize} minions.");
					return false;
				}

				// set choose one option
				IPlayable subSource = chooseOne > 0 ? source.ChooseOnePlayables[chooseOne - 1] : source;

				// check if we can play this card and the target is valid
				if (!source.IsPlayableByPlayer || !subSource.IsPlayableByCardReq || !subSource.IsValidPlayTarget(target))
				{
					return false;
				}

				return true;
			};

		public static Func<Controller, IPlayable, bool> PayPhase
			=> delegate (Controller c, IPlayable source)
			{
				if (source.Card.HasOverload)
				{
					c.OverloadOwed += source.Overload;
					c.OverloadThisGame += source.Overload;
				}
					
				int cost = source.Cost;
				if (cost > 0)
				{
					if (c.ControllerAuraEffects[GameTag.SPELLS_COST_HEALTH] == 1)
					{
						c.Hero.TakeDamage(c.Hero, cost);
						return true;
					}

					int tempUsed = Math.Min(c.TemporaryMana, cost);
					c.TemporaryMana -= tempUsed;
					c.UsedMana += cost - tempUsed;
					c.TotalManaSpentThisGame += cost;
				}
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PayPhase", !c.Game.Logging? "":$"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
				return true;
			};

		public static Func<Controller, Hero, ICharacter, int, bool> PlayHero
			=> delegate (Controller c, Hero hero, ICharacter target, int chooseOne)
			{
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayHero", !c.Game.Logging? "":$"{c.Name} plays Hero {hero} {(target != null ? "with target " + target : "to board")}.");


				Hero oldHero = c.Hero;
				hero[GameTag.ZONE] = (int)Zone.PLAY;
				//hero[GameTag.LINKED_ENTITY] = c.Hero.Id;
				hero[GameTag.HEALTH] = oldHero[GameTag.HEALTH];
				hero[GameTag.DAMAGE] = oldHero[GameTag.DAMAGE];
				hero[GameTag.ARMOR] = oldHero[GameTag.ARMOR] + hero.Card[GameTag.ARMOR];
				hero[GameTag.EXHAUSTED] = oldHero[GameTag.EXHAUSTED];

				c.SetasideZone.Add(oldHero);
				//oldHero[GameTag.REVEALED] = 1;
				//c[GameTag.HERO_ENTITY] = hero.Id;
				hero.Weapon = oldHero.Weapon;
				c.SetasideZone.Add(oldHero.HeroPower);
				hero.HeroPower = (HeroPower) Entity.FromCard(c, Cards.FromAssetId(hero[GameTag.HERO_POWER]));
				hero.HeroPower.Power?.Trigger?.Activate(hero.HeroPower);
				if (hero.HeroPower.IsPassiveHeroPower)	// Valeera, ad hoc for now; Maybe revisit here for Bosses
					hero.HeroPower.ActivateTask();

				c.Hero = hero;
				hero.Power?.Trigger?.Activate(hero);

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				OnPlayTrigger.Invoke(c, hero);

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				hero.ActivateTask(PowerActivation.POWER, target, chooseOne);
				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				{
					hero.ActivateTask(PowerActivation.POWER, target);
				}
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				//hero.JustPlayed = false;
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterPlayCardTrigger(hero);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				return true;
			};

		public static Func<Controller, Minion, ICharacter, int, int, bool> PlayMinion
			=> delegate (Controller c, Minion minion, ICharacter target, int zonePosition, int chooseOne)
			{
				Trigger.ValidateTriggers(c.Game, minion, SequenceType.PlayMinion);

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayMinion", !c.Game.Logging? "":$"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
						 $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");

				c.NumMinionsPlayedThisTurn++;
				c.BoardZone.Add(minion, zonePosition);

				// - PreSummon Phase --> PreSummon Phase Trigger (Tidecaller)
				//   (death processing, aura updates)
				// not Implemented

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnPlayMinionTrigger(minion);
				OnPlayTrigger.Invoke(c, minion);

				// - Summon Resolution Step (Work in Process)
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnSummonTrigger(minion);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				// Noggenfogger here
				if (target != null)
				{
					c.Game.TaskQueue.StartEvent();
					c.Game.TriggerManager.OnTargetTrigger(minion);
					c.Game.ProcessTasks();
					c.Game.TaskQueue.EndEvent();
					if (minion.CardTarget != target.Id)
						target = (ICharacter)c.Game.IdEntityDic[minion.CardTarget];
				}

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				if (minion.Combo && c.IsComboActive)
					minion.ActivateTask(PowerActivation.COMBO, target);
				else
					minion.ActivateTask(PowerActivation.POWER, target, chooseOne);
				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry && minion.HasBattleCry)
				//if (minion[GameTag.BATTLECRY] == 2)
				{
					minion.ActivateTask(PowerActivation.POWER, target, chooseOne);
				}
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				//minion.JustPlayed = false;
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterPlayMinionTrigger(minion);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				// - After Summon Phase --> After Summon Trigger
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterPlayCardTrigger(minion);
				AfterSummonTrigger.Invoke(c, minion);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				switch (minion.Race)
				{
					case Race.ELEMENTAL:
						c.NumElementalsPlayedThisTurn++;
						break;
					case Race.MURLOC:
						c.NumMurlocsPlayedThisGame++;
						break;
				}

				return true;
			};

		public static Func<Controller, Spell, ICharacter, int, bool> PlaySpell
			=> delegate (Controller c, Spell spell, ICharacter target, int chooseOne)
			{
				Trigger.ValidateTriggers(c.Game, spell, SequenceType.PlaySpell);

				if (c.Game.History)
				{
					if (spell.IsSecret || spell.IsQuest)
						spell[GameTag.ZONE] = (int)Zone.SECRET;
					else
						spell[GameTag.ZONE] = (int)Zone.PLAY;
				}

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnCastSpellTrigger(spell);
				OnPlayTrigger.Invoke(c, spell);

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":$"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

				// check the spell is countered
				if (spell.IsCountered)
				{
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !c.Game.Logging ? "" : $"Spell {spell} has been countred.");
					c.GraveyardZone.Add(spell);
				}
				else
				{
					// check Spellbender and Mayor Noggenfogger
					if (target != null)
					{
						c.Game.TaskQueue.StartEvent();
						c.Game.TriggerManager.OnTargetTrigger(spell);
						c.Game.ProcessTasks();
						c.Game.TaskQueue.EndEvent();
						if (target.Id != spell.CardTarget)
						{
							target = (ICharacter)spell.Game.IdEntityDic[spell.CardTarget];
							c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !c.Game.Logging ? "" : $"trigger Spellbender Phase. Target of {spell} is changed to {target}.");
						}
					}

					CastSpell.Invoke(c, spell, target, chooseOne);
					c.Game.DeathProcessingAndAuraUpdate();
				}
				
				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":"trigger After Play Phase");
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterCastTrigger(spell);
				c.Game.TriggerManager.OnAfterPlayCardTrigger(spell);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				c.NumSpellsPlayedThisGame++;
				if (spell.IsSecret)
					c.NumSecretsPlayedThisGame++;
				if (spell.Cost >= 5)
					c.NumSpellCostOver5CastedThisGame++;

				return true;
			};

		public static Func<Controller, Weapon, ICharacter, int, bool> PlayWeapon
			=> delegate (Controller c, Weapon weapon, ICharacter target, int chooseOne)
			{
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayWeapon", !c.Game.Logging ? "" : $"{c.Hero} gets Weapon {c.Hero.Weapon}.");
				//Weapon oldWeapon = c.Hero.Weapon;

				//if (oldWeapon != null)
				//	c.Hero.Weapon = null;

				c.Hero.AddWeapon(weapon);

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				c.Game.TaskQueue.StartEvent();
				OnPlayTrigger.Invoke(c, weapon);

				weapon.Card.Power?.Aura?.Activate(weapon);
				weapon.Card.Power?.Trigger?.Activate(weapon);


				if (target != null)
				{
					c.Game.TaskQueue.StartEvent();
					c.Game.TriggerManager.OnTargetTrigger(weapon);
					c.Game.ProcessTasks();
					c.Game.TaskQueue.EndEvent();
					if (target.Id != weapon.CardTarget)
						target = (ICharacter) weapon.Game.IdEntityDic[weapon.CardTarget];
				}

				// activate battlecry
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, weapon.Id, "", -1, 0));

				c.Game.TaskQueue.StartEvent();
				weapon.ActivateTask(PowerActivation.POWER, target);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				//if (oldWeapon != null)
				//	//TODO

				c.Game.DeathProcessingAndAuraUpdate();


				c.NumWeaponsPlayedThisGame++;

				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlayWeapon", !c.Game.Logging? "":"trigger After Play Phase");
				c.Game.TaskQueue.StartEvent();
				c.Game.TriggerManager.OnAfterPlayCardTrigger(weapon);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();

				return true;
			};

		private static Action<Controller, IPlayable> OnPlayTrigger
			=> delegate (Controller c, IPlayable playable)
			{
				//playable.JustPlayed = true;
				c.Game.TriggerManager.OnPlayCardTrigger(playable);
				c.Game.ProcessTasks();
				c.Game.TaskQueue.EndEvent();

				c.Game.DeathProcessingAndAuraUpdate();
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
