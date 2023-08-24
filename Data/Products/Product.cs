using ConsoleGenericStore.Data._Shared;

namespace ConsoleGenericStore.Data.Products
{
	public class Product : Base
	{
		public Product(ECategory category, string name, decimal price, string description)
		{
			Category = category;
			Name = name;
			Price = price;
			Description = description;
		}

		public ECategory Category { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
	}
}
