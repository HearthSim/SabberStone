using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class InvalidCardsGen
	{
		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [EX1_295] Ice Block - COST:3 
			// - Fac: neutral, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("EX1_295", new Power {
				// TODO [EX1_295] Ice Block && Test: Ice Block_EX1_295
				InfoCardId = "EX1_295o",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [EX1_050] Coldlight Oracle - COST:3 [ATK:2/HP:2] 
			// - Race: murloc, Fac: neutral, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Each player draws 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_050", new Power {
				// TODO [EX1_050] Coldlight Oracle && Test: Coldlight Oracle_EX1_050
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_620] Molten Giant - COST:20 [ATK:8/HP:8] 
			// - Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less for each damage your hero has taken.
			// --------------------------------------------------------
			cards.Add("EX1_620", new Power {
				// TODO [EX1_620] Molten Giant && Test: Molten Giant_EX1_620
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Mage(cards);
			Neutral(cards);
		}
	}
}
