using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Data.Users
{
	public abstract class User : Base
	{
		protected User(string name, string email)
		{
			Name = name;
			Email = email;
		}

		public string Name { get; set; }
		public string Email { get; set; }
	}

}
