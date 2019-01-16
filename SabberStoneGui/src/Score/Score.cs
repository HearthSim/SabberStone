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
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCoreGui.Score
{
	public interface IScore
	{
		Controller Controller { get; set; }
		int Rate();
	}

	public class Score : IScore
	{
		public Controller Controller { get; set; }

		public int HeroHp => Controller.Hero.Health;

		public int OpHeroHp => Controller.Opponent.Hero.Health;

		public int HeroAtk => Controller.Hero.TotalAttackDamage;

		public int OpHeroAtk => Controller.Opponent.Hero.TotalAttackDamage;

		public HandZone HandZone => Controller.HandZone;

		public int HandTotCost => HandZone.Sum(p => p.Cost);

		public int HandCnt => Controller.HandZone.Count;

		public int OpHandCnt => Controller.Opponent.HandZone.Count;

		public int DeckCnt => Controller.DeckZone.Count;

		public int OpDeckCnt => Controller.Opponent.DeckZone.Count;

		public BoardZone BoardZone => Controller.BoardZone;

		public BoardZone OpBoardZone => Controller.Opponent.BoardZone;

		public int MinionTotAtk => BoardZone.Sum(p => p.AttackDamage);

		public int OpMinionTotAtk => OpBoardZone.Sum(p => p.AttackDamage);

		public int MinionTotHealth => BoardZone.Sum(p => p.Health);

		public int OpMinionTotHealth => OpBoardZone.Sum(p => p.Health);

		public int MinionTotHealthTaunt => BoardZone.Where(p => p.HasTaunt).Sum(p => p.Health);

		public int OpMinionTotHealthTaunt => OpBoardZone.Where(p => p.HasTaunt).Sum(p => p.Health);

		public virtual int Rate()
		{
			return 0;
		}

	}
}
