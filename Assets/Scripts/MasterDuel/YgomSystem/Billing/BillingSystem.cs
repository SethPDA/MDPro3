using System;
using System.Collections.Generic;
using KonamiCommonIAB;

namespace YgomSystem.Billing
{
	public class BillingSystem
	{
		private static IBilling m_billing;

		public static bool restoreOnLogin => false;

		public static bool isVoid => false;

		public static bool initialized => false;

		public static void Initialize()
		{
		}

		public static bool canMakePayment()
		{
			return false;
		}

		public static void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
		{
		}

		public static ProductInfo GetItem(string productId)
		{
			return null;
		}

		public static string GetDisplayedPrice(string productId)
		{
			return null;
		}

		public static string GetDoubleNotationDisplayPrice(string productId)
		{
			return null;
		}

		public static void BuyItem(int shopId, string productId, Action<ResultCode> callback = null)
		{
		}

		public static void DoRestore(Action<ResultCode> callback)
		{
		}

		public static void DoRestore(Action<ResultCode, List<Purchase>> callback)
		{
		}
	}
}
