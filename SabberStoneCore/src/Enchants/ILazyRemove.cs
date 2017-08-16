using SabberStoneCore.Model;

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// Interface for all special effects which can be removed at a certain phase of the game.
	/// </summary>
	/// <seealso cref="Trigger"/>
	/// <seealso cref="Enchant"/>
	public interface ILazyRemove
	{
		/// <summary>
		/// Method which removes the implemented special effect from the game.
		/// The removal can be instantaneous or delayed.
		/// 
		/// In the case of <see cref="Trigger.Remove"/>, removing is anstantaneous.
		/// In the case of <see cref="Enchant.Remove"/>, the remove operation is queued
		/// on the game and will be executed on the next <see cref="Game.DeathProcessingAndAuraUpdate"/>.
		/// </summary>
		void Remove();
	}
}
