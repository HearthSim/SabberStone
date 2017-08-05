using SabberStoneCore.Model.Entities.Playables;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	public interface ITargeting : IEntity
	{
		IEnumerable<ICharacter> ValidPlayTargets { get; }
		bool IsValidPlayTarget(ICharacter target);

		bool ChooseOne { get; set; }
	}
}
