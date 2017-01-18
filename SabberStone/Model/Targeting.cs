using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HearthDb.Enums;
using log4net;

namespace SabberStone.Model
{
    public interface ITargeting : IEntity
    {
        IEnumerable<ICharacter> ValidPlayTargets { get; }
        bool IsValidPlayTarget(ICharacter target);

        int ChooseOneOption { get; set; }
        Card RefCard { get; }
        bool ChooseOne { get; set; }
    }

    public abstract class Targeting : Entity, ITargeting
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public int ChooseOneOption { get; set; } = 0;

        public Card RefCard => ChooseOneOption > 0 ? ChooseOneCards[ChooseOneOption-1] : Card;

        protected Targeting(Controller controller, Card card, Dictionary<GameTag, int> tags, int id) : base(controller.Game, card, tags, id)
        {
            Controller = controller;
        }

        // Default definition of whether the entity currently requires a target list to be calculated before use
        protected internal virtual bool NeedsTargetList => RefCard.RequiresTarget || RefCard.RequiresTargetIfAvailable || RefCard.RequiresTargetIfAvailableAndDragonInHand && Controller.DragonInHand;

        public IEnumerable<ICharacter> ValidPlayTargets => GetValidPlayTargets();

        public virtual bool IsValidPlayTarget(ICharacter target = null)
        {
            // check if the current target is legit
            if ((RefCard.RequiresTargetIfAvailable ||
                RefCard.RequiresTargetIfAvailableAndDragonInHand && Controller.DragonInHand) && target == null && ValidPlayTargets.Any())
            {
                Log.Info($"{this} hasn't a target and there are valid targets for this card.");
                return false;
            }

            // target reqiuired for this card
            if (RefCard.RequiresTarget && target == null)
            {
                Log.Info($"{this} requires a target.");
                return false;
            }

            // got target but isn't contained in valid targets
            if (target != null && !ValidPlayTargets.Contains(target))
            {
                Log.Info($"{this} has an invalid target {target}.");
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

            foreach (var item in RefCard.Requirements)
            {
                var req = item.Key;
                var param = item.Value;

                Log.Debug($"{this} check PlayReq {req} for target {target.Card.Name} ... !");

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
                        if ((minion != null) && minion.HasCharge)
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
                        if ((minion == null) || !minion.HasTaunt)
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
                        if ((minion == null) || !minion.HasDeathrattle)
                        {
                            return false;
                        }
                        break;
                    case PlayReq.REQ_TARGET_WITH_BATTLECRY:
                        if ((minion == null) || !minion.HasBattleCry)
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
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND:
                        if (!Controller.DragonInHand)
                        {
                            return false;
                        }
                        break;
                    // implemented in playable ... 
                    case PlayReq.REQ_NUM_MINION_SLOTS:
                        break;

                    // already implemented ... card.RequiresTarget and RequiresTargetIfAvailable
                    case PlayReq.REQ_TARGET_TO_PLAY:
                    case PlayReq.REQ_TARGET_IF_AVAILABLE:
                        break;

                    // TODO still haven't implemented all playerreq ...
                    case PlayReq.REQ_NONSTEALTH_ENEMY_TARGET: // Enemy target cannot be stealthed.
                    case PlayReq.REQ_ENCHANTED_TARGET: // Target must be enchanted.
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
                    case PlayReq.REQ_FRIENDLY_MINION_DIED_THIS_GAME:
                    case PlayReq.REQ_ENEMY_WEAPON_EQUIPPED:
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS:
                    case PlayReq.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS:
                    case PlayReq.REQ_SECRET_CAP_FOR_NON_SECRET:
                    case PlayReq.REQ_TARGET_EXACT_COST:
                    case PlayReq.REQ_STEALTHED_TARGET:
                    case PlayReq.REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT:
                    case PlayReq.REQ_DRAG_TO_PLAY:
                        Log.Info($"PlayReq {req} not implemented right now!");
                        break;

                    default:
                        Log.Info($"PlayReq {req} not in switch needs to be added!");
                        break;
                }
            }

            return true;
        }
    }
}