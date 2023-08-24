
using ConsoleGenericStore.Data._Shared;
using ConsoleGenericStore.Data.Users;

namespace ConsoleGenericStore.Controller.CustomerController
{
	public static class CustomerController
	{
        public static void ListAllCustomers()
		{
			Console.WriteLine("List of registered customers");
			Console.WriteLine("");
			foreach (var customer in PinnedLists.ListCustomers)
			{
				Console.WriteLine($"Name: {customer.Name} | Email: {customer.Email}");
			}
			Console.WriteLine($"--------------------------------");
		}


	}
}
