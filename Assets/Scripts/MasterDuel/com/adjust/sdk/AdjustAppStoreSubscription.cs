using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustAppStoreSubscription
	{
		internal string price;

		internal string currency;

		internal string transactionId;

		internal string receipt;

		internal string billingStore;

		internal string transactionDate;

		internal string salesRegion;

		internal List<string> partnerList;

		internal List<string> callbackList;

		public AdjustAppStoreSubscription(string price, string currency, string transactionId, string receipt)
		{
		}

		public void setTransactionDate(string transactionDate)
		{
		}

		public void setSalesRegion(string salesRegion)
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
