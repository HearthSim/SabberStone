using System;
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Entities.Playables;

namespace SabberStoneCore.Actions
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

                // play block
                if (c.Game.HistoryEnabled)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(EBlockType.PLAY, source.Id,"",0, target?.Id ?? 0));

                c.NumCardsPlayedThisTurn++;

                c.LastCardPlayed = source.Id;

                // show entity
                if (c.Game.HistoryEnabled)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.ShowEntity(source));

                // target is beeing set onto this gametag
                if (target != null)
                {
                    source.CardTarget = target.Id;
                }

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

                source.CardTarget = -1;

                c.NumOptionsPlayedThisTurn++;

                c.IsComboActive = true;

                if (c.Game.HistoryEnabled)
                    c.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

                return true;
            };

        public static Func<Controller, IPlayable, ICharacter, int, int, bool> PrePlayPhase
            => delegate(Controller c, IPlayable source, ICharacter target, int zonePosition, int chooseOne)
            {
                // can't play because we got already board full
                if (source is Minion && c.Board.IsFull)
                {
                    c.Game.Log(ELogLevel.WARNING, EBlockType.ACTION, "PrePlayPhase", $"Board has already {c.Board.MaxSize} minions.");
                    return false;
                }

                // set choose one option
                var subSource = chooseOne > 0 ? source.ChooseOnePlayables[chooseOne - 1] : source;

                // check if we can play this card and the target is valid
                if (!source.IsPlayableByController || !subSource.IsPlayableByCardReq || !subSource.IsValidPlayTarget(target))
                {
                    return false;
                }

                // copy choose one enchantment to the actual source
                if (source.ChooseOneMechanic)
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
                if (source.ComboMechanic)
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
                c.OverloadOwed += source.Overload;
                var cost = source.Cost;
                if (cost > 0)
                {
                    var tempUsed = Math.Min(c.TemporaryMana, cost);
                    c.TemporaryMana -= tempUsed;
                    c.UsedMana += cost - tempUsed;
                    c.TotalManaSpentThisGame += cost;
                }
                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "PayPhase", $"Paying {source} for {source.Cost} Mana, remaining mana is {c.RemainingMana}.");
                return true;
            };

        public static Func<Controller, Minion, ICharacter, int, bool> PlayMinion
            => delegate(Controller c, Minion minion, ICharacter target, int zonePosition)
            {
                // - PreSummon Phase --> PreSummon Trigger (TideCaller)
                //   (death processing, aura updates)

                // remove from hand zone
                if (!RemoveFromZone.Invoke(c, minion))
                    return false;

                if (!minion.HasCharge)
                    minion.IsExhausted = true;

                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "PlayMinion", $"{c.Name} plays Minion {minion} {(target != null ? "with target " + target : "to board")} " +
                         $"{(zonePosition > -1 ? "position " + zonePosition : "")}.");

                // - PreSummon Phase --> PreSummon Phase Trigger (Tidecaller)
                //   (death processing, aura updates)
                c.Board.Add(minion, zonePosition);
                c.Game.DeathProcessingAndAuraUpdate();

                // - OnPlay Phase --> OnPlay Trigger (Illidan)
                //   (death processing, aura updates)
                OnPlayTrigger.Invoke(c, minion);

                // - BattleCry Phase --> Battle Cry Resolves
                //   (death processing, aura updates)
                minion.ApplyEnchantments(EEnchantmentActivation.BATTLECRY, EZone.PLAY, target);
                // check if [LOE_077] Brann Bronzebeard aura is active
                if (c.ExtraBattlecry)
                //if (minion[GameTag.BATTLECRY] == 2)
                {
                    minion.ApplyEnchantments(EEnchantmentActivation.BATTLECRY, EZone.PLAY, target);
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
                    case ERace.ELEMENTAL:
                        c.NumElementalsPlayedThisTurn++;
                        break;
                    case ERace.MURLOC:
                        c.NumMurlocsPlayedThisGame++;
                        break;
                }

                return true;
            };

        public static Func<Controller, Spell, ICharacter, bool> PlaySpell
            => delegate(Controller c, Spell spell, ICharacter target)
            {
                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "PlaySpell", $"{c.Name} plays Spell {spell} {(target != null ? "with target " + target.Card : "to board")}.");

                // trigger Spellbender Phase
                c.Game.Log(ELogLevel.DEBUG, EBlockType.ACTION, "PlaySpell", "trigger Spellbender Phase (not implemented)");

                // trigger SpellText Phase
                c.Game.Log(ELogLevel.DEBUG, EBlockType.ACTION, "PlaySpell", "trigger SpellText Phase (not implemented)");

                if (spell.IsCountered)
                {
                    c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "PlaySpell", $"Spell {spell} has been countred.");
                    c.Graveyard.Add(spell);
                }
                else if (spell.IsSecret || spell.IsQuest)
                {
                    spell.ApplyEnchantments(EEnchantmentActivation.SECRET_OR_QUEST, EZone.PLAY);
                    c.Secrets.Add(spell);

                    c.NumSecretsPlayedThisGame++;
                }
                else
                {
                    spell.ApplyEnchantments(EEnchantmentActivation.SPELL, EZone.PLAY, target);
                    c.Graveyard.Add(spell);
                }
                c.Game.DeathProcessingAndAuraUpdate();

                // trigger After Play Phase
                c.Game.Log(ELogLevel.DEBUG, EBlockType.ACTION, "PlaySpell", "trigger After Play Phase");
                spell.JustPlayed = false;
                c.Game.DeathProcessingAndAuraUpdate();

                c.NumSpellsPlayedThisGame++;

                return true;
            };

        public static Func<Controller, Weapon, bool> PlayWeapon
            => delegate(Controller c, Weapon weapon)
            {
				weapon.SetOrderOfPlay(ECardType.WEAPON);
				c.Hero.AddWeapon(weapon);

                c.Game.Log(ELogLevel.INFO, EBlockType.ACTION, "PlayWeapon", $"{c.Hero} gets Weapon {c.Hero.Weapon}.");

                // activate battlecry
                weapon.ApplyEnchantments(EEnchantmentActivation.WEAPON, EZone.PLAY);
                weapon.ApplyEnchantments(EEnchantmentActivation.BATTLECRY, EZone.PLAY);
                c.Game.DeathProcessingAndAuraUpdate();

                c.NumWeaponsPlayedThisGame++;

                // trigger After Play Phase
                c.Game.Log(ELogLevel.DEBUG, EBlockType.ACTION, "PlayWeapon", "trigger After Play Phase");
                weapon.JustPlayed = false;

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