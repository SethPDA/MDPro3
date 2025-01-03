using System;
using System.Collections.Generic;

namespace YgomGame.GemShop
{
	public class ProductContext : IComparable<ProductContext>
	{
		private Dictionary<int, int> m_ItemNumMap;

		public ProductStyle style;

		public string productName;

		public long endDateTs;

		public string limitdate;

		public long shopPaidId;

		public int thumbId;

		public string priceLabel;

		public string doubleNotationPriceLabel;

		public string limitBuyLabel;

		public int order;

		public bool soldout;

		public bool isLimitedDate => false;

		public bool isInTermDate => false;

		public void SetItemNum(int itemId, int num)
		{
		}

		public int GetItemNum(int itemId)
		{
			return 0;
		}

		public int Compare(ProductContext a, ProductContext b)
		{
			return 0;
		}

		public int CompareTo(ProductContext other)
		{
			return 0;
		}
	}
}
