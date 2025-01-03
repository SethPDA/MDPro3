namespace KonamiCommonIAB
{
	public abstract class Purchase
	{
		public abstract string productId { get; }

		public string receipt => null;

		public abstract string getReceipt();

		public abstract ProductInfo getProductInfo();
	}
}
