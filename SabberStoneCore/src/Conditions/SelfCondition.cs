using System;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Conditions
{
	/// <summary>
	/// Container for all conditions about the subject <see cref="IPlayable"/>
	/// instance.
	/// </summary>
	public class SelfCondition
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public static SelfCondition IsDead => new SelfCondition(me => me is ICharacter && me.ToBeDestroyed);
		public static SelfCondition IsNotImmune => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsImmune);
		public static SelfCondition IsSilenced => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsSilenced);
		public static SelfCondition IsBoardFull => new SelfCondition(me => me.Controller.BoardZone.IsFull);
		public static SelfCondition IsHandEmpty => new SelfCondition(me => me.Controller.HandZone.IsEmpty);
		public static SelfCondition IsOpDeckNotEmpty => new SelfCondition(me => !me.Controller.Opponent.DeckZone.IsEmpty);
		public static SelfCondition IsHandNotEmpty => new SelfCondition(me => !me.Controller.HandZone.IsEmpty);
		public static SelfCondition IsHandFull => new SelfCondition(me => me.Controller.HandZone.IsFull);
		public static SelfCondition IsOpHandEmpty => new SelfCondition(me => me.Controller.Opponent.HandZone.IsEmpty);
		public static SelfCondition IsOpHandFull => new SelfCondition(me => me.Controller.Opponent.HandZone.IsFull);
		//public static SelfCondition IsStackEmpty => new SelfCondition(me => me == null);

		public static SelfCondition IsCurrentPlayer => new SelfCondition(me => me.Game.CurrentPlayer == me.Controller);
		public static SelfCondition IsNotCurrentPlayer => new SelfCondition(me => me.Game.CurrentPlayer != me.Controller);

		public static SelfCondition IsComboActive => new SelfCondition(me => me.Controller.Combo);
		public static SelfCondition IsAnyWeaponEquiped => new SelfCondition(me => (me as Hero)?.Weapon != null);
		public static SelfCondition IsThisWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon == me);

		public static SelfCondition IsEnraged = new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);

		public static SelfCondition IsDamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);
		public static SelfCondition IsUndamaged => new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage == 0);

		public static SelfCondition IsControllingRace(Race race) => new SelfCondition(me => me.Controller.BoardZone.Any(p => (Race)p.GetNativeGameTag(GameTag.CARDRACE) == race));
		public static SelfCondition IsControllingSecret => new SelfCondition(me => me.Controller.SecretZone.Count > 0);

		public static SelfCondition IsDragonInHand => new SelfCondition(me => me.Controller.HandZone.Any(p => p is ICharacter && ((ICharacter)p).Race == Race.DRAGON));
		public static SelfCondition Is5PlusAtkInHand => new SelfCondition(me => me.Controller.HandZone.Any(p => p is ICharacter && ((ICharacter)p).AttackDamage >= 5));
		public static SelfCondition IsRace(params Race[] races) => new SelfCondition(me => me is ICharacter && races.Contains(((ICharacter)me).Race));
		public static SelfCondition IsNotRace(params Race[] races) => new SelfCondition(me => me is ICharacter && !races.Contains(((ICharacter)me).Race));
		public static SelfCondition IsMinion => new SelfCondition(me => me is Minion);
		public static SelfCondition IsSpell => new SelfCondition(me => me is Spell);
		public static SelfCondition IsSecret => new SelfCondition(me => me is Spell && me[GameTag.SECRET] == 1);
		public static SelfCondition IsWeapon => new SelfCondition(me => me is Weapon);
		public static SelfCondition IsWeaponEquiped => new SelfCondition(me => me.Controller.Hero.Weapon != null);
		public static SelfCondition IsHero => new SelfCondition(me => me is Hero);
		public static SelfCondition IsHeroPower => new SelfCondition(me => me is HeroPower);
		public static SelfCondition IsAttacking => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsAttacking);
		public static SelfCondition IsCthun => new SelfCondition(me => me.Card.Id.Equals("OG_280"));
		public static SelfCondition IsSilverHandRecruit => new SelfCondition(me => me.Card.Id.Equals("CS2_101t"));
		public static SelfCondition IsSpellDmgOnHero => new SelfCondition(me => me.Controller.CurrentSpellPower > 0);
		public static SelfCondition IsNotAttackingThisTurn(int number) => new SelfCondition(me => me is ICharacter && ((ICharacter)me).NumAttacksThisTurn == number);
		public static SelfCondition IsCardId(string cardId) => new SelfCondition(me => me.Card == Cards.FromId(cardId));
		public static SelfCondition IsNotCardClass(CardClass cardClass) => new SelfCondition(me => me.Card.Class != cardClass);

		public static SelfCondition MinionsPlayedThisTurn(int number) => new SelfCondition(me => me.Controller.NumMinionsPlayedThisTurn == number);
		public static SelfCondition ElementalPlayedLastTurn => new SelfCondition(me => me.Controller.NumElementalsPlayedLastTurn > 0);

		public static SelfCondition HasMinionInDeck(GameTag tag) => new SelfCondition(me => me.Controller.DeckZone.Any(p => p is Minion && p[tag] > 0));
		public static SelfCondition HasSpellInDeck => new SelfCondition(me => me.Controller.DeckZone.Any(p => p is Spell));
		public static SelfCondition HasMinionInHand => new SelfCondition(me => me.Controller.HandZone.Any(p => p is Minion));
		public static SelfCondition HasMyHeroAttackedThisTurn => new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn > 0);
		public static SelfCondition HasMyHeroNotAttackedThisTurn => new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn == 0);

		public static SelfCondition IsDeathrattleMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasDeathrattle);
		public static SelfCondition IsBattlecryMinion => new SelfCondition(me => me is Minion && ((Minion)me).HasBattleCry);

		public static SelfCondition IsCthunDead => new SelfCondition(me => me.Controller.GraveyardZone.Any(p => p.Card.Id.Equals("OG_280")));

		public static SelfCondition IsInZone(params Zone[] zones)
		{
			// entities that don't have a real zone like Heroes are checked on the gametag value
			return new SelfCondition(me =>
			(me.Zone != null && Array.IndexOf(zones, me.Zone.Type) > -1) ||
			(me.Zone == null && Array.IndexOf(zones, (Zone)((Entity)me).GetNativeGameTag(GameTag.ZONE)) > -1));
		}

		public static SelfCondition IsFrozen => new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsFrozen);
		public static SelfCondition IsHeroPowerCard(string cardId) => new SelfCondition(me => me.Controller.Hero.HeroPower.Card.Id.Equals(cardId));
		public static SelfCondition IsNoDupeInDeck => new SelfCondition(me => !me.Controller.DeckZone.GroupBy(x => new { x.Card.Id }).Any(x => x.Skip(1).Any()));
		public static SelfCondition HasNoSpecficCostCardsInDeck(int cost) => new SelfCondition(me => !me.Controller.DeckZone.Any(x => x.Cost == cost));
		public static SelfCondition IsManaCrystalFull => new SelfCondition(me => me.Controller.BaseMana == 10);
		public static SelfCondition IsRemaningManaFull => new SelfCondition(me => me.Controller.RemainingMana == 10);

		public static SelfCondition IsNotDead => new SelfCondition(me => me is ICharacter && !me.ToBeDestroyed);
		public static SelfCondition IsNotSilenced => new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsSilenced);
		public static SelfCondition IsNotBoardFull => new SelfCondition(me => !me.Controller.BoardZone.IsFull);
		public static SelfCondition IsDurabilityOkay => new SelfCondition(me => me is Weapon && ((Weapon)me).Durability > 0);

		public static SelfCondition IsAnyNotImmune => new SelfCondition(me => me.Game.Characters.Exists(p => !p.IsImmune));
		public static SelfCondition IsOpNotBoardFull => new SelfCondition(me => !me.Controller.Opponent.BoardZone.IsFull);
		public static SelfCondition IsOpTurn => new SelfCondition(me => me.Controller != me.Game.CurrentPlayer);
		public static SelfCondition IsMyTurn => new SelfCondition(me => me.Controller == me.Game.CurrentPlayer);
		public static SelfCondition IsSecretOrQuestActive => new SelfCondition(me => me.Zone.Type == Zone.SECRET);
		public static SelfCondition IsQuestDone => new SelfCondition(me => me[GameTag.QUEST_PROGRESS] == me[GameTag.QUEST_PROGRESS_TOTAL]);
		public static SelfCondition IsProposedDefender(CardType cardType) => new SelfCondition(me => me is ICharacter && me.Game.IdEntityDic[me.Game.ProposedDefender].Card.Type == cardType);
		public static SelfCondition IsHeroProposedDefender(CardType cardType) => new SelfCondition(me => me is Hero && me.Game.IdEntityDic.ContainsKey(me.Game.ProposedDefender) && me.Game.IdEntityDic[me.Game.ProposedDefender].Card.Type == cardType);
		public static SelfCondition HasLessHandCardsThenOp => new SelfCondition(me => me.Controller.HandZone.Count < me.Controller.Opponent.HandZone.Count);

		public static SelfCondition HasTarget => new SelfCondition(me => me.CardTarget > 0);

		public static SelfCondition AnyNonClassCardInHand(CardClass cardClass)
			=> new SelfCondition(me => me.Controller.HandZone.Any(p => p.Card.Class != cardClass));

		public static SelfCondition IsZoneCount(Zone zone, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me.Controller.ControlledZones[zone].Count == amount
				 || relaSign == RelaSign.GEQ && me.Controller.ControlledZones[zone].Count >= amount
				 || relaSign == RelaSign.LEQ && me.Controller.ControlledZones[zone].Count <= amount);

		public static SelfCondition IsOpZoneCount(Zone zone, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me.Controller.Opponent.ControlledZones[zone].Count == amount
				 || relaSign == RelaSign.GEQ && me.Controller.Opponent.ControlledZones[zone].Count >= amount
				 || relaSign == RelaSign.LEQ && me.Controller.Opponent.ControlledZones[zone].Count <= amount);

		public static SelfCondition HasBoardMinion(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me.Controller.BoardZone.Any(p => p[tag] == amount)
				 || relaSign == RelaSign.GEQ && me.Controller.BoardZone.Any(p => p[tag] >= amount)
				 || relaSign == RelaSign.LEQ && me.Controller.BoardZone.Any(p => p[tag] <= amount));

		public static SelfCondition HasOpBoardMinion(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me.Controller.Opponent.BoardZone.Any(p => p[tag] == amount)
				 || relaSign == RelaSign.GEQ && me.Controller.Opponent.BoardZone.Any(p => p[tag] >= amount)
				 || relaSign == RelaSign.LEQ && me.Controller.Opponent.BoardZone.Any(p => p[tag] <= amount));

		public static SelfCondition IsTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me[tag] == value
				 || relaSign == RelaSign.GEQ && me[tag] >= value
				 || relaSign == RelaSign.LEQ && me[tag] <= value);

		public static SelfCondition IsBaseTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
					relaSign == RelaSign.EQ && me.Card[tag] == value
				 || relaSign == RelaSign.GEQ && me.Card[tag] >= value
				 || relaSign == RelaSign.LEQ && me.Card[tag] <= value);

		public static SelfCondition IsCthunGameTag(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
			{
				if (!me.Controller.SeenCthun)
					return false;
				IPlayable proxyCthun = me.Game.IdEntityDic[me.Controller.ProxyCthun];
				return relaSign == RelaSign.EQ && proxyCthun[tag] == value
					|| relaSign == RelaSign.GEQ && proxyCthun[tag] >= value
					|| relaSign == RelaSign.LEQ && proxyCthun[tag] <= value;
			});

		public static SelfCondition IsHealth(int value, RelaSign relaSign)
			=> new SelfCondition(me => relaSign == RelaSign.EQ && me is ICharacter && ((ICharacter)me).Health == value
									|| relaSign == RelaSign.GEQ && me is ICharacter && ((ICharacter)me).Health >= value
									|| relaSign == RelaSign.LEQ && me is ICharacter && ((ICharacter)me).Health <= value);


		public static SelfCondition IsBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me => relaSign == RelaSign.EQ && me.Controller.BoardZone.Count == value
									|| relaSign == RelaSign.GEQ && me.Controller.BoardZone.Count >= value
									|| relaSign == RelaSign.LEQ && me.Controller.BoardZone.Count <= value);

		public static SelfCondition IsOpBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
		{
			return new SelfCondition(me => relaSign == RelaSign.EQ && me.Controller.Opponent.BoardZone.Count == value
												|| relaSign == RelaSign.GEQ && me.Controller.Opponent.BoardZone.Count >= value
												|| relaSign == RelaSign.LEQ && me.Controller.Opponent.BoardZone.Count <= value);
		}

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

		public static SelfCondition IsStep(Step step)
		{
			return new SelfCondition(me => me.Game.Step == step);
		}

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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
