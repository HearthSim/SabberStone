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
using SabberStoneCore.CardSets.Adventure;
using SabberStoneCore.CardSets.Standard;

//using SabberStoneCore.CardSets.TavernBrawl;
//using SabberStoneCore.CardSets.Adventure;

namespace SabberStoneCore.src.Loader
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

	internal class CardDefs
	{
		private static CardDefs _instance;

		/// <summary>
		/// Contains all defined powers.
		/// The index is the CARDID of the card which powers are defined.
		/// </summary>
		private readonly Dictionary<string, CardDef> _cardDefsDic;

		/// <summary>
		/// Private constructor as per Singleton pattern.
		/// </summary>
		private CardDefs()
		{
			_cardDefsDic = new Dictionary<string, CardDef>();

			// Standard
			CoreCardsGen.AddAll(_cardDefsDic);
			Expert1CardsGen.AddAll(_cardDefsDic);

			GilneasCardsGen.AddAll(_cardDefsDic);
			BoomsdayCardsGen.AddAll(_cardDefsDic);
			TrollCardsGen.AddAll(_cardDefsDic);
			DalaranCardsGen.AddAll(_cardDefsDic);
			UldumCardsGen.AddAll(_cardDefsDic);
			DragonsCardsGen.AddAll(_cardDefsDic);

			// Rest
			NaxxCardsGen.AddAll(_cardDefsDic);
			GvgCardsGen.AddAll(_cardDefsDic);
			BrmCardsGen.AddAll(_cardDefsDic);
			TgtCardsGen.AddAll(_cardDefsDic);
			LoeCardsGen.AddAll(_cardDefsDic);
			GangsCardsGen.AddAll(_cardDefsDic);
			KaraCardsGen.AddAll(_cardDefsDic);
			OgCardsGen.AddAll(_cardDefsDic);
			UngoroCardsGen.AddAll(_cardDefsDic);
			IcecrownCardsGen.AddAll(_cardDefsDic);
			LootapaloozaCardsGen.AddAll(_cardDefsDic);

			HofCardsGen.AddAll(_cardDefsDic);

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
			//LootapaloozaCardsGenAdv.AddAll(_cardDefsDic);
		}

		/// <summary>
		/// Use the Singleton pattern to provide the same powers to each requester.
		/// </summary>
		public static CardDefs Instance => _instance ?? (_instance = new CardDefs());

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public IReadOnlyDictionary<string, CardDef> Get => _cardDefsDic;
	}
}
