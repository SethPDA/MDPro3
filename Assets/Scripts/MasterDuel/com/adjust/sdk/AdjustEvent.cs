using System;
using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustEvent
	{
		internal string currency;

		internal string eventToken;

		internal string callbackId;

		internal string transactionId;

		internal double? revenue;

		internal List<string> partnerList;

		internal List<string> callbackList;

		internal string receipt;

		internal bool isReceiptSet;

		public AdjustEvent(string eventToken)
		{
		}

		public void setRevenue(double amount, string currency)
		{
		}

		public void addCallbackParameter(string key, string value)
		{
		}

		public void addPartnerParameter(string key, string value)
		{
		}

		public void setTransactionId(string transactionId)
		{
		}

		public void setCallbackId(string callbackId)
		{
		}

		[Obsolete]
		public void setReceipt(string receipt, string transactionId)
		{
		}
	}
}
