using System;

namespace SabberStoneCore.Enums
{
	[Flags]
	public enum TargetingType
	{
		None = 0,
		Friendly = 1,
		Enemy = 2,
		Minion = 4,
		Hero = 8,
		All = Friendly | Enemy | Minion | Hero,
		FriendlyCharacters = Friendly | Minion | Hero,
		EnemyCharacters = Enemy | Minion | Hero,
		AllMinions = Friendly | Enemy | Minion,
		FriendlyMinions = Friendly | Minion,
		EnemyMinions = Enemy | Minion,
		Heroes = Friendly | Enemy | Hero
	}
}
