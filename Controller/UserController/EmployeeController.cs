using ConsoleGenericStore.Data.Users;

namespace ConsoleGenericStore.Controller.EmployeeController
{
	public static class EmployeeController
	{
		public static List<Employee> ListEmployees = new List<Employee>();

		public static void RegisterEmployee(Employee employee)
		{
			ListEmployees.Add(employee);
		}
		public static void ListAllEmployees()
		{
			Console.WriteLine("List of registered employees");
			Console.WriteLine("");
			foreach (var employee in ListEmployees)
			{
				Console.WriteLine($"Name: {employee.Name} | Email: {employee.Email} | RN: {employee.RegistryNumber}");
			}
			Console.WriteLine($"--------------------------------");
		}


	}
}