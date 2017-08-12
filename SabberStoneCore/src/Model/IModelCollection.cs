using System.Collections.Generic;

namespace SabberStoneCore.Model
{
	/// <summary>
	/// Interface which enforces primitive behaviour on the implementing collection
	/// class.
	/// The interface borrows collection behaviour from ICollection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IModelCollection<T> : ICollection<T>, IModel<IModelCollection<T>> where T : class, IModel
	{
	}

	/// <summary>
	/// Read-Only version of <see cref="IModelCollection{T}"/>.
	/// The interface borrows collection behaviour from IReadonlyCollection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IReadOnlyModelCollection<T> : IReadOnlyCollection<T>, IModel<IReadOnlyModelCollection<T>> where T : class, IModel
	{
	}
}
