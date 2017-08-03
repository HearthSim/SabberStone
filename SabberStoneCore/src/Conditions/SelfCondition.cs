using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Conditions
{
    public class SelfCondition
    {
        public static SelfCondition IsDead => new SelfCondition(me => me is ICharacter && me.ToBeDestroyed);
        public static SelfCondition IsNotImmune => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsImmune);
        public static SelfCondition IsSilenced => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsSilenced);
        public static SelfCondition IsBoardFull => new SelfCondition(me => me.Controller.Board.IsFull);
        public static SelfCondition IsHandEmpty => new SelfCondition(me => me.Controller.Hand.IsEmpty);
        public static SelfCondition IsOpDeckNotEmpty => new SelfCondition(me => !me.Controller.Opponent.Deck.IsEmpty);
        public static SelfCondition IsHandNotEmpty => new SelfCondition(me => !me.Controller.Hand.IsEmpty);
        public static SelfCondition IsHandFull => new SelfCondition(me => me.Controller.Hand.IsFull);
        public static SelfCondition IsOpHandEmpty => new SelfCondition(me => me.Controller.Opponent.Hand.IsEmpty);
        public static SelfCondition IsOpHandFull => new SelfCondition(me => me.Controller.Opponent.Hand.IsFull);

        public static SelfCondition IsCurrentPlayer => new SelfCondition(me => me.Game.CurrentPlayer == me.Controller);
        public static SelfCondition IsNotCurrentPlayer => new SelfCondition(me => me.Game.CurrentPlayer != me.Controller);

        public static SelfCondition IsComboActive => new SelfCondition(me => me.Controller.Combo);
        public static SelfCondition IsAnyWeaponEquiped => new SelfCondition(me => (me as Hero)?.Weapon != null);
        public static SelfCondition IsThisWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon == me);

        public static SelfCondition IsEnraged = new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);

        public static SelfCondition IsDamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);
        public static SelfCondition IsUndamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage == 0);

        public static SelfCondition IsControllingRace(ERace race) => new SelfCondition(me => me.Controller.Board.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == race));
        public static SelfCondition IsControllingSecret => new SelfCondition(me => me.Controller.Secrets.Count > 0);

        public static SelfCondition IsDragonInHand => new SelfCondition(me => me.Controller.Hand.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).Race == ERace.DRAGON));
        public static SelfCondition Is5PlusAtkInHand => new SelfCondition(me => me.Controller.Hand.GetAll.Exists(p => p is ICharacter && ((ICharacter)p).AttackDamage >= 5));
        public static SelfCondition IsRace(params ERace[] races) => new SelfCondition(me => me is ICharacter && races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsNotRace(params ERace[] races) => new SelfCondition(me => me is ICharacter && !races.Contains(((ICharacter)me).Race));
        public static SelfCondition IsMinion => new SelfCondition(me => me is Minion);
        public static SelfCondition IsSpell => new SelfCondition(me => me is Spell);
        public static SelfCondition IsSecret => new SelfCondition(me => me is Spell && me[EGameTag.SECRET] == 1);
        public static SelfCondition IsWeapon => new SelfCondition(me => me is Weapon);
        public static SelfCondition IsWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon != null);
        public static SelfCondition IsHero => new SelfCondition(me => me is Hero);
        public static SelfCondition IsHeroPower => new SelfCondition(me => me is HeroPower);
        public static SelfCondition IsAttacking => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsAttacking);
        public static SelfCondition IsCthun => new SelfCondition(me => me.Card.Id.Equals("OG_280"));
        public static SelfCondition IsSilverHandRecruit => new SelfCondition(me => me.Card.Id.Equals("CS2_101t"));
        public static SelfCondition IsSpellDmgOnHero => new SelfCondition(me => me.Controller.Hero.SpellPowerDamage > 0);
        public static SelfCondition IsNotAttackingThisTurn(int number) => new SelfCondition(me => me is Minion && ((Minion)me).NumAttacksThisTurn == number);
        public static SelfCondition IsCardId(string cardId) => new SelfCondition(me => me.Card == Cards.FromId(cardId));
        public static SelfCondition IsNotCardClass(ECardClass cardClass) => new SelfCondition(me => me.Card.Class != cardClass);

        public static SelfCondition MinionsPlayedThisTurn(int number) => new SelfCondition(me => me.Controller.NumMinionsPlayedThisTurn == number);
        public static SelfCondition ElementalPlayedLastTurn => new SelfCondition(me => me.Controller.NumElementalsPlayedLastTurn > 0);

        public static SelfCondition HasSpellInDeck => new SelfCondition(me => me.Controller.Deck.Any(p => p is Spell));
        public static SelfCondition HasMinionInHand => new SelfCondition(me => me.Controller.Hand.Any(p => p is Minion));
        public static SelfCondition HasMyHeroAttackedThisTurn => new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn > 0);
        public static SelfCondition HasMyHeroNotAttackedThisTurn => new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn == 0);

        public static SelfCondition IsDeathrattleMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasDeathrattle);
        public static SelfCondition IsBattlecryMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasBattleCry);

        public static SelfCondition IsCthunDead => new SelfCondition(me => me.Controller.Graveyard.GetAll.Exists(p => p.Card.Id.Equals("OG_280")));

        public static SelfCondition IsInZone(params EZone[] zones) => new SelfCondition(me => me.Zone == null || zones.Contains(me.Zone.Type));
        public static SelfCondition IsFrozen => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsFrozen);
        public static SelfCondition IsHeroPowerCard(string cardId) => new SelfCondition(me => me.Controller.Hero.Power.Card.Id.Equals(cardId));
        public static SelfCondition IsNoDupeInDeck => new SelfCondition(me => !me.Controller.Deck.GroupBy(x => new {x.Card.Id}).Any(x => x.Skip(1).Any()));
        public static SelfCondition IsManaCrystalFull => new SelfCondition(me => me.Controller.BaseMana == 10);
        public static SelfCondition IsRemaningManaFull => new SelfCondition(me => me.Controller.RemainingMana == 10);

        public static SelfCondition IsNotDead => new SelfCondition(me => me is ICharacter && !me.ToBeDestroyed);
        public static SelfCondition IsNotSilenced => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsSilenced);
        public static SelfCondition IsNotBoardFull => new SelfCondition(me => !me.Controller.Board.IsFull);
        public static SelfCondition IsDurabilityOkay => new SelfCondition(me => me is Weapon && ((Weapon)me).Durability > 0);

        public static SelfCondition IsAnyNotImmune => new SelfCondition(me => me.Game.Characters.Exists(p => !p.IsImmune));
        public static SelfCondition IsOpNotBoardFull => new SelfCondition(me => !me.Controller.Opponent.Board.IsFull);
        public static SelfCondition IsSecretOrQuestActive => new SelfCondition(me => me.Zone.Type == EZone.SECRET);
        public static SelfCondition IsQuestDone => new SelfCondition(me => me[EGameTag.QUEST_PROGRESS] == me[EGameTag.QUEST_PROGRESS_TOTAL]);
        public static SelfCondition IsProposedDefender(ECardType cardType) => new SelfCondition(me => me is ICharacter && me.Game.Entities[((ICharacter)me).ProposedDefender].Card.Type == cardType);
        public static SelfCondition IsHeroProposedDefender(ECardType cardType) => new SelfCondition(me => me.Game.Entities[me.Controller.Hero.ProposedDefender].Card.Type == cardType);
        public static SelfCondition HasLessHandCardsThenOp => new SelfCondition(me => me.Controller.Hand.Count < me.Controller.Opponent.Hand.Count);

        public static SelfCondition AnyNonClassCardInHand(ECardClass cardClass)
            => new SelfCondition(me => me.Controller.Hand.GetAll.Any(p => p.Card.Class != cardClass));

        public static SelfCondition IsZoneCount(EZone zone, int amount, ERelaSign relaSign = ERelaSign.EQ) 
            => new SelfCondition(me =>
                    relaSign == ERelaSign.EQ  && me.Controller.Zones[zone].Count == amount
                 || relaSign == ERelaSign.GEQ && me.Controller.Zones[zone].Count >= amount
                 || relaSign == ERelaSign.LEQ && me.Controller.Zones[zone].Count <= amount);

        public static SelfCondition IsOpZoneCount(EZone zone, int amount, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me =>
                    relaSign == ERelaSign.EQ  && me.Controller.Opponent.Zones[zone].Count == amount
                 || relaSign == ERelaSign.GEQ && me.Controller.Opponent.Zones[zone].Count >= amount
                 || relaSign == ERelaSign.LEQ && me.Controller.Opponent.Zones[zone].Count <= amount);

        public static SelfCondition HasBoardMinion(EGameTag tag, int amount, ERelaSign relaSign = ERelaSign.EQ) 
            => new SelfCondition(me => 
                    relaSign == ERelaSign.EQ  && me.Controller.Board.Any(p => p[tag] == amount)
                 || relaSign == ERelaSign.GEQ && me.Controller.Board.Any(p => p[tag] >= amount)
                 || relaSign == ERelaSign.LEQ && me.Controller.Board.Any(p => p[tag] <= amount));

        public static SelfCondition HasOpBoardMinion(EGameTag tag, int amount, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me =>
                    relaSign == ERelaSign.EQ  && me.Controller.Opponent.Board.Any(p => p[tag] == amount)
                 || relaSign == ERelaSign.GEQ && me.Controller.Opponent.Board.Any(p => p[tag] >= amount)
                 || relaSign == ERelaSign.LEQ && me.Controller.Opponent.Board.Any(p => p[tag] <= amount));

        public static SelfCondition IsTagValue(EGameTag tag, int value, ERelaSign relaSign = ERelaSign.EQ) 
            => new SelfCondition(me => 
                    relaSign == ERelaSign.EQ  && me[tag] == value
                 || relaSign == ERelaSign.GEQ && me[tag] >= value
                 || relaSign == ERelaSign.LEQ && me[tag] <= value);

        public static SelfCondition IsBaseTagValue(EGameTag tag, int value, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me =>
                    relaSign == ERelaSign.EQ && me.Card[tag] == value
                 || relaSign == ERelaSign.GEQ && me.Card[tag] >= value
                 || relaSign == ERelaSign.LEQ && me.Card[tag] <= value);

        public static SelfCondition IsCthunGameTag(EGameTag tag, int value, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me =>
            {
                if (!me.Controller.SeenCthun)
                    return false;
                var proxyCthun = me.Game.Entities[me.Controller.ProxyCthun];
                return relaSign == ERelaSign.EQ  && proxyCthun[tag] == value
                    || relaSign == ERelaSign.GEQ && proxyCthun[tag] >= value
                    || relaSign == ERelaSign.LEQ && proxyCthun[tag] <= value;
            });

        public static SelfCondition IsHealth(int value, ERelaSign relaSign)
            => new SelfCondition(me => relaSign == ERelaSign.EQ && me is ICharacter && ((ICharacter)me).Health == value
                                    || relaSign == ERelaSign.GEQ && me is ICharacter && ((ICharacter)me).Health >= value
                                    || relaSign == ERelaSign.LEQ && me is ICharacter && ((ICharacter)me).Health <= value);
  

        public static SelfCondition IsBoardCount(int value, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me => relaSign == ERelaSign.EQ  && me.Controller.Board.Count == value
                                    || relaSign == ERelaSign.GEQ && me.Controller.Board.Count >= value
                                    || relaSign == ERelaSign.LEQ && me.Controller.Board.Count <= value);

        public static SelfCondition IsOpBoardCount(int value, ERelaSign relaSign = ERelaSign.EQ)
            => new SelfCondition(me => relaSign == ERelaSign.EQ && me.Controller.Opponent.Board.Count == value
                                    || relaSign == ERelaSign.GEQ && me.Controller.Opponent.Board.Count >= value
                                    || relaSign == ERelaSign.LEQ && me.Controller.Opponent.Board.Count <= value);

        public static SelfCondition IsHeroLethalPreDamaged 
            => new SelfCondition(me => 
            {
                var hero = me as Hero;
                if (hero == null)
                {
                    return false;
                }
                return hero.PreDamage > 0 && hero.PreDamage >= hero.Health;
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