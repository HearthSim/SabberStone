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
using System.Linq;
using System.Text;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStonePowerLog.Model;

namespace SabberStonePowerLog.src.Sync
{
	public class SyncedGame : Game
	{
		private readonly PowerGame _powerGame;

		public SyncedGame(PowerGame powerGame) : base(new GameConfig())
		{
			_powerGame = powerGame;
		}

		public void Sync()
		{
			Player1 = new Controller(this, _powerGame.Player1.Name, 1, Game.Player1.Id);
			Player2 = new Controller(this, _powerGame.Player2.Name, 2, Game.Player2.Id);

			var entities = _powerGame.Entities.Values;
			var cards = entities.Where(a =>
			{
				if (!a.Data.ContainsKey("CARDTYPE"))
					return false;
				return a.Data["CARDTYPE"] == "MINION" || a.Data["CARDTYPE"] == "SPELL";
			});
			Player1.DeckCards.AddRange(cards.Where(a => a.Data["CONTROLLER"] == Player1.PlayerId.ToString()).Select(a => Cards.FromId(a.Data["CARD_ID"])));
			Player2.DeckCards.AddRange(cards.Where(a => a.Data["CONTROLLER"] == Player2.PlayerId.ToString()).Select(a => Cards.FromId(a.Data["CARD_ID"])));
		}
	}
}
