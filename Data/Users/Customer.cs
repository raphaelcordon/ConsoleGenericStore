using ConsoleGenericStore.Data._Shared;
using ConsoleGenericStore.Data.Purchases;

namespace ConsoleGenericStore.Data.Users
{
	public class Customer : User
	{
		public Customer(string name, string email) : base(name, email) => PinnedLists.ListCustomers.Add(item: this);

		public PuchaseHist PuchaseHist = new PuchaseHist();

	}



}
