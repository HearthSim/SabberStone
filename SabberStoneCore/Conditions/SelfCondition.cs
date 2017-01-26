using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Conditions
{
    public class SelfCondition
    {
        public static SelfCondition IsDead => new SelfCondition(me => me is ICharacter && me.ToBeDestroyed);
        public static SelfCondition IsSilenced => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsSilenced);
        public static SelfCondition IsBoardFull => new SelfCondition(me => me.Controller.Board.IsFull);
        public static SelfCondition IsHandEmpty => new SelfCondition(me => me.Controller.Hand.IsEmpty);
        public static SelfCondition IsComboActive => new SelfCondition(me => me.Controller.Combo);
        public static SelfCondition IsAnyWeaponEquiped => new SelfCondition(me => (me as Hero)?.Weapon != null);
        public static SelfCondition IsThisWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon == me);
        public static SelfCondition IsControlingBeast => new SelfCondition(me => me.Controller.Board.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == Race.BEAST));
        public static SelfCondition IsControlingPirate => new SelfCondition(me => me.Controller.Board.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == Race.PIRATE));
        public static SelfCondition IsDragonInHand => new SelfCondition(me => me.Controller.Hand.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == Race.DRAGON));
        public static SelfCondition IsRace(params Race[] races) => new SelfCondition(me => me is ICharacter && races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsNotRace(params Race[] races) => new SelfCondition(me => me is ICharacter && !races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsMinion => new SelfCondition(me => me is Minion);
        public static SelfCondition IsDeathrattleMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasDeathrattle);
        public static SelfCondition IsInPlayZone => IsInZone(Zone.PLAY);
        public static SelfCondition IsInHandZone => IsInZone(Zone.HAND);
        public static SelfCondition IsInHandOrPlayZone => new SelfCondition(me => me.Zone != null && (me.Zone.Type == Zone.PLAY || me.Zone.Type == Zone.HAND));
        public static SelfCondition IsInSetasideOrHandOrPlayZone => new SelfCondition(me => me.Zone != null && (me.Zone.Type == Zone.SETASIDE || me.Zone.Type == Zone.PLAY || me.Zone.Type == Zone.HAND));
        public static SelfCondition IsCthunDead => new SelfCondition(me => me.Controller.Graveyard.GetAll.Exists(p => p.Card.Id.Equals("OG_280")));

        public static SelfCondition IsInDeckZone => IsInZone(Zone.DECK);
        public static SelfCondition IsInZone(Zone zone) => new SelfCondition(me => me.Zone.Type == zone);
        public static SelfCondition IsFrozen => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsFrozen);
        public static SelfCondition IsTagValue(GameTag tag, int value) => new SelfCondition(me => me[tag] == value);
        public static SelfCondition IsHeroPower(string cardId) => new SelfCondition(me => me.Controller.Hero.Power.Card.Id.Equals(cardId));
        public static SelfCondition IsNoDupeInDeck => new SelfCondition(me => !me.Controller.Deck.GroupBy(x => new {x.Card.Id}).Any(x => x.Skip(1).Any()));
        public static SelfCondition IsManaCrystalFull => new SelfCondition(me => me.Controller.BaseMana == 10);
        public static SelfCondition IsRemaningManaFull => new SelfCondition(me => me.Controller.RemainingMana == 10);

        public static SelfCondition IsNotDead => new SelfCondition(me => me is ICharacter && !me.ToBeDestroyed);
        public static SelfCondition IsNotSilenced => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsSilenced);
        public static SelfCondition IsNotBoardFull => new SelfCondition(me => !me.Controller.Board.IsFull);
        public static SelfCondition IsDurabilityOkay => new SelfCondition(me => me is Weapon && ((Weapon)me).Durability > 0);

        public static SelfCondition IsOpNotBoardFull => new SelfCondition(me => !me.Controller.Opponent.Board.IsFull);
        public static SelfCondition IsSecretActive => new SelfCondition(me => me.Zone.Type == Zone.SECRET);


        private readonly Func<IPlayable, bool> _function;

        public SelfCondition(Func<IPlayable, bool> function)
        {
            _function = function;
        }

        public bool Eval(IPlayable owner)
        {
            return _function(owner);
        }

    }

}