using System;

namespace SabberStoneCore.Exceptions
{
	public abstract class SabberStoneExceptions : Exception
	{
		protected SabberStoneExceptions() { }

		protected SabberStoneExceptions(string message) : base(message) { }

		protected SabberStoneExceptions(string message, Exception innerException) : base(message, innerException) { }

	}

	public class GameException : SabberStoneExceptions
	{
		public GameException() { }

		public GameException(string message) : base(message) { }

		public GameException(string message, Exception innerException) : base(message, innerException) { }
	}

	public class ZoneException : SabberStoneExceptions
	{
		public ZoneException() { }

		public ZoneException(string message) : base(message) { }

		public ZoneException(string message, Exception innerException) : base(message, innerException) { }
	}

	public class ControllerException : SabberStoneExceptions
	{
		public ControllerException() { }

		public ControllerException(string message) : base(message) { }

		public ControllerException(string message, Exception innerException) : base(message, innerException) { }
	}

	public class EntityException : SabberStoneExceptions
	{
		public EntityException() { }

		public EntityException(string message) : base(message) { }

		public EntityException(string message, Exception innerException) : base(message, innerException) { }
	}

	public class EnchantException : SabberStoneExceptions
	{
		public EnchantException() { }

		public EnchantException(string message) : base(message) { }

		public EnchantException(string message, Exception innerException) : base(message, innerException) { }
	}
}