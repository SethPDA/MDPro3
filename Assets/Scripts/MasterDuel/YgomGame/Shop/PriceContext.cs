using System;
using System.Collections.Generic;
using YgomGame.Utility;

namespace YgomGame.Shop
{
	public class PriceContext : IComparable<PriceContext>
	{
		private Dictionary<string, object> m_PriceData;

		private List<PriceContext> m_AllPrices;

		public int sort => 0;

		public int priceId => 0;

		public int confirmRegId => 0;

		public bool payItemIsPeriod => false;

		public int payItemCategory => 0;

		public int payItemId => 0;

		public int payItemHave => 0;

		public long limitdateTs => 0L;

		public string limitdate => null;

		public int priceAmount => 0;

		public int freeNum => 0;

		public List<PriceContext> allPrices => null;

		public bool hasSubPrices => false;

		public int buyCount => 0;

		public int buttonType => 0;

		public string priceLabelText => null;

		public string priceButtonIconPath => null;

		public string confirmDialogTitleId => null;

		public string confirmDialogMessageId => null;

		public string routeScheme => null;

		public string GetPriceFreeText()
		{
			return null;
		}

		public string MakePopText(TextGroupLoadHolder textGroupLoadHolder)
		{
			return null;
		}

		public void Import(Dictionary<string, object> priceData)
		{
		}

		public int Compare(PriceContext a, PriceContext b)
		{
			return 0;
		}

		public int CompareTo(PriceContext other)
		{
			return 0;
		}
	}
}
