using ConsoleGenericStore.Data.Products;

namespace ConsoleGenericStore.Controller.ProductController
{
	public class ProductController
	{
		public static List<Product> ListProducts = new List<Product>();
		public static void RegisterProduct(Product product)
		{
			ListProducts.Add(product);
		}
		public static void ListAllProducts()
		{
			Console.WriteLine("List of registered products");
			Console.WriteLine("");
			foreach (var product in ListProducts)
			{
				Console.WriteLine($"Product: {product.Name} | Price: {product.Price} | Category: {product.Category} | Description: {product.Description}");
			}
			Console.WriteLine($"--------------------------------");
		}
	}
}
