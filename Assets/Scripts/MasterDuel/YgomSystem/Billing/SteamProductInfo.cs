using KonamiCommonIAB;

namespace YgomSystem.Billing
{
	public class SteamProductInfo : ProductInfo
	{
		private string m_productId;

		private float m_price;

		private string m_currency;

		private string m_displayedPrice;

		public override string productId => null;

		public override string title => null;

		public override string description => null;

		public override string displayedPrice => null;

		public override string currency => null;

		public override float price => 0f;

		public SteamProductInfo(string _productId, float _price = 0f, string _displayedPrice = "", string _currency = "")
		{
		}
	}
}
