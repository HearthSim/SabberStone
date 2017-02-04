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
        public static SelfCondition IsNotImmune => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsImmune);
        public static SelfCondition IsSilenced => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsSilenced);
        public static SelfCondition IsBoardFull => new SelfCondition(me => me.Controller.Board.IsFull);
        public static SelfCondition IsHandEmpty => new SelfCondition(me => me.Controller.Hand.IsEmpty);
        public static SelfCondition IsComboActive => new SelfCondition(me => me.Controller.Combo);
        public static SelfCondition IsAnyWeaponEquiped => new SelfCondition(me => (me as Hero)?.Weapon != null);
        public static SelfCondition IsThisWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon == me);

        public static SelfCondition IsEnraged = new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);

        public static SelfCondition IsDamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);
        public static SelfCondition IsUndamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage == 0);

        public static SelfCondition IsControlingRace(Race race) => new SelfCondition(me => me.Controller.Board.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == race));
        public static SelfCondition IsControlingBeast => IsControlingRace(Race.BEAST);
        public static SelfCondition IsControlingPirate => IsControlingRace(Race.PIRATE);

        public static SelfCondition IsDragonInHand => new SelfCondition(me => me.Controller.Hand.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == Race.DRAGON));
        public static SelfCondition IsRace(params Race[] races) => new SelfCondition(me => me is ICharacter && races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsNotRace(params Race[] races) => new SelfCondition(me => me is ICharacter && !races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsMinion => new SelfCondition(me => me is Minion);
        public static SelfCondition IsSpell => new SelfCondition(me => me is Spell);
        public static SelfCondition IsWeapon => new SelfCondition(me => me is Weapon);
        public static SelfCondition IsWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon != null);
        public static SelfCondition IsHero => new SelfCondition(me => me is Hero);
        public static SelfCondition IsAttacking => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsAttacking);
        public static SelfCondition IsCthun => new SelfCondition(me => me.Card.Id.Equals("OG_280"));
        public static SelfCondition IsSilverHandRecruit => new SelfCondition(me => me.Card.Id.Equals("CS2_101t"));
        public static SelfCondition IsSpellDmgOnHero => new SelfCondition(me => me.Controller.Hero.SpellPower > 0);
        public static SelfCondition IsNotAttackingThisTurn(int number) => new SelfCondition(me => me is Minion && ((Minion)me).NumAttacksThisTurn == number);

        public static SelfCondition IsDeathrattleMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasDeathrattle);
        public static SelfCondition IsInPlayZone => IsInZone(Zone.PLAY);
        public static SelfCondition IsInHandZone => IsInZone(Zone.HAND);
        public static SelfCondition IsInHandOrPlayZone => new SelfCondition(me => me.Zone != null && (me.Zone.Type == Zone.PLAY || me.Zone.Type == Zone.HAND));
        public static SelfCondition IsInSetasideOrHandOrPlayZone => new SelfCondition(me => me.Zone != null && (me.Zone.Type == Zone.SETASIDE || me.Zone.Type == Zone.PLAY || me.Zone.Type == Zone.HAND));
        public static SelfCondition IsCthunDead => new SelfCondition(me => me.Controller.Graveyard.GetAll.Exists(p => p.Card.Id.Equals("OG_280")));

        public static SelfCondition IsInDeckZone => IsInZone(Zone.DECK);
        public static SelfCondition IsInZone(Zone zone) => new SelfCondition(me => me.Zone.Type == zone);
        public static SelfCondition IsFrozen => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsFrozen);
        public static SelfCondition IsHeroPower(string cardId) => new SelfCondition(me => me.Controller.Hero.Power.Card.Id.Equals(cardId));
        public static SelfCondition IsNoDupeInDeck => new SelfCondition(me => !me.Controller.Deck.GroupBy(x => new {x.Card.Id}).Any(x => x.Skip(1).Any()));
        public static SelfCondition IsManaCrystalFull => new SelfCondition(me => me.Controller.BaseMana == 10);
        public static SelfCondition IsRemaningManaFull => new SelfCondition(me => me.Controller.RemainingMana == 10);

        public static SelfCondition IsNotDead => new SelfCondition(me => me is ICharacter && !me.ToBeDestroyed);
        public static SelfCondition IsNotSilenced => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsSilenced);
        public static SelfCondition IsNotBoardFull => new SelfCondition(me => !me.Controller.Board.IsFull);
        public static SelfCondition IsDurabilityOkay => new SelfCondition(me => me is Weapon && ((Weapon)me).Durability > 0);

        public static SelfCondition IsAnyNotImmune => new SelfCondition(me => me.Game.Characters.Exists(p => !p.IsImmune));
        public static SelfCondition IsOpNotBoardFull => new SelfCondition(me => !me.Controller.Opponent.Board.IsFull);
        public static SelfCondition IsSecretActive => new SelfCondition(me => me.Zone.Type == Zone.SECRET);
        public static SelfCondition IsProposedDefender(CardType cardType) => new SelfCondition(me => me is ICharacter && me.Game.IdEntityDic[((ICharacter)me).ProposedDefender].Card.Type == cardType);

        public static SelfCondition HasBoardMinion(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ) 
            => new SelfCondition(me => 
                    relaSign == RelaSign.EQ  && me.Controller.Board.Any(p => p[tag] == amount)
                 || relaSign == RelaSign.GEQ && me.Controller.Board.Any(p => p[tag] >= amount)
                 || relaSign == RelaSign.LEQ && me.Controller.Board.Any(p => p[tag] <= amount));

        public static SelfCondition HasOpBoardMinion(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ)
            => new SelfCondition(me =>
                    relaSign == RelaSign.EQ  && me.Controller.Opponent.Board.Any(p => p[tag] == amount)
                 || relaSign == RelaSign.GEQ && me.Controller.Opponent.Board.Any(p => p[tag] >= amount)
                 || relaSign == RelaSign.LEQ && me.Controller.Opponent.Board.Any(p => p[tag] <= amount));

        public static SelfCondition IsTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ) 
            => new SelfCondition(me => 
                    relaSign == RelaSign.EQ  && me[tag] == value
                 || relaSign == RelaSign.GEQ && me[tag] >= value
                 || relaSign == RelaSign.LEQ && me[tag] <= value);


        public static SelfCondition IsCthunGameTag(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
            => new SelfCondition(me =>
            {
                if (!me.Controller.SeenCthun)
                    return false;
                var proxyCthun = me.Game.IdEntityDic[me.Controller.ProxyCthun];
                return relaSign == RelaSign.EQ  && proxyCthun[tag] == value
                    || relaSign == RelaSign.GEQ && proxyCthun[tag] >= value
                    || relaSign == RelaSign.LEQ && proxyCthun[tag] <= value;
            });

        public static SelfCondition IsHealth(int value, RelaSign relaSign)
            => new SelfCondition(me => relaSign == RelaSign.EQ && me is ICharacter && ((ICharacter)me).Health == value
                                    || relaSign == RelaSign.GEQ && me is ICharacter && ((ICharacter)me).Health >= value
                                    || relaSign == RelaSign.LEQ && me is ICharacter && ((ICharacter)me).Health <= value);
  

        public static SelfCondition IsBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
            => new SelfCondition(me => relaSign == RelaSign.EQ  && me.Controller.Board.Count == value
                                    || relaSign == RelaSign.GEQ && me.Controller.Board.Count >= value
                                    || relaSign == RelaSign.LEQ && me.Controller.Board.Count <= value);


        public static SelfCondition IsLethalPreDamaged 
            => new SelfCondition(me => 
            {
                var character = me as ICharacter;
                if (character == null)
                {
                    return false;
                }
                return character.PreDamage > 0 && character.PreDamage >= character.Health;
            });

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