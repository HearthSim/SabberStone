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
using System.Linq;
using System.Text;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Auras
{
	public class SwitchingAura : Aura
	{
		private readonly SelfCondition _initialisationCondtion;
		private readonly TriggerType _offTrigger;
		private readonly TriggerManager.TriggerHandler _offHandler;
		private readonly TriggerManager.TriggerHandler _onHandler;

		private bool _removed;

		public SwitchingAura(AuraType type, SelfCondition initCondition, TriggerType offTrigger, params IEffect[] effects) : base(type, effects)
		{
			_initialisationCondtion = initCondition;
			_offTrigger = offTrigger;
		}

		public SwitchingAura(AuraType type, SelfCondition initCondition, TriggerType offTrigger, string enchantmentId) : base(type, enchantmentId)
		{
			_initialisationCondtion = initCondition;
			_offTrigger = offTrigger;
		}

		protected SwitchingAura(SwitchingAura prototype, IPlayable owner) : base(prototype, owner)
		{
			_initialisationCondtion = prototype._initialisationCondtion;
			_offTrigger = prototype._offTrigger;
			_offHandler = TurnOff;
			_onHandler = TurnOn;
		}

		public override void Activate(IPlayable owner, bool cloning = false)
		{
			if (Effects == null)
				Effects = EnchantmentCard.Power.Enchant.Effects;

			var instance = new SwitchingAura(this, owner);

			AddToGame(owner, instance);

			owner.Game.TriggerManager.TurnStartTrigger += instance._onHandler;
			owner.Game.TriggerManager.EndTurnTrigger += instance._offHandler;

			switch (_offTrigger)
			{
				case TriggerType.PLAY_MINION:
					owner.Game.TriggerManager.PlayMinionTrigger += instance._offHandler;
					break;
				case TriggerType.CAST_SPELL:
					owner.Game.TriggerManager.CastSpellTrigger += instance._offHandler;
					break;
				default:
					throw new NotImplementedException();
			}

			if (!cloning)
			{
				if (!instance._initialisationCondtion.Eval(owner))
					instance.On = false;
				else
					instance.AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.AddAll), 1);
			}
		}

		public override void Remove()
		{
			base.Remove();

			_removed = true;

			Game.TriggerManager.TurnStartTrigger -= _onHandler;
			Game.TriggerManager.EndTurnTrigger -= _offHandler;

			switch (_offTrigger)
			{
				case TriggerType.PLAY_MINION:
					Game.TriggerManager.PlayMinionTrigger -= _offHandler;
					break;
				case TriggerType.CAST_SPELL:
					Game.TriggerManager.CastSpellTrigger -= _offHandler;
					break;
				default:
					throw new NotImplementedException();
			}
		}

		//protected override void UpdateInternal()
		//{
		//	if (!On) return;

		//	base.UpdateInternal();
		//}

		protected override void RemoveInternal()
		{
			AppliedEntityIdCollection.ForEach(Game.IdEntityDic, Effects,
				(id, idDict, effs) =>
				{
					IPlayable entity = idDict[id];
					for (int i = 0; i < effs.Length; i++)
						effs[i].RemoveAuraFrom(entity);
				});

			AppliedEntityIdCollection.Clear();

			if (_removed)
				Game.Auras.Remove(this);

			// TODO: EnchantmentCard, if there is a case

			if (Game.Logging)
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Aura.RemoveInternal",
					$"{Owner}'s aura is removed from " +
					$"{string.Join(",", AppliedEntityIdCollection.Select(i => Game.IdEntityDic[i]))})");
		}

		private void TurnOff(IEntity source)
		{
			if (!On) return;
			On = false;
			if (source.Game.Logging)
				source.Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "SwitchingAura.TurnOff",
				$"{source} triggers {_offTrigger}. {Owner}'s aura is now turned off for this turn.");

			AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.RemoveAll), 0);
		}

		private void TurnOn(IEntity source)
		{
			if (On) return;

			On = true;
			AuraUpdateInstructionsQueue.Enqueue(new AuraUpdateInstruction(Instruction.AddAll), 1);
		}
	}
}
