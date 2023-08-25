using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Data.Products
{
	public class Product : Base
	{
		public Product(string name, decimal price, string description, ECategory category)
		{
			Name = name;
			Price = price;
			Description = description;
			Category = category;
		}

		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public ECategory Category { get; set; }
	}

}
