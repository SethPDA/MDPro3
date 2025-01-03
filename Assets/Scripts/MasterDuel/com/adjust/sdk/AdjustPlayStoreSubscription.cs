using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustPlayStoreSubscription
	{
		internal string price;

		internal string currency;

		internal string sku;

		internal string orderId;

		internal string signature;

		internal string purchaseToken;

		internal string billingStore;

		internal string purchaseTime;

		internal List<string> partnerList;

		internal List<string> callbackList;

		public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken)
		{
		}

		public void setPurchaseTime(string purchaseTime)
		{
		}

		public void addCallbackParameter(string key, string value)
		{
		}

		public void addPartnerParameter(string key, string value)
		{
		}
	}
}
