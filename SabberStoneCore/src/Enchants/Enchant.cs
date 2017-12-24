using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
    public class Enchant
    {
	    public Effect[] Effects;

	    internal int Count = 1;
    }

	public struct Effect
	{
		public GameTag Tag;
		public EffectOperator Operator;
		public int Value;

		public void Apply(IPlayable playable)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					playable[Tag] += Value;
					return;
				case EffectOperator.SUB:
					playable[Tag] -= Value;
					if (playable[Tag] < 0)
						playable[Tag] = 0;
					return;
				case EffectOperator.MUL:
					playable[Tag] *= Value;
					return;
				case EffectOperator.SET:
					playable[Tag] = Value;
					return;
			}
		}
	}

	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}
}
