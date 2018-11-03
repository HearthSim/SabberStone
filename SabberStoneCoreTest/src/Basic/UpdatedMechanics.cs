using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;

namespace SabberStoneCoreTest.Basic
{
	/// <summary>
	/// Tests for changed Mechanics updated since 12.0 patch
	/// </summary>
	public class UpdatedMechanics
	{
		[Fact(Skip = "not yet implemented")]
		public static void CopyEnchantment1()
		{
			var game = new Game(new GameConfig
			{
				FillDecks = true,
				FillDecksPredictably = true,
			});
			game.StartGame();

			// Cards that are resurrected currently do not and will continue not to retain any enchantments,
			// unless specifically stated otherwise.
			// => Implemented already

			// If you copy a card from a deck to a deck,
			// the copy retains enchantments. (eg.Archbishop Benedictus)

			IPlayable barnabus = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("UNG_116t"));
			game.ProcessCard(barnabus, null, true);
			List<Minion> deckMinions = game.CurrentPlayer.DeckZone
				.Where(p => p is Minion)
				.Cast<Minion>()
				.ToList();

			Assert.True(deckMinions.TrueForAll(p => p.Cost == 0));

			game.EndTurn();

			int countBefore = game.CurrentPlayer.DeckZone.Count;
			IPlayable benedictus = game.ProcessCard("Archbishop Benedictus", null, true);

			List<Minion> copiedMinions = game.CurrentPlayer.DeckZone
				.Where(p => p.Id > benedictus.Id && p is Minion)
				.Cast<Minion>()
				.ToList();

			Assert.True(copiedMinions.TrueForAll(p => p.Cost == 0));
		}

		[Fact]
		public static void CopyEnchantment2()
		{
			var game = new Game(new GameConfig
			{
				FillDecks = true,
				FillDecksPredictably = true,
			});
			game.StartGame();

			// If you copy a card from a hand to a hand, the copy retains enchantments. (eg. Mind Vision)

			// If you copy a card from play to play,
			// the copy retains enchantments. (eg. Molten Reflection)
			// => Implemented already

			// If you copy a card from a deck to a hand, the copy retains enchantments. (eg. Thoughtsteal)

			// If you copy a card from a deck to play, the copy retains enchantments. (eg. Mindgames)

			// If you copy a card from hand to play, the copy retains enchantments. (eg. Kobold Illusionist)
		}

		[Fact]
		public static void Transform()
		{
			// Shifter Zerus, Molten Blade, and Shifting Scroll
			// all transform in your hand at the start of every turn.
			// Following the 12.0 update, they will no longer keep any enchantments when they transform.
			// This includes things like hand buffs and Emperor Thaurissan mana-cost discounts.

			// The impact on Voodoo Doll is a little different with the update.
			// If you transform the minion that’s already been cursed by Voodoo Doll,
			// the curse will be broken, and the transformed (and formerly cursed) minion
			// will not be killed when Voodoo Doll dies. Silencing the cursed minion will also break the curse,
			// in addition to silencing the Voodoo Doll.
		}
	}
}
