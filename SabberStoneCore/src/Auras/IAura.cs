using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Auras
{
	/// <summary>
	/// Interface for Ongoing Effects.
	/// </summary>
	public interface IAura
	{
		/// <summary> The entity who owns this effect. </summary>
		IPlayable Owner { get; }

		/// <summary> Refreshes this effect. </summary>
		void Update();

		/// <summary> Removes this effect from the game. </summary>
		void Remove();

		/// <summary>
		/// Activates this effect and add an instance to the game of the given entity.
		/// </summary>
		/// <param name="owner">The entity who owns this effect.</param>
		void Activate(IPlayable owner);

		/// <summary>
		/// Performs a deep copy of this object.
		/// The resulting cloned instance will be added to the given clone entity's game.
		/// </summary>
		/// <param name="clone">The (might be cloned)owner of the cloned instance.</param>
		void Clone(IPlayable clone);
	}
}
