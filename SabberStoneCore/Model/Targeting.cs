using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public interface ITargeting : IEntity
    {
        IEnumerable<ICharacter> ValidPlayTargets { get; }
        bool IsValidPlayTarget(ICharacter target);

        bool ChooseOne { get; set; }
    }

    public abstract class Targeting : Entity, ITargeting
    {
        protected Targeting(Controller controller, Card card, Dictionary<GameTag, int> tags) : base(controller.Game, card, tags)
        {
            Controller = controller;
        }

        // Default definition of whether the entity currently requires a target list to be calculated before use
        protected internal virtual bool NeedsTargetList =>
            Card.RequiresTarget
            || Card.RequiresTargetForCombo
            || Card.RequiresTargetIfAvailable
            || Card.RequiresTargetIfAvailableAndDragonInHand // && Controller.DragonInHand 
            || Card.RequiresTargetIfAvailableAndMinimumFriendlyMinions // && Controller.Board.Count >= 4
            || Card.RequiresTargetIfAvailableAndMinimumFriendlySecrets; // && Controller.Secrets.Count > 0;

        public IEnumerable<ICharacter> ValidPlayTargets => GetValidPlayTargets();

        public virtual bool IsValidPlayTarget(ICharacter target = null)
        {
            // check if the current target is legit
            if (NeedsTargetList && target == null && ValidPlayTargets.Any())
            {
                Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Targeting", $"{this} hasn't a target and there are valid targets for this card.");
                return false;
            }

            // target reqiuired for this card
            if (Card.RequiresTarget && target == null)
            {
                Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Targeting", $"{this} requires a target.");
                return false;
            }

            // got target but isn't contained in valid targets
            if (target != null && !ValidPlayTargets.Contains(target))
            {
                Game.Log(LogLevel.VERBOSE, BlockType.PLAY, "Targeting", $"{this} has an invalid target {target}.");
                return false;
            }

            return true;
        }

        // Default targeting for spells and hero powers
        protected internal virtual IEnumerable<ICharacter> GetValidPlayTargets()
        {
            // If this is an untargeted card, return an empty list
            return !NeedsTargetList ? new List<ICharacter>() : Game.Characters.Where(TargetingRequirements);
        }

        public virtual bool TargetingRequirements(ICharacter target)
        {
            var minion = target as Minion;
            if (minion != null && minion.HasStealth && minion.Controller != Controller)
            {
                return false;
            }

            foreach (var item in Card.Requirements)
            {
                var req = item.Key;
                var param = item.Value;

                Game.Log(LogLevel.DEBUG, BlockType.PLAY, "Targeting", $"{this} check PlayReq {req} for target {target.Card.Name} ... !");

                switch (req)
                {
                    //[22] REQ_TARGET_IF_AVAILABLE - If one is available, target is required. [Always:False, Param:False]

                    case PlayReq.REQ_MINION_TARGET: // Target must be a minion.
                        if (!(target is Minion))
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_FRIENDLY_TARGET: // Target must be friendly.
                        if (target.Controller != Controller)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_ENEMY_TARGET: // Target must be an enemy.
                        if (target.Controller == Controller)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_DAMAGED_TARGET: // Target must be damaged.
                        if (target.Damage == 0)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_FROZEN_TARGET: // Target must be frozen.
                        if (!target.IsFrozen)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_CHARGE_TARGET: // Target must have charge.
                        if (minion != null && minion.HasCharge)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_NONSELF_TARGET: // Cannot target self.
                        if (this == target)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_WITH_RACE: // Target must have race: [Always:False, Param:True]
                        if (target.Race != (Race)param)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_HERO_TARGET: // Target must be a hero.
                        if (!(target is Hero))
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_MUST_TARGET_TAUNTER: // Must ALWAYS target taunters.
                        if (minion == null || !minion.HasTaunt)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_UNDAMAGED_TARGET:
                        if (target.Damage > 0)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_LEGENDARY_TARGET:
                        if (target.Card.Rarity != Rarity.LEGENDARY)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_WITH_DEATHRATTLE:
                        if (minion == null || !minion.HasDeathrattle)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_WITH_BATTLECRY:
                        if (minion == null || !minion.HasBattleCry)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_HERO_OR_MINION_TARGET: // Target must be a hero or minion.
                        if (!(target is Minion) && !(target is Hero))
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_MINION_OR_ENEMY_HERO:
                        if (!(target is Minion) && target != Controller.Opponent.Hero)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_MAX_ATTACK: // Target must have a max atk of: [Always:False, Param:True]
                        if (target.AttackDamage > param)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_MIN_ATTACK: // Target must have a minimum atk of: [Always:False, Param:True]
                        if (target.AttackDamage < param)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS:
                        if (Controller.Board.Count < param)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS:
                        if (Controller.Secrets.Count < param)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND:
                        if (!Controller.DragonInHand)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_STEALTHED_TARGET:
                        if (!(target is Minion) || !((Minion)target).HasStealth)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_FOR_COMBO:
                        if (!Controller.IsComboActive)
                        {
                            return false;
                        }
                        break;
                    // implemented in playable ... 
                    case PlayReq.REQ_NUM_MINION_SLOTS:
                    case PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME:
                        break;

                    // already implemented ... card.RequiresTarget and RequiresTargetIfAvailable
                    case PlayReq.REQ_TARGET_TO_PLAY:
                    case PlayReq.REQ_TARGET_IF_AVAILABLE:
                        break;

                    // TODO still haven't implemented all playerreq ...
                    case PlayReq.REQ_NONSTEALTH_ENEMY_TARGET: // Enemy target cannot be stealthed.
                    case PlayReq.REQ_MAX_SECRETS:
                    case PlayReq.REQ_TARGET_ATTACKED_THIS_TURN: // Target must have already attacked this turn.
                    case PlayReq.REQ_TARGET_TAUNTER: // Default attack power must target taunters
                    case PlayReq.REQ_CAN_BE_ATTACKED: // Target cannot have the tag 'can't be attacked.'
                    case PlayReq.REQ_TARGET_MAGNET: // Must target magnet (enemy) minion if one exists.
                    case PlayReq.REQ_CAN_BE_TARGETED_BY_SPELLS: // Can be targeted by spells.
                    case PlayReq.REQ_CAN_BE_TARGETED_BY_OPPONENTS:
                    // Target cannot have the tag 'can't be targeted by opponents.'
                    case PlayReq.REQ_CAN_BE_TARGETED_BY_HERO_POWERS:
                    // Target cannot have the tag 'can't be targeted by hero powers.'
                    case PlayReq.REQ_ENEMY_TARGET_NOT_IMMUNE: // Enemy target cannot be immune.
                    case PlayReq.REQ_SUBCARD_IS_PLAYABLE:
                    case PlayReq.REQ_CAN_BE_TARGETED_BY_BATTLECRIES:
                    case PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_TURN:
                    case PlayReq.REQ_ENEMY_WEAPON_EQUIPPED:
                    case PlayReq.REQ_SECRET_ZONE_CAP:
                    case PlayReq.REQ_TARGET_EXACT_COST:
                    case PlayReq.REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT:
                        Game.Log(LogLevel.ERROR, BlockType.PLAY, "Targeting", $"PlayReq {req} not implemented right now!");
                        break;

                    default:
                        Game.Log(LogLevel.ERROR, BlockType.PLAY, "Targeting", $"PlayReq {req} not in switch needs to be added!");
                        break;
                }
            }

            return true;
        }
    }
}