using ConsoleGenericStore.Data.Purchases;

namespace ConsoleGenericStore.Controller.PurchaseController
{
	public class PurchaseController
	{
		public static List<Purchase> purchasesList = new List<Purchase>();

		public static void RegisterPurchase(Purchase purchase)
		{
			purchasesList.Add(purchase);
		}
		public static void RegisterAllPurchases(List<Purchase> purchases)
		{
			foreach (Purchase purchase in purchases)
			{
				purchasesList.Add(purchase);
			}
		}
		public static void ListAllPurchases()
		{
			Console.WriteLine("List of registered purchases");
			Console.WriteLine("");
			foreach (var purchase in purchasesList)
			{
				Console.WriteLine($"Customer: {purchase.Customer.Name} | Is Concluded? {purchase.IsConcluded}");
				foreach (var item in purchase.Products)
				{
					Console.WriteLine($"   Product: {item.Name} - Price: {item.Price}");
                }
            }
			Console.WriteLine();
			Console.WriteLine($"--------------------------------");
		}
	}
}
