using System;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Conditions;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;
using System.Diagnostics;

namespace SabberStoneCore.Enchants
{

	/// <summary>
	/// Represents a buff/debuff which is, when activated, attached to an <see cref="IEntity"/>
	/// or an <see cref="IZone"/>.
	/// An enchant applies it's effect until removal conditions (<see cref="RemoveTriggerTags"/>)
	/// are met. (Forcing enchant removal through silence is ALSO done through the use of
	/// <see cref="RemoveTriggerTags"/>.)
	/// </summary>
	public class Enchant : ILazyRemove, IModel<Enchant>
	{
		// TODO; Cloning is cleaner when ParentContainer is removed.
		// This would require a removal rework!
		/// <summary>
		/// Get or set the container which holds the current object (this).
		/// </summary>
		public List<Enchant> ParentContainer { get; set; }

		public List<SelfCondition> EnableConditions { get; set; } = new List<SelfCondition>();

		public List<RelaCondition> ApplyConditions { get; set; } = new List<RelaCondition>();

		public string CardId { get; set; }

		public Game Game { get; set; }

		/// <summary>
		/// The entity which brings the defined effects into play.
		/// </summary>
		public IPlayable EffectCarrier
		{
			get { return Game.EntityContainer[_subjectEntityID]; }
			set { _subjectEntityID = value.Id; }
		}
		private int _subjectEntityID;

		public Dictionary<GameTag, int> Effects { get; set; } = new Dictionary<GameTag, int>();

		/// <summary>
		/// Gets or sets the function which applies a fixed value to the specified 
		/// tags stored in <see cref="Effects"/>.
		/// </summary>
		public Func<IPlayable, int> FixedValueFunc { get; set; }

		/// <summary>
		/// Function for which result sums together with the base tag value.
		/// The alternative is to give a value other than 0 for the tag key in <see cref="Effects"/>.
		/// </summary>
		public Func<IPlayable, int> ValueFunc { get; set; }

		public int TurnsActive { get; set; } = -1;

		public int Turn { get; set; }

		public List<GameTag> RemoveTriggerTags { get; set; } = new List<GameTag>();

		internal Dictionary<GameTag, int> RemoveTriggers { get; set; } = new Dictionary<GameTag, int>();

		/// <summary>
		/// Gets or sets the task which is IMMEDIATELY executed when this enchant is MARKED for removal.
		/// </summary>
		public ISimpleTask ImmediateRemovalTask { get; set; }

		/// <summary>
		/// Gets or sets the task which is executed after the enchant is removed from the game.
		/// (It's effects on entities are removed.)
		/// 
		/// Enchant removal is lazy, so this task will be processed within the next 
		/// <see cref="Game.DeathProcessingAndAuraUpdate"/>!
		/// </summary>
		public ISimpleTask PostEffectTask { get; set; }

		public Enchant() { }

		/// <summary>
		/// Activate the effects of this enchant. 
		/// <para>
		/// This enchant object is cloned and stored in the container where it's effects must apply to
		/// entities.
		/// </para>
		/// </summary>
		/// <param name="cardId"></param>
		/// <param name="parentContainer"></param>
		/// <param name="effectCarrier"></param>
		public void Activate(string cardId, List<Enchant> parentContainer, IPlayable effectCarrier)
		{
			Enchant clone = Clone(effectCarrier.Game);
			clone.CardId = cardId;
			clone.ParentContainer = parentContainer;
			clone.EffectCarrier = effectCarrier;
			clone.RemoveTriggers = RemoveTriggerTags.ToDictionary(p => p, p => effectCarrier.Controller[p]);

			parentContainer.Add(clone);
		}

		/// <summary>
		/// Called when the auras in the game are updated and this enchant is marked to be lazily removed.
		/// </summary>
		public void Remove()
		{
			if (PostEffectTask != null)
			{
				Game.Log(LogLevel.INFO, BlockType.TRIGGER, "Enchant", "enqueueuing lazy removal task here!");

				// clone task here
				var clone = PostEffectTask.Clone(null) as ISimpleTask;
				clone.Game = EffectCarrier.Controller.Game;
				clone.Controller = EffectCarrier.Controller;
				clone.Source = EffectCarrier;
				clone.Target = EffectCarrier;

				EffectCarrier.Controller.Game.TaskQueue.Enqueue(clone);
			}
			ParentContainer.Remove(this);
		}

		/// <summary>
		/// Test if the removal conditions of this enchant are met.
		/// </summary>
		/// <returns>True if the removal conditions are NOT met, false otherwise.</returns>
		public bool IsEnabled()
		{
			bool flag = true;

			EnableConditions.ForEach(p => flag &= p.Eval(EffectCarrier));

			RemoveTriggers.ToList().ForEach(p => flag &= EffectCarrier.Controller[p.Key] <= p.Value);

			flag &= TurnsActive < 0 || EffectCarrier.Game.Turn <= Turn + TurnsActive;

			if (!flag && !EffectCarrier.Game.LazyRemoves.Contains(this))
			{
				EffectCarrier.Game.LazyRemoves.Enqueue(this);
				// execute removal task here, ex. health rentantion   
				if (ImmediateRemovalTask != null)
				{
					Game.Log(LogLevel.INFO, BlockType.TRIGGER, "Enchant", "executing removal task priority here");
					EffectCarrier.Controller.Game.TaskQueue.Execute(ImmediateRemovalTask, EffectCarrier.Controller, EffectCarrier, EffectCarrier);
				}
			}

			return flag;
		}

