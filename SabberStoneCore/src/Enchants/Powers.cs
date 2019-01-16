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
using System.Collections.Generic;
using SabberStoneCore.CardSets;
using SabberStoneCore.CardSets.Standard;

//using SabberStoneCore.CardSets.TavernBrawl;
//using SabberStoneCore.CardSets.Adventure;

namespace SabberStoneCore.Enchants
{
	///// <summary>
	///// Interface for instances which support delayed removal.
	///// This interface is used to remove <see cref="OldEnchant"/>s after various
	///// effects were calculated.
	///// </summary>
	///// <seealso cref="Game.LazyRemoves"/>
	//public interface ILazyRemove
	//{
	//	/// <summary>Initiates removal of the implemented type.
	//	/// The instance will remove itself from the game.
	//	/// </summary>
	//	void Remove();
	//}

	internal class Powers
	{
		private static Powers _instance;

		/// <summary>
		/// Contains all defined powers.
		/// The index is the CARDID of the card which powers are defined.
		/// </summary>
		private readonly Dictionary<string, Power> _powerDic;

		/// <summary>
		/// Private constructor as per Singleton pattern.
		/// </summary>
		private Powers()
		{
			_powerDic =
			new Dictionary<string, Power>();

			// Standard
			CoreCardsGen.AddAll(_powerDic);
			Expert1CardsGen.AddAll(_powerDic);

			UngoroCardsGen.AddAll(_powerDic);
			IcecrownCardsGen.AddAll(_powerDic);
			LootapaloozaCardsGen.AddAll(_powerDic);
			GilneasCardsGen.AddAll(_powerDic);
			BoomsdayCardsGen.AddAll(_powerDic);
			TrollCardsGen.AddAll(_powerDic);

			// Rest
			NaxxCardsGen.AddAll(_powerDic);
			GvgCardsGen.AddAll(_powerDic);
			BrmCardsGen.AddAll(_powerDic);
			TgtCardsGen.AddAll(_powerDic);
			LoeCardsGen.AddAll(_powerDic);
			GangsCardsGen.AddAll(_powerDic);
			KaraCardsGen.AddAll(_powerDic);
			OgCardsGen.AddAll(_powerDic);

			HofCardsGen.AddAll(_powerDic);

			// Tavern Brawl
			//TbCardsGen.AddAll(_powerDic);

			// ****************************************
			// * DO NOT UNCOMMENT THEM BEFORE REMOVING
			// * REDUNDANT CARD IMPLEMENTATIONS IN THE
			// * ADV SET!!!
			// ****************************************
			// Adventure
			//BrmCardsGenAdv.AddAll(_powerDic);
			//NaxxCardsGenAdv.AddAll(_powerDic);
			//LoeCardsGenAdv.AddAll(_powerDic);
			//KaraCardsGenAdv.AddAll(_powerDic);
			//IcecrownCardsGenAdv.AddAll(_powerDic);
			//LootapaloozaCardsGenAdv.AddAll(_powerDic);
		}

		/// <summary>
		/// Use the Singleton pattern to provide the same powers to each requester.
		/// </summary>
		public static Powers Instance => _instance ?? (_instance = new Powers());

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public IReadOnlyDictionary<string, Power> Get => _powerDic;
	}
}
