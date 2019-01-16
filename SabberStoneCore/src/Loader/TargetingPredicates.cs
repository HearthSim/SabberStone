using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Loader
{
	public delegate bool AvailabilityPredicate(Controller controller);
	public delegate bool TargetingPredicate(ICharacter target);

	public static class TargetingPredicates
	{
		private static readonly TargetingPredicate ReqMurlocTarget
			= t => t.Race == Race.MURLOC;
		private static readonly TargetingPredicate ReqDemonTarget
			= t => t.Race == Race.DEMON;
		private static readonly TargetingPredicate ReqMechTarget
			= t => t.Race == Race.MECHANICAL;
		private static readonly TargetingPredicate ReqElementalTarget
			= t => t.Race == Race.ELEMENTAL;
		private static readonly TargetingPredicate ReqBeastTarget
			= t => t.Race == Race.BEAST;
		private static readonly TargetingPredicate ReqTotemTarget
			= t => t.Race == Race.TOTEM;
		private static readonly TargetingPredicate ReqPirateTarget
			= t => t.Race == Race.PIRATE;
		private static readonly TargetingPredicate ReqDragonTarget
			= t => t.Race == Race.DRAGON;

		public static readonly TargetingPredicate ReqFrozenTarget
			= t => t.IsFrozen;
		public static readonly TargetingPredicate ReqDamagedTarget
			= t => t.Damage > 0;
		public static readonly TargetingPredicate ReqUndamagedTarget
			= t => t.Damage == 0;
		public static readonly TargetingPredicate ReqMustTargetTaunter
			= t => t.HasTaunt;
		public static readonly TargetingPredicate ReqStealthedTarget
			= t => t.HasStealth;
		public static readonly TargetingPredicate ReqTargetWithDeathrattle
			= t => t.HasDeathrattle;
		public static readonly TargetingPredicate ReqLegendaryTarget
			= t => t.Card.Rarity == Rarity.LEGENDARY;

		public static TargetingPredicate ReqTargetWithRace(int race)
		{
			switch ((Race) race)
			{
				case Race.MURLOC:
					return ReqMurlocTarget;
				case Race.DEMON:
					return ReqDemonTarget;
				case Race.MECHANICAL:
					return ReqMechTarget;
				case Race.ELEMENTAL:
					return ReqElementalTarget;
				case Race.BEAST:
					return ReqBeastTarget;
				case Race.TOTEM:
					return ReqTotemTarget;
				case Race.PIRATE:
					return ReqPirateTarget;
				case Race.DRAGON:
					return ReqDragonTarget;
				// Ignores
				case Race.UNDEAD:
				case Race.EGG:
					return null;
				default:
					throw new IndexOutOfRangeException(
						$@"Targeting Race {(Race)race} is not implemented! Please Check \Loader\TargetingPredicates.cs");
			}
		}

		public static TargetingPredicate ReqTargetMaxAttack(int value)
		{
			return t => t.AttackDamage <= value;
		}

		public static TargetingPredicate ReqTargetMinAttack(int value)
		{
			return t => t.AttackDamage >= value;
		}

		private static readonly AvailabilityPredicate ReqMin1EnemyMinion
			= c => c.Opponent.BoardZone.Count >= 1;
		private static readonly AvailabilityPredicate ReqMin2EnemyMinions
			= c => c.Opponent.BoardZone.Count >= 2;
		private static readonly AvailabilityPredicate ReqMin1TotalMinion
			= c => c.BoardZone.Count + c.Opponent.BoardZone.Count > 0;

		public static readonly AvailabilityPredicate ReqTargetForCombo
			= c => c.IsComboActive;

		public static readonly AvailabilityPredicate ElementalPlayedLastTurn
			= c => c.NumElementalsPlayedLastTurn > 0;

		public static readonly AvailabilityPredicate DragonInHand
			= c => c.DragonInHand;

		public static readonly AvailabilityPredicate ReqNumMinionSlots
			= c => !c.BoardZone.IsFull;

		public static readonly AvailabilityPredicate ReqHandNotFull
			= c => !c.HandZone.IsFull;

		public static readonly AvailabilityPredicate ReqWeaponEquipped
			= c => c.Hero.Weapon != null;

		public static readonly AvailabilityPredicate ReqFriendlyMinionDiedThisGame
			= c => c.GraveyardZone.Any(q => q is Minion m && m.ToBeDestroyed);

		public static readonly AvailabilityPredicate ReqSecretZoneCapForNonSecret
			= c => !c.SecretZone.IsFull;

		public static AvailabilityPredicate MinimumFriendlyMinions(int value)
		{
			if (value == 1)
				return c => c.BoardZone.Count > 0;
			if (value == 4)
				return c => c.BoardZone.Count >= 4;

			throw new NotImplementedException(
				$@"REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = {value} is not implemented. Please Check \Loader\TargetingPredicates.cs");
		}

		public static AvailabilityPredicate MinimumFriendlySecrets(int value)
		{
			if (value == 1)
				return c => c.SecretZone.Count > 0;
			throw new NotImplementedException(
				$@"REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = {value} is not implemented. Please Check \Loader\TargetingPredicates.cs");
		}

		public static AvailabilityPredicate ReqMinimumEnemyMinions(int value)
		{
			if (value == 1)
				return ReqMin1EnemyMinion;
			if (value == 2)
				return ReqMin2EnemyMinions;
			if (value == 0)
				return c => true;
			throw new NotImplementedException(
				$@"REQ_MINIMUM_ENEMY_MINIONS = {value} is not implemented. Please Check \Loader\TargetingPredicates.cs");
		}

		public static AvailabilityPredicate ReqMinimumTotalMinions(int value)
		{
			if (value == 1)
				return ReqMin1TotalMinion;
			return c => c.BoardZone.Count + c.Opponent.BoardZone.Count >= value;
		}

		public static AvailabilityPredicate ReqEntireEntourageNotInPlay(int assetId)
		{
			switch (assetId)
			{
				// Totemic Call
				case 687:
				case 40247:
				case 53238:
					return ReqTotemicCall;
				// True Love
				case 39563:
				case 40276:
					return ReqTrueLove;
				default:
					throw new NotImplementedException(
						$@"REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY of card {assetId} is not implemented. Please Check \Loader\TargetingPredicates.cs");
			}
		}

		private static unsafe bool ReqTotemicCall(Controller c)
		{
			int count = c.BoardZone.Count;

			if (count == 7)
				return false;
			if (count < 4)
				return true;

			int* ent = stackalloc int[4];
			ent[0] = 537;
			ent[1] = 850;
			ent[2] = 458;
			ent[3] = 764;

			return CheckEntourages(c, ent, 4);
		}

		private static unsafe bool ReqTrueLove(Controller c)
		{
			int* ent = stackalloc int[1];
			ent[0] = 39561;

			return CheckEntourages(c, ent, 1);
		}

		private static unsafe bool CheckEntourages(Controller c, int* ent, int count)
		{
			int[] indices = new int[count];
			ReadOnlySpan<Minion> span = c.BoardZone.GetSpan();
			for (int i = 0, j = span.Length, k = 0; i < span.Length; i++)
			{
				int index = -1;
				for (int m = 0; m < count; m++)
					if (ent[m] == span[i].Card.AssetId)
					{
						index = m;
						break;
					}

				if (index < 0)
				{
					if (--j < count)
						break;
					continue;
				}

				bool flag = false;
				for (int l = 0; l < k; l++)
				{
					if (indices[l] != index) continue;
					flag = true;
					break;
				}

				if (flag)
				{
					if (--j < count)
						break;
				}
				else
				{
					indices[k++] = index;
					if (k == count)
						return false;
				}
			}
			
			return true;
		}
	}
}
