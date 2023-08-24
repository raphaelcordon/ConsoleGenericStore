using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Controller.EmployeeController
{
	public static class EmployeeController
	{
		public static void ListAllEmployees()
		{
			Console.WriteLine("List of registered employees");
			Console.WriteLine("");
			foreach (var employee in PinnedLists.ListEmployees)
			{
				Console.WriteLine($"Name: {employee.Name} | Email: {employee.Email}");
			}
			Console.WriteLine($"--------------------------------");
		}


	}
}