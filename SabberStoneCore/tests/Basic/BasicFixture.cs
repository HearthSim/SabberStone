using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using System;

namespace SabberStoneCoreTest.Basic
{
	/// <summary>
	/// Object which performs setup operations before tests are run.
	/// For more information, see https://xunit.github.io/docs/shared-context.html#class-fixture
	/// </summary>
	/// <seealso cref="System.IDisposable" />
	public class BasicFixture : IDisposable
	{
		public readonly GameConfig EmptyConfiguration;
		public readonly GameConfig BasicConfiguration;
		public readonly GameConfig Conf1StartFill;

		public BasicFixture()
		{
			EmptyConfiguration = new GameConfig();

			BasicConfiguration = new GameConfig()
			{
				Player1CardClass = ECardClass.HUNTER,
				Player2CardClass = ECardClass.MAGE,
				FormatType = EFormatType.FT_STANDARD
			};

			Conf1StartFill = new GameConfig()
			{
				Player1CardClass = ECardClass.HUNTER,
				Player2CardClass = ECardClass.MAGE,
				FormatType = EFormatType.FT_STANDARD,
				StartPlayerIdx = 1,
				FillDecks = true
			};

		}

		public void Dispose()
		{
			// Nothing yet
		}
	}
}
