namespace ConsoleGenericStore.Data.Purchases
{
	public class PuchaseHist
	{
		public List<Purchase> Purchases { get; set; } = new List<Purchase>();
		public DateTime PurchaseTime { get; set; } = DateTime.Now;
	}
}
