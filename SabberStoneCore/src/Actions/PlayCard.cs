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
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Triggers;

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
				// Preplay Phase : check the given source is playable
				if (!skipPrePhase)
					if (!PrePlayPhase.Invoke(c, source, target, zonePosition, chooseOne))
						return false;

				Game game = c.Game;
				bool history = game.History;

				// Start play block
				if (history)
					game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.PLAY, source.Id, "", 0, target?.Id ?? 0));

				game.CurrentEventData = new EventMetaData(source, target);

				// Pay Phase
				if (!PayPhase.Invoke(c, source))
					return false;

				bool echo = source.IsEcho;

				// remove from hand zone
				if (!RemoveFromZone.Invoke(c, source))
					return false;

				c.NumCardsPlayedThisTurn++;
				c.LastCardPlayed = source.Id;

				// record played cards for effect of cards like Obsidian Shard and Lynessa Sunsorrow
				// or use graveyard instead with 'played' tag(or bool)?
				c.CardsPlayedThisTurn.Add(source.Card);
				c.PlayHistory.Add(new PlayHistoryEntry(in source, in target, in chooseOne));

				//// show entity
				//if (c.Game.History)
				//	c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(source));

				// target is beeing set onto this gametag
				if (target != null)
				{
					source.CardTarget = target.Id;
					Trigger.ValidateTriggers(game, source, SequenceType.Target);
				}


				Trigger.ValidateTriggers(game, source, SequenceType.PlayCard);
				switch (source)
				{
					case Hero hero:
						PlayHero.Invoke(c, game, hero, target, chooseOne);
						break;
					case Minion minion:
						PlayMinion.Invoke(c, game, minion, target, zonePosition, chooseOne);
						break;
					case Weapon weapon:
						PlayWeapon.Invoke(c, game, weapon, target, chooseOne);
						break;
					case Spell spell:
						PlaySpell.Invoke(c, game, spell, target, chooseOne);
						break;
				}

				if (echo && !(source is Spell s && s.IsCountered))
				{
					var echoTags = new EntityData
					{
						{GameTag.GHOSTLY, 1}
					};
					IPlayable echoPlayable = Entity.FromCard(c, source.Card, echoTags, c.HandZone);
					echoPlayable[GameTag.DISPLAYED_CREATOR] = source.Id;

					c.Game.AuraUpdate();

					c.Game.GhostlyCards.Add(echoPlayable.Id);
				}

				if (!c.IsComboActive)
					c.IsComboActive = true;

				c.NumOptionsPlayedThisTurn++;

				if (history)
				{
					if (source[GameTag.GHOSTLY] == 1)
						source[GameTag.GHOSTLY] = 0;
					game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());
				}

				game.CurrentEventData = null;

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
				int cost = source.Cost;
				if (cost > 0)
				{
					source[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = cost;

					if (source is Spell && c.ControllerAuraEffects[GameTag.SPELLS_COST_HEALTH] == 1)
					{
						c.Hero.TakeDamage(c.Hero, cost);
						return true;
					}

					if (source.AuraEffects?.CardCostHealth ?? false)
					{
						c.Hero.TakeDamage(c.Hero, cost);
						return true;
					}

					int tempUsed = Math.Min(c.TemporaryMana, cost);
					if (tempUsed > 0) c.TemporaryMana -= tempUsed;
					c.UsedMana += cost - tempUsed;
					c.TotalManaSpentThisGame += cost;
				}
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PayPhase", !c.Game.Logging? "":$"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
				return true;
			};

		public static Func<Controller, Game, Hero, ICharacter, int, bool> PlayHero
			=> delegate (Controller c, Game game, Hero hero, ICharacter target, int chooseOne)
			{ 
				game.Log(LogLevel.INFO, BlockType.ACTION, "PlayHero", !game.Logging? "":$"{c.Name} plays Hero {hero} {(target != null ? "with target " + target : "to board")}.");


				Hero oldHero = c.Hero;
				hero[GameTag.ZONE] = (int)Zone.PLAY;
				//hero[GameTag.LINKED_ENTITY] = c.Hero.Id;
				//hero[GameTag.HEALTH] = oldHero[GameTag.HEALTH];
				hero.BaseHealth = oldHero.BaseHealth;
				//hero[GameTag.DAMAGE] = oldHero[GameTag.DAMAGE];
				hero.Damage = oldHero.Damage;
				hero[GameTag.ARMOR] = oldHero[GameTag.ARMOR] + hero.Card[GameTag.ARMOR];
				hero.IsExhausted = oldHero.IsExhausted;

				c.SetasideZone.Add(oldHero);
				//oldHero[GameTag.REVEALED] = 1;
				//c[GameTag.HERO_ENTITY] = hero.Id;
				hero.Weapon = oldHero.Weapon;
				c.SetasideZone.Add(oldHero.HeroPower);
				hero.HeroPower = (HeroPower) Entity.FromCard(c, Cards.GetHeroPower(hero.Card[GameTag.HERO_POWER]));
				hero.HeroPower.Power?.Trigger?.Activate(hero.HeroPower);

				c.Hero = hero;
				hero.Power?.Trigger?.Activate(hero);

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				OnPlayTrigger.Invoke(game, hero);

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				hero.ActivateTask(PowerActivation.POWER, target, chooseOne);
				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				{
					hero.ActivateTask(PowerActivation.POWER, target);
				}
				if (hero.HeroPower.IsPassiveHeroPower)  // Valeera, ad hoc for now; Maybe revisit here for Bosses
					hero.HeroPower.ActivateTask();
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				//hero.JustPlayed = false;
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterPlayCardTrigger(hero);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();

				return true;
			};

		public static Func<Controller, Game, Minion, ICharacter, int, int, bool> PlayMinion
			=> delegate (Controller c, Game game, Minion minion, ICharacter target, int zonePosition, int chooseOne)
			{
				Trigger.ValidateTriggers(game, minion, SequenceType.PlayMinion);

				game.Log(LogLevel.INFO, BlockType.ACTION, "PlayMinion", !game.Logging? "":$"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
						 $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");

				c.NumMinionsPlayedThisTurn++;
				c.BoardZone.Add(minion, zonePosition);

				// - PreSummon Phase --> PreSummon Phase Trigger (Tidecaller)
				//   (death processing, aura updates)
				// not Implemented

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnPlayMinionTrigger(minion);
				OnPlayTrigger.Invoke(game, minion);

				// - Summon Resolution Step (Work in Process)
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnSummonTrigger(minion);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				// Noggenfogger here
				if (target != null)
				{
					game.TaskQueue.StartEvent();
					game.TriggerManager.OnTargetTrigger(minion);
					game.ProcessTasks();
					game.TaskQueue.EndEvent();
					if (minion.CardTarget != target.Id)
						target = (ICharacter)game.IdEntityDic[minion.CardTarget];
				}

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				if (minion.Combo && c.IsComboActive)
				{
					minion.ActivateTask(PowerActivation.COMBO, target);
					if (c.ControllerAuraEffects[GameTag.EXTRA_MINION_BATTLECRIES_BASE] == 1)
						minion.ActivateTask(PowerActivation.COMBO, target);
				}
				else
					minion.ActivateTask(PowerActivation.POWER, target, chooseOne);

				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry && minion.HasBattleCry)
				{
					minion.ActivateTask(PowerActivation.POWER, target, chooseOne);
				}

				OverloadBlock(c, minion, game.History);

				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();

				minion = (Minion)game.CurrentEventData.EventSource;

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				//minion.JustPlayed = false;
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterPlayMinionTrigger(minion);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				// - After Summon Phase --> After Summon Trigger
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterPlayCardTrigger(minion);
				AfterSummonTrigger.Invoke(game, minion, null);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();

				if (minion.IsRace(Race.ELEMENTAL))
					c.NumElementalsPlayedThisTurn++;
				if (minion.IsRace(Race.MURLOC))
					c.NumMurlocsPlayedThisGame++;

				return true;
			};

		public static Func<Controller, Game, Spell, ICharacter, int, bool> PlaySpell
			=> delegate (Controller c, Game game, Spell spell, ICharacter target, int chooseOne)
			{
				Trigger.ValidateTriggers(game, spell, SequenceType.PlaySpell);

				if (game.History)
				{
					if (spell.IsSecret || spell.IsQuest)
						spell[GameTag.ZONE] = (int)Zone.SECRET;
					else
						spell[GameTag.ZONE] = (int)Zone.PLAY;
				}

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnCastSpellTrigger(spell);
				OnPlayTrigger.Invoke(game, spell);

				game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !game.Logging? "":$"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

				// check the spell is countered
				if (spell.IsCountered)
				{
					game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !game.Logging ? "" : $"Spell {spell} has been countred.");
					c.GraveyardZone.Add(spell);
				}
				else
				{
					// check Spellbender and Mayor Noggenfogger
					if (target != null)
					{
						game.TaskQueue.StartEvent();
						int temp = game.CurrentEventData.EventNumber;
						game.CurrentEventData.EventNumber = chooseOne;
						game.TriggerManager.OnTargetTrigger(spell);
						game.ProcessTasks();
						game.CurrentEventData.EventNumber = temp;
						game.TaskQueue.EndEvent();
						if (target.Id != spell.CardTarget)
						{
							target = (ICharacter)spell.Game.IdEntityDic[spell.CardTarget];
							game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !game.Logging ? "" : $"trigger Spellbender Phase. Target of {spell} is changed to {target}.");
						}
					}

					CastSpell.Invoke(c, game, spell, target, chooseOne);
					game.DeathProcessingAndAuraUpdate();
				}
				
				// trigger After Play Phase
				game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !game.Logging? "":"trigger After Play Phase");
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterCastTrigger(spell);
				game.TriggerManager.OnAfterPlayCardTrigger(spell);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				c.NumSpellsPlayedThisGame++;
				if (spell.IsSecret)
					c.NumSecretsPlayedThisGame++;

				game.DeathProcessingAndAuraUpdate();

				return true;
			};

		public static Func<Controller, Game, Weapon, ICharacter, int, bool> PlayWeapon
			=> delegate (Controller c, Game game, Weapon weapon, ICharacter target, int chooseOne)
			{
				game.Log(LogLevel.INFO, BlockType.ACTION, "PlayWeapon", !game.Logging ? "" : $"{c.Hero} gets Weapon {c.Hero.Weapon}.");

				//c.Hero.AddWeapon(weapon);

				if (game.History)
					weapon[GameTag.ZONE] = (int) Zone.PLAY;

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				game.TaskQueue.StartEvent();
				OnPlayTrigger.Invoke(game, weapon);

				// not sure... need some test
				weapon.Card.Power?.Aura?.Activate(weapon);
				weapon.Card.Power?.Trigger?.Activate(weapon);


				if (target != null)
				{
					game.TaskQueue.StartEvent();
					game.TriggerManager.OnTargetTrigger(weapon);
					game.ProcessTasks();
					game.TaskQueue.EndEvent();
					if (target.Id != weapon.CardTarget)
						target = (ICharacter) weapon.Game.IdEntityDic[weapon.CardTarget];
				}

				OverloadBlock(c, weapon, game.History);

				// - Equipping Phase --> Resolve Battlecry, OnDeathTrigger
				// activate battlecry
				if (game.History)
					game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, weapon.Id, "", -1, 0));

				game.TaskQueue.StartEvent();
				weapon.ActivateTask(PowerActivation.POWER, target);
				if (c.ExtraBattlecry && weapon.Card[GameTag.BATTLECRY] == 1)
					weapon.ActivateTask(PowerActivation.POWER, target);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				if (game.History)
					game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

				// equip new weapon here
				game.TaskQueue.StartEvent();
				// destroy old weapon
				// equip new weapon
				// weapon's deathrattle task queues up here
				c.Hero.AddWeapon(weapon);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				// deathprocessing;
				game.DeathProcessingAndAuraUpdate();

				// trigger After Play Phase
				game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlayWeapon", !game.Logging? "":"trigger After Play Phase");
				game.TaskQueue.StartEvent();
				game.TriggerManager.OnAfterPlayCardTrigger(weapon);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();

				c.NumWeaponsPlayedThisGame++;

				return true;
			};

		private static Action<Game, IPlayable> OnPlayTrigger
			=> delegate (Game game, IPlayable playable)
			{
				//playable.JustPlayed = true;
				game.TriggerManager.OnPlayCardTrigger(playable);
				game.ProcessTasks();
				game.TaskQueue.EndEvent();

				game.DeathProcessingAndAuraUpdate();
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
