namespace KonamiCommonIAB
{
	public abstract class ProductInfo
	{
		public string json => null;

		public abstract string productId { get; }

		public abstract string title { get; }

		public abstract string description { get; }

		public abstract string displayedPrice { get; }

		public abstract string currency { get; }

		public abstract float price { get; }
	}
}
