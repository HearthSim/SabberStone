using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
    internal static class Enchants
    {
	    private static Regex AttackHealth = new Regex(@"[+](\d)[/][+](\d)");
	    private static Regex SetAttackHealth = new Regex(@"(\d)[/](\d)");
	    private static Regex Attack = new Regex(@"[+](\d) Attack");
	    private static Regex Health = new Regex(@"[+](\d) Health");

	    public static readonly Enchant AddAttackScriptTag =
		    new Enchant(Effects.Attack_N(0))
		    {
			    UseScriptTag = true
		    };
	    public static readonly Enchant AddHealthScriptTag =
		    new Enchant(Effects.Health_N(0))
		    {
			    UseScriptTag = true
		    };
	    public static readonly Enchant SetAttackScriptTag =
		    new Enchant(Effects.SetAttack(0))
		    {
			    UseScriptTag = true
		    };
		public static readonly Enchant AddAttackHealthScriptTag =
		    new Enchant(Effects.AttackHealth_N(0))
		    {
			    UseScriptTag = true
		    };
	    public static readonly Enchant SetAttackHealthScriptTag =
		    new Enchant(Effects.SetAttackHealth(0))
		    {
			    UseScriptTag = true
		    };

		/// <summary>
		/// Generate proper <see cref="Enchant"/> from the text of the given card.
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
		public static Enchant GetAutoEnchantFromText(string cardId)
		{
			Card card = Cards.FromId(cardId);
			string text = card.Text;
		    var effects = new List<IEffect>();
			bool oneTurn = false;
			bool mod = false;

			Match attackHealth = AttackHealth.Match(text);
		    Match attack = Attack.Match(text);
		    Match health = Health.Match(text);
		    Match set = SetAttackHealth.Match(text);

			if (attackHealth.Success)
			{
				effects.Add(Effects.Attack_N(Int32.Parse(attackHealth.Groups[1].Value)));
				effects.Add(Effects.Health_N(Int32.Parse(attackHealth.Groups[2].Value)));
			}
		    else if (attack.Success)
		    {
			    effects.Add(Effects.Attack_N(Int32.Parse(attack.Groups[1].Value)));
		    }
		    else if (health.Success)
		    {
			    effects.Add(Effects.Health_N(Int32.Parse(health.Groups[1].Value)));
		    }
			else if
				(set.Success)
			{
				effects.Add(Effects.SetAttack(Int32.Parse(set.Groups[1].Value)));
				effects.Add(Effects.SetMaxHealth(Int32.Parse(set.Groups[2].Value)));
			}
			// generate magnetic enchants
			else if (card[GameTag.MODULAR] == 1)
			{
				effects.AddRange(Effects.AttackHealth_N(0));
				mod = true;
			}

			if (text.Contains(@"<b>Taunt</b>"))
		    {
			    effects.Add(Effects.TauntEff);
		    }

		    if (text.Contains(@"<b>Windfury</b>"))
		    {
			    effects.Add(Effects.Windfury);
		    }

		    if (text.Contains(@"<b>Charge</b>"))
		    {
			    effects.Add(Effects.Charge);
		    }

		    if (text.Contains(@"<b>Immune</b>"))
		    {
			    effects.Add(Effects.Immune);
		    }

		    if (text.Contains(@"<b>Divine Shield</b>"))
		    {
			    effects.Add(new Effect(GameTag.DIVINE_SHIELD, EffectOperator.SET, 1));
		    }

		    if (text.Contains(@"<b>Poisonous</b>"))
		    {
			    effects.Add(new Effect(GameTag.POISONOUS, EffectOperator.SET, 1));
		    }

		    if (text.Contains(@"<b>Lifesteal</b>"))
		    {
			    effects.Add(Effects.Lifesteal);
		    }

		    if (text.Contains(@"<b>Rush</b>"))
		    {
			    effects.Add(Effects.Rush);
		    }

			if (text.Contains("this turn"))
		    {
				oneTurn = true;
		    }

			var output = new Enchant(effects.ToArray())
			{
				IsOneTurnEffect = oneTurn
			};
			if (mod)
				output.UseScriptTag = true;

			return output;
	    }


    }

	internal static class Effects
	{
		internal static IEffect Attack_N(int n)
		{
			return new GenericEffect<ATK, Character>(ATK.Singleton, EffectOperator.ADD, n);
		}

		internal static IEffect Health_N(int n)
		{
			return new GenericEffect<Health, Character>(Health.Singleton, EffectOperator.ADD, n);
		}

		internal static IEffect[] AttackHealth_N(int n)
		{
			return new[] {Attack_N(n), Health_N(n)};
		}

		internal static IEffect SetAttack(int n)
		{
			return new GenericEffect<ATK, Character>(ATK.Singleton, EffectOperator.SET, n);
		}

		internal static IEffect SetMaxHealth(int n)
		{
			return new GenericEffect<Health, Character>(Health.Singleton, EffectOperator.SET, n);
		}

		internal static IEffect[] SetAttackHealth(int n)
		{
			return new[] {SetAttack(n), SetMaxHealth(n)};
		}

		internal static IEffect ReduceCost(int n)
		{
			return new GenericEffect<Cost, Playable>(Cost.Singleton, EffectOperator.SUB, n);
		}

		internal static IEffect SetCost(int n)
		{
			return new GenericEffect<Cost, Playable>(Cost.Singleton, EffectOperator.SET, n);
		}

		internal static IEffect AddCost(int n)
		{
			return new GenericEffect<Cost, Playable>(Cost.Singleton, EffectOperator.ADD, n);
		}

		internal static IEffect TauntEff => new GenericEffect<Taunt, Character>(Taunt.Singleton, EffectOperator.SET, 1);

		internal static IEffect StealthEff =>
			new GenericEffect<Stealth, Character>(Stealth.Singleton, EffectOperator.SET, 1);

		internal static Effect Windfury => new Effect(GameTag.WINDFURY, EffectOperator.SET, 1);

		internal static Effect Charge => new Effect(GameTag.CHARGE, EffectOperator.SET, 1);

		internal static Effect Immune => new Effect(GameTag.IMMUNE, EffectOperator.SET, 1);

		internal static Effect Lifesteal => new Effect(GameTag.LIFESTEAL, EffectOperator.SET, 1);

		internal static Effect Rush => new Effect(GameTag.RUSH, EffectOperator.SET, 1);

		internal static Effect Echo => new Effect(GameTag.ECHO, EffectOperator.SET, 1);


		private class Cost : IntAttr<Playable>
		{
			public static readonly Cost Singleton = new Cost();

			protected override ref int? GetRef(Playable entity)
			{
				return ref entity._modifiedCost;
			}

			protected override int GetCardValue(Playable entity)
			{
				return entity.Card.Cost;
			}

			public override void ApplyAura(Playable entity, EffectOperator @operator, int value)
			{
				Playable.CostManager costManager = entity._costManager;
				if (costManager == null)
				{
					costManager = new Playable.CostManager();
					entity._costManager = costManager;
				}

				costManager.AddCostAura(@operator, value);
			}

			public override void RemoveAura(Playable entity, EffectOperator @operator, int value)
			{
				entity._costManager.RemoveCostAura(@operator, value);
			}

			protected override ref int GetAuraRef(AuraEffects auraEffects)
			{
				throw new NotImplementedException();
			}
		}

		private class ATK : IntAttr<Character>
		{
			public static readonly ATK Singleton = new ATK();

			protected override ref int? GetRef(Character entity)
			{
				return ref entity._modifiedATK;
			}

			protected override int GetCardValue(Character entity)
			{
				return entity.Card.ATK;
			}

			protected override ref int GetAuraRef(AuraEffects auraEffects)
			{
				return ref auraEffects._data[3];
			}

			public override void Apply(Character entity, EffectOperator @operator, int value)
			{
				if (@operator == EffectOperator.SET)
				{
					for (int i = entity.Game.OneTurnEffects.Count - 1; i >= 0; i--)
					{
						(int id, IEffect eff) = entity.Game.OneTurnEffects[i];
						if (id != entity.Id || !(eff is GenericEffect<ATK, Character>)) continue;
						entity.Game.OneTurnEffects.RemoveAt(i);
					}
				}

				base.Apply(entity, @operator, value);
			}

			public override void ApplyAura(Character entity, EffectOperator @operator, int value)
			{
				base.ApplyAura(entity, @operator, value);
			}
		}

		private class Health : IntAttr<Character>
		{
			public static readonly Health Singleton = new Health();

			protected override ref int? GetRef(Character entity)
			{
				return ref entity._modifiedHealth;
			}

			protected override int GetCardValue(Character entity)
			{
				return entity.Card.Health;
			}

			protected override ref int GetAuraRef(AuraEffects auraEffects)
			{
				return ref auraEffects._data[4];
			}

			public override void Apply(Character entity, EffectOperator @operator, int value)
			{
				if (@operator == EffectOperator.SET)
				{
					if (entity is Hero h)
					{
						int hbh = h.BaseHealth;
						if (hbh > value)
							h.Damage = hbh - value;
						else
							h.Health = value;
						return;
					}

					if (entity is Minion m)
					{
						m.Health = value;
						return;
					}
				}

				base.Apply(entity, @operator, value);
			}

			public override void RemoveAura(Character entity, EffectOperator @operator, int value)
			{
				base.RemoveAura(entity, @operator, value);

				if (@operator == EffectOperator.ADD)
					entity.Damage -= value;
			}
		}

		private class Stealth : BoolAttr<Character>
		{
			public static readonly Stealth Singleton = new Stealth();

			protected override ref bool? GetRef(Character entity)
			{
				return ref entity._modifiedStealth;
			}

			protected override ref int GetAuraRef(AuraEffects auraEffects)
			{
				throw new NotImplementedException();
			}
		}

		private class Taunt : BoolAttr<Character>
		{
			public static readonly Taunt Singleton = new Taunt();

			protected override ref bool? GetRef(Character entity)
			{
				return ref entity._modifiedTaunt;
			}

			protected override ref int GetAuraRef(AuraEffects auraEffects)
			{
				return ref auraEffects._data[6];
			}
		}
	}
}