		/// <summary>
		/// Test if this enchant applies on the given subject.
		/// 
		/// Example: Stormwind Champion [CS2_222] brings an auro into play
		/// which buffs all OTHER minions with +1/+1.
		/// This effect is NOT applied to the Stormwind Champion himself!
		/// </summary>
		/// <param name="subject"></param>
		/// <returns>True if the effect applies on subject, false otherwise.</returns>
		private bool IsApplying(IPlayable subject)
		{
			bool flag = true;
			ApplyConditions.ForEach(p => flag &= p.Eval(EffectCarrier, subject));
			return flag;
		}

		/// <summary>
		/// Apply this enchant, if applicable, on the provided entity.
		/// </summary>
		/// <param name="subject">The subject of this enchant.</param>
		/// <param name="gameTag">The <see cref="GameTag"/> that needs updating.</param>
		/// <param name="value">The current value of the provided gameTag.</param>
		/// <returns>The updated value of the specified gameTag, which is calculated by 
		/// applying this enchant (if requirements are met) on the original value.
		/// </returns>
		public int Apply(Entity subject, GameTag gameTag, int value)
		{
			// only allow enchantments on playable entitys ...
			var target = subject as IPlayable;
			//if (target == null && !(entity is Controller))
			//{
			//    return value;
			//}

			// The enchant must have been built to manipulate the specified GameTag.
			if (!Effects.ContainsKey(gameTag))
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Enchant", $"GameTag {gameTag} not concerned by this enchanting ...");
				return value;
			}

			if (!IsEnabled())
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Enchant", $"Enchant from {EffectCarrier} isn't enabled! {target}");
				return value;
			}

			if (!IsApplying(target))
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Enchant", $"Enchant conditions not meet.");
				return value;
			}

			if (FixedValueFunc != null)
			{
				Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Enchant", $"Card[ind.{target.OrderOfPlay}.{target}] got enchanted. Using fixed value func.");
				return FixedValueFunc.Invoke(EffectCarrier);
			}

			Game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "Enchant", $"Card[ind.{target?.OrderOfPlay}.{target}] got enchanted. {gameTag} = {value} + {Effects[gameTag]} variable effect? {ValueFunc != null}");

			// Sum the specified values with the base tag value.
			int effectValue = ValueFunc?.Invoke(EffectCarrier) ?? Effects[gameTag];
			int updatedValue = value + effectValue;

			// TODO; Replace this check with a bool test on tags
			if (gameTag == GameTag.CHARGE || gameTag == GameTag.WINDFURY || gameTag == GameTag.IMMUNE)
			{
				return updatedValue == 0 ? 0 : 1;
			}

			// TODO; This test might be moved to the previous if-test.
			if (gameTag == GameTag.BATTLECRY)
			{
				return updatedValue != 0 ? updatedValue : 0;
			}

			// No negative tag values are allowed.
			if (updatedValue < 0)
			{
				updatedValue = 0;
			}

			return updatedValue;
		}

		//public Enchant Copy(string sourceId, Game newGame, int turn, List<Enchant> containingList, IPlayable oldOwner, Dictionary<GameTag, int> removeTriggers)
		//      {
		//          return new Enchant()
		//          {
		//              Game = newGame,
		//              ParentContainer = containingList,
		//              Owner = oldOwner, // Only entityID is stored internally
		//              Turn = turn,

		//              CardId = sourceId,
		//              EnableConditions = EnableConditions, // Stateless
		//              ApplyConditions = ApplyConditions, // Stateless
		//              SingleTask = SingleTask?.Clone(null), // Deep copy
		//              RemovalTask = RemovalTask?.Clone(null), // Deep copy
		//              Effects = new Dictionary<GameTag, int>(Effects), // Shallow copy is enough
		//              ValueFunc = ValueFunc,
		//              FixedValueFunc = FixedValueFunc,
		//              TurnsActive = TurnsActive,

		//              RemoveTriggerTags = new List<GameTag>(RemoveTriggerTags), // Shallow copy is enough
		//              RemoveTriggers = new Dictionary<GameTag, int>(removeTriggers), // Shallow copy is enough
		//          };
		//      }

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public Enchant Clone(Game newGame)
		{
			var deepClone = new Enchant()
			{
				Game = newGame,
				ParentContainer = null, // MUST be set for removal to work!
				// EffectCarrier = EffectCarrier.ClonedFrom(newGame),
				_subjectEntityID = _subjectEntityID,
				Turn = Turn,

				CardId = CardId,
				EnableConditions = EnableConditions, // Stateless
				ApplyConditions = ApplyConditions, // Stateless
				PostEffectTask = PostEffectTask?.Clone(newGame), // Deep copy
				ImmediateRemovalTask = ImmediateRemovalTask?.Clone(newGame), // Deep copy
				Effects = new Dictionary<GameTag, int>(Effects), // Shallow copy is enough
				ValueFunc = ValueFunc, // Stateless
				FixedValueFunc = FixedValueFunc, // Stateless
				TurnsActive = TurnsActive,

				RemoveTriggerTags = new List<GameTag>(RemoveTriggerTags), // Shallow copy is enough
				RemoveTriggers = new Dictionary<GameTag, int>(RemoveTriggers) // Shallow copy is enough
			};

			return deepClone;
		}

		public string ToHash(params GameTag[] ignore)
		{
			return $"{CardId}{(TurnsActive > -1 ? $",{Turn}" : "")}";
		}

		public void Stamp(IModel other)
		{
			throw new NotImplementedException();
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion
	}

}
