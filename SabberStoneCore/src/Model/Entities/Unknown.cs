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
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model.Entities
{
	public class Unknown : Playable
	{
		public static readonly Card UnknownCard = new Card("", -1,
			new[]
			{
				new Tag(GameTag.CARDNAME, "UNKNOWN ENTITY"),
				new Tag(GameTag.CARD_ID, -1)
			}, new Dictionary<PlayReq, int>(), null, new Tag[0]);

		public Unknown(in Controller controller, in IDictionary<GameTag, int> tags, in int id) : base(in controller, in UnknownCard, in tags, in id)
		{
		}

		private Unknown(in Controller controller, in Playable playable) : base(in controller, in playable)
		{
		}

		#region Overrides of Playable

		public override IPlayable Clone(in Controller controller)
		{
			return new Unknown(in controller, this);
		}

		#endregion
	}
}
