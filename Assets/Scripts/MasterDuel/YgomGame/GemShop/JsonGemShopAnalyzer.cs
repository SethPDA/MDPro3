using System.Collections.Generic;

namespace YgomGame.GemShop
{
	public class JsonGemShopAnalyzer
	{
		public class ProductAnalyzer
		{
			public string GetProductNameId(object productData)
			{
				return null;
			}

			public string CreateProductName(object productData, int gemCount)
			{
				return null;
			}

			public long GetShopPaidId(object productData)
			{
				return 0L;
			}

			public string GetProductId(object productData)
			{
				return null;
			}

			public int GetConfirmRegId(object productData)
			{
				return 0;
			}

			public bool GetEnabled(object productData)
			{
				return false;
			}

			public IReadOnlyDictionary<string, object> GetItems(object productData)
			{
				return null;
			}

			public string GetPriceLabel(object productData)
			{
				return null;
			}

			public int GetOrder(object productData)
			{
				return 0;
			}

			public int GetLimitBuyCount(object productData)
			{
				return 0;
			}

			public long GetEndDateTs(object productData)
			{
				return 0L;
			}

			public string GetLimitdate(object productData)
			{
				return null;
			}

			public int GetBuyCount(object productData)
			{
				return 0;
			}

			public int GetThumbId(object productData)
			{
				return 0;
			}

			public ProductStyle GetProductStyle(object productData)
			{
				return default(ProductStyle);
			}
		}

		public ProductAnalyzer product;
	}
}
