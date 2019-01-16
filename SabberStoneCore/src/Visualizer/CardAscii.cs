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
using System.Linq;
using SabberStoneCore.Enums;
using System;

namespace SabberStoneCore.Visualizer
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class CardAsciiBuilder
	{
		private readonly char[][] _baseCardArray = new char[6][]
		{       //   0    1    2    3    4    5    6
            new [] {'+', '-', '-', '-', '-', '-', '+'}, // 0
            new [] {'|', ' ', ' ', ' ', ' ', ' ', '|'}, // 1
            new [] {'|', ' ', ' ', ' ', ' ', ' ', '|'}, // 2
            new [] {'|', ' ', ' ', ' ', ' ', ' ', '|'}, // 3
            new [] {'+', '-', '-', '-', '-', '-', '+'}, // 4
            new [] {' ', ' ', ' ', ' ', ' ', ' ', ' '}  // 5
        };

		private char[][] _generatedcard;

		public CardAsciiBuilder Create()
		{
			_generatedcard = _baseCardArray;
			return this;
		}

		public CardAsciiBuilder ZoneCards(int cnt, Zone zoneType)
		{
			char[] strArray1 = cnt.ToString().PadLeft(2, ' ').ToCharArray();
			char[] strArray2 = zoneType.ToString().ToUpper().PadRight(4, ' ').ToCharArray();
			_generatedcard[2][2] = strArray1[0];
			_generatedcard[2][3] = strArray1[1];
			_generatedcard[3][2] = strArray2[0];
			_generatedcard[3][3] = strArray2[1];
			_generatedcard[3][4] = strArray2[2];
			_generatedcard[3][5] = strArray2[3];
			return this;
		}

		public CardAsciiBuilder Name(string name)
		{
			char[] strArray = name.PadRight(8).ToCharArray();
			_generatedcard[5][0] = strArray[0];
			_generatedcard[5][1] = strArray[1];
			_generatedcard[5][2] = strArray[2];
			_generatedcard[5][3] = strArray[3];
			_generatedcard[5][4] = strArray[4];
			_generatedcard[5][5] = strArray[5];
			_generatedcard[5][6] = strArray[6];
			return this;
		}

		public CardAsciiBuilder SpellText(string text)
		{
			char[] strArray = String.Join("", text.Split(' ').Select(p => p).ToList()).PadRight(15).ToCharArray();
			_generatedcard[1][1] = strArray[0];
			_generatedcard[1][2] = strArray[1];
			_generatedcard[1][3] = strArray[2];
			_generatedcard[1][4] = strArray[3];
			_generatedcard[1][5] = strArray[4];
			_generatedcard[2][1] = strArray[5];
			_generatedcard[2][2] = strArray[6];
			_generatedcard[2][3] = strArray[7];
			_generatedcard[2][4] = strArray[8];
			_generatedcard[2][5] = strArray[9];
			_generatedcard[3][1] = strArray[10];
			_generatedcard[3][2] = strArray[11];
			_generatedcard[3][3] = strArray[12];
			_generatedcard[3][4] = strArray[13];
			_generatedcard[3][5] = strArray[14];
			return this;
		}

		public CardAsciiBuilder Type(CardType cardType)
		{
			char oneChar = cardType.ToString().ToCharArray()[0];
			if (cardType == CardType.SPELL)
			{
				oneChar = 'S';
			}
			_generatedcard[0][5] = oneChar;
			return this;
		}

		public CardAsciiBuilder Exhausted(bool flag)
		{
			char char1 = flag ? 'x' : 'o';
			_generatedcard[0][0] = char1;
			return this;
		}

		public CardAsciiBuilder Cost(int cost)
		{
			char[] strArray = cost.ToString().PadLeft(2, '-').ToCharArray();
			_generatedcard[0][2] = strArray[0];
			_generatedcard[0][3] = strArray[1];
			return this;
		}

		public CardAsciiBuilder AttackDamage(int number)
		{
			char[] strArray = number.ToString().PadLeft(2).ToCharArray();
			_generatedcard[1][1] = strArray[0];
			_generatedcard[1][2] = strArray[1];
			_generatedcard[1][3] = '/';
			return this;
		}

		public CardAsciiBuilder Durability(int number)
		{
			char[] strArray = number.ToString().PadRight(2).ToCharArray();
			_generatedcard[1][4] = strArray[0];
			_generatedcard[1][5] = strArray[1];
			_generatedcard[1][3] = '/';
			return this;
		}

		public CardAsciiBuilder HeroWeaponAttackDamage(int number)
		{
			if (number != 0)
			{
				char[] strArray = number.ToString().PadLeft(2).ToCharArray();
				_generatedcard[2][1] = strArray[0];
				_generatedcard[2][2] = strArray[1];
				_generatedcard[2][3] = '/';
			}
			return this;
		}

		public CardAsciiBuilder HeroWeaponDurability(int number)
		{
			if (number != 0)
			{
				char[] strArray = number.ToString().PadRight(2).ToCharArray();
				_generatedcard[2][4] = strArray[0];
				_generatedcard[2][5] = strArray[1];
				_generatedcard[2][3] = '/';
			}
			return this;
		}

		public CardAsciiBuilder HeroPowerExhausted(bool flag)
		{
			char char1 = flag ? 'x' : 'o';
			_generatedcard[3][3] = '/';
			_generatedcard[3][4] = 'P';
			_generatedcard[3][5] = char1;
			return this;
		}

		public CardAsciiBuilder Health(int number)
		{
			char[] strArray = number.ToString().PadRight(2).ToCharArray();
			_generatedcard[1][4] = strArray[0];
			_generatedcard[1][5] = strArray[1];
			_generatedcard[1][3] = '/';
			return this;
		}


		public CardAsciiBuilder Spellpower(int number)
		{
			if (number > 0)
			{
				_generatedcard[2][1] = number.ToString().ToCharArray()[0];
				_generatedcard[2][2] = 'S';
			}
			return this;
		}

		public CardAsciiBuilder Deathrattle(bool flag)
		{
			char char1 = flag ? 'D' : ' ';
			_generatedcard[2][3] = char1;
			return this;
		}

		public CardAsciiBuilder Battlecry(bool flag)
		{
			char char1 = flag ? 'B' : ' ';
			_generatedcard[2][4] = char1;
			return this;
		}

		public CardAsciiBuilder Inspire(bool flag)
		{
			char char1 = flag ? 'I' : ' ';
			_generatedcard[2][5] = char1;
			return this;
		}

		public CardAsciiBuilder Enrage(bool flag)
		{
			char char1 = flag ? 'e' : '+';
			_generatedcard[4][6] = char1;
			return this;
		}

		public CardAsciiBuilder Windfury(bool flag)
		{
			char char1 = flag ? 'w' : '-';
			_generatedcard[4][5] = char1;
			return this;
		}

		public CardAsciiBuilder Frozen(bool flag)
		{
			char char1 = flag ? 'f' : '-';
			_generatedcard[4][4] = char1;
			return this;
		}

		public CardAsciiBuilder Stealth(bool flag)
		{
			char char1 = flag ? 's' : '-';
			_generatedcard[4][3] = char1;
			return this;
		}

		public CardAsciiBuilder DivineShield(bool flag)
		{
			char char1 = flag ? 'd' : '-';
			_generatedcard[4][2] = char1;
			return this;
		}

		public CardAsciiBuilder Taunt(bool flag)
		{
			char char1 = flag ? 't' : '-';
			_generatedcard[4][1] = char1;
			return this;
		}

		public CardAsciiBuilder Charge(bool flag)
		{
			char char1 = flag ? 'c' : '+';
			_generatedcard[4][0] = char1;
			return this;
		}

		public CardAsciiBuilder Freeze(bool flag)
		{
			char char1 = flag ? 'F' : '|';
			_generatedcard[3][6] = char1;
			return this;
		}

		public CardAsciiBuilder Silenced(bool flag)
		{
			char char1 = flag ? 'S' : ' ';
			_generatedcard[3][3] = char1;
			return this;
		}

		public CardAsciiBuilder Poisonus(bool flag)
		{
			char char1 = flag ? 'P' : '|';
			_generatedcard[3][0] = char1;
			return this;
		}

		public char[][] Build()
		{
			return _generatedcard;
		}

		public static string[] PrintHelp()
		{
			string[] result = new string[18];

			char[][] cardAscii = new CardAsciiBuilder().Create().AttackDamage(8).Health(5).Cost(3)
				.Name("HS Card").Type(CardType.MINION)
				.Battlecry(true).Deathrattle(true).Exhausted(true).Spellpower(2).Inspire(true)
				.Poisonus(true).Freeze(true).Silenced(true)
				.Charge(true).DivineShield(true).Frozen(true).Stealth(true).Enrage(true).Taunt(true).Windfury(true)
				.Build();

			result[0] = "   " + new string(cardAscii[0]) + " ";
			result[1] = "   " + new string(cardAscii[1]) + " ";
			result[2] = "   " + new string(cardAscii[2]) + " ";
			result[3] = "   " + new string(cardAscii[3]) + " ";
			result[4] = "   " + new string(cardAscii[4]) + " ";
			result[5] = "   " + new string(cardAscii[5]) + " ";

			char[][] notExhausted = new CardAsciiBuilder().Create().Name("!Exhaus").Exhausted(false).Build();

			result[0] += new string(notExhausted[0]) + " ";
			result[1] += new string(notExhausted[1]) + " ";
			result[2] += new string(notExhausted[2]) + " ";
			result[3] += new string(notExhausted[3]) + " ";
			result[4] += new string(notExhausted[4]) + " ";
			result[5] += new string(notExhausted[5]) + " ";

			char[][] exhausted = new CardAsciiBuilder().Create().Name("Exhaust").Exhausted(true).Build();

			result[0] += new string(exhausted[0]) + " ";
			result[1] += new string(exhausted[1]) + " ";
			result[2] += new string(exhausted[2]) + " ";
			result[3] += new string(exhausted[3]) + " ";
			result[4] += new string(exhausted[4]) + " ";
			result[5] += new string(exhausted[5]) + " ";

			char[][] cost = new CardAsciiBuilder().Create().Name("Cost").Cost(5).Build();

			result[0] += new string(cost[0]) + " ";
			result[1] += new string(cost[1]) + " ";
			result[2] += new string(cost[2]) + " ";
			result[3] += new string(cost[3]) + " ";
			result[4] += new string(cost[4]) + " ";
			result[5] += new string(cost[5]) + " ";

			char[][] type = new CardAsciiBuilder().Create().Name("Type").Type(CardType.MINION).Build();

			result[0] += new string(type[0]) + " ";
			result[1] += new string(type[1]) + " ";
			result[2] += new string(type[2]) + " ";
			result[3] += new string(type[3]) + " ";
			result[4] += new string(type[4]) + " ";
			result[5] += new string(type[5]) + " ";

			char[][] atk = new CardAsciiBuilder().Create().Name("Attack").AttackDamage(5).Build();

			result[0] += new string(atk[0]) + " ";
			result[1] += new string(atk[1]) + " ";
			result[2] += new string(atk[2]) + " ";
			result[3] += new string(atk[3]) + " ";
			result[4] += new string(atk[4]) + " ";
			result[5] += new string(atk[5]) + " ";

			char[][] health = new CardAsciiBuilder().Create().Name("Health").Health(5).Build();

			result[0] += new string(health[0]) + " ";
			result[1] += new string(health[1]) + " ";
			result[2] += new string(health[2]) + " ";
			result[3] += new string(health[3]) + " ";
			result[4] += new string(health[4]) + " ";
			result[5] += new string(health[5]) + " ";

			char[][] spell = new CardAsciiBuilder().Create().Name("SpelPow").Spellpower(1).Build();

			result[0] += new string(spell[0]) + " ";
			result[1] += new string(spell[1]) + " ";
			result[2] += new string(spell[2]) + " ";
			result[3] += new string(spell[3]) + " ";
			result[4] += new string(spell[4]) + " ";
			result[5] += new string(spell[5]) + " ";

			char[][] death = new CardAsciiBuilder().Create().Name("DeathR").Deathrattle(true).Build();

			result[0] += new string(death[0]) + " ";
			result[1] += new string(death[1]) + " ";
			result[2] += new string(death[2]) + " ";
			result[3] += new string(death[3]) + " ";
			result[4] += new string(death[4]) + " ";
			result[5] += new string(death[5]) + " ";

			char[][] battle = new CardAsciiBuilder().Create().Name("BatlCry").Battlecry(true).Build();

			result[0] += new string(battle[0]) + " ";
			result[1] += new string(battle[1]) + " ";
			result[2] += new string(battle[2]) + " ";
			result[3] += new string(battle[3]) + " ";
			result[4] += new string(battle[4]) + " ";
			result[5] += new string(battle[5]) + " ";

			char[][] insp = new CardAsciiBuilder().Create().Name("Inspir").Inspire(true).Build();

			result[0] += new string(insp[0]) + " ";
			result[1] += new string(insp[1]) + " ";
			result[2] += new string(insp[2]) + " ";
			result[3] += new string(insp[3]) + " ";
			result[4] += new string(insp[4]) + " ";
			result[5] += new string(insp[5]) + " ";

			char[][] poison = new CardAsciiBuilder().Create().Name("Poisons").Poisonus(true).Build();

			result[06] = "   " + new string(poison[0]) + " ";
			result[07] = "   " + new string(poison[1]) + " ";
			result[08] = "   " + new string(poison[2]) + " ";
			result[09] = "   " + new string(poison[3]) + " ";
			result[10] = "   " + new string(poison[4]) + " ";
			result[11] = "   " + new string(poison[5]) + " ";

			char[][] silence = new CardAsciiBuilder().Create().Name("Silencd").Silenced(true).Build();

			result[06] += new string(silence[0]) + " ";
			result[07] += new string(silence[1]) + " ";
			result[08] += new string(silence[2]) + " ";
			result[09] += new string(silence[3]) + " ";
			result[10] += new string(silence[4]) + " ";
			result[11] += new string(silence[5]) + " ";

			char[][] freeze = new CardAsciiBuilder().Create().Name("Freeze").Freeze(true).Build();

			result[06] += new string(freeze[0]) + " ";
			result[07] += new string(freeze[1]) + " ";
			result[08] += new string(freeze[2]) + " ";
			result[09] += new string(freeze[3]) + " ";
			result[10] += new string(freeze[4]) + " ";
			result[11] += new string(freeze[5]) + " ";

			char[][] charge = new CardAsciiBuilder().Create().Name("Charge").Charge(true).Build();

			result[06] += new string(charge[0]) + " ";
			result[07] += new string(charge[1]) + " ";
			result[08] += new string(charge[2]) + " ";
			result[09] += new string(charge[3]) + " ";
			result[10] += new string(charge[4]) + " ";
			result[11] += new string(charge[5]) + " ";

			char[][] taunt = new CardAsciiBuilder().Create().Name("Taunt").Taunt(true).Build();

			result[06] += new string(taunt[0]) + " ";
			result[07] += new string(taunt[1]) + " ";
			result[08] += new string(taunt[2]) + " ";
			result[09] += new string(taunt[3]) + " ";
			result[10] += new string(taunt[4]) + " ";
			result[11] += new string(taunt[5]) + " ";

			char[][] divine = new CardAsciiBuilder().Create().Name("DivShil").DivineShield(true).Build();

			result[06] += new string(divine[0]) + " ";
			result[07] += new string(divine[1]) + " ";
			result[08] += new string(divine[2]) + " ";
			result[09] += new string(divine[3]) + " ";
			result[10] += new string(divine[4]) + " ";
			result[11] += new string(divine[5]) + " ";

			char[][] stealth = new CardAsciiBuilder().Create().Name("Stealth").Stealth(true).Build();

			result[06] += new string(stealth[0]) + " ";
			result[07] += new string(stealth[1]) + " ";
			result[08] += new string(stealth[2]) + " ";
			result[09] += new string(stealth[3]) + " ";
			result[10] += new string(stealth[4]) + " ";
			result[11] += new string(stealth[5]) + " ";

			char[][] windfury = new CardAsciiBuilder().Create().Name("WiFury").Windfury(true).Build();

			result[06] += new string(windfury[0]) + " ";
			result[07] += new string(windfury[1]) + " ";
			result[08] += new string(windfury[2]) + " ";
			result[09] += new string(windfury[3]) + " ";
			result[10] += new string(windfury[4]) + " ";
			result[11] += new string(windfury[5]) + " ";

			char[][] enraged = new CardAsciiBuilder().Create().Name("Enraged").Enrage(true).Build();

			result[06] += new string(enraged[0]) + " ";
			result[07] += new string(enraged[1]) + " ";
			result[08] += new string(enraged[2]) + " ";
			result[09] += new string(enraged[3]) + " ";
			result[10] += new string(enraged[4]) + " ";
			result[11] += new string(enraged[5]) + " ";

			char[][] heroweap = new CardAsciiBuilder().Create().Name("WeapAtk").HeroWeaponAttackDamage(3).Build();

			result[12] = "   " + new string(heroweap[0]) + " ";
			result[13] = "   " + new string(heroweap[1]) + " ";
			result[14] = "   " + new string(heroweap[2]) + " ";
			result[15] = "   " + new string(heroweap[3]) + " ";
			result[16] = "   " + new string(heroweap[4]) + " ";
			result[17] = "   " + new string(heroweap[5]) + " ";

			char[][] herodura = new CardAsciiBuilder().Create().Name("WeapDur").HeroWeaponDurability(3).Build();

			result[12] += new string(herodura[0]) + " ";
			result[13] += new string(herodura[1]) + " ";
			result[14] += new string(herodura[2]) + " ";
			result[15] += new string(herodura[3]) + " ";
			result[16] += new string(herodura[4]) + " ";
			result[17] += new string(herodura[5]) + " ";

			char[][] pownotex = new CardAsciiBuilder().Create().Name("Pow!Exh").HeroPowerExhausted(false).Build();

			result[12] += new string(pownotex[0]) + " ";
			result[13] += new string(pownotex[1]) + " ";
			result[14] += new string(pownotex[2]) + " ";
			result[15] += new string(pownotex[3]) + " ";
			result[16] += new string(pownotex[4]) + " ";
			result[17] += new string(pownotex[5]) + " ";

			char[][] powex = new CardAsciiBuilder().Create().Name("Pow!Exh").HeroPowerExhausted(true).Build();

			result[12] += new string(powex[0]) + " ";
			result[13] += new string(powex[1]) + " ";
			result[14] += new string(powex[2]) + " ";
			result[15] += new string(powex[3]) + " ";
			result[16] += new string(powex[4]) + " ";
			result[17] += new string(powex[5]) + " ";

			return result;
		}
	}
	#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
