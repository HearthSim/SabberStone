using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;

namespace SabberStoneCore.src.Loader
{
	public class CardDef
	{
		public Dictionary<PlayReq, int> PlayReqs { get; private set; }

		public Power Power { get; private set; }

		public CardDef()
		{
		}
		public CardDef(Dictionary<PlayReq, int> playReq)
		{
			PlayReqs = playReq;
		}

		public CardDef(Power power)
		{
			Power = power;
		}

		public CardDef(Dictionary<PlayReq, int> playReq, Power power)
		{
			PlayReqs = playReq;
			Power = power;
		}
	}
}
