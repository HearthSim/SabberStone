using System;
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Actions
{
	public partial class Generic
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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

				// play block
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.PLAY, source.Id, "", 0, target?.Id ?? 0));

				c.NumCardsPlayedThisTurn++;

				c.LastCardPlayed = source.Id;

				//// show entity
				//if (c.Game.History)
				//	c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(source));

				// target is beeing set onto this gametag
				if (target != null)
				{
					source.CardTarget = target.Id;
				}

				if (source.Card.Powers != null)
				{
					foreach (Power power in source.Card.Powers)
					{
						if (power.Trigger?.TriggerActivation == TriggerActivation.PLAY)
							power.Trigger.Activate(c.Game, source.Id);
					}
				}


				if (source is Hero hero)
				{
					PlayHero.Invoke(c, hero, target);
				}
				else if (source is Minion minion)
				{
					PlayMinion.Invoke(c, minion, target, zonePosition);
				}
				else if (source is Weapon weapon)
				{
					// - OnPlay Phase --> OnPlay Trigger (Illidan)
					//   (death processing, aura updates)
					OnPlayTrigger.Invoke(c, weapon);

					if (!RemoveFromZone.Invoke(c, source))
						return false;

					PlayWeapon.Invoke(c, (Weapon)source);
				}
				else if (source is Spell)
				{

					// - OnPlay Phase --> OnPlay Trigger (Illidan)
					//   (death processing, aura updates)
					OnPlayTrigger.Invoke(c, (Spell)source);

					source[GameTag.TAG_LAST_KNOWN_COST_IN_HAND] = source[GameTag.COST];

					// remove from hand zone
					if (!RemoveFromZone.Invoke(c, source))
						return false;

					PlaySpell.Invoke(c, (Spell)source, target);
				}

				source.CardTarget = -1;

				c.NumOptionsPlayedThisTurn++;

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

				// copy choose one power to the actual source
				if (source.ChooseOne)
				{
					// [OG_044] Fandral Staghelm, Aura active 
					if (c.ChooseBoth
					&& !source.Card.Id.Equals("EX1_165") // OG_044a, using choose one 0 option
					&& !source.Card.Id.Equals("BRM_010") // OG_044b, using choose one 0 option
					&& !source.Card.Id.Equals("AT_042")) // OG_044c, using choose one 0 option
					{
						if (source.Powers == null)
							source.Powers = new List<Power>();
						source.Powers.AddRange(source.ChooseOnePlayables[0].Powers);
						source.Powers.AddRange(source.ChooseOnePlayables[1].Powers);
					}
					else
					{
						source.Powers = subSource.Powers;
					}
				}

				// replace powers with the no combo or combo one ..
				if (source.Combo && !(source is Minion))
				{
					if (source.Powers.Count > 1)
					{
						source.Powers = new List<Power> { source.Powers[c.IsComboActive ? 1 : 0] };
					}
					else if (c.IsComboActive && source.Powers.Count > 0)
					{
						source.Powers = new List<Power> { source.Powers[0] };
					}
					else
					{
						//source.Powers = new List<Power> { };
						source.Powers = null;
					}
				}

				return true;
			};

		public static Func<Controller, IPlayable, bool> PayPhase
			=> delegate (Controller c, IPlayable source)
			{
				c.OverloadOwed += source.Overload;
				int cost = source.Cost;
				if (cost > 0)
				{
					int tempUsed = Math.Min(c.TemporaryMana, cost);
					c.TemporaryMana -= tempUsed;
					c.UsedMana += cost - tempUsed;
					c.TotalManaSpentThisGame += cost;
				}
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PayPhase", !c.Game.Logging? "":$"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
				return true;
			};

		public static Func<Controller, Hero, ICharacter, bool> PlayHero
			=> delegate (Controller c, Hero hero, ICharacter target)
			{
				// remove from hand zone
				if (!RemoveFromZone.Invoke(c, hero))
					return false;

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
				c.SetasideZone.Add(oldHero.Power);
				hero.Power = (HeroPower) Entity.FromCard(c, Cards.FromAssetId(hero[GameTag.HERO_POWER]));

				c.Hero = hero;

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				OnPlayTrigger.Invoke(c, hero);

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				hero.ApplyPowers(PowerActivation.BATTLECRY, Zone.PLAY, target);

				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				//if (minion[GameTag.BATTLECRY] == 2)
				{
					hero.ApplyPowers(PowerActivation.BATTLECRY, Zone.PLAY, target);
				}
				c.Game.DeathProcessingAndAuraUpdate();

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				hero.JustPlayed = false;
				c.Game.DeathProcessingAndAuraUpdate();

				return true;
			};

		public static Func<Controller, Minion, ICharacter, int, bool> PlayMinion
			=> delegate (Controller c, Minion minion, ICharacter target, int zonePosition)
			{
				// - PreSummon Phase --> PreSummon Trigger (TideCaller)
				//   (death processing, aura updates)

				// remove from hand zone
				if (!RemoveFromZone.Invoke(c, minion))
					return false;

				if (!minion.HasCharge)
					minion.IsExhausted = true;

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayMinion", !c.Game.Logging? "":$"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
						 $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");

				// - PreSummon Phase --> PreSummon Phase Trigger (Tidecaller)
				//   (death processing, aura updates)
				c.BoardZone.Add(minion, zonePosition);
				c.Game.DeathProcessingAndAuraUpdate();

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				OnPlayTrigger.Invoke(c, minion);

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				minion.ApplyPowers(PowerActivation.BATTLECRY, Zone.PLAY, target);
				if (minion.Combo && c.IsComboActive)
					minion.ApplyPowers(PowerActivation.COMBO, Zone.PLAY, target);
				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				//if (minion[GameTag.BATTLECRY] == 2)
				{
					minion.ApplyPowers(PowerActivation.BATTLECRY, Zone.PLAY, target);
				}
				c.Game.DeathProcessingAndAuraUpdate();

				// - After Play Phase --> After play Trigger / Secrets (Mirror Entity)
				//   (death processing, aura updates)
				minion.JustPlayed = false;
				c.Game.DeathProcessingAndAuraUpdate();

				// - After Summon Phase --> After Summon Trigger
				//   (death processing, aura updates)
				AfterSummonTrigger.Invoke(c, minion);

				c.NumMinionsPlayedThisTurn++;

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

		public static Func<Controller, Spell, ICharacter, bool> PlaySpell
			=> delegate (Controller c, Spell spell, ICharacter target)
			{
				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":$"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

				// trigger Spellbender Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":"trigger Spellbender Phase (not implemented)");

				// trigger SpellText Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":"trigger SpellText Phase (not implemented)");

				spell[GameTag.ZONE] = (int)Zone.PLAY;

				if (spell.IsCountered)
				{
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":$"Spell {spell} has been countred.");
					spell.JustPlayed = false;
					c.GraveyardZone.Add(spell);
				}
				else if (spell.IsSecret || spell.IsQuest)
				{
					c.NumSpellsPlayedThisGame++;
					if (spell.IsSecret)
						c.NumSecretsPlayedThisGame++;
					spell.ApplyPowers(PowerActivation.SECRET_OR_QUEST, Zone.PLAY);
					c.SecretZone.Add(spell);
				}
				else
				{
					c.NumSpellsPlayedThisGame++;
					spell.ApplyPowers(PowerActivation.SPELL, Zone.PLAY, target);
					c.GraveyardZone.Add(spell);
				}
				c.Game.DeathProcessingAndAuraUpdate();

				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", !c.Game.Logging? "":"trigger After Play Phase");

				spell.JustPlayed = false;

				c.Game.DeathProcessingAndAuraUpdate();



				return true;
			};

		public static Func<Controller, Weapon, bool> PlayWeapon
			=> delegate (Controller c, Weapon weapon)
			{
				c.Hero.AddWeapon(weapon);

				c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayWeapon", !c.Game.Logging? "":$"{c.Hero} gets Weapon {c.Hero.Weapon}.");

				// activate battlecry
				weapon.ApplyPowers(PowerActivation.WEAPON, Zone.PLAY);
				weapon.ApplyPowers(PowerActivation.BATTLECRY, Zone.PLAY);
				c.Game.DeathProcessingAndAuraUpdate();

				c.NumWeaponsPlayedThisGame++;

				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlayWeapon", !c.Game.Logging? "":"trigger After Play Phase");
				weapon.JustPlayed = false;

				return true;
			};

		private static Action<Controller, IPlayable> OnPlayTrigger
			=> delegate (Controller c, IPlayable playable)
			{
				playable.JustPlayed = true;
				c.Game.DeathProcessingAndAuraUpdate();
			};
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
