using System.Linq;
using System.Text;
using SabberStoneCore.Actions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Implementation of the Enrage effect.
	/// </summary>
	public class EnrageEffect : Aura
	{
		private bool _enraged;
		private IPlayable _target;
		private Enchantment _currentInstance;

		public EnrageEffect(AuraType type, params IEffect[] effects) : base(type, effects)
		{
		}

		public EnrageEffect(AuraType type, string enchantmentId) : base(type, enchantmentId)
		{

		}

		private EnrageEffect(EnrageEffect prototype, IPlayable owner) : base(prototype, owner)
		{
			_enraged = prototype._enraged;
			Restless = true;            //	can cause performance issue; should replace with heal trigger ?
			switch (Type)
			{
				case AuraType.SELF:
					_target = owner;
					break;
				case AuraType.WEAPON:
					_target = owner.Controller.Hero.Weapon;
					break;
			}
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			//if (owner is Enchantment e)
			//	owner = (IPlayable)e.Target;

			var instance = new EnrageEffect(this, owner);

			owner.Game.Auras.Add(instance);
			owner.OngoingEffect = instance;
		}

		public override void Update()
		{
			var m = (Minion) Owner;

			// Remove this EnrageEffect from the target
			if (!On)
			{
				Game.Auras.Remove(this);

				if (!_enraged) return;

				// Spiteful Smith
				if (Type == AuraType.WEAPON)
				{
					Weapon weapon = m.Controller.Hero.Weapon;
					if (weapon == null)
						return;

					if (_target != weapon)
						return;
				}

				foreach (IEffect eff in EnchantmentCard.Power.Enchant.Effects)
				{
					eff.RemoveFrom(_target);
				}
				_currentInstance?.Remove();
				//if (_target != null)
				//	for (int i = 0; i < Effects.Length; i++)
				//		Effects[i].RemoveFrom(_target.AuraEffects);
			}

			if (Type == AuraType.WEAPON)
			{
				Weapon weapon = m.Controller.Hero.Weapon;
				if (weapon == null)
					return;

				if (_target != weapon)
				{
					_currentInstance?.Remove();
					_currentInstance = null;

					_target = weapon;
				}
			}

			if (!_enraged)
			{
				if (m.Damage == 0) return;
				//if (_target != null)
				//	for (int i = 0; i < Effects.Length; i++)
				//		Effects[i].ApplyTo(_target.AuraEffects);
				Generic.AddEnchantmentBlock.Invoke(m.Controller, EnchantmentCard, m, _target, 0, 0, false);
				if (Game.History)
					_currentInstance = _target.AppliedEnchantments.Last();
				_enraged = true;
			}
			else
			{
				if (m.Damage != 0) return;

				_currentInstance?.Remove();
				_enraged = false;
			}
		}

		public override void Clone(IPlayable clone)
		{
			Activate(clone, true);
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[EE:");
			sb.Append(Owner.Card.Name);
			sb.Append("]");
			return sb.ToString();
		}
	}
}
