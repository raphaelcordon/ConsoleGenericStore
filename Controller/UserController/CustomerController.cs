using ConsoleGenericStore.Data.Users;

namespace ConsoleGenericStore.Controller.CustomerController
{
	public static class CustomerController
	{
		public static List<Customer> ListCustomers = new List<Customer>();
		
		public static void RegisterCustomer(Customer customer)
		{
			ListCustomers.Add(customer);
		}
		public static void RegisterAllCustomers(List<Customer> customers)
		{
			foreach (var customer in customers)
			{
				ListCustomers.Add(customer);
			}
		}
		public static void ListAllCustomers()
		{
			Console.WriteLine("List of registered customers");
			Console.WriteLine("");
			foreach (var customer in ListCustomers)
			{
				Console.WriteLine($"Name: {customer.Name} | Email: {customer.Email}");
			}
			Console.WriteLine($"--------------------------------");
		}
	}
}
