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
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest
{
	/// <summary>
	/// Helper methods for unit tests
	/// </summary>
    internal static class TestUtils
    {
		/// <summary>
		/// Plays a card that matches the provided name. Returns the created <see cref="IPlayable"/> object from the card.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static IPlayable ProcessCard(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1)
	    {
			var character = target as ICharacter;

			if (target != null && character == null)
				throw new ArgumentException($"Can't target non-charater entity {target}");

			IPlayable entity;
			try
			{
				entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
			}
			catch (NullReferenceException)
			{
				throw new Exception($"There is no card named \"{cardName}\". Please Check Again!");
			}

		    if (asZeroCost)
			    entity.Cost = 0;
		    game.DeathProcessingAndAuraUpdate();
		    var option = PlayCardTask.Any(game.CurrentPlayer, entity, character, zonePosition, chooseOne);
		    if (!game.Process(option))
			    throw new Exception($"{option} is not a valid task.");

			return entity;
	    }

		/// <summary>
		/// Plays the provided entity as current player of the game.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		public static IPlayable ProcessCard(this Game game, IPlayable entity, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1)
	    {
			if (target != null && !(target is ICharacter))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
			var option = PlayCardTask.Any(game.CurrentPlayer, entity, (ICharacter) target, zonePosition, chooseOne);
			if (!game.Process(option))
				throw new Exception($"{option} is not a valid task.");
			return entity;
		}

		/// <summary>
		/// Plays a card that matches the provided name. Returns the created entity as the given type.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static T ProcessCard<T>(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1) where T: IPlayable
		{
			IPlayable entity;
			try
			{
				entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
			}
			catch (NullReferenceException)
			{
				throw new Exception($"There is no card named \"{cardName}\". Please Check Again!");
			}
			if (!(entity is T t))
			    throw new ArgumentException($"The given card is not {typeof(T)}");
			if (target != null && !(target is ICharacter))
				throw new ArgumentException($"Can't target non-charater entity {target}");
		    if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
			var option = PlayCardTask.Any(game.CurrentPlayer, t, (ICharacter) target, zonePosition, chooseOne);

		    if (!game.Process(option))
			    throw new Exception($"{option} is not a valid task.");

		    return t;
		}

	    public static T ProcessCard<T>(this Game game, T entity, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1) where T : IPlayable
	    {
			if (target != null && !(target is ICharacter))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			if (asZeroCost)
			    entity.Cost = 0;
		    game.DeathProcessingAndAuraUpdate();
		    var option = PlayCardTask.Any(game.CurrentPlayer, entity, (ICharacter) target, zonePosition, chooseOne);

			if (!game.Process(option))
				throw new Exception($"{option} is not a valid task.");

			return entity;
	    }

		/// <summary>
		/// Ends the current player's turn.
		/// </summary>
		public static void EndTurn(this Game game)
	    {
		    game.Process(EndTurnTask.Any(game.CurrentPlayer));
	    }

		/// <summary>
		/// Plays current player's Hero Power.
		/// </summary>
	    public static void PlayHeroPower(this Game game, IPlayable target = null, int chooseOne = 0, bool asZeroCost = false, bool autoRefresh = false)
	    {
			if (target != null && !(target is ICharacter))
				throw new ArgumentException($"Can't target non-charater entity {target}");
			var option = HeroPowerTask.Any(game.CurrentPlayer, (ICharacter) target, chooseOne, asZeroCost);

			if (asZeroCost)
			{
				Generic.AddEnchantmentBlock(game, Cards.FromId("TRL_407e"), game.CurrentPlayer.Hero, game.CurrentPlayer,
					0, 0, 0);
				game.AuraUpdate();
			}

			if (!game.Process(option))
				throw new Exception($"{option} is not a valid task.");
			if (autoRefresh)
			    game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
	    }

		/// <summary>
		/// Choose Nth item from choices (the leftest one is 1).
		/// </summary>
		/// <returns>The chosen entity.</returns>
		public static IPlayable ChooseNthChoice(this Game game, int n)
	    {
		    if (n > game.CurrentPlayer.Choice.Choices.Count)
			    throw new ArgumentOutOfRangeException();

		    int pick = game.CurrentPlayer.Choice.Choices[n - 1];
		    ChooseTask option = ChooseTask.Pick(game.CurrentPlayer, pick);
		    if (!game.Process(option))
			    throw new Exception($"{option} is not a valid task.");

		    return game.IdEntityDic[pick];
	    }

		/// <summary>
		/// Gets the cards of current choice session.
		/// </summary>
		public static Card[] GetChoiceCards(this Game game)
		{
			List<int> choices = game.CurrentPlayer.Choice?.Choices;
			if (choices == null)
				throw new Exception("There is no active choices.");

			Card[] result = new Card[choices.Count];
			for (int i = 0; i < choices.Count; i++)
				result[i] = game.IdEntityDic[choices[i]].Card;

			return result;
		}

		/// <summary>
		/// Kill this Minion.
		/// </summary>
		/// <param name="m"></param>
	    public static void Kill(this Minion m)
	    {
		    if (m.Zone.Type != SabberStoneCore.Enums.Zone.PLAY)
			    throw new ArgumentException($"{m} is not in the board.");

			m.ToBeDestroyed = true;
		    m.Game.DeathProcessingAndAuraUpdate();
	    }

		/// <summary>
		/// Cast to <see cref="ICharacter"/>
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
	    public static ICharacter AsCharacter(this IPlayable p)
	    {
		    var c = p as ICharacter;
		    if (c == null)
			    throw new InvalidCastException($"{p} is not a Character");

			return c;
	    }

		/// <summary>
		/// Performs an attack with this character to the given defender.
		/// </summary>
		public static void Attack(this ICharacter attacker, ICharacter defender)
		{
			if (defender == null)
				throw new ArgumentNullException(nameof(defender));

			string reason;
			if (attacker.Controller != attacker.Game.CurrentPlayer)
				reason = "The attacker is a minion of the current player.";
			else if (attacker.IsExhausted)
			{
				if (!(attacker is Hero hero) || hero.ExtraAttacksThisTurn <= 0 ||
					hero.ExtraAttacksThisTurn < hero.NumAttacksThisTurn)
					reason = "The attacker is exhausted.";
				else
					reason = null;
			}
			else if
				(attacker.AttackDamage == 0)
				reason = "The attacker's ATK is 0.";
			else if (attacker.IsFrozen)
				reason = "The attacker is frozen.";
			else if
				(attacker.Card.Untouchable)
				reason = "The attacker is dormant.";
			else if
				(!attacker.IsValidAttackTarget(defender))
				reason = $"{defender} is not a valid attack target for the attacker.";
			else
				reason = null;

			if (reason != null)
				throw new Exception($"{attacker} can't attack. ({reason})");

			PlayerTask task = attacker is Hero
				? (PlayerTask) HeroAttackTask.Any(attacker.Controller, defender)
				: MinionAttackTask.Any(attacker.Controller, attacker, defender);

			if (!attacker.Game.Process(task))
				throw new Exception($"{task} is not a valid task.");
		}
    }
}
