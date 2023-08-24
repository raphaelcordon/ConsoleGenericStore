using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Data.Users
{
	public class Employee : User
	{
		public Employee(string name, string email) : base(name, email) => PinnedLists.ListEmployees.Add(item: this);


		public string RegistryNumber { get; set; } 
		public EEmployeeRole Role { get; set; }
	}
}
