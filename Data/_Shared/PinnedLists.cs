using ConsoleGenericStore.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenericStore.Data._Shared
{
	public struct PinnedLists
	{
		public static List<Customer> ListCustomers = new List<Customer>();
		public static List<Employee> ListEmployees = new List<Employee>();
	}
}
