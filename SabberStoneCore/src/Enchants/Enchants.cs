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
using System.Text.RegularExpressions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Enchants
{
    internal static class Enchants
    {
	    private static Regex AttackHealth = new Regex(@"[+](\d)[/][+](\d)");
	    private static Regex SetAttackHealth = new Regex(@"(\d)[/](\d)");
	    private static Regex Attack = new Regex(@"[+](\d) Attack");
	    private static Regex Health = new Regex(@"[+](\d) Health");

	    public static readonly Enchant AddAttackScriptTag =
		    new Enchant(GameTag.ATK, EffectOperator.ADD);
	    public static readonly Enchant AddHealthScriptTag =
		    new Enchant(GameTag.HEALTH, EffectOperator.ADD, 0)
		    {
			    UseScriptTag = true
		    };
	    public static readonly Enchant SetAttackScriptTag =
		    new Enchant(GameTag.ATK, EffectOperator.SET, 0)
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
		    var effects = new List<Effect>();
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
		internal static Effect Attack_N(int n)
		{
			return new Effect(GameTag.ATK, EffectOperator.ADD, n);
		}

		internal static Effect Health_N(int n)
		{
			return new Effect(GameTag.HEALTH, EffectOperator.ADD, n);
		}

		internal static Effect[] AttackHealth_N(int n)
		{
			return new[] {Attack_N(n), Health_N(n)};
		}

		internal static Effect SetAttack(int n)
		{
			return new Effect(GameTag.ATK, EffectOperator.SET, n);
		}

		internal static Effect SetMaxHealth(int n)
		{
			return new Effect(GameTag.HEALTH, EffectOperator.SET, n);
		}

		internal static Effect[] SetAttackHealth(int n)
		{
			return new[] {SetAttack(n), SetMaxHealth(n)};
		}

		internal static Effect ReduceCost(int n)
		{
			return new Effect(GameTag.COST, EffectOperator.SUB, n);
		}

		internal static Effect Taunt => new Effect(GameTag.TAUNT, EffectOperator.SET, 1);

		internal static Effect Windfury => new Effect(GameTag.WINDFURY, EffectOperator.SET, 1);

		internal static Effect Charge => new Effect(GameTag.CHARGE, EffectOperator.SET, 1);

		internal static Effect Immune => new Effect(GameTag.IMMUNE, EffectOperator.SET, 1);

		internal static Effect Lifesteal => new Effect(GameTag.LIFESTEAL, EffectOperator.SET, 1);

		internal static Effect Rush => new Effect(GameTag.RUSH, EffectOperator.SET, 1);

		internal static Effect Echo => new Effect(GameTag.ECHO, EffectOperator.SET, 1);
	}
}
