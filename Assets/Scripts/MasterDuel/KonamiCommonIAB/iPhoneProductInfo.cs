namespace KonamiCommonIAB
{
	internal class iPhoneProductInfo : ProductInfo
	{
		private SKProduct info;

		public override string productId => null;

		public override string title => null;

		public override string description => null;

		public override string displayedPrice => null;

		public override string currency => null;

		public override float price => 0f;

		public string country => null;

		public iPhoneProductInfo(SKProduct obj)
		{
		}
	}
}
