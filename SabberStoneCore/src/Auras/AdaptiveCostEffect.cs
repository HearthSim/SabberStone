using System;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

// ReSharper disable InconsistentNaming

namespace SabberStoneCore.Auras
{
	public partial interface IAdaptiveCostEffect : IAura
	{
		/// <summary>Apply cost reduction to current cost</summary>
		/// <value><see cref="ICharacter"/></value>
		int Apply(int value);
	}

	/// <summary>
	/// Implementation of the specific effects of varying cost. e.g. Giants
	/// </summary>
	public class AdaptiveCostEffect : IAdaptiveCostEffect
	{
		private readonly Playable _owner;

		private readonly EffectOperator _operator;
		private readonly Func<IPlayable, int> _costFunction;
		private readonly SelfCondition _condition;

		/// <summary>
		/// Creates an Adaptive Cost Effect that varies the owner's cost.
		/// (e.g. Giants needs subtraction. They costs less for the calculated value from the given cost function.)
		/// The argument of the cost function is the owner entity.
		/// </summary>
		/// <param name="costFunc">The cost function to calculate the amount the owner costs varies.</param>
		/// <param name="operator">This determines how cost varies.</param>
		public AdaptiveCostEffect(Func<IPlayable, int> costFunc, EffectOperator @operator = EffectOperator.SUB,
			SelfCondition triggerCondition = null)
		{
			_costFunction = costFunc;
			_operator = @operator;
			_condition = triggerCondition;
		}

		private AdaptiveCostEffect(AdaptiveCostEffect prototype, IPlayable owner)
		{
			if (!(owner is Playable p))
				throw new Exception($"Can't activate {this} to non-playable {owner}");

			_owner = p;

			_condition = prototype._condition;
			_costFunction = prototype._costFunction;
			_operator = prototype._operator;
		}

		public IPlayable Owner => _owner;

		public void Activate(Playable owner, bool cloning = false)
		{
			if (!cloning && !(owner.Zone is HandZone)) return;

			var instance = new AdaptiveCostEffect(this, owner);

			if (owner._costManager == null)
				owner._costManager = new Playable.CostManager();

			owner._costManager.ActivateAdaptiveEffect(instance);
			owner.OngoingEffect = instance;
			owner.Game.Auras.Add(instance);
		}

		public int Apply(int value)
		{
			if (_condition == null || _condition.Eval(_owner))
			{
				if (_costFunction != null)
				{
					if (_operator == EffectOperator.SUB)
						return value - _costFunction.Invoke(_owner);
					if (_operator == EffectOperator.SET)
						return _costFunction.Invoke(_owner);
					if (_operator == EffectOperator.ADD)
						return value + _costFunction.Invoke(_owner);
					if (_operator == EffectOperator.MUL)
						return value * _costFunction.Invoke(_owner);
				}
			}
			return value;
		}

		public void Remove()
		{
			_owner.OngoingEffect = null;
			_owner.Game.Auras.Remove(this);
			_owner._costManager?.DeactivateAdaptiveEffect();
		}

		void IAura.Activate(IPlayable owner)
		{
			Activate((Playable)owner, false);
		}

		public void Update()
		{
			_owner._costManager.UpdateAdaptiveEffect();
		}

		public void Clone(IPlayable clone)
		{
			Activate((Playable)clone, true);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[ACE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}

		public static readonly AdaptiveCostEffect NumEachMinionDiedThisTurn
			= new AdaptiveCostEffect(p => p.Controller.NumFriendlyMinionsThatDiedThisTurn
			                              + p.Controller.Opponent.NumFriendlyMinionsThatDiedThisTurn);
	}
}
