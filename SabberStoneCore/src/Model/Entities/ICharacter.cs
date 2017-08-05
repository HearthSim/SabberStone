using SabberStoneCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Represents an entity in game which behaves as an actor. 
	/// The actions it can perform, as well as actions it undergoes,
	/// are defined by this interface.
	/// 
	/// The properties defined by this type are non complex, they have a
	/// very superficial meaning.
	/// </summary>
	public interface ICharacter : IPlayable
	{
		/// <summary>
		/// <see cref="ERace"/>
		/// </summary>
		ERace Race { get; set; }

		/// <summary>
		/// Indicates if this character can continue performing actions.
		/// </summary>
		bool IsDead { get; }

		/// <summary>
		/// Indicates if this character has the possibility to attack.
		/// </summary>
		bool CanAttack { get; }

		/// <summary>
		/// Contains a sequence of valid targets, also Characters, which
		/// can be attacked.
		/// </summary>
		IEnumerable<ICharacter> ValidAttackTargets { get; }

		/// <summary>
		/// Indicates if the provided target is attackable.
		/// 
		/// A quick solution would be to test if there are no taunt minions
		/// present and the target is not immune.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		bool IsValidAttackTarget(ICharacter target);

		/// <summary>
		/// This character takes damage from a certain other entity.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		bool TakeDamage(IPlayable source, int damage);

		/// <summary>
		/// Reverse of <see cref="TakeDamage(IPlayable, Int32)"/>
		/// </summary>
		/// <param name="source"></param>
		/// <param name="heal"></param>
		void TakeHeal(IPlayable source, int heal);

		/// <summary>
		/// This character receives a heal for it's maximum health.
		/// </summary>
		/// <param name="source"></param>
		void TakeFullHeal(IPlayable source);

		/// <summary>
		/// This character receives a specified amount of armor.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="armor"></param>
		void GainArmor(IPlayable source, int armor);

		/// <summary>
		/// The amount of damage this character can output.
		/// </summary>
		int AttackDamage { get; set; }

		/// <summary>
		/// The amount of damage taken during the evaluation of one phase.
		/// </summary>
		int Damage { get; set; }

		/// <summary>
		/// The amount of damage this character is about to take.
		/// </summary>
		int PreDamage { get; set; }

		/// <summary>
		/// The amount of health this character has remaing. This value is returned
		/// AFTER SUBTRACTING the pending damage for this entity.
		/// </summary>
		int Health { get; set; }

		/// <summary>
		/// The starting amount of health of this character.
		/// </summary>
		int BaseHealth { get; }

		/// <summary>
		/// Amount of attacks this character has executed during this turn.
		/// </summary>
		int NumAttacksThisTurn { get; set; }

		/// <summary>
		/// This character is currently attacking another character.
		/// </summary>
		bool IsAttacking { get; set; }
		/// <summary>
		/// This character is currently defending against another character.
		/// </summary>
		bool IsDefending { get; set; }

		/// <summary>
		/// The entityID of the character which wants to attack, by entering the
		/// next combat phase.
		/// The defender is this character.
		/// </summary>
		int ProposedAttacker { get; set; }

		/// <summary>
		/// The entityID of the character which has to defend during the next
		/// combat phase.
		/// The attacker is this character.
		/// </summary>
		int ProposedDefender { get; set; }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		bool CantBeTargetedBySpells { get; set; }
		bool CantBeTargetedByOpponents { get; set; }
		bool CantBeTargetedByHeroPowers { get; set; }
		bool IsExhausted { get; set; }
		bool IsFrozen { get; set; }
		bool IsSilenced { get; set; }
		bool IsImmune { get; set; }
		bool HasTaunt { get; set; }
		bool HasWindfury { get; set; }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
