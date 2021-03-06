using NHibernate.Validator.Constraints;

namespace NHibernate.Validator.Tests.ValidatorsTest
{
	public class FooLength
	{
		private int id;

		public FooLength(int id, string message)
		{
			this.message = message;
			this.id = id;
		}

		public FooLength()
		{
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		[NotNull]
		[Length(Min = 1, Max = 10)]
		private string message;
	}
}