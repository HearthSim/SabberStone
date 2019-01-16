using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Enums;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;

namespace SabberStoneCoreTest.Basic
{
	/// <summary>
	/// Tests for changed Mechanics updated since 12.0 patch
	/// </summary>
	public class UpdatedMechanics
	{
		[Fact]
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

			// If you copy a card from play to play,
			// the copy retains enchantments. (eg. Molten Reflection)
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
				StartPlayer = 1,
				FillDecks = false,
				Shuffle = false,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Mind Control"),
					Cards.FromName("Obsidian Statue")
				}
			});
			game.StartGame();

			// If you copy a card from a hand to a hand, the copy retains enchantments. (eg. Mind Vision)
			Spell testSubject = (Spell)game.CurrentPlayer.HandZone[0];
			Minion testSubject2 = (Minion) game.CurrentPlayer.HandZone[1];
			int cardCost = testSubject.Card.Cost;
			// Should not copy effects from Auras
			game.ProcessCard("Radiant Elemental", asZeroCost: true);
			Assert.Equal(cardCost - 1, testSubject.Cost);
			game.ProcessCard("Deathaxe Punisher", asZeroCost: true);
			Assert.Equal(testSubject2.Card.ATK + 2, testSubject2.AttackDamage);
			Assert.Equal(testSubject2.Card.Health + 2, testSubject2.Health);
			game.ProcessCard("Emperor Thaurissan", asZeroCost: true);
			game.EndTurn();

			Assert.Equal(cardCost - 2, testSubject.Cost);
			Assert.Equal(testSubject2.Card.Cost - 1, testSubject2.Cost);

			for (int i = 0; i < 5; i++)
			{
				game.ProcessCard("Mind Vision", asZeroCost: true);
				IPlayable copied = game.CurrentPlayer.HandZone.Last();
				Assert.Equal(copied.Card.Cost - 1, copied.Cost);
				if (copied is Minion m)
				{
					Assert.Equal(m.Card.ATK + 2, m.AttackDamage);
					Assert.Equal(m.Card.Health + 2, m.Health);
				}
			}

			// TODO: Haven't found a real case to test this yet.
			// If you copy a card from hand to play, the copy retains enchantments. (eg. Kobold Illusionist)
		}

		[Fact]
		public static void CopyEnchantment3()
		{
			var game = new Game(new GameConfig
			{
				FillDecks = true,
				FillDecksPredictably = true,
			});
			game.StartGame();

			for (int i = game.CurrentPlayer.DeckZone.Count - 1; i >= 0; i--)
				if (game.CurrentPlayer.DeckZone[i].Card.Type != CardType.MINION)
					game.CurrentPlayer.DeckZone.Remove(game.CurrentPlayer.DeckZone[i]);

			// If you copy a card from a deck to a hand, the copy retains enchantments. (eg. Thoughtsteal)
			game.ProcessCard("Luna's Pocket Galaxy", asZeroCost: true);
			game.ProcessCard("Prince Keleseth", asZeroCost: true);

			Minion[] minions = game.CurrentPlayer.DeckZone
				.Where(p => p.Card.Type == CardType.MINION)
				.Cast<Minion>()
				.ToArray();

			for (int i = 0; i < minions.Length; i++)
			{
				Assert.Equal(1, minions[i].Cost);
				Assert.Equal(minions[i].Card.ATK + 1, minions[i].AttackDamage);
				Assert.Equal(minions[i].Card.Health + 1, minions[i].Health);
			}

			game.EndTurn();

			game.ProcessCard("Thoughtsteal", asZeroCost: true);

			for (int i = 1; i < 3; i++)
			{
				IPlayable copied = game.CurrentPlayer.HandZone[game.CurrentPlayer.HandZone.Count - i];
				if (!(copied.OngoingEffect is AdaptiveCostEffect))
					Assert.Equal(1, copied.Cost);

				if (copied is Minion m)
				{
					Assert.Equal(m.Card.ATK + 1, m.AttackDamage);
					Assert.Equal(m.Card.Health + 1, m.Health);
				}
			}

			// If you copy a card from a deck to play, the copy retains enchantments. (eg. Mindgames)
			if (minions.Length > 0)
			{
				game.ProcessCard("Mindgames", asZeroCost: true);
				Minion m = game.CurrentPlayer.BoardZone[0];
				Assert.Equal(m.Card.ATK + 1, m.AttackDamage);
				Assert.Equal(m.Card.Health + 1, m.Health);
			}
		}

		[Fact(Skip ="Not implemented.")]
		public static void Transform()
		{
			// Shifter Zerus, Molten Blade, and Shifting Scroll
			// all transform in your hand at the start of every turn.
			// Following the 12.0 update, they will no longer keep any enchantments when they transform.
			// This includes things like hand buffs and Emperor Thaurissan mana-cost discounts.
			// => Implemented

			// TODO:
			// The impact on Voodoo Doll is a little different with the update.
			// If you transform the minion that’s already been cursed by Voodoo Doll,
			// the curse will be broken, and the transformed (and formerly cursed) minion
			// will not be killed when Voodoo Doll dies. Silencing the cursed minion will also break the curse,
			// in addition to silencing the Voodoo Doll.
		}
	}
}
