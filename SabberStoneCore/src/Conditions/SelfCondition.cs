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
using System.Linq;
using SabberStoneCore.Enums;
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
		public static readonly SelfCondition IsDead = new SelfCondition(me => me.ToBeDestroyed && me.Card.Type == CardType.MINION);
		public static readonly SelfCondition IsNotImmune = new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsImmune);
		public static readonly SelfCondition IsSilenced = new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsSilenced);
		public static readonly SelfCondition IsBoardFull = new SelfCondition(me => me.Controller.BoardZone.IsFull);
		public static readonly SelfCondition IsHandEmpty = new SelfCondition(me => me.Controller.HandZone.IsEmpty);
		public static readonly SelfCondition IsDeckEmpty = new SelfCondition(me => me.Controller.DeckZone.IsEmpty);
		public static readonly SelfCondition IsOpDeckNotEmpty = new SelfCondition(me => !me.Controller.Opponent.DeckZone.IsEmpty);
		public static readonly SelfCondition IsHandNotEmpty = new SelfCondition(me => !me.Controller.HandZone.IsEmpty);
		public static readonly SelfCondition IsHandFull = new SelfCondition(me => me.Controller.HandZone.IsFull);
		public static readonly SelfCondition IsOpHandEmpty = new SelfCondition(me => me.Controller.Opponent.HandZone.IsEmpty);
		public static readonly SelfCondition IsOpHandFull = new SelfCondition(me => me.Controller.Opponent.HandZone.IsFull);
		//public static SelfCondition IsStackEmpty => new SelfCondition(me => me == null);

		public static readonly SelfCondition IsCurrentPlayer = new SelfCondition(me => me.Game.CurrentPlayer == me.Controller);
		public static readonly SelfCondition IsNotCurrentPlayer = new SelfCondition(me => me.Game.CurrentPlayer != me.Controller);

		public static readonly SelfCondition IsComboActive = new SelfCondition(me => me.Controller.IsComboActive);
		public static readonly SelfCondition IsAnyWeaponEquiped = new SelfCondition(me => (me as Hero)?.Weapon != null);
		public static readonly SelfCondition IsThisWeaponEquiped = new SelfCondition(me => me.Controller.Hero.Weapon == me);

		public static readonly SelfCondition IsDamaged = new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage > 0);
		public static readonly SelfCondition IsUndamaged = new SelfCondition(me => me is ICharacter && ((ICharacter)me).Damage == 0);

		public static SelfCondition IsControllingRace(Race race) => new SelfCondition(me => me.Controller.BoardZone.Any(p => p.Card.IsRace(race)));

		public static readonly SelfCondition IsControllingFrozen =
			new SelfCondition(me => me.Controller.BoardZone.Any(p => p.IsFrozen));
		public static readonly SelfCondition IsControllingSecret = new SelfCondition(me => me.Controller.SecretZone.Count > 0);

		public static readonly SelfCondition IsDragonInHand = new SelfCondition(me => me.Controller.HandZone.Any(p => p is ICharacter && ((ICharacter)p).IsRace(Race.DRAGON)));
		public static readonly SelfCondition Is5PlusAtkInHand = new SelfCondition(me => me.Controller.HandZone.Any(p => p is ICharacter && ((ICharacter)p).AttackDamage >= 5));

		public static readonly SelfCondition Has5PlusCostSpellInHand = new SelfCondition(me =>
			me.Controller.HandZone.Any(p => p.Card.Type == CardType.SPELL && p.Cost >= 5));
		public static SelfCondition IsRace(Race race) => new SelfCondition(me => me is ICharacter ch && ch.IsRace(race));
		public static SelfCondition IsNotRace(Race race) => new SelfCondition(me => me is ICharacter ch && !ch.IsRace(race));
		public static readonly SelfCondition IsMinion = new SelfCondition(me => me is Minion);
		public static readonly SelfCondition IsSpell = new SelfCondition(me => me is Spell);
		public static readonly SelfCondition IsSecret = new SelfCondition(me => me.Card.IsSecret);
		public static readonly SelfCondition IsWeapon = new SelfCondition(me => me is Weapon);
		public static readonly SelfCondition IsWeaponEquiped = new SelfCondition(me => me.Controller.Hero.Weapon != null);
		public static readonly SelfCondition IsHero = new SelfCondition(me => me is Hero);
		public static readonly SelfCondition IsHeroPower = new SelfCondition(me => me is HeroPower);

		public static readonly SelfCondition IsHeroPowerTargetingMinion = new SelfCondition(me =>
			me.Card.Type == CardType.HERO_POWER &&
			me.Game.CurrentEventData.EventTarget.Card.Type == CardType.MINION);
		public static SelfCondition HasArmorLessThan(int amount) => new SelfCondition(me => me.Controller.Hero.Armor < amount);
		public static readonly SelfCondition IsAttacking = new SelfCondition(me => me is ICharacter && ((ICharacter)me).IsAttacking);
		public static readonly SelfCondition IsCthun = new SelfCondition(me => me.Card.Id.Equals("OG_280"));
		public static readonly SelfCondition IsSilverHandRecruit = new SelfCondition(me => me.Card.Id.Equals("CS2_101t"));
		public static readonly SelfCondition IsTreant = new SelfCondition(me => me.Card.Name == "Treant");

		public static readonly SelfCondition IsControllingTreant =
			new SelfCondition(me => me.Controller.BoardZone.Any(m => m.Card.Name == "Treant"));
		public static readonly SelfCondition IsControllingLackey =
			new SelfCondition(me => me.Controller.BoardZone.Any(m => m.Card[Enums.GameTag.MARK_OF_EVIL] == 1));

		public static readonly SelfCondition IsSpellDmgOnHero = new SelfCondition(me => me.Controller.CurrentSpellPower > 0);
		public static readonly SelfCondition IsntSpellDmgOnHero = new SelfCondition(me => me.Controller.CurrentSpellPower == 0);
		public static SelfCondition IsNotAttackingThisTurn(int number) => new SelfCondition(me => me is ICharacter ch && ch.NumAttacksThisTurn == number);
		public static SelfCondition IsCardId(string cardId) => new SelfCondition(me => me.Card.Id == cardId);
		public static SelfCondition IsNotCardClass(CardClass cardClass) => new SelfCondition(me => me.Card.Class != cardClass);
		public static SelfCondition IsNotStartInDeck => new SelfCondition(me => me.Id > (me.Controller.DeckCards.Count + me.Controller.Opponent.DeckCards.Count + 7));

		public static SelfCondition MinionsPlayedThisTurn(int number) => new SelfCondition(me => me.Controller.NumMinionsPlayedThisTurn == number && me.Controller == me.Game.CurrentPlayer);

		public static SelfCondition SpellsPlayedThisTurn(int number) => new SelfCondition(me =>
			me.Controller.CardsPlayedThisTurn.Count(card => card.Type == CardType.SPELL) == number);
		public static SelfCondition ElementalPlayedLastTurn => new SelfCondition(me => me.Controller.NumElementalsPlayedLastTurn > 0);

		public static SelfCondition HasMinionInDeck() => new SelfCondition(me => me.Controller.DeckZone.Any(p => p is Minion));
		public static SelfCondition HasMinionInDeck(GameTag tag) => new SelfCondition(me => me.Controller.DeckZone.Any(p => p is Minion && p[tag] > 0));
		public static readonly SelfCondition HasSpellInDeck = new SelfCondition(me => me.Controller.DeckZone.Any(p => p is Spell));
		public static readonly SelfCondition IsNoDupeInDeck = new SelfCondition(me => !me.Controller.DeckZone.GroupBy(x => new { x.Card.Id }).Any(x => x.Skip(1).Any()));
		public static SelfCondition HasNoSpecficCostCardsInDeck(int cost) => new SelfCondition(me => !me.Controller.DeckZone.Any(x => x.Cost == cost));
		public static readonly SelfCondition HasNoMinionInDeck = new SelfCondition(me => !me.Controller.DeckZone.Any(p => p is Minion));
		public static readonly SelfCondition HasNoOddCostInDeck = new SelfCondition(me => me.Controller.DeckZone.NoOddCostCards);
		public static readonly SelfCondition HasNoEvenCostInDeck = new SelfCondition(me => me.Controller.DeckZone.NoEvenCostCards);

		public static readonly SelfCondition HasMinionInHand = new SelfCondition(me => me.Controller.HandZone.Any(p => p is Minion));
		public static readonly SelfCondition HasMyHeroAttackedThisTurn = new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn > 0);
		public static readonly SelfCondition HasMyHeroNotAttackedThisTurn = new SelfCondition(me => me.Controller.Hero.NumAttacksThisTurn == 0);
		public static readonly SelfCondition IsMyHeroDamagedThisTurn = new SelfCondition(me => me.Controller.Hero.DamageTakenThisTurn > 0);

		public static readonly SelfCondition IsDeathrattleCard = new SelfCondition(me => me.Card.Deathrattle);
		public static readonly SelfCondition IsEchoCard = new SelfCondition(me => me.Card.Echo);
		public static readonly SelfCondition IsComboCard = new SelfCondition(me => me.Card.Combo);
		public static readonly SelfCondition IsLifestealCard = new SelfCondition(me => me.Card.LifeSteal);
		public static readonly SelfCondition IsDeathrattleMinion = new SelfCondition(me => me is Minion minion && minion.HasDeathrattle);
		public static readonly SelfCondition IsBattlecryMinion = new SelfCondition(me => me is Minion minion && minion.HasBattleCry);
		public static readonly SelfCondition HasRush = new SelfCondition(me => me is Minion minion && minion.IsRush);

		public static readonly SelfCondition IsCthunDead = new SelfCondition(me => me.Controller.GraveyardZone.Any(p => p.Card.Id.Equals("OG_280")));

		public static readonly SelfCondition NotPlayedAnySpellThisTurn =
			new SelfCondition(me => me.Controller.CardsPlayedThisTurn.All(p => p.Type != CardType.SPELL));
		//public static SelfCondition NumSpellPlayedThisturn


		// entities that don't have a real zone like Heroes are checked on the gametag value
		public static SelfCondition IsInZone(Zone zone) =>
			new SelfCondition(me =>
				me.Zone != null
					? me.Zone.Type == zone
					: me.NativeTags.TryGetValue(GameTag.ZONE, out int value) && (Zone)value == zone);


		public static readonly SelfCondition IsOverloadCard = new SelfCondition(me => me.Card.HasOverload);
		public static readonly SelfCondition IsBattleCryCard = new SelfCondition(me => me.Card.Tags.ContainsKey(GameTag.BATTLECRY));
		public static readonly SelfCondition IsChooseOneCard = new SelfCondition(me => me.Card.ChooseOne);
		public static readonly SelfCondition HasTaunt = new SelfCondition(me => me is Minion m && m.HasTaunt);
		public static readonly SelfCondition IsFrozen = new SelfCondition(me => me is ICharacter character && character.IsFrozen);
		public static SelfCondition IsHeroPowerCard(string cardId) => new SelfCondition(me => me.Controller.Hero.HeroPower.Card.Id.Equals(cardId));
		public static readonly SelfCondition IsManaCrystalFull = new SelfCondition(me => me.Controller.BaseMana == 10);
		public static readonly SelfCondition IsRemaningManaFull = new SelfCondition(me => me.Controller.RemainingMana == 10);

		public static readonly SelfCondition IsNotDead = new SelfCondition(me => me is ICharacter && !me.ToBeDestroyed);
		public static readonly SelfCondition IsNotUntouchable = new SelfCondition(me => !me.Card.Untouchable);
		public static readonly SelfCondition IsNotSilenced = new SelfCondition(me => me is ICharacter && !((ICharacter)me).IsSilenced);
		public static readonly SelfCondition IsNotBoardFull = new SelfCondition(me => !me.Controller.BoardZone.IsFull);
		public static readonly SelfCondition IsDurabilityOkay = new SelfCondition(me => me is Weapon && ((Weapon)me).Durability > 0);

		public static readonly SelfCondition IsAnyNotImmune = new SelfCondition(me => me.Game.Characters.Exists(p => !p.IsImmune));
		public static readonly SelfCondition IsOpNotBoardFull = new SelfCondition(me => !me.Controller.Opponent.BoardZone.IsFull);
		public static readonly SelfCondition IsOpTurn = new SelfCondition(me => me.Controller != me.Game.CurrentPlayer);
		public static readonly SelfCondition IsMyTurn = new SelfCondition(me => me.Controller == me.Game.CurrentPlayer);
		public static readonly SelfCondition IsSecretOrQuestActive = new SelfCondition(me => me.Zone.Type == Zone.SECRET);
		public static readonly SelfCondition IsQuestDone = new SelfCondition(me => me[GameTag.QUEST_PROGRESS] == me[GameTag.QUEST_PROGRESS_TOTAL]);

		public static readonly SelfCondition IsSpellTargetingMinion = new SelfCondition(me =>
			me.Card.Type == CardType.SPELL && me.Game.IdEntityDic[me.CardTarget].Card.Type == CardType.MINION);

		public static readonly SelfCondition HoldingAnotherClassCard =
			new SelfCondition(me => me.Controller.HandZone.Any(p => p.Card.Class != me.Controller.HeroClass));

		//public static SelfCondition IsProposedDefender(CardType cardType) => new SelfCondition(me => me is ICharacter && me.Game.IdEntityDic[me.Game.ProposedDefender].Card.Type == cardType);
		public static SelfCondition IsProposedDefender(CardType cardType) => IsEventTargetIs(cardType);

		public static readonly SelfCondition HasLessHandCardsThenOp = new SelfCondition(me => me.Controller.HandZone.Count < me.Controller.Opponent.HandZone.Count);

		public static readonly SelfCondition IsAnyDiedThisTurn = new SelfCondition(p => p.Controller.NumFriendlyMinionsThatDiedThisTurn + p.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn > 0);

		public static readonly SelfCondition DoesOpHasMoresMinions =
			new SelfCondition(me => me.Controller.BoardZone.CountExceptUntouchables < me.Controller.Opponent.BoardZone.CountExceptUntouchables);

		public static readonly SelfCondition HasTarget = new SelfCondition(me => me.CardTarget > 0);

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
			{
				return relaSign == RelaSign.EQ && me.Controller.BoardZone.Any(p => GetTagValue(p, tag) == amount)
				       || relaSign == RelaSign.GEQ && me.Controller.BoardZone.Any(p => GetTagValue(p, tag) >= amount)
				       || relaSign == RelaSign.LEQ && me.Controller.BoardZone.Any(p => GetTagValue(p, tag) <= amount);
			});

		public static SelfCondition HasOpBoardMinion(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
			{

				return relaSign == RelaSign.EQ && me.Controller.Opponent.BoardZone.Any(p => GetTagValue(p, tag) == amount)
				       || relaSign == RelaSign.GEQ && me.Controller.Opponent.BoardZone.Any(p => GetTagValue(p, tag) >= amount)
				       || relaSign == RelaSign.LEQ && me.Controller.Opponent.BoardZone.Any(p => GetTagValue(p, tag) <= amount);
			});

		public static SelfCondition HasOp(GameTag tag, int amount, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me =>
				   relaSign == RelaSign.EQ &&
				   (me.Controller.Opponent.BoardZone.Any(p => p[tag] == amount)
				    || me.Controller.Opponent.Hero[tag] == amount)
				|| relaSign == RelaSign.GEQ &&
				   me.Controller.Opponent.BoardZone.Any(p => p[tag] >= amount
					|| me.Controller.Opponent.Hero[tag] >= amount)
				|| relaSign == RelaSign.LEQ &&
				   me.Controller.Opponent.BoardZone.Any(p => p[tag] <= amount
				    || me.Controller.Opponent.Hero[tag] <= amount));


		public static SelfCondition IsCost(int value, RelaSign relaSign = RelaSign.EQ)
		{
			return new SelfCondition(me =>
			{
				int val = me.Cost;

				return relaSign == RelaSign.EQ && val == value
				       || relaSign == RelaSign.GEQ && val >= value
				       || relaSign == RelaSign.LEQ && val <= value;
			});
		}

		public static SelfCondition IsTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
		{
			return new SelfCondition(me =>
			{
				int val = GetTagValue(me, tag);

				return relaSign == RelaSign.EQ && val == value
				       || relaSign == RelaSign.GEQ && val >= value
				       || relaSign == RelaSign.LEQ && val <= value;
			});
		}

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
				int val = GetTagValue(proxyCthun, tag);

				return relaSign == RelaSign.EQ && val == value
				       || relaSign == RelaSign.GEQ && val >= value
				       || relaSign == RelaSign.LEQ && val <= value;
			});

		public static SelfCondition IsHealth(int value, RelaSign relaSign)
			=> new SelfCondition(me => relaSign == RelaSign.EQ && me is ICharacter && ((ICharacter)me).Health == value
									|| relaSign == RelaSign.GEQ && me is ICharacter && ((ICharacter)me).Health >= value
									|| relaSign == RelaSign.LEQ && me is ICharacter && ((ICharacter)me).Health <= value);


		public static SelfCondition IsBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
			=> new SelfCondition(me => relaSign == RelaSign.EQ && me.Controller.BoardZone.CountExceptUntouchables == value
									|| relaSign == RelaSign.GEQ && me.Controller.BoardZone.CountExceptUntouchables >= value
									|| relaSign == RelaSign.LEQ && me.Controller.BoardZone.CountExceptUntouchables <= value);

		public static SelfCondition IsOpBoardCount(int value, RelaSign relaSign = RelaSign.EQ)
		{
			return new SelfCondition(me => relaSign == RelaSign.EQ && me.Controller.Opponent.BoardZone.Count == value
												|| relaSign == RelaSign.GEQ && me.Controller.Opponent.BoardZone.Count >= value
												|| relaSign == RelaSign.LEQ && me.Controller.Opponent.BoardZone.Count <= value);
		}

		public static readonly SelfCondition HasProperTargetsInBoard =
			new SelfCondition(me => !me.Card.MustHaveTargetToPlay || me.HasAnyValidPlayTargets);

		public static readonly SelfCondition IsHeroLethalPreDamaged
			= new SelfCondition(me => me is Hero hero && hero.Game.CurrentEventData.EventNumber >= hero.Health);

		public static SelfCondition IsCurrentEventNumber(int value, RelaSign relaSign)
		{
			return new SelfCondition(p => relaSign == RelaSign.EQ ? p.Game.CurrentEventData.EventNumber == value :
				relaSign == RelaSign.GEQ ? p.Game.CurrentEventData.EventNumber >= value :
				p.Game.CurrentEventData.EventNumber <= value);
		}
		public static SelfCondition IsEventTargetIs(CardType type)
		{
			return new SelfCondition(p => p.Game.CurrentEventData?.EventTarget.Card.Type == type);
		}
		public static SelfCondition IsEventTargetTagValue(GameTag tag, int value, RelaSign relaSign = RelaSign.EQ)
		{
			return new SelfCondition(p => relaSign == RelaSign.EQ ? p.Game.CurrentEventData.EventTarget?[tag] == value :
				relaSign == RelaSign.GEQ ? p.Game.CurrentEventData.EventTarget?[tag] >= value :
				p.Game.CurrentEventData.EventTarget?[tag] <= value);
		}

		public static SelfCondition CheckThreshold(RelaSign relaSign)
		{
			return new SelfCondition(me =>
			{
				int currentValue = me.Controller[(GameTag) me.Card[GameTag.PLAYER_TAG_THRESHOLD_TAG_ID]];
				int threshold = me.Card[GameTag.PLAYER_TAG_THRESHOLD_VALUE];

				return relaSign == RelaSign.GEQ ? currentValue >= threshold
					: relaSign == RelaSign.EQ ? currentValue == threshold
					: currentValue <= threshold;
			});
		}

		public static readonly SelfCondition IsEventSourceFriendly = new SelfCondition(p => p.Game.CurrentEventData.EventSource.Controller == p.Controller);

		public static readonly SelfCondition IsDefenderDead =
			new SelfCondition(p => p.Game.CurrentEventData?.EventTarget.ToBeDestroyed ?? false);

		public static readonly SelfCondition IsDefenderNotDead =
			new SelfCondition(p => !p.Game.CurrentEventData?.EventTarget.ToBeDestroyed ?? false);

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

		public static SelfCondition operator +(SelfCondition a, SelfCondition b)
		{
			return new SelfCondition(a._function + b._function);
		}

		private static int GetTagValue(IPlayable me, GameTag tag)
		{
			if (tag == GameTag.COST)
				return me.Cost;

			if (me is Character c)
			{
				if (tag == GameTag.ATK)
					return c.AttackDamage;
				else if
					(tag == GameTag.HEALTH)
					return c.BaseHealth;
				else
					return c[tag];
			}
			else
				return me[tag];
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
