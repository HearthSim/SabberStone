using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;

namespace SabberStoneCore.src.Loader
{
	public class CardDef
	{
		public Power Power { get; private set; }

		public CardDef()
		{
		}

		public CardDef(Power power)
		{
			Power = power;
		}


	}
}
