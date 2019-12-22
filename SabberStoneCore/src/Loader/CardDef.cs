using System;
using System.Collections;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;

namespace SabberStoneCore.src.Loader
{
	public class CardDef
	{
		public PlayReq[] PlayReqs { get; private set; }

		public Power Power { get; private set; }

		public CardDef()
		{
		}
		public CardDef(PlayReq[] playReq)
		{
			PlayReqs = playReq;
		}

		public CardDef(Power power)
		{
			Power = power;
		}

		public CardDef(PlayReq[] playReq, Power power)
		{
			PlayReqs = playReq;
			Power = power;
		}
	}
}
