using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Enchants
{
    public static class Enchants
    {
	    private static Regex AttackHealth = new Regex(@"[+](\d)[/][+](\d)");
	    private static Regex Attack = new Regex(@"[+](\d) Attack");
	    private static Regex Health = new Regex(@"[+](\d) Health");

	    public static Enchant GetAutoEnchantFromText(string cardId)
	    {
			string text = Cards.FromId(cardId).Text;
		    var effects = new List<Effect>();

		    Match attackHealth = AttackHealth.Match(text);
		    Match attack = Attack.Match(text);
		    Match health = Health.Match(text);

			if (attackHealth.Success)
			{
				effects.Add(Effects.Attack_N(Int32.Parse(attackHealth.Captures[0].Value)));
				effects.Add(Effects.Health_N(Int32.Parse(attackHealth.Captures[1].Value)));
			}
		    else if (attack.Success)
		    {
			    effects.Add(Effects.Attack_N(Int32.Parse(attack.Captures[0].Value)));
		    }
		    else if (health.Success)
		    {
			    effects.Add(Effects.Health_N(Int32.Parse(attack.Captures[0].Value)));
		    }

		    if (text.Contains(@"<b>Taunt</b>"))
		    {
			    effects.Add(Effects.Taunt);
		    }

		    if (text.Contains(@"<b>Windfury</b>"))
		    {
			    effects.Add(Effects.Windfury);
		    }

		    if (text.Contains(@"<b>Charge</b>"))
		    {
			    effects.Add(Effects.Charge);
		    }

		    return new Enchant
		    {
			    Effects = effects.ToArray()
		    };

		    throw new Exception();
	    }
    }

	internal static class Effects
	{
		internal static Effect Attack_N(int n)
		{
			return new Effect
			{
				Tag = GameTag.ATK,
				Operator = EffectOperator.ADD,
				Value = n
			};
		}

		internal static Effect Health_N(int n)
		{
			return new Effect
			{
				Tag = GameTag.HEALTH,
				Operator = EffectOperator.ADD,
				Value = n
			};
		}

		internal static Effect Taunt => new Effect
		{
			Tag = GameTag.TAUNT,
			Operator = EffectOperator.SET,
			Value = 1
		};

		internal static Effect Windfury => new Effect
		{
			Tag = GameTag.WINDFURY,
			Operator = EffectOperator.SET,
			Value = 1
		};

		internal static Effect Charge => new Effect
		{
			Tag = GameTag.CHARGE,
			Operator = EffectOperator.SET,
			Value = 1
		};
	}
}
