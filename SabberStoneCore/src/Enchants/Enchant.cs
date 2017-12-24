using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
    public class Enchant
    {
	    public string EnchantmentId;
		public Controller Controller;
	    public int TargetId;
	    public Effect[] Effects;
		public Trigger UpdateTrigger;
	    public bool IsStacking;

		private IPlayable Target;

	    internal int Count = 1;

		public Enchant() { }

	    public Enchant(Effect effect, bool isStacking = false)
	    {
		    Effects = new[] {effect};
			IsStacking = isStacking;
	    }

	    public void ActivateTo(IPlayable entity)
	    {
		    if (!IsStacking || !entity.Enchants.Contains(EnchantmentId))
			    entity.Enchants.Add(EnchantmentId);

		    for (int i = 0; i < Effects.Length; i++)
			    Effects[i].Apply(entity);
	    }


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
