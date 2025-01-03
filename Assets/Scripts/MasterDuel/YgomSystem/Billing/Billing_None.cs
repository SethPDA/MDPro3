using System;
using System.Collections.Generic;
using KonamiCommonIAB;

namespace YgomSystem.Billing
{
	public class Billing_None : IBilling
	{
		protected Dictionary<string, ProductInfo> m_productDic;

		public bool initialized => false;

		public bool canMakePayment()
		{
			return false;
		}

		public void Initialize()
		{
		}

		public void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
		{
		}

		public ProductInfo GetItem(string productId)
		{
			return null;
		}

		public void DoRestore(Action<ResultCode> callback = null)
		{
		}

		public void BuyItem(int shopId, string productId, Action<ResultCode> callback = null)
		{
		}

		public void DoRestore(Action<ResultCode, List<Purchase>> callback)
		{
		}

		public string GetDoubleNotationDisplayPrice(string productId)
		{
			return null;
		}

		public virtual string GetDoubleNotationDisplayPrice(ProductInfo productInfo)
		{
			return null;
		}
	}
}
