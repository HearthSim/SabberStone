using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;
using System.Text;

namespace SabberStoneCoreConsole
{
	internal static class Extensions
	{

		public static string FullPrint(this Game game)
		{
			var str = new StringBuilder();
			str.AppendLine(game.Player1.HandZone.FullPrint());
			str.AppendLine(game.Player1.Hero.FullPrint());
			str.AppendLine(game.Player1.BoardZone.FullPrint());
			str.AppendLine(game.Player2.BoardZone.FullPrint());
			str.AppendLine(game.Player2.Hero.FullPrint());
			str.AppendLine(game.Player2.HandZone.FullPrint());
			return str.ToString();
		}

		public static string FullPrint(this Hero hero)
		{
			var str = new StringBuilder();
			string mStr = hero.Weapon != null ? $"[{hero.Weapon.Card.Name}[{hero.Weapon.AttackDamage}/{hero.Weapon.Durability}]]" : "[NO WEAPON]";
			str.Append($"[HERO][{hero}][ATK{hero.AttackDamage}/AR{hero.Armor}/HP{hero.Health}][{mStr}][SP{hero.SpellPowerDamage}]");
			str.Append($"[ENCH {hero.Enchants.Count}]");
			str.Append($"[TRIG {hero.Triggers.Count}]");
			return str.ToString();
		}

		public static string FullPrint(this Choice choice)
		{
			var str = new StringBuilder();
			str.Append($"{choice.Controller.Name}[ChoiceType:{choice.ChoiceType}][ChoiceAction:{choice.ChoiceAction}][");
			str.Append(String.Join(",", choice.Choices));
			return str.ToString();
		}
	}
}
