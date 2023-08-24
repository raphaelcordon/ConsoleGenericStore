using ConsoleGenericStore.Data._Shared;
using ConsoleGenericStore.Data.Products;
using ConsoleGenericStore.Data.Users;

namespace ConsoleGenericStore.Data.Purchases
{
	public class Purchase : Base
	{
		public Purchase(List<Product> products, Customer customer, bool isConcluded)
		{
			Products = products;
			Customer = customer;
			IsConcluded = isConcluded;
		}

		public List<Product> Products { get; set; }
		public Customer Customer { get; set; }
		public bool IsConcluded { get; set; }
	}
}
