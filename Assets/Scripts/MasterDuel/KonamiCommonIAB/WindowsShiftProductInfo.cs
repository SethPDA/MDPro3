namespace KonamiCommonIAB
{
	internal class WindowsShiftProductInfo : ProductInfo
	{
		private string _productId;

		private string _title;

		private long _price;

		public override string productId => null;

		public override string title => null;

		public override string description => null;

		public override string displayedPrice => null;

		public override string currency => null;

		public override float price => 0f;

		public WindowsShiftProductInfo(string prodId, string title, long price)
		{
		}
	}
}
