using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Data.Users
{
	public class Employee : User
	{
		public Employee(string name, string email, string registryNumber, EEmployeeRole role) : base(name, email)
		{
			RegistryNumber = registryNumber;
			Role = role;
		}


		public string RegistryNumber { get; set; } 
		public EEmployeeRole Role { get; set; }
	}
}
