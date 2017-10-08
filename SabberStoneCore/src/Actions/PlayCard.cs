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

				// show entity
				if (c.Game.History)
					c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(source));

				// target is beeing set onto this gametag
				if (target != null)
				{
					source.CardTarget = target.Id;
				}
				if (source is Hero)
				{
					PlayHero.Invoke(c, (Hero)source, target);
				}
				else if (source is Minion)
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
					c.Game.Log(LogLevel.WARNING, BlockType.ACTION, "PrePlayPhase", $"Board has already {c.BoardZone.MaxSize} minions.");
					return false;
				}

				// set choose one option
				IPlayable subSource = chooseOne > 0 ? source.ChooseOnePlayables[chooseOne - 1] : source;

				// check if we can play this card and the target is valid
				if (!source.IsPlayableByPlayer || !subSource.IsPlayableByCardReq || !subSource.IsValidPlayTarget(target))
				{
					return false;
				}

				// copy choose one enchantment to the actual source
				if (source.ChooseOne)
				{
					// [OG_044] Fandral Staghelm, Aura active 
					if (c.ChooseBoth
					&& !source.Card.Id.Equals("EX1_165") // OG_044a, using choose one 0 option
					&& !source.Card.Id.Equals("BRM_010") // OG_044b, using choose one 0 option
					&& !source.Card.Id.Equals("AT_042")) // OG_044c, using choose one 0 option
					{
						source.Enchantments.AddRange(source.ChooseOnePlayables[0].Enchantments);
						source.Enchantments.AddRange(source.ChooseOnePlayables[1].Enchantments);
					}
					else
					{
						source.Enchantments = subSource.Enchantments;
					}
				}

				// replace enchantments with the no combo or combo one ..
				if (source.Combo && !(source is Minion))
				{
					if (source.Enchantments.Count > 1)
					{
						source.Enchantments = new List<Enchantment> { source.Enchantments[c.IsComboActive ? 1 : 0] };
					}
					else if (c.IsComboActive && source.Enchantments.Count > 0)
					{
						source.Enchantments = new List<Enchantment> { source.Enchantments[0] };
					}
					else
					{
						source.Enchantments = new List<Enchantment> { };
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
				if (c.Game.Logging)
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PayPhase", $"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
				return true;
			};

		public static Func<Controller, Hero, ICharacter, bool> PlayHero
			=> delegate (Controller c, Hero hero, ICharacter target)
			{
				// remove from hand zone
				if (!RemoveFromZone.Invoke(c, hero))
					return false;

				if (c.Game.Logging)
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayHero", $"{c.Name} plays Hero {hero} {(target != null ? "with target " + target : "to board")}.");

				// removing the current Id, to readd it as hero
				c.Game.IdEntityDic.Remove(hero.Id);

				c.AddHeroAndPower(hero.Card, null, new Dictionary<GameTag, int>()
				{
					[GameTag.HEALTH] = c.Hero[GameTag.HEALTH],
					[GameTag.DAMAGE] = c.Hero[GameTag.DAMAGE],
					[GameTag.ARMOR] = c.Hero[GameTag.ARMOR] + hero.Card[GameTag.ARMOR],
					[GameTag.EXHAUSTED] = c.Hero[GameTag.EXHAUSTED]
				}, hero.Id);

				// - OnPlay Phase --> OnPlay Trigger (Illidan)
				//   (death processing, aura updates)
				OnPlayTrigger.Invoke(c, hero);

				// - BattleCry Phase --> Battle Cry Resolves
				//   (death processing, aura updates)
				hero.ApplyEnchantments(EnchantmentActivation.BATTLECRY, Zone.PLAY, target);

				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				//if (minion[GameTag.BATTLECRY] == 2)
				{
					hero.ApplyEnchantments(EnchantmentActivation.BATTLECRY, Zone.PLAY, target);
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

				if (c.Game.Logging)
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayMinion", $"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
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
				minion.ApplyEnchantments(EnchantmentActivation.BATTLECRY, Zone.PLAY, target);
				if (minion.Combo && c.IsComboActive)
					minion.ApplyEnchantments(EnchantmentActivation.COMBO, Zone.PLAY, target);
				// check if [LOE_077] Brann Bronzebeard aura is active
				if (c.ExtraBattlecry)
				//if (minion[GameTag.BATTLECRY] == 2)
				{
					minion.ApplyEnchantments(EnchantmentActivation.BATTLECRY, Zone.PLAY, target);
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
				if (c.Game.Logging)
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", $"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

				// trigger Spellbender Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", "trigger Spellbender Phase (not implemented)");

				// trigger SpellText Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", "trigger SpellText Phase (not implemented)");

				if (spell.IsCountered)
				{
					if (c.Game.Logging)
						c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlaySpell", $"Spell {spell} has been countred.");
					spell.JustPlayed = false;
					c.GraveyardZone.Add(spell);
				}
				else if (spell.IsSecret || spell.IsQuest)
				{
					c.NumSpellsPlayedThisGame++;
					c.NumSecretsPlayedThisGame++;
					spell.ApplyEnchantments(EnchantmentActivation.SECRET_OR_QUEST, Zone.PLAY);
					c.SecretZone.Add(spell);
				}
				else
				{
					c.NumSpellsPlayedThisGame++;
					spell.ApplyEnchantments(EnchantmentActivation.SPELL, Zone.PLAY, target);
					c.GraveyardZone.Add(spell);
				}
				c.Game.DeathProcessingAndAuraUpdate();

				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlaySpell", "trigger After Play Phase");
				spell.JustPlayed = false;
				c.Game.DeathProcessingAndAuraUpdate();



				return true;
			};

		public static Func<Controller, Weapon, bool> PlayWeapon
			=> delegate (Controller c, Weapon weapon)
			{
				c.Hero.AddWeapon(weapon);

				if (c.Game.Logging)
					c.Game.Log(LogLevel.INFO, BlockType.ACTION, "PlayWeapon", $"{c.Hero} gets Weapon {c.Hero.Weapon}.");

				// activate battlecry
				weapon.ApplyEnchantments(EnchantmentActivation.WEAPON, Zone.PLAY);
				weapon.ApplyEnchantments(EnchantmentActivation.BATTLECRY, Zone.PLAY);
				c.Game.DeathProcessingAndAuraUpdate();

				c.NumWeaponsPlayedThisGame++;

				// trigger After Play Phase
				c.Game.Log(LogLevel.DEBUG, BlockType.ACTION, "PlayWeapon", "trigger After Play Phase");
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
